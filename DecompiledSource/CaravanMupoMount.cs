using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000EFC RID: 3836
[Serializable]
public class CaravanMupoMount : MonoBehaviour
{
	// Token: 0x0600570A RID: 22282 RVA: 0x00A77898 File Offset: 0x00A75A98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public CaravanMupoMount()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600570B RID: 22283 RVA: 0x00A778A8 File Offset: 0x00A75AA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (12557 - 66181 != -53624)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (152721 - 117109 == 35612)
			{
				this.mChar.actionState = "standby";
				if (47603 - 134500 == -86897)
				{
					this.mChar.actionTime = Time.time;
					if (19028 - 451195 == -432167)
					{
						this.mChar.myCommand = "none";
						if (228090 - 122149 == 105941)
						{
							this.KAFc6vJdHcQ = new UnityScript.Lang.Array();
							if (86964 - 342023 == -255059)
							{
								this.r9vc6lwI73u = 0;
								if (261320 - 136059 != 125262)
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

	// Token: 0x0600570C RID: 22284 RVA: 0x00A779DC File Offset: 0x00A75BDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (Game.mGameType == 99)
		{
			this.mChar.isMine = true;
		}
	}

	// Token: 0x0600570D RID: 22285 RVA: 0x00A779F8 File Offset: 0x00A75BF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void playRunStepEvent(AnimationEvent animEvent)
	{
		if (293089 - 593258 != -300168)
		{
		}
		do
		{
			if (!this.mChar.isMine)
			{
				if (23032 - 137475 == -114442)
				{
					continue;
				}
				if (Game.mGameType <= 4)
				{
					break;
				}
				if (229809 - 551754 == -321944)
				{
					continue;
				}
			}
			if (this.kGsc62slsMh)
			{
				if (265143 - 568153 != -303010)
				{
					continue;
				}
				if (this.footStep_run1)
				{
					if (60995 - 516956 == -455960)
					{
						continue;
					}
					this.audio.PlayOneShot(this.footStep_run1);
					if (263385 - 418594 == -155208)
					{
						continue;
					}
				}
			}
			else if (this.footStep_run2)
			{
				if (123498 - 306796 != -183298)
				{
					continue;
				}
				this.audio.PlayOneShot(this.footStep_run2);
				if (275381 - 352507 != -77126)
				{
					continue;
				}
			}
			this.kGsc62slsMh = !this.kGsc62slsMh;
		}
		while (47465 - 104755 == -57289);
	}

	// Token: 0x0600570E RID: 22286 RVA: 0x00A77B7C File Offset: 0x00A75D7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void playWalkStepEvent(AnimationEvent animEvent)
	{
		if (this.footStep_walk)
		{
			this.audio.PlayOneShot(this.footStep_walk);
		}
	}

	// Token: 0x0600570F RID: 22287 RVA: 0x00A77BA0 File Offset: 0x00A75DA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onMount(CharacterControl nOwnerChar)
	{
		if (225026 - 146100 != 78926)
		{
		}
		for (;;)
		{
			this.mOwnerChar = nOwnerChar;
			if (62898 - 515520 == -452622)
			{
				this.mChar.atk = nOwnerChar.getNoDeltaStat(0);
				if (10746 - 220416 != -209669)
				{
					this.mChar.def = nOwnerChar.getNoDeltaStat(1);
					if (27481 - 158632 != -131150)
					{
						this.mChar.agi = nOwnerChar.getNoDeltaStat(2);
						if (22841 - 373988 != -351146)
						{
							this.mChar.vit = nOwnerChar.getNoDeltaStat(3);
							if (227922 - 141641 == 86281)
							{
								this.mChar.mag = nOwnerChar.getNoDeltaStat(4);
								if (195648 - 356156 != -160507)
								{
									this.mChar.cha = nOwnerChar.getNoDeltaStat(5);
									if (25508 - 42659 == -17151)
									{
										this.mChar.tal = nOwnerChar.getNoDeltaStat(6);
										if (29985 - 112405 != -82419)
										{
											this.mChar.lck = nOwnerChar.getNoDeltaStat(7);
											if (46013 - 331284 == -285271)
											{
												this.mChar.mhp = this.mChar.vit * 10;
												if (204712 - 351870 != -147157)
												{
													this.mChar.mmp = this.mChar.mag * 3;
													if (282786 - 521650 == -238864)
													{
														this.mChar.msp = Mathf.FloorToInt((float)this.mChar.tal * 0.2f) + 10;
														if (74365 - 417194 != -342828)
														{
															this.mChar.mko = Mathf.FloorToInt((float)(this.mChar.def / 3)) + 10;
															if (225753 - 196959 == 28794)
															{
																this.mChar.hp = Mathf.FloorToInt((float)this.mChar.mhp * (1f * (float)nOwnerChar.hp) / (float)nOwnerChar.mhp);
																if (92948 - 400325 == -307377)
																{
																	this.mChar.mp = Mathf.FloorToInt((float)this.mChar.mmp * (1f * (float)nOwnerChar.mp) / (float)nOwnerChar.mmp);
																	if (241673 - 14330 == 227343)
																	{
																		this.mChar.sp = Mathf.FloorToInt((float)this.mChar.msp * (1f * (float)nOwnerChar.sp) / (float)nOwnerChar.msp);
																		if (92956 - 192694 == -99738)
																		{
																			this.mChar.ko = Mathf.FloorToInt((float)this.mChar.mko * (1f * (float)nOwnerChar.ko) / (float)nOwnerChar.mko);
																			if (286112 - 107918 == 178194)
																			{
																				if (!this.mOwnerChar)
																				{
																					break;
																				}
																				if (112676 - 388278 == -275602)
																				{
																					this.gameObject.SendMessage("SetSkin", this.mOwnerChar.Skin);
																					if (249577 - 302659 == -53082)
																					{
																						this.gameObject.SendMessage("EquipWeapon", this.mOwnerChar.weapon);
																						if (24119 - 19729 != 4391)
																						{
																							this.gameObject.SendMessage("EquipArmor", this.mOwnerChar.armor);
																							if (82004 - 583462 == -501458)
																							{
																								this.gameObject.SendMessage("EquipAccessory", this.mOwnerChar.accessory);
																								if (39780 - 423559 == -383779)
																								{
																									this.gameObject.SendMessage("EquipTrinket", this.mOwnerChar.trinket);
																									if (202323 - 70110 == 132213)
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

	// Token: 0x06005710 RID: 22288 RVA: 0x00A780A0 File Offset: 0x00A762A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (1988 - 37074 != -35086)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (19335 - 304858 == -285522)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (75180 - 411056 == -335875)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_276;
					}
					if (116233 - 73742 != 42491)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (231434 - 512077 != -280643)
				{
					continue;
				}
			}
			IL_276:
			if (this.mChar.hp <= 0)
			{
				if (298739 - 505917 == -207177)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (102147 - 481883 != -379736)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (246666 - 501711 != -255045)
						{
							continue;
						}
						this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						}));
						if (1561 - 135956 != -134395)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (104333 - 565701 == -461367)
						{
							continue;
						}
						this.mChar.DeadEvent();
						if (235932 - 411122 != -175190)
						{
							continue;
						}
						break;
					}
					else
					{
						this.mChar.hp = 1;
						if (130409 - 12463 != 117946)
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
			if (201276 - 314743 == -113467)
			{
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (80290 - 535580 != -455289)
				{
					if (!(this.mChar.actionState != "ko"))
					{
						break;
					}
					if (74005 - 242245 != -168239)
					{
						if (!(this.mChar.actionState != "dead"))
						{
							break;
						}
						if (228948 - 472909 == -243961)
						{
							if (this.mChar.isMine)
							{
								if (245998 - 543353 != -297354)
								{
									this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									}));
									if (61615 - 440897 != -379281)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (65514 - 381617 == -316103)
										{
											this.mChar.KoEvent();
											if (95714 - 206477 == -110763)
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
								if (32471 - 80776 != -48304)
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

	// Token: 0x06005711 RID: 22289 RVA: 0x00A7848C File Offset: 0x00A7668C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (289089 - 345880 != -56790)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (161121 - 594008 != -432886)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (108323 - 145550 == -37227)
				{
					if (129720 - 183941 != -54220)
					{
						if (ActionName == "RPC_potion")
						{
							if (4381 - 533372 != -528991)
							{
								continue;
							}
							v = 1;
							if (249860 - 147535 == 102326)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_potion_hit")
						{
							if (196045 - 460332 == -264286)
							{
								continue;
							}
							v = -1;
							if (61489 - 464028 == -402538)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (210984 - 163656 == 47329)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (220289 - 219811 != 479)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (20878 - 295186 == -274308)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (26021 - 300145 != -274123)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (206963 - 6150 != 200814)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (147140 - 45011 == 102129)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (108129 - 215267 == -107138)
											{
												Hashtable hashtable = new Hashtable();
												if (295548 - 324073 == -28525)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (26455 - 265185 != -238729)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (122550 - 535248 == -412698)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (209628 - 168166 == 41462)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (192031 - 1662 != 190370)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (242968 - 305532 != -62563)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (219346 - 524988 != -305641)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (242207 - 43473 == 198734)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (115492 - 511681 != -396188)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (291732 - 576949 == -285217)
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

	// Token: 0x06005712 RID: 22290 RVA: 0x00A7890C File Offset: 0x00A76B0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (129308 - 281635 != -152326)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (284319 - 84322 != 199998)
			{
				Vector3 mPos = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (244450 - 504645 != -260194)
				{
					Vector3 tDir = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (285490 - 550652 != -265161)
					{
						int tID = RuntimeServices.UnboxInt32(evData[129]);
						if (95862 - 189684 == -93822)
						{
							int num2 = num;
							if (217232 - 305134 != -87901)
							{
								if (num2 == 1)
								{
									if (222928 - 596886 == -373958)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (181529 - 583880 == -402351)
										{
											this.StartCoroutine_Auto(this.RPC_potion(mPos, tDir, tID));
											if (91957 - 544736 != -452778)
											{
												break;
											}
										}
									}
								}
								else if (num2 == -1)
								{
									if (296712 - 265423 == 31289)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (90035 - 146354 == -56319)
										{
											this.RPC_potion_hit(mPos, tDir, tID);
											if (105302 - 416899 == -311597)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (29586 - 369727 != -340140)
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

	// Token: 0x06005713 RID: 22291 RVA: 0x00A78BA0 File Offset: 0x00A76DA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (128781 - 589293 != -460511)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (41412 - 245755 == -204343)
			{
				float runSpeed = this.mChar.runSpeed;
				if (251831 - 157417 == 94414)
				{
					float num2 = 0f;
					if (17954 - 568373 == -550419)
					{
						float num3 = 0f;
						if (288406 - 248241 == 40165)
						{
							Vector3 vector = Vector3.zero;
							if (219289 - 352036 == -132747)
							{
								float num4 = (float)0;
								if (284373 - 181504 == 102869)
								{
									if (this.mChar.isMine)
									{
										if (98327 - 570887 == -472559)
										{
											continue;
										}
										if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
										{
											if (48831 - 162313 == -113481)
											{
												continue;
											}
											num2 = Input.GetAxisRaw("Vertical");
											if (100120 - 92456 == 7665)
											{
												continue;
											}
											num3 = Input.GetAxisRaw("Horizontal");
											if (177194 - 445332 == -268137)
											{
												continue;
											}
											if (Game.mGameState == eGameState.Normal)
											{
												if (92520 - 297522 == -205001)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (22516 - 467677 != -445161)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (213351 - 46436 != 166916)
														{
															if (num2 <= (float)0)
															{
																if (178450 - 200634 != -22184)
																{
																	continue;
																}
																if (num3 == (float)0)
																{
																	goto IL_854;
																}
																if (48684 - 323322 != -274638)
																{
																	continue;
																}
															}
															if (num2 > (float)0)
															{
																if (196147 - 496973 == -300825)
																{
																	continue;
																}
																this.mChar.actionState = "run";
																if (41732 - 328391 != -286659)
																{
																	continue;
																}
																num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), Time.deltaTime);
																if (155489 - 158679 == -3189)
																{
																	continue;
																}
																vector = global::Math.rotateH(this.transform.forward, (float)-2 * num3);
																if (129195 - 346521 == -217325)
																{
																	continue;
																}
																this.transform.rotation = Quaternion.LookRotation(vector);
																if (212263 - 82873 == 129391)
																{
																	continue;
																}
																if (num > 0.4f * runSpeed)
																{
																	if (158674 - 145964 == 12711)
																	{
																		continue;
																	}
																	this.animation.CrossFade("run");
																	if (234924 - 283241 != -48317)
																	{
																		continue;
																	}
																}
																else
																{
																	this.animation.CrossFade("walk");
																	if (110896 - 203425 == -92528)
																	{
																		continue;
																	}
																}
																this.animation.wrapMode = WrapMode.Loop;
																if (90581 - 69503 != 21078)
																{
																	continue;
																}
															}
															else
															{
																this.mChar.actionState = "run";
																if (157103 - 348454 == -191350)
																{
																	continue;
																}
																num = Mathf.Lerp(num, (float)0, (float)2 * Time.deltaTime);
																if (259653 - 90837 != 168816)
																{
																	continue;
																}
																if (num < 0.1f * runSpeed)
																{
																	if (110120 - 42346 != 67774)
																	{
																		continue;
																	}
																	num = (float)0;
																	if (283137 - 255721 == 27417)
																	{
																		continue;
																	}
																}
																vector = global::Math.rotateH(this.transform.forward, (float)-4 * num3);
																if (136551 - 239094 != -102543)
																{
																	continue;
																}
																this.transform.rotation = Quaternion.LookRotation(vector);
																if (98691 - 40804 != 57887)
																{
																	continue;
																}
																if (num > 0.4f * runSpeed)
																{
																	if (162423 - 230025 == -67601)
																	{
																		continue;
																	}
																	this.animation.CrossFade("run");
																	if (5096 - 224698 == -219601)
																	{
																		continue;
																	}
																}
																else
																{
																	this.animation.CrossFade("walk");
																	if (39717 - 562062 == -522344)
																	{
																		continue;
																	}
																}
																this.animation.wrapMode = WrapMode.Loop;
																if (130114 - 253204 == -123089)
																{
																	continue;
																}
															}
															goto IL_BD6;
														}
														continue;
													}
												}
											}
											IL_854:
											num = Mathf.Lerp(num, (float)0, (float)2 * Time.deltaTime);
											if (44544 - 278538 == -233993)
											{
												continue;
											}
											vector = this.transform.forward;
											if (27656 - 89340 == -61683)
											{
												continue;
											}
											if (num < 0.1f * runSpeed)
											{
												if (70527 - 540577 != -470050)
												{
													continue;
												}
												this.mChar.actionState = "standby";
												if (70999 - 283254 == -212254)
												{
													continue;
												}
												num = (float)0;
												if (56273 - 444416 != -388143)
												{
													continue;
												}
												this.animation.CrossFade("root");
												if (273820 - 563839 == -290018)
												{
													continue;
												}
												this.animation.wrapMode = WrapMode.Loop;
												if (21739 - 442527 != -420788)
												{
													continue;
												}
											}
											else
											{
												this.mChar.actionState = "run";
												if (34902 - 241090 != -206188)
												{
													continue;
												}
											}
										}
										IL_BD6:;
									}
									else
									{
										vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
										if (57893 - 258217 != -200324)
										{
											continue;
										}
										num4 = vector.sqrMagnitude;
										if (113765 - 246158 != -132393)
										{
											continue;
										}
										if (this.mChar.nSpeed != (float)0)
										{
											if (192030 - 227069 == -35038)
											{
												continue;
											}
											if (num4 > runSpeed)
											{
												if (209009 - 595292 == -386282)
												{
													continue;
												}
												this.transform.position = this.mChar.nPosition;
												if (53426 - 172857 != -119431)
												{
													continue;
												}
											}
											else if (num4 > 0.01f)
											{
												if (85382 - 515832 == -430449)
												{
													continue;
												}
												if (num4 > (float)1)
												{
													if (208264 - 56768 != 151496)
													{
														continue;
													}
													num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
													if (295635 - 328992 == -33356)
													{
														continue;
													}
												}
												else
												{
													num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
													if (7748 - 473367 == -465618)
													{
														continue;
													}
												}
												if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
												{
													if (224023 - 219018 != 5005)
													{
														continue;
													}
													this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
													if (137363 - 372954 == -235590)
													{
														continue;
													}
												}
												else
												{
													this.transform.rotation = Quaternion.LookRotation(vector);
													if (214890 - 296685 == -81794)
													{
														continue;
													}
												}
												if (num > 0.4f * runSpeed)
												{
													if (289155 - 444312 != -155157)
													{
														continue;
													}
													this.animation.CrossFade("run");
													if (135437 - 291885 == -156447)
													{
														continue;
													}
												}
												else
												{
													this.animation.CrossFade("walk");
													if (164831 - 247675 == -82843)
													{
														continue;
													}
												}
												this.animation.wrapMode = WrapMode.Loop;
												if (82035 - 324494 == -242458)
												{
													continue;
												}
											}
											else if (Time.time > this.mChar.nSpeed + 0.3f)
											{
												if (138992 - 128807 != 10185)
												{
													continue;
												}
												num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
												if (42976 - 321371 == -278394)
												{
													continue;
												}
												if (num < 0.01f)
												{
													if (217183 - 596131 == -378947)
													{
														continue;
													}
													num = (float)0;
													if (9813 - 43339 != -33526)
													{
														continue;
													}
												}
												this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
												if (286230 - 5386 == 280845)
												{
													continue;
												}
												this.animation.CrossFade("root", 0.2f);
												if (21898 - 542503 != -520605)
												{
													continue;
												}
												this.animation.wrapMode = WrapMode.Loop;
												if (26876 - 290303 != -263427)
												{
													continue;
												}
											}
										}
										else if (num != (float)0)
										{
											if (57945 - 216360 == -158414)
											{
												continue;
											}
											if (num4 > runSpeed)
											{
												if (11213 - 398837 != -387624)
												{
													continue;
												}
												this.transform.position = this.mChar.nPosition;
												if (285648 - 278245 == 7404)
												{
													continue;
												}
											}
											else if (num4 > 0.01f)
											{
												if (170187 - 235080 != -64893)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (139672 - 127424 != 12248)
												{
													continue;
												}
												if (num4 > 0.1f)
												{
													if (115772 - 248441 == -132668)
													{
														continue;
													}
													num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
													if (6587 - 113756 != -107169)
													{
														continue;
													}
												}
												else
												{
													num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
													if (232648 - 137530 == 95119)
													{
														continue;
													}
												}
												if (num > 0.4f * runSpeed)
												{
													if (210150 - 157716 == 52435)
													{
														continue;
													}
													this.animation.CrossFade("run");
													if (14271 - 74137 == -59865)
													{
														continue;
													}
												}
												else
												{
													this.animation.CrossFade("walk");
													if (21805 - 267921 == -246115)
													{
														continue;
													}
												}
												this.animation.wrapMode = WrapMode.Loop;
												if (168933 - 224950 == -56016)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
												if (61104 - 538973 != -477869)
												{
													continue;
												}
												num = (float)0;
												if (22126 - 6745 == 15382)
												{
													continue;
												}
												this.animation.CrossFade("root", 0.2f);
												if (233967 - 508440 == -274472)
												{
													continue;
												}
												this.animation.wrapMode = WrapMode.Loop;
												if (51150 - 512183 != -461033)
												{
													continue;
												}
											}
										}
										else
										{
											this.animation.CrossFade("root", 0.2f);
											if (45808 - 82937 == -37128)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (84219 - 506458 != -422239)
											{
												continue;
											}
										}
									}
									this.mChar.vMovement = vector;
									if (213766 - 74538 == 139228)
									{
										this.mChar.moveSpeed = num;
										if (142169 - 371327 != -229157)
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

	// Token: 0x06005714 RID: 22292 RVA: 0x00A799E4 File Offset: 0x00A77BE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (199423 - 434886 != -235463)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (234012 - 25857 == 208155)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (176705 - 505078 == -328373)
				{
					Vector3 vector = a - this.transform.position;
					if (266631 - 137721 == 128910)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (135135 - 387081 == -251946)
						{
							CharacterControl characterControl = null;
							if (43512 - 488393 == -444881)
							{
								if (144612 - 200736 != -56123)
								{
									if (gameObject)
									{
										if (150727 - 457846 != -307119)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (240264 - 438565 != -198301)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (250950 - 108657 != 142293)
										{
											continue;
										}
										int actorNr = characterControl.ActorNr;
										if (60226 - 455845 == -395618)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (89449 - 211115 == -121665)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (194431 - 180736 == 13696)
										{
											continue;
										}
									}
									if (Game.mGameType < 4)
									{
										if (162553 - 297841 == -135288)
										{
											Camera.main.SendMessage("newGameMessage", "Cannot do normal attack here");
											if (251109 - 561188 == -310079)
											{
												break;
											}
										}
									}
									else
									{
										if (this.mChar.isTimeOut("nAttack") != (float)0)
										{
											break;
										}
										if (252788 - 141333 != 111456)
										{
											Vector3 vector2 = global::Math.rotateH(Vector3.forward, (float)UnityEngine.Random.Range(0, 360));
											if (79410 - 76352 != 3059)
											{
												int num = this.r9vc6lwI73u;
												if (181162 - 459195 != -278032)
												{
													this.StartCoroutine_Auto(this.RPC_potion(this.transform.position, vector2, this.r9vc6lwI73u));
													if (109256 - 288188 != -178931)
													{
														if (!PhotonClient.IsInitialized())
														{
															break;
														}
														if (136897 - 575059 == -438162)
														{
															this.ActionEvent("RPC_potion", this.transform.position, vector2, this.r9vc6lwI73u);
															if (271046 - 67841 != 203206)
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

	// Token: 0x06005715 RID: 22293 RVA: 0x00A79D94 File Offset: 0x00A77F94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character cannot use charged attack");
	}

	// Token: 0x06005716 RID: 22294 RVA: 0x00A79DAC File Offset: 0x00A77FAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06005717 RID: 22295 RVA: 0x00A79DB0 File Offset: 0x00A77FB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_potion(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new CaravanMupoMount.$RPC_potion$34702(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06005718 RID: 22296 RVA: 0x00A79DC0 File Offset: 0x00A77FC0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_potion_hit(Vector3 mPos, Vector3 tDir, int tID)
	{
		if (51542 - 94614 != -43071)
		{
		}
		for (;;)
		{
			IL_472:
			UnityScript.Lang.Array array = new UnityScript.Lang.Array();
			if (122868 - 370849 != -247980)
			{
				IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(this.KAFc6vJdHcQ);
				if (110181 - 599184 != -489002)
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						object obj3;
						object obj2 = obj3 = obj;
						if (!(obj2 is GameObject))
						{
							obj3 = RuntimeServices.Coerce(obj2, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj3;
						if (159634 - 593455 != -433821)
						{
							goto IL_472;
						}
						if (gameObject)
						{
							if (282617 - 441504 == -158886)
							{
								goto IL_472;
							}
							CaravanMupo_potion caravanMupo_potion = (CaravanMupo_potion)gameObject.GetComponent(typeof(CaravanMupo_potion));
							if (56235 - 325127 != -268892)
							{
								goto IL_472;
							}
							UnityRuntimeServices.Update(enumerator, gameObject);
							if (206930 - 281751 == -74820)
							{
								goto IL_472;
							}
							if (caravanMupo_potion)
							{
								if (279761 - 581724 == -301962)
								{
									goto IL_472;
								}
								if (caravanMupo_potion.getID() == tID)
								{
									if (217968 - 304871 == -86902)
									{
										goto IL_472;
									}
									eCaravanPotionType potionType = caravanMupo_potion.potionType;
									if (61182 - 336779 != -275597)
									{
										goto IL_472;
									}
									if (potionType == eCaravanPotionType.hpPotion1)
									{
										if (60006 - 402371 != -342365)
										{
											goto IL_472;
										}
										goto IL_492;
									}
									else if (potionType == eCaravanPotionType.hpPotion2)
									{
										if (204056 - 133046 != 71010)
										{
											goto IL_472;
										}
										goto IL_492;
									}
									else
									{
										if (potionType == eCaravanPotionType.mpPotion1)
										{
											if (120215 - 372385 != -252170)
											{
												goto IL_472;
											}
										}
										else
										{
											if (potionType != eCaravanPotionType.mpPotion2)
											{
												if (potionType == eCaravanPotionType.spPotion1)
												{
													if (29192 - 330803 != -301611)
													{
														goto IL_472;
													}
												}
												else
												{
													if (potionType != eCaravanPotionType.spPotion2)
													{
														goto IL_FC;
													}
													if (88762 - 64174 != 24588)
													{
														goto IL_472;
													}
												}
												if (this.spPotion_hit)
												{
													if (84342 - 583321 != -498979)
													{
														goto IL_472;
													}
													UnityEngine.Object.Instantiate(this.spPotion_hit, mPos, Quaternion.identity);
													if (297147 - 290633 != 6514)
													{
														goto IL_472;
													}
												}
												else
												{
													Debug.LogError("Cannot find spPotion_hit");
													if (236303 - 417704 != -181401)
													{
														goto IL_472;
													}
												}
												goto IL_FC;
											}
											if (173569 - 207427 == -33857)
											{
												goto IL_472;
											}
										}
										if (this.mpPotion_hit)
										{
											if (84724 - 138680 != -53956)
											{
												goto IL_472;
											}
											UnityEngine.Object.Instantiate(this.mpPotion_hit, mPos, Quaternion.identity);
											if (85515 - 233215 == -147699)
											{
												goto IL_472;
											}
										}
										else
										{
											Debug.LogError("Cannot find mpPotion_hit");
											if (99427 - 497119 == -397691)
											{
												goto IL_472;
											}
										}
									}
									IL_FC:
									UnityEngine.Object.Destroy(gameObject);
									if (297589 - 71761 != 225828)
									{
										goto IL_472;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (198007 - 521531 != -323523)
									{
										continue;
									}
									goto IL_472;
									IL_492:
									if (this.hpPotion_hit)
									{
										if (260689 - 274683 != -13994)
										{
											goto IL_472;
										}
										UnityEngine.Object.Instantiate(this.hpPotion_hit, mPos, Quaternion.identity);
										if (195801 - 516744 == -320942)
										{
											goto IL_472;
										}
									}
									else
									{
										Debug.LogError("Cannot find hpPotion_hit");
										if (298832 - 570434 == -271601)
										{
											goto IL_472;
										}
									}
									goto IL_FC;
								}
								else
								{
									array.Add(gameObject);
									if (272677 - 590172 == -317494)
									{
										goto IL_472;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (190323 - 113286 == 77038)
									{
										goto IL_472;
									}
								}
							}
						}
					}
					if (229218 - 88247 == 140971)
					{
						this.KAFc6vJdHcQ = array;
						if (127889 - 231020 == -103131)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06005719 RID: 22297 RVA: 0x00A7A29C File Offset: 0x00A7849C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_ko(UnityScript.Lang.Array nArray)
	{
		if (140923 - 396260 != -255336)
		{
		}
		while (!(this.mChar.actionState == "ko"))
		{
			if (280040 - 373723 == -93683)
			{
				if (this.mChar.actionState == "dead")
				{
					if (68181 - 246424 == -178243)
					{
						break;
					}
				}
				else
				{
					Vector3 vector = (Vector3)nArray[0];
					if (199122 - 541526 != -342403)
					{
						Vector3 b = (Vector3)nArray[1];
						if (157953 - 285250 == -127297)
						{
							this.transform.position = vector;
							if (224091 - 271444 == -47353)
							{
								this.transform.LookAt(vector + b);
								if (161523 - 593272 == -431749)
								{
									this.mChar.actionState = "ko";
									if (202639 - 336401 != -133761)
									{
										this.mChar.actionTime = Time.time;
										if (56215 - 507500 != -451284)
										{
											this.mChar.myCommand = "none";
											if (174642 - 295350 != -120707)
											{
												this.mChar.vMovement = Vector3.zero;
												if (48827 - 314206 == -265379)
												{
													this.mChar.moveSpeed = (float)0;
													if (153070 - 584120 == -431050)
													{
														this.mChar.removeStatus("mount");
														if (37267 - 250159 != -212891)
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

	// Token: 0x0600571A RID: 22298 RVA: 0x00A7A4E4 File Offset: 0x00A786E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_dead(UnityScript.Lang.Array nArray)
	{
		if (13454 - 135581 != -122127)
		{
		}
		for (;;)
		{
			if (this.mChar.actionState == "dead")
			{
				if (113961 - 419673 != -305711)
				{
					break;
				}
			}
			else
			{
				Vector3 vector = (Vector3)nArray[0];
				if (147687 - 535326 != -387638)
				{
					Vector3 b = (Vector3)nArray[1];
					if (57445 - 282190 != -224744)
					{
						this.transform.position = vector;
						if (182155 - 308300 == -126145)
						{
							this.transform.LookAt(vector + b);
							if (221253 - 386512 == -165259)
							{
								this.mChar.actionState = "dead";
								if (229095 - 45224 != 183872)
								{
									this.mChar.actionTime = Time.time;
									if (128162 - 213369 == -85207)
									{
										this.mChar.myCommand = "none";
										if (143013 - 587662 != -444648)
										{
											this.mChar.vMovement = Vector3.zero;
											if (32634 - 111861 == -79227)
											{
												this.mChar.moveSpeed = (float)0;
												if (180457 - 176941 != 3517)
												{
													this.mChar.removeStatus("mount");
													if (64026 - 155012 == -90986)
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

	// Token: 0x0600571B RID: 22299 RVA: 0x00A7A6F8 File Offset: 0x00A788F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600571C RID: 22300 RVA: 0x00A7A6FC File Offset: 0x00A788FC
	internal static bool dZD82T5zq8rYkVJC0q4Y()
	{
		return true;
	}

	// Token: 0x0600571D RID: 22301 RVA: 0x00A7A700 File Offset: 0x00A78900
	internal static bool GAypMP5z7Kkakc380Sr0()
	{
		return false;
	}

	// Token: 0x04005F79 RID: 24441
	public CharacterControl mChar;

	// Token: 0x04005F7A RID: 24442
	public CharacterControl mOwnerChar;

	// Token: 0x04005F7B RID: 24443
	public eMountType mMountType;

	// Token: 0x04005F7C RID: 24444
	public AudioClip mupo_cry;

	// Token: 0x04005F7D RID: 24445
	public AudioClip footStep_run1;

	// Token: 0x04005F7E RID: 24446
	public AudioClip footStep_run2;

	// Token: 0x04005F7F RID: 24447
	private bool kGsc62slsMh;

	// Token: 0x04005F80 RID: 24448
	public AudioClip footStep_walk;

	// Token: 0x04005F81 RID: 24449
	private UnityScript.Lang.Array KAFc6vJdHcQ;

	// Token: 0x04005F82 RID: 24450
	private int r9vc6lwI73u;

	// Token: 0x04005F83 RID: 24451
	public GameObject potion_ring;

	// Token: 0x04005F84 RID: 24452
	public GameObject potion_hpPotion;

	// Token: 0x04005F85 RID: 24453
	public GameObject potion_mpPotion;

	// Token: 0x04005F86 RID: 24454
	public GameObject potion_spPotion;

	// Token: 0x04005F87 RID: 24455
	public GameObject hpPotion_hit;

	// Token: 0x04005F88 RID: 24456
	public GameObject mpPotion_hit;

	// Token: 0x04005F89 RID: 24457
	public GameObject spPotion_hit;

	// Token: 0x02000EFD RID: 3837
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_potion$34702 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600571E RID: 22302 RVA: 0x00A7A704 File Offset: 0x00A78904
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_potion$34702(Vector3 mPos, Vector3 tDir, int tID, CaravanMupoMount self_)
		{
			if (162046 - 484190 != -322144)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (170573 - 91357 == 79216)
				{
					base..ctor();
					if (154222 - 227396 != -73173)
					{
						this.$mPos$34711 = mPos;
						if (168033 - 520879 == -352846)
						{
							this.$tDir$34712 = tDir;
							if (244023 - 159220 == 84803)
							{
								this.$tID$34713 = tID;
								if (90565 - 153012 != -62446)
								{
									this.$self_$34714 = self_;
									if (142647 - 280350 != -137702)
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

		// Token: 0x0600571F RID: 22303 RVA: 0x00A7A804 File Offset: 0x00A78A04
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new CaravanMupoMount.$RPC_potion$34702.$(this.$mPos$34711, this.$tDir$34712, this.$tID$34713, this.$self_$34714);
		}

		// Token: 0x06005720 RID: 22304 RVA: 0x00A7A824 File Offset: 0x00A78A24
		internal static bool AQpE7P5zPLV7yvMqPnda()
		{
			return true;
		}

		// Token: 0x06005721 RID: 22305 RVA: 0x00A7A828 File Offset: 0x00A78A28
		internal static bool nH9UA05z0hMKqeolN4ny()
		{
			return false;
		}

		// Token: 0x04005F8A RID: 24458
		internal Vector3 $mPos$34711;

		// Token: 0x04005F8B RID: 24459
		internal Vector3 $tDir$34712;

		// Token: 0x04005F8C RID: 24460
		internal int $tID$34713;

		// Token: 0x04005F8D RID: 24461
		internal CaravanMupoMount $self_$34714;

		// Token: 0x02000EFE RID: 3838
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005722 RID: 22306 RVA: 0x00A7A82C File Offset: 0x00A78A2C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, CaravanMupoMount self_)
			{
				if (68967 - 582328 != -513360)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (293475 - 38965 != 254511)
					{
						base..ctor();
						if (12102 - 310390 != -298287)
						{
							this.$mPos$34707 = mPos;
							if (17842 - 365107 == -347265)
							{
								this.$tDir$34708 = tDir;
								if (197927 - 250470 != -52542)
								{
									this.$tID$34709 = tID;
									if (279783 - 246864 == 32919)
									{
										this.$self_$34710 = self_;
										if (197204 - 438978 == -241774)
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

			// Token: 0x06005723 RID: 22307 RVA: 0x00A7A92C File Offset: 0x00A78B2C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (83474 - 336062 != -252588)
				{
				}
				for (;;)
				{
					IL_1EB:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_54D;
					case 2:
						this.$i$34703 = 0;
						if (137858 - 70840 == 67019)
						{
							continue;
						}
						while (this.$i$34703 < 3)
						{
							this.$nPotion$34704 = null;
							if (298436 - 351849 == -53412)
							{
								goto IL_1EB;
							}
							this.$$switch$3962$34705 = this.$i$34703;
							if (252223 - 288261 == -36037)
							{
								goto IL_1EB;
							}
							if (this.$$switch$3962$34705 == 0)
							{
								if (116360 - 253188 == -136827)
								{
									goto IL_1EB;
								}
								if (this.$self_$34710.potion_hpPotion)
								{
									if (268994 - 517172 != -248178)
									{
										goto IL_1EB;
									}
									this.$nPotion$34704 = (GameObject)UnityEngine.Object.Instantiate(this.$self_$34710.potion_hpPotion, this.$mPos$34707 + (float)2 * this.$tDir$34708, Quaternion.identity);
									if (185281 - 105641 != 79640)
									{
										goto IL_1EB;
									}
								}
							}
							else if (this.$$switch$3962$34705 == 1)
							{
								if (132527 - 123983 != 8544)
								{
									goto IL_1EB;
								}
								if (this.$self_$34710.potion_mpPotion)
								{
									if (171406 - 197491 != -26085)
									{
										goto IL_1EB;
									}
									this.$nPotion$34704 = (GameObject)UnityEngine.Object.Instantiate(this.$self_$34710.potion_mpPotion, this.$mPos$34707 + global::Math.rotateH((float)2 * this.$tDir$34708, (float)120), Quaternion.identity);
									if (49492 - 364656 == -315163)
									{
										goto IL_1EB;
									}
								}
							}
							else if (this.$$switch$3962$34705 == 2)
							{
								if (246762 - 92606 != 154156)
								{
									goto IL_1EB;
								}
								if (this.$self_$34710.potion_spPotion)
								{
									if (170716 - 495918 == -325201)
									{
										goto IL_1EB;
									}
									this.$nPotion$34704 = (GameObject)UnityEngine.Object.Instantiate(this.$self_$34710.potion_spPotion, this.$mPos$34707 + global::Math.rotateH((float)2 * this.$tDir$34708, (float)240), Quaternion.identity);
									if (76125 - 442982 != -366857)
									{
										goto IL_1EB;
									}
								}
							}
							if (this.$nPotion$34704)
							{
								if (48246 - 464210 != -415964)
								{
									goto IL_1EB;
								}
								this.$self_$34710.r9vc6lwI73u = this.$self_$34710.r9vc6lwI73u + 1;
								if (157338 - 570135 == -412796)
								{
									goto IL_1EB;
								}
								this.$self_$34710.KAFc6vJdHcQ.Add(this.$nPotion$34704);
								if (209823 - 105340 != 104483)
								{
									goto IL_1EB;
								}
								this.$mPotionScript$34706 = (CaravanMupo_potion)this.$nPotion$34704.GetComponent(typeof(CaravanMupo_potion));
								if (72837 - 545272 != -472435)
								{
									goto IL_1EB;
								}
								if (this.$mPotionScript$34706)
								{
									if (163846 - 320046 == -156199)
									{
										goto IL_1EB;
									}
									this.$mPotionScript$34706.Init(12, this.$tID$34709 + this.$i$34703, this.$self_$34710.mChar.ActorNr);
									if (42126 - 108942 == -66815)
									{
										goto IL_1EB;
									}
								}
							}
							this.$i$34703++;
							if (94356 - 541970 != -447614)
							{
								goto IL_1EB;
							}
						}
						if (212389 - 454390 == -242000)
						{
							continue;
						}
						this.YieldDefault(1);
						if (6946 - 206959 != -200013)
						{
							continue;
						}
						goto IL_54D;
					default:
						if (222342 - 77615 == 144728)
						{
							continue;
						}
						break;
					}
					this.$self_$34710.mChar.addTimeOut("nAttack", (float)3);
					if (109167 - 138569 == -29402)
					{
						if (this.$self_$34710.potion_ring)
						{
							if (69252 - 89764 == -20512)
							{
								UnityEngine.Object.Instantiate(this.$self_$34710.potion_ring, this.$mPos$34707, Quaternion.LookRotation(this.$tDir$34708));
								if (113736 - 360878 == -247142)
								{
									break;
								}
							}
						}
						else
						{
							Debug.LogError("Missing potion_ring effect");
							if (95834 - 153308 == -57474)
							{
								break;
							}
						}
					}
				}
				IL_D5:
				return this.Yield(2, new WaitForSeconds(0.4f));
				goto IL_D5;
				IL_54D:
				return false;
			}

			// Token: 0x06005724 RID: 22308 RVA: 0x00A7AE98 File Offset: 0x00A79098
			internal static bool PB60e85zblK9NcjgLbww()
			{
				return true;
			}

			// Token: 0x06005725 RID: 22309 RVA: 0x00A7AE9C File Offset: 0x00A7909C
			internal static bool SwKeP25zuRARTgfAZ98t()
			{
				return false;
			}

			// Token: 0x04005F8E RID: 24462
			internal int $i$34703;

			// Token: 0x04005F8F RID: 24463
			internal GameObject $nPotion$34704;

			// Token: 0x04005F90 RID: 24464
			internal int $$switch$3962$34705;

			// Token: 0x04005F91 RID: 24465
			internal CaravanMupo_potion $mPotionScript$34706;

			// Token: 0x04005F92 RID: 24466
			internal Vector3 $mPos$34707;

			// Token: 0x04005F93 RID: 24467
			internal Vector3 $tDir$34708;

			// Token: 0x04005F94 RID: 24468
			internal int $tID$34709;

			// Token: 0x04005F95 RID: 24469
			internal CaravanMupoMount $self_$34710;
		}
	}
}
