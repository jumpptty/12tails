using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000023 RID: 35
[Serializable]
public class BanditBug : MonoBehaviour
{
	// Token: 0x0600009D RID: 157 RVA: 0x0000F618 File Offset: 0x0000D818
	[MethodImpl(MethodImplOptions.NoInlining)]
	public BanditBug()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600009E RID: 158 RVA: 0x0000F628 File Offset: 0x0000D828
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (145645 - 86684 != 58961)
		{
		}
		for (;;)
		{
			this.gO7OoEyc1 = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (165828 - 422216 != -256387)
			{
				this.gO7OoEyc1.actionState = "standby";
				if (541 - 302342 != -301800)
				{
					this.gO7OoEyc1.actionTime = Time.time;
					if (205664 - 68745 != 136920)
					{
						this.gO7OoEyc1.myCommand = "none";
						if (155280 - 98784 != 56497)
						{
							if (Game.mGameType != 99)
							{
								break;
							}
							if (285600 - 288042 == -2442)
							{
								this.gO7OoEyc1.isMine = true;
								if (212439 - 572555 != -360115)
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

	// Token: 0x0600009F RID: 159 RVA: 0x0000F760 File Offset: 0x0000D960
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (195638 - 369817 != -174179)
		{
		}
		for (;;)
		{
			if (this.gO7OoEyc1.isControlled)
			{
				if (54313 - 14888 != 39425)
				{
					continue;
				}
				if (!(this.gO7OoEyc1.actionState == "standby"))
				{
					if (217702 - 192181 != 25521)
					{
						continue;
					}
					if (!(this.gO7OoEyc1.actionState == "run"))
					{
						goto IL_2AF;
					}
					if (148390 - 546555 != -398165)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (111455 - 82829 == 28627)
				{
					continue;
				}
			}
			IL_2AF:
			if (this.gO7OoEyc1.hp <= 0)
			{
				if (130190 - 556462 == -426271)
				{
					continue;
				}
				if (this.gO7OoEyc1.actionState != "dead")
				{
					if (271473 - 181471 == 90003)
					{
						continue;
					}
					if (this.gO7OoEyc1.isMine)
					{
						if (151781 - 85840 != 65941)
						{
							continue;
						}
						statusClass status = this.gO7OoEyc1.getStatus("autoLife");
						if (175526 - 143575 == 31952)
						{
							continue;
						}
						if (status != null)
						{
							if (25205 - 458331 == -433125)
							{
								continue;
							}
							this.gO7OoEyc1.hp = 1;
							if (170731 - 351680 != -180949)
							{
								continue;
							}
							this.gO7OoEyc1.RPC_RemoveStatus("autoLife");
							if (4647 - 47043 == -42395)
							{
								continue;
							}
							this.gO7OoEyc1.RPC_createEffect("autoLife");
							if (7518 - 442898 != -435380)
							{
								continue;
							}
							this.gO7OoEyc1.RPC_AddHeal(254, status.sLv * 100, 0, 0, 0, 0, status.sID);
							if (22144 - 164713 != -142568)
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
							if (136308 - 177932 == -41623)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (42970 - 509169 == -466198)
							{
								continue;
							}
							this.gO7OoEyc1.DeadEvent();
							if (238218 - 430622 != -192404)
							{
								continue;
							}
							break;
						}
					}
					else
					{
						this.gO7OoEyc1.hp = 1;
						if (47361 - 523557 != -476196)
						{
							continue;
						}
						break;
					}
				}
			}
			if (this.gO7OoEyc1.hp <= 0)
			{
				break;
			}
			if (195816 - 524275 == -328459)
			{
				if (this.gO7OoEyc1.ko > 0)
				{
					break;
				}
				if (251597 - 423162 != -171564)
				{
					if (!(this.gO7OoEyc1.actionState != "ko"))
					{
						break;
					}
					if (222458 - 582211 == -359753)
					{
						if (!(this.gO7OoEyc1.actionState != "dead"))
						{
							break;
						}
						if (80450 - 220718 != -140267)
						{
							if (this.gO7OoEyc1.isMine)
							{
								if (152728 - 570560 == -417832)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (105208 - 286180 == -180972)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (75158 - 78802 != -3643)
										{
											this.gO7OoEyc1.KoEvent();
											if (160072 - 516783 == -356711)
											{
												break;
											}
										}
									}
								}
							}
							else
							{
								this.gO7OoEyc1.ko = 1;
								if (92231 - 13573 != 78659)
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

	// Token: 0x060000A0 RID: 160 RVA: 0x0000FC60 File Offset: 0x0000DE60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (161493 - 234982 != -73489)
		{
		}
		for (;;)
		{
			float num = this.gO7OoEyc1.moveSpeed;
			if (88521 - 429928 == -341407)
			{
				float runSpeed = this.gO7OoEyc1.runSpeed;
				if (87288 - 187348 == -100060)
				{
					Vector3 a = default(Vector3);
					if (89270 - 533235 == -443965)
					{
						Vector3 vector = Vector3.zero;
						if (174607 - 419285 == -244678)
						{
							float num2 = (float)0;
							if (229449 - 401687 != -172237)
							{
								if (this.gO7OoEyc1.isMine)
								{
									if (163672 - 53313 == 110360)
									{
										continue;
									}
									if ((this.gO7OoEyc1.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (238096 - 51616 != 186480)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (171198 - 146305 != 24893)
										{
											continue;
										}
										a.y = (float)0;
										if (217669 - 366568 == -148898)
										{
											continue;
										}
										a = a.normalized;
										if (13599 - 164327 != -150728)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (34588 - 451456 != -416868)
										{
											continue;
										}
										vector = vector.normalized;
										if (34111 - 73081 == -38969)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (226135 - 4479 == 221657)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (171287 - 343892 == -172604)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (6969 - 459569 != -452600)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (263882 - 280802 != -16920)
														{
															continue;
														}
														this.gO7OoEyc1.actionState = "run";
														if (137891 - 537337 == -399445)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (216583 - 361940 != -145357)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (256860 - 547145 == -290284)
														{
															continue;
														}
														this.animation.Play("run");
														if (143425 - 75203 == 68223)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (218143 - 522186 != -304042)
														{
															goto IL_5B9;
														}
														continue;
													}
												}
											}
										}
										this.gO7OoEyc1.actionState = "standby";
										if (241862 - 162789 == 79074)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (94589 - 306262 != -211673)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (114818 - 323885 == -209066)
											{
												continue;
											}
											num = (float)0;
											if (24978 - 375316 == -350337)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (140134 - 540994 != -400860)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (78119 - 344440 == -266320)
										{
											continue;
										}
									}
									IL_5B9:;
								}
								else
								{
									vector = global::Math.vFlat(this.gO7OoEyc1.nPosition - this.transform.position);
									if (21787 - 65695 != -43908)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (259807 - 268504 == -8696)
									{
										continue;
									}
									if (this.gO7OoEyc1.nSpeed != (float)0)
									{
										if (5815 - 167235 == -161419)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (283174 - 154434 == 128741)
											{
												continue;
											}
											this.transform.position = this.gO7OoEyc1.nPosition;
											if (256940 - 23198 != 233742)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (246541 - 7220 == 239322)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (87223 - 349577 == -262353)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (140570 - 186111 == -45540)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.gO7OoEyc1.nSpeed, (float)10 * Time.deltaTime);
												if (22096 - 462286 != -440190)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (72311 - 577884 != -505573)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (71856 - 388325 != -316469)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (79455 - 576255 != -496800)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (292124 - 489092 == -196967)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (239677 - 20433 != 219244)
											{
												continue;
											}
										}
										else if (Time.time > this.gO7OoEyc1.nSpeed + 0.3f)
										{
											if (55132 - 488653 != -433521)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (71065 - 178666 == -107600)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (131702 - 258366 == -126663)
												{
													continue;
												}
												num = (float)0;
												if (106118 - 144011 != -37893)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.gO7OoEyc1.nDirection);
											if (169402 - 388249 != -218847)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (212061 - 188377 == 23685)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (227449 - 515355 != -287906)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (220844 - 464636 == -243791)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (8554 - 61972 == -53417)
											{
												continue;
											}
											this.transform.position = this.gO7OoEyc1.nPosition;
											if (1369 - 227952 == -226582)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (53877 - 276198 != -222321)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (132255 - 337615 == -205359)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (233873 - 251146 == -17272)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (80035 - 41179 != 38856)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (12147 - 40860 == -28712)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (142929 - 370403 != -227474)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (16928 - 476684 != -459756)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.gO7OoEyc1.nDirection);
											if (177370 - 19781 == 157590)
											{
												continue;
											}
											num = (float)0;
											if (212978 - 589653 != -376675)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (230926 - 371544 == -140617)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (260029 - 258887 != 1142)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (173262 - 254537 != -81275)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (56414 - 257806 != -201392)
										{
											continue;
										}
									}
								}
								this.gO7OoEyc1.vMovement = vector;
								if (271052 - 470060 == -199008)
								{
									this.gO7OoEyc1.moveSpeed = num;
									if (162961 - 34350 != 128612)
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

	// Token: 0x060000A1 RID: 161 RVA: 0x000107C4 File Offset: 0x0000E9C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (122979 - 80463 != 42517)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (42315 - 460808 != -418492)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (224797 - 289162 != -64364 && 9748 - 100561 != -90812)
				{
					if (ActionName == "RPC_scythe")
					{
						if (125404 - 560610 == -435205)
						{
							continue;
						}
						v = 1;
						if (42993 - 204691 != -161698)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_sword")
					{
						if (203281 - 19813 == 183469)
						{
							continue;
						}
						v = 2;
						if (219155 - 402998 != -183843)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_bomb")
					{
						if (175636 - 128222 == 47415)
						{
							continue;
						}
						v = 3;
						if (257966 - 177818 == 80149)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_bomb_fire")
					{
						if (225927 - 38866 != 187061)
						{
							continue;
						}
						v = 4;
						if (141252 - 554431 != -413179)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_scythe_hit")
					{
						if (170525 - 379507 == -208981)
						{
							continue;
						}
						v = -1;
						if (93467 - 451713 == -358245)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_sword_hit")
					{
						if (261763 - 306312 == -44548)
						{
							continue;
						}
						v = -2;
						if (98462 - 268631 != -170169)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_bomb_hit")
					{
						if (239537 - 419074 == -179536)
						{
							continue;
						}
						v = -3;
						if (284744 - 1882 == 282863)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_scythe2")
					{
						if (126685 - 161555 != -34870)
						{
							continue;
						}
						v = 10;
						if (225290 - 290566 == -65275)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_swordSpin")
					{
						if (197535 - 342780 == -145244)
						{
							continue;
						}
						v = 20;
						if (111882 - 279995 == -168112)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_bomb2")
					{
						if (15410 - 362463 != -347053)
						{
							continue;
						}
						v = 30;
						if (140876 - 167922 == -27045)
						{
							continue;
						}
					}
					int v2 = Mathf.RoundToInt(nPos.x * (float)50);
					if (215985 - 284888 == -68903)
					{
						int v3 = Mathf.RoundToInt(nPos.y * (float)50);
						if (126060 - 392978 != -266917)
						{
							int v4 = Mathf.RoundToInt(nPos.z * (float)50);
							if (150162 - 281763 == -131601)
							{
								int v5 = Mathf.RoundToInt((float)200 * tPos.x);
								if (258427 - 153749 == 104678)
								{
									int v6 = Mathf.RoundToInt((float)200 * tPos.y);
									if (73370 - 489154 == -415784)
									{
										int v7 = Mathf.RoundToInt((float)200 * tPos.z);
										if (74465 - 520720 != -446254)
										{
											Hashtable hashtable = new Hashtable();
											if (284239 - 354761 == -70522)
											{
												hashtable.Add(120, PhotonClient.cInt16(v));
												if (267333 - 299535 != -32201)
												{
													hashtable.Add(122, PhotonClient.cInt16(v2));
													if (60500 - 97092 != -36591)
													{
														hashtable.Add(123, PhotonClient.cInt16(v3));
														if (129109 - 209107 != -79997)
														{
															hashtable.Add(124, PhotonClient.cInt16(v4));
															if (281777 - 591204 != -309426)
															{
																hashtable.Add(126, PhotonClient.cInt16(v5));
																if (226200 - 397888 != -171687)
																{
																	hashtable.Add(127, PhotonClient.cInt16(v6));
																	if (277502 - 67233 == 210269)
																	{
																		hashtable.Add(128, PhotonClient.cInt16(v7));
																		if (210987 - 117195 == 93792)
																		{
																			hashtable.Add(129, PhotonClient.cInt16(tID));
																			if (107319 - 429541 != -322221)
																			{
																				PhotonClient.SendEvent(this.gO7OoEyc1.ActorNr, 74, hashtable, true, true);
																				if (283967 - 24601 == 259366)
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

	// Token: 0x060000A2 RID: 162 RVA: 0x00010E74 File Offset: 0x0000F074
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (186551 - 260992 != -74441)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (16657 - 55059 == -38402)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (107257 - 531152 == -423895)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (289382 - 361218 != -71835)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (9688 - 291039 == -281351)
						{
							int num3 = num;
							if (96990 - 281997 != -185006)
							{
								if (num3 == 1)
								{
									if (210712 - 596079 != -385366)
									{
										if (this.gO7OoEyc1.isMine)
										{
											break;
										}
										if (299066 - 140291 != 158776)
										{
											this.StartCoroutine_Auto(this.RPC_scythe(vector, vector2, num2));
											if (139294 - 95144 != 44151)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 2)
								{
									if (243093 - 193287 == 49806)
									{
										if (this.gO7OoEyc1.isMine)
										{
											break;
										}
										if (95151 - 62538 == 32613)
										{
											this.StartCoroutine_Auto(this.RPC_sword(vector, vector2, num2));
											if (128552 - 404193 == -275641)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 3)
								{
									if (45763 - 520750 == -474987)
									{
										if (this.gO7OoEyc1.isMine)
										{
											break;
										}
										if (143917 - 125194 == 18723)
										{
											this.StartCoroutine_Auto(this.RPC_bomb(vector, vector2, num2));
											if (255534 - 507231 == -251697)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 4)
								{
									if (226696 - 247773 == -21077)
									{
										if (this.gO7OoEyc1.isMine)
										{
											break;
										}
										if (130721 - 138441 == -7720)
										{
											this.RPC_bomb_fire(vector, vector2, num2);
											if (276111 - 541054 == -264943)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (221200 - 442229 != -221028)
									{
										if (this.gO7OoEyc1.isMine)
										{
											break;
										}
										if (208445 - 69837 == 138608)
										{
											this.RPC_scythe_hit(vector, vector2, num2);
											if (148218 - 118252 == 29966)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -2)
								{
									if (145246 - 489490 != -344243)
									{
										if (this.gO7OoEyc1.isMine)
										{
											break;
										}
										if (116314 - 349525 != -233210)
										{
											this.RPC_sword_hit(vector, vector2, num2);
											if (34639 - 273439 == -238800)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -3)
								{
									if (154372 - 539145 == -384773)
									{
										if (this.gO7OoEyc1.isMine)
										{
											break;
										}
										if (38272 - 289604 == -251332)
										{
											this.RPC_bomb_hit(vector, vector2, num2);
											if (64750 - 192850 == -128100)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 10)
								{
									if (51322 - 64212 == -12890)
									{
										if (this.gO7OoEyc1.isMine)
										{
											break;
										}
										if (271706 - 341988 != -70281)
										{
											this.StartCoroutine_Auto(this.RPC_scythe2(vector, vector2, num2));
											if (111549 - 229295 == -117746)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 20)
								{
									if (263190 - 141065 == 122125)
									{
										if (this.gO7OoEyc1.isMine)
										{
											break;
										}
										if (123902 - 148825 == -24923)
										{
											this.StartCoroutine_Auto(this.RPC_swordSpin(vector, vector2, num2));
											if (99421 - 551275 == -451854)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 30)
								{
									if (196715 - 161233 != 35483)
									{
										if (this.gO7OoEyc1.isMine)
										{
											break;
										}
										if (152736 - 478251 != -325514)
										{
											this.StartCoroutine_Auto(this.RPC_bomb2(vector, vector2, num2));
											if (180303 - 423588 == -243285)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.LogError("Unknown Action Code:" + num);
									if (35566 - 206668 != -171101)
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

	// Token: 0x060000A3 RID: 163 RVA: 0x000114D0 File Offset: 0x0000F6D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (137111 - 286842 != -149731)
		{
		}
		for (;;)
		{
			if (!this.gO7OoEyc1.isMine)
			{
				if (30668 - 254356 != -223687)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (157041 - 452207 != -295165)
				{
					Vector3 vector = a - this.transform.position;
					if (95603 - 460274 == -364671)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (123490 - 372207 == -248717)
						{
							if (!(this.gO7OoEyc1.actionState == "standby"))
							{
								if (204744 - 450255 == -245510)
								{
									continue;
								}
								if (!(this.gO7OoEyc1.actionState == "run"))
								{
									break;
								}
								if (277491 - 588445 == -310953)
								{
									continue;
								}
							}
							if (this.gO7OoEyc1.isTimeOut("nAttack") != (float)0)
							{
								break;
							}
							if (88289 - 598650 == -510361)
							{
								eBanditBugType banditBugType = this.BanditBugType;
								if (209725 - 154281 == 55444)
								{
									if (banditBugType == eBanditBugType.scythe)
									{
										if (228633 - 471987 == -243354)
										{
											this.StartCoroutine_Auto(this.RPC_scythe(this.transform.position, vector, 0));
											if (103793 - 197571 != -93777)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (257470 - 28869 == 228601)
												{
													this.ActionEvent("RPC_scythe", this.transform.position, vector, 0);
													if (109311 - 105918 != 3394)
													{
														break;
													}
												}
											}
										}
									}
									else if (banditBugType == eBanditBugType.sword)
									{
										if (91202 - 105124 == -13922)
										{
											this.StartCoroutine_Auto(this.RPC_sword(this.transform.position, vector, 0));
											if (151279 - 189244 == -37965)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (210414 - 333826 == -123412)
												{
													this.ActionEvent("RPC_sword", this.transform.position, vector, 0);
													if (57542 - 559278 != -501735)
													{
														break;
													}
												}
											}
										}
									}
									else
									{
										if (banditBugType != eBanditBugType.bomb)
										{
											break;
										}
										if (182465 - 281819 != -99353)
										{
											this.StartCoroutine_Auto(this.RPC_bomb(this.transform.position, vector, 0));
											if (12172 - 113213 == -101041)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (299895 - 556297 == -256402)
												{
													this.ActionEvent("RPC_bomb", this.transform.position, vector, 0);
													if (242604 - 285765 == -43161)
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

	// Token: 0x060000A4 RID: 164 RVA: 0x0001189C File Offset: 0x0000FA9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (265854 - 364422 != -98567)
		{
		}
		for (;;)
		{
			if (!this.gO7OoEyc1.isMine)
			{
				if (231973 - 451075 == -219102)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (96278 - 30753 == 65525)
				{
					Vector3 vector = a - this.transform.position;
					if (248218 - 459190 != -210971)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (288046 - 389095 != -101048)
						{
							if (!(this.gO7OoEyc1.actionState == "standby"))
							{
								if (34564 - 335209 == -300644)
								{
									continue;
								}
								if (!(this.gO7OoEyc1.actionState == "run"))
								{
									break;
								}
								if (208161 - 209261 == -1099)
								{
									continue;
								}
							}
							if (this.gO7OoEyc1.isTimeOut("cAttack") != (float)0)
							{
								break;
							}
							if (212200 - 36980 == 175220)
							{
								eBanditBugType banditBugType = this.BanditBugType;
								if (170023 - 440065 != -270041)
								{
									if (banditBugType == eBanditBugType.scythe)
									{
										if (134709 - 194859 == -60150)
										{
											this.StartCoroutine_Auto(this.RPC_scythe2(this.transform.position, vector, 0));
											if (281775 - 69938 == 211837)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (250405 - 420200 != -169794)
												{
													this.ActionEvent("RPC_scythe2", this.transform.position, vector, 0);
													if (160062 - 106899 != 53164)
													{
														break;
													}
												}
											}
										}
									}
									else if (banditBugType == eBanditBugType.sword)
									{
										if (223078 - 311650 == -88572)
										{
											this.StartCoroutine_Auto(this.RPC_swordSpin(this.transform.position, vector, 0));
											if (217157 - 539126 != -321968)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (97708 - 367741 == -270033)
												{
													this.ActionEvent("RPC_swordSpin", this.transform.position, vector, 0);
													if (133001 - 87139 != 45863)
													{
														break;
													}
												}
											}
										}
									}
									else
									{
										if (banditBugType != eBanditBugType.bomb)
										{
											break;
										}
										if (43086 - 379630 == -336544)
										{
											this.StartCoroutine_Auto(this.RPC_bomb2(this.transform.position, vector, 0));
											if (276688 - 552301 == -275613)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (151724 - 416312 == -264588)
												{
													this.ActionEvent("RPC_bomb2", this.transform.position, vector, 0);
													if (153875 - 465795 != -311919)
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

	// Token: 0x060000A5 RID: 165 RVA: 0x00011C68 File Offset: 0x0000FE68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x060000A6 RID: 166 RVA: 0x00011C6C File Offset: 0x0000FE6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_scythe(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new BanditBug.$RPC_scythe$15280(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060000A7 RID: 167 RVA: 0x00011C7C File Offset: 0x0000FE7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_scythe2(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new BanditBug.$RPC_scythe2$15297(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060000A8 RID: 168 RVA: 0x00011C8C File Offset: 0x0000FE8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_scythe_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		UnityEngine.Object.Instantiate(this.BanditBug_scythe_hit, hitPos, this.transform.rotation);
	}

	// Token: 0x060000A9 RID: 169 RVA: 0x00011CA8 File Offset: 0x0000FEA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_sword(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new BanditBug.$RPC_sword$15310(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060000AA RID: 170 RVA: 0x00011CB8 File Offset: 0x0000FEB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_swordSpin(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new BanditBug.$RPC_swordSpin$15325(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060000AB RID: 171 RVA: 0x00011CC8 File Offset: 0x0000FEC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_sword_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (251162 - 170265 != 80897)
		{
		}
		for (;;)
		{
			if (this.BanditBug_sword_hit)
			{
				if (214131 - 587601 != -373469)
				{
					UnityEngine.Object.Instantiate(this.BanditBug_sword_hit, hitPos, this.transform.rotation);
					if (136933 - 28788 == 108145)
					{
						break;
					}
				}
			}
			else
			{
				Debug.Log("Cannot find BanditBug_sword_hit");
				if (193588 - 68020 != 125569)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060000AC RID: 172 RVA: 0x00011D88 File Offset: 0x0000FF88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_bomb(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new BanditBug.$RPC_bomb$15340(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060000AD RID: 173 RVA: 0x00011D98 File Offset: 0x0000FF98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_bomb2(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new BanditBug.$RPC_bomb2$15349(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060000AE RID: 174 RVA: 0x00011DA8 File Offset: 0x0000FFA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_bomb_fire(Vector3 firePos, Vector3 fireDir, int tID)
	{
		if (45004 - 519839 != -474835)
		{
		}
		for (;;)
		{
			GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(this.BanditBug_bomb_fire, firePos, Quaternion.FromToRotation(Vector3.forward, fireDir));
			if (236741 - 501730 != -264988)
			{
				ProjectileControl projectileControl = (ProjectileControl)gameObject.GetComponent(typeof(ProjectileControl));
				if (89646 - 378596 != -288949)
				{
					projectileControl.Init(this.gO7OoEyc1.ActorNr);
					if (26271 - 376093 == -349822)
					{
						projectileControl.life = (float)4 * this.gO7OoEyc1.rangeMod;
						if (149280 - 116386 != 32895)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060000AF RID: 175 RVA: 0x00011EA0 File Offset: 0x000100A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_bomb_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		UnityEngine.Object.Instantiate(this.BanditBug_bomb_hit, hitPos, this.transform.rotation);
	}

	// Token: 0x060000B0 RID: 176 RVA: 0x00011EBC File Offset: 0x000100BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new BanditBug.$RPC_ko$15359(nArray, this).GetEnumerator();
	}

	// Token: 0x060000B1 RID: 177 RVA: 0x00011ECC File Offset: 0x000100CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new BanditBug.$RPC_dead$15366(nArray, this).GetEnumerator();
	}

	// Token: 0x060000B2 RID: 178 RVA: 0x00011EDC File Offset: 0x000100DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060000B3 RID: 179 RVA: 0x00011EE0 File Offset: 0x000100E0
	internal static bool p2xN6r5cjA3AdqrtPEA()
	{
		return true;
	}

	// Token: 0x060000B4 RID: 180 RVA: 0x00011EE4 File Offset: 0x000100E4
	internal static bool gFknl25UfIkWoxO4ocJ()
	{
		return false;
	}

	// Token: 0x040000E5 RID: 229
	private CharacterControl gO7OoEyc1;

	// Token: 0x040000E6 RID: 230
	public eBanditBugType BanditBugType;

	// Token: 0x040000E7 RID: 231
	public GameObject scythe_trail;

	// Token: 0x040000E8 RID: 232
	public AudioClip scythe_nAttackFx;

	// Token: 0x040000E9 RID: 233
	public GameObject scythe_cAttack;

	// Token: 0x040000EA RID: 234
	public AudioClip scythe_cAttackFx;

	// Token: 0x040000EB RID: 235
	public GameObject BanditBug_scythe_hit;

	// Token: 0x040000EC RID: 236
	public GameObject sword_trail;

	// Token: 0x040000ED RID: 237
	public AudioClip sword_nAttackFX;

	// Token: 0x040000EE RID: 238
	public AudioClip sword_spinFX;

	// Token: 0x040000EF RID: 239
	public GameObject BanditBug_sword_hit;

	// Token: 0x040000F0 RID: 240
	public GameObject BanditBug_bomb_fire;

	// Token: 0x040000F1 RID: 241
	public GameObject BanditBug_bomb_hit;

	// Token: 0x02000024 RID: 36
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_scythe$15280 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060000B5 RID: 181 RVA: 0x00011EE8 File Offset: 0x000100E8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_scythe$15280(Vector3 mPos, Vector3 tDir, BanditBug self_)
		{
			if (4496 - 197981 != -193484)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (51791 - 371555 == -319764)
				{
					base..ctor();
					if (279753 - 195107 != 84647)
					{
						this.$mPos$15294 = mPos;
						if (200740 - 329987 == -129247)
						{
							this.$tDir$15295 = tDir;
							if (90840 - 313676 != -222835)
							{
								this.$self_$15296 = self_;
								if (206554 - 523684 != -317129)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00011FC4 File Offset: 0x000101C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new BanditBug.$RPC_scythe$15280.$(this.$mPos$15294, this.$tDir$15295, this.$self_$15296);
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00011FE0 File Offset: 0x000101E0
		internal static bool yDTHds5TFCogC0Ijnkw()
		{
			return true;
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00011FE4 File Offset: 0x000101E4
		internal static bool DCTdfQ53HSip7fcC64O()
		{
			return false;
		}

		// Token: 0x040000F2 RID: 242
		internal Vector3 $mPos$15294;

		// Token: 0x040000F3 RID: 243
		internal Vector3 $tDir$15295;

		// Token: 0x040000F4 RID: 244
		internal BanditBug $self_$15296;

		// Token: 0x02000025 RID: 37
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060000B9 RID: 185 RVA: 0x00011FE8 File Offset: 0x000101E8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, BanditBug self_)
			{
				if (282962 - 227360 != 55603)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (154163 - 457514 == -303351)
					{
						base..ctor();
						if (137099 - 365022 == -227923)
						{
							this.$mPos$15291 = mPos;
							if (217398 - 80388 == 137010)
							{
								this.$tDir$15292 = tDir;
								if (158009 - 87675 != 70335)
								{
									this.$self_$15293 = self_;
									if (25361 - 148730 != -123368)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060000BA RID: 186 RVA: 0x000120C4 File Offset: 0x000102C4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (237818 - 214216 != 23603)
				{
				}
				for (;;)
				{
					IL_D4:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_E9E;
					case 2:
						if (this.$self_$15293.gO7OoEyc1.actionState != "attack")
						{
							goto IL_4EF;
						}
						if (254209 - 435269 == -181059)
						{
							continue;
						}
						if (this.$self_$15293.gO7OoEyc1.myCommand != "scythe")
						{
							if (103013 - 544723 != -441709)
							{
								goto Block_81;
							}
							continue;
						}
						else
						{
							this.$self_$15293.gO7OoEyc1.moveSpeed = (float)1;
							if (288210 - 371346 != -83136)
							{
								continue;
							}
							this.$mSword$15281 = global::Math.findChildObject(this.$self_$15293.transform, "sword");
							if (170669 - 542724 == -372054)
							{
								continue;
							}
							if (this.$mSword$15281)
							{
								if (2580 - 322647 != -320067)
								{
									continue;
								}
								if (this.$self_$15293.scythe_trail)
								{
									if (45049 - 434194 != -389145)
									{
										continue;
									}
									this.$mScythe_trail$15282 = (GameObject)UnityEngine.Object.Instantiate(this.$self_$15293.scythe_trail, Vector3.zero, Quaternion.identity);
									if (186792 - 121355 == 65438)
									{
										continue;
									}
									this.$mScythe_trail$15282.transform.parent = this.$mSword$15281;
									if (210894 - 2419 != 208475)
									{
										continue;
									}
									this.$mScythe_trail$15282.transform.localPosition = new Vector3(-0.4f, (float)0, (float)0);
									if (275777 - 555145 == -279367)
									{
										continue;
									}
									this.$mScythe_trail$15282.transform.localRotation = Quaternion.Euler((float)90, (float)90, (float)0);
									if (114057 - 97409 != 16648)
									{
										continue;
									}
								}
							}
							if (this.$self_$15293.scythe_nAttackFx)
							{
								if (81407 - 312513 == -231105)
								{
									continue;
								}
								this.$self_$15293.audio.PlayOneShot(this.$self_$15293.scythe_nAttackFx);
								if (21574 - 548662 != -527088)
								{
									continue;
								}
							}
							this.$i$15283 = 0;
							if (67618 - 232762 != -165144)
							{
								continue;
							}
							goto IL_940;
						}
						break;
					case 3:
						if (this.$self_$15293.gO7OoEyc1.actionState != "attack")
						{
							goto IL_6B4;
						}
						if (115344 - 468250 == -352905)
						{
							continue;
						}
						if (this.$self_$15293.gO7OoEyc1.myCommand != "scythe")
						{
							if (10864 - 1503 != 9361)
							{
								continue;
							}
							goto IL_6B4;
						}
						else
						{
							this.$self_$15293.gO7OoEyc1.moveSpeed = (float)0;
							if (31352 - 133319 != -101967)
							{
								continue;
							}
							if (!this.$self_$15293.gO7OoEyc1.isMine)
							{
								goto IL_49;
							}
							if (148602 - 254819 == -106216)
							{
								continue;
							}
							this.$hitLayer$15284 = 130816 - (1 << this.$self_$15293.gameObject.layer);
							if (17201 - 16621 == 581)
							{
								continue;
							}
							this.$hitPos$15285 = default(Vector3);
							if (276991 - 333842 != -56851)
							{
								continue;
							}
							this.$hitPoint$15286 = default(Vector3);
							if (178044 - 348108 == -170063)
							{
								continue;
							}
							this.$$switch$795$15287 = this.$i$15283;
							if (119269 - 302540 != -183271)
							{
								continue;
							}
							if (this.$$switch$795$15287 == 0)
							{
								if (21222 - 150568 == -129345)
								{
									continue;
								}
								this.$hitPoint$15286 = this.$self_$15293.transform.position + (float)1 * this.$self_$15293.transform.forward;
								if (222298 - 186913 == 35386)
								{
									continue;
								}
							}
							else if (this.$$switch$795$15287 == 1)
							{
								if (121300 - 200451 != -79151)
								{
									continue;
								}
								this.$hitPoint$15286 = this.$self_$15293.transform.position + 3.5f * this.$self_$15293.transform.forward;
								if (268288 - 339133 != -70845)
								{
									continue;
								}
							}
							else if (this.$$switch$795$15287 == 2)
							{
								if (215446 - 489063 != -273617)
								{
									continue;
								}
								this.$hitPoint$15286 = this.$self_$15293.transform.position + 3.5f * this.$self_$15293.transform.forward;
								if (248690 - 387689 != -138999)
								{
									continue;
								}
							}
							else if (this.$$switch$795$15287 == 3)
							{
								if (3005 - 256799 == -253793)
								{
									continue;
								}
								this.$hitPoint$15286 = this.$self_$15293.transform.position + (float)1 * this.$self_$15293.transform.forward;
								if (289063 - 264023 != 25040)
								{
									continue;
								}
							}
							this.$hitList$15288 = Damage.FindRecTarget(this.$hitPoint$15286, this.$self_$15293.transform.forward, (float)1 * this.$self_$15293.gO7OoEyc1.rangeMod, (float)1 * this.$self_$15293.gO7OoEyc1.rangeMod, (float)2 * this.$self_$15293.gO7OoEyc1.rangeMod, (float)2 * this.$self_$15293.gO7OoEyc1.rangeMod, this.$hitLayer$15284);
							if (276047 - 177594 != 98453)
							{
								continue;
							}
							this.$$iterator$9881$15290 = UnityRuntimeServices.GetEnumerator(this.$hitList$15288);
							if (288368 - 229091 == 59278)
							{
								continue;
							}
							while (this.$$iterator$9881$15290.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$9881$15290.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$15289 = (GameObject)obj2;
								if (298542 - 338168 == -39625)
								{
									goto IL_D4;
								}
								if (this.$self_$15293.gO7OoEyc1.hit(1, this.$hitObject$15289, (int)(0.5f * (float)this.$self_$15293.gO7OoEyc1.atk), 1, 0, 0.5f * global::Math.vFlat(this.$hitObject$15289.transform.position - this.$hitPoint$15286).normalized) != 0)
								{
									if (299645 - 30298 == 269348)
									{
										goto IL_D4;
									}
									this.$hitPos$15285 = this.$hitObject$15289.collider.ClosestPointOnBounds(this.$hitPoint$15286 + 0.5f * Vector3.up);
									if (245476 - 439933 != -194457)
									{
										goto IL_D4;
									}
									UnityRuntimeServices.Update(this.$$iterator$9881$15290, this.$hitObject$15289);
									if (86489 - 189461 != -102972)
									{
										goto IL_D4;
									}
									this.$self_$15293.RPC_scythe_hit(this.$hitPos$15285, this.$self_$15293.transform.forward, 0);
									if (1448 - 91828 == -90379)
									{
										goto IL_D4;
									}
									this.$self_$15293.ActionEvent("RPC_scythe_hit", this.$hitPos$15285, this.$self_$15293.transform.forward, 0);
									if (111582 - 441005 != -329423)
									{
										goto IL_D4;
									}
								}
							}
							if (10310 - 551176 != -540866)
							{
								continue;
							}
							goto IL_49;
						}
						break;
					case 4:
						if (this.$self_$15293.gO7OoEyc1.actionState != "attack")
						{
							goto IL_8B5;
						}
						if (195141 - 481644 == -286502)
						{
							continue;
						}
						if (this.$self_$15293.gO7OoEyc1.myCommand != "scythe")
						{
							if (196609 - 102197 != 94413)
							{
								goto Block_42;
							}
							continue;
						}
						else
						{
							this.$i$15283++;
							if (155168 - 32731 != 122437)
							{
								continue;
							}
							goto IL_940;
						}
						break;
					case 5:
						if (this.$self_$15293.gO7OoEyc1.actionState == "attack")
						{
							if (76282 - 537258 == -460975)
							{
								continue;
							}
							if (this.$self_$15293.gO7OoEyc1.myCommand == "scythe")
							{
								if (130065 - 562068 == -432002)
								{
									continue;
								}
								this.$self_$15293.gO7OoEyc1.actionState = "standby";
								if (18028 - 326986 != -308958)
								{
									continue;
								}
								this.$self_$15293.gO7OoEyc1.actionTime = Time.time;
								if (45434 - 140340 != -94906)
								{
									continue;
								}
								this.$self_$15293.gO7OoEyc1.myCommand = "none";
								if (234304 - 477994 != -243690)
								{
									continue;
								}
								if (!this.$self_$15293.gO7OoEyc1.isMine)
								{
									if (296480 - 448186 != -151706)
									{
										continue;
									}
									this.$self_$15293.gO7OoEyc1.nPosition = this.$self_$15293.transform.position;
									if (199767 - 410544 != -210777)
									{
										continue;
									}
									this.$self_$15293.gO7OoEyc1.oPosition = this.$self_$15293.transform.position;
									if (231203 - 488132 != -256929)
									{
										continue;
									}
									this.$self_$15293.gO7OoEyc1.nDirection = this.$self_$15293.transform.forward;
									if (237706 - 197194 == 40513)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (115122 - 52138 != 62984)
						{
							continue;
						}
						goto IL_E9E;
					default:
						if (291449 - 412913 == -121463)
						{
							continue;
						}
						break;
					}
					this.$self_$15293.gO7OoEyc1.actionState = "attack";
					if (231981 - 368017 != -136036)
					{
						continue;
					}
					this.$self_$15293.gO7OoEyc1.actionTime = Time.time;
					if (298895 - 345666 == -46770)
					{
						continue;
					}
					this.$self_$15293.gO7OoEyc1.myCommand = "scythe";
					if (222689 - 128647 == 94043)
					{
						continue;
					}
					this.$self_$15293.gO7OoEyc1.addTimeOut("nAttack", (float)2);
					if (298586 - 287530 == 11057)
					{
						continue;
					}
					this.$self_$15293.transform.position = this.$mPos$15291;
					if (73824 - 358765 == -284940)
					{
						continue;
					}
					this.$self_$15293.transform.LookAt(this.$mPos$15291 + global::Math.vFlat(this.$tDir$15292));
					if (89421 - 326905 != -237484)
					{
						continue;
					}
					this.$self_$15293.animation.CrossFade("nAttack");
					if (28237 - 89902 != -61665)
					{
						continue;
					}
					this.$self_$15293.animation.wrapMode = WrapMode.Once;
					if (295573 - 78113 == 217461)
					{
						continue;
					}
					this.$self_$15293.gO7OoEyc1.vMovement = this.$self_$15293.transform.forward;
					if (17433 - 139034 != -121601)
					{
						continue;
					}
					this.$self_$15293.gO7OoEyc1.moveSpeed = (float)0;
					if (231979 - 470065 != -238086)
					{
						continue;
					}
					goto IL_DEB;
					IL_940:
					if (this.$i$15283 < 4)
					{
						goto IL_802;
					}
					if (284955 - 113423 == 171532)
					{
						if (this.$self_$15293.gO7OoEyc1.actionState != "attack")
						{
							goto IL_637;
						}
						if (93759 - 544175 == -450416)
						{
							if (this.$self_$15293.gO7OoEyc1.myCommand != "scythe")
							{
								if (66550 - 284834 == -218284)
								{
									goto IL_637;
								}
							}
							else
							{
								this.$self_$15293.gO7OoEyc1.moveSpeed = (float)0;
								if (67618 - 194691 == -127073)
								{
									goto IL_3B0;
								}
							}
						}
					}
				}
				IL_49:
				return this.Yield(4, new WaitForSeconds(0.1f));
				IL_3B0:
				return this.Yield(5, new WaitForSeconds(0.2f));
				IL_4EF:
				Block_42:
				IL_637:
				IL_6B4:
				goto IL_E9E;
				IL_802:
				return this.Yield(3, new WaitForSeconds(0.1f));
				IL_8B5:
				Block_81:
				goto IL_4EF;
				IL_DEB:
				return this.Yield(2, new WaitForSeconds(0.2f));
				IL_E9E:
				return false;
			}

			// Token: 0x060000BB RID: 187 RVA: 0x00012F84 File Offset: 0x00011184
			internal static bool OZ6gmr5XgQWqCcwZLVA()
			{
				return true;
			}

			// Token: 0x060000BC RID: 188 RVA: 0x00012F88 File Offset: 0x00011188
			internal static bool WoKbfK5QagvSKbrP2nE()
			{
				return false;
			}

			// Token: 0x040000F5 RID: 245
			internal Transform $mSword$15281;

			// Token: 0x040000F6 RID: 246
			internal GameObject $mScythe_trail$15282;

			// Token: 0x040000F7 RID: 247
			internal int $i$15283;

			// Token: 0x040000F8 RID: 248
			internal int $hitLayer$15284;

			// Token: 0x040000F9 RID: 249
			internal Vector3 $hitPos$15285;

			// Token: 0x040000FA RID: 250
			internal Vector3 $hitPoint$15286;

			// Token: 0x040000FB RID: 251
			internal int $$switch$795$15287;

			// Token: 0x040000FC RID: 252
			internal UnityScript.Lang.Array $hitList$15288;

			// Token: 0x040000FD RID: 253
			internal GameObject $hitObject$15289;

			// Token: 0x040000FE RID: 254
			internal IEnumerator $$iterator$9881$15290;

			// Token: 0x040000FF RID: 255
			internal Vector3 $mPos$15291;

			// Token: 0x04000100 RID: 256
			internal Vector3 $tDir$15292;

			// Token: 0x04000101 RID: 257
			internal BanditBug $self_$15293;
		}
	}

	// Token: 0x02000026 RID: 38
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_scythe2$15297 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060000BD RID: 189 RVA: 0x00012F8C File Offset: 0x0001118C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_scythe2$15297(Vector3 mPos, Vector3 tDir, BanditBug self_)
		{
			if (218864 - 386466 != -167602)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (130849 - 470633 != -339783)
				{
					base..ctor();
					if (116809 - 187188 != -70378)
					{
						this.$mPos$15307 = mPos;
						if (162059 - 306644 == -144585)
						{
							this.$tDir$15308 = tDir;
							if (73102 - 539521 != -466418)
							{
								this.$self_$15309 = self_;
								if (294641 - 485151 == -190510)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00013068 File Offset: 0x00011268
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new BanditBug.$RPC_scythe2$15297.$(this.$mPos$15307, this.$tDir$15308, this.$self_$15309);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00013084 File Offset: 0x00011284
		internal static bool WhIfRK5klS8A34VwNPs()
		{
			return true;
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00013088 File Offset: 0x00011288
		internal static bool ns4wTM5Gw2ygtQmInpk()
		{
			return false;
		}

		// Token: 0x04000102 RID: 258
		internal Vector3 $mPos$15307;

		// Token: 0x04000103 RID: 259
		internal Vector3 $tDir$15308;

		// Token: 0x04000104 RID: 260
		internal BanditBug $self_$15309;

		// Token: 0x02000027 RID: 39
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060000C1 RID: 193 RVA: 0x0001308C File Offset: 0x0001128C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, BanditBug self_)
			{
				if (95 - 12226 != -12131)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (80430 - 533367 != -452936)
					{
						base..ctor();
						if (203860 - 587117 != -383256)
						{
							this.$mPos$15304 = mPos;
							if (249170 - 469019 == -219849)
							{
								this.$tDir$15305 = tDir;
								if (69238 - 558336 != -489097)
								{
									this.$self_$15306 = self_;
									if (2487 - 345741 == -343254)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060000C2 RID: 194 RVA: 0x00013168 File Offset: 0x00011368
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (181586 - 224738 != -43151)
				{
				}
				for (;;)
				{
					IL_3D5:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_A35;
					case 2:
						if (this.$self_$15306.gO7OoEyc1.actionState != "attack")
						{
							goto IL_529;
						}
						if (258320 - 326038 != -67718)
						{
							continue;
						}
						if (this.$self_$15306.gO7OoEyc1.myCommand != "scythe2")
						{
							if (24172 - 413289 != -389117)
							{
								continue;
							}
							goto IL_529;
						}
						else
						{
							this.$self_$15306.gO7OoEyc1.moveSpeed = (float)2;
							if (40932 - 117429 != -76497)
							{
								continue;
							}
							goto IL_739;
						}
						break;
					case 3:
						if (this.$self_$15306.gO7OoEyc1.actionState != "attack")
						{
							goto IL_6DA;
						}
						if (159257 - 475919 == -316661)
						{
							continue;
						}
						if (this.$self_$15306.gO7OoEyc1.myCommand != "scythe2")
						{
							if (219591 - 34857 != 184735)
							{
								goto Block_53;
							}
							continue;
						}
						else
						{
							this.$firePos$15298 = this.$self_$15306.transform.position;
							if (243196 - 241280 != 1916)
							{
								continue;
							}
							if (this.$self_$15306.scythe_cAttack)
							{
								if (88394 - 443523 != -355129)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$15306.scythe_cAttack, this.$firePos$15298, this.$self_$15306.transform.rotation);
								if (84568 - 270047 == -185478)
								{
									continue;
								}
							}
							else
							{
								Debug.Log("Missing scythe_cAttack effect");
								if (86503 - 188456 == -101952)
								{
									continue;
								}
							}
							if (!this.$self_$15306.scythe_cAttackFx)
							{
								goto IL_441;
							}
							if (34455 - 515908 != -481453)
							{
								continue;
							}
							this.$self_$15306.audio.PlayOneShot(this.$self_$15306.scythe_cAttackFx);
							if (29247 - 119713 != -90466)
							{
								continue;
							}
							goto IL_441;
						}
						break;
					case 4:
						if (this.$self_$15306.gO7OoEyc1.actionState != "attack")
						{
							goto IL_9D6;
						}
						if (182838 - 105041 == 77798)
						{
							continue;
						}
						if (this.$self_$15306.gO7OoEyc1.myCommand != "scythe2")
						{
							if (72492 - 332078 != -259586)
							{
								continue;
							}
							goto IL_9D6;
						}
						else
						{
							if (!this.$self_$15306.gO7OoEyc1.isMine)
							{
								goto IL_35B;
							}
							if (156970 - 212997 == -56026)
							{
								continue;
							}
							this.$hitLayer$15299 = 130816 - (1 << this.$self_$15306.gameObject.layer);
							if (132464 - 226654 != -94190)
							{
								continue;
							}
							this.$hitList$15300 = Damage.FindAreaTarget(this.$firePos$15298, (float)6 * this.$self_$15306.gO7OoEyc1.rangeMod, (float)2 * this.$self_$15306.gO7OoEyc1.rangeMod, this.$hitLayer$15299);
							if (206688 - 328065 == -121376)
							{
								continue;
							}
							this.$$iterator$9883$15303 = UnityRuntimeServices.GetEnumerator(this.$hitList$15300);
							if (13982 - 164515 == -150532)
							{
								continue;
							}
							while (this.$$iterator$9883$15303.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$9883$15303.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$15301 = (GameObject)obj2;
								if (166559 - 577237 == -410677)
								{
									goto IL_3D5;
								}
								if (this.$self_$15306.gO7OoEyc1.hit(10, this.$hitObject$15301, (int)(0.5f * (float)this.$self_$15306.gO7OoEyc1.atk), 1, 0, 0.5f * (this.$hitObject$15301.transform.position - this.$self_$15306.transform.position).normalized) != 0)
								{
									if (116939 - 543034 == -426094)
									{
										goto IL_3D5;
									}
									this.$hitPos$15302 = this.$hitObject$15301.collider.ClosestPointOnBounds(this.$firePos$15298 + 0.3f * Vector3.up);
									if (189377 - 329571 == -140193)
									{
										goto IL_3D5;
									}
									UnityRuntimeServices.Update(this.$$iterator$9883$15303, this.$hitObject$15301);
									if (288782 - 316108 != -27326)
									{
										goto IL_3D5;
									}
									this.$self_$15306.RPC_scythe_hit(this.$hitPos$15302, this.$self_$15306.transform.forward, 0);
									if (212291 - 112364 != 99927)
									{
										goto IL_3D5;
									}
									this.$self_$15306.ActionEvent("RPC_scythe_hit", this.$hitPos$15302, this.$self_$15306.transform.forward, 0);
									if (261261 - 197700 == 63562)
									{
										goto IL_3D5;
									}
								}
							}
							if (159675 - 518274 != -358599)
							{
								continue;
							}
							goto IL_35B;
						}
						break;
					case 5:
						if (this.$self_$15306.gO7OoEyc1.actionState == "attack")
						{
							if (147884 - 587155 == -439270)
							{
								continue;
							}
							if (this.$self_$15306.gO7OoEyc1.myCommand == "scythe2")
							{
								if (59953 - 459342 == -399388)
								{
									continue;
								}
								this.$self_$15306.gO7OoEyc1.actionState = "standby";
								if (56937 - 173454 == -116516)
								{
									continue;
								}
								this.$self_$15306.gO7OoEyc1.actionTime = Time.time;
								if (239441 - 181459 == 57983)
								{
									continue;
								}
								this.$self_$15306.gO7OoEyc1.myCommand = "none";
								if (238309 - 340936 == -102626)
								{
									continue;
								}
								if (!this.$self_$15306.gO7OoEyc1.isMine)
								{
									if (35298 - 18827 != 16471)
									{
										continue;
									}
									this.$self_$15306.gO7OoEyc1.nPosition = this.$self_$15306.transform.position;
									if (296571 - 65386 == 231186)
									{
										continue;
									}
									this.$self_$15306.gO7OoEyc1.oPosition = this.$self_$15306.transform.position;
									if (252269 - 417637 == -165367)
									{
										continue;
									}
									this.$self_$15306.gO7OoEyc1.nDirection = this.$self_$15306.transform.forward;
									if (191005 - 218325 != -27320)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (24995 - 210599 != -185603)
						{
							goto Block_10;
						}
						continue;
					default:
						if (36601 - 93736 == -57134)
						{
							continue;
						}
						break;
					}
					this.$self_$15306.gO7OoEyc1.actionState = "attack";
					if (13785 - 471843 != -458057)
					{
						this.$self_$15306.gO7OoEyc1.actionTime = Time.time;
						if (238725 - 519821 != -281095)
						{
							this.$self_$15306.gO7OoEyc1.myCommand = "scythe2";
							if (281706 - 321833 == -40127)
							{
								this.$self_$15306.gO7OoEyc1.addTimeOut("cAttack", (float)8);
								if (64955 - 509635 != -444679)
								{
									this.$self_$15306.transform.position = this.$mPos$15304;
									if (98179 - 19867 == 78312)
									{
										this.$self_$15306.transform.LookAt(this.$mPos$15304 + global::Math.vFlat(this.$tDir$15305));
										if (161767 - 537396 != -375628)
										{
											this.$self_$15306.animation.CrossFade("cAttack");
											if (75043 - 373769 != -298725)
											{
												this.$self_$15306.animation.wrapMode = WrapMode.Once;
												if (1325 - 29346 != -28020)
												{
													this.$self_$15306.gO7OoEyc1.vMovement = this.$self_$15306.transform.forward;
													if (180443 - 342287 != -161843)
													{
														this.$self_$15306.gO7OoEyc1.moveSpeed = (float)0;
														if (97708 - 72107 == 25601)
														{
															goto IL_852;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_10:
				goto IL_A35;
				IL_35B:
				return this.Yield(5, new WaitForSeconds(0.1f));
				IL_441:
				return this.Yield(4, new WaitForSeconds(0.2f));
				IL_529:
				IL_6DA:
				goto IL_A35;
				IL_739:
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_852:
				return this.Yield(2, new WaitForSeconds(0.3f));
				Block_53:
				IL_9D6:
				IL_A35:
				return false;
			}

			// Token: 0x060000C3 RID: 195 RVA: 0x00013BBC File Offset: 0x00011DBC
			internal static bool khk3E55HVXlq828vFTv()
			{
				return true;
			}

			// Token: 0x060000C4 RID: 196 RVA: 0x00013BC0 File Offset: 0x00011DC0
			internal static bool e9d2LD5WhCwQjtdqUSE()
			{
				return false;
			}

			// Token: 0x04000105 RID: 261
			internal Vector3 $firePos$15298;

			// Token: 0x04000106 RID: 262
			internal int $hitLayer$15299;

			// Token: 0x04000107 RID: 263
			internal UnityScript.Lang.Array $hitList$15300;

			// Token: 0x04000108 RID: 264
			internal GameObject $hitObject$15301;

			// Token: 0x04000109 RID: 265
			internal Vector3 $hitPos$15302;

			// Token: 0x0400010A RID: 266
			internal IEnumerator $$iterator$9883$15303;

			// Token: 0x0400010B RID: 267
			internal Vector3 $mPos$15304;

			// Token: 0x0400010C RID: 268
			internal Vector3 $tDir$15305;

			// Token: 0x0400010D RID: 269
			internal BanditBug $self_$15306;
		}
	}

	// Token: 0x02000028 RID: 40
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_sword$15310 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060000C5 RID: 197 RVA: 0x00013BC4 File Offset: 0x00011DC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_sword$15310(Vector3 mPos, Vector3 tDir, BanditBug self_)
		{
			if (212868 - 119794 != 93074)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (33901 - 316432 == -282531)
				{
					base..ctor();
					if (19971 - 232593 != -212621)
					{
						this.$mPos$15322 = mPos;
						if (128382 - 99602 == 28780)
						{
							this.$tDir$15323 = tDir;
							if (27032 - 53488 == -26456)
							{
								this.$self_$15324 = self_;
								if (62719 - 394151 == -331432)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x00013CA0 File Offset: 0x00011EA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new BanditBug.$RPC_sword$15310.$(this.$mPos$15322, this.$tDir$15323, this.$self_$15324);
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00013CBC File Offset: 0x00011EBC
		internal static bool WsrkiT5ACckRnFUy0OY()
		{
			return true;
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00013CC0 File Offset: 0x00011EC0
		internal static bool seHFll5lj37JKA7RIo4()
		{
			return false;
		}

		// Token: 0x0400010E RID: 270
		internal Vector3 $mPos$15322;

		// Token: 0x0400010F RID: 271
		internal Vector3 $tDir$15323;

		// Token: 0x04000110 RID: 272
		internal BanditBug $self_$15324;

		// Token: 0x02000029 RID: 41
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060000C9 RID: 201 RVA: 0x00013CC4 File Offset: 0x00011EC4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, BanditBug self_)
			{
				if (48046 - 457082 != -409035)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (40559 - 25132 == 15427)
					{
						base..ctor();
						if (252815 - 53353 == 199462)
						{
							this.$mPos$15319 = mPos;
							if (287343 - 450823 == -163480)
							{
								this.$tDir$15320 = tDir;
								if (199701 - 465743 == -266042)
								{
									this.$self_$15321 = self_;
									if (276442 - 24873 == 251569)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060000CA RID: 202 RVA: 0x00013DA0 File Offset: 0x00011FA0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (161480 - 382745 != -221265)
				{
				}
				for (;;)
				{
					IL_89E:
					switch (this._state)
					{
					case 0:
						goto IL_517;
					case 1:
						goto IL_BE7;
					case 2:
						if (this.$self_$15321.gO7OoEyc1.actionState != "attack")
						{
							goto IL_64F;
						}
						if (53183 - 307780 == -254596)
						{
							continue;
						}
						if (this.$self_$15321.gO7OoEyc1.myCommand != "sword")
						{
							if (95481 - 256977 != -161496)
							{
								continue;
							}
							goto IL_64F;
						}
						else
						{
							if (!this.$self_$15321.gO7OoEyc1.isMine)
							{
								goto IL_1BD;
							}
							if (15242 - 328585 == -313342)
							{
								continue;
							}
							this.$hitLayer$15314 = 130816 - (1 << this.$self_$15321.gameObject.layer);
							if (221938 - 445373 != -223435)
							{
								continue;
							}
							this.$hitList$15315 = Damage.FindRecTarget(this.$self_$15321.transform.position, this.$self_$15321.transform.forward, (float)1 * this.$self_$15321.gO7OoEyc1.rangeMod, (float)1 * this.$self_$15321.gO7OoEyc1.rangeMod, (float)2 * this.$self_$15321.gO7OoEyc1.rangeMod, (float)2 * this.$self_$15321.gO7OoEyc1.rangeMod, this.$hitLayer$15314);
							if (235509 - 256785 != -21276)
							{
								continue;
							}
							this.$$iterator$9882$15318 = UnityRuntimeServices.GetEnumerator(this.$hitList$15315);
							if (232577 - 415769 != -183192)
							{
								continue;
							}
							while (this.$$iterator$9882$15318.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$9882$15318.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$15316 = (GameObject)obj2;
								if (228905 - 448942 != -220037)
								{
									goto IL_89E;
								}
								if (this.$self_$15321.gO7OoEyc1.hit(99, this.$hitObject$15316, (int)(0.5f * (float)this.$self_$15321.gO7OoEyc1.atk), 1, 0, 0.5f * (this.$hitObject$15316.transform.position - this.$self_$15321.transform.position).normalized) != 0)
								{
									if (109752 - 123375 == -13622)
									{
										goto IL_89E;
									}
									this.$hitPos$15317 = this.$hitObject$15316.collider.ClosestPointOnBounds(this.$self_$15321.transform.position + 0.3f * Vector3.up);
									if (133861 - 39752 != 94109)
									{
										goto IL_89E;
									}
									UnityRuntimeServices.Update(this.$$iterator$9882$15318, this.$hitObject$15316);
									if (121378 - 467894 == -346515)
									{
										goto IL_89E;
									}
									this.$self_$15321.RPC_sword_hit(this.$hitPos$15317, this.$self_$15321.transform.forward, 0);
									if (181991 - 227306 == -45314)
									{
										goto IL_89E;
									}
									this.$self_$15321.ActionEvent("RPC_sword_hit", this.$hitPos$15317, this.$self_$15321.transform.forward, 0);
									if (91170 - 418072 != -326902)
									{
										goto IL_89E;
									}
								}
							}
							if (112184 - 279047 != -166862)
							{
								goto Block_71;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$15321.gO7OoEyc1.actionState != "attack")
						{
							goto IL_A4A;
						}
						if (63541 - 447128 != -383587)
						{
							continue;
						}
						if (this.$self_$15321.gO7OoEyc1.myCommand != "sword")
						{
							if (74339 - 485195 != -410856)
							{
								continue;
							}
							goto IL_A4A;
						}
						else
						{
							this.$self_$15321.gO7OoEyc1.moveSpeed = (float)0;
							if (237676 - 321667 == -83990)
							{
								continue;
							}
							if (this.$i$15313 != 0)
							{
								goto IL_9C4;
							}
							if (51946 - 258306 != -206359)
							{
								goto Block_44;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$15321.gO7OoEyc1.actionState != "attack")
						{
							goto IL_86D;
						}
						if (265231 - 191931 == 73301)
						{
							continue;
						}
						if (this.$self_$15321.gO7OoEyc1.myCommand != "sword")
						{
							if (179690 - 519130 != -339440)
							{
								continue;
							}
							goto IL_86D;
						}
						else
						{
							this.$self_$15321.gO7OoEyc1.moveSpeed = (float)5;
							if (209870 - 311215 != -101345)
							{
								continue;
							}
							goto IL_9C4;
						}
						break;
					case 5:
						if (this.$self_$15321.gO7OoEyc1.actionState == "attack")
						{
							if (27371 - 347382 == -320010)
							{
								continue;
							}
							if (this.$self_$15321.gO7OoEyc1.myCommand == "sword")
							{
								if (40082 - 558108 == -518025)
								{
									continue;
								}
								this.$self_$15321.gO7OoEyc1.actionState = "standby";
								if (240899 - 186873 != 54026)
								{
									continue;
								}
								this.$self_$15321.gO7OoEyc1.actionTime = Time.time;
								if (92698 - 18830 != 73868)
								{
									continue;
								}
								this.$self_$15321.gO7OoEyc1.myCommand = "none";
								if (76764 - 518440 != -441676)
								{
									continue;
								}
								if (!this.$self_$15321.gO7OoEyc1.isMine)
								{
									if (222775 - 574625 != -351850)
									{
										continue;
									}
									this.$self_$15321.gO7OoEyc1.nPosition = this.$self_$15321.transform.position;
									if (14103 - 233640 != -219537)
									{
										continue;
									}
									this.$self_$15321.gO7OoEyc1.oPosition = this.$self_$15321.transform.position;
									if (90085 - 17084 != 73001)
									{
										continue;
									}
									this.$self_$15321.gO7OoEyc1.nDirection = this.$self_$15321.transform.forward;
									if (238732 - 290937 == -52204)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (227805 - 427331 != -199525)
						{
							goto Block_5;
						}
						continue;
					default:
						if (192153 - 271951 != -79798)
						{
							continue;
						}
						goto IL_517;
					}
					IL_46E:
					if (this.$i$15313 < 2)
					{
						goto IL_4C8;
					}
					if (86980 - 267393 != -180412)
					{
						goto Block_28;
					}
					continue;
					IL_9C4:
					this.$i$15313++;
					if (267166 - 541693 != -274527)
					{
						continue;
					}
					goto IL_46E;
					IL_517:
					this.$self_$15321.gO7OoEyc1.actionState = "attack";
					if (123110 - 37202 == 85908)
					{
						this.$self_$15321.gO7OoEyc1.actionTime = Time.time;
						if (26351 - 37609 != -11257)
						{
							this.$self_$15321.gO7OoEyc1.myCommand = "sword";
							if (139107 - 306854 == -167747)
							{
								this.$self_$15321.gO7OoEyc1.addTimeOut("nAttack", (float)2);
								if (202439 - 298833 == -96394)
								{
									this.$self_$15321.transform.position = this.$mPos$15319;
									if (291745 - 395015 == -103270)
									{
										this.$self_$15321.transform.LookAt(this.$mPos$15319 + global::Math.vFlat(this.$tDir$15320));
										if (158946 - 508472 == -349526)
										{
											this.$self_$15321.animation.CrossFade("nAttack");
											if (52745 - 432553 != -379807)
											{
												this.$self_$15321.animation.wrapMode = WrapMode.Once;
												if (281336 - 486821 == -205485)
												{
													this.$self_$15321.gO7OoEyc1.vMovement = this.$self_$15321.transform.forward;
													if (288905 - 338958 != -50052)
													{
														this.$self_$15321.gO7OoEyc1.moveSpeed = (float)5;
														if (22323 - 391629 == -369306)
														{
															this.$mSword$15311 = global::Math.findChildObject(this.$self_$15321.transform, "sword");
															if (6107 - 269574 == -263467)
															{
																if (this.$mSword$15311)
																{
																	if (80755 - 566120 == -485364)
																	{
																		continue;
																	}
																	if (this.$self_$15321.sword_trail)
																	{
																		if (213053 - 438413 != -225360)
																		{
																			continue;
																		}
																		this.$mSword_trail$15312 = (GameObject)UnityEngine.Object.Instantiate(this.$self_$15321.sword_trail, Vector3.zero, Quaternion.identity);
																		if (123425 - 405974 == -282548)
																		{
																			continue;
																		}
																		this.$mSword_trail$15312.transform.parent = this.$mSword$15311;
																		if (187878 - 219090 == -31211)
																		{
																			continue;
																		}
																		this.$mSword_trail$15312.transform.localPosition = new Vector3(-0.4f, (float)0, (float)0);
																		if (276107 - 522660 == -246552)
																		{
																			continue;
																		}
																		this.$mSword_trail$15312.transform.localRotation = Quaternion.Euler((float)90, (float)90, (float)0);
																		if (174974 - 364874 == -189899)
																		{
																			continue;
																		}
																	}
																}
																if (this.$self_$15321.sword_nAttackFX)
																{
																	if (98748 - 441323 == -342574)
																	{
																		continue;
																	}
																	this.$self_$15321.audio.PlayOneShot(this.$self_$15321.sword_nAttackFX);
																	if (226994 - 324378 == -97383)
																	{
																		continue;
																	}
																}
																this.$i$15313 = 0;
																if (276747 - 414439 != -137691)
																{
																	goto IL_46E;
																}
															}
														}
													}
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
				goto IL_BE7;
				IL_1BD:
				return this.Yield(3, new WaitForSeconds(0.1f));
				Block_28:
				return this.Yield(5, new WaitForSeconds(0.1f));
				IL_4C8:
				return this.Yield(2, new WaitForSeconds(0.2f));
				IL_64F:
				goto IL_BE7;
				Block_44:
				return this.Yield(4, new WaitForSeconds(0.1f));
				IL_86D:
				IL_A4A:
				goto IL_BE7;
				Block_71:
				goto IL_1BD;
				IL_BE7:
				return false;
			}

			// Token: 0x060000CB RID: 203 RVA: 0x000149A8 File Offset: 0x00012BA8
			internal static bool K36Wwv5y5DdJa4mSTwm()
			{
				return true;
			}

			// Token: 0x060000CC RID: 204 RVA: 0x000149AC File Offset: 0x00012BAC
			internal static bool f9CIVf5STv07JHavCS0()
			{
				return false;
			}

			// Token: 0x04000111 RID: 273
			internal Transform $mSword$15311;

			// Token: 0x04000112 RID: 274
			internal GameObject $mSword_trail$15312;

			// Token: 0x04000113 RID: 275
			internal int $i$15313;

			// Token: 0x04000114 RID: 276
			internal int $hitLayer$15314;

			// Token: 0x04000115 RID: 277
			internal UnityScript.Lang.Array $hitList$15315;

			// Token: 0x04000116 RID: 278
			internal GameObject $hitObject$15316;

			// Token: 0x04000117 RID: 279
			internal Vector3 $hitPos$15317;

			// Token: 0x04000118 RID: 280
			internal IEnumerator $$iterator$9882$15318;

			// Token: 0x04000119 RID: 281
			internal Vector3 $mPos$15319;

			// Token: 0x0400011A RID: 282
			internal Vector3 $tDir$15320;

			// Token: 0x0400011B RID: 283
			internal BanditBug $self_$15321;
		}
	}

	// Token: 0x0200002A RID: 42
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_swordSpin$15325 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060000CD RID: 205 RVA: 0x000149B0 File Offset: 0x00012BB0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_swordSpin$15325(Vector3 mPos, Vector3 tDir, BanditBug self_)
		{
			if (87024 - 123845 != -36821)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (183867 - 451641 == -267774)
				{
					base..ctor();
					if (108561 - 567215 != -458653)
					{
						this.$mPos$15337 = mPos;
						if (279942 - 412459 == -132517)
						{
							this.$tDir$15338 = tDir;
							if (8130 - 590390 != -582259)
							{
								this.$self_$15339 = self_;
								if (231566 - 156917 == 74649)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00014A8C File Offset: 0x00012C8C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new BanditBug.$RPC_swordSpin$15325.$(this.$mPos$15337, this.$tDir$15338, this.$self_$15339);
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00014AA8 File Offset: 0x00012CA8
		internal static bool MxV1CZ5oAEDJHcWE4Kw()
		{
			return true;
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00014AAC File Offset: 0x00012CAC
		internal static bool W1StDa5EL7AUvVd87ni()
		{
			return false;
		}

		// Token: 0x0400011C RID: 284
		internal Vector3 $mPos$15337;

		// Token: 0x0400011D RID: 285
		internal Vector3 $tDir$15338;

		// Token: 0x0400011E RID: 286
		internal BanditBug $self_$15339;

		// Token: 0x0200002B RID: 43
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060000D1 RID: 209 RVA: 0x00014AB0 File Offset: 0x00012CB0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, BanditBug self_)
			{
				if (90720 - 351775 != -261055)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (48953 - 122401 != -73447)
					{
						base..ctor();
						if (8819 - 2104 != 6716)
						{
							this.$mPos$15334 = mPos;
							if (232205 - 576315 == -344110)
							{
								this.$tDir$15335 = tDir;
								if (57555 - 465991 == -408436)
								{
									this.$self_$15336 = self_;
									if (135582 - 397000 != -261417)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060000D2 RID: 210 RVA: 0x00014B8C File Offset: 0x00012D8C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (202519 - 62469 != 140050)
				{
				}
				for (;;)
				{
					IL_3AC:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_BB2;
					case 2:
						if (this.$self_$15336.gO7OoEyc1.actionState != "attack")
						{
							goto IL_22D;
						}
						if (52676 - 11207 == 41470)
						{
							continue;
						}
						if (this.$self_$15336.gO7OoEyc1.myCommand != "swordSpin")
						{
							if (243584 - 281809 != -38224)
							{
								goto Block_44;
							}
							continue;
						}
						else
						{
							this.$self_$15336.gO7OoEyc1.moveSpeed = (float)6;
							if (59713 - 81740 == -22026)
							{
								continue;
							}
							this.$mSword$15326 = global::Math.findChildObject(this.$self_$15336.transform, "sword");
							if (9347 - 340097 != -330750)
							{
								continue;
							}
							if (this.$mSword$15326)
							{
								if (184573 - 174866 != 9707)
								{
									continue;
								}
								if (this.$self_$15336.sword_trail)
								{
									if (127629 - 575122 == -447492)
									{
										continue;
									}
									this.$mSword_trail$15327 = (GameObject)UnityEngine.Object.Instantiate(this.$self_$15336.sword_trail, Vector3.zero, Quaternion.identity);
									if (99368 - 297490 == -198121)
									{
										continue;
									}
									this.$mSword_trail$15327.transform.parent = this.$mSword$15326;
									if (77723 - 182065 != -104342)
									{
										continue;
									}
									this.$mSword_trail$15327.transform.localPosition = new Vector3(-0.4f, (float)0, (float)0);
									if (281491 - 100667 == 180825)
									{
										continue;
									}
									this.$mSword_trail$15327.transform.localRotation = Quaternion.Euler((float)90, (float)90, (float)0);
									if (291008 - 411477 == -120468)
									{
										continue;
									}
								}
							}
							if (this.$self_$15336.sword_spinFX)
							{
								if (35016 - 290372 == -255355)
								{
									continue;
								}
								this.$self_$15336.audio.PlayOneShot(this.$self_$15336.sword_spinFX);
								if (91462 - 223549 == -132086)
								{
									continue;
								}
							}
							this.$i$15328 = 0;
							if (169193 - 444750 != -275556)
							{
								goto IL_67E;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$15336.gO7OoEyc1.actionState != "attack")
						{
							goto IL_809;
						}
						if (122144 - 596256 != -474112)
						{
							continue;
						}
						if (this.$self_$15336.gO7OoEyc1.myCommand != "swordSpin")
						{
							if (176536 - 94737 != 81800)
							{
								goto IL_809;
							}
							continue;
						}
						else
						{
							if (this.$i$15328 == 2)
							{
								if (198189 - 51607 != 146582)
								{
									continue;
								}
								this.$self_$15336.gO7OoEyc1.moveSpeed = (float)0;
								if (100776 - 11336 == 89441)
								{
									continue;
								}
							}
							if (!this.$self_$15336.gO7OoEyc1.isMine)
							{
								goto IL_539;
							}
							if (31141 - 433242 == -402100)
							{
								continue;
							}
							this.$hitLayer$15329 = 130816 - (1 << this.$self_$15336.gameObject.layer);
							if (16199 - 333605 == -317405)
							{
								continue;
							}
							this.$hitList$15330 = Damage.FindAreaTarget(this.$self_$15336.transform.position, (float)2 * this.$self_$15336.gO7OoEyc1.rangeMod, (float)2 * this.$self_$15336.gO7OoEyc1.rangeMod, this.$hitLayer$15329);
							if (127798 - 575913 != -448115)
							{
								continue;
							}
							this.$$iterator$9884$15333 = UnityRuntimeServices.GetEnumerator(this.$hitList$15330);
							if (61240 - 127905 != -66665)
							{
								continue;
							}
							while (this.$$iterator$9884$15333.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$9884$15333.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$15331 = (GameObject)obj2;
								if (244209 - 574363 == -330153)
								{
									goto IL_3AC;
								}
								if (this.$self_$15336.gO7OoEyc1.hit(99, this.$hitObject$15331, (int)(0.5f * (float)this.$self_$15336.gO7OoEyc1.atk), 1, 0, 0.5f * (this.$hitObject$15331.transform.position - this.$self_$15336.transform.position).normalized) != 0)
								{
									if (221951 - 186530 == 35422)
									{
										goto IL_3AC;
									}
									this.$hitPos$15332 = this.$hitObject$15331.collider.ClosestPointOnBounds(this.$self_$15336.transform.position + 0.3f * Vector3.up);
									if (236036 - 211938 != 24098)
									{
										goto IL_3AC;
									}
									UnityRuntimeServices.Update(this.$$iterator$9884$15333, this.$hitObject$15331);
									if (160504 - 53445 != 107059)
									{
										goto IL_3AC;
									}
									this.$self_$15336.RPC_sword_hit(this.$hitPos$15332, this.$self_$15336.transform.forward, 0);
									if (251906 - 546840 == -294933)
									{
										goto IL_3AC;
									}
									this.$self_$15336.ActionEvent("RPC_sword_hit", this.$hitPos$15332, this.$self_$15336.transform.forward, 0);
									if (225781 - 440335 != -214554)
									{
										goto IL_3AC;
									}
								}
							}
							if (103263 - 481048 != -377785)
							{
								continue;
							}
							goto IL_539;
						}
						break;
					case 4:
						if (this.$self_$15336.gO7OoEyc1.actionState != "attack")
						{
							goto IL_959;
						}
						if (112477 - 575252 == -462774)
						{
							continue;
						}
						if (this.$self_$15336.gO7OoEyc1.myCommand != "swordSpin")
						{
							if (53441 - 401900 != -348459)
							{
								continue;
							}
							goto IL_959;
						}
						else
						{
							this.$i$15328++;
							if (70946 - 456454 != -385508)
							{
								continue;
							}
							goto IL_67E;
						}
						break;
					case 5:
						if (this.$self_$15336.gO7OoEyc1.actionState == "attack")
						{
							if (20242 - 70738 != -50496)
							{
								continue;
							}
							if (this.$self_$15336.gO7OoEyc1.myCommand == "swordSpin")
							{
								if (259706 - 593524 != -333818)
								{
									continue;
								}
								this.$self_$15336.gO7OoEyc1.actionState = "standby";
								if (175130 - 390692 != -215562)
								{
									continue;
								}
								this.$self_$15336.gO7OoEyc1.actionTime = Time.time;
								if (189482 - 437881 != -248399)
								{
									continue;
								}
								this.$self_$15336.gO7OoEyc1.myCommand = "none";
								if (16464 - 92757 != -76293)
								{
									continue;
								}
								if (!this.$self_$15336.gO7OoEyc1.isMine)
								{
									if (157826 - 554153 == -396326)
									{
										continue;
									}
									this.$self_$15336.gO7OoEyc1.nPosition = this.$self_$15336.transform.position;
									if (34893 - 573116 == -538222)
									{
										continue;
									}
									this.$self_$15336.gO7OoEyc1.oPosition = this.$self_$15336.transform.position;
									if (138491 - 224111 != -85620)
									{
										continue;
									}
									this.$self_$15336.gO7OoEyc1.nDirection = this.$self_$15336.transform.forward;
									if (163972 - 345655 != -181683)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (121211 - 335143 != -213931)
						{
							goto Block_9;
						}
						continue;
					default:
						if (7981 - 79832 == -71850)
						{
							continue;
						}
						break;
					}
					this.$self_$15336.gO7OoEyc1.actionState = "attack";
					if (167266 - 572477 == -405210)
					{
						continue;
					}
					this.$self_$15336.gO7OoEyc1.actionTime = Time.time;
					if (90541 - 66139 != 24402)
					{
						continue;
					}
					this.$self_$15336.gO7OoEyc1.myCommand = "swordSpin";
					if (37082 - 177336 != -140254)
					{
						continue;
					}
					this.$self_$15336.gO7OoEyc1.addTimeOut("cAttack", (float)8);
					if (158355 - 441121 != -282766)
					{
						continue;
					}
					this.$self_$15336.transform.position = this.$mPos$15334;
					if (296673 - 267425 != 29248)
					{
						continue;
					}
					this.$self_$15336.transform.LookAt(this.$mPos$15334 + global::Math.vFlat(this.$tDir$15335));
					if (140233 - 450271 == -310037)
					{
						continue;
					}
					this.$self_$15336.animation.CrossFade("cAttack");
					if (246343 - 564554 == -318210)
					{
						continue;
					}
					this.$self_$15336.animation.wrapMode = WrapMode.Once;
					if (207810 - 505103 != -297293)
					{
						continue;
					}
					this.$self_$15336.gO7OoEyc1.vMovement = this.$self_$15336.transform.forward;
					if (62139 - 79718 == -17578)
					{
						continue;
					}
					this.$self_$15336.gO7OoEyc1.moveSpeed = (float)0;
					if (108612 - 219740 != -111128)
					{
						continue;
					}
					goto IL_A11;
					IL_67E:
					if (this.$i$15328 < 4)
					{
						goto IL_8DF;
					}
					if (58628 - 211421 == -152793)
					{
						goto IL_A98;
					}
				}
				Block_9:
				IL_22D:
				goto IL_BB2;
				IL_539:
				return this.Yield(4, new WaitForSeconds(0.1f));
				Block_44:
				IL_809:
				goto IL_BB2;
				IL_8DF:
				return this.Yield(3, new WaitForSeconds(0.1f));
				IL_959:
				goto IL_BB2;
				IL_A11:
				return this.Yield(2, new WaitForSeconds(0.2f));
				IL_A98:
				return this.Yield(5, new WaitForSeconds(0.2f));
				IL_BB2:
				return false;
			}

			// Token: 0x060000D3 RID: 211 RVA: 0x00015760 File Offset: 0x00013960
			internal static bool C8kegb52gWuFbswe66N()
			{
				return true;
			}

			// Token: 0x060000D4 RID: 212 RVA: 0x00015764 File Offset: 0x00013964
			internal static bool wXQhOV58M9u4fcIimww()
			{
				return false;
			}

			// Token: 0x0400011F RID: 287
			internal Transform $mSword$15326;

			// Token: 0x04000120 RID: 288
			internal GameObject $mSword_trail$15327;

			// Token: 0x04000121 RID: 289
			internal int $i$15328;

			// Token: 0x04000122 RID: 290
			internal int $hitLayer$15329;

			// Token: 0x04000123 RID: 291
			internal UnityScript.Lang.Array $hitList$15330;

			// Token: 0x04000124 RID: 292
			internal GameObject $hitObject$15331;

			// Token: 0x04000125 RID: 293
			internal Vector3 $hitPos$15332;

			// Token: 0x04000126 RID: 294
			internal IEnumerator $$iterator$9884$15333;

			// Token: 0x04000127 RID: 295
			internal Vector3 $mPos$15334;

			// Token: 0x04000128 RID: 296
			internal Vector3 $tDir$15335;

			// Token: 0x04000129 RID: 297
			internal BanditBug $self_$15336;
		}
	}

	// Token: 0x0200002C RID: 44
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_bomb$15340 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060000D5 RID: 213 RVA: 0x00015768 File Offset: 0x00013968
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_bomb$15340(Vector3 mPos, Vector3 tDir, BanditBug self_)
		{
			if (7194 - 392171 != -384976)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (41278 - 135044 == -93766)
				{
					base..ctor();
					if (13009 - 533739 != -520729)
					{
						this.$mPos$15346 = mPos;
						if (91424 - 324528 != -233103)
						{
							this.$tDir$15347 = tDir;
							if (208425 - 525142 == -316717)
							{
								this.$self_$15348 = self_;
								if (289487 - 368535 == -79048)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00015844 File Offset: 0x00013A44
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new BanditBug.$RPC_bomb$15340.$(this.$mPos$15346, this.$tDir$15347, this.$self_$15348);
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00015860 File Offset: 0x00013A60
		internal static bool HP1Z9g5Zvcyxt6vR2oM()
		{
			return true;
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00015864 File Offset: 0x00013A64
		internal static bool Chm5PL5CZibrl4B872A()
		{
			return false;
		}

		// Token: 0x0400012A RID: 298
		internal Vector3 $mPos$15346;

		// Token: 0x0400012B RID: 299
		internal Vector3 $tDir$15347;

		// Token: 0x0400012C RID: 300
		internal BanditBug $self_$15348;

		// Token: 0x0200002D RID: 45
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060000D9 RID: 217 RVA: 0x00015868 File Offset: 0x00013A68
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, BanditBug self_)
			{
				if (53463 - 149346 != -95883)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (176251 - 152127 != 24125)
					{
						base..ctor();
						if (139025 - 497264 == -358239)
						{
							this.$mPos$15343 = mPos;
							if (278954 - 332389 == -53435)
							{
								this.$tDir$15344 = tDir;
								if (106631 - 540274 != -433642)
								{
									this.$self_$15345 = self_;
									if (296638 - 170042 == 126596)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060000DA RID: 218 RVA: 0x00015944 File Offset: 0x00013B44
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (148485 - 168153 != -19668)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_709;
					case 2:
						if (this.$self_$15345.gO7OoEyc1.actionState != "attack")
						{
							goto IL_146;
						}
						if (185076 - 418095 != -233019)
						{
							continue;
						}
						if (this.$self_$15345.gO7OoEyc1.myCommand != "bomb")
						{
							if (77517 - 399055 != -321538)
							{
								continue;
							}
							goto IL_146;
						}
						else
						{
							this.$self_$15345.gO7OoEyc1.moveSpeed = (float)2;
							if (270873 - 347212 == -76338)
							{
								continue;
							}
							if (!this.$self_$15345.gO7OoEyc1.isMine)
							{
								goto IL_43C;
							}
							if (155517 - 177413 == -21895)
							{
								continue;
							}
							this.$firePos$15341 = this.$mPos$15343 + this.$self_$15345.transform.TransformDirection((float)0, 0.5f, 0.5f);
							if (207816 - 374251 != -166435)
							{
								continue;
							}
							this.$fireDir$15342 = global::Math.getTrajectoryVector(this.$firePos$15341, this.$mPos$15343 + this.$tDir$15344, (float)15);
							if (165653 - 330384 == -164730)
							{
								continue;
							}
							this.$self_$15345.RPC_bomb_fire(this.$firePos$15341, this.$fireDir$15342, 0);
							if (38186 - 263318 == -225131)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								goto IL_43C;
							}
							if (51613 - 383784 == -332170)
							{
								continue;
							}
							this.$self_$15345.ActionEvent("RPC_bomb_fire", this.$firePos$15341, this.$fireDir$15342, 0);
							if (75502 - 122201 != -46698)
							{
								goto Block_20;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$15345.gO7OoEyc1.actionState != "attack")
						{
							goto IL_1EF;
						}
						if (179326 - 423492 == -244165)
						{
							continue;
						}
						if (this.$self_$15345.gO7OoEyc1.myCommand != "bomb")
						{
							if (169304 - 142554 != 26750)
							{
								continue;
							}
							goto IL_1EF;
						}
						else
						{
							this.$self_$15345.gO7OoEyc1.moveSpeed = (float)0;
							if (206902 - 544310 != -337407)
							{
								goto Block_14;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$15345.gO7OoEyc1.actionState == "attack")
						{
							if (85223 - 331628 == -246404)
							{
								continue;
							}
							if (this.$self_$15345.gO7OoEyc1.myCommand == "bomb")
							{
								if (89145 - 485840 != -396695)
								{
									continue;
								}
								this.$self_$15345.gO7OoEyc1.actionState = "standby";
								if (160478 - 199362 != -38884)
								{
									continue;
								}
								this.$self_$15345.gO7OoEyc1.actionTime = Time.time;
								if (250748 - 499023 != -248275)
								{
									continue;
								}
								this.$self_$15345.gO7OoEyc1.myCommand = "none";
								if (188822 - 421651 != -232829)
								{
									continue;
								}
								if (!this.$self_$15345.gO7OoEyc1.isMine)
								{
									if (260129 - 289457 == -29327)
									{
										continue;
									}
									this.$self_$15345.gO7OoEyc1.nPosition = this.$self_$15345.transform.position;
									if (276938 - 526079 != -249141)
									{
										continue;
									}
									this.$self_$15345.gO7OoEyc1.oPosition = this.$self_$15345.transform.position;
									if (153596 - 597983 != -444387)
									{
										continue;
									}
									this.$self_$15345.gO7OoEyc1.nDirection = this.$self_$15345.transform.forward;
									if (267790 - 549788 != -281998)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (238979 - 117640 != 121340)
						{
							goto Block_26;
						}
						continue;
					default:
						if (255350 - 36996 != 218354)
						{
							continue;
						}
						break;
					}
					this.$self_$15345.gO7OoEyc1.actionState = "attack";
					if (257092 - 119359 == 137733)
					{
						this.$self_$15345.gO7OoEyc1.actionTime = Time.time;
						if (32604 - 504684 != -472079)
						{
							this.$self_$15345.gO7OoEyc1.myCommand = "bomb";
							if (138951 - 581456 == -442505)
							{
								this.$self_$15345.gO7OoEyc1.addTimeOut("nAttack", (float)3);
								if (52680 - 473282 == -420602)
								{
									this.$self_$15345.transform.position = this.$mPos$15343;
									if (16080 - 300747 == -284667)
									{
										this.$self_$15345.transform.LookAt(this.$mPos$15343 + global::Math.vFlat(this.$tDir$15344));
										if (291110 - 121695 != 169416)
										{
											this.$self_$15345.animation.CrossFade("nAttack");
											if (90858 - 535854 != -444995)
											{
												this.$self_$15345.animation.wrapMode = WrapMode.Once;
												if (79275 - 180705 == -101430)
												{
													this.$self_$15345.gO7OoEyc1.vMovement = this.$self_$15345.transform.forward;
													if (155967 - 578266 == -422299)
													{
														this.$self_$15345.gO7OoEyc1.moveSpeed = (float)0;
														if (293676 - 457299 != -163622)
														{
															goto Block_37;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_146:
				IL_1EF:
				goto IL_709;
				Block_14:
				return this.Yield(4, new WaitForSeconds(0.2f));
				Block_20:
				goto IL_43C;
				Block_26:
				goto IL_709;
				IL_43C:
				return this.Yield(3, new WaitForSeconds(0.3f));
				Block_37:
				return this.Yield(2, new WaitForSeconds(0.3f));
				IL_709:
				return false;
			}

			// Token: 0x060000DB RID: 219 RVA: 0x0001606C File Offset: 0x0001426C
			internal static bool AYIYsx5L5AUYsIpUOc4()
			{
				return true;
			}

			// Token: 0x060000DC RID: 220 RVA: 0x00016070 File Offset: 0x00014270
			internal static bool amgVPu5OECNtNt8WYYy()
			{
				return false;
			}

			// Token: 0x0400012D RID: 301
			internal Vector3 $firePos$15341;

			// Token: 0x0400012E RID: 302
			internal Vector3 $fireDir$15342;

			// Token: 0x0400012F RID: 303
			internal Vector3 $mPos$15343;

			// Token: 0x04000130 RID: 304
			internal Vector3 $tDir$15344;

			// Token: 0x04000131 RID: 305
			internal BanditBug $self_$15345;
		}
	}

	// Token: 0x0200002E RID: 46
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_bomb2$15349 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060000DD RID: 221 RVA: 0x00016074 File Offset: 0x00014274
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_bomb2$15349(Vector3 mPos, Vector3 tDir, BanditBug self_)
		{
			if (216539 - 350594 != -134055)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (51022 - 404081 == -353059)
				{
					base..ctor();
					if (45682 - 216481 == -170799)
					{
						this.$mPos$15356 = mPos;
						if (252358 - 104900 == 147458)
						{
							this.$tDir$15357 = tDir;
							if (14125 - 71499 == -57374)
							{
								this.$self_$15358 = self_;
								if (299357 - 369862 != -70504)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00016150 File Offset: 0x00014350
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new BanditBug.$RPC_bomb2$15349.$(this.$mPos$15356, this.$tDir$15357, this.$self_$15358);
		}

		// Token: 0x060000DF RID: 223 RVA: 0x0001616C File Offset: 0x0001436C
		internal static bool NdfNLP5mAqTEcaYLujo()
		{
			return true;
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00016170 File Offset: 0x00014370
		internal static bool EfLMoW5Fqy6Ai8khN3C()
		{
			return false;
		}

		// Token: 0x04000132 RID: 306
		internal Vector3 $mPos$15356;

		// Token: 0x04000133 RID: 307
		internal Vector3 $tDir$15357;

		// Token: 0x04000134 RID: 308
		internal BanditBug $self_$15358;

		// Token: 0x0200002F RID: 47
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060000E1 RID: 225 RVA: 0x00016174 File Offset: 0x00014374
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, BanditBug self_)
			{
				if (125378 - 44474 != 80905)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (90706 - 484866 == -394160)
					{
						base..ctor();
						if (260498 - 399229 != -138730)
						{
							this.$mPos$15353 = mPos;
							if (159400 - 2574 != 156827)
							{
								this.$tDir$15354 = tDir;
								if (115656 - 464353 != -348696)
								{
									this.$self_$15355 = self_;
									if (264518 - 34398 != 230121)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060000E2 RID: 226 RVA: 0x00016250 File Offset: 0x00014450
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (90814 - 224405 != -133590)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_720;
					case 2:
						if (this.$self_$15355.gO7OoEyc1.actionState != "attack")
						{
							goto IL_503;
						}
						if (36644 - 40042 != -3398)
						{
							continue;
						}
						if (this.$self_$15355.gO7OoEyc1.myCommand != "bomb2")
						{
							if (167004 - 434337 != -267333)
							{
								continue;
							}
							goto IL_503;
						}
						else
						{
							this.$i$15350 = 0;
							if (27533 - 328509 != -300975)
							{
								goto IL_37C;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$15355.gO7OoEyc1.actionState != "attack")
						{
							goto IL_7A;
						}
						if (71374 - 518651 != -447277)
						{
							continue;
						}
						if (this.$self_$15355.gO7OoEyc1.myCommand != "bomb2")
						{
							if (287194 - 579039 != -291844)
							{
								goto Block_43;
							}
							continue;
						}
						else
						{
							this.$firePos$15351 = this.$mPos$15353 + this.$self_$15355.transform.TransformDirection((float)0, 0.5f, 0.5f);
							if (17463 - 259219 == -241755)
							{
								continue;
							}
							this.$fireDir$15352 = global::Math.getTrajectoryVector(this.$firePos$15351, this.$mPos$15353 + this.$tDir$15354 + new Vector3(UnityEngine.Random.Range(-1.2f, 1.2f), (float)0, UnityEngine.Random.Range(-1.2f, 1.2f)), (float)15);
							if (77831 - 273496 != -195665)
							{
								continue;
							}
							this.$self_$15355.RPC_bomb_fire(this.$firePos$15351, this.$fireDir$15352, 0);
							if (99364 - 156335 != -56971)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (182549 - 370230 != -187681)
								{
									continue;
								}
								this.$self_$15355.ActionEvent("RPC_bomb_fire", this.$firePos$15351, this.$fireDir$15352, 0);
								if (478 - 411639 == -411160)
								{
									continue;
								}
							}
							this.$i$15350++;
							if (267906 - 393390 != -125484)
							{
								continue;
							}
							goto IL_37C;
						}
						break;
					case 4:
						if (this.$self_$15355.gO7OoEyc1.actionState == "attack")
						{
							if (280772 - 591936 != -311164)
							{
								continue;
							}
							if (this.$self_$15355.gO7OoEyc1.myCommand == "bomb2")
							{
								if (259403 - 329772 == -70368)
								{
									continue;
								}
								this.$self_$15355.gO7OoEyc1.actionState = "standby";
								if (276701 - 556653 == -279951)
								{
									continue;
								}
								this.$self_$15355.gO7OoEyc1.actionTime = Time.time;
								if (20749 - 36540 != -15791)
								{
									continue;
								}
								this.$self_$15355.gO7OoEyc1.myCommand = "none";
								if (257043 - 255364 != 1679)
								{
									continue;
								}
								if (!this.$self_$15355.gO7OoEyc1.isMine)
								{
									if (75294 - 87925 != -12631)
									{
										continue;
									}
									this.$self_$15355.gO7OoEyc1.nPosition = this.$self_$15355.transform.position;
									if (67725 - 287383 != -219658)
									{
										continue;
									}
									this.$self_$15355.gO7OoEyc1.oPosition = this.$self_$15355.transform.position;
									if (33416 - 269762 == -236345)
									{
										continue;
									}
									this.$self_$15355.gO7OoEyc1.nDirection = this.$self_$15355.transform.forward;
									if (127416 - 262184 != -134768)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (51677 - 347638 != -295961)
						{
							continue;
						}
						goto IL_720;
					default:
						if (154995 - 141763 == 13233)
						{
							continue;
						}
						break;
					}
					this.$self_$15355.gO7OoEyc1.actionState = "attack";
					if (220334 - 81347 != 138987)
					{
						continue;
					}
					this.$self_$15355.gO7OoEyc1.actionTime = Time.time;
					if (24083 - 333571 != -309488)
					{
						continue;
					}
					this.$self_$15355.gO7OoEyc1.myCommand = "bomb2";
					if (49779 - 203229 == -153449)
					{
						continue;
					}
					this.$self_$15355.gO7OoEyc1.addTimeOut("cAttack", (float)8);
					if (105229 - 377116 == -271886)
					{
						continue;
					}
					this.$self_$15355.transform.position = this.$mPos$15353;
					if (165416 - 324484 == -159067)
					{
						continue;
					}
					this.$self_$15355.transform.LookAt(this.$mPos$15353 + global::Math.vFlat(this.$tDir$15354));
					if (111721 - 557539 == -445817)
					{
						continue;
					}
					this.$self_$15355.animation.CrossFade("cAttack");
					if (212417 - 162532 != 49885)
					{
						continue;
					}
					this.$self_$15355.animation.wrapMode = WrapMode.Once;
					if (5333 - 399765 != -394432)
					{
						continue;
					}
					this.$self_$15355.gO7OoEyc1.vMovement = this.$self_$15355.transform.forward;
					if (152141 - 556888 == -404746)
					{
						continue;
					}
					this.$self_$15355.gO7OoEyc1.moveSpeed = (float)0;
					if (218511 - 385975 != -167464)
					{
						continue;
					}
					goto IL_63C;
					IL_37C:
					if (this.$i$15350 < 4)
					{
						goto IL_2A3;
					}
					if (172632 - 372483 != -199850)
					{
						goto Block_23;
					}
				}
				IL_7A:
				goto IL_720;
				IL_2A3:
				return this.Yield(3, new WaitForSeconds(0.2f));
				Block_23:
				return this.Yield(4, new WaitForSeconds(0.2f));
				IL_503:
				goto IL_720;
				IL_63C:
				return this.Yield(2, new WaitForSeconds(0.1f));
				Block_43:
				IL_720:
				return false;
			}

			// Token: 0x060000E3 RID: 227 RVA: 0x00016990 File Offset: 0x00014B90
			internal static bool HM9Ks35MWUD4ITk9dKK()
			{
				return true;
			}

			// Token: 0x060000E4 RID: 228 RVA: 0x00016994 File Offset: 0x00014B94
			internal static bool Icaxj65xGeV3QDVIdnH()
			{
				return false;
			}

			// Token: 0x04000135 RID: 309
			internal int $i$15350;

			// Token: 0x04000136 RID: 310
			internal Vector3 $firePos$15351;

			// Token: 0x04000137 RID: 311
			internal Vector3 $fireDir$15352;

			// Token: 0x04000138 RID: 312
			internal Vector3 $mPos$15353;

			// Token: 0x04000139 RID: 313
			internal Vector3 $tDir$15354;

			// Token: 0x0400013A RID: 314
			internal BanditBug $self_$15355;
		}
	}

	// Token: 0x02000030 RID: 48
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$15359 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060000E5 RID: 229 RVA: 0x00016998 File Offset: 0x00014B98
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$15359(UnityScript.Lang.Array nArray, BanditBug self_)
		{
			if (235743 - 19118 != 216625)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (283637 - 234233 != 49405)
				{
					base..ctor();
					if (278317 - 194453 != 83865)
					{
						this.$nArray$15364 = nArray;
						if (5198 - 44093 == -38895)
						{
							this.$self_$15365 = self_;
							if (52510 - 199434 == -146924)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x00016A54 File Offset: 0x00014C54
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new BanditBug.$RPC_ko$15359.$(this.$nArray$15364, this.$self_$15365);
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x00016A68 File Offset: 0x00014C68
		internal static bool iE23EU5gQ9kDyyWFxkg()
		{
			return true;
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00016A6C File Offset: 0x00014C6C
		internal static bool QJSRjX5fd1hJh1dxQJh()
		{
			return false;
		}

		// Token: 0x0400013B RID: 315
		internal UnityScript.Lang.Array $nArray$15364;

		// Token: 0x0400013C RID: 316
		internal BanditBug $self_$15365;

		// Token: 0x02000031 RID: 49
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060000E9 RID: 233 RVA: 0x00016A70 File Offset: 0x00014C70
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, BanditBug self_)
			{
				if (227470 - 169115 != 58356)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (125247 - 273116 != -147868)
					{
						base..ctor();
						if (49845 - 165708 != -115862)
						{
							this.$nArray$15362 = nArray;
							if (140465 - 63037 != 77429)
							{
								this.$self_$15363 = self_;
								if (261784 - 154628 == 107156)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060000EA RID: 234 RVA: 0x00016B2C File Offset: 0x00014D2C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (93365 - 487235 != -393870)
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
						if (this.$self_$15363.gO7OoEyc1.actionState != "ko")
						{
							if (241749 - 210878 != 30871)
							{
								continue;
							}
							goto IL_336;
						}
						else
						{
							this.$self_$15363.animation.Play("getUp");
							if (176533 - 645 != 175888)
							{
								continue;
							}
							this.$self_$15363.animation.wrapMode = WrapMode.Once;
							if (130539 - 512544 != -382005)
							{
								continue;
							}
							goto IL_A9;
						}
						break;
					case 3:
						if (this.$self_$15363.gO7OoEyc1.actionState != "ko")
						{
							if (160536 - 452395 != -291859)
							{
								continue;
							}
							goto IL_75;
						}
						else
						{
							this.$self_$15363.gO7OoEyc1.actionState = "standby";
							if (261592 - 436784 == -175191)
							{
								continue;
							}
							this.$self_$15363.gO7OoEyc1.actionTime = Time.time;
							if (184585 - 332204 == -147618)
							{
								continue;
							}
							this.$self_$15363.gO7OoEyc1.myCommand = "none";
							if (92442 - 476038 != -383596)
							{
								continue;
							}
							this.$self_$15363.gO7OoEyc1.ko = this.$self_$15363.gO7OoEyc1.mko;
							if (63292 - 252763 != -189471)
							{
								continue;
							}
							this.YieldDefault(1);
							if (175369 - 416320 != -240950)
							{
								goto Block_14;
							}
							continue;
						}
						break;
					default:
						if (53336 - 5741 == 47596)
						{
							continue;
						}
						break;
					}
					if (this.$self_$15363.gO7OoEyc1.actionState == "ko")
					{
						break;
					}
					if (269557 - 487855 == -218298)
					{
						if (this.$self_$15363.gO7OoEyc1.actionState == "dead")
						{
							if (262487 - 48877 != 213611)
							{
								break;
							}
						}
						else
						{
							this.$mPos$15360 = (Vector3)this.$nArray$15362[0];
							if (130823 - 207556 == -76733)
							{
								this.$mDir$15361 = (Vector3)this.$nArray$15362[1];
								if (51022 - 195222 == -144200)
								{
									this.$self_$15363.gO7OoEyc1.ko = 0;
									if (255187 - 444234 != -189046)
									{
										this.$self_$15363.gO7OoEyc1.actionState = "ko";
										if (173720 - 208339 == -34619)
										{
											this.$self_$15363.gO7OoEyc1.actionTime = Time.time;
											if (133992 - 23034 == 110958)
											{
												this.$self_$15363.gO7OoEyc1.myCommand = "none";
												if (202604 - 243501 != -40896)
												{
													this.$self_$15363.gO7OoEyc1.vMovement = Vector3.zero;
													if (228823 - 268653 == -39830)
													{
														this.$self_$15363.gO7OoEyc1.moveSpeed = (float)0;
														if (34156 - 461555 != -427398)
														{
															this.$self_$15363.animation.Play("ko");
															if (292900 - 469268 == -176368)
															{
																this.$self_$15363.animation.wrapMode = WrapMode.Once;
																if (299767 - 335807 != -36039)
																{
																	goto Block_25;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_75:
				goto IL_48C;
				IL_A9:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_14:
				IL_336:
				goto IL_48C;
				Block_25:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_48C:
				return false;
			}

			// Token: 0x060000EB RID: 235 RVA: 0x00016FD8 File Offset: 0x000151D8
			internal static bool ojM6YQ5n419CiRtu2wU()
			{
				return true;
			}

			// Token: 0x060000EC RID: 236 RVA: 0x00016FDC File Offset: 0x000151DC
			internal static bool TTVZrO56x1UMP7WiHmj()
			{
				return false;
			}

			// Token: 0x0400013D RID: 317
			internal Vector3 $mPos$15360;

			// Token: 0x0400013E RID: 318
			internal Vector3 $mDir$15361;

			// Token: 0x0400013F RID: 319
			internal UnityScript.Lang.Array $nArray$15362;

			// Token: 0x04000140 RID: 320
			internal BanditBug $self_$15363;
		}
	}

	// Token: 0x02000032 RID: 50
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$15366 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060000ED RID: 237 RVA: 0x00016FE0 File Offset: 0x000151E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$15366(UnityScript.Lang.Array nArray, BanditBug self_)
		{
			if (175177 - 404498 != -229320)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (98509 - 78186 != 20324)
				{
					base..ctor();
					if (187098 - 426401 != -239302)
					{
						this.$nArray$15371 = nArray;
						if (186624 - 158477 != 28148)
						{
							this.$self_$15372 = self_;
							if (219710 - 80154 == 139556)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060000EE RID: 238 RVA: 0x0001709C File Offset: 0x0001529C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new BanditBug.$RPC_dead$15366.$(this.$nArray$15371, this.$self_$15372);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x000170B0 File Offset: 0x000152B0
		internal static bool Xeqhwx5iM3wrScAD31K()
		{
			return true;
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x000170B4 File Offset: 0x000152B4
		internal static bool cAA5Zy5K0wdCvwu0Rup()
		{
			return false;
		}

		// Token: 0x04000141 RID: 321
		internal UnityScript.Lang.Array $nArray$15371;

		// Token: 0x04000142 RID: 322
		internal BanditBug $self_$15372;

		// Token: 0x02000033 RID: 51
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060000F1 RID: 241 RVA: 0x000170B8 File Offset: 0x000152B8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, BanditBug self_)
			{
				if (244579 - 222257 != 22323)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (278438 - 351524 != -73085)
					{
						base..ctor();
						if (220133 - 360464 != -140330)
						{
							this.$nArray$15369 = nArray;
							if (284055 - 334370 == -50315)
							{
								this.$self_$15370 = self_;
								if (270848 - 119641 != 151208)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060000F2 RID: 242 RVA: 0x00017174 File Offset: 0x00015374
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (253236 - 239602 != 13634)
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
						if (this.$self_$15370.gO7OoEyc1.actionState != "dead")
						{
							if (35198 - 389045 != -353846)
							{
								goto Block_17;
							}
							continue;
						}
						else
						{
							if (!this.$self_$15370.gO7OoEyc1.isPlayer)
							{
								if (124322 - 142451 != -18129)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$15370.gameObject);
								if (101391 - 324100 == -222708)
								{
									continue;
								}
							}
							else if (this.$self_$15370.gO7OoEyc1.isMine)
							{
								if (204693 - 493319 != -288626)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$15370.gameObject);
								if (86949 - 312351 == -225401)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (294263 - 82603 != 211660)
							{
								continue;
							}
							goto IL_42F;
						}
						break;
					default:
						if (294931 - 527035 == -232103)
						{
							continue;
						}
						break;
					}
					if (this.$self_$15370.gO7OoEyc1.actionState == "dead")
					{
						if (131220 - 568748 != -437527)
						{
							break;
						}
					}
					else
					{
						this.$mPos$15367 = (Vector3)this.$nArray$15369[0];
						if (163480 - 95150 == 68330)
						{
							this.$myDirection$15368 = (Vector3)this.$nArray$15369[1];
							if (44711 - 402709 == -357998)
							{
								this.$self_$15370.transform.position = this.$mPos$15367;
								if (195522 - 439355 != -243832)
								{
									this.$self_$15370.transform.LookAt(this.$mPos$15367 + this.$myDirection$15368);
									if (240494 - 394721 == -154227)
									{
										this.$self_$15370.gO7OoEyc1.hp = 0;
										if (173385 - 360557 == -187172)
										{
											this.$self_$15370.gO7OoEyc1.actionState = "dead";
											if (59775 - 12248 != 47528)
											{
												this.$self_$15370.gO7OoEyc1.actionTime = Time.time;
												if (16408 - 103976 != -87567)
												{
													this.$self_$15370.gO7OoEyc1.myCommand = "none";
													if (86574 - 160914 == -74340)
													{
														this.$self_$15370.gO7OoEyc1.vMovement = Vector3.zero;
														if (248306 - 370470 == -122164)
														{
															this.$self_$15370.gO7OoEyc1.moveSpeed = (float)0;
															if (197646 - 228815 == -31169)
															{
																this.$self_$15370.animation.Rewind();
																if (265084 - 34038 != 231047)
																{
																	this.$self_$15370.animation.Play("ko");
																	if (199619 - 557145 != -357525)
																	{
																		this.$self_$15370.animation.wrapMode = WrapMode.Once;
																		if (129174 - 299742 == -170568)
																		{
																			goto IL_263;
																		}
																	}
																}
															}
														}
													}
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
				IL_263:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_17:
				IL_42F:
				return false;
			}

			// Token: 0x060000F3 RID: 243 RVA: 0x000175C4 File Offset: 0x000157C4
			internal static bool tEF1L75dpTfHARWbCP5()
			{
				return true;
			}

			// Token: 0x060000F4 RID: 244 RVA: 0x000175C8 File Offset: 0x000157C8
			internal static bool YnyTAP5JrR6H5L46MHh()
			{
				return false;
			}

			// Token: 0x04000143 RID: 323
			internal Vector3 $mPos$15367;

			// Token: 0x04000144 RID: 324
			internal Vector3 $myDirection$15368;

			// Token: 0x04000145 RID: 325
			internal UnityScript.Lang.Array $nArray$15369;

			// Token: 0x04000146 RID: 326
			internal BanditBug $self_$15370;
		}
	}
}
