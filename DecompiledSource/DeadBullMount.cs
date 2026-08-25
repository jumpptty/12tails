using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000E61 RID: 3681
[Serializable]
public class DeadBullMount : MonoBehaviour
{
	// Token: 0x06005359 RID: 21337 RVA: 0x00A285B0 File Offset: 0x00A267B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public DeadBullMount()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600535A RID: 21338 RVA: 0x00A285C0 File Offset: 0x00A267C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void playFootStepEvent(AnimationEvent animEvent)
	{
		if (79805 - 206126 != -126321)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (183535 - 47883 != 135652)
				{
					continue;
				}
				if (Game.mGameType <= 4)
				{
					break;
				}
				if (123453 - 63486 != 59967)
				{
					continue;
				}
			}
			if (!this.footStep_run)
			{
				break;
			}
			if (298025 - 189384 != 108642)
			{
				this.audio.PlayOneShot(this.footStep_run);
				if (64556 - 181153 == -116597)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600535B RID: 21339 RVA: 0x00A2869C File Offset: 0x00A2689C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (1125 - 446304 != -445178)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (277633 - 154863 == 122770)
			{
				this.mChar.actionState = "standby";
				if (269813 - 213694 == 56119)
				{
					this.mChar.actionTime = Time.time;
					if (52032 - 92283 == -40251)
					{
						this.mChar.myCommand = "none";
						if (42581 - 142342 != -99760)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600535C RID: 21340 RVA: 0x00A28788 File Offset: 0x00A26988
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (Game.mGameType == 99)
		{
			this.mChar.isMine = true;
		}
	}

	// Token: 0x0600535D RID: 21341 RVA: 0x00A287A4 File Offset: 0x00A269A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onMount(CharacterControl nOwnerChar)
	{
		if (203917 - 281872 != -77955)
		{
		}
		for (;;)
		{
			this.mOwnerChar = nOwnerChar;
			if (216082 - 9529 != 206554)
			{
				this.mChar.atk = nOwnerChar.getNoDeltaStat(0);
				if (185129 - 9758 != 175372)
				{
					this.mChar.def = nOwnerChar.getNoDeltaStat(1);
					if (2138 - 179910 == -177772)
					{
						this.mChar.agi = nOwnerChar.getNoDeltaStat(2) + 30;
						if (209541 - 99646 != 109896)
						{
							this.mChar.vit = nOwnerChar.getNoDeltaStat(3) + 30;
							if (71755 - 579664 != -507908)
							{
								this.mChar.mag = nOwnerChar.getNoDeltaStat(4);
								if (131979 - 349397 == -217418)
								{
									this.mChar.cha = nOwnerChar.getNoDeltaStat(5);
									if (275052 - 226092 == 48960)
									{
										this.mChar.tal = nOwnerChar.getNoDeltaStat(6);
										if (104586 - 7681 != 96906)
										{
											this.mChar.lck = nOwnerChar.getNoDeltaStat(7);
											if (87288 - 551403 == -464115)
											{
												this.mChar.mhp = this.mChar.vit * 10;
												if (235432 - 229387 == 6045)
												{
													this.mChar.mmp = this.mChar.mag * 3;
													if (103521 - 394712 == -291191)
													{
														this.mChar.msp = Mathf.FloorToInt((float)this.mChar.tal * 0.2f) + 10;
														if (35080 - 565064 != -529983)
														{
															this.mChar.mko = Mathf.FloorToInt((float)(this.mChar.def / 3)) + 10;
															if (23664 - 268475 != -244810)
															{
																this.mChar.hp = Mathf.FloorToInt((float)this.mChar.mhp * (1f * (float)nOwnerChar.hp) / (float)nOwnerChar.mhp);
																if (267910 - 290724 != -22813)
																{
																	this.mChar.mp = Mathf.FloorToInt((float)this.mChar.mmp * (1f * (float)nOwnerChar.mp) / (float)nOwnerChar.mmp);
																	if (290538 - 592860 != -302321)
																	{
																		this.mChar.sp = Mathf.FloorToInt((float)this.mChar.msp * (1f * (float)nOwnerChar.sp) / (float)nOwnerChar.msp);
																		if (61228 - 400501 == -339273)
																		{
																			this.mChar.ko = Mathf.FloorToInt((float)this.mChar.mko * (1f * (float)nOwnerChar.ko) / (float)nOwnerChar.mko);
																			if (263395 - 97473 == 165922)
																			{
																				if (!this.mOwnerChar)
																				{
																					break;
																				}
																				if (28295 - 536362 == -508067)
																				{
																					this.gameObject.SendMessage("SetSkin", this.mOwnerChar.Skin);
																					if (208152 - 302786 != -94633)
																					{
																						this.gameObject.SendMessage("EquipWeapon", this.mOwnerChar.weapon);
																						if (48214 - 236668 == -188454)
																						{
																							this.gameObject.SendMessage("EquipArmor", this.mOwnerChar.armor);
																							if (278041 - 526272 != -248230)
																							{
																								this.gameObject.SendMessage("EquipAccessory", this.mOwnerChar.accessory);
																								if (259868 - 90346 != 169523)
																								{
																									this.gameObject.SendMessage("EquipTrinket", this.mOwnerChar.trinket);
																									if (15318 - 507180 == -491862)
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

	// Token: 0x0600535E RID: 21342 RVA: 0x00A28CAC File Offset: 0x00A26EAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (6804 - 452912 != -446108)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (163521 - 594974 != -431453)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (182192 - 224556 != -42364)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_126;
					}
					if (236730 - 350436 == -113705)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (272656 - 127502 != 145154)
				{
					continue;
				}
			}
			IL_126:
			if (this.mChar.hp <= 0)
			{
				if (266189 - 219493 != 46696)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (278877 - 78061 == 200817)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (203235 - 329144 == -125908)
						{
							continue;
						}
						this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						}));
						if (169500 - 190123 != -20623)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (87669 - 460819 != -373150)
						{
							continue;
						}
						this.mChar.DeadEvent();
						if (134851 - 162290 != -27438)
						{
							break;
						}
						continue;
					}
					else
					{
						this.mChar.hp = 1;
						if (233532 - 80927 != 152606)
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
			if (249088 - 195307 == 53781)
			{
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (215035 - 38474 != 176562)
				{
					if (!(this.mChar.actionState != "ko"))
					{
						break;
					}
					if (70271 - 278184 == -207913)
					{
						if (!(this.mChar.actionState != "dead"))
						{
							break;
						}
						if (21526 - 371655 != -350128)
						{
							if (this.mChar.isMine)
							{
								if (158872 - 242934 != -84061)
								{
									this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									}));
									if (171628 - 309833 != -138204)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (20061 - 86177 == -66116)
										{
											this.mChar.KoEvent();
											if (285209 - 53382 != 231828)
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
								if (77891 - 428146 != -350254)
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

	// Token: 0x0600535F RID: 21343 RVA: 0x00A29098 File Offset: 0x00A27298
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (250912 - 296743 != -45830)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (273997 - 515162 != -241164)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (90454 - 506357 != -415902 && 131435 - 445122 != -313686)
				{
					if (ActionName == "RPC_nAttack")
					{
						if (214167 - 306599 == -92431)
						{
							continue;
						}
						v = 1;
						if (39008 - 362067 == -323058)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nAttack_fire")
					{
						if (208211 - 516167 != -307956)
						{
							continue;
						}
						v = 2;
						if (292749 - 98668 != 194081)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_cAttack")
					{
						if (58248 - 170001 == -111752)
						{
							continue;
						}
						v = 11;
						if (221733 - 97815 != 123918)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_cAttack_hit")
					{
						if (516 - 35800 == -35283)
						{
							continue;
						}
						v = -11;
						if (82078 - 453939 != -371861)
						{
							continue;
						}
					}
					else
					{
						Debug.Log("Unknown Action Name:" + ActionName);
						if (224790 - 399845 != -175055)
						{
							continue;
						}
					}
					int v2 = Mathf.RoundToInt(nPos.x * (float)50);
					if (150572 - 409965 != -259392)
					{
						int v3 = Mathf.RoundToInt(nPos.y * (float)50);
						if (143500 - 45584 == 97916)
						{
							int v4 = Mathf.RoundToInt(nPos.z * (float)50);
							if (132879 - 399036 == -266157)
							{
								int v5 = Mathf.RoundToInt((float)200 * tPos.x);
								if (99057 - 135975 != -36917)
								{
									int v6 = Mathf.RoundToInt((float)200 * tPos.y);
									if (229702 - 400788 == -171086)
									{
										int v7 = Mathf.RoundToInt((float)200 * tPos.z);
										if (151692 - 221592 == -69900)
										{
											Hashtable hashtable = new Hashtable();
											if (95451 - 217090 == -121639)
											{
												hashtable.Add(120, PhotonClient.cInt16(v));
												if (194625 - 251186 != -56560)
												{
													hashtable.Add(122, PhotonClient.cInt16(v2));
													if (118332 - 241678 != -123345)
													{
														hashtable.Add(123, PhotonClient.cInt16(v3));
														if (231113 - 266908 != -35794)
														{
															hashtable.Add(124, PhotonClient.cInt16(v4));
															if (249009 - 403462 == -154453)
															{
																hashtable.Add(126, PhotonClient.cInt16(v5));
																if (187636 - 346140 == -158504)
																{
																	hashtable.Add(127, PhotonClient.cInt16(v6));
																	if (153162 - 482818 != -329655)
																	{
																		hashtable.Add(128, PhotonClient.cInt16(v7));
																		if (165744 - 357086 != -191341)
																		{
																			hashtable.Add(129, PhotonClient.cInt16(tID));
																			if (193754 - 193346 != 409)
																			{
																				PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																				if (206521 - 386333 != -179811)
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

	// Token: 0x06005360 RID: 21344 RVA: 0x00A295B0 File Offset: 0x00A277B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (147753 - 210389 != -62636)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (163889 - 216823 == -52934)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (8621 - 219860 != -211238)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (14739 - 489485 != -474745)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (41400 - 415019 == -373619)
						{
							int num3 = num;
							if (181397 - 56722 == 124675)
							{
								if (num3 == 1)
								{
									if (201438 - 241865 != -40426)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (217948 - 124714 == 93234)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (204251 - 476200 == -271949)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 2)
								{
									if (34715 - 544673 != -509957)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (197128 - 171772 != 25357)
										{
											this.RPC_nAttack_fire(vector, vector2, num2);
											if (262092 - 480116 == -218024)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (22864 - 588835 == -565971)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (150558 - 313656 == -163098)
										{
											this.StartCoroutine_Auto(this.RPC_cAttack(vector, vector2, num2));
											if (266544 - 403660 == -137116)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -11)
								{
									if (102857 - 97857 == 5000)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (80241 - 133626 != -53384)
										{
											this.RPC_cAttack_hit(vector, vector2, num2);
											if (132338 - 593474 != -461135)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (207032 - 404571 == -197539)
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

	// Token: 0x06005361 RID: 21345 RVA: 0x00A29934 File Offset: 0x00A27B34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (63532 - 9026 != 54506)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (291755 - 281315 == 10440)
			{
				float runSpeed = this.mChar.runSpeed;
				if (210024 - 570790 == -360766)
				{
					Vector3 a = default(Vector3);
					if (51327 - 213986 == -162659)
					{
						Vector3 vector = Vector3.zero;
						if (218775 - 574711 == -355936)
						{
							float num2 = (float)0;
							if (107336 - 230293 == -122957)
							{
								if (this.mChar.isMine)
								{
									if (254436 - 155300 == 99137)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (230036 - 558106 == -328069)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (24889 - 421459 != -396570)
										{
											continue;
										}
										a.y = (float)0;
										if (148625 - 300729 == -152103)
										{
											continue;
										}
										a = a.normalized;
										if (102143 - 428069 != -325926)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (55372 - 118441 == -63068)
										{
											continue;
										}
										vector = vector.normalized;
										if (114400 - 179517 != -65117)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (192303 - 142488 == 49816)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (134599 - 69650 != 64949)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (77340 - 557702 == -480361)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (42362 - 371809 == -329446)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (232586 - 494514 != -261928)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (135369 - 296848 == -161478)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (260467 - 421549 == -161081)
														{
															continue;
														}
														this.animation.Play("run");
														if (255207 - 57633 != 197574)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (292979 - 50646 != 242334)
														{
															goto IL_92;
														}
														continue;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (26200 - 596220 != -570020)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (44972 - 554991 == -510018)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (255468 - 593016 == -337547)
											{
												continue;
											}
											num = (float)0;
											if (250429 - 571563 == -321133)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (270097 - 402084 == -131986)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (199648 - 337767 != -138119)
										{
											continue;
										}
									}
									IL_92:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (295268 - 446424 == -151155)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (272672 - 378037 != -105365)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (297247 - 237815 != 59432)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (140661 - 413834 != -273173)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (24336 - 193834 == -169497)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (296092 - 475118 == -179025)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (280089 - 154542 == 125548)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (61993 - 469039 == -407045)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (54880 - 111263 == -56382)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (245259 - 206772 == 38488)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (215252 - 95204 != 120048)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (130048 - 407626 != -277578)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (280063 - 174549 == 105515)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (30731 - 42970 != -12239)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (137627 - 388498 != -250871)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (210527 - 184805 == 25723)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (77807 - 455985 != -378178)
												{
													continue;
												}
												num = (float)0;
												if (222902 - 504484 == -281581)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (54195 - 145367 == -91171)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (217066 - 258315 == -41248)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (16145 - 232391 == -216245)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (179583 - 380547 != -200964)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (218873 - 503797 != -284924)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (156125 - 43976 != 112149)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (223421 - 551379 == -327957)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (118472 - 525295 != -406823)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (17308 - 410721 == -393412)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (233932 - 527395 == -293462)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (296595 - 450328 != -153733)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (287592 - 474248 == -186655)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (54485 - 354250 == -299764)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (174276 - 170049 != 4227)
											{
												continue;
											}
											num = (float)0;
											if (71731 - 40269 != 31462)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (72743 - 406335 == -333591)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (137675 - 492714 != -355039)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (242655 - 243712 != -1057)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (228771 - 327199 == -98427)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (75246 - 140747 != -65500)
								{
									this.mChar.moveSpeed = num;
									if (96377 - 441245 != -344867)
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

	// Token: 0x06005362 RID: 21346 RVA: 0x00A2A498 File Offset: 0x00A28698
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (51164 - 156893 != -105728)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (42868 - 164706 != -121837)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (142207 - 581562 == -439355)
				{
					Vector3 vector = a - this.transform.position;
					if (279784 - 213936 == 65848)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (56675 - 77826 == -21151)
						{
							CharacterControl characterControl = null;
							if (25248 - 455111 != -429862 && 81373 - 28125 != 53249)
							{
								if (gameObject)
								{
									if (242353 - 21175 != 221178)
									{
										continue;
									}
									characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (190061 - 63054 == 127008)
									{
										continue;
									}
								}
								if (characterControl)
								{
									if (111388 - 303678 == -192289)
									{
										continue;
									}
									int actorNr = characterControl.ActorNr;
									if (214410 - 303291 != -88881)
									{
										continue;
									}
								}
								if (!(this.mChar.actionState == "standby"))
								{
									if (148353 - 294917 != -146564)
									{
										continue;
									}
									if (!(this.mChar.actionState == "run"))
									{
										break;
									}
									if (276256 - 203270 != 72986)
									{
										continue;
									}
								}
								if (Game.mGameType < 4)
								{
									if (211883 - 427181 == -215298)
									{
										Camera.main.SendMessage("newGameMessage", "Cannot do normal attack here");
										if (235666 - 18802 != 216865)
										{
											break;
										}
									}
								}
								else if (this.mChar.isTimeOut("nAttack") != (float)0)
								{
									if (95638 - 169853 == -74215)
									{
										Camera.main.SendMessage("newGameMessage", "Normal attack time out");
										if (290510 - 157005 != 133506)
										{
											break;
										}
									}
								}
								else
								{
									if (gameObject)
									{
										if (3657 - 478923 != -475266)
										{
											continue;
										}
										if (this.gameObject != gameObject)
										{
											if (298464 - 27726 == 270739)
											{
												continue;
											}
											if (PlayerPrefs.GetInt("autoAimSkill", 1) != 0)
											{
												if (250457 - 408823 == -158365)
												{
													continue;
												}
												Vector3 vector2 = gameObject.transform.position - this.transform.position;
												if (60496 - 105489 == -44992)
												{
													continue;
												}
												vector = vector2.normalized;
												if (31923 - 500745 != -468822)
												{
													continue;
												}
											}
										}
									}
									this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, vector, 0));
									if (39891 - 505298 == -465407)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (166011 - 588127 != -422115)
										{
											this.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
											if (59195 - 566427 == -507232)
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

	// Token: 0x06005363 RID: 21347 RVA: 0x00A2A8F0 File Offset: 0x00A28AF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (145426 - 591553 != -446126)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (15167 - 427835 != -412667)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (96219 - 498857 != -402637)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (103371 - 491617 != -388245)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (137006 - 305078 == -168072)
						{
							CharacterControl characterControl = null;
							if (221047 - 306728 != -85680 && 3500 - 438855 != -435354)
							{
								if (gameObject)
								{
									if (102159 - 413307 != -311148)
									{
										continue;
									}
									characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (195798 - 358790 != -162992)
									{
										continue;
									}
								}
								if (characterControl)
								{
									if (140534 - 277467 != -136933)
									{
										continue;
									}
									int actorNr = characterControl.ActorNr;
									if (207609 - 387395 == -179785)
									{
										continue;
									}
								}
								if (!(this.mChar.actionState == "standby"))
								{
									if (139458 - 335319 != -195861)
									{
										continue;
									}
									if (!(this.mChar.actionState == "run"))
									{
										break;
									}
									if (170937 - 558286 == -387348)
									{
										continue;
									}
								}
								if (Game.mGameType < 4)
								{
									if (66358 - 165867 == -99509)
									{
										Camera.main.SendMessage("newGameMessage", "Cannot do charge attack here");
										if (215853 - 300919 != -85065)
										{
											break;
										}
									}
								}
								else if (this.mChar.isTimeOut("cAttack") != (float)0)
								{
									if (295398 - 475026 == -179628)
									{
										Camera.main.SendMessage("newGameMessage", "Charge attack time out");
										if (280760 - 312888 != -32127)
										{
											break;
										}
									}
								}
								else
								{
									if (gameObject)
									{
										if (88816 - 30719 == 58098)
										{
											continue;
										}
										if (this.gameObject != gameObject)
										{
											if (145908 - 235063 == -89154)
											{
												continue;
											}
											if (PlayerPrefs.GetInt("autoAimSkill", 1) != 0)
											{
												if (257216 - 423511 != -166295)
												{
													continue;
												}
												Vector3 vector2 = gameObject.transform.position - this.transform.position;
												if (135881 - 165446 != -29565)
												{
													continue;
												}
												vector = vector2.normalized;
												if (226763 - 111140 == 115624)
												{
													continue;
												}
											}
										}
									}
									this.StartCoroutine_Auto(this.RPC_cAttack(this.transform.position, vector, 0));
									if (83297 - 332681 == -249384)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (79347 - 379445 == -300098)
										{
											this.ActionEvent("RPC_cAttack", this.transform.position, vector, 0);
											if (266132 - 35372 == 230760)
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

	// Token: 0x06005364 RID: 21348 RVA: 0x00A2AD4C File Offset: 0x00A28F4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06005365 RID: 21349 RVA: 0x00A2AD50 File Offset: 0x00A28F50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new DeadBullMount.$RPC_nAttack$34206(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06005366 RID: 21350 RVA: 0x00A2AD60 File Offset: 0x00A28F60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_fire(Vector3 firePos, Vector3 fireDir, int tID)
	{
		if (130257 - 192292 != -62035)
		{
		}
		for (;;)
		{
			if (this.nAttack_fire)
			{
				if (106770 - 32332 == 74438)
				{
					Quaternion rotation = Quaternion.LookRotation(fireDir);
					if (253515 - 225316 != 28200)
					{
						GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(this.nAttack_fire, firePos, rotation);
						if (242472 - 440794 != -198321)
						{
							if (!gameObject)
							{
								break;
							}
							if (22514 - 363213 == -340699)
							{
								ProjectileControl projectileControl = (ProjectileControl)gameObject.GetComponent(typeof(ProjectileControl));
								if (52476 - 330982 == -278506)
								{
									projectileControl.Init(this.mChar.ActorNr);
									if (197990 - 435512 == -237522)
									{
										projectileControl.life = (float)2;
										if (244725 - 538687 == -293962)
										{
											DeadBullMount_nAttack deadBullMount_nAttack = (DeadBullMount_nAttack)gameObject.GetComponent(typeof(DeadBullMount_nAttack));
											if (74656 - 165454 == -90798)
											{
												if (!deadBullMount_nAttack)
												{
													break;
												}
												if (93777 - 473386 != -379608)
												{
													deadBullMount_nAttack.Init(this.gameObject);
													if (264850 - 305421 != -40570)
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
			else
			{
				Debug.LogError("Cannot find nAttack projectile");
				if (202401 - 163475 == 38926)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005367 RID: 21351 RVA: 0x00A2AF58 File Offset: 0x00A29158
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_cAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new DeadBullMount.$RPC_cAttack$34213(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06005368 RID: 21352 RVA: 0x00A2AF68 File Offset: 0x00A29168
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_cAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (130638 - 101430 != 29209)
		{
		}
		for (;;)
		{
			if (this.cAttack_hit)
			{
				if (179452 - 85053 != 94400)
				{
					UnityEngine.Object.Instantiate(this.cAttack_hit, hitPos, this.transform.rotation);
					if (278553 - 236750 != 41804)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Missing cAttack_hit effect");
				if (155873 - 564495 != -408621)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005369 RID: 21353 RVA: 0x00A2B028 File Offset: 0x00A29228
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_ko(UnityScript.Lang.Array nArray)
	{
		if (77097 - 144620 != -67523)
		{
		}
		while (!(this.mChar.actionState == "ko"))
		{
			if (271192 - 578749 != -307556)
			{
				if (this.mChar.actionState == "dead")
				{
					if (108761 - 557208 != -448446)
					{
						break;
					}
				}
				else
				{
					Vector3 vector = (Vector3)nArray[0];
					if (119576 - 153063 != -33486)
					{
						Vector3 b = (Vector3)nArray[1];
						if (24972 - 141890 != -116917)
						{
							this.transform.position = vector;
							if (153387 - 557237 != -403849)
							{
								this.transform.LookAt(vector + b);
								if (39337 - 307867 == -268530)
								{
									this.mChar.actionState = "ko";
									if (23185 - 434486 != -411300)
									{
										this.mChar.actionTime = Time.time;
										if (222105 - 548168 == -326063)
										{
											this.mChar.myCommand = "none";
											if (82380 - 466277 != -383896)
											{
												this.mChar.vMovement = Vector3.zero;
												if (165735 - 395443 != -229707)
												{
													this.mChar.moveSpeed = (float)0;
													if (94283 - 427715 == -333432)
													{
														if (this.ko_ring)
														{
															if (97185 - 389943 != -292758)
															{
																continue;
															}
															UnityEngine.Object.Instantiate(this.ko_ring, this.transform.position, this.transform.rotation);
															if (222563 - 363801 != -141238)
															{
																continue;
															}
														}
														else
														{
															Debug.LogError("Cannot find ko_ring effect");
															if (275593 - 25939 == 249655)
															{
																continue;
															}
														}
														this.mChar.removeStatus("mount");
														if (24942 - 369607 != -344664)
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

	// Token: 0x0600536A RID: 21354 RVA: 0x00A2B300 File Offset: 0x00A29500
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_dead(UnityScript.Lang.Array nArray)
	{
		if (195491 - 208897 != -13405)
		{
		}
		for (;;)
		{
			if (this.mChar.actionState == "dead")
			{
				if (137073 - 215929 == -78856)
				{
					break;
				}
			}
			else
			{
				Vector3 vector = (Vector3)nArray[0];
				if (188349 - 50491 != 137859)
				{
					Vector3 b = (Vector3)nArray[1];
					if (179253 - 569134 != -389880)
					{
						this.transform.position = vector;
						if (40779 - 23310 == 17469)
						{
							this.transform.LookAt(vector + b);
							if (224298 - 598106 != -373807)
							{
								this.mChar.actionState = "dead";
								if (152717 - 25151 != 127567)
								{
									this.mChar.actionTime = Time.time;
									if (81378 - 174212 != -92833)
									{
										this.mChar.myCommand = "none";
										if (218977 - 274282 == -55305)
										{
											this.mChar.vMovement = Vector3.zero;
											if (286440 - 405643 == -119203)
											{
												this.mChar.moveSpeed = (float)0;
												if (207191 - 100593 == 106598)
												{
													if (!this.ko_ring)
													{
														if (81245 - 356341 == -275095)
														{
															continue;
														}
														this.ko_ring = (GameObject)Resources.Load("GameAssets/Characters/Mounts/LionBugMount/Effects/ko_ring", typeof(GameObject));
														if (252667 - 114264 != 138403)
														{
															continue;
														}
													}
													if (this.ko_ring)
													{
														if (275074 - 531490 != -256416)
														{
															continue;
														}
														UnityEngine.Object.Instantiate(this.ko_ring, this.transform.position, this.transform.rotation);
														if (240538 - 599688 != -359150)
														{
															continue;
														}
													}
													else
													{
														Debug.LogError("Cannot find ko_ring effect");
														if (231252 - 64520 == 166733)
														{
															continue;
														}
													}
													this.mChar.removeStatus("mount");
													if (218656 - 489755 != -271098)
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

	// Token: 0x0600536B RID: 21355 RVA: 0x00A2B608 File Offset: 0x00A29808
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600536C RID: 21356 RVA: 0x00A2B60C File Offset: 0x00A2980C
	internal static bool sC0Xnx5hqEKXYk9Rh5FF()
	{
		return true;
	}

	// Token: 0x0600536D RID: 21357 RVA: 0x00A2B610 File Offset: 0x00A29810
	internal static bool V1E2Ak5h7WKffcCLOZoO()
	{
		return false;
	}

	// Token: 0x04005C9D RID: 23709
	public CharacterControl mChar;

	// Token: 0x04005C9E RID: 23710
	public CharacterControl mOwnerChar;

	// Token: 0x04005C9F RID: 23711
	public AudioClip footStep_run;

	// Token: 0x04005CA0 RID: 23712
	public GameObject nAttack_ring;

	// Token: 0x04005CA1 RID: 23713
	public GameObject nAttack_fire;

	// Token: 0x04005CA2 RID: 23714
	public GameObject cAttack_ring;

	// Token: 0x04005CA3 RID: 23715
	public GameObject cAttack_hit;

	// Token: 0x04005CA4 RID: 23716
	public GameObject ko_ring;

	// Token: 0x02000E62 RID: 3682
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$34206 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600536E RID: 21358 RVA: 0x00A2B614 File Offset: 0x00A29814
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$34206(Vector3 mPos, Vector3 tDir, DeadBullMount self_)
		{
			if (146732 - 245142 != -98410)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (75179 - 336764 == -261585)
				{
					base..ctor();
					if (91897 - 130888 != -38990)
					{
						this.$mPos$34210 = mPos;
						if (189855 - 429467 == -239612)
						{
							this.$tDir$34211 = tDir;
							if (220018 - 29153 != 190866)
							{
								this.$self_$34212 = self_;
								if (140319 - 112993 != 27327)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600536F RID: 21359 RVA: 0x00A2B6F0 File Offset: 0x00A298F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new DeadBullMount.$RPC_nAttack$34206.$(this.$mPos$34210, this.$tDir$34211, this.$self_$34212);
		}

		// Token: 0x06005370 RID: 21360 RVA: 0x00A2B70C File Offset: 0x00A2990C
		internal static bool aCVX6u5hPUIlLUW8Xfu9()
		{
			return true;
		}

		// Token: 0x06005371 RID: 21361 RVA: 0x00A2B710 File Offset: 0x00A29910
		internal static bool lcJfCm5h02nh5i0LDGO9()
		{
			return false;
		}

		// Token: 0x04005CA5 RID: 23717
		internal Vector3 $mPos$34210;

		// Token: 0x04005CA6 RID: 23718
		internal Vector3 $tDir$34211;

		// Token: 0x04005CA7 RID: 23719
		internal DeadBullMount $self_$34212;

		// Token: 0x02000E63 RID: 3683
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005372 RID: 21362 RVA: 0x00A2B714 File Offset: 0x00A29914
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, DeadBullMount self_)
			{
				if (243477 - 104712 != 138765)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (35519 - 574089 != -538569)
					{
						base..ctor();
						if (203510 - 469099 == -265589)
						{
							this.$mPos$34207 = mPos;
							if (71785 - 517526 == -445741)
							{
								this.$tDir$34208 = tDir;
								if (251551 - 539382 != -287830)
								{
									this.$self_$34209 = self_;
									if (14144 - 358889 != -344744)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06005373 RID: 21363 RVA: 0x00A2B7F0 File Offset: 0x00A299F0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (23806 - 166930 != -143123)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_91B;
					case 2:
						if (this.$self_$34209.mChar.actionState != "attack")
						{
							if (266093 - 324957 != -58864)
							{
								continue;
							}
							if (this.$self_$34209.mChar.myCommand != "nAttack")
							{
								if (103869 - 140872 != -37003)
								{
									continue;
								}
								goto IL_171;
							}
						}
						this.$self_$34209.mChar.moveSpeed = (float)1;
						if (277305 - 375871 != -98566)
						{
							continue;
						}
						if (!this.$self_$34209.mChar.isMine)
						{
							goto IL_122;
						}
						if (272957 - 55977 == 216981)
						{
							continue;
						}
						this.$self_$34209.RPC_nAttack_fire(this.$self_$34209.transform.position + this.$self_$34209.transform.TransformDirection(-1.5f, 0.2f, 0.5f), this.$self_$34209.transform.forward, 0);
						if (116047 - 562375 == -446327)
						{
							continue;
						}
						this.$self_$34209.ActionEvent("RPC_nAttack_fire", this.$self_$34209.transform.position + this.$self_$34209.transform.TransformDirection(-1.5f, 0.2f, 0.5f), this.$self_$34209.transform.forward, 0);
						if (256001 - 300842 != -44841)
						{
							continue;
						}
						goto IL_122;
					case 3:
						if (this.$self_$34209.mChar.actionState != "attack")
						{
							if (165700 - 572246 != -406546)
							{
								continue;
							}
							if (this.$self_$34209.mChar.myCommand != "nAttack")
							{
								if (179528 - 136353 != 43175)
								{
									continue;
								}
								goto IL_57E;
							}
						}
						if (!this.$self_$34209.mChar.isMine)
						{
							goto IL_2E1;
						}
						if (62107 - 132846 != -70739)
						{
							continue;
						}
						this.$self_$34209.RPC_nAttack_fire(this.$self_$34209.transform.position + this.$self_$34209.transform.TransformDirection(1.5f, 0.2f, 0.5f), this.$self_$34209.transform.forward, 0);
						if (211787 - 290737 == -78949)
						{
							continue;
						}
						this.$self_$34209.ActionEvent("RPC_nAttack_fire", this.$self_$34209.transform.position + this.$self_$34209.transform.TransformDirection(1.5f, 0.2f, 0.5f), this.$self_$34209.transform.forward, 0);
						if (200481 - 489481 != -288999)
						{
							goto Block_36;
						}
						continue;
					case 4:
						if (this.$self_$34209.mChar.actionState != "attack")
						{
							if (97666 - 239807 != -142141)
							{
								continue;
							}
							if (this.$self_$34209.mChar.myCommand != "nAttack")
							{
								if (114252 - 337282 != -223029)
								{
									goto Block_24;
								}
								continue;
							}
						}
						this.$self_$34209.mChar.moveSpeed = (float)0;
						if (186080 - 19626 != 166455)
						{
							goto Block_12;
						}
						continue;
					case 5:
						if (this.$self_$34209.mChar.actionState == "attack")
						{
							if (29194 - 468968 != -439774)
							{
								continue;
							}
							if (this.$self_$34209.mChar.myCommand == "nAttack")
							{
								if (180499 - 483081 == -302581)
								{
									continue;
								}
								this.$self_$34209.mChar.actionState = "standby";
								if (12561 - 386187 != -373626)
								{
									continue;
								}
								this.$self_$34209.mChar.actionTime = Time.time;
								if (235712 - 6905 != 228807)
								{
									continue;
								}
								this.$self_$34209.mChar.myCommand = "none";
								if (84828 - 378039 != -293211)
								{
									continue;
								}
								if (!this.$self_$34209.mChar.isMine)
								{
									if (1573 - 190226 == -188652)
									{
										continue;
									}
									this.$self_$34209.mChar.nPosition = this.$self_$34209.transform.position;
									if (215034 - 18927 != 196107)
									{
										continue;
									}
									this.$self_$34209.mChar.oPosition = this.$self_$34209.transform.position;
									if (55110 - 228392 == -173281)
									{
										continue;
									}
									this.$self_$34209.mChar.nDirection = this.$self_$34209.transform.forward;
									if (92777 - 207957 != -115180)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (176158 - 313017 != -136859)
						{
							continue;
						}
						goto IL_91B;
					default:
						if (167889 - 72940 != 94949)
						{
							continue;
						}
						break;
					}
					this.$self_$34209.mChar.actionState = "attack";
					if (65663 - 394533 == -328870)
					{
						this.$self_$34209.mChar.actionTime = Time.time;
						if (199926 - 490644 != -290717)
						{
							this.$self_$34209.mChar.myCommand = "nAttack";
							if (108815 - 81244 == 27571)
							{
								this.$self_$34209.mChar.addTimeOut("nAttack", this.$self_$34209.mChar.agiAdjust((float)4));
								if (197527 - 105184 != 92344)
								{
									this.$self_$34209.transform.position = this.$mPos$34207;
									if (133896 - 410419 != -276522)
									{
										this.$self_$34209.transform.LookAt(this.$mPos$34207 + global::Math.vFlat(this.$tDir$34208));
										if (110207 - 140729 == -30522)
										{
											this.$self_$34209.animation.CrossFade("nAttack");
											if (15364 - 24470 != -9105)
											{
												this.$self_$34209.animation.wrapMode = WrapMode.Once;
												if (234991 - 90644 != 144348)
												{
													this.$self_$34209.mChar.vMovement = this.$self_$34209.transform.forward;
													if (24123 - 550614 == -526491)
													{
														this.$self_$34209.mChar.moveSpeed = (float)0;
														if (250043 - 261286 == -11243)
														{
															if (this.$self_$34209.nAttack_ring)
															{
																if (207093 - 346443 == -139350)
																{
																	this.$self_$34209.mChar.createEffect(this.$self_$34209.nAttack_ring, this.$self_$34209.transform.position, Quaternion.identity);
																	if (8737 - 273478 != -264740)
																	{
																		goto Block_30;
																	}
																}
															}
															else
															{
																Debug.LogError("Missing nAttack_ring effect");
																if (118806 - 466556 != -347749)
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
					}
				}
				IL_122:
				return this.Yield(3, new WaitForSeconds(0.3f));
				IL_171:
				goto IL_91B;
				Block_12:
				return this.Yield(5, new WaitForSeconds(0.2f));
				IL_2E1:
				return this.Yield(4, new WaitForSeconds(0.2f));
				Block_24:
				goto IL_91B;
				Block_30:
				Block_31:
				goto IL_68A;
				IL_57E:
				goto IL_91B;
				Block_36:
				goto IL_2E1;
				IL_68A:
				return this.Yield(2, new WaitForSeconds(0.6f));
				IL_91B:
				return false;
			}

			// Token: 0x06005374 RID: 21364 RVA: 0x00A2C12C File Offset: 0x00A2A32C
			internal static bool aOJWDU5hb1NcE0HD3QAT()
			{
				return true;
			}

			// Token: 0x06005375 RID: 21365 RVA: 0x00A2C130 File Offset: 0x00A2A330
			internal static bool AUjPKd5hu19LxAC3obvy()
			{
				return false;
			}

			// Token: 0x04005CA8 RID: 23720
			internal Vector3 $mPos$34207;

			// Token: 0x04005CA9 RID: 23721
			internal Vector3 $tDir$34208;

			// Token: 0x04005CAA RID: 23722
			internal DeadBullMount $self_$34209;
		}
	}

	// Token: 0x02000E64 RID: 3684
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_cAttack$34213 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005376 RID: 21366 RVA: 0x00A2C134 File Offset: 0x00A2A334
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_cAttack$34213(Vector3 mPos, Vector3 tDir, DeadBullMount self_)
		{
			if (271647 - 72393 != 199254)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (213549 - 83330 == 130219)
				{
					base..ctor();
					if (109561 - 147910 != -38348)
					{
						this.$mPos$34223 = mPos;
						if (30460 - 424521 != -394060)
						{
							this.$tDir$34224 = tDir;
							if (109521 - 422196 != -312674)
							{
								this.$self_$34225 = self_;
								if (106089 - 403765 != -297675)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06005377 RID: 21367 RVA: 0x00A2C210 File Offset: 0x00A2A410
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new DeadBullMount.$RPC_cAttack$34213.$(this.$mPos$34223, this.$tDir$34224, this.$self_$34225);
		}

		// Token: 0x06005378 RID: 21368 RVA: 0x00A2C22C File Offset: 0x00A2A42C
		internal static bool zcJJwP5hI2NA4CP3IXBX()
		{
			return true;
		}

		// Token: 0x06005379 RID: 21369 RVA: 0x00A2C230 File Offset: 0x00A2A430
		internal static bool d41SW95hBtBVmeEDVISc()
		{
			return false;
		}

		// Token: 0x04005CAB RID: 23723
		internal Vector3 $mPos$34223;

		// Token: 0x04005CAC RID: 23724
		internal Vector3 $tDir$34224;

		// Token: 0x04005CAD RID: 23725
		internal DeadBullMount $self_$34225;

		// Token: 0x02000E65 RID: 3685
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600537A RID: 21370 RVA: 0x00A2C234 File Offset: 0x00A2A434
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, DeadBullMount self_)
			{
				if (185568 - 58271 != 127297)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (234483 - 316119 != -81635)
					{
						base..ctor();
						if (85255 - 141679 != -56423)
						{
							this.$mPos$34220 = mPos;
							if (110001 - 50928 == 59073)
							{
								this.$tDir$34221 = tDir;
								if (71467 - 342170 == -270703)
								{
									this.$self_$34222 = self_;
									if (182467 - 161369 != 21099)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x0600537B RID: 21371 RVA: 0x00A2C310 File Offset: 0x00A2A510
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (235527 - 829 != 234698)
				{
				}
				for (;;)
				{
					IL_8A6:
					switch (this._state)
					{
					case 0:
						goto IL_95F;
					case 1:
						goto IL_A1B;
					case 2:
						if (this.$self_$34222.mChar.actionState != "attack")
						{
							if (34219 - 175497 == -141277)
							{
								continue;
							}
							if (this.$self_$34222.mChar.myCommand != "cAttack")
							{
								if (13563 - 329202 != -315638)
								{
									goto Block_40;
								}
								continue;
							}
						}
						this.$self_$34222.mChar.moveSpeed = (float)4;
						if (257812 - 164754 != 93058)
						{
							continue;
						}
						this.$i$34214 = 0;
						if (96459 - 280760 == -184300)
						{
							continue;
						}
						break;
					case 3:
						if (this.$self_$34222.mChar.actionState != "attack")
						{
							if (270633 - 474017 == -203383)
							{
								continue;
							}
							if (this.$self_$34222.mChar.myCommand != "cAttack")
							{
								if (209577 - 489189 != -279612)
								{
									continue;
								}
								goto IL_46F;
							}
						}
						this.$self_$34222.mChar.moveSpeed = (float)6;
						if (228693 - 465939 != -237246)
						{
							continue;
						}
						if (this.$self_$34222.mChar.isMine)
						{
							if (285546 - 17511 != 268035)
							{
								continue;
							}
							this.$hitLayer$34215 = 130816 - (1 << this.$self_$34222.gameObject.layer);
							if (171841 - 122661 != 49180)
							{
								continue;
							}
							this.$hitList$34216 = Damage.FindRecTarget(this.$self_$34222.transform.position, this.$self_$34222.transform.forward, (float)2, (float)2, (float)2, (float)2, this.$hitLayer$34215);
							if (257135 - 196529 != 60606)
							{
								continue;
							}
							this.$$iterator$10892$34219 = UnityRuntimeServices.GetEnumerator(this.$hitList$34216);
							if (240955 - 277649 != -36694)
							{
								continue;
							}
							while (this.$$iterator$10892$34219.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10892$34219.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$34217 = (GameObject)obj2;
								if (77532 - 236909 != -159377)
								{
									goto IL_8A6;
								}
								if (this.$self_$34222.mChar.hit(11, this.$hitObject$34217, (int)(0.5f * (float)this.$self_$34222.mChar.atk), 3, 0, 0.5f * this.$self_$34222.transform.forward) != 0)
								{
									if (72893 - 122852 != -49959)
									{
										goto IL_8A6;
									}
									this.$hitPos$34218 = this.$hitObject$34217.collider.ClosestPointOnBounds(this.$self_$34222.transform.position + 1.7f * Vector3.up);
									if (153395 - 79909 != 73486)
									{
										goto IL_8A6;
									}
									UnityRuntimeServices.Update(this.$$iterator$10892$34219, this.$hitObject$34217);
									if (108581 - 566341 == -457759)
									{
										goto IL_8A6;
									}
									this.$self_$34222.RPC_cAttack_hit(this.$hitPos$34218, this.$self_$34222.transform.forward, 0);
									if (30930 - 284714 == -253783)
									{
										goto IL_8A6;
									}
									this.$self_$34222.ActionEvent("RPC_cAttack_hit", this.$hitPos$34218, this.$self_$34222.transform.forward, 0);
									if (130133 - 192885 != -62752)
									{
										goto IL_8A6;
									}
									this.$self_$34222.mChar.sp = this.$self_$34222.mChar.sp + 1;
									if (202732 - 384306 != -181574)
									{
										goto IL_8A6;
									}
								}
							}
							if (59194 - 236627 != -177433)
							{
								continue;
							}
						}
						this.$i$34214++;
						if (113212 - 177963 == -64750)
						{
							continue;
						}
						break;
					case 4:
						if (this.$self_$34222.mChar.actionState == "attack")
						{
							if (273303 - 8490 != 264813)
							{
								continue;
							}
							if (this.$self_$34222.mChar.myCommand == "cAttack")
							{
								if (260948 - 318757 == -57808)
								{
									continue;
								}
								this.$self_$34222.mChar.actionState = "standby";
								if (184286 - 99737 == 84550)
								{
									continue;
								}
								this.$self_$34222.mChar.actionTime = Time.time;
								if (264079 - 268922 != -4843)
								{
									continue;
								}
								this.$self_$34222.mChar.myCommand = "none";
								if (134635 - 197367 == -62731)
								{
									continue;
								}
								if (!this.$self_$34222.mChar.isMine)
								{
									if (67520 - 204346 != -136826)
									{
										continue;
									}
									this.$self_$34222.mChar.nPosition = this.$self_$34222.transform.position;
									if (274436 - 141813 != 132623)
									{
										continue;
									}
									this.$self_$34222.mChar.oPosition = this.$self_$34222.transform.position;
									if (89270 - 511729 != -422459)
									{
										continue;
									}
									this.$self_$34222.mChar.nDirection = this.$self_$34222.transform.forward;
									if (34425 - 141133 != -106708)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (299988 - 527270 != -227281)
						{
							goto Block_48;
						}
						continue;
					default:
						if (43462 - 119989 != -76526)
						{
							goto IL_95F;
						}
						continue;
					}
					if (this.$i$34214 < 4)
					{
						break;
					}
					if (14416 - 414691 != -400275)
					{
						continue;
					}
					this.$self_$34222.mChar.moveSpeed = (float)0;
					if (120050 - 8622 != 111428)
					{
						continue;
					}
					goto IL_554;
					IL_95F:
					this.$self_$34222.mChar.actionState = "attack";
					if (72800 - 411075 == -338275)
					{
						this.$self_$34222.mChar.actionTime = Time.time;
						if (82825 - 312079 != -229253)
						{
							this.$self_$34222.mChar.myCommand = "cAttack";
							if (153111 - 394983 != -241871)
							{
								this.$self_$34222.mChar.addTimeOut("cAttack", this.$self_$34222.mChar.agiAdjust((float)6));
								if (75616 - 598257 != -522640)
								{
									this.$self_$34222.transform.position = this.$mPos$34220;
									if (23661 - 229292 != -205630)
									{
										this.$self_$34222.transform.LookAt(this.$mPos$34220 + global::Math.vFlat(this.$tDir$34221));
										if (57829 - 379770 == -321941)
										{
											this.$self_$34222.animation.CrossFade("cAttack");
											if (170204 - 245196 != -74991)
											{
												this.$self_$34222.animation.wrapMode = WrapMode.Once;
												if (258183 - 378034 == -119851)
												{
													this.$self_$34222.mChar.vMovement = this.$self_$34222.transform.forward;
													if (270106 - 442478 != -172371)
													{
														this.$self_$34222.mChar.moveSpeed = (float)0;
														if (277958 - 540401 != -262442)
														{
															if (this.$self_$34222.cAttack_ring)
															{
																if (207654 - 497087 != -289432)
																{
																	this.$self_$34222.mChar.createEffect(this.$self_$34222.cAttack_ring, this.$self_$34222.transform.position, Quaternion.identity);
																	if (115154 - 162446 == -47292)
																	{
																		goto IL_65A;
																	}
																}
															}
															else
															{
																Debug.LogError("Missing cAttack_ring effect");
																if (63483 - 177047 != -113563)
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
					}
				}
				return this.Yield(3, new WaitForSeconds(0.1f));
				IL_46F:
				goto IL_A1B;
				IL_554:
				return this.Yield(4, new WaitForSeconds(0.1f));
				IL_65A:
				Block_37:
				goto IL_910;
				Block_40:
				Block_48:
				goto IL_A1B;
				IL_910:
				return this.Yield(2, new WaitForSeconds(0.3f));
				IL_A1B:
				return false;
			}

			// Token: 0x0600537C RID: 21372 RVA: 0x00A2CD4C File Offset: 0x00A2AF4C
			internal static bool JddWlj5heswSkS9yyueW()
			{
				return true;
			}

			// Token: 0x0600537D RID: 21373 RVA: 0x00A2CD50 File Offset: 0x00A2AF50
			internal static bool oRc78L5hrE0s9NFk1Wkw()
			{
				return false;
			}

			// Token: 0x04005CAE RID: 23726
			internal int $i$34214;

			// Token: 0x04005CAF RID: 23727
			internal int $hitLayer$34215;

			// Token: 0x04005CB0 RID: 23728
			internal UnityScript.Lang.Array $hitList$34216;

			// Token: 0x04005CB1 RID: 23729
			internal GameObject $hitObject$34217;

			// Token: 0x04005CB2 RID: 23730
			internal Vector3 $hitPos$34218;

			// Token: 0x04005CB3 RID: 23731
			internal IEnumerator $$iterator$10892$34219;

			// Token: 0x04005CB4 RID: 23732
			internal Vector3 $mPos$34220;

			// Token: 0x04005CB5 RID: 23733
			internal Vector3 $tDir$34221;

			// Token: 0x04005CB6 RID: 23734
			internal DeadBullMount $self_$34222;
		}
	}
}
