using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020001D8 RID: 472
[Serializable]
public class ShogunBug : MonoBehaviour
{
	// Token: 0x06000A99 RID: 2713 RVA: 0x001107D8 File Offset: 0x0010E9D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ShogunBug()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06000A9A RID: 2714 RVA: 0x001107E8 File Offset: 0x0010E9E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (80288 - 452246 != -371957)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (241875 - 339646 == -97771)
			{
				this.mChar.actionState = "standby";
				if (46916 - 492625 == -445709)
				{
					this.mChar.actionTime = Time.time;
					if (96799 - 121873 != -25073)
					{
						this.mChar.myCommand = "none";
						if (26771 - 349764 == -322993)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06000A9B RID: 2715 RVA: 0x001108D4 File Offset: 0x0010EAD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (Game.mGameType == 99)
		{
			this.mChar.isMine = true;
		}
	}

	// Token: 0x06000A9C RID: 2716 RVA: 0x001108F0 File Offset: 0x0010EAF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (171465 - 480470 != -309004)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (156470 - 371550 != -215080)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (252523 - 297311 == -44787)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_307;
					}
					if (33551 - 109407 != -75856)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (254806 - 484438 != -229632)
				{
					continue;
				}
			}
			IL_307:
			if (this.mChar.hp <= 0)
			{
				if (241553 - 254754 != -13201)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (13687 - 463390 == -449702)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (62668 - 184109 == -121440)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (267638 - 3495 == 264144)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (49851 - 515190 == -465338)
						{
							continue;
						}
						this.mChar.DeadEvent();
						if (57194 - 174565 != -117370)
						{
							break;
						}
						continue;
					}
					else
					{
						this.mChar.hp = 1;
						if (293721 - 435319 != -141597)
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
			if (42661 - 594540 != -551878)
			{
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (164548 - 346975 == -182427)
				{
					if (!(this.mChar.actionState != "ko"))
					{
						break;
					}
					if (174792 - 170307 != 4486)
					{
						if (!(this.mChar.actionState != "dead"))
						{
							break;
						}
						if (268439 - 186251 == 82188)
						{
							if (this.mChar.isMine)
							{
								if (271505 - 334846 != -63340)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (1723 - 374730 != -373006)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (77981 - 304382 == -226401)
										{
											this.mChar.KoEvent();
											if (246535 - 471353 != -224817)
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
								if (28890 - 472901 == -444011)
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

	// Token: 0x06000A9D RID: 2717 RVA: 0x00110CE8 File Offset: 0x0010EEE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (764 - 179988 != -179223)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (111661 - 246592 == -134931)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (166269 - 348916 != -182646 && 170234 - 29389 != 140846)
				{
					if (ActionName == "RPC_nAttack")
					{
						if (53896 - 373554 == -319657)
						{
							continue;
						}
						v = 1;
						if (190632 - 226648 != -36016)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nAttack_hit")
					{
						if (90536 - 330121 != -239585)
						{
							continue;
						}
						v = -1;
						if (88651 - 54067 == 34585)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_braveSpirit")
					{
						if (18942 - 246977 == -228034)
						{
							continue;
						}
						v = 2;
						if (169690 - 483683 != -313993)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_shogunSpear")
					{
						if (56206 - 498335 != -442129)
						{
							continue;
						}
						v = 3;
						if (244798 - 173556 != 71242)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_shogunSpear_hit")
					{
						if (285 - 581400 == -581114)
						{
							continue;
						}
						v = -3;
						if (123648 - 362155 != -238507)
						{
							continue;
						}
					}
					else
					{
						Debug.Log("Unknown Action Name:" + ActionName);
						if (41747 - 190434 != -148687)
						{
							continue;
						}
					}
					int v2 = Mathf.RoundToInt(nPos.x * (float)50);
					if (79193 - 373667 == -294474)
					{
						int v3 = Mathf.RoundToInt(nPos.y * (float)50);
						if (170722 - 271590 == -100868)
						{
							int v4 = Mathf.RoundToInt(nPos.z * (float)50);
							if (96199 - 422691 == -326492)
							{
								int v5 = Mathf.RoundToInt((float)200 * tPos.x);
								if (166578 - 237590 == -71012)
								{
									int v6 = Mathf.RoundToInt((float)200 * tPos.y);
									if (277359 - 186995 != 90365)
									{
										int v7 = Mathf.RoundToInt((float)200 * tPos.z);
										if (205791 - 120271 == 85520)
										{
											Hashtable hashtable = new Hashtable();
											if (223393 - 485446 != -262052)
											{
												hashtable.Add(120, PhotonClient.cInt16(v));
												if (52357 - 363724 != -311366)
												{
													hashtable.Add(122, PhotonClient.cInt16(v2));
													if (229104 - 305982 == -76878)
													{
														hashtable.Add(123, PhotonClient.cInt16(v3));
														if (134 - 467622 == -467488)
														{
															hashtable.Add(124, PhotonClient.cInt16(v4));
															if (97791 - 432934 != -335142)
															{
																hashtable.Add(126, PhotonClient.cInt16(v5));
																if (219998 - 295761 != -75762)
																{
																	hashtable.Add(127, PhotonClient.cInt16(v6));
																	if (23477 - 272036 != -248558)
																	{
																		hashtable.Add(128, PhotonClient.cInt16(v7));
																		if (189920 - 568807 == -378887)
																		{
																			hashtable.Add(129, PhotonClient.cInt16(tID));
																			if (262225 - 589649 != -327423)
																			{
																				PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																				if (128017 - 343740 == -215723)
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

	// Token: 0x06000A9E RID: 2718 RVA: 0x00111248 File Offset: 0x0010F448
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (287884 - 56716 != 231169)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (233167 - 282755 != -49587)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (63737 - 119632 == -55895)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (160239 - 383081 != -222841)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (59462 - 217336 == -157874)
						{
							int num3 = num;
							if (46056 - 583365 != -537308)
							{
								if (num3 == 1)
								{
									if (20494 - 221226 != -200731)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (120091 - 372654 == -252563)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (203649 - 60312 == 143337)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (293 - 346394 != -346100)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (244531 - 491859 != -247327)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (157423 - 5977 != 151447)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 2)
								{
									if (241890 - 534754 != -292863)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (234908 - 170602 == 64306)
										{
											this.StartCoroutine_Auto(this.RPC_braveSpirit(vector, vector2, num2));
											if (95573 - 136492 == -40919)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 3)
								{
									if (120883 - 163106 != -42222)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (226421 - 370197 == -143776)
										{
											this.StartCoroutine_Auto(this.RPC_shogunSpear(vector, vector2, num2));
											if (34567 - 246412 != -211844)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -3)
								{
									if (96546 - 425520 != -328973)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (18322 - 176164 == -157842)
										{
											this.RPC_shogunSpear_hit(vector, vector2, num2);
											if (16143 - 54324 == -38181)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (44891 - 74938 != -30046)
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

	// Token: 0x06000A9F RID: 2719 RVA: 0x00111648 File Offset: 0x0010F848
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (236245 - 130440 != 105806)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (129817 - 232244 == -102427)
			{
				float runSpeed = this.mChar.runSpeed;
				if (115958 - 123191 != -7232)
				{
					Vector3 a = default(Vector3);
					if (38175 - 508922 == -470747)
					{
						Vector3 vector = Vector3.zero;
						if (126312 - 488084 == -361772)
						{
							float num2 = (float)0;
							if (208886 - 343119 != -134232)
							{
								if (this.mChar.isMine)
								{
									if (50548 - 241795 != -191247)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (161078 - 413765 != -252687)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (163981 - 381723 != -217742)
										{
											continue;
										}
										a.y = (float)0;
										if (184412 - 238126 == -53713)
										{
											continue;
										}
										a = a.normalized;
										if (122133 - 72280 == 49854)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (251225 - 286722 != -35497)
										{
											continue;
										}
										vector = vector.normalized;
										if (147720 - 376565 != -228845)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (198388 - 435220 == -236831)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (14040 - 578401 == -564360)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (287242 - 90953 != 196289)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (260944 - 455680 != -194736)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (168807 - 106043 != 62764)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (166588 - 289592 != -123004)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (52451 - 368710 != -316259)
														{
															continue;
														}
														this.animation.Play("run");
														if (235879 - 574360 != -338481)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (45173 - 398591 != -353418)
														{
															continue;
														}
														goto IL_5C7;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (183539 - 510556 == -327016)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (215646 - 490331 != -274685)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (228641 - 224484 != 4157)
											{
												continue;
											}
											num = (float)0;
											if (59285 - 106818 == -47532)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (253413 - 195838 == 57576)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (138244 - 211879 != -73635)
										{
											continue;
										}
									}
									IL_5C7:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (266095 - 97809 == 168287)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (67705 - 188305 == -120599)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (244320 - 517422 != -273102)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (268059 - 491109 == -223049)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (212758 - 387312 == -174553)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (41754 - 583218 == -541463)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (187475 - 415993 == -228517)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (240047 - 318231 != -78184)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (114428 - 48441 != 65987)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (262174 - 349875 != -87701)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (134763 - 252364 != -117601)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (64979 - 446732 != -381753)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (221411 - 43932 != 177479)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (36667 - 81865 == -45197)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (51948 - 232431 != -180483)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (60958 - 439874 == -378915)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (99908 - 161981 != -62073)
												{
													continue;
												}
												num = (float)0;
												if (182194 - 465292 != -283098)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (45344 - 274498 == -229153)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (282133 - 212585 != 69548)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (49671 - 517123 != -467452)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (230195 - 579247 == -349051)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (234828 - 287715 == -52886)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (131366 - 408698 != -277332)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (260544 - 235555 != 24989)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (69379 - 159262 != -89883)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (59966 - 394723 == -334756)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (35401 - 268393 == -232991)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (284388 - 153380 != 131008)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (161391 - 55466 == 105926)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (92078 - 8394 != 83684)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (296736 - 86549 == 210188)
											{
												continue;
											}
											num = (float)0;
											if (257669 - 340711 != -83042)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (14393 - 494203 != -479810)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (112388 - 41416 != 70972)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (15349 - 260965 == -245615)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (229741 - 2021 == 227721)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (66679 - 383203 == -316524)
								{
									this.mChar.moveSpeed = num;
									if (123290 - 230682 != -107391)
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

	// Token: 0x06000AA0 RID: 2720 RVA: 0x001121AC File Offset: 0x001103AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (226762 - 446537 != -219775)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (66857 - 597045 == -530188)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (234549 - 360039 != -125489)
				{
					Vector3 vector = a - this.transform.position;
					if (116455 - 362956 == -246501)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (5109 - 241511 == -236402)
						{
							if (!(this.mChar.actionState == "standby"))
							{
								if (268615 - 3148 == 265468)
								{
									continue;
								}
								if (!(this.mChar.actionState == "run"))
								{
									break;
								}
								if (218721 - 371816 == -153094)
								{
									continue;
								}
							}
							if (this.mChar.isTimeOut("nAttack") != (float)0)
							{
								break;
							}
							if (149371 - 525757 != -376385)
							{
								this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, vector, 0));
								if (209087 - 285358 != -76270)
								{
									if (!PhotonClient.IsInitialized())
									{
										break;
									}
									if (211981 - 209348 != 2634)
									{
										this.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
										if (12119 - 374726 != -362606)
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

	// Token: 0x06000AA1 RID: 2721 RVA: 0x001123D0 File Offset: 0x001105D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (123116 - 210475 != -87359)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (9430 - 63504 == -54074)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (163614 - 532440 != -368825)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (223026 - 462319 != -239292)
					{
						Vector3 normalized = vector.normalized;
						if (134149 - 176629 != -42479)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (87907 - 567795 == -479888)
							{
								if (227968 - 349743 != -121774)
								{
									if (gameObject)
									{
										if (52641 - 400344 == -347702)
										{
											continue;
										}
										CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (121304 - 55807 != 65497)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (114995 - 71520 == 43476)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (254900 - 420527 == -165626)
										{
											continue;
										}
									}
									if (this.mChar.sp > 30)
									{
										if (264166 - 92601 != 171565)
										{
											continue;
										}
										if (this.mChar.isTimeOut("shogunSpear") == (float)0)
										{
											if (41883 - 369780 != -327897)
											{
												continue;
											}
											this.mChar.sp = this.mChar.sp - 30;
											if (116779 - 406796 != -290017)
											{
												continue;
											}
											this.StartCoroutine_Auto(this.RPC_shogunSpear(this.transform.position, normalized, 0));
											if (238582 - 371681 == -133098)
											{
												continue;
											}
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (117667 - 52447 != 65220)
											{
												continue;
											}
											this.ActionEvent("RPC_shogunSpear", this.transform.position, normalized, 0);
											if (51286 - 19782 != 31505)
											{
												break;
											}
											continue;
										}
									}
									if (this.mChar.isTimeOut("braveSpirit") != (float)0)
									{
										break;
									}
									if (81262 - 269460 != -188197)
									{
										this.StartCoroutine_Auto(this.RPC_braveSpirit(this.transform.position, normalized, 0));
										if (299467 - 286627 == 12840)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (88157 - 548311 == -460154)
											{
												this.ActionEvent("RPC_braveSpirit", this.transform.position, normalized, 0);
												if (233160 - 223813 == 9347)
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

	// Token: 0x06000AA2 RID: 2722 RVA: 0x001127AC File Offset: 0x001109AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06000AA3 RID: 2723 RVA: 0x001127B0 File Offset: 0x001109B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new ShogunBug.$RPC_nAttack$17107(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06000AA4 RID: 2724 RVA: 0x001127C0 File Offset: 0x001109C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (this.nAttack_hit)
		{
			UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, this.transform.rotation);
		}
	}

	// Token: 0x06000AA5 RID: 2725 RVA: 0x001127EC File Offset: 0x001109EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_braveSpirit(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new ShogunBug.$RPC_braveSpirit$17121(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06000AA6 RID: 2726 RVA: 0x001127FC File Offset: 0x001109FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_shogunSpear(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new ShogunBug.$RPC_shogunSpear$17133(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06000AA7 RID: 2727 RVA: 0x0011280C File Offset: 0x00110A0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_shogunSpear_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (this.shogunSpear_hit)
		{
			UnityEngine.Object.Instantiate(this.shogunSpear_hit, hitPos, this.transform.rotation);
		}
	}

	// Token: 0x06000AA8 RID: 2728 RVA: 0x00112838 File Offset: 0x00110A38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new ShogunBug.$RPC_ko$17147(nArray, this).GetEnumerator();
	}

	// Token: 0x06000AA9 RID: 2729 RVA: 0x00112848 File Offset: 0x00110A48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new ShogunBug.$RPC_dead$17154(nArray, this).GetEnumerator();
	}

	// Token: 0x06000AAA RID: 2730 RVA: 0x00112858 File Offset: 0x00110A58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06000AAB RID: 2731 RVA: 0x0011285C File Offset: 0x00110A5C
	internal static bool sPSVw2HkxXpEy591DaD()
	{
		return true;
	}

	// Token: 0x06000AAC RID: 2732 RVA: 0x00112860 File Offset: 0x00110A60
	internal static bool txtIHPHGY7ALZLa3WVO()
	{
		return false;
	}

	// Token: 0x04000973 RID: 2419
	public CharacterControl mChar;

	// Token: 0x04000974 RID: 2420
	public GameObject nAttack_hit;

	// Token: 0x04000975 RID: 2421
	private GameObject jFMeI1W6PK;

	// Token: 0x04000976 RID: 2422
	private AudioClip zVseJpGyCP;

	// Token: 0x04000977 RID: 2423
	public GameObject shogunSpear_hit;

	// Token: 0x020001D9 RID: 473
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$17107 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000AAD RID: 2733 RVA: 0x00112864 File Offset: 0x00110A64
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$17107(Vector3 mPos, Vector3 tDir, ShogunBug self_)
		{
			if (87204 - 445130 != -357925)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (230823 - 523050 != -292226)
				{
					base..ctor();
					if (125963 - 258946 != -132982)
					{
						this.$mPos$17118 = mPos;
						if (260958 - 220111 == 40847)
						{
							this.$tDir$17119 = tDir;
							if (119605 - 457980 == -338375)
							{
								this.$self_$17120 = self_;
								if (152101 - 240469 == -88368)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000AAE RID: 2734 RVA: 0x00112940 File Offset: 0x00110B40
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ShogunBug.$RPC_nAttack$17107.$(this.$mPos$17118, this.$tDir$17119, this.$self_$17120);
		}

		// Token: 0x06000AAF RID: 2735 RVA: 0x0011295C File Offset: 0x00110B5C
		internal static bool fqeHLcHHeynu29HS2VT()
		{
			return true;
		}

		// Token: 0x06000AB0 RID: 2736 RVA: 0x00112960 File Offset: 0x00110B60
		internal static bool CUWkU4HWL1tMPbLP4UX()
		{
			return false;
		}

		// Token: 0x04000978 RID: 2424
		internal Vector3 $mPos$17118;

		// Token: 0x04000979 RID: 2425
		internal Vector3 $tDir$17119;

		// Token: 0x0400097A RID: 2426
		internal ShogunBug $self_$17120;

		// Token: 0x020001DA RID: 474
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000AB1 RID: 2737 RVA: 0x00112964 File Offset: 0x00110B64
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, ShogunBug self_)
			{
				if (294839 - 14899 != 279941)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (220858 - 305990 != -85131)
					{
						base..ctor();
						if (174483 - 344669 != -170185)
						{
							this.$mPos$17115 = mPos;
							if (211787 - 13002 != 198786)
							{
								this.$tDir$17116 = tDir;
								if (68052 - 156227 == -88175)
								{
									this.$self_$17117 = self_;
									if (202139 - 16913 != 185227)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000AB2 RID: 2738 RVA: 0x00112A40 File Offset: 0x00110C40
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (260312 - 209265 != 51047)
				{
				}
				for (;;)
				{
					IL_D59:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_E1D;
					case 2:
						if (this.$self_$17117.mChar.actionState != "attack")
						{
							goto IL_90D;
						}
						if (215424 - 183845 == 31580)
						{
							continue;
						}
						if (this.$self_$17117.mChar.myCommand != "nAttack")
						{
							if (296057 - 549648 != -253590)
							{
								goto Block_13;
							}
							continue;
						}
						else
						{
							this.$self_$17117.mChar.vMovement = this.$self_$17117.transform.forward;
							if (223623 - 199170 == 24454)
							{
								continue;
							}
							this.$self_$17117.mChar.moveSpeed = (float)4;
							if (15385 - 95752 != -80367)
							{
								continue;
							}
							this.$hitLayer$17108 = 130816 - (1 << this.$self_$17117.gameObject.layer);
							if (124586 - 258296 != -133710)
							{
								continue;
							}
							this.$hitList$17109 = null;
							if (115935 - 327800 != -211865)
							{
								continue;
							}
							this.$hitPos$17110 = default(Vector3);
							if (249749 - 459122 == -209372)
							{
								continue;
							}
							if (!this.$self_$17117.mChar.isMine)
							{
								goto IL_94C;
							}
							if (171235 - 418815 != -247580)
							{
								continue;
							}
							this.$hitList$17109 = Damage.FindRecTarget(this.$self_$17117.transform.position - this.$self_$17117.mChar.rangeMod * this.$self_$17117.transform.forward, this.$self_$17117.transform.forward, (float)3 * this.$self_$17117.mChar.rangeMod, (float)3 * this.$self_$17117.mChar.rangeMod, (float)4 * this.$self_$17117.mChar.rangeMod, (float)2 * this.$self_$17117.mChar.rangeMod, this.$hitLayer$17108);
							if (268750 - 302986 == -34235)
							{
								continue;
							}
							this.$$iterator$10008$17112 = UnityRuntimeServices.GetEnumerator(this.$hitList$17109);
							if (131353 - 148449 != -17096)
							{
								continue;
							}
							while (this.$$iterator$10008$17112.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10008$17112.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$17111 = (GameObject)obj2;
								if (181672 - 221599 != -39927)
								{
									goto IL_D59;
								}
								if (this.$self_$17117.mChar.hit(1, this.$hitObject$17111, (int)(0.5f * (float)this.$self_$17117.mChar.atk), 1, 0, 0.5f * (this.$hitObject$17111.transform.position - this.$self_$17117.transform.position).normalized) != 0)
								{
									if (126509 - 465582 != -339073)
									{
										goto IL_D59;
									}
									this.$hitPos$17110 = this.$hitObject$17111.collider.ClosestPointOnBounds(this.$self_$17117.transform.position + 0.3f * Vector3.up);
									if (213850 - 299278 != -85428)
									{
										goto IL_D59;
									}
									UnityRuntimeServices.Update(this.$$iterator$10008$17112, this.$hitObject$17111);
									if (199406 - 595445 != -396039)
									{
										goto IL_D59;
									}
									this.$self_$17117.RPC_nAttack_hit(this.$hitPos$17110, this.$self_$17117.transform.forward, 0);
									if (69607 - 502535 == -432927)
									{
										goto IL_D59;
									}
									this.$self_$17117.ActionEvent("RPC_nAttack_hit", this.$hitPos$17110, this.$self_$17117.transform.forward, 0);
									if (1263 - 25696 == -24432)
									{
										goto IL_D59;
									}
									this.$self_$17117.mChar.sp = this.$self_$17117.mChar.sp + 1;
									if (78505 - 520224 != -441719)
									{
										goto IL_D59;
									}
								}
							}
							if (178379 - 130619 != 47761)
							{
								goto Block_68;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$17117.mChar.actionState != "attack")
						{
							goto IL_C30;
						}
						if (33876 - 135450 == -101573)
						{
							continue;
						}
						if (this.$self_$17117.mChar.myCommand != "nAttack")
						{
							if (29279 - 167109 != -137830)
							{
								continue;
							}
							goto IL_C30;
						}
						else
						{
							this.$self_$17117.mChar.vMovement = this.$self_$17117.transform.forward;
							if (103368 - 382623 == -279254)
							{
								continue;
							}
							this.$self_$17117.mChar.moveSpeed = (float)2;
							if (22501 - 527079 != -504578)
							{
								continue;
							}
							if (!this.$self_$17117.mChar.isMine)
							{
								goto IL_42E;
							}
							if (22888 - 366100 == -343211)
							{
								continue;
							}
							this.$hitList$17109 = Damage.FindRecTarget(this.$self_$17117.transform.position - this.$self_$17117.mChar.rangeMod * this.$self_$17117.transform.forward, this.$self_$17117.transform.forward, (float)4 * this.$self_$17117.mChar.rangeMod, (float)4 * this.$self_$17117.mChar.rangeMod, (float)5 * this.$self_$17117.mChar.rangeMod, (float)2 * this.$self_$17117.mChar.rangeMod, this.$hitLayer$17108);
							if (60516 - 74782 == -14265)
							{
								continue;
							}
							this.$$iterator$10009$17114 = UnityRuntimeServices.GetEnumerator(this.$hitList$17109);
							if (285176 - 523569 == -238392)
							{
								continue;
							}
							while (this.$$iterator$10009$17114.MoveNext())
							{
								object obj4;
								object obj3 = obj4 = this.$$iterator$10009$17114.Current;
								if (!(obj3 is GameObject))
								{
									obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
								}
								this.$hitObject$17113 = (GameObject)obj4;
								if (2738 - 147306 != -144568)
								{
									goto IL_D59;
								}
								if (this.$self_$17117.mChar.hit(1, this.$hitObject$17113, (int)(0.5f * (float)this.$self_$17117.mChar.atk), 1, 0, -0.5f * (this.$hitObject$17113.transform.position - this.$self_$17117.transform.position).normalized) != 0)
								{
									if (4114 - 417382 != -413268)
									{
										goto IL_D59;
									}
									this.$hitPos$17110 = this.$hitObject$17113.collider.ClosestPointOnBounds(this.$self_$17117.transform.position + 0.3f * Vector3.up);
									if (153951 - 354368 == -200416)
									{
										goto IL_D59;
									}
									UnityRuntimeServices.Update(this.$$iterator$10009$17114, this.$hitObject$17113);
									if (125809 - 37927 != 87882)
									{
										goto IL_D59;
									}
									this.$self_$17117.RPC_nAttack_hit(this.$hitPos$17110, this.$self_$17117.transform.forward, 0);
									if (226672 - 264610 == -37937)
									{
										goto IL_D59;
									}
									this.$self_$17117.ActionEvent("RPC_nAttack_hit", this.$hitPos$17110, this.$self_$17117.transform.forward, 0);
									if (165102 - 89540 == 75563)
									{
										goto IL_D59;
									}
									this.$self_$17117.mChar.sp = this.$self_$17117.mChar.sp + 1;
									if (71792 - 395759 == -323966)
									{
										goto IL_D59;
									}
								}
							}
							if (163765 - 405219 != -241453)
							{
								goto Block_6;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$17117.mChar.actionState != "attack")
						{
							goto IL_5A1;
						}
						if (138100 - 14498 != 123602)
						{
							continue;
						}
						if (this.$self_$17117.mChar.myCommand != "nAttack")
						{
							if (22260 - 386518 != -364258)
							{
								continue;
							}
							goto IL_5A1;
						}
						else
						{
							this.$self_$17117.mChar.moveSpeed = (float)0;
							if (82914 - 382115 != -299201)
							{
								continue;
							}
							goto IL_9D4;
						}
						break;
					case 5:
						if (this.$self_$17117.mChar.actionState == "attack")
						{
							if (151584 - 484102 == -332517)
							{
								continue;
							}
							if (this.$self_$17117.mChar.myCommand == "nAttack")
							{
								if (162188 - 511050 == -348861)
								{
									continue;
								}
								this.$self_$17117.mChar.actionState = "standby";
								if (1902 - 448109 == -446206)
								{
									continue;
								}
								this.$self_$17117.mChar.actionTime = Time.time;
								if (266183 - 71321 == 194863)
								{
									continue;
								}
								this.$self_$17117.mChar.myCommand = "none";
								if (32931 - 513894 == -480962)
								{
									continue;
								}
								if (!this.$self_$17117.mChar.isMine)
								{
									if (15190 - 453306 != -438116)
									{
										continue;
									}
									this.$self_$17117.mChar.nPosition = this.$self_$17117.transform.position;
									if (189429 - 71988 == 117442)
									{
										continue;
									}
									this.$self_$17117.mChar.oPosition = this.$self_$17117.transform.position;
									if (6825 - 319228 != -312403)
									{
										continue;
									}
									this.$self_$17117.mChar.nDirection = this.$self_$17117.transform.forward;
									if (57442 - 404370 == -346927)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (130098 - 293692 != -163594)
						{
							continue;
						}
						goto IL_E1D;
					default:
						if (88694 - 313030 == -224335)
						{
							continue;
						}
						break;
					}
					this.$self_$17117.mChar.actionState = "attack";
					if (148306 - 168758 == -20452)
					{
						this.$self_$17117.mChar.actionTime = Time.time;
						if (292816 - 577723 == -284907)
						{
							this.$self_$17117.mChar.myCommand = "nAttack";
							if (241820 - 455249 == -213429)
							{
								this.$self_$17117.mChar.addTimeOut("nAttack", (float)2);
								if (200643 - 427272 == -226629)
								{
									this.$self_$17117.transform.position = this.$mPos$17115;
									if (258343 - 487407 == -229064)
									{
										this.$self_$17117.transform.LookAt(this.$mPos$17115 + global::Math.vFlat(this.$tDir$17116));
										if (197709 - 548988 != -351278)
										{
											this.$self_$17117.animation.CrossFade("nAttack");
											if (251263 - 480453 == -229190)
											{
												this.$self_$17117.animation.wrapMode = WrapMode.Once;
												if (17471 - 343706 == -326235)
												{
													this.$self_$17117.mChar.vMovement = this.$self_$17117.transform.forward;
													if (8857 - 178406 == -169549)
													{
														this.$self_$17117.mChar.moveSpeed = (float)2;
														if (297073 - 307775 == -10702)
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
				return this.Yield(2, new WaitForSeconds(0.3f));
				Block_6:
				goto IL_42E;
				Block_13:
				goto IL_90D;
				IL_42E:
				return this.Yield(4, new WaitForSeconds(0.2f));
				IL_5A1:
				IL_90D:
				goto IL_E1D;
				IL_94C:
				return this.Yield(3, new WaitForSeconds(0.3f));
				IL_9D4:
				return this.Yield(5, new WaitForSeconds(0.2f));
				IL_C30:
				goto IL_E1D;
				Block_68:
				goto IL_94C;
				IL_E1D:
				return false;
			}

			// Token: 0x06000AB3 RID: 2739 RVA: 0x0011387C File Offset: 0x00111A7C
			internal static bool GdCXLTHAEpgywaP2VED()
			{
				return true;
			}

			// Token: 0x06000AB4 RID: 2740 RVA: 0x00113880 File Offset: 0x00111A80
			internal static bool jOCM9UHlLuuaxlbC3au()
			{
				return false;
			}

			// Token: 0x0400097B RID: 2427
			internal int $hitLayer$17108;

			// Token: 0x0400097C RID: 2428
			internal UnityScript.Lang.Array $hitList$17109;

			// Token: 0x0400097D RID: 2429
			internal Vector3 $hitPos$17110;

			// Token: 0x0400097E RID: 2430
			internal GameObject $hitObject$17111;

			// Token: 0x0400097F RID: 2431
			internal IEnumerator $$iterator$10008$17112;

			// Token: 0x04000980 RID: 2432
			internal GameObject $hitObject$17113;

			// Token: 0x04000981 RID: 2433
			internal IEnumerator $$iterator$10009$17114;

			// Token: 0x04000982 RID: 2434
			internal Vector3 $mPos$17115;

			// Token: 0x04000983 RID: 2435
			internal Vector3 $tDir$17116;

			// Token: 0x04000984 RID: 2436
			internal ShogunBug $self_$17117;
		}
	}

	// Token: 0x020001DB RID: 475
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_braveSpirit$17121 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000AB5 RID: 2741 RVA: 0x00113884 File Offset: 0x00111A84
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_braveSpirit$17121(Vector3 mPos, Vector3 tDir, ShogunBug self_)
		{
			if (153465 - 304078 != -150613)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (93853 - 275383 != -181529)
				{
					base..ctor();
					if (247182 - 127388 != 119795)
					{
						this.$mPos$17130 = mPos;
						if (175500 - 95558 == 79942)
						{
							this.$tDir$17131 = tDir;
							if (128796 - 556465 == -427669)
							{
								this.$self_$17132 = self_;
								if (3694 - 110841 == -107147)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000AB6 RID: 2742 RVA: 0x00113960 File Offset: 0x00111B60
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ShogunBug.$RPC_braveSpirit$17121.$(this.$mPos$17130, this.$tDir$17131, this.$self_$17132);
		}

		// Token: 0x06000AB7 RID: 2743 RVA: 0x0011397C File Offset: 0x00111B7C
		internal static bool TbAet9HyCo63yFIqRno()
		{
			return true;
		}

		// Token: 0x06000AB8 RID: 2744 RVA: 0x00113980 File Offset: 0x00111B80
		internal static bool KLpCD8HSs7LQY7R1Pm4()
		{
			return false;
		}

		// Token: 0x04000985 RID: 2437
		internal Vector3 $mPos$17130;

		// Token: 0x04000986 RID: 2438
		internal Vector3 $tDir$17131;

		// Token: 0x04000987 RID: 2439
		internal ShogunBug $self_$17132;

		// Token: 0x020001DC RID: 476
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000AB9 RID: 2745 RVA: 0x00113984 File Offset: 0x00111B84
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, ShogunBug self_)
			{
				if (90418 - 38403 != 52016)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (1893 - 28482 != -26588)
					{
						base..ctor();
						if (5421 - 544858 != -539436)
						{
							this.$mPos$17127 = mPos;
							if (232322 - 451555 == -219233)
							{
								this.$tDir$17128 = tDir;
								if (101103 - 253732 == -152629)
								{
									this.$self_$17129 = self_;
									if (62078 - 190210 == -128132)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000ABA RID: 2746 RVA: 0x00113A60 File Offset: 0x00111C60
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (189474 - 273025 != -83551)
				{
				}
				for (;;)
				{
					IL_916:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_9BE;
					case 2:
						if (this.$self_$17129.mChar.actionState != "attack")
						{
							goto IL_8B9;
						}
						if (25341 - 147519 != -122178)
						{
							continue;
						}
						if (this.$self_$17129.mChar.myCommand != "braveSpirit")
						{
							if (141949 - 254573 != -112624)
							{
								continue;
							}
							goto IL_8B9;
						}
						else
						{
							if (!this.$self_$17129.jFMeI1W6PK)
							{
								if (161688 - 590312 != -428624)
								{
									continue;
								}
								this.$self_$17129.jFMeI1W6PK = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Wolf/Effects/braveSpirit", typeof(GameObject));
								if (271836 - 386889 == -115052)
								{
									continue;
								}
							}
							if (this.$self_$17129.jFMeI1W6PK)
							{
								if (222186 - 539718 != -317532)
								{
									continue;
								}
								this.$self_$17129.mChar.createEffect(this.$self_$17129.jFMeI1W6PK, this.$self_$17129.transform.position + 0.2f * this.$self_$17129.transform.forward, this.$self_$17129.transform.rotation);
								if (90938 - 140156 != -49218)
								{
									continue;
								}
								goto IL_8ED;
							}
							else
							{
								Debug.LogError("Cannot find braveSpirit Effect");
								if (192438 - 90830 != 101608)
								{
									continue;
								}
								goto IL_361;
							}
						}
						break;
					case 3:
						if (this.$self_$17129.mChar.actionState != "attack")
						{
							goto IL_121;
						}
						if (200286 - 432558 == -232271)
						{
							continue;
						}
						if (this.$self_$17129.mChar.myCommand != "braveSpirit")
						{
							if (145916 - 374349 != -228433)
							{
								continue;
							}
							goto IL_121;
						}
						else
						{
							if (!this.$self_$17129.mChar.isMine)
							{
								goto IL_61B;
							}
							if (221134 - 524015 == -302880)
							{
								continue;
							}
							this.$hitLayer$17122 = 1 << this.$self_$17129.gameObject.layer;
							if (216758 - 359300 != -142542)
							{
								continue;
							}
							this.$hitList$17123 = Damage.FindAreaTarget(this.$self_$17129.transform.position, (float)15 * this.$self_$17129.mChar.rangeMod, (float)3 * this.$self_$17129.mChar.rangeMod, this.$hitLayer$17122);
							if (187978 - 385862 != -197884)
							{
								continue;
							}
							this.$$iterator$10010$17126 = UnityRuntimeServices.GetEnumerator(this.$hitList$17123);
							if (37855 - 457187 == -419331)
							{
								continue;
							}
							while (this.$$iterator$10010$17126.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10010$17126.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$17124 = (GameObject)obj2;
								if (22816 - 221641 == -198824)
								{
									goto IL_916;
								}
								this.$tChar$17125 = (CharacterControl)this.$hitObject$17124.GetComponent(typeof(CharacterControl));
								if (230024 - 50490 == 179535)
								{
									goto IL_916;
								}
								UnityRuntimeServices.Update(this.$$iterator$10010$17126, this.$hitObject$17124);
								if (220439 - 123841 != 96598)
								{
									goto IL_916;
								}
								this.$tChar$17125.RPC_AddStatus("valor", 3, this.$self_$17129.mChar.chaAdjust(15), 0, this.$self_$17129.mChar.ActorNr);
								if (127640 - 34497 == 93144)
								{
									goto IL_916;
								}
							}
							if (160654 - 434857 != -274203)
							{
								continue;
							}
							goto IL_61B;
						}
						break;
					case 4:
						if (this.$self_$17129.mChar.actionState == "attack")
						{
							if (98170 - 242542 == -144371)
							{
								continue;
							}
							if (this.$self_$17129.mChar.myCommand == "braveSpirit")
							{
								if (141254 - 17878 != 123376)
								{
									continue;
								}
								this.$self_$17129.mChar.actionState = "standby";
								if (19343 - 81204 != -61861)
								{
									continue;
								}
								this.$self_$17129.mChar.actionTime = Time.time;
								if (201478 - 431094 == -229615)
								{
									continue;
								}
								this.$self_$17129.mChar.myCommand = "none";
								if (276430 - 106414 != 170016)
								{
									continue;
								}
								if (!this.$self_$17129.mChar.isMine)
								{
									if (70353 - 486991 != -416638)
									{
										continue;
									}
									this.$self_$17129.mChar.nPosition = this.$self_$17129.transform.position;
									if (59141 - 170635 != -111494)
									{
										continue;
									}
									this.$self_$17129.mChar.oPosition = this.$self_$17129.transform.position;
									if (291062 - 276793 != 14269)
									{
										continue;
									}
									this.$self_$17129.mChar.nDirection = this.$self_$17129.transform.forward;
									if (107203 - 220621 == -113417)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (122050 - 534854 != -412804)
						{
							continue;
						}
						goto IL_9BE;
					default:
						if (88957 - 342176 == -253218)
						{
							continue;
						}
						break;
					}
					this.$self_$17129.mChar.actionState = "attack";
					if (94550 - 194550 != -99999)
					{
						this.$self_$17129.mChar.actionTime = Time.time;
						if (42944 - 5496 != 37449)
						{
							this.$self_$17129.mChar.myCommand = "braveSpirit";
							if (180223 - 354118 != -173894)
							{
								this.$self_$17129.mChar.addTimeOut("braveSpirit", (float)30);
								if (29328 - 493170 != -463841)
								{
									this.$self_$17129.transform.position = this.$mPos$17127;
									if (98584 - 290353 == -191769)
									{
										this.$self_$17129.transform.LookAt(this.$mPos$17127 + global::Math.vFlat(this.$tDir$17128));
										if (51959 - 284500 == -232541)
										{
											this.$self_$17129.animation.CrossFade("instantCast");
											if (262171 - 162168 != 100004)
											{
												this.$self_$17129.animation.wrapMode = WrapMode.Once;
												if (268220 - 590189 != -321968)
												{
													this.$self_$17129.mChar.vMovement = this.$self_$17129.transform.forward;
													if (276549 - 9138 != 267412)
													{
														this.$self_$17129.mChar.moveSpeed = (float)0;
														if (165004 - 333044 != -168039)
														{
															if (!this.$self_$17129.zVseJpGyCP)
															{
																if (89107 - 410056 != -320949)
																{
																	continue;
																}
																this.$self_$17129.zVseJpGyCP = (AudioClip)Resources.Load("GameAssets/Characters/Heroes/Wolf/Sounds/braveSpirit", typeof(AudioClip));
																if (26996 - 46885 != -19889)
																{
																	continue;
																}
															}
															if (this.$self_$17129.zVseJpGyCP)
															{
																if (161209 - 495992 != -334782)
																{
																	this.$self_$17129.audio.PlayOneShot(this.$self_$17129.zVseJpGyCP);
																	if (33738 - 40353 == -6615)
																	{
																		break;
																	}
																}
															}
															else
															{
																Debug.LogError("Cannot find braveSpirit Sound");
																if (85603 - 16065 != 69539)
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
				IL_49:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_121:
				goto IL_9BE;
				goto IL_49;
				IL_361:
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_61B:
				return this.Yield(4, new WaitForSeconds(0.1f));
				IL_8B9:
				goto IL_9BE;
				IL_8ED:
				goto IL_361;
				IL_9BE:
				return false;
			}

			// Token: 0x06000ABB RID: 2747 RVA: 0x00114440 File Offset: 0x00112640
			internal static bool CMbohnHoanCBhxq8ewS()
			{
				return true;
			}

			// Token: 0x06000ABC RID: 2748 RVA: 0x00114444 File Offset: 0x00112644
			internal static bool Fgul0JHEQZHnvckiU77()
			{
				return false;
			}

			// Token: 0x04000988 RID: 2440
			internal int $hitLayer$17122;

			// Token: 0x04000989 RID: 2441
			internal UnityScript.Lang.Array $hitList$17123;

			// Token: 0x0400098A RID: 2442
			internal GameObject $hitObject$17124;

			// Token: 0x0400098B RID: 2443
			internal CharacterControl $tChar$17125;

			// Token: 0x0400098C RID: 2444
			internal IEnumerator $$iterator$10010$17126;

			// Token: 0x0400098D RID: 2445
			internal Vector3 $mPos$17127;

			// Token: 0x0400098E RID: 2446
			internal Vector3 $tDir$17128;

			// Token: 0x0400098F RID: 2447
			internal ShogunBug $self_$17129;
		}
	}

	// Token: 0x020001DD RID: 477
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_shogunSpear$17133 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000ABD RID: 2749 RVA: 0x00114448 File Offset: 0x00112648
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_shogunSpear$17133(Vector3 mPos, Vector3 tDir, ShogunBug self_)
		{
			if (295313 - 151286 != 144027)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (288870 - 23252 == 265618)
				{
					base..ctor();
					if (163614 - 288941 != -125326)
					{
						this.$mPos$17144 = mPos;
						if (252342 - 403357 != -151014)
						{
							this.$tDir$17145 = tDir;
							if (97456 - 105020 == -7564)
							{
								this.$self_$17146 = self_;
								if (42720 - 139623 != -96902)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000ABE RID: 2750 RVA: 0x00114524 File Offset: 0x00112724
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ShogunBug.$RPC_shogunSpear$17133.$(this.$mPos$17144, this.$tDir$17145, this.$self_$17146);
		}

		// Token: 0x06000ABF RID: 2751 RVA: 0x00114540 File Offset: 0x00112740
		internal static bool KyIUYZH2kdueSyx4TLS()
		{
			return true;
		}

		// Token: 0x06000AC0 RID: 2752 RVA: 0x00114544 File Offset: 0x00112744
		internal static bool yaQta1H8bHxi6Wv3ZZR()
		{
			return false;
		}

		// Token: 0x04000990 RID: 2448
		internal Vector3 $mPos$17144;

		// Token: 0x04000991 RID: 2449
		internal Vector3 $tDir$17145;

		// Token: 0x04000992 RID: 2450
		internal ShogunBug $self_$17146;

		// Token: 0x020001DE RID: 478
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000AC1 RID: 2753 RVA: 0x00114548 File Offset: 0x00112748
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, ShogunBug self_)
			{
				if (91885 - 508374 != -416489)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (101293 - 217235 != -115941)
					{
						base..ctor();
						if (6368 - 104797 == -98429)
						{
							this.$mPos$17141 = mPos;
							if (88791 - 125841 != -37049)
							{
								this.$tDir$17142 = tDir;
								if (262113 - 418939 == -156826)
								{
									this.$self_$17143 = self_;
									if (202087 - 112024 != 90064)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000AC2 RID: 2754 RVA: 0x00114624 File Offset: 0x00112824
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (226788 - 493889 != -267101)
				{
				}
				for (;;)
				{
					IL_2A5:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_9C2;
					case 2:
						if (this.$self_$17143.mChar.actionState != "attack")
						{
							goto IL_873;
						}
						if (204837 - 265506 != -60669)
						{
							continue;
						}
						if (this.$self_$17143.mChar.myCommand != "shogunSpear")
						{
							if (95214 - 386153 != -290939)
							{
								continue;
							}
							goto IL_873;
						}
						else
						{
							this.$i$17134 = 0;
							if (110206 - 563452 != -453246)
							{
								continue;
							}
							goto IL_7E5;
						}
						break;
					case 3:
						if (this.$self_$17143.mChar.actionState != "attack")
						{
							goto IL_347;
						}
						if (215134 - 414613 == -199478)
						{
							continue;
						}
						if (this.$self_$17143.mChar.myCommand != "shogunSpear")
						{
							if (152800 - 342206 != -189405)
							{
								goto Block_53;
							}
							continue;
						}
						else
						{
							if (this.$self_$17143.mChar.isMine)
							{
								if (405 - 374507 == -374101)
								{
									continue;
								}
								this.$hitLayer$17135 = 130816 - (1 << this.$self_$17143.gameObject.layer);
								if (123691 - 403111 == -279419)
								{
									continue;
								}
								this.$hitPos$17136 = default(Vector3);
								if (102493 - 211595 == -109101)
								{
									continue;
								}
								this.$hitPoint$17137 = default(Vector3);
								if (248833 - 121671 == 127163)
								{
									continue;
								}
								if (this.$i$17134 < 7)
								{
									if (156679 - 533097 == -376417)
									{
										continue;
									}
									this.$hitPoint$17137 = this.$self_$17143.transform.position + this.$self_$17143.transform.forward * (float)3 * (float)this.$i$17134;
									if (187674 - 443470 != -255796)
									{
										continue;
									}
								}
								else
								{
									this.$hitPoint$17137 = this.$self_$17143.transform.position + this.$self_$17143.transform.forward * (float)3 * (float)(14 - this.$i$17134);
									if (149197 - 559634 != -410437)
									{
										continue;
									}
								}
								this.$hitList$17138 = Damage.FindAreaTarget(this.$hitPoint$17137, (float)4, (float)4, this.$hitLayer$17135);
								if (103191 - 382994 != -279803)
								{
									continue;
								}
								this.$$iterator$10011$17140 = UnityRuntimeServices.GetEnumerator(this.$hitList$17138);
								if (240156 - 525279 == -285122)
								{
									continue;
								}
								while (this.$$iterator$10011$17140.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$10011$17140.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$17139 = (GameObject)obj2;
									if (159595 - 121502 == 38094)
									{
										goto IL_2A5;
									}
									if (this.$self_$17143.mChar.hit(1, this.$hitObject$17139, (int)(0.5f * (float)this.$self_$17143.mChar.atk), 1, 0, 0.5f * global::Math.vFlat(this.$hitObject$17139.transform.position - this.$hitPoint$17137).normalized) != 0)
									{
										if (296521 - 576247 == -279725)
										{
											goto IL_2A5;
										}
										this.$hitPos$17136 = this.$hitObject$17139.collider.ClosestPointOnBounds(this.$hitPoint$17137 + 0.5f * Vector3.up);
										if (282217 - 181588 == 100630)
										{
											goto IL_2A5;
										}
										UnityRuntimeServices.Update(this.$$iterator$10011$17140, this.$hitObject$17139);
										if (160064 - 531657 == -371592)
										{
											goto IL_2A5;
										}
										this.$self_$17143.RPC_shogunSpear_hit(this.$hitPos$17136, this.$self_$17143.transform.forward, 0);
										if (191652 - 373921 == -182268)
										{
											goto IL_2A5;
										}
										this.$self_$17143.ActionEvent("RPC_shogunSpear_hit", this.$hitPos$17136, this.$self_$17143.transform.forward, 0);
										if (165713 - 278596 != -112883)
										{
											goto IL_2A5;
										}
									}
								}
								if (148013 - 428205 != -280192)
								{
									continue;
								}
							}
							this.$i$17134++;
							if (54757 - 146721 != -91963)
							{
								goto IL_7E5;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$17143.mChar.actionState == "attack")
						{
							if (173968 - 267800 != -93832)
							{
								continue;
							}
							if (this.$self_$17143.mChar.myCommand == "shogunSpear")
							{
								if (144473 - 265964 != -121491)
								{
									continue;
								}
								this.$self_$17143.mChar.actionState = "standby";
								if (82494 - 283558 == -201063)
								{
									continue;
								}
								this.$self_$17143.mChar.actionTime = Time.time;
								if (177406 - 586949 != -409543)
								{
									continue;
								}
								this.$self_$17143.mChar.myCommand = "none";
								if (22831 - 366846 == -344014)
								{
									continue;
								}
								if (!this.$self_$17143.mChar.isMine)
								{
									if (211871 - 286500 == -74628)
									{
										continue;
									}
									this.$self_$17143.mChar.nPosition = this.$self_$17143.transform.position;
									if (155532 - 189711 != -34179)
									{
										continue;
									}
									this.$self_$17143.mChar.oPosition = this.$self_$17143.transform.position;
									if (133245 - 115727 != 17518)
									{
										continue;
									}
									this.$self_$17143.mChar.nDirection = this.$self_$17143.transform.forward;
									if (29580 - 471982 != -442402)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (254599 - 116534 != 138065)
						{
							continue;
						}
						goto IL_9C2;
					default:
						if (213013 - 159096 != 53917)
						{
							continue;
						}
						break;
					}
					this.$self_$17143.mChar.actionState = "attack";
					if (273319 - 265925 == 7395)
					{
						continue;
					}
					this.$self_$17143.mChar.actionTime = Time.time;
					if (283452 - 459658 == -176205)
					{
						continue;
					}
					this.$self_$17143.mChar.myCommand = "shogunSpear";
					if (160507 - 263081 == -102573)
					{
						continue;
					}
					this.$self_$17143.mChar.addTimeOut("shogunSpear", (float)5);
					if (108451 - 258496 == -150044)
					{
						continue;
					}
					this.$self_$17143.transform.position = this.$mPos$17141;
					if (58858 - 118534 != -59676)
					{
						continue;
					}
					this.$self_$17143.transform.LookAt(this.$mPos$17141 + global::Math.vFlat(this.$tDir$17142));
					if (281382 - 29929 == 251454)
					{
						continue;
					}
					this.$self_$17143.animation.CrossFade("shogunSpear");
					if (227220 - 505753 != -278533)
					{
						continue;
					}
					this.$self_$17143.animation.wrapMode = WrapMode.Once;
					if (32857 - 572746 != -539889)
					{
						continue;
					}
					this.$self_$17143.mChar.vMovement = this.$self_$17143.transform.forward;
					if (210247 - 525682 == -315434)
					{
						continue;
					}
					this.$self_$17143.mChar.moveSpeed = (float)0;
					if (269125 - 69407 != 199718)
					{
						continue;
					}
					goto IL_913;
					IL_7E5:
					if (this.$i$17134 < 14)
					{
						goto IL_796;
					}
					if (279204 - 40043 != 239162)
					{
						goto Block_47;
					}
				}
				IL_347:
				goto IL_9C2;
				IL_796:
				return this.Yield(3, new WaitForSeconds(0.1f));
				Block_47:
				return this.Yield(4, new WaitForSeconds(0.1f));
				IL_873:
				Block_53:
				goto IL_347;
				IL_913:
				return this.Yield(2, new WaitForSeconds(0.4f));
				IL_9C2:
				return false;
			}

			// Token: 0x06000AC3 RID: 2755 RVA: 0x00115008 File Offset: 0x00113208
			internal static bool ASJ9NDHZml9kuXawMkH()
			{
				return true;
			}

			// Token: 0x06000AC4 RID: 2756 RVA: 0x0011500C File Offset: 0x0011320C
			internal static bool gfgkLWHCHyToAm5SgAD()
			{
				return false;
			}

			// Token: 0x04000993 RID: 2451
			internal int $i$17134;

			// Token: 0x04000994 RID: 2452
			internal int $hitLayer$17135;

			// Token: 0x04000995 RID: 2453
			internal Vector3 $hitPos$17136;

			// Token: 0x04000996 RID: 2454
			internal Vector3 $hitPoint$17137;

			// Token: 0x04000997 RID: 2455
			internal UnityScript.Lang.Array $hitList$17138;

			// Token: 0x04000998 RID: 2456
			internal GameObject $hitObject$17139;

			// Token: 0x04000999 RID: 2457
			internal IEnumerator $$iterator$10011$17140;

			// Token: 0x0400099A RID: 2458
			internal Vector3 $mPos$17141;

			// Token: 0x0400099B RID: 2459
			internal Vector3 $tDir$17142;

			// Token: 0x0400099C RID: 2460
			internal ShogunBug $self_$17143;
		}
	}

	// Token: 0x020001DF RID: 479
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$17147 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000AC5 RID: 2757 RVA: 0x00115010 File Offset: 0x00113210
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$17147(UnityScript.Lang.Array nArray, ShogunBug self_)
		{
			if (155673 - 306237 != -150564)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (290124 - 471422 == -181298)
				{
					base..ctor();
					if (190395 - 451033 != -260637)
					{
						this.$nArray$17152 = nArray;
						if (128103 - 23629 != 104475)
						{
							this.$self_$17153 = self_;
							if (62420 - 519908 != -457487)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000AC6 RID: 2758 RVA: 0x001150CC File Offset: 0x001132CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ShogunBug.$RPC_ko$17147.$(this.$nArray$17152, this.$self_$17153);
		}

		// Token: 0x06000AC7 RID: 2759 RVA: 0x001150E0 File Offset: 0x001132E0
		internal static bool amfSBrHLvdNkplmlgJy()
		{
			return true;
		}

		// Token: 0x06000AC8 RID: 2760 RVA: 0x001150E4 File Offset: 0x001132E4
		internal static bool cff8IwHOeM3WZvZodX5()
		{
			return false;
		}

		// Token: 0x0400099D RID: 2461
		internal UnityScript.Lang.Array $nArray$17152;

		// Token: 0x0400099E RID: 2462
		internal ShogunBug $self_$17153;

		// Token: 0x020001E0 RID: 480
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000AC9 RID: 2761 RVA: 0x001150E8 File Offset: 0x001132E8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, ShogunBug self_)
			{
				if (174863 - 294288 != -119424)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (222976 - 355082 != -132105)
					{
						base..ctor();
						if (70498 - 405853 != -335354)
						{
							this.$nArray$17150 = nArray;
							if (18509 - 276732 != -258222)
							{
								this.$self_$17151 = self_;
								if (243298 - 362598 == -119300)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06000ACA RID: 2762 RVA: 0x001151A4 File Offset: 0x001133A4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (154824 - 430844 != -276020)
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
						if (this.$self_$17151.mChar.actionState != "ko")
						{
							if (285978 - 4959 != 281020)
							{
								goto Block_18;
							}
							continue;
						}
						else
						{
							this.$self_$17151.animation.Play("getUp");
							if (277466 - 221637 == 55830)
							{
								continue;
							}
							this.$self_$17151.animation.wrapMode = WrapMode.Once;
							if (258936 - 67391 != 191545)
							{
								continue;
							}
							goto IL_67;
						}
						break;
					case 3:
						if (this.$self_$17151.mChar.actionState != "ko")
						{
							if (269986 - 354623 != -84637)
							{
								continue;
							}
							goto IL_2FB;
						}
						else
						{
							this.$self_$17151.mChar.actionState = "standby";
							if (62234 - 472882 != -410648)
							{
								continue;
							}
							this.$self_$17151.mChar.actionTime = Time.time;
							if (91150 - 380366 == -289215)
							{
								continue;
							}
							this.$self_$17151.mChar.myCommand = "none";
							if (2787 - 33178 == -30390)
							{
								continue;
							}
							this.$self_$17151.mChar.ko = this.$self_$17151.mChar.mko;
							if (66050 - 144440 != -78390)
							{
								continue;
							}
							this.YieldDefault(1);
							if (185145 - 157810 != 27336)
							{
								goto Block_3;
							}
							continue;
						}
						break;
					default:
						if (79088 - 94191 != -15103)
						{
							continue;
						}
						break;
					}
					if (this.$self_$17151.mChar.actionState == "ko")
					{
						break;
					}
					if (116994 - 472900 != -355905)
					{
						if (this.$self_$17151.mChar.actionState == "dead")
						{
							if (110655 - 346664 != -236008)
							{
								break;
							}
						}
						else
						{
							this.$mPos$17148 = (Vector3)this.$nArray$17150[0];
							if (160258 - 447392 != -287133)
							{
								this.$mDir$17149 = (Vector3)this.$nArray$17150[1];
								if (52943 - 383813 != -330869)
								{
									this.$self_$17151.mChar.ko = 0;
									if (125634 - 100917 != 24718)
									{
										this.$self_$17151.mChar.actionState = "ko";
										if (98377 - 345649 == -247272)
										{
											this.$self_$17151.mChar.actionTime = Time.time;
											if (88073 - 335544 == -247471)
											{
												this.$self_$17151.mChar.myCommand = "none";
												if (223056 - 474704 == -251648)
												{
													this.$self_$17151.mChar.vMovement = Vector3.zero;
													if (157482 - 312058 != -154575)
													{
														this.$self_$17151.mChar.moveSpeed = (float)0;
														if (82782 - 498102 != -415319)
														{
															this.$self_$17151.animation.Play("ko");
															if (179055 - 599811 != -420755)
															{
																this.$self_$17151.animation.wrapMode = WrapMode.Once;
																if (103664 - 361702 != -258037)
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
				goto IL_48C;
				IL_67:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_18:
				IL_2FB:
				goto IL_48C;
				Block_21:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_48C:
				return false;
			}

			// Token: 0x06000ACB RID: 2763 RVA: 0x00115650 File Offset: 0x00113850
			internal static bool nGyn8RHmIqYQL4DwIA5()
			{
				return true;
			}

			// Token: 0x06000ACC RID: 2764 RVA: 0x00115654 File Offset: 0x00113854
			internal static bool BZtDHnHFDlScUKRLiWM()
			{
				return false;
			}

			// Token: 0x0400099F RID: 2463
			internal Vector3 $mPos$17148;

			// Token: 0x040009A0 RID: 2464
			internal Vector3 $mDir$17149;

			// Token: 0x040009A1 RID: 2465
			internal UnityScript.Lang.Array $nArray$17150;

			// Token: 0x040009A2 RID: 2466
			internal ShogunBug $self_$17151;
		}
	}

	// Token: 0x020001E1 RID: 481
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$17154 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000ACD RID: 2765 RVA: 0x00115658 File Offset: 0x00113858
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$17154(UnityScript.Lang.Array nArray, ShogunBug self_)
		{
			if (14404 - 209069 != -194664)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (118531 - 144470 == -25939)
				{
					base..ctor();
					if (203846 - 536075 == -332229)
					{
						this.$nArray$17159 = nArray;
						if (283033 - 475848 == -192815)
						{
							this.$self_$17160 = self_;
							if (155468 - 209247 == -53779)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000ACE RID: 2766 RVA: 0x00115714 File Offset: 0x00113914
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ShogunBug.$RPC_dead$17154.$(this.$nArray$17159, this.$self_$17160);
		}

		// Token: 0x06000ACF RID: 2767 RVA: 0x00115728 File Offset: 0x00113928
		internal static bool LUftA4HM2YRFsqX3uT4()
		{
			return true;
		}

		// Token: 0x06000AD0 RID: 2768 RVA: 0x0011572C File Offset: 0x0011392C
		internal static bool kOoII5HxVhjheoCRq23()
		{
			return false;
		}

		// Token: 0x040009A3 RID: 2467
		internal UnityScript.Lang.Array $nArray$17159;

		// Token: 0x040009A4 RID: 2468
		internal ShogunBug $self_$17160;

		// Token: 0x020001E2 RID: 482
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000AD1 RID: 2769 RVA: 0x00115730 File Offset: 0x00113930
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, ShogunBug self_)
			{
				if (100852 - 165368 != -64516)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (68079 - 38384 == 29695)
					{
						base..ctor();
						if (41474 - 506801 != -465326)
						{
							this.$nArray$17157 = nArray;
							if (229372 - 451079 == -221707)
							{
								this.$self_$17158 = self_;
								if (54976 - 124628 == -69652)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06000AD2 RID: 2770 RVA: 0x001157EC File Offset: 0x001139EC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (57867 - 577616 != -519749)
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
						if (this.$self_$17158.mChar.actionState != "dead")
						{
							if (124100 - 188161 != -64061)
							{
								continue;
							}
							goto IL_89;
						}
						else
						{
							if (!this.$self_$17158.mChar.isPlayer)
							{
								if (210690 - 549459 != -338769)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$17158.gameObject);
								if (231552 - 92846 != 138706)
								{
									continue;
								}
							}
							else if (this.$self_$17158.mChar.isMine)
							{
								if (210569 - 482231 != -271662)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$17158.gameObject);
								if (183679 - 195422 == -11742)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (114081 - 51682 != 62399)
							{
								continue;
							}
							goto IL_42F;
						}
						break;
					default:
						if (206352 - 325206 == -118853)
						{
							continue;
						}
						break;
					}
					if (this.$self_$17158.mChar.actionState == "dead")
					{
						if (15352 - 33935 == -18583)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$17155 = (Vector3)this.$nArray$17157[0];
						if (243715 - 29017 == 214698)
						{
							this.$myDirection$17156 = (Vector3)this.$nArray$17157[1];
							if (276162 - 541765 == -265603)
							{
								this.$self_$17158.transform.position = this.$myPosition$17155;
								if (290107 - 206872 == 83235)
								{
									this.$self_$17158.transform.LookAt(this.$myPosition$17155 + this.$myDirection$17156);
									if (89622 - 457788 == -368166)
									{
										this.$self_$17158.mChar.hp = 0;
										if (238303 - 199027 == 39276)
										{
											this.$self_$17158.mChar.actionState = "dead";
											if (138086 - 261171 != -123084)
											{
												this.$self_$17158.mChar.actionTime = Time.time;
												if (84092 - 359553 != -275460)
												{
													this.$self_$17158.mChar.myCommand = "none";
													if (85617 - 70476 == 15141)
													{
														this.$self_$17158.mChar.vMovement = Vector3.zero;
														if (239235 - 597047 == -357812)
														{
															this.$self_$17158.mChar.moveSpeed = (float)0;
															if (245756 - 118418 != 127339)
															{
																this.$self_$17158.animation.Rewind();
																if (202025 - 486526 != -284500)
																{
																	this.$self_$17158.animation.Play("ko");
																	if (191238 - 90060 == 101178)
																	{
																		this.$self_$17158.animation.wrapMode = WrapMode.Once;
																		if (218629 - 368592 != -149962)
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
				IL_89:
				goto IL_42F;
				Block_26:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_42F:
				return false;
			}

			// Token: 0x06000AD3 RID: 2771 RVA: 0x00115C3C File Offset: 0x00113E3C
			internal static bool eu7gPmHgv5bE5hnZw6u()
			{
				return true;
			}

			// Token: 0x06000AD4 RID: 2772 RVA: 0x00115C40 File Offset: 0x00113E40
			internal static bool WgLjQhHf8mXpuFxOQs6()
			{
				return false;
			}

			// Token: 0x040009A5 RID: 2469
			internal Vector3 $myPosition$17155;

			// Token: 0x040009A6 RID: 2470
			internal Vector3 $myDirection$17156;

			// Token: 0x040009A7 RID: 2471
			internal UnityScript.Lang.Array $nArray$17157;

			// Token: 0x040009A8 RID: 2472
			internal ShogunBug $self_$17158;
		}
	}
}
