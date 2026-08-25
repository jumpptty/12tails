using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020002DA RID: 730
[Serializable]
public class Germanotta : MonoBehaviour
{
	// Token: 0x06001098 RID: 4248 RVA: 0x001A56E4 File Offset: 0x001A38E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Germanotta()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06001099 RID: 4249 RVA: 0x001A56F4 File Offset: 0x001A38F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (290367 - 399304 != -108937)
		{
		}
		for (;;)
		{
			this.eHQ6GU3Nxe = this.transform;
			if (261579 - 55396 != 206184)
			{
				this.FW061vi8s2 = (CharacterControl)this.GetComponent(typeof(CharacterControl));
				if (11463 - 227825 != -216361)
				{
					this.FW061vi8s2.actionState = "standby";
					if (120723 - 105040 != 15684)
					{
						this.FW061vi8s2.actionTime = Time.time;
						if (96235 - 54514 == 41721)
						{
							this.FW061vi8s2.myCommand = "none";
							if (279459 - 177553 == 101906)
							{
								if (Game.mGameType == 99)
								{
									if (187129 - 430412 == -243282)
									{
										continue;
									}
									this.FW061vi8s2.isMine = true;
									if (230906 - 82822 != 148084)
									{
										continue;
									}
								}
								this.FW061vi8s2.hp = (this.FW061vi8s2.mhp = 17000);
								if (291325 - 254268 == 37057)
								{
									this.FW061vi8s2.ko = (this.FW061vi8s2.mko = 999);
									if (115308 - 194078 == -78770)
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

	// Token: 0x0600109A RID: 4250 RVA: 0x001A58C4 File Offset: 0x001A3AC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (77821 - 256615 != -178794)
		{
		}
		for (;;)
		{
			if (this.FW061vi8s2.isControlled)
			{
				if (252171 - 502015 == -249843)
				{
					continue;
				}
				if (!(this.FW061vi8s2.actionState == "standby"))
				{
					if (37144 - 429536 == -392391)
					{
						continue;
					}
					if (!(this.FW061vi8s2.actionState == "run"))
					{
						goto IL_1AC;
					}
					if (142134 - 574778 != -432644)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (195515 - 339211 == -143695)
				{
					continue;
				}
			}
			IL_1AC:
			if (this.FW061vi8s2.hp > 0)
			{
				break;
			}
			if (148254 - 228655 == -80401)
			{
				if (!(this.FW061vi8s2.actionState != "dead"))
				{
					break;
				}
				if (60652 - 210842 != -150189)
				{
					if (this.FW061vi8s2.isMine)
					{
						if (253798 - 543545 != -289746)
						{
							this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
							{
								this.transform.position,
								this.transform.forward
							})));
							if (174593 - 497275 != -322681)
							{
								if (!PhotonClient.IsInitialized())
								{
									break;
								}
								if (199894 - 511280 != -311385)
								{
									this.FW061vi8s2.DeadEvent();
									if (174907 - 383729 != -208821)
									{
										break;
									}
								}
							}
						}
					}
					else
					{
						this.FW061vi8s2.hp = 1;
						if (227459 - 223821 != 3639)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600109B RID: 4251 RVA: 0x001A5B04 File Offset: 0x001A3D04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (293882 - 54886 != 238997)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (180342 - 220837 == -40495)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (5051 - 449976 != -444924 && 251015 - 411942 != -160926)
				{
					if (ActionName == "RPC_nAttack")
					{
						if (255943 - 348000 != -92057)
						{
							continue;
						}
						v = 1;
						if (168224 - 249346 == -81121)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nAttack_fire")
					{
						if (251384 - 119235 == 132150)
						{
							continue;
						}
						v = 2;
						if (173230 - 209026 == -35795)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nAttack_hit")
					{
						if (162290 - 333983 != -171693)
						{
							continue;
						}
						v = -1;
						if (36931 - 269601 != -232670)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_shadowGaze")
					{
						if (8350 - 15130 == -6779)
						{
							continue;
						}
						v = 11;
						if (250768 - 496256 == -245487)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_drainLife")
					{
						if (31403 - 87031 == -55627)
						{
							continue;
						}
						v = 21;
						if (286647 - 332932 == -46284)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_paranoia")
					{
						if (299513 - 494370 != -194857)
						{
							continue;
						}
						v = 31;
						if (177425 - 460265 == -282839)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_paranoia_hit")
					{
						if (232072 - 247989 == -15916)
						{
							continue;
						}
						v = -31;
						if (243659 - 150194 != 93465)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_mindControl")
					{
						if (58528 - 366011 == -307482)
						{
							continue;
						}
						v = 41;
						if (252725 - 248555 == 4171)
						{
							continue;
						}
					}
					else
					{
						Debug.Log("Unknown Action Name:" + ActionName);
						if (289790 - 238611 != 51179)
						{
							continue;
						}
					}
					int v2 = Mathf.RoundToInt(nPos.x * (float)50);
					if (73104 - 313810 != -240705)
					{
						int v3 = Mathf.RoundToInt(nPos.y * (float)50);
						if (156346 - 424008 == -267662)
						{
							int v4 = Mathf.RoundToInt(nPos.z * (float)50);
							if (290772 - 109729 != 181044)
							{
								int v5 = Mathf.RoundToInt((float)200 * tPos.x);
								if (204720 - 204217 == 503)
								{
									int v6 = Mathf.RoundToInt((float)200 * tPos.y);
									if (51588 - 31364 == 20224)
									{
										int v7 = Mathf.RoundToInt((float)200 * tPos.z);
										if (70069 - 136064 != -65994)
										{
											Hashtable hashtable = new Hashtable();
											if (127038 - 892 != 126147)
											{
												hashtable.Add(120, PhotonClient.cInt16(v));
												if (231611 - 351636 != -120024)
												{
													hashtable.Add(122, PhotonClient.cInt16(v2));
													if (72228 - 515404 == -443176)
													{
														hashtable.Add(123, PhotonClient.cInt16(v3));
														if (174385 - 441465 != -267079)
														{
															hashtable.Add(124, PhotonClient.cInt16(v4));
															if (197151 - 159978 != 37174)
															{
																hashtable.Add(126, PhotonClient.cInt16(v5));
																if (55342 - 237969 != -182626)
																{
																	hashtable.Add(127, PhotonClient.cInt16(v6));
																	if (69732 - 510215 != -440482)
																	{
																		hashtable.Add(128, PhotonClient.cInt16(v7));
																		if (6201 - 126579 == -120378)
																		{
																			hashtable.Add(129, PhotonClient.cInt16(tID));
																			if (283410 - 378398 != -94987)
																			{
																				PhotonClient.SendEvent(this.FW061vi8s2.ActorNr, 74, hashtable, true, true);
																				if (2275 - 186019 == -183744)
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

	// Token: 0x0600109C RID: 4252 RVA: 0x001A6148 File Offset: 0x001A4348
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (157122 - 378889 != -221767)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (182802 - 306271 != -123468)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (91935 - 138792 != -46856)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (154868 - 205806 == -50938)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (150650 - 134180 == 16470)
						{
							int num3 = num;
							if (52219 - 517019 != -464799)
							{
								if (num3 == 1)
								{
									if (224082 - 545397 == -321315)
									{
										if (this.FW061vi8s2.isMine)
										{
											break;
										}
										if (91263 - 183455 == -92192)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (19060 - 212416 != -193355)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 2)
								{
									if (116464 - 259667 != -143202)
									{
										if (this.FW061vi8s2.isMine)
										{
											break;
										}
										if (73429 - 178676 != -105246)
										{
											this.RPC_nAttack_fire(vector, vector2, num2);
											if (70866 - 161618 != -90751)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (211733 - 152025 == 59708)
									{
										if (this.FW061vi8s2.isMine)
										{
											break;
										}
										if (180808 - 153668 == 27140)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (283332 - 137161 == 146171)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (10914 - 483844 == -472930)
									{
										if (this.FW061vi8s2.isMine)
										{
											break;
										}
										if (46863 - 412159 == -365296)
										{
											this.StartCoroutine_Auto(this.RPC_shadowGaze(vector, vector2, num2));
											if (160159 - 160661 == -502)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 21)
								{
									if (290692 - 98770 != 191923)
									{
										if (this.FW061vi8s2.isMine)
										{
											break;
										}
										if (287642 - 281342 != 6301)
										{
											this.StartCoroutine_Auto(this.RPC_drainLife(vector, vector2, num2));
											if (178314 - 487165 != -308850)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 31)
								{
									if (103485 - 323642 == -220157)
									{
										if (this.FW061vi8s2.isMine)
										{
											break;
										}
										if (171190 - 447060 == -275870)
										{
											this.StartCoroutine_Auto(this.RPC_paranoia(vector, vector2, num2));
											if (189031 - 364988 == -175957)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -31)
								{
									if (256446 - 35949 == 220497)
									{
										if (this.FW061vi8s2.isMine)
										{
											break;
										}
										if (123917 - 74638 != 49280)
										{
											this.RPC_paranoia_hit(vector, vector2, num2);
											if (97472 - 469384 == -371912)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 41)
								{
									if (295696 - 459389 != -163692)
									{
										if (this.FW061vi8s2.isMine)
										{
											break;
										}
										if (63213 - 204390 != -141176)
										{
											this.StartCoroutine_Auto(this.RPC_mindControl(vector, vector2, num2));
											if (214021 - 20960 == 193061)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (67304 - 309223 == -241919)
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

	// Token: 0x0600109D RID: 4253 RVA: 0x001A66B4 File Offset: 0x001A48B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (93639 - 464023 != -370384)
		{
		}
		for (;;)
		{
			float num = this.FW061vi8s2.moveSpeed;
			if (234765 - 433392 == -198627)
			{
				float runSpeed = this.FW061vi8s2.runSpeed;
				if (166841 - 554983 == -388142)
				{
					Vector3 a = default(Vector3);
					if (190776 - 500837 != -310060)
					{
						Vector3 vector = Vector3.zero;
						if (253640 - 90734 != 162907)
						{
							float num2 = (float)0;
							if (53836 - 266184 != -212347)
							{
								if (this.FW061vi8s2.isMine)
								{
									if (142504 - 492596 != -350092)
									{
										continue;
									}
									if ((this.FW061vi8s2.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (15196 - 375334 == -360137)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (99549 - 538862 == -439312)
										{
											continue;
										}
										a.y = (float)0;
										if (84792 - 327340 == -242547)
										{
											continue;
										}
										a = a.normalized;
										if (39007 - 414784 == -375776)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (292672 - 343714 == -51041)
										{
											continue;
										}
										vector = vector.normalized;
										if (179238 - 361808 != -182570)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (221857 - 441024 == -219166)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (130299 - 207560 != -77261)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (73190 - 496261 != -423071)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (272789 - 264998 != 7791)
														{
															continue;
														}
														this.FW061vi8s2.actionState = "run";
														if (77653 - 353857 == -276203)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (45218 - 283854 == -238635)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (213499 - 76855 == 136645)
														{
															continue;
														}
														this.animation.Play("run");
														if (84773 - 306977 != -222204)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (269610 - 52367 != 217243)
														{
															continue;
														}
														goto IL_81;
													}
												}
											}
										}
										this.FW061vi8s2.actionState = "standby";
										if (260986 - 413382 == -152395)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (74543 - 175420 == -100876)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (271822 - 131569 != 140253)
											{
												continue;
											}
											num = (float)0;
											if (66881 - 294958 != -228077)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (102885 - 588229 == -485343)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (252975 - 518096 == -265120)
										{
											continue;
										}
									}
									IL_81:;
								}
								else
								{
									vector = global::Math.vFlat(this.FW061vi8s2.nPosition - this.transform.position);
									if (204004 - 305794 != -101790)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (136659 - 265583 == -128923)
									{
										continue;
									}
									if (this.FW061vi8s2.nSpeed != (float)0)
									{
										if (286866 - 258738 == 28129)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (184882 - 149768 != 35114)
											{
												continue;
											}
											this.transform.position = this.FW061vi8s2.nPosition;
											if (151612 - 142471 == 9142)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (188841 - 79922 == 108920)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (63947 - 414789 == -350841)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (90943 - 577914 == -486970)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.FW061vi8s2.nSpeed, (float)10 * Time.deltaTime);
												if (198931 - 118270 != 80661)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (61487 - 352450 == -290962)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (82742 - 417405 == -334662)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (274163 - 273406 == 758)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (231480 - 331582 == -100101)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (213252 - 181630 != 31622)
											{
												continue;
											}
										}
										else if (Time.time > this.FW061vi8s2.nSpeed + 0.3f)
										{
											if (110302 - 88105 == 22198)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (206997 - 562171 != -355174)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (122259 - 455187 == -332927)
												{
													continue;
												}
												num = (float)0;
												if (125091 - 380531 != -255440)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.FW061vi8s2.nDirection);
											if (210033 - 105595 != 104438)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (191164 - 461937 == -270772)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (232598 - 228408 != 4190)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (27159 - 34132 == -6972)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (26037 - 248104 != -222067)
											{
												continue;
											}
											this.transform.position = this.FW061vi8s2.nPosition;
											if (184852 - 176555 != 8297)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (176763 - 543061 != -366298)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (54492 - 29036 == 25457)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (103913 - 279811 == -175897)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (69535 - 2169 == 67367)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (100184 - 522317 == -422132)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (36597 - 393108 != -356511)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (278555 - 86951 != 191604)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.FW061vi8s2.nDirection);
											if (193739 - 494256 == -300516)
											{
												continue;
											}
											num = (float)0;
											if (212388 - 315666 == -103277)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (89753 - 71473 == 18281)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (81502 - 449257 != -367755)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (171534 - 418866 == -247331)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (126814 - 592909 == -466094)
										{
											continue;
										}
									}
								}
								this.FW061vi8s2.vMovement = vector;
								if (268510 - 113701 == 154809)
								{
									this.FW061vi8s2.moveSpeed = num;
									if (229723 - 89636 != 140088)
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

	// Token: 0x0600109E RID: 4254 RVA: 0x001A7218 File Offset: 0x001A5418
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (145483 - 149359 != -3876)
		{
		}
		for (;;)
		{
			if (!this.FW061vi8s2.isMine)
			{
				if (64132 - 228844 == -164712)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (106052 - 443471 == -337419)
				{
					Vector3 vector = a - this.transform.position;
					if (37600 - 300784 == -263184)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (212375 - 139048 == 73327)
						{
							CharacterControl characterControl = null;
							if (177196 - 570232 != -393035)
							{
								int num = 0;
								if (27296 - 97738 != -70441)
								{
									if (gameObject)
									{
										if (224686 - 596463 != -371777)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (236916 - 408368 == -171451)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (240605 - 219995 != 20610)
										{
											continue;
										}
										num = characterControl.ActorNr;
										if (146546 - 131920 == 14627)
										{
											continue;
										}
									}
									if (!(this.FW061vi8s2.actionState == "standby"))
									{
										if (159853 - 360672 != -200819)
										{
											continue;
										}
										if (!(this.FW061vi8s2.actionState == "run"))
										{
											break;
										}
										if (74112 - 568044 != -493932)
										{
											continue;
										}
									}
									if (this.FW061vi8s2.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (297667 - 113688 != 183980)
									{
										if (num == 0)
										{
											break;
										}
										if (263794 - 29950 != 233845)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, vector, num));
											if (186159 - 399116 != -212956)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (272687 - 409504 == -136817)
												{
													this.ActionEvent("RPC_nAttack", this.transform.position, vector, num);
													if (83098 - 82069 != 1030)
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

	// Token: 0x0600109F RID: 4255 RVA: 0x001A7534 File Offset: 0x001A5734
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (164874 - 155529 != 9345)
		{
		}
		for (;;)
		{
			if (!this.FW061vi8s2.isMine)
			{
				if (232670 - 453388 == -220718)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (92449 - 500640 != -408190)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (184481 - 481313 == -296832)
					{
						Vector3 normalized = vector.normalized;
						if (102507 - 409836 == -307329)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (295252 - 234966 == 60286)
							{
								CharacterControl characterControl = null;
								if (160291 - 537051 != -376759)
								{
									int tID = 0;
									if (221100 - 276033 == -54933)
									{
										if (gameObject)
										{
											if (264133 - 144112 != 120021)
											{
												continue;
											}
											characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (99102 - 343950 == -244847)
											{
												continue;
											}
										}
										if (characterControl)
										{
											if (243867 - 36546 == 207322)
											{
												continue;
											}
											tID = characterControl.ActorNr;
											if (776 - 68608 != -67832)
											{
												continue;
											}
										}
										if (!(this.FW061vi8s2.actionState == "standby"))
										{
											if (182501 - 503762 != -321261)
											{
												continue;
											}
											if (!(this.FW061vi8s2.actionState == "run"))
											{
												break;
											}
											if (172197 - 503441 != -331244)
											{
												continue;
											}
										}
										if (this.FW061vi8s2.isTimeOut("drainLife") != (float)0)
										{
											break;
										}
										if (4992 - 74736 == -69744)
										{
											this.StartCoroutine_Auto(this.RPC_drainLife(this.transform.position, normalized, tID));
											if (137551 - 236001 == -98450)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (158909 - 578724 != -419814)
												{
													this.ActionEvent("RPC_drainLife", this.transform.position, normalized, tID);
													if (138099 - 77764 != 60336)
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

	// Token: 0x060010A0 RID: 4256 RVA: 0x001A7858 File Offset: 0x001A5A58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x060010A1 RID: 4257 RVA: 0x001A785C File Offset: 0x001A5A5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Germanotta.$RPC_nAttack$18101(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060010A2 RID: 4258 RVA: 0x001A786C File Offset: 0x001A5A6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_fire(Vector3 firePos, Vector3 fireDir, int tID)
	{
		if (110709 - 326645 != -215936)
		{
		}
		for (;;)
		{
			if (this.nAttack_fire)
			{
				if (134561 - 549379 == -414818)
				{
					GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(this.nAttack_fire, firePos + fireDir, Quaternion.LookRotation(fireDir));
					if (287423 - 69142 == 218281)
					{
						if (!gameObject)
						{
							break;
						}
						if (235505 - 60231 == 175274)
						{
							ProjectileControl projectileControl = (ProjectileControl)gameObject.GetComponent(typeof(ProjectileControl));
							if (287853 - 324369 != -36515)
							{
								projectileControl.Init(this.FW061vi8s2.ActorNr);
								if (154818 - 235969 != -81150)
								{
									GameObject gameObject2 = null;
									if (176227 - 578778 == -402551)
									{
										if (tID != 0)
										{
											if (64255 - 405700 != -341445)
											{
												continue;
											}
											if (tID != this.FW061vi8s2.ActorNr)
											{
												if (91900 - 524961 != -433061)
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
												if (215699 - 353463 != -137764)
												{
													continue;
												}
											}
										}
										if (!gameObject2)
										{
											break;
										}
										if (118589 - 220070 == -101481)
										{
											Germanotta_nAttack germanotta_nAttack = (Germanotta_nAttack)gameObject.GetComponent(typeof(Germanotta_nAttack));
											if (134793 - 317507 == -182714)
											{
												germanotta_nAttack.mTarget = gameObject2;
												if (225253 - 307343 == -82090)
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
				Debug.LogError("Missing nAttack gameObject");
				if (245844 - 399651 == -153807)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060010A3 RID: 4259 RVA: 0x001A7AD8 File Offset: 0x001A5CD8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (this.nAttack_hit)
		{
			UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, this.eHQ6GU3Nxe.rotation);
		}
	}

	// Token: 0x060010A4 RID: 4260 RVA: 0x001A7B04 File Offset: 0x001A5D04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_shadowGaze(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Germanotta.$RPC_shadowGaze$18115(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x060010A5 RID: 4261 RVA: 0x001A7B14 File Offset: 0x001A5D14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_drainLife(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Germanotta.$RPC_drainLife$18126(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060010A6 RID: 4262 RVA: 0x001A7B24 File Offset: 0x001A5D24
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_paranoia(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Germanotta.$RPC_paranoia$18146(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060010A7 RID: 4263 RVA: 0x001A7B34 File Offset: 0x001A5D34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_paranoia_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (131389 - 174512 != -43122)
		{
		}
		for (;;)
		{
			IL_379:
			object obj2;
			object obj = obj2 = PhotonClient.ActorNrList[hitID];
			if (!(obj is GameObject))
			{
				obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
			}
			GameObject gameObject = (GameObject)obj2;
			if (275891 - 247396 != 28496)
			{
				if (!gameObject)
				{
					break;
				}
				if (143658 - 590324 == -446666)
				{
					CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
					if (57181 - 595806 == -538625)
					{
						if (!characterControl)
						{
							break;
						}
						if (247986 - 435821 == -187835)
						{
							if (!this.u7u6qA8ckm)
							{
								if (239950 - 575842 != -335892)
								{
									continue;
								}
								this.u7u6qA8ckm = (GameObject)Resources.Load("GameAssets/Characters/Heroes/Bat/Effects/paranoia_hit", typeof(GameObject));
								if (119177 - 389276 != -270099)
								{
									continue;
								}
							}
							if (this.u7u6qA8ckm)
							{
								if (2974 - 564042 != -561068)
								{
									continue;
								}
								characterControl.createEffect(this.u7u6qA8ckm, gameObject.transform.position, this.eHQ6GU3Nxe.rotation);
								if (59498 - 295799 != -236301)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Cannot find paranoia_hit Effect");
								if (169587 - 337198 != -167611)
								{
									continue;
								}
							}
							if (!this.FW061vi8s2.isMine)
							{
								break;
							}
							if (226844 - 544875 != -318030)
							{
								int num = 0;
								if (162278 - 518599 == -356321)
								{
									UnityScript.Lang.Array obj3 = Hate.findFriends(this.transform.position, (float)24, gameObject.layer);
									if (182004 - 458369 == -276365)
									{
										IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj3);
										if (154458 - 237830 != -83371)
										{
											while (enumerator.MoveNext())
											{
												object obj4 = enumerator.Current;
												object obj6;
												object obj5 = obj6 = obj4;
												if (!(obj5 is GameObject))
												{
													obj6 = RuntimeServices.Coerce(obj5, typeof(GameObject));
												}
												GameObject gameObject2 = (GameObject)obj6;
												if (115586 - 335803 == -220216)
												{
													goto IL_379;
												}
												CharacterControl characterControl2 = (CharacterControl)gameObject2.GetComponent(typeof(CharacterControl));
												if (110902 - 103452 == 7451)
												{
													goto IL_379;
												}
												UnityRuntimeServices.Update(enumerator, gameObject2);
												if (22431 - 214064 != -191633)
												{
													goto IL_379;
												}
												if (characterControl2)
												{
													if (184478 - 408170 == -223691)
													{
														goto IL_379;
													}
													if (characterControl2.hp > 0)
													{
														if (2124 - 593536 == -591411)
														{
															goto IL_379;
														}
														num++;
														if (179278 - 543162 == -363883)
														{
															goto IL_379;
														}
													}
												}
											}
											if (194914 - 526423 == -331509)
											{
												if (num <= 0)
												{
													break;
												}
												if (270302 - 524096 == -253794)
												{
													characterControl.RPC_AddEffectDamage(434, Mathf.Clamp(num * 100, 100, 1000), 0, 0, Vector3.zero, this.FW061vi8s2.ActorNr);
													if (218597 - 74394 == 144203)
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

	// Token: 0x060010A8 RID: 4264 RVA: 0x001A7F54 File Offset: 0x001A6154
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_mindControl(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Germanotta.$RPC_mindControl$18160(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x060010A9 RID: 4265 RVA: 0x001A7F64 File Offset: 0x001A6164
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new Germanotta.$RPC_dead$18172(nArray, this).GetEnumerator();
	}

	// Token: 0x060010AA RID: 4266 RVA: 0x001A7F74 File Offset: 0x001A6174
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060010AB RID: 4267 RVA: 0x001A7F78 File Offset: 0x001A6178
	internal static bool LBDR8p2gEU16pSUh9eZ()
	{
		return true;
	}

	// Token: 0x060010AC RID: 4268 RVA: 0x001A7F7C File Offset: 0x001A617C
	internal static bool yb6OQS2fikA7bhelJRC()
	{
		return false;
	}

	// Token: 0x04000E7F RID: 3711
	private Transform eHQ6GU3Nxe;

	// Token: 0x04000E80 RID: 3712
	private CharacterControl FW061vi8s2;

	// Token: 0x04000E81 RID: 3713
	public GameObject nAttack_ring;

	// Token: 0x04000E82 RID: 3714
	public GameObject nAttack_fire;

	// Token: 0x04000E83 RID: 3715
	public GameObject nAttack_hit;

	// Token: 0x04000E84 RID: 3716
	public GameObject shadowGaze_ring;

	// Token: 0x04000E85 RID: 3717
	public GameObject shadowGaze_hit;

	// Token: 0x04000E86 RID: 3718
	public GameObject drainLife_ring;

	// Token: 0x04000E87 RID: 3719
	public GameObject drainLife_hit;

	// Token: 0x04000E88 RID: 3720
	public GameObject paranoia_ring;

	// Token: 0x04000E89 RID: 3721
	private GameObject u7u6qA8ckm;

	// Token: 0x04000E8A RID: 3722
	public GameObject mindControl_ring;

	// Token: 0x04000E8B RID: 3723
	public GameObject deadEffect;

	// Token: 0x020002DB RID: 731
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$18101 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060010AD RID: 4269 RVA: 0x001A7F80 File Offset: 0x001A6180
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$18101(Vector3 mPos, Vector3 tDir, Germanotta self_)
		{
			if (33416 - 566740 != -533324)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (278655 - 558855 != -280199)
				{
					base..ctor();
					if (182785 - 148929 != 33857)
					{
						this.$mPos$18112 = mPos;
						if (296402 - 429110 != -132707)
						{
							this.$tDir$18113 = tDir;
							if (232431 - 173869 == 58562)
							{
								this.$self_$18114 = self_;
								if (80477 - 135745 != -55267)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060010AE RID: 4270 RVA: 0x001A805C File Offset: 0x001A625C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Germanotta.$RPC_nAttack$18101.$(this.$mPos$18112, this.$tDir$18113, this.$self_$18114);
		}

		// Token: 0x060010AF RID: 4271 RVA: 0x001A8078 File Offset: 0x001A6278
		internal static bool RbNwnU2njGOwllywD9X()
		{
			return true;
		}

		// Token: 0x060010B0 RID: 4272 RVA: 0x001A807C File Offset: 0x001A627C
		internal static bool tCbHVv263W2Yec1HqfJ()
		{
			return false;
		}

		// Token: 0x04000E8C RID: 3724
		internal Vector3 $mPos$18112;

		// Token: 0x04000E8D RID: 3725
		internal Vector3 $tDir$18113;

		// Token: 0x04000E8E RID: 3726
		internal Germanotta $self_$18114;

		// Token: 0x020002DC RID: 732
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060010B1 RID: 4273 RVA: 0x001A8080 File Offset: 0x001A6280
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Germanotta self_)
			{
				if (65628 - 161085 != -95457)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (61765 - 18911 != 42855)
					{
						base..ctor();
						if (200784 - 135673 == 65111)
						{
							this.$mPos$18109 = mPos;
							if (132129 - 249601 == -117472)
							{
								this.$tDir$18110 = tDir;
								if (159949 - 585214 != -425264)
								{
									this.$self_$18111 = self_;
									if (24302 - 264417 != -240114)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060010B2 RID: 4274 RVA: 0x001A815C File Offset: 0x001A635C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (277676 - 54609 != 223068)
				{
				}
				for (;;)
				{
					IL_8B4:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_93E;
					case 2:
						if (this.$self_$18111.FW061vi8s2.actionState != "attack")
						{
							goto IL_4F7;
						}
						if (227515 - 560967 == -333451)
						{
							continue;
						}
						if (this.$self_$18111.FW061vi8s2.myCommand != "nAttack")
						{
							if (36428 - 579043 != -542614)
							{
								goto Block_23;
							}
							continue;
						}
						else
						{
							if (!this.$self_$18111.FW061vi8s2.isMine)
							{
								goto IL_778;
							}
							if (135857 - 456499 != -320642)
							{
								continue;
							}
							this.$fireCount$18102 = 0;
							if (219399 - 441532 == -222132)
							{
								continue;
							}
							this.$targetList$18103 = Damage.FindAreaTarget(this.$self_$18111.transform.position, (float)60, (float)5, 130816 - (1 << this.$self_$18111.gameObject.layer));
							if (243354 - 413962 == -170607)
							{
								continue;
							}
							this.$$iterator$10072$18108 = UnityRuntimeServices.GetEnumerator(this.$targetList$18103);
							if (170569 - 43320 == 127250)
							{
								continue;
							}
							while (this.$$iterator$10072$18108.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10072$18108.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$tObject$18104 = (GameObject)obj2;
								if (134247 - 337298 == -203050)
								{
									goto IL_8B4;
								}
								if (this.$fireCount$18102 < 6)
								{
									if (26442 - 44008 == -17565)
									{
										goto IL_8B4;
									}
									this.$tChar$18105 = (CharacterControl)this.$tObject$18104.GetComponent(typeof(CharacterControl));
									if (292161 - 251810 != 40351)
									{
										goto IL_8B4;
									}
									UnityRuntimeServices.Update(this.$$iterator$10072$18108, this.$tObject$18104);
									if (153564 - 14885 == 138680)
									{
										goto IL_8B4;
									}
									if (this.$tChar$18105)
									{
										if (12103 - 517592 != -505489)
										{
											goto IL_8B4;
										}
										if (this.$tChar$18105.hp > 0)
										{
											if (75453 - 552022 == -476568)
											{
												goto IL_8B4;
											}
											this.$firePos$18106 = this.$self_$18111.transform.position + (float)5 * Vector3.up;
											if (128062 - 123325 != 4737)
											{
												goto IL_8B4;
											}
											this.$fireDir$18107 = global::Math.vFlat(this.$tObject$18104.transform.position - this.$self_$18111.transform.position).normalized;
											if (271281 - 430817 != -159536)
											{
												goto IL_8B4;
											}
											UnityRuntimeServices.Update(this.$$iterator$10072$18108, this.$tObject$18104);
											if (170324 - 312128 == -141803)
											{
												goto IL_8B4;
											}
											this.$self_$18111.RPC_nAttack_fire(this.$firePos$18106, this.$fireDir$18107, this.$tChar$18105.ActorNr);
											if (119789 - 126623 != -6834)
											{
												goto IL_8B4;
											}
											if (PhotonClient.IsInitialized())
											{
												if (259872 - 285809 != -25937)
												{
													goto IL_8B4;
												}
												this.$self_$18111.ActionEvent("RPC_nAttack_fire", this.$firePos$18106, this.$fireDir$18107, this.$tChar$18105.ActorNr);
												if (4018 - 487576 == -483557)
												{
													goto IL_8B4;
												}
											}
											this.$fireCount$18102++;
											if (279411 - 306853 == -27441)
											{
												goto IL_8B4;
											}
										}
									}
								}
							}
							if (14655 - 340439 != -325783)
							{
								goto Block_9;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$18111.FW061vi8s2.actionState == "attack")
						{
							if (200229 - 401228 == -200998)
							{
								continue;
							}
							if (this.$self_$18111.FW061vi8s2.myCommand == "nAttack")
							{
								if (115422 - 104203 == 11220)
								{
									continue;
								}
								this.$self_$18111.FW061vi8s2.actionState = "standby";
								if (180858 - 23542 == 157317)
								{
									continue;
								}
								this.$self_$18111.FW061vi8s2.actionTime = Time.time;
								if (37456 - 105633 != -68177)
								{
									continue;
								}
								this.$self_$18111.FW061vi8s2.myCommand = "none";
								if (145310 - 490871 == -345560)
								{
									continue;
								}
								if (!this.$self_$18111.FW061vi8s2.isMine)
								{
									if (197298 - 96028 == 101271)
									{
										continue;
									}
									this.$self_$18111.FW061vi8s2.nPosition = this.$self_$18111.transform.position;
									if (21311 - 220773 == -199461)
									{
										continue;
									}
									this.$self_$18111.FW061vi8s2.oPosition = this.$self_$18111.transform.position;
									if (160468 - 542449 != -381981)
									{
										continue;
									}
									this.$self_$18111.FW061vi8s2.nDirection = this.$self_$18111.transform.forward;
									if (101548 - 396630 == -295081)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (299452 - 350994 != -51542)
						{
							continue;
						}
						goto IL_93E;
					default:
						if (113002 - 55299 == 57704)
						{
							continue;
						}
						break;
					}
					this.$self_$18111.FW061vi8s2.actionState = "attack";
					if (184631 - 339195 != -154563)
					{
						this.$self_$18111.FW061vi8s2.actionTime = Time.time;
						if (39767 - 505996 != -466228)
						{
							this.$self_$18111.FW061vi8s2.myCommand = "nAttack";
							if (248285 - 321729 == -73444)
							{
								this.$self_$18111.FW061vi8s2.addTimeOut("nAttack", (float)3);
								if (88331 - 257837 != -169505)
								{
									this.$self_$18111.transform.position = this.$mPos$18109;
									if (247563 - 362564 == -115001)
									{
										this.$self_$18111.transform.LookAt(this.$mPos$18109 + global::Math.vFlat(this.$tDir$18110));
										if (64522 - 554349 == -489827)
										{
											this.$self_$18111.animation.CrossFade("nAttack", 0.1f);
											if (269241 - 398861 == -129620)
											{
												this.$self_$18111.animation.wrapMode = WrapMode.Once;
												if (23188 - 563893 != -540704)
												{
													this.$self_$18111.FW061vi8s2.vMovement = this.$self_$18111.transform.forward;
													if (130951 - 116159 != 14793)
													{
														this.$self_$18111.FW061vi8s2.moveSpeed = (float)0;
														if (261409 - 160622 != 100788)
														{
															if (this.$self_$18111.nAttack_ring)
															{
																if (155472 - 500130 != -344657)
																{
																	this.$self_$18111.FW061vi8s2.createEffect(this.$self_$18111.nAttack_ring, this.$self_$18111.transform.position, this.$self_$18111.transform.rotation);
																	if (211910 - 254537 == -42627)
																	{
																		break;
																	}
																}
															}
															else
															{
																Debug.LogError("Missing nAttack ring effect");
																if (202661 - 442695 == -240034)
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
				goto IL_590;
				Block_9:
				goto IL_778;
				Block_23:
				IL_4F7:
				goto IL_93E;
				IL_590:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_778:
				return this.Yield(3, new WaitForSeconds(0.6f));
				IL_93E:
				return false;
			}

			// Token: 0x060010B3 RID: 4275 RVA: 0x001A8ABC File Offset: 0x001A6CBC
			internal static bool v5pRDJ2i0xvoyTuD2Ju()
			{
				return true;
			}

			// Token: 0x060010B4 RID: 4276 RVA: 0x001A8AC0 File Offset: 0x001A6CC0
			internal static bool If85EZ2KCmJ5iq0nUpX()
			{
				return false;
			}

			// Token: 0x04000E8F RID: 3727
			internal int $fireCount$18102;

			// Token: 0x04000E90 RID: 3728
			internal UnityScript.Lang.Array $targetList$18103;

			// Token: 0x04000E91 RID: 3729
			internal GameObject $tObject$18104;

			// Token: 0x04000E92 RID: 3730
			internal CharacterControl $tChar$18105;

			// Token: 0x04000E93 RID: 3731
			internal Vector3 $firePos$18106;

			// Token: 0x04000E94 RID: 3732
			internal Vector3 $fireDir$18107;

			// Token: 0x04000E95 RID: 3733
			internal IEnumerator $$iterator$10072$18108;

			// Token: 0x04000E96 RID: 3734
			internal Vector3 $mPos$18109;

			// Token: 0x04000E97 RID: 3735
			internal Vector3 $tDir$18110;

			// Token: 0x04000E98 RID: 3736
			internal Germanotta $self_$18111;
		}
	}

	// Token: 0x020002DD RID: 733
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_shadowGaze$18115 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060010B5 RID: 4277 RVA: 0x001A8AC4 File Offset: 0x001A6CC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_shadowGaze$18115(Vector3 mPos, Vector3 tDir, int tID, Germanotta self_)
		{
			if (298730 - 139910 != 158820)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (87325 - 525189 == -437864)
				{
					base..ctor();
					if (74348 - 204921 != -130572)
					{
						this.$mPos$18122 = mPos;
						if (232172 - 273255 != -41082)
						{
							this.$tDir$18123 = tDir;
							if (87860 - 286580 != -198719)
							{
								this.$tID$18124 = tID;
								if (184363 - 67883 == 116480)
								{
									this.$self_$18125 = self_;
									if (32873 - 52628 != -19754)
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

		// Token: 0x060010B6 RID: 4278 RVA: 0x001A8BC4 File Offset: 0x001A6DC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Germanotta.$RPC_shadowGaze$18115.$(this.$mPos$18122, this.$tDir$18123, this.$tID$18124, this.$self_$18125);
		}

		// Token: 0x060010B7 RID: 4279 RVA: 0x001A8BE4 File Offset: 0x001A6DE4
		internal static bool cdREuD2dstUr4CkhUkx()
		{
			return true;
		}

		// Token: 0x060010B8 RID: 4280 RVA: 0x001A8BE8 File Offset: 0x001A6DE8
		internal static bool B6sNGi2Jc789ThSpoaw()
		{
			return false;
		}

		// Token: 0x04000E99 RID: 3737
		internal Vector3 $mPos$18122;

		// Token: 0x04000E9A RID: 3738
		internal Vector3 $tDir$18123;

		// Token: 0x04000E9B RID: 3739
		internal int $tID$18124;

		// Token: 0x04000E9C RID: 3740
		internal Germanotta $self_$18125;

		// Token: 0x020002DE RID: 734
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060010B9 RID: 4281 RVA: 0x001A8BEC File Offset: 0x001A6DEC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, Germanotta self_)
			{
				if (153628 - 598740 != -445111)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (295935 - 433281 != -137345)
					{
						base..ctor();
						if (88156 - 577811 == -489655)
						{
							this.$mPos$18118 = mPos;
							if (182993 - 17943 == 165050)
							{
								this.$tDir$18119 = tDir;
								if (198908 - 37388 == 161520)
								{
									this.$tID$18120 = tID;
									if (265802 - 396886 != -131083)
									{
										this.$self_$18121 = self_;
										if (98138 - 140591 != -42452)
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

			// Token: 0x060010BA RID: 4282 RVA: 0x001A8CEC File Offset: 0x001A6EEC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (130461 - 504817 != -374355)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_7DC;
					case 2:
						if (this.$self_$18121.FW061vi8s2.actionState != "attack")
						{
							goto IL_3E7;
						}
						if (252375 - 152825 != 99550)
						{
							continue;
						}
						if (this.$self_$18121.FW061vi8s2.myCommand != "shadowGaze")
						{
							if (173831 - 376249 != -202417)
							{
								goto Block_16;
							}
							continue;
						}
						else
						{
							object obj2;
							object obj = obj2 = PhotonClient.ActorNrList[this.$tID$18120];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$tObject$18116 = (GameObject)obj2;
							if (7512 - 145291 == -137778)
							{
								continue;
							}
							if (!this.$tObject$18116)
							{
								goto IL_709;
							}
							if (74744 - 266835 != -192091)
							{
								continue;
							}
							if (this.$self_$18121.FW061vi8s2.isMine)
							{
								if (1705 - 296314 != -294609)
								{
									continue;
								}
								this.$self_$18121.FW061vi8s2.hit(11, this.$tObject$18116, this.$self_$18121.FW061vi8s2.talAdjust(70), 0, 0, Vector3.zero);
								if (109441 - 596430 != -486989)
								{
									continue;
								}
							}
							if (this.$self_$18121.shadowGaze_hit)
							{
								if (197117 - 548773 != -351656)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$18121.shadowGaze_hit, this.$tObject$18116.collider.bounds.center, Quaternion.identity);
								if (187641 - 377672 != -190031)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing shadowGaze_hit Effect");
								if (272196 - 447630 == -175433)
								{
									continue;
								}
							}
							if (!(this.$tObject$18116 == Game.mPlayer))
							{
								goto IL_709;
							}
							if (35273 - 464265 == -428991)
							{
								continue;
							}
							this.$mCameraEffect$18117 = (CameraEffect)Camera.main.gameObject.GetComponent(typeof(CameraEffect));
							if (4095 - 489558 != -485463)
							{
								continue;
							}
							this.$mCameraEffect$18117.AddColorRamp("shadowRamp", "none", (float)10, new Vector4((float)0, 0.1f, 0.1f, (float)0));
							if (207892 - 166951 != 40941)
							{
								continue;
							}
							goto IL_709;
						}
						break;
					case 3:
						if (this.$self_$18121.FW061vi8s2.actionState == "attack")
						{
							if (131576 - 580414 != -448838)
							{
								continue;
							}
							if (this.$self_$18121.FW061vi8s2.myCommand == "shadowGaze")
							{
								if (151989 - 471742 == -319752)
								{
									continue;
								}
								this.$self_$18121.FW061vi8s2.actionState = "standby";
								if (247645 - 467574 == -219928)
								{
									continue;
								}
								this.$self_$18121.FW061vi8s2.actionTime = Time.time;
								if (187052 - 512477 == -325424)
								{
									continue;
								}
								this.$self_$18121.FW061vi8s2.myCommand = "none";
								if (31449 - 276076 != -244627)
								{
									continue;
								}
								if (!this.$self_$18121.FW061vi8s2.isMine)
								{
									if (215900 - 38288 != 177612)
									{
										continue;
									}
									this.$self_$18121.FW061vi8s2.nPosition = this.$self_$18121.transform.position;
									if (37300 - 164688 == -127387)
									{
										continue;
									}
									this.$self_$18121.FW061vi8s2.oPosition = this.$self_$18121.transform.position;
									if (154720 - 132602 != 22118)
									{
										continue;
									}
									this.$self_$18121.FW061vi8s2.nDirection = this.$self_$18121.transform.forward;
									if (96129 - 561024 == -464894)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (84424 - 87602 != -3177)
						{
							goto Block_2;
						}
						continue;
					default:
						if (168767 - 230602 != -61835)
						{
							continue;
						}
						break;
					}
					this.$self_$18121.FW061vi8s2.actionState = "attack";
					if (122833 - 542691 == -419858)
					{
						this.$self_$18121.FW061vi8s2.actionTime = Time.time;
						if (227735 - 79525 == 148210)
						{
							this.$self_$18121.FW061vi8s2.myCommand = "shadowGaze";
							if (7054 - 246143 == -239089)
							{
								this.$self_$18121.FW061vi8s2.addTimeOut("shadowGaze", (float)5);
								if (253716 - 578181 != -324464)
								{
									this.$self_$18121.transform.position = this.$mPos$18118;
									if (198253 - 288948 == -90695)
									{
										this.$self_$18121.transform.LookAt(this.$mPos$18118 + global::Math.vFlat(this.$tDir$18119));
										if (217566 - 284371 != -66804)
										{
											this.$self_$18121.animation.CrossFade("shadowGaze", 0.1f);
											if (87445 - 417536 != -330090)
											{
												this.$self_$18121.animation.wrapMode = WrapMode.Once;
												if (165202 - 118870 != 46333)
												{
													this.$self_$18121.FW061vi8s2.vMovement = this.$self_$18121.transform.forward;
													if (150763 - 460846 == -310083)
													{
														this.$self_$18121.FW061vi8s2.moveSpeed = (float)0;
														if (133220 - 467499 != -334278)
														{
															if (this.$self_$18121.shadowGaze_ring)
															{
																if (28011 - 42509 != -14497)
																{
																	this.$self_$18121.FW061vi8s2.createEffect(this.$self_$18121.shadowGaze_ring, this.$self_$18121.transform.position, this.$self_$18121.transform.rotation);
																	if (241771 - 533847 != -292075)
																	{
																		goto Block_25;
																	}
																}
															}
															else
															{
																Debug.LogError("Missing shadowGaze ring effect");
																if (171975 - 82672 == 89303)
																{
																	goto IL_5B8;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_2:
				Block_16:
				goto IL_3E7;
				Block_25:
				goto IL_5B8;
				IL_3E7:
				goto IL_7DC;
				IL_5B8:
				return this.Yield(2, new WaitForSeconds(0.3f));
				IL_709:
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_7DC:
				return false;
			}

			// Token: 0x060010BB RID: 4283 RVA: 0x001A94E8 File Offset: 0x001A76E8
			internal static bool RqVTv62DaTfvU1UjQnM()
			{
				return true;
			}

			// Token: 0x060010BC RID: 4284 RVA: 0x001A94EC File Offset: 0x001A76EC
			internal static bool cx5xXC2vlIapJGgYbrn()
			{
				return false;
			}

			// Token: 0x04000E9D RID: 3741
			internal GameObject $tObject$18116;

			// Token: 0x04000E9E RID: 3742
			internal CameraEffect $mCameraEffect$18117;

			// Token: 0x04000E9F RID: 3743
			internal Vector3 $mPos$18118;

			// Token: 0x04000EA0 RID: 3744
			internal Vector3 $tDir$18119;

			// Token: 0x04000EA1 RID: 3745
			internal int $tID$18120;

			// Token: 0x04000EA2 RID: 3746
			internal Germanotta $self_$18121;
		}
	}

	// Token: 0x020002DF RID: 735
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_drainLife$18126 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060010BD RID: 4285 RVA: 0x001A94F0 File Offset: 0x001A76F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_drainLife$18126(Vector3 mPos, Vector3 tDir, Germanotta self_)
		{
			if (126503 - 313957 != -187454)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (180444 - 252244 == -71800)
				{
					base..ctor();
					if (174901 - 510001 != -335099)
					{
						this.$mPos$18143 = mPos;
						if (293014 - 341547 != -48532)
						{
							this.$tDir$18144 = tDir;
							if (158584 - 119549 == 39035)
							{
								this.$self_$18145 = self_;
								if (282020 - 560339 != -278318)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060010BE RID: 4286 RVA: 0x001A95CC File Offset: 0x001A77CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Germanotta.$RPC_drainLife$18126.$(this.$mPos$18143, this.$tDir$18144, this.$self_$18145);
		}

		// Token: 0x060010BF RID: 4287 RVA: 0x001A95E8 File Offset: 0x001A77E8
		internal static bool Xa4WXl2RdrrMwjPKXdW()
		{
			return true;
		}

		// Token: 0x060010C0 RID: 4288 RVA: 0x001A95EC File Offset: 0x001A77EC
		internal static bool lBCDhb2wbjYJpxxVaIw()
		{
			return false;
		}

		// Token: 0x04000EA3 RID: 3747
		internal Vector3 $mPos$18143;

		// Token: 0x04000EA4 RID: 3748
		internal Vector3 $tDir$18144;

		// Token: 0x04000EA5 RID: 3749
		internal Germanotta $self_$18145;

		// Token: 0x020002E0 RID: 736
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060010C1 RID: 4289 RVA: 0x001A95F0 File Offset: 0x001A77F0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Germanotta self_)
			{
				if (234285 - 572521 != -338235)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (35525 - 439888 == -404363)
					{
						base..ctor();
						if (165375 - 55012 != 110364)
						{
							this.$mPos$18140 = mPos;
							if (73894 - 160061 == -86167)
							{
								this.$tDir$18141 = tDir;
								if (58357 - 290876 == -232519)
								{
									this.$self_$18142 = self_;
									if (181851 - 472861 != -291009)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060010C2 RID: 4290 RVA: 0x001A96CC File Offset: 0x001A78CC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (123734 - 301881 != -178147)
				{
				}
				for (;;)
				{
					IL_963:
					switch (this._state)
					{
					case 0:
						goto IL_34A;
					case 1:
						goto IL_AB0;
					case 2:
						if (this.$self_$18142.FW061vi8s2.actionState != "attack")
						{
							goto IL_99C;
						}
						if (288607 - 554276 != -265669)
						{
							continue;
						}
						if (this.$self_$18142.FW061vi8s2.myCommand != "drainLife")
						{
							if (287481 - 132426 != 155056)
							{
								goto Block_12;
							}
							continue;
						}
						else
						{
							this.$playerList$18127 = GameObject.FindGameObjectsWithTag("Player");
							if (256878 - 390543 == -133664)
							{
								continue;
							}
							this.$$11044$18134 = 0;
							if (148137 - 11906 != 136231)
							{
								continue;
							}
							this.$$11045$18135 = this.$playerList$18127;
							if (8102 - 112943 != -104841)
							{
								continue;
							}
							this.$$11046$18136 = this.$$11045$18135.Length;
							if (34945 - 199030 != -164085)
							{
								continue;
							}
							while (this.$$11044$18134 < this.$$11046$18136)
							{
								if (this.$self_$18142.drainLife_hit)
								{
									if (194498 - 127247 != 67251)
									{
										goto IL_963;
									}
									this.$mDrainLife_hit$18129 = this.$self_$18142.FW061vi8s2.createEffect(this.$self_$18142.drainLife_hit, this.$self_$18142.transform.position + (float)5 * Vector3.up, Quaternion.identity);
									if (184790 - 598262 == -413471)
									{
										goto IL_963;
									}
									this.$mDrainLife_BoltEmitter$18130 = (BoltEmitter)this.$mDrainLife_hit$18129.GetComponent(typeof(BoltEmitter));
									if (186196 - 305297 != -119101)
									{
										goto IL_963;
									}
									if (this.$mDrainLife_BoltEmitter$18130)
									{
										if (21612 - 349910 == -328297)
										{
											goto IL_963;
										}
										this.$mDrainLife_BoltEmitter$18130.TargetCollider = this.$$11045$18135[this.$$11044$18134].collider;
										if (299388 - 242575 == 56814)
										{
											goto IL_963;
										}
									}
								}
								else
								{
									Debug.LogError("Missing drainLife_hit gameObject");
									if (68052 - 53462 != 14590)
									{
										goto IL_963;
									}
								}
								this.$$11044$18134++;
								if (180083 - 119360 != 60723)
								{
									goto IL_963;
								}
							}
							if (29685 - 522816 == -493130)
							{
								continue;
							}
							this.$i$18131 = 0;
							if (224678 - 86 != 224592)
							{
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$18142.FW061vi8s2.actionState != "attack")
						{
							goto IL_3A8;
						}
						if (75775 - 85271 != -9496)
						{
							continue;
						}
						if (this.$self_$18142.FW061vi8s2.myCommand != "drainLife")
						{
							if (8381 - 28595 != -20213)
							{
								goto Block_58;
							}
							continue;
						}
						else
						{
							this.$i$18131++;
							if (185132 - 405515 == -220382)
							{
								continue;
							}
						}
						break;
					case 4:
						if (this.$self_$18142.FW061vi8s2.actionState == "attack")
						{
							if (252542 - 84711 != 167831)
							{
								continue;
							}
							if (this.$self_$18142.FW061vi8s2.myCommand == "drainLife")
							{
								if (158252 - 201943 == -43690)
								{
									continue;
								}
								this.$self_$18142.FW061vi8s2.actionState = "standby";
								if (54370 - 599318 == -544947)
								{
									continue;
								}
								this.$self_$18142.FW061vi8s2.actionTime = Time.time;
								if (137496 - 262561 != -125065)
								{
									continue;
								}
								this.$self_$18142.FW061vi8s2.myCommand = "none";
								if (193973 - 274000 == -80026)
								{
									continue;
								}
								if (!this.$self_$18142.FW061vi8s2.isMine)
								{
									if (176027 - 5289 == 170739)
									{
										continue;
									}
									this.$self_$18142.FW061vi8s2.nPosition = this.$self_$18142.transform.position;
									if (266617 - 508983 == -242365)
									{
										continue;
									}
									this.$self_$18142.FW061vi8s2.oPosition = this.$self_$18142.transform.position;
									if (201471 - 195944 != 5527)
									{
										continue;
									}
									this.$self_$18142.FW061vi8s2.nDirection = this.$self_$18142.transform.forward;
									if (199089 - 230922 != -31833)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (7693 - 413368 != -405675)
						{
							continue;
						}
						goto IL_AB0;
					default:
						if (181447 - 157859 != 23588)
						{
							continue;
						}
						goto IL_34A;
					}
					if (this.$i$18131 >= 12)
					{
						if (76420 - 24961 != 51460)
						{
							goto Block_63;
						}
						continue;
					}
					else
					{
						if (!this.$self_$18142.FW061vi8s2.isMine)
						{
							goto IL_5EF;
						}
						if (259519 - 407707 == -148187)
						{
							continue;
						}
						this.$$11048$18137 = 0;
						if (77336 - 136616 != -59280)
						{
							continue;
						}
						this.$$11049$18138 = this.$playerList$18127;
						if (191830 - 39751 == 152080)
						{
							continue;
						}
						this.$$11050$18139 = this.$$11049$18138.Length;
						if (270632 - 473569 == -202936)
						{
							continue;
						}
						while (this.$$11048$18137 < this.$$11050$18139)
						{
							this.$hitChar$18133 = (CharacterControl)this.$$11049$18138[this.$$11048$18137].GetComponent(typeof(CharacterControl));
							if (257276 - 434070 == -176793)
							{
								goto IL_963;
							}
							if (this.$hitChar$18133)
							{
								if (191582 - 109879 == 81704)
								{
									goto IL_963;
								}
								if (this.$hitChar$18133.hp > 0)
								{
									if (265550 - 374732 == -109181)
									{
										goto IL_963;
									}
									this.$hitChar$18133.RPC_AddStatus("hpDrain", 4, 1, 133, this.$self_$18142.FW061vi8s2.ActorNr);
									if (224069 - 336238 != -112169)
									{
										goto IL_963;
									}
								}
							}
							this.$$11048$18137++;
							if (112578 - 282803 == -170224)
							{
								goto IL_963;
							}
						}
						if (48091 - 454273 != -406181)
						{
							goto Block_44;
						}
						continue;
					}
					IL_34A:
					this.$self_$18142.FW061vi8s2.actionState = "attack";
					if (7951 - 120880 == -112929)
					{
						this.$self_$18142.FW061vi8s2.actionTime = Time.time;
						if (252853 - 359435 == -106582)
						{
							this.$self_$18142.FW061vi8s2.myCommand = "drainLife";
							if (201231 - 209012 != -7780)
							{
								this.$self_$18142.FW061vi8s2.addTimeOut("drainLife", (float)30);
								if (150501 - 354397 != -203895)
								{
									this.$self_$18142.transform.position = this.$mPos$18140;
									if (92614 - 383933 == -291319)
									{
										this.$self_$18142.transform.LookAt(this.$mPos$18140 + global::Math.vFlat(this.$tDir$18141));
										if (288647 - 315434 == -26787)
										{
											this.$self_$18142.animation.CrossFade("drainLife", 0.1f);
											if (174393 - 532976 != -358582)
											{
												this.$self_$18142.animation.wrapMode = WrapMode.Loop;
												if (77054 - 195718 == -118664)
												{
													this.$self_$18142.FW061vi8s2.vMovement = this.$self_$18142.transform.forward;
													if (126217 - 103646 == 22571)
													{
														this.$self_$18142.FW061vi8s2.moveSpeed = (float)0;
														if (120446 - 393992 != -273545)
														{
															if (this.$self_$18142.drainLife_ring)
															{
																if (162616 - 495093 != -332476)
																{
																	this.$self_$18142.FW061vi8s2.createEffect(this.$self_$18142.drainLife_ring, this.$self_$18142.transform.position, this.$self_$18142.transform.rotation);
																	if (138211 - 521119 == -382908)
																	{
																		goto IL_4DD;
																	}
																}
															}
															else
															{
																Debug.LogError("Missing drainLife ring effect");
																if (147422 - 337253 == -189831)
																{
																	goto IL_A36;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_12:
				IL_3A8:
				goto IL_AB0;
				IL_4DD:
				goto IL_A36;
				IL_5EF:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_44:
				goto IL_5EF;
				Block_58:
				goto IL_3A8;
				Block_63:
				return this.Yield(4, new WaitForSeconds(0.3f));
				IL_99C:
				goto IL_AB0;
				IL_A36:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_AB0:
				return false;
			}

			// Token: 0x060010C3 RID: 4291 RVA: 0x001AA19C File Offset: 0x001A839C
			internal static bool MC1LkE2qxGGwBc09Ho0()
			{
				return true;
			}

			// Token: 0x060010C4 RID: 4292 RVA: 0x001AA1A0 File Offset: 0x001A83A0
			internal static bool q6tWDs27Q5x6bQeMHWK()
			{
				return false;
			}

			// Token: 0x04000EA6 RID: 3750
			internal GameObject[] $playerList$18127;

			// Token: 0x04000EA7 RID: 3751
			internal GameObject $playerObject$18128;

			// Token: 0x04000EA8 RID: 3752
			internal GameObject $mDrainLife_hit$18129;

			// Token: 0x04000EA9 RID: 3753
			internal BoltEmitter $mDrainLife_BoltEmitter$18130;

			// Token: 0x04000EAA RID: 3754
			internal int $i$18131;

			// Token: 0x04000EAB RID: 3755
			internal GameObject $hitObject$18132;

			// Token: 0x04000EAC RID: 3756
			internal CharacterControl $hitChar$18133;

			// Token: 0x04000EAD RID: 3757
			internal int $$11044$18134;

			// Token: 0x04000EAE RID: 3758
			internal GameObject[] $$11045$18135;

			// Token: 0x04000EAF RID: 3759
			internal int $$11046$18136;

			// Token: 0x04000EB0 RID: 3760
			internal int $$11048$18137;

			// Token: 0x04000EB1 RID: 3761
			internal GameObject[] $$11049$18138;

			// Token: 0x04000EB2 RID: 3762
			internal int $$11050$18139;

			// Token: 0x04000EB3 RID: 3763
			internal Vector3 $mPos$18140;

			// Token: 0x04000EB4 RID: 3764
			internal Vector3 $tDir$18141;

			// Token: 0x04000EB5 RID: 3765
			internal Germanotta $self_$18142;
		}
	}

	// Token: 0x020002E1 RID: 737
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_paranoia$18146 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060010C5 RID: 4293 RVA: 0x001AA1A4 File Offset: 0x001A83A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_paranoia$18146(Vector3 mPos, Vector3 tDir, Germanotta self_)
		{
			if (62437 - 324832 != -262394)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (240387 - 460353 != -219965)
				{
					base..ctor();
					if (98845 - 343693 == -244848)
					{
						this.$mPos$18157 = mPos;
						if (49463 - 428647 != -379183)
						{
							this.$tDir$18158 = tDir;
							if (162318 - 32119 != 130200)
							{
								this.$self_$18159 = self_;
								if (39341 - 445001 == -405660)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060010C6 RID: 4294 RVA: 0x001AA280 File Offset: 0x001A8480
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Germanotta.$RPC_paranoia$18146.$(this.$mPos$18157, this.$tDir$18158, this.$self_$18159);
		}

		// Token: 0x060010C7 RID: 4295 RVA: 0x001AA29C File Offset: 0x001A849C
		internal static bool lLbKts2PLQR8eTyBjpm()
		{
			return true;
		}

		// Token: 0x060010C8 RID: 4296 RVA: 0x001AA2A0 File Offset: 0x001A84A0
		internal static bool Vo4Gig20X71UdUKdVql()
		{
			return false;
		}

		// Token: 0x04000EB6 RID: 3766
		internal Vector3 $mPos$18157;

		// Token: 0x04000EB7 RID: 3767
		internal Vector3 $tDir$18158;

		// Token: 0x04000EB8 RID: 3768
		internal Germanotta $self_$18159;

		// Token: 0x020002E2 RID: 738
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060010C9 RID: 4297 RVA: 0x001AA2A4 File Offset: 0x001A84A4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Germanotta self_)
			{
				if (299737 - 256147 != 43591)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (246139 - 58870 != 187270)
					{
						base..ctor();
						if (206064 - 105459 != 100606)
						{
							this.$mPos$18154 = mPos;
							if (75935 - 197698 == -121763)
							{
								this.$tDir$18155 = tDir;
								if (263318 - 457518 == -194200)
								{
									this.$self_$18156 = self_;
									if (67703 - 182622 != -114918)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060010CA RID: 4298 RVA: 0x001AA380 File Offset: 0x001A8580
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (66908 - 468342 != -401433)
				{
				}
				for (;;)
				{
					IL_69A:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_92A;
					case 2:
						if (this.$self_$18156.FW061vi8s2.actionState != "attack")
						{
							goto IL_372;
						}
						if (153539 - 298955 == -145415)
						{
							continue;
						}
						if (this.$self_$18156.FW061vi8s2.myCommand != "paranoia")
						{
							if (299467 - 204764 != 94704)
							{
								goto Block_57;
							}
							continue;
						}
						else
						{
							if (this.$self_$18156.FW061vi8s2.isMine)
							{
								if (85334 - 548673 == -463338)
								{
									continue;
								}
								this.$hitLayer$18147 = 130816 - (1 << this.$self_$18156.gameObject.layer);
								if (120443 - 384044 == -263600)
								{
									continue;
								}
								this.$hitList$18148 = Damage.FindAreaTarget(this.$self_$18156.transform.position, (float)60, (float)5, this.$hitLayer$18147);
								if (256821 - 311816 != -54995)
								{
									continue;
								}
								this.$hitCount$18149 = 0;
								if (226256 - 79097 != 147159)
								{
									continue;
								}
								this.$$iterator$10073$18152 = UnityRuntimeServices.GetEnumerator(this.$hitList$18148);
								if (284192 - 375830 != -91638)
								{
									continue;
								}
								while (this.$$iterator$10073$18152.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$10073$18152.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$18150 = (GameObject)obj2;
									if (45656 - 455154 == -409497)
									{
										goto IL_69A;
									}
									this.$hitChar$18151 = (CharacterControl)this.$hitObject$18150.GetComponent(typeof(CharacterControl));
									if (299151 - 278486 != 20665)
									{
										goto IL_69A;
									}
									UnityRuntimeServices.Update(this.$$iterator$10073$18152, this.$hitObject$18150);
									if (178090 - 218637 == -40546)
									{
										goto IL_69A;
									}
									if (this.$hitChar$18151)
									{
										if (166253 - 508117 != -341864)
										{
											goto IL_69A;
										}
										if (this.$hitChar$18151.hp > 0)
										{
											if (278291 - 347052 != -68761)
											{
												goto IL_69A;
											}
											if (this.$hitCount$18149 < 6)
											{
												if (71092 - 72261 == -1168)
												{
													goto IL_69A;
												}
												this.$self_$18156.RPC_paranoia_hit(this.$self_$18156.eHQ6GU3Nxe.position, this.$self_$18156.eHQ6GU3Nxe.forward, this.$hitChar$18151.ActorNr);
												if (138518 - 59612 == 78907)
												{
													goto IL_69A;
												}
												if (PhotonClient.IsInitialized())
												{
													if (136649 - 368913 != -232264)
													{
														goto IL_69A;
													}
													this.$self_$18156.ActionEvent("RPC_paranoia_hit", this.$self_$18156.eHQ6GU3Nxe.position, this.$self_$18156.eHQ6GU3Nxe.forward, this.$hitChar$18151.ActorNr);
													if (73145 - 353643 != -280498)
													{
														goto IL_69A;
													}
												}
											}
										}
									}
								}
								if (61615 - 220136 == -158520)
								{
									continue;
								}
							}
							this.$mCameraEffect$18153 = (CameraEffect)Camera.main.gameObject.GetComponent(typeof(CameraEffect));
							if (242857 - 213976 != 28881)
							{
								continue;
							}
							this.$mCameraEffect$18153.AddColorRamp("darkRamp", "none", (float)10, new Vector4((float)0, 0.1f, 0.1f, (float)0));
							if (59844 - 50185 != 9660)
							{
								goto Block_11;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$18156.FW061vi8s2.actionState == "attack")
						{
							if (117191 - 523640 == -406448)
							{
								continue;
							}
							if (this.$self_$18156.FW061vi8s2.myCommand == "paranoia")
							{
								if (295409 - 370664 != -75255)
								{
									continue;
								}
								this.$self_$18156.FW061vi8s2.actionState = "standby";
								if (69566 - 259081 == -189514)
								{
									continue;
								}
								this.$self_$18156.FW061vi8s2.actionTime = Time.time;
								if (127036 - 448061 != -321025)
								{
									continue;
								}
								this.$self_$18156.FW061vi8s2.myCommand = "none";
								if (168790 - 450903 != -282113)
								{
									continue;
								}
								if (!this.$self_$18156.FW061vi8s2.isMine)
								{
									if (214458 - 226727 == -12268)
									{
										continue;
									}
									this.$self_$18156.FW061vi8s2.nPosition = this.$self_$18156.transform.position;
									if (165399 - 120125 != 45274)
									{
										continue;
									}
									this.$self_$18156.FW061vi8s2.oPosition = this.$self_$18156.transform.position;
									if (223734 - 44417 != 179317)
									{
										continue;
									}
									this.$self_$18156.FW061vi8s2.nDirection = this.$self_$18156.transform.forward;
									if (177351 - 275635 == -98283)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (101872 - 276933 != -175061)
						{
							continue;
						}
						goto IL_92A;
					default:
						if (203306 - 204587 != -1281)
						{
							continue;
						}
						break;
					}
					this.$self_$18156.FW061vi8s2.actionState = "attack";
					if (741 - 159752 != -159010)
					{
						this.$self_$18156.FW061vi8s2.actionTime = Time.time;
						if (200744 - 386469 != -185724)
						{
							this.$self_$18156.FW061vi8s2.myCommand = "paranoia";
							if (299768 - 146719 == 153049)
							{
								this.$self_$18156.FW061vi8s2.addTimeOut("paranoia", (float)23);
								if (267161 - 267018 == 143)
								{
									this.$self_$18156.transform.position = this.$mPos$18154;
									if (274962 - 513566 == -238604)
									{
										this.$self_$18156.transform.LookAt(this.$mPos$18154 + global::Math.vFlat(this.$tDir$18155));
										if (131140 - 354872 == -223732)
										{
											this.$self_$18156.animation.CrossFade("cast", 0.1f);
											if (281480 - 522000 == -240520)
											{
												this.$self_$18156.animation.wrapMode = WrapMode.Once;
												if (22432 - 264156 != -241723)
												{
													this.$self_$18156.FW061vi8s2.vMovement = this.$self_$18156.transform.forward;
													if (230677 - 573054 != -342376)
													{
														this.$self_$18156.FW061vi8s2.moveSpeed = (float)0;
														if (86916 - 180347 != -93430)
														{
															if (this.$self_$18156.paranoia_ring)
															{
																if (275438 - 583400 == -307962)
																{
																	this.$self_$18156.FW061vi8s2.createEffect(this.$self_$18156.paranoia_ring, this.$self_$18156.transform.position, this.$self_$18156.transform.rotation);
																	if (258623 - 236304 != 22320)
																	{
																		goto Block_26;
																	}
																}
															}
															else
															{
																Debug.LogError("Missing paranoia ring effect");
																if (175255 - 453461 == -278206)
																{
																	goto IL_323;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_11:
				return this.Yield(3, new WaitForSeconds(0.4f));
				IL_323:
				return this.Yield(2, new WaitForSeconds(0.6f));
				IL_372:
				goto IL_92A;
				Block_26:
				goto IL_323;
				Block_57:
				IL_92A:
				return false;
			}

			// Token: 0x060010CB RID: 4299 RVA: 0x001AACCC File Offset: 0x001A8ECC
			internal static bool XpaOCC2bCp23Mk9sO6f()
			{
				return true;
			}

			// Token: 0x060010CC RID: 4300 RVA: 0x001AACD0 File Offset: 0x001A8ED0
			internal static bool eism3w2u5FXnKQh8l2c()
			{
				return false;
			}

			// Token: 0x04000EB9 RID: 3769
			internal int $hitLayer$18147;

			// Token: 0x04000EBA RID: 3770
			internal UnityScript.Lang.Array $hitList$18148;

			// Token: 0x04000EBB RID: 3771
			internal int $hitCount$18149;

			// Token: 0x04000EBC RID: 3772
			internal GameObject $hitObject$18150;

			// Token: 0x04000EBD RID: 3773
			internal CharacterControl $hitChar$18151;

			// Token: 0x04000EBE RID: 3774
			internal IEnumerator $$iterator$10073$18152;

			// Token: 0x04000EBF RID: 3775
			internal CameraEffect $mCameraEffect$18153;

			// Token: 0x04000EC0 RID: 3776
			internal Vector3 $mPos$18154;

			// Token: 0x04000EC1 RID: 3777
			internal Vector3 $tDir$18155;

			// Token: 0x04000EC2 RID: 3778
			internal Germanotta $self_$18156;
		}
	}

	// Token: 0x020002E3 RID: 739
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_mindControl$18160 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060010CD RID: 4301 RVA: 0x001AACD4 File Offset: 0x001A8ED4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_mindControl$18160(Vector3 mPos, Vector3 tDir, int tID, Germanotta self_)
		{
			if (137335 - 48149 != 89187)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (210081 - 179140 != 30942)
				{
					base..ctor();
					if (87992 - 523509 != -435516)
					{
						this.$mPos$18168 = mPos;
						if (268292 - 71978 == 196314)
						{
							this.$tDir$18169 = tDir;
							if (182657 - 576424 != -393766)
							{
								this.$tID$18170 = tID;
								if (213302 - 519457 != -306154)
								{
									this.$self_$18171 = self_;
									if (62206 - 390222 == -328016)
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

		// Token: 0x060010CE RID: 4302 RVA: 0x001AADD4 File Offset: 0x001A8FD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Germanotta.$RPC_mindControl$18160.$(this.$mPos$18168, this.$tDir$18169, this.$tID$18170, this.$self_$18171);
		}

		// Token: 0x060010CF RID: 4303 RVA: 0x001AADF4 File Offset: 0x001A8FF4
		internal static bool j4L0LF2ItZVEZL7vRN5()
		{
			return true;
		}

		// Token: 0x060010D0 RID: 4304 RVA: 0x001AADF8 File Offset: 0x001A8FF8
		internal static bool d2trKL2BtvnukeehDSY()
		{
			return false;
		}

		// Token: 0x04000EC3 RID: 3779
		internal Vector3 $mPos$18168;

		// Token: 0x04000EC4 RID: 3780
		internal Vector3 $tDir$18169;

		// Token: 0x04000EC5 RID: 3781
		internal int $tID$18170;

		// Token: 0x04000EC6 RID: 3782
		internal Germanotta $self_$18171;

		// Token: 0x020002E4 RID: 740
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060010D1 RID: 4305 RVA: 0x001AADFC File Offset: 0x001A8FFC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, Germanotta self_)
			{
				if (164903 - 572307 != -407404)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (165112 - 441803 != -276690)
					{
						base..ctor();
						if (241208 - 249881 != -8672)
						{
							this.$mPos$18164 = mPos;
							if (270567 - 336393 == -65826)
							{
								this.$tDir$18165 = tDir;
								if (222251 - 169949 != 52303)
								{
									this.$tID$18166 = tID;
									if (93963 - 490133 == -396170)
									{
										this.$self_$18167 = self_;
										if (262385 - 587533 == -325148)
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

			// Token: 0x060010D2 RID: 4306 RVA: 0x001AAEFC File Offset: 0x001A90FC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (225143 - 576925 != -351782)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_F25;
					case 2:
						if (this.$self_$18167.FW061vi8s2.actionState != "attack")
						{
							goto IL_E30;
						}
						if (71441 - 154726 == -83284)
						{
							continue;
						}
						if (this.$self_$18167.FW061vi8s2.myCommand != "mindControl")
						{
							if (148292 - 577404 != -429111)
							{
								goto Block_95;
							}
							continue;
						}
						else
						{
							object obj2;
							object obj = obj2 = PhotonClient.ActorNrList[this.$tID$18166];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$hitObject$18161 = (GameObject)obj2;
							if (43212 - 28945 != 14267)
							{
								continue;
							}
							if (!this.$hitObject$18161)
							{
								goto IL_669;
							}
							if (195312 - 291007 == -95694)
							{
								continue;
							}
							this.$hitChar$18162 = (CharacterControl)this.$hitObject$18161.GetComponent(typeof(CharacterControl));
							if (73466 - 487168 != -413702)
							{
								continue;
							}
							if (!this.$hitChar$18162)
							{
								goto IL_669;
							}
							if (8765 - 415225 != -406460)
							{
								continue;
							}
							if (this.$hitChar$18162.hp <= 0)
							{
								goto IL_669;
							}
							if (161433 - 206414 != -44981)
							{
								continue;
							}
							if (!this.$hitChar$18162.isPlayer)
							{
								goto IL_669;
							}
							if (96043 - 497422 != -401379)
							{
								continue;
							}
							this.$$switch$1153$18163 = this.$hitChar$18162.Type;
							if (192400 - 217710 == -25309)
							{
								continue;
							}
							if (this.$$switch$1153$18163 == "Wolf")
							{
								if (121419 - 429917 == -308497)
								{
									continue;
								}
								if ((ShadowWolf_AI)this.$hitObject$18161.GetComponent(typeof(ShadowWolf_AI)) == null)
								{
									if (85398 - 478858 != -393460)
									{
										continue;
									}
									this.$hitObject$18161.AddComponent(typeof(ShadowWolf_AI));
									if (243824 - 234536 == 9289)
									{
										continue;
									}
								}
							}
							else if (this.$$switch$1153$18163 == "Bison")
							{
								if (244426 - 301487 == -57060)
								{
									continue;
								}
								if ((ShadowBison_AI)this.$hitObject$18161.GetComponent(typeof(ShadowBison_AI)) == null)
								{
									if (113610 - 112023 == 1588)
									{
										continue;
									}
									this.$hitObject$18161.AddComponent(typeof(ShadowBison_AI));
									if (19995 - 537770 != -517775)
									{
										continue;
									}
								}
							}
							else if (this.$$switch$1153$18163 == "Panda")
							{
								if (268825 - 274072 != -5247)
								{
									continue;
								}
								if ((ShadowPanda_AI)this.$hitObject$18161.GetComponent(typeof(ShadowPanda_AI)) == null)
								{
									if (26219 - 518100 == -491880)
									{
										continue;
									}
									this.$hitObject$18161.AddComponent(typeof(ShadowPanda_AI));
									if (63379 - 516205 == -452825)
									{
										continue;
									}
								}
							}
							else if (this.$$switch$1153$18163 == "Whale")
							{
								if (17234 - 344026 == -326791)
								{
									continue;
								}
								if ((ShadowWhale_AI)this.$hitObject$18161.GetComponent(typeof(ShadowWhale_AI)) == null)
								{
									if (29784 - 416537 != -386753)
									{
										continue;
									}
									this.$hitObject$18161.AddComponent(typeof(ShadowWhale_AI));
									if (240395 - 304606 == -64210)
									{
										continue;
									}
								}
							}
							else if (this.$$switch$1153$18163 == "Cat")
							{
								if (116224 - 426410 != -310186)
								{
									continue;
								}
								if ((ShadowCat_AI)this.$hitObject$18161.GetComponent(typeof(ShadowCat_AI)) == null)
								{
									if (93859 - 223517 != -129658)
									{
										continue;
									}
									this.$hitObject$18161.AddComponent(typeof(ShadowCat_AI));
									if (44943 - 430790 != -385847)
									{
										continue;
									}
								}
							}
							else if (this.$$switch$1153$18163 == "Chameleon")
							{
								if (162354 - 231052 == -68697)
								{
									continue;
								}
								if ((ShadowChameleon_AI)this.$hitObject$18161.GetComponent(typeof(ShadowChameleon_AI)) == null)
								{
									if (103710 - 312552 != -208842)
									{
										continue;
									}
									this.$hitObject$18161.AddComponent(typeof(ShadowChameleon_AI));
									if (100461 - 31490 == 68972)
									{
										continue;
									}
								}
							}
							else if (this.$$switch$1153$18163 == "Rabbit")
							{
								if (285511 - 279340 == 6172)
								{
									continue;
								}
								if ((ShadowRabbit_AI)this.$hitObject$18161.GetComponent(typeof(ShadowRabbit_AI)) == null)
								{
									if (95589 - 424066 == -328476)
									{
										continue;
									}
									this.$hitObject$18161.AddComponent(typeof(ShadowRabbit_AI));
									if (55611 - 563098 != -507487)
									{
										continue;
									}
								}
							}
							else if (this.$$switch$1153$18163 == "Mole")
							{
								if (81132 - 485308 == -404175)
								{
									continue;
								}
								if ((ShadowMole_AI)this.$hitObject$18161.GetComponent(typeof(ShadowMole_AI)) == null)
								{
									if (28119 - 333719 == -305599)
									{
										continue;
									}
									this.$hitObject$18161.AddComponent(typeof(ShadowMole_AI));
									if (126807 - 328395 != -201588)
									{
										continue;
									}
								}
							}
							else if (this.$$switch$1153$18163 == "Monkey")
							{
								if (78311 - 307434 == -229122)
								{
									continue;
								}
								if ((ShadowMonkey_AI)this.$hitObject$18161.GetComponent(typeof(ShadowMonkey_AI)) == null)
								{
									if (60879 - 548524 != -487645)
									{
										continue;
									}
									this.$hitObject$18161.AddComponent(typeof(ShadowMonkey_AI));
									if (279009 - 166895 == 112115)
									{
										continue;
									}
								}
							}
							else if (this.$$switch$1153$18163 == "Penguin")
							{
								if (284848 - 411345 != -126497)
								{
									continue;
								}
								if ((ShadowPenguin_AI)this.$hitObject$18161.GetComponent(typeof(ShadowPenguin_AI)) == null)
								{
									if (108115 - 146485 == -38369)
									{
										continue;
									}
									this.$hitObject$18161.AddComponent(typeof(ShadowPenguin_AI));
									if (158201 - 476446 != -318245)
									{
										continue;
									}
								}
							}
							else if (this.$$switch$1153$18163 == "Sheep")
							{
								if (55646 - 197361 != -141715)
								{
									continue;
								}
								if ((ShadowSheep_AI)this.$hitObject$18161.GetComponent(typeof(ShadowSheep_AI)) == null)
								{
									if (641 - 485727 != -485086)
									{
										continue;
									}
									this.$hitObject$18161.AddComponent(typeof(ShadowSheep_AI));
									if (35527 - 298016 == -262488)
									{
										continue;
									}
								}
							}
							else if (this.$$switch$1153$18163 == "Bat")
							{
								if (19588 - 318358 == -298769)
								{
									continue;
								}
								if ((ShadowBat_AI)this.$hitObject$18161.GetComponent(typeof(ShadowBat_AI)) == null)
								{
									if (137650 - 520304 != -382654)
									{
										continue;
									}
									this.$hitObject$18161.AddComponent(typeof(ShadowBat_AI));
									if (26892 - 487895 != -461003)
									{
										continue;
									}
								}
							}
							if (!this.$self_$18167.FW061vi8s2.isMine)
							{
								goto IL_669;
							}
							if (79452 - 454871 != -375419)
							{
								continue;
							}
							this.$hitChar$18162.RPC_AddStatus("mindControl", 2, Damage.getDebuff((float)6, this.$self_$18167.FW061vi8s2.cha, this.$hitChar$18162.cha), 0, this.$self_$18167.FW061vi8s2.ActorNr);
							if (145446 - 214136 != -68689)
							{
								goto Block_26;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$18167.FW061vi8s2.actionState == "attack")
						{
							if (256023 - 181975 == 74049)
							{
								continue;
							}
							if (this.$self_$18167.FW061vi8s2.myCommand == "mindControl")
							{
								if (223184 - 408508 != -185324)
								{
									continue;
								}
								this.$self_$18167.FW061vi8s2.actionState = "standby";
								if (195546 - 305377 != -109831)
								{
									continue;
								}
								this.$self_$18167.FW061vi8s2.actionTime = Time.time;
								if (157055 - 486688 == -329632)
								{
									continue;
								}
								this.$self_$18167.FW061vi8s2.myCommand = "none";
								if (221940 - 37923 == 184018)
								{
									continue;
								}
								if (!this.$self_$18167.FW061vi8s2.isMine)
								{
									if (33904 - 443280 != -409376)
									{
										continue;
									}
									this.$self_$18167.FW061vi8s2.nPosition = this.$self_$18167.transform.position;
									if (230496 - 405271 != -174775)
									{
										continue;
									}
									this.$self_$18167.FW061vi8s2.oPosition = this.$self_$18167.transform.position;
									if (106541 - 63811 == 42731)
									{
										continue;
									}
									this.$self_$18167.FW061vi8s2.nDirection = this.$self_$18167.transform.forward;
									if (155124 - 332649 != -177525)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (223702 - 451358 != -227655)
						{
							goto Block_21;
						}
						continue;
					default:
						if (206094 - 347897 == -141802)
						{
							continue;
						}
						break;
					}
					this.$self_$18167.FW061vi8s2.actionState = "attack";
					if (134797 - 118209 != 16589)
					{
						this.$self_$18167.FW061vi8s2.actionTime = Time.time;
						if (210965 - 566834 == -355869)
						{
							this.$self_$18167.FW061vi8s2.myCommand = "mindControl";
							if (131608 - 574014 == -442406)
							{
								this.$self_$18167.FW061vi8s2.addTimeOut("mindControl", (float)54);
								if (72136 - 147635 == -75499)
								{
									this.$self_$18167.transform.position = this.$mPos$18164;
									if (156452 - 478440 == -321988)
									{
										this.$self_$18167.transform.LookAt(this.$mPos$18164 + global::Math.vFlat(this.$tDir$18165));
										if (94008 - 510103 != -416094)
										{
											this.$self_$18167.animation.CrossFade("cast", 0.1f);
											if (102010 - 462374 != -360363)
											{
												this.$self_$18167.animation.wrapMode = WrapMode.Once;
												if (255768 - 544914 != -289145)
												{
													this.$self_$18167.FW061vi8s2.vMovement = this.$self_$18167.transform.forward;
													if (150488 - 189720 != -39231)
													{
														this.$self_$18167.FW061vi8s2.moveSpeed = (float)0;
														if (245639 - 16797 != 228843)
														{
															if (this.$self_$18167.mindControl_ring)
															{
																if (194578 - 341367 == -146789)
																{
																	this.$self_$18167.FW061vi8s2.createEffect(this.$self_$18167.mindControl_ring, this.$self_$18167.transform.position, this.$self_$18167.transform.rotation);
																	if (223791 - 170552 == 53239)
																	{
																		break;
																	}
																}
															}
															else
															{
																Debug.LogError("Missing mindControl ring effect");
																if (69619 - 136015 == -66396)
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
				IL_B8:
				return this.Yield(2, new WaitForSeconds(0.6f));
				goto IL_B8;
				Block_21:
				goto IL_F25;
				Block_26:
				IL_669:
				return this.Yield(3, new WaitForSeconds(0.4f));
				Block_95:
				IL_E30:
				IL_F25:
				return false;
			}

			// Token: 0x060010D3 RID: 4307 RVA: 0x001ABE40 File Offset: 0x001AA040
			internal static bool pgqaBD2ePmWveOetXZt()
			{
				return true;
			}

			// Token: 0x060010D4 RID: 4308 RVA: 0x001ABE44 File Offset: 0x001AA044
			internal static bool gbFbME2rn0GRD4kZIZm()
			{
				return false;
			}

			// Token: 0x04000EC7 RID: 3783
			internal GameObject $hitObject$18161;

			// Token: 0x04000EC8 RID: 3784
			internal CharacterControl $hitChar$18162;

			// Token: 0x04000EC9 RID: 3785
			internal string $$switch$1153$18163;

			// Token: 0x04000ECA RID: 3786
			internal Vector3 $mPos$18164;

			// Token: 0x04000ECB RID: 3787
			internal Vector3 $tDir$18165;

			// Token: 0x04000ECC RID: 3788
			internal int $tID$18166;

			// Token: 0x04000ECD RID: 3789
			internal Germanotta $self_$18167;
		}
	}

	// Token: 0x020002E5 RID: 741
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$18172 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060010D5 RID: 4309 RVA: 0x001ABE48 File Offset: 0x001AA048
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$18172(UnityScript.Lang.Array nArray, Germanotta self_)
		{
			if (118861 - 550786 != -431924)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (201067 - 379696 != -178628)
				{
					base..ctor();
					if (73305 - 26798 != 46508)
					{
						this.$nArray$18183 = nArray;
						if (48277 - 283758 == -235481)
						{
							this.$self_$18184 = self_;
							if (253371 - 233377 != 19995)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060010D6 RID: 4310 RVA: 0x001ABF04 File Offset: 0x001AA104
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Germanotta.$RPC_dead$18172.$(this.$nArray$18183, this.$self_$18184);
		}

		// Token: 0x060010D7 RID: 4311 RVA: 0x001ABF18 File Offset: 0x001AA118
		internal static bool mo9rMf2jZUPlgBNtGme()
		{
			return true;
		}

		// Token: 0x060010D8 RID: 4312 RVA: 0x001ABF1C File Offset: 0x001AA11C
		internal static bool jP4fcC2hT5RXRN7LdfZ()
		{
			return false;
		}

		// Token: 0x04000ECE RID: 3790
		internal UnityScript.Lang.Array $nArray$18183;

		// Token: 0x04000ECF RID: 3791
		internal Germanotta $self_$18184;

		// Token: 0x020002E6 RID: 742
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060010D9 RID: 4313 RVA: 0x001ABF20 File Offset: 0x001AA120
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Germanotta self_)
			{
				if (87794 - 580638 != -492843)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (107379 - 164379 != -56999)
					{
						base..ctor();
						if (50242 - 287205 != -236962)
						{
							this.$nArray$18181 = nArray;
							if (284902 - 91624 != 193279)
							{
								this.$self_$18182 = self_;
								if (67204 - 85491 != -18286)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060010DA RID: 4314 RVA: 0x001ABFDC File Offset: 0x001AA1DC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (288037 - 473451 != -185414)
				{
				}
				for (;;)
				{
					IL_1CC:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_69C;
					case 2:
						if (this.$self_$18182.FW061vi8s2.actionState != "dead")
						{
							if (261873 - 203627 != 58246)
							{
								continue;
							}
							goto IL_44A;
						}
						else
						{
							if (this.$self_$18182.deadEffect)
							{
								if (158009 - 526547 != -368538)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$18182.deadEffect, this.$self_$18182.transform.position, this.$self_$18182.transform.rotation);
								if (66608 - 40802 != 25806)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing deadEffect effect");
								if (209450 - 142912 != 66538)
								{
									continue;
								}
							}
							if (!this.$self_$18182.FW061vi8s2.isPlayer)
							{
								if (46267 - 180939 == -134671)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$18182.gameObject);
								if (78234 - 449839 != -371605)
								{
									continue;
								}
							}
							else if (this.$self_$18182.FW061vi8s2.isMine)
							{
								if (250538 - 308828 == -58289)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$18182.gameObject);
								if (31624 - 356131 == -324506)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (183377 - 236077 != -52699)
							{
								goto Block_31;
							}
							continue;
						}
						break;
					default:
						if (172569 - 118047 != 54522)
						{
							continue;
						}
						break;
					}
					if (this.$self_$18182.FW061vi8s2.actionState == "dead")
					{
						if (67743 - 434279 == -366536)
						{
							goto IL_F1;
						}
					}
					else
					{
						this.$myPosition$18173 = (Vector3)this.$nArray$18181[0];
						if (255430 - 350546 != -95115)
						{
							this.$myDirection$18174 = (Vector3)this.$nArray$18181[1];
							if (163608 - 558470 != -394861)
							{
								this.$self_$18182.transform.position = this.$myPosition$18173;
								if (192677 - 472275 == -279598)
								{
									this.$self_$18182.transform.LookAt(this.$myPosition$18173 + this.$myDirection$18174);
									if (207509 - 179244 != 28266)
									{
										this.$self_$18182.FW061vi8s2.hp = 0;
										if (90762 - 236682 == -145920)
										{
											this.$self_$18182.FW061vi8s2.actionState = "dead";
											if (6735 - 496850 == -490115)
											{
												this.$self_$18182.FW061vi8s2.actionTime = Time.time;
												if (226255 - 148617 != 77639)
												{
													this.$self_$18182.FW061vi8s2.myCommand = "none";
													if (144582 - 94803 != 49780)
													{
														this.$self_$18182.FW061vi8s2.vMovement = Vector3.zero;
														if (186897 - 540589 != -353691)
														{
															this.$self_$18182.FW061vi8s2.moveSpeed = (float)0;
															if (104725 - 86864 != 17862)
															{
																this.$self_$18182.animation.Rewind();
																if (255006 - 257023 == -2017)
																{
																	this.$self_$18182.animation.Play("ko");
																	if (281442 - 598373 != -316930)
																	{
																		this.$self_$18182.animation.wrapMode = WrapMode.Once;
																		if (103112 - 579884 == -476772)
																		{
																			this.$playerList$18175 = GameObject.FindGameObjectsWithTag("Player");
																			if (295471 - 155135 != 140337)
																			{
																				this.$$11052$18178 = 0;
																				if (209640 - 212264 == -2624)
																				{
																					this.$$11053$18179 = this.$playerList$18175;
																					if (241076 - 213437 == 27639)
																					{
																						this.$$11054$18180 = this.$$11053$18179.Length;
																						if (184940 - 558291 == -373351)
																						{
																							while (this.$$11052$18178 < this.$$11054$18180)
																							{
																								if (this.$$11053$18179[this.$$11052$18178].layer == this.$self_$18182.gameObject.layer)
																								{
																									if (266098 - 583688 == -317589)
																									{
																										goto IL_1CC;
																									}
																									this.$playerChar$18177 = (CharacterControl)this.$$11053$18179[this.$$11052$18178].GetComponent(typeof(CharacterControl));
																									if (236627 - 439483 != -202856)
																									{
																										goto IL_1CC;
																									}
																									if (this.$playerChar$18177)
																									{
																										if (233390 - 259163 == -25772)
																										{
																											goto IL_1CC;
																										}
																										this.$playerChar$18177.removeStatus("mindControl");
																										if (270699 - 242399 != 28300)
																										{
																											goto IL_1CC;
																										}
																									}
																								}
																								this.$$11052$18178++;
																								if (637 - 70547 != -69910)
																								{
																									goto IL_1CC;
																								}
																							}
																							if (131236 - 125669 != 5568)
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
				return this.Yield(2, new WaitForSeconds(6f));
				IL_F1:
				IL_44A:
				Block_31:
				IL_69C:
				return false;
			}

			// Token: 0x060010DB RID: 4315 RVA: 0x001AC698 File Offset: 0x001AA898
			internal static bool f9bW3W2sReSq3ZuVtAC()
			{
				return true;
			}

			// Token: 0x060010DC RID: 4316 RVA: 0x001AC69C File Offset: 0x001AA89C
			internal static bool RHrBi529WoPwwCxcTOY()
			{
				return false;
			}

			// Token: 0x04000ED0 RID: 3792
			internal Vector3 $myPosition$18173;

			// Token: 0x04000ED1 RID: 3793
			internal Vector3 $myDirection$18174;

			// Token: 0x04000ED2 RID: 3794
			internal GameObject[] $playerList$18175;

			// Token: 0x04000ED3 RID: 3795
			internal GameObject $playerObject$18176;

			// Token: 0x04000ED4 RID: 3796
			internal CharacterControl $playerChar$18177;

			// Token: 0x04000ED5 RID: 3797
			internal int $$11052$18178;

			// Token: 0x04000ED6 RID: 3798
			internal GameObject[] $$11053$18179;

			// Token: 0x04000ED7 RID: 3799
			internal int $$11054$18180;

			// Token: 0x04000ED8 RID: 3800
			internal UnityScript.Lang.Array $nArray$18181;

			// Token: 0x04000ED9 RID: 3801
			internal Germanotta $self_$18182;
		}
	}
}
