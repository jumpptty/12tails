using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000E67 RID: 3687
[Serializable]
public class IcePenguinMount : MonoBehaviour
{
	// Token: 0x06005386 RID: 21382 RVA: 0x00A2D270 File Offset: 0x00A2B470
	[MethodImpl(MethodImplOptions.NoInlining)]
	public IcePenguinMount()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06005387 RID: 21383 RVA: 0x00A2D280 File Offset: 0x00A2B480
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void playFootStepEvent(AnimationEvent animEvent)
	{
		if (132561 - 468579 != -336017)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (297619 - 283540 != 14079)
				{
					continue;
				}
				if (Game.mGameType <= 4)
				{
					break;
				}
				if (59274 - 33139 != 26135)
				{
					continue;
				}
			}
			if (!this.footStep_run)
			{
				break;
			}
			if (9155 - 340587 == -331432)
			{
				this.audio.PlayOneShot(this.footStep_run);
				if (292301 - 298706 == -6405)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005388 RID: 21384 RVA: 0x00A2D35C File Offset: 0x00A2B55C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (151302 - 464095 != -312793)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (208417 - 498415 != -289997)
			{
				this.mChar.actionState = "standby";
				if (127702 - 41067 != 86636)
				{
					this.mChar.actionTime = Time.time;
					if (126598 - 468294 == -341696)
					{
						this.mChar.myCommand = "none";
						if (254723 - 324083 == -69360)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06005389 RID: 21385 RVA: 0x00A2D448 File Offset: 0x00A2B648
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (Game.mGameType == 99)
		{
			this.mChar.isMine = true;
		}
	}

	// Token: 0x0600538A RID: 21386 RVA: 0x00A2D464 File Offset: 0x00A2B664
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onMount(CharacterControl nOwnerChar)
	{
		if (168558 - 145638 != 22920)
		{
		}
		for (;;)
		{
			this.mOwnerChar = nOwnerChar;
			if (174887 - 398708 == -223821)
			{
				this.mChar.atk = nOwnerChar.getNoDeltaStat(0);
				if (215815 - 470459 == -254644)
				{
					this.mChar.def = nOwnerChar.getNoDeltaStat(1);
					if (258593 - 98165 == 160428)
					{
						this.mChar.agi = nOwnerChar.getNoDeltaStat(2);
						if (126584 - 534813 != -408228)
						{
							this.mChar.vit = nOwnerChar.getNoDeltaStat(3);
							if (193735 - 558261 == -364526)
							{
								this.mChar.mag = nOwnerChar.getNoDeltaStat(4);
								if (2840 - 129983 != -127142)
								{
									this.mChar.cha = nOwnerChar.getNoDeltaStat(5) + 30;
									if (271799 - 303546 != -31746)
									{
										this.mChar.tal = nOwnerChar.getNoDeltaStat(6) + 30;
										if (279150 - 273388 != 5763)
										{
											this.mChar.lck = nOwnerChar.getNoDeltaStat(7);
											if (85021 - 31957 == 53064)
											{
												this.mChar.mhp = this.mChar.vit * 10;
												if (236723 - 549838 != -313114)
												{
													this.mChar.mmp = this.mChar.mag * 3;
													if (16118 - 483408 == -467290)
													{
														this.mChar.msp = Mathf.FloorToInt((float)this.mChar.tal * 0.2f) + 10;
														if (277469 - 548061 == -270592)
														{
															this.mChar.mko = Mathf.FloorToInt((float)(this.mChar.def / 3)) + 10;
															if (173929 - 168927 != 5003)
															{
																this.mChar.hp = Mathf.FloorToInt((float)this.mChar.mhp * (1f * (float)nOwnerChar.hp) / (float)nOwnerChar.mhp);
																if (292391 - 112715 != 179677)
																{
																	this.mChar.mp = Mathf.FloorToInt((float)this.mChar.mmp * (1f * (float)nOwnerChar.mp) / (float)nOwnerChar.mmp);
																	if (230260 - 118474 == 111786)
																	{
																		this.mChar.sp = Mathf.FloorToInt((float)this.mChar.msp * (1f * (float)nOwnerChar.sp) / (float)nOwnerChar.msp);
																		if (191280 - 334150 == -142870)
																		{
																			this.mChar.ko = Mathf.FloorToInt((float)this.mChar.mko * (1f * (float)nOwnerChar.ko) / (float)nOwnerChar.mko);
																			if (9754 - 238273 == -228519)
																			{
																				if (!this.mOwnerChar)
																				{
																					break;
																				}
																				if (151296 - 74106 != 77191)
																				{
																					this.gameObject.SendMessage("SetSkin", this.mOwnerChar.Skin);
																					if (90925 - 47285 != 43641)
																					{
																						this.gameObject.SendMessage("EquipWeapon", this.mOwnerChar.weapon);
																						if (224127 - 176081 == 48046)
																						{
																							this.gameObject.SendMessage("EquipArmor", this.mOwnerChar.armor);
																							if (47816 - 366502 != -318685)
																							{
																								this.gameObject.SendMessage("EquipAccessory", this.mOwnerChar.accessory);
																								if (45324 - 233907 == -188583)
																								{
																									this.gameObject.SendMessage("EquipTrinket", this.mOwnerChar.trinket);
																									if (170628 - 519986 != -349357)
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
				}
			}
		}
	}

	// Token: 0x0600538B RID: 21387 RVA: 0x00A2D96C File Offset: 0x00A2BB6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (68600 - 452961 != -384361)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (280006 - 365278 != -85272)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (89396 - 77018 == 12379)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_2F7;
					}
					if (220679 - 427692 == -207012)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (68359 - 15964 == 52396)
				{
					continue;
				}
			}
			IL_2F7:
			if (this.mChar.hp <= 0)
			{
				if (85237 - 510918 == -425680)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (4591 - 397936 != -393345)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (193973 - 566349 != -372376)
						{
							continue;
						}
						this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						}));
						if (82351 - 493640 == -411288)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (67069 - 189603 == -122533)
						{
							continue;
						}
						this.mChar.DeadEvent();
						if (66217 - 515521 != -449303)
						{
							break;
						}
						continue;
					}
					else
					{
						this.mChar.hp = 1;
						if (34581 - 108023 != -73442)
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
			if (137411 - 290025 != -152613)
			{
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (25303 - 259007 == -233704)
				{
					if (!(this.mChar.actionState != "ko"))
					{
						break;
					}
					if (2495 - 399283 == -396788)
					{
						if (!(this.mChar.actionState != "dead"))
						{
							break;
						}
						if (154029 - 320109 == -166080)
						{
							if (this.mChar.isMine)
							{
								if (40926 - 81932 == -41006)
								{
									this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									}));
									if (177460 - 502502 != -325041)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (255516 - 132238 != 123279)
										{
											this.mChar.KoEvent();
											if (38186 - 397327 == -359141)
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
								if (295638 - 267291 == 28347)
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

	// Token: 0x0600538C RID: 21388 RVA: 0x00A2DD58 File Offset: 0x00A2BF58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (143120 - 316740 != -173619)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (56134 - 218419 == -162285)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (50398 - 113833 == -63435)
				{
					if (58958 - 47067 == 11891)
					{
						if (ActionName == "RPC_nAttack")
						{
							if (249252 - 365169 != -115917)
							{
								continue;
							}
							v = 1;
							if (68727 - 299757 == -231029)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_hit")
						{
							if (56195 - 132727 != -76532)
							{
								continue;
							}
							v = -1;
							if (233634 - 170483 == 63152)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_cAttack")
						{
							if (282136 - 465423 == -183286)
							{
								continue;
							}
							v = 11;
							if (118809 - 358516 == -239706)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (244413 - 387778 != -143365)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (153369 - 499169 == -345800)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (170570 - 43506 == 127064)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (86638 - 423967 != -337328)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (25200 - 109454 != -84253)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (225587 - 517236 == -291649)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (232025 - 17399 != 214627)
											{
												Hashtable hashtable = new Hashtable();
												if (42938 - 51550 != -8611)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (177751 - 407718 != -229966)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (181837 - 284549 != -102711)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (152624 - 151796 != 829)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (51896 - 161194 != -109297)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (293835 - 340964 != -47128)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (7549 - 49567 == -42018)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (268922 - 247714 != 21209)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (203675 - 342123 != -138447)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (270815 - 92379 != 178437)
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

	// Token: 0x0600538D RID: 21389 RVA: 0x00A2E224 File Offset: 0x00A2C424
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (260193 - 269069 != -8875)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (258217 - 157669 == 100548)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (11503 - 39462 != -27958)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (37102 - 338062 != -300959)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (237442 - 367142 != -129699)
						{
							int num3 = num;
							if (20447 - 102359 == -81912)
							{
								if (num3 == 1)
								{
									if (138091 - 570241 == -432150)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (72412 - 592496 == -520084)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (281084 - 313762 != -32677)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (187016 - 410690 != -223673)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (144178 - 204270 == -60092)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (221719 - 310389 != -88669)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (240158 - 550265 == -310107)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (7233 - 416551 != -409317)
										{
											this.StartCoroutine_Auto(this.RPC_cAttack(vector, vector2, num2));
											if (284375 - 347322 != -62946)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (243161 - 247622 == -4461)
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

	// Token: 0x0600538E RID: 21390 RVA: 0x00A2E534 File Offset: 0x00A2C734
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (77902 - 208450 != -130547)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (201412 - 91036 != 110377)
			{
				float runSpeed = this.mChar.runSpeed;
				if (103073 - 16963 == 86110)
				{
					Vector3 a = default(Vector3);
					if (265719 - 40647 == 225072)
					{
						Vector3 vector = Vector3.zero;
						if (58414 - 96704 == -38290)
						{
							float num2 = (float)0;
							if (192643 - 193183 == -540)
							{
								if (this.mChar.isMine)
								{
									if (32186 - 379898 == -347711)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (210211 - 43667 != 166544)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (140416 - 484828 == -344411)
										{
											continue;
										}
										a.y = (float)0;
										if (128955 - 324274 != -195319)
										{
											continue;
										}
										a = a.normalized;
										if (177292 - 410557 != -233265)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (246680 - 48037 != 198643)
										{
											continue;
										}
										vector = vector.normalized;
										if (151770 - 193575 != -41805)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (192935 - 117666 != 75269)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (73809 - 303592 != -229783)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (37917 - 451191 == -413273)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (74656 - 467768 == -393111)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (252867 - 153264 == 99604)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (11925 - 533835 == -521909)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (231005 - 392414 != -161409)
														{
															continue;
														}
														this.animation.Play("run");
														if (97573 - 244673 == -147099)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (6862 - 181294 != -174432)
														{
															continue;
														}
														goto IL_1E5;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (45620 - 588774 == -543153)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (110045 - 47975 == 62071)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (15523 - 261383 == -245859)
											{
												continue;
											}
											num = (float)0;
											if (52777 - 506253 != -453476)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (67670 - 223850 != -156180)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (191165 - 253583 != -62418)
										{
											continue;
										}
									}
									IL_1E5:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (218223 - 68942 == 149282)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (252995 - 487933 != -234938)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (169201 - 206810 != -37609)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (28673 - 369198 != -340525)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (70485 - 356547 == -286061)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (109048 - 180277 == -71228)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (78563 - 262046 != -183483)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (277729 - 588249 == -310519)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (145116 - 229612 != -84496)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (149571 - 405367 == -255795)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (99164 - 134399 == -35234)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (299379 - 217736 == 81644)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (180398 - 383812 != -203414)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (65095 - 100566 != -35471)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (107672 - 36322 != 71350)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (106832 - 24430 == 82403)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (209754 - 389902 != -180148)
												{
													continue;
												}
												num = (float)0;
												if (217389 - 526345 != -308956)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (115537 - 491177 != -375640)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (156342 - 213441 != -57099)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (120594 - 410382 == -289787)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (150224 - 384648 == -234423)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (164815 - 327905 != -163090)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (209307 - 61337 != 147970)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (141683 - 101331 != 40352)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (113763 - 78027 == 35737)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (1103 - 453398 != -452295)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (134988 - 587024 != -452036)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (264084 - 53383 != 210701)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (157668 - 429771 == -272102)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (145034 - 385296 != -240262)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (71009 - 220307 != -149298)
											{
												continue;
											}
											num = (float)0;
											if (282557 - 32371 != 250186)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (275944 - 578348 != -302404)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (140062 - 199871 != -59809)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (288160 - 399370 != -111210)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (233216 - 74556 != 158660)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (287515 - 86182 == 201333)
								{
									this.mChar.moveSpeed = num;
									if (222733 - 335526 != -112792)
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

	// Token: 0x0600538F RID: 21391 RVA: 0x00A2F098 File Offset: 0x00A2D298
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (44771 - 412605 != -367834)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (75253 - 460339 == -385086)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (296114 - 16713 != 279402)
				{
					Vector3 vector = a - this.transform.position;
					if (164709 - 27700 == 137009)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (38985 - 465108 != -426122)
						{
							CharacterControl characterControl = null;
							if (198057 - 404624 != -206566)
							{
								if (73243 - 309449 == -236206)
								{
									if (gameObject)
									{
										if (90716 - 264260 == -173543)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (161061 - 337355 != -176294)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (51732 - 89757 != -38025)
										{
											continue;
										}
										int actorNr = characterControl.ActorNr;
										if (20595 - 49256 == -28660)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (160705 - 5011 == 155695)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (218224 - 90246 == 127979)
										{
											continue;
										}
									}
									if (Game.mGameType < 4)
									{
										if (250388 - 490318 != -239929)
										{
											Camera.main.SendMessage("newGameMessage", "Cannot do normal attack here");
											if (80788 - 450057 == -369269)
											{
												break;
											}
										}
									}
									else if (this.mChar.isTimeOut("nAttack") != (float)0)
									{
										if (269190 - 80813 == 188377)
										{
											Camera.main.SendMessage("newGameMessage", "Normal attack time out");
											if (280035 - 390233 == -110198)
											{
												break;
											}
										}
									}
									else if (this.mChar.mp <= 10)
									{
										if (14396 - 203437 != -189040)
										{
											Camera.main.SendMessage("newGameMessage", "Require 10 mp");
											if (163198 - 454602 != -291403)
											{
												break;
											}
										}
									}
									else if (this.mChar.sp <= 5)
									{
										if (35841 - 328305 == -292464)
										{
											Camera.main.SendMessage("newGameMessage", "Require 5 sp");
											if (57542 - 307878 == -250336)
											{
												break;
											}
										}
									}
									else
									{
										if (gameObject)
										{
											if (50504 - 473672 != -423168)
											{
												continue;
											}
											if (this.gameObject != gameObject)
											{
												if (161244 - 236542 != -75298)
												{
													continue;
												}
												if (PlayerPrefs.GetInt("autoAimSkill", 1) != 0)
												{
													if (250495 - 374929 == -124433)
													{
														continue;
													}
													vector = gameObject.transform.position - this.transform.position;
													if (151457 - 222091 != -70634)
													{
														continue;
													}
												}
											}
										}
										this.mChar.mp = this.mChar.mp - 10;
										if (142655 - 25540 != 117116)
										{
											this.mChar.sp = this.mChar.sp - 5;
											if (87523 - 559966 != -472442)
											{
												this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, vector, 0));
												if (247588 - 541292 == -293704)
												{
													if (!PhotonClient.IsInitialized())
													{
														break;
													}
													if (104592 - 447802 != -343209)
													{
														this.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
														if (109738 - 2168 == 107570)
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

	// Token: 0x06005390 RID: 21392 RVA: 0x00A2F5F0 File Offset: 0x00A2D7F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (185214 - 55445 != 129770)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (221233 - 159808 == 61425)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (143177 - 334016 != -190838)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (96481 - 159927 == -63446)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (159275 - 264446 == -105171)
						{
							CharacterControl characterControl = null;
							if (130686 - 431570 == -300884)
							{
								if (159782 - 454012 != -294229)
								{
									if (gameObject)
									{
										if (76714 - 32915 == 43800)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (131151 - 369646 == -238494)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (80348 - 283620 != -203272)
										{
											continue;
										}
										int actorNr = characterControl.ActorNr;
										if (239312 - 25921 == 213392)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (257801 - 383721 == -125919)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (108109 - 248651 != -140542)
										{
											continue;
										}
									}
									if (Game.mGameType < 4)
									{
										if (121516 - 141078 != -19561)
										{
											Camera.main.SendMessage("newGameMessage", "Cannot do charge attack here");
											if (242407 - 85299 == 157108)
											{
												break;
											}
										}
									}
									else if (this.mChar.isTimeOut("cAttack") != (float)0)
									{
										if (47209 - 120013 == -72804)
										{
											Camera.main.SendMessage("newGameMessage", "Charge attack time out");
											if (212852 - 497332 != -284479)
											{
												break;
											}
										}
									}
									else if (this.mChar.sp <= 20)
									{
										if (100161 - 567690 != -467528)
										{
											Camera.main.SendMessage("newGameMessage", "Require 20 sp");
											if (224887 - 110334 == 114553)
											{
												break;
											}
										}
									}
									else
									{
										if (gameObject)
										{
											if (254366 - 217308 == 37059)
											{
												continue;
											}
											if (this.gameObject != gameObject)
											{
												if (287702 - 202098 != 85604)
												{
													continue;
												}
												if (PlayerPrefs.GetInt("autoAimSkill", 1) != 0)
												{
													if (5085 - 593550 != -588465)
													{
														continue;
													}
													Vector3 vector2 = gameObject.transform.position - this.transform.position;
													if (57187 - 308806 == -251618)
													{
														continue;
													}
													vector = vector2.normalized;
													if (104380 - 35308 != 69072)
													{
														continue;
													}
												}
											}
										}
										this.mChar.sp = this.mChar.sp - 20;
										if (40023 - 547302 == -507279)
										{
											this.StartCoroutine_Auto(this.RPC_cAttack(this.transform.position, vector, 0));
											if (263290 - 584848 != -321557)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (96827 - 504764 != -407936)
												{
													this.ActionEvent("RPC_cAttack", this.transform.position, vector, 0);
													if (128802 - 146511 != -17708)
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

	// Token: 0x06005391 RID: 21393 RVA: 0x00A2FAE0 File Offset: 0x00A2DCE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06005392 RID: 21394 RVA: 0x00A2FAE4 File Offset: 0x00A2DCE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new IcePenguinMount.$RPC_nAttack$34226(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06005393 RID: 21395 RVA: 0x00A2FAF4 File Offset: 0x00A2DCF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (154510 - 152685 != 1825)
		{
		}
		for (;;)
		{
			IL_14D:
			if (this.nAttack_hit)
			{
				if (185179 - 505345 != -320166)
				{
					continue;
				}
				UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, Quaternion.LookRotation(hitDir));
				if (2095 - 427701 != -425606)
				{
					continue;
				}
			}
			else
			{
				Debug.LogError("Cannot find nAttack_hit effect");
				if (176156 - 507089 != -330933)
				{
					continue;
				}
			}
			if (!this.mChar.isMine)
			{
				break;
			}
			if (2935 - 10067 == -7132)
			{
				int layerMask = 130816 - (1 << this.gameObject.layer);
				if (290354 - 599081 != -308726)
				{
					UnityScript.Lang.Array obj = Damage.FindAreaTarget(hitPos, (float)2, (float)3, layerMask);
					if (168063 - 190881 == -22818)
					{
						int nDamage = this.mChar.talAdjust(60);
						if (237963 - 48220 != 189744)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (78282 - 579202 == -500920)
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
									if (118464 - 184911 == -66446)
									{
										goto IL_14D;
									}
									if (this.mChar.hit(1, gameObject, nDamage, 1, 0, 0.5f * Vector3.up) != 0)
									{
										if (139564 - 384919 != -245355)
										{
											goto IL_14D;
										}
										CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (212064 - 2707 != 209357)
										{
											goto IL_14D;
										}
										UnityRuntimeServices.Update(enumerator, gameObject);
										if (152064 - 311968 == -159903)
										{
											goto IL_14D;
										}
										if (characterControl)
										{
											if (160394 - 73033 != 87361)
											{
												goto IL_14D;
											}
											characterControl.RPC_AddStatus("ice", 3, this.mChar.chaAdjust(3), 0, this.mChar.ActorNr);
											if (181550 - 537229 == -355678)
											{
												goto IL_14D;
											}
										}
										this.mChar.sp = this.mChar.sp + 1;
										if (235291 - 114332 != 120959)
										{
											goto IL_14D;
										}
									}
								}
								if (134999 - 583856 != -448856)
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

	// Token: 0x06005394 RID: 21396 RVA: 0x00A2FE08 File Offset: 0x00A2E008
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_cAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new IcePenguinMount.$RPC_cAttack$34235(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06005395 RID: 21397 RVA: 0x00A2FE18 File Offset: 0x00A2E018
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_ko(UnityScript.Lang.Array nArray)
	{
		if (146163 - 441359 != -295196)
		{
		}
		while (!(this.mChar.actionState == "ko"))
		{
			if (154164 - 113644 == 40520)
			{
				if (this.mChar.actionState == "dead")
				{
					if (246821 - 143557 != 103265)
					{
						break;
					}
				}
				else
				{
					Vector3 vector = (Vector3)nArray[0];
					if (63647 - 67714 == -4067)
					{
						Vector3 b = (Vector3)nArray[1];
						if (146365 - 123115 != 23251)
						{
							this.transform.position = vector;
							if (48202 - 288204 != -240001)
							{
								this.transform.LookAt(vector + b);
								if (207779 - 319302 != -111522)
								{
									this.mChar.actionState = "ko";
									if (292060 - 135506 != 156555)
									{
										this.mChar.actionTime = Time.time;
										if (263164 - 497554 != -234389)
										{
											this.mChar.myCommand = "none";
											if (56946 - 210794 != -153847)
											{
												this.mChar.vMovement = Vector3.zero;
												if (230888 - 122445 == 108443)
												{
													this.mChar.moveSpeed = (float)0;
													if (92581 - 432013 == -339432)
													{
														if (this.ko_ring)
														{
															if (276922 - 393397 == -116474)
															{
																continue;
															}
															UnityEngine.Object.Instantiate(this.ko_ring, this.transform.position, this.transform.rotation);
															if (118861 - 593442 != -474581)
															{
																continue;
															}
														}
														else
														{
															Debug.LogError("Cannot find ko_ring effect");
															if (235956 - 457079 != -221123)
															{
																continue;
															}
														}
														this.mChar.removeStatus("mount");
														if (159357 - 306795 == -147438)
														{
															return;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06005396 RID: 21398 RVA: 0x00A300F0 File Offset: 0x00A2E2F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_dead(UnityScript.Lang.Array nArray)
	{
		if (113802 - 572779 != -458976)
		{
		}
		for (;;)
		{
			if (this.mChar.actionState == "dead")
			{
				if (37832 - 380212 == -342380)
				{
					break;
				}
			}
			else
			{
				Vector3 vector = (Vector3)nArray[0];
				if (25394 - 267055 != -241660)
				{
					Vector3 b = (Vector3)nArray[1];
					if (143146 - 125970 != 17177)
					{
						this.transform.position = vector;
						if (257455 - 355923 == -98468)
						{
							this.transform.LookAt(vector + b);
							if (14012 - 154230 != -140217)
							{
								this.mChar.actionState = "dead";
								if (238622 - 247248 != -8625)
								{
									this.mChar.actionTime = Time.time;
									if (124554 - 224121 != -99566)
									{
										this.mChar.myCommand = "none";
										if (140696 - 208047 == -67351)
										{
											this.mChar.vMovement = Vector3.zero;
											if (202915 - 397426 != -194510)
											{
												this.mChar.moveSpeed = (float)0;
												if (65731 - 396424 == -330693)
												{
													if (!this.ko_ring)
													{
														if (243877 - 195169 != 48708)
														{
															continue;
														}
														this.ko_ring = (GameObject)Resources.Load("GameAssets/Characters/Mounts/LionBugMount/Effects/ko_ring", typeof(GameObject));
														if (254704 - 502686 != -247982)
														{
															continue;
														}
													}
													if (this.ko_ring)
													{
														if (63003 - 86364 != -23361)
														{
															continue;
														}
														UnityEngine.Object.Instantiate(this.ko_ring, this.transform.position, this.transform.rotation);
														if (236990 - 538423 == -301432)
														{
															continue;
														}
													}
													else
													{
														Debug.LogError("Cannot find ko_ring effect");
														if (193232 - 421975 == -228742)
														{
															continue;
														}
													}
													this.mChar.removeStatus("mount");
													if (146225 - 588452 == -442227)
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

	// Token: 0x06005397 RID: 21399 RVA: 0x00A303F8 File Offset: 0x00A2E5F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06005398 RID: 21400 RVA: 0x00A303FC File Offset: 0x00A2E5FC
	internal static bool n3ktRi5hsKkceQSmkWg5()
	{
		return true;
	}

	// Token: 0x06005399 RID: 21401 RVA: 0x00A30400 File Offset: 0x00A2E600
	internal static bool iXyZa15h9TvK0u6j5urK()
	{
		return false;
	}

	// Token: 0x04005CBB RID: 23739
	public CharacterControl mChar;

	// Token: 0x04005CBC RID: 23740
	public CharacterControl mOwnerChar;

	// Token: 0x04005CBD RID: 23741
	public AudioClip footStep_run;

	// Token: 0x04005CBE RID: 23742
	public GameObject nAttack_ring;

	// Token: 0x04005CBF RID: 23743
	public GameObject nAttack_hit;

	// Token: 0x04005CC0 RID: 23744
	public GameObject cAttack_ring;

	// Token: 0x04005CC1 RID: 23745
	public GameObject ko_ring;

	// Token: 0x02000E68 RID: 3688
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$34226 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600539A RID: 21402 RVA: 0x00A30404 File Offset: 0x00A2E604
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$34226(Vector3 mPos, Vector3 tDir, int tID, IcePenguinMount self_)
		{
			if (209908 - 505368 != -295460)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (135352 - 133684 == 1668)
				{
					base..ctor();
					if (39972 - 190373 != -150400)
					{
						this.$mPos$34231 = mPos;
						if (58362 - 568727 != -510364)
						{
							this.$tDir$34232 = tDir;
							if (64764 - 253166 != -188401)
							{
								this.$tID$34233 = tID;
								if (26027 - 149737 == -123710)
								{
									this.$self_$34234 = self_;
									if (138559 - 479273 != -340713)
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

		// Token: 0x0600539B RID: 21403 RVA: 0x00A30504 File Offset: 0x00A2E704
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new IcePenguinMount.$RPC_nAttack$34226.$(this.$mPos$34231, this.$tDir$34232, this.$tID$34233, this.$self_$34234);
		}

		// Token: 0x0600539C RID: 21404 RVA: 0x00A30524 File Offset: 0x00A2E724
		internal static bool QU3boh5h1S06hyjsBRxV()
		{
			return true;
		}

		// Token: 0x0600539D RID: 21405 RVA: 0x00A30528 File Offset: 0x00A2E728
		internal static bool pyMnnV5h4o9VKiT77hc9()
		{
			return false;
		}

		// Token: 0x04005CC2 RID: 23746
		internal Vector3 $mPos$34231;

		// Token: 0x04005CC3 RID: 23747
		internal Vector3 $tDir$34232;

		// Token: 0x04005CC4 RID: 23748
		internal int $tID$34233;

		// Token: 0x04005CC5 RID: 23749
		internal IcePenguinMount $self_$34234;

		// Token: 0x02000E69 RID: 3689
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600539E RID: 21406 RVA: 0x00A3052C File Offset: 0x00A2E72C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, IcePenguinMount self_)
			{
				if (109086 - 128011 != -18924)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (25830 - 583291 != -557460)
					{
						base..ctor();
						if (19990 - 193718 != -173727)
						{
							this.$mPos$34227 = mPos;
							if (286499 - 367382 != -80882)
							{
								this.$tDir$34228 = tDir;
								if (107557 - 281707 == -174150)
								{
									this.$tID$34229 = tID;
									if (23796 - 31753 != -7956)
									{
										this.$self_$34230 = self_;
										if (36707 - 298580 == -261873)
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

			// Token: 0x0600539F RID: 21407 RVA: 0x00A3062C File Offset: 0x00A2E82C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (255730 - 265403 != -9672)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_6A4;
					case 2:
						if (this.$self_$34230.mChar.actionState != "attack")
						{
							goto IL_18A;
						}
						if (234288 - 251452 == -17163)
						{
							continue;
						}
						if (this.$self_$34230.mChar.myCommand != "nAttack")
						{
							if (32750 - 424753 != -392002)
							{
								goto IL_18A;
							}
							continue;
						}
						else
						{
							this.$self_$34230.mChar.moveSpeed = (float)0;
							if (280508 - 241665 != 38843)
							{
								continue;
							}
							if (!this.$self_$34230.mChar.isMine)
							{
								goto IL_102;
							}
							if (130589 - 259437 == -128847)
							{
								continue;
							}
							this.$self_$34230.RPC_nAttack_hit(this.$mPos$34227 + this.$tDir$34228, this.$tDir$34228, this.$tID$34229);
							if (131073 - 293534 != -162461)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								goto IL_102;
							}
							if (261194 - 287049 != -25855)
							{
								continue;
							}
							this.$self_$34230.ActionEvent("RPC_nAttack_hit", this.$mPos$34227 + this.$tDir$34228, this.$tDir$34228, this.$tID$34229);
							if (31183 - 494262 != -463079)
							{
								continue;
							}
							goto IL_102;
						}
						break;
					case 3:
						if (this.$self_$34230.mChar.actionState == "attack")
						{
							if (47132 - 496068 == -448935)
							{
								continue;
							}
							if (this.$self_$34230.mChar.myCommand == "nAttack")
							{
								if (278915 - 17035 == 261881)
								{
									continue;
								}
								this.$self_$34230.mChar.actionState = "standby";
								if (185520 - 228787 != -43267)
								{
									continue;
								}
								this.$self_$34230.mChar.actionTime = Time.time;
								if (241218 - 110422 == 130797)
								{
									continue;
								}
								this.$self_$34230.mChar.myCommand = "none";
								if (90469 - 129959 != -39490)
								{
									continue;
								}
								if (!this.$self_$34230.mChar.isMine)
								{
									if (158959 - 189054 != -30095)
									{
										continue;
									}
									this.$self_$34230.mChar.nPosition = this.$self_$34230.transform.position;
									if (14350 - 378761 != -364411)
									{
										continue;
									}
									this.$self_$34230.mChar.oPosition = this.$self_$34230.transform.position;
									if (59490 - 469837 != -410347)
									{
										continue;
									}
									this.$self_$34230.mChar.nDirection = this.$self_$34230.transform.forward;
									if (201611 - 302863 != -101252)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (104144 - 380301 != -276157)
						{
							continue;
						}
						goto IL_6A4;
					default:
						if (77124 - 194486 != -117362)
						{
							continue;
						}
						break;
					}
					this.$self_$34230.mChar.actionState = "attack";
					if (54443 - 558109 == -503666)
					{
						this.$self_$34230.mChar.actionTime = Time.time;
						if (120124 - 532288 != -412163)
						{
							this.$self_$34230.mChar.myCommand = "nAttack";
							if (237106 - 375241 != -138134)
							{
								this.$self_$34230.mChar.addTimeOut("nAttack", this.$self_$34230.mChar.agiAdjust((float)5));
								if (141450 - 53491 == 87959)
								{
									this.$self_$34230.transform.position = this.$mPos$34227;
									if (212039 - 259379 != -47339)
									{
										this.$self_$34230.transform.LookAt(this.$mPos$34227 + global::Math.vFlat(this.$tDir$34228));
										if (216503 - 319077 == -102574)
										{
											this.$self_$34230.animation.CrossFade("nAttack");
											if (137709 - 117219 == 20490)
											{
												this.$self_$34230.animation.wrapMode = WrapMode.Once;
												if (76841 - 104334 == -27493)
												{
													this.$self_$34230.mChar.vMovement = this.$self_$34230.transform.forward;
													if (173706 - 161900 != 11807)
													{
														this.$self_$34230.mChar.moveSpeed = (float)0;
														if (148770 - 146115 != 2656)
														{
															if (this.$self_$34230.nAttack_ring)
															{
																if (70288 - 523597 == -453309)
																{
																	this.$self_$34230.mChar.createEffect(this.$self_$34230.nAttack_ring, this.$self_$34230.transform.position, this.$self_$34230.transform.rotation);
																	if (45210 - 471650 != -426439)
																	{
																		goto Block_31;
																	}
																}
															}
															else
															{
																Debug.LogError("Missing nAttack_ring effect");
																if (293164 - 298974 != -5809)
																{
																	goto Block_15;
																}
															}
														}
													}
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
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_18A:
				goto IL_6A4;
				IL_1EA:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_15:
				Block_31:
				goto IL_1EA;
				IL_6A4:
				return false;
			}

			// Token: 0x060053A0 RID: 21408 RVA: 0x00A30CF0 File Offset: 0x00A2EEF0
			internal static bool jhuPel5hzTQByYD5CKpn()
			{
				return true;
			}

			// Token: 0x060053A1 RID: 21409 RVA: 0x00A30CF4 File Offset: 0x00A2EEF4
			internal static bool wk5FVW5sa1AE1FqLJsAt()
			{
				return false;
			}

			// Token: 0x04005CC6 RID: 23750
			internal Vector3 $mPos$34227;

			// Token: 0x04005CC7 RID: 23751
			internal Vector3 $tDir$34228;

			// Token: 0x04005CC8 RID: 23752
			internal int $tID$34229;

			// Token: 0x04005CC9 RID: 23753
			internal IcePenguinMount $self_$34230;
		}
	}

	// Token: 0x02000E6A RID: 3690
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_cAttack$34235 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060053A2 RID: 21410 RVA: 0x00A30CF8 File Offset: 0x00A2EEF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_cAttack$34235(Vector3 mPos, Vector3 tDir, IcePenguinMount self_)
		{
			if (106244 - 566193 != -459949)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (43897 - 123298 != -79400)
				{
					base..ctor();
					if (73626 - 426801 != -353174)
					{
						this.$mPos$34244 = mPos;
						if (169243 - 35580 != 133664)
						{
							this.$tDir$34245 = tDir;
							if (168724 - 156769 != 11956)
							{
								this.$self_$34246 = self_;
								if (6166 - 208024 != -201857)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060053A3 RID: 21411 RVA: 0x00A30DD4 File Offset: 0x00A2EFD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new IcePenguinMount.$RPC_cAttack$34235.$(this.$mPos$34244, this.$tDir$34245, this.$self_$34246);
		}

		// Token: 0x060053A4 RID: 21412 RVA: 0x00A30DF0 File Offset: 0x00A2EFF0
		internal static bool Ypsd225s5BJ6nv0RuoUO()
		{
			return true;
		}

		// Token: 0x060053A5 RID: 21413 RVA: 0x00A30DF4 File Offset: 0x00A2EFF4
		internal static bool BaVN3q5spbK04pHp4oUW()
		{
			return false;
		}

		// Token: 0x04005CCA RID: 23754
		internal Vector3 $mPos$34244;

		// Token: 0x04005CCB RID: 23755
		internal Vector3 $tDir$34245;

		// Token: 0x04005CCC RID: 23756
		internal IcePenguinMount $self_$34246;

		// Token: 0x02000E6B RID: 3691
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060053A6 RID: 21414 RVA: 0x00A30DF8 File Offset: 0x00A2EFF8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, IcePenguinMount self_)
			{
				if (119316 - 79368 != 39949)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (173292 - 298968 == -125676)
					{
						base..ctor();
						if (18912 - 300758 == -281846)
						{
							this.$mPos$34241 = mPos;
							if (121525 - 248743 == -127218)
							{
								this.$tDir$34242 = tDir;
								if (178125 - 231635 != -53509)
								{
									this.$self_$34243 = self_;
									if (25024 - 332753 != -307728)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060053A7 RID: 21415 RVA: 0x00A30ED4 File Offset: 0x00A2F0D4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (280201 - 146116 != 134085)
				{
				}
				for (;;)
				{
					IL_74F:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_8F0;
					case 2:
						if (this.$self_$34243.mChar.actionState != "attack")
						{
							goto IL_65D;
						}
						if (41113 - 176501 != -135388)
						{
							continue;
						}
						if (this.$self_$34243.mChar.myCommand != "cAttack")
						{
							if (90245 - 463672 != -373426)
							{
								goto Block_23;
							}
							continue;
						}
						else
						{
							this.$self_$34243.mChar.moveSpeed = (float)8;
							if (168921 - 469410 != -300489)
							{
								continue;
							}
							if (this.$self_$34243.cAttack_ring)
							{
								if (294376 - 150850 != 143526)
								{
									continue;
								}
								this.$self_$34243.mChar.createEffect(this.$self_$34243.cAttack_ring, this.$self_$34243.transform.position, this.$self_$34243.transform.rotation);
								if (251609 - 430058 != -178449)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing cAttack_ring effect");
								if (175417 - 537286 == -361868)
								{
									continue;
								}
							}
							this.$i$34236 = 1;
							if (84290 - 202774 != -118484)
							{
								continue;
							}
							goto IL_636;
						}
						break;
					case 3:
						if (this.$self_$34243.mChar.actionState != "attack")
						{
							goto IL_814;
						}
						if (127577 - 151396 == -23818)
						{
							continue;
						}
						if (this.$self_$34243.mChar.myCommand != "cAttack")
						{
							if (131420 - 565151 != -433730)
							{
								goto IL_814;
							}
							continue;
						}
						else
						{
							this.$self_$34243.mChar.moveSpeed = (float)(12 - this.$i$34236);
							if (80008 - 69418 == 10591)
							{
								continue;
							}
							if (this.$self_$34243.mChar.isMine)
							{
								if (204992 - 512109 != -307117)
								{
									continue;
								}
								this.$hitLayer$34237 = 130816 - (1 << this.$self_$34243.gameObject.layer);
								if (270546 - 83362 == 187185)
								{
									continue;
								}
								this.$hitList$34238 = Damage.FindRecTarget(this.$self_$34243.transform.position, this.$self_$34243.transform.forward, (float)2, (float)2, (float)3, (float)3, this.$hitLayer$34237);
								if (229837 - 482383 != -252546)
								{
									continue;
								}
								this.$$iterator$10893$34240 = UnityRuntimeServices.GetEnumerator(this.$hitList$34238);
								if (146067 - 448418 == -302350)
								{
									continue;
								}
								while (this.$$iterator$10893$34240.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$10893$34240.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$34239 = (GameObject)obj2;
									if (279827 - 423727 != -143900)
									{
										goto IL_74F;
									}
									this.$self_$34243.mChar.hit(1, this.$hitObject$34239, (int)(0.5f * (float)this.$self_$34243.mChar.atk + (float)this.$self_$34243.mOwnerChar.talAdjust(15)), 3, 0, Vector3.zero);
									if (294212 - 219988 != 74224)
									{
										goto IL_74F;
									}
									UnityRuntimeServices.Update(this.$$iterator$10893$34240, this.$hitObject$34239);
									if (11214 - 328517 != -317303)
									{
										goto IL_74F;
									}
								}
								if (69180 - 444610 == -375429)
								{
									continue;
								}
							}
							this.$i$34236++;
							if (181254 - 535477 != -354222)
							{
								goto IL_636;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$34243.mChar.actionState == "attack")
						{
							if (144478 - 174941 == -30462)
							{
								continue;
							}
							if (this.$self_$34243.mChar.myCommand == "cAttack")
							{
								if (253353 - 553903 == -300549)
								{
									continue;
								}
								this.$self_$34243.mChar.actionState = "standby";
								if (257823 - 327523 != -69700)
								{
									continue;
								}
								this.$self_$34243.mChar.actionTime = Time.time;
								if (229329 - 29856 != 199473)
								{
									continue;
								}
								this.$self_$34243.mChar.myCommand = "none";
								if (145629 - 120057 == 25573)
								{
									continue;
								}
								if (!this.$self_$34243.mChar.isMine)
								{
									if (290344 - 376061 != -85717)
									{
										continue;
									}
									this.$self_$34243.mChar.nPosition = this.$self_$34243.transform.position;
									if (105894 - 431860 == -325965)
									{
										continue;
									}
									this.$self_$34243.mChar.oPosition = this.$self_$34243.transform.position;
									if (47005 - 361850 != -314845)
									{
										continue;
									}
									this.$self_$34243.mChar.nDirection = this.$self_$34243.transform.forward;
									if (141584 - 418616 == -277031)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (184181 - 247561 != -63379)
						{
							goto Block_31;
						}
						continue;
					default:
						if (48821 - 39879 == 8943)
						{
							continue;
						}
						break;
					}
					this.$self_$34243.mChar.actionState = "attack";
					if (299190 - 367294 != -68104)
					{
						continue;
					}
					this.$self_$34243.mChar.actionTime = Time.time;
					if (128835 - 551303 != -422468)
					{
						continue;
					}
					this.$self_$34243.mChar.myCommand = "cAttack";
					if (179699 - 280816 != -101117)
					{
						continue;
					}
					this.$self_$34243.mChar.addTimeOut("cAttack", this.$self_$34243.mChar.agiAdjust((float)6));
					if (75569 - 240987 == -165417)
					{
						continue;
					}
					this.$self_$34243.transform.position = this.$mPos$34241;
					if (285962 - 201897 != 84065)
					{
						continue;
					}
					this.$self_$34243.transform.LookAt(this.$mPos$34241 + global::Math.vFlat(this.$tDir$34242));
					if (6469 - 515481 != -509012)
					{
						continue;
					}
					this.$self_$34243.animation.CrossFade("cAttack");
					if (61903 - 65452 != -3549)
					{
						continue;
					}
					this.$self_$34243.animation.wrapMode = WrapMode.Once;
					if (46907 - 311160 == -264252)
					{
						continue;
					}
					this.$self_$34243.mChar.vMovement = this.$self_$34243.transform.forward;
					if (243622 - 521039 != -277417)
					{
						continue;
					}
					this.$self_$34243.mChar.moveSpeed = (float)0;
					if (230518 - 101771 != 128748)
					{
						goto Block_35;
					}
					continue;
					IL_636:
					if (this.$i$34236 <= 12)
					{
						break;
					}
					if (170160 - 201893 == -31733)
					{
						goto IL_33B;
					}
				}
				return this.Yield(3, new WaitForSeconds(0.15f));
				IL_33B:
				return this.Yield(4, new WaitForSeconds(0.2f));
				Block_23:
				Block_31:
				goto IL_8F0;
				Block_35:
				return this.Yield(2, new WaitForSeconds(0.2f));
				IL_65D:
				IL_814:
				IL_8F0:
				return false;
			}

			// Token: 0x060053A8 RID: 21416 RVA: 0x00A317E4 File Offset: 0x00A2F9E4
			internal static bool av7ydT5sVU7B8DpWKQBX()
			{
				return true;
			}

			// Token: 0x060053A9 RID: 21417 RVA: 0x00A317E8 File Offset: 0x00A2F9E8
			internal static bool k6A4jF5stYNTIH5TeijE()
			{
				return false;
			}

			// Token: 0x04005CCD RID: 23757
			internal int $i$34236;

			// Token: 0x04005CCE RID: 23758
			internal int $hitLayer$34237;

			// Token: 0x04005CCF RID: 23759
			internal UnityScript.Lang.Array $hitList$34238;

			// Token: 0x04005CD0 RID: 23760
			internal GameObject $hitObject$34239;

			// Token: 0x04005CD1 RID: 23761
			internal IEnumerator $$iterator$10893$34240;

			// Token: 0x04005CD2 RID: 23762
			internal Vector3 $mPos$34241;

			// Token: 0x04005CD3 RID: 23763
			internal Vector3 $tDir$34242;

			// Token: 0x04005CD4 RID: 23764
			internal IcePenguinMount $self_$34243;
		}
	}
}
