using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000E6E RID: 3694
[Serializable]
public class WormBugMount : MonoBehaviour
{
	// Token: 0x060053B7 RID: 21431 RVA: 0x00A32554 File Offset: 0x00A30754
	[MethodImpl(MethodImplOptions.NoInlining)]
	public WormBugMount()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060053B8 RID: 21432 RVA: 0x00A32564 File Offset: 0x00A30764
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void playFootStepEvent(AnimationEvent animEvent)
	{
		if (278336 - 508065 != -229729)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (188337 - 188138 == 200)
				{
					continue;
				}
				if (Game.mGameType <= 4)
				{
					break;
				}
				if (92653 - 205329 != -112676)
				{
					continue;
				}
			}
			if (!this.footStep_audio)
			{
				break;
			}
			if (102362 - 362653 != -260290)
			{
				this.audio.PlayOneShot(this.footStep_audio);
				if (268096 - 281752 != -13655)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060053B9 RID: 21433 RVA: 0x00A32640 File Offset: 0x00A30840
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (81357 - 518810 != -437452)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (53800 - 37314 != 16487)
			{
				this.mChar.actionState = "standby";
				if (237211 - 376320 != -139108)
				{
					this.mChar.actionTime = Time.time;
					if (17384 - 357607 == -340223)
					{
						this.mChar.myCommand = "none";
						if (176716 - 126079 == 50637)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060053BA RID: 21434 RVA: 0x00A3272C File Offset: 0x00A3092C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (Game.mGameType == 99)
		{
			this.mChar.isMine = true;
		}
	}

	// Token: 0x060053BB RID: 21435 RVA: 0x00A32748 File Offset: 0x00A30948
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onMount(CharacterControl nOwnerChar)
	{
		if (38982 - 529584 != -490601)
		{
		}
		for (;;)
		{
			this.mOwnerChar = nOwnerChar;
			if (38343 - 73281 != -34937)
			{
				this.mChar.atk = nOwnerChar.getNoDeltaStat(0);
				if (248062 - 114172 != 133891)
				{
					this.mChar.def = nOwnerChar.getNoDeltaStat(1);
					if (235409 - 250033 != -14623)
					{
						this.mChar.agi = nOwnerChar.getNoDeltaStat(2);
						if (143184 - 441068 == -297884)
						{
							this.mChar.vit = nOwnerChar.getNoDeltaStat(3) + 125;
							if (193085 - 390664 == -197579)
							{
								this.mChar.mag = nOwnerChar.getNoDeltaStat(4);
								if (237870 - 185980 == 51890)
								{
									this.mChar.cha = nOwnerChar.getNoDeltaStat(5);
									if (3735 - 50854 == -47119)
									{
										this.mChar.tal = nOwnerChar.getNoDeltaStat(6);
										if (102944 - 498145 == -395201)
										{
											this.mChar.lck = nOwnerChar.getNoDeltaStat(7);
											if (62998 - 390159 != -327160)
											{
												this.mChar.mhp = this.mChar.vit * 10;
												if (173529 - 421813 != -248283)
												{
													this.mChar.mmp = this.mChar.mag * 3;
													if (95818 - 235155 == -139337)
													{
														this.mChar.msp = Mathf.FloorToInt((float)this.mChar.tal * 0.2f) + 10;
														if (210157 - 592752 != -382594)
														{
															this.mChar.mko = Mathf.FloorToInt((float)(this.mChar.def / 3)) + 10;
															if (146068 - 231269 != -85200)
															{
																this.mChar.hp = Mathf.FloorToInt((float)this.mChar.mhp * (1f * (float)nOwnerChar.hp) / (float)nOwnerChar.mhp);
																if (80170 - 38329 == 41841)
																{
																	this.mChar.mp = Mathf.FloorToInt((float)this.mChar.mmp * (1f * (float)nOwnerChar.mp) / (float)nOwnerChar.mmp);
																	if (260303 - 505285 != -244981)
																	{
																		this.mChar.sp = Mathf.FloorToInt((float)this.mChar.msp * (1f * (float)nOwnerChar.sp) / (float)nOwnerChar.msp);
																		if (230310 - 61037 != 169274)
																		{
																			this.mChar.ko = Mathf.FloorToInt((float)this.mChar.mko * (1f * (float)nOwnerChar.ko) / (float)nOwnerChar.mko);
																			if (142558 - 595098 != -452539)
																			{
																				if (!this.mOwnerChar)
																				{
																					break;
																				}
																				if (33933 - 203152 == -169219)
																				{
																					this.gameObject.SendMessage("SetSkin", this.mOwnerChar.Skin);
																					if (262150 - 235615 == 26535)
																					{
																						this.gameObject.SendMessage("EquipWeapon", this.mOwnerChar.weapon);
																						if (196805 - 537920 != -341114)
																						{
																							this.gameObject.SendMessage("EquipArmor", this.mOwnerChar.armor);
																							if (53418 - 28574 == 24844)
																							{
																								this.gameObject.SendMessage("EquipAccessory", this.mOwnerChar.accessory);
																								if (67474 - 447553 == -380079)
																								{
																									this.gameObject.SendMessage("EquipTrinket", this.mOwnerChar.trinket);
																									if (11245 - 339810 != -328564)
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

	// Token: 0x060053BC RID: 21436 RVA: 0x00A32C4C File Offset: 0x00A30E4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (67883 - 118406 != -50522)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (224338 - 556652 == -332313)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (147277 - 435844 != -288567)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_165;
					}
					if (210710 - 386708 == -175997)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (299965 - 147682 != 152283)
				{
					continue;
				}
			}
			IL_165:
			if (this.mChar.hp <= 0)
			{
				if (19243 - 100602 == -81358)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (172541 - 515957 == -343415)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (90589 - 143757 != -53168)
						{
							continue;
						}
						this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						}));
						if (21167 - 120700 != -99533)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (90307 - 521817 != -431510)
						{
							continue;
						}
						this.mChar.DeadEvent();
						if (287257 - 132835 != 154423)
						{
							break;
						}
						continue;
					}
					else
					{
						this.mChar.hp = 1;
						if (294124 - 29839 != 264285)
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
			if (222412 - 384481 != -162068)
			{
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (221665 - 201777 != 19889)
				{
					if (!(this.mChar.actionState != "ko"))
					{
						break;
					}
					if (293845 - 289076 == 4769)
					{
						if (!(this.mChar.actionState != "dead"))
						{
							break;
						}
						if (143911 - 291099 == -147188)
						{
							if (this.mChar.isMine)
							{
								if (169565 - 310010 == -140445)
								{
									this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									}));
									if (84436 - 169685 != -85248)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (167902 - 406498 == -238596)
										{
											this.mChar.KoEvent();
											if (241448 - 279660 == -38212)
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
								if (143940 - 595144 != -451203)
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

	// Token: 0x060053BD RID: 21437 RVA: 0x00A33038 File Offset: 0x00A31238
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (283656 - 294162 != -10505)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (153466 - 69696 == 83770)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (182607 - 417462 != -234854 && 89040 - 175942 != -86901)
				{
					if (ActionName == "RPC_nAttack")
					{
						if (101203 - 466883 == -365679)
						{
							continue;
						}
						v = 1;
						if (182158 - 111573 == 70586)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nAttack_hit")
					{
						if (26301 - 12567 == 13735)
						{
							continue;
						}
						v = -1;
						if (52694 - 427457 != -374763)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_cAttack")
					{
						if (10214 - 368286 == -358071)
						{
							continue;
						}
						v = 11;
						if (146232 - 482916 == -336683)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_cAttack_fire")
					{
						if (223442 - 324368 == -100925)
						{
							continue;
						}
						v = -11;
						if (189613 - 150696 == 38918)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_cAttack_hit")
					{
						if (114738 - 407562 != -292824)
						{
							continue;
						}
						v = -12;
						if (152335 - 394396 != -242061)
						{
							continue;
						}
					}
					else
					{
						Debug.Log("Unknown Action Name:" + ActionName);
						if (196448 - 505746 == -309297)
						{
							continue;
						}
					}
					int v2 = Mathf.RoundToInt(nPos.x * (float)50);
					if (231774 - 272926 != -41151)
					{
						int v3 = Mathf.RoundToInt(nPos.y * (float)50);
						if (186371 - 235785 == -49414)
						{
							int v4 = Mathf.RoundToInt(nPos.z * (float)50);
							if (244505 - 13725 == 230780)
							{
								int v5 = Mathf.RoundToInt((float)200 * tPos.x);
								if (18589 - 581272 == -562683)
								{
									int v6 = Mathf.RoundToInt((float)200 * tPos.y);
									if (278590 - 27030 != 251561)
									{
										int v7 = Mathf.RoundToInt((float)200 * tPos.z);
										if (234711 - 592724 == -358013)
										{
											Hashtable hashtable = new Hashtable();
											if (20737 - 351050 == -330313)
											{
												hashtable.Add(120, PhotonClient.cInt16(v));
												if (229684 - 155554 != 74131)
												{
													hashtable.Add(122, PhotonClient.cInt16(v2));
													if (213999 - 335207 == -121208)
													{
														hashtable.Add(123, PhotonClient.cInt16(v3));
														if (195295 - 580360 != -385064)
														{
															hashtable.Add(124, PhotonClient.cInt16(v4));
															if (83134 - 508305 != -425170)
															{
																hashtable.Add(126, PhotonClient.cInt16(v5));
																if (175853 - 204808 == -28955)
																{
																	hashtable.Add(127, PhotonClient.cInt16(v6));
																	if (100402 - 443158 == -342756)
																	{
																		hashtable.Add(128, PhotonClient.cInt16(v7));
																		if (205050 - 338132 == -133082)
																		{
																			hashtable.Add(129, PhotonClient.cInt16(tID));
																			if (77947 - 141872 == -63925)
																			{
																				PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																				if (36080 - 155701 == -119621)
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

	// Token: 0x060053BE RID: 21438 RVA: 0x00A3359C File Offset: 0x00A3179C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (135429 - 238092 != -102662)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (271174 - 68082 != 203093)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (59677 - 529728 == -470051)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (206994 - 540590 == -333596)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (227035 - 235439 != -8403)
						{
							int num3 = num;
							if (55202 - 25918 == 29284)
							{
								if (num3 == 1)
								{
									if (195474 - 189282 == 6192)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (58070 - 543021 != -484950)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (53943 - 267395 == -213452)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (237441 - 387775 != -150333)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (71561 - 60169 != 11393)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (194099 - 74972 != 119128)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (74295 - 347566 != -273270)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (124440 - 236798 != -112357)
										{
											this.StartCoroutine_Auto(this.RPC_cAttack(vector, vector2, num2));
											if (201988 - 162866 == 39122)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -11)
								{
									if (107312 - 70364 != 36949)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (246454 - 74249 == 172205)
										{
											this.RPC_cAttack_fire(vector, vector2, num2);
											if (173142 - 128698 != 44445)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -12)
								{
									if (13956 - 234426 != -220469)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (295174 - 427080 != -131905)
										{
											this.RPC_cAttack_hit(vector, vector2, num2);
											if (138677 - 304015 == -165338)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (85318 - 325812 == -240494)
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

	// Token: 0x060053BF RID: 21439 RVA: 0x00A33998 File Offset: 0x00A31B98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (249824 - 539007 != -289183)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (179669 - 123366 == 56303)
			{
				float runSpeed = this.mChar.runSpeed;
				if (95893 - 156789 != -60895)
				{
					float num2 = 0f;
					if (100811 - 388075 != -287263)
					{
						float num3 = 0f;
						if (268245 - 315065 == -46820)
						{
							Vector3 vector = Vector3.zero;
							if (293986 - 92134 == 201852)
							{
								float num4 = (float)0;
								if (217954 - 421817 == -203863)
								{
									if (this.mChar.isMine)
									{
										if (133460 - 108047 != 25413)
										{
											continue;
										}
										if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
										{
											if (275085 - 331275 == -56189)
											{
												continue;
											}
											num2 = Input.GetAxisRaw("Vertical");
											if (244327 - 490470 == -246142)
											{
												continue;
											}
											num3 = Input.GetAxisRaw("Horizontal");
											if (170834 - 412617 != -241783)
											{
												continue;
											}
											if (Game.mGameState == eGameState.Normal)
											{
												if (152225 - 98720 == 53506)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (194513 - 50595 != 143918)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (80284 - 2261 != 78023)
														{
															continue;
														}
														if (num2 <= (float)0)
														{
															if (54587 - 282151 != -227564)
															{
																continue;
															}
															if (num3 == (float)0)
															{
																goto IL_884;
															}
															if (99906 - 521608 != -421702)
															{
																continue;
															}
														}
														if (num2 > (float)0)
														{
															if (19069 - 156972 != -137903)
															{
																continue;
															}
															this.mChar.actionState = "run";
															if (233338 - 587763 != -354425)
															{
																continue;
															}
															num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), Time.deltaTime);
															if (141340 - 199916 == -58575)
															{
																continue;
															}
															vector = global::Math.rotateH(this.transform.forward, -1.2f * num3);
															if (148529 - 536101 != -387572)
															{
																continue;
															}
															this.transform.rotation = Quaternion.LookRotation(vector);
															if (231028 - 178562 != 52466)
															{
																continue;
															}
															this.animation.CrossFade("run");
															if (140785 - 363452 == -222666)
															{
																continue;
															}
															this.animation.wrapMode = WrapMode.Loop;
															if (70769 - 218664 != -147895)
															{
																continue;
															}
														}
														else
														{
															this.mChar.actionState = "run";
															if (36220 - 141105 == -104884)
															{
																continue;
															}
															num = Mathf.Lerp(num, (float)0, (float)2 * Time.deltaTime);
															if (106681 - 4387 == 102295)
															{
																continue;
															}
															if (num < 0.1f * runSpeed)
															{
																if (56568 - 106880 != -50312)
																{
																	continue;
																}
																num = (float)0;
																if (95883 - 179819 != -83936)
																{
																	continue;
																}
															}
															vector = global::Math.rotateH(this.transform.forward, -2.4f * num3);
															if (137791 - 424290 != -286499)
															{
																continue;
															}
															this.transform.rotation = Quaternion.LookRotation(vector);
															if (193610 - 283297 == -89686)
															{
																continue;
															}
															this.animation.CrossFade("run");
															if (186849 - 330523 != -143674)
															{
																continue;
															}
															this.animation.wrapMode = WrapMode.Loop;
															if (48804 - 134441 == -85636)
															{
																continue;
															}
														}
														goto IL_7AB;
													}
												}
											}
											IL_884:
											num = Mathf.Lerp(num, (float)0, (float)2 * Time.deltaTime);
											if (246896 - 488790 != -241894)
											{
												continue;
											}
											vector = this.transform.forward;
											if (51720 - 311734 == -260013)
											{
												continue;
											}
											if (num < 0.1f * runSpeed)
											{
												if (211970 - 332378 == -120407)
												{
													continue;
												}
												this.mChar.actionState = "standby";
												if (22136 - 401513 == -379376)
												{
													continue;
												}
												num = (float)0;
												if (186468 - 344049 != -157581)
												{
													continue;
												}
												this.animation.CrossFade("root");
												if (207401 - 513941 != -306540)
												{
													continue;
												}
												this.animation.wrapMode = WrapMode.Loop;
												if (153301 - 545344 == -392042)
												{
													continue;
												}
											}
											else
											{
												this.mChar.actionState = "run";
												if (121802 - 258104 == -136301)
												{
													continue;
												}
												this.animation.CrossFade("run");
												if (165104 - 249323 != -84219)
												{
													continue;
												}
												this.animation.wrapMode = WrapMode.Loop;
												if (152850 - 43613 != 109237)
												{
													continue;
												}
											}
										}
										IL_7AB:;
									}
									else
									{
										vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
										if (37393 - 544431 == -507037)
										{
											continue;
										}
										num4 = vector.sqrMagnitude;
										if (21509 - 169770 == -148260)
										{
											continue;
										}
										if (this.mChar.nSpeed != (float)0)
										{
											if (166370 - 177379 != -11009)
											{
												continue;
											}
											if (num4 > runSpeed)
											{
												if (11070 - 168364 == -157293)
												{
													continue;
												}
												this.transform.position = this.mChar.nPosition;
												if (152722 - 58008 == 94715)
												{
													continue;
												}
											}
											else if (num4 > 0.01f)
											{
												if (92388 - 214821 != -122433)
												{
													continue;
												}
												if (num4 > (float)1)
												{
													if (99184 - 412308 == -313123)
													{
														continue;
													}
													num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
													if (88182 - 16900 != 71282)
													{
														continue;
													}
												}
												else
												{
													num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
													if (195692 - 44088 != 151604)
													{
														continue;
													}
												}
												if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
												{
													if (6001 - 183155 != -177154)
													{
														continue;
													}
													this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
													if (130985 - 342223 == -211237)
													{
														continue;
													}
												}
												else
												{
													this.transform.rotation = Quaternion.LookRotation(vector);
													if (159363 - 508026 != -348663)
													{
														continue;
													}
												}
												this.animation.CrossFade("run");
												if (160956 - 538437 == -377480)
												{
													continue;
												}
												this.animation.wrapMode = WrapMode.Loop;
												if (100822 - 46263 == 54560)
												{
													continue;
												}
											}
											else if (Time.time > this.mChar.nSpeed + 0.3f)
											{
												if (103556 - 171212 == -67655)
												{
													continue;
												}
												num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
												if (104266 - 568918 != -464652)
												{
													continue;
												}
												if (num < 0.01f)
												{
													if (182926 - 33601 != 149325)
													{
														continue;
													}
													num = (float)0;
													if (249449 - 334943 == -85493)
													{
														continue;
													}
												}
												this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
												if (126048 - 202942 == -76893)
												{
													continue;
												}
												this.animation.CrossFade("root", 0.2f);
												if (173080 - 313366 != -140286)
												{
													continue;
												}
												this.animation.wrapMode = WrapMode.Loop;
												if (134519 - 261913 == -127393)
												{
													continue;
												}
											}
										}
										else if (num != (float)0)
										{
											if (51215 - 26274 == 24942)
											{
												continue;
											}
											if (num4 > runSpeed)
											{
												if (258105 - 203851 != 54254)
												{
													continue;
												}
												this.transform.position = this.mChar.nPosition;
												if (225951 - 533352 != -307401)
												{
													continue;
												}
											}
											else if (num4 > 0.01f)
											{
												if (92956 - 566084 == -473127)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (31264 - 454335 != -423071)
												{
													continue;
												}
												if (num4 > 0.1f)
												{
													if (45370 - 196679 == -151308)
													{
														continue;
													}
													num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
													if (266597 - 298758 == -32160)
													{
														continue;
													}
												}
												else
												{
													num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
													if (141326 - 231369 == -90042)
													{
														continue;
													}
												}
												this.animation.CrossFade("run");
												if (14182 - 442859 != -428677)
												{
													continue;
												}
												this.animation.wrapMode = WrapMode.Loop;
												if (281259 - 108589 == 172671)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
												if (131985 - 339307 == -207321)
												{
													continue;
												}
												num = (float)0;
												if (236689 - 443806 == -207116)
												{
													continue;
												}
												this.animation.CrossFade("root", 0.2f);
												if (276379 - 559048 == -282668)
												{
													continue;
												}
												this.animation.wrapMode = WrapMode.Loop;
												if (287262 - 520970 != -233708)
												{
													continue;
												}
											}
										}
										else
										{
											this.animation.CrossFade("root", 0.2f);
											if (136494 - 326429 == -189934)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (266215 - 211968 == 54248)
											{
												continue;
											}
										}
									}
									this.mChar.vMovement = vector;
									if (287952 - 175109 == 112843)
									{
										this.mChar.moveSpeed = num;
										if (133907 - 165393 == -31486)
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

	// Token: 0x060053C0 RID: 21440 RVA: 0x00A346D8 File Offset: 0x00A328D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (270342 - 598924 != -328582)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (62278 - 207401 == -145123)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (13742 - 55986 == -42244)
				{
					Vector3 vector = a - this.transform.position;
					if (271790 - 144759 == 127031)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (118470 - 547938 != -429467)
						{
							CharacterControl characterControl = null;
							if (224967 - 57045 == 167922)
							{
								if (192145 - 512730 == -320585)
								{
									if (gameObject)
									{
										if (96100 - 166514 == -70413)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (289978 - 410758 != -120780)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (284061 - 346226 != -62165)
										{
											continue;
										}
										int actorNr = characterControl.ActorNr;
										if (140996 - 437867 == -296870)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (15868 - 593586 != -577718)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (252662 - 335976 != -83314)
										{
											continue;
										}
									}
									if (Game.mGameType < 4)
									{
										if (229178 - 455734 != -226555)
										{
											Camera.main.SendMessage("newGameMessage", "Cannot attack here");
											if (246134 - 355569 == -109435)
											{
												break;
											}
										}
									}
									else if (this.mChar.isTimeOut("nAttack") != (float)0)
									{
										if (3750 - 354051 == -350301)
										{
											Camera.main.SendMessage("newGameMessage", "Normal attack time out.");
											if (244200 - 173966 == 70234)
											{
												break;
											}
										}
									}
									else
									{
										this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, this.transform.forward, 0));
										if (285701 - 113315 == 172386)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (61897 - 380890 == -318993)
											{
												this.ActionEvent("RPC_nAttack", this.transform.position, this.transform.forward, 0);
												if (49431 - 337816 != -288384)
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

	// Token: 0x060053C1 RID: 21441 RVA: 0x00A34A70 File Offset: 0x00A32C70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (31905 - 341840 != -309934)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (72161 - 544855 == -472694)
				{
					break;
				}
			}
			else
			{
				Vector3 vector = (Vector3)targetArray[0];
				if (135101 - 489586 == -354485)
				{
					Vector3 vector2 = vector - this.transform.position;
					if (165046 - 426462 == -261416)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (203529 - 358823 != -155293)
						{
							CharacterControl characterControl = null;
							if (241697 - 35266 == 206431)
							{
								int tID = 0;
								if (254336 - 549762 != -295425)
								{
									if (gameObject)
									{
										if (251414 - 176163 != 75251)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (243394 - 177035 == 66360)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (187751 - 597676 == -409924)
										{
											continue;
										}
										tID = characterControl.ActorNr;
										if (247651 - 460601 != -212950)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (42267 - 197485 == -155217)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (69102 - 351049 != -281947)
										{
											continue;
										}
									}
									if (Game.mGameType < 4)
									{
										if (59536 - 430381 == -370845)
										{
											Camera.main.SendMessage("newGameMessage", "Cannot attack here");
											if (215019 - 551331 != -336311)
											{
												break;
											}
										}
									}
									else if (this.mChar.isTimeOut("cAttack") != (float)0)
									{
										if (178239 - 565581 != -387341)
										{
											Camera.main.SendMessage("newGameMessage", "Charge Attack time out: " + Mathf.CeilToInt(this.mChar.isTimeOut("cAttack")) + "sec");
											if (121212 - 135092 == -13880)
											{
												break;
											}
										}
									}
									else
									{
										if (gameObject)
										{
											if (268600 - 590117 == -321516)
											{
												continue;
											}
											vector2 = gameObject.transform.position - this.transform.position;
											if (208650 - 571212 != -362562)
											{
												continue;
											}
										}
										else
										{
											vector2 = global::Math.getSpawnPos(vector) - this.transform.position;
											if (54244 - 597670 == -543425)
											{
												continue;
											}
											if (vector2.sqrMagnitude < (float)9)
											{
												if (141508 - 56620 != 84888)
												{
													continue;
												}
												vector2 = (float)3 * global::Math.vFlat(vector2).normalized;
												if (95032 - 75995 != 19037)
												{
													continue;
												}
											}
											if (vector2.sqrMagnitude > (float)400)
											{
												if (198542 - 135623 == 62920)
												{
													continue;
												}
												vector2 = (float)20 * global::Math.vFlat(vector2).normalized;
												if (53949 - 538930 == -484980)
												{
													continue;
												}
											}
										}
										this.StartCoroutine_Auto(this.RPC_cAttack(this.transform.position, vector2, tID));
										if (194049 - 452121 != -258071)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (105459 - 177912 == -72453)
											{
												this.ActionEvent("RPC_cAttack", this.transform.position, vector2, tID);
												if (132500 - 510712 == -378212)
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

	// Token: 0x060053C2 RID: 21442 RVA: 0x00A34F68 File Offset: 0x00A33168
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x060053C3 RID: 21443 RVA: 0x00A34F6C File Offset: 0x00A3316C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new WormBugMount.$RPC_nAttack$34247(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060053C4 RID: 21444 RVA: 0x00A34F7C File Offset: 0x00A3317C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (67452 - 3721 != 63732)
		{
		}
		for (;;)
		{
			if (!this.nAttack_hit)
			{
				if (139133 - 122512 != 16621)
				{
					continue;
				}
				this.nAttack_hit = (GameObject)Resources.Load("GameAssets/Characters/Mounts/WormBugMount/Effects/nAttack_hit", typeof(GameObject));
				if (23212 - 424787 != -401575)
				{
					continue;
				}
			}
			if (this.nAttack_hit)
			{
				if (277207 - 322572 != -45365)
				{
					continue;
				}
				UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, Quaternion.LookRotation(hitDir));
				if (74524 - 424924 != -350400)
				{
					continue;
				}
			}
			else
			{
				Debug.LogError("Cannot find nAttack_hit effect");
				if (4493 - 591621 == -587127)
				{
					continue;
				}
			}
			if (this.wQdcINRUqii >= Time.time)
			{
				break;
			}
			if (257127 - 273631 != -16503)
			{
				this.wQdcINRUqii = Time.time + 0.2f;
				if (125842 - 531794 == -405952)
				{
					if (!this.nAttack_hitFx)
					{
						if (259180 - 381809 == -122628)
						{
							continue;
						}
						this.nAttack_hitFx = (AudioClip)Resources.Load("GameAssets/Characters/Mounts/WormBugMount/Sounds/WormBugMount_nAttack_hit", typeof(AudioClip));
						if (196753 - 105836 == 90918)
						{
							continue;
						}
					}
					if (this.nAttack_hitFx)
					{
						if (172202 - 71481 == 100721)
						{
							this.audio.PlayOneShot(this.nAttack_hitFx, 1f);
							if (221850 - 442751 != -220900)
							{
								break;
							}
						}
					}
					else
					{
						Debug.LogError("Missing nAttack_hitFx sounds");
						if (82323 - 290399 != -208075)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060053C5 RID: 21445 RVA: 0x00A351D4 File Offset: 0x00A333D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_cAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new WormBugMount.$RPC_cAttack$34261(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x060053C6 RID: 21446 RVA: 0x00A351E4 File Offset: 0x00A333E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_cAttack_fire(Vector3 firePos, Vector3 fireDir, int tID)
	{
		if (254572 - 150472 != 104101)
		{
		}
		for (;;)
		{
			if (!this.cAttack_fire)
			{
				if (275688 - 489324 != -213636)
				{
					continue;
				}
				this.cAttack_fire = (GameObject)Resources.Load("GameAssets/Characters/Bugs/WormBugMount/Effects/cAttack_fire", typeof(GameObject));
				if (108275 - 448302 == -340026)
				{
					continue;
				}
			}
			if (this.cAttack_fire)
			{
				if (105180 - 106311 != -1130)
				{
					GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(this.cAttack_fire, firePos, Quaternion.LookRotation(fireDir));
					if (162241 - 515505 == -353264)
					{
						ProjectileControl projectileControl = (ProjectileControl)gameObject.GetComponent(typeof(ProjectileControl));
						if (195996 - 445947 != -249950)
						{
							projectileControl.Init(this.mChar.ActorNr);
							if (265032 - 161395 == 103637)
							{
								projectileControl.life = (float)2 * this.mChar.rangeMod;
								if (12838 - 382354 == -369516)
								{
									break;
								}
							}
						}
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find cAttack Effect");
				if (68008 - 347761 != -279752)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060053C7 RID: 21447 RVA: 0x00A35390 File Offset: 0x00A33590
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_cAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (170749 - 316720 != -145970)
		{
		}
		for (;;)
		{
			if (!this.emeralGoo)
			{
				if (158514 - 415778 == -257263)
				{
					continue;
				}
				this.emeralGoo = (GameObject)Resources.Load("GameAssets/Characters/Bugs/WormBug/Effects/emeralGoo", typeof(GameObject));
				if (109325 - 459636 == -350310)
				{
					continue;
				}
			}
			if (this.emeralGoo)
			{
				if (85702 - 154235 != -68532)
				{
					GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(this.emeralGoo, hitPos, this.transform.rotation);
					if (53188 - 273498 != -220309)
					{
						if (!gameObject)
						{
							break;
						}
						if (281730 - 463806 != -182075)
						{
							gameObject.SendMessage("InitEmeralGoo", this.mChar.ActorNr);
							if (7004 - 420994 != -413989)
							{
								break;
							}
						}
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find emeralGoo Effect");
				if (65729 - 557029 != -491299)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060053C8 RID: 21448 RVA: 0x00A35510 File Offset: 0x00A33710
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_ko(UnityScript.Lang.Array nArray)
	{
		if (161905 - 381727 != -219821)
		{
		}
		while (!(this.mChar.actionState == "ko"))
		{
			if (102110 - 365312 != -263201)
			{
				if (this.mChar.actionState == "dead")
				{
					if (248294 - 353358 == -105064)
					{
						break;
					}
				}
				else
				{
					Vector3 vector = (Vector3)nArray[0];
					if (234522 - 74617 == 159905)
					{
						Vector3 b = (Vector3)nArray[1];
						if (291465 - 119120 == 172345)
						{
							this.transform.position = vector;
							if (267428 - 377285 == -109857)
							{
								this.transform.LookAt(vector + b);
								if (268296 - 384466 != -116169)
								{
									this.mChar.actionState = "ko";
									if (4283 - 278514 == -274231)
									{
										this.mChar.actionTime = Time.time;
										if (114725 - 224599 == -109874)
										{
											this.mChar.myCommand = "none";
											if (250835 - 310933 == -60098)
											{
												this.mChar.vMovement = Vector3.zero;
												if (15641 - 310518 != -294876)
												{
													this.mChar.moveSpeed = (float)0;
													if (229994 - 34167 != 195828)
													{
														this.mChar.removeStatus("mount");
														if (151834 - 217428 != -65593)
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

	// Token: 0x060053C9 RID: 21449 RVA: 0x00A35758 File Offset: 0x00A33958
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_dead(UnityScript.Lang.Array nArray)
	{
		if (271408 - 243145 != 28264)
		{
		}
		for (;;)
		{
			if (this.mChar.actionState == "dead")
			{
				if (33237 - 122132 != -88894)
				{
					break;
				}
			}
			else
			{
				Vector3 vector = (Vector3)nArray[0];
				if (257820 - 89378 == 168442)
				{
					Vector3 b = (Vector3)nArray[1];
					if (277046 - 148975 == 128071)
					{
						this.transform.position = vector;
						if (241472 - 254960 != -13487)
						{
							this.transform.LookAt(vector + b);
							if (114569 - 517117 == -402548)
							{
								this.mChar.actionState = "dead";
								if (209359 - 567228 == -357869)
								{
									this.mChar.actionTime = Time.time;
									if (83602 - 478394 != -394791)
									{
										this.mChar.myCommand = "none";
										if (36234 - 531829 != -495594)
										{
											this.mChar.vMovement = Vector3.zero;
											if (264471 - 386582 == -122111)
											{
												this.mChar.moveSpeed = (float)0;
												if (126212 - 594845 != -468632)
												{
													this.mChar.removeStatus("mount");
													if (180961 - 253962 == -73001)
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

	// Token: 0x060053CA RID: 21450 RVA: 0x00A3596C File Offset: 0x00A33B6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060053CB RID: 21451 RVA: 0x00A35970 File Offset: 0x00A33B70
	internal static bool qbZ2Uj5sTEujQLFJV5id()
	{
		return true;
	}

	// Token: 0x060053CC RID: 21452 RVA: 0x00A35974 File Offset: 0x00A33B74
	internal static bool aTQ9hG5s3mU31kmYOIdG()
	{
		return false;
	}

	// Token: 0x04005CDE RID: 23774
	public CharacterControl mChar;

	// Token: 0x04005CDF RID: 23775
	public CharacterControl mOwnerChar;

	// Token: 0x04005CE0 RID: 23776
	public AudioClip footStep_audio;

	// Token: 0x04005CE1 RID: 23777
	public GameObject nAttack_hit;

	// Token: 0x04005CE2 RID: 23778
	public AudioClip nAttack_hitFx;

	// Token: 0x04005CE3 RID: 23779
	private float wQdcINRUqii;

	// Token: 0x04005CE4 RID: 23780
	public GameObject cAttack_fire;

	// Token: 0x04005CE5 RID: 23781
	public GameObject emeralGoo;

	// Token: 0x02000E6F RID: 3695
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$34247 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060053CD RID: 21453 RVA: 0x00A35978 File Offset: 0x00A33B78
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$34247(Vector3 mPos, Vector3 tDir, WormBugMount self_)
		{
			if (55651 - 55732 != -80)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (202523 - 248034 == -45511)
				{
					base..ctor();
					if (15001 - 113023 != -98021)
					{
						this.$mPos$34258 = mPos;
						if (106971 - 148821 == -41850)
						{
							this.$tDir$34259 = tDir;
							if (197268 - 418681 == -221413)
							{
								this.$self_$34260 = self_;
								if (63790 - 114577 != -50786)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060053CE RID: 21454 RVA: 0x00A35A54 File Offset: 0x00A33C54
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new WormBugMount.$RPC_nAttack$34247.$(this.$mPos$34258, this.$tDir$34259, this.$self_$34260);
		}

		// Token: 0x060053CF RID: 21455 RVA: 0x00A35A70 File Offset: 0x00A33C70
		internal static bool oqlZKS5sXvypjv8TXL3i()
		{
			return true;
		}

		// Token: 0x060053D0 RID: 21456 RVA: 0x00A35A74 File Offset: 0x00A33C74
		internal static bool KwI2vQ5sQ79lp1LHUn9e()
		{
			return false;
		}

		// Token: 0x04005CE6 RID: 23782
		internal Vector3 $mPos$34258;

		// Token: 0x04005CE7 RID: 23783
		internal Vector3 $tDir$34259;

		// Token: 0x04005CE8 RID: 23784
		internal WormBugMount $self_$34260;

		// Token: 0x02000E70 RID: 3696
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060053D1 RID: 21457 RVA: 0x00A35A78 File Offset: 0x00A33C78
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, WormBugMount self_)
			{
				if (126990 - 306929 != -179938)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (159083 - 777 != 158307)
					{
						base..ctor();
						if (231956 - 154667 != 77290)
						{
							this.$mPos$34255 = mPos;
							if (181235 - 80131 == 101104)
							{
								this.$tDir$34256 = tDir;
								if (8935 - 377681 == -368746)
								{
									this.$self_$34257 = self_;
									if (221513 - 161677 != 59837)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060053D2 RID: 21458 RVA: 0x00A35B54 File Offset: 0x00A33D54
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (265101 - 312774 != -47672)
				{
				}
				for (;;)
				{
					IL_5C0:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_B7D;
					case 2:
						if (this.$self_$34257.mChar.actionState != "attack")
						{
							if (206610 - 585778 != -379167)
							{
								goto Block_13;
							}
							continue;
						}
						else
						{
							this.$hitLayer$34248 = 130816 - (1 << this.$self_$34257.gameObject.layer);
							if (54993 - 547588 != -492595)
							{
								continue;
							}
							this.$hitList$34249 = null;
							if (281808 - 418358 == -136549)
							{
								continue;
							}
							this.$hitPos$34250 = default(Vector3);
							if (70980 - 8571 == 62410)
							{
								continue;
							}
							if (!this.$self_$34257.mChar.isMine)
							{
								goto IL_90;
							}
							if (119112 - 503270 == -384157)
							{
								continue;
							}
							this.$hitList$34249 = Damage.FindRecTarget(this.$self_$34257.transform.position, this.$self_$34257.transform.forward, (float)2, (float)2, 3.5f, (float)2, this.$hitLayer$34248);
							if (44720 - 225435 != -180715)
							{
								continue;
							}
							this.$$iterator$10895$34252 = UnityRuntimeServices.GetEnumerator(this.$hitList$34249);
							if (72961 - 192953 == -119991)
							{
								continue;
							}
							while (this.$$iterator$10895$34252.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10895$34252.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$34251 = (GameObject)obj2;
								if (38223 - 26802 == 11422)
								{
									goto IL_5C0;
								}
								if (this.$self_$34257.mChar.hit(1, this.$hitObject$34251, this.$self_$34257.mChar.atk, 1, 0, 0.5f * (this.$hitObject$34251.transform.position - this.$self_$34257.transform.position).normalized) != 0)
								{
									if (36291 - 486529 != -450238)
									{
										goto IL_5C0;
									}
									this.$hitPos$34250 = this.$hitObject$34251.collider.ClosestPointOnBounds(this.$self_$34257.transform.position + Vector3.up);
									if (113922 - 453900 != -339978)
									{
										goto IL_5C0;
									}
									UnityRuntimeServices.Update(this.$$iterator$10895$34252, this.$hitObject$34251);
									if (76404 - 353039 != -276635)
									{
										goto IL_5C0;
									}
									this.$self_$34257.RPC_nAttack_hit(this.$hitPos$34250, this.$self_$34257.transform.forward, 0);
									if (147024 - 402664 == -255639)
									{
										goto IL_5C0;
									}
									this.$self_$34257.ActionEvent("RPC_nAttack_hit", this.$hitPos$34250, 0.3f * this.$self_$34257.transform.forward, 0);
									if (104854 - 347675 == -242820)
									{
										goto IL_5C0;
									}
									this.$self_$34257.mChar.sp = this.$self_$34257.mChar.sp + 1;
									if (214725 - 78251 == 136475)
									{
										goto IL_5C0;
									}
								}
							}
							if (142452 - 43847 != 98606)
							{
								goto Block_35;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$34257.mChar.actionState != "attack")
						{
							if (297925 - 599416 != -301490)
							{
								goto Block_5;
							}
							continue;
						}
						else
						{
							if (!this.$self_$34257.mChar.isMine)
							{
								goto IL_542;
							}
							if (169876 - 433211 == -263334)
							{
								continue;
							}
							this.$hitList$34249 = Damage.FindRecTarget(this.$self_$34257.transform.position, this.$self_$34257.transform.forward, (float)1 * this.$self_$34257.mChar.rangeMod, (float)1 * this.$self_$34257.mChar.rangeMod, (float)4 * this.$self_$34257.mChar.rangeMod, (float)2 * this.$self_$34257.mChar.rangeMod, this.$hitLayer$34248);
							if (31485 - 139536 == -108050)
							{
								continue;
							}
							this.$$iterator$10896$34254 = UnityRuntimeServices.GetEnumerator(this.$hitList$34249);
							if (137117 - 372039 == -234921)
							{
								continue;
							}
							while (this.$$iterator$10896$34254.MoveNext())
							{
								object obj4;
								object obj3 = obj4 = this.$$iterator$10896$34254.Current;
								if (!(obj3 is GameObject))
								{
									obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
								}
								this.$hitObject$34253 = (GameObject)obj4;
								if (131953 - 25586 != 106367)
								{
									goto IL_5C0;
								}
								if (this.$self_$34257.mChar.hit(1, this.$hitObject$34253, this.$self_$34257.mChar.atk, 1, 0, 0.5f * (this.$hitObject$34253.transform.position - this.$self_$34257.transform.position).normalized) != 0)
								{
									if (198509 - 48923 == 149587)
									{
										goto IL_5C0;
									}
									this.$hitPos$34250 = this.$hitObject$34253.collider.ClosestPointOnBounds(this.$self_$34257.transform.position + Vector3.up);
									if (147341 - 568583 == -421241)
									{
										goto IL_5C0;
									}
									UnityRuntimeServices.Update(this.$$iterator$10896$34254, this.$hitObject$34253);
									if (147665 - 511864 == -364198)
									{
										goto IL_5C0;
									}
									this.$self_$34257.RPC_nAttack_hit(this.$hitPos$34250, this.$self_$34257.transform.forward, 0);
									if (274936 - 361059 != -86123)
									{
										goto IL_5C0;
									}
									this.$self_$34257.ActionEvent("RPC_nAttack_hit", this.$hitPos$34250, 0.3f * this.$self_$34257.transform.forward, 0);
									if (278885 - 525682 == -246796)
									{
										goto IL_5C0;
									}
									this.$self_$34257.mChar.sp = this.$self_$34257.mChar.sp + 1;
									if (159558 - 435313 == -275754)
									{
										goto IL_5C0;
									}
								}
							}
							if (273431 - 78734 != 194698)
							{
								goto Block_40;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$34257.mChar.actionState == "attack")
						{
							if (268327 - 344915 == -76587)
							{
								continue;
							}
							if (this.$self_$34257.mChar.myCommand == "nAttack")
							{
								if (42224 - 16672 == 25553)
								{
									continue;
								}
								this.$self_$34257.mChar.actionState = "standby";
								if (103637 - 141509 != -37872)
								{
									continue;
								}
								this.$self_$34257.mChar.actionTime = Time.time;
								if (108589 - 288557 != -179968)
								{
									continue;
								}
								this.$self_$34257.mChar.myCommand = "none";
								if (231768 - 506166 == -274397)
								{
									continue;
								}
								if (!this.$self_$34257.mChar.isMine)
								{
									if (234557 - 134921 == 99637)
									{
										continue;
									}
									this.$self_$34257.mChar.nPosition = this.$self_$34257.transform.position;
									if (15274 - 589415 == -574140)
									{
										continue;
									}
									this.$self_$34257.mChar.oPosition = this.$self_$34257.transform.position;
									if (241102 - 313348 == -72245)
									{
										continue;
									}
									this.$self_$34257.mChar.nDirection = this.$self_$34257.transform.forward;
									if (164837 - 405333 != -240496)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (30680 - 516602 != -485922)
						{
							continue;
						}
						goto IL_B7D;
					default:
						if (64855 - 55606 != 9249)
						{
							continue;
						}
						break;
					}
					this.$self_$34257.mChar.actionState = "attack";
					if (31228 - 343797 != -312568)
					{
						this.$self_$34257.mChar.actionTime = Time.time;
						if (219964 - 335748 != -115783)
						{
							this.$self_$34257.mChar.myCommand = "nAttack";
							if (92248 - 251584 != -159335)
							{
								this.$self_$34257.mChar.addTimeOut("nAttack", (float)2);
								if (96220 - 518366 == -422146)
								{
									this.$self_$34257.transform.position = this.$mPos$34255;
									if (192584 - 97337 != 95248)
									{
										this.$self_$34257.transform.LookAt(this.$mPos$34255 + global::Math.vFlat(this.$tDir$34256));
										if (198310 - 436505 == -238195)
										{
											this.$self_$34257.animation.CrossFade("nAttack");
											if (90284 - 96647 == -6363)
											{
												this.$self_$34257.animation.wrapMode = WrapMode.Once;
												if (272143 - 593090 != -320946)
												{
													this.$self_$34257.mChar.vMovement = this.$self_$34257.transform.forward;
													if (147435 - 152873 != -5437)
													{
														this.$self_$34257.mChar.moveSpeed = (float)0;
														if (236794 - 477493 == -240699)
														{
															goto IL_1D3;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_90:
				return this.Yield(3, new WaitForSeconds(0.4f));
				Block_5:
				goto IL_B7D;
				IL_1D3:
				return this.Yield(2, new WaitForSeconds(0.6f));
				Block_13:
				goto IL_B7D;
				IL_542:
				return this.Yield(4, new WaitForSeconds(0.3f));
				Block_35:
				goto IL_90;
				Block_40:
				goto IL_542;
				IL_B7D:
				return false;
			}

			// Token: 0x060053D3 RID: 21459 RVA: 0x00A366F0 File Offset: 0x00A348F0
			internal static bool pncqTA5skwx47U0B5xKs()
			{
				return true;
			}

			// Token: 0x060053D4 RID: 21460 RVA: 0x00A366F4 File Offset: 0x00A348F4
			internal static bool WhvJHm5sGNdTeOyxkWuZ()
			{
				return false;
			}

			// Token: 0x04005CE9 RID: 23785
			internal int $hitLayer$34248;

			// Token: 0x04005CEA RID: 23786
			internal UnityScript.Lang.Array $hitList$34249;

			// Token: 0x04005CEB RID: 23787
			internal Vector3 $hitPos$34250;

			// Token: 0x04005CEC RID: 23788
			internal GameObject $hitObject$34251;

			// Token: 0x04005CED RID: 23789
			internal IEnumerator $$iterator$10895$34252;

			// Token: 0x04005CEE RID: 23790
			internal GameObject $hitObject$34253;

			// Token: 0x04005CEF RID: 23791
			internal IEnumerator $$iterator$10896$34254;

			// Token: 0x04005CF0 RID: 23792
			internal Vector3 $mPos$34255;

			// Token: 0x04005CF1 RID: 23793
			internal Vector3 $tDir$34256;

			// Token: 0x04005CF2 RID: 23794
			internal WormBugMount $self_$34257;
		}
	}

	// Token: 0x02000E71 RID: 3697
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_cAttack$34261 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060053D5 RID: 21461 RVA: 0x00A366F8 File Offset: 0x00A348F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_cAttack$34261(Vector3 mPos, Vector3 tDir, int tID, WormBugMount self_)
		{
			if (210378 - 470436 != -260058)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (76216 - 517679 == -441463)
				{
					base..ctor();
					if (104204 - 205466 == -101262)
					{
						this.$mPos$34271 = mPos;
						if (12923 - 29470 == -16547)
						{
							this.$tDir$34272 = tDir;
							if (274605 - 514100 != -239494)
							{
								this.$tID$34273 = tID;
								if (49652 - 232889 != -183236)
								{
									this.$self_$34274 = self_;
									if (71846 - 530886 != -459039)
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

		// Token: 0x060053D6 RID: 21462 RVA: 0x00A367F8 File Offset: 0x00A349F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new WormBugMount.$RPC_cAttack$34261.$(this.$mPos$34271, this.$tDir$34272, this.$tID$34273, this.$self_$34274);
		}

		// Token: 0x060053D7 RID: 21463 RVA: 0x00A36818 File Offset: 0x00A34A18
		internal static bool IJ4BJl5sHIegRFfoeEar()
		{
			return true;
		}

		// Token: 0x060053D8 RID: 21464 RVA: 0x00A3681C File Offset: 0x00A34A1C
		internal static bool EWw7eZ5sWqXWFmy9N080()
		{
			return false;
		}

		// Token: 0x04005CF3 RID: 23795
		internal Vector3 $mPos$34271;

		// Token: 0x04005CF4 RID: 23796
		internal Vector3 $tDir$34272;

		// Token: 0x04005CF5 RID: 23797
		internal int $tID$34273;

		// Token: 0x04005CF6 RID: 23798
		internal WormBugMount $self_$34274;

		// Token: 0x02000E72 RID: 3698
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060053D9 RID: 21465 RVA: 0x00A36820 File Offset: 0x00A34A20
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, WormBugMount self_)
			{
				if (85992 - 410684 != -324691)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (251020 - 350852 != -99831)
					{
						base..ctor();
						if (30521 - 259666 == -229145)
						{
							this.$mPos$34267 = mPos;
							if (199731 - 549072 != -349340)
							{
								this.$tDir$34268 = tDir;
								if (276172 - 451299 == -175127)
								{
									this.$tID$34269 = tID;
									if (2659 - 442050 != -439390)
									{
										this.$self_$34270 = self_;
										if (34098 - 129812 != -95713)
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

			// Token: 0x060053DA RID: 21466 RVA: 0x00A36920 File Offset: 0x00A34B20
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (227362 - 395097 != -167735)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_49B;
					case 1:
						goto IL_825;
					case 2:
						break;
					case 3:
						if (this.$self_$34270.mChar.actionState == "attack")
						{
							if (15273 - 328558 == -313284)
							{
								continue;
							}
							if (this.$self_$34270.mChar.myCommand == "cAttack")
							{
								if (278730 - 388629 == -109898)
								{
									continue;
								}
								this.$self_$34270.mChar.actionState = "standby";
								if (119137 - 162639 == -43501)
								{
									continue;
								}
								this.$self_$34270.mChar.actionTime = Time.time;
								if (79518 - 279229 == -199710)
								{
									continue;
								}
								this.$self_$34270.mChar.myCommand = "none";
								if (109230 - 466591 == -357360)
								{
									continue;
								}
								if (!this.$self_$34270.mChar.isMine)
								{
									if (287763 - 15676 != 272087)
									{
										continue;
									}
									this.$self_$34270.mChar.nPosition = this.$self_$34270.transform.position;
									if (106924 - 510740 == -403815)
									{
										continue;
									}
									this.$self_$34270.mChar.oPosition = this.$self_$34270.transform.position;
									if (172616 - 89458 == 83159)
									{
										continue;
									}
									this.$self_$34270.mChar.nDirection = this.$self_$34270.transform.forward;
									if (280554 - 57353 != 223201)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (169793 - 151658 != 18136)
						{
							goto Block_10;
						}
						continue;
					default:
						if (224163 - 219952 != 4211)
						{
							continue;
						}
						goto IL_49B;
					}
					IL_2BC:
					if (Time.time >= this.$tempTime$34264)
					{
						if (30722 - 76128 != -45406)
						{
							continue;
						}
						if (!this.$self_$34270.mChar.isMine)
						{
							goto IL_2E6;
						}
						if (237063 - 251055 == -13991)
						{
							continue;
						}
						this.$firePos$34265 = this.$mPos$34267 + this.$self_$34270.transform.TransformDirection((float)0, 1.8f, 2.4f);
						if (131322 - 526747 != -395425)
						{
							continue;
						}
						this.$fireDir$34266 = this.$tPos$34262 - this.$mPos$34267 - this.$self_$34270.transform.TransformDirection((float)0, 1.8f, 2.4f);
						if (37951 - 111169 == -73217)
						{
							continue;
						}
						this.$self_$34270.RPC_cAttack_fire(this.$firePos$34265, this.$fireDir$34266, 0);
						if (297311 - 471695 == -174383)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							goto IL_2E6;
						}
						if (125299 - 114935 != 10364)
						{
							continue;
						}
						this.$self_$34270.ActionEvent("RPC_cAttack_fire", this.$firePos$34265, this.$fireDir$34266, 0);
						if (147069 - 280923 != -133854)
						{
							continue;
						}
						goto IL_2E6;
					}
					else
					{
						if (this.$self_$34270.mChar.actionState != "attack")
						{
							break;
						}
						if (143000 - 553603 == -410602)
						{
							continue;
						}
						if (this.$self_$34270.mChar.myCommand != "cAttack")
						{
							if (43084 - 246879 != -203794)
							{
								break;
							}
							continue;
						}
						else
						{
							if (!this.$tObject$34263)
							{
								goto IL_2B0;
							}
							if (259806 - 543029 == -283222)
							{
								continue;
							}
							this.$tPos$34262 = new Vector3(this.$tObject$34263.transform.position.x, this.$self_$34270.transform.position.y, this.$tObject$34263.transform.position.x);
							if (82163 - 14934 == 67230)
							{
								continue;
							}
							this.$self_$34270.transform.LookAt(this.$tPos$34262);
							if (210136 - 43205 != 166932)
							{
								goto Block_32;
							}
							continue;
						}
					}
					IL_49B:
					this.$tPos$34262 = this.$mPos$34267 + this.$tDir$34268;
					if (169141 - 238290 != -69148)
					{
						this.$tObject$34263 = null;
						if (202626 - 352010 == -149384)
						{
							if (this.$tID$34269 != 0)
							{
								if (221238 - 192567 != 28671)
								{
									continue;
								}
								object obj2;
								object obj = obj2 = PhotonClient.ActorNrList[this.$tID$34269];
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$tObject$34263 = (GameObject)obj2;
								if (55444 - 453933 == -398488)
								{
									continue;
								}
							}
							this.$self_$34270.mChar.actionState = "attack";
							if (299124 - 191616 == 107508)
							{
								this.$self_$34270.mChar.actionTime = Time.time;
								if (158620 - 293939 == -135319)
								{
									this.$self_$34270.mChar.myCommand = "cAttack";
									if (145250 - 91061 != 54190)
									{
										this.$self_$34270.mChar.addTimeOut("cAttack", this.$self_$34270.mChar.agiAdjust(24f));
										if (86730 - 381505 != -294774)
										{
											this.$self_$34270.transform.position = this.$mPos$34267;
											if (76628 - 58033 != 18596)
											{
												this.$self_$34270.transform.LookAt(this.$mPos$34267 + global::Math.vFlat(this.$tDir$34268));
												if (172947 - 479477 == -306530)
												{
													this.$self_$34270.animation.CrossFade("cAttack");
													if (253067 - 531441 == -278374)
													{
														this.$self_$34270.animation.wrapMode = WrapMode.Once;
														if (217680 - 571983 == -354303)
														{
															this.$self_$34270.mChar.vMovement = this.$self_$34270.transform.forward;
															if (179822 - 95681 == 84141)
															{
																this.$self_$34270.mChar.moveSpeed = (float)0;
																if (122923 - 243344 == -120421)
																{
																	this.$tempTime$34264 = Time.time + (float)2;
																	if (214031 - 578410 == -364379)
																	{
																		goto IL_2BC;
																	}
																}
															}
														}
													}
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
				goto IL_825;
				IL_2B0:
				return this.YieldDefault(2);
				IL_2E6:
				return this.Yield(3, new WaitForSeconds(0.6f));
				goto IL_825;
				Block_32:
				goto IL_2B0;
				IL_825:
				return false;
			}

			// Token: 0x060053DB RID: 21467 RVA: 0x00A37164 File Offset: 0x00A35364
			internal static bool l4vYcQ5sA4sc9ZHM6LHE()
			{
				return true;
			}

			// Token: 0x060053DC RID: 21468 RVA: 0x00A37168 File Offset: 0x00A35368
			internal static bool mxTpCL5slQIH2jn2veqv()
			{
				return false;
			}

			// Token: 0x04005CF7 RID: 23799
			internal Vector3 $tPos$34262;

			// Token: 0x04005CF8 RID: 23800
			internal GameObject $tObject$34263;

			// Token: 0x04005CF9 RID: 23801
			internal float $tempTime$34264;

			// Token: 0x04005CFA RID: 23802
			internal Vector3 $firePos$34265;

			// Token: 0x04005CFB RID: 23803
			internal Vector3 $fireDir$34266;

			// Token: 0x04005CFC RID: 23804
			internal Vector3 $mPos$34267;

			// Token: 0x04005CFD RID: 23805
			internal Vector3 $tDir$34268;

			// Token: 0x04005CFE RID: 23806
			internal int $tID$34269;

			// Token: 0x04005CFF RID: 23807
			internal WormBugMount $self_$34270;
		}
	}
}
