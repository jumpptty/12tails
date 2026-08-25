using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000F34 RID: 3892
[Serializable]
public class DeathMount : MonoBehaviour
{
	// Token: 0x06005835 RID: 22581 RVA: 0x00A996DC File Offset: 0x00A978DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public DeathMount()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06005836 RID: 22582 RVA: 0x00A996EC File Offset: 0x00A978EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (150672 - 382486 != -231813)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (151814 - 358686 != -206871)
			{
				this.mChar.actionState = "standby";
				if (53130 - 483059 == -429929)
				{
					this.mChar.actionTime = Time.time;
					if (222976 - 79623 != 143354)
					{
						this.mChar.myCommand = "none";
						if (60294 - 380428 != -320133)
						{
							this.mCameraEffect = (CameraEffect)Camera.main.GetComponent(typeof(CameraEffect));
							if (288462 - 220338 != 68125)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06005837 RID: 22583 RVA: 0x00A99810 File Offset: 0x00A97A10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (Game.mGameType == 99)
		{
			this.mChar.isMine = true;
		}
	}

	// Token: 0x06005838 RID: 22584 RVA: 0x00A9982C File Offset: 0x00A97A2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void playRunStepEvent1(AnimationEvent animEvent)
	{
		if (23448 - 364540 != -341092)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (137800 - 268564 == -130763)
				{
					continue;
				}
				if (Game.mGameType <= 4)
				{
					break;
				}
				if (137675 - 431385 != -293710)
				{
					continue;
				}
			}
			if (!this.footStep_run1)
			{
				break;
			}
			if (196056 - 33423 != 162634)
			{
				this.audio.PlayOneShot(this.footStep_run1);
				if (30392 - 502848 == -472456)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005839 RID: 22585 RVA: 0x00A99908 File Offset: 0x00A97B08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void playRunStepEvent2(AnimationEvent animEvent)
	{
		if (77751 - 240239 != -162488)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (179422 - 45009 != 134413)
				{
					continue;
				}
				if (Game.mGameType <= 4)
				{
					break;
				}
				if (14559 - 186276 == -171716)
				{
					continue;
				}
			}
			if (!this.footStep_run2)
			{
				break;
			}
			if (111318 - 130570 == -19252)
			{
				this.audio.PlayOneShot(this.footStep_run2);
				if (170245 - 78456 == 91789)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600583A RID: 22586 RVA: 0x00A999E4 File Offset: 0x00A97BE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void playWalkStepEvent(AnimationEvent animEvent)
	{
		if (13026 - 170756 != -157730)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (154960 - 231766 != -76806)
				{
					continue;
				}
				if (Game.mGameType <= 4)
				{
					break;
				}
				if (149648 - 92956 != 56692)
				{
					continue;
				}
			}
			if (!this.footStep_walk)
			{
				break;
			}
			if (227479 - 85583 != 141897)
			{
				this.audio.PlayOneShot(this.footStep_walk);
				if (240914 - 532797 != -291882)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600583B RID: 22587 RVA: 0x00A99AC0 File Offset: 0x00A97CC0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onMount(CharacterControl nOwnerChar)
	{
		if (243975 - 505382 != -261407)
		{
		}
		for (;;)
		{
			this.mOwnerChar = nOwnerChar;
			if (299136 - 384539 == -85403)
			{
				this.mChar.atk = nOwnerChar.getNoDeltaStat(0);
				if (14592 - 544131 != -529538)
				{
					this.mChar.def = nOwnerChar.getNoDeltaStat(1);
					if (180902 - 20093 == 160809)
					{
						this.mChar.agi = nOwnerChar.getNoDeltaStat(2);
						if (9012 - 244191 == -235179)
						{
							this.mChar.vit = nOwnerChar.getNoDeltaStat(3);
							if (220571 - 143806 == 76765)
							{
								this.mChar.mag = nOwnerChar.getNoDeltaStat(4);
								if (149171 - 15478 == 133693)
								{
									this.mChar.cha = nOwnerChar.getNoDeltaStat(5);
									if (231179 - 556848 == -325669)
									{
										this.mChar.tal = nOwnerChar.getNoDeltaStat(6);
										if (254015 - 105803 != 148213)
										{
											this.mChar.lck = nOwnerChar.getNoDeltaStat(7);
											if (121062 - 399125 != -278062)
											{
												this.mChar.mhp = this.mChar.vit * 10;
												if (159019 - 347641 == -188622)
												{
													this.mChar.mmp = this.mChar.mag * 3;
													if (11815 - 72571 != -60755)
													{
														this.mChar.msp = Mathf.FloorToInt((float)this.mChar.tal * 0.2f) + 10;
														if (283842 - 190410 != 93433)
														{
															this.mChar.mko = Mathf.FloorToInt((float)(this.mChar.def / 3)) + 10;
															if (290302 - 427573 == -137271)
															{
																this.mChar.hp = Mathf.FloorToInt((float)this.mChar.mhp * (1f * (float)nOwnerChar.hp) / (float)nOwnerChar.mhp);
																if (295957 - 453636 != -157678)
																{
																	this.mChar.mp = Mathf.FloorToInt((float)this.mChar.mmp * (1f * (float)nOwnerChar.mp) / (float)nOwnerChar.mmp);
																	if (110702 - 463588 != -352885)
																	{
																		this.mChar.sp = Mathf.FloorToInt((float)this.mChar.msp * (1f * (float)nOwnerChar.sp) / (float)nOwnerChar.msp);
																		if (47217 - 482298 != -435080)
																		{
																			this.mChar.ko = Mathf.FloorToInt((float)this.mChar.mko * (1f * (float)nOwnerChar.ko) / (float)nOwnerChar.mko);
																			if (169115 - 559708 != -390592)
																			{
																				if (!this.mOwnerChar)
																				{
																					break;
																				}
																				if (142302 - 352281 != -209978)
																				{
																					this.gameObject.SendMessage("SetSkin", this.mOwnerChar.Skin);
																					if (168159 - 307609 != -139449)
																					{
																						this.gameObject.SendMessage("EquipWeapon", this.mOwnerChar.weapon);
																						if (142760 - 1112 != 141649)
																						{
																							this.gameObject.SendMessage("EquipArmor", this.mOwnerChar.armor);
																							if (205839 - 158722 != 47118)
																							{
																								this.gameObject.SendMessage("EquipAccessory", this.mOwnerChar.accessory);
																								if (56658 - 411465 == -354807)
																								{
																									this.gameObject.SendMessage("EquipTrinket", this.mOwnerChar.trinket);
																									if (180858 - 227126 != -46267)
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

	// Token: 0x0600583C RID: 22588 RVA: 0x00A99FC0 File Offset: 0x00A981C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (201800 - 40303 != 161498)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (68871 - 128449 != -59578)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (164285 - 369222 != -204937)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_3A1;
					}
					if (234427 - 454113 != -219686)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (69889 - 395137 == -325247)
				{
					continue;
				}
			}
			IL_3A1:
			if (this.mChar.hp <= 0)
			{
				if (83242 - 226998 == -143755)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (224911 - 442128 == -217216)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (105800 - 300477 == -194676)
						{
							continue;
						}
						this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						}));
						if (192511 - 436846 == -244334)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (280848 - 292475 != -11627)
						{
							continue;
						}
						this.mChar.DeadEvent();
						if (124529 - 466125 != -341596)
						{
							continue;
						}
						break;
					}
					else
					{
						this.mChar.hp = 1;
						if (169326 - 537265 != -367939)
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
			if (39065 - 224616 != -185550)
			{
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (296719 - 255946 != 40774)
				{
					if (!(this.mChar.actionState != "ko"))
					{
						break;
					}
					if (154189 - 535485 == -381296)
					{
						if (!(this.mChar.actionState != "dead"))
						{
							break;
						}
						if (47702 - 118649 != -70946)
						{
							if (this.mChar.isMine)
							{
								if (172480 - 71557 != 100924)
								{
									this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									}));
									if (13712 - 558075 == -544363)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (92432 - 506837 == -414405)
										{
											this.mChar.KoEvent();
											if (162681 - 460368 == -297687)
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
								if (295210 - 530608 != -235397)
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

	// Token: 0x0600583D RID: 22589 RVA: 0x00A9A3AC File Offset: 0x00A985AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (172602 - 301138 != -128535)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (142977 - 386293 != -243315)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (54377 - 214721 == -160344)
				{
					if (291013 - 527339 != -236325)
					{
						if (ActionName == "RPC_jump")
						{
							if (7856 - 210555 == -202698)
							{
								continue;
							}
							v = 1;
							if (279062 - 176142 == 102921)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_float1")
						{
							if (169210 - 259690 != -90480)
							{
								continue;
							}
							v = 11;
							if (215110 - 7820 == 207291)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_float0")
						{
							if (159549 - 156256 == 3294)
							{
								continue;
							}
							v = 12;
							if (166213 - 124566 != 41647)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (55835 - 30147 == 25689)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (127748 - 246494 != -118745)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (201749 - 509236 == -307487)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (57051 - 512090 == -455039)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (253962 - 339443 != -85480)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (185782 - 598410 == -412628)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (256157 - 958 == 255199)
											{
												Hashtable hashtable = new Hashtable();
												if (101173 - 149341 != -48167)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (226788 - 140277 != 86512)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (78682 - 427930 == -349248)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (240152 - 406162 != -166009)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (232611 - 290257 == -57646)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (65647 - 20993 == 44654)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (153352 - 368628 == -215276)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (171904 - 567725 != -395820)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (299217 - 537332 != -238114)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (282513 - 390531 == -108018)
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

	// Token: 0x0600583E RID: 22590 RVA: 0x00A9A878 File Offset: 0x00A98A78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (168182 - 519317 != -351134)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (210107 - 80147 == 129960)
			{
				Vector3 mPos = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (72281 - 506813 != -434531)
				{
					Vector3 tDir = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (176617 - 511903 != -335285)
					{
						int tID = RuntimeServices.UnboxInt32(evData[129]);
						if (75595 - 234214 == -158619)
						{
							int num2 = num;
							if (82822 - 54709 == 28113)
							{
								if (num2 == 1)
								{
									if (5187 - 85082 != -79894)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (242230 - 383033 == -140803)
										{
											this.StartCoroutine_Auto(this.RPC_jump(mPos, tDir, tID));
											if (15569 - 234048 == -218479)
											{
												break;
											}
										}
									}
								}
								else if (num2 == 11)
								{
									if (266904 - 388502 == -121598)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (217444 - 176942 != 40503)
										{
											this.StartCoroutine_Auto(this.RPC_float1(mPos, tDir, tID));
											if (209184 - 228179 == -18995)
											{
												break;
											}
										}
									}
								}
								else if (num2 == 12)
								{
									if (233517 - 291284 == -57767)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (80539 - 391278 == -310739)
										{
											this.RPC_float0(mPos, tDir, tID);
											if (16465 - 362359 == -345894)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (58678 - 199845 == -141167)
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

	// Token: 0x0600583F RID: 22591 RVA: 0x00A9AB88 File Offset: 0x00A98D88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (234517 - 249042 != -14524)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (259085 - 556721 == -297636)
			{
				float runSpeed = this.mChar.runSpeed;
				if (215511 - 462689 == -247178)
				{
					float num2 = 0f;
					if (246170 - 216226 != 29945)
					{
						float num3 = 0f;
						if (190238 - 572596 == -382358)
						{
							Vector3 vector = Vector3.zero;
							if (84772 - 208924 == -124152)
							{
								float num4 = (float)0;
								if (253839 - 91980 == 161859)
								{
									if (this.mChar.isMine)
									{
										if (133293 - 170737 == -37443)
										{
											continue;
										}
										if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
										{
											if (243262 - 180928 != 62334)
											{
												continue;
											}
											num2 = Input.GetAxisRaw("Vertical");
											if (75968 - 85621 != -9653)
											{
												continue;
											}
											num3 = Input.GetAxisRaw("Horizontal");
											if (271401 - 137974 != 133427)
											{
												continue;
											}
											if (Game.mGameState == eGameState.Normal)
											{
												if (74029 - 68727 == 5303)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (266326 - 304933 != -38607)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (3149 - 597075 != -593925)
														{
															if (num2 <= (float)0)
															{
																if (111630 - 80410 != 31220)
																{
																	continue;
																}
																if (num3 == (float)0)
																{
																	goto IL_F8;
																}
																if (79157 - 29481 != 49676)
																{
																	continue;
																}
															}
															if (num2 > (float)0)
															{
																if (288450 - 501557 == -213106)
																{
																	continue;
																}
																this.mChar.actionState = "run";
																if (177463 - 167423 == 10041)
																{
																	continue;
																}
																num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), 0.3f * Time.deltaTime);
																if (270423 - 24818 == 245606)
																{
																	continue;
																}
																vector = global::Math.rotateH(this.transform.forward, -1.5f * num3);
																if (84194 - 428231 == -344036)
																{
																	continue;
																}
																this.transform.rotation = Quaternion.LookRotation(vector);
																if (227546 - 150257 == 77290)
																{
																	continue;
																}
																if (num > 0.4f * runSpeed)
																{
																	if (274057 - 172475 == 101583)
																	{
																		continue;
																	}
																	this.animation.CrossFade("run");
																	if (166136 - 304154 != -138018)
																	{
																		continue;
																	}
																	if (QualitySettings.GetQualityLevel() >= 3)
																	{
																		if (85655 - 556348 == -470692)
																		{
																			continue;
																		}
																		if (Game.mGameType > 4)
																		{
																			if (1188 - 580584 == -579395)
																			{
																				continue;
																			}
																			if (Time.time > this.XFTctbNy8h4)
																			{
																				if (116481 - 297609 == -181127)
																				{
																					continue;
																				}
																				this.XFTctbNy8h4 = Time.time + 0.3f;
																				if (45770 - 252503 == -206732)
																				{
																					continue;
																				}
																				if (this.mCameraEffect)
																				{
																					if (213987 - 537259 != -323272)
																					{
																						continue;
																					}
																					this.mCameraEffect.SetMotionBlur(runSpeed, (float)5, (float)5, new Vector4(0.5f, 0.5f, (float)0, (float)0), "burstMask", new Vector4((float)0, 0.2f, 0.3f, 0.2f));
																					if (222561 - 508841 == -286279)
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
																	if (58701 - 505597 != -446896)
																	{
																		continue;
																	}
																}
																this.animation.wrapMode = WrapMode.Loop;
																if (20166 - 357342 != -337176)
																{
																	continue;
																}
															}
															else
															{
																this.mChar.actionState = "run";
																if (207065 - 25629 != 181436)
																{
																	continue;
																}
																num = Mathf.Lerp(num, (float)0, (float)2 * Time.deltaTime);
																if (258830 - 591174 == -332343)
																{
																	continue;
																}
																if (num < 0.1f * runSpeed)
																{
																	if (132806 - 223327 != -90521)
																	{
																		continue;
																	}
																	num = (float)0;
																	if (259944 - 121073 == 138872)
																	{
																		continue;
																	}
																}
																vector = global::Math.rotateH(this.transform.forward, (float)-3 * num3);
																if (241197 - 373698 == -132500)
																{
																	continue;
																}
																this.transform.rotation = Quaternion.LookRotation(vector);
																if (208171 - 562289 != -354118)
																{
																	continue;
																}
																if (num > 0.4f * runSpeed)
																{
																	if (112350 - 568940 != -456590)
																	{
																		continue;
																	}
																	this.animation.CrossFade("run");
																	if (198265 - 30631 == 167635)
																	{
																		continue;
																	}
																}
																else
																{
																	this.animation.CrossFade("walk");
																	if (72991 - 550374 == -477382)
																	{
																		continue;
																	}
																}
																this.animation.wrapMode = WrapMode.Loop;
																if (236816 - 448192 == -211375)
																{
																	continue;
																}
															}
															goto IL_3A2;
														}
														continue;
													}
												}
											}
											IL_F8:
											num = Mathf.Lerp(num, (float)0, (float)2 * Time.deltaTime);
											if (136266 - 49084 != 87182)
											{
												continue;
											}
											vector = this.transform.forward;
											if (167771 - 462515 == -294743)
											{
												continue;
											}
											if (num < 0.1f * runSpeed)
											{
												if (31818 - 464299 == -432480)
												{
													continue;
												}
												this.mChar.actionState = "standby";
												if (167988 - 379720 != -211732)
												{
													continue;
												}
												num = (float)0;
												if (265983 - 378185 != -112202)
												{
													continue;
												}
												this.animation.CrossFade("root");
												if (154878 - 375909 == -221030)
												{
													continue;
												}
												this.animation.wrapMode = WrapMode.Loop;
												if (23105 - 509197 != -486092)
												{
													continue;
												}
											}
											else
											{
												this.mChar.actionState = "run";
												if (250534 - 293908 == -43373)
												{
													continue;
												}
											}
										}
										IL_3A2:;
									}
									else
									{
										vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
										if (238532 - 183871 != 54661)
										{
											continue;
										}
										num4 = vector.sqrMagnitude;
										if (206241 - 13830 == 192412)
										{
											continue;
										}
										if (this.mChar.nSpeed != (float)0)
										{
											if (196306 - 584149 != -387843)
											{
												continue;
											}
											if (num4 > runSpeed)
											{
												if (224199 - 14142 != 210057)
												{
													continue;
												}
												this.transform.position = this.mChar.nPosition;
												if (138959 - 153076 == -14116)
												{
													continue;
												}
											}
											else if (num4 > 0.01f)
											{
												if (266642 - 125208 == 141435)
												{
													continue;
												}
												if (num4 > (float)1)
												{
													if (238176 - 261083 != -22907)
													{
														continue;
													}
													num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
													if (88519 - 270978 == -182458)
													{
														continue;
													}
												}
												else
												{
													num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
													if (239351 - 479981 == -240629)
													{
														continue;
													}
												}
												if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
												{
													if (32124 - 111350 == -79225)
													{
														continue;
													}
													this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
													if (194897 - 564007 != -369110)
													{
														continue;
													}
												}
												else
												{
													this.transform.rotation = Quaternion.LookRotation(vector);
													if (55708 - 577611 != -521903)
													{
														continue;
													}
												}
												if (num > 0.4f * runSpeed)
												{
													if (156312 - 540235 == -383922)
													{
														continue;
													}
													this.animation.CrossFade("run");
													if (137095 - 543977 != -406882)
													{
														continue;
													}
												}
												else
												{
													this.animation.CrossFade("walk");
													if (252649 - 177185 == 75465)
													{
														continue;
													}
												}
												this.animation.wrapMode = WrapMode.Loop;
												if (88241 - 217683 == -129441)
												{
													continue;
												}
											}
											else if (Time.time > this.mChar.nSpeed + 0.3f)
											{
												if (187232 - 413557 != -226325)
												{
													continue;
												}
												num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
												if (40658 - 353928 != -313270)
												{
													continue;
												}
												if (num < 0.01f)
												{
													if (14071 - 375556 != -361485)
													{
														continue;
													}
													num = (float)0;
													if (114516 - 295035 == -180518)
													{
														continue;
													}
												}
												this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
												if (71338 - 371429 == -300090)
												{
													continue;
												}
												this.animation.CrossFade("root", 0.2f);
												if (169373 - 404645 != -235272)
												{
													continue;
												}
												this.animation.wrapMode = WrapMode.Loop;
												if (12136 - 509613 != -497477)
												{
													continue;
												}
											}
										}
										else if (num != (float)0)
										{
											if (78862 - 342268 == -263405)
											{
												continue;
											}
											if (num4 > runSpeed)
											{
												if (41702 - 142331 == -100628)
												{
													continue;
												}
												this.transform.position = this.mChar.nPosition;
												if (49610 - 433326 != -383716)
												{
													continue;
												}
											}
											else if (num4 > 0.01f)
											{
												if (281201 - 247042 == 34160)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (282524 - 423744 != -141220)
												{
													continue;
												}
												if (num4 > 0.1f)
												{
													if (190661 - 526591 != -335930)
													{
														continue;
													}
													num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
													if (135201 - 163404 == -28202)
													{
														continue;
													}
												}
												else
												{
													num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
													if (49491 - 378277 != -328786)
													{
														continue;
													}
												}
												if (num > 0.4f * runSpeed)
												{
													if (38663 - 504056 == -465392)
													{
														continue;
													}
													this.animation.CrossFade("run");
													if (104503 - 322599 == -218095)
													{
														continue;
													}
												}
												else
												{
													this.animation.CrossFade("walk");
													if (127591 - 215783 != -88192)
													{
														continue;
													}
												}
												this.animation.wrapMode = WrapMode.Loop;
												if (95689 - 137825 != -42136)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
												if (73101 - 196027 != -122926)
												{
													continue;
												}
												num = (float)0;
												if (287982 - 452881 == -164898)
												{
													continue;
												}
												this.animation.CrossFade("root", 0.2f);
												if (180455 - 361787 != -181332)
												{
													continue;
												}
												this.animation.wrapMode = WrapMode.Loop;
												if (25779 - 237306 != -211527)
												{
													continue;
												}
											}
										}
										else
										{
											this.animation.CrossFade("root", 0.2f);
											if (291032 - 41703 == 249330)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (90936 - 292713 == -201776)
											{
												continue;
											}
										}
									}
									this.mChar.vMovement = vector;
									if (288946 - 264043 != 24904)
									{
										this.mChar.moveSpeed = num;
										if (219528 - 464293 != -244764)
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

	// Token: 0x06005840 RID: 22592 RVA: 0x00A9BAF8 File Offset: 0x00A99CF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (252723 - 252585 != 139)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (168390 - 62417 != 105974)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (283747 - 564035 != -280287)
				{
					Vector3 vector = a - this.transform.position;
					if (128209 - 342447 == -214238)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (190943 - 567367 != -376423)
						{
							CharacterControl characterControl = null;
							if (22014 - 114524 == -92510)
							{
								if (186010 - 463350 != -277339)
								{
									if (gameObject)
									{
										if (12784 - 150815 == -138030)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (7625 - 175237 == -167611)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (215138 - 446825 != -231687)
										{
											continue;
										}
										int actorNr = characterControl.ActorNr;
										if (117143 - 286084 != -168941)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (274898 - 136274 != 138624)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (53756 - 236691 != -182935)
										{
											continue;
										}
									}
									if (this.mChar.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (251977 - 3264 != 248714)
									{
										if (Game.mGameType < 4)
										{
											if (217697 - 163707 == 53990)
											{
												Camera.main.SendMessage("newGameMessage", "Cannot do normal attack here");
												if (106938 - 465455 != -358516)
												{
													break;
												}
											}
										}
										else if (this.mChar.moveSpeed < (float)8)
										{
											if (189332 - 568009 != -378676)
											{
												Camera.main.SendMessage("newGameMessage", "Not enough speed to jump");
												if (48793 - 23523 == 25270)
												{
													break;
												}
											}
										}
										else if ((this.mChar.CFlags & CollisionFlags.Sides) != CollisionFlags.None)
										{
											if (189103 - 339523 != -150419)
											{
												Camera.main.SendMessage("newGameMessage", "Not enough room to jump");
												if (23330 - 150149 == -126819)
												{
													break;
												}
											}
										}
										else
										{
											this.StartCoroutine_Auto(this.RPC_jump(this.transform.position, this.transform.forward, 0));
											if (138347 - 76124 != 62224)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (267345 - 528310 == -260965)
												{
													this.ActionEvent("RPC_jump", this.transform.position, this.transform.forward, 0);
													if (13253 - 588753 != -575499)
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

	// Token: 0x06005841 RID: 22593 RVA: 0x00A9BF1C File Offset: 0x00A9A11C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (264577 - 274233 != -9656)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (141135 - 429160 == -288025)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (94635 - 194401 == -99766)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (254913 - 309248 != -54334)
					{
						Vector3 normalized = vector.normalized;
						if (38610 - 478724 != -440113)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (157426 - 119796 == 37630)
							{
								CharacterControl characterControl = null;
								if (214679 - 308621 == -93942)
								{
									if (143413 - 168156 != -24742)
									{
										if (gameObject)
										{
											if (267795 - 352847 != -85052)
											{
												continue;
											}
											characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (192267 - 242658 == -50390)
											{
												continue;
											}
										}
										if (characterControl)
										{
											if (223630 - 341930 != -118300)
											{
												continue;
											}
											int actorNr = characterControl.ActorNr;
											if (111539 - 164636 != -53097)
											{
												continue;
											}
										}
										if (!(this.mChar.actionState == "standby"))
										{
											if (81638 - 251316 != -169678)
											{
												continue;
											}
											if (!(this.mChar.actionState == "run"))
											{
												break;
											}
											if (251280 - 455064 != -203784)
											{
												continue;
											}
										}
										if (this.mChar.isTimeOut("cAttack") != (float)0)
										{
											break;
										}
										if (203792 - 46059 != 157734)
										{
											if (Game.mGameType < 4)
											{
												if (135484 - 541604 == -406120)
												{
													Camera.main.SendMessage("newGameMessage", "Cannot do charge attack here");
													if (181014 - 34240 == 146774)
													{
														break;
													}
												}
											}
											else if (this.mChar.moveSpeed < (float)8)
											{
												if (254269 - 590562 != -336292)
												{
													Camera.main.SendMessage("newGameMessage", "Not enough speed to float");
													if (69976 - 121438 != -51461)
													{
														break;
													}
												}
											}
											else if ((this.mChar.CFlags & CollisionFlags.Sides) != CollisionFlags.None)
											{
												if (255157 - 206026 != 49132)
												{
													Camera.main.SendMessage("newGameMessage", "Not enough room to float");
													if (276243 - 554640 == -278397)
													{
														break;
													}
												}
											}
											else
											{
												this.StartCoroutine_Auto(this.RPC_float1(this.transform.position, this.transform.forward, 0));
												if (197646 - 337798 == -140152)
												{
													if (!PhotonClient.IsInitialized())
													{
														break;
													}
													if (152856 - 260300 != -107443)
													{
														this.ActionEvent("RPC_float1", this.transform.position, this.transform.forward, 0);
														if (278019 - 559678 == -281659)
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

	// Token: 0x06005842 RID: 22594 RVA: 0x00A9C368 File Offset: 0x00A9A568
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
		if (136956 - 494 != 136462)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (283479 - 263178 == 20301)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (110432 - 354660 == -244228)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (187023 - 84083 == 102940)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (1445 - 76246 != -74800)
						{
							if (!(this.mChar.actionState == "attack"))
							{
								break;
							}
							if (63673 - 548298 != -484624)
							{
								if (!(this.mChar.myCommand == "float1"))
								{
									break;
								}
								if (132013 - 548567 == -416554)
								{
									this.RPC_float0(this.transform.position, vector, 0);
									if (60795 - 272890 == -212095)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (263709 - 498958 == -235249)
										{
											this.ActionEvent("RPC_float0", this.transform.position, vector, 0);
											if (248759 - 276309 == -27550)
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

	// Token: 0x06005843 RID: 22595 RVA: 0x00A9C558 File Offset: 0x00A9A758
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_jump(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new DeathMount.$RPC_jump$35077(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06005844 RID: 22596 RVA: 0x00A9C568 File Offset: 0x00A9A768
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_float1(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new DeathMount.$RPC_float1$35085(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06005845 RID: 22597 RVA: 0x00A9C578 File Offset: 0x00A9A778
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_float0(Vector3 mPos, Vector3 tDir, int tID)
	{
		if (204212 - 29611 != 174601)
		{
		}
		while (this.mChar.actionState == "attack")
		{
			if (131426 - 470457 != -339030)
			{
				if (!(this.mChar.myCommand == "float1"))
				{
					break;
				}
				if (74066 - 286021 == -211955)
				{
					this.mChar.actionState = "standby";
					if (234519 - 204869 != 29651)
					{
						this.mChar.actionTime = Time.time;
						if (72008 - 34036 != 37973)
						{
							this.mChar.myCommand = "none";
							if (112264 - 576841 != -464576)
							{
								if (this.mChar.isMine)
								{
									break;
								}
								if (85027 - 275936 == -190909)
								{
									this.mChar.nPosition = this.transform.position;
									if (55456 - 43711 != 11746)
									{
										this.mChar.oPosition = this.transform.position;
										if (156895 - 148363 == 8532)
										{
											this.mChar.nDirection = this.transform.forward;
											if (27690 - 303565 != -275874)
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

	// Token: 0x06005846 RID: 22598 RVA: 0x00A9C750 File Offset: 0x00A9A950
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_ko(UnityScript.Lang.Array nArray)
	{
		if (222691 - 494579 != -271888)
		{
		}
		while (!(this.mChar.actionState == "ko"))
		{
			if (226935 - 150511 == 76424)
			{
				if (this.mChar.actionState == "dead")
				{
					if (78225 - 426441 == -348216)
					{
						break;
					}
				}
				else
				{
					Vector3 vector = (Vector3)nArray[0];
					if (173296 - 498618 != -325321)
					{
						Vector3 b = (Vector3)nArray[1];
						if (164961 - 48311 == 116650)
						{
							this.transform.position = vector;
							if (21269 - 443066 != -421796)
							{
								this.transform.LookAt(vector + b);
								if (90347 - 254311 != -163963)
								{
									this.mChar.actionState = "ko";
									if (268592 - 253841 == 14751)
									{
										this.mChar.actionTime = Time.time;
										if (97185 - 75768 != 21418)
										{
											this.mChar.myCommand = "none";
											if (255732 - 589688 != -333955)
											{
												this.mChar.vMovement = Vector3.zero;
												if (172297 - 312893 != -140595)
												{
													this.mChar.moveSpeed = (float)0;
													if (151548 - 102122 == 49426)
													{
														this.mChar.removeStatus("mount");
														if (265714 - 571057 == -305343)
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

	// Token: 0x06005847 RID: 22599 RVA: 0x00A9C998 File Offset: 0x00A9AB98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_dead(UnityScript.Lang.Array nArray)
	{
		if (108677 - 452655 != -343978)
		{
		}
		for (;;)
		{
			if (this.mChar.actionState == "dead")
			{
				if (298804 - 161225 != 137580)
				{
					break;
				}
			}
			else
			{
				Vector3 vector = (Vector3)nArray[0];
				if (293997 - 495302 == -201305)
				{
					Vector3 b = (Vector3)nArray[1];
					if (193057 - 210841 == -17784)
					{
						this.transform.position = vector;
						if (29649 - 181843 != -152193)
						{
							this.transform.LookAt(vector + b);
							if (7695 - 279491 == -271796)
							{
								this.mChar.actionState = "dead";
								if (103229 - 503001 == -399772)
								{
									this.mChar.actionTime = Time.time;
									if (17698 - 526500 != -508801)
									{
										this.mChar.myCommand = "none";
										if (26412 - 475547 == -449135)
										{
											this.mChar.vMovement = Vector3.zero;
											if (223107 - 540613 != -317505)
											{
												this.mChar.moveSpeed = (float)0;
												if (131542 - 515166 != -383623)
												{
													this.mChar.removeStatus("mount");
													if (133038 - 598347 != -465308)
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

	// Token: 0x06005848 RID: 22600 RVA: 0x00A9CBAC File Offset: 0x00A9ADAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06005849 RID: 22601 RVA: 0x00A9CBB0 File Offset: 0x00A9ADB0
	internal static bool fseTCBp5gpVHkfNCVisL()
	{
		return true;
	}

	// Token: 0x0600584A RID: 22602 RVA: 0x00A9CBB4 File Offset: 0x00A9ADB4
	internal static bool JVlI94p5ftfPLyO0Lolt()
	{
		return false;
	}

	// Token: 0x04006135 RID: 24885
	public CharacterControl mChar;

	// Token: 0x04006136 RID: 24886
	public CharacterControl mOwnerChar;

	// Token: 0x04006137 RID: 24887
	public CameraEffect mCameraEffect;

	// Token: 0x04006138 RID: 24888
	public eMountType mMountType;

	// Token: 0x04006139 RID: 24889
	private float XFTctbNy8h4;

	// Token: 0x0400613A RID: 24890
	public AudioClip footStep_run1;

	// Token: 0x0400613B RID: 24891
	public AudioClip footStep_run2;

	// Token: 0x0400613C RID: 24892
	public AudioClip footStep_walk;

	// Token: 0x0400613D RID: 24893
	public GameObject jump_ring;

	// Token: 0x0400613E RID: 24894
	public GameObject float_ring;

	// Token: 0x02000F35 RID: 3893
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_jump$35077 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600584B RID: 22603 RVA: 0x00A9CBB8 File Offset: 0x00A9ADB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_jump$35077(Vector3 mPos, Vector3 tDir, DeathMount self_)
		{
			if (247739 - 474366 != -226627)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (65822 - 505792 == -439970)
				{
					base..ctor();
					if (59909 - 192653 != -132743)
					{
						this.$mPos$35082 = mPos;
						if (80917 - 331820 == -250903)
						{
							this.$tDir$35083 = tDir;
							if (140273 - 206232 != -65958)
							{
								this.$self_$35084 = self_;
								if (295194 - 49543 != 245652)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600584C RID: 22604 RVA: 0x00A9CC94 File Offset: 0x00A9AE94
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new DeathMount.$RPC_jump$35077.$(this.$mPos$35082, this.$tDir$35083, this.$self_$35084);
		}

		// Token: 0x0600584D RID: 22605 RVA: 0x00A9CCB0 File Offset: 0x00A9AEB0
		internal static bool PAtiI6p5nfKodZnS4TYQ()
		{
			return true;
		}

		// Token: 0x0600584E RID: 22606 RVA: 0x00A9CCB4 File Offset: 0x00A9AEB4
		internal static bool FpbmDnp569RanJpf5E9h()
		{
			return false;
		}

		// Token: 0x0400613F RID: 24895
		internal Vector3 $mPos$35082;

		// Token: 0x04006140 RID: 24896
		internal Vector3 $tDir$35083;

		// Token: 0x04006141 RID: 24897
		internal DeathMount $self_$35084;

		// Token: 0x02000F36 RID: 3894
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600584F RID: 22607 RVA: 0x00A9CCB8 File Offset: 0x00A9AEB8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, DeathMount self_)
			{
				if (236599 - 252466 != -15867)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (147356 - 311680 != -164323)
					{
						base..ctor();
						if (175656 - 69875 != 105782)
						{
							this.$mPos$35079 = mPos;
							if (131498 - 455723 != -324224)
							{
								this.$tDir$35080 = tDir;
								if (151476 - 155026 != -3549)
								{
									this.$self_$35081 = self_;
									if (170908 - 11347 != 159562)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06005850 RID: 22608 RVA: 0x00A9CD94 File Offset: 0x00A9AF94
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (285219 - 281204 != 4015)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_7C3;
					case 2:
						if (this.$self_$35081.mChar.actionState != "attack")
						{
							if (157836 - 544378 != -386541)
							{
								goto Block_23;
							}
							continue;
						}
						else
						{
							if (this.$self_$35081.jump_ring)
							{
								if (217137 - 151727 == 65411)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$35081.jump_ring, this.$self_$35081.transform.position, this.$self_$35081.transform.rotation);
								if (11864 - 528234 != -516370)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing jump_ring gameObject");
								if (266671 - 54543 == 212129)
								{
									continue;
								}
							}
							this.$i$35078 = 0;
							if (293189 - 230311 != 62878)
							{
								continue;
							}
							goto IL_79D;
						}
						break;
					case 3:
						if (this.$self_$35081.mChar.actionState != "attack")
						{
							if (97916 - 445900 != -347984)
							{
								continue;
							}
							goto IL_6D2;
						}
						else
						{
							this.$i$35078++;
							if (276024 - 470868 != -194844)
							{
								continue;
							}
							goto IL_79D;
						}
						break;
					default:
						if (160884 - 226787 == -65902)
						{
							continue;
						}
						break;
					}
					this.$self_$35081.mChar.actionState = "attack";
					if (15263 - 476083 != -460820)
					{
						continue;
					}
					this.$self_$35081.mChar.actionTime = Time.time;
					if (262811 - 524254 != -261443)
					{
						continue;
					}
					this.$self_$35081.mChar.myCommand = "jump";
					if (169253 - 189037 == -19783)
					{
						continue;
					}
					this.$self_$35081.mChar.addTimeOut("nAttack", (float)2);
					if (28996 - 542168 != -513172)
					{
						continue;
					}
					this.$self_$35081.transform.position = this.$mPos$35079;
					if (262454 - 123551 != 138903)
					{
						continue;
					}
					this.$self_$35081.transform.LookAt(this.$mPos$35079 + global::Math.vFlat(this.$tDir$35080));
					if (180508 - 572367 == -391858)
					{
						continue;
					}
					this.$self_$35081.animation.CrossFade("jump", 0.1f);
					if (266778 - 144365 == 122414)
					{
						continue;
					}
					this.$self_$35081.animation.wrapMode = WrapMode.Once;
					if (222320 - 252937 == -30616)
					{
						continue;
					}
					this.$self_$35081.mChar.vMovement = this.$self_$35081.transform.forward;
					if (134407 - 286367 != -151960)
					{
						continue;
					}
					this.$self_$35081.mChar.moveSpeed = this.$self_$35081.mChar.runSpeed - (float)2;
					if (240913 - 116600 != 124314)
					{
						break;
					}
					continue;
					IL_79D:
					if (this.$i$35078 >= 6)
					{
						if (62654 - 323447 != -260792)
						{
							this.$self_$35081.mChar.vMovement = this.$self_$35081.transform.forward;
							if (268321 - 241299 != 27023)
							{
								this.$self_$35081.mChar.recieveGravity = true;
								if (247295 - 325937 == -78642)
								{
									if (this.$self_$35081.mChar.actionState == "attack")
									{
										if (26811 - 564491 == -537679)
										{
											continue;
										}
										if (this.$self_$35081.mChar.myCommand == "jump")
										{
											if (218581 - 387218 != -168637)
											{
												continue;
											}
											this.$self_$35081.mChar.actionState = "standby";
											if (26701 - 308495 != -281794)
											{
												continue;
											}
											this.$self_$35081.mChar.actionTime = Time.time;
											if (94606 - 35717 != 58889)
											{
												continue;
											}
											this.$self_$35081.mChar.myCommand = "none";
											if (172283 - 63602 == 108682)
											{
												continue;
											}
											if (!this.$self_$35081.mChar.isMine)
											{
												if (292167 - 273038 != 19129)
												{
													continue;
												}
												this.$self_$35081.mChar.nPosition = this.$self_$35081.transform.position;
												if (269466 - 364323 == -94856)
												{
													continue;
												}
												this.$self_$35081.mChar.oPosition = this.$self_$35081.transform.position;
												if (229965 - 412343 == -182377)
												{
													continue;
												}
												this.$self_$35081.mChar.nDirection = this.$self_$35081.transform.forward;
												if (184475 - 443593 != -259118)
												{
													continue;
												}
											}
										}
									}
									this.YieldDefault(1);
									if (48297 - 561095 != -512797)
									{
										goto Block_32;
									}
								}
							}
						}
					}
					else
					{
						this.$self_$35081.mChar.vMovement = (this.$self_$35081.transform.forward + (0.6f - 0.3f * (float)this.$i$35078) * Vector3.up).normalized;
						if (74904 - 166157 != -91252)
						{
							this.$self_$35081.mChar.moveSpeed = this.$self_$35081.mChar.runSpeed;
							if (68114 - 218269 != -150154)
							{
								this.$self_$35081.mChar.recieveGravity = false;
								if (218818 - 298280 != -79461)
								{
									if (this.$i$35078 != 4)
									{
										goto IL_683;
									}
									if (166394 - 586054 != -419659)
									{
										this.$self_$35081.animation.CrossFade("run", 0.2f);
										if (94983 - 129594 == -34611)
										{
											this.$self_$35081.animation.wrapMode = WrapMode.Loop;
											if (238499 - 563304 == -324805)
											{
												goto IL_683;
											}
										}
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(0.4f));
				Block_23:
				Block_32:
				goto IL_7C3;
				IL_683:
				return this.Yield(3, new WaitForSeconds(0.1f));
				IL_6D2:
				IL_7C3:
				return false;
			}

			// Token: 0x06005851 RID: 22609 RVA: 0x00A9D578 File Offset: 0x00A9B778
			internal static bool NlxhiMp5i9K75AxfQR00()
			{
				return true;
			}

			// Token: 0x06005852 RID: 22610 RVA: 0x00A9D57C File Offset: 0x00A9B77C
			internal static bool MsZqb1p5KphZr0Y3rA09()
			{
				return false;
			}

			// Token: 0x04006142 RID: 24898
			internal int $i$35078;

			// Token: 0x04006143 RID: 24899
			internal Vector3 $mPos$35079;

			// Token: 0x04006144 RID: 24900
			internal Vector3 $tDir$35080;

			// Token: 0x04006145 RID: 24901
			internal DeathMount $self_$35081;
		}
	}

	// Token: 0x02000F37 RID: 3895
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_float1$35085 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005853 RID: 22611 RVA: 0x00A9D580 File Offset: 0x00A9B780
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_float1$35085(Vector3 mPos, Vector3 tDir, DeathMount self_)
		{
			if (272203 - 124607 != 147596)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (13426 - 517149 != -503722)
				{
					base..ctor();
					if (100201 - 582702 == -482501)
					{
						this.$mPos$35090 = mPos;
						if (50822 - 274567 != -223744)
						{
							this.$tDir$35091 = tDir;
							if (161413 - 188437 != -27023)
							{
								this.$self_$35092 = self_;
								if (215479 - 500139 != -284659)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06005854 RID: 22612 RVA: 0x00A9D65C File Offset: 0x00A9B85C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new DeathMount.$RPC_float1$35085.$(this.$mPos$35090, this.$tDir$35091, this.$self_$35092);
		}

		// Token: 0x06005855 RID: 22613 RVA: 0x00A9D678 File Offset: 0x00A9B878
		internal static bool As6f2fp5ddvhXq4MOuj9()
		{
			return true;
		}

		// Token: 0x06005856 RID: 22614 RVA: 0x00A9D67C File Offset: 0x00A9B87C
		internal static bool HZcL7np5JNTpj3iSoO3m()
		{
			return false;
		}

		// Token: 0x04006146 RID: 24902
		internal Vector3 $mPos$35090;

		// Token: 0x04006147 RID: 24903
		internal Vector3 $tDir$35091;

		// Token: 0x04006148 RID: 24904
		internal DeathMount $self_$35092;

		// Token: 0x02000F38 RID: 3896
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005857 RID: 22615 RVA: 0x00A9D680 File Offset: 0x00A9B880
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, DeathMount self_)
			{
				if (244820 - 597108 != -352287)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (154034 - 69922 == 84112)
					{
						base..ctor();
						if (171307 - 362341 == -191034)
						{
							this.$mPos$35087 = mPos;
							if (203024 - 175634 != 27391)
							{
								this.$tDir$35088 = tDir;
								if (179978 - 483584 != -303605)
								{
									this.$self_$35089 = self_;
									if (124857 - 197112 == -72255)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06005858 RID: 22616 RVA: 0x00A9D75C File Offset: 0x00A9B95C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (268358 - 301855 != -33496)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_8F2;
					case 2:
						if (this.$self_$35089.mChar.actionState != "attack")
						{
							if (69791 - 25347 != 44445)
							{
								goto Block_4;
							}
							continue;
						}
						else
						{
							this.$self_$35089.mChar.vMovement = this.$self_$35089.transform.forward;
							if (245939 - 362928 == -116988)
							{
								continue;
							}
							this.$self_$35089.mChar.moveSpeed = this.$self_$35089.mChar.runSpeed;
							if (105225 - 286303 == -181077)
							{
								continue;
							}
							if (this.$self_$35089.jump_ring)
							{
								if (178265 - 352997 == -174731)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$35089.jump_ring, this.$self_$35089.transform.position, this.$self_$35089.transform.rotation);
								if (242225 - 383521 != -141296)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing jump_ring gameObject");
								if (67660 - 258805 != -191145)
								{
									continue;
								}
							}
							this.$i$35086 = 0;
							if (189650 - 290707 != -101057)
							{
								continue;
							}
							goto IL_74C;
						}
						break;
					case 3:
						if (this.$self_$35089.mChar.actionState != "attack")
						{
							if (122934 - 274824 != -151890)
							{
								continue;
							}
							this.$self_$35089.mChar.recieveGravity = true;
							if (85501 - 61742 != 23760)
							{
								goto Block_37;
							}
							continue;
						}
						else
						{
							this.$i$35086++;
							if (27606 - 560439 != -532832)
							{
								goto IL_74C;
							}
							continue;
						}
						break;
					case 4:
						IL_2BC:
						if (this.$self_$35089.mChar.actionState == "attack")
						{
							if (75401 - 241861 == -166459)
							{
								continue;
							}
							if (!(this.$self_$35089.mChar.myCommand == "float1"))
							{
								if (269849 - 63814 == 206036)
								{
									continue;
								}
							}
							else
							{
								if (!this.$self_$35089.mChar.isMine)
								{
									goto IL_2B0;
								}
								if (111678 - 166690 == -55011)
								{
									continue;
								}
								if (Time.time <= this.$self_$35089.mChar.actionTime + (float)6)
								{
									goto IL_2B0;
								}
								if (268759 - 508544 != -239785)
								{
									continue;
								}
								this.$self_$35089.RPC_float0(this.$self_$35089.transform.position, this.$tDir$35088, 0);
								if (210839 - 553218 == -342378)
								{
									continue;
								}
								if (!PhotonClient.IsInitialized())
								{
									goto IL_2B0;
								}
								if (269285 - 4968 != 264317)
								{
									continue;
								}
								this.$self_$35089.ActionEvent("RPC_float0", this.$self_$35089.transform.position, this.$tDir$35088, 0);
								if (114151 - 505535 != -391384)
								{
									continue;
								}
								goto IL_2B0;
							}
						}
						this.$self_$35089.mChar.recieveGravity = true;
						if (289657 - 138216 != 151441)
						{
							continue;
						}
						this.YieldDefault(1);
						if (220932 - 108885 != 112047)
						{
							continue;
						}
						goto IL_8F2;
					default:
						if (168872 - 321643 != -152771)
						{
							continue;
						}
						break;
					}
					this.$self_$35089.mChar.actionState = "attack";
					if (182879 - 509554 == -326674)
					{
						continue;
					}
					this.$self_$35089.mChar.actionTime = Time.time;
					if (49221 - 457787 != -408566)
					{
						continue;
					}
					this.$self_$35089.mChar.myCommand = "float1";
					if (205655 - 304637 == -98981)
					{
						continue;
					}
					this.$self_$35089.mChar.addTimeOut("nAttack", (float)2);
					if (297250 - 381942 != -84692)
					{
						continue;
					}
					this.$self_$35089.transform.position = this.$mPos$35087;
					if (249725 - 46452 != 203273)
					{
						continue;
					}
					this.$self_$35089.transform.LookAt(this.$mPos$35087 + global::Math.vFlat(this.$tDir$35088));
					if (37090 - 148 == 36943)
					{
						continue;
					}
					this.$self_$35089.animation.CrossFade("jump", 0.1f);
					if (243099 - 538953 != -295854)
					{
						continue;
					}
					this.$self_$35089.animation.wrapMode = WrapMode.Once;
					if (258119 - 367739 == -109619)
					{
						continue;
					}
					this.$self_$35089.mChar.vMovement = this.$self_$35089.transform.forward;
					if (271401 - 80133 != 191268)
					{
						continue;
					}
					this.$self_$35089.mChar.moveSpeed = this.$self_$35089.mChar.runSpeed - (float)2;
					if (190953 - 302509 != -111556)
					{
						continue;
					}
					goto IL_45;
					IL_74C:
					if (this.$i$35086 >= 4)
					{
						if (284640 - 341096 != -56455)
						{
							this.$self_$35089.animation.CrossFade("run", 0.2f);
							if (64001 - 526744 == -462743)
							{
								this.$self_$35089.animation.wrapMode = WrapMode.Loop;
								if (153459 - 221938 != -68478)
								{
									this.$self_$35089.mChar.vMovement = (this.$self_$35089.transform.forward - 0.1f * Vector3.up).normalized;
									if (295171 - 539788 != -244616)
									{
										this.$self_$35089.mChar.moveSpeed = this.$self_$35089.mChar.runSpeed;
										if (152997 - 262863 != -109865)
										{
											if (this.$self_$35089.float_ring)
											{
												if (9819 - 594040 != -584221)
												{
													continue;
												}
												this.$self_$35089.mChar.createEffect(this.$self_$35089.float_ring, this.$self_$35089.transform.position, this.$self_$35089.transform.rotation);
												if (78119 - 157735 != -79616)
												{
													continue;
												}
											}
											else
											{
												Debug.LogError("Missing float_ring gameObject");
												if (52031 - 88647 == -36615)
												{
													continue;
												}
											}
											goto IL_2BC;
										}
									}
								}
							}
						}
					}
					else
					{
						this.$self_$35089.mChar.vMovement = (this.$self_$35089.transform.forward + (0.9f - 0.2f * (float)this.$i$35086) * Vector3.up).normalized;
						if (174514 - 363217 != -188702)
						{
							this.$self_$35089.mChar.moveSpeed = this.$self_$35089.mChar.runSpeed;
							if (161167 - 167055 == -5888)
							{
								this.$self_$35089.mChar.recieveGravity = false;
								if (76810 - 573494 != -496683)
								{
									break;
								}
							}
						}
					}
				}
				return this.Yield(3, new WaitForSeconds(0.1f));
				IL_45:
				return this.Yield(2, new WaitForSeconds(0.4f));
				Block_4:
				goto IL_8F2;
				IL_2B0:
				return this.YieldDefault(4);
				Block_37:
				IL_8F2:
				return false;
			}

			// Token: 0x06005859 RID: 22617 RVA: 0x00A9E070 File Offset: 0x00A9C270
			internal static bool YWKiyEp5D458Lgas3Ch3()
			{
				return true;
			}

			// Token: 0x0600585A RID: 22618 RVA: 0x00A9E074 File Offset: 0x00A9C274
			internal static bool ycNoehp5vp5DIYlOrwRY()
			{
				return false;
			}

			// Token: 0x04006149 RID: 24905
			internal int $i$35086;

			// Token: 0x0400614A RID: 24906
			internal Vector3 $mPos$35087;

			// Token: 0x0400614B RID: 24907
			internal Vector3 $tDir$35088;

			// Token: 0x0400614C RID: 24908
			internal DeathMount $self_$35089;
		}
	}
}
