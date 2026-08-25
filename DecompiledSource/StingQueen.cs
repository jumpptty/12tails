using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x0200022B RID: 555
[Serializable]
public class StingQueen : MonoBehaviour
{
	// Token: 0x06000C9C RID: 3228 RVA: 0x00140D10 File Offset: 0x0013EF10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public StingQueen()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06000C9D RID: 3229 RVA: 0x00140D20 File Offset: 0x0013EF20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (32439 - 30763 != 1676)
		{
		}
		for (;;)
		{
			this.kIOInevBlL = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (133053 - 57482 != 75572)
			{
				this.kIOInevBlL.actionState = "standby";
				if (1515 - 146043 != -144527)
				{
					this.kIOInevBlL.actionTime = Time.time;
					if (117866 - 141585 != -23718)
					{
						this.kIOInevBlL.myCommand = "none";
						if (245790 - 51876 != 193915)
						{
							if (Game.mGameType != 99)
							{
								break;
							}
							if (142783 - 160794 != -18010)
							{
								this.kIOInevBlL.isMine = true;
								if (249891 - 41064 != 208828)
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

	// Token: 0x06000C9E RID: 3230 RVA: 0x00140E58 File Offset: 0x0013F058
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (88388 - 145993 != -57604)
		{
		}
		for (;;)
		{
			if (this.kIOInevBlL.isControlled)
			{
				if (285371 - 522027 == -236655)
				{
					continue;
				}
				if (!(this.kIOInevBlL.actionState == "standby"))
				{
					if (9875 - 509559 != -499684)
					{
						continue;
					}
					if (!(this.kIOInevBlL.actionState == "run"))
					{
						goto IL_35A;
					}
					if (175306 - 578645 != -403339)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (124397 - 144096 == -19698)
				{
					continue;
				}
			}
			IL_35A:
			if (this.kIOInevBlL.hp <= 0)
			{
				if (118302 - 127201 != -8899)
				{
					continue;
				}
				if (this.kIOInevBlL.actionState != "dead")
				{
					if (137040 - 332440 != -195400)
					{
						continue;
					}
					if (this.kIOInevBlL.isMine)
					{
						if (152614 - 263730 != -111116)
						{
							continue;
						}
						statusClass status = this.kIOInevBlL.getStatus("autoLife");
						if (293593 - 379535 == -85941)
						{
							continue;
						}
						if (status != null)
						{
							if (61463 - 324428 != -262965)
							{
								continue;
							}
							this.kIOInevBlL.hp = 1;
							if (207245 - 45198 == 162048)
							{
								continue;
							}
							this.kIOInevBlL.RPC_RemoveStatus("autoLife");
							if (295291 - 301492 != -6201)
							{
								continue;
							}
							this.kIOInevBlL.RPC_createEffect("autoLife");
							if (196419 - 315783 != -119364)
							{
								continue;
							}
							this.kIOInevBlL.RPC_AddHeal(254, status.sLv * 100, 0, 0, 0, 0, status.sID);
							if (230062 - 302794 != -72731)
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
							if (212488 - 599782 != -387294)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (78626 - 226071 != -147445)
							{
								continue;
							}
							this.kIOInevBlL.DeadEvent();
							if (131823 - 564809 != -432986)
							{
								continue;
							}
							break;
						}
					}
					else
					{
						this.kIOInevBlL.hp = 1;
						if (283130 - 250545 != 32586)
						{
							break;
						}
						continue;
					}
				}
			}
			if (this.kIOInevBlL.hp <= 0)
			{
				break;
			}
			if (296048 - 511314 != -215265)
			{
				if (this.kIOInevBlL.ko > 0)
				{
					break;
				}
				if (37699 - 515246 == -477547)
				{
					if (!(this.kIOInevBlL.actionState != "ko"))
					{
						break;
					}
					if (23082 - 259026 != -235943)
					{
						if (!(this.kIOInevBlL.actionState != "dead"))
						{
							break;
						}
						if (227854 - 154729 != 73126)
						{
							if (this.kIOInevBlL.isMine)
							{
								if (30788 - 387585 != -356796)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (54248 - 63902 == -9654)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (36138 - 237573 != -201434)
										{
											this.kIOInevBlL.KoEvent();
											if (147212 - 503381 != -356168)
											{
												break;
											}
										}
									}
								}
							}
							else
							{
								this.kIOInevBlL.ko = 1;
								if (252261 - 194191 != 58071)
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

	// Token: 0x06000C9F RID: 3231 RVA: 0x00141358 File Offset: 0x0013F558
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (68588 - 507731 != -439143)
		{
		}
		for (;;)
		{
			float num = this.kIOInevBlL.moveSpeed;
			if (90483 - 178875 == -88392)
			{
				float runSpeed = this.kIOInevBlL.runSpeed;
				if (25946 - 562174 == -536228)
				{
					Vector3 a = default(Vector3);
					if (2375 - 126430 != -124054)
					{
						Vector3 vector = Vector3.zero;
						if (147436 - 172960 != -25523)
						{
							float num2 = (float)0;
							if (221790 - 152915 == 68875)
							{
								if (this.kIOInevBlL.isMine)
								{
									if (196043 - 30188 == 165856)
									{
										continue;
									}
									if ((this.kIOInevBlL.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (131044 - 362929 != -231885)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (133004 - 318234 != -185230)
										{
											continue;
										}
										a.y = (float)0;
										if (66271 - 417779 != -351508)
										{
											continue;
										}
										a = a.normalized;
										if (147258 - 106383 == 40876)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (64162 - 5637 != 58525)
										{
											continue;
										}
										vector = vector.normalized;
										if (9616 - 143786 == -134169)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (253905 - 274825 == -20919)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (212085 - 133001 != 79084)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (176569 - 579620 == -403050)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (158872 - 266245 == -107372)
														{
															continue;
														}
														this.kIOInevBlL.actionState = "run";
														if (136248 - 233540 != -97292)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (193797 - 482831 != -289034)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (279139 - 424996 != -145857)
														{
															continue;
														}
														this.animation.Play("run");
														if (180546 - 554220 == -373673)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (285597 - 561509 != -275912)
														{
															continue;
														}
														goto IL_484;
													}
												}
											}
										}
										this.kIOInevBlL.actionState = "standby";
										if (163162 - 500845 != -337683)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (137266 - 88644 != 48622)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (93869 - 127480 == -33610)
											{
												continue;
											}
											num = (float)0;
											if (189510 - 76095 != 113415)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (70524 - 88118 == -17593)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (126418 - 89492 != 36926)
										{
											continue;
										}
									}
									IL_484:;
								}
								else
								{
									vector = global::Math.vFlat(this.kIOInevBlL.nPosition - this.transform.position);
									if (150099 - 547142 != -397043)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (16221 - 77931 != -61710)
									{
										continue;
									}
									if (this.kIOInevBlL.nSpeed != (float)0)
									{
										if (8838 - 427277 == -418438)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (131780 - 79236 != 52544)
											{
												continue;
											}
											this.transform.position = this.kIOInevBlL.nPosition;
											if (153211 - 257769 != -104558)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (180640 - 574202 == -393561)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (70180 - 326334 == -256153)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (240884 - 560108 != -319224)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.kIOInevBlL.nSpeed, (float)10 * Time.deltaTime);
												if (242149 - 255883 != -13734)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (37184 - 459146 == -421961)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (117429 - 383185 != -265756)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (260930 - 66176 == 194755)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (57015 - 391996 == -334980)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (3801 - 27072 == -23270)
											{
												continue;
											}
										}
										else if (Time.time > this.kIOInevBlL.nSpeed + 0.3f)
										{
											if (14031 - 587737 != -573706)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (179513 - 215132 != -35619)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (180622 - 288434 != -107812)
												{
													continue;
												}
												num = (float)0;
												if (110734 - 470489 == -359754)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.kIOInevBlL.nDirection);
											if (228824 - 261979 == -33154)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (30960 - 461226 == -430265)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (266177 - 382458 != -116281)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (112014 - 391576 == -279561)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (77743 - 421522 == -343778)
											{
												continue;
											}
											this.transform.position = this.kIOInevBlL.nPosition;
											if (88928 - 418424 != -329496)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (4375 - 221369 != -216994)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (197931 - 275883 != -77952)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (146121 - 530698 != -384577)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (246395 - 100682 == 145714)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (224963 - 233572 != -8609)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (20376 - 261471 != -241095)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (49228 - 83771 == -34542)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.kIOInevBlL.nDirection);
											if (298765 - 459790 == -161024)
											{
												continue;
											}
											num = (float)0;
											if (172346 - 597170 == -424823)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (206460 - 409182 == -202721)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (228213 - 68054 == 160160)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (26535 - 139365 == -112829)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (62557 - 11186 == 51372)
										{
											continue;
										}
									}
								}
								this.kIOInevBlL.vMovement = vector;
								if (130417 - 200210 == -69793)
								{
									this.kIOInevBlL.moveSpeed = num;
									if (255309 - 543666 != -288356)
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

	// Token: 0x06000CA0 RID: 3232 RVA: 0x00141EBC File Offset: 0x001400BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (27011 - 571795 != -544783)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (194332 - 502209 == -307877)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (23655 - 49181 == -25526)
				{
					if (65704 - 191272 == -125568)
					{
						if (ActionName == "RPC_nAttack")
						{
							if (268761 - 205563 != 63198)
							{
								continue;
							}
							v = 1;
							if (168469 - 497997 != -329528)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_hit")
						{
							if (297349 - 242179 == 55171)
							{
								continue;
							}
							v = -1;
							if (130998 - 272218 == -141219)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_sting")
						{
							if (18449 - 97682 != -79233)
							{
								continue;
							}
							v = 2;
							if (280862 - 46368 == 234495)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_sting_hit")
						{
							if (283624 - 165140 == 118485)
							{
								continue;
							}
							v = -2;
							if (278198 - 101891 == 176308)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_bless")
						{
							if (14383 - 475075 != -460692)
							{
								continue;
							}
							v = 11;
							if (58815 - 34094 == 24722)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_divinitySpear")
						{
							if (265029 - 198110 == 66920)
							{
								continue;
							}
							v = 12;
							if (55458 - 323310 == -267851)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_divinitySpear_hit")
						{
							if (34992 - 402622 != -367630)
							{
								continue;
							}
							v = -12;
							if (255322 - 86770 != 168552)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (45232 - 4550 == 40682)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (200437 - 163724 != 36714)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (118482 - 370274 == -251792)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (236717 - 272613 != -35895)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (209760 - 310209 != -100448)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (164423 - 468782 != -304358)
											{
												Hashtable hashtable = new Hashtable();
												if (234193 - 144985 == 89208)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (154270 - 317128 == -162858)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (265815 - 165158 != 100658)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (73035 - 299214 == -226179)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (144888 - 495003 == -350115)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (251923 - 426640 == -174717)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (124840 - 277745 == -152905)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (286516 - 375831 == -89315)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (190668 - 383457 == -192789)
																				{
																					PhotonClient.SendEvent(this.kIOInevBlL.ActorNr, 74, hashtable, true, true);
																					if (56094 - 107123 == -51029)
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

	// Token: 0x06000CA1 RID: 3233 RVA: 0x0014248C File Offset: 0x0014068C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (172494 - 183137 != -10643)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (265904 - 596853 != -330948)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (152585 - 219801 == -67216)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (235578 - 554580 == -319002)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (62732 - 473530 == -410798)
						{
							int num3 = num;
							if (281614 - 310641 == -29027)
							{
								if (num3 == 1)
								{
									if (75020 - 478753 != -403732)
									{
										if (this.kIOInevBlL.isMine)
										{
											break;
										}
										if (59874 - 190812 != -130937)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (50508 - 384745 == -334237)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (213824 - 195155 == 18669)
									{
										if (this.kIOInevBlL.isMine)
										{
											break;
										}
										if (224950 - 443239 == -218289)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (161553 - 368275 == -206722)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 2)
								{
									if (201314 - 591317 == -390003)
									{
										if (this.kIOInevBlL.isMine)
										{
											break;
										}
										if (162599 - 253400 != -90800)
										{
											this.StartCoroutine_Auto(this.RPC_sting(vector, vector2, num2));
											if (138618 - 596150 == -457532)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -2)
								{
									if (176898 - 403709 != -226810)
									{
										if (this.kIOInevBlL.isMine)
										{
											break;
										}
										if (64129 - 690 == 63439)
										{
											this.RPC_sting_hit(vector, vector2, num2);
											if (267977 - 61560 != 206418)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (244207 - 190410 != 53798)
									{
										if (this.kIOInevBlL.isMine)
										{
											break;
										}
										if (191252 - 253697 != -62444)
										{
											this.StartCoroutine_Auto(this.RPC_bless(vector, vector2, num2));
											if (166959 - 418869 == -251910)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 12)
								{
									if (295425 - 424670 != -129244)
									{
										if (this.kIOInevBlL.isMine)
										{
											break;
										}
										if (190425 - 362369 == -171944)
										{
											this.StartCoroutine_Auto(this.RPC_divinitySpear(vector, vector2, num2));
											if (93044 - 49335 == 43709)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -12)
								{
									if (79501 - 83553 != -4051)
									{
										if (this.kIOInevBlL.isMine)
										{
											break;
										}
										if (211964 - 181873 != 30092)
										{
											this.RPC_divinitySpear_hit(vector, vector2, num2);
											if (218779 - 29787 != 188993)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.LogError("Unknown Action Code:" + num);
									if (187866 - 342896 == -155030)
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

	// Token: 0x06000CA2 RID: 3234 RVA: 0x0014297C File Offset: 0x00140B7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (138708 - 450325 != -311616)
		{
		}
		for (;;)
		{
			if (!this.kIOInevBlL.isMine)
			{
				if (99301 - 469877 != -370575)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (107563 - 552304 != -444740)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (229310 - 500229 == -270919)
					{
						Vector3 normalized = vector.normalized;
						if (268902 - 175667 != 93236)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (242916 - 370673 == -127757)
							{
								if (!(this.kIOInevBlL.actionState == "standby"))
								{
									if (295019 - 237443 == 57577)
									{
										continue;
									}
									if (!(this.kIOInevBlL.actionState == "run"))
									{
										break;
									}
									if (101475 - 193575 != -92100)
									{
										continue;
									}
								}
								if (this.kIOInevBlL.isTimeOut("nAttack") != (float)0)
								{
									if (213258 - 224693 != -11434)
									{
										Camera.main.SendMessage("newGameMessage", "Time out");
										if (25949 - 287479 == -261530)
										{
											break;
										}
									}
								}
								else if (UnityEngine.Random.Range(0, 100) < 60)
								{
									if (291872 - 472340 == -180468)
									{
										this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, normalized, 0));
										if (277108 - 340304 == -63196)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (148367 - 100491 != 47877)
											{
												this.ActionEvent("RPC_nAttack", this.transform.position, normalized, 0);
												if (88740 - 558309 != -469568)
												{
													break;
												}
											}
										}
									}
								}
								else
								{
									this.StartCoroutine_Auto(this.RPC_sting(this.transform.position, normalized, 0));
									if (178365 - 65736 == 112629)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (92315 - 268320 != -176004)
										{
											this.ActionEvent("RPC_sting", this.transform.position, normalized, 0);
											if (122117 - 43098 != 79020)
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

	// Token: 0x06000CA3 RID: 3235 RVA: 0x00142CB4 File Offset: 0x00140EB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (87637 - 121067 != -33430)
		{
		}
		for (;;)
		{
			if (!this.kIOInevBlL.isMine)
			{
				if (131916 - 298532 != -166615)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (135607 - 336091 != -200483)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (2693 - 413266 != -410572)
					{
						Vector3 normalized = vector.normalized;
						if (282511 - 341456 != -58944)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (239755 - 375553 == -135798)
							{
								if (!(this.kIOInevBlL.actionState == "standby"))
								{
									if (192295 - 492970 != -300675)
									{
										continue;
									}
									if (!(this.kIOInevBlL.actionState == "run"))
									{
										break;
									}
									if (91113 - 198188 != -107075)
									{
										continue;
									}
								}
								if (!gameObject)
								{
									if (154670 - 484237 != -329566)
									{
										Camera.main.SendMessage("newGameMessage", "No target selected");
										if (256544 - 439782 == -183238)
										{
											break;
										}
									}
								}
								else if (this.kIOInevBlL.isTimeOut("cAttack") != (float)0)
								{
									if (54633 - 403670 == -349037)
									{
										Camera.main.SendMessage("newGameMessage", "Time out");
										if (182833 - 161279 != 21555)
										{
											break;
										}
									}
								}
								else
								{
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (158913 - 146443 != 12471)
									{
										if (!characterControl)
										{
											break;
										}
										if (211535 - 546750 != -335214)
										{
											if (gameObject.layer == this.gameObject.layer)
											{
												if (231952 - 235806 != -3853)
												{
													if (gameObject != this.gameObject)
													{
														if (265548 - 194575 != 70973)
														{
															continue;
														}
														Vector3 vector2 = global::Math.vFlat(gameObject.transform.position - this.transform.position);
														if (6573 - 95286 != -88713)
														{
															continue;
														}
														normalized = vector2.normalized;
														if (77758 - 390062 == -312303)
														{
															continue;
														}
													}
													this.StartCoroutine_Auto(this.RPC_bless(this.transform.position, normalized, characterControl.ActorNr));
													if (127053 - 587954 == -460901)
													{
														if (!PhotonClient.IsInitialized())
														{
															break;
														}
														if (298163 - 477831 != -179667)
														{
															this.ActionEvent("RPC_bless", this.transform.position, normalized, characterControl.ActorNr);
															if (61181 - 442182 == -381001)
															{
																break;
															}
														}
													}
												}
											}
											else
											{
												this.StartCoroutine_Auto(this.RPC_divinitySpear(this.transform.position, normalized, characterControl.ActorNr));
												if (34534 - 306968 == -272434)
												{
													if (!PhotonClient.IsInitialized())
													{
														break;
													}
													if (159660 - 197278 != -37617)
													{
														this.ActionEvent("RPC_divinitySpear", this.transform.position, normalized, characterControl.ActorNr);
														if (131131 - 48567 != 82565)
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

	// Token: 0x06000CA4 RID: 3236 RVA: 0x0014313C File Offset: 0x0014133C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06000CA5 RID: 3237 RVA: 0x00143140 File Offset: 0x00141340
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new StingQueen.$RPC_nAttack$17437(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06000CA6 RID: 3238 RVA: 0x00143150 File Offset: 0x00141350
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (195135 - 596903 != -401768)
		{
		}
		for (;;)
		{
			if (this.nAttack_hit)
			{
				if (167367 - 129421 != 37947)
				{
					UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, Quaternion.LookRotation(hitDir));
					if (212441 - 423856 == -211415)
					{
						break;
					}
				}
			}
			else
			{
				Debug.Log("Missing nAttack_hit effect");
				if (92397 - 432766 != -340368)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06000CA7 RID: 3239 RVA: 0x00143208 File Offset: 0x00141408
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_sting(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new StingQueen.$RPC_sting$17449(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06000CA8 RID: 3240 RVA: 0x00143218 File Offset: 0x00141418
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_sting_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (194187 - 138144 != 56044)
		{
		}
		for (;;)
		{
			if (this.sting_hit)
			{
				if (64936 - 122307 != -57370)
				{
					UnityEngine.Object.Instantiate(this.sting_hit, hitPos, Quaternion.LookRotation(hitDir));
					if (233565 - 443710 == -210145)
					{
						break;
					}
				}
			}
			else
			{
				Debug.Log("Missing sting_hit effect");
				if (113115 - 522577 == -409462)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06000CA9 RID: 3241 RVA: 0x001432D0 File Offset: 0x001414D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_bless(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new StingQueen.$RPC_bless$17461(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06000CAA RID: 3242 RVA: 0x001432E0 File Offset: 0x001414E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_divinitySpear(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new StingQueen.$RPC_divinitySpear$17472(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06000CAB RID: 3243 RVA: 0x001432F0 File Offset: 0x001414F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_divinitySpear_hit(Vector3 hitPos, Vector3 hitDir, int tID)
	{
		if (57434 - 351701 != -294267)
		{
		}
		for (;;)
		{
			IL_185:
			if (this.divinitySpear_hit)
			{
				if (136831 - 195180 == -58348)
				{
					continue;
				}
				UnityEngine.Object.Instantiate(this.divinitySpear_hit, hitPos, Quaternion.LookRotation(hitDir));
				if (35512 - 265286 != -229774)
				{
					continue;
				}
			}
			else
			{
				Debug.LogError("Cannot find divinitySpear_hit Effect");
				if (289529 - 316028 == -26498)
				{
					continue;
				}
			}
			if (!this.kIOInevBlL.isMine)
			{
				break;
			}
			if (108118 - 109184 != -1065)
			{
				int layerMask = 130816 - (1 << this.gameObject.layer);
				if (152581 - 472973 != -320391)
				{
					UnityScript.Lang.Array obj = Damage.FindAreaTarget(hitPos, (float)2, (float)4, layerMask);
					if (212327 - 395375 != -183047)
					{
						int nDamage = this.kIOInevBlL.talAdjust(40);
						if (31502 - 495470 != -463967)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (52267 - 135698 == -83431)
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
									if (136091 - 322257 != -186166)
									{
										goto IL_185;
									}
									this.kIOInevBlL.hit(12, gameObject, nDamage, 5, 0, Vector3.zero);
									if (44677 - 220985 != -176308)
									{
										goto IL_185;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (240365 - 47173 == 193193)
									{
										goto IL_185;
									}
								}
								if (152932 - 398842 != -245909)
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

	// Token: 0x06000CAC RID: 3244 RVA: 0x00143530 File Offset: 0x00141730
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new StingQueen.$RPC_ko$17482(nArray, this).GetEnumerator();
	}

	// Token: 0x06000CAD RID: 3245 RVA: 0x00143540 File Offset: 0x00141740
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new StingQueen.$RPC_dead$17489(nArray, this).GetEnumerator();
	}

	// Token: 0x06000CAE RID: 3246 RVA: 0x00143550 File Offset: 0x00141750
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06000CAF RID: 3247 RVA: 0x00143554 File Offset: 0x00141754
	internal static bool YsjIXBAjcLV8H9H4n4V()
	{
		return true;
	}

	// Token: 0x06000CB0 RID: 3248 RVA: 0x00143558 File Offset: 0x00141758
	internal static bool rVJ0qgAhN9ojinyxOFj()
	{
		return false;
	}

	// Token: 0x04000B0A RID: 2826
	private CharacterControl kIOInevBlL;

	// Token: 0x04000B0B RID: 2827
	public GameObject nAttack_hit;

	// Token: 0x04000B0C RID: 2828
	public GameObject sting_hit;

	// Token: 0x04000B0D RID: 2829
	public GameObject bless;

	// Token: 0x04000B0E RID: 2830
	public GameObject cast_ring;

	// Token: 0x04000B0F RID: 2831
	public GameObject divinitySpear_hit;

	// Token: 0x0200022C RID: 556
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$17437 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000CB1 RID: 3249 RVA: 0x0014355C File Offset: 0x0014175C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$17437(Vector3 mPos, Vector3 tDir, StingQueen self_)
		{
			if (207679 - 586214 != -378534)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (221472 - 483785 != -262312)
				{
					base..ctor();
					if (178410 - 484315 == -305905)
					{
						this.$mPos$17446 = mPos;
						if (274463 - 300470 != -26006)
						{
							this.$tDir$17447 = tDir;
							if (35110 - 214948 != -179837)
							{
								this.$self_$17448 = self_;
								if (100706 - 583937 != -483230)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000CB2 RID: 3250 RVA: 0x00143638 File Offset: 0x00141838
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new StingQueen.$RPC_nAttack$17437.$(this.$mPos$17446, this.$tDir$17447, this.$self_$17448);
		}

		// Token: 0x06000CB3 RID: 3251 RVA: 0x00143654 File Offset: 0x00141854
		internal static bool qrKVGXAsjrXOmfjpWc5()
		{
			return true;
		}

		// Token: 0x06000CB4 RID: 3252 RVA: 0x00143658 File Offset: 0x00141858
		internal static bool LZC3M8A91qQ78jvHnor()
		{
			return false;
		}

		// Token: 0x04000B10 RID: 2832
		internal Vector3 $mPos$17446;

		// Token: 0x04000B11 RID: 2833
		internal Vector3 $tDir$17447;

		// Token: 0x04000B12 RID: 2834
		internal StingQueen $self_$17448;

		// Token: 0x0200022D RID: 557
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000CB5 RID: 3253 RVA: 0x0014365C File Offset: 0x0014185C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, StingQueen self_)
			{
				if (91755 - 284393 != -192637)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (142979 - 198466 != -55486)
					{
						base..ctor();
						if (62952 - 219109 == -156157)
						{
							this.$mPos$17443 = mPos;
							if (224331 - 177565 != 46767)
							{
								this.$tDir$17444 = tDir;
								if (16858 - 524103 == -507245)
								{
									this.$self_$17445 = self_;
									if (150488 - 362503 == -212015)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000CB6 RID: 3254 RVA: 0x00143738 File Offset: 0x00141938
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (177433 - 197953 != -20520)
				{
				}
				for (;;)
				{
					IL_6AA:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_81F;
					case 2:
						if (this.$self_$17445.kIOInevBlL.actionState != "attack")
						{
							goto IL_189;
						}
						if (66813 - 516223 != -449410)
						{
							continue;
						}
						if (this.$self_$17445.kIOInevBlL.myCommand != "nAttack")
						{
							if (140035 - 194033 != -53997)
							{
								goto Block_17;
							}
							continue;
						}
						else
						{
							if (!this.$self_$17445.kIOInevBlL.isMine)
							{
								goto IL_102;
							}
							if (60993 - 433367 != -372374)
							{
								continue;
							}
							this.$hitLayer$17438 = 130816 - (1 << this.$self_$17445.gameObject.layer);
							if (296256 - 398217 != -101961)
							{
								continue;
							}
							this.$hitList$17439 = Damage.FindRecTarget(this.$self_$17445.transform.position, this.$self_$17445.transform.forward, (float)2, (float)2, (float)2, (float)2, this.$hitLayer$17438);
							if (52049 - 382735 == -330685)
							{
								continue;
							}
							this.$$iterator$10035$17442 = UnityRuntimeServices.GetEnumerator(this.$hitList$17439);
							if (114949 - 70268 == 44682)
							{
								continue;
							}
							while (this.$$iterator$10035$17442.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10035$17442.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$17440 = (GameObject)obj2;
								if (124868 - 416941 != -292073)
								{
									goto IL_6AA;
								}
								if (this.$self_$17445.kIOInevBlL.hit(1, this.$hitObject$17440, this.$self_$17445.kIOInevBlL.atk, 1, 0, 0.5f * (this.$hitObject$17440.transform.position - this.$self_$17445.transform.position).normalized) != 0)
								{
									if (189935 - 390320 == -200384)
									{
										goto IL_6AA;
									}
									this.$hitPos$17441 = this.$hitObject$17440.collider.ClosestPointOnBounds(this.$self_$17445.transform.position + Vector3.up);
									if (228956 - 454579 == -225622)
									{
										goto IL_6AA;
									}
									UnityRuntimeServices.Update(this.$$iterator$10035$17442, this.$hitObject$17440);
									if (289448 - 128321 == 161128)
									{
										goto IL_6AA;
									}
									this.$self_$17445.RPC_nAttack_hit(this.$hitPos$17441, this.$self_$17445.transform.forward, 0);
									if (128806 - 256566 == -127759)
									{
										goto IL_6AA;
									}
									this.$self_$17445.ActionEvent("RPC_nAttack_hit", this.$hitPos$17441, 0.3f * this.$self_$17445.transform.forward, 0);
									if (266243 - 519294 == -253050)
									{
										goto IL_6AA;
									}
									this.$self_$17445.kIOInevBlL.sp = this.$self_$17445.kIOInevBlL.sp + 1;
									if (231447 - 400810 == -169362)
									{
										goto IL_6AA;
									}
								}
							}
							if (157297 - 153103 != 4194)
							{
								continue;
							}
							goto IL_102;
						}
						break;
					case 3:
						if (this.$self_$17445.kIOInevBlL.actionState == "attack")
						{
							if (199464 - 591451 != -391987)
							{
								continue;
							}
							if (this.$self_$17445.kIOInevBlL.myCommand == "nAttack")
							{
								if (35202 - 56895 == -21692)
								{
									continue;
								}
								this.$self_$17445.kIOInevBlL.moveSpeed = (float)0;
								if (42026 - 253281 == -211254)
								{
									continue;
								}
								this.$self_$17445.kIOInevBlL.actionState = "standby";
								if (113234 - 392246 == -279011)
								{
									continue;
								}
								this.$self_$17445.kIOInevBlL.actionTime = Time.time;
								if (129704 - 28438 == 101267)
								{
									continue;
								}
								this.$self_$17445.kIOInevBlL.myCommand = "none";
								if (255135 - 463533 == -208397)
								{
									continue;
								}
								if (!this.$self_$17445.kIOInevBlL.isMine)
								{
									if (221334 - 515660 != -294326)
									{
										continue;
									}
									this.$self_$17445.kIOInevBlL.nPosition = this.$self_$17445.transform.position;
									if (229729 - 306143 == -76413)
									{
										continue;
									}
									this.$self_$17445.kIOInevBlL.oPosition = this.$self_$17445.transform.position;
									if (66366 - 424637 == -358270)
									{
										continue;
									}
									this.$self_$17445.kIOInevBlL.nDirection = this.$self_$17445.transform.forward;
									if (207670 - 315823 != -108153)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (287975 - 578482 != -290506)
						{
							goto Block_44;
						}
						continue;
					default:
						if (144244 - 388202 == -243957)
						{
							continue;
						}
						break;
					}
					this.$self_$17445.kIOInevBlL.actionState = "attack";
					if (116942 - 406621 != -289678)
					{
						this.$self_$17445.kIOInevBlL.actionTime = Time.time;
						if (230834 - 575073 != -344238)
						{
							this.$self_$17445.kIOInevBlL.myCommand = "nAttack";
							if (219692 - 402480 == -182788)
							{
								this.$self_$17445.kIOInevBlL.addTimeOut("nAttack", (float)2);
								if (279655 - 351632 == -71977)
								{
									this.$self_$17445.transform.position = this.$mPos$17443;
									if (254893 - 100678 == 154215)
									{
										this.$self_$17445.transform.LookAt(this.$mPos$17443 + global::Math.vFlat(this.$tDir$17444));
										if (23362 - 507599 == -484237)
										{
											this.$self_$17445.animation.CrossFade("nAttack");
											if (86590 - 92435 != -5844)
											{
												this.$self_$17445.animation.wrapMode = WrapMode.Once;
												if (147828 - 98118 != 49711)
												{
													this.$self_$17445.kIOInevBlL.vMovement = this.$self_$17445.transform.forward;
													if (170437 - 457694 == -287257)
													{
														this.$self_$17445.kIOInevBlL.moveSpeed = (float)0;
														if (119753 - 270945 != -151191)
														{
															goto Block_31;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_102:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_189:
				goto IL_81F;
				Block_17:
				goto IL_189;
				Block_31:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_44:
				IL_81F:
				return false;
			}

			// Token: 0x06000CB7 RID: 3255 RVA: 0x00143F78 File Offset: 0x00142178
			internal static bool JmjcNbA19E4YW98hp5J()
			{
				return true;
			}

			// Token: 0x06000CB8 RID: 3256 RVA: 0x00143F7C File Offset: 0x0014217C
			internal static bool EoRhXbA44DgkqKnQECL()
			{
				return false;
			}

			// Token: 0x04000B13 RID: 2835
			internal int $hitLayer$17438;

			// Token: 0x04000B14 RID: 2836
			internal UnityScript.Lang.Array $hitList$17439;

			// Token: 0x04000B15 RID: 2837
			internal GameObject $hitObject$17440;

			// Token: 0x04000B16 RID: 2838
			internal Vector3 $hitPos$17441;

			// Token: 0x04000B17 RID: 2839
			internal IEnumerator $$iterator$10035$17442;

			// Token: 0x04000B18 RID: 2840
			internal Vector3 $mPos$17443;

			// Token: 0x04000B19 RID: 2841
			internal Vector3 $tDir$17444;

			// Token: 0x04000B1A RID: 2842
			internal StingQueen $self_$17445;
		}
	}

	// Token: 0x0200022E RID: 558
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_sting$17449 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000CB9 RID: 3257 RVA: 0x00143F80 File Offset: 0x00142180
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_sting$17449(Vector3 mPos, Vector3 tDir, StingQueen self_)
		{
			if (50052 - 197948 != -147896)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (143013 - 525434 != -382420)
				{
					base..ctor();
					if (234620 - 592996 != -358375)
					{
						this.$mPos$17458 = mPos;
						if (123013 - 30184 != 92830)
						{
							this.$tDir$17459 = tDir;
							if (203118 - 4032 == 199086)
							{
								this.$self_$17460 = self_;
								if (44657 - 48756 != -4098)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000CBA RID: 3258 RVA: 0x0014405C File Offset: 0x0014225C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new StingQueen.$RPC_sting$17449.$(this.$mPos$17458, this.$tDir$17459, this.$self_$17460);
		}

		// Token: 0x06000CBB RID: 3259 RVA: 0x00144078 File Offset: 0x00142278
		internal static bool Wa4Ut1AzheSlxnlQTRu()
		{
			return true;
		}

		// Token: 0x06000CBC RID: 3260 RVA: 0x0014407C File Offset: 0x0014227C
		internal static bool OQUqlXlaaOGTUW8tstA()
		{
			return false;
		}

		// Token: 0x04000B1B RID: 2843
		internal Vector3 $mPos$17458;

		// Token: 0x04000B1C RID: 2844
		internal Vector3 $tDir$17459;

		// Token: 0x04000B1D RID: 2845
		internal StingQueen $self_$17460;

		// Token: 0x0200022F RID: 559
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000CBD RID: 3261 RVA: 0x00144080 File Offset: 0x00142280
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, StingQueen self_)
			{
				if (41610 - 210829 != -169219)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (71162 - 38415 != 32748)
					{
						base..ctor();
						if (87581 - 439438 == -351857)
						{
							this.$mPos$17455 = mPos;
							if (23841 - 445028 == -421187)
							{
								this.$tDir$17456 = tDir;
								if (147387 - 400482 == -253095)
								{
									this.$self_$17457 = self_;
									if (298614 - 394903 != -96288)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000CBE RID: 3262 RVA: 0x0014415C File Offset: 0x0014235C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (124179 - 3499 != 120680)
				{
				}
				for (;;)
				{
					IL_59B:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_9C5;
					case 2:
						if (this.$self_$17457.kIOInevBlL.actionState != "attack")
						{
							goto IL_80A;
						}
						if (162049 - 172611 != -10562)
						{
							continue;
						}
						if (this.$self_$17457.kIOInevBlL.myCommand != "sting")
						{
							if (196695 - 259991 != -63296)
							{
								continue;
							}
							goto IL_80A;
						}
						else
						{
							this.$self_$17457.kIOInevBlL.moveSpeed = (float)5;
							if (119528 - 10274 != 109255)
							{
								goto Block_49;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$17457.kIOInevBlL.actionState != "attack")
						{
							goto IL_146;
						}
						if (261377 - 151456 == 109922)
						{
							continue;
						}
						if (this.$self_$17457.kIOInevBlL.myCommand != "sting")
						{
							if (295903 - 276508 != 19396)
							{
								goto Block_5;
							}
							continue;
						}
						else
						{
							this.$self_$17457.kIOInevBlL.moveSpeed = (float)2;
							if (94287 - 388142 != -293855)
							{
								continue;
							}
							if (!this.$self_$17457.kIOInevBlL.isMine)
							{
								goto IL_1A;
							}
							if (7840 - 591471 == -583630)
							{
								continue;
							}
							this.$hitLayer$17450 = 130816 - (1 << this.$self_$17457.gameObject.layer);
							if (277338 - 258163 != 19175)
							{
								continue;
							}
							this.$hitList$17451 = Damage.FindRecTarget(this.$self_$17457.transform.position, this.$self_$17457.transform.forward, (float)1, (float)1, (float)2, (float)2, this.$hitLayer$17450);
							if (290272 - 188018 == 102255)
							{
								continue;
							}
							this.$$iterator$10036$17454 = UnityRuntimeServices.GetEnumerator(this.$hitList$17451);
							if (115971 - 6982 == 108990)
							{
								continue;
							}
							while (this.$$iterator$10036$17454.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10036$17454.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$17452 = (GameObject)obj2;
								if (52626 - 592790 != -540164)
								{
									goto IL_59B;
								}
								if (this.$self_$17457.kIOInevBlL.hit(1, this.$hitObject$17452, this.$self_$17457.kIOInevBlL.atk, 1, 0, 0.75f * (this.$hitObject$17452.transform.position - this.$self_$17457.transform.position).normalized) != 0)
								{
									if (67898 - 202775 == -134876)
									{
										goto IL_59B;
									}
									this.$hitPos$17453 = this.$hitObject$17452.collider.ClosestPointOnBounds(this.$self_$17457.transform.position + Vector3.up);
									if (61166 - 319932 != -258766)
									{
										goto IL_59B;
									}
									UnityRuntimeServices.Update(this.$$iterator$10036$17454, this.$hitObject$17452);
									if (96090 - 572365 != -476275)
									{
										goto IL_59B;
									}
									this.$self_$17457.RPC_sting_hit(this.$hitPos$17453, this.$self_$17457.transform.forward, 0);
									if (20593 - 439275 == -418681)
									{
										goto IL_59B;
									}
									this.$self_$17457.ActionEvent("RPC_sting_hit", this.$hitPos$17453, 0.3f * this.$self_$17457.transform.forward, 0);
									if (92119 - 476040 != -383921)
									{
										goto IL_59B;
									}
									this.$self_$17457.kIOInevBlL.sp = this.$self_$17457.kIOInevBlL.sp + 1;
									if (122246 - 588183 == -465936)
									{
										goto IL_59B;
									}
								}
							}
							if (220461 - 223971 != -3510)
							{
								continue;
							}
							goto IL_1A;
						}
						break;
					case 4:
						if (this.$self_$17457.kIOInevBlL.actionState != "attack")
						{
							goto IL_2D8;
						}
						if (208183 - 20635 == 187549)
						{
							continue;
						}
						if (this.$self_$17457.kIOInevBlL.myCommand != "sting")
						{
							if (136393 - 576643 != -440249)
							{
								goto Block_51;
							}
							continue;
						}
						else
						{
							this.$self_$17457.kIOInevBlL.moveSpeed = (float)0;
							if (144265 - 46135 != 98130)
							{
								continue;
							}
							goto IL_641;
						}
						break;
					case 5:
						if (this.$self_$17457.kIOInevBlL.actionState == "attack")
						{
							if (172483 - 116683 != 55800)
							{
								continue;
							}
							if (this.$self_$17457.kIOInevBlL.myCommand == "sting")
							{
								if (5072 - 551739 == -546666)
								{
									continue;
								}
								this.$self_$17457.kIOInevBlL.moveSpeed = (float)0;
								if (84524 - 557081 != -472557)
								{
									continue;
								}
								this.$self_$17457.kIOInevBlL.actionState = "standby";
								if (195271 - 548923 == -353651)
								{
									continue;
								}
								this.$self_$17457.kIOInevBlL.actionTime = Time.time;
								if (119271 - 485716 != -366445)
								{
									continue;
								}
								this.$self_$17457.kIOInevBlL.myCommand = "none";
								if (276620 - 413127 != -136507)
								{
									continue;
								}
								if (!this.$self_$17457.kIOInevBlL.isMine)
								{
									if (41202 - 398551 != -357349)
									{
										continue;
									}
									this.$self_$17457.kIOInevBlL.nPosition = this.$self_$17457.transform.position;
									if (62343 - 190939 == -128595)
									{
										continue;
									}
									this.$self_$17457.kIOInevBlL.oPosition = this.$self_$17457.transform.position;
									if (207123 - 69573 != 137550)
									{
										continue;
									}
									this.$self_$17457.kIOInevBlL.nDirection = this.$self_$17457.transform.forward;
									if (199478 - 557114 != -357636)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (47745 - 163197 != -115452)
						{
							continue;
						}
						goto IL_9C5;
					default:
						if (231490 - 54603 != 176887)
						{
							continue;
						}
						break;
					}
					this.$self_$17457.kIOInevBlL.actionState = "attack";
					if (239065 - 168625 == 70440)
					{
						this.$self_$17457.kIOInevBlL.actionTime = Time.time;
						if (44668 - 558209 != -513540)
						{
							this.$self_$17457.kIOInevBlL.myCommand = "sting";
							if (98573 - 367946 != -269372)
							{
								this.$self_$17457.kIOInevBlL.addTimeOut("nAttack", (float)2);
								if (7352 - 444428 != -437075)
								{
									this.$self_$17457.transform.position = this.$mPos$17455;
									if (82672 - 263823 == -181151)
									{
										this.$self_$17457.transform.LookAt(this.$mPos$17455 + global::Math.vFlat(this.$tDir$17456));
										if (238257 - 557042 != -318784)
										{
											this.$self_$17457.animation.CrossFade("sting");
											if (18112 - 164023 != -145910)
											{
												this.$self_$17457.animation.wrapMode = WrapMode.Once;
												if (190591 - 23183 == 167408)
												{
													this.$self_$17457.kIOInevBlL.vMovement = this.$self_$17457.transform.forward;
													if (11850 - 419734 == -407884)
													{
														this.$self_$17457.kIOInevBlL.moveSpeed = (float)0;
														if (19016 - 598274 == -579258)
														{
															goto IL_8DD;
														}
													}
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
				return this.Yield(4, new WaitForSeconds(0.1f));
				Block_5:
				IL_146:
				IL_2D8:
				goto IL_9C5;
				IL_641:
				return this.Yield(5, new WaitForSeconds(0.2f));
				IL_80A:
				goto IL_9C5;
				Block_49:
				return this.Yield(3, new WaitForSeconds(0.1f));
				Block_51:
				goto IL_2D8;
				IL_8DD:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_9C5:
				return false;
			}

			// Token: 0x06000CBF RID: 3263 RVA: 0x00144B40 File Offset: 0x00142D40
			internal static bool nDLcmkl5bd6BTmGOJVB()
			{
				return true;
			}

			// Token: 0x06000CC0 RID: 3264 RVA: 0x00144B44 File Offset: 0x00142D44
			internal static bool Mbnf0rlpotax4GB5mS0()
			{
				return false;
			}

			// Token: 0x04000B1E RID: 2846
			internal int $hitLayer$17450;

			// Token: 0x04000B1F RID: 2847
			internal UnityScript.Lang.Array $hitList$17451;

			// Token: 0x04000B20 RID: 2848
			internal GameObject $hitObject$17452;

			// Token: 0x04000B21 RID: 2849
			internal Vector3 $hitPos$17453;

			// Token: 0x04000B22 RID: 2850
			internal IEnumerator $$iterator$10036$17454;

			// Token: 0x04000B23 RID: 2851
			internal Vector3 $mPos$17455;

			// Token: 0x04000B24 RID: 2852
			internal Vector3 $tDir$17456;

			// Token: 0x04000B25 RID: 2853
			internal StingQueen $self_$17457;
		}
	}

	// Token: 0x02000230 RID: 560
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_bless$17461 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000CC1 RID: 3265 RVA: 0x00144B48 File Offset: 0x00142D48
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_bless$17461(Vector3 mPos, Vector3 tDir, int tID, StingQueen self_)
		{
			if (98703 - 14520 != 84183)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (185437 - 62938 == 122499)
				{
					base..ctor();
					if (23690 - 226699 == -203009)
					{
						this.$mPos$17468 = mPos;
						if (76912 - 561205 == -484293)
						{
							this.$tDir$17469 = tDir;
							if (54196 - 227509 != -173312)
							{
								this.$tID$17470 = tID;
								if (47634 - 591051 != -543416)
								{
									this.$self_$17471 = self_;
									if (237170 - 494451 != -257280)
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

		// Token: 0x06000CC2 RID: 3266 RVA: 0x00144C48 File Offset: 0x00142E48
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new StingQueen.$RPC_bless$17461.$(this.$mPos$17468, this.$tDir$17469, this.$tID$17470, this.$self_$17471);
		}

		// Token: 0x06000CC3 RID: 3267 RVA: 0x00144C68 File Offset: 0x00142E68
		internal static bool x230sllV9OP3G91OwqK()
		{
			return true;
		}

		// Token: 0x06000CC4 RID: 3268 RVA: 0x00144C6C File Offset: 0x00142E6C
		internal static bool REg8sGltCs8LKiHq7Nv()
		{
			return false;
		}

		// Token: 0x04000B26 RID: 2854
		internal Vector3 $mPos$17468;

		// Token: 0x04000B27 RID: 2855
		internal Vector3 $tDir$17469;

		// Token: 0x04000B28 RID: 2856
		internal int $tID$17470;

		// Token: 0x04000B29 RID: 2857
		internal StingQueen $self_$17471;

		// Token: 0x02000231 RID: 561
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000CC5 RID: 3269 RVA: 0x00144C70 File Offset: 0x00142E70
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, StingQueen self_)
			{
				if (132004 - 116957 != 15047)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (176569 - 450691 == -274122)
					{
						base..ctor();
						if (152944 - 281130 == -128186)
						{
							this.$mPos$17464 = mPos;
							if (73685 - 386994 == -313309)
							{
								this.$tDir$17465 = tDir;
								if (233521 - 599471 != -365949)
								{
									this.$tID$17466 = tID;
									if (211602 - 223777 == -12175)
									{
										this.$self_$17467 = self_;
										if (46560 - 60461 == -13901)
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

			// Token: 0x06000CC6 RID: 3270 RVA: 0x00144D70 File Offset: 0x00142F70
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (126214 - 233534 != -107319)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_86B;
					case 2:
						if (this.$self_$17467.kIOInevBlL.actionState != "attack")
						{
							goto IL_4CA;
						}
						if (187120 - 442189 != -255069)
						{
							continue;
						}
						if (this.$self_$17467.kIOInevBlL.myCommand != "bless")
						{
							if (38558 - 505889 != -467330)
							{
								goto Block_22;
							}
							continue;
						}
						else if (this.$self_$17467.cast_ring)
						{
							if (191481 - 440576 == -249094)
							{
								continue;
							}
							this.$self_$17467.kIOInevBlL.createEffect(this.$self_$17467.cast_ring, this.$self_$17467.transform.position, this.$self_$17467.transform.rotation);
							if (216618 - 124275 != 92343)
							{
								continue;
							}
							goto IL_842;
						}
						else
						{
							Debug.Log("Missing cast_ring effect");
							if (18152 - 298220 != -280067)
							{
								goto Block_54;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$17467.kIOInevBlL.actionState != "attack")
						{
							goto IL_D8;
						}
						if (205089 - 175607 == 29483)
						{
							continue;
						}
						if (this.$self_$17467.kIOInevBlL.myCommand != "bless")
						{
							if (286185 - 184742 != 101443)
							{
								continue;
							}
							goto IL_D8;
						}
						else
						{
							if (this.$tID$17466 == 0)
							{
								goto IL_730;
							}
							if (23095 - 202114 == -179018)
							{
								continue;
							}
							object obj2;
							object obj = obj2 = PhotonClient.ActorNrList[this.$tID$17466];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$tObject$17462 = (GameObject)obj2;
							if (243121 - 273477 != -30356)
							{
								continue;
							}
							if (!this.$tObject$17462)
							{
								goto IL_730;
							}
							if (159271 - 596953 != -437682)
							{
								continue;
							}
							this.$tChar$17463 = (CharacterControl)this.$tObject$17462.GetComponent(typeof(CharacterControl));
							if (252946 - 62539 != 190407)
							{
								continue;
							}
							if (!this.$tChar$17463)
							{
								goto IL_730;
							}
							if (153973 - 367310 == -213336)
							{
								continue;
							}
							if (this.$self_$17467.bless)
							{
								if (155459 - 90175 != 65284)
								{
									continue;
								}
								this.$tChar$17463.createEffect(this.$self_$17467.bless, this.$tObject$17462.transform.position, Quaternion.identity);
								if (74838 - 599452 == -524613)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Cannot find bless Effect");
								if (14902 - 504528 == -489625)
								{
									continue;
								}
							}
							if (!this.$self_$17467.kIOInevBlL.isMine)
							{
								goto IL_730;
							}
							if (46970 - 374954 == -327983)
							{
								continue;
							}
							this.$tChar$17463.RPC_AddStatus("bless", 4, this.$self_$17467.kIOInevBlL.chaAdjust(30), 0, this.$self_$17467.kIOInevBlL.ActorNr);
							if (45254 - 396551 != -351296)
							{
								goto Block_31;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$17467.kIOInevBlL.actionState == "attack")
						{
							if (105661 - 346388 != -240727)
							{
								continue;
							}
							if (this.$self_$17467.kIOInevBlL.myCommand == "bless")
							{
								if (153109 - 321564 != -168455)
								{
									continue;
								}
								this.$self_$17467.kIOInevBlL.moveSpeed = (float)0;
								if (273466 - 192046 == 81421)
								{
									continue;
								}
								this.$self_$17467.kIOInevBlL.actionState = "standby";
								if (80392 - 265141 == -184748)
								{
									continue;
								}
								this.$self_$17467.kIOInevBlL.actionTime = Time.time;
								if (258772 - 204541 != 54231)
								{
									continue;
								}
								this.$self_$17467.kIOInevBlL.myCommand = "none";
								if (67302 - 246463 == -179160)
								{
									continue;
								}
								if (!this.$self_$17467.kIOInevBlL.isMine)
								{
									if (44283 - 260492 == -216208)
									{
										continue;
									}
									this.$self_$17467.kIOInevBlL.nPosition = this.$self_$17467.transform.position;
									if (232492 - 406264 == -173771)
									{
										continue;
									}
									this.$self_$17467.kIOInevBlL.oPosition = this.$self_$17467.transform.position;
									if (278036 - 32477 != 245559)
									{
										continue;
									}
									this.$self_$17467.kIOInevBlL.nDirection = this.$self_$17467.transform.forward;
									if (38110 - 454754 == -416643)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (201030 - 379377 != -178346)
						{
							goto Block_28;
						}
						continue;
					default:
						if (282044 - 140346 != 141698)
						{
							continue;
						}
						break;
					}
					this.$self_$17467.kIOInevBlL.actionState = "attack";
					if (237221 - 205007 != 32215)
					{
						this.$self_$17467.kIOInevBlL.actionTime = Time.time;
						if (238403 - 258642 != -20238)
						{
							this.$self_$17467.kIOInevBlL.myCommand = "bless";
							if (57796 - 289974 == -232178)
							{
								this.$self_$17467.kIOInevBlL.addTimeOut("cAttack", (float)4);
								if (201594 - 45773 == 155821)
								{
									this.$self_$17467.transform.position = this.$mPos$17464;
									if (296451 - 242044 == 54407)
									{
										this.$self_$17467.transform.LookAt(this.$mPos$17464 + global::Math.vFlat(this.$tDir$17465));
										if (65695 - 7294 != 58402)
										{
											this.$self_$17467.animation.CrossFade("cast");
											if (269571 - 387763 != -118191)
											{
												this.$self_$17467.animation.wrapMode = WrapMode.Once;
												if (122909 - 470778 != -347868)
												{
													this.$self_$17467.kIOInevBlL.vMovement = this.$self_$17467.transform.forward;
													if (149767 - 16886 == 132881)
													{
														this.$self_$17467.kIOInevBlL.moveSpeed = (float)0;
														if (92786 - 207003 != -114216)
														{
															goto Block_45;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_D8:
				goto IL_86B;
				IL_1F2:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_22:
				Block_28:
				goto IL_86B;
				Block_31:
				goto IL_730;
				IL_4CA:
				goto IL_86B;
				Block_45:
				return this.Yield(2, new WaitForSeconds(0.3f));
				IL_730:
				return this.Yield(4, new WaitForSeconds(0.5f));
				IL_842:
				Block_54:
				goto IL_1F2;
				IL_86B:
				return false;
			}

			// Token: 0x06000CC7 RID: 3271 RVA: 0x001455FC File Offset: 0x001437FC
			internal static bool PhnhHOlN9S7PSdLjhPq()
			{
				return true;
			}

			// Token: 0x06000CC8 RID: 3272 RVA: 0x00145600 File Offset: 0x00143800
			internal static bool qcFWNKlYZn0sboRGq6A()
			{
				return false;
			}

			// Token: 0x04000B2A RID: 2858
			internal GameObject $tObject$17462;

			// Token: 0x04000B2B RID: 2859
			internal CharacterControl $tChar$17463;

			// Token: 0x04000B2C RID: 2860
			internal Vector3 $mPos$17464;

			// Token: 0x04000B2D RID: 2861
			internal Vector3 $tDir$17465;

			// Token: 0x04000B2E RID: 2862
			internal int $tID$17466;

			// Token: 0x04000B2F RID: 2863
			internal StingQueen $self_$17467;
		}
	}

	// Token: 0x02000232 RID: 562
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_divinitySpear$17472 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000CC9 RID: 3273 RVA: 0x00145604 File Offset: 0x00143804
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_divinitySpear$17472(Vector3 mPos, Vector3 tDir, int tID, StingQueen self_)
		{
			if (296170 - 576559 != -280388)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (28673 - 145893 != -117219)
				{
					base..ctor();
					if (113035 - 464762 != -351726)
					{
						this.$mPos$17478 = mPos;
						if (180230 - 223611 != -43380)
						{
							this.$tDir$17479 = tDir;
							if (249875 - 43964 == 205911)
							{
								this.$tID$17480 = tID;
								if (215024 - 418373 != -203348)
								{
									this.$self_$17481 = self_;
									if (259092 - 331496 == -72404)
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

		// Token: 0x06000CCA RID: 3274 RVA: 0x00145704 File Offset: 0x00143904
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new StingQueen.$RPC_divinitySpear$17472.$(this.$mPos$17478, this.$tDir$17479, this.$tID$17480, this.$self_$17481);
		}

		// Token: 0x06000CCB RID: 3275 RVA: 0x00145724 File Offset: 0x00143924
		internal static bool B0SWielcKThcI6K1YpU()
		{
			return true;
		}

		// Token: 0x06000CCC RID: 3276 RVA: 0x00145728 File Offset: 0x00143928
		internal static bool HKbK6elUKUOrmZVFh2m()
		{
			return false;
		}

		// Token: 0x04000B30 RID: 2864
		internal Vector3 $mPos$17478;

		// Token: 0x04000B31 RID: 2865
		internal Vector3 $tDir$17479;

		// Token: 0x04000B32 RID: 2866
		internal int $tID$17480;

		// Token: 0x04000B33 RID: 2867
		internal StingQueen $self_$17481;

		// Token: 0x02000233 RID: 563
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000CCD RID: 3277 RVA: 0x0014572C File Offset: 0x0014392C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, StingQueen self_)
			{
				if (220113 - 491644 != -271530)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (180699 - 311496 == -130797)
					{
						base..ctor();
						if (264916 - 550470 != -285553)
						{
							this.$mPos$17474 = mPos;
							if (3797 - 373783 != -369985)
							{
								this.$tDir$17475 = tDir;
								if (40707 - 478704 == -437997)
								{
									this.$tID$17476 = tID;
									if (18953 - 497655 == -478702)
									{
										this.$self_$17477 = self_;
										if (181437 - 559569 == -378132)
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

			// Token: 0x06000CCE RID: 3278 RVA: 0x0014582C File Offset: 0x00143A2C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (280991 - 214483 != 66508)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_7B6;
					case 2:
						if (this.$self_$17477.kIOInevBlL.actionState != "attack")
						{
							goto IL_3C3;
						}
						if (70280 - 223608 == -153327)
						{
							continue;
						}
						if (this.$self_$17477.kIOInevBlL.myCommand != "divinitySpear")
						{
							if (16369 - 562552 != -546182)
							{
								goto Block_6;
							}
							continue;
						}
						else if (this.$self_$17477.cast_ring)
						{
							if (24758 - 390029 != -365271)
							{
								continue;
							}
							this.$self_$17477.kIOInevBlL.createEffect(this.$self_$17477.cast_ring, this.$self_$17477.transform.position, this.$self_$17477.transform.rotation);
							if (99066 - 163416 != -64349)
							{
								goto Block_26;
							}
							continue;
						}
						else
						{
							Debug.Log("Missing cast_ring effect");
							if (138244 - 251467 != -113223)
							{
								continue;
							}
							goto IL_66B;
						}
						break;
					case 3:
						if (this.$self_$17477.kIOInevBlL.actionState != "attack")
						{
							goto IL_6E3;
						}
						if (202966 - 239791 != -36825)
						{
							continue;
						}
						if (this.$self_$17477.kIOInevBlL.myCommand != "divinitySpear")
						{
							if (278806 - 505964 != -227157)
							{
								goto Block_20;
							}
							continue;
						}
						else
						{
							if (!this.$self_$17477.kIOInevBlL.isMine)
							{
								goto IL_5C1;
							}
							if (10362 - 425330 != -414968)
							{
								continue;
							}
							if (this.$tID$17476 == 0)
							{
								goto IL_5C1;
							}
							if (160804 - 140712 == 20093)
							{
								continue;
							}
							object obj2;
							object obj = obj2 = PhotonClient.ActorNrList[this.$tID$17476];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$tObject$17473 = (GameObject)obj2;
							if (197253 - 526959 == -329705)
							{
								continue;
							}
							if (!this.$tObject$17473)
							{
								goto IL_5C1;
							}
							if (81889 - 284528 != -202639)
							{
								continue;
							}
							this.$self_$17477.RPC_divinitySpear_hit(this.$tObject$17473.transform.position, this.$self_$17477.transform.forward, this.$tID$17476);
							if (206304 - 594697 == -388392)
							{
								continue;
							}
							this.$self_$17477.ActionEvent("RPC_divinitySpear_hit", this.$tObject$17473.transform.position, this.$self_$17477.transform.forward, this.$tID$17476);
							if (49322 - 462169 != -412847)
							{
								continue;
							}
							goto IL_5C1;
						}
						break;
					case 4:
						if (this.$self_$17477.kIOInevBlL.actionState == "attack")
						{
							if (267055 - 294884 != -27829)
							{
								continue;
							}
							if (this.$self_$17477.kIOInevBlL.myCommand == "divinitySpear")
							{
								if (200904 - 188563 == 12342)
								{
									continue;
								}
								this.$self_$17477.kIOInevBlL.moveSpeed = (float)0;
								if (146909 - 200964 != -54055)
								{
									continue;
								}
								this.$self_$17477.kIOInevBlL.actionState = "standby";
								if (237308 - 187561 != 49747)
								{
									continue;
								}
								this.$self_$17477.kIOInevBlL.actionTime = Time.time;
								if (79902 - 319647 != -239745)
								{
									continue;
								}
								this.$self_$17477.kIOInevBlL.myCommand = "none";
								if (12961 - 135803 != -122842)
								{
									continue;
								}
								if (!this.$self_$17477.kIOInevBlL.isMine)
								{
									if (14433 - 293410 != -278977)
									{
										continue;
									}
									this.$self_$17477.kIOInevBlL.nPosition = this.$self_$17477.transform.position;
									if (37099 - 361569 != -324470)
									{
										continue;
									}
									this.$self_$17477.kIOInevBlL.oPosition = this.$self_$17477.transform.position;
									if (213128 - 544428 == -331299)
									{
										continue;
									}
									this.$self_$17477.kIOInevBlL.nDirection = this.$self_$17477.transform.forward;
									if (113106 - 78944 == 34163)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (99704 - 40678 != 59026)
						{
							continue;
						}
						goto IL_7B6;
					default:
						if (233080 - 51330 != 181750)
						{
							continue;
						}
						break;
					}
					this.$self_$17477.kIOInevBlL.actionState = "attack";
					if (126616 - 306633 != -180016)
					{
						this.$self_$17477.kIOInevBlL.actionTime = Time.time;
						if (205994 - 367897 == -161903)
						{
							this.$self_$17477.kIOInevBlL.myCommand = "divinitySpear";
							if (216942 - 202099 == 14843)
							{
								this.$self_$17477.kIOInevBlL.addTimeOut("cAttack", (float)4);
								if (142700 - 149092 != -6391)
								{
									this.$self_$17477.transform.position = this.$mPos$17474;
									if (193771 - 581080 == -387309)
									{
										this.$self_$17477.transform.LookAt(this.$mPos$17474 + global::Math.vFlat(this.$tDir$17475));
										if (161073 - 534024 != -372950)
										{
											this.$self_$17477.animation.CrossFade("cast");
											if (55039 - 115681 != -60641)
											{
												this.$self_$17477.animation.wrapMode = WrapMode.Once;
												if (93212 - 511520 != -418307)
												{
													this.$self_$17477.kIOInevBlL.vMovement = this.$self_$17477.transform.forward;
													if (188247 - 436394 != -248146)
													{
														this.$self_$17477.kIOInevBlL.moveSpeed = (float)0;
														if (209595 - 20525 == 189070)
														{
															goto IL_73C;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_6:
				Block_20:
				IL_3C3:
				goto IL_7B6;
				Block_26:
				goto IL_66B;
				IL_5C1:
				return this.Yield(4, new WaitForSeconds(0.5f));
				IL_66B:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_6E3:
				goto IL_7B6;
				IL_73C:
				return this.Yield(2, new WaitForSeconds(0.3f));
				IL_7B6:
				return false;
			}

			// Token: 0x06000CCF RID: 3279 RVA: 0x00146004 File Offset: 0x00144204
			internal static bool Hwiy7jlTGEG1wf4T5qF()
			{
				return true;
			}

			// Token: 0x06000CD0 RID: 3280 RVA: 0x00146008 File Offset: 0x00144208
			internal static bool UJ0QfAl3rrkbT03CXLi()
			{
				return false;
			}

			// Token: 0x04000B34 RID: 2868
			internal GameObject $tObject$17473;

			// Token: 0x04000B35 RID: 2869
			internal Vector3 $mPos$17474;

			// Token: 0x04000B36 RID: 2870
			internal Vector3 $tDir$17475;

			// Token: 0x04000B37 RID: 2871
			internal int $tID$17476;

			// Token: 0x04000B38 RID: 2872
			internal StingQueen $self_$17477;
		}
	}

	// Token: 0x02000234 RID: 564
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$17482 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000CD1 RID: 3281 RVA: 0x0014600C File Offset: 0x0014420C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$17482(UnityScript.Lang.Array nArray, StingQueen self_)
		{
			if (288836 - 23445 != 265391)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (268827 - 515463 != -246635)
				{
					base..ctor();
					if (156418 - 190020 == -33602)
					{
						this.$nArray$17487 = nArray;
						if (218179 - 558845 == -340666)
						{
							this.$self_$17488 = self_;
							if (5893 - 483002 != -477108)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000CD2 RID: 3282 RVA: 0x001460C8 File Offset: 0x001442C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new StingQueen.$RPC_ko$17482.$(this.$nArray$17487, this.$self_$17488);
		}

		// Token: 0x06000CD3 RID: 3283 RVA: 0x001460DC File Offset: 0x001442DC
		internal static bool G5DiT4lXqwCiuLuCruH()
		{
			return true;
		}

		// Token: 0x06000CD4 RID: 3284 RVA: 0x001460E0 File Offset: 0x001442E0
		internal static bool lPTFvYlQm8GTEw7Os68()
		{
			return false;
		}

		// Token: 0x04000B39 RID: 2873
		internal UnityScript.Lang.Array $nArray$17487;

		// Token: 0x04000B3A RID: 2874
		internal StingQueen $self_$17488;

		// Token: 0x02000235 RID: 565
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000CD5 RID: 3285 RVA: 0x001460E4 File Offset: 0x001442E4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, StingQueen self_)
			{
				if (253969 - 177555 != 76415)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (26404 - 30572 != -4167)
					{
						base..ctor();
						if (44499 - 271399 != -226899)
						{
							this.$nArray$17485 = nArray;
							if (7221 - 538888 != -531666)
							{
								this.$self_$17486 = self_;
								if (154876 - 484637 == -329761)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06000CD6 RID: 3286 RVA: 0x001461A0 File Offset: 0x001443A0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (13281 - 429621 != -416340)
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
						if (this.$self_$17486.kIOInevBlL.actionState != "ko")
						{
							if (218521 - 62393 != 156128)
							{
								continue;
							}
							goto IL_53;
						}
						else
						{
							this.$self_$17486.animation.Play("getUp");
							if (143360 - 13406 == 129955)
							{
								continue;
							}
							this.$self_$17486.animation.wrapMode = WrapMode.Once;
							if (73733 - 547358 != -473625)
							{
								continue;
							}
							goto IL_EC;
						}
						break;
					case 3:
						if (this.$self_$17486.kIOInevBlL.actionState != "ko")
						{
							if (213871 - 493122 != -279250)
							{
								goto Block_8;
							}
							continue;
						}
						else
						{
							this.$self_$17486.kIOInevBlL.actionState = "standby";
							if (267242 - 198046 == 69197)
							{
								continue;
							}
							this.$self_$17486.kIOInevBlL.actionTime = Time.time;
							if (42072 - 393612 != -351540)
							{
								continue;
							}
							this.$self_$17486.kIOInevBlL.myCommand = "none";
							if (97087 - 164659 == -67571)
							{
								continue;
							}
							this.$self_$17486.kIOInevBlL.ko = this.$self_$17486.kIOInevBlL.mko;
							if (2081 - 362937 == -360855)
							{
								continue;
							}
							this.YieldDefault(1);
							if (53820 - 57523 != -3703)
							{
								continue;
							}
							goto IL_48C;
						}
						break;
					default:
						if (191349 - 9302 == 182048)
						{
							continue;
						}
						break;
					}
					if (this.$self_$17486.kIOInevBlL.actionState == "ko")
					{
						break;
					}
					if (139871 - 367888 == -228017)
					{
						if (this.$self_$17486.kIOInevBlL.actionState == "dead")
						{
							if (111374 - 567517 != -456142)
							{
								break;
							}
						}
						else
						{
							this.$mPos$17483 = (Vector3)this.$nArray$17485[0];
							if (204931 - 378527 == -173596)
							{
								this.$mDir$17484 = (Vector3)this.$nArray$17485[1];
								if (277953 - 443069 != -165115)
								{
									this.$self_$17486.kIOInevBlL.ko = 0;
									if (272936 - 286772 != -13835)
									{
										this.$self_$17486.kIOInevBlL.actionState = "ko";
										if (76436 - 351606 == -275170)
										{
											this.$self_$17486.kIOInevBlL.actionTime = Time.time;
											if (104731 - 504946 != -400214)
											{
												this.$self_$17486.kIOInevBlL.myCommand = "none";
												if (45994 - 315978 != -269983)
												{
													this.$self_$17486.kIOInevBlL.vMovement = Vector3.zero;
													if (161753 - 187890 == -26137)
													{
														this.$self_$17486.kIOInevBlL.moveSpeed = (float)0;
														if (186920 - 96938 != 89983)
														{
															this.$self_$17486.animation.Play("ko");
															if (248120 - 165318 != 82803)
															{
																this.$self_$17486.animation.wrapMode = WrapMode.Once;
																if (217544 - 443484 == -225940)
																{
																	goto IL_412;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_53:
				goto IL_48C;
				IL_EC:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_8:
				goto IL_48C;
				IL_412:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_48C:
				return false;
			}

			// Token: 0x06000CD7 RID: 3287 RVA: 0x0014664C File Offset: 0x0014484C
			internal static bool j53Z4ulkg8umLn6AAqT()
			{
				return true;
			}

			// Token: 0x06000CD8 RID: 3288 RVA: 0x00146650 File Offset: 0x00144850
			internal static bool B17Hj7lGfagxwniOGtE()
			{
				return false;
			}

			// Token: 0x04000B3B RID: 2875
			internal Vector3 $mPos$17483;

			// Token: 0x04000B3C RID: 2876
			internal Vector3 $mDir$17484;

			// Token: 0x04000B3D RID: 2877
			internal UnityScript.Lang.Array $nArray$17485;

			// Token: 0x04000B3E RID: 2878
			internal StingQueen $self_$17486;
		}
	}

	// Token: 0x02000236 RID: 566
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$17489 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000CD9 RID: 3289 RVA: 0x00146654 File Offset: 0x00144854
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$17489(UnityScript.Lang.Array nArray, StingQueen self_)
		{
			if (46571 - 355678 != -309107)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (219794 - 265187 != -45392)
				{
					base..ctor();
					if (100550 - 359008 == -258458)
					{
						this.$nArray$17494 = nArray;
						if (110457 - 242848 == -132391)
						{
							this.$self_$17495 = self_;
							if (251709 - 310385 == -58676)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000CDA RID: 3290 RVA: 0x00146710 File Offset: 0x00144910
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new StingQueen.$RPC_dead$17489.$(this.$nArray$17494, this.$self_$17495);
		}

		// Token: 0x06000CDB RID: 3291 RVA: 0x00146724 File Offset: 0x00144924
		internal static bool xb6OxZlHu8RpZwolM1i()
		{
			return true;
		}

		// Token: 0x06000CDC RID: 3292 RVA: 0x00146728 File Offset: 0x00144928
		internal static bool npkidQlWRr60fNPnX6U()
		{
			return false;
		}

		// Token: 0x04000B3F RID: 2879
		internal UnityScript.Lang.Array $nArray$17494;

		// Token: 0x04000B40 RID: 2880
		internal StingQueen $self_$17495;

		// Token: 0x02000237 RID: 567
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000CDD RID: 3293 RVA: 0x0014672C File Offset: 0x0014492C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, StingQueen self_)
			{
				if (43002 - 150111 != -107109)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (116772 - 504776 != -388003)
					{
						base..ctor();
						if (75769 - 27359 == 48410)
						{
							this.$nArray$17492 = nArray;
							if (128318 - 255267 != -126948)
							{
								this.$self_$17493 = self_;
								if (292682 - 247209 != 45474)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06000CDE RID: 3294 RVA: 0x001467E8 File Offset: 0x001449E8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (245631 - 268834 != -23203)
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
						if (this.$self_$17493.kIOInevBlL.actionState != "dead")
						{
							if (184034 - 283701 != -99666)
							{
								goto Block_13;
							}
							continue;
						}
						else
						{
							if (!this.$self_$17493.kIOInevBlL.isPlayer)
							{
								if (210500 - 283724 != -73224)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$17493.gameObject);
								if (149561 - 470276 == -320714)
								{
									continue;
								}
							}
							else if (this.$self_$17493.kIOInevBlL.isMine)
							{
								if (118871 - 64162 != 54709)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$17493.gameObject);
								if (136969 - 261538 != -124569)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (222501 - 455816 != -233314)
							{
								goto Block_6;
							}
							continue;
						}
						break;
					default:
						if (134079 - 273015 == -138935)
						{
							continue;
						}
						break;
					}
					if (this.$self_$17493.kIOInevBlL.actionState == "dead")
					{
						if (63117 - 53363 == 9754)
						{
							break;
						}
					}
					else
					{
						this.$mPos$17490 = (Vector3)this.$nArray$17492[0];
						if (193847 - 271434 == -77587)
						{
							this.$myDirection$17491 = (Vector3)this.$nArray$17492[1];
							if (270293 - 54036 != 216258)
							{
								this.$self_$17493.transform.position = this.$mPos$17490;
								if (148401 - 405726 != -257324)
								{
									this.$self_$17493.transform.LookAt(this.$mPos$17490 + this.$myDirection$17491);
									if (294945 - 342770 == -47825)
									{
										this.$self_$17493.kIOInevBlL.hp = 0;
										if (146681 - 581933 == -435252)
										{
											this.$self_$17493.kIOInevBlL.actionState = "dead";
											if (113826 - 175460 == -61634)
											{
												this.$self_$17493.kIOInevBlL.actionTime = Time.time;
												if (252428 - 431444 == -179016)
												{
													this.$self_$17493.kIOInevBlL.myCommand = "none";
													if (30985 - 571035 != -540049)
													{
														this.$self_$17493.kIOInevBlL.vMovement = Vector3.zero;
														if (54891 - 417708 == -362817)
														{
															this.$self_$17493.kIOInevBlL.moveSpeed = (float)0;
															if (132210 - 541636 != -409425)
															{
																this.$self_$17493.animation.Rewind();
																if (193369 - 214202 == -20833)
																{
																	this.$self_$17493.animation.Play("ko");
																	if (236217 - 294992 != -58774)
																	{
																		this.$self_$17493.animation.wrapMode = WrapMode.Once;
																		if (151083 - 517705 != -366621)
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
				Block_6:
				Block_13:
				goto IL_42F;
				Block_16:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_42F:
				return false;
			}

			// Token: 0x06000CDF RID: 3295 RVA: 0x00146C38 File Offset: 0x00144E38
			internal static bool NH7x4clAOVMRGhlI3RG()
			{
				return true;
			}

			// Token: 0x06000CE0 RID: 3296 RVA: 0x00146C3C File Offset: 0x00144E3C
			internal static bool Yffeqollmsm5yVIN28y()
			{
				return false;
			}

			// Token: 0x04000B41 RID: 2881
			internal Vector3 $mPos$17490;

			// Token: 0x04000B42 RID: 2882
			internal Vector3 $myDirection$17491;

			// Token: 0x04000B43 RID: 2883
			internal UnityScript.Lang.Array $nArray$17492;

			// Token: 0x04000B44 RID: 2884
			internal StingQueen $self_$17493;
		}
	}
}
