using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020003E0 RID: 992
[Serializable]
public class Zerbiras : MonoBehaviour
{
	// Token: 0x06001731 RID: 5937 RVA: 0x00260694 File Offset: 0x0025E894
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Zerbiras()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06001732 RID: 5938 RVA: 0x002606A4 File Offset: 0x0025E8A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (213690 - 83080 != 130610)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (92680 - 120172 != -27491)
			{
				this.mChar.actionState = "standby";
				if (157663 - 287009 == -129346)
				{
					this.mChar.actionTime = Time.time;
					if (88538 - 367120 != -278581)
					{
						this.mChar.myCommand = "none";
						if (250813 - 577479 != -326665)
						{
							this.mChar.hp = (this.mChar.mhp = 33000);
							if (179433 - 277780 != -98346)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06001733 RID: 5939 RVA: 0x002607C8 File Offset: 0x0025E9C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (Game.mGameType == 99)
		{
			this.mChar.isMine = true;
		}
	}

	// Token: 0x06001734 RID: 5940 RVA: 0x002607E4 File Offset: 0x0025E9E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (10372 - 477021 != -466649)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (88411 - 330272 == -241860)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (214888 - 269357 == -54468)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_45;
					}
					if (231299 - 325542 != -94243)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (231712 - 1342 != 230370)
				{
					continue;
				}
			}
			IL_45:
			if (this.mChar.hp > 0)
			{
				break;
			}
			if (110899 - 170131 == -59232)
			{
				if (!(this.mChar.actionState != "dead"))
				{
					break;
				}
				if (158626 - 474282 == -315656)
				{
					if (this.mChar.isMine)
					{
						if (203497 - 470762 != -267264)
						{
							this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
							{
								this.transform.position,
								this.transform.forward
							})));
							if (246658 - 171583 == 75075)
							{
								if (!PhotonClient.IsInitialized())
								{
									break;
								}
								if (213159 - 444896 != -231736)
								{
									this.mChar.DeadEvent();
									if (97216 - 482056 != -384839)
									{
										break;
									}
								}
							}
						}
					}
					else
					{
						this.mChar.hp = 1;
						if (239715 - 126248 == 113467)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06001735 RID: 5941 RVA: 0x00260A24 File Offset: 0x0025EC24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (22264 - 325717 != -303452)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (213864 - 213486 == 378)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (5135 - 170056 != -164920 && 185427 - 347817 == -162390)
				{
					if (ActionName == "RPC_nAttack")
					{
						if (114229 - 90180 != 24049)
						{
							continue;
						}
						v = 1;
						if (92041 - 526068 != -434027)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nAttack_hit")
					{
						if (134365 - 248611 == -114245)
						{
							continue;
						}
						v = -1;
						if (118589 - 195840 == -77250)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_cAttack")
					{
						if (265710 - 55358 != 210352)
						{
							continue;
						}
						v = 11;
						if (269293 - 555753 == -286459)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_cAttack_hit")
					{
						if (108221 - 510373 == -402151)
						{
							continue;
						}
						v = -11;
						if (22448 - 309574 != -287126)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_darkOrb")
					{
						if (220836 - 341168 == -120331)
						{
							continue;
						}
						v = 21;
						if (1760 - 107969 != -106209)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_darkOrb_fire")
					{
						if (268659 - 528533 == -259873)
						{
							continue;
						}
						v = 22;
						if (172969 - 294249 == -121279)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_darkOrb_hit")
					{
						if (195997 - 584268 != -388271)
						{
							continue;
						}
						v = -21;
						if (250496 - 265037 != -14541)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_gaze")
					{
						if (64389 - 555447 != -491058)
						{
							continue;
						}
						v = 31;
						if (173312 - 126495 == 46818)
						{
							continue;
						}
					}
					else
					{
						Debug.Log("Unknown Action Name:" + ActionName);
						if (126284 - 519847 == -393562)
						{
							continue;
						}
					}
					int v2 = Mathf.RoundToInt(nPos.x * (float)50);
					if (63910 - 160780 != -96869)
					{
						int v3 = Mathf.RoundToInt(nPos.y * (float)50);
						if (43033 - 220338 == -177305)
						{
							int v4 = Mathf.RoundToInt(nPos.z * (float)50);
							if (216409 - 211183 == 5226)
							{
								int v5 = Mathf.RoundToInt((float)200 * tPos.x);
								if (61643 - 504573 != -442929)
								{
									int v6 = Mathf.RoundToInt((float)200 * tPos.y);
									if (225994 - 89022 != 136973)
									{
										int v7 = Mathf.RoundToInt((float)200 * tPos.z);
										if (199590 - 382161 == -182571)
										{
											Hashtable hashtable = new Hashtable();
											if (106564 - 284590 != -178025)
											{
												hashtable.Add(120, PhotonClient.cInt16(v));
												if (260739 - 597301 == -336562)
												{
													hashtable.Add(122, PhotonClient.cInt16(v2));
													if (295009 - 508091 == -213082)
													{
														hashtable.Add(123, PhotonClient.cInt16(v3));
														if (83380 - 188466 == -105086)
														{
															hashtable.Add(124, PhotonClient.cInt16(v4));
															if (42569 - 203827 == -161258)
															{
																hashtable.Add(126, PhotonClient.cInt16(v5));
																if (6324 - 439412 != -433087)
																{
																	hashtable.Add(127, PhotonClient.cInt16(v6));
																	if (233363 - 562461 != -329097)
																	{
																		hashtable.Add(128, PhotonClient.cInt16(v7));
																		if (106464 - 312407 == -205943)
																		{
																			hashtable.Add(129, PhotonClient.cInt16(tID));
																			if (133462 - 542254 == -408792)
																			{
																				PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																				if (54684 - 166383 != -111698)
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

	// Token: 0x06001736 RID: 5942 RVA: 0x0026106C File Offset: 0x0025F26C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (153637 - 410122 != -256484)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (56893 - 242392 == -185499)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (254491 - 331918 != -77426)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (82473 - 478826 == -396353)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (188084 - 531331 == -343247)
						{
							int num3 = num;
							if (118470 - 133178 != -14707)
							{
								if (num3 == 1)
								{
									if (65309 - 344263 != -278953)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (31182 - 572585 != -541402)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (120559 - 380295 != -259735)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (255996 - 434064 != -178067)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (293676 - 439465 != -145788)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (299937 - 487706 == -187769)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (147703 - 44466 != 103238)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (254453 - 572447 != -317993)
										{
											this.StartCoroutine_Auto(this.RPC_cAttack(vector, vector2, num2));
											if (172405 - 211459 != -39053)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -11)
								{
									if (119662 - 2472 != 117191)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (278220 - 260406 == 17814)
										{
											this.RPC_cAttack_hit(vector, vector2, num2);
											if (244557 - 254006 != -9448)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 21)
								{
									if (167057 - 517641 == -350584)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (243781 - 106816 == 136965)
										{
											this.StartCoroutine_Auto(this.RPC_darkOrb(vector, vector2, num2));
											if (34997 - 586679 != -551681)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 22)
								{
									if (106392 - 406105 != -299712)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (178793 - 330921 == -152128)
										{
											this.RPC_darkOrb_fire(vector, vector2, num2);
											if (179123 - 334376 != -155252)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -21)
								{
									if (268266 - 407558 == -139292)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (167478 - 129089 != 38390)
										{
											this.RPC_darkOrb_hit(vector, vector2, num2);
											if (7989 - 512402 == -504413)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 31)
								{
									if (82818 - 478000 != -395181)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (107259 - 291000 == -183741)
										{
											this.StartCoroutine_Auto(this.RPC_gaze(vector, vector2, num2));
											if (268754 - 315920 != -47165)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (49862 - 292049 == -242187)
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

	// Token: 0x06001737 RID: 5943 RVA: 0x002615D4 File Offset: 0x0025F7D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (266581 - 335813 != -69232)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (250371 - 549239 != -298867)
			{
				float runSpeed = this.mChar.runSpeed;
				if (213805 - 202494 != 11312)
				{
					Vector3 a = default(Vector3);
					if (233512 - 538821 != -305308)
					{
						Vector3 vector = Vector3.zero;
						if (165604 - 205868 == -40264)
						{
							float num2 = (float)0;
							if (271370 - 556199 == -284829)
							{
								if (this.mChar.isMine)
								{
									if (30154 - 262646 == -232491)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (158907 - 162145 != -3238)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (143626 - 119718 == 23909)
										{
											continue;
										}
										a.y = (float)0;
										if (206983 - 427105 == -220121)
										{
											continue;
										}
										a = a.normalized;
										if (122641 - 506851 == -384209)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (288165 - 375770 != -87605)
										{
											continue;
										}
										vector = vector.normalized;
										if (281061 - 104444 == 176618)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (133417 - 97676 == 35742)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (206674 - 29638 != 177036)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (199745 - 593488 == -393742)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (14516 - 148151 != -133635)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (103536 - 182803 == -79266)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (264996 - 275766 != -10770)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (197063 - 153151 != 43912)
														{
															continue;
														}
														this.animation.Play("run");
														if (79705 - 388868 == -309162)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (2845 - 206842 != -203996)
														{
															goto IL_2DA;
														}
														continue;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (214709 - 506713 != -292004)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (117903 - 45552 != 72351)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (226313 - 168024 == 58290)
											{
												continue;
											}
											num = (float)0;
											if (262466 - 546590 == -284123)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (282291 - 552491 == -270199)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (63214 - 522913 != -459699)
										{
											continue;
										}
									}
									IL_2DA:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (208134 - 36701 != 171433)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (154855 - 544894 == -390038)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (63420 - 351892 != -288472)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (298437 - 141587 != 156850)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (37502 - 324525 != -287023)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (263852 - 461734 != -197882)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (152676 - 209273 != -56597)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (290182 - 120395 != 169787)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (201994 - 378880 == -176885)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (62820 - 249131 == -186310)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (174267 - 288049 != -113782)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (234750 - 580363 == -345612)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (274259 - 418563 != -144304)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (9344 - 402044 != -392700)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (78307 - 336930 != -258623)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (273622 - 148520 == 125103)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (99058 - 196225 != -97167)
												{
													continue;
												}
												num = (float)0;
												if (114026 - 23087 != 90939)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (106285 - 202910 != -96625)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (273614 - 79207 != 194407)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (281228 - 508643 != -227415)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (121664 - 192246 != -70582)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (21064 - 540960 != -519896)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (191663 - 295398 != -103735)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (148691 - 414075 != -265384)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (274802 - 313176 != -38374)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (81505 - 196754 == -115248)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (207841 - 366651 == -158809)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (210765 - 523771 == -313005)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (18383 - 260136 != -241753)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (226429 - 183525 == 42905)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (17364 - 36149 != -18785)
											{
												continue;
											}
											num = (float)0;
											if (242406 - 174955 == 67452)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (282343 - 548811 == -266467)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (276378 - 255904 != 20474)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (291522 - 404068 != -112546)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (47196 - 565237 != -518041)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (80439 - 222585 != -142145)
								{
									this.mChar.moveSpeed = num;
									if (189594 - 466596 == -277002)
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

	// Token: 0x06001738 RID: 5944 RVA: 0x00262138 File Offset: 0x00260338
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (61129 - 321875 != -260745)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (65944 - 156146 == -90202)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (94543 - 160257 != -65713)
				{
					Vector3 vector = a - this.transform.position;
					if (57914 - 24601 == 33313)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (222532 - 489500 != -266967)
						{
							CharacterControl characterControl = null;
							if (279562 - 289559 != -9996 && 94615 - 463289 != -368673)
							{
								if (gameObject)
								{
									if (11223 - 412598 != -401375)
									{
										continue;
									}
									characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (21077 - 317340 == -296262)
									{
										continue;
									}
								}
								if (characterControl)
								{
									if (9019 - 571865 == -562845)
									{
										continue;
									}
									int actorNr = characterControl.ActorNr;
									if (123350 - 591167 == -467816)
									{
										continue;
									}
								}
								if (!(this.mChar.actionState == "standby"))
								{
									if (282502 - 325187 != -42685)
									{
										continue;
									}
									if (!(this.mChar.actionState == "run"))
									{
										break;
									}
									if (296618 - 303195 != -6577)
									{
										continue;
									}
								}
								if (this.mChar.isTimeOut("nAttack") != (float)0)
								{
									break;
								}
								if (70622 - 99196 == -28574)
								{
									this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, vector, 0));
									if (56829 - 39111 != 17719)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (175297 - 190534 == -15237)
										{
											this.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
											if (204964 - 321709 != -116744)
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

	// Token: 0x06001739 RID: 5945 RVA: 0x00262430 File Offset: 0x00260630
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (254375 - 179463 != 74912)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (161845 - 513878 != -352032)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (215018 - 525104 != -310085)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (173626 - 585918 != -412291)
					{
						Vector3 normalized = vector.normalized;
						if (149176 - 375955 != -226778)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (27833 - 20065 == 7768)
							{
								CharacterControl characterControl = null;
								if (119986 - 269256 == -149270)
								{
									if (267289 - 356393 != -89103)
									{
										if (gameObject)
										{
											if (193200 - 568203 != -375003)
											{
												continue;
											}
											characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (84978 - 11585 == 73394)
											{
												continue;
											}
										}
										if (characterControl)
										{
											if (20074 - 168622 != -148548)
											{
												continue;
											}
											int actorNr = characterControl.ActorNr;
											if (136185 - 258735 != -122550)
											{
												continue;
											}
										}
										if (!(this.mChar.actionState == "standby"))
										{
											if (168950 - 200835 != -31885)
											{
												continue;
											}
											if (!(this.mChar.actionState == "run"))
											{
												break;
											}
											if (39332 - 554313 == -514980)
											{
												continue;
											}
										}
										if (this.mChar.isTimeOut("cAttack") != (float)0)
										{
											break;
										}
										if (8140 - 388920 != -380779)
										{
											this.StartCoroutine_Auto(this.RPC_cAttack(this.transform.position, normalized, 0));
											if (174773 - 3192 != 171582)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (258878 - 206072 != 52807)
												{
													this.ActionEvent("RPC_cAttack", this.transform.position, normalized, 0);
													if (182902 - 18624 == 164278)
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

	// Token: 0x0600173A RID: 5946 RVA: 0x00262750 File Offset: 0x00260950
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x0600173B RID: 5947 RVA: 0x00262754 File Offset: 0x00260954
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Zerbiras.$RPC_nAttack$19154(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x0600173C RID: 5948 RVA: 0x00262764 File Offset: 0x00260964
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (251776 - 322871 != -71095)
		{
		}
		for (;;)
		{
			if (this.nAttack_hit)
			{
				if (26057 - 26491 != -433)
				{
					UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, Quaternion.LookRotation(hitDir));
					if (250884 - 81246 == 169638)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find nAttack_hit effect");
				if (272617 - 325306 != -52688)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600173D RID: 5949 RVA: 0x0026281C File Offset: 0x00260A1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_cAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Zerbiras.$RPC_cAttack$19167(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x0600173E RID: 5950 RVA: 0x0026282C File Offset: 0x00260A2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_cAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (267131 - 15941 != 251190)
		{
		}
		for (;;)
		{
			if (this.cAttack_hit)
			{
				if (244754 - 407897 != -163142)
				{
					UnityEngine.Object.Instantiate(this.cAttack_hit, hitPos, Quaternion.LookRotation(hitDir));
					if (111562 - 201275 == -89713)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find cAttack_hit effect");
				if (36882 - 506598 == -469716)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600173F RID: 5951 RVA: 0x002628E4 File Offset: 0x00260AE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_darkOrb(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Zerbiras.$RPC_darkOrb$19186(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06001740 RID: 5952 RVA: 0x002628F4 File Offset: 0x00260AF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_darkOrb_fire(Vector3 firePos, Vector3 fireDir, int tID)
	{
		if (162539 - 399379 != -236840)
		{
		}
		for (;;)
		{
			if (this.darkOrb)
			{
				if (44899 - 130958 != -86058)
				{
					GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(this.darkOrb, firePos, Quaternion.LookRotation(fireDir));
					if (190362 - 18183 == 172179)
					{
						ProjectileControl projectileControl = (ProjectileControl)gameObject.GetComponent(typeof(ProjectileControl));
						if (69112 - 44036 != 25077)
						{
							projectileControl.Init(this.mChar.ActorNr);
							if (63970 - 455842 != -391871)
							{
								projectileControl.life = (float)5 * this.mChar.rangeMod;
								if (151268 - 7919 == 143349)
								{
									GameObject gameObject2 = null;
									if (29 - 97813 != -97783)
									{
										if (tID != 0)
										{
											if (235980 - 593265 == -357284)
											{
												continue;
											}
											if (tID != this.mChar.ActorNr)
											{
												if (100420 - 249679 == -149258)
												{
													continue;
												}
												object obj2;
												object obj = obj2 = PhotonClient.ActorNrList[tID];
												if (!(obj is GameObject))
												{
													obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
												}
												gameObject2 = (GameObject)obj2;
												if (193922 - 285153 != -91231)
												{
													continue;
												}
											}
										}
										if (!gameObject2)
										{
											break;
										}
										if (103788 - 98617 != 5172)
										{
											Zerbiras_darkOrb zerbiras_darkOrb = (Zerbiras_darkOrb)gameObject.GetComponent(typeof(Zerbiras_darkOrb));
											if (125181 - 437476 != -312294)
											{
												zerbiras_darkOrb.mTarget = gameObject2;
												if (56188 - 497320 != -441131)
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
			else
			{
				Debug.LogError("Cannot find darkOrb Effect");
				if (34196 - 392474 != -358277)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06001741 RID: 5953 RVA: 0x00262B64 File Offset: 0x00260D64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_darkOrb_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (32589 - 217452 != -184862)
		{
		}
		for (;;)
		{
			if (this.darkOrb_hit)
			{
				if (93162 - 109505 == -16343)
				{
					UnityEngine.Object.Instantiate(this.darkOrb_hit, hitPos, this.transform.rotation);
					if (194679 - 53455 != 141225)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find darkOrb Effect");
				if (277315 - 169934 == 107381)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06001742 RID: 5954 RVA: 0x00262C24 File Offset: 0x00260E24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_gaze(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Zerbiras.$RPC_gaze$19201(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06001743 RID: 5955 RVA: 0x00262C34 File Offset: 0x00260E34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new Zerbiras.$RPC_ko$19213(nArray, this).GetEnumerator();
	}

	// Token: 0x06001744 RID: 5956 RVA: 0x00262C44 File Offset: 0x00260E44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new Zerbiras.$RPC_dead$19220(nArray, this).GetEnumerator();
	}

	// Token: 0x06001745 RID: 5957 RVA: 0x00262C54 File Offset: 0x00260E54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06001746 RID: 5958 RVA: 0x00262C58 File Offset: 0x00260E58
	internal static bool Optu8uMzIkUTd0cbC7g()
	{
		return true;
	}

	// Token: 0x06001747 RID: 5959 RVA: 0x00262C5C File Offset: 0x00260E5C
	internal static bool Q6R52pxa6yqW7RTfFW6()
	{
		return false;
	}

	// Token: 0x040013BE RID: 5054
	public CharacterControl mChar;

	// Token: 0x040013BF RID: 5055
	public AudioClip nAttack_fx;

	// Token: 0x040013C0 RID: 5056
	public GameObject nAttack_hit;

	// Token: 0x040013C1 RID: 5057
	public GameObject cAttack_ring;

	// Token: 0x040013C2 RID: 5058
	public GameObject cAttack_hit;

	// Token: 0x040013C3 RID: 5059
	public GameObject darkOrb_ring;

	// Token: 0x040013C4 RID: 5060
	public GameObject darkOrb;

	// Token: 0x040013C5 RID: 5061
	public GameObject darkOrb_hit;

	// Token: 0x040013C6 RID: 5062
	public GameObject gaze_ring;

	// Token: 0x040013C7 RID: 5063
	public AudioClip gaze_fx;

	// Token: 0x020003E1 RID: 993
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$19154 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001748 RID: 5960 RVA: 0x00262C60 File Offset: 0x00260E60
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$19154(Vector3 mPos, Vector3 tDir, Zerbiras self_)
		{
			if (1425 - 263281 != -261855)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (286955 - 186383 != 100573)
				{
					base..ctor();
					if (273216 - 559311 == -286095)
					{
						this.$mPos$19164 = mPos;
						if (21597 - 494668 == -473071)
						{
							this.$tDir$19165 = tDir;
							if (72773 - 216592 != -143818)
							{
								this.$self_$19166 = self_;
								if (211530 - 167031 == 44499)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001749 RID: 5961 RVA: 0x00262D3C File Offset: 0x00260F3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Zerbiras.$RPC_nAttack$19154.$(this.$mPos$19164, this.$tDir$19165, this.$self_$19166);
		}

		// Token: 0x0600174A RID: 5962 RVA: 0x00262D58 File Offset: 0x00260F58
		internal static bool Yf7K2Sx5OlhWodGqd0F()
		{
			return true;
		}

		// Token: 0x0600174B RID: 5963 RVA: 0x00262D5C File Offset: 0x00260F5C
		internal static bool trdo3RxpyvRR9EMBfn6()
		{
			return false;
		}

		// Token: 0x040013C8 RID: 5064
		internal Vector3 $mPos$19164;

		// Token: 0x040013C9 RID: 5065
		internal Vector3 $tDir$19165;

		// Token: 0x040013CA RID: 5066
		internal Zerbiras $self_$19166;

		// Token: 0x020003E2 RID: 994
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600174C RID: 5964 RVA: 0x00262D60 File Offset: 0x00260F60
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Zerbiras self_)
			{
				if (110881 - 499271 != -388390)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (9627 - 384711 == -375084)
					{
						base..ctor();
						if (279030 - 220753 != 58278)
						{
							this.$mPos$19161 = mPos;
							if (198392 - 372591 == -174199)
							{
								this.$tDir$19162 = tDir;
								if (186383 - 256263 != -69879)
								{
									this.$self_$19163 = self_;
									if (238499 - 122616 != 115884)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x0600174D RID: 5965 RVA: 0x00262E3C File Offset: 0x0026103C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (17897 - 515292 != -497394)
				{
				}
				for (;;)
				{
					IL_83:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_97C;
					case 2:
						if (this.$self_$19163.mChar.actionState != "attack")
						{
							goto IL_30F;
						}
						if (129421 - 524851 != -395430)
						{
							continue;
						}
						if (this.$self_$19163.mChar.myCommand != "nAttack")
						{
							if (65666 - 493350 != -427684)
							{
								continue;
							}
							goto IL_30F;
						}
						else
						{
							this.$i$19155 = 0;
							if (139163 - 17080 != 122084)
							{
								goto IL_68C;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$19163.mChar.actionState != "attack")
						{
							goto IL_4F;
						}
						if (26929 - 238446 == -211516)
						{
							continue;
						}
						if (this.$self_$19163.mChar.myCommand != "nAttack")
						{
							if (268257 - 84744 != 183514)
							{
								goto Block_23;
							}
							continue;
						}
						else
						{
							if (this.$self_$19163.mChar.isMine)
							{
								if (175616 - 141851 != 33765)
								{
									continue;
								}
								this.$hitLayer$19156 = 130816 - (1 << this.$self_$19163.gameObject.layer);
								if (233333 - 329081 == -95747)
								{
									continue;
								}
								this.$hitList$19157 = Damage.FindRecTarget(this.$self_$19163.transform.position, this.$self_$19163.transform.forward, (float)2, (float)(1 + this.$i$19155), (float)(3 + this.$i$19155), (float)3, this.$hitLayer$19156);
								if (265159 - 450451 != -185292)
								{
									continue;
								}
								this.$$iterator$10507$19160 = UnityRuntimeServices.GetEnumerator(this.$hitList$19157);
								if (266197 - 89642 == 176556)
								{
									continue;
								}
								while (this.$$iterator$10507$19160.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$10507$19160.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$19158 = (GameObject)obj2;
									if (48526 - 575508 == -526981)
									{
										goto IL_83;
									}
									if (this.$self_$19163.mChar.hit(1, this.$hitObject$19158, (int)(0.75f * (float)this.$self_$19163.mChar.atk + (float)(this.$i$19155 * 45)), 1, 0, (float)2 * this.$self_$19163.transform.forward) != 0)
									{
										if (101140 - 138679 == -37538)
										{
											goto IL_83;
										}
										this.$hitPos$19159 = this.$hitObject$19158.collider.ClosestPointOnBounds(this.$self_$19163.transform.position + this.$self_$19163.transform.TransformDirection((float)1, 1.5f, 2.5f));
										if (164686 - 397789 != -233103)
										{
											goto IL_83;
										}
										UnityRuntimeServices.Update(this.$$iterator$10507$19160, this.$hitObject$19158);
										if (44654 - 550081 != -505427)
										{
											goto IL_83;
										}
										this.$self_$19163.RPC_nAttack_hit(this.$hitPos$19159, this.$self_$19163.transform.forward, 0);
										if (299656 - 34915 != 264741)
										{
											goto IL_83;
										}
										if (PhotonClient.IsInitialized())
										{
											if (143804 - 80971 == 62834)
											{
												goto IL_83;
											}
											this.$self_$19163.ActionEvent("RPC_nAttack_hit", this.$hitPos$19159, this.$self_$19163.transform.forward, 0);
											if (291220 - 129541 == 161680)
											{
												goto IL_83;
											}
										}
									}
								}
								if (152462 - 251315 == -98852)
								{
									continue;
								}
							}
							this.$i$19155++;
							if (56361 - 294604 != -238242)
							{
								goto IL_68C;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$19163.mChar.actionState == "attack")
						{
							if (189941 - 471163 != -281222)
							{
								continue;
							}
							if (this.$self_$19163.mChar.myCommand == "nAttack")
							{
								if (110168 - 204862 == -94693)
								{
									continue;
								}
								this.$self_$19163.mChar.actionState = "standby";
								if (91011 - 17137 != 73874)
								{
									continue;
								}
								this.$self_$19163.mChar.actionTime = Time.time;
								if (235830 - 477941 == -242110)
								{
									continue;
								}
								this.$self_$19163.mChar.myCommand = "none";
								if (195277 - 374735 != -179458)
								{
									continue;
								}
								if (!this.$self_$19163.mChar.isMine)
								{
									if (180661 - 85275 == 95387)
									{
										continue;
									}
									this.$self_$19163.mChar.nPosition = this.$self_$19163.transform.position;
									if (79940 - 333621 != -253681)
									{
										continue;
									}
									this.$self_$19163.mChar.oPosition = this.$self_$19163.transform.position;
									if (259141 - 76705 != 182436)
									{
										continue;
									}
									this.$self_$19163.mChar.nDirection = this.$self_$19163.transform.forward;
									if (19808 - 524855 == -505046)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (158713 - 404579 != -245865)
						{
							goto Block_12;
						}
						continue;
					default:
						if (216787 - 356334 != -139547)
						{
							continue;
						}
						break;
					}
					this.$self_$19163.mChar.actionState = "attack";
					if (42098 - 272191 != -230093)
					{
						continue;
					}
					this.$self_$19163.mChar.actionTime = Time.time;
					if (179097 - 507730 != -328633)
					{
						continue;
					}
					this.$self_$19163.mChar.myCommand = "nAttack";
					if (270493 - 519740 != -249247)
					{
						continue;
					}
					this.$self_$19163.mChar.addTimeOut("nAttack", (float)1);
					if (17855 - 288253 == -270397)
					{
						continue;
					}
					this.$self_$19163.transform.position = this.$mPos$19161;
					if (185930 - 276138 != -90208)
					{
						continue;
					}
					this.$self_$19163.transform.LookAt(this.$mPos$19161 + global::Math.vFlat(this.$tDir$19162));
					if (290499 - 77253 != 213246)
					{
						continue;
					}
					this.$self_$19163.animation.Play("nAttack");
					if (220395 - 258660 != -38265)
					{
						continue;
					}
					this.$self_$19163.animation.wrapMode = WrapMode.Once;
					if (286434 - 510586 != -224152)
					{
						continue;
					}
					this.$self_$19163.mChar.vMovement = this.$self_$19163.transform.forward;
					if (133894 - 531015 == -397120)
					{
						continue;
					}
					this.$self_$19163.mChar.moveSpeed = (float)0;
					if (272822 - 353686 != -80864)
					{
						continue;
					}
					if (this.$self_$19163.nAttack_fx)
					{
						if (98958 - 476858 != -377900)
						{
							continue;
						}
						this.$self_$19163.audio.PlayOneShot(this.$self_$19163.nAttack_fx);
						if (64623 - 558556 != -493932)
						{
							break;
						}
						continue;
					}
					else
					{
						Debug.LogError("Cannot find nAttack_fx effect");
						if (161458 - 351235 != -189777)
						{
							continue;
						}
						break;
					}
					IL_68C:
					if (this.$i$19155 < 2)
					{
						goto IL_63D;
					}
					if (166976 - 293242 == -126266)
					{
						goto IL_8C1;
					}
				}
				goto IL_557;
				IL_4F:
				goto IL_97C;
				Block_12:
				IL_30F:
				Block_23:
				goto IL_4F;
				IL_557:
				return this.Yield(2, new WaitForSeconds(0.1f));
				IL_63D:
				return this.Yield(3, new WaitForSeconds(0.3f));
				IL_8C1:
				return this.Yield(4, new WaitForSeconds(0.3f));
				IL_97C:
				return false;
			}

			// Token: 0x0600174E RID: 5966 RVA: 0x002637D8 File Offset: 0x002619D8
			internal static bool Yage4OxVuGN0Yd961wD()
			{
				return true;
			}

			// Token: 0x0600174F RID: 5967 RVA: 0x002637DC File Offset: 0x002619DC
			internal static bool rTNe6nxtbwZskZgBjw4()
			{
				return false;
			}

			// Token: 0x040013CB RID: 5067
			internal int $i$19155;

			// Token: 0x040013CC RID: 5068
			internal int $hitLayer$19156;

			// Token: 0x040013CD RID: 5069
			internal UnityScript.Lang.Array $hitList$19157;

			// Token: 0x040013CE RID: 5070
			internal GameObject $hitObject$19158;

			// Token: 0x040013CF RID: 5071
			internal Vector3 $hitPos$19159;

			// Token: 0x040013D0 RID: 5072
			internal IEnumerator $$iterator$10507$19160;

			// Token: 0x040013D1 RID: 5073
			internal Vector3 $mPos$19161;

			// Token: 0x040013D2 RID: 5074
			internal Vector3 $tDir$19162;

			// Token: 0x040013D3 RID: 5075
			internal Zerbiras $self_$19163;
		}
	}

	// Token: 0x020003E3 RID: 995
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_cAttack$19167 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001750 RID: 5968 RVA: 0x002637E0 File Offset: 0x002619E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_cAttack$19167(Vector3 mPos, Vector3 tDir, Zerbiras self_)
		{
			if (61225 - 490933 != -429708)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (38192 - 533406 == -495214)
				{
					base..ctor();
					if (260477 - 160208 == 100269)
					{
						this.$mPos$19183 = mPos;
						if (82032 - 394551 != -312518)
						{
							this.$tDir$19184 = tDir;
							if (36999 - 208776 != -171776)
							{
								this.$self_$19185 = self_;
								if (246704 - 206950 != 39755)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001751 RID: 5969 RVA: 0x002638BC File Offset: 0x00261ABC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Zerbiras.$RPC_cAttack$19167.$(this.$mPos$19183, this.$tDir$19184, this.$self_$19185);
		}

		// Token: 0x06001752 RID: 5970 RVA: 0x002638D8 File Offset: 0x00261AD8
		internal static bool OFcqSGxNrLqbGukNX9K()
		{
			return true;
		}

		// Token: 0x06001753 RID: 5971 RVA: 0x002638DC File Offset: 0x00261ADC
		internal static bool oYehhmxYo21aCNFDS4F()
		{
			return false;
		}

		// Token: 0x040013D4 RID: 5076
		internal Vector3 $mPos$19183;

		// Token: 0x040013D5 RID: 5077
		internal Vector3 $tDir$19184;

		// Token: 0x040013D6 RID: 5078
		internal Zerbiras $self_$19185;

		// Token: 0x020003E4 RID: 996
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001754 RID: 5972 RVA: 0x002638E0 File Offset: 0x00261AE0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Zerbiras self_)
			{
				if (76310 - 157067 != -80757)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (9659 - 437863 != -428203)
					{
						base..ctor();
						if (197161 - 188966 == 8195)
						{
							this.$mPos$19180 = mPos;
							if (117171 - 149182 != -32010)
							{
								this.$tDir$19181 = tDir;
								if (152805 - 8477 != 144329)
								{
									this.$self_$19182 = self_;
									if (45761 - 306743 != -260981)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06001755 RID: 5973 RVA: 0x002639BC File Offset: 0x00261BBC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (177975 - 584876 != -406901)
				{
				}
				for (;;)
				{
					IL_1A:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_D89;
					case 2:
						if (this.$self_$19182.mChar.actionState != "attack")
						{
							goto IL_476;
						}
						if (176998 - 52549 != 124449)
						{
							continue;
						}
						if (this.$self_$19182.mChar.myCommand != "cAttack")
						{
							if (202175 - 273111 != -70936)
							{
								continue;
							}
							goto IL_476;
						}
						else
						{
							if (this.$self_$19182.cAttack_ring)
							{
								if (196324 - 87547 == 108778)
								{
									continue;
								}
								this.$self_$19182.mChar.createEffect(this.$self_$19182.cAttack_ring, this.$self_$19182.transform.position, this.$self_$19182.transform.rotation);
								if (246126 - 170056 == 76071)
								{
									continue;
								}
							}
							this.$self_$19182.mChar.moveSpeed = (float)24;
							if (219480 - 187765 != 31715)
							{
								continue;
							}
							this.$ignoreLayer$19168 = 130818;
							if (123637 - 303631 == -179993)
							{
								continue;
							}
							this.$ignoreList$19169 = Damage.FindAreaTarget(this.$self_$19182.transform.position, (float)40, (float)4, this.$ignoreLayer$19168);
							if (50079 - 174834 == -124754)
							{
								continue;
							}
							this.$$iterator$10508$19171 = UnityRuntimeServices.GetEnumerator(this.$ignoreList$19169);
							if (260427 - 47496 != 212931)
							{
								continue;
							}
							while (this.$$iterator$10508$19171.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10508$19171.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$ignoreObject$19170 = (GameObject)obj2;
								if (214618 - 420310 != -205692)
								{
									goto IL_1A;
								}
								if (this.$ignoreObject$19170)
								{
									if (289649 - 225487 != 64162)
									{
										goto IL_1A;
									}
									if (this.$self_$19182.gameObject != this.$ignoreObject$19170)
									{
										if (102682 - 580932 == -478249)
										{
											goto IL_1A;
										}
										Physics.IgnoreCollision(this.$self_$19182.gameObject.collider, this.$ignoreObject$19170.collider, true);
										if (115070 - 480363 == -365292)
										{
											goto IL_1A;
										}
										UnityRuntimeServices.Update(this.$$iterator$10508$19171, this.$ignoreObject$19170);
										if (118826 - 330565 != -211739)
										{
											goto IL_1A;
										}
									}
								}
							}
							if (128259 - 93476 != 34783)
							{
								continue;
							}
							this.$i$19172 = 0;
							if (84241 - 441130 != -356889)
							{
								continue;
							}
							goto IL_5CA;
						}
						break;
					case 3:
						if (this.$self_$19182.mChar.actionState != "attack")
						{
							goto IL_BA6;
						}
						if (146505 - 402148 != -255643)
						{
							continue;
						}
						if (this.$self_$19182.mChar.myCommand != "cAttack")
						{
							if (222164 - 537246 != -315081)
							{
								goto Block_62;
							}
							continue;
						}
						else
						{
							this.$i$19172++;
							if (89901 - 198453 != -108552)
							{
								continue;
							}
							goto IL_5CA;
						}
						break;
					case 4:
						if (this.$self_$19182.mChar.actionState != "attack")
						{
							goto IL_239;
						}
						if (95489 - 17733 == 77757)
						{
							continue;
						}
						if (this.$self_$19182.mChar.myCommand != "cAttack")
						{
							if (202816 - 80447 != 122369)
							{
								continue;
							}
							goto IL_239;
						}
						else
						{
							this.$self_$19182.mChar.moveSpeed = (float)0;
							if (14211 - 109422 != -95211)
							{
								continue;
							}
							this.$$iterator$10510$19179 = UnityRuntimeServices.GetEnumerator(this.$ignoreList$19169);
							if (121431 - 259728 != -138297)
							{
								continue;
							}
							while (this.$$iterator$10510$19179.MoveNext())
							{
								object obj4;
								object obj3 = obj4 = this.$$iterator$10510$19179.Current;
								if (!(obj3 is GameObject))
								{
									obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
								}
								this.$ignoreObject$19178 = (GameObject)obj4;
								if (200965 - 123584 == 77382)
								{
									goto IL_1A;
								}
								if (this.$ignoreObject$19178)
								{
									if (30429 - 222454 != -192025)
									{
										goto IL_1A;
									}
									if (this.$self_$19182.gameObject != this.$ignoreObject$19178)
									{
										if (200050 - 19171 != 180879)
										{
											goto IL_1A;
										}
										Physics.IgnoreCollision(this.$self_$19182.gameObject.collider, this.$ignoreObject$19178.collider, false);
										if (47763 - 108998 == -61234)
										{
											goto IL_1A;
										}
										UnityRuntimeServices.Update(this.$$iterator$10510$19179, this.$ignoreObject$19178);
										if (24512 - 103513 == -79000)
										{
											goto IL_1A;
										}
									}
								}
							}
							if (112977 - 82984 != 29994)
							{
								goto Block_45;
							}
							continue;
						}
						break;
					case 5:
						if (this.$self_$19182.mChar.actionState == "attack")
						{
							if (63677 - 49246 == 14432)
							{
								continue;
							}
							if (this.$self_$19182.mChar.myCommand == "cAttack")
							{
								if (263603 - 233329 == 30275)
								{
									continue;
								}
								this.$self_$19182.mChar.actionState = "standby";
								if (112948 - 19941 == 93008)
								{
									continue;
								}
								this.$self_$19182.mChar.actionTime = Time.time;
								if (167629 - 527557 == -359927)
								{
									continue;
								}
								this.$self_$19182.mChar.myCommand = "none";
								if (296467 - 101297 != 195170)
								{
									continue;
								}
								if (!this.$self_$19182.mChar.isMine)
								{
									if (140721 - 242439 == -101717)
									{
										continue;
									}
									this.$self_$19182.mChar.nPosition = this.$self_$19182.transform.position;
									if (207557 - 226674 != -19117)
									{
										continue;
									}
									this.$self_$19182.mChar.oPosition = this.$self_$19182.transform.position;
									if (175374 - 473355 != -297981)
									{
										continue;
									}
									this.$self_$19182.mChar.nDirection = this.$self_$19182.transform.forward;
									if (240124 - 228422 == 11703)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (14300 - 599737 != -585436)
						{
							goto Block_82;
						}
						continue;
					default:
						if (83350 - 99675 != -16325)
						{
							continue;
						}
						break;
					}
					this.$self_$19182.mChar.actionState = "attack";
					if (299956 - 433604 != -133648)
					{
						continue;
					}
					this.$self_$19182.mChar.actionTime = Time.time;
					if (13347 - 150931 != -137584)
					{
						continue;
					}
					this.$self_$19182.mChar.myCommand = "cAttack";
					if (35003 - 18904 != 16099)
					{
						continue;
					}
					this.$self_$19182.mChar.addTimeOut("cAttack", (float)6);
					if (248820 - 142801 == 106020)
					{
						continue;
					}
					this.$self_$19182.transform.position = this.$mPos$19180;
					if (23938 - 220079 != -196141)
					{
						continue;
					}
					this.$self_$19182.transform.LookAt(this.$mPos$19180 + global::Math.vFlat(this.$tDir$19181));
					if (201782 - 494093 == -292310)
					{
						continue;
					}
					this.$self_$19182.animation.Play("cAttack");
					if (261829 - 568904 != -307075)
					{
						continue;
					}
					this.$self_$19182.animation.wrapMode = WrapMode.Once;
					if (177842 - 85326 != 92516)
					{
						continue;
					}
					this.$self_$19182.mChar.vMovement = this.$self_$19182.transform.forward;
					if (128157 - 551769 == -423611)
					{
						continue;
					}
					this.$self_$19182.mChar.moveSpeed = (float)0;
					if (198656 - 91113 != 107543)
					{
						continue;
					}
					goto IL_654;
					IL_5CA:
					if (this.$i$19172 >= 4)
					{
						if (268169 - 38274 != 229896)
						{
							goto Block_34;
						}
					}
					else
					{
						if (!this.$self_$19182.mChar.isMine)
						{
							goto IL_AD4;
						}
						if (45506 - 279829 == -234323)
						{
							this.$hitLayer$19173 = 130816 - (1 << this.$self_$19182.gameObject.layer);
							if (23504 - 365030 != -341525)
							{
								this.$hitList$19174 = Damage.FindRecTarget(this.$self_$19182.transform.position - this.$self_$19182.transform.forward, this.$self_$19182.transform.forward, (float)2, (float)2, (float)3, (float)3 * this.$self_$19182.mChar.rangeMod, this.$hitLayer$19173);
								if (148612 - 73209 == 75403)
								{
									this.$$iterator$10509$19177 = UnityRuntimeServices.GetEnumerator(this.$hitList$19174);
									if (169696 - 244219 != -74522)
									{
										while (this.$$iterator$10509$19177.MoveNext())
										{
											object obj6;
											object obj5 = obj6 = this.$$iterator$10509$19177.Current;
											if (!(obj5 is GameObject))
											{
												obj6 = RuntimeServices.Coerce(obj5, typeof(GameObject));
											}
											this.$hitObject$19175 = (GameObject)obj6;
											if (277784 - 20880 != 256904)
											{
												goto IL_1A;
											}
											if (this.$self_$19182.mChar.hit(11, this.$hitObject$19175, (int)(0.5f * (float)this.$self_$19182.mChar.atk + (float)this.$self_$19182.mChar.talAdjust(60)), 0, 0, 0.5f * this.$self_$19182.transform.forward) != 0)
											{
												if (209600 - 20485 != 189115)
												{
													goto IL_1A;
												}
												this.$hitPos$19176 = this.$hitObject$19175.collider.ClosestPointOnBounds(this.$self_$19182.transform.position + 1.5f * Vector3.up);
												if (274321 - 314836 == -40514)
												{
													goto IL_1A;
												}
												UnityRuntimeServices.Update(this.$$iterator$10509$19177, this.$hitObject$19175);
												if (203750 - 572501 == -368750)
												{
													goto IL_1A;
												}
												this.$self_$19182.RPC_cAttack_hit(this.$hitPos$19176, this.$self_$19182.transform.forward, 0);
												if (57832 - 271338 != -213506)
												{
													goto IL_1A;
												}
												this.$self_$19182.ActionEvent("RPC_cAttack_hit", this.$hitPos$19176, this.$self_$19182.transform.forward, 0);
												if (100137 - 400071 != -299934)
												{
													goto IL_1A;
												}
											}
										}
										if (60629 - 594557 == -533928)
										{
											goto IL_AD4;
										}
									}
								}
							}
						}
					}
				}
				IL_239:
				IL_476:
				goto IL_D89;
				Block_34:
				return this.Yield(4, new WaitForSeconds(0.1f));
				IL_654:
				return this.Yield(2, new WaitForSeconds(0.3f));
				Block_45:
				return this.Yield(5, new WaitForSeconds(0.1f));
				Block_62:
				goto IL_BA6;
				IL_AD4:
				return this.Yield(3, new WaitForSeconds(0.1f));
				IL_BA6:
				Block_82:
				IL_D89:
				return false;
			}

			// Token: 0x06001756 RID: 5974 RVA: 0x00264764 File Offset: 0x00262964
			internal static bool EC9j8ExcOAnTBJcKQ12()
			{
				return true;
			}

			// Token: 0x06001757 RID: 5975 RVA: 0x00264768 File Offset: 0x00262968
			internal static bool YJuwp9xUlJG2d0WwuBn()
			{
				return false;
			}

			// Token: 0x040013D7 RID: 5079
			internal int $ignoreLayer$19168;

			// Token: 0x040013D8 RID: 5080
			internal UnityScript.Lang.Array $ignoreList$19169;

			// Token: 0x040013D9 RID: 5081
			internal GameObject $ignoreObject$19170;

			// Token: 0x040013DA RID: 5082
			internal IEnumerator $$iterator$10508$19171;

			// Token: 0x040013DB RID: 5083
			internal int $i$19172;

			// Token: 0x040013DC RID: 5084
			internal int $hitLayer$19173;

			// Token: 0x040013DD RID: 5085
			internal UnityScript.Lang.Array $hitList$19174;

			// Token: 0x040013DE RID: 5086
			internal GameObject $hitObject$19175;

			// Token: 0x040013DF RID: 5087
			internal Vector3 $hitPos$19176;

			// Token: 0x040013E0 RID: 5088
			internal IEnumerator $$iterator$10509$19177;

			// Token: 0x040013E1 RID: 5089
			internal GameObject $ignoreObject$19178;

			// Token: 0x040013E2 RID: 5090
			internal IEnumerator $$iterator$10510$19179;

			// Token: 0x040013E3 RID: 5091
			internal Vector3 $mPos$19180;

			// Token: 0x040013E4 RID: 5092
			internal Vector3 $tDir$19181;

			// Token: 0x040013E5 RID: 5093
			internal Zerbiras $self_$19182;
		}
	}

	// Token: 0x020003E5 RID: 997
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_darkOrb$19186 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001758 RID: 5976 RVA: 0x0026476C File Offset: 0x0026296C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_darkOrb$19186(Vector3 mPos, Vector3 tDir, Zerbiras self_)
		{
			if (257905 - 284558 != -26652)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (15427 - 268125 != -252697)
				{
					base..ctor();
					if (289046 - 400929 != -111882)
					{
						this.$mPos$19198 = mPos;
						if (293095 - 125144 == 167951)
						{
							this.$tDir$19199 = tDir;
							if (160695 - 408126 != -247430)
							{
								this.$self_$19200 = self_;
								if (265214 - 245879 == 19335)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001759 RID: 5977 RVA: 0x00264848 File Offset: 0x00262A48
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Zerbiras.$RPC_darkOrb$19186.$(this.$mPos$19198, this.$tDir$19199, this.$self_$19200);
		}

		// Token: 0x0600175A RID: 5978 RVA: 0x00264864 File Offset: 0x00262A64
		internal static bool qjpvuSxThPXCNOjUosm()
		{
			return true;
		}

		// Token: 0x0600175B RID: 5979 RVA: 0x00264868 File Offset: 0x00262A68
		internal static bool CvLxR6x3Ty2fcZTeV8M()
		{
			return false;
		}

		// Token: 0x040013E6 RID: 5094
		internal Vector3 $mPos$19198;

		// Token: 0x040013E7 RID: 5095
		internal Vector3 $tDir$19199;

		// Token: 0x040013E8 RID: 5096
		internal Zerbiras $self_$19200;

		// Token: 0x020003E6 RID: 998
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600175C RID: 5980 RVA: 0x0026486C File Offset: 0x00262A6C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Zerbiras self_)
			{
				if (90744 - 417149 != -326404)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (35704 - 97559 != -61854)
					{
						base..ctor();
						if (42163 - 307858 != -265694)
						{
							this.$mPos$19195 = mPos;
							if (70897 - 471091 == -400194)
							{
								this.$tDir$19196 = tDir;
								if (248543 - 54316 == 194227)
								{
									this.$self_$19197 = self_;
									if (263909 - 332120 != -68210)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x0600175D RID: 5981 RVA: 0x00264948 File Offset: 0x00262B48
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (57610 - 410095 != -352484)
				{
				}
				for (;;)
				{
					IL_38A:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_95E;
					case 2:
						if (this.$self_$19197.mChar.actionState != "attack")
						{
							goto IL_2FF;
						}
						if (47533 - 420349 != -372816)
						{
							continue;
						}
						if (this.$self_$19197.mChar.myCommand != "darkOrb")
						{
							if (126671 - 138658 != -11987)
							{
								continue;
							}
							goto IL_2FF;
						}
						else
						{
							if (!this.$self_$19197.mChar.isMine)
							{
								goto IL_701;
							}
							if (169267 - 157219 == 12049)
							{
								continue;
							}
							this.$targetLayer$19187 = 130816 - (1 << this.$self_$19197.gameObject.layer) + 2 + 4;
							if (126806 - 274741 == -147934)
							{
								continue;
							}
							this.$targetList$19188 = Damage.RemoveDeadChar(Damage.FindAreaTarget(this.$self_$19197.transform.position, (float)20, (float)10, this.$targetLayer$19187));
							if (205394 - 249554 != -44160)
							{
								continue;
							}
							this.$i$19189 = 0;
							if (140194 - 565470 != -425276)
							{
								continue;
							}
							while (this.$i$19189 < 3)
							{
								this.$targetID$19190 = 0;
								if (106022 - 83037 == 22986)
								{
									goto IL_38A;
								}
								if (this.$targetList$19188.length > 0)
								{
									if (34230 - 300333 != -266103)
									{
										goto IL_38A;
									}
									object obj2;
									object obj = obj2 = this.$targetList$19188[UnityEngine.Random.Range(0, this.$targetList$19188.length)];
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$tObject$19191 = (GameObject)obj2;
									if (299895 - 183312 != 116583)
									{
										goto IL_38A;
									}
									if (this.$tObject$19191)
									{
										if (4379 - 428388 != -424009)
										{
											goto IL_38A;
										}
										this.$tChar$19192 = (CharacterControl)this.$tObject$19191.GetComponent(typeof(CharacterControl));
										if (191250 - 166160 == 25091)
										{
											goto IL_38A;
										}
									}
									if (this.$tChar$19192)
									{
										if (49472 - 43786 != 5686)
										{
											goto IL_38A;
										}
										this.$targetID$19190 = this.$tChar$19192.ActorNr;
										if (4990 - 348550 == -343559)
										{
											goto IL_38A;
										}
									}
								}
								this.$firePos$19193 = this.$self_$19197.transform.position + this.$self_$19197.transform.TransformDirection((float)(this.$i$19189 * 1 - 1), (this.$i$19189 != 1) ? ((float)5) : 6.5f, (float)4);
								if (154975 - 341866 != -186891)
								{
									goto IL_38A;
								}
								this.$fireDir$19194 = global::Math.rotateH(this.$self_$19197.transform.forward, (float)(30 * this.$i$19189 - 30)).normalized;
								if (286931 - 314779 != -27848)
								{
									goto IL_38A;
								}
								this.$self_$19197.RPC_darkOrb_fire(this.$firePos$19193, this.$fireDir$19194, this.$targetID$19190);
								if (140105 - 177824 != -37719)
								{
									goto IL_38A;
								}
								if (PhotonClient.IsInitialized())
								{
									if (232856 - 463154 != -230298)
									{
										goto IL_38A;
									}
									this.$self_$19197.ActionEvent("RPC_darkOrb_fire", this.$firePos$19193, this.$fireDir$19194, this.$targetID$19190);
									if (95792 - 130659 == -34866)
									{
										goto IL_38A;
									}
								}
								this.$i$19189++;
								if (204158 - 37468 == 166691)
								{
									goto IL_38A;
								}
							}
							if (199572 - 443831 != -244259)
							{
								continue;
							}
							goto IL_701;
						}
						break;
					case 3:
						if (this.$self_$19197.mChar.actionState == "attack")
						{
							if (243813 - 40357 == 203457)
							{
								continue;
							}
							if (this.$self_$19197.mChar.myCommand == "darkOrb")
							{
								if (282599 - 183185 == 99415)
								{
									continue;
								}
								this.$self_$19197.mChar.actionState = "standby";
								if (225714 - 16998 != 208716)
								{
									continue;
								}
								this.$self_$19197.mChar.actionTime = Time.time;
								if (143834 - 214102 == -70267)
								{
									continue;
								}
								this.$self_$19197.mChar.myCommand = "none";
								if (211148 - 91153 == 119996)
								{
									continue;
								}
								if (!this.$self_$19197.mChar.isMine)
								{
									if (295820 - 89985 != 205835)
									{
										continue;
									}
									this.$self_$19197.mChar.nPosition = this.$self_$19197.transform.position;
									if (293165 - 298294 == -5128)
									{
										continue;
									}
									this.$self_$19197.mChar.oPosition = this.$self_$19197.transform.position;
									if (294337 - 204015 == 90323)
									{
										continue;
									}
									this.$self_$19197.mChar.nDirection = this.$self_$19197.transform.forward;
									if (107913 - 595861 == -487947)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (58883 - 522182 != -463299)
						{
							continue;
						}
						goto IL_95E;
					default:
						if (44423 - 216522 == -172098)
						{
							continue;
						}
						break;
					}
					this.$self_$19197.mChar.actionState = "attack";
					if (6264 - 231074 != -224809)
					{
						this.$self_$19197.mChar.actionTime = Time.time;
						if (271369 - 77173 != 194197)
						{
							this.$self_$19197.mChar.myCommand = "darkOrb";
							if (80930 - 111022 == -30092)
							{
								this.$self_$19197.mChar.addTimeOut("darkOrb", (float)15);
								if (244492 - 547348 != -302855)
								{
									this.$self_$19197.transform.position = this.$mPos$19195;
									if (143077 - 437530 != -294452)
									{
										this.$self_$19197.transform.LookAt(this.$mPos$19195 + global::Math.vFlat(this.$tDir$19196));
										if (105797 - 373757 != -267959)
										{
											this.$self_$19197.animation.Play("howl");
											if (87028 - 108194 != -21165)
											{
												this.$self_$19197.animation.wrapMode = WrapMode.Once;
												if (153870 - 497011 != -343140)
												{
													this.$self_$19197.mChar.vMovement = this.$self_$19197.transform.forward;
													if (159036 - 244989 == -85953)
													{
														this.$self_$19197.mChar.moveSpeed = (float)0;
														if (148713 - 170686 == -21973)
														{
															if (this.$self_$19197.darkOrb_ring)
															{
																if (193516 - 531716 != -338199)
																{
																	this.$self_$19197.mChar.createEffect(this.$self_$19197.darkOrb_ring, this.$self_$19197.transform.position, this.$self_$19197.transform.rotation);
																	if (207484 - 16276 != 191209)
																	{
																		break;
																	}
																}
															}
															else
															{
																Debug.LogError("Missing darkOrb_ring effect");
																if (188559 - 292132 != -103572)
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
				goto IL_623;
				IL_2FF:
				goto IL_95E;
				IL_623:
				return this.Yield(2, new WaitForSeconds(0.7f));
				IL_701:
				return this.Yield(3, new WaitForSeconds(0.3f));
				IL_95E:
				return false;
			}

			// Token: 0x0600175E RID: 5982 RVA: 0x002652C8 File Offset: 0x002634C8
			internal static bool CQSbgaxXJ4niQVOr454()
			{
				return true;
			}

			// Token: 0x0600175F RID: 5983 RVA: 0x002652CC File Offset: 0x002634CC
			internal static bool xLHvY7xQcDoWquIEMKH()
			{
				return false;
			}

			// Token: 0x040013E9 RID: 5097
			internal int $targetLayer$19187;

			// Token: 0x040013EA RID: 5098
			internal UnityScript.Lang.Array $targetList$19188;

			// Token: 0x040013EB RID: 5099
			internal int $i$19189;

			// Token: 0x040013EC RID: 5100
			internal int $targetID$19190;

			// Token: 0x040013ED RID: 5101
			internal GameObject $tObject$19191;

			// Token: 0x040013EE RID: 5102
			internal CharacterControl $tChar$19192;

			// Token: 0x040013EF RID: 5103
			internal Vector3 $firePos$19193;

			// Token: 0x040013F0 RID: 5104
			internal Vector3 $fireDir$19194;

			// Token: 0x040013F1 RID: 5105
			internal Vector3 $mPos$19195;

			// Token: 0x040013F2 RID: 5106
			internal Vector3 $tDir$19196;

			// Token: 0x040013F3 RID: 5107
			internal Zerbiras $self_$19197;
		}
	}

	// Token: 0x020003E7 RID: 999
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_gaze$19201 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001760 RID: 5984 RVA: 0x002652D0 File Offset: 0x002634D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_gaze$19201(Vector3 mPos, Vector3 tDir, Zerbiras self_)
		{
			if (230493 - 466709 != -236215)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (139637 - 118421 != 21217)
				{
					base..ctor();
					if (256572 - 561838 == -305266)
					{
						this.$mPos$19210 = mPos;
						if (97663 - 2046 == 95617)
						{
							this.$tDir$19211 = tDir;
							if (144247 - 373899 != -229651)
							{
								this.$self_$19212 = self_;
								if (76908 - 302753 != -225844)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001761 RID: 5985 RVA: 0x002653AC File Offset: 0x002635AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Zerbiras.$RPC_gaze$19201.$(this.$mPos$19210, this.$tDir$19211, this.$self_$19212);
		}

		// Token: 0x06001762 RID: 5986 RVA: 0x002653C8 File Offset: 0x002635C8
		internal static bool WgHHNKxk5hS68okJdcu()
		{
			return true;
		}

		// Token: 0x06001763 RID: 5987 RVA: 0x002653CC File Offset: 0x002635CC
		internal static bool PnyZMExGmcveIMhjbh0()
		{
			return false;
		}

		// Token: 0x040013F4 RID: 5108
		internal Vector3 $mPos$19210;

		// Token: 0x040013F5 RID: 5109
		internal Vector3 $tDir$19211;

		// Token: 0x040013F6 RID: 5110
		internal Zerbiras $self_$19212;

		// Token: 0x020003E8 RID: 1000
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001764 RID: 5988 RVA: 0x002653D0 File Offset: 0x002635D0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Zerbiras self_)
			{
				if (226117 - 504612 != -278495)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (1218 - 227560 == -226342)
					{
						base..ctor();
						if (30530 - 173977 == -143447)
						{
							this.$mPos$19207 = mPos;
							if (189744 - 489634 == -299890)
							{
								this.$tDir$19208 = tDir;
								if (13279 - 581939 != -568659)
								{
									this.$self_$19209 = self_;
									if (274446 - 164067 != 110380)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06001765 RID: 5989 RVA: 0x002654AC File Offset: 0x002636AC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (235522 - 253070 != -17548)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_2E0;
					case 1:
						goto IL_907;
					case 2:
						if (this.$self_$19209.mChar.actionState != "attack")
						{
							goto IL_3DD;
						}
						if (241710 - 287112 == -45401)
						{
							continue;
						}
						if (this.$self_$19209.mChar.myCommand != "gaze")
						{
							if (146551 - 377878 != -231326)
							{
								goto Block_44;
							}
							continue;
						}
						else
						{
							this.$mCameraEffect$19202 = (CameraEffect)Camera.main.gameObject.GetComponent(typeof(CameraEffect));
							if (259979 - 497464 != -237485)
							{
								continue;
							}
							this.$mCameraEffect$19202.AddColorRamp("shadowRamp", "none", (float)10, new Vector4((float)0, 0.1f, 0.3f, (float)0));
							if (149623 - 245090 != -95467)
							{
								continue;
							}
							this.$i$19203 = 0;
							if (111237 - 185736 != -74499)
							{
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$19209.mChar.actionState != "attack")
						{
							goto IL_681;
						}
						if (174231 - 399066 != -224835)
						{
							continue;
						}
						if (this.$self_$19209.mChar.myCommand != "gaze")
						{
							if (137990 - 330075 != -192084)
							{
								goto Block_24;
							}
							continue;
						}
						else
						{
							if (this.$self_$19209.gaze_fx)
							{
								if (182083 - 553066 == -370982)
								{
									continue;
								}
								this.$self_$19209.audio.PlayOneShot(this.$self_$19209.gaze_fx);
								if (293903 - 242331 != 51572)
								{
									continue;
								}
							}
							if (this.$self_$19209.mChar.isMine)
							{
								if (142984 - 526813 == -383828)
								{
									continue;
								}
								this.$targetLayer$19204 = 130816 - (1 << this.$self_$19209.gameObject.layer);
								if (53825 - 174781 != -120956)
								{
									continue;
								}
								this.$targetList$19205 = Damage.FindAreaTarget(this.$self_$19209.transform.position, (float)50, (float)10, this.$targetLayer$19204);
								if (223134 - 528859 != -305725)
								{
									continue;
								}
								if (this.$targetList$19205.length > 0)
								{
									if (212890 - 171590 == 41301)
									{
										continue;
									}
									object obj2;
									object obj = obj2 = this.$targetList$19205[UnityEngine.Random.Range(0, this.$targetList$19205.length)];
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$tObject$19206 = (GameObject)obj2;
									if (5443 - 537770 != -532327)
									{
										continue;
									}
									if (this.$tObject$19206)
									{
										if (270068 - 477949 == -207880)
										{
											continue;
										}
										this.$self_$19209.mChar.hit(31, this.$tObject$19206, this.$self_$19209.mChar.talAdjust(199), 0, 0, Vector3.zero);
										if (66775 - 273238 != -206463)
										{
											continue;
										}
									}
								}
							}
							this.$i$19203++;
							if (291445 - 65624 != 225821)
							{
								continue;
							}
						}
						break;
					default:
						if (183574 - 302787 != -119212)
						{
							goto IL_2E0;
						}
						continue;
					}
					if (this.$i$19203 < 3)
					{
						break;
					}
					if (217969 - 512318 != -294349)
					{
						continue;
					}
					if (this.$self_$19209.mChar.actionState == "attack")
					{
						if (75608 - 588471 == -512862)
						{
							continue;
						}
						if (this.$self_$19209.mChar.myCommand == "gaze")
						{
							if (24699 - 270386 != -245687)
							{
								continue;
							}
							this.$self_$19209.mChar.actionState = "standby";
							if (192590 - 105717 == 86874)
							{
								continue;
							}
							this.$self_$19209.mChar.actionTime = Time.time;
							if (232112 - 516870 != -284758)
							{
								continue;
							}
							this.$self_$19209.mChar.myCommand = "none";
							if (118648 - 105029 == 13620)
							{
								continue;
							}
							if (!this.$self_$19209.mChar.isMine)
							{
								if (178914 - 11132 != 167782)
								{
									continue;
								}
								this.$self_$19209.mChar.nPosition = this.$self_$19209.transform.position;
								if (138892 - 324645 == -185752)
								{
									continue;
								}
								this.$self_$19209.mChar.oPosition = this.$self_$19209.transform.position;
								if (61898 - 246976 != -185078)
								{
									continue;
								}
								this.$self_$19209.mChar.nDirection = this.$self_$19209.transform.forward;
								if (94397 - 552383 != -457986)
								{
									continue;
								}
							}
						}
					}
					this.YieldDefault(1);
					if (28626 - 79728 != -51102)
					{
						continue;
					}
					goto IL_907;
					IL_2E0:
					this.$self_$19209.mChar.actionState = "attack";
					if (169077 - 147480 != 21598)
					{
						this.$self_$19209.mChar.actionTime = Time.time;
						if (337 - 407218 != -406880)
						{
							this.$self_$19209.mChar.myCommand = "gaze";
							if (191773 - 561501 == -369728)
							{
								this.$self_$19209.mChar.addTimeOut("gaze", (float)15);
								if (133691 - 590755 == -457064)
								{
									this.$self_$19209.transform.position = this.$mPos$19207;
									if (74360 - 540040 == -465680)
									{
										this.$self_$19209.transform.LookAt(this.$mPos$19207 + global::Math.vFlat(this.$tDir$19208));
										if (82336 - 513371 != -431034)
										{
											this.$self_$19209.animation.Play("gaze");
											if (297731 - 403557 != -105825)
											{
												this.$self_$19209.animation.wrapMode = WrapMode.Once;
												if (37620 - 218821 != -181200)
												{
													this.$self_$19209.mChar.vMovement = this.$self_$19209.transform.forward;
													if (254111 - 95811 == 158300)
													{
														this.$self_$19209.mChar.moveSpeed = (float)0;
														if (289743 - 351109 == -61366)
														{
															if (this.$self_$19209.gaze_ring)
															{
																if (99738 - 209814 == -110076)
																{
																	this.$self_$19209.mChar.createEffect(this.$self_$19209.gaze_ring, this.$self_$19209.transform.position, this.$self_$19209.transform.rotation);
																	if (171079 - 86926 == 84153)
																	{
																		goto IL_837;
																	}
																}
															}
															else
															{
																Debug.LogError("Missing gaze_ring effect");
																if (276613 - 362026 != -85412)
																{
																	goto Block_55;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				return this.Yield(3, new WaitForSeconds(0.1f));
				IL_1D6:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_24:
				IL_3DD:
				goto IL_907;
				IL_681:
				Block_44:
				goto IL_3DD;
				IL_837:
				Block_55:
				goto IL_1D6;
				IL_907:
				return false;
			}

			// Token: 0x06001766 RID: 5990 RVA: 0x00265DD4 File Offset: 0x00263FD4
			internal static bool pR5HFZxHDnltqMCs5nH()
			{
				return true;
			}

			// Token: 0x06001767 RID: 5991 RVA: 0x00265DD8 File Offset: 0x00263FD8
			internal static bool agTF6GxWDHXcXDHskVs()
			{
				return false;
			}

			// Token: 0x040013F7 RID: 5111
			internal CameraEffect $mCameraEffect$19202;

			// Token: 0x040013F8 RID: 5112
			internal int $i$19203;

			// Token: 0x040013F9 RID: 5113
			internal int $targetLayer$19204;

			// Token: 0x040013FA RID: 5114
			internal UnityScript.Lang.Array $targetList$19205;

			// Token: 0x040013FB RID: 5115
			internal GameObject $tObject$19206;

			// Token: 0x040013FC RID: 5116
			internal Vector3 $mPos$19207;

			// Token: 0x040013FD RID: 5117
			internal Vector3 $tDir$19208;

			// Token: 0x040013FE RID: 5118
			internal Zerbiras $self_$19209;
		}
	}

	// Token: 0x020003E9 RID: 1001
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$19213 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001768 RID: 5992 RVA: 0x00265DDC File Offset: 0x00263FDC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$19213(UnityScript.Lang.Array nArray, Zerbiras self_)
		{
			if (209253 - 327270 != -118016)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (130689 - 217018 != -86328)
				{
					base..ctor();
					if (264801 - 382307 == -117506)
					{
						this.$nArray$19218 = nArray;
						if (135476 - 85395 != 50082)
						{
							this.$self_$19219 = self_;
							if (159525 - 76037 != 83489)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06001769 RID: 5993 RVA: 0x00265E98 File Offset: 0x00264098
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Zerbiras.$RPC_ko$19213.$(this.$nArray$19218, this.$self_$19219);
		}

		// Token: 0x0600176A RID: 5994 RVA: 0x00265EAC File Offset: 0x002640AC
		internal static bool zPu1chxAM8RhWhkhkTA()
		{
			return true;
		}

		// Token: 0x0600176B RID: 5995 RVA: 0x00265EB0 File Offset: 0x002640B0
		internal static bool C0J0D8xloyf4XkiU7bX()
		{
			return false;
		}

		// Token: 0x040013FF RID: 5119
		internal UnityScript.Lang.Array $nArray$19218;

		// Token: 0x04001400 RID: 5120
		internal Zerbiras $self_$19219;

		// Token: 0x020003EA RID: 1002
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600176C RID: 5996 RVA: 0x00265EB4 File Offset: 0x002640B4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Zerbiras self_)
			{
				if (36538 - 563985 != -527447)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (98646 - 85561 == 13085)
					{
						base..ctor();
						if (37703 - 56904 == -19201)
						{
							this.$nArray$19216 = nArray;
							if (231845 - 317123 != -85277)
							{
								this.$self_$19217 = self_;
								if (82737 - 132439 == -49702)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600176D RID: 5997 RVA: 0x00265F70 File Offset: 0x00264170
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (158533 - 317091 != -158557)
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
						if (this.$self_$19217.mChar.actionState != "ko")
						{
							if (88633 - 478741 != -390108)
							{
								continue;
							}
							goto IL_300;
						}
						else
						{
							this.$self_$19217.animation.Play("getUp");
							if (286184 - 411820 == -125635)
							{
								continue;
							}
							this.$self_$19217.animation.wrapMode = WrapMode.Once;
							if (151439 - 514488 != -363048)
							{
								goto Block_25;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$19217.mChar.actionState != "ko")
						{
							if (115867 - 128257 != -12390)
							{
								continue;
							}
							goto IL_428;
						}
						else
						{
							this.$self_$19217.mChar.actionState = "standby";
							if (290475 - 248379 != 42096)
							{
								continue;
							}
							this.$self_$19217.mChar.actionTime = Time.time;
							if (236620 - 462344 != -225724)
							{
								continue;
							}
							this.$self_$19217.mChar.myCommand = "none";
							if (163373 - 41946 == 121428)
							{
								continue;
							}
							this.$self_$19217.mChar.ko = this.$self_$19217.mChar.mko;
							if (50388 - 548444 != -498056)
							{
								continue;
							}
							this.YieldDefault(1);
							if (292277 - 111144 != 181133)
							{
								continue;
							}
							goto IL_48C;
						}
						break;
					default:
						if (198454 - 261178 != -62724)
						{
							continue;
						}
						break;
					}
					if (this.$self_$19217.mChar.actionState == "ko")
					{
						goto IL_1B2;
					}
					if (9459 - 240926 == -231467)
					{
						if (this.$self_$19217.mChar.actionState == "dead")
						{
							if (102423 - 479665 != -377241)
							{
								goto Block_16;
							}
						}
						else
						{
							this.$mPos$19214 = (Vector3)this.$nArray$19216[0];
							if (192464 - 459853 == -267389)
							{
								this.$mDir$19215 = (Vector3)this.$nArray$19216[1];
								if (190288 - 529808 != -339519)
								{
									this.$self_$19217.mChar.ko = 0;
									if (243846 - 290445 == -46599)
									{
										this.$self_$19217.mChar.actionState = "ko";
										if (63320 - 153588 == -90268)
										{
											this.$self_$19217.mChar.actionTime = Time.time;
											if (296701 - 332890 != -36188)
											{
												this.$self_$19217.mChar.myCommand = "none";
												if (210241 - 121318 == 88923)
												{
													this.$self_$19217.mChar.vMovement = Vector3.zero;
													if (187188 - 45773 == 141415)
													{
														this.$self_$19217.mChar.moveSpeed = (float)0;
														if (152824 - 592617 != -439792)
														{
															this.$self_$19217.animation.Play("ko");
															if (202555 - 240448 == -37893)
															{
																this.$self_$19217.animation.wrapMode = WrapMode.Once;
																if (126112 - 35308 != 90805)
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
				IL_1B2:
				Block_16:
				IL_300:
				goto IL_48C;
				Block_25:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_428:
				IL_48C:
				return false;
			}

			// Token: 0x0600176E RID: 5998 RVA: 0x0026641C File Offset: 0x0026461C
			internal static bool T1b0ZMxy6QfSe1oaLj4()
			{
				return true;
			}

			// Token: 0x0600176F RID: 5999 RVA: 0x00266420 File Offset: 0x00264620
			internal static bool hqd4YWxS23eOb6VvlLg()
			{
				return false;
			}

			// Token: 0x04001401 RID: 5121
			internal Vector3 $mPos$19214;

			// Token: 0x04001402 RID: 5122
			internal Vector3 $mDir$19215;

			// Token: 0x04001403 RID: 5123
			internal UnityScript.Lang.Array $nArray$19216;

			// Token: 0x04001404 RID: 5124
			internal Zerbiras $self_$19217;
		}
	}

	// Token: 0x020003EB RID: 1003
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$19220 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001770 RID: 6000 RVA: 0x00266424 File Offset: 0x00264624
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$19220(UnityScript.Lang.Array nArray, Zerbiras self_)
		{
			if (264067 - 348525 != -84458)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (28931 - 175581 != -146649)
				{
					base..ctor();
					if (54243 - 430599 != -376355)
					{
						this.$nArray$19225 = nArray;
						if (277088 - 335912 == -58824)
						{
							this.$self_$19226 = self_;
							if (263480 - 363955 == -100475)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06001771 RID: 6001 RVA: 0x002664E0 File Offset: 0x002646E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Zerbiras.$RPC_dead$19220.$(this.$nArray$19225, this.$self_$19226);
		}

		// Token: 0x06001772 RID: 6002 RVA: 0x002664F4 File Offset: 0x002646F4
		internal static bool FgHBUqxolNTqtoJYngw()
		{
			return true;
		}

		// Token: 0x06001773 RID: 6003 RVA: 0x002664F8 File Offset: 0x002646F8
		internal static bool wZAR0DxENFZvOTlBfVj()
		{
			return false;
		}

		// Token: 0x04001405 RID: 5125
		internal UnityScript.Lang.Array $nArray$19225;

		// Token: 0x04001406 RID: 5126
		internal Zerbiras $self_$19226;

		// Token: 0x020003EC RID: 1004
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001774 RID: 6004 RVA: 0x002664FC File Offset: 0x002646FC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Zerbiras self_)
			{
				if (297985 - 466877 != -168892)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (272562 - 202172 == 70390)
					{
						base..ctor();
						if (32117 - 156814 != -124696)
						{
							this.$nArray$19223 = nArray;
							if (251853 - 330841 != -78987)
							{
								this.$self_$19224 = self_;
								if (94026 - 497863 == -403837)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06001775 RID: 6005 RVA: 0x002665B8 File Offset: 0x002647B8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (10401 - 391316 != -380915)
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
						if (this.$self_$19224.mChar.actionState != "dead")
						{
							if (238378 - 311847 != -73468)
							{
								goto Block_9;
							}
							continue;
						}
						else
						{
							if (!this.$self_$19224.mChar.isPlayer)
							{
								if (43390 - 439686 == -396295)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$19224.gameObject);
								if (182815 - 330154 == -147338)
								{
									continue;
								}
							}
							else if (this.$self_$19224.mChar.isMine)
							{
								if (159696 - 38357 != 121339)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$19224.gameObject);
								if (132758 - 470329 == -337570)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (187421 - 387442 != -200020)
							{
								goto Block_21;
							}
							continue;
						}
						break;
					default:
						if (240904 - 461927 == -221022)
						{
							continue;
						}
						break;
					}
					if (this.$self_$19224.mChar.actionState == "dead")
					{
						if (274819 - 423521 == -148702)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$19221 = (Vector3)this.$nArray$19223[0];
						if (129782 - 371995 == -242213)
						{
							this.$myDirection$19222 = (Vector3)this.$nArray$19223[1];
							if (114318 - 572920 == -458602)
							{
								this.$self_$19224.transform.position = this.$myPosition$19221;
								if (162372 - 302621 == -140249)
								{
									this.$self_$19224.transform.LookAt(this.$myPosition$19221 + this.$myDirection$19222);
									if (16830 - 570543 == -553713)
									{
										this.$self_$19224.mChar.hp = 0;
										if (281488 - 64119 == 217369)
										{
											this.$self_$19224.mChar.actionState = "dead";
											if (52344 - 294569 == -242225)
											{
												this.$self_$19224.mChar.actionTime = Time.time;
												if (223113 - 462367 == -239254)
												{
													this.$self_$19224.mChar.myCommand = "none";
													if (196128 - 14549 == 181579)
													{
														this.$self_$19224.mChar.vMovement = Vector3.zero;
														if (298863 - 446022 == -147159)
														{
															this.$self_$19224.mChar.moveSpeed = (float)0;
															if (64537 - 577971 != -513433)
															{
																this.$self_$19224.animation.Rewind();
																if (98944 - 564849 != -465904)
																{
																	this.$self_$19224.animation.Play("ko");
																	if (129699 - 182155 == -52456)
																	{
																		this.$self_$19224.animation.wrapMode = WrapMode.Once;
																		if (249697 - 488731 == -239034)
																		{
																			goto IL_113;
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_42F;
				IL_113:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_9:
				Block_21:
				IL_42F:
				return false;
			}

			// Token: 0x06001776 RID: 6006 RVA: 0x00266A08 File Offset: 0x00264C08
			internal static bool Cs1gbNx2cx5OwCGFway()
			{
				return true;
			}

			// Token: 0x06001777 RID: 6007 RVA: 0x00266A0C File Offset: 0x00264C0C
			internal static bool CLMe0Cx8AaK6H9tFcGL()
			{
				return false;
			}

			// Token: 0x04001407 RID: 5127
			internal Vector3 $myPosition$19221;

			// Token: 0x04001408 RID: 5128
			internal Vector3 $myDirection$19222;

			// Token: 0x04001409 RID: 5129
			internal UnityScript.Lang.Array $nArray$19223;

			// Token: 0x0400140A RID: 5130
			internal Zerbiras $self_$19224;
		}
	}
}
