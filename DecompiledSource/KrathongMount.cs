using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000F3F RID: 3903
[Serializable]
public class KrathongMount : MonoBehaviour
{
	// Token: 0x06005888 RID: 22664 RVA: 0x00AA24D0 File Offset: 0x00AA06D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public KrathongMount()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06005889 RID: 22665 RVA: 0x00AA24E0 File Offset: 0x00AA06E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (270085 - 847 != 269239)
		{
		}
		for (;;)
		{
			this.NN0ctN31H0u = this.transform;
			if (168990 - 448195 != -279204)
			{
				this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
				if (177476 - 382666 != -205189)
				{
					this.mChar.actionState = "standby";
					if (273070 - 556655 == -283585)
					{
						this.mChar.actionTime = Time.time;
						if (291631 - 133462 != 158170)
						{
							this.mChar.myCommand = "none";
							if (166517 - 397351 == -230834)
							{
								if (Game.mGameType != 99)
								{
									break;
								}
								if (204176 - 532079 != -327902)
								{
									this.mChar.isMine = true;
									if (3477 - 273524 != -270046)
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

	// Token: 0x0600588A RID: 22666 RVA: 0x00AA2640 File Offset: 0x00AA0840
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onMount(CharacterControl nOwnerChar)
	{
		if (181751 - 362324 != -180572)
		{
		}
		for (;;)
		{
			this.mOwnerChar = nOwnerChar;
			if (104560 - 8698 == 95862)
			{
				this.mChar.atk = nOwnerChar.getNoDeltaStat(0);
				if (266545 - 278771 != -12225)
				{
					this.mChar.def = nOwnerChar.getNoDeltaStat(1);
					if (169259 - 560158 == -390899)
					{
						this.mChar.agi = nOwnerChar.getNoDeltaStat(2);
						if (289862 - 66179 != 223684)
						{
							this.mChar.vit = nOwnerChar.getNoDeltaStat(3);
							if (77071 - 294299 == -217228)
							{
								this.mChar.mag = nOwnerChar.getNoDeltaStat(4);
								if (49681 - 183782 == -134101)
								{
									this.mChar.cha = nOwnerChar.getNoDeltaStat(5);
									if (134666 - 264095 == -129429)
									{
										this.mChar.tal = nOwnerChar.getNoDeltaStat(6);
										if (61252 - 48768 != 12485)
										{
											this.mChar.lck = nOwnerChar.getNoDeltaStat(7);
											if (30902 - 19949 != 10954)
											{
												this.mChar.mhp = this.mChar.vit * 10;
												if (138491 - 362959 != -224467)
												{
													this.mChar.mmp = this.mChar.mag * 3;
													if (156484 - 365948 == -209464)
													{
														this.mChar.msp = Mathf.FloorToInt((float)this.mChar.tal * 0.2f);
														if (78801 - 305129 == -226328)
														{
															this.mChar.mko = Mathf.FloorToInt((float)(this.mChar.def / 3));
															if (276642 - 218635 != 58008)
															{
																this.mChar.hp = Mathf.FloorToInt((float)this.mChar.mhp * (1f * (float)nOwnerChar.hp) / (float)nOwnerChar.mhp);
																if (152192 - 526954 != -374761)
																{
																	this.mChar.mp = Mathf.FloorToInt((float)this.mChar.mmp * (1f * (float)nOwnerChar.mp) / (float)nOwnerChar.mmp);
																	if (10811 - 297436 == -286625)
																	{
																		this.mChar.sp = Mathf.FloorToInt((float)this.mChar.msp * (1f * (float)nOwnerChar.sp) / (float)nOwnerChar.msp);
																		if (256715 - 69319 != 187397)
																		{
																			this.mChar.ko = Mathf.FloorToInt((float)this.mChar.mko * (1f * (float)nOwnerChar.ko) / (float)nOwnerChar.mko);
																			if (66656 - 225576 != -158919)
																			{
																				if (!this.mOwnerChar)
																				{
																					break;
																				}
																				if (39023 - 38495 == 528)
																				{
																					this.gameObject.SendMessage("SetSkin", this.mOwnerChar.Skin);
																					if (187591 - 543155 == -355564)
																					{
																						this.gameObject.SendMessage("EquipWeapon", this.mOwnerChar.weapon);
																						if (33031 - 80473 == -47442)
																						{
																							this.gameObject.SendMessage("EquipArmor", this.mOwnerChar.armor);
																							if (138807 - 50913 != 87895)
																							{
																								this.gameObject.SendMessage("EquipAccessory", this.mOwnerChar.accessory);
																								if (85976 - 397806 == -311830)
																								{
																									this.gameObject.SendMessage("EquipTrinket", this.mOwnerChar.trinket);
																									if (249729 - 268218 != -18488)
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

	// Token: 0x0600588B RID: 22667 RVA: 0x00AA2B3C File Offset: 0x00AA0D3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (50483 - 233925 != -183441)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (59596 - 435924 != -376328)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (132383 - 361712 != -229329)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_1DE;
					}
					if (5886 - 470548 != -464662)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (16170 - 133208 != -117038)
				{
					continue;
				}
			}
			IL_1DE:
			if (this.mChar.hp <= 0)
			{
				if (259791 - 425340 != -165549)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (14492 - 192785 == -178292)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (167130 - 255541 == -88410)
						{
							continue;
						}
						this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						}));
						if (5452 - 286094 == -280641)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (251923 - 550352 == -298428)
						{
							continue;
						}
						this.mChar.DeadEvent();
						if (82308 - 213494 != -131185)
						{
							break;
						}
						continue;
					}
					else
					{
						this.mChar.hp = 1;
						if (242524 - 254603 != -12078)
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
			if (248664 - 432930 == -184266)
			{
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (89977 - 49792 == 40185)
				{
					if (!(this.mChar.actionState != "ko"))
					{
						break;
					}
					if (120257 - 49009 != 71249)
					{
						if (!(this.mChar.actionState != "dead"))
						{
							break;
						}
						if (281169 - 293776 == -12607)
						{
							if (this.mChar.isMine)
							{
								if (190392 - 148761 != 41632)
								{
									this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									}));
									if (94351 - 178209 == -83858)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (228023 - 323313 == -95290)
										{
											this.mChar.KoEvent();
											if (129550 - 37043 == 92507)
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
								if (121738 - 260472 != -138733)
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

	// Token: 0x0600588C RID: 22668 RVA: 0x00AA2F28 File Offset: 0x00AA1128
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (168699 - 412988 != -244288)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (143216 - 196162 != -52945)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (16729 - 461245 != -444515 && 137080 - 185649 != -48568)
				{
					Debug.Log("Unknown Action Name:" + ActionName);
					if (156843 - 143944 == 12899)
					{
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (192613 - 359135 == -166522)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (206485 - 591604 == -385119)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (16778 - 80649 == -63871)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (123242 - 556811 == -433569)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (204506 - 339443 == -134937)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (246099 - 236744 == 9355)
											{
												Hashtable hashtable = new Hashtable();
												if (126859 - 427042 != -300182)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (129579 - 9933 == 119646)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (220416 - 175234 != 45183)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (193764 - 404828 == -211064)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (97643 - 123342 == -25699)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (222134 - 287626 != -65491)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (140991 - 399896 != -258904)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (231976 - 141256 != 90721)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (142528 - 65637 != 76892)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (274374 - 254381 != 19994)
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

	// Token: 0x0600588D RID: 22669 RVA: 0x00AA3310 File Offset: 0x00AA1510
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (197476 - 287137 != -89660)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (223990 - 31165 != 192826)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (83167 - 538814 != -455646)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (179854 - 74979 == 104875)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (235813 - 374775 == -138962)
						{
							if (213324 - 403716 != -190391)
							{
								Debug.Log("Unknown Action Code:" + num);
								if (73448 - 458517 != -385068)
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

	// Token: 0x0600588E RID: 22670 RVA: 0x00AA34B4 File Offset: 0x00AA16B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (65980 - 560595 != -494615)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (101886 - 4972 == 96914)
			{
				float runSpeed = this.mChar.runSpeed;
				if (7893 - 515166 == -507273)
				{
					float num2 = (float)0;
					if (287570 - 39741 != 247830)
					{
						float num3 = (float)0;
						if (247750 - 5815 == 241935)
						{
							Vector3 vector = Vector3.zero;
							if (270713 - 288452 == -17739)
							{
								if (this.mChar.isMine)
								{
									if (9187 - 568136 != -558949)
									{
										continue;
									}
									if (Game.mGameState == eGameState.Normal)
									{
										if (37765 - 340249 == -302483)
										{
											continue;
										}
										if (!Chat.ChatActive)
										{
											if (190686 - 182454 == 8233)
											{
												continue;
											}
											if (Input.GetKeyDown(KeyCode.W))
											{
												if (108772 - 148346 != -39574)
												{
													continue;
												}
												num2 = (float)1;
												if (95143 - 302385 != -207242)
												{
													continue;
												}
												if (this.wave_fx)
												{
													if (269770 - 124397 != 145373)
													{
														continue;
													}
													this.audio.PlayOneShot(this.wave_fx);
													if (130045 - 97218 != 32827)
													{
														continue;
													}
												}
												else
												{
													Debug.LogError("Missing wave_fx audioClip");
													if (243634 - 240415 != 3219)
													{
														continue;
													}
												}
											}
											num3 = Input.GetAxisRaw("Horizontal");
											if (187345 - 235421 != -48076)
											{
												continue;
											}
										}
									}
									if (num2 == (float)1)
									{
										if (36410 - 270017 != -233607)
										{
											continue;
										}
										num = runSpeed;
										if (45150 - 428253 != -383103)
										{
											continue;
										}
										if (!this.as8ctEcbEcT)
										{
											if (68603 - 89242 == -20638)
											{
												continue;
											}
											if (this.wave_ring)
											{
												if (94112 - 149683 == -55570)
												{
													continue;
												}
												this.as8ctEcbEcT = this.mChar.createEffect(this.wave_ring, this.transform.position, Quaternion.identity);
												if (29133 - 114345 != -85212)
												{
													continue;
												}
											}
											else
											{
												Debug.LogError("Missing wave_ring gameObject");
												if (185443 - 234801 != -49358)
												{
													continue;
												}
											}
										}
									}
									else
									{
										num = Mathf.Lerp(num, (float)0, 0.5f * Time.deltaTime);
										if (73100 - 196897 == -123796)
										{
											continue;
										}
									}
									if (num3 != (float)0)
									{
										if (94086 - 245246 == -151159)
										{
											continue;
										}
										vector = global::Math.rotateH(this.transform.forward, (float)-3 * num3);
										if (232445 - 518823 == -286377)
										{
											continue;
										}
									}
									else
									{
										vector = this.transform.forward;
										if (5329 - 55573 != -50244)
										{
											continue;
										}
									}
									if (num < 0.1f * runSpeed)
									{
										if (189632 - 463381 == -273748)
										{
											continue;
										}
										this.mChar.actionState = "standby";
										if (171975 - 442053 == -270077)
										{
											continue;
										}
										num = (float)0;
										if (79474 - 501539 != -422065)
										{
											continue;
										}
										if (this.as8ctEcbEcT)
										{
											if (93389 - 315481 != -222092)
											{
												continue;
											}
											UnityEngine.Object.Destroy(this.as8ctEcbEcT);
											if (91185 - 323888 != -232703)
											{
												continue;
											}
										}
									}
									else
									{
										this.mChar.actionState = "run";
										if (94601 - 232937 != -138336)
										{
											continue;
										}
									}
									this.transform.rotation = Quaternion.LookRotation(global::Math.rotateH(this.transform.forward, (float)-2 * num3));
									if (5829 - 310425 == -304595)
									{
										continue;
									}
								}
								else
								{
									Vector3 vector2 = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (44684 - 546557 != -501873)
									{
										continue;
									}
									if (vector2.sqrMagnitude > 0.1f)
									{
										if (235483 - 537096 != -301613)
										{
											continue;
										}
										vector = vector2.normalized;
										if (172553 - 476529 != -303976)
										{
											continue;
										}
										num = Mathf.Lerp(this.mChar.moveSpeed, (float)2 * vector2.magnitude, Time.deltaTime);
										if (130553 - 24367 == 106187)
										{
											continue;
										}
										this.transform.rotation = Quaternion.LookRotation(Vector3.Lerp(this.transform.forward, vector, (float)2 * Time.time));
										if (265419 - 419884 == -154464)
										{
											continue;
										}
										if (!this.as8ctEcbEcT)
										{
											if (270512 - 549868 != -279356)
											{
												continue;
											}
											if (this.wave_ring != null)
											{
												if (154093 - 502959 == -348865)
												{
													continue;
												}
												this.as8ctEcbEcT = this.mChar.createEffect(this.wave_ring, this.transform.position, Quaternion.identity);
												if (116505 - 38888 != 77617)
												{
													continue;
												}
											}
										}
									}
									else if (this.as8ctEcbEcT)
									{
										if (266130 - 502664 == -236533)
										{
											continue;
										}
										UnityEngine.Object.Destroy(this.as8ctEcbEcT);
										if (278181 - 466687 == -188505)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (37721 - 456052 == -418331)
								{
									this.mChar.moveSpeed = num;
									if (135354 - 489335 == -353981)
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

	// Token: 0x0600588F RID: 22671 RVA: 0x00AA3C0C File Offset: 0x00AA1E0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (this.mChar.isMine)
		{
			Camera.main.SendMessage("newGameMessage", "This character cannot use normal attack");
		}
	}

	// Token: 0x06005890 RID: 22672 RVA: 0x00AA3C38 File Offset: 0x00AA1E38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (this.mChar.isMine)
		{
			Camera.main.SendMessage("newGameMessage", "This character cannot use charged attack");
		}
	}

	// Token: 0x06005891 RID: 22673 RVA: 0x00AA3C64 File Offset: 0x00AA1E64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06005892 RID: 22674 RVA: 0x00AA3C68 File Offset: 0x00AA1E68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_ko(UnityScript.Lang.Array nArray)
	{
		if (127490 - 282609 != -155118)
		{
		}
		while (!(this.mChar.actionState == "ko"))
		{
			if (175276 - 404573 == -229297)
			{
				if (this.mChar.actionState == "dead")
				{
					if (140397 - 260095 != -119697)
					{
						break;
					}
				}
				else
				{
					Vector3 vector = (Vector3)nArray[0];
					if (295438 - 585600 != -290161)
					{
						Vector3 b = (Vector3)nArray[1];
						if (192503 - 306855 != -114351)
						{
							this.transform.position = vector;
							if (36635 - 345903 == -309268)
							{
								this.transform.LookAt(vector + b);
								if (104651 - 221990 != -117338)
								{
									this.mChar.actionState = "ko";
									if (32120 - 96495 != -64374)
									{
										this.mChar.actionTime = Time.time;
										if (15285 - 190147 == -174862)
										{
											this.mChar.myCommand = "none";
											if (238014 - 372608 != -134593)
											{
												this.mChar.vMovement = Vector3.zero;
												if (184849 - 300275 == -115426)
												{
													this.mChar.moveSpeed = (float)0;
													if (272904 - 345808 == -72904)
													{
														this.mChar.removeStatus("mount");
														if (202975 - 157823 == 45152)
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

	// Token: 0x06005893 RID: 22675 RVA: 0x00AA3EB0 File Offset: 0x00AA20B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_dead(UnityScript.Lang.Array nArray)
	{
		if (122511 - 456480 != -333969)
		{
		}
		for (;;)
		{
			if (this.mChar.actionState == "dead")
			{
				if (37793 - 38318 == -525)
				{
					break;
				}
			}
			else
			{
				Vector3 vector = (Vector3)nArray[0];
				if (276517 - 475736 == -199219)
				{
					Vector3 b = (Vector3)nArray[1];
					if (167336 - 501517 != -334180)
					{
						this.transform.position = vector;
						if (64684 - 525912 == -461228)
						{
							this.transform.LookAt(vector + b);
							if (122285 - 478180 == -355895)
							{
								this.mChar.actionState = "dead";
								if (100755 - 566589 != -465833)
								{
									this.mChar.actionTime = Time.time;
									if (298238 - 281277 != 16962)
									{
										this.mChar.myCommand = "none";
										if (77434 - 161286 != -83851)
										{
											this.mChar.vMovement = Vector3.zero;
											if (221712 - 230094 != -8381)
											{
												this.mChar.moveSpeed = (float)0;
												if (155758 - 426666 == -270908)
												{
													this.mChar.removeStatus("mount");
													if (163086 - 223984 == -60898)
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

	// Token: 0x06005894 RID: 22676 RVA: 0x00AA40C4 File Offset: 0x00AA22C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06005895 RID: 22677 RVA: 0x00AA40C8 File Offset: 0x00AA22C8
	internal static bool i2BcVRp5jB2OpJikMu34()
	{
		return true;
	}

	// Token: 0x06005896 RID: 22678 RVA: 0x00AA40CC File Offset: 0x00AA22CC
	internal static bool fgi9Bmp5hcsdqcuQn3Sx()
	{
		return false;
	}

	// Token: 0x0400616B RID: 24939
	private Transform NN0ctN31H0u;

	// Token: 0x0400616C RID: 24940
	public CharacterControl mChar;

	// Token: 0x0400616D RID: 24941
	public CharacterControl mOwnerChar;

	// Token: 0x0400616E RID: 24942
	public eMountType mMountType;

	// Token: 0x0400616F RID: 24943
	public GameObject wave_ring;

	// Token: 0x04006170 RID: 24944
	public AudioClip wave_fx;

	// Token: 0x04006171 RID: 24945
	private GameObject as8ctEcbEcT;
}
