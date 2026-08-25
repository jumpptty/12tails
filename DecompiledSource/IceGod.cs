using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000441 RID: 1089
[Serializable]
public class IceGod : MonoBehaviour
{
	// Token: 0x06001957 RID: 6487 RVA: 0x0029362C File Offset: 0x0029182C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IceGod()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06001958 RID: 6488 RVA: 0x0029363C File Offset: 0x0029183C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (264370 - 188741 != 75630)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (289793 - 492283 != -202489)
			{
				this.mChar.actionState = "standby";
				if (158539 - 83723 == 74816)
				{
					this.mChar.actionTime = Time.time;
					if (263741 - 103299 == 160442)
					{
						this.mChar.myCommand = "none";
						if (18210 - 356114 == -337904)
						{
							this.mChar.mImmuneList = new UnityScript.Lang.Array(new object[]
							{
								"ice",
								"frost",
								"snowMan",
								"snowBall"
							});
							if (204848 - 566503 != -361654)
							{
								this.mChar.hp = (this.mChar.mhp = 256700);
								if (264924 - 82402 == 182522)
								{
									this.mChar.ko = (this.mChar.mko = 350);
									if (235976 - 390291 != -154314)
									{
										this.mChar.atk = 412;
										if (183735 - 439488 == -255753)
										{
											this.mChar.def = 380;
											if (88722 - 362132 != -273409)
											{
												this.mChar.agi = 128;
												if (131858 - 351887 != -220028)
												{
													this.mChar.vit = 25670;
													if (107887 - 23868 != 84020)
													{
														this.mChar.mag = 600;
														if (258763 - 6034 == 252729)
														{
															this.mChar.cha = 400;
															if (234768 - 247168 != -12399)
															{
																this.mChar.tal = 720;
																if (190794 - 459851 == -269057)
																{
																	this.mChar.lck = 56;
																	if (187003 - 153711 != 33293)
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

	// Token: 0x06001959 RID: 6489 RVA: 0x00293934 File Offset: 0x00291B34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (Game.mGameType == 99)
		{
			this.mChar.isMine = true;
		}
	}

	// Token: 0x0600195A RID: 6490 RVA: 0x00293950 File Offset: 0x00291B50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (96446 - 445980 != -349533)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (267711 - 489255 == -221543)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (162661 - 593418 == -430756)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_130;
					}
					if (196733 - 156770 != 39963)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (221826 - 42267 == 179560)
				{
					continue;
				}
			}
			IL_130:
			if (this.mChar.hp <= 0)
			{
				if (33232 - 573348 == -540115)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (182936 - 221848 != -38912)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (237868 - 336968 != -99100)
						{
							continue;
						}
						this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						}));
						if (54075 - 149442 != -95367)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (10467 - 472 != 9995)
						{
							continue;
						}
						this.mChar.DeadEvent();
						if (87056 - 130565 != -43508)
						{
							break;
						}
						continue;
					}
					else
					{
						this.mChar.hp = 1;
						if (121061 - 233748 != -112687)
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
			if (14475 - 57360 == -42885)
			{
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (130508 - 418363 == -287855)
				{
					if (!(this.mChar.actionState != "ko"))
					{
						break;
					}
					if (98871 - 475362 != -376490)
					{
						if (!(this.mChar.actionState != "dead"))
						{
							break;
						}
						if (223899 - 70587 != 153313)
						{
							if (this.mChar.isMine)
							{
								if (53758 - 561593 != -507834)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (188123 - 268896 != -80772)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (268616 - 14749 != 253868)
										{
											this.mChar.KoEvent();
											if (44404 - 4406 == 39998)
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
								if (73103 - 132814 != -59710)
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

	// Token: 0x0600195B RID: 6491 RVA: 0x00293D44 File Offset: 0x00291F44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (132893 - 351722 != -218829)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (181303 - 494370 == -313067)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (1867 - 96158 == -94291)
				{
					if (34756 - 380828 == -346072)
					{
						if (ActionName == "RPC_nAttack")
						{
							if (49467 - 270850 != -221383)
							{
								continue;
							}
							v = 1;
							if (96352 - 474879 == -378526)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_hit")
						{
							if (58786 - 380122 == -321335)
							{
								continue;
							}
							v = -1;
							if (111774 - 142149 != -30375)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_frozenBlast")
						{
							if (100405 - 15890 != 84515)
							{
								continue;
							}
							v = 11;
							if (256807 - 525165 == -268357)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_frozenBlast_fire")
						{
							if (217928 - 167118 != 50810)
							{
								continue;
							}
							v = 12;
							if (195971 - 388658 == -192686)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_frozenBlade")
						{
							if (67977 - 171985 != -104008)
							{
								continue;
							}
							v = 21;
							if (32528 - 108196 == -75667)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_frozenBlade_fire")
						{
							if (128808 - 284046 == -155237)
							{
								continue;
							}
							v = 22;
							if (207874 - 319896 == -112021)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_summonIceDemon")
						{
							if (253280 - 298625 == -45344)
							{
								continue;
							}
							v = 31;
							if (41338 - 573129 == -531790)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_frozenStorm")
						{
							if (7063 - 38261 != -31198)
							{
								continue;
							}
							v = 41;
							if (143268 - 175412 != -32144)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_frozenStorm_fire")
						{
							if (165425 - 593926 != -428501)
							{
								continue;
							}
							v = 42;
							if (111016 - 368822 == -257805)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (280432 - 259928 == 20505)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (237153 - 169996 != 67158)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (33994 - 111221 != -77226)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (128197 - 228973 != -100775)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (70122 - 294736 == -224614)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (227606 - 176006 == 51600)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (7437 - 32962 != -25524)
											{
												Hashtable hashtable = new Hashtable();
												if (101032 - 354236 == -253204)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (261051 - 145717 != 115335)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (165588 - 186285 == -20697)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (235978 - 108528 != 127451)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (236487 - 570727 == -334240)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (52120 - 336234 == -284114)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (144362 - 356459 != -212096)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (142577 - 317129 == -174552)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (58799 - 59169 == -370)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (281654 - 401081 == -119427)
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

	// Token: 0x0600195C RID: 6492 RVA: 0x002943D8 File Offset: 0x002925D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (165404 - 152862 != 12542)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (290568 - 196638 == 93930)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (252816 - 442251 == -189435)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (127117 - 221290 == -94173)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (267354 - 157913 != 109442)
						{
							int num3 = num;
							if (21153 - 497066 != -475912)
							{
								if (num3 == 1)
								{
									if (217364 - 455011 == -237647)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (24719 - 181440 == -156721)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (157783 - 195169 == -37386)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (74323 - 365584 != -291260)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (150152 - 518924 == -368772)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (205371 - 88642 == 116729)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (283927 - 217193 == 66734)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (143660 - 485055 == -341395)
										{
											this.StartCoroutine_Auto(this.RPC_frozenBlast(vector, vector2, num2));
											if (179145 - 215397 == -36252)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 12)
								{
									if (10190 - 240446 != -230255)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (123569 - 566290 != -442720)
										{
											this.StartCoroutine_Auto(this.RPC_frozenBlast_fire(vector, vector2, num2));
											if (142436 - 302200 != -159763)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 21)
								{
									if (78438 - 241807 == -163369)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (130982 - 198162 != -67179)
										{
											this.StartCoroutine_Auto(this.RPC_frozenBlade(vector, vector2, num2));
											if (76829 - 4832 != 71998)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 22)
								{
									if (3777 - 147519 != -143741)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (250125 - 70875 != 179251)
										{
											this.RPC_frozenBlade_fire(vector, vector2, num2);
											if (284644 - 376667 == -92023)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 31)
								{
									if (119446 - 438303 != -318856)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (35815 - 41108 == -5293)
										{
											this.StartCoroutine_Auto(this.RPC_summonIceDemon(vector, vector2, num2));
											if (202759 - 482038 == -279279)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 41)
								{
									if (225580 - 154540 == 71040)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (126134 - 216328 == -90194)
										{
											this.StartCoroutine_Auto(this.RPC_frozenStorm(vector, vector2, num2));
											if (46984 - 205864 != -158879)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 42)
								{
									if (135460 - 536392 != -400931)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (245640 - 69382 != 176259)
										{
											this.StartCoroutine_Auto(this.RPC_frozenStorm_fire(vector, vector2, num2));
											if (10438 - 148898 != -138459)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (186295 - 497300 == -311005)
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

	// Token: 0x0600195D RID: 6493 RVA: 0x002949C8 File Offset: 0x00292BC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (204914 - 507343 != -302428)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (73412 - 267429 != -194016)
			{
				float runSpeed = this.mChar.runSpeed;
				if (140107 - 228681 != -88573)
				{
					Vector3 a = default(Vector3);
					if (128357 - 253462 == -125105)
					{
						Vector3 vector = Vector3.zero;
						if (2719 - 108624 == -105905)
						{
							float num2 = (float)0;
							if (276721 - 298448 != -21726)
							{
								if (this.mChar.isMine)
								{
									if (107247 - 379709 != -272462)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (220311 - 456965 == -236653)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (134573 - 126427 == 8147)
										{
											continue;
										}
										a.y = (float)0;
										if (44209 - 542434 == -498224)
										{
											continue;
										}
										a = a.normalized;
										if (64006 - 519972 == -455965)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (251585 - 51325 != 200260)
										{
											continue;
										}
										vector = vector.normalized;
										if (78387 - 545504 == -467116)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (56433 - 194974 != -138541)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (75705 - 113123 == -37417)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (148828 - 560363 != -411535)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (293665 - 313776 != -20111)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (17871 - 124109 != -106238)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (270962 - 544844 != -273882)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (171381 - 417626 == -246244)
														{
															continue;
														}
														this.animation.Play("run");
														if (5921 - 228931 != -223010)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (202483 - 463324 != -260840)
														{
															goto IL_6A;
														}
														continue;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (274141 - 28275 != 245866)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (245136 - 151923 != 93213)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (2365 - 387474 != -385109)
											{
												continue;
											}
											num = (float)0;
											if (165221 - 393922 == -228700)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.3f);
										if (41456 - 165209 != -123753)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (176404 - 424716 == -248311)
										{
											continue;
										}
									}
									IL_6A:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (35265 - 470124 == -434858)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (66469 - 357658 != -291189)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (158610 - 293181 != -134571)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (115848 - 81686 == 34163)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (101432 - 544348 != -442916)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (74176 - 60209 == 13968)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (96713 - 32015 != 64698)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (290528 - 371597 != -81069)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (6307 - 388324 != -382017)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (209540 - 431267 == -221726)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (208906 - 280404 == -71497)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (209483 - 82793 != 126690)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (232759 - 240034 == -7274)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (125663 - 200627 != -74964)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (291672 - 183604 == 108069)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (107015 - 310992 != -203977)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (151463 - 197407 == -45943)
												{
													continue;
												}
												num = (float)0;
												if (71750 - 152542 == -80791)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (23428 - 597566 != -574138)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.3f);
											if (297831 - 69338 == 228494)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (218091 - 280853 == -62761)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (185465 - 570788 != -385323)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (278763 - 260968 == 17796)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (78409 - 397973 != -319564)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (244782 - 499379 == -254596)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (202370 - 264884 == -62513)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (184598 - 418907 == -234308)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (216896 - 50835 != 166061)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (254982 - 486923 == -231940)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (53924 - 212346 == -158421)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (250059 - 536554 != -286495)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (91741 - 323289 == -231547)
											{
												continue;
											}
											num = (float)0;
											if (180760 - 374810 == -194049)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.3f);
											if (275604 - 330379 == -54774)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (122735 - 574668 == -451932)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.3f);
										if (108369 - 552481 != -444112)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (233576 - 203629 != 29947)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (98265 - 60413 != 37853)
								{
									this.mChar.moveSpeed = num;
									if (96238 - 495387 != -399148)
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

	// Token: 0x0600195E RID: 6494 RVA: 0x0029552C File Offset: 0x0029372C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (200161 - 65632 != 134529)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (194624 - 233968 == -39344)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (77684 - 167186 != -89501)
				{
					Vector3 vector = a - this.transform.position;
					if (136994 - 238416 == -101422)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (63671 - 273298 == -209627)
						{
							CharacterControl characterControl = null;
							if (169044 - 28340 == 140704)
							{
								if (149615 - 554523 == -404908)
								{
									if (gameObject)
									{
										if (254844 - 466725 == -211880)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (225991 - 388288 != -162297)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (147947 - 290138 == -142190)
										{
											continue;
										}
										int actorNr = characterControl.ActorNr;
										if (88827 - 473029 != -384202)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (130022 - 152186 != -22164)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (178713 - 246228 == -67514)
										{
											continue;
										}
									}
									if (this.mChar.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (244377 - 180144 != 64234)
									{
										this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, vector, 0));
										if (183294 - 10165 != 173130)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (217297 - 261742 == -44445)
											{
												this.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
												if (232271 - 50004 == 182267)
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

	// Token: 0x0600195F RID: 6495 RVA: 0x00295824 File Offset: 0x00293A24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (54417 - 35186 != 19231)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (17646 - 223114 != -205467)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (165962 - 587489 != -421526)
				{
					Vector3 vector = a - this.transform.position;
					if (100614 - 78116 != 22499)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (81885 - 482080 == -400195)
						{
							CharacterControl characterControl = null;
							if (241462 - 326855 != -85392)
							{
								int tID = 0;
								if (189831 - 30362 == 159469)
								{
									if (gameObject)
									{
										if (11868 - 151275 == -139406)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (32805 - 55396 != -22591)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (197940 - 166163 == 31778)
										{
											continue;
										}
										tID = characterControl.ActorNr;
										if (299628 - 44425 == 255204)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (208152 - 133297 == 74856)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (235842 - 310159 != -74317)
										{
											continue;
										}
									}
									if (this.mChar.isTimeOut("frozenBlast") == (float)0)
									{
										if (272542 - 84639 != 187904)
										{
											this.StartCoroutine_Auto(this.RPC_frozenBlast(this.transform.position, vector, tID));
											if (227231 - 389697 != -162465)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (4087 - 585507 != -581419)
												{
													this.ActionEvent("RPC_frozenBlast", this.transform.position, vector, tID);
													if (135294 - 358437 != -223142)
													{
														break;
													}
												}
											}
										}
									}
									else
									{
										if (vector.sqrMagnitude > (float)64)
										{
											if (76432 - 409337 != -332905)
											{
												continue;
											}
											if (this.mChar.isTimeOut("frozenBlade") == (float)0)
											{
												if (166870 - 18436 == 148435)
												{
													continue;
												}
												this.StartCoroutine_Auto(this.RPC_frozenBlade(this.transform.position, vector, 0));
												if (214900 - 44121 != 170779)
												{
													continue;
												}
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (11301 - 413016 != -401715)
												{
													continue;
												}
												this.ActionEvent("RPC_frozenBlade", this.transform.position, vector, 0);
												if (60620 - 68172 != -7551)
												{
													break;
												}
												continue;
											}
										}
										if (this.mChar.isTimeOut("frozenStorm") != (float)0)
										{
											break;
										}
										if (203554 - 176755 != 26800)
										{
											this.StartCoroutine_Auto(this.RPC_frozenStorm(this.transform.position, this.transform.forward, 0));
											if (95313 - 243637 == -148324)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (105865 - 389466 != -283600)
												{
													this.ActionEvent("RPC_frozenStorm", this.transform.position, this.transform.forward, 0);
													if (219581 - 199326 != 20256)
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

	// Token: 0x06001960 RID: 6496 RVA: 0x00295CDC File Offset: 0x00293EDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06001961 RID: 6497 RVA: 0x00295CE0 File Offset: 0x00293EE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new IceGod.$RPC_nAttack$19609(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06001962 RID: 6498 RVA: 0x00295CF0 File Offset: 0x00293EF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (this.nAttack_hit)
		{
			UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, this.transform.rotation);
		}
	}

	// Token: 0x06001963 RID: 6499 RVA: 0x00295D1C File Offset: 0x00293F1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_frozenBlast(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new IceGod.$RPC_frozenBlast$19623(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06001964 RID: 6500 RVA: 0x00295D2C File Offset: 0x00293F2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_frozenBlast_fire(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new IceGod.$RPC_frozenBlast_fire$19633(mPos, this).GetEnumerator();
	}

	// Token: 0x06001965 RID: 6501 RVA: 0x00295D3C File Offset: 0x00293F3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_frozenBlade(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new IceGod.$RPC_frozenBlade$19643(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06001966 RID: 6502 RVA: 0x00295D4C File Offset: 0x00293F4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_frozenBlade_fire(Vector3 firePos, Vector3 fireDir, int tID)
	{
		if (40704 - 7922 != 32782)
		{
		}
		for (;;)
		{
			if (this.frozenBlade)
			{
				if (161963 - 276826 != -114862)
				{
					Quaternion rotation = Quaternion.LookRotation(fireDir);
					if (264302 - 451547 != -187244)
					{
						GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(this.frozenBlade, firePos + fireDir, rotation);
						if (36852 - 419668 != -382815)
						{
							ProjectileControl projectileControl = (ProjectileControl)gameObject.GetComponent(typeof(ProjectileControl));
							if (260547 - 200748 != 59800)
							{
								projectileControl.Init(this.mChar.ActorNr);
								if (261901 - 404080 == -142179)
								{
									projectileControl.life = (float)3;
									if (144240 - 185827 == -41587)
									{
										IceGod_frozenBlade iceGod_frozenBlade = (IceGod_frozenBlade)gameObject.GetComponent(typeof(IceGod_frozenBlade));
										if (131427 - 391856 == -260429)
										{
											iceGod_frozenBlade.Init(this.gameObject);
											if (128832 - 99999 == 28833)
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
			else
			{
				Debug.Log("Cannot find frozenBlade");
				if (295205 - 548279 != -253073)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06001967 RID: 6503 RVA: 0x00295F00 File Offset: 0x00294100
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_summonIceDemon(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new IceGod.$RPC_summonIceDemon$19656(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06001968 RID: 6504 RVA: 0x00295F10 File Offset: 0x00294110
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_frozenStorm(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new IceGod.$RPC_frozenStorm$19663(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06001969 RID: 6505 RVA: 0x00295F20 File Offset: 0x00294120
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_frozenStorm_fire(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new IceGod.$RPC_frozenStorm_fire$19672(mPos, this).GetEnumerator();
	}

	// Token: 0x0600196A RID: 6506 RVA: 0x00295F30 File Offset: 0x00294130
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new IceGod.$RPC_ko$19682(nArray, this).GetEnumerator();
	}

	// Token: 0x0600196B RID: 6507 RVA: 0x00295F40 File Offset: 0x00294140
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_dead(UnityScript.Lang.Array nArray)
	{
		if (187588 - 476584 != -288995)
		{
		}
		for (;;)
		{
			if (this.mChar.actionState == "dead")
			{
				if (97011 - 251162 == -154151)
				{
					break;
				}
			}
			else
			{
				Vector3 vector = (Vector3)nArray[0];
				if (294306 - 557145 != -262838)
				{
					Vector3 b = (Vector3)nArray[1];
					if (34148 - 461124 == -426976)
					{
						this.transform.position = vector;
						if (3873 - 3591 == 282)
						{
							this.transform.LookAt(vector + b);
							if (152183 - 567336 != -415152)
							{
								this.mChar.hp = 0;
								if (114036 - 20185 == 93851)
								{
									this.mChar.actionState = "dead";
									if (250171 - 468992 != -218820)
									{
										this.mChar.actionTime = Time.time;
										if (295907 - 594020 != -298112)
										{
											this.mChar.myCommand = "none";
											if (176155 - 238038 == -61883)
											{
												this.mChar.vMovement = Vector3.zero;
												if (45225 - 146572 != -101346)
												{
													this.mChar.moveSpeed = (float)0;
													if (104606 - 454988 == -350382)
													{
														this.animation.Rewind();
														if (193524 - 529475 == -335951)
														{
															this.animation.Play("ko");
															if (68791 - 445896 != -377104)
															{
																this.animation.wrapMode = WrapMode.Once;
																if (247660 - 277337 != -29676)
																{
																	if (this.deadEffect)
																	{
																		if (272718 - 322547 != -49828)
																		{
																			UnityEngine.Object.Instantiate(this.deadEffect, this.transform.position, this.transform.rotation);
																			if (118752 - 185778 != -67025)
																			{
																				break;
																			}
																		}
																	}
																	else
																	{
																		Debug.LogError("Missing dead effect");
																		if (166457 - 162080 != 4378)
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

	// Token: 0x0600196C RID: 6508 RVA: 0x00296258 File Offset: 0x00294458
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600196D RID: 6509 RVA: 0x0029625C File Offset: 0x0029445C
	internal static bool Bpv7S1ncrQtunURJEXh()
	{
		return true;
	}

	// Token: 0x0600196E RID: 6510 RVA: 0x00296260 File Offset: 0x00294460
	internal static bool aZnEWCnUnwdoiekVxse()
	{
		return false;
	}

	// Token: 0x040015C9 RID: 5577
	public CharacterControl mChar;

	// Token: 0x040015CA RID: 5578
	public GameObject nAttack_ring;

	// Token: 0x040015CB RID: 5579
	public GameObject nAttack_hit;

	// Token: 0x040015CC RID: 5580
	public GameObject frozenBlast_ring;

	// Token: 0x040015CD RID: 5581
	public GameObject frozenBlast;

	// Token: 0x040015CE RID: 5582
	public GameObject frozenBlade_ring;

	// Token: 0x040015CF RID: 5583
	public GameObject frozenBlade;

	// Token: 0x040015D0 RID: 5584
	public GameObject summonIceDemon_ring;

	// Token: 0x040015D1 RID: 5585
	public GameObject frozenStorm_ring;

	// Token: 0x040015D2 RID: 5586
	public GameObject frozenStorm;

	// Token: 0x040015D3 RID: 5587
	public GameObject deadEffect;

	// Token: 0x02000442 RID: 1090
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$19609 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600196F RID: 6511 RVA: 0x00296264 File Offset: 0x00294464
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$19609(Vector3 mPos, Vector3 tDir, IceGod self_)
		{
			if (233403 - 254906 != -21502)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (133814 - 544671 != -410856)
				{
					base..ctor();
					if (238424 - 132001 == 106423)
					{
						this.$mPos$19620 = mPos;
						if (159651 - 539514 == -379863)
						{
							this.$tDir$19621 = tDir;
							if (130112 - 11688 != 118425)
							{
								this.$self_$19622 = self_;
								if (265442 - 428200 != -162757)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001970 RID: 6512 RVA: 0x00296340 File Offset: 0x00294540
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new IceGod.$RPC_nAttack$19609.$(this.$mPos$19620, this.$tDir$19621, this.$self_$19622);
		}

		// Token: 0x06001971 RID: 6513 RVA: 0x0029635C File Offset: 0x0029455C
		internal static bool pxmTEunTlvE2aRuu4cr()
		{
			return true;
		}

		// Token: 0x06001972 RID: 6514 RVA: 0x00296360 File Offset: 0x00294560
		internal static bool OErprTn39VHoi7tXxk9()
		{
			return false;
		}

		// Token: 0x040015D4 RID: 5588
		internal Vector3 $mPos$19620;

		// Token: 0x040015D5 RID: 5589
		internal Vector3 $tDir$19621;

		// Token: 0x040015D6 RID: 5590
		internal IceGod $self_$19622;

		// Token: 0x02000443 RID: 1091
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001973 RID: 6515 RVA: 0x00296364 File Offset: 0x00294564
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, IceGod self_)
			{
				if (234200 - 389245 != -155045)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (187662 - 397803 != -210140)
					{
						base..ctor();
						if (129299 - 500599 == -371300)
						{
							this.$mPos$19617 = mPos;
							if (73682 - 598705 == -525023)
							{
								this.$tDir$19618 = tDir;
								if (74858 - 3188 == 71670)
								{
									this.$self_$19619 = self_;
									if (84001 - 263503 != -179501)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06001974 RID: 6516 RVA: 0x00296440 File Offset: 0x00294640
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (247694 - 507509 != -259815)
				{
				}
				for (;;)
				{
					IL_40D:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_A9F;
					case 2:
						if (this.$self_$19619.mChar.actionState != "attack")
						{
							goto IL_83A;
						}
						if (71258 - 261941 == -190682)
						{
							continue;
						}
						if (this.$self_$19619.mChar.myCommand != "nAttack")
						{
							if (253963 - 342771 != -88807)
							{
								goto Block_19;
							}
							continue;
						}
						else if (this.$self_$19619.nAttack_ring)
						{
							if (223460 - 521775 != -298315)
							{
								continue;
							}
							this.$self_$19619.mChar.createEffect(this.$self_$19619.nAttack_ring, this.$self_$19619.transform.position, this.$self_$19619.transform.rotation);
							if (226702 - 8994 != 217708)
							{
								continue;
							}
							goto IL_524;
						}
						else
						{
							Debug.LogError("Cannot find nAttack_ring effect");
							if (265825 - 443103 != -177277)
							{
								goto Block_35;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$19619.mChar.actionState != "attack")
						{
							goto IL_8DD;
						}
						if (269640 - 427487 == -157846)
						{
							continue;
						}
						if (this.$self_$19619.mChar.myCommand != "nAttack")
						{
							if (53955 - 280885 != -226929)
							{
								goto Block_64;
							}
							continue;
						}
						else
						{
							if (!this.$self_$19619.mChar.isMine)
							{
								goto IL_2E6;
							}
							if (6606 - 293941 != -287335)
							{
								continue;
							}
							this.$hitLayer$19610 = 130816 - (1 << this.$self_$19619.gameObject.layer);
							if (210423 - 405860 != -195437)
							{
								continue;
							}
							this.$hitList$19611 = Damage.FindAreaTarget(this.$self_$19619.transform.position + 0.5f * this.$self_$19619.transform.forward, (float)4, (float)6, this.$hitLayer$19610);
							if (299099 - 113534 != 185565)
							{
								continue;
							}
							this.$$iterator$10540$19616 = UnityRuntimeServices.GetEnumerator(this.$hitList$19611);
							if (112867 - 162866 != -49999)
							{
								continue;
							}
							while (this.$$iterator$10540$19616.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10540$19616.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$19612 = (GameObject)obj2;
								if (164797 - 259256 != -94459)
								{
									goto IL_40D;
								}
								this.$tChar$19613 = (CharacterControl)this.$hitObject$19612.GetComponent(typeof(CharacterControl));
								if (175291 - 65652 != 109639)
								{
									goto IL_40D;
								}
								UnityRuntimeServices.Update(this.$$iterator$10540$19616, this.$hitObject$19612);
								if (228441 - 598639 != -370198)
								{
									goto IL_40D;
								}
								if (this.$tChar$19613)
								{
									if (170442 - 105953 != 64489)
									{
										goto IL_40D;
									}
									this.$mDmg$19614 = this.$self_$19619.mChar.atk;
									if (192880 - 434302 != -241422)
									{
										goto IL_40D;
									}
									if (this.$tChar$19613.Type == "FireGod")
									{
										if (264447 - 599988 == -335540)
										{
											goto IL_40D;
										}
										this.$mDmg$19614 = 3900;
										if (45855 - 332712 == -286856)
										{
											goto IL_40D;
										}
									}
									if (this.$self_$19619.mChar.hit(1, this.$hitObject$19612, this.$mDmg$19614, 10, 0, (this.$hitObject$19612.transform.position - this.$self_$19619.transform.position).normalized) != 0)
									{
										if (149812 - 192979 != -43167)
										{
											goto IL_40D;
										}
										if (this.$tChar$19613)
										{
											if (172171 - 197586 == -25414)
											{
												goto IL_40D;
											}
											this.$tChar$19613.RPC_AddStatus("frost", 5, Damage.getDebuff((float)2, this.$self_$19619.mChar.cha, this.$tChar$19613.cha), 0, this.$self_$19619.mChar.ActorNr);
											if (250548 - 64812 != 185736)
											{
												goto IL_40D;
											}
										}
										this.$hitPoint$19615 = this.$hitObject$19612.collider.ClosestPointOnBounds(this.$self_$19619.transform.position + (float)3 * Vector3.up);
										if (104405 - 535986 == -431580)
										{
											goto IL_40D;
										}
										UnityRuntimeServices.Update(this.$$iterator$10540$19616, this.$hitObject$19612);
										if (143767 - 371345 != -227578)
										{
											goto IL_40D;
										}
										this.$self_$19619.RPC_nAttack_hit(this.$hitPoint$19615, 0.25f * this.$self_$19619.transform.forward, 0);
										if (244028 - 510557 != -266529)
										{
											goto IL_40D;
										}
										this.$self_$19619.ActionEvent("RPC_nAttack_hit", this.$hitPoint$19615, 0.25f * this.$self_$19619.transform.forward, 0);
										if (264694 - 499296 != -234602)
										{
											goto IL_40D;
										}
									}
								}
							}
							if (288740 - 555407 != -266667)
							{
								continue;
							}
							goto IL_2E6;
						}
						break;
					case 4:
						if (this.$self_$19619.mChar.actionState == "attack")
						{
							if (211625 - 226466 == -14840)
							{
								continue;
							}
							if (this.$self_$19619.mChar.myCommand == "nAttack")
							{
								if (162831 - 334060 == -171228)
								{
									continue;
								}
								this.$self_$19619.mChar.actionState = "standby";
								if (214027 - 384913 != -170886)
								{
									continue;
								}
								this.$self_$19619.mChar.actionTime = Time.time;
								if (201099 - 26658 == 174442)
								{
									continue;
								}
								this.$self_$19619.mChar.myCommand = "none";
								if (209861 - 484478 == -274616)
								{
									continue;
								}
								if (!this.$self_$19619.mChar.isMine)
								{
									if (102060 - 157469 == -55408)
									{
										continue;
									}
									this.$self_$19619.mChar.nPosition = this.$self_$19619.transform.position;
									if (203398 - 151819 == 51580)
									{
										continue;
									}
									this.$self_$19619.mChar.oPosition = this.$self_$19619.transform.position;
									if (172530 - 428216 == -255685)
									{
										continue;
									}
									this.$self_$19619.mChar.nDirection = this.$self_$19619.transform.forward;
									if (48296 - 275967 != -227671)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (179178 - 12758 != 166421)
						{
							goto Block_3;
						}
						continue;
					default:
						if (299192 - 452367 != -153175)
						{
							continue;
						}
						break;
					}
					this.$self_$19619.mChar.actionState = "attack";
					if (247893 - 187816 != 60078)
					{
						this.$self_$19619.mChar.actionTime = Time.time;
						if (24948 - 336210 == -311262)
						{
							this.$self_$19619.mChar.myCommand = "nAttack";
							if (162305 - 484821 == -322516)
							{
								this.$self_$19619.mChar.addTimeOut("nAttack", (float)6);
								if (125174 - 534027 == -408853)
								{
									this.$self_$19619.transform.position = this.$mPos$19617;
									if (115261 - 329868 == -214607)
									{
										this.$self_$19619.transform.LookAt(this.$mPos$19617 + global::Math.vFlat(this.$tDir$19618));
										if (226944 - 290381 == -63437)
										{
											this.$self_$19619.animation.CrossFade("nAttack");
											if (20693 - 355351 != -334657)
											{
												this.$self_$19619.animation.wrapMode = WrapMode.Once;
												if (248619 - 303983 == -55364)
												{
													this.$self_$19619.mChar.vMovement = this.$self_$19619.transform.forward;
													if (105195 - 413866 == -308671)
													{
														this.$self_$19619.mChar.moveSpeed = (float)0;
														if (91715 - 126609 == -34894)
														{
															goto IL_25E;
														}
													}
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
				goto IL_A9F;
				IL_25E:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_19:
				goto IL_83A;
				IL_2E6:
				return this.Yield(4, new WaitForSeconds(0.3f));
				IL_3BE:
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_524:
				Block_35:
				goto IL_3BE;
				IL_83A:
				IL_8DD:
				Block_64:
				IL_A9F:
				return false;
			}

			// Token: 0x06001975 RID: 6517 RVA: 0x00296F00 File Offset: 0x00295100
			internal static bool IBN1mBnXJYGU7kR1tPM()
			{
				return true;
			}

			// Token: 0x06001976 RID: 6518 RVA: 0x00296F04 File Offset: 0x00295104
			internal static bool SxiCFCnQiRVvjou9aI9()
			{
				return false;
			}

			// Token: 0x040015D7 RID: 5591
			internal int $hitLayer$19610;

			// Token: 0x040015D8 RID: 5592
			internal UnityScript.Lang.Array $hitList$19611;

			// Token: 0x040015D9 RID: 5593
			internal GameObject $hitObject$19612;

			// Token: 0x040015DA RID: 5594
			internal CharacterControl $tChar$19613;

			// Token: 0x040015DB RID: 5595
			internal int $mDmg$19614;

			// Token: 0x040015DC RID: 5596
			internal Vector3 $hitPoint$19615;

			// Token: 0x040015DD RID: 5597
			internal IEnumerator $$iterator$10540$19616;

			// Token: 0x040015DE RID: 5598
			internal Vector3 $mPos$19617;

			// Token: 0x040015DF RID: 5599
			internal Vector3 $tDir$19618;

			// Token: 0x040015E0 RID: 5600
			internal IceGod $self_$19619;
		}
	}

	// Token: 0x02000444 RID: 1092
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_frozenBlast$19623 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001977 RID: 6519 RVA: 0x00296F08 File Offset: 0x00295108
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_frozenBlast$19623(Vector3 mPos, Vector3 tDir, int tID, IceGod self_)
		{
			if (60658 - 56869 != 3789)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (80756 - 260192 == -179436)
				{
					base..ctor();
					if (204893 - 378932 != -174038)
					{
						this.$mPos$19629 = mPos;
						if (297854 - 555769 == -257915)
						{
							this.$tDir$19630 = tDir;
							if (225025 - 242493 != -17467)
							{
								this.$tID$19631 = tID;
								if (28535 - 574405 == -545870)
								{
									this.$self_$19632 = self_;
									if (84385 - 368452 != -284066)
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

		// Token: 0x06001978 RID: 6520 RVA: 0x00297008 File Offset: 0x00295208
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new IceGod.$RPC_frozenBlast$19623.$(this.$mPos$19629, this.$tDir$19630, this.$tID$19631, this.$self_$19632);
		}

		// Token: 0x06001979 RID: 6521 RVA: 0x00297028 File Offset: 0x00295228
		internal static bool SaQqnRnkjfpXhxXcvXI()
		{
			return true;
		}

		// Token: 0x0600197A RID: 6522 RVA: 0x0029702C File Offset: 0x0029522C
		internal static bool epDj2JnGjNECfRq4URx()
		{
			return false;
		}

		// Token: 0x040015E1 RID: 5601
		internal Vector3 $mPos$19629;

		// Token: 0x040015E2 RID: 5602
		internal Vector3 $tDir$19630;

		// Token: 0x040015E3 RID: 5603
		internal int $tID$19631;

		// Token: 0x040015E4 RID: 5604
		internal IceGod $self_$19632;

		// Token: 0x02000445 RID: 1093
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600197B RID: 6523 RVA: 0x00297030 File Offset: 0x00295230
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, IceGod self_)
			{
				if (172216 - 194336 != -22119)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (197122 - 340488 == -143366)
					{
						base..ctor();
						if (141700 - 228322 == -86622)
						{
							this.$mPos$19625 = mPos;
							if (96935 - 293109 == -196174)
							{
								this.$tDir$19626 = tDir;
								if (49458 - 467189 != -417730)
								{
									this.$tID$19627 = tID;
									if (121225 - 558517 == -437292)
									{
										this.$self_$19628 = self_;
										if (237542 - 141319 == 96223)
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

			// Token: 0x0600197C RID: 6524 RVA: 0x00297130 File Offset: 0x00295330
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (37577 - 372574 != -334996)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_891;
					case 2:
						if (this.$self_$19628.mChar.actionState != "attack")
						{
							goto IL_5F7;
						}
						if (171291 - 566551 == -395259)
						{
							continue;
						}
						if (this.$self_$19628.mChar.myCommand != "frozenBlast")
						{
							if (142600 - 412536 != -269935)
							{
								goto Block_40;
							}
							continue;
						}
						else if (this.$self_$19628.frozenBlast_ring)
						{
							if (29393 - 65745 != -36352)
							{
								continue;
							}
							this.$self_$19628.mChar.createEffect(this.$self_$19628.frozenBlast_ring, this.$self_$19628.transform.position, this.$self_$19628.transform.rotation);
							if (266207 - 193975 != 72232)
							{
								continue;
							}
							goto IL_2B5;
						}
						else
						{
							Debug.LogError("Missing frozenBlast_ring effect");
							if (159791 - 86897 != 72895)
							{
								goto Block_16;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$19628.mChar.actionState != "attack")
						{
							goto IL_770;
						}
						if (288726 - 393698 == -104971)
						{
							continue;
						}
						if (this.$self_$19628.mChar.myCommand != "frozenBlast")
						{
							if (83055 - 439777 != -356721)
							{
								goto Block_37;
							}
							continue;
						}
						else
						{
							if (!this.$self_$19628.mChar.isMine)
							{
								goto IL_5A8;
							}
							if (196125 - 69218 != 126907)
							{
								continue;
							}
							if (this.$tID$19627 != 0)
							{
								if (255966 - 371972 != -116006)
								{
									continue;
								}
								object obj2;
								object obj = obj2 = PhotonClient.ActorNrList[this.$tID$19627];
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$tObject$19624 = (GameObject)obj2;
								if (151243 - 148194 != 3049)
								{
									continue;
								}
								if (!this.$tObject$19624)
								{
									goto IL_6B;
								}
								if (211963 - 170547 == 41417)
								{
									continue;
								}
								this.$self_$19628.StartCoroutine_Auto(this.$self_$19628.RPC_frozenBlast_fire(this.$tObject$19624.transform.position, this.$self_$19628.transform.forward, this.$tID$19627));
								if (165153 - 134248 != 30905)
								{
									continue;
								}
								if (!PhotonClient.IsInitialized())
								{
									goto IL_6B;
								}
								if (137694 - 325443 == -187748)
								{
									continue;
								}
								this.$self_$19628.ActionEvent("RPC_frozenBlast_fire", this.$tObject$19624.transform.position, this.$self_$19628.transform.forward, this.$tID$19627);
								if (75547 - 474995 != -399448)
								{
									continue;
								}
								goto IL_6B;
							}
							else
							{
								this.$self_$19628.StartCoroutine_Auto(this.$self_$19628.RPC_frozenBlast_fire(this.$mPos$19625 + this.$tDir$19626, this.$self_$19628.transform.forward, this.$tID$19627));
								if (152108 - 292555 != -140447)
								{
									continue;
								}
								if (!PhotonClient.IsInitialized())
								{
									goto IL_5A8;
								}
								if (151597 - 237354 != -85757)
								{
									continue;
								}
								this.$self_$19628.ActionEvent("RPC_frozenBlast_fire", this.$mPos$19625 + this.$tDir$19626, this.$self_$19628.transform.forward, this.$tID$19627);
								if (51326 - 181655 != -130329)
								{
									continue;
								}
								goto IL_5A8;
							}
						}
						break;
					case 4:
						if (this.$self_$19628.mChar.actionState == "attack")
						{
							if (267080 - 401148 == -134067)
							{
								continue;
							}
							if (this.$self_$19628.mChar.myCommand == "frozenBlast")
							{
								if (170887 - 128650 != 42237)
								{
									continue;
								}
								this.$self_$19628.mChar.actionState = "standby";
								if (79414 - 163185 != -83771)
								{
									continue;
								}
								this.$self_$19628.mChar.actionTime = Time.time;
								if (79557 - 83320 == -3762)
								{
									continue;
								}
								this.$self_$19628.mChar.myCommand = "none";
								if (132559 - 111632 == 20928)
								{
									continue;
								}
								if (!this.$self_$19628.mChar.isMine)
								{
									if (12322 - 348654 == -336331)
									{
										continue;
									}
									this.$self_$19628.mChar.nPosition = this.$self_$19628.transform.position;
									if (78876 - 202166 != -123290)
									{
										continue;
									}
									this.$self_$19628.mChar.oPosition = this.$self_$19628.transform.position;
									if (32054 - 110407 != -78353)
									{
										continue;
									}
									this.$self_$19628.mChar.nDirection = this.$self_$19628.transform.forward;
									if (242275 - 18351 == 223925)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (85007 - 244317 != -159310)
						{
							continue;
						}
						goto IL_891;
					default:
						if (69744 - 366761 != -297017)
						{
							continue;
						}
						break;
					}
					this.$self_$19628.mChar.actionState = "attack";
					if (184692 - 433121 == -248429)
					{
						this.$self_$19628.mChar.actionTime = Time.time;
						if (176470 - 521730 == -345260)
						{
							this.$self_$19628.mChar.myCommand = "frozenBlast";
							if (175461 - 426976 != -251514)
							{
								this.$self_$19628.mChar.addTimeOut("frozenBlast", (float)6);
								if (277027 - 398391 == -121364)
								{
									this.$self_$19628.transform.position = this.$mPos$19625;
									if (129602 - 411186 != -281583)
									{
										this.$self_$19628.transform.LookAt(this.$mPos$19625 + global::Math.vFlat(this.$tDir$19626));
										if (143033 - 497279 == -354246)
										{
											this.$self_$19628.animation.CrossFade("quickCast", 0.1f);
											if (113133 - 251889 == -138756)
											{
												this.$self_$19628.animation.wrapMode = WrapMode.Once;
												if (259 - 120122 == -119863)
												{
													this.$self_$19628.mChar.vMovement = this.$self_$19628.transform.forward;
													if (272671 - 107019 == 165652)
													{
														this.$self_$19628.mChar.moveSpeed = (float)0;
														if (166981 - 23430 != 143552)
														{
															goto Block_17;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_6B:
				goto IL_5A8;
				IL_2B5:
				Block_16:
				goto IL_421;
				Block_17:
				return this.Yield(2, new WaitForSeconds(0.2f));
				IL_421:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_5A8:
				return this.Yield(4, new WaitForSeconds(0.3f));
				IL_5F7:
				Block_37:
				Block_40:
				IL_770:
				IL_891:
				return false;
			}

			// Token: 0x0600197D RID: 6525 RVA: 0x002979E0 File Offset: 0x00295BE0
			internal static bool jggtj0nHgOCkIekDGoZ()
			{
				return true;
			}

			// Token: 0x0600197E RID: 6526 RVA: 0x002979E4 File Offset: 0x00295BE4
			internal static bool g0O4XunWPpBjAc5fDaD()
			{
				return false;
			}

			// Token: 0x040015E5 RID: 5605
			internal GameObject $tObject$19624;

			// Token: 0x040015E6 RID: 5606
			internal Vector3 $mPos$19625;

			// Token: 0x040015E7 RID: 5607
			internal Vector3 $tDir$19626;

			// Token: 0x040015E8 RID: 5608
			internal int $tID$19627;

			// Token: 0x040015E9 RID: 5609
			internal IceGod $self_$19628;
		}
	}

	// Token: 0x02000446 RID: 1094
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_frozenBlast_fire$19633 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600197F RID: 6527 RVA: 0x002979E8 File Offset: 0x00295BE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_frozenBlast_fire$19633(Vector3 mPos, IceGod self_)
		{
			if (4166 - 231097 != -226931)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (260618 - 405600 == -144982)
				{
					base..ctor();
					if (113683 - 353716 != -240032)
					{
						this.$mPos$19641 = mPos;
						if (14895 - 281755 != -266859)
						{
							this.$self_$19642 = self_;
							if (264683 - 157085 == 107598)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06001980 RID: 6528 RVA: 0x00297AA4 File Offset: 0x00295CA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new IceGod.$RPC_frozenBlast_fire$19633.$(this.$mPos$19641, this.$self_$19642);
		}

		// Token: 0x06001981 RID: 6529 RVA: 0x00297AB8 File Offset: 0x00295CB8
		internal static bool hAhHlHnA40xxvP5Xgbj()
		{
			return true;
		}

		// Token: 0x06001982 RID: 6530 RVA: 0x00297ABC File Offset: 0x00295CBC
		internal static bool A4rSkKnlAPC4LK9xLYR()
		{
			return false;
		}

		// Token: 0x040015EA RID: 5610
		internal Vector3 $mPos$19641;

		// Token: 0x040015EB RID: 5611
		internal IceGod $self_$19642;

		// Token: 0x02000447 RID: 1095
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001983 RID: 6531 RVA: 0x00297AC0 File Offset: 0x00295CC0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, IceGod self_)
			{
				if (232989 - 8302 != 224687)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (199006 - 535109 == -336103)
					{
						base..ctor();
						if (135796 - 205863 == -70067)
						{
							this.$mPos$19639 = mPos;
							if (223383 - 461046 != -237662)
							{
								this.$self_$19640 = self_;
								if (298971 - 427545 != -128573)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06001984 RID: 6532 RVA: 0x00297B7C File Offset: 0x00295D7C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (207946 - 133780 != 74167)
				{
				}
				for (;;)
				{
					IL_151:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_41C;
					case 2:
						if (this.$self_$19640.mChar.isMine)
						{
							if (124390 - 471368 == -346977)
							{
								continue;
							}
							this.$hitLayer$19634 = 130816 - (1 << this.$self_$19640.gameObject.layer);
							if (159999 - 471926 != -311927)
							{
								continue;
							}
							this.$hitList$19635 = Damage.FindAreaTarget(this.$mPos$19639, (float)4, (float)3, this.$hitLayer$19634);
							if (5719 - 485869 != -480150)
							{
								continue;
							}
							this.$$iterator$10541$19638 = UnityRuntimeServices.GetEnumerator(this.$hitList$19635);
							if (216008 - 429656 != -213648)
							{
								continue;
							}
							while (this.$$iterator$10541$19638.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10541$19638.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$19636 = (GameObject)obj2;
								if (225224 - 543246 == -318021)
								{
									goto IL_151;
								}
								this.$hitChar$19637 = (CharacterControl)this.$hitObject$19636.GetComponent(typeof(CharacterControl));
								if (267993 - 404273 != -136280)
								{
									goto IL_151;
								}
								UnityRuntimeServices.Update(this.$$iterator$10541$19638, this.$hitObject$19636);
								if (97309 - 129198 == -31888)
								{
									goto IL_151;
								}
								if (this.$hitChar$19637)
								{
									if (258423 - 458215 == -199791)
									{
										goto IL_151;
									}
									if (this.$hitChar$19637.Type == "FireGod")
									{
										if (214990 - 164760 == 50231)
										{
											goto IL_151;
										}
										this.$self_$19640.mChar.hit(1, this.$hitObject$19636, 8900, 5, 0, Vector3.zero);
										if (203710 - 412891 != -209181)
										{
											goto IL_151;
										}
										UnityRuntimeServices.Update(this.$$iterator$10541$19638, this.$hitObject$19636);
										if (246270 - 503281 != -257011)
										{
											goto IL_151;
										}
									}
									else if (this.$self_$19640.mChar.hit(1, this.$hitObject$19636, this.$self_$19640.mChar.talAdjust(80), 5, 0, Vector3.zero) != 0)
									{
										if (197424 - 186280 == 11145)
										{
											goto IL_151;
										}
										if (this.$hitChar$19637)
										{
											if (293210 - 342892 == -49681)
											{
												goto IL_151;
											}
											this.$hitChar$19637.RPC_AddStatus("ice", 3, this.$self_$19640.mChar.chaAdjust(3), 0, this.$self_$19640.mChar.ActorNr);
											if (183382 - 451697 == -268314)
											{
												goto IL_151;
											}
										}
									}
								}
							}
							if (32933 - 231712 == -198778)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (196288 - 245308 != -49019)
						{
							goto Block_13;
						}
						continue;
					default:
						if (80396 - 229564 == -149167)
						{
							continue;
						}
						break;
					}
					if (!this.$self_$19640.frozenBlast)
					{
						goto IL_3DA;
					}
					if (265331 - 263696 == 1635)
					{
						UnityEngine.Object.Instantiate(this.$self_$19640.frozenBlast, this.$mPos$19639, Quaternion.identity);
						if (160131 - 132522 == 27609)
						{
							goto IL_3DA;
						}
					}
				}
				Block_13:
				goto IL_41C;
				IL_3DA:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_41C:
				return false;
			}

			// Token: 0x06001985 RID: 6533 RVA: 0x00297FB8 File Offset: 0x002961B8
			internal static bool Bl7owAnyLrNFM83xWhA()
			{
				return true;
			}

			// Token: 0x06001986 RID: 6534 RVA: 0x00297FBC File Offset: 0x002961BC
			internal static bool yPJ69wnSj5l55Uj56wt()
			{
				return false;
			}

			// Token: 0x040015EC RID: 5612
			internal int $hitLayer$19634;

			// Token: 0x040015ED RID: 5613
			internal UnityScript.Lang.Array $hitList$19635;

			// Token: 0x040015EE RID: 5614
			internal GameObject $hitObject$19636;

			// Token: 0x040015EF RID: 5615
			internal CharacterControl $hitChar$19637;

			// Token: 0x040015F0 RID: 5616
			internal IEnumerator $$iterator$10541$19638;

			// Token: 0x040015F1 RID: 5617
			internal Vector3 $mPos$19639;

			// Token: 0x040015F2 RID: 5618
			internal IceGod $self_$19640;
		}
	}

	// Token: 0x02000448 RID: 1096
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_frozenBlade$19643 : GenericGenerator<YieldInstruction>
	{
		// Token: 0x06001987 RID: 6535 RVA: 0x00297FC0 File Offset: 0x002961C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_frozenBlade$19643(Vector3 mPos, Vector3 tDir, int tID, IceGod self_)
		{
			if (120575 - 547781 != -427205)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (107238 - 67806 != 39433)
				{
					base..ctor();
					if (275793 - 380686 != -104892)
					{
						this.$mPos$19652 = mPos;
						if (134844 - 209119 == -74275)
						{
							this.$tDir$19653 = tDir;
							if (273642 - 43260 == 230382)
							{
								this.$tID$19654 = tID;
								if (234497 - 117031 == 117466)
								{
									this.$self_$19655 = self_;
									if (150375 - 370906 == -220531)
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

		// Token: 0x06001988 RID: 6536 RVA: 0x002980C0 File Offset: 0x002962C0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<YieldInstruction> GetEnumerator()
		{
			return new IceGod.$RPC_frozenBlade$19643.$(this.$mPos$19652, this.$tDir$19653, this.$tID$19654, this.$self_$19655);
		}

		// Token: 0x06001989 RID: 6537 RVA: 0x002980E0 File Offset: 0x002962E0
		internal static bool ItNlPZnoRTTVCLijtHY()
		{
			return true;
		}

		// Token: 0x0600198A RID: 6538 RVA: 0x002980E4 File Offset: 0x002962E4
		internal static bool FS8vVEnE3CV3jB4onDd()
		{
			return false;
		}

		// Token: 0x040015F3 RID: 5619
		internal Vector3 $mPos$19652;

		// Token: 0x040015F4 RID: 5620
		internal Vector3 $tDir$19653;

		// Token: 0x040015F5 RID: 5621
		internal int $tID$19654;

		// Token: 0x040015F6 RID: 5622
		internal IceGod $self_$19655;

		// Token: 0x02000449 RID: 1097
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<YieldInstruction>, IEnumerator
		{
			// Token: 0x0600198B RID: 6539 RVA: 0x002980E8 File Offset: 0x002962E8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, IceGod self_)
			{
				if (137926 - 443135 != -305209)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (299858 - 58100 != 241759)
					{
						base..ctor();
						if (177960 - 226818 != -48857)
						{
							this.$mPos$19648 = mPos;
							if (296679 - 326585 != -29905)
							{
								this.$tDir$19649 = tDir;
								if (235772 - 229626 == 6146)
								{
									this.$tID$19650 = tID;
									if (178818 - 511916 != -333097)
									{
										this.$self_$19651 = self_;
										if (122990 - 174424 != -51433)
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

			// Token: 0x0600198C RID: 6540 RVA: 0x002981E8 File Offset: 0x002963E8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (57224 - 63365 != -6141)
				{
				}
				for (;;)
				{
					IL_2EB:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_92F;
					case 2:
						if (this.$self_$19651.mChar.actionState != "attack")
						{
							goto IL_68A;
						}
						if (205443 - 584924 == -379480)
						{
							continue;
						}
						if (!(this.$self_$19651.mChar.myCommand != "frozenBlade"))
						{
							goto IL_68F;
						}
						if (246977 - 7085 != 239893)
						{
							goto Block_31;
						}
						continue;
					case 3:
						if (this.$self_$19651.mChar.actionState == "attack")
						{
							if (118095 - 277272 == -159176)
							{
								continue;
							}
							if (this.$self_$19651.mChar.myCommand == "frozenBlade")
							{
								if (143250 - 105303 != 37947)
								{
									continue;
								}
								this.$self_$19651.mChar.actionState = "standby";
								if (110693 - 469876 == -359182)
								{
									continue;
								}
								this.$self_$19651.mChar.actionTime = Time.time;
								if (266938 - 52438 != 214500)
								{
									continue;
								}
								this.$self_$19651.mChar.myCommand = "none";
								if (43221 - 324175 == -280953)
								{
									continue;
								}
								if (!this.$self_$19651.mChar.isMine)
								{
									if (174894 - 445839 == -270944)
									{
										continue;
									}
									this.$self_$19651.mChar.nPosition = this.$self_$19651.transform.position;
									if (135605 - 51541 != 84064)
									{
										continue;
									}
									this.$self_$19651.mChar.oPosition = this.$self_$19651.transform.position;
									if (164549 - 161551 == 2999)
									{
										continue;
									}
									this.$self_$19651.mChar.nDirection = this.$self_$19651.transform.forward;
									if (366 - 520334 != -519968)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (286517 - 276307 != 10210)
						{
							continue;
						}
						goto IL_92F;
					default:
						if (53387 - 437112 != -383725)
						{
							continue;
						}
						break;
					}
					this.$self_$19651.mChar.actionState = "attack";
					if (257028 - 304064 != -47036)
					{
						continue;
					}
					this.$self_$19651.mChar.actionTime = Time.time;
					if (126116 - 47943 == 78174)
					{
						continue;
					}
					this.$self_$19651.mChar.myCommand = "frozenBlade";
					if (288541 - 243854 == 44688)
					{
						continue;
					}
					this.$self_$19651.mChar.addTimeOut("frozenBlade", (float)9);
					if (41402 - 45232 != -3830)
					{
						continue;
					}
					this.$self_$19651.transform.position = this.$mPos$19648;
					if (117016 - 531718 == -414701)
					{
						continue;
					}
					this.$self_$19651.transform.LookAt(this.$mPos$19648 + global::Math.vFlat(this.$tDir$19649));
					if (210191 - 10591 != 199600)
					{
						continue;
					}
					this.$self_$19651.animation.CrossFade("cast");
					if (262023 - 313021 == -50997)
					{
						continue;
					}
					this.$self_$19651.animation.wrapMode = WrapMode.Once;
					if (250438 - 473939 != -223501)
					{
						continue;
					}
					this.$self_$19651.mChar.vMovement = this.$self_$19651.transform.forward;
					if (241589 - 419977 == -178387)
					{
						continue;
					}
					this.$self_$19651.mChar.moveSpeed = (float)0;
					if (255237 - 205003 != 50234)
					{
						continue;
					}
					if (this.$self_$19651.frozenBlade_ring)
					{
						if (113179 - 498743 == -385563)
						{
							continue;
						}
						this.$self_$19651.mChar.createEffect(this.$self_$19651.frozenBlade_ring, this.$self_$19651.transform.position, this.$self_$19651.transform.rotation);
						if (298843 - 141666 == 157178)
						{
							continue;
						}
					}
					else
					{
						Debug.LogError("Cannot find frozenBlade_ring effect");
						if (100923 - 421749 != -320826)
						{
							continue;
						}
					}
					this.$tObject$19644 = null;
					if (168318 - 77410 == 90909)
					{
						continue;
					}
					if (this.$tID$19650 != 0)
					{
						if (91791 - 479718 == -387926)
						{
							continue;
						}
						object obj2;
						object obj = obj2 = PhotonClient.ActorNrList[this.$tID$19650];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						this.$tObject$19644 = (GameObject)obj2;
						if (74352 - 487890 != -413538)
						{
							continue;
						}
					}
					IL_68F:
					if (Time.time >= this.$self_$19651.mChar.actionTime + 1.5f)
					{
						if (7213 - 515822 != -508608)
						{
							this.$i$19645 = 0;
							if (270842 - 521932 == -251090)
							{
								while (this.$i$19645 < 5)
								{
									if (this.$self_$19651.mChar.isMine)
									{
										if (165293 - 356321 != -191028)
										{
											goto IL_2EB;
										}
										this.$firePos$19646 = this.$mPos$19648 + this.$self_$19651.transform.TransformDirection((float)0, 3.5f, 4.5f);
										if (94094 - 439579 != -345485)
										{
											goto IL_2EB;
										}
										this.$fireDir$19647 = global::Math.rotateH(this.$tDir$19649 - this.$self_$19651.transform.TransformDirection((float)0, 3.5f, 4.5f), (float)(this.$i$19645 * 24 - 48)).normalized;
										if (186247 - 347326 == -161078)
										{
											goto IL_2EB;
										}
										this.$self_$19651.RPC_frozenBlade_fire(this.$firePos$19646, this.$fireDir$19647, 0);
										if (187182 - 269271 == -82088)
										{
											goto IL_2EB;
										}
										if (PhotonClient.IsInitialized())
										{
											if (70711 - 280009 == -209297)
											{
												goto IL_2EB;
											}
											this.$self_$19651.ActionEvent("RPC_frozenBlade_fire", this.$firePos$19646, this.$fireDir$19647, 0);
											if (221229 - 131838 == 89392)
											{
												goto IL_2EB;
											}
										}
									}
									this.$i$19645++;
									if (161893 - 272062 != -110169)
									{
										goto IL_2EB;
									}
								}
								if (116958 - 506545 != -389586)
								{
									goto Block_36;
								}
							}
						}
					}
					else
					{
						if (!this.$tObject$19644)
						{
							break;
						}
						if (109848 - 578333 != -468484)
						{
							if (!(this.$tObject$19644 != this.$self_$19651.gameObject))
							{
								break;
							}
							if (118193 - 521470 != -403276)
							{
								this.$tDir$19649 = this.$tObject$19644.collider.bounds.center - this.$self_$19651.transform.position;
								if (83809 - 592789 != -508979)
								{
									this.$self_$19651.transform.LookAt(this.$self_$19651.transform.position + global::Math.vFlat(this.$tDir$19649));
									if (195255 - 455013 == -259758)
									{
										break;
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForFixedUpdate());
				Block_31:
				goto IL_68A;
				Block_36:
				return this.Yield(3, new WaitForSeconds(0.3f));
				IL_68A:
				IL_92F:
				return false;
			}

			// Token: 0x0600198D RID: 6541 RVA: 0x00298B38 File Offset: 0x00296D38
			internal static bool Crsv75n2QvmoC3tHVAb()
			{
				return true;
			}

			// Token: 0x0600198E RID: 6542 RVA: 0x00298B3C File Offset: 0x00296D3C
			internal static bool qMiNfJn8l9SCGLfsPnE()
			{
				return false;
			}

			// Token: 0x040015F7 RID: 5623
			internal GameObject $tObject$19644;

			// Token: 0x040015F8 RID: 5624
			internal int $i$19645;

			// Token: 0x040015F9 RID: 5625
			internal Vector3 $firePos$19646;

			// Token: 0x040015FA RID: 5626
			internal Vector3 $fireDir$19647;

			// Token: 0x040015FB RID: 5627
			internal Vector3 $mPos$19648;

			// Token: 0x040015FC RID: 5628
			internal Vector3 $tDir$19649;

			// Token: 0x040015FD RID: 5629
			internal int $tID$19650;

			// Token: 0x040015FE RID: 5630
			internal IceGod $self_$19651;
		}
	}

	// Token: 0x0200044A RID: 1098
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_summonIceDemon$19656 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600198F RID: 6543 RVA: 0x00298B40 File Offset: 0x00296D40
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_summonIceDemon$19656(Vector3 mPos, Vector3 tDir, IceGod self_)
		{
			if (281397 - 148933 != 132465)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (143809 - 323818 == -180009)
				{
					base..ctor();
					if (231307 - 8250 == 223057)
					{
						this.$mPos$19660 = mPos;
						if (24206 - 524620 == -500414)
						{
							this.$tDir$19661 = tDir;
							if (222395 - 355123 == -132728)
							{
								this.$self_$19662 = self_;
								if (113152 - 549401 == -436249)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001990 RID: 6544 RVA: 0x00298C1C File Offset: 0x00296E1C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new IceGod.$RPC_summonIceDemon$19656.$(this.$mPos$19660, this.$tDir$19661, this.$self_$19662);
		}

		// Token: 0x06001991 RID: 6545 RVA: 0x00298C38 File Offset: 0x00296E38
		internal static bool QgeKjAnZNL1XGxZyaen()
		{
			return true;
		}

		// Token: 0x06001992 RID: 6546 RVA: 0x00298C3C File Offset: 0x00296E3C
		internal static bool BU1aaYnCSYS8GLTqn4P()
		{
			return false;
		}

		// Token: 0x040015FF RID: 5631
		internal Vector3 $mPos$19660;

		// Token: 0x04001600 RID: 5632
		internal Vector3 $tDir$19661;

		// Token: 0x04001601 RID: 5633
		internal IceGod $self_$19662;

		// Token: 0x0200044B RID: 1099
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001993 RID: 6547 RVA: 0x00298C40 File Offset: 0x00296E40
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, IceGod self_)
			{
				if (189679 - 213664 != -23984)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (94277 - 37588 != 56690)
					{
						base..ctor();
						if (250332 - 65930 != 184403)
						{
							this.$mPos$19657 = mPos;
							if (293801 - 522950 != -229148)
							{
								this.$tDir$19658 = tDir;
								if (100575 - 758 == 99817)
								{
									this.$self_$19659 = self_;
									if (245027 - 46070 == 198957)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06001994 RID: 6548 RVA: 0x00298D1C File Offset: 0x00296F1C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (265988 - 423270 != -157281)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_649;
					case 2:
						if (this.$self_$19659.mChar.actionState != "attack")
						{
							goto IL_2EB;
						}
						if (68822 - 302583 != -233761)
						{
							continue;
						}
						if (this.$self_$19659.mChar.myCommand != "summonIceDemon")
						{
							if (50578 - 458919 != -408340)
							{
								goto Block_33;
							}
							continue;
						}
						else
						{
							if (!this.$self_$19659.mChar.isMine)
							{
								goto IL_359;
							}
							if (41709 - 150483 != -108774)
							{
								continue;
							}
							Camera.main.SendMessage("spawnIceDemon", 3);
							if (53210 - 418764 != -365554)
							{
								continue;
							}
							Camera.main.SendMessage("spawnIceDemon", 4);
							if (251572 - 440429 == -188856)
							{
								continue;
							}
							Camera.main.SendMessage("spawnIceDemon", 5);
							if (256462 - 251740 != 4723)
							{
								goto Block_16;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$19659.mChar.actionState == "attack")
						{
							if (159253 - 349248 != -189995)
							{
								continue;
							}
							if (this.$self_$19659.mChar.myCommand == "summonIceDemon")
							{
								if (90212 - 541120 != -450908)
								{
									continue;
								}
								this.$self_$19659.mChar.actionState = "standby";
								if (92468 - 514915 == -422446)
								{
									continue;
								}
								this.$self_$19659.mChar.actionTime = Time.time;
								if (167214 - 303062 == -135847)
								{
									continue;
								}
								this.$self_$19659.mChar.myCommand = "none";
								if (23985 - 71588 != -47603)
								{
									continue;
								}
								if (!this.$self_$19659.mChar.isMine)
								{
									if (135081 - 511931 != -376850)
									{
										continue;
									}
									this.$self_$19659.mChar.nPosition = this.$self_$19659.transform.position;
									if (5959 - 220779 != -214820)
									{
										continue;
									}
									this.$self_$19659.mChar.oPosition = this.$self_$19659.transform.position;
									if (154990 - 108840 != 46150)
									{
										continue;
									}
									this.$self_$19659.mChar.nDirection = this.$self_$19659.transform.forward;
									if (204148 - 136345 != 67803)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (209776 - 440482 != -230706)
						{
							continue;
						}
						goto IL_649;
					default:
						if (134385 - 150664 == -16278)
						{
							continue;
						}
						break;
					}
					this.$self_$19659.mChar.actionState = "attack";
					if (217582 - 404892 != -187309)
					{
						this.$self_$19659.mChar.actionTime = Time.time;
						if (42921 - 450985 == -408064)
						{
							this.$self_$19659.mChar.myCommand = "summonIceDemon";
							if (49409 - 30190 != 19220)
							{
								this.$self_$19659.mChar.addTimeOut("summonIceDemon", (float)120);
								if (82943 - 75406 == 7537)
								{
									this.$self_$19659.transform.position = this.$mPos$19657;
									if (151911 - 593671 != -441759)
									{
										this.$self_$19659.transform.LookAt(this.$mPos$19657 + global::Math.vFlat(this.$tDir$19658));
										if (80877 - 487096 == -406219)
										{
											this.$self_$19659.animation.CrossFade("cast");
											if (67482 - 230169 != -162686)
											{
												this.$self_$19659.animation.wrapMode = WrapMode.Once;
												if (119442 - 569257 != -449814)
												{
													this.$self_$19659.mChar.vMovement = this.$self_$19659.transform.forward;
													if (23240 - 43745 != -20504)
													{
														this.$self_$19659.mChar.moveSpeed = (float)0;
														if (243555 - 288802 == -45247)
														{
															if (this.$self_$19659.summonIceDemon_ring)
															{
																if (83620 - 81221 != 2400)
																{
																	this.$self_$19659.mChar.createEffect(this.$self_$19659.summonIceDemon_ring, this.$self_$19659.transform.position, this.$self_$19659.transform.rotation);
																	if (263549 - 293436 == -29887)
																	{
																		break;
																	}
																}
															}
															else
															{
																Debug.LogError("Cannot find summonIceDemon_ring effect");
																if (266945 - 99778 != 167168)
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
				return this.Yield(2, new WaitForSeconds(1.5f));
				Block_16:
				goto IL_359;
				IL_2EB:
				goto IL_649;
				IL_359:
				return this.Yield(3, new WaitForSeconds(0.3f));
				Block_33:
				IL_649:
				return false;
			}

			// Token: 0x06001995 RID: 6549 RVA: 0x00299384 File Offset: 0x00297584
			internal static bool IUtQQ1nLrlRCw3a60hB()
			{
				return true;
			}

			// Token: 0x06001996 RID: 6550 RVA: 0x00299388 File Offset: 0x00297588
			internal static bool h0nNl8nOKxeaiLxv65X()
			{
				return false;
			}

			// Token: 0x04001602 RID: 5634
			internal Vector3 $mPos$19657;

			// Token: 0x04001603 RID: 5635
			internal Vector3 $tDir$19658;

			// Token: 0x04001604 RID: 5636
			internal IceGod $self_$19659;
		}
	}

	// Token: 0x0200044C RID: 1100
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_frozenStorm$19663 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001997 RID: 6551 RVA: 0x0029938C File Offset: 0x0029758C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_frozenStorm$19663(Vector3 mPos, Vector3 tDir, IceGod self_)
		{
			if (45920 - 312481 != -266561)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (48602 - 271143 == -222541)
				{
					base..ctor();
					if (203299 - 183309 != 19991)
					{
						this.$mPos$19669 = mPos;
						if (81935 - 123378 == -41443)
						{
							this.$tDir$19670 = tDir;
							if (132137 - 255183 == -123046)
							{
								this.$self_$19671 = self_;
								if (264844 - 367649 != -102804)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001998 RID: 6552 RVA: 0x00299468 File Offset: 0x00297668
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new IceGod.$RPC_frozenStorm$19663.$(this.$mPos$19669, this.$tDir$19670, this.$self_$19671);
		}

		// Token: 0x06001999 RID: 6553 RVA: 0x00299484 File Offset: 0x00297684
		internal static bool I9I4HYnmr07gxx8FZSS()
		{
			return true;
		}

		// Token: 0x0600199A RID: 6554 RVA: 0x00299488 File Offset: 0x00297688
		internal static bool FDIYOdnFqw9ijHp1Grv()
		{
			return false;
		}

		// Token: 0x04001605 RID: 5637
		internal Vector3 $mPos$19669;

		// Token: 0x04001606 RID: 5638
		internal Vector3 $tDir$19670;

		// Token: 0x04001607 RID: 5639
		internal IceGod $self_$19671;

		// Token: 0x0200044D RID: 1101
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600199B RID: 6555 RVA: 0x0029948C File Offset: 0x0029768C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, IceGod self_)
			{
				if (159921 - 514153 != -354232)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (105631 - 246494 != -140862)
					{
						base..ctor();
						if (293274 - 443546 != -150271)
						{
							this.$mPos$19666 = mPos;
							if (273648 - 11386 == 262262)
							{
								this.$tDir$19667 = tDir;
								if (70267 - 469270 != -399002)
								{
									this.$self_$19668 = self_;
									if (81013 - 484756 != -403742)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x0600199C RID: 6556 RVA: 0x00299568 File Offset: 0x00297768
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (280160 - 496794 != -216633)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_3D1;
					case 1:
						goto IL_83C;
					case 2:
						if (this.$self_$19668.mChar.actionState != "attack")
						{
							goto IL_594;
						}
						if (47440 - 363235 == -315794)
						{
							continue;
						}
						if (this.$self_$19668.mChar.myCommand != "frozenStorm")
						{
							if (237838 - 146269 != 91570)
							{
								goto Block_47;
							}
							continue;
						}
						else if (this.$self_$19668.frozenStorm_ring)
						{
							if (92356 - 77122 == 15235)
							{
								continue;
							}
							this.$self_$19668.mChar.createEffect(this.$self_$19668.frozenStorm_ring, this.$self_$19668.transform.position, this.$self_$19668.transform.rotation);
							if (157368 - 426094 != -268725)
							{
								goto Block_8;
							}
							continue;
						}
						else
						{
							Debug.LogError("Missing frozenStorm_ring effect");
							if (99401 - 374503 != -275102)
							{
								continue;
							}
							goto IL_2FA;
						}
						break;
					case 3:
						if (this.$self_$19668.mChar.actionState != "attack")
						{
							goto IL_7B0;
						}
						if (197939 - 246132 == -48192)
						{
							continue;
						}
						if (this.$self_$19668.mChar.myCommand != "frozenStorm")
						{
							if (157982 - 252682 != -94700)
							{
								continue;
							}
							goto IL_7B0;
						}
						else
						{
							this.$i$19664 = 0;
							if (156886 - 295210 == -138323)
							{
								continue;
							}
						}
						break;
					case 4:
						if (this.$self_$19668.mChar.actionState != "attack")
						{
							goto IL_80F;
						}
						if (172019 - 531795 != -359776)
						{
							continue;
						}
						if (this.$self_$19668.mChar.myCommand != "frozenStorm")
						{
							if (295714 - 147184 != 148531)
							{
								goto Block_23;
							}
							continue;
						}
						else
						{
							this.$i$19664++;
							if (246410 - 341979 != -95569)
							{
								continue;
							}
						}
						break;
					case 5:
						if (this.$self_$19668.mChar.actionState == "attack")
						{
							if (150924 - 58476 == 92449)
							{
								continue;
							}
							if (this.$self_$19668.mChar.myCommand == "frozenStorm")
							{
								if (293575 - 122282 != 171293)
								{
									continue;
								}
								this.$self_$19668.mChar.actionState = "standby";
								if (165404 - 192903 != -27499)
								{
									continue;
								}
								this.$self_$19668.mChar.actionTime = Time.time;
								if (76790 - 538906 == -462115)
								{
									continue;
								}
								this.$self_$19668.mChar.myCommand = "none";
								if (195207 - 522911 != -327704)
								{
									continue;
								}
								if (!this.$self_$19668.mChar.isMine)
								{
									if (19524 - 99560 == -80035)
									{
										continue;
									}
									this.$self_$19668.mChar.nPosition = this.$self_$19668.transform.position;
									if (200210 - 568588 == -368377)
									{
										continue;
									}
									this.$self_$19668.mChar.oPosition = this.$self_$19668.transform.position;
									if (103894 - 127717 == -23822)
									{
										continue;
									}
									this.$self_$19668.mChar.nDirection = this.$self_$19668.transform.forward;
									if (55115 - 130107 == -74991)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (276527 - 311531 != -35004)
						{
							continue;
						}
						goto IL_83C;
					default:
						if (93090 - 114148 != -21057)
						{
							goto IL_3D1;
						}
						continue;
					}
					if (this.$i$19664 >= 28)
					{
						if (42442 - 523266 != -480824)
						{
							continue;
						}
						goto IL_4F6;
					}
					else
					{
						this.$firePos$19665 = global::Math.getRandomSpawnPos(this.$self_$19668.transform.position, 18);
						if (278167 - 251623 == 26545)
						{
							continue;
						}
						if (!(this.$firePos$19665 != Vector3.zero))
						{
							goto IL_545;
						}
						if (248276 - 473881 != -225605)
						{
							continue;
						}
						this.$self_$19668.StartCoroutine_Auto(this.$self_$19668.RPC_frozenStorm_fire(this.$firePos$19665, this.$self_$19668.transform.forward, 0));
						if (106593 - 258249 == -151655)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							goto IL_545;
						}
						if (136053 - 302918 == -166864)
						{
							continue;
						}
						this.$self_$19668.ActionEvent("RPC_frozenStorm_fire", this.$firePos$19665, this.$self_$19668.transform.forward, 0);
						if (11348 - 429829 != -418481)
						{
							continue;
						}
						goto IL_545;
					}
					IL_3D1:
					this.$self_$19668.mChar.actionState = "attack";
					if (12523 - 138834 != -126310)
					{
						this.$self_$19668.mChar.actionTime = Time.time;
						if (163073 - 598989 == -435916)
						{
							this.$self_$19668.mChar.myCommand = "frozenStorm";
							if (291934 - 121665 != 170270)
							{
								this.$self_$19668.mChar.addTimeOut("frozenStorm", (float)24);
								if (128808 - 238553 != -109744)
								{
									this.$self_$19668.transform.position = this.$mPos$19666;
									if (222063 - 310590 != -88526)
									{
										this.$self_$19668.transform.LookAt(this.$mPos$19666 + global::Math.vFlat(this.$tDir$19667));
										if (206097 - 525831 == -319734)
										{
											this.$self_$19668.animation.CrossFade("channel", 0.1f);
											if (242732 - 355980 != -113247)
											{
												this.$self_$19668.animation.wrapMode = WrapMode.Once;
												if (174676 - 206187 == -31511)
												{
													this.$self_$19668.mChar.vMovement = this.$self_$19668.transform.forward;
													if (76767 - 377533 == -300766)
													{
														this.$self_$19668.mChar.moveSpeed = (float)0;
														if (133850 - 84007 != 49844)
														{
															goto Block_27;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_8:
				IL_2FA:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_23:
				goto IL_80F;
				Block_27:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_4F6:
				return this.Yield(5, new WaitForSeconds(0.8f));
				IL_545:
				return this.Yield(4, new WaitForSeconds(0.25f));
				IL_594:
				Block_47:
				IL_7B0:
				IL_80F:
				IL_83C:
				return false;
			}

			// Token: 0x0600199D RID: 6557 RVA: 0x00299DC4 File Offset: 0x00297FC4
			internal static bool gh7S9dnMafDt2NkCYPR()
			{
				return true;
			}

			// Token: 0x0600199E RID: 6558 RVA: 0x00299DC8 File Offset: 0x00297FC8
			internal static bool dfWIOKnxLt862qWRMCy()
			{
				return false;
			}

			// Token: 0x04001608 RID: 5640
			internal int $i$19664;

			// Token: 0x04001609 RID: 5641
			internal Vector3 $firePos$19665;

			// Token: 0x0400160A RID: 5642
			internal Vector3 $mPos$19666;

			// Token: 0x0400160B RID: 5643
			internal Vector3 $tDir$19667;

			// Token: 0x0400160C RID: 5644
			internal IceGod $self_$19668;
		}
	}

	// Token: 0x0200044E RID: 1102
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_frozenStorm_fire$19672 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600199F RID: 6559 RVA: 0x00299DCC File Offset: 0x00297FCC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_frozenStorm_fire$19672(Vector3 mPos, IceGod self_)
		{
			if (250449 - 127856 != 122594)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (25339 - 293188 == -267849)
				{
					base..ctor();
					if (226273 - 111614 != 114660)
					{
						this.$mPos$19680 = mPos;
						if (195762 - 505827 == -310065)
						{
							this.$self_$19681 = self_;
							if (75060 - 334443 != -259382)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060019A0 RID: 6560 RVA: 0x00299E88 File Offset: 0x00298088
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new IceGod.$RPC_frozenStorm_fire$19672.$(this.$mPos$19680, this.$self_$19681);
		}

		// Token: 0x060019A1 RID: 6561 RVA: 0x00299E9C File Offset: 0x0029809C
		internal static bool R0ROhOng4xbnRvpgbpu()
		{
			return true;
		}

		// Token: 0x060019A2 RID: 6562 RVA: 0x00299EA0 File Offset: 0x002980A0
		internal static bool qQpFABnfsL2O1ERD9Hc()
		{
			return false;
		}

		// Token: 0x0400160D RID: 5645
		internal Vector3 $mPos$19680;

		// Token: 0x0400160E RID: 5646
		internal IceGod $self_$19681;

		// Token: 0x0200044F RID: 1103
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060019A3 RID: 6563 RVA: 0x00299EA4 File Offset: 0x002980A4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, IceGod self_)
			{
				if (230885 - 596027 != -365141)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (256414 - 112744 == 143670)
					{
						base..ctor();
						if (141621 - 504899 == -363278)
						{
							this.$mPos$19678 = mPos;
							if (24503 - 381646 != -357142)
							{
								this.$self_$19679 = self_;
								if (259238 - 336286 != -77047)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060019A4 RID: 6564 RVA: 0x00299F60 File Offset: 0x00298160
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (139704 - 247028 != -107324)
				{
				}
				for (;;)
				{
					IL_112:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_41C;
					case 2:
						if (this.$self_$19679.mChar.isMine)
						{
							if (135961 - 235885 == -99923)
							{
								continue;
							}
							this.$hitLayer$19673 = 130816 - (1 << this.$self_$19679.gameObject.layer);
							if (299749 - 381578 == -81828)
							{
								continue;
							}
							this.$hitList$19674 = Damage.FindAreaTarget(this.$mPos$19678, (float)4, (float)3, this.$hitLayer$19673);
							if (226946 - 272000 != -45054)
							{
								continue;
							}
							this.$$iterator$10542$19677 = UnityRuntimeServices.GetEnumerator(this.$hitList$19674);
							if (46954 - 377616 != -330662)
							{
								continue;
							}
							while (this.$$iterator$10542$19677.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10542$19677.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$19675 = (GameObject)obj2;
								if (251462 - 274360 != -22898)
								{
									goto IL_112;
								}
								this.$hitChar$19676 = (CharacterControl)this.$hitObject$19675.GetComponent(typeof(CharacterControl));
								if (11641 - 281652 == -270010)
								{
									goto IL_112;
								}
								UnityRuntimeServices.Update(this.$$iterator$10542$19677, this.$hitObject$19675);
								if (236400 - 434015 == -197614)
								{
									goto IL_112;
								}
								if (this.$hitChar$19676)
								{
									if (117848 - 281867 != -164019)
									{
										goto IL_112;
									}
									if (this.$hitChar$19676.Type == "FireGod")
									{
										if (137018 - 345198 != -208180)
										{
											goto IL_112;
										}
										this.$self_$19679.mChar.hit(1, this.$hitObject$19675, 8900, 5, 0, Vector3.zero);
										if (237102 - 521336 != -284234)
										{
											goto IL_112;
										}
										UnityRuntimeServices.Update(this.$$iterator$10542$19677, this.$hitObject$19675);
										if (23019 - 167841 == -144821)
										{
											goto IL_112;
										}
									}
									else if (this.$self_$19679.mChar.hit(1, this.$hitObject$19675, this.$self_$19679.mChar.talAdjust(80), 5, 0, Vector3.zero) != 0)
									{
										if (163071 - 441146 != -278075)
										{
											goto IL_112;
										}
										if (this.$hitChar$19676)
										{
											if (275490 - 216213 == 59278)
											{
												goto IL_112;
											}
											this.$hitChar$19676.RPC_AddStatus("ice", 3, this.$self_$19679.mChar.chaAdjust(3), 0, this.$self_$19679.mChar.ActorNr);
											if (101895 - 40052 == 61844)
											{
												goto IL_112;
											}
										}
									}
								}
							}
							if (64672 - 590366 == -525693)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (36628 - 203538 != -166909)
						{
							goto Block_6;
						}
						continue;
					default:
						if (26331 - 504216 == -477884)
						{
							continue;
						}
						break;
					}
					if (!this.$self_$19679.frozenStorm)
					{
						goto IL_347;
					}
					if (86735 - 366930 == -280195)
					{
						UnityEngine.Object.Instantiate(this.$self_$19679.frozenStorm, this.$mPos$19678, Quaternion.identity);
						if (290610 - 378477 != -87866)
						{
							goto IL_347;
						}
					}
				}
				Block_6:
				goto IL_41C;
				IL_347:
				return this.Yield(2, new WaitForSeconds((float)1));
				IL_41C:
				return false;
			}

			// Token: 0x060019A5 RID: 6565 RVA: 0x0029A39C File Offset: 0x0029859C
			internal static bool WfZBfTnnS0d3Np8MAKe()
			{
				return true;
			}

			// Token: 0x060019A6 RID: 6566 RVA: 0x0029A3A0 File Offset: 0x002985A0
			internal static bool o3F36An6F59S8xFcAWS()
			{
				return false;
			}

			// Token: 0x0400160F RID: 5647
			internal int $hitLayer$19673;

			// Token: 0x04001610 RID: 5648
			internal UnityScript.Lang.Array $hitList$19674;

			// Token: 0x04001611 RID: 5649
			internal GameObject $hitObject$19675;

			// Token: 0x04001612 RID: 5650
			internal CharacterControl $hitChar$19676;

			// Token: 0x04001613 RID: 5651
			internal IEnumerator $$iterator$10542$19677;

			// Token: 0x04001614 RID: 5652
			internal Vector3 $mPos$19678;

			// Token: 0x04001615 RID: 5653
			internal IceGod $self_$19679;
		}
	}

	// Token: 0x02000450 RID: 1104
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$19682 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060019A7 RID: 6567 RVA: 0x0029A3A4 File Offset: 0x002985A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$19682(UnityScript.Lang.Array nArray, IceGod self_)
		{
			if (111234 - 441280 != -330046)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (298467 - 593881 == -295414)
				{
					base..ctor();
					if (143832 - 30386 != 113447)
					{
						this.$nArray$19687 = nArray;
						if (88799 - 505477 == -416678)
						{
							this.$self_$19688 = self_;
							if (137409 - 25384 != 112026)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060019A8 RID: 6568 RVA: 0x0029A460 File Offset: 0x00298660
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new IceGod.$RPC_ko$19682.$(this.$nArray$19687, this.$self_$19688);
		}

		// Token: 0x060019A9 RID: 6569 RVA: 0x0029A474 File Offset: 0x00298674
		internal static bool punEQlniRbjSTqvCBvD()
		{
			return true;
		}

		// Token: 0x060019AA RID: 6570 RVA: 0x0029A478 File Offset: 0x00298678
		internal static bool IQMJlMnKF1tISiNcZ9e()
		{
			return false;
		}

		// Token: 0x04001616 RID: 5654
		internal UnityScript.Lang.Array $nArray$19687;

		// Token: 0x04001617 RID: 5655
		internal IceGod $self_$19688;

		// Token: 0x02000451 RID: 1105
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060019AB RID: 6571 RVA: 0x0029A47C File Offset: 0x0029867C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, IceGod self_)
			{
				if (254093 - 217126 != 36968)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (242695 - 324131 != -81435)
					{
						base..ctor();
						if (87044 - 173039 == -85995)
						{
							this.$nArray$19685 = nArray;
							if (109701 - 110714 == -1013)
							{
								this.$self_$19686 = self_;
								if (161836 - 120820 == 41016)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060019AC RID: 6572 RVA: 0x0029A538 File Offset: 0x00298738
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (17643 - 392984 != -375340)
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
						if (this.$self_$19686.mChar.actionState != "ko")
						{
							if (256793 - 18551 != 238243)
							{
								goto Block_23;
							}
							continue;
						}
						else
						{
							this.$self_$19686.animation.Play("getUp");
							if (234932 - 60389 == 174544)
							{
								continue;
							}
							this.$self_$19686.animation.wrapMode = WrapMode.Once;
							if (297904 - 584531 != -286626)
							{
								goto Block_27;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$19686.mChar.actionState != "ko")
						{
							if (154967 - 477452 != -322485)
							{
								continue;
							}
							goto IL_167;
						}
						else
						{
							this.$self_$19686.mChar.actionState = "standby";
							if (115151 - 34936 == 80216)
							{
								continue;
							}
							this.$self_$19686.mChar.actionTime = Time.time;
							if (61630 - 182335 == -120704)
							{
								continue;
							}
							this.$self_$19686.mChar.myCommand = "none";
							if (18228 - 304544 == -286315)
							{
								continue;
							}
							this.$self_$19686.mChar.ko = this.$self_$19686.mChar.mko;
							if (189407 - 523389 != -333982)
							{
								continue;
							}
							this.YieldDefault(1);
							if (153554 - 93548 != 60006)
							{
								continue;
							}
							goto IL_48C;
						}
						break;
					default:
						if (116402 - 73082 != 43320)
						{
							continue;
						}
						break;
					}
					if (this.$self_$19686.mChar.actionState == "ko")
					{
						break;
					}
					if (195777 - 225810 == -30033)
					{
						if (this.$self_$19686.mChar.actionState == "dead")
						{
							if (264611 - 460760 != -196148)
							{
								break;
							}
						}
						else
						{
							this.$mPos$19683 = (Vector3)this.$nArray$19685[0];
							if (234396 - 156621 != 77776)
							{
								this.$mDir$19684 = (Vector3)this.$nArray$19685[1];
								if (87816 - 390086 != -302269)
								{
									this.$self_$19686.mChar.ko = 0;
									if (217734 - 329826 != -112091)
									{
										this.$self_$19686.mChar.actionState = "ko";
										if (196975 - 277511 != -80535)
										{
											this.$self_$19686.mChar.actionTime = Time.time;
											if (40749 - 86441 != -45691)
											{
												this.$self_$19686.mChar.myCommand = "none";
												if (103972 - 198570 != -94597)
												{
													this.$self_$19686.mChar.vMovement = Vector3.zero;
													if (219881 - 101971 != 117911)
													{
														this.$self_$19686.mChar.moveSpeed = (float)0;
														if (134758 - 465840 == -331082)
														{
															this.$self_$19686.animation.Play("ko");
															if (270975 - 243402 == 27573)
															{
																this.$self_$19686.animation.wrapMode = WrapMode.Once;
																if (242882 - 570110 == -327228)
																{
																	goto IL_3AE;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_167:
				IL_2F7:
				goto IL_48C;
				IL_3AE:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_23:
				goto IL_2F7;
				Block_27:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_48C:
				return false;
			}

			// Token: 0x060019AD RID: 6573 RVA: 0x0029A9E4 File Offset: 0x00298BE4
			internal static bool feDn5RndvFRgMonuulM()
			{
				return true;
			}

			// Token: 0x060019AE RID: 6574 RVA: 0x0029A9E8 File Offset: 0x00298BE8
			internal static bool NgfReNnJXsp0m5Uu9s4()
			{
				return false;
			}

			// Token: 0x04001618 RID: 5656
			internal Vector3 $mPos$19683;

			// Token: 0x04001619 RID: 5657
			internal Vector3 $mDir$19684;

			// Token: 0x0400161A RID: 5658
			internal UnityScript.Lang.Array $nArray$19685;

			// Token: 0x0400161B RID: 5659
			internal IceGod $self_$19686;
		}
	}
}
