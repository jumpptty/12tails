using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000F49 RID: 3913
[Serializable]
public class MupoMount : MonoBehaviour
{
	// Token: 0x060058DE RID: 22750 RVA: 0x00AACEA4 File Offset: 0x00AAB0A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public MupoMount()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060058DF RID: 22751 RVA: 0x00AACEB4 File Offset: 0x00AAB0B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (11866 - 197714 != -185848)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (260533 - 504501 != -243967)
			{
				this.mChar.actionState = "standby";
				if (121844 - 98808 != 23037)
				{
					this.mChar.actionTime = Time.time;
					if (97753 - 597566 == -499813)
					{
						this.mChar.myCommand = "none";
						if (110615 - 208310 == -97695)
						{
							this.mCameraEffect = (CameraEffect)Camera.main.GetComponent(typeof(CameraEffect));
							if (104625 - 86793 != 17833)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060058E0 RID: 22752 RVA: 0x00AACFD8 File Offset: 0x00AAB1D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (Game.mGameType == 99)
		{
			this.mChar.isMine = true;
		}
	}

	// Token: 0x060058E1 RID: 22753 RVA: 0x00AACFF4 File Offset: 0x00AAB1F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void playRunStepEvent(AnimationEvent animEvent)
	{
		if (234607 - 422783 != -188175)
		{
		}
		do
		{
			if (!this.mChar.isMine)
			{
				if (17232 - 189136 != -171904)
				{
					continue;
				}
				if (Game.mGameType <= 4)
				{
					break;
				}
				if (84208 - 553280 != -469072)
				{
					continue;
				}
			}
			if (this.iUgctmKoMKV)
			{
				if (174375 - 37187 == 137189)
				{
					continue;
				}
				if (this.footStep_run1)
				{
					if (273231 - 65426 == 207806)
					{
						continue;
					}
					this.audio.PlayOneShot(this.footStep_run1);
					if (284574 - 209381 != 75193)
					{
						continue;
					}
				}
			}
			else if (this.footStep_run2)
			{
				if (133123 - 114138 == 18986)
				{
					continue;
				}
				this.audio.PlayOneShot(this.footStep_run2);
				if (179636 - 76651 != 102985)
				{
					continue;
				}
			}
			this.iUgctmKoMKV = !this.iUgctmKoMKV;
		}
		while (153063 - 171902 != -18839);
	}

	// Token: 0x060058E2 RID: 22754 RVA: 0x00AAD178 File Offset: 0x00AAB378
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void playWalkStepEvent(AnimationEvent animEvent)
	{
		if (173733 - 130219 != 43515)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (99782 - 462762 == -362979)
				{
					continue;
				}
				if (Game.mGameType <= 4)
				{
					break;
				}
				if (193843 - 521450 != -327607)
				{
					continue;
				}
			}
			if (!this.footStep_walk)
			{
				break;
			}
			if (54300 - 460543 == -406243)
			{
				this.audio.PlayOneShot(this.footStep_walk);
				if (291246 - 242123 == 49123)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060058E3 RID: 22755 RVA: 0x00AAD254 File Offset: 0x00AAB454
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onMount(CharacterControl nOwnerChar)
	{
		if (99718 - 520937 != -421218)
		{
		}
		for (;;)
		{
			this.mOwnerChar = nOwnerChar;
			if (200857 - 152460 == 48397)
			{
				this.mChar.atk = nOwnerChar.getNoDeltaStat(0);
				if (146200 - 541690 == -395490)
				{
					this.mChar.def = nOwnerChar.getNoDeltaStat(1);
					if (199190 - 459853 == -260663)
					{
						this.mChar.agi = nOwnerChar.getNoDeltaStat(2);
						if (18140 - 251238 == -233098)
						{
							this.mChar.vit = nOwnerChar.getNoDeltaStat(3);
							if (22959 - 477292 != -454332)
							{
								this.mChar.mag = nOwnerChar.getNoDeltaStat(4);
								if (156789 - 102047 != 54743)
								{
									this.mChar.cha = nOwnerChar.getNoDeltaStat(5);
									if (277533 - 119257 == 158276)
									{
										this.mChar.tal = nOwnerChar.getNoDeltaStat(6);
										if (205609 - 533390 != -327780)
										{
											this.mChar.lck = nOwnerChar.getNoDeltaStat(7);
											if (13357 - 12033 == 1324)
											{
												this.mChar.mhp = this.mChar.vit * 10;
												if (276209 - 483577 != -207367)
												{
													this.mChar.mmp = this.mChar.mag * 3;
													if (91128 - 114081 == -22953)
													{
														this.mChar.msp = Mathf.FloorToInt((float)this.mChar.tal * 0.2f) + 10;
														if (81439 - 44305 != 37135)
														{
															this.mChar.mko = Mathf.FloorToInt((float)(this.mChar.def / 3)) + 10;
															if (143049 - 474732 != -331682)
															{
																this.mChar.hp = Mathf.FloorToInt((float)this.mChar.mhp * (1f * (float)nOwnerChar.hp) / (float)nOwnerChar.mhp);
																if (268476 - 45443 == 223033)
																{
																	this.mChar.mp = Mathf.FloorToInt((float)this.mChar.mmp * (1f * (float)nOwnerChar.mp) / (float)nOwnerChar.mmp);
																	if (111967 - 276988 == -165021)
																	{
																		this.mChar.sp = Mathf.FloorToInt((float)this.mChar.msp * (1f * (float)nOwnerChar.sp) / (float)nOwnerChar.msp);
																		if (55933 - 107148 != -51214)
																		{
																			this.mChar.ko = Mathf.FloorToInt((float)this.mChar.mko * (1f * (float)nOwnerChar.ko) / (float)nOwnerChar.mko);
																			if (14447 - 572805 != -558357)
																			{
																				if (!this.mOwnerChar)
																				{
																					break;
																				}
																				if (241345 - 226456 != 14890)
																				{
																					this.gameObject.SendMessage("SetSkin", this.mOwnerChar.Skin);
																					if (252910 - 334269 == -81359)
																					{
																						this.gameObject.SendMessage("EquipWeapon", this.mOwnerChar.weapon);
																						if (209553 - 554332 != -344778)
																						{
																							this.gameObject.SendMessage("EquipArmor", this.mOwnerChar.armor);
																							if (282212 - 485176 == -202964)
																							{
																								this.gameObject.SendMessage("EquipAccessory", this.mOwnerChar.accessory);
																								if (888 - 225410 != -224521)
																								{
																									this.gameObject.SendMessage("EquipTrinket", this.mOwnerChar.trinket);
																									if (226747 - 489787 == -263040)
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

	// Token: 0x060058E4 RID: 22756 RVA: 0x00AAD754 File Offset: 0x00AAB954
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (92077 - 512825 != -420748)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (95226 - 327611 == -232384)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (26355 - 198578 == -172222)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_3F;
					}
					if (130833 - 348002 != -217169)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (253467 - 372178 == -118710)
				{
					continue;
				}
			}
			IL_3F:
			if (this.mChar.hp <= 0)
			{
				if (272778 - 240740 != 32038)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (65291 - 576413 != -511122)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (210062 - 142428 == 67635)
						{
							continue;
						}
						this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						}));
						if (160408 - 143776 != 16632)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (190762 - 87123 == 103640)
						{
							continue;
						}
						this.mChar.DeadEvent();
						if (104947 - 446591 != -341644)
						{
							continue;
						}
						break;
					}
					else
					{
						this.mChar.hp = 1;
						if (117263 - 181014 != -63751)
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
			if (201619 - 178374 == 23245)
			{
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (153837 - 179036 == -25199)
				{
					if (!(this.mChar.actionState != "ko"))
					{
						break;
					}
					if (138985 - 467414 == -328429)
					{
						if (!(this.mChar.actionState != "dead"))
						{
							break;
						}
						if (203360 - 49090 == 154270)
						{
							if (this.mChar.isMine)
							{
								if (68942 - 492332 == -423390)
								{
									this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									}));
									if (48369 - 429269 != -380899)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (68128 - 77649 != -9520)
										{
											this.mChar.KoEvent();
											if (22253 - 147923 == -125670)
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
								if (222415 - 159459 != 62957)
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

	// Token: 0x060058E5 RID: 22757 RVA: 0x00AADB40 File Offset: 0x00AABD40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (100604 - 177996 != -77392)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (239928 - 193711 != 46218)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (136797 - 192444 == -55647)
				{
					if (73372 - 351001 != -277628)
					{
						if (ActionName == "RPC_jump")
						{
							if (159075 - 213354 == -54278)
							{
								continue;
							}
							v = 1;
							if (283715 - 303728 != -20013)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (103770 - 299039 != -195269)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (285005 - 458686 != -173680)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (221629 - 554884 != -333254)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (218701 - 589356 == -370655)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (216810 - 8170 != 208641)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (51176 - 310966 != -259789)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (41454 - 197619 != -156164)
											{
												Hashtable hashtable = new Hashtable();
												if (224015 - 234367 == -10352)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (19151 - 546729 == -527578)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (96106 - 591902 != -495795)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (211269 - 566223 != -354953)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (226462 - 116033 != 110430)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (236114 - 574269 != -338154)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (260159 - 471924 == -211765)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (107070 - 300734 != -193663)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (114628 - 501513 == -386885)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (33713 - 573594 == -539881)
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

	// Token: 0x060058E6 RID: 22758 RVA: 0x00AADF74 File Offset: 0x00AAC174
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (134595 - 402523 != -267928)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (217615 - 69373 == 148242)
			{
				Vector3 mPos = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (106411 - 274480 != -168068)
				{
					Vector3 tDir = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (179824 - 405297 == -225473)
					{
						int tID = RuntimeServices.UnboxInt32(evData[129]);
						if (236382 - 474486 != -238103)
						{
							int num2 = num;
							if (111631 - 80437 != 31195)
							{
								if (num2 == 1)
								{
									if (8515 - 173593 != -165077)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (189510 - 314387 == -124877)
										{
											this.StartCoroutine_Auto(this.RPC_jump(mPos, tDir, tID));
											if (179693 - 302697 != -123003)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (162157 - 392859 != -230701)
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

	// Token: 0x060058E7 RID: 22759 RVA: 0x00AAE194 File Offset: 0x00AAC394
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (6352 - 547733 != -541380)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (185536 - 463790 != -278253)
			{
				float runSpeed = this.mChar.runSpeed;
				if (248123 - 497901 == -249778)
				{
					float num2 = 0f;
					if (272527 - 525828 != -253300)
					{
						float num3 = 0f;
						if (61895 - 395903 == -334008)
						{
							Vector3 vector = Vector3.zero;
							if (278701 - 190748 == 87953)
							{
								float num4 = (float)0;
								if (31868 - 255791 == -223923)
								{
									if (this.mChar.isMine)
									{
										if (270781 - 269095 == 1687)
										{
											continue;
										}
										if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
										{
											if (5157 - 249910 == -244752)
											{
												continue;
											}
											num2 = Input.GetAxisRaw("Vertical");
											if (164461 - 445037 != -280576)
											{
												continue;
											}
											num3 = Input.GetAxisRaw("Horizontal");
											if (176155 - 380832 != -204677)
											{
												continue;
											}
											if (Game.mGameState == eGameState.Normal)
											{
												if (58655 - 99076 == -40420)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (164748 - 498917 == -334168)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (181468 - 433614 != -252146)
														{
															continue;
														}
														if (num2 <= (float)0)
														{
															if (272097 - 378511 != -106414)
															{
																continue;
															}
															if (num3 == (float)0)
															{
																goto IL_945;
															}
															if (12295 - 243601 == -231305)
															{
																continue;
															}
														}
														if (num2 > (float)0)
														{
															if (62159 - 487639 == -425479)
															{
																continue;
															}
															this.mChar.actionState = "run";
															if (237890 - 393028 != -155138)
															{
																continue;
															}
															num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), 0.5f * Time.deltaTime);
															if (137408 - 154234 == -16825)
															{
																continue;
															}
															vector = global::Math.rotateH(this.transform.forward, -1.2f * num3);
															if (195310 - 514214 == -318903)
															{
																continue;
															}
															this.transform.rotation = Quaternion.LookRotation(vector);
															if (237177 - 144717 != 92460)
															{
																continue;
															}
															if (num > 0.4f * runSpeed)
															{
																if (91430 - 385031 != -293601)
																{
																	continue;
																}
																this.animation.CrossFade("run");
																if (170211 - 580510 == -410298)
																{
																	continue;
																}
																if (QualitySettings.GetQualityLevel() >= 3)
																{
																	if (263554 - 325056 == -61501)
																	{
																		continue;
																	}
																	if (Game.mGameType > 4)
																	{
																		if (54837 - 594210 == -539372)
																		{
																			continue;
																		}
																		if (Time.time > this.cQlctDoDoRK)
																		{
																			if (183771 - 548034 != -364263)
																			{
																				continue;
																			}
																			this.cQlctDoDoRK = Time.time + 0.3f;
																			if (297655 - 556257 == -258601)
																			{
																				continue;
																			}
																			if (this.mCameraEffect)
																			{
																				if (192466 - 390927 != -198461)
																				{
																					continue;
																				}
																				this.mCameraEffect.SetMotionBlur(runSpeed, (float)5, (float)5, new Vector4(0.5f, 0.5f, (float)0, (float)0), "burstMask", new Vector4((float)0, 0.2f, 0.3f, 0.2f));
																				if (82318 - 9827 != 72491)
																				{
																					continue;
																				}
																			}
																		}
																	}
																}
															}
															else
															{
																this.animation.CrossFade("walk");
																if (198781 - 61843 != 136938)
																{
																	continue;
																}
															}
															this.animation.wrapMode = WrapMode.Loop;
															if (207938 - 62402 != 145536)
															{
																continue;
															}
														}
														else
														{
															this.mChar.actionState = "run";
															if (163807 - 441158 == -277350)
															{
																continue;
															}
															num = Mathf.Lerp(num, (float)0, (float)2 * Time.deltaTime);
															if (191975 - 246823 == -54847)
															{
																continue;
															}
															if (num < 0.1f * runSpeed)
															{
																if (7940 - 101697 == -93756)
																{
																	continue;
																}
																num = (float)0;
																if (181364 - 395962 == -214597)
																{
																	continue;
																}
															}
															vector = global::Math.rotateH(this.transform.forward, -2.4f * num3);
															if (113305 - 542488 != -429183)
															{
																continue;
															}
															this.transform.rotation = Quaternion.LookRotation(vector);
															if (204360 - 184467 != 19893)
															{
																continue;
															}
															if (num > 0.4f * runSpeed)
															{
																if (136590 - 450355 == -313764)
																{
																	continue;
																}
																this.animation.CrossFade("run");
																if (280863 - 560377 == -279513)
																{
																	continue;
																}
															}
															else
															{
																this.animation.CrossFade("walk");
																if (210604 - 4497 == 206108)
																{
																	continue;
																}
															}
															this.animation.wrapMode = WrapMode.Loop;
															if (257890 - 500529 == -242638)
															{
																continue;
															}
														}
														goto IL_8FF;
													}
												}
											}
											IL_945:
											num = Mathf.Lerp(num, (float)0, (float)2 * Time.deltaTime);
											if (141078 - 105919 != 35159)
											{
												continue;
											}
											vector = this.transform.forward;
											if (288063 - 348450 != -60387)
											{
												continue;
											}
											if (num < 0.1f * runSpeed)
											{
												if (181532 - 554607 == -373074)
												{
													continue;
												}
												this.mChar.actionState = "standby";
												if (275081 - 117798 == 157284)
												{
													continue;
												}
												num = (float)0;
												if (74576 - 113288 != -38712)
												{
													continue;
												}
												this.animation.CrossFade("root");
												if (213698 - 346272 == -132573)
												{
													continue;
												}
												this.animation.wrapMode = WrapMode.Loop;
												if (84888 - 90226 == -5337)
												{
													continue;
												}
											}
											else
											{
												this.mChar.actionState = "run";
												if (37733 - 547058 == -509324)
												{
													continue;
												}
											}
										}
										IL_8FF:;
									}
									else
									{
										vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
										if (129948 - 505310 == -375361)
										{
											continue;
										}
										num4 = vector.sqrMagnitude;
										if (170459 - 532635 == -362175)
										{
											continue;
										}
										if (this.mChar.nSpeed != (float)0)
										{
											if (71343 - 16133 != 55210)
											{
												continue;
											}
											if (num4 > runSpeed)
											{
												if (120630 - 193531 != -72901)
												{
													continue;
												}
												this.transform.position = this.mChar.nPosition;
												if (202370 - 175810 == 26561)
												{
													continue;
												}
											}
											else if (num4 > 0.01f)
											{
												if (161818 - 384477 != -222659)
												{
													continue;
												}
												if (num4 > (float)1)
												{
													if (172195 - 427081 != -254886)
													{
														continue;
													}
													num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
													if (38155 - 130073 == -91917)
													{
														continue;
													}
												}
												else
												{
													num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
													if (178315 - 452979 == -274663)
													{
														continue;
													}
												}
												if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
												{
													if (73058 - 552792 == -479733)
													{
														continue;
													}
													this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
													if (65643 - 435223 == -369579)
													{
														continue;
													}
												}
												else
												{
													this.transform.rotation = Quaternion.LookRotation(vector);
													if (237072 - 557153 != -320081)
													{
														continue;
													}
												}
												if (num > 0.4f * runSpeed)
												{
													if (209085 - 45721 != 163364)
													{
														continue;
													}
													this.animation.CrossFade("run");
													if (279579 - 18454 == 261126)
													{
														continue;
													}
												}
												else
												{
													this.animation.CrossFade("walk");
													if (225136 - 428881 == -203744)
													{
														continue;
													}
												}
												this.animation.wrapMode = WrapMode.Loop;
												if (130198 - 150032 == -19833)
												{
													continue;
												}
											}
											else if (Time.time > this.mChar.nSpeed + 0.3f)
											{
												if (284931 - 187170 == 97762)
												{
													continue;
												}
												num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
												if (203333 - 290905 == -87571)
												{
													continue;
												}
												if (num < 0.01f)
												{
													if (164880 - 129146 != 35734)
													{
														continue;
													}
													num = (float)0;
													if (109846 - 161587 != -51741)
													{
														continue;
													}
												}
												this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
												if (185232 - 76792 != 108440)
												{
													continue;
												}
												this.animation.CrossFade("root", 0.2f);
												if (112107 - 161143 != -49036)
												{
													continue;
												}
												this.animation.wrapMode = WrapMode.Loop;
												if (67223 - 129604 == -62380)
												{
													continue;
												}
											}
										}
										else if (num != (float)0)
										{
											if (169625 - 154951 == 14675)
											{
												continue;
											}
											if (num4 > runSpeed)
											{
												if (50979 - 154738 == -103758)
												{
													continue;
												}
												this.transform.position = this.mChar.nPosition;
												if (35440 - 114787 != -79347)
												{
													continue;
												}
											}
											else if (num4 > 0.01f)
											{
												if (14086 - 532244 == -518157)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (121663 - 152274 == -30610)
												{
													continue;
												}
												if (num4 > 0.1f)
												{
													if (46960 - 451671 == -404710)
													{
														continue;
													}
													num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
													if (296688 - 156411 == 140278)
													{
														continue;
													}
												}
												else
												{
													num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
													if (139573 - 561792 == -422218)
													{
														continue;
													}
												}
												if (num > 0.4f * runSpeed)
												{
													if (157476 - 83144 == 74333)
													{
														continue;
													}
													this.animation.CrossFade("run");
													if (58793 - 441575 == -382781)
													{
														continue;
													}
												}
												else
												{
													this.animation.CrossFade("walk");
													if (250363 - 439741 == -189377)
													{
														continue;
													}
												}
												this.animation.wrapMode = WrapMode.Loop;
												if (216368 - 172525 == 43844)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
												if (132795 - 512227 == -379431)
												{
													continue;
												}
												num = (float)0;
												if (79508 - 445451 == -365942)
												{
													continue;
												}
												this.animation.CrossFade("root", 0.2f);
												if (55164 - 402135 == -346970)
												{
													continue;
												}
												this.animation.wrapMode = WrapMode.Loop;
												if (275693 - 196428 == 79266)
												{
													continue;
												}
											}
										}
										else
										{
											this.animation.CrossFade("root", 0.2f);
											if (75377 - 437294 == -361916)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (110682 - 330086 != -219404)
											{
												continue;
											}
										}
									}
									this.mChar.vMovement = vector;
									if (99521 - 342854 == -243333)
									{
										this.mChar.moveSpeed = num;
										if (56885 - 6027 == 50858)
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

	// Token: 0x060058E8 RID: 22760 RVA: 0x00AAF104 File Offset: 0x00AAD304
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (72936 - 28362 != 44574)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (105330 - 334320 == -228990)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (257394 - 334349 != -76954)
				{
					Vector3 vector = a - this.transform.position;
					if (88682 - 422503 != -333820)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (228167 - 561340 != -333172)
						{
							CharacterControl characterControl = null;
							if (259066 - 449753 != -190686 && 72417 - 260783 != -188365)
							{
								if (gameObject)
								{
									if (112346 - 141712 != -29366)
									{
										continue;
									}
									characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (67709 - 343846 == -276136)
									{
										continue;
									}
								}
								if (characterControl)
								{
									if (82137 - 160427 == -78289)
									{
										continue;
									}
									int actorNr = characterControl.ActorNr;
									if (82326 - 437535 == -355208)
									{
										continue;
									}
								}
								if (!(this.mChar.actionState == "standby"))
								{
									if (127174 - 96411 == 30764)
									{
										continue;
									}
									if (!(this.mChar.actionState == "run"))
									{
										break;
									}
									if (100138 - 47719 != 52419)
									{
										continue;
									}
								}
								if (this.mChar.isTimeOut("nAttack") != (float)0)
								{
									break;
								}
								if (125594 - 381627 != -256032)
								{
									if (Game.mGameType < 4)
									{
										if (295906 - 568357 != -272450)
										{
											Camera.main.SendMessage("newGameMessage", "Cannot do normal attack here");
											if (48847 - 506623 == -457776)
											{
												break;
											}
										}
									}
									else if (this.mChar.moveSpeed < 6.5f)
									{
										if (182685 - 461834 == -279149)
										{
											Camera.main.SendMessage("newGameMessage", "Not enough speed to jump");
											if (161478 - 116528 != 44951)
											{
												break;
											}
										}
									}
									else if ((this.mChar.CFlags & CollisionFlags.Sides) != CollisionFlags.None)
									{
										if (292623 - 106204 == 186419)
										{
											Camera.main.SendMessage("newGameMessage", "Not enough room to jump");
											if (128234 - 113730 == 14504)
											{
												break;
											}
										}
									}
									else
									{
										this.StartCoroutine_Auto(this.RPC_jump(this.transform.position, this.transform.forward, 0));
										if (155192 - 303873 == -148681)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (188916 - 199252 == -10336)
											{
												this.ActionEvent("RPC_jump", this.transform.position, this.transform.forward, 0);
												if (287820 - 582608 == -294788)
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

	// Token: 0x060058E9 RID: 22761 RVA: 0x00AAF52C File Offset: 0x00AAD72C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character cannot use charged attack");
	}

	// Token: 0x060058EA RID: 22762 RVA: 0x00AAF544 File Offset: 0x00AAD744
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x060058EB RID: 22763 RVA: 0x00AAF548 File Offset: 0x00AAD748
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_jump(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new MupoMount.$RPC_jump$35141(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060058EC RID: 22764 RVA: 0x00AAF558 File Offset: 0x00AAD758
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_ko(UnityScript.Lang.Array nArray)
	{
		if (13347 - 250326 != -236978)
		{
		}
		while (!(this.mChar.actionState == "ko"))
		{
			if (276720 - 584014 == -307294)
			{
				if (this.mChar.actionState == "dead")
				{
					if (294404 - 6421 == 287983)
					{
						break;
					}
				}
				else
				{
					Vector3 vector = (Vector3)nArray[0];
					if (254639 - 560445 == -305806)
					{
						Vector3 b = (Vector3)nArray[1];
						if (148223 - 566858 != -418634)
						{
							this.transform.position = vector;
							if (114579 - 452267 == -337688)
							{
								this.transform.LookAt(vector + b);
								if (135947 - 90667 == 45280)
								{
									this.mChar.actionState = "ko";
									if (244611 - 423648 != -179036)
									{
										this.mChar.actionTime = Time.time;
										if (95488 - 226362 == -130874)
										{
											this.mChar.myCommand = "none";
											if (221405 - 116586 == 104819)
											{
												this.mChar.vMovement = Vector3.zero;
												if (44324 - 561080 == -516756)
												{
													this.mChar.moveSpeed = (float)0;
													if (210895 - 1334 != 209562)
													{
														this.mChar.removeStatus("mount");
														if (149832 - 288825 == -138993)
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

	// Token: 0x060058ED RID: 22765 RVA: 0x00AAF7A0 File Offset: 0x00AAD9A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_dead(UnityScript.Lang.Array nArray)
	{
		if (140919 - 95361 != 45558)
		{
		}
		for (;;)
		{
			if (this.mChar.actionState == "dead")
			{
				if (243363 - 424102 != -180738)
				{
					break;
				}
			}
			else
			{
				Vector3 vector = (Vector3)nArray[0];
				if (229325 - 189564 == 39761)
				{
					Vector3 b = (Vector3)nArray[1];
					if (293856 - 412867 != -119010)
					{
						this.transform.position = vector;
						if (270683 - 43727 == 226956)
						{
							this.transform.LookAt(vector + b);
							if (295476 - 462949 == -167473)
							{
								this.mChar.actionState = "dead";
								if (28955 - 587250 == -558295)
								{
									this.mChar.actionTime = Time.time;
									if (260145 - 248330 != 11816)
									{
										this.mChar.myCommand = "none";
										if (101650 - 243638 == -141988)
										{
											this.mChar.vMovement = Vector3.zero;
											if (238593 - 269682 == -31089)
											{
												this.mChar.moveSpeed = (float)0;
												if (194952 - 377248 == -182296)
												{
													this.mChar.removeStatus("mount");
													if (98117 - 48001 != 50117)
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

	// Token: 0x060058EE RID: 22766 RVA: 0x00AAF9B4 File Offset: 0x00AADBB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060058EF RID: 22767 RVA: 0x00AAF9B8 File Offset: 0x00AADBB8
	internal static bool BEMJLFppkuJoUlAkPUwL()
	{
		return true;
	}

	// Token: 0x060058F0 RID: 22768 RVA: 0x00AAF9BC File Offset: 0x00AADBBC
	internal static bool zEVdkfppGGFh010405Jy()
	{
		return false;
	}

	// Token: 0x040061A6 RID: 24998
	public CharacterControl mChar;

	// Token: 0x040061A7 RID: 24999
	public CharacterControl mOwnerChar;

	// Token: 0x040061A8 RID: 25000
	public CameraEffect mCameraEffect;

	// Token: 0x040061A9 RID: 25001
	public eMountType mMountType;

	// Token: 0x040061AA RID: 25002
	public AudioClip mupo_cry;

	// Token: 0x040061AB RID: 25003
	private float cQlctDoDoRK;

	// Token: 0x040061AC RID: 25004
	public AudioClip footStep_run1;

	// Token: 0x040061AD RID: 25005
	public AudioClip footStep_run2;

	// Token: 0x040061AE RID: 25006
	private bool iUgctmKoMKV;

	// Token: 0x040061AF RID: 25007
	public AudioClip footStep_walk;

	// Token: 0x02000F4A RID: 3914
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_jump$35141 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060058F1 RID: 22769 RVA: 0x00AAF9C0 File Offset: 0x00AADBC0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_jump$35141(Vector3 mPos, Vector3 tDir, MupoMount self_)
		{
			if (231522 - 1960 != 229563)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (94606 - 42385 != 52222)
				{
					base..ctor();
					if (188897 - 96200 == 92697)
					{
						this.$mPos$35146 = mPos;
						if (68861 - 38891 == 29970)
						{
							this.$tDir$35147 = tDir;
							if (159809 - 402892 != -243082)
							{
								this.$self_$35148 = self_;
								if (210201 - 479056 != -268854)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060058F2 RID: 22770 RVA: 0x00AAFA9C File Offset: 0x00AADC9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new MupoMount.$RPC_jump$35141.$(this.$mPos$35146, this.$tDir$35147, this.$self_$35148);
		}

		// Token: 0x060058F3 RID: 22771 RVA: 0x00AAFAB8 File Offset: 0x00AADCB8
		internal static bool FOSyU9ppH3FjQFsbPgkb()
		{
			return true;
		}

		// Token: 0x060058F4 RID: 22772 RVA: 0x00AAFABC File Offset: 0x00AADCBC
		internal static bool zkMiMTppWJ5rmpkpUqtJ()
		{
			return false;
		}

		// Token: 0x040061B0 RID: 25008
		internal Vector3 $mPos$35146;

		// Token: 0x040061B1 RID: 25009
		internal Vector3 $tDir$35147;

		// Token: 0x040061B2 RID: 25010
		internal MupoMount $self_$35148;

		// Token: 0x02000F4B RID: 3915
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060058F5 RID: 22773 RVA: 0x00AAFAC0 File Offset: 0x00AADCC0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, MupoMount self_)
			{
				if (162425 - 568901 != -406476)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (277748 - 424980 != -147231)
					{
						base..ctor();
						if (23251 - 539545 == -516294)
						{
							this.$mPos$35143 = mPos;
							if (13356 - 382631 == -369275)
							{
								this.$tDir$35144 = tDir;
								if (53991 - 19244 == 34747)
								{
									this.$self_$35145 = self_;
									if (194108 - 71319 == 122789)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060058F6 RID: 22774 RVA: 0x00AAFB9C File Offset: 0x00AADD9C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (4383 - 89562 != -85179)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_74A;
					case 2:
						if (this.$self_$35145.mChar.actionState != "attack")
						{
							if (176683 - 388312 != -211628)
							{
								goto Block_29;
							}
							continue;
						}
						else
						{
							this.$i$35142 = 0;
							if (183447 - 82528 != 100919)
							{
								continue;
							}
							goto IL_6E7;
						}
						break;
					case 3:
						if (this.$self_$35145.mChar.actionState != "attack")
						{
							if (164970 - 553832 != -388861)
							{
								goto Block_13;
							}
							continue;
						}
						else
						{
							this.$i$35142++;
							if (82247 - 582414 != -500166)
							{
								goto IL_6E7;
							}
							continue;
						}
						break;
					default:
						if (241813 - 75243 == 166571)
						{
							continue;
						}
						break;
					}
					this.$self_$35145.mChar.actionState = "attack";
					if (194258 - 403439 != -209181)
					{
						continue;
					}
					this.$self_$35145.mChar.actionTime = Time.time;
					if (296690 - 287714 == 8977)
					{
						continue;
					}
					this.$self_$35145.mChar.myCommand = "jump";
					if (162087 - 73560 != 88527)
					{
						continue;
					}
					this.$self_$35145.mChar.addTimeOut("nAttack", (float)2);
					if (91761 - 167952 == -76190)
					{
						continue;
					}
					this.$self_$35145.transform.position = this.$mPos$35143;
					if (190018 - 304653 == -114634)
					{
						continue;
					}
					this.$self_$35145.transform.LookAt(this.$mPos$35143 + global::Math.vFlat(this.$tDir$35144));
					if (282523 - 232174 != 50349)
					{
						continue;
					}
					this.$self_$35145.animation.CrossFade("jump", 0.2f);
					if (58751 - 271070 == -212318)
					{
						continue;
					}
					this.$self_$35145.animation.wrapMode = WrapMode.Once;
					if (28372 - 131532 == -103159)
					{
						continue;
					}
					this.$self_$35145.mChar.vMovement = this.$self_$35145.transform.forward;
					if (127863 - 463472 == -335608)
					{
						continue;
					}
					this.$self_$35145.mChar.moveSpeed = this.$self_$35145.mChar.runSpeed + (float)2;
					if (263333 - 255377 == 7957)
					{
						continue;
					}
					if (!this.$self_$35145.mupo_cry)
					{
						goto IL_462;
					}
					if (44946 - 278662 == -233715)
					{
						continue;
					}
					this.$self_$35145.audio.PlayOneShot(this.$self_$35145.mupo_cry);
					if (246661 - 75356 != 171305)
					{
						continue;
					}
					goto IL_462;
					IL_6E7:
					if (this.$i$35142 >= 6)
					{
						if (179857 - 389727 != -209869)
						{
							this.$self_$35145.mChar.vMovement = this.$self_$35145.transform.forward;
							if (183752 - 501757 == -318005)
							{
								this.$self_$35145.mChar.recieveGravity = true;
								if (224139 - 172474 != 51666)
								{
									if (this.$self_$35145.mChar.actionState == "attack")
									{
										if (36414 - 449001 == -412586)
										{
											continue;
										}
										if (this.$self_$35145.mChar.myCommand == "jump")
										{
											if (212894 - 144617 == 68278)
											{
												continue;
											}
											this.$self_$35145.mChar.actionState = "standby";
											if (254154 - 113406 == 140749)
											{
												continue;
											}
											this.$self_$35145.mChar.actionTime = Time.time;
											if (16455 - 489092 != -472637)
											{
												continue;
											}
											this.$self_$35145.mChar.myCommand = "none";
											if (78821 - 63152 != 15669)
											{
												continue;
											}
											if (!this.$self_$35145.mChar.isMine)
											{
												if (240814 - 358643 != -117829)
												{
													continue;
												}
												this.$self_$35145.mChar.nPosition = this.$self_$35145.transform.position;
												if (19675 - 94088 == -74412)
												{
													continue;
												}
												this.$self_$35145.mChar.oPosition = this.$self_$35145.transform.position;
												if (33874 - 217662 != -183788)
												{
													continue;
												}
												this.$self_$35145.mChar.nDirection = this.$self_$35145.transform.forward;
												if (278178 - 485381 == -207202)
												{
													continue;
												}
											}
										}
									}
									this.YieldDefault(1);
									if (88918 - 376219 != -287300)
									{
										goto Block_14;
									}
								}
							}
						}
					}
					else
					{
						this.$self_$35145.mChar.vMovement = (this.$self_$35145.transform.forward + (0.6f - 0.3f * (float)this.$i$35142) * Vector3.up).normalized;
						if (236200 - 1993 == 234207)
						{
							this.$self_$35145.mChar.recieveGravity = false;
							if (290591 - 171006 == 119585)
							{
								if (this.$i$35142 != 4)
								{
									break;
								}
								if (44893 - 55486 == -10593)
								{
									this.$self_$35145.animation.CrossFade("run", 0.2f);
									if (245902 - 337473 == -91571)
									{
										this.$self_$35145.animation.wrapMode = WrapMode.Loop;
										if (82932 - 91266 == -8334)
										{
											break;
										}
									}
								}
							}
						}
					}
				}
				return this.Yield(3, new WaitForSeconds(0.1f));
				Block_13:
				Block_14:
				goto IL_74A;
				IL_462:
				return this.Yield(2, new WaitForSeconds(0.2f));
				Block_29:
				IL_74A:
				return false;
			}

			// Token: 0x060058F7 RID: 22775 RVA: 0x00AB0308 File Offset: 0x00AAE508
			internal static bool TWBIfHppAEUbEd4JdcKi()
			{
				return true;
			}

			// Token: 0x060058F8 RID: 22776 RVA: 0x00AB030C File Offset: 0x00AAE50C
			internal static bool aNiF51ppliwDGpyYntNm()
			{
				return false;
			}

			// Token: 0x040061B3 RID: 25011
			internal int $i$35142;

			// Token: 0x040061B4 RID: 25012
			internal Vector3 $mPos$35143;

			// Token: 0x040061B5 RID: 25013
			internal Vector3 $tDir$35144;

			// Token: 0x040061B6 RID: 25014
			internal MupoMount $self_$35145;
		}
	}
}
