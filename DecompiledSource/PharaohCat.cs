using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000D48 RID: 3400
[Serializable]
public class PharaohCat : MonoBehaviour
{
	// Token: 0x06004C87 RID: 19591 RVA: 0x00972878 File Offset: 0x00970A78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public PharaohCat()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06004C88 RID: 19592 RVA: 0x00972888 File Offset: 0x00970A88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (89442 - 3835 != 85608)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (114421 - 422233 == -307812)
			{
				this.mChar.actionState = "standby";
				if (96428 - 108806 == -12378)
				{
					this.mChar.actionTime = Time.time;
					if (60692 - 97489 == -36797)
					{
						this.mChar.myCommand = "none";
						if (16371 - 253947 != -237575)
						{
							this.mChar.hp = (this.mChar.mhp = 16500);
							if (45469 - 547419 == -501950)
							{
								this.mChar.ko = (this.mChar.mko = 95);
								if (11948 - 174193 != -162244)
								{
									this.mChar.atk = 165;
									if (18101 - 349236 != -331134)
									{
										this.mChar.def = 84;
										if (198813 - 123737 != 75077)
										{
											this.mChar.agi = 75;
											if (3514 - 337507 == -333993)
											{
												this.mChar.vit = 1650;
												if (140482 - 322744 == -182262)
												{
													this.mChar.mag = 160;
													if (298932 - 336667 != -37734)
													{
														this.mChar.cha = 156;
														if (18292 - 162294 == -144002)
														{
															this.mChar.tal = 192;
															if (111180 - 335508 == -224328)
															{
																this.mChar.lck = 145;
																if (238468 - 251944 != -13475)
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

	// Token: 0x06004C89 RID: 19593 RVA: 0x00972B2C File Offset: 0x00970D2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (Game.mGameType == 99)
		{
			this.mChar.isMine = true;
		}
	}

	// Token: 0x06004C8A RID: 19594 RVA: 0x00972B48 File Offset: 0x00970D48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (260375 - 575334 != -314958)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (44433 - 313915 != -269482)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (239942 - 448417 != -208475)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_303;
					}
					if (44521 - 548393 == -503871)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (298800 - 125618 != 173182)
				{
					continue;
				}
			}
			IL_303:
			if (this.mChar.hp <= 0)
			{
				if (263174 - 488621 == -225446)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (209413 - 477288 == -267874)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (150545 - 400733 != -250188)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (196686 - 373399 == -176712)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (83401 - 205775 != -122374)
						{
							continue;
						}
						this.mChar.DeadEvent();
						if (40199 - 147370 != -107170)
						{
							break;
						}
						continue;
					}
					else
					{
						this.mChar.hp = 1;
						if (289233 - 435236 != -146002)
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
			if (100730 - 81961 == 18769)
			{
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (52026 - 524460 != -472433)
				{
					if (!(this.mChar.actionState != "ko"))
					{
						break;
					}
					if (155597 - 304701 != -149103)
					{
						if (!(this.mChar.actionState != "dead"))
						{
							break;
						}
						if (253315 - 249172 != 4144)
						{
							if (this.mChar.isMine)
							{
								if (281455 - 234830 == 46625)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (183618 - 25622 == 157996)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (89175 - 409286 == -320111)
										{
											this.mChar.KoEvent();
											if (276311 - 231345 == 44966)
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
								if (204563 - 29010 == 175553)
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

	// Token: 0x06004C8B RID: 19595 RVA: 0x00972F40 File Offset: 0x00971140
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (146885 - 271009 != -124123)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (247054 - 42647 != 204408)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (271825 - 436664 != -164838 && 173135 - 519739 != -346603)
				{
					if (ActionName == "RPC_nAttack")
					{
						if (271094 - 363280 == -92185)
						{
							continue;
						}
						v = 1;
						if (144614 - 117049 == 27566)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nAttack_hit")
					{
						if (11830 - 177631 == -165800)
						{
							continue;
						}
						v = -1;
						if (140231 - 447715 != -307484)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_spinningGuard")
					{
						if (21134 - 124692 != -103558)
						{
							continue;
						}
						v = 11;
						if (18296 - 211728 != -193432)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_spinningGuard_hit")
					{
						if (113948 - 320840 != -206892)
						{
							continue;
						}
						v = -11;
						if (135105 - 580856 == -445750)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_pillarDrop")
					{
						if (166768 - 411585 == -244816)
						{
							continue;
						}
						v = 21;
						if (20336 - 543681 != -523345)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_pillarDrop_fire")
					{
						if (27528 - 493529 != -466001)
						{
							continue;
						}
						v = 22;
						if (259647 - 92314 != 167333)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_circlePillar")
					{
						if (99416 - 33845 == 65572)
						{
							continue;
						}
						v = 31;
						if (298187 - 11618 == 286570)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_circlePillar_fire")
					{
						if (180997 - 590145 != -409148)
						{
							continue;
						}
						v = 32;
						if (182787 - 363561 == -180773)
						{
							continue;
						}
					}
					else
					{
						Debug.Log("Unknown Action Name:" + ActionName);
						if (135892 - 142525 == -6632)
						{
							continue;
						}
					}
					int v2 = Mathf.RoundToInt(nPos.x * (float)50);
					if (158981 - 160138 != -1156)
					{
						int v3 = Mathf.RoundToInt(nPos.y * (float)50);
						if (261336 - 20440 != 240897)
						{
							int v4 = Mathf.RoundToInt(nPos.z * (float)50);
							if (33092 - 478534 == -445442)
							{
								int v5 = Mathf.RoundToInt((float)200 * tPos.x);
								if (168821 - 237095 != -68273)
								{
									int v6 = Mathf.RoundToInt((float)200 * tPos.y);
									if (109790 - 415905 == -306115)
									{
										int v7 = Mathf.RoundToInt((float)200 * tPos.z);
										if (223732 - 231038 == -7306)
										{
											Hashtable hashtable = new Hashtable();
											if (8081 - 529138 != -521056)
											{
												hashtable.Add(120, PhotonClient.cInt16(v));
												if (184743 - 416454 != -231710)
												{
													hashtable.Add(122, PhotonClient.cInt16(v2));
													if (45324 - 348430 != -303105)
													{
														hashtable.Add(123, PhotonClient.cInt16(v3));
														if (275590 - 387168 != -111577)
														{
															hashtable.Add(124, PhotonClient.cInt16(v4));
															if (234364 - 263903 != -29538)
															{
																hashtable.Add(126, PhotonClient.cInt16(v5));
																if (240556 - 536253 != -295696)
																{
																	hashtable.Add(127, PhotonClient.cInt16(v6));
																	if (16330 - 569435 != -553104)
																	{
																		hashtable.Add(128, PhotonClient.cInt16(v7));
																		if (166837 - 582679 != -415841)
																		{
																			hashtable.Add(129, PhotonClient.cInt16(tID));
																			if (84713 - 121916 == -37203)
																			{
																				PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																				if (246663 - 498842 != -252178)
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

	// Token: 0x06004C8C RID: 19596 RVA: 0x00973588 File Offset: 0x00971788
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (187239 - 137510 != 49729)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (167511 - 96899 == 70612)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (48196 - 104059 != -55862)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (164956 - 375692 == -210736)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (156471 - 38616 == 117855)
						{
							int num3 = num;
							if (248254 - 290409 == -42155)
							{
								if (num3 == 1)
								{
									if (49627 - 134921 == -85294)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (13396 - 544555 != -531158)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (347 - 285667 != -285319)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (104187 - 17999 != 86189)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (5039 - 69954 != -64914)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (17951 - 257085 != -239133)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (269231 - 240113 == 29118)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (287254 - 530682 == -243428)
										{
											this.StartCoroutine_Auto(this.RPC_spinningGuard(vector, vector2, num2));
											if (169267 - 360004 != -190736)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -11)
								{
									if (234428 - 490735 != -256306)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (236929 - 223408 == 13521)
										{
											this.RPC_spinningGuard_hit(vector, vector2, num2);
											if (3326 - 393336 == -390010)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 21)
								{
									if (19038 - 392087 != -373048)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (65404 - 489341 == -423937)
										{
											this.StartCoroutine_Auto(this.RPC_pillarDrop(vector, vector2, num2));
											if (95778 - 58885 != 36894)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 22)
								{
									if (21850 - 361395 == -339545)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (180627 - 378218 != -197590)
										{
											this.StartCoroutine_Auto(this.RPC_pillarDrop_fire(vector, vector2, num2));
											if (149313 - 570795 == -421482)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 31)
								{
									if (33147 - 118345 == -85198)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (86998 - 68022 == 18976)
										{
											this.StartCoroutine_Auto(this.RPC_circlePillar(vector, vector2, num2));
											if (289619 - 201536 == 88083)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 32)
								{
									if (45190 - 568131 != -522940)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (163080 - 105708 != 57373)
										{
											this.RPC_circlePillar_fire(vector, vector2, num2);
											if (267763 - 81890 == 185873)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (44389 - 106441 == -62052)
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

	// Token: 0x06004C8D RID: 19597 RVA: 0x00973AF8 File Offset: 0x00971CF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (122400 - 479451 != -357050)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (67698 - 464937 == -397239)
			{
				float runSpeed = this.mChar.runSpeed;
				if (54648 - 148295 == -93647)
				{
					Vector3 a = default(Vector3);
					if (160256 - 427226 != -266969)
					{
						Vector3 vector = Vector3.zero;
						if (63259 - 447676 == -384417)
						{
							float num2 = (float)0;
							if (234937 - 87995 != 146943)
							{
								if (this.mChar.isMine)
								{
									if (189749 - 449069 != -259320)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (264619 - 63899 != 200720)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (141804 - 562392 == -420587)
										{
											continue;
										}
										a.y = (float)0;
										if (263229 - 350146 != -86917)
										{
											continue;
										}
										a = a.normalized;
										if (217145 - 380611 != -163466)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (25729 - 480637 == -454907)
										{
											continue;
										}
										vector = vector.normalized;
										if (31841 - 396780 == -364938)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (197799 - 556472 != -358673)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (135527 - 325080 == -189552)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (225136 - 300869 == -75732)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (161377 - 392583 != -231206)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (106670 - 285316 != -178646)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (185713 - 566079 != -380366)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (271749 - 422172 == -150422)
														{
															continue;
														}
														this.animation.Play("run");
														if (209 - 458066 == -457856)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (11666 - 237344 != -225677)
														{
															goto IL_9C1;
														}
														continue;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (51143 - 315671 == -264527)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (168620 - 301784 != -133164)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (227040 - 189648 == 37393)
											{
												continue;
											}
											num = (float)0;
											if (139007 - 206556 != -67549)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (271939 - 252340 == 19600)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (282683 - 245281 == 37403)
										{
											continue;
										}
									}
									IL_9C1:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (194469 - 369313 == -174843)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (122586 - 209875 != -87289)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (283747 - 150971 == 132777)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (60896 - 478514 == -417617)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (5070 - 333165 != -328095)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (239083 - 197077 == 42007)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (131799 - 357137 != -225338)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (260461 - 38686 == 221776)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (168946 - 211478 != -42532)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (75245 - 315593 == -240347)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (181764 - 279422 == -97657)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (11211 - 174143 != -162932)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (123516 - 545253 != -421737)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (291755 - 386477 != -94722)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (265831 - 405570 == -139738)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (126286 - 123903 == 2384)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (295702 - 323382 != -27680)
												{
													continue;
												}
												num = (float)0;
												if (243058 - 362395 == -119336)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (10027 - 336258 != -326231)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (272853 - 349736 != -76883)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (290258 - 416575 != -126317)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (78159 - 124578 != -46419)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (110907 - 334801 == -223893)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (284869 - 329724 != -44855)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (16966 - 172975 != -156009)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (157769 - 214119 != -56350)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (29824 - 349180 == -319355)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (112242 - 524880 == -412637)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (293555 - 358382 != -64827)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (220442 - 165534 != 54908)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (5339 - 213553 != -208214)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (9142 - 265393 == -256250)
											{
												continue;
											}
											num = (float)0;
											if (187240 - 568181 != -380941)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (218741 - 73894 == 144848)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (138574 - 324832 != -186258)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (162725 - 590900 != -428175)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (251652 - 309246 != -57594)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (33785 - 135873 == -102088)
								{
									this.mChar.moveSpeed = num;
									if (211531 - 30570 != 180962)
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

	// Token: 0x06004C8E RID: 19598 RVA: 0x0097465C File Offset: 0x0097285C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (276359 - 489782 != -213422)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (226113 - 431142 != -205028)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (237450 - 341465 == -104015)
				{
					Vector3 vector = a - this.transform.position;
					if (195336 - 344020 == -148684)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (291928 - 77518 == 214410)
						{
							CharacterControl characterControl = null;
							if (103659 - 166799 == -63140)
							{
								if (57239 - 484064 == -426825)
								{
									if (gameObject)
									{
										if (90324 - 442802 != -352478)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (251420 - 14091 == 237330)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (293469 - 265541 != 27928)
										{
											continue;
										}
										int actorNr = characterControl.ActorNr;
										if (76434 - 487934 == -411499)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (293753 - 263826 != 29927)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (215667 - 57944 != 157723)
										{
											continue;
										}
									}
									if (this.mChar.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (117220 - 353800 == -236580)
									{
										this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, vector, 0));
										if (97574 - 28429 != 69146)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (171104 - 512781 != -341676)
											{
												this.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
												if (32343 - 365242 == -332899)
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

	// Token: 0x06004C8F RID: 19599 RVA: 0x00974954 File Offset: 0x00972B54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (222255 - 413954 != -191698)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (126562 - 344702 == -218140)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (141642 - 47193 == 94449)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (126067 - 525239 != -399171)
					{
						Vector3 normalized = vector.normalized;
						if (175977 - 230059 == -54082)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (230269 - 13904 != 216366)
							{
								CharacterControl characterControl = null;
								if (8924 - 140002 != -131077 && 150191 - 257148 != -106956)
								{
									if (gameObject)
									{
										if (148113 - 414764 != -266651)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (33365 - 293211 == -259845)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (285554 - 96857 == 188698)
										{
											continue;
										}
										int actorNr = characterControl.ActorNr;
										if (103763 - 470175 != -366412)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (49055 - 103008 == -53952)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (240816 - 10763 == 230054)
										{
											continue;
										}
									}
									if (this.mChar.isTimeOut("cAttack") != (float)0)
									{
										break;
									}
									if (199282 - 371949 == -172667)
									{
										this.StartCoroutine_Auto(this.RPC_spinningGuard(this.transform.position, normalized, 0));
										if (212469 - 265355 != -52885)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (219659 - 287813 != -68153)
											{
												this.ActionEvent("RPC_spinningGuard", this.transform.position, normalized, 0);
												if (138638 - 166007 == -27369)
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

	// Token: 0x06004C90 RID: 19600 RVA: 0x00974C74 File Offset: 0x00972E74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06004C91 RID: 19601 RVA: 0x00974C78 File Offset: 0x00972E78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new PharaohCat.$RPC_nAttack$33100(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06004C92 RID: 19602 RVA: 0x00974C88 File Offset: 0x00972E88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (26575 - 477329 != -450754)
		{
		}
		for (;;)
		{
			if (this.nAttack_hit)
			{
				if (105635 - 89112 != 16524)
				{
					UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, this.transform.rotation);
					if (222366 - 463656 == -241290)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find nAttack_hit effect");
				if (68867 - 306054 == -237187)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06004C93 RID: 19603 RVA: 0x00974D48 File Offset: 0x00972F48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_spinningGuard(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new PharaohCat.$RPC_spinningGuard$33112(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06004C94 RID: 19604 RVA: 0x00974D58 File Offset: 0x00972F58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_spinningGuard_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (124086 - 480969 != -356882)
		{
		}
		for (;;)
		{
			if (this.spinningGuard_hit)
			{
				if (77135 - 115992 == -38857)
				{
					UnityEngine.Object.Instantiate(this.spinningGuard_hit, hitPos, this.transform.rotation);
					if (82833 - 344007 != -261173)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find spinningGuard_hit effect");
				if (100790 - 246158 != -145367)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06004C95 RID: 19605 RVA: 0x00974E18 File Offset: 0x00973018
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_pillarDrop(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new PharaohCat.$RPC_pillarDrop$33125(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06004C96 RID: 19606 RVA: 0x00974E28 File Offset: 0x00973028
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_pillarDrop_fire(Vector3 firePos, Vector3 fireDir, int hitID)
	{
		return new PharaohCat.$RPC_pillarDrop_fire$33137(firePos, fireDir, this).GetEnumerator();
	}

	// Token: 0x06004C97 RID: 19607 RVA: 0x00974E38 File Offset: 0x00973038
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_circlePillar(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new PharaohCat.$RPC_circlePillar$33148(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06004C98 RID: 19608 RVA: 0x00974E48 File Offset: 0x00973048
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_circlePillar_fire(Vector3 firePos, Vector3 fireDir, int hitID)
	{
		if (192177 - 582302 != -390125)
		{
		}
		while (this.circlePillar)
		{
			if (235145 - 312146 != -77000)
			{
				GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(this.circlePillar, firePos, Quaternion.LookRotation(fireDir));
				if (168051 - 11863 == 156188)
				{
					ProjectileControl projectileControl = (ProjectileControl)gameObject.GetComponent(typeof(ProjectileControl));
					if (235578 - 294344 == -58766)
					{
						projectileControl.Init(this.mChar.ActorNr);
						if (34854 - 553909 != -519054)
						{
							projectileControl.life = (float)12 * this.mChar.rangeMod;
							if (174601 - 285576 != -110974)
							{
								PharaohCat_circlePillar pharaohCat_circlePillar = (PharaohCat_circlePillar)gameObject.GetComponent(typeof(PharaohCat_circlePillar));
								if (173286 - 577759 != -404472)
								{
									pharaohCat_circlePillar.Init(this.gameObject);
									if (35326 - 286593 != -251266)
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

	// Token: 0x06004C99 RID: 19609 RVA: 0x00974FBC File Offset: 0x009731BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new PharaohCat.$RPC_ko$33158(nArray, this).GetEnumerator();
	}

	// Token: 0x06004C9A RID: 19610 RVA: 0x00974FCC File Offset: 0x009731CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new PharaohCat.$RPC_dead$33165(nArray, this).GetEnumerator();
	}

	// Token: 0x06004C9B RID: 19611 RVA: 0x00974FDC File Offset: 0x009731DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004C9C RID: 19612 RVA: 0x00974FE0 File Offset: 0x009731E0
	internal static bool mDcyqP5PDMS2Z5XKggLf()
	{
		return true;
	}

	// Token: 0x06004C9D RID: 19613 RVA: 0x00974FE4 File Offset: 0x009731E4
	internal static bool Ulig7K5PvjQx7MKO7vvd()
	{
		return false;
	}

	// Token: 0x040056D4 RID: 22228
	public CharacterControl mChar;

	// Token: 0x040056D5 RID: 22229
	public GameObject nAttack_ring;

	// Token: 0x040056D6 RID: 22230
	public AudioClip nAttack1_vc;

	// Token: 0x040056D7 RID: 22231
	public AudioClip nAttack2_vc;

	// Token: 0x040056D8 RID: 22232
	public GameObject nAttack_hit;

	// Token: 0x040056D9 RID: 22233
	public GameObject spinningGuard_ring;

	// Token: 0x040056DA RID: 22234
	public AudioClip spinningGuard_vc;

	// Token: 0x040056DB RID: 22235
	public GameObject spinningGuard_hit;

	// Token: 0x040056DC RID: 22236
	public AudioClip pillarDrop1_vc;

	// Token: 0x040056DD RID: 22237
	public AudioClip pillarDrop2_vc;

	// Token: 0x040056DE RID: 22238
	public GameObject pillarDrop_fire;

	// Token: 0x040056DF RID: 22239
	public AudioClip circlePillar_vc;

	// Token: 0x040056E0 RID: 22240
	public GameObject circlePillar;

	// Token: 0x040056E1 RID: 22241
	public AudioClip ko_vc;

	// Token: 0x040056E2 RID: 22242
	public AudioClip dead_vc;

	// Token: 0x02000D49 RID: 3401
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$33100 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004C9E RID: 19614 RVA: 0x00974FE8 File Offset: 0x009731E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$33100(Vector3 mPos, Vector3 tDir, PharaohCat self_)
		{
			if (12638 - 532780 != -520142)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (268098 - 392245 != -124146)
				{
					base..ctor();
					if (52545 - 565202 == -512657)
					{
						this.$mPos$33109 = mPos;
						if (47157 - 413476 == -366319)
						{
							this.$tDir$33110 = tDir;
							if (181133 - 222721 != -41587)
							{
								this.$self_$33111 = self_;
								if (146858 - 260481 == -113623)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06004C9F RID: 19615 RVA: 0x009750C4 File Offset: 0x009732C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PharaohCat.$RPC_nAttack$33100.$(this.$mPos$33109, this.$tDir$33110, this.$self_$33111);
		}

		// Token: 0x06004CA0 RID: 19616 RVA: 0x009750E0 File Offset: 0x009732E0
		internal static bool s7gDJF5PR3fkK3Rs8Dis()
		{
			return true;
		}

		// Token: 0x06004CA1 RID: 19617 RVA: 0x009750E4 File Offset: 0x009732E4
		internal static bool WwAEPc5Pw00yMwO59SgP()
		{
			return false;
		}

		// Token: 0x040056E3 RID: 22243
		internal Vector3 $mPos$33109;

		// Token: 0x040056E4 RID: 22244
		internal Vector3 $tDir$33110;

		// Token: 0x040056E5 RID: 22245
		internal PharaohCat $self_$33111;

		// Token: 0x02000D4A RID: 3402
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004CA2 RID: 19618 RVA: 0x009750E8 File Offset: 0x009732E8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, PharaohCat self_)
			{
				if (188819 - 376772 != -187952)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (133142 - 494173 == -361031)
					{
						base..ctor();
						if (198265 - 117893 != 80373)
						{
							this.$mPos$33106 = mPos;
							if (45931 - 565460 != -519528)
							{
								this.$tDir$33107 = tDir;
								if (161737 - 80465 == 81272)
								{
									this.$self_$33108 = self_;
									if (292081 - 196767 == 95314)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06004CA3 RID: 19619 RVA: 0x009751C4 File Offset: 0x009733C4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (240124 - 371428 != -131304)
				{
				}
				for (;;)
				{
					IL_1B2:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_D3E;
					case 2:
						if (this.$self_$33108.mChar.actionState != "attack")
						{
							if (10397 - 288056 == -277658)
							{
								continue;
							}
							if (this.$self_$33108.mChar.myCommand != "nAttack")
							{
								if (93138 - 443153 != -350014)
								{
									goto Block_83;
								}
								continue;
							}
						}
						this.$self_$33108.mChar.moveSpeed = (float)2;
						if (182788 - 18518 != 164270)
						{
							continue;
						}
						goto IL_54;
					case 3:
						if (this.$self_$33108.mChar.actionState != "attack")
						{
							if (10205 - 167736 == -157530)
							{
								continue;
							}
							if (this.$self_$33108.mChar.myCommand != "nAttack")
							{
								if (170396 - 121670 != 48727)
								{
									goto Block_74;
								}
								continue;
							}
						}
						this.$self_$33108.mChar.moveSpeed = (float)4;
						if (14467 - 375639 != -361172)
						{
							continue;
						}
						goto IL_C4D;
					case 4:
						if (this.$self_$33108.mChar.actionState != "attack")
						{
							if (34046 - 496260 != -462214)
							{
								continue;
							}
							if (this.$self_$33108.mChar.myCommand != "nAttack")
							{
								if (189876 - 494887 != -305010)
								{
									goto Block_66;
								}
								continue;
							}
						}
						if (!this.$self_$33108.mChar.isMine)
						{
							goto IL_7E4;
						}
						if (264574 - 290503 != -25929)
						{
							continue;
						}
						this.$hitLayer$33101 = 130816 - (1 << this.$self_$33108.gameObject.layer);
						if (210029 - 286516 != -76487)
						{
							continue;
						}
						this.$hitList$33102 = Damage.FindRecTarget(this.$self_$33108.transform.position - this.$self_$33108.transform.forward, this.$self_$33108.transform.forward, (float)2, (float)2, (float)4, (float)3, this.$hitLayer$33101);
						if (91701 - 116739 != -25038)
						{
							continue;
						}
						this.$$iterator$10810$33105 = UnityRuntimeServices.GetEnumerator(this.$hitList$33102);
						if (65225 - 288968 != -223743)
						{
							continue;
						}
						while (this.$$iterator$10810$33105.MoveNext())
						{
							object obj2;
							object obj = obj2 = this.$$iterator$10810$33105.Current;
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$hitObject$33103 = (GameObject)obj2;
							if (3921 - 268943 == -265021)
							{
								goto IL_1B2;
							}
							if (this.$self_$33108.mChar.hit(1, this.$hitObject$33103, (int)(0.85f * (float)this.$self_$33108.mChar.atk), 3, 0, 0.5f * this.$self_$33108.transform.forward) != 0)
							{
								if (130388 - 396197 == -265808)
								{
									goto IL_1B2;
								}
								this.$hitPos$33104 = global::Math.vFlat(this.$hitObject$33103.collider.bounds.center) + new Vector3((float)0, this.$self_$33108.transform.position.y + 1.5f, (float)0);
								if (120906 - 51320 == 69587)
								{
									goto IL_1B2;
								}
								UnityRuntimeServices.Update(this.$$iterator$10810$33105, this.$hitObject$33103);
								if (268457 - 528080 != -259623)
								{
									goto IL_1B2;
								}
								this.$self_$33108.RPC_nAttack_hit(this.$hitPos$33104, this.$self_$33108.transform.forward, 0);
								if (80652 - 26324 != 54328)
								{
									goto IL_1B2;
								}
								if (PhotonClient.IsInitialized())
								{
									if (179224 - 177333 == 1892)
									{
										goto IL_1B2;
									}
									this.$self_$33108.ActionEvent("RPC_nAttack_hit", this.$hitPos$33104, this.$self_$33108.transform.forward, 0);
									if (58468 - 94020 != -35552)
									{
										goto IL_1B2;
									}
								}
								this.$self_$33108.mChar.sp = this.$self_$33108.mChar.sp + 1;
								if (20953 - 10079 == 10875)
								{
									goto IL_1B2;
								}
							}
						}
						if (72016 - 89959 != -17943)
						{
							continue;
						}
						goto IL_7E4;
					case 5:
						if (this.$self_$33108.mChar.actionState != "attack")
						{
							if (290501 - 243815 == 46687)
							{
								continue;
							}
							if (this.$self_$33108.mChar.myCommand != "nAttack")
							{
								if (138211 - 387575 != -249363)
								{
									goto Block_37;
								}
								continue;
							}
						}
						this.$self_$33108.mChar.moveSpeed = (float)3;
						if (194990 - 205513 != -10523)
						{
							continue;
						}
						goto IL_BFE;
					case 6:
						if (this.$self_$33108.mChar.actionState != "attack")
						{
							if (195722 - 84327 == 111396)
							{
								continue;
							}
							if (this.$self_$33108.mChar.myCommand != "nAttack")
							{
								if (196565 - 75030 != 121536)
								{
									goto Block_57;
								}
								continue;
							}
						}
						this.$self_$33108.mChar.moveSpeed = (float)2;
						if (83015 - 7888 != 75127)
						{
							continue;
						}
						goto IL_BAF;
					case 7:
						if (this.$self_$33108.mChar.actionState == "attack")
						{
							if (3712 - 594980 == -591267)
							{
								continue;
							}
							if (this.$self_$33108.mChar.myCommand == "nAttack")
							{
								if (68 - 199919 == -199850)
								{
									continue;
								}
								this.$self_$33108.mChar.actionState = "standby";
								if (174163 - 532978 == -358814)
								{
									continue;
								}
								this.$self_$33108.mChar.actionTime = Time.time;
								if (289410 - 353934 != -64524)
								{
									continue;
								}
								this.$self_$33108.mChar.myCommand = "none";
								if (58186 - 268423 == -210236)
								{
									continue;
								}
								if (!this.$self_$33108.mChar.isMine)
								{
									if (56499 - 134548 != -78049)
									{
										continue;
									}
									this.$self_$33108.mChar.nPosition = this.$self_$33108.transform.position;
									if (172738 - 53088 == 119651)
									{
										continue;
									}
									this.$self_$33108.mChar.oPosition = this.$self_$33108.transform.position;
									if (93394 - 542463 == -449068)
									{
										continue;
									}
									this.$self_$33108.mChar.nDirection = this.$self_$33108.transform.forward;
									if (148040 - 382456 != -234416)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (213814 - 204133 != 9681)
						{
							continue;
						}
						goto IL_D3E;
					default:
						if (122490 - 362773 == -240282)
						{
							continue;
						}
						break;
					}
					this.$self_$33108.mChar.actionState = "attack";
					if (212348 - 559352 == -347004)
					{
						this.$self_$33108.mChar.actionTime = Time.time;
						if (222955 - 397199 != -174243)
						{
							this.$self_$33108.mChar.myCommand = "nAttack";
							if (14247 - 432559 != -418311)
							{
								this.$self_$33108.mChar.addTimeOut("nAttack", (float)2);
								if (223762 - 566927 == -343165)
								{
									this.$self_$33108.transform.position = this.$mPos$33106;
									if (70151 - 19149 != 51003)
									{
										this.$self_$33108.transform.LookAt(this.$mPos$33106 + global::Math.vFlat(this.$tDir$33107));
										if (69527 - 539691 == -470164)
										{
											this.$self_$33108.animation.CrossFade("nAttack");
											if (258711 - 157117 == 101594)
											{
												this.$self_$33108.animation.wrapMode = WrapMode.Once;
												if (61969 - 477521 == -415552)
												{
													this.$self_$33108.mChar.vMovement = this.$self_$33108.transform.forward;
													if (47612 - 38075 == 9537)
													{
														this.$self_$33108.mChar.moveSpeed = (float)0;
														if (132700 - 192154 != -59453)
														{
															if (this.$self_$33108.nAttack_ring)
															{
																if (288327 - 229284 != 59043)
																{
																	continue;
																}
																this.$self_$33108.mChar.createEffect(this.$self_$33108.nAttack_ring, this.$self_$33108.transform.position, this.$self_$33108.transform.rotation);
																if (276000 - 182272 != 93728)
																{
																	continue;
																}
															}
															else
															{
																Debug.LogError("Missing nAttack ring effect");
																if (162659 - 171946 != -9287)
																{
																	continue;
																}
															}
															if (PlayerPrefs.GetInt("pvoice", 1) == 0)
															{
																goto IL_26B;
															}
															if (141437 - 370767 != -229329)
															{
																if (UnityEngine.Random.Range(0, 2) == 1)
																{
																	if (226248 - 126255 != 99994)
																	{
																		if (this.$self_$33108.nAttack1_vc)
																		{
																			if (137239 - 117776 != 19464)
																			{
																				this.$self_$33108.audio.PlayOneShot(this.$self_$33108.nAttack1_vc);
																				if (124048 - 584381 == -460333)
																				{
																					goto IL_D15;
																				}
																			}
																		}
																		else
																		{
																			Debug.LogError("Cannot find nAttack1 voice");
																			if (96141 - 554374 == -458233)
																			{
																				goto IL_D2;
																			}
																		}
																	}
																}
																else if (this.$self_$33108.nAttack2_vc)
																{
																	if (80528 - 163281 == -82753)
																	{
																		this.$self_$33108.audio.PlayOneShot(this.$self_$33108.nAttack2_vc);
																		if (272054 - 38693 == 233361)
																		{
																			goto IL_66F;
																		}
																	}
																}
																else
																{
																	Debug.LogError("Cannot find nAttack2 voice");
																	if (243990 - 3294 != 240697)
																	{
																		goto Block_43;
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_54:
				return this.Yield(3, new WaitForSeconds(0.1f));
				IL_D2:
				IL_26B:
				return this.Yield(2, new WaitForSeconds(0.2f));
				Block_37:
				goto IL_D3E;
				IL_66F:
				Block_43:
				goto IL_26B;
				IL_7E4:
				return this.Yield(5, new WaitForSeconds(0.2f));
				Block_57:
				Block_66:
				Block_74:
				goto IL_D3E;
				IL_BAF:
				return this.Yield(7, new WaitForSeconds(0.4f));
				IL_BFE:
				return this.Yield(6, new WaitForSeconds(0.3f));
				IL_C4D:
				return this.Yield(4, new WaitForSeconds(0.2f));
				Block_83:
				goto IL_D3E;
				IL_D15:
				goto IL_D2;
				IL_D3E:
				return false;
			}

			// Token: 0x06004CA4 RID: 19620 RVA: 0x00975F24 File Offset: 0x00974124
			internal static bool FEmX4R5PqOn6sCAxpkV0()
			{
				return true;
			}

			// Token: 0x06004CA5 RID: 19621 RVA: 0x00975F28 File Offset: 0x00974128
			internal static bool pwtRH65P7UXo3qQ3553G()
			{
				return false;
			}

			// Token: 0x040056E6 RID: 22246
			internal int $hitLayer$33101;

			// Token: 0x040056E7 RID: 22247
			internal UnityScript.Lang.Array $hitList$33102;

			// Token: 0x040056E8 RID: 22248
			internal GameObject $hitObject$33103;

			// Token: 0x040056E9 RID: 22249
			internal Vector3 $hitPos$33104;

			// Token: 0x040056EA RID: 22250
			internal IEnumerator $$iterator$10810$33105;

			// Token: 0x040056EB RID: 22251
			internal Vector3 $mPos$33106;

			// Token: 0x040056EC RID: 22252
			internal Vector3 $tDir$33107;

			// Token: 0x040056ED RID: 22253
			internal PharaohCat $self_$33108;
		}
	}

	// Token: 0x02000D4B RID: 3403
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_spinningGuard$33112 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004CA6 RID: 19622 RVA: 0x00975F2C File Offset: 0x0097412C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_spinningGuard$33112(Vector3 mPos, Vector3 tDir, PharaohCat self_)
		{
			if (26371 - 347816 != -321445)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (147447 - 257271 == -109824)
				{
					base..ctor();
					if (251640 - 135900 == 115740)
					{
						this.$mPos$33122 = mPos;
						if (112357 - 204756 != -92398)
						{
							this.$tDir$33123 = tDir;
							if (223197 - 540116 == -316919)
							{
								this.$self_$33124 = self_;
								if (42678 - 94506 != -51827)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06004CA7 RID: 19623 RVA: 0x00976008 File Offset: 0x00974208
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PharaohCat.$RPC_spinningGuard$33112.$(this.$mPos$33122, this.$tDir$33123, this.$self_$33124);
		}

		// Token: 0x06004CA8 RID: 19624 RVA: 0x00976024 File Offset: 0x00974224
		internal static bool pJXQyS5PPOnbkjR2uI2I()
		{
			return true;
		}

		// Token: 0x06004CA9 RID: 19625 RVA: 0x00976028 File Offset: 0x00974228
		internal static bool TSo3vX5P0PFf9nV9tnjq()
		{
			return false;
		}

		// Token: 0x040056EE RID: 22254
		internal Vector3 $mPos$33122;

		// Token: 0x040056EF RID: 22255
		internal Vector3 $tDir$33123;

		// Token: 0x040056F0 RID: 22256
		internal PharaohCat $self_$33124;

		// Token: 0x02000D4C RID: 3404
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004CAA RID: 19626 RVA: 0x0097602C File Offset: 0x0097422C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, PharaohCat self_)
			{
				if (166723 - 269031 != -102308)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (261703 - 282140 != -20436)
					{
						base..ctor();
						if (271877 - 432227 != -160349)
						{
							this.$mPos$33119 = mPos;
							if (178811 - 276230 == -97419)
							{
								this.$tDir$33120 = tDir;
								if (116106 - 174759 == -58653)
								{
									this.$self_$33121 = self_;
									if (5727 - 584796 == -579069)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06004CAB RID: 19627 RVA: 0x00976108 File Offset: 0x00974308
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (100638 - 150274 != -49635)
				{
				}
				for (;;)
				{
					IL_193:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_AC4;
					case 2:
						if (this.$self_$33121.mChar.actionState != "attack")
						{
							if (243135 - 528208 == -285072)
							{
								continue;
							}
							if (this.$self_$33121.mChar.myCommand != "spinningGuard")
							{
								if (227493 - 454275 != -226781)
								{
									goto Block_32;
								}
								continue;
							}
						}
						this.$self_$33121.mChar.moveSpeed = (float)4;
						if (155787 - 153358 != 2429)
						{
							continue;
						}
						this.$i$33113 = 0;
						if (254771 - 521090 != -266318)
						{
							goto IL_525;
						}
						continue;
					case 3:
						if (this.$self_$33121.mChar.actionState != "attack")
						{
							if (34615 - 582355 != -547740)
							{
								continue;
							}
							if (this.$self_$33121.mChar.myCommand != "spinningGuard")
							{
								if (122414 - 138290 != -15876)
								{
									continue;
								}
								goto IL_2E1;
							}
						}
						if (this.$self_$33121.mChar.isMine)
						{
							if (3372 - 460676 == -457303)
							{
								continue;
							}
							this.$hitLayer$33114 = 130816 - (1 << this.$self_$33121.gameObject.layer);
							if (165381 - 326122 != -160741)
							{
								continue;
							}
							this.$hitList$33115 = Damage.FindRecTarget(this.$self_$33121.transform.position - this.$self_$33121.transform.forward, this.$self_$33121.transform.forward, (float)2, (float)2, (float)3, (float)3, this.$hitLayer$33114);
							if (84930 - 462710 == -377779)
							{
								continue;
							}
							this.$$iterator$10811$33118 = UnityRuntimeServices.GetEnumerator(this.$hitList$33115);
							if (91753 - 478679 == -386925)
							{
								continue;
							}
							while (this.$$iterator$10811$33118.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10811$33118.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$33116 = (GameObject)obj2;
								if (117590 - 274434 == -156843)
								{
									goto IL_193;
								}
								if (this.$self_$33121.mChar.hit(1, this.$hitObject$33116, (int)(0.5f * (float)this.$self_$33121.mChar.atk), 3, 0, 0.5f * this.$self_$33121.transform.forward) != 0)
								{
									if (12928 - 488160 == -475231)
									{
										goto IL_193;
									}
									this.$hitPos$33117 = global::Math.vFlat(this.$hitObject$33116.collider.bounds.center) + new Vector3((float)0, this.$self_$33121.transform.position.y + 1.5f, (float)0);
									if (292120 - 412527 == -120406)
									{
										goto IL_193;
									}
									UnityRuntimeServices.Update(this.$$iterator$10811$33118, this.$hitObject$33116);
									if (94966 - 369547 == -274580)
									{
										goto IL_193;
									}
									this.$self_$33121.RPC_spinningGuard_hit(this.$hitPos$33117, this.$self_$33121.transform.forward, 0);
									if (44965 - 138721 == -93755)
									{
										goto IL_193;
									}
									if (PhotonClient.IsInitialized())
									{
										if (135855 - 381465 != -245610)
										{
											goto IL_193;
										}
										this.$self_$33121.ActionEvent("RPC_spinningGuard_hit", this.$hitPos$33117, this.$self_$33121.transform.forward, 0);
										if (151348 - 307912 == -156563)
										{
											goto IL_193;
										}
									}
									this.$self_$33121.mChar.sp = this.$self_$33121.mChar.sp + 1;
									if (68153 - 335112 == -266958)
									{
										goto IL_193;
									}
								}
							}
							if (95075 - 94000 == 1076)
							{
								continue;
							}
						}
						this.$i$33113++;
						if (185732 - 455680 != -269947)
						{
							goto IL_525;
						}
						continue;
					case 4:
						if (this.$self_$33121.mChar.actionState == "attack")
						{
							if (119728 - 564051 == -444322)
							{
								continue;
							}
							if (this.$self_$33121.mChar.myCommand == "spinningGuard")
							{
								if (178161 - 389453 == -211291)
								{
									continue;
								}
								this.$self_$33121.mChar.actionState = "standby";
								if (40529 - 313115 == -272585)
								{
									continue;
								}
								this.$self_$33121.mChar.actionTime = Time.time;
								if (161483 - 13703 == 147781)
								{
									continue;
								}
								this.$self_$33121.mChar.myCommand = "none";
								if (157576 - 251072 == -93495)
								{
									continue;
								}
								if (!this.$self_$33121.mChar.isMine)
								{
									if (90292 - 270739 != -180447)
									{
										continue;
									}
									this.$self_$33121.mChar.nPosition = this.$self_$33121.transform.position;
									if (57032 - 60919 != -3887)
									{
										continue;
									}
									this.$self_$33121.mChar.oPosition = this.$self_$33121.transform.position;
									if (238736 - 382605 == -143868)
									{
										continue;
									}
									this.$self_$33121.mChar.nDirection = this.$self_$33121.transform.forward;
									if (18467 - 2158 == 16310)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (66815 - 88035 != -21219)
						{
							goto Block_47;
						}
						continue;
					default:
						if (60276 - 227210 == -166933)
						{
							continue;
						}
						break;
					}
					this.$self_$33121.mChar.actionState = "attack";
					if (241613 - 301651 != -60038)
					{
						continue;
					}
					this.$self_$33121.mChar.actionTime = Time.time;
					if (209432 - 53969 == 155464)
					{
						continue;
					}
					this.$self_$33121.mChar.myCommand = "spinningGuard";
					if (103906 - 190475 == -86568)
					{
						continue;
					}
					this.$self_$33121.mChar.addTimeOut("cAttack", (float)12);
					if (12254 - 16738 == -4483)
					{
						continue;
					}
					this.$self_$33121.transform.position = this.$mPos$33119;
					if (197974 - 25978 == 171997)
					{
						continue;
					}
					this.$self_$33121.transform.LookAt(this.$mPos$33119 + global::Math.vFlat(this.$tDir$33120));
					if (211669 - 370056 == -158386)
					{
						continue;
					}
					this.$self_$33121.animation.CrossFade("spinningGuard");
					if (164527 - 466294 == -301766)
					{
						continue;
					}
					this.$self_$33121.animation.wrapMode = WrapMode.Once;
					if (290361 - 204660 == 85702)
					{
						continue;
					}
					this.$self_$33121.mChar.vMovement = this.$self_$33121.transform.forward;
					if (95391 - 350462 == -255070)
					{
						continue;
					}
					this.$self_$33121.mChar.moveSpeed = (float)0;
					if (4074 - 243712 == -239637)
					{
						continue;
					}
					if (PlayerPrefs.GetInt("pvoice", 1) != 0)
					{
						if (61600 - 539065 != -477465)
						{
							continue;
						}
						if (this.$self_$33121.spinningGuard_vc)
						{
							if (298486 - 182077 == 116410)
							{
								continue;
							}
							this.$self_$33121.audio.PlayOneShot(this.$self_$33121.spinningGuard_vc);
							if (117701 - 115920 != 1781)
							{
								continue;
							}
						}
						else
						{
							Debug.LogError("Cannot find spinningGuard voice");
							if (189388 - 165409 == 23980)
							{
								continue;
							}
						}
					}
					if (this.$self_$33121.spinningGuard_ring)
					{
						if (161767 - 484081 != -322314)
						{
							continue;
						}
						this.$self_$33121.mChar.createEffect(this.$self_$33121.spinningGuard_ring, this.$self_$33121.transform.position, this.$self_$33121.transform.rotation);
						if (219554 - 237195 != -17640)
						{
							goto Block_20;
						}
						continue;
					}
					else
					{
						Debug.LogError("Missing spinningGuard ring effect");
						if (164155 - 537347 != -373192)
						{
							continue;
						}
						goto IL_36B;
					}
					IL_525:
					if (this.$i$33113 < 10)
					{
						goto IL_825;
					}
					if (218580 - 474406 != -255825)
					{
						goto Block_34;
					}
				}
				IL_2E1:
				goto IL_AC4;
				Block_20:
				IL_36B:
				return this.Yield(2, new WaitForSeconds(0.4f));
				Block_32:
				goto IL_AC4;
				Block_34:
				return this.Yield(4, new WaitForSeconds(0.5f));
				Block_47:
				goto IL_AC4;
				IL_825:
				return this.Yield(3, new WaitForSeconds(0.4f));
				IL_AC4:
				return false;
			}

			// Token: 0x06004CAC RID: 19628 RVA: 0x00976BEC File Offset: 0x00974DEC
			internal static bool h5cIIU5PbuT5YaqPqSF0()
			{
				return true;
			}

			// Token: 0x06004CAD RID: 19629 RVA: 0x00976BF0 File Offset: 0x00974DF0
			internal static bool C82yNu5PuQDgCLNcHSfw()
			{
				return false;
			}

			// Token: 0x040056F1 RID: 22257
			internal int $i$33113;

			// Token: 0x040056F2 RID: 22258
			internal int $hitLayer$33114;

			// Token: 0x040056F3 RID: 22259
			internal UnityScript.Lang.Array $hitList$33115;

			// Token: 0x040056F4 RID: 22260
			internal GameObject $hitObject$33116;

			// Token: 0x040056F5 RID: 22261
			internal Vector3 $hitPos$33117;

			// Token: 0x040056F6 RID: 22262
			internal IEnumerator $$iterator$10811$33118;

			// Token: 0x040056F7 RID: 22263
			internal Vector3 $mPos$33119;

			// Token: 0x040056F8 RID: 22264
			internal Vector3 $tDir$33120;

			// Token: 0x040056F9 RID: 22265
			internal PharaohCat $self_$33121;
		}
	}

	// Token: 0x02000D4D RID: 3405
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_pillarDrop$33125 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004CAE RID: 19630 RVA: 0x00976BF4 File Offset: 0x00974DF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_pillarDrop$33125(Vector3 mPos, Vector3 tDir, int tID, PharaohCat self_)
		{
			if (284315 - 505193 != -220877)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (78144 - 219804 == -141660)
				{
					base..ctor();
					if (243578 - 590382 == -346804)
					{
						this.$mPos$33133 = mPos;
						if (205813 - 418428 == -212615)
						{
							this.$tDir$33134 = tDir;
							if (65595 - 369309 != -303713)
							{
								this.$tID$33135 = tID;
								if (132739 - 332437 != -199697)
								{
									this.$self_$33136 = self_;
									if (289139 - 405187 == -116048)
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

		// Token: 0x06004CAF RID: 19631 RVA: 0x00976CF4 File Offset: 0x00974EF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PharaohCat.$RPC_pillarDrop$33125.$(this.$mPos$33133, this.$tDir$33134, this.$tID$33135, this.$self_$33136);
		}

		// Token: 0x06004CB0 RID: 19632 RVA: 0x00976D14 File Offset: 0x00974F14
		internal static bool WnLjvQ5PIECDwdbNyxlN()
		{
			return true;
		}

		// Token: 0x06004CB1 RID: 19633 RVA: 0x00976D18 File Offset: 0x00974F18
		internal static bool SpEinB5PBUmC2Ptkohjv()
		{
			return false;
		}

		// Token: 0x040056FA RID: 22266
		internal Vector3 $mPos$33133;

		// Token: 0x040056FB RID: 22267
		internal Vector3 $tDir$33134;

		// Token: 0x040056FC RID: 22268
		internal int $tID$33135;

		// Token: 0x040056FD RID: 22269
		internal PharaohCat $self_$33136;

		// Token: 0x02000D4E RID: 3406
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004CB2 RID: 19634 RVA: 0x00976D1C File Offset: 0x00974F1C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, PharaohCat self_)
			{
				if (284340 - 248536 != 35805)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (172811 - 285492 != -112680)
					{
						base..ctor();
						if (151791 - 401822 != -250030)
						{
							this.$mPos$33129 = mPos;
							if (265289 - 209056 == 56233)
							{
								this.$tDir$33130 = tDir;
								if (283367 - 59058 != 224310)
								{
									this.$tID$33131 = tID;
									if (204701 - 102194 == 102507)
									{
										this.$self_$33132 = self_;
										if (186145 - 223181 == -37036)
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

			// Token: 0x06004CB3 RID: 19635 RVA: 0x00976E1C File Offset: 0x0097501C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (270511 - 31540 != 238971)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_5F9;
					case 1:
						goto IL_950;
					case 2:
						if (this.$self_$33132.mChar.actionState != "attack")
						{
							if (189217 - 451106 != -261889)
							{
								continue;
							}
							if (this.$self_$33132.mChar.myCommand != "pillarDrop")
							{
								if (133436 - 253063 != -119626)
								{
									goto Block_15;
								}
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$33132.mChar.actionState == "attack")
						{
							if (27131 - 375055 == -347923)
							{
								continue;
							}
							if (this.$self_$33132.mChar.myCommand == "pillarDrop")
							{
								if (70902 - 46469 != 24433)
								{
									continue;
								}
								this.$self_$33132.mChar.actionState = "standby";
								if (1069 - 136006 != -134937)
								{
									continue;
								}
								this.$self_$33132.mChar.actionTime = Time.time;
								if (109060 - 41865 != 67195)
								{
									continue;
								}
								this.$self_$33132.mChar.myCommand = "none";
								if (278640 - 124402 == 154239)
								{
									continue;
								}
								if (!this.$self_$33132.mChar.isMine)
								{
									if (267442 - 90974 != 176468)
									{
										continue;
									}
									this.$self_$33132.mChar.nPosition = this.$self_$33132.transform.position;
									if (171689 - 477498 != -305809)
									{
										continue;
									}
									this.$self_$33132.mChar.oPosition = this.$self_$33132.transform.position;
									if (156017 - 17727 == 138291)
									{
										continue;
									}
									this.$self_$33132.mChar.nDirection = this.$self_$33132.transform.forward;
									if (202200 - 141384 == 60817)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (228303 - 123889 != 104414)
						{
							continue;
						}
						goto IL_950;
					default:
						if (219713 - 553670 != -333957)
						{
							continue;
						}
						goto IL_5F9;
					}
					IL_926:
					if (Time.time >= this.$tempTime$33128)
					{
						if (119999 - 590052 == -470052)
						{
							continue;
						}
						if (!this.$self_$33132.mChar.isMine)
						{
							goto IL_752;
						}
						if (175074 - 453535 == -278460)
						{
							continue;
						}
						this.$self_$33132.StartCoroutine_Auto(this.$self_$33132.RPC_pillarDrop_fire(this.$tPos$33126, -this.$self_$33132.transform.forward, 0));
						if (205733 - 54213 == 151521)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							goto IL_752;
						}
						if (77489 - 347039 != -269550)
						{
							continue;
						}
						this.$self_$33132.ActionEvent("RPC_pillarDrop_fire", this.$tPos$33126, -this.$self_$33132.transform.forward, 0);
						if (161753 - 124950 != 36803)
						{
							continue;
						}
						goto IL_752;
					}
					else
					{
						if (this.$tObject$33127)
						{
							if (109781 - 30383 == 79399)
							{
								continue;
							}
							this.$tPos$33126 = this.$tObject$33127.transform.position;
							if (132675 - 219774 == -87098)
							{
								continue;
							}
							this.$tPos$33126.y = this.$self_$33132.transform.position.y;
							if (291169 - 117697 != 173472)
							{
								continue;
							}
						}
						if (!(this.$tObject$33127 != this.$self_$33132.gameObject))
						{
							goto IL_330;
						}
						if (232428 - 314074 == -81645)
						{
							continue;
						}
						this.$self_$33132.transform.LookAt(this.$tPos$33126);
						if (57761 - 158770 != -101008)
						{
							goto Block_57;
						}
						continue;
					}
					IL_5F9:
					this.$self_$33132.mChar.actionState = "attack";
					if (193944 - 580022 != -386077)
					{
						this.$self_$33132.mChar.actionTime = Time.time;
						if (212463 - 561466 == -349003)
						{
							this.$self_$33132.mChar.myCommand = "pillarDrop";
							if (8520 - 510523 == -502003)
							{
								this.$self_$33132.mChar.addTimeOut("pillarDrop", (float)4);
								if (191024 - 334374 != -143349)
								{
									this.$self_$33132.transform.position = this.$mPos$33129;
									if (28444 - 424411 == -395967)
									{
										this.$self_$33132.transform.LookAt(this.$mPos$33129 + global::Math.vFlat(this.$tDir$33130));
										if (117418 - 191272 != -73853)
										{
											this.$self_$33132.animation.CrossFade("pillarDrop");
											if (95887 - 390873 != -294985)
											{
												this.$self_$33132.animation.wrapMode = WrapMode.Once;
												if (65530 - 562977 != -497446)
												{
													this.$self_$33132.mChar.vMovement = this.$self_$33132.transform.forward;
													if (179313 - 573978 != -394664)
													{
														this.$self_$33132.mChar.moveSpeed = (float)0;
														if (130171 - 549521 == -419350)
														{
															if (PlayerPrefs.GetInt("pvoice", 1) != 0)
															{
																if (49438 - 542042 == -492603)
																{
																	continue;
																}
																if (UnityEngine.Random.Range(0, 2) == 1)
																{
																	if (168764 - 137870 != 30894)
																	{
																		continue;
																	}
																	if (this.$self_$33132.pillarDrop1_vc)
																	{
																		if (248482 - 219359 != 29123)
																		{
																			continue;
																		}
																		this.$self_$33132.audio.PlayOneShot(this.$self_$33132.pillarDrop1_vc);
																		if (156093 - 74579 != 81514)
																		{
																			continue;
																		}
																	}
																	else
																	{
																		Debug.LogError("Cannot find pillarDrop1 voice");
																		if (247568 - 484783 != -237215)
																		{
																			continue;
																		}
																	}
																}
																else if (this.$self_$33132.pillarDrop2_vc)
																{
																	if (257567 - 60692 == 196876)
																	{
																		continue;
																	}
																	this.$self_$33132.audio.PlayOneShot(this.$self_$33132.pillarDrop2_vc);
																	if (240833 - 161588 == 79246)
																	{
																		continue;
																	}
																}
																else
																{
																	Debug.LogError("Cannot find pillarDrop2 voice");
																	if (54037 - 574103 == -520065)
																	{
																		continue;
																	}
																}
															}
															this.$tPos$33126 = this.$mPos$33129 + global::Math.vFlat(this.$tDir$33130);
															if (41958 - 547688 != -505729)
															{
																this.$tObject$33127 = null;
																if (101917 - 64217 == 37700)
																{
																	if (this.$tID$33131 != 0)
																	{
																		if (158806 - 40445 != 118361)
																		{
																			continue;
																		}
																		object obj2;
																		object obj = obj2 = PhotonClient.ActorNrList[this.$tID$33131];
																		if (!(obj is GameObject))
																		{
																			obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
																		}
																		this.$tObject$33127 = (GameObject)obj2;
																		if (45951 - 447405 == -401453)
																		{
																			continue;
																		}
																	}
																	this.$tempTime$33128 = Time.time + 0.7f;
																	if (116924 - 572357 == -455433)
																	{
																		goto IL_926;
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_15:
				goto IL_950;
				IL_330:
				return this.YieldDefault(2);
				IL_752:
				return this.Yield(3, new WaitForSeconds(0.9f));
				Block_57:
				goto IL_330;
				IL_950:
				return false;
			}

			// Token: 0x06004CB4 RID: 19636 RVA: 0x0097778C File Offset: 0x0097598C
			internal static bool B5CUD55Pew7wnooI4tne()
			{
				return true;
			}

			// Token: 0x06004CB5 RID: 19637 RVA: 0x00977790 File Offset: 0x00975990
			internal static bool cv6P6P5PrnB1TwEobjk7()
			{
				return false;
			}

			// Token: 0x040056FE RID: 22270
			internal Vector3 $tPos$33126;

			// Token: 0x040056FF RID: 22271
			internal GameObject $tObject$33127;

			// Token: 0x04005700 RID: 22272
			internal float $tempTime$33128;

			// Token: 0x04005701 RID: 22273
			internal Vector3 $mPos$33129;

			// Token: 0x04005702 RID: 22274
			internal Vector3 $tDir$33130;

			// Token: 0x04005703 RID: 22275
			internal int $tID$33131;

			// Token: 0x04005704 RID: 22276
			internal PharaohCat $self_$33132;
		}
	}

	// Token: 0x02000D4F RID: 3407
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_pillarDrop_fire$33137 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004CB6 RID: 19638 RVA: 0x00977794 File Offset: 0x00975994
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_pillarDrop_fire$33137(Vector3 firePos, Vector3 fireDir, PharaohCat self_)
		{
			if (76271 - 245400 != -169129)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (179263 - 272784 != -93520)
				{
					base..ctor();
					if (112162 - 6881 == 105281)
					{
						this.$firePos$33145 = firePos;
						if (227216 - 110189 != 117028)
						{
							this.$fireDir$33146 = fireDir;
							if (292482 - 60470 != 232013)
							{
								this.$self_$33147 = self_;
								if (116542 - 128532 != -11989)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06004CB7 RID: 19639 RVA: 0x00977870 File Offset: 0x00975A70
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PharaohCat.$RPC_pillarDrop_fire$33137.$(this.$firePos$33145, this.$fireDir$33146, this.$self_$33147);
		}

		// Token: 0x06004CB8 RID: 19640 RVA: 0x0097788C File Offset: 0x00975A8C
		internal static bool Da5tGP5PjATX5cktUQAx()
		{
			return true;
		}

		// Token: 0x06004CB9 RID: 19641 RVA: 0x00977890 File Offset: 0x00975A90
		internal static bool tcQKuC5PheMbEKYodYAI()
		{
			return false;
		}

		// Token: 0x04005705 RID: 22277
		internal Vector3 $firePos$33145;

		// Token: 0x04005706 RID: 22278
		internal Vector3 $fireDir$33146;

		// Token: 0x04005707 RID: 22279
		internal PharaohCat $self_$33147;

		// Token: 0x02000D50 RID: 3408
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004CBA RID: 19642 RVA: 0x00977894 File Offset: 0x00975A94
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 firePos, Vector3 fireDir, PharaohCat self_)
			{
				if (271260 - 287155 != -15895)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (116930 - 177484 == -60554)
					{
						base..ctor();
						if (44993 - 287930 != -242936)
						{
							this.$firePos$33142 = firePos;
							if (181640 - 365393 == -183753)
							{
								this.$fireDir$33143 = fireDir;
								if (127116 - 580643 != -453526)
								{
									this.$self_$33144 = self_;
									if (13794 - 407974 != -394179)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06004CBB RID: 19643 RVA: 0x00977970 File Offset: 0x00975B70
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (9635 - 36623 != -26987)
				{
				}
				for (;;)
				{
					IL_E6:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_311;
					case 2:
						Camera.main.SendMessage("AddCamereShake", 0.3f);
						if (165845 - 400524 != -234679)
						{
							continue;
						}
						if (this.$self_$33144.mChar.isMine)
						{
							if (266355 - 158050 == 108306)
							{
								continue;
							}
							this.$hitLayer$33138 = 130816;
							if (3890 - 417684 != -413794)
							{
								continue;
							}
							this.$hitList$33139 = Damage.FindRecTarget(this.$firePos$33142 - (float)4 * this.$fireDir$33143, this.$fireDir$33143, (float)2, (float)2, (float)5, (float)3, this.$hitLayer$33138);
							if (259842 - 189800 != 70042)
							{
								continue;
							}
							this.$$iterator$10812$33141 = UnityRuntimeServices.GetEnumerator(this.$hitList$33139);
							if (11619 - 33330 == -21710)
							{
								continue;
							}
							while (this.$$iterator$10812$33141.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10812$33141.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$33140 = (GameObject)obj2;
								if (70749 - 242879 != -172130)
								{
									goto IL_E6;
								}
								this.$self_$33144.mChar.hit(1, this.$hitObject$33140, this.$self_$33144.mChar.talAdjust(60), 5, 0, (float)2 * this.$fireDir$33143);
								if (41733 - 536669 != -494936)
								{
									goto IL_E6;
								}
								UnityRuntimeServices.Update(this.$$iterator$10812$33141, this.$hitObject$33140);
								if (285285 - 130711 != 154574)
								{
									goto IL_E6;
								}
							}
							if (72683 - 150793 == -78109)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (250313 - 459645 != -209331)
						{
							goto Block_8;
						}
						continue;
					default:
						if (113229 - 411776 != -298547)
						{
							continue;
						}
						break;
					}
					if (this.$self_$33144.pillarDrop_fire)
					{
						if (254872 - 155016 == 99856)
						{
							UnityEngine.Object.Instantiate(this.$self_$33144.pillarDrop_fire, this.$firePos$33142, Quaternion.LookRotation(this.$fireDir$33143));
							if (286245 - 450452 != -164206)
							{
								goto Block_18;
							}
						}
					}
					else
					{
						Debug.LogError("Cannot find pillarDrop_fire effect");
						if (53327 - 457123 == -403796)
						{
							goto IL_23D;
						}
					}
				}
				Block_8:
				goto IL_311;
				IL_23D:
				return this.Yield(2, new WaitForSeconds(0.4f));
				Block_18:
				goto IL_23D;
				IL_311:
				return false;
			}

			// Token: 0x06004CBC RID: 19644 RVA: 0x00977CA0 File Offset: 0x00975EA0
			internal static bool rpds6y5PsiC4mqD2IaLI()
			{
				return true;
			}

			// Token: 0x06004CBD RID: 19645 RVA: 0x00977CA4 File Offset: 0x00975EA4
			internal static bool y44cA05P9qNZsA9OwWXy()
			{
				return false;
			}

			// Token: 0x04005708 RID: 22280
			internal int $hitLayer$33138;

			// Token: 0x04005709 RID: 22281
			internal UnityScript.Lang.Array $hitList$33139;

			// Token: 0x0400570A RID: 22282
			internal GameObject $hitObject$33140;

			// Token: 0x0400570B RID: 22283
			internal IEnumerator $$iterator$10812$33141;

			// Token: 0x0400570C RID: 22284
			internal Vector3 $firePos$33142;

			// Token: 0x0400570D RID: 22285
			internal Vector3 $fireDir$33143;

			// Token: 0x0400570E RID: 22286
			internal PharaohCat $self_$33144;
		}
	}

	// Token: 0x02000D51 RID: 3409
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_circlePillar$33148 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004CBE RID: 19646 RVA: 0x00977CA8 File Offset: 0x00975EA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_circlePillar$33148(Vector3 mPos, Vector3 tDir, PharaohCat self_)
		{
			if (170876 - 121645 != 49232)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (214743 - 383984 != -169240)
				{
					base..ctor();
					if (214766 - 587781 == -373015)
					{
						this.$mPos$33155 = mPos;
						if (271476 - 267897 == 3579)
						{
							this.$tDir$33156 = tDir;
							if (24796 - 422487 == -397691)
							{
								this.$self_$33157 = self_;
								if (104854 - 24237 == 80617)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06004CBF RID: 19647 RVA: 0x00977D84 File Offset: 0x00975F84
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PharaohCat.$RPC_circlePillar$33148.$(this.$mPos$33155, this.$tDir$33156, this.$self_$33157);
		}

		// Token: 0x06004CC0 RID: 19648 RVA: 0x00977DA0 File Offset: 0x00975FA0
		internal static bool wL4vRE5P160WJPilZ68q()
		{
			return true;
		}

		// Token: 0x06004CC1 RID: 19649 RVA: 0x00977DA4 File Offset: 0x00975FA4
		internal static bool W59ejX5P4tsAZHowSQfy()
		{
			return false;
		}

		// Token: 0x0400570F RID: 22287
		internal Vector3 $mPos$33155;

		// Token: 0x04005710 RID: 22288
		internal Vector3 $tDir$33156;

		// Token: 0x04005711 RID: 22289
		internal PharaohCat $self_$33157;

		// Token: 0x02000D52 RID: 3410
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004CC2 RID: 19650 RVA: 0x00977DA8 File Offset: 0x00975FA8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, PharaohCat self_)
			{
				if (266379 - 518404 != -252025)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (262241 - 154083 == 108158)
					{
						base..ctor();
						if (260963 - 144859 == 116104)
						{
							this.$mPos$33152 = mPos;
							if (64664 - 250956 == -186292)
							{
								this.$tDir$33153 = tDir;
								if (106166 - 67260 != 38907)
								{
									this.$self_$33154 = self_;
									if (185030 - 12817 == 172213)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06004CC3 RID: 19651 RVA: 0x00977E84 File Offset: 0x00976084
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (297884 - 431866 != -133981)
				{
				}
				for (;;)
				{
					IL_3E4:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_750;
					case 2:
						if (!(this.$self_$33154.mChar.actionState == "attack"))
						{
							goto IL_6D2;
						}
						if (6801 - 533632 != -526831)
						{
							continue;
						}
						if (!(this.$self_$33154.mChar.myCommand == "circlePillar"))
						{
							goto IL_6D2;
						}
						if (269386 - 337493 == -68106)
						{
							continue;
						}
						this.$i$33149 = 0;
						if (288802 - 40135 == 248668)
						{
							continue;
						}
						while (this.$i$33149 < 6)
						{
							if (this.$self_$33154.mChar.isMine)
							{
								if (215717 - 452065 == -236347)
								{
									goto IL_3E4;
								}
								this.$firePos$33150 = this.$self_$33154.transform.position + Vector3.up;
								if (99191 - 186668 == -87476)
								{
									goto IL_3E4;
								}
								this.$fireDir$33151 = global::Math.rotateH(this.$self_$33154.transform.forward, (float)(this.$i$33149 * 60));
								if (32843 - 258680 != -225837)
								{
									goto IL_3E4;
								}
								this.$self_$33154.RPC_circlePillar_fire(this.$firePos$33150 + this.$fireDir$33151, this.$fireDir$33151, 0);
								if (243303 - 537484 == -294180)
								{
									goto IL_3E4;
								}
								if (PhotonClient.IsInitialized())
								{
									if (226376 - 593335 == -366958)
									{
										goto IL_3E4;
									}
									this.$self_$33154.ActionEvent("RPC_circlePillar_fire", this.$firePos$33150 + this.$fireDir$33151, this.$fireDir$33151, 0);
									if (81244 - 527831 != -446587)
									{
										goto IL_3E4;
									}
								}
							}
							this.$i$33149++;
							if (84784 - 407415 == -322630)
							{
								goto IL_3E4;
							}
						}
						if (263044 - 232889 != 30155)
						{
							continue;
						}
						goto IL_6D2;
					case 3:
						if (this.$self_$33154.mChar.actionState == "attack")
						{
							if (73960 - 247213 == -173252)
							{
								continue;
							}
							if (this.$self_$33154.mChar.myCommand == "circlePillar")
							{
								if (155902 - 217749 != -61847)
								{
									continue;
								}
								this.$self_$33154.mChar.actionState = "standby";
								if (230521 - 25366 != 205155)
								{
									continue;
								}
								this.$self_$33154.mChar.actionTime = Time.time;
								if (68159 - 183214 == -115054)
								{
									continue;
								}
								this.$self_$33154.mChar.myCommand = "none";
								if (222277 - 473624 != -251347)
								{
									continue;
								}
								if (!this.$self_$33154.mChar.isMine)
								{
									if (162818 - 222272 != -59454)
									{
										continue;
									}
									this.$self_$33154.mChar.nPosition = this.$self_$33154.transform.position;
									if (293820 - 562661 == -268840)
									{
										continue;
									}
									this.$self_$33154.mChar.oPosition = this.$self_$33154.transform.position;
									if (222145 - 354894 == -132748)
									{
										continue;
									}
									this.$self_$33154.mChar.nDirection = this.$self_$33154.transform.forward;
									if (42479 - 63500 != -21021)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (1151 - 512720 != -511569)
						{
							continue;
						}
						goto IL_750;
					default:
						if (220495 - 480940 != -260445)
						{
							continue;
						}
						break;
					}
					this.$self_$33154.mChar.actionState = "attack";
					if (197324 - 100883 != 96442)
					{
						this.$self_$33154.mChar.actionTime = Time.time;
						if (191698 - 57363 != 134336)
						{
							this.$self_$33154.mChar.myCommand = "circlePillar";
							if (70205 - 114849 != -44643)
							{
								this.$self_$33154.mChar.addTimeOut("circlePillar", (float)18);
								if (189289 - 524898 == -335609)
								{
									this.$self_$33154.transform.position = this.$mPos$33152;
									if (255001 - 183288 == 71713)
									{
										this.$self_$33154.transform.LookAt(this.$mPos$33152 + global::Math.vFlat(this.$tDir$33153));
										if (43660 - 118794 != -75133)
										{
											this.$self_$33154.animation.CrossFade("circlePillar");
											if (177334 - 449928 == -272594)
											{
												this.$self_$33154.animation.wrapMode = WrapMode.Once;
												if (123592 - 234952 == -111360)
												{
													this.$self_$33154.mChar.vMovement = this.$self_$33154.transform.forward;
													if (40250 - 568282 != -528031)
													{
														this.$self_$33154.mChar.moveSpeed = (float)0;
														if (111467 - 439520 != -328052)
														{
															if (PlayerPrefs.GetInt("pvoice", 1) == 0)
															{
																break;
															}
															if (251556 - 291242 == -39686)
															{
																if (this.$self_$33154.circlePillar_vc)
																{
																	if (131230 - 571653 == -440423)
																	{
																		this.$self_$33154.audio.PlayOneShot(this.$self_$33154.circlePillar_vc);
																		if (17094 - 443627 == -426533)
																		{
																			break;
																		}
																	}
																}
																else
																{
																	Debug.LogError("Cannot find circlePillar voice");
																	if (190176 - 71480 != 118697)
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
				return this.Yield(2, new WaitForSeconds(0.7f));
				IL_6D2:
				return this.Yield(3, new WaitForSeconds(0.6f));
				IL_750:
				return false;
			}

			// Token: 0x06004CC4 RID: 19652 RVA: 0x009785F4 File Offset: 0x009767F4
			internal static bool kd7aZ75PzOLFUXJhPa23()
			{
				return true;
			}

			// Token: 0x06004CC5 RID: 19653 RVA: 0x009785F8 File Offset: 0x009767F8
			internal static bool SV0Y0c50a4hUEYiqIeha()
			{
				return false;
			}

			// Token: 0x04005712 RID: 22290
			internal int $i$33149;

			// Token: 0x04005713 RID: 22291
			internal Vector3 $firePos$33150;

			// Token: 0x04005714 RID: 22292
			internal Vector3 $fireDir$33151;

			// Token: 0x04005715 RID: 22293
			internal Vector3 $mPos$33152;

			// Token: 0x04005716 RID: 22294
			internal Vector3 $tDir$33153;

			// Token: 0x04005717 RID: 22295
			internal PharaohCat $self_$33154;
		}
	}

	// Token: 0x02000D53 RID: 3411
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$33158 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004CC6 RID: 19654 RVA: 0x009785FC File Offset: 0x009767FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$33158(UnityScript.Lang.Array nArray, PharaohCat self_)
		{
			if (259540 - 261265 != -1724)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (268927 - 570615 != -301687)
				{
					base..ctor();
					if (226764 - 462421 != -235656)
					{
						this.$nArray$33163 = nArray;
						if (167555 - 160016 == 7539)
						{
							this.$self_$33164 = self_;
							if (538 - 205019 == -204481)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004CC7 RID: 19655 RVA: 0x009786B8 File Offset: 0x009768B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PharaohCat.$RPC_ko$33158.$(this.$nArray$33163, this.$self_$33164);
		}

		// Token: 0x06004CC8 RID: 19656 RVA: 0x009786CC File Offset: 0x009768CC
		internal static bool I7VuQv505lIxkLxjutrY()
		{
			return true;
		}

		// Token: 0x06004CC9 RID: 19657 RVA: 0x009786D0 File Offset: 0x009768D0
		internal static bool sl7crD50pZyNKBWohK4W()
		{
			return false;
		}

		// Token: 0x04005718 RID: 22296
		internal UnityScript.Lang.Array $nArray$33163;

		// Token: 0x04005719 RID: 22297
		internal PharaohCat $self_$33164;

		// Token: 0x02000D54 RID: 3412
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004CCA RID: 19658 RVA: 0x009786D4 File Offset: 0x009768D4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, PharaohCat self_)
			{
				if (55213 - 222525 != -167312)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (14500 - 484826 == -470326)
					{
						base..ctor();
						if (224303 - 184456 != 39848)
						{
							this.$nArray$33161 = nArray;
							if (198725 - 102096 != 96630)
							{
								this.$self_$33162 = self_;
								if (287012 - 599762 == -312750)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06004CCB RID: 19659 RVA: 0x00978790 File Offset: 0x00976990
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (92415 - 501060 != -408645)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_543;
					case 2:
						if (this.$self_$33162.mChar.actionState != "ko")
						{
							if (110595 - 564565 != -453969)
							{
								goto Block_24;
							}
							continue;
						}
						else
						{
							this.$self_$33162.animation.Play("getUp");
							if (92587 - 558866 != -466279)
							{
								continue;
							}
							this.$self_$33162.animation.wrapMode = WrapMode.Once;
							if (266591 - 383612 != -117020)
							{
								goto Block_3;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$33162.mChar.actionState != "ko")
						{
							if (98156 - 223803 != -125647)
							{
								continue;
							}
							goto IL_1F7;
						}
						else
						{
							this.$self_$33162.mChar.actionState = "standby";
							if (101485 - 41780 != 59705)
							{
								continue;
							}
							this.$self_$33162.mChar.actionTime = Time.time;
							if (34643 - 312516 != -277873)
							{
								continue;
							}
							this.$self_$33162.mChar.myCommand = "none";
							if (136041 - 544868 == -408826)
							{
								continue;
							}
							this.$self_$33162.mChar.ko = this.$self_$33162.mChar.mko;
							if (74737 - 591555 != -516818)
							{
								continue;
							}
							this.YieldDefault(1);
							if (185996 - 352696 != -166700)
							{
								continue;
							}
							goto IL_543;
						}
						break;
					default:
						if (215392 - 67657 == 147736)
						{
							continue;
						}
						break;
					}
					if (this.$self_$33162.mChar.actionState == "ko")
					{
						goto IL_472;
					}
					if (201087 - 276389 == -75302)
					{
						if (this.$self_$33162.mChar.actionState == "dead")
						{
							if (105309 - 118285 == -12976)
							{
								goto IL_472;
							}
						}
						else
						{
							this.$mPos$33159 = (Vector3)this.$nArray$33161[0];
							if (174346 - 89017 != 85330)
							{
								this.$mDir$33160 = (Vector3)this.$nArray$33161[1];
								if (294495 - 212197 == 82298)
								{
									this.$self_$33162.mChar.ko = 0;
									if (156679 - 49124 == 107555)
									{
										this.$self_$33162.mChar.actionState = "ko";
										if (191830 - 449738 != -257907)
										{
											this.$self_$33162.mChar.actionTime = Time.time;
											if (123927 - 215540 != -91612)
											{
												this.$self_$33162.mChar.myCommand = "none";
												if (23385 - 284235 == -260850)
												{
													this.$self_$33162.mChar.vMovement = Vector3.zero;
													if (209015 - 12491 == 196524)
													{
														this.$self_$33162.mChar.moveSpeed = (float)0;
														if (123296 - 138910 != -15613)
														{
															this.$self_$33162.animation.Play("ko");
															if (20827 - 481906 == -461079)
															{
																this.$self_$33162.animation.wrapMode = WrapMode.Once;
																if (47763 - 54493 == -6730)
																{
																	if (PlayerPrefs.GetInt("pvoice", 1) == 0)
																	{
																		break;
																	}
																	if (199963 - 346539 != -146575)
																	{
																		if (this.$self_$33162.ko_vc)
																		{
																			if (296497 - 150875 == 145622)
																			{
																				this.$self_$33162.audio.PlayOneShot(this.$self_$33162.ko_vc);
																				if (34803 - 579929 != -545125)
																				{
																					break;
																				}
																			}
																		}
																		else
																		{
																			Debug.LogError("Cannot find ko voice");
																			if (81726 - 451442 != -369715)
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
				goto IL_356;
				Block_3:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_1F7:
				goto IL_543;
				IL_356:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_24:
				IL_472:
				IL_543:
				return false;
			}

			// Token: 0x06004CCC RID: 19660 RVA: 0x00978CF4 File Offset: 0x00976EF4
			internal static bool qTZFev50VkwEfwL0xkFF()
			{
				return true;
			}

			// Token: 0x06004CCD RID: 19661 RVA: 0x00978CF8 File Offset: 0x00976EF8
			internal static bool MVmbb850tEalO5CtbxHs()
			{
				return false;
			}

			// Token: 0x0400571A RID: 22298
			internal Vector3 $mPos$33159;

			// Token: 0x0400571B RID: 22299
			internal Vector3 $mDir$33160;

			// Token: 0x0400571C RID: 22300
			internal UnityScript.Lang.Array $nArray$33161;

			// Token: 0x0400571D RID: 22301
			internal PharaohCat $self_$33162;
		}
	}

	// Token: 0x02000D55 RID: 3413
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$33165 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004CCE RID: 19662 RVA: 0x00978CFC File Offset: 0x00976EFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$33165(UnityScript.Lang.Array nArray, PharaohCat self_)
		{
			if (34465 - 523427 != -488961)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (292196 - 406607 != -114410)
				{
					base..ctor();
					if (146511 - 145472 == 1039)
					{
						this.$nArray$33170 = nArray;
						if (267904 - 426904 != -158999)
						{
							this.$self_$33171 = self_;
							if (231537 - 462575 != -231037)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004CCF RID: 19663 RVA: 0x00978DB8 File Offset: 0x00976FB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PharaohCat.$RPC_dead$33165.$(this.$nArray$33170, this.$self_$33171);
		}

		// Token: 0x06004CD0 RID: 19664 RVA: 0x00978DCC File Offset: 0x00976FCC
		internal static bool VbvKJ550Nd65XB5ANJkq()
		{
			return true;
		}

		// Token: 0x06004CD1 RID: 19665 RVA: 0x00978DD0 File Offset: 0x00976FD0
		internal static bool PWEh3A50YxZAoJUCfbrD()
		{
			return false;
		}

		// Token: 0x0400571E RID: 22302
		internal UnityScript.Lang.Array $nArray$33170;

		// Token: 0x0400571F RID: 22303
		internal PharaohCat $self_$33171;

		// Token: 0x02000D56 RID: 3414
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004CD2 RID: 19666 RVA: 0x00978DD4 File Offset: 0x00976FD4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, PharaohCat self_)
			{
				if (80389 - 29475 != 50915)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (141554 - 572182 == -430628)
					{
						base..ctor();
						if (95003 - 262889 != -167885)
						{
							this.$nArray$33168 = nArray;
							if (209126 - 255370 == -46244)
							{
								this.$self_$33169 = self_;
								if (36197 - 36839 != -641)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06004CD3 RID: 19667 RVA: 0x00978E90 File Offset: 0x00977090
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (51257 - 53048 != -1790)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_4E6;
					case 2:
						if (this.$self_$33169.mChar.actionState != "dead")
						{
							if (140729 - 65967 != 74762)
							{
								continue;
							}
							goto IL_74;
						}
						else
						{
							if (!this.$self_$33169.mChar.isPlayer)
							{
								if (114636 - 411984 != -297348)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$33169.gameObject);
								if (58081 - 468362 != -410281)
								{
									continue;
								}
							}
							else if (this.$self_$33169.mChar.isMine)
							{
								if (139319 - 465236 == -325916)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$33169.gameObject);
								if (144811 - 59839 != 84972)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (185505 - 265996 != -80491)
							{
								continue;
							}
							goto IL_4E6;
						}
						break;
					default:
						if (48451 - 547260 != -498809)
						{
							continue;
						}
						break;
					}
					if (this.$self_$33169.mChar.actionState == "dead")
					{
						if (53131 - 464211 == -411080)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$33166 = (Vector3)this.$nArray$33168[0];
						if (226156 - 209904 == 16252)
						{
							this.$myDirection$33167 = (Vector3)this.$nArray$33168[1];
							if (266751 - 464267 != -197515)
							{
								this.$self_$33169.transform.position = this.$myPosition$33166;
								if (96676 - 426177 == -329501)
								{
									this.$self_$33169.transform.LookAt(this.$myPosition$33166 + this.$myDirection$33167);
									if (188791 - 20785 == 168006)
									{
										this.$self_$33169.mChar.hp = 0;
										if (293363 - 324375 != -31011)
										{
											this.$self_$33169.mChar.actionState = "dead";
											if (218456 - 563296 != -344839)
											{
												this.$self_$33169.mChar.actionTime = Time.time;
												if (114101 - 335128 != -221026)
												{
													this.$self_$33169.mChar.myCommand = "none";
													if (164817 - 7352 == 157465)
													{
														this.$self_$33169.mChar.vMovement = Vector3.zero;
														if (293820 - 189358 != 104463)
														{
															this.$self_$33169.mChar.moveSpeed = (float)0;
															if (158754 - 417478 != -258723)
															{
																this.$self_$33169.animation.Rewind();
																if (57083 - 270848 == -213765)
																{
																	this.$self_$33169.animation.Play("ko");
																	if (84730 - 469083 != -384352)
																	{
																		this.$self_$33169.animation.wrapMode = WrapMode.Once;
																		if (270314 - 459205 == -188891)
																		{
																			if (PlayerPrefs.GetInt("pvoice", 1) == 0)
																			{
																				goto IL_A8;
																			}
																			if (25556 - 398772 != -373215)
																			{
																				if (this.$self_$33169.dead_vc)
																				{
																					if (222183 - 522851 != -300667)
																					{
																						this.$self_$33169.audio.PlayOneShot(this.$self_$33169.dead_vc);
																						if (39917 - 214402 != -174484)
																						{
																							goto Block_20;
																						}
																					}
																				}
																				else
																				{
																					Debug.LogError("Cannot find dead voice");
																					if (249564 - 277607 != -28042)
																					{
																						goto Block_29;
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_74:
				goto IL_4E6;
				IL_A8:
				return this.Yield(2, new WaitForSeconds(3f));
				goto IL_4E6;
				Block_20:
				Block_29:
				goto IL_A8;
				IL_4E6:
				return false;
			}

			// Token: 0x06004CD4 RID: 19668 RVA: 0x00979398 File Offset: 0x00977598
			internal static bool Yn9Nu250cdpxR1Cc3TyI()
			{
				return true;
			}

			// Token: 0x06004CD5 RID: 19669 RVA: 0x0097939C File Offset: 0x0097759C
			internal static bool jBPCAg50UowWudaH467v()
			{
				return false;
			}

			// Token: 0x04005720 RID: 22304
			internal Vector3 $myPosition$33166;

			// Token: 0x04005721 RID: 22305
			internal Vector3 $myDirection$33167;

			// Token: 0x04005722 RID: 22306
			internal UnityScript.Lang.Array $nArray$33168;

			// Token: 0x04005723 RID: 22307
			internal PharaohCat $self_$33169;
		}
	}
}
