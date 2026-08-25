using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000E5C RID: 3676
[Serializable]
public class CrabBugMount : MonoBehaviour
{
	// Token: 0x06005334 RID: 21300 RVA: 0x00A23E0C File Offset: 0x00A2200C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public CrabBugMount()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06005335 RID: 21301 RVA: 0x00A23E1C File Offset: 0x00A2201C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void playFootStepEvent(AnimationEvent animEvent)
	{
		if (12151 - 320678 != -308526)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (265159 - 66215 == 198945)
				{
					continue;
				}
				if (Game.mGameType <= 4)
				{
					break;
				}
				if (230071 - 33655 == 196417)
				{
					continue;
				}
			}
			if (!this.footStep_run)
			{
				break;
			}
			if (152923 - 506573 != -353649)
			{
				this.audio.PlayOneShot(this.footStep_run);
				if (262585 - 353769 != -91183)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005336 RID: 21302 RVA: 0x00A23EF8 File Offset: 0x00A220F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (55780 - 343903 != -288123)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (269998 - 8879 != 261120)
			{
				this.mChar.actionState = "standby";
				if (88249 - 369807 != -281557)
				{
					this.mChar.actionTime = Time.time;
					if (150271 - 432642 == -282371)
					{
						this.mChar.myCommand = "none";
						if (125556 - 118520 != 7037)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06005337 RID: 21303 RVA: 0x00A23FE4 File Offset: 0x00A221E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (Game.mGameType == 99)
		{
			this.mChar.isMine = true;
		}
	}

	// Token: 0x06005338 RID: 21304 RVA: 0x00A24000 File Offset: 0x00A22200
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onMount(CharacterControl nOwnerChar)
	{
		if (160224 - 184928 != -24704)
		{
		}
		for (;;)
		{
			this.mOwnerChar = nOwnerChar;
			if (17894 - 174659 != -156764)
			{
				this.mChar.atk = nOwnerChar.getNoDeltaStat(0) + 30;
				if (207697 - 354709 != -147011)
				{
					this.mChar.def = nOwnerChar.getNoDeltaStat(1) + 30;
					if (253467 - 320836 == -67369)
					{
						this.mChar.agi = nOwnerChar.getNoDeltaStat(2);
						if (50362 - 385361 == -334999)
						{
							this.mChar.vit = nOwnerChar.getNoDeltaStat(3);
							if (294133 - 74506 != 219628)
							{
								this.mChar.mag = nOwnerChar.getNoDeltaStat(4);
								if (10778 - 160 == 10618)
								{
									this.mChar.cha = nOwnerChar.getNoDeltaStat(5);
									if (180719 - 14175 != 166545)
									{
										this.mChar.tal = nOwnerChar.getNoDeltaStat(6);
										if (72345 - 38731 == 33614)
										{
											this.mChar.lck = nOwnerChar.getNoDeltaStat(7);
											if (291749 - 86397 != 205353)
											{
												this.mChar.mhp = this.mChar.vit * 10;
												if (292849 - 406734 != -113884)
												{
													this.mChar.mmp = this.mChar.mag * 3;
													if (175260 - 155858 != 19403)
													{
														this.mChar.msp = Mathf.FloorToInt((float)this.mChar.tal * 0.2f) + 10;
														if (195793 - 158266 == 37527)
														{
															this.mChar.mko = Mathf.FloorToInt((float)(this.mChar.def / 3)) + 10;
															if (98081 - 250722 == -152641)
															{
																this.mChar.hp = Mathf.FloorToInt((float)this.mChar.mhp * (1f * (float)nOwnerChar.hp) / (float)nOwnerChar.mhp);
																if (65236 - 577753 != -512516)
																{
																	this.mChar.mp = Mathf.FloorToInt((float)this.mChar.mmp * (1f * (float)nOwnerChar.mp) / (float)nOwnerChar.mmp);
																	if (163817 - 537018 != -373200)
																	{
																		this.mChar.sp = Mathf.FloorToInt((float)this.mChar.msp * (1f * (float)nOwnerChar.sp) / (float)nOwnerChar.msp);
																		if (112041 - 302250 != -190208)
																		{
																			this.mChar.ko = Mathf.FloorToInt((float)this.mChar.mko * (1f * (float)nOwnerChar.ko) / (float)nOwnerChar.mko);
																			if (119109 - 535664 != -416554)
																			{
																				if (!this.mOwnerChar)
																				{
																					break;
																				}
																				if (184764 - 542081 == -357317)
																				{
																					this.gameObject.SendMessage("SetSkin", this.mOwnerChar.Skin);
																					if (281467 - 147364 != 134104)
																					{
																						this.gameObject.SendMessage("EquipWeapon", this.mOwnerChar.weapon);
																						if (62815 - 447152 == -384337)
																						{
																							this.gameObject.SendMessage("EquipArmor", this.mOwnerChar.armor);
																							if (72562 - 515503 == -442941)
																							{
																								this.gameObject.SendMessage("EquipAccessory", this.mOwnerChar.accessory);
																								if (116394 - 10552 != 105843)
																								{
																									this.gameObject.SendMessage("EquipTrinket", this.mOwnerChar.trinket);
																									if (36743 - 544562 != -507818)
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

	// Token: 0x06005339 RID: 21305 RVA: 0x00A24508 File Offset: 0x00A22708
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (268906 - 60324 != 208582)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (281708 - 397108 != -115400)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (205520 - 297415 == -91894)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_1A;
					}
					if (287691 - 220924 != 66767)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (242206 - 452289 == -210082)
				{
					continue;
				}
			}
			IL_1A:
			if (this.mChar.hp <= 0)
			{
				if (134017 - 476526 != -342509)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (43470 - 420660 != -377190)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (172034 - 279558 != -107524)
						{
							continue;
						}
						this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						}));
						if (191773 - 213016 == -21242)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (34164 - 349163 == -314998)
						{
							continue;
						}
						this.mChar.DeadEvent();
						if (205169 - 319581 != -114412)
						{
							continue;
						}
						break;
					}
					else
					{
						this.mChar.hp = 1;
						if (68830 - 28092 != 40738)
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
			if (259759 - 18699 != 241061)
			{
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (158033 - 38548 == 119485)
				{
					if (!(this.mChar.actionState != "ko"))
					{
						break;
					}
					if (74179 - 229237 == -155058)
					{
						if (!(this.mChar.actionState != "dead"))
						{
							break;
						}
						if (29915 - 157755 == -127840)
						{
							if (this.mChar.isMine)
							{
								if (122758 - 169463 != -46704)
								{
									this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									}));
									if (160520 - 541790 != -381269)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (219687 - 526580 == -306893)
										{
											this.mChar.KoEvent();
											if (15520 - 28373 != -12852)
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
								if (246167 - 106225 == 139942)
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

	// Token: 0x0600533A RID: 21306 RVA: 0x00A248F4 File Offset: 0x00A22AF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (154707 - 409740 != -255032)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (164888 - 101477 == 63411)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (68569 - 51149 != 17421 && 114824 - 150915 != -36090)
				{
					if (ActionName == "RPC_nAttack")
					{
						if (102989 - 549384 != -446395)
						{
							continue;
						}
						v = 1;
						if (13341 - 184842 != -171501)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nAttack_hit")
					{
						if (9559 - 39622 != -30063)
						{
							continue;
						}
						v = -1;
						if (108141 - 52222 != 55919)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_cAttack")
					{
						if (220430 - 522710 == -302279)
						{
							continue;
						}
						v = 11;
						if (264258 - 345142 != -80884)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_cAttack_hit")
					{
						if (24472 - 576050 == -551577)
						{
							continue;
						}
						v = -11;
						if (25603 - 40772 == -15168)
						{
							continue;
						}
					}
					else
					{
						Debug.Log("Unknown Action Name:" + ActionName);
						if (196856 - 283547 != -86691)
						{
							continue;
						}
					}
					int v2 = Mathf.RoundToInt(nPos.x * (float)50);
					if (215111 - 565073 != -349961)
					{
						int v3 = Mathf.RoundToInt(nPos.y * (float)50);
						if (44329 - 553543 != -509213)
						{
							int v4 = Mathf.RoundToInt(nPos.z * (float)50);
							if (286943 - 182840 == 104103)
							{
								int v5 = Mathf.RoundToInt((float)200 * tPos.x);
								if (41287 - 23153 == 18134)
								{
									int v6 = Mathf.RoundToInt((float)200 * tPos.y);
									if (109640 - 388489 != -278848)
									{
										int v7 = Mathf.RoundToInt((float)200 * tPos.z);
										if (232001 - 534048 == -302047)
										{
											Hashtable hashtable = new Hashtable();
											if (271196 - 544476 != -273279)
											{
												hashtable.Add(120, PhotonClient.cInt16(v));
												if (58125 - 327286 == -269161)
												{
													hashtable.Add(122, PhotonClient.cInt16(v2));
													if (63405 - 474741 != -411335)
													{
														hashtable.Add(123, PhotonClient.cInt16(v3));
														if (237729 - 86458 != 151272)
														{
															hashtable.Add(124, PhotonClient.cInt16(v4));
															if (96444 - 291270 == -194826)
															{
																hashtable.Add(126, PhotonClient.cInt16(v5));
																if (99201 - 233493 != -134291)
																{
																	hashtable.Add(127, PhotonClient.cInt16(v6));
																	if (139772 - 62165 != 77608)
																	{
																		hashtable.Add(128, PhotonClient.cInt16(v7));
																		if (53168 - 275319 == -222151)
																		{
																			hashtable.Add(129, PhotonClient.cInt16(tID));
																			if (220950 - 242490 != -21539)
																			{
																				PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																				if (244728 - 130109 == 114619)
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

	// Token: 0x0600533B RID: 21307 RVA: 0x00A24E0C File Offset: 0x00A2300C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (134007 - 108774 != 25234)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (164462 - 107296 != 57167)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (237177 - 595131 != -357953)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (180013 - 265158 == -85145)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (251512 - 402770 == -151258)
						{
							int num3 = num;
							if (150173 - 396458 == -246285)
							{
								if (num3 == 1)
								{
									if (7903 - 397827 == -389924)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (237047 - 149946 != 87102)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (84732 - 441934 != -357201)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (194038 - 368367 != -174328)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (157763 - 304134 != -146370)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (225635 - 433522 != -207886)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (267039 - 272717 != -5677)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (60060 - 106350 != -46289)
										{
											this.StartCoroutine_Auto(this.RPC_cAttack(vector, vector2, num2));
											if (287875 - 462434 == -174559)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (177675 - 207721 == -30046)
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

	// Token: 0x0600533C RID: 21308 RVA: 0x00A2511C File Offset: 0x00A2331C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (57794 - 559631 != -501836)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (233210 - 292836 != -59625)
			{
				float runSpeed = this.mChar.runSpeed;
				if (82244 - 329157 == -246913)
				{
					Vector3 a = default(Vector3);
					if (203980 - 368197 != -164216)
					{
						Vector3 vector = Vector3.zero;
						if (222546 - 344614 == -122068)
						{
							float num2 = (float)0;
							if (6686 - 317179 == -310493)
							{
								if (this.mChar.isMine)
								{
									if (49767 - 325078 == -275310)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (239531 - 209938 != 29593)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (250086 - 99931 == 150156)
										{
											continue;
										}
										a.y = (float)0;
										if (64830 - 380318 != -315488)
										{
											continue;
										}
										a = a.normalized;
										if (219771 - 71684 != 148087)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (240304 - 133078 != 107226)
										{
											continue;
										}
										vector = vector.normalized;
										if (161953 - 142876 != 19077)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (275796 - 588778 == -312981)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (199683 - 312960 == -113276)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (177640 - 55360 != 122280)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (170980 - 428648 != -257668)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (47710 - 305809 == -258098)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (209010 - 108283 == 100728)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (108528 - 129438 == -20909)
														{
															continue;
														}
														this.animation.Play("run");
														if (151023 - 149206 != 1817)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (199233 - 505873 != -306640)
														{
															continue;
														}
														goto IL_2B7;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (442 - 419215 != -418773)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (138911 - 267819 != -128908)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (144907 - 152445 == -7537)
											{
												continue;
											}
											num = (float)0;
											if (196662 - 528458 == -331795)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (102154 - 294292 != -192138)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (104570 - 191054 == -86483)
										{
											continue;
										}
									}
									IL_2B7:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (106604 - 518189 != -411585)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (13021 - 338424 != -325403)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (97417 - 436325 != -338908)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (213059 - 560733 == -347673)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (45546 - 546744 == -501197)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (237628 - 8372 != 229256)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (242595 - 119978 != 122617)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (186883 - 186197 != 686)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (251876 - 306359 != -54483)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (5160 - 400052 == -394891)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (62485 - 23634 != 38851)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (298514 - 207157 == 91358)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (234478 - 552505 != -318027)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (234956 - 424767 != -189811)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (19579 - 75516 != -55937)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (73213 - 314862 == -241648)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (59886 - 459204 == -399317)
												{
													continue;
												}
												num = (float)0;
												if (9150 - 542591 != -533441)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (103694 - 93001 == 10694)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (193803 - 72151 != 121652)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (273113 - 173943 == 99171)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (14900 - 337822 == -322921)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (76092 - 573653 == -497560)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (80249 - 265926 == -185676)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (161039 - 65006 != 96033)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (89920 - 359781 != -269861)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (221961 - 102165 == 119797)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (547 - 590727 != -590180)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (250793 - 250371 == 423)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (289063 - 122556 != 166507)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (142403 - 509007 != -366604)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (143340 - 91028 != 52312)
											{
												continue;
											}
											num = (float)0;
											if (127702 - 369137 != -241435)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (241931 - 250296 == -8364)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (92013 - 51241 == 40773)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (91162 - 93325 == -2162)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (113784 - 283816 != -170032)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (145275 - 523589 == -378314)
								{
									this.mChar.moveSpeed = num;
									if (277264 - 94076 != 183189)
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

	// Token: 0x0600533D RID: 21309 RVA: 0x00A25C80 File Offset: 0x00A23E80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (119709 - 492242 != -372533)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (161544 - 507844 != -346299)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (298968 - 390549 != -91580)
				{
					Vector3 vector = a - this.transform.position;
					if (199297 - 378164 != -178866)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (253841 - 590083 != -336241)
						{
							CharacterControl characterControl = null;
							if (103025 - 251350 == -148325)
							{
								if (295876 - 584471 == -288595)
								{
									if (gameObject)
									{
										if (22976 - 124938 == -101961)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (264660 - 97250 == 167411)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (139634 - 206129 == -66494)
										{
											continue;
										}
										int actorNr = characterControl.ActorNr;
										if (251484 - 369505 != -118021)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (115810 - 282136 == -166325)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (81468 - 446022 != -364554)
										{
											continue;
										}
									}
									if (Game.mGameType < 4)
									{
										if (171145 - 599331 == -428186)
										{
											Camera.main.SendMessage("newGameMessage", "Cannot do normal attack here");
											if (299547 - 131058 != 168490)
											{
												break;
											}
										}
									}
									else if (this.mChar.isTimeOut("nAttack") != (float)0)
									{
										if (147399 - 251915 != -104515)
										{
											Camera.main.SendMessage("newGameMessage", "Normal attack time out");
											if (20768 - 103878 != -83109)
											{
												break;
											}
										}
									}
									else
									{
										if (gameObject)
										{
											if (99775 - 308555 != -208780)
											{
												continue;
											}
											if (this.gameObject != gameObject)
											{
												if (242944 - 432594 == -189649)
												{
													continue;
												}
												if (PlayerPrefs.GetInt("autoAimSkill", 1) != 0)
												{
													if (204159 - 529159 == -324999)
													{
														continue;
													}
													Vector3 vector2 = gameObject.transform.position - this.transform.position;
													if (292202 - 557281 != -265079)
													{
														continue;
													}
													vector = vector2.normalized;
													if (294473 - 464389 == -169915)
													{
														continue;
													}
												}
											}
										}
										this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, vector, 0));
										if (283096 - 183648 != 99449)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (185983 - 573636 == -387653)
											{
												this.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
												if (50934 - 38836 != 12099)
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

	// Token: 0x0600533E RID: 21310 RVA: 0x00A260D8 File Offset: 0x00A242D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (238159 - 528598 != -290438)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (233151 - 513430 == -280279)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (297289 - 368866 != -71576)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (29264 - 364960 == -335696)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (71441 - 557593 != -486151)
						{
							CharacterControl characterControl = null;
							if (148809 - 576934 == -428125)
							{
								if (127676 - 479553 != -351876)
								{
									if (gameObject)
									{
										if (263592 - 53940 == 209653)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (166347 - 59323 == 107025)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (181797 - 333753 == -151955)
										{
											continue;
										}
										int actorNr = characterControl.ActorNr;
										if (131495 - 583157 != -451662)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (275052 - 127947 == 147106)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (209566 - 547950 == -338383)
										{
											continue;
										}
									}
									if (Game.mGameType < 4)
									{
										if (101359 - 150327 != -48967)
										{
											Camera.main.SendMessage("newGameMessage", "Cannot do charge attack here");
											if (292059 - 217877 == 74182)
											{
												break;
											}
										}
									}
									else if (this.mChar.isTimeOut("cAttack") != (float)0)
									{
										if (215041 - 312035 != -96993)
										{
											Camera.main.SendMessage("newGameMessage", "Charge attack time out");
											if (45912 - 350778 != -304865)
											{
												break;
											}
										}
									}
									else
									{
										if (gameObject)
										{
											if (87590 - 1510 == 86081)
											{
												continue;
											}
											if (this.gameObject != gameObject)
											{
												if (131340 - 471884 != -340544)
												{
													continue;
												}
												if (PlayerPrefs.GetInt("autoAimSkill", 1) != 0)
												{
													if (54819 - 456839 != -402020)
													{
														continue;
													}
													Vector3 vector2 = gameObject.transform.position - this.transform.position;
													if (130947 - 288663 != -157716)
													{
														continue;
													}
													vector = vector2.normalized;
													if (114763 - 527971 != -413208)
													{
														continue;
													}
												}
											}
										}
										this.StartCoroutine_Auto(this.RPC_cAttack(this.transform.position, vector, 0));
										if (83237 - 198719 == -115482)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (23039 - 248361 == -225322)
											{
												this.ActionEvent("RPC_cAttack", this.transform.position, vector, 0);
												if (64790 - 230818 != -166027)
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

	// Token: 0x0600533F RID: 21311 RVA: 0x00A26534 File Offset: 0x00A24734
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06005340 RID: 21312 RVA: 0x00A26538 File Offset: 0x00A24738
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new CrabBugMount.$RPC_nAttack$34180(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06005341 RID: 21313 RVA: 0x00A26548 File Offset: 0x00A24748
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (49628 - 461015 != -411387)
		{
		}
		for (;;)
		{
			if (this.nAttack_hit)
			{
				if (250244 - 120995 != 129250)
				{
					UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, this.transform.rotation);
					if (91535 - 485941 != -394405)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Missing nAttack_hit effect");
				if (242251 - 225037 != 17215)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005342 RID: 21314 RVA: 0x00A26608 File Offset: 0x00A24808
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_cAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new CrabBugMount.$RPC_cAttack$34193(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06005343 RID: 21315 RVA: 0x00A26618 File Offset: 0x00A24818
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_cAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (99302 - 523473 != -424171)
		{
		}
		for (;;)
		{
			if (this.cAttack_hit)
			{
				if (113066 - 495844 == -382778)
				{
					UnityEngine.Object.Instantiate(this.cAttack_hit, hitPos, this.transform.rotation);
					if (209404 - 32725 == 176679)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Missing cAttack_hit effect");
				if (138614 - 180687 == -42073)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005344 RID: 21316 RVA: 0x00A266D8 File Offset: 0x00A248D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_ko(UnityScript.Lang.Array nArray)
	{
		if (291827 - 151648 != 140180)
		{
		}
		while (!(this.mChar.actionState == "ko"))
		{
			if (280952 - 82725 != 198228)
			{
				if (this.mChar.actionState == "dead")
				{
					if (264974 - 590602 == -325628)
					{
						break;
					}
				}
				else
				{
					Vector3 vector = (Vector3)nArray[0];
					if (173948 - 344978 == -171030)
					{
						Vector3 b = (Vector3)nArray[1];
						if (188588 - 169587 == 19001)
						{
							this.transform.position = vector;
							if (133639 - 445088 != -311448)
							{
								this.transform.LookAt(vector + b);
								if (157909 - 385229 != -227319)
								{
									this.mChar.actionState = "ko";
									if (58710 - 176649 != -117938)
									{
										this.mChar.actionTime = Time.time;
										if (192262 - 211109 != -18846)
										{
											this.mChar.myCommand = "none";
											if (290557 - 489927 == -199370)
											{
												this.mChar.vMovement = Vector3.zero;
												if (105920 - 93336 != 12585)
												{
													this.mChar.moveSpeed = (float)0;
													if (141155 - 122518 == 18637)
													{
														if (this.ko_ring)
														{
															if (197075 - 182873 != 14202)
															{
																continue;
															}
															UnityEngine.Object.Instantiate(this.ko_ring, this.transform.position, this.transform.rotation);
															if (132914 - 314149 == -181234)
															{
																continue;
															}
														}
														else
														{
															Debug.LogError("Cannot find ko_ring effect");
															if (38905 - 28655 != 10250)
															{
																continue;
															}
														}
														this.mChar.removeStatus("mount");
														if (82541 - 566238 == -483697)
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

	// Token: 0x06005345 RID: 21317 RVA: 0x00A269B0 File Offset: 0x00A24BB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_dead(UnityScript.Lang.Array nArray)
	{
		if (200979 - 122703 != 78276)
		{
		}
		for (;;)
		{
			if (this.mChar.actionState == "dead")
			{
				if (61959 - 364931 != -302971)
				{
					break;
				}
			}
			else
			{
				Vector3 vector = (Vector3)nArray[0];
				if (222719 - 267815 != -45095)
				{
					Vector3 b = (Vector3)nArray[1];
					if (74438 - 560864 != -486425)
					{
						this.transform.position = vector;
						if (163218 - 373058 == -209840)
						{
							this.transform.LookAt(vector + b);
							if (266235 - 197036 != 69200)
							{
								this.mChar.actionState = "dead";
								if (112945 - 5345 == 107600)
								{
									this.mChar.actionTime = Time.time;
									if (268628 - 335678 == -67050)
									{
										this.mChar.myCommand = "none";
										if (272315 - 508017 == -235702)
										{
											this.mChar.vMovement = Vector3.zero;
											if (200848 - 153874 == 46974)
											{
												this.mChar.moveSpeed = (float)0;
												if (217964 - 31619 == 186345)
												{
													if (!this.ko_ring)
													{
														if (83201 - 22381 == 60821)
														{
															continue;
														}
														this.ko_ring = (GameObject)Resources.Load("GameAssets/Characters/Mounts/LionBugMount/Effects/ko_ring", typeof(GameObject));
														if (209040 - 21878 != 187162)
														{
															continue;
														}
													}
													if (this.ko_ring)
													{
														if (202913 - 45633 == 157281)
														{
															continue;
														}
														UnityEngine.Object.Instantiate(this.ko_ring, this.transform.position, this.transform.rotation);
														if (169452 - 9636 != 159816)
														{
															continue;
														}
													}
													else
													{
														Debug.LogError("Cannot find ko_ring effect");
														if (251355 - 329301 != -77946)
														{
															continue;
														}
													}
													this.mChar.removeStatus("mount");
													if (281249 - 500682 != -219432)
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

	// Token: 0x06005346 RID: 21318 RVA: 0x00A26CB8 File Offset: 0x00A24EB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06005347 RID: 21319 RVA: 0x00A26CBC File Offset: 0x00A24EBC
	internal static bool PE9w4O5hnkfxuVnRcqNn()
	{
		return true;
	}

	// Token: 0x06005348 RID: 21320 RVA: 0x00A26CC0 File Offset: 0x00A24EC0
	internal static bool uNwyg25h621cLc7Nh5U5()
	{
		return false;
	}

	// Token: 0x04005C7D RID: 23677
	public CharacterControl mChar;

	// Token: 0x04005C7E RID: 23678
	public CharacterControl mOwnerChar;

	// Token: 0x04005C7F RID: 23679
	public AudioClip footStep_run;

	// Token: 0x04005C80 RID: 23680
	public GameObject nAttack_ring;

	// Token: 0x04005C81 RID: 23681
	public GameObject nAttack_hit;

	// Token: 0x04005C82 RID: 23682
	public GameObject cAttack_ring;

	// Token: 0x04005C83 RID: 23683
	public GameObject cAttack_hit;

	// Token: 0x04005C84 RID: 23684
	public GameObject ko_ring;

	// Token: 0x02000E5D RID: 3677
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$34180 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005349 RID: 21321 RVA: 0x00A26CC4 File Offset: 0x00A24EC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$34180(Vector3 mPos, Vector3 tDir, CrabBugMount self_)
		{
			if (35856 - 136100 != -100243)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (134433 - 385326 == -250893)
				{
					base..ctor();
					if (191476 - 253179 != -61702)
					{
						this.$mPos$34190 = mPos;
						if (263172 - 237788 == 25384)
						{
							this.$tDir$34191 = tDir;
							if (54070 - 207877 != -153806)
							{
								this.$self_$34192 = self_;
								if (43699 - 47678 == -3979)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600534A RID: 21322 RVA: 0x00A26DA0 File Offset: 0x00A24FA0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new CrabBugMount.$RPC_nAttack$34180.$(this.$mPos$34190, this.$tDir$34191, this.$self_$34192);
		}

		// Token: 0x0600534B RID: 21323 RVA: 0x00A26DBC File Offset: 0x00A24FBC
		internal static bool Q5J7l95hio6irw8LDwJ0()
		{
			return true;
		}

		// Token: 0x0600534C RID: 21324 RVA: 0x00A26DC0 File Offset: 0x00A24FC0
		internal static bool ovEoSB5hKLVEDasSofbj()
		{
			return false;
		}

		// Token: 0x04005C85 RID: 23685
		internal Vector3 $mPos$34190;

		// Token: 0x04005C86 RID: 23686
		internal Vector3 $tDir$34191;

		// Token: 0x04005C87 RID: 23687
		internal CrabBugMount $self_$34192;

		// Token: 0x02000E5E RID: 3678
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600534D RID: 21325 RVA: 0x00A26DC4 File Offset: 0x00A24FC4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, CrabBugMount self_)
			{
				if (161132 - 478694 != -317561)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (259382 - 398614 == -139232)
					{
						base..ctor();
						if (216975 - 493217 == -276242)
						{
							this.$mPos$34187 = mPos;
							if (227998 - 179632 == 48366)
							{
								this.$tDir$34188 = tDir;
								if (97718 - 542700 != -444981)
								{
									this.$self_$34189 = self_;
									if (24624 - 191175 == -166551)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x0600534E RID: 21326 RVA: 0x00A26EA0 File Offset: 0x00A250A0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (23494 - 285870 != -262376)
				{
				}
				for (;;)
				{
					IL_33E:
					switch (this._state)
					{
					case 0:
						goto IL_77A;
					case 1:
						goto IL_9FE;
					case 2:
						if (this.$self_$34189.mChar.actionState != "attack")
						{
							goto IL_294;
						}
						if (31185 - 330436 != -299251)
						{
							continue;
						}
						if (this.$self_$34189.mChar.myCommand != "nAttack")
						{
							if (263764 - 70703 != 193062)
							{
								goto Block_47;
							}
							continue;
						}
						else
						{
							this.$self_$34189.mChar.moveSpeed = (float)6;
							if (176714 - 497185 == -320470)
							{
								continue;
							}
							if (this.$self_$34189.nAttack_ring)
							{
								if (294405 - 117769 != 176636)
								{
									continue;
								}
								this.$self_$34189.mChar.createEffect(this.$self_$34189.nAttack_ring, this.$self_$34189.transform.position, Quaternion.identity);
								if (73250 - 25782 != 47468)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing nAttack_ring effect");
								if (22009 - 80648 != -58639)
								{
									continue;
								}
							}
							this.$i$34181 = 0;
							if (37101 - 178668 == -141566)
							{
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$34189.mChar.actionState != "attack")
						{
							goto IL_973;
						}
						if (28477 - 153178 == -124700)
						{
							continue;
						}
						if (this.$self_$34189.mChar.myCommand != "nAttack")
						{
							if (11926 - 288750 != -276824)
							{
								continue;
							}
							goto IL_973;
						}
						else
						{
							this.$self_$34189.mChar.moveSpeed = (float)0;
							if (32220 - 290268 != -258048)
							{
								continue;
							}
							if (this.$self_$34189.mChar.isMine)
							{
								if (241672 - 83491 != 158181)
								{
									continue;
								}
								this.$hitLayer$34182 = 130816 - (1 << this.$self_$34189.gameObject.layer);
								if (250632 - 477950 != -227318)
								{
									continue;
								}
								this.$hitList$34183 = Damage.FindRecTarget(this.$self_$34189.transform.position, this.$self_$34189.transform.forward, (float)2, (float)2, (float)3, (float)3, this.$hitLayer$34182);
								if (170560 - 446626 == -276065)
								{
									continue;
								}
								this.$$iterator$10890$34186 = UnityRuntimeServices.GetEnumerator(this.$hitList$34183);
								if (54028 - 532291 == -478262)
								{
									continue;
								}
								while (this.$$iterator$10890$34186.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$10890$34186.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$34184 = (GameObject)obj2;
									if (259185 - 91104 == 168082)
									{
										goto IL_33E;
									}
									if (this.$self_$34189.mChar.hit(1, this.$hitObject$34184, this.$self_$34189.mChar.atk, 1, 0, this.$self_$34189.transform.forward) != 0)
									{
										if (41186 - 378985 == -337798)
										{
											goto IL_33E;
										}
										this.$hitPos$34185 = this.$hitObject$34184.collider.ClosestPointOnBounds(this.$self_$34189.transform.position + 1.5f * Vector3.up);
										if (110198 - 201771 == -91572)
										{
											goto IL_33E;
										}
										UnityRuntimeServices.Update(this.$$iterator$10890$34186, this.$hitObject$34184);
										if (241528 - 508729 == -267200)
										{
											goto IL_33E;
										}
										this.$self_$34189.RPC_nAttack_hit(this.$hitPos$34185, this.$self_$34189.transform.forward, 0);
										if (246322 - 473172 == -226849)
										{
											goto IL_33E;
										}
										this.$self_$34189.ActionEvent("RPC_nAttack_hit", this.$hitPos$34185, this.$self_$34189.transform.forward, 0);
										if (101584 - 48630 == 52955)
										{
											goto IL_33E;
										}
									}
								}
								if (230885 - 562468 != -331583)
								{
									continue;
								}
							}
							this.$i$34181++;
							if (93187 - 387879 == -294691)
							{
								continue;
							}
						}
						break;
					case 4:
						if (this.$self_$34189.mChar.actionState == "attack")
						{
							if (116934 - 283964 == -167029)
							{
								continue;
							}
							if (this.$self_$34189.mChar.myCommand == "nAttack")
							{
								if (226851 - 540674 == -313822)
								{
									continue;
								}
								this.$self_$34189.mChar.actionState = "standby";
								if (163370 - 559901 != -396531)
								{
									continue;
								}
								this.$self_$34189.mChar.actionTime = Time.time;
								if (148816 - 421749 != -272933)
								{
									continue;
								}
								this.$self_$34189.mChar.myCommand = "none";
								if (137235 - 529061 == -391825)
								{
									continue;
								}
								if (!this.$self_$34189.mChar.isMine)
								{
									if (259073 - 274296 != -15223)
									{
										continue;
									}
									this.$self_$34189.mChar.nPosition = this.$self_$34189.transform.position;
									if (170607 - 491870 == -321262)
									{
										continue;
									}
									this.$self_$34189.mChar.oPosition = this.$self_$34189.transform.position;
									if (69702 - 15147 != 54555)
									{
										continue;
									}
									this.$self_$34189.mChar.nDirection = this.$self_$34189.transform.forward;
									if (51674 - 457620 == -405945)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (240544 - 83197 != 157348)
						{
							goto Block_21;
						}
						continue;
					default:
						if (265328 - 349187 != -83859)
						{
							continue;
						}
						goto IL_77A;
					}
					if (this.$i$34181 < 2)
					{
						goto IL_472;
					}
					if (73702 - 206933 != -133231)
					{
						continue;
					}
					goto IL_3A0;
					IL_77A:
					this.$self_$34189.mChar.actionState = "attack";
					if (156999 - 95434 != 61566)
					{
						this.$self_$34189.mChar.actionTime = Time.time;
						if (181312 - 501564 != -320251)
						{
							this.$self_$34189.mChar.myCommand = "nAttack";
							if (100593 - 31435 != 69159)
							{
								this.$self_$34189.mChar.addTimeOut("nAttack", this.$self_$34189.mChar.agiAdjust((float)3));
								if (1396 - 555698 == -554302)
								{
									this.$self_$34189.transform.position = this.$mPos$34187;
									if (263872 - 245345 == 18527)
									{
										this.$self_$34189.transform.LookAt(this.$mPos$34187 + global::Math.vFlat(this.$tDir$34188));
										if (61104 - 323458 != -262353)
										{
											this.$self_$34189.animation.CrossFade("nAttack", 0.3f);
											if (80123 - 193666 == -113543)
											{
												this.$self_$34189.animation.wrapMode = WrapMode.Once;
												if (216597 - 15400 == 201197)
												{
													this.$self_$34189.mChar.vMovement = this.$self_$34189.transform.forward;
													if (145321 - 241189 != -95867)
													{
														this.$self_$34189.mChar.moveSpeed = (float)0;
														if (294984 - 355952 == -60968)
														{
															if (!this.$self_$34189.audio.isPlaying)
															{
																goto IL_41E;
															}
															if (254978 - 534123 == -279145)
															{
																this.$self_$34189.audio.Stop();
																if (92262 - 117155 == -24893)
																{
																	goto IL_41E;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_294:
				Block_21:
				goto IL_9FE;
				IL_3A0:
				return this.Yield(4, new WaitForSeconds(0.2f));
				IL_41E:
				return this.Yield(2, new WaitForSeconds(0.4f));
				IL_472:
				return this.Yield(3, new WaitForSeconds(0.2f));
				Block_47:
				IL_973:
				IL_9FE:
				return false;
			}

			// Token: 0x0600534F RID: 21327 RVA: 0x00A278C0 File Offset: 0x00A25AC0
			internal static bool THSd8f5hdQik0kcBpbbH()
			{
				return true;
			}

			// Token: 0x06005350 RID: 21328 RVA: 0x00A278C4 File Offset: 0x00A25AC4
			internal static bool YMw54x5hJ5Im0PQyQpBu()
			{
				return false;
			}

			// Token: 0x04005C88 RID: 23688
			internal int $i$34181;

			// Token: 0x04005C89 RID: 23689
			internal int $hitLayer$34182;

			// Token: 0x04005C8A RID: 23690
			internal UnityScript.Lang.Array $hitList$34183;

			// Token: 0x04005C8B RID: 23691
			internal GameObject $hitObject$34184;

			// Token: 0x04005C8C RID: 23692
			internal Vector3 $hitPos$34185;

			// Token: 0x04005C8D RID: 23693
			internal IEnumerator $$iterator$10890$34186;

			// Token: 0x04005C8E RID: 23694
			internal Vector3 $mPos$34187;

			// Token: 0x04005C8F RID: 23695
			internal Vector3 $tDir$34188;

			// Token: 0x04005C90 RID: 23696
			internal CrabBugMount $self_$34189;
		}
	}

	// Token: 0x02000E5F RID: 3679
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_cAttack$34193 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005351 RID: 21329 RVA: 0x00A278C8 File Offset: 0x00A25AC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_cAttack$34193(Vector3 mPos, Vector3 tDir, CrabBugMount self_)
		{
			if (138750 - 441312 != -302561)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (234380 - 328840 != -94459)
				{
					base..ctor();
					if (251279 - 52721 != 198559)
					{
						this.$mPos$34203 = mPos;
						if (219816 - 25217 == 194599)
						{
							this.$tDir$34204 = tDir;
							if (104249 - 291308 == -187059)
							{
								this.$self_$34205 = self_;
								if (174189 - 225427 != -51237)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06005352 RID: 21330 RVA: 0x00A279A4 File Offset: 0x00A25BA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new CrabBugMount.$RPC_cAttack$34193.$(this.$mPos$34203, this.$tDir$34204, this.$self_$34205);
		}

		// Token: 0x06005353 RID: 21331 RVA: 0x00A279C0 File Offset: 0x00A25BC0
		internal static bool BU08BZ5hDrwDufGdCetm()
		{
			return true;
		}

		// Token: 0x06005354 RID: 21332 RVA: 0x00A279C4 File Offset: 0x00A25BC4
		internal static bool v9mENu5hvoncrSmAricU()
		{
			return false;
		}

		// Token: 0x04005C91 RID: 23697
		internal Vector3 $mPos$34203;

		// Token: 0x04005C92 RID: 23698
		internal Vector3 $tDir$34204;

		// Token: 0x04005C93 RID: 23699
		internal CrabBugMount $self_$34205;

		// Token: 0x02000E60 RID: 3680
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005355 RID: 21333 RVA: 0x00A279C8 File Offset: 0x00A25BC8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, CrabBugMount self_)
			{
				if (72018 - 433238 != -361220)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (175586 - 32319 == 143267)
					{
						base..ctor();
						if (171553 - 399782 != -228228)
						{
							this.$mPos$34200 = mPos;
							if (213636 - 14728 == 198908)
							{
								this.$tDir$34201 = tDir;
								if (239413 - 52438 != 186976)
								{
									this.$self_$34202 = self_;
									if (78088 - 550481 != -472392)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06005356 RID: 21334 RVA: 0x00A27AA4 File Offset: 0x00A25CA4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (246376 - 305624 != -59248)
				{
				}
				for (;;)
				{
					IL_258:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_AE4;
					case 2:
						if (this.$self_$34202.mChar.actionState != "attack")
						{
							goto IL_510;
						}
						if (246131 - 151677 != 94454)
						{
							continue;
						}
						if (this.$self_$34202.mChar.myCommand != "cAttack")
						{
							if (264989 - 264961 != 29)
							{
								goto Block_64;
							}
							continue;
						}
						else
						{
							this.$self_$34202.mChar.moveSpeed = (float)9;
							if (81191 - 206363 != -125172)
							{
								continue;
							}
							goto IL_6A9;
						}
						break;
					case 3:
						if (this.$self_$34202.mChar.actionState != "attack")
						{
							goto IL_295;
						}
						if (294142 - 586932 == -292789)
						{
							continue;
						}
						if (this.$self_$34202.mChar.myCommand != "cAttack")
						{
							if (132463 - 319595 != -187132)
							{
								continue;
							}
							goto IL_295;
						}
						else
						{
							this.$i$34194 = 0;
							if (33388 - 87369 != -53980)
							{
								goto IL_9AC;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$34202.mChar.actionState != "attack")
						{
							goto IL_9D2;
						}
						if (217004 - 396188 == -179183)
						{
							continue;
						}
						if (this.$self_$34202.mChar.myCommand != "cAttack")
						{
							if (180869 - 172645 != 8225)
							{
								goto Block_37;
							}
							continue;
						}
						else
						{
							this.$i$34194++;
							if (290506 - 491945 != -201439)
							{
								continue;
							}
							goto IL_9AC;
						}
						break;
					case 5:
						if (this.$self_$34202.mChar.actionState == "attack")
						{
							if (92361 - 177479 == -85117)
							{
								continue;
							}
							if (this.$self_$34202.mChar.myCommand == "cAttack")
							{
								if (210866 - 281566 == -70699)
								{
									continue;
								}
								this.$self_$34202.mChar.actionState = "standby";
								if (57532 - 752 != 56780)
								{
									continue;
								}
								this.$self_$34202.mChar.actionTime = Time.time;
								if (17656 - 595991 == -578334)
								{
									continue;
								}
								this.$self_$34202.mChar.myCommand = "none";
								if (98493 - 495371 == -396877)
								{
									continue;
								}
								if (!this.$self_$34202.mChar.isMine)
								{
									if (168731 - 438365 == -269633)
									{
										continue;
									}
									this.$self_$34202.mChar.nPosition = this.$self_$34202.transform.position;
									if (71388 - 256014 != -184626)
									{
										continue;
									}
									this.$self_$34202.mChar.oPosition = this.$self_$34202.transform.position;
									if (128534 - 21406 != 107128)
									{
										continue;
									}
									this.$self_$34202.mChar.nDirection = this.$self_$34202.transform.forward;
									if (36692 - 12785 != 23907)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (234688 - 401090 != -166401)
						{
							goto Block_54;
						}
						continue;
					default:
						if (98448 - 251706 != -153258)
						{
							continue;
						}
						break;
					}
					this.$self_$34202.mChar.actionState = "attack";
					if (279571 - 393841 != -114270)
					{
						continue;
					}
					this.$self_$34202.mChar.actionTime = Time.time;
					if (216805 - 520633 != -303828)
					{
						continue;
					}
					this.$self_$34202.mChar.myCommand = "cAttack";
					if (248958 - 233788 == 15171)
					{
						continue;
					}
					this.$self_$34202.mChar.addTimeOut("cAttack", this.$self_$34202.mChar.agiAdjust((float)5));
					if (18949 - 173051 != -154102)
					{
						continue;
					}
					this.$self_$34202.transform.position = this.$mPos$34200;
					if (116753 - 107976 != 8777)
					{
						continue;
					}
					this.$self_$34202.transform.LookAt(this.$mPos$34200 + global::Math.vFlat(this.$tDir$34201));
					if (131864 - 64540 != 67324)
					{
						continue;
					}
					this.$self_$34202.animation.CrossFade("cAttack", 0.2f);
					if (33145 - 218930 != -185785)
					{
						continue;
					}
					this.$self_$34202.animation.wrapMode = WrapMode.Once;
					if (282933 - 397983 == -115049)
					{
						continue;
					}
					this.$self_$34202.mChar.vMovement = this.$self_$34202.transform.forward;
					if (273750 - 240787 != 32963)
					{
						continue;
					}
					this.$self_$34202.mChar.moveSpeed = (float)0;
					if (298027 - 510253 != -212226)
					{
						continue;
					}
					if (this.$self_$34202.cAttack_ring)
					{
						if (180804 - 554218 == -373413)
						{
							continue;
						}
						this.$self_$34202.mChar.createEffect(this.$self_$34202.cAttack_ring, this.$self_$34202.transform.position, Quaternion.identity);
						if (170791 - 150177 != 20614)
						{
							continue;
						}
						goto IL_925;
					}
					else
					{
						Debug.LogError("Missing cAttack_ring effect");
						if (1548 - 226227 != -224678)
						{
							goto Block_56;
						}
						continue;
					}
					IL_9AC:
					if (this.$i$34194 >= 3)
					{
						if (165214 - 173993 == -8779)
						{
							this.$self_$34202.mChar.vMovement = this.$self_$34202.transform.forward;
							if (124700 - 136354 == -11654)
							{
								this.$self_$34202.mChar.moveSpeed = (float)0;
								if (135859 - 189069 == -53210)
								{
									goto IL_4C1;
								}
							}
						}
					}
					else
					{
						if (!this.$self_$34202.mChar.isMine)
						{
							goto IL_3A0;
						}
						if (255287 - 101226 != 154062)
						{
							this.$hitLayer$34195 = 130816 - (1 << this.$self_$34202.gameObject.layer);
							if (59265 - 96704 != -37438)
							{
								this.$hitList$34196 = Damage.FindRecTarget(this.$self_$34202.transform.position - this.$self_$34202.transform.forward, this.$self_$34202.transform.forward, (float)2 * this.$self_$34202.mChar.rangeMod, (float)2 * this.$self_$34202.mChar.rangeMod, (float)4 * this.$self_$34202.mChar.rangeMod, (float)3 * this.$self_$34202.mChar.rangeMod, this.$hitLayer$34195);
								if (254034 - 294118 == -40084)
								{
									this.$$iterator$10891$34199 = UnityRuntimeServices.GetEnumerator(this.$hitList$34196);
									if (299535 - 42307 != 257229)
									{
										while (this.$$iterator$10891$34199.MoveNext())
										{
											object obj2;
											object obj = obj2 = this.$$iterator$10891$34199.Current;
											if (!(obj is GameObject))
											{
												obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
											}
											this.$hitObject$34197 = (GameObject)obj2;
											if (22061 - 133423 != -111362)
											{
												goto IL_258;
											}
											if (this.$self_$34202.mChar.hit(11, this.$hitObject$34197, (int)(0.75f * (float)this.$self_$34202.mChar.atk + (float)this.$self_$34202.mOwnerChar.talAdjust(30)), 1, 0, this.$self_$34202.transform.forward) != 0)
											{
												if (75055 - 472196 == -397140)
												{
													goto IL_258;
												}
												this.$hitPos$34198 = this.$hitObject$34197.collider.ClosestPointOnBounds(this.$self_$34202.transform.position + (float)2 * Vector3.up);
												if (173547 - 426550 != -253003)
												{
													goto IL_258;
												}
												UnityRuntimeServices.Update(this.$$iterator$10891$34199, this.$hitObject$34197);
												if (237032 - 371858 != -134826)
												{
													goto IL_258;
												}
												this.$self_$34202.RPC_cAttack_hit(this.$hitPos$34198, this.$self_$34202.transform.forward, 0);
												if (86945 - 388135 != -301190)
												{
													goto IL_258;
												}
												this.$self_$34202.ActionEvent("RPC_cAttack_hit", this.$hitPos$34198, this.$self_$34202.transform.forward, 0);
												if (143553 - 440513 == -296959)
												{
													goto IL_258;
												}
											}
										}
										if (159022 - 2508 == 156514)
										{
											goto IL_3A0;
										}
									}
								}
							}
						}
					}
				}
				IL_295:
				goto IL_AE4;
				IL_3A0:
				return this.Yield(4, new WaitForSeconds(0.1f));
				IL_4C1:
				return this.Yield(5, new WaitForSeconds(0.3f));
				IL_510:
				goto IL_AE4;
				IL_5A7:
				return this.Yield(2, new WaitForSeconds(0.2f));
				Block_37:
				goto IL_9D2;
				IL_6A9:
				return this.Yield(3, new WaitForSeconds(0.4f));
				Block_54:
				goto IL_AE4;
				IL_925:
				Block_56:
				goto IL_5A7;
				IL_9D2:
				Block_64:
				IL_AE4:
				return false;
			}

			// Token: 0x06005357 RID: 21335 RVA: 0x00A285A8 File Offset: 0x00A267A8
			internal static bool eAQvc25hROrNGZkVdvTQ()
			{
				return true;
			}

			// Token: 0x06005358 RID: 21336 RVA: 0x00A285AC File Offset: 0x00A267AC
			internal static bool JtTTtc5hw9ciyvsXCVKG()
			{
				return false;
			}

			// Token: 0x04005C94 RID: 23700
			internal int $i$34194;

			// Token: 0x04005C95 RID: 23701
			internal int $hitLayer$34195;

			// Token: 0x04005C96 RID: 23702
			internal UnityScript.Lang.Array $hitList$34196;

			// Token: 0x04005C97 RID: 23703
			internal GameObject $hitObject$34197;

			// Token: 0x04005C98 RID: 23704
			internal Vector3 $hitPos$34198;

			// Token: 0x04005C99 RID: 23705
			internal IEnumerator $$iterator$10891$34199;

			// Token: 0x04005C9A RID: 23706
			internal Vector3 $mPos$34200;

			// Token: 0x04005C9B RID: 23707
			internal Vector3 $tDir$34201;

			// Token: 0x04005C9C RID: 23708
			internal CrabBugMount $self_$34202;
		}
	}
}
