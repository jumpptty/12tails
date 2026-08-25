using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000F44 RID: 3908
[Serializable]
public class MoleTank : MonoBehaviour
{
	// Token: 0x060058B9 RID: 22713 RVA: 0x00AA7EB8 File Offset: 0x00AA60B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public MoleTank()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060058BA RID: 22714 RVA: 0x00AA7EC8 File Offset: 0x00AA60C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (150687 - 464129 != -313441)
		{
		}
		for (;;)
		{
			this.mTransform = this.transform;
			if (248226 - 531903 != -283676)
			{
				this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
				if (193197 - 581758 != -388560)
				{
					this.mChar.actionState = "standby";
					if (131495 - 116901 == 14594)
					{
						this.mChar.actionTime = Time.time;
						if (140029 - 398440 != -258410)
						{
							this.mChar.myCommand = "none";
							if (233969 - 220741 == 13228)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060058BB RID: 22715 RVA: 0x00AA7FDC File Offset: 0x00AA61DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (71691 - 234953 != -163262)
		{
		}
		do
		{
			if (Game.mGameType == 99)
			{
				if (218489 - 554532 != -336043)
				{
					continue;
				}
				this.mChar.isMine = true;
				if (161193 - 445505 == -284311)
				{
					continue;
				}
			}
			this.KqectiT15tC = this.transform.Find("MoleTank_tri");
		}
		while (280883 - 31815 != 249068);
	}

	// Token: 0x060058BC RID: 22716 RVA: 0x00AA8090 File Offset: 0x00AA6290
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onMount(CharacterControl nOwnerChar)
	{
		if (197480 - 274520 != -77040)
		{
		}
		for (;;)
		{
			this.mOwnerChar = nOwnerChar;
			if (271164 - 260261 != 10904)
			{
				this.mChar.atk = nOwnerChar.getNoDeltaStat(0);
				if (47800 - 546002 != -498201)
				{
					this.mChar.def = nOwnerChar.getNoDeltaStat(1) + 50;
					if (38885 - 209383 == -170498)
					{
						this.mChar.agi = nOwnerChar.getNoDeltaStat(2);
						if (267260 - 417847 != -150586)
						{
							this.mChar.vit = nOwnerChar.getNoDeltaStat(3) + 50;
							if (74561 - 213249 != -138687)
							{
								this.mChar.mag = nOwnerChar.getNoDeltaStat(4);
								if (50098 - 54764 == -4666)
								{
									this.mChar.cha = nOwnerChar.getNoDeltaStat(5);
									if (172088 - 435352 == -263264)
									{
										this.mChar.tal = nOwnerChar.getNoDeltaStat(6);
										if (180313 - 453664 != -273350)
										{
											this.mChar.lck = nOwnerChar.getNoDeltaStat(7);
											if (232307 - 409153 != -176845)
											{
												this.mChar.mhp = this.mChar.vit * 10;
												if (132815 - 196889 == -64074)
												{
													this.mChar.mmp = this.mChar.mag * 3;
													if (117465 - 438975 != -321509)
													{
														this.mChar.msp = Mathf.FloorToInt((float)this.mChar.tal * 0.2f) + 10;
														if (252359 - 202412 == 49947)
														{
															this.mChar.mko = Mathf.FloorToInt((float)(this.mChar.def / 3)) + 10;
															if (229252 - 490586 == -261334)
															{
																this.mChar.hp = Mathf.FloorToInt((float)this.mChar.mhp * (1f * (float)nOwnerChar.hp) / (float)nOwnerChar.mhp);
																if (64897 - 568659 != -503761)
																{
																	this.mChar.mp = Mathf.FloorToInt((float)this.mChar.mmp * (1f * (float)nOwnerChar.mp) / (float)nOwnerChar.mmp);
																	if (282625 - 486686 == -204061)
																	{
																		this.mChar.sp = Mathf.FloorToInt((float)this.mChar.msp * (1f * (float)nOwnerChar.sp) / (float)nOwnerChar.msp);
																		if (296235 - 258170 != 38066)
																		{
																			this.mChar.ko = Mathf.FloorToInt((float)this.mChar.mko * (1f * (float)nOwnerChar.ko) / (float)nOwnerChar.mko);
																			if (133530 - 450745 == -317215)
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

	// Token: 0x060058BD RID: 22717 RVA: 0x00AA8460 File Offset: 0x00AA6660
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (234577 - 190635 != 43943)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (37968 - 319299 != -281331)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (68677 - 94973 == -26295)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_29D;
					}
					if (249974 - 131319 == 118656)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (208392 - 57979 == 150414)
				{
					continue;
				}
			}
			IL_29D:
			if (this.mChar.hp > 0)
			{
				goto IL_3C3;
			}
			if (65828 - 52680 == 13149)
			{
				continue;
			}
			if (!(this.mChar.actionState != "dead"))
			{
				goto IL_3C3;
			}
			if (139761 - 103506 != 36255)
			{
				continue;
			}
			if (this.mChar.isMine)
			{
				if (200951 - 465761 != -264810)
				{
					continue;
				}
				this.RPC_dead(new UnityScript.Lang.Array(new object[]
				{
					this.transform.position,
					this.transform.forward
				}));
				if (187329 - 542626 != -355297)
				{
					continue;
				}
				if (PhotonClient.IsInitialized())
				{
					if (165708 - 460382 != -294674)
					{
						continue;
					}
					this.mChar.DeadEvent();
					if (23906 - 386400 == -362493)
					{
						continue;
					}
				}
			}
			else
			{
				this.mChar.hp = 1;
				if (6364 - 80513 == -74148)
				{
					continue;
				}
			}
			IL_545:
			if (!this.KqectiT15tC)
			{
				break;
			}
			if (204135 - 313637 != -109502)
			{
				continue;
			}
			if ((this.mChar.CFlags & CollisionFlags.Below) == CollisionFlags.None)
			{
				break;
			}
			if (92529 - 260568 != -168039)
			{
				continue;
			}
			if (this.IuJct8M432f < Time.time)
			{
				if (147552 - 356874 == -209321)
				{
					continue;
				}
				this.IuJct8M432f = Time.time + 0.1f;
				if (76978 - 276756 != -199778)
				{
					continue;
				}
				RaycastHit raycastHit = default(RaycastHit);
				if (180352 - 215212 != -34860)
				{
					continue;
				}
				if (Physics.Raycast(this.transform.position + Vector3.up, -Vector3.up, out raycastHit, 1.5f, 1))
				{
					if (246866 - 299023 != -52157)
					{
						continue;
					}
					this.ih4ct0n2B8t = Quaternion.LookRotation(Vector3.Cross(-this.transform.right, raycastHit.normal), raycastHit.normal);
					if (189998 - 127041 != 62957)
					{
						continue;
					}
				}
			}
			this.KqectiT15tC.rotation = Quaternion.Slerp(this.KqectiT15tC.rotation, this.ih4ct0n2B8t, (float)5 * Time.deltaTime);
			if (202714 - 2794 != 199920)
			{
				continue;
			}
			break;
			IL_3C3:
			if (this.mChar.hp <= 0)
			{
				goto IL_545;
			}
			if (205302 - 510789 != -305486)
			{
				if (this.mChar.ko > 0)
				{
					goto IL_545;
				}
				if (193330 - 309232 != -115901)
				{
					if (!(this.mChar.actionState != "ko"))
					{
						goto IL_545;
					}
					if (105397 - 116757 != -11359)
					{
						if (!(this.mChar.actionState != "dead"))
						{
							goto IL_545;
						}
						if (73277 - 536717 != -463439)
						{
							if (this.mChar.isMine)
							{
								if (157888 - 309805 != -151916)
								{
									this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									}));
									if (271689 - 432394 == -160705)
									{
										if (PhotonClient.IsInitialized())
										{
											if (248249 - 322169 == -73919)
											{
												continue;
											}
											this.mChar.KoEvent();
											if (234378 - 407056 != -172678)
											{
												continue;
											}
										}
										goto IL_545;
									}
								}
							}
							else
							{
								this.mChar.ko = 1;
								if (282840 - 148277 == 134563)
								{
									goto IL_545;
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060058BE RID: 22718 RVA: 0x00AA89F0 File Offset: 0x00AA6BF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (83036 - 445790 != -362754)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (247382 - 172539 == 74843)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (108581 - 162712 != -54130)
				{
					if (299899 - 366915 == -67016)
					{
						if (ActionName == "RPC_nAttack")
						{
							if (197918 - 17596 != 180322)
							{
								continue;
							}
							v = 1;
							if (9931 - 300658 != -290727)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_fire")
						{
							if (91509 - 326929 != -235420)
							{
								continue;
							}
							v = 2;
							if (237612 - 116729 == 120884)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_hit")
						{
							if (181634 - 175422 == 6213)
							{
								continue;
							}
							v = -1;
							if (239153 - 380285 == -141131)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_rAttack")
						{
							if (180129 - 477552 == -297422)
							{
								continue;
							}
							v = 11;
							if (47894 - 74046 == -26151)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_rAttack_hit")
						{
							if (14491 - 495086 != -480595)
							{
								continue;
							}
							v = -11;
							if (157498 - 238565 == -81066)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (217412 - 34767 == 182646)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (141473 - 570112 != -428638)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (863 - 417875 != -417011)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (118925 - 300087 == -181162)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (83508 - 598337 != -514828)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (251777 - 309704 != -57926)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (187722 - 436919 != -249196)
											{
												Hashtable hashtable = new Hashtable();
												if (85859 - 257665 != -171805)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (117962 - 28562 == 89400)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (200003 - 317595 != -117591)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (89595 - 438521 == -348926)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (201722 - 155558 != 46165)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (264997 - 206133 != 58865)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (78961 - 404197 == -325236)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (267361 - 405256 != -137894)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (253543 - 32769 == 220774)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (257272 - 507971 == -250699)
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

	// Token: 0x060058BF RID: 22719 RVA: 0x00AA8F50 File Offset: 0x00AA7150
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (234956 - 9211 != 225745)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (79819 - 276399 == -196580)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (41457 - 304993 != -263535)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (206993 - 340540 == -133547)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (149429 - 519183 != -369753)
						{
							int num3 = num;
							if (193350 - 451484 != -258133)
							{
								if (num3 == 1)
								{
									if (214721 - 533879 != -319157)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (285113 - 337794 != -52680)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (280580 - 156187 != 124394)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 2)
								{
									if (176450 - 54318 == 122132)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (140346 - 266040 != -125693)
										{
											this.RPC_nAttack_fire(vector, vector2, num2);
											if (275217 - 313316 != -38098)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (116058 - 207305 == -91247)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (42584 - 28349 == 14235)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (189116 - 115915 == 73201)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (178261 - 113394 == 64867)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (38122 - 205410 == -167288)
										{
											this.StartCoroutine_Auto(this.RPC_rAttack(vector, vector2, num2));
											if (284950 - 345394 != -60443)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -11)
								{
									if (57442 - 302118 == -244676)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (144693 - 246324 == -101631)
										{
											this.RPC_rAttack_hit(vector, vector2, num2);
											if (226527 - 296375 == -69848)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (96853 - 596742 == -499889)
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

	// Token: 0x060058C0 RID: 22720 RVA: 0x00AA9348 File Offset: 0x00AA7548
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (299498 - 131131 != 168367)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (85776 - 85427 == 349)
			{
				float runSpeed = this.mChar.runSpeed;
				if (236319 - 41196 == 195123)
				{
					float num2 = 0f;
					if (288552 - 285623 == 2929)
					{
						float num3 = 0f;
						if (162481 - 384853 == -222372)
						{
							Vector3 vector = Vector3.zero;
							if (283746 - 179419 != 104328)
							{
								float num4 = (float)0;
								if (115800 - 361577 != -245776)
								{
									if (this.mChar.isMine)
									{
										if (170595 - 272784 != -102189)
										{
											continue;
										}
										if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
										{
											if (170270 - 358925 != -188655)
											{
												continue;
											}
											num2 = Input.GetAxisRaw("Vertical");
											if (267472 - 48305 != 219167)
											{
												continue;
											}
											num3 = Input.GetAxisRaw("Horizontal");
											if (140116 - 232174 != -92058)
											{
												continue;
											}
											if (Game.mGameState == eGameState.Normal)
											{
												if (231996 - 123988 != 108008)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (129727 - 245917 == -116189)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (204682 - 211728 != -7045)
														{
															if (num2 == (float)0)
															{
																if (73578 - 518840 == -445261)
																{
																	continue;
																}
																if (num3 == (float)0)
																{
																	goto IL_DF0;
																}
																if (83340 - 120932 == -37591)
																{
																	continue;
																}
															}
															if (num2 > (float)0)
															{
																if (242401 - 284104 == -41702)
																{
																	continue;
																}
																this.mChar.actionState = "run";
																if (80856 - 153167 != -72311)
																{
																	continue;
																}
																num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), 0.5f * Time.deltaTime);
																if (235433 - 277130 != -41697)
																{
																	continue;
																}
																vector = global::Math.rotateH(this.transform.forward, -0.6f * num3);
																if (225513 - 115656 != 109857)
																{
																	continue;
																}
																this.transform.rotation = Quaternion.LookRotation(vector);
																if (204485 - 554259 != -349774)
																{
																	continue;
																}
																this.animation.CrossFade("run");
																if (2079 - 215555 == -213475)
																{
																	continue;
																}
																this.animation.wrapMode = WrapMode.Loop;
																if (229647 - 567155 == -337507)
																{
																	continue;
																}
																if (!this.audio.isPlaying)
																{
																	if (99333 - 110655 == -11321)
																	{
																		continue;
																	}
																	this.audio.Play();
																	if (238449 - 300769 == -62319)
																	{
																		continue;
																	}
																}
															}
															else if (num2 < (float)0)
															{
																if (249208 - 484993 == -235784)
																{
																	continue;
																}
																this.mChar.actionState = "run";
																if (186612 - 21045 != 165567)
																{
																	continue;
																}
																num = Mathf.Lerp(num, Mathf.Clamp(-runSpeed, (float)-12, (float)0), 0.5f * Time.deltaTime);
																if (237164 - 387126 != -149962)
																{
																	continue;
																}
																vector = global::Math.rotateH(this.transform.forward, -0.6f * num3);
																if (171348 - 194004 == -22655)
																{
																	continue;
																}
																this.transform.rotation = Quaternion.LookRotation(vector);
																if (232562 - 544609 != -312047)
																{
																	continue;
																}
																this.animation.CrossFade("reverse");
																if (150785 - 540969 != -390184)
																{
																	continue;
																}
																this.animation.wrapMode = WrapMode.Loop;
																if (25737 - 471946 != -446209)
																{
																	continue;
																}
																if (!this.audio.isPlaying)
																{
																	if (104133 - 599860 != -495727)
																	{
																		continue;
																	}
																	this.audio.Play();
																	if (277497 - 204298 != 73199)
																	{
																		continue;
																	}
																}
															}
															else
															{
																this.mChar.actionState = "run";
																if (294792 - 276908 == 17885)
																{
																	continue;
																}
																num = Mathf.Lerp(num, (float)0, (float)2 * Time.deltaTime);
																if (273404 - 229463 == 43942)
																{
																	continue;
																}
																if (num < 0.1f * runSpeed)
																{
																	if (43018 - 443554 == -400535)
																	{
																		continue;
																	}
																	num = (float)0;
																	if (104023 - 490283 != -386260)
																	{
																		continue;
																	}
																}
																vector = global::Math.rotateH(this.transform.forward, -1.2f * num3);
																if (25361 - 261117 == -235755)
																{
																	continue;
																}
																this.transform.rotation = Quaternion.LookRotation(vector);
																if (155946 - 418845 != -262899)
																{
																	continue;
																}
																this.animation.CrossFade("run");
																if (5874 - 58751 != -52877)
																{
																	continue;
																}
																this.animation.wrapMode = WrapMode.Loop;
																if (37573 - 142857 == -105283)
																{
																	continue;
																}
																if (!this.audio.isPlaying)
																{
																	if (25795 - 173382 != -147587)
																	{
																		continue;
																	}
																	this.audio.Play();
																	if (160895 - 316856 != -155961)
																	{
																		continue;
																	}
																}
															}
															goto IL_12C3;
														}
														continue;
													}
												}
											}
											IL_DF0:
											num = Mathf.Lerp(num, (float)0, (float)2 * Time.deltaTime);
											if (247989 - 137514 == 110476)
											{
												continue;
											}
											vector = this.transform.forward;
											if (132876 - 196207 == -63330)
											{
												continue;
											}
											if (num < 0.1f * runSpeed)
											{
												if (9153 - 260233 == -251079)
												{
													continue;
												}
												this.mChar.actionState = "standby";
												if (35363 - 234771 != -199408)
												{
													continue;
												}
												num = (float)0;
												if (145520 - 27900 == 117621)
												{
													continue;
												}
												this.animation.CrossFade("root");
												if (30976 - 30433 == 544)
												{
													continue;
												}
												this.animation.wrapMode = WrapMode.Loop;
												if (145510 - 40517 == 104994)
												{
													continue;
												}
												if (this.audio.isPlaying)
												{
													if (252675 - 569672 != -316997)
													{
														continue;
													}
													this.audio.Stop();
													if (96752 - 245548 != -148796)
													{
														continue;
													}
												}
											}
											else
											{
												this.mChar.actionState = "run";
												if (138386 - 213727 != -75341)
												{
													continue;
												}
											}
										}
										IL_12C3:;
									}
									else
									{
										vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
										if (11240 - 469223 == -457982)
										{
											continue;
										}
										num4 = vector.sqrMagnitude;
										if (110683 - 553135 == -442451)
										{
											continue;
										}
										if (this.mChar.nSpeed > (float)0)
										{
											if (244402 - 53278 != 191124)
											{
												continue;
											}
											if (num4 > runSpeed)
											{
												if (138082 - 489188 != -351106)
												{
													continue;
												}
												this.transform.position = this.mChar.nPosition;
												if (118960 - 424004 == -305043)
												{
													continue;
												}
											}
											else if (num4 > 0.01f)
											{
												if (298144 - 304388 != -6244)
												{
													continue;
												}
												if (num4 > (float)1)
												{
													if (50144 - 301081 == -250936)
													{
														continue;
													}
													num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
													if (70980 - 163446 != -92466)
													{
														continue;
													}
												}
												else
												{
													num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
													if (229345 - 265067 == -35721)
													{
														continue;
													}
												}
												if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
												{
													if (274963 - 301250 != -26287)
													{
														continue;
													}
													this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
													if (272869 - 54995 == 217875)
													{
														continue;
													}
												}
												else
												{
													this.transform.rotation = Quaternion.LookRotation(vector);
													if (192172 - 301735 != -109563)
													{
														continue;
													}
												}
												this.animation.Play("run");
												if (94929 - 54974 == 39956)
												{
													continue;
												}
												this.animation.wrapMode = WrapMode.Loop;
												if (141820 - 84612 == 57209)
												{
													continue;
												}
												if (!this.audio.isPlaying)
												{
													if (197245 - 584071 != -386826)
													{
														continue;
													}
													this.audio.Play();
													if (80793 - 251503 == -170709)
													{
														continue;
													}
												}
											}
											else if (Time.time > this.mChar.nSpeed + 0.3f)
											{
												if (134704 - 439167 == -304462)
												{
													continue;
												}
												num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
												if (142958 - 374819 != -231861)
												{
													continue;
												}
												if (num < 0.01f)
												{
													if (35715 - 320505 == -284789)
													{
														continue;
													}
													num = (float)0;
													if (216425 - 280301 == -63875)
													{
														continue;
													}
												}
												this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
												if (15896 - 458959 == -443062)
												{
													continue;
												}
												this.animation.CrossFade("root", 0.2f);
												if (243399 - 164238 == 79162)
												{
													continue;
												}
												this.animation.wrapMode = WrapMode.Loop;
												if (12225 - 223037 == -210811)
												{
													continue;
												}
												if (this.audio.isPlaying)
												{
													if (288305 - 326054 != -37749)
													{
														continue;
													}
													this.audio.Stop();
													if (174834 - 170719 != 4115)
													{
														continue;
													}
												}
											}
										}
										else if (this.mChar.nSpeed < (float)0)
										{
											if (103586 - 162397 == -58810)
											{
												continue;
											}
											vector *= (float)-1;
											if (227589 - 446507 != -218918)
											{
												continue;
											}
											if (num4 > runSpeed)
											{
												if (287183 - 357316 != -70133)
												{
													continue;
												}
												this.transform.position = this.mChar.nPosition;
												if (143709 - 29459 == 114251)
												{
													continue;
												}
											}
											else if (num4 > 0.01f)
											{
												if (238304 - 446040 == -207735)
												{
													continue;
												}
												if (num4 > (float)1)
												{
													if (1569 - 56797 == -55227)
													{
														continue;
													}
													num = Mathf.Lerp(num, -1.2f * runSpeed, (float)10 * Time.deltaTime);
													if (217525 - 37194 != 180331)
													{
														continue;
													}
												}
												else
												{
													num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
													if (277857 - 404919 != -127062)
													{
														continue;
													}
												}
												if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
												{
													if (190728 - 357915 == -167186)
													{
														continue;
													}
													this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
													if (22340 - 435428 == -413087)
													{
														continue;
													}
												}
												else
												{
													this.transform.rotation = Quaternion.LookRotation(vector);
													if (38601 - 412657 != -374056)
													{
														continue;
													}
												}
												this.animation.Play("reverse");
												if (95681 - 575869 == -480187)
												{
													continue;
												}
												this.animation.wrapMode = WrapMode.Loop;
												if (78629 - 145183 != -66554)
												{
													continue;
												}
												if (!this.audio.isPlaying)
												{
													if (33222 - 360547 == -327324)
													{
														continue;
													}
													this.audio.Play();
													if (202607 - 287140 == -84532)
													{
														continue;
													}
												}
											}
											else if (Time.time < this.mChar.nSpeed - 0.3f)
											{
												if (59702 - 442521 == -382818)
												{
													continue;
												}
												num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
												if (174568 - 127572 != 46996)
												{
													continue;
												}
												if (num > 0.01f)
												{
													if (296326 - 489891 != -193565)
													{
														continue;
													}
													num = (float)0;
													if (228306 - 492466 != -264160)
													{
														continue;
													}
												}
												this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
												if (189879 - 569084 == -379204)
												{
													continue;
												}
												this.animation.CrossFade("root", 0.2f);
												if (8623 - 359463 != -350840)
												{
													continue;
												}
												this.animation.wrapMode = WrapMode.Loop;
												if (65295 - 558722 == -493426)
												{
													continue;
												}
												if (this.audio.isPlaying)
												{
													if (271196 - 40767 != 230429)
													{
														continue;
													}
													this.audio.Stop();
													if (75163 - 585568 != -510405)
													{
														continue;
													}
												}
											}
										}
										else if (num != (float)0)
										{
											if (29955 - 161206 != -131251)
											{
												continue;
											}
											if (num4 > runSpeed)
											{
												if (252432 - 413290 == -160857)
												{
													continue;
												}
												this.transform.position = this.mChar.nPosition;
												if (236586 - 206976 != 29610)
												{
													continue;
												}
											}
											else if (num4 > 0.01f)
											{
												if (70980 - 554765 == -483784)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (171876 - 79414 != 92462)
												{
													continue;
												}
												if (num4 > 0.1f)
												{
													if (104102 - 344128 == -240025)
													{
														continue;
													}
													num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
													if (122380 - 365121 != -242741)
													{
														continue;
													}
												}
												else
												{
													num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
													if (135048 - 244379 != -109331)
													{
														continue;
													}
												}
												this.animation.CrossFade("run", 0.5f);
												if (141087 - 536537 != -395450)
												{
													continue;
												}
												this.animation.wrapMode = WrapMode.Loop;
												if (226374 - 341567 != -115193)
												{
													continue;
												}
												if (!this.audio.isPlaying)
												{
													if (204989 - 37347 == 167643)
													{
														continue;
													}
													this.audio.Play();
													if (52438 - 539426 == -486987)
													{
														continue;
													}
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
												if (184093 - 174304 != 9789)
												{
													continue;
												}
												num = (float)0;
												if (232013 - 542945 != -310932)
												{
													continue;
												}
												this.animation.CrossFade("root", 0.2f);
												if (280097 - 474539 == -194441)
												{
													continue;
												}
												this.animation.wrapMode = WrapMode.Loop;
												if (50658 - 535976 == -485317)
												{
													continue;
												}
												if (this.audio.isPlaying)
												{
													if (265980 - 68451 != 197529)
													{
														continue;
													}
													this.audio.Stop();
													if (73740 - 73773 != -33)
													{
														continue;
													}
												}
											}
										}
										else
										{
											this.animation.CrossFade("root", 0.2f);
											if (3302 - 214003 != -210701)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (97415 - 511455 != -414040)
											{
												continue;
											}
											if (this.audio.isPlaying)
											{
												if (217829 - 555272 != -337443)
												{
													continue;
												}
												this.audio.Stop();
												if (1900 - 422452 != -420552)
												{
													continue;
												}
											}
										}
									}
									this.mChar.vMovement = vector;
									if (163021 - 270242 != -107220)
									{
										this.mChar.moveSpeed = num;
										if (105845 - 119086 != -13240)
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

	// Token: 0x060058C1 RID: 22721 RVA: 0x00AAA870 File Offset: 0x00AA8A70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (270327 - 112093 != 158234)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (92074 - 467638 != -375563)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (7531 - 466541 != -459009)
				{
					Vector3 vector = a - this.transform.position;
					if (268376 - 319087 != -50710)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (34555 - 536882 != -502326)
						{
							CharacterControl characterControl = null;
							if (220433 - 160099 != 60335 && 259528 - 417571 != -158042)
							{
								if (gameObject)
								{
									if (205876 - 463675 != -257799)
									{
										continue;
									}
									characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (53042 - 564409 == -511366)
									{
										continue;
									}
								}
								if (characterControl)
								{
									if (39039 - 53087 != -14048)
									{
										continue;
									}
									int actorNr = characterControl.ActorNr;
									if (276401 - 173278 == 103124)
									{
										continue;
									}
								}
								if (!(this.mChar.actionState == "standby"))
								{
									if (233837 - 476802 == -242964)
									{
										continue;
									}
									if (!(this.mChar.actionState == "run"))
									{
										break;
									}
									if (172351 - 241 != 172110)
									{
										continue;
									}
								}
								if (Game.mGameType < 4)
								{
									if (54897 - 102520 == -47623)
									{
										Camera.main.SendMessage("newGameMessage", "Cannot do normal attack here");
										if (139377 - 369208 == -229831)
										{
											break;
										}
									}
								}
								else if (this.mChar.isTimeOut("nAttack") != (float)0)
								{
									if (95135 - 218258 != -123122)
									{
										Camera.main.SendMessage("newGameMessage", "Attack TimeOut!");
										if (140480 - 192116 == -51636)
										{
											break;
										}
									}
								}
								else if (this.mChar.moveSpeed > (float)2)
								{
									if (189960 - 504652 == -314692)
									{
										this.StartCoroutine_Auto(this.RPC_rAttack(this.transform.position, this.transform.forward, 0));
										if (1246 - 260777 != -259530)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (207350 - 121009 != 86342)
											{
												this.ActionEvent("RPC_rAttack", this.transform.position, this.transform.forward, 0);
												if (270433 - 501540 != -231106)
												{
													break;
												}
											}
										}
									}
								}
								else
								{
									this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, this.transform.forward, 0));
									if (116670 - 407571 == -290901)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (204408 - 436390 == -231982)
										{
											this.ActionEvent("RPC_nAttack", this.transform.position, this.transform.forward, 0);
											if (188865 - 228647 != -39781)
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

	// Token: 0x060058C2 RID: 22722 RVA: 0x00AAACD8 File Offset: 0x00AA8ED8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (98954 - 585148 != -486193)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (187806 - 271204 != -83397)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (265627 - 201178 == 64449)
				{
					Vector3 vector = a - this.transform.position;
					if (57668 - 324505 == -266837)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (276145 - 275708 != 438)
						{
							CharacterControl characterControl = null;
							if (114639 - 403837 != -289197)
							{
								if (172516 - 245736 == -73220)
								{
									if (gameObject)
									{
										if (191969 - 318251 != -126282)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (91370 - 255114 == -163743)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (234957 - 163724 != 71233)
										{
											continue;
										}
										int actorNr = characterControl.ActorNr;
										if (119702 - 206168 != -86466)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (65454 - 287075 != -221621)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (298940 - 68114 != 230826)
										{
											continue;
										}
									}
									if (Game.mGameType < 4)
									{
										if (139402 - 182423 == -43021)
										{
											Camera.main.SendMessage("newGameMessage", "Cannot do normal attack here");
											if (237846 - 61092 != 176755)
											{
												break;
											}
										}
									}
									else if (this.mChar.isTimeOut("nAttack") != (float)0)
									{
										if (277497 - 349517 == -72020)
										{
											Camera.main.SendMessage("newGameMessage", "Attack TimeOut!");
											if (207274 - 147086 != 60189)
											{
												break;
											}
										}
									}
									else
									{
										this.StartCoroutine_Auto(this.RPC_rAttack(this.transform.position, this.transform.forward, 0));
										if (57619 - 297734 == -240115)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (197559 - 450092 != -252532)
											{
												this.ActionEvent("RPC_rAttack", this.transform.position, this.transform.forward, 0);
												if (204112 - 400544 == -196432)
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

	// Token: 0x060058C3 RID: 22723 RVA: 0x00AAB070 File Offset: 0x00AA9270
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x060058C4 RID: 22724 RVA: 0x00AAB074 File Offset: 0x00AA9274
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new MoleTank.$RPC_nAttack$35119(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060058C5 RID: 22725 RVA: 0x00AAB084 File Offset: 0x00AA9284
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_fire(Vector3 firePos, Vector3 fireDir, int tID)
	{
		if (31402 - 515841 != -484439)
		{
		}
		while (this.nAttack_fire)
		{
			if (264166 - 384475 != -120308)
			{
				GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(this.nAttack_fire, firePos, Quaternion.LookRotation(fireDir));
				if (4334 - 308763 == -304429)
				{
					ProjectileControl projectileControl = (ProjectileControl)gameObject.GetComponent(typeof(ProjectileControl));
					if (105496 - 485925 != -380428)
					{
						projectileControl.Init(this.mChar.ActorNr);
						if (107542 - 108684 == -1142)
						{
							projectileControl.life = (float)2 * this.mChar.rangeMod;
							if (279466 - 370025 != -90558)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060058C6 RID: 22726 RVA: 0x00AAB1A4 File Offset: 0x00AA93A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int tID)
	{
		if (149017 - 545366 != -396348)
		{
		}
		for (;;)
		{
			IL_3B:
			if (this.nAttack_hit)
			{
				if (4825 - 113955 == -109129)
				{
					continue;
				}
				UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, this.transform.rotation);
				if (59070 - 466840 == -407769)
				{
					continue;
				}
			}
			else
			{
				Debug.LogError("Cannot find nAttack_hit Effect");
				if (46640 - 201045 == -154404)
				{
					continue;
				}
			}
			if (!this.mChar.isMine)
			{
				break;
			}
			if (280253 - 408931 == -128678)
			{
				int layerMask = 130816 - (1 << this.gameObject.layer);
				if (76638 - 373368 == -296730)
				{
					UnityScript.Lang.Array obj = Damage.FindAreaTarget(hitPos - 0.5f * Vector3.up, (float)5, (float)3, layerMask);
					if (221977 - 496844 == -274867)
					{
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
						if (216095 - 214584 != 1512)
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
								if (172979 - 66731 == 106249)
								{
									goto IL_3B;
								}
								this.mChar.hit(1, gameObject, this.mChar.atk, 1, 0, 0.5f * this.transform.forward);
								if (97766 - 73119 == 24648)
								{
									goto IL_3B;
								}
								UnityRuntimeServices.Update(enumerator, gameObject);
								if (135230 - 177331 != -42101)
								{
									goto IL_3B;
								}
							}
							if (101506 - 23151 == 78355)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060058C7 RID: 22727 RVA: 0x00AAB3EC File Offset: 0x00AA95EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_rAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new MoleTank.$RPC_rAttack$35128(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060058C8 RID: 22728 RVA: 0x00AAB3FC File Offset: 0x00AA95FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_rAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (137981 - 42561 != 95420)
		{
		}
		for (;;)
		{
			if (this.rAttack_hit)
			{
				if (192010 - 87023 == 104987)
				{
					UnityEngine.Object.Instantiate(this.rAttack_hit, hitPos, this.transform.rotation);
					if (201003 - 458387 != -257383)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Missing rAttack_hit effect");
				if (138573 - 567596 == -429023)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060058C9 RID: 22729 RVA: 0x00AAB4BC File Offset: 0x00AA96BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_ko(UnityScript.Lang.Array nArray)
	{
		if (296899 - 150553 != 146347)
		{
		}
		while (!(this.mChar.actionState == "ko"))
		{
			if (81402 - 256772 != -175369)
			{
				if (this.mChar.actionState == "dead")
				{
					if (258321 - 107154 == 151167)
					{
						break;
					}
				}
				else
				{
					Vector3 vector = (Vector3)nArray[0];
					if (136472 - 488422 != -351949)
					{
						Vector3 b = (Vector3)nArray[1];
						if (214121 - 237614 != -23492)
						{
							this.transform.position = vector;
							if (36782 - 51173 == -14391)
							{
								this.transform.LookAt(vector + b);
								if (189722 - 384666 != -194943)
								{
									this.mChar.actionState = "ko";
									if (272698 - 231029 != 41670)
									{
										this.mChar.actionTime = Time.time;
										if (279706 - 359412 != -79705)
										{
											this.mChar.myCommand = "none";
											if (205648 - 129817 != 75832)
											{
												this.mChar.vMovement = Vector3.zero;
												if (209029 - 583922 != -374892)
												{
													this.mChar.moveSpeed = (float)0;
													if (106479 - 38054 == 68425)
													{
														if (this.ko_ring)
														{
															if (215349 - 25688 != 189661)
															{
																continue;
															}
															UnityEngine.Object.Instantiate(this.ko_ring, this.mTransform.position, this.mTransform.rotation);
															if (98393 - 589423 != -491030)
															{
																continue;
															}
														}
														else
														{
															Debug.Log("Missing ko_ring");
															if (60859 - 492507 == -431647)
															{
																continue;
															}
														}
														this.mChar.removeStatus("mount");
														if (103715 - 69405 == 34310)
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

	// Token: 0x060058CA RID: 22730 RVA: 0x00AAB794 File Offset: 0x00AA9994
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_dead(UnityScript.Lang.Array nArray)
	{
		if (220128 - 265955 != -45827)
		{
		}
		for (;;)
		{
			if (this.mChar.actionState == "dead")
			{
				if (106017 - 218185 != -112167)
				{
					break;
				}
			}
			else
			{
				Vector3 vector = (Vector3)nArray[0];
				if (170374 - 274978 == -104604)
				{
					Vector3 b = (Vector3)nArray[1];
					if (279645 - 245889 == 33756)
					{
						this.transform.position = vector;
						if (284219 - 55870 == 228349)
						{
							this.transform.LookAt(vector + b);
							if (222688 - 23144 != 199545)
							{
								this.mChar.actionState = "dead";
								if (92042 - 468267 == -376225)
								{
									this.mChar.actionTime = Time.time;
									if (108455 - 163398 != -54942)
									{
										this.mChar.myCommand = "none";
										if (243890 - 546440 == -302550)
										{
											this.mChar.vMovement = Vector3.zero;
											if (184898 - 435004 != -250105)
											{
												this.mChar.moveSpeed = (float)0;
												if (126812 - 483048 != -356235)
												{
													if (this.ko_ring)
													{
														if (5532 - 520307 != -514775)
														{
															continue;
														}
														UnityEngine.Object.Instantiate(this.ko_ring, this.mTransform.position, this.mTransform.rotation);
														if (165109 - 182581 != -17472)
														{
															continue;
														}
													}
													else
													{
														Debug.Log("Missing ko_ring");
														if (236997 - 232757 == 4241)
														{
															continue;
														}
													}
													this.mChar.removeStatus("mount");
													if (205436 - 309113 != -103676)
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

	// Token: 0x060058CB RID: 22731 RVA: 0x00AABA38 File Offset: 0x00AA9C38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060058CC RID: 22732 RVA: 0x00AABA3C File Offset: 0x00AA9C3C
	internal static bool OE4Fy3ppVHjmcLyo8FZZ()
	{
		return true;
	}

	// Token: 0x060058CD RID: 22733 RVA: 0x00AABA40 File Offset: 0x00AA9C40
	internal static bool R0q3ZhpptCJPrDaaxsyJ()
	{
		return false;
	}

	// Token: 0x04006187 RID: 24967
	public Transform mTransform;

	// Token: 0x04006188 RID: 24968
	public CharacterControl mChar;

	// Token: 0x04006189 RID: 24969
	public CharacterControl mOwnerChar;

	// Token: 0x0400618A RID: 24970
	private Quaternion ih4ct0n2B8t;

	// Token: 0x0400618B RID: 24971
	private float IuJct8M432f;

	// Token: 0x0400618C RID: 24972
	private Transform KqectiT15tC;

	// Token: 0x0400618D RID: 24973
	public GameObject nAttack_fire;

	// Token: 0x0400618E RID: 24974
	public GameObject nAttack_hit;

	// Token: 0x0400618F RID: 24975
	public GameObject rAttack_ring;

	// Token: 0x04006190 RID: 24976
	public GameObject rAttack_hit;

	// Token: 0x04006191 RID: 24977
	public GameObject ko_ring;

	// Token: 0x02000F45 RID: 3909
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$35119 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060058CE RID: 22734 RVA: 0x00AABA44 File Offset: 0x00AA9C44
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$35119(Vector3 mPos, Vector3 tDir, MoleTank self_)
		{
			if (217826 - 479708 != -261882)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (109437 - 534009 != -424571)
				{
					base..ctor();
					if (238783 - 334246 != -95462)
					{
						this.$mPos$35125 = mPos;
						if (202781 - 298065 == -95284)
						{
							this.$tDir$35126 = tDir;
							if (227811 - 148297 != 79515)
							{
								this.$self_$35127 = self_;
								if (118317 - 355532 != -237214)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060058CF RID: 22735 RVA: 0x00AABB20 File Offset: 0x00AA9D20
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new MoleTank.$RPC_nAttack$35119.$(this.$mPos$35125, this.$tDir$35126, this.$self_$35127);
		}

		// Token: 0x060058D0 RID: 22736 RVA: 0x00AABB3C File Offset: 0x00AA9D3C
		internal static bool ri6nG8ppN1O8JEIKkXH3()
		{
			return true;
		}

		// Token: 0x060058D1 RID: 22737 RVA: 0x00AABB40 File Offset: 0x00AA9D40
		internal static bool t7uvwJppYg4JbS7hREeN()
		{
			return false;
		}

		// Token: 0x04006192 RID: 24978
		internal Vector3 $mPos$35125;

		// Token: 0x04006193 RID: 24979
		internal Vector3 $tDir$35126;

		// Token: 0x04006194 RID: 24980
		internal MoleTank $self_$35127;

		// Token: 0x02000F46 RID: 3910
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060058D2 RID: 22738 RVA: 0x00AABB44 File Offset: 0x00AA9D44
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, MoleTank self_)
			{
				if (293664 - 551578 != -257913)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (288637 - 421398 != -132760)
					{
						base..ctor();
						if (163470 - 43773 == 119697)
						{
							this.$mPos$35122 = mPos;
							if (210138 - 480264 == -270126)
							{
								this.$tDir$35123 = tDir;
								if (231841 - 591461 == -359620)
								{
									this.$self_$35124 = self_;
									if (56109 - 221345 != -165235)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060058D3 RID: 22739 RVA: 0x00AABC20 File Offset: 0x00AA9E20
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (141540 - 337330 != -195789)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_6E8;
					case 2:
						if (this.$self_$35124.mChar.actionState != "attack")
						{
							if (113633 - 273335 != -159702)
							{
								continue;
							}
							goto IL_1FF;
						}
						else
						{
							this.$self_$35124.mChar.vMovement = this.$self_$35124.transform.forward;
							if (142373 - 388823 != -246450)
							{
								continue;
							}
							this.$self_$35124.mChar.moveSpeed = (float)0;
							if (92076 - 506882 == -414805)
							{
								continue;
							}
							if (this.$self_$35124.mChar.actionState == "attack")
							{
								if (292069 - 80494 == 211576)
								{
									continue;
								}
								if (this.$self_$35124.mChar.myCommand == "nAttack")
								{
									if (148523 - 211850 != -63327)
									{
										continue;
									}
									this.$self_$35124.mChar.actionState = "standby";
									if (210354 - 93236 != 117118)
									{
										continue;
									}
									this.$self_$35124.mChar.actionTime = Time.time;
									if (234801 - 298182 == -63380)
									{
										continue;
									}
									this.$self_$35124.mChar.myCommand = "none";
									if (112216 - 296146 == -183929)
									{
										continue;
									}
									if (!this.$self_$35124.mChar.isMine)
									{
										if (82179 - 21068 != 61111)
										{
											continue;
										}
										this.$self_$35124.mChar.nPosition = this.$self_$35124.transform.position;
										if (164173 - 469848 != -305675)
										{
											continue;
										}
										this.$self_$35124.mChar.oPosition = this.$self_$35124.transform.position;
										if (298374 - 416953 == -118578)
										{
											continue;
										}
										this.$self_$35124.mChar.nDirection = this.$self_$35124.transform.forward;
										if (252949 - 486651 != -233702)
										{
											continue;
										}
									}
								}
							}
							this.YieldDefault(1);
							if (74018 - 88830 != -14811)
							{
								goto Block_31;
							}
							continue;
						}
						break;
					default:
						if (292776 - 451299 == -158522)
						{
							continue;
						}
						break;
					}
					this.$self_$35124.mChar.actionState = "attack";
					if (109866 - 47987 != 61880)
					{
						this.$self_$35124.mChar.actionTime = Time.time;
						if (131794 - 94032 == 37762)
						{
							this.$self_$35124.mChar.myCommand = "nAttack";
							if (252506 - 38465 == 214041)
							{
								this.$self_$35124.mChar.addTimeOut("nAttack", 0.5f);
								if (190995 - 419423 == -228428)
								{
									this.$self_$35124.transform.position = this.$mPos$35122;
									if (49286 - 199109 == -149823)
									{
										this.$self_$35124.transform.LookAt(this.$mPos$35122 + global::Math.vFlat(this.$tDir$35123));
										if (154618 - 520678 != -366059)
										{
											this.$self_$35124.animation.Play("nAttack");
											if (236206 - 457838 != -221631)
											{
												this.$self_$35124.animation.wrapMode = WrapMode.Once;
												if (169729 - 508882 != -339152)
												{
													this.$self_$35124.mChar.vMovement = this.$self_$35124.transform.forward;
													if (76196 - 229383 == -153187)
													{
														this.$self_$35124.mChar.moveSpeed = (float)0;
														if (33175 - 277136 != -243960)
														{
															if (this.$self_$35124.audio.isPlaying)
															{
																if (196181 - 452104 != -255923)
																{
																	continue;
																}
																this.$self_$35124.audio.Stop();
																if (108340 - 434132 == -325791)
																{
																	continue;
																}
															}
															if (!this.$self_$35124.mChar.isMine)
															{
																goto IL_66A;
															}
															if (22704 - 498661 != -475956)
															{
																if (!this.$self_$35124.KqectiT15tC)
																{
																	goto IL_66A;
																}
																if (152844 - 258077 == -105233)
																{
																	this.$firePos$35120 = this.$self_$35124.transform.position + this.$self_$35124.KqectiT15tC.TransformDirection((float)0, 1.2f, -1.4f);
																	if (112542 - 322018 == -209476)
																	{
																		this.$fireDir$35121 = -this.$self_$35124.KqectiT15tC.forward + 0.05f * this.$self_$35124.KqectiT15tC.up;
																		if (105078 - 269001 != -163922)
																		{
																			this.$self_$35124.RPC_nAttack_fire(this.$firePos$35120, this.$fireDir$35121.normalized, 0);
																			if (29993 - 51845 == -21852)
																			{
																				if (!PhotonClient.IsInitialized())
																				{
																					goto IL_66A;
																				}
																				if (185746 - 167954 != 17793)
																				{
																					this.$self_$35124.ActionEvent("RPC_nAttack_fire", this.$firePos$35120, this.$fireDir$35121.normalized, 0);
																					if (44999 - 449188 == -404189)
																					{
																						goto IL_66A;
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_1FF:
				Block_31:
				goto IL_6E8;
				IL_66A:
				return this.Yield(2, new WaitForSeconds(0.2f));
				IL_6E8:
				return false;
			}

			// Token: 0x060058D4 RID: 22740 RVA: 0x00AAC328 File Offset: 0x00AAA528
			internal static bool U9xaPBppcVov8WMpDmqN()
			{
				return true;
			}

			// Token: 0x060058D5 RID: 22741 RVA: 0x00AAC32C File Offset: 0x00AAA52C
			internal static bool fqlM2sppUmINma4mJT87()
			{
				return false;
			}

			// Token: 0x04006195 RID: 24981
			internal Vector3 $firePos$35120;

			// Token: 0x04006196 RID: 24982
			internal Vector3 $fireDir$35121;

			// Token: 0x04006197 RID: 24983
			internal Vector3 $mPos$35122;

			// Token: 0x04006198 RID: 24984
			internal Vector3 $tDir$35123;

			// Token: 0x04006199 RID: 24985
			internal MoleTank $self_$35124;
		}
	}

	// Token: 0x02000F47 RID: 3911
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_rAttack$35128 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060058D6 RID: 22742 RVA: 0x00AAC330 File Offset: 0x00AAA530
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_rAttack$35128(Vector3 mPos, Vector3 tDir, MoleTank self_)
		{
			if (79707 - 11703 != 68004)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (157633 - 529388 == -371755)
				{
					base..ctor();
					if (162396 - 39134 != 123263)
					{
						this.$mPos$35138 = mPos;
						if (201109 - 302581 != -101471)
						{
							this.$tDir$35139 = tDir;
							if (131314 - 141442 != -10127)
							{
								this.$self_$35140 = self_;
								if (140392 - 279843 != -139450)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060058D7 RID: 22743 RVA: 0x00AAC40C File Offset: 0x00AAA60C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new MoleTank.$RPC_rAttack$35128.$(this.$mPos$35138, this.$tDir$35139, this.$self_$35140);
		}

		// Token: 0x060058D8 RID: 22744 RVA: 0x00AAC428 File Offset: 0x00AAA628
		internal static bool nJFky6ppTQsSXvM5Lw0P()
		{
			return true;
		}

		// Token: 0x060058D9 RID: 22745 RVA: 0x00AAC42C File Offset: 0x00AAA62C
		internal static bool zrbwvZpp3XH8GRHYAYkh()
		{
			return false;
		}

		// Token: 0x0400619A RID: 24986
		internal Vector3 $mPos$35138;

		// Token: 0x0400619B RID: 24987
		internal Vector3 $tDir$35139;

		// Token: 0x0400619C RID: 24988
		internal MoleTank $self_$35140;

		// Token: 0x02000F48 RID: 3912
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060058DA RID: 22746 RVA: 0x00AAC430 File Offset: 0x00AAA630
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, MoleTank self_)
			{
				if (105574 - 338399 != -232825)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (180987 - 285143 != -104155)
					{
						base..ctor();
						if (38691 - 115724 == -77033)
						{
							this.$mPos$35135 = mPos;
							if (211470 - 427400 != -215929)
							{
								this.$tDir$35136 = tDir;
								if (76015 - 202648 == -126633)
								{
									this.$self_$35137 = self_;
									if (166584 - 79389 != 87196)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060058DB RID: 22747 RVA: 0x00AAC50C File Offset: 0x00AAA70C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (97108 - 190214 != -93105)
				{
				}
				for (;;)
				{
					IL_650:
					switch (this._state)
					{
					case 0:
						goto IL_278;
					case 1:
						goto IL_96E;
					case 2:
						if (this.$self_$35137.mChar.actionState != "attack")
						{
							goto IL_C9;
						}
						if (86702 - 509477 != -422775)
						{
							continue;
						}
						if (this.$self_$35137.mChar.myCommand != "rAttack")
						{
							if (231129 - 259496 != -28366)
							{
								goto Block_49;
							}
							continue;
						}
						else
						{
							this.$i$35129++;
							if (248575 - 470744 != -222169)
							{
								continue;
							}
						}
						break;
					default:
						if (25039 - 399806 != -374766)
						{
							goto IL_278;
						}
						continue;
					}
					IL_F6:
					if (this.$i$35129 >= 6)
					{
						if (104584 - 294430 == -189845)
						{
							continue;
						}
						this.$self_$35137.mChar.vMovement = this.$self_$35137.transform.forward;
						if (257718 - 275033 == -17314)
						{
							continue;
						}
						this.$self_$35137.mChar.moveSpeed = (float)4;
						if (132773 - 563698 != -430925)
						{
							continue;
						}
						if (this.$self_$35137.mChar.actionState == "attack")
						{
							if (224918 - 397755 == -172836)
							{
								continue;
							}
							if (this.$self_$35137.mChar.myCommand == "rAttack")
							{
								if (168213 - 151939 == 16275)
								{
									continue;
								}
								this.$self_$35137.mChar.actionState = "standby";
								if (214750 - 255065 == -40314)
								{
									continue;
								}
								this.$self_$35137.mChar.actionTime = Time.time;
								if (201621 - 69067 != 132554)
								{
									continue;
								}
								this.$self_$35137.mChar.myCommand = "none";
								if (243426 - 12708 != 230718)
								{
									continue;
								}
								if (!this.$self_$35137.mChar.isMine)
								{
									if (20229 - 48354 != -28125)
									{
										continue;
									}
									this.$self_$35137.mChar.nPosition = this.$self_$35137.transform.position;
									if (62361 - 140997 == -78635)
									{
										continue;
									}
									this.$self_$35137.mChar.oPosition = this.$self_$35137.transform.position;
									if (178677 - 50968 == 127710)
									{
										continue;
									}
									this.$self_$35137.mChar.nDirection = this.$self_$35137.transform.forward;
									if (160468 - 497619 == -337150)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (52905 - 495341 != -442435)
						{
							break;
						}
						continue;
					}
					else
					{
						if (!this.$self_$35137.mChar.isMine)
						{
							goto IL_3B8;
						}
						if (124463 - 3458 != 121005)
						{
							continue;
						}
						this.$hitLayer$35130 = 130816 - (1 << this.$self_$35137.gameObject.layer);
						if (102737 - 341704 == -238966)
						{
							continue;
						}
						this.$hitList$35131 = Damage.FindRecTarget(this.$self_$35137.transform.position, this.$self_$35137.transform.forward, (float)1, (float)1, (float)3, (float)3, this.$hitLayer$35130);
						if (216433 - 424043 == -207609)
						{
							continue;
						}
						this.$$iterator$10919$35134 = UnityRuntimeServices.GetEnumerator(this.$hitList$35131);
						if (88462 - 280526 == -192063)
						{
							continue;
						}
						while (this.$$iterator$10919$35134.MoveNext())
						{
							object obj2;
							object obj = obj2 = this.$$iterator$10919$35134.Current;
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$hitObject$35132 = (GameObject)obj2;
							if (266675 - 187377 != 79298)
							{
								goto IL_650;
							}
							if (this.$self_$35137.mChar.hit(1, this.$hitObject$35132, (int)(0.75f * (float)this.$self_$35137.mChar.atk), 4, 0, 0.3f * this.$self_$35137.transform.forward) != 0)
							{
								if (69096 - 209747 != -140651)
								{
									goto IL_650;
								}
								this.$hitPos$35133 = this.$hitObject$35132.collider.ClosestPointOnBounds(this.$self_$35137.transform.position + 0.6f * Vector3.up);
								if (33413 - 350607 != -317194)
								{
									goto IL_650;
								}
								UnityRuntimeServices.Update(this.$$iterator$10919$35134, this.$hitObject$35132);
								if (255348 - 520949 == -265600)
								{
									goto IL_650;
								}
								this.$self_$35137.RPC_rAttack_hit(this.$hitPos$35133, this.$self_$35137.transform.forward, 0);
								if (122572 - 367328 != -244756)
								{
									goto IL_650;
								}
								this.$self_$35137.ActionEvent("RPC_rAttack_hit", this.$hitPos$35133, this.$self_$35137.transform.forward, 0);
								if (160782 - 82732 == 78051)
								{
									goto IL_650;
								}
							}
						}
						if (216819 - 399614 != -182794)
						{
							goto Block_21;
						}
						continue;
					}
					IL_278:
					this.$self_$35137.mChar.actionState = "attack";
					if (171120 - 280091 == -108971)
					{
						this.$self_$35137.mChar.actionTime = Time.time;
						if (283695 - 185902 != 97794)
						{
							this.$self_$35137.mChar.myCommand = "rAttack";
							if (219153 - 585343 != -366189)
							{
								this.$self_$35137.mChar.addTimeOut("nAttack", (float)2);
								if (165320 - 75812 != 89509)
								{
									this.$self_$35137.transform.position = this.$mPos$35135;
									if (159769 - 343178 != -183408)
									{
										this.$self_$35137.transform.LookAt(this.$mPos$35135 + global::Math.vFlat(this.$tDir$35136));
										if (104835 - 226900 != -122064)
										{
											this.$self_$35137.animation.CrossFade("rAttack", 0.1f);
											if (107413 - 409235 == -301822)
											{
												this.$self_$35137.animation.wrapMode = WrapMode.Loop;
												if (184036 - 303519 == -119483)
												{
													this.$self_$35137.mChar.vMovement = this.$self_$35137.transform.forward;
													if (28137 - 521351 == -493214)
													{
														this.$self_$35137.mChar.moveSpeed = (float)6;
														if (215358 - 436257 != -220898)
														{
															if (this.$self_$35137.audio.isPlaying)
															{
																if (39759 - 434569 != -394810)
																{
																	continue;
																}
																this.$self_$35137.audio.Stop();
																if (202207 - 529658 == -327450)
																{
																	continue;
																}
															}
															if (this.$self_$35137.rAttack_ring)
															{
																if (196915 - 232314 == -35398)
																{
																	continue;
																}
																this.$self_$35137.mChar.createEffect(this.$self_$35137.rAttack_ring, this.$self_$35137.transform.position, this.$self_$35137.transform.rotation);
																if (128874 - 305234 == -176359)
																{
																	continue;
																}
															}
															else
															{
																Debug.LogError("Missing rAttack_ring effect");
																if (136051 - 487551 == -351499)
																{
																	continue;
																}
															}
															this.$i$35129 = 0;
															if (153209 - 116321 == 36888)
															{
																goto IL_F6;
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_C9:
				goto IL_96E;
				Block_21:
				IL_3B8:
				return this.Yield(2, new WaitForSeconds(0.15f));
				Block_49:
				IL_96E:
				return false;
			}

			// Token: 0x060058DC RID: 22748 RVA: 0x00AACE9C File Offset: 0x00AAB09C
			internal static bool jKYxF2ppXvgGo7WqcJIX()
			{
				return true;
			}

			// Token: 0x060058DD RID: 22749 RVA: 0x00AACEA0 File Offset: 0x00AAB0A0
			internal static bool Y5BKGdppQEjVbeNwis4V()
			{
				return false;
			}

			// Token: 0x0400619D RID: 24989
			internal int $i$35129;

			// Token: 0x0400619E RID: 24990
			internal int $hitLayer$35130;

			// Token: 0x0400619F RID: 24991
			internal UnityScript.Lang.Array $hitList$35131;

			// Token: 0x040061A0 RID: 24992
			internal GameObject $hitObject$35132;

			// Token: 0x040061A1 RID: 24993
			internal Vector3 $hitPos$35133;

			// Token: 0x040061A2 RID: 24994
			internal IEnumerator $$iterator$10919$35134;

			// Token: 0x040061A3 RID: 24995
			internal Vector3 $mPos$35135;

			// Token: 0x040061A4 RID: 24996
			internal Vector3 $tDir$35136;

			// Token: 0x040061A5 RID: 24997
			internal MoleTank $self_$35137;
		}
	}
}
