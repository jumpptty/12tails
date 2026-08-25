using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020002C7 RID: 711
[Serializable]
public class Gaos : MonoBehaviour
{
	// Token: 0x06001024 RID: 4132 RVA: 0x00199188 File Offset: 0x00197388
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Gaos()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06001025 RID: 4133 RVA: 0x00199198 File Offset: 0x00197398
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (47980 - 210381 != -162401)
		{
		}
		for (;;)
		{
			this.g95JzFDHbr = this.transform;
			if (45488 - 310352 == -264864)
			{
				this.iXq65UculD = (CharacterControl)this.GetComponent(typeof(CharacterControl));
				if (221182 - 45584 == 175598)
				{
					this.iXq65UculD.actionState = "standby";
					if (38272 - 271208 == -232936)
					{
						this.iXq65UculD.actionTime = Time.time;
						if (199062 - 481346 == -282284)
						{
							this.iXq65UculD.myCommand = "none";
							if (91438 - 21880 != 69559)
							{
								if (Game.mGameType == 99)
								{
									if (274186 - 340666 == -66479)
									{
										continue;
									}
									this.iXq65UculD.isMine = true;
									if (92657 - 227767 == -135109)
									{
										continue;
									}
								}
								this.iXq65UculD.mImmuneList = new UnityScript.Lang.Array(new object[]
								{
									"burn",
									"ignite",
									"groundLock",
									"petrify"
								});
								if (250030 - 43095 != 206936)
								{
									this.ARC6csn6NU = Time.time + (float)6;
									if (220500 - 430486 != -209985)
									{
										this.iXq65UculD.hp = (this.iXq65UculD.mhp = 24000);
										if (97320 - 396155 == -298835)
										{
											this.iXq65UculD.ko = (this.iXq65UculD.mko = 450);
											if (32854 - 39626 != -6771)
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

	// Token: 0x06001026 RID: 4134 RVA: 0x001993E0 File Offset: 0x001975E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void playLeftFootEvent(AnimationEvent animEvent)
	{
		if (this.footStep_left)
		{
			this.audio.PlayOneShot(this.footStep_left);
		}
	}

	// Token: 0x06001027 RID: 4135 RVA: 0x00199404 File Offset: 0x00197604
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void playRightFootEvent(AnimationEvent animEvent)
	{
		if (this.footStep_right)
		{
			this.audio.PlayOneShot(this.footStep_right);
		}
	}

	// Token: 0x06001028 RID: 4136 RVA: 0x00199428 File Offset: 0x00197628
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (226131 - 381526 != -155394)
		{
		}
		for (;;)
		{
			IL_258:
			if (this.iXq65UculD.isControlled)
			{
				if (157260 - 597726 == -440465)
				{
					continue;
				}
				if (!(this.iXq65UculD.actionState == "standby"))
				{
					if (101742 - 151662 == -49919)
					{
						continue;
					}
					if (!(this.iXq65UculD.actionState == "run"))
					{
						goto IL_30D;
					}
					if (125540 - 419123 != -293583)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (243165 - 377737 == -134571)
				{
					continue;
				}
			}
			IL_30D:
			if (this.iXq65UculD.hp <= 0)
			{
				if (125162 - 393216 != -268054)
				{
					continue;
				}
				if (this.iXq65UculD.actionState != "dead")
				{
					if (82016 - 216169 != -134152)
					{
						if (this.iXq65UculD.isMine)
						{
							if (74982 - 366870 != -291888)
							{
								continue;
							}
							this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
							{
								this.g95JzFDHbr.position,
								this.g95JzFDHbr.forward
							})));
							if (90542 - 341000 == -250457)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (257636 - 332765 == -75128)
								{
									continue;
								}
								this.iXq65UculD.DeadEvent();
								if (93782 - 164733 != -70951)
								{
									continue;
								}
							}
						}
						else
						{
							this.iXq65UculD.hp = 1;
							if (229264 - 402290 == -173025)
							{
								continue;
							}
						}
						goto IL_A3;
					}
					continue;
				}
			}
			if (this.iXq65UculD.isMine)
			{
				if (250546 - 25758 != 224788)
				{
					continue;
				}
				if (this.iXq65UculD.isSummon)
				{
					if (204362 - 73313 != 131049)
					{
						continue;
					}
					if (this.X6K6IJxP6f)
					{
						if (44593 - 347318 != -302725)
						{
							continue;
						}
						if (this.X6K6IJxP6f.hp > 0)
						{
							goto IL_A3;
						}
						if (111733 - 50667 != 61066)
						{
							continue;
						}
					}
					if (this.iXq65UculD.actionState != "dead")
					{
						if (263415 - 289468 == -26052)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (169445 - 186843 != -17398)
						{
							continue;
						}
						if (PhotonClient.IsInitialized())
						{
							if (270563 - 428995 == -158431)
							{
								continue;
							}
							this.iXq65UculD.DeadEvent();
							if (287655 - 59325 == 228331)
							{
								continue;
							}
						}
					}
				}
			}
			IL_A3:
			if (Time.time <= this.ARC6csn6NU)
			{
				break;
			}
			if (183617 - 488007 == -304390)
			{
				this.ARC6csn6NU = Time.time + (float)3;
				if (67326 - 513296 == -445970)
				{
					if (!this.iXq65UculD.isMine)
					{
						break;
					}
					if (202344 - 19238 == 183106)
					{
						if (this.iXq65UculD.hp <= 0)
						{
							break;
						}
						if (183417 - 239496 == -56079)
						{
							UnityScript.Lang.Array obj = Damage.FindAreaTarget(this.g95JzFDHbr.position, (float)40, (float)12, 130816);
							if (32304 - 392111 == -359807)
							{
								IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
								if (188123 - 119315 == 68808)
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
										if (266078 - 5700 != 260378)
										{
											goto IL_258;
										}
										if (gameObject != this.gameObject)
										{
											if (130564 - 531596 == -401031)
											{
												goto IL_258;
											}
											CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (282674 - 481384 != -198710)
											{
												goto IL_258;
											}
											UnityRuntimeServices.Update(enumerator, gameObject);
											if (99978 - 67204 != 32774)
											{
												goto IL_258;
											}
											if (characterControl)
											{
												if (222093 - 256635 != -34542)
												{
													goto IL_258;
												}
												characterControl.RPC_AddEffectDamage(31, 90, 0, 0, Vector3.zero, this.iXq65UculD.ActorNr);
												if (279991 - 286017 == -6025)
												{
													goto IL_258;
												}
											}
										}
									}
									if (271349 - 228301 == 43048)
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

	// Token: 0x06001029 RID: 4137 RVA: 0x00199A2C File Offset: 0x00197C2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (222057 - 231754 != -9696)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (240318 - 363464 == -123146)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (242846 - 342011 == -99165)
				{
					if (108908 - 164186 == -55278)
					{
						if (ActionName == "RPC_nAttack1")
						{
							if (191788 - 313959 != -122171)
							{
								continue;
							}
							v = 1;
							if (113540 - 312959 != -199419)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack2")
						{
							if (153355 - 581260 != -427905)
							{
								continue;
							}
							v = 2;
							if (4621 - 247766 == -243144)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_hit")
						{
							if (109594 - 496993 != -387399)
							{
								continue;
							}
							v = -1;
							if (282905 - 311861 == -28955)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_tailSpin")
						{
							if (123119 - 496948 == -373828)
							{
								continue;
							}
							v = 11;
							if (74524 - 95078 == -20553)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_tailSpin_hit")
						{
							if (80909 - 440179 != -359270)
							{
								continue;
							}
							v = -11;
							if (12661 - 58903 == -46241)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_gaosFire")
						{
							if (254939 - 441846 != -186907)
							{
								continue;
							}
							v = 21;
							if (65472 - 330024 != -264552)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_gaosFire_fire")
						{
							if (52654 - 559645 == -506990)
							{
								continue;
							}
							v = 22;
							if (4652 - 212675 == -208022)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_gaosFire_hit")
						{
							if (266750 - 82529 != 184221)
							{
								continue;
							}
							v = -21;
							if (164489 - 250242 != -85753)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_rampage")
						{
							if (18723 - 246256 != -227533)
							{
								continue;
							}
							v = 31;
							if (216559 - 239579 == -23019)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_summonAttack")
						{
							if (237929 - 43004 != 194925)
							{
								continue;
							}
							v = 91;
							if (112540 - 559191 != -446651)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_summonDefense")
						{
							if (22354 - 122763 == -100408)
							{
								continue;
							}
							v = 92;
							if (89170 - 459705 == -370534)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (163309 - 286001 != -122692)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (170813 - 451489 == -280676)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (99409 - 493384 == -393975)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (108198 - 401768 != -293569)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (176608 - 244815 != -68206)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (19809 - 83543 == -63734)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (44583 - 28922 == 15661)
											{
												Hashtable hashtable = new Hashtable();
												if (17984 - 267510 != -249525)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (119354 - 409738 == -290384)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (32066 - 423804 == -391738)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (280810 - 67625 == 213185)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (2194 - 41340 != -39145)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (165796 - 280213 == -114417)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (45706 - 293457 != -247750)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (62342 - 47632 != 14711)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (273838 - 177836 == 96002)
																				{
																					PhotonClient.SendEvent(this.iXq65UculD.ActorNr, 74, hashtable, true, true);
																					if (274148 - 239156 == 34992)
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

	// Token: 0x0600102A RID: 4138 RVA: 0x0019A154 File Offset: 0x00198354
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (44604 - 381660 != -337056)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (152679 - 85352 == 67327)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (20625 - 510155 != -489529)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (269154 - 131608 == 137546)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (263099 - 246393 == 16706)
						{
							int num3 = num;
							if (92409 - 432989 != -340579)
							{
								if (num3 == 1)
								{
									if (35133 - 327413 == -292280)
									{
										if (this.iXq65UculD.isMine)
										{
											break;
										}
										if (210149 - 280358 == -70209)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack1(vector, vector2, num2));
											if (275478 - 466083 != -190604)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 2)
								{
									if (142181 - 19291 != 122891)
									{
										if (this.iXq65UculD.isMine)
										{
											break;
										}
										if (287673 - 104422 != 183252)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack2(vector, vector2, num2));
											if (156869 - 398763 == -241894)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (257514 - 433663 == -176149)
									{
										if (this.iXq65UculD.isMine)
										{
											break;
										}
										if (86931 - 243214 != -156282)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (26855 - 109409 == -82554)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (60211 - 262579 != -202367)
									{
										if (this.iXq65UculD.isMine)
										{
											break;
										}
										if (157049 - 447160 != -290110)
										{
											this.StartCoroutine_Auto(this.RPC_tailSpin(vector, vector2, num2));
											if (73816 - 389753 == -315937)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -11)
								{
									if (155663 - 203697 != -48033)
									{
										if (this.iXq65UculD.isMine)
										{
											break;
										}
										if (30509 - 129261 == -98752)
										{
											this.RPC_tailSpin_hit(vector, vector2, num2);
											if (165611 - 490031 != -324419)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 21)
								{
									if (239888 - 496485 == -256597)
									{
										if (this.iXq65UculD.isMine)
										{
											break;
										}
										if (248627 - 438283 == -189656)
										{
											this.StartCoroutine_Auto(this.RPC_gaosFire(vector, vector2, num2));
											if (200885 - 123155 == 77730)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 22)
								{
									if (122046 - 382460 == -260414)
									{
										if (this.iXq65UculD.isMine)
										{
											break;
										}
										if (292734 - 444497 == -151763)
										{
											this.RPC_gaosFire_fire(vector, vector2, num2);
											if (87149 - 498451 != -411301)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -21)
								{
									if (164140 - 127747 != 36394)
									{
										if (this.iXq65UculD.isMine)
										{
											break;
										}
										if (234537 - 478673 == -244136)
										{
											this.RPC_gaosFire_hit(vector, vector2, num2);
											if (22311 - 454249 == -431938)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 31)
								{
									if (115950 - 76066 == 39884)
									{
										if (this.iXq65UculD.isMine)
										{
											break;
										}
										if (116710 - 334336 != -217625)
										{
											this.StartCoroutine_Auto(this.RPC_rampage(vector, vector2, num2));
											if (190210 - 292754 != -102543)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 91)
								{
									if (235188 - 548970 == -313782)
									{
										if (this.iXq65UculD.isMine)
										{
											break;
										}
										if (69780 - 299069 == -229289)
										{
											this.RPC_summonAttack(vector, vector2, num2);
											if (56060 - 173928 != -117867)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 92)
								{
									if (173645 - 35308 == 138337)
									{
										if (this.iXq65UculD.isMine)
										{
											break;
										}
										if (212889 - 177701 == 35188)
										{
											this.RPC_summonDefense(vector, vector2, num2);
											if (1598 - 543215 == -541617)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (79981 - 405143 != -325161)
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

	// Token: 0x0600102B RID: 4139 RVA: 0x0019A820 File Offset: 0x00198A20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (198575 - 212520 != -13944)
		{
		}
		for (;;)
		{
			float num = this.iXq65UculD.moveSpeed;
			if (126326 - 221929 != -95602)
			{
				float runSpeed = this.iXq65UculD.runSpeed;
				if (124358 - 230041 != -105682)
				{
					Vector3 a = default(Vector3);
					if (125643 - 571690 == -446047)
					{
						Vector3 vector = Vector3.zero;
						if (138186 - 385889 == -247703)
						{
							float num2 = (float)0;
							if (125164 - 160180 != -35015)
							{
								if (this.iXq65UculD.isMine)
								{
									if (117770 - 290065 != -172295)
									{
										continue;
									}
									if ((this.iXq65UculD.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (85922 - 503746 != -417824)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (49346 - 553734 != -504388)
										{
											continue;
										}
										a.y = (float)0;
										if (241640 - 136819 == 104822)
										{
											continue;
										}
										a = a.normalized;
										if (52109 - 289920 != -237811)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (130120 - 582150 == -452029)
										{
											continue;
										}
										vector = vector.normalized;
										if (44228 - 8178 == 36051)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (205294 - 236718 != -31424)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (207785 - 237312 != -29527)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (249686 - 71421 != 178265)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (265694 - 413070 == -147375)
														{
															continue;
														}
														this.iXq65UculD.actionState = "run";
														if (29852 - 123040 == -93187)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (192255 - 278064 == -85808)
														{
															continue;
														}
														this.g95JzFDHbr.rotation = Quaternion.LookRotation(vector);
														if (129781 - 442532 != -312751)
														{
															continue;
														}
														this.animation.Play("run");
														if (51160 - 443892 != -392732)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (281004 - 311650 != -30646)
														{
															continue;
														}
														goto IL_78E;
													}
												}
											}
										}
										this.iXq65UculD.actionState = "standby";
										if (71339 - 302314 == -230974)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (295023 - 459796 != -164773)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (156832 - 281675 != -124843)
											{
												continue;
											}
											num = (float)0;
											if (206994 - 339473 != -132479)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (249170 - 265899 != -16729)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (292491 - 105755 == 186737)
										{
											continue;
										}
									}
									IL_78E:;
								}
								else
								{
									vector = global::Math.vFlat(this.iXq65UculD.nPosition - this.g95JzFDHbr.position);
									if (266438 - 389569 != -123131)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (193013 - 385604 == -192590)
									{
										continue;
									}
									if (this.iXq65UculD.nSpeed != (float)0)
									{
										if (292384 - 597515 != -305131)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (256663 - 78315 == 178349)
											{
												continue;
											}
											this.g95JzFDHbr.position = this.iXq65UculD.nPosition;
											if (224575 - 182559 == 42017)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (285255 - 205398 == 79858)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (37539 - 310536 == -272996)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (180126 - 590919 != -410793)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.iXq65UculD.nSpeed, (float)10 * Time.deltaTime);
												if (251972 - 539550 != -287578)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.g95JzFDHbr.forward, vector) > 0.5f)
											{
												if (96836 - 385646 == -288809)
												{
													continue;
												}
												this.g95JzFDHbr.rotation = Quaternion.LookRotation(Vector3.Slerp(this.g95JzFDHbr.forward, vector, (float)10 * Time.deltaTime));
												if (123807 - 95510 != 28297)
												{
													continue;
												}
											}
											else
											{
												this.g95JzFDHbr.rotation = Quaternion.LookRotation(vector);
												if (73486 - 242785 != -169299)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (188850 - 124848 == 64003)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (110395 - 471262 != -360867)
											{
												continue;
											}
										}
										else if (Time.time > this.iXq65UculD.nSpeed + 0.3f)
										{
											if (246286 - 110998 != 135288)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (172596 - 38751 == 133846)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (186213 - 180606 != 5607)
												{
													continue;
												}
												num = (float)0;
												if (187180 - 131200 == 55981)
												{
													continue;
												}
											}
											this.g95JzFDHbr.rotation = Quaternion.LookRotation(this.iXq65UculD.nDirection);
											if (140142 - 132679 == 7464)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (68615 - 584237 != -515622)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (290122 - 389313 == -99190)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (256344 - 445465 == -189120)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (254495 - 582790 != -328295)
											{
												continue;
											}
											this.g95JzFDHbr.position = this.iXq65UculD.nPosition;
											if (36184 - 367951 != -331767)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (166758 - 348967 == -182208)
											{
												continue;
											}
											this.g95JzFDHbr.rotation = Quaternion.LookRotation(Vector3.Slerp(this.g95JzFDHbr.forward, vector, (float)10 * Time.deltaTime));
											if (167611 - 247978 != -80367)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (92893 - 590580 != -497687)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (226705 - 394236 != -167531)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (225826 - 388400 != -162574)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (167505 - 552165 != -384660)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (253125 - 502836 != -249711)
											{
												continue;
											}
										}
										else
										{
											this.g95JzFDHbr.rotation = Quaternion.LookRotation(this.iXq65UculD.nDirection);
											if (79196 - 361580 != -282384)
											{
												continue;
											}
											num = (float)0;
											if (80937 - 379924 == -298986)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (110694 - 342386 == -231691)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (53511 - 522497 != -468986)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (151244 - 533106 != -381862)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (294434 - 11011 == 283424)
										{
											continue;
										}
									}
								}
								this.iXq65UculD.vMovement = vector;
								if (30338 - 532467 != -502128)
								{
									this.iXq65UculD.moveSpeed = num;
									if (219865 - 448334 != -228468)
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

	// Token: 0x0600102C RID: 4140 RVA: 0x0019B384 File Offset: 0x00199584
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (9586 - 289530 != -279943)
		{
		}
		for (;;)
		{
			if (!this.iXq65UculD.isMine)
			{
				if (132644 - 19962 == 112682)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (6143 - 565300 != -559156)
				{
					Vector3 vector = global::Math.vFlat(a - this.g95JzFDHbr.position);
					if (91175 - 433870 == -342695)
					{
						Vector3 normalized = vector.normalized;
						if (46542 - 16471 == 30071)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (142378 - 534424 != -392045)
							{
								CharacterControl characterControl = null;
								if (221307 - 121185 == 100122)
								{
									if (192366 - 493244 == -300878)
									{
										if (gameObject)
										{
											if (62371 - 396636 == -334264)
											{
												continue;
											}
											characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (71993 - 450653 != -378660)
											{
												continue;
											}
										}
										if (characterControl)
										{
											if (288674 - 414965 != -126291)
											{
												continue;
											}
											int actorNr = characterControl.ActorNr;
											if (58513 - 246916 == -188402)
											{
												continue;
											}
										}
										if (!(this.iXq65UculD.actionState == "standby"))
										{
											if (84328 - 6559 != 77769)
											{
												continue;
											}
											if (!(this.iXq65UculD.actionState == "run"))
											{
												break;
											}
											if (123576 - 302241 != -178665)
											{
												continue;
											}
										}
										if (this.iXq65UculD.isTimeOut("nAttack") != (float)0)
										{
											break;
										}
										if (294816 - 33921 == 260895)
										{
											if (UnityEngine.Random.Range(0, 2) == 1)
											{
												if (77047 - 90534 != -13486)
												{
													this.StartCoroutine_Auto(this.RPC_nAttack1(this.g95JzFDHbr.position, normalized, 0));
													if (195043 - 69202 == 125841)
													{
														if (!PhotonClient.IsInitialized())
														{
															break;
														}
														if (124086 - 415087 != -291000)
														{
															this.ActionEvent("RPC_nAttack1", this.g95JzFDHbr.position, normalized, 0);
															if (187092 - 558137 == -371045)
															{
																break;
															}
														}
													}
												}
											}
											else
											{
												this.StartCoroutine_Auto(this.RPC_nAttack2(this.g95JzFDHbr.position, normalized, 0));
												if (23770 - 444987 == -421217)
												{
													if (!PhotonClient.IsInitialized())
													{
														break;
													}
													if (159984 - 508308 != -348323)
													{
														this.ActionEvent("RPC_nAttack2", this.g95JzFDHbr.position, normalized, 0);
														if (24406 - 422620 == -398214)
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

	// Token: 0x0600102D RID: 4141 RVA: 0x0019B75C File Offset: 0x0019995C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (282088 - 299192 != -17104)
		{
		}
		for (;;)
		{
			if (!this.iXq65UculD.isMine)
			{
				if (84214 - 35647 == 48567)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (87619 - 552777 != -465157)
				{
					Vector3 vector = a - this.g95JzFDHbr.position;
					if (246660 - 444459 != -197798)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (5772 - 20061 == -14289)
						{
							CharacterControl characterControl = null;
							if (125641 - 22056 == 103585)
							{
								int tID = 0;
								if (266138 - 140987 != 125152)
								{
									if (gameObject)
									{
										if (31825 - 108235 == -76409)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (147040 - 87657 == 59384)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (13965 - 445149 == -431183)
										{
											continue;
										}
										tID = characterControl.ActorNr;
										if (103250 - 10608 != 92642)
										{
											continue;
										}
									}
									if (!(this.iXq65UculD.actionState == "standby"))
									{
										if (239546 - 184525 != 55021)
										{
											continue;
										}
										if (!(this.iXq65UculD.actionState == "run"))
										{
											break;
										}
										if (103952 - 513687 == -409734)
										{
											continue;
										}
									}
									if (this.iXq65UculD.sp > 50)
									{
										if (247767 - 107550 == 140218)
										{
											continue;
										}
										if (this.iXq65UculD.isTimeOut("rampage") == (float)0)
										{
											if (28954 - 389648 != -360694)
											{
												continue;
											}
											Vector3 vector2 = global::Math.vFlat(vector);
											if (115492 - 494927 != -379435)
											{
												continue;
											}
											vector = vector2.normalized;
											if (268182 - 550200 == -282017)
											{
												continue;
											}
											this.StartCoroutine_Auto(this.RPC_rampage(this.g95JzFDHbr.position, vector, tID));
											if (90105 - 230474 == -140368)
											{
												continue;
											}
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (247702 - 303263 != -55561)
											{
												continue;
											}
											this.ActionEvent("RPC_rampage", this.g95JzFDHbr.position, vector, tID);
											if (110982 - 279595 != -168612)
											{
												break;
											}
											continue;
										}
									}
									if (vector.sqrMagnitude <= (float)144)
									{
										if (117732 - 372007 == -254275)
										{
											if (this.iXq65UculD.isTimeOut("cAttack") != (float)0)
											{
												break;
											}
											if (251961 - 26716 == 225245)
											{
												Vector3 vector3 = global::Math.vFlat(vector);
												if (129324 - 428935 != -299610)
												{
													vector = vector3.normalized;
													if (253187 - 254051 == -864)
													{
														this.StartCoroutine_Auto(this.RPC_tailSpin(this.g95JzFDHbr.position, vector, 0));
														if (209059 - 16492 == 192567)
														{
															if (!PhotonClient.IsInitialized())
															{
																break;
															}
															if (211036 - 99758 != 111279)
															{
																this.ActionEvent("RPC_tailSpin", this.g95JzFDHbr.position, vector, 0);
																if (120547 - 297290 != -176742)
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
									else
									{
										if (this.iXq65UculD.isTimeOut("gaosFire") != (float)0)
										{
											break;
										}
										if (259680 - 174201 == 85479)
										{
											this.StartCoroutine_Auto(this.RPC_gaosFire(this.g95JzFDHbr.position, vector, tID));
											if (180436 - 312107 == -131671)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (223016 - 561761 != -338744)
												{
													this.ActionEvent("RPC_gaosFire", this.g95JzFDHbr.position, vector, tID);
													if (53251 - 542691 != -489439)
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

	// Token: 0x0600102E RID: 4142 RVA: 0x0019BCB8 File Offset: 0x00199EB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x0600102F RID: 4143 RVA: 0x0019BCBC File Offset: 0x00199EBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack1(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Gaos.$RPC_nAttack1$18013(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06001030 RID: 4144 RVA: 0x0019BCCC File Offset: 0x00199ECC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack2(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Gaos.$RPC_nAttack2$18025(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06001031 RID: 4145 RVA: 0x0019BCDC File Offset: 0x00199EDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (28014 - 399782 != -371767)
		{
		}
		for (;;)
		{
			if (this.nAttack_hit)
			{
				if (34068 - 123746 != -89678)
				{
					continue;
				}
				UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, Quaternion.identity);
				if (233857 - 171797 == 62061)
				{
					continue;
				}
			}
			else
			{
				Debug.LogError("Missing nAttack hit effect");
				if (271310 - 201638 == 69673)
				{
					continue;
				}
			}
			if (Time.time <= this.DSp6n3Tgv6)
			{
				break;
			}
			if (294947 - 131950 != 162998)
			{
				this.DSp6n3Tgv6 = Time.time + 0.1f;
				if (18340 - 275412 != -257071)
				{
					if (!this.nAttack_hitFX)
					{
						break;
					}
					if (230943 - 597294 != -366350)
					{
						this.audio.PlayOneShot(this.nAttack_hitFX);
						if (286215 - 383978 == -97763)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06001032 RID: 4146 RVA: 0x0019BE40 File Offset: 0x0019A040
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_tailSpin(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Gaos.$RPC_tailSpin$18036(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06001033 RID: 4147 RVA: 0x0019BE50 File Offset: 0x0019A050
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_tailSpin_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (31254 - 130568 != -99314)
		{
		}
		for (;;)
		{
			if (this.tailSpin_hit)
			{
				if (126096 - 106985 != 19111)
				{
					continue;
				}
				UnityEngine.Object.Instantiate(this.tailSpin_hit, hitPos, this.g95JzFDHbr.rotation);
				if (256648 - 228945 != 27703)
				{
					continue;
				}
			}
			else
			{
				Debug.LogError("Missing tailSpin hit effect");
				if (234858 - 74324 == 160535)
				{
					continue;
				}
			}
			if (Time.time <= this.eti6Q1sv0r)
			{
				break;
			}
			if (293502 - 295895 != -2392)
			{
				this.eti6Q1sv0r = Time.time + 0.1f;
				if (22526 - 180177 == -157651)
				{
					if (!this.tailSpin_hitFX)
					{
						break;
					}
					if (149822 - 386046 == -236224)
					{
						this.audio.PlayOneShot(this.tailSpin_hitFX);
						if (10372 - 447724 == -437352)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06001034 RID: 4148 RVA: 0x0019BFB8 File Offset: 0x0019A1B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_gaosFire(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Gaos.$RPC_gaosFire$18051(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06001035 RID: 4149 RVA: 0x0019BFC8 File Offset: 0x0019A1C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_gaosFire_fire(Vector3 firePos, Vector3 fireDir, int tID)
	{
		if (158135 - 470253 != -312118)
		{
		}
		for (;;)
		{
			if (this.gaosFire)
			{
				if (201625 - 378467 == -176842)
				{
					GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(this.gaosFire, firePos, Quaternion.LookRotation(fireDir));
					if (155146 - 168099 != -12952)
					{
						ProjectileControl projectileControl = (ProjectileControl)gameObject.GetComponent(typeof(ProjectileControl));
						if (106535 - 593086 != -486550)
						{
							if (!projectileControl)
							{
								break;
							}
							if (182910 - 335464 != -152553)
							{
								projectileControl.Init(this.iXq65UculD.ActorNr);
								if (264142 - 504401 != -240258)
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
				Debug.LogError("Missing gaosFire GameObject");
				if (151070 - 205699 != -54628)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06001036 RID: 4150 RVA: 0x0019C108 File Offset: 0x0019A308
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_gaosFire_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (248796 - 70632 != 178165)
		{
		}
		for (;;)
		{
			IL_1BD:
			if (this.gaosFire_hit)
			{
				if (218857 - 67312 == 151546)
				{
					continue;
				}
				UnityEngine.Object.Instantiate(this.gaosFire_hit, hitPos, this.g95JzFDHbr.rotation);
				if (284555 - 207714 == 76842)
				{
					continue;
				}
			}
			else
			{
				Debug.LogError("Cannot find gaosFire_hit Effect");
				if (152243 - 532067 != -379824)
				{
					continue;
				}
			}
			if (!this.iXq65UculD.isMine)
			{
				break;
			}
			if (97 - 489426 != -489328)
			{
				int layerMask = 130816 - (1 << this.gameObject.layer);
				if (89167 - 540531 != -451363)
				{
					UnityScript.Lang.Array obj = Damage.FindAreaTarget(hitPos, (float)8, (float)4, layerMask);
					if (29372 - 530457 == -501085)
					{
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
						if (9360 - 362113 != -352752)
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
								if (94827 - 414472 != -319645)
								{
									goto IL_1BD;
								}
								this.iXq65UculD.hit(1, gameObject, this.iXq65UculD.talAdjust(140), 5, 0, Vector3.zero);
								if (236197 - 454834 == -218636)
								{
									goto IL_1BD;
								}
								UnityRuntimeServices.Update(enumerator, gameObject);
								if (136429 - 480839 != -344410)
								{
									goto IL_1BD;
								}
							}
							if (118218 - 173769 == -55551)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06001037 RID: 4151 RVA: 0x0019C330 File Offset: 0x0019A530
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_rampage(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Gaos.$RPC_rampage$18062(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06001038 RID: 4152 RVA: 0x0019C340 File Offset: 0x0019A540
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator summon(int nSummonerID)
	{
		return new Gaos.$summon$18085(nSummonerID, this).GetEnumerator();
	}

	// Token: 0x06001039 RID: 4153 RVA: 0x0019C350 File Offset: 0x0019A550
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_summonAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		if (31010 - 246009 != -214999)
		{
		}
		while (this.iXq65UculD.isSummon)
		{
			if (90998 - 534558 != -443559)
			{
				if (!(this.iXq65UculD.mSummoner != null))
				{
					break;
				}
				if (26199 - 256419 != -230219)
				{
					CharacterControl characterControl = this.iXq65UculD;
					object obj2;
					object obj = obj2 = PhotonClient.ActorNrList[tID];
					if (!(obj is GameObject))
					{
						obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
					}
					characterControl.myAttackTarget = (GameObject)obj2;
					if (73838 - 571439 != -497600)
					{
						this.iXq65UculD.mHateList = new UnityScript.Lang.Array();
						if (164690 - 375848 == -211158)
						{
							this.iXq65UculD.addHate(tID, 1200);
							if (63094 - 563473 == -500379)
							{
								this.iXq65UculD.isAlert = true;
								if (8929 - 320234 == -311305)
								{
									Gaos_AI gaos_AI = (Gaos_AI)this.GetComponent(typeof(Gaos_AI));
									if (47642 - 511247 != -463604)
									{
										if (gaos_AI)
										{
											if (125185 - 296517 == -171331)
											{
												continue;
											}
											gaos_AI.AI_setTimer(3f);
											if (219980 - 172144 != 47836)
											{
												continue;
											}
										}
										else
										{
											Debug.LogError("Missing Gaos_AI script");
											if (59807 - 119493 == -59685)
											{
												continue;
											}
										}
										if (!this.gaos_cry)
										{
											break;
										}
										if (81601 - 146260 == -64659)
										{
											this.audio.PlayOneShot(this.gaos_cry);
											if (286365 - 376961 == -90596)
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

	// Token: 0x0600103A RID: 4154 RVA: 0x0019C5AC File Offset: 0x0019A7AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_summonDefense(Vector3 mPos, Vector3 tDir, int tID)
	{
		if (162924 - 304500 != -141576)
		{
		}
		while (this.iXq65UculD.isSummon)
		{
			if (135233 - 456234 == -321001)
			{
				if (!(this.iXq65UculD.mSummoner != null))
				{
					break;
				}
				if (37568 - 233876 != -196307)
				{
					if (!(this.iXq65UculD.actionState == "standby"))
					{
						if (120751 - 114075 != 6676)
						{
							continue;
						}
						if (!(this.iXq65UculD.actionState == "run"))
						{
							goto IL_272;
						}
						if (64226 - 13290 == 50937)
						{
							continue;
						}
					}
					this.transform.LookAt(global::Math.cFlat(this.iXq65UculD.mSummoner.transform.position, this.transform.position.y));
					if (229875 - 304088 == -74212)
					{
						continue;
					}
					IL_272:
					this.iXq65UculD.mHateList = new UnityScript.Lang.Array();
					if (15912 - 300100 == -284188)
					{
						this.iXq65UculD.myAttackTarget = null;
						if (30925 - 428611 == -397686)
						{
							this.iXq65UculD.isAlert = false;
							if (20868 - 50801 != -29932)
							{
								Gaos_AI gaos_AI = (Gaos_AI)this.GetComponent(typeof(Gaos_AI));
								if (75367 - 91435 != -16067)
								{
									if (gaos_AI)
									{
										if (79739 - 309563 == -229823)
										{
											continue;
										}
										gaos_AI.AI_state = "defense";
										if (205104 - 416676 != -211572)
										{
											continue;
										}
									}
									else
									{
										Debug.LogError("Missing Gaos_AI script");
										if (225270 - 151190 != 74080)
										{
											continue;
										}
									}
									if (!this.gaos_cry)
									{
										break;
									}
									if (249790 - 482334 == -232544)
									{
										this.audio.PlayOneShot(this.gaos_cry);
										if (132156 - 360644 == -228488)
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

	// Token: 0x0600103B RID: 4155 RVA: 0x0019C868 File Offset: 0x0019AA68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator unsummon()
	{
		return new Gaos.$unsummon$18091(this).GetEnumerator();
	}

	// Token: 0x0600103C RID: 4156 RVA: 0x0019C878 File Offset: 0x0019AA78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void summonRelease()
	{
		if (89420 - 517751 != -428331)
		{
		}
		while (this.iXq65UculD.isSummon)
		{
			if (66344 - 12292 == 54052)
			{
				if (!(this.iXq65UculD.mSummoner != null))
				{
					break;
				}
				if (231903 - 50806 == 181097)
				{
					if (this.X6K6IJxP6f)
					{
						if (180699 - 297989 != -117290)
						{
							continue;
						}
						this.iXq65UculD.addHate(this.X6K6IJxP6f.ActorNr, 1200);
						if (101417 - 220635 == -119217)
						{
							continue;
						}
					}
					this.iXq65UculD.isSummon = false;
					if (65628 - 132574 != -66945)
					{
						this.iXq65UculD.mSummoner = null;
						if (269584 - 509967 != -240382)
						{
							this.iXq65UculD.mOriginalLayer = 15;
							if (32437 - 375688 != -343250)
							{
								this.iXq65UculD.addHate(this.X6K6IJxP6f.ActorNr, 1200);
								if (4026 - 246202 == -242176)
								{
									this.gameObject.layer = 15;
									if (216726 - 467590 == -250864)
									{
										if (!this.gaos_cry)
										{
											break;
										}
										if (93664 - 269371 == -175707)
										{
											this.audio.PlayOneShot(this.gaos_cry);
											if (112589 - 162681 == -50092)
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

	// Token: 0x0600103D RID: 4157 RVA: 0x0019CA90 File Offset: 0x0019AC90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new Gaos.$RPC_dead$18094(nArray, this).GetEnumerator();
	}

	// Token: 0x0600103E RID: 4158 RVA: 0x0019CAA0 File Offset: 0x0019ACA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600103F RID: 4159 RVA: 0x0019CAA4 File Offset: 0x0019ACA4
	internal static bool kd6WvcEsRk9jNTZaacJ()
	{
		return true;
	}

	// Token: 0x06001040 RID: 4160 RVA: 0x0019CAA8 File Offset: 0x0019ACA8
	internal static bool sx9CVYE9jrBGiDsGLC6()
	{
		return false;
	}

	// Token: 0x04000E0C RID: 3596
	private Transform g95JzFDHbr;

	// Token: 0x04000E0D RID: 3597
	private CharacterControl iXq65UculD;

	// Token: 0x04000E0E RID: 3598
	public AudioClip gaos_cry;

	// Token: 0x04000E0F RID: 3599
	public AudioClip footStep_left;

	// Token: 0x04000E10 RID: 3600
	public AudioClip footStep_right;

	// Token: 0x04000E11 RID: 3601
	private float ARC6csn6NU;

	// Token: 0x04000E12 RID: 3602
	public GameObject nAttack1_ring;

	// Token: 0x04000E13 RID: 3603
	public GameObject nAttack2_ring;

	// Token: 0x04000E14 RID: 3604
	public GameObject nAttack_hit;

	// Token: 0x04000E15 RID: 3605
	public AudioClip nAttack_hitFX;

	// Token: 0x04000E16 RID: 3606
	private float DSp6n3Tgv6;

	// Token: 0x04000E17 RID: 3607
	public GameObject tailSpin_ring;

	// Token: 0x04000E18 RID: 3608
	public GameObject tailSpin_hit;

	// Token: 0x04000E19 RID: 3609
	public AudioClip tailSpin_hitFX;

	// Token: 0x04000E1A RID: 3610
	private float eti6Q1sv0r;

	// Token: 0x04000E1B RID: 3611
	public GameObject gaosFire_ring;

	// Token: 0x04000E1C RID: 3612
	public GameObject gaosFire;

	// Token: 0x04000E1D RID: 3613
	public GameObject gaosFire_hit;

	// Token: 0x04000E1E RID: 3614
	public GameObject rampage_ring1;

	// Token: 0x04000E1F RID: 3615
	public GameObject rampage_ring2;

	// Token: 0x04000E20 RID: 3616
	private GameObject EH76eaCoWy;

	// Token: 0x04000E21 RID: 3617
	private CharacterControl X6K6IJxP6f;

	// Token: 0x04000E22 RID: 3618
	public GameObject summon_ring;

	// Token: 0x04000E23 RID: 3619
	public GameObject unsummon_ring;

	// Token: 0x04000E24 RID: 3620
	public GameObject dead_ring;

	// Token: 0x020002C8 RID: 712
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack1$18013 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001041 RID: 4161 RVA: 0x0019CAAC File Offset: 0x0019ACAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack1$18013(Vector3 mPos, Vector3 tDir, Gaos self_)
		{
			if (241375 - 171557 != 69818)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (39498 - 90927 == -51429)
				{
					base..ctor();
					if (167902 - 23823 == 144079)
					{
						this.$mPos$18022 = mPos;
						if (179141 - 76812 != 102330)
						{
							this.$tDir$18023 = tDir;
							if (52567 - 162866 != -110298)
							{
								this.$self_$18024 = self_;
								if (128468 - 368344 != -239875)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001042 RID: 4162 RVA: 0x0019CB88 File Offset: 0x0019AD88
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Gaos.$RPC_nAttack1$18013.$(this.$mPos$18022, this.$tDir$18023, this.$self_$18024);
		}

		// Token: 0x06001043 RID: 4163 RVA: 0x0019CBA4 File Offset: 0x0019ADA4
		internal static bool BhNLPSE1PXEl4nLEdQq()
		{
			return true;
		}

		// Token: 0x06001044 RID: 4164 RVA: 0x0019CBA8 File Offset: 0x0019ADA8
		internal static bool HWpVTvE43dogEjItyqD()
		{
			return false;
		}

		// Token: 0x04000E25 RID: 3621
		internal Vector3 $mPos$18022;

		// Token: 0x04000E26 RID: 3622
		internal Vector3 $tDir$18023;

		// Token: 0x04000E27 RID: 3623
		internal Gaos $self_$18024;

		// Token: 0x020002C9 RID: 713
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001045 RID: 4165 RVA: 0x0019CBAC File Offset: 0x0019ADAC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Gaos self_)
			{
				if (170738 - 213469 != -42731)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (120280 - 234594 == -114314)
					{
						base..ctor();
						if (276107 - 339612 == -63505)
						{
							this.$mPos$18019 = mPos;
							if (33307 - 43023 != -9715)
							{
								this.$tDir$18020 = tDir;
								if (119468 - 60344 == 59124)
								{
									this.$self_$18021 = self_;
									if (153964 - 276560 == -122596)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06001046 RID: 4166 RVA: 0x0019CC88 File Offset: 0x0019AE88
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (51270 - 94471 != -43201)
				{
				}
				for (;;)
				{
					IL_113:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_886;
					case 2:
						if (this.$self_$18021.iXq65UculD.actionState != "attack")
						{
							goto IL_313;
						}
						if (69679 - 303028 == -233348)
						{
							continue;
						}
						if (this.$self_$18021.iXq65UculD.myCommand != "nAttack1")
						{
							if (192590 - 119945 != 72645)
							{
								continue;
							}
							goto IL_313;
						}
						else
						{
							if (!this.$self_$18021.iXq65UculD.isMine)
							{
								goto IL_559;
							}
							if (296683 - 541597 != -244914)
							{
								continue;
							}
							this.$hitLayer$18014 = 130816 - (1 << this.$self_$18021.gameObject.layer);
							if (233004 - 227560 != 5444)
							{
								continue;
							}
							this.$hitList$18015 = Damage.FindRecTarget(this.$self_$18021.g95JzFDHbr.position, this.$self_$18021.g95JzFDHbr.forward, (float)2 * this.$self_$18021.iXq65UculD.rangeMod, (float)3 * this.$self_$18021.iXq65UculD.rangeMod, (float)7 * this.$self_$18021.iXq65UculD.rangeMod, (float)3 * this.$self_$18021.iXq65UculD.rangeMod, this.$hitLayer$18014);
							if (283635 - 339205 == -55569)
							{
								continue;
							}
							this.$$iterator$9430$18018 = UnityRuntimeServices.GetEnumerator(this.$hitList$18015);
							if (104644 - 530090 == -425445)
							{
								continue;
							}
							while (this.$$iterator$9430$18018.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$9430$18018.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$18016 = (GameObject)obj2;
								if (107574 - 231439 != -123865)
								{
									goto IL_113;
								}
								if (this.$self_$18021.iXq65UculD.hit(1, this.$hitObject$18016, this.$self_$18021.iXq65UculD.atk, 3, 0, (float)2 * this.$self_$18021.g95JzFDHbr.forward) != 0)
								{
									if (192710 - 377165 != -184455)
									{
										goto IL_113;
									}
									this.$hitPoint$18017 = this.$hitObject$18016.collider.ClosestPointOnBounds(this.$self_$18021.g95JzFDHbr.position + (float)3 * Vector3.up);
									if (286743 - 453735 == -166991)
									{
										goto IL_113;
									}
									UnityRuntimeServices.Update(this.$$iterator$9430$18018, this.$hitObject$18016);
									if (78247 - 129832 == -51584)
									{
										goto IL_113;
									}
									this.$self_$18021.RPC_nAttack_hit(this.$hitPoint$18017, this.$self_$18021.g95JzFDHbr.forward, 0);
									if (268853 - 329180 == -60326)
									{
										goto IL_113;
									}
									this.$self_$18021.ActionEvent("RPC_nAttack_hit", this.$hitPoint$18017, this.$self_$18021.g95JzFDHbr.forward, 0);
									if (285723 - 277570 != 8153)
									{
										goto IL_113;
									}
								}
							}
							if (133525 - 20533 != 112993)
							{
								goto Block_24;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$18021.iXq65UculD.actionState == "attack")
						{
							if (211458 - 180653 == 30806)
							{
								continue;
							}
							if (this.$self_$18021.iXq65UculD.myCommand == "nAttack1")
							{
								if (120423 - 223821 == -103397)
								{
									continue;
								}
								this.$self_$18021.iXq65UculD.actionState = "standby";
								if (59766 - 156961 != -97195)
								{
									continue;
								}
								this.$self_$18021.iXq65UculD.actionTime = Time.time;
								if (7417 - 126529 != -119112)
								{
									continue;
								}
								this.$self_$18021.iXq65UculD.myCommand = "none";
								if (160498 - 103318 != 57180)
								{
									continue;
								}
								if (!this.$self_$18021.iXq65UculD.isMine)
								{
									if (12115 - 97081 != -84966)
									{
										continue;
									}
									this.$self_$18021.iXq65UculD.nPosition = this.$self_$18021.g95JzFDHbr.position;
									if (123112 - 502642 != -379530)
									{
										continue;
									}
									this.$self_$18021.iXq65UculD.oPosition = this.$self_$18021.g95JzFDHbr.position;
									if (6309 - 70321 != -64012)
									{
										continue;
									}
									this.$self_$18021.iXq65UculD.nDirection = this.$self_$18021.g95JzFDHbr.forward;
									if (238526 - 519249 == -280722)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (285566 - 258265 != 27301)
						{
							continue;
						}
						goto IL_886;
					default:
						if (212658 - 371478 != -158820)
						{
							continue;
						}
						break;
					}
					this.$self_$18021.iXq65UculD.actionState = "attack";
					if (73379 - 122273 == -48894)
					{
						this.$self_$18021.iXq65UculD.actionTime = Time.time;
						if (288920 - 135751 != 153170)
						{
							this.$self_$18021.iXq65UculD.myCommand = "nAttack1";
							if (252590 - 294907 != -42316)
							{
								this.$self_$18021.iXq65UculD.addTimeOut("nAttack", (float)3);
								if (291801 - 277153 != 14649)
								{
									this.$self_$18021.g95JzFDHbr.position = this.$mPos$18019;
									if (66755 - 468805 == -402050)
									{
										this.$self_$18021.g95JzFDHbr.LookAt(this.$mPos$18019 + global::Math.vFlat(this.$tDir$18020));
										if (68712 - 424341 == -355629)
										{
											this.$self_$18021.animation.CrossFade("nAttack1");
											if (112579 - 170341 != -57761)
											{
												this.$self_$18021.animation.wrapMode = WrapMode.Once;
												if (76582 - 400737 == -324155)
												{
													this.$self_$18021.iXq65UculD.vMovement = this.$self_$18021.g95JzFDHbr.forward;
													if (74710 - 421607 == -346897)
													{
														this.$self_$18021.iXq65UculD.moveSpeed = (float)0;
														if (289842 - 479205 == -189363)
														{
															if (this.$self_$18021.nAttack1_ring)
															{
																if (207686 - 561064 != -353377)
																{
																	this.$self_$18021.iXq65UculD.createEffect(this.$self_$18021.nAttack1_ring, this.$self_$18021.g95JzFDHbr.position, this.$self_$18021.g95JzFDHbr.rotation);
																	if (82479 - 134107 == -51628)
																	{
																		break;
																	}
																}
															}
															else
															{
																Debug.LogError("Missing nAttack1 ring effect");
																if (201869 - 537000 == -335131)
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
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_313:
				goto IL_886;
				Block_24:
				IL_559:
				return this.Yield(3, new WaitForSeconds(0.7f));
				IL_886:
				return false;
			}

			// Token: 0x06001047 RID: 4167 RVA: 0x0019D530 File Offset: 0x0019B730
			internal static bool KticfjEzfdISIsDm5nc()
			{
				return true;
			}

			// Token: 0x06001048 RID: 4168 RVA: 0x0019D534 File Offset: 0x0019B734
			internal static bool HvaXhZ2aV9yyO67ZMI2()
			{
				return false;
			}

			// Token: 0x04000E28 RID: 3624
			internal int $hitLayer$18014;

			// Token: 0x04000E29 RID: 3625
			internal UnityScript.Lang.Array $hitList$18015;

			// Token: 0x04000E2A RID: 3626
			internal GameObject $hitObject$18016;

			// Token: 0x04000E2B RID: 3627
			internal Vector3 $hitPoint$18017;

			// Token: 0x04000E2C RID: 3628
			internal IEnumerator $$iterator$9430$18018;

			// Token: 0x04000E2D RID: 3629
			internal Vector3 $mPos$18019;

			// Token: 0x04000E2E RID: 3630
			internal Vector3 $tDir$18020;

			// Token: 0x04000E2F RID: 3631
			internal Gaos $self_$18021;
		}
	}

	// Token: 0x020002CA RID: 714
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack2$18025 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001049 RID: 4169 RVA: 0x0019D538 File Offset: 0x0019B738
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack2$18025(Vector3 mPos, Vector3 tDir, Gaos self_)
		{
			if (223341 - 226839 != -3498)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (177459 - 309866 == -132407)
				{
					base..ctor();
					if (22829 - 563348 == -540519)
					{
						this.$mPos$18033 = mPos;
						if (274429 - 75053 == 199376)
						{
							this.$tDir$18034 = tDir;
							if (221525 - 133886 != 87640)
							{
								this.$self_$18035 = self_;
								if (70668 - 473020 != -402351)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600104A RID: 4170 RVA: 0x0019D614 File Offset: 0x0019B814
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Gaos.$RPC_nAttack2$18025.$(this.$mPos$18033, this.$tDir$18034, this.$self_$18035);
		}

		// Token: 0x0600104B RID: 4171 RVA: 0x0019D630 File Offset: 0x0019B830
		internal static bool aoIASX25mn3IsGq0CLH()
		{
			return true;
		}

		// Token: 0x0600104C RID: 4172 RVA: 0x0019D634 File Offset: 0x0019B834
		internal static bool V0lnOi2pkBwmg2NuKTw()
		{
			return false;
		}

		// Token: 0x04000E30 RID: 3632
		internal Vector3 $mPos$18033;

		// Token: 0x04000E31 RID: 3633
		internal Vector3 $tDir$18034;

		// Token: 0x04000E32 RID: 3634
		internal Gaos $self_$18035;

		// Token: 0x020002CB RID: 715
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600104D RID: 4173 RVA: 0x0019D638 File Offset: 0x0019B838
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Gaos self_)
			{
				if (77532 - 342779 != -265246)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (148120 - 277454 == -129334)
					{
						base..ctor();
						if (77939 - 54721 == 23218)
						{
							this.$mPos$18030 = mPos;
							if (71296 - 261046 != -189749)
							{
								this.$tDir$18031 = tDir;
								if (134160 - 577381 == -443221)
								{
									this.$self_$18032 = self_;
									if (155373 - 94753 == 60620)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x0600104E RID: 4174 RVA: 0x0019D714 File Offset: 0x0019B914
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (127737 - 52145 != 75592)
				{
				}
				for (;;)
				{
					IL_78B:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_81F;
					case 2:
						if (this.$self_$18032.iXq65UculD.actionState != "attack")
						{
							goto IL_552;
						}
						if (46685 - 500142 != -453457)
						{
							continue;
						}
						if (this.$self_$18032.iXq65UculD.myCommand != "nAttack2")
						{
							if (249676 - 165125 != 84551)
							{
								continue;
							}
							goto IL_552;
						}
						else
						{
							Vector3 vector = this.$self_$18032.g95JzFDHbr.position - Camera.main.transform.position;
							if (157157 - 91483 != 65674)
							{
								continue;
							}
							if (vector.sqrMagnitude <= (float)900)
							{
								if (101034 - 27444 != 73590)
								{
									continue;
								}
								Camera.main.SendMessage("AddCamereShake", 0.5f);
								if (169757 - 293616 == -123858)
								{
									continue;
								}
							}
							if (!this.$self_$18032.iXq65UculD.isMine)
							{
								goto IL_4AD;
							}
							if (46153 - 202500 != -156347)
							{
								continue;
							}
							this.$hitLayer$18026 = 130816 - (1 << this.$self_$18032.gameObject.layer);
							if (69285 - 35573 == 33713)
							{
								continue;
							}
							this.$hitList$18027 = Damage.FindAreaTarget(this.$self_$18032.g95JzFDHbr.position + this.$self_$18032.g95JzFDHbr.TransformDirection(1.2f, (float)0, (float)2), (float)5 * this.$self_$18032.iXq65UculD.rangeMod, (float)3, this.$hitLayer$18026);
							if (84248 - 300488 == -216239)
							{
								continue;
							}
							this.$$iterator$9431$18029 = UnityRuntimeServices.GetEnumerator(this.$hitList$18027);
							if (217900 - 518415 != -300515)
							{
								continue;
							}
							while (this.$$iterator$9431$18029.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$9431$18029.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$18028 = (GameObject)obj2;
								if (220347 - 328785 != -108438)
								{
									goto IL_78B;
								}
								this.$self_$18032.iXq65UculD.hit(1, this.$hitObject$18028, (int)(0.6f * (float)this.$self_$18032.iXq65UculD.atk), 3, 0, Vector3.up);
								if (265963 - 233893 != 32070)
								{
									goto IL_78B;
								}
								UnityRuntimeServices.Update(this.$$iterator$9431$18029, this.$hitObject$18028);
								if (232237 - 300738 != -68501)
								{
									goto IL_78B;
								}
							}
							if (226259 - 261026 != -34767)
							{
								continue;
							}
							goto IL_4AD;
						}
						break;
					case 3:
						if (this.$self_$18032.iXq65UculD.actionState == "attack")
						{
							if (288070 - 405097 == -117026)
							{
								continue;
							}
							if (this.$self_$18032.iXq65UculD.myCommand == "nAttack2")
							{
								if (262224 - 385752 == -123527)
								{
									continue;
								}
								this.$self_$18032.iXq65UculD.actionState = "standby";
								if (258823 - 71329 != 187494)
								{
									continue;
								}
								this.$self_$18032.iXq65UculD.actionTime = Time.time;
								if (236879 - 566068 == -329188)
								{
									continue;
								}
								this.$self_$18032.iXq65UculD.myCommand = "none";
								if (167222 - 219897 != -52675)
								{
									continue;
								}
								if (!this.$self_$18032.iXq65UculD.isMine)
								{
									if (115991 - 292176 != -176185)
									{
										continue;
									}
									this.$self_$18032.iXq65UculD.nPosition = this.$self_$18032.g95JzFDHbr.position;
									if (206314 - 10332 != 195982)
									{
										continue;
									}
									this.$self_$18032.iXq65UculD.oPosition = this.$self_$18032.g95JzFDHbr.position;
									if (247280 - 44086 == 203195)
									{
										continue;
									}
									this.$self_$18032.iXq65UculD.nDirection = this.$self_$18032.g95JzFDHbr.forward;
									if (83046 - 336592 == -253545)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (231888 - 258637 != -26749)
						{
							continue;
						}
						goto IL_81F;
					default:
						if (175231 - 595075 != -419844)
						{
							continue;
						}
						break;
					}
					this.$self_$18032.iXq65UculD.actionState = "attack";
					if (192119 - 22667 != 169453)
					{
						this.$self_$18032.iXq65UculD.actionTime = Time.time;
						if (22499 - 135336 == -112837)
						{
							this.$self_$18032.iXq65UculD.myCommand = "nAttack2";
							if (159055 - 31445 != 127611)
							{
								this.$self_$18032.iXq65UculD.addTimeOut("nAttack", (float)3);
								if (268110 - 419633 == -151523)
								{
									this.$self_$18032.g95JzFDHbr.position = this.$mPos$18030;
									if (5771 - 403628 == -397857)
									{
										this.$self_$18032.g95JzFDHbr.LookAt(this.$mPos$18030 + global::Math.vFlat(this.$tDir$18031));
										if (246301 - 413821 != -167519)
										{
											this.$self_$18032.animation.CrossFade("nAttack2");
											if (258274 - 235285 == 22989)
											{
												this.$self_$18032.animation.wrapMode = WrapMode.Once;
												if (201821 - 205895 != -4073)
												{
													this.$self_$18032.iXq65UculD.vMovement = this.$self_$18032.g95JzFDHbr.forward;
													if (109261 - 124639 != -15377)
													{
														this.$self_$18032.iXq65UculD.moveSpeed = (float)0;
														if (273505 - 191930 == 81575)
														{
															if (this.$self_$18032.nAttack2_ring)
															{
																if (231317 - 30248 != 201070)
																{
																	this.$self_$18032.iXq65UculD.createEffect(this.$self_$18032.nAttack2_ring, this.$self_$18032.g95JzFDHbr.position, this.$self_$18032.g95JzFDHbr.rotation);
																	if (32562 - 451485 != -418922)
																	{
																		break;
																	}
																}
															}
															else
															{
																Debug.LogError("Missing nAttack2 ring effect");
																if (14354 - 217756 == -203402)
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
				IL_1C8:
				return this.Yield(2, new WaitForSeconds(0.6f));
				IL_4AD:
				return this.Yield(3, new WaitForSeconds(1.2f));
				goto IL_1C8;
				IL_552:
				IL_81F:
				return false;
			}

			// Token: 0x0600104F RID: 4175 RVA: 0x0019DF54 File Offset: 0x0019C154
			internal static bool UXXigM2ViJZbiMd7fNh()
			{
				return true;
			}

			// Token: 0x06001050 RID: 4176 RVA: 0x0019DF58 File Offset: 0x0019C158
			internal static bool jfq5B42twFZki0vyu4i()
			{
				return false;
			}

			// Token: 0x04000E33 RID: 3635
			internal int $hitLayer$18026;

			// Token: 0x04000E34 RID: 3636
			internal UnityScript.Lang.Array $hitList$18027;

			// Token: 0x04000E35 RID: 3637
			internal GameObject $hitObject$18028;

			// Token: 0x04000E36 RID: 3638
			internal IEnumerator $$iterator$9431$18029;

			// Token: 0x04000E37 RID: 3639
			internal Vector3 $mPos$18030;

			// Token: 0x04000E38 RID: 3640
			internal Vector3 $tDir$18031;

			// Token: 0x04000E39 RID: 3641
			internal Gaos $self_$18032;
		}
	}

	// Token: 0x020002CC RID: 716
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_tailSpin$18036 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001051 RID: 4177 RVA: 0x0019DF5C File Offset: 0x0019C15C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_tailSpin$18036(Vector3 mPos, Vector3 tDir, Gaos self_)
		{
			if (41660 - 424895 != -383234)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (152999 - 467005 != -314005)
				{
					base..ctor();
					if (241581 - 126533 != 115049)
					{
						this.$mPos$18048 = mPos;
						if (117920 - 359358 == -241438)
						{
							this.$tDir$18049 = tDir;
							if (261656 - 440313 != -178656)
							{
								this.$self_$18050 = self_;
								if (60525 - 494648 == -434123)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001052 RID: 4178 RVA: 0x0019E038 File Offset: 0x0019C238
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Gaos.$RPC_tailSpin$18036.$(this.$mPos$18048, this.$tDir$18049, this.$self_$18050);
		}

		// Token: 0x06001053 RID: 4179 RVA: 0x0019E054 File Offset: 0x0019C254
		internal static bool xGfhEL2NGyHlXH3nmEq()
		{
			return true;
		}

		// Token: 0x06001054 RID: 4180 RVA: 0x0019E058 File Offset: 0x0019C258
		internal static bool pHZ2wZ2YC2eCOmnXHWu()
		{
			return false;
		}

		// Token: 0x04000E3A RID: 3642
		internal Vector3 $mPos$18048;

		// Token: 0x04000E3B RID: 3643
		internal Vector3 $tDir$18049;

		// Token: 0x04000E3C RID: 3644
		internal Gaos $self_$18050;

		// Token: 0x020002CD RID: 717
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001055 RID: 4181 RVA: 0x0019E05C File Offset: 0x0019C25C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Gaos self_)
			{
				if (63956 - 116807 != -52850)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (281748 - 214521 == 67227)
					{
						base..ctor();
						if (199344 - 144698 == 54646)
						{
							this.$mPos$18045 = mPos;
							if (228073 - 423928 != -195854)
							{
								this.$tDir$18046 = tDir;
								if (125799 - 193725 != -67925)
								{
									this.$self_$18047 = self_;
									if (227887 - 231607 == -3720)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06001056 RID: 4182 RVA: 0x0019E138 File Offset: 0x0019C338
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (127142 - 28586 != 98557)
				{
				}
				for (;;)
				{
					IL_2DF:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_B3A;
					case 2:
						if (this.$self_$18047.iXq65UculD.actionState != "attack")
						{
							goto IL_7FE;
						}
						if (38158 - 473522 != -435364)
						{
							continue;
						}
						if (this.$self_$18047.iXq65UculD.myCommand != "tailSpin")
						{
							if (189401 - 596988 != -407586)
							{
								goto Block_64;
							}
							continue;
						}
						else
						{
							this.$i$18037 = 0;
							if (214204 - 554507 != -340302)
							{
								goto IL_DC;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$18047.iXq65UculD.actionState != "attack")
						{
							goto IL_39C;
						}
						if (140900 - 210603 != -69703)
						{
							continue;
						}
						if (this.$self_$18047.iXq65UculD.myCommand != "tailSpin")
						{
							if (37062 - 318156 != -281094)
							{
								continue;
							}
							goto IL_39C;
						}
						else
						{
							this.$i$18037++;
							if (284303 - 559037 != -274733)
							{
								goto IL_DC;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$18047.iXq65UculD.actionState == "attack")
						{
							if (242837 - 240638 != 2199)
							{
								continue;
							}
							if (this.$self_$18047.iXq65UculD.myCommand == "tailSpin")
							{
								if (127234 - 239955 != -112721)
								{
									continue;
								}
								this.$self_$18047.iXq65UculD.actionState = "standby";
								if (249163 - 110867 == 138297)
								{
									continue;
								}
								this.$self_$18047.iXq65UculD.actionTime = Time.time;
								if (68822 - 61477 == 7346)
								{
									continue;
								}
								this.$self_$18047.iXq65UculD.myCommand = "none";
								if (211688 - 214433 == -2744)
								{
									continue;
								}
								if (!this.$self_$18047.iXq65UculD.isMine)
								{
									if (192469 - 114030 != 78439)
									{
										continue;
									}
									this.$self_$18047.iXq65UculD.nPosition = this.$self_$18047.g95JzFDHbr.position;
									if (63094 - 293149 != -230055)
									{
										continue;
									}
									this.$self_$18047.iXq65UculD.oPosition = this.$self_$18047.g95JzFDHbr.position;
									if (267116 - 260042 == 7075)
									{
										continue;
									}
									this.$self_$18047.iXq65UculD.nDirection = this.$self_$18047.g95JzFDHbr.forward;
									if (88950 - 104791 != -15841)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (220696 - 476850 != -256154)
						{
							continue;
						}
						goto IL_B3A;
					default:
						if (298181 - 242000 == 56182)
						{
							continue;
						}
						break;
					}
					this.$self_$18047.iXq65UculD.actionState = "attack";
					if (64826 - 216653 != -151827)
					{
						continue;
					}
					this.$self_$18047.iXq65UculD.actionTime = Time.time;
					if (95887 - 551415 == -455527)
					{
						continue;
					}
					this.$self_$18047.iXq65UculD.myCommand = "tailSpin";
					if (199625 - 253488 == -53862)
					{
						continue;
					}
					this.$self_$18047.iXq65UculD.addTimeOut("cAttack", (float)15);
					if (292708 - 348857 != -56149)
					{
						continue;
					}
					this.$self_$18047.g95JzFDHbr.position = this.$mPos$18045;
					if (123045 - 396812 != -273767)
					{
						continue;
					}
					this.$self_$18047.g95JzFDHbr.LookAt(this.$mPos$18045 + global::Math.vFlat(this.$tDir$18046.normalized));
					if (125907 - 599076 != -473169)
					{
						continue;
					}
					this.$self_$18047.animation.CrossFade("tailSpin");
					if (138664 - 363353 == -224688)
					{
						continue;
					}
					this.$self_$18047.animation.wrapMode = WrapMode.Once;
					if (66076 - 493174 != -427098)
					{
						continue;
					}
					this.$self_$18047.iXq65UculD.vMovement = this.$self_$18047.g95JzFDHbr.forward;
					if (197827 - 313526 == -115698)
					{
						continue;
					}
					this.$self_$18047.iXq65UculD.moveSpeed = (float)0;
					if (70604 - 50536 == 20069)
					{
						continue;
					}
					if (this.$self_$18047.tailSpin_ring)
					{
						if (171096 - 195043 != -23947)
						{
							continue;
						}
						this.$self_$18047.iXq65UculD.createEffect(this.$self_$18047.tailSpin_ring, this.$self_$18047.g95JzFDHbr.position, this.$self_$18047.g95JzFDHbr.rotation);
						if (129580 - 581797 != -452216)
						{
							break;
						}
						continue;
					}
					else
					{
						Debug.LogError("Missing tailSpin ring effect");
						if (130300 - 361294 != -230993)
						{
							break;
						}
						continue;
					}
					IL_DC:
					if (this.$i$18037 >= 4)
					{
						if (25742 - 145585 == -119843)
						{
							goto IL_18D;
						}
					}
					else
					{
						if (!this.$self_$18047.iXq65UculD.isMine)
						{
							goto IL_8C4;
						}
						if (69593 - 452238 == -382645)
						{
							this.$hitDir$18038 = this.$self_$18047.g95JzFDHbr.forward;
							if (180580 - 429880 == -249300)
							{
								this.$$switch$1145$18039 = this.$i$18037;
								if (256758 - 312311 == -55553)
								{
									if (this.$$switch$1145$18039 == 0)
									{
										if (137875 - 233346 == -95470)
										{
											continue;
										}
										this.$hitDir$18038 = -this.$self_$18047.g95JzFDHbr.forward;
										if (170809 - 521308 != -350499)
										{
											continue;
										}
									}
									else if (this.$$switch$1145$18039 == 1)
									{
										if (152745 - 70201 != 82544)
										{
											continue;
										}
										this.$hitDir$18038 = this.$self_$18047.g95JzFDHbr.right;
										if (158590 - 435560 != -276970)
										{
											continue;
										}
									}
									else if (this.$$switch$1145$18039 == 2)
									{
										if (37942 - 7706 == 30237)
										{
											continue;
										}
										this.$hitDir$18038 = this.$self_$18047.g95JzFDHbr.forward;
										if (85671 - 254820 == -169148)
										{
											continue;
										}
									}
									else if (this.$$switch$1145$18039 == 3)
									{
										if (92660 - 519581 == -426920)
										{
											continue;
										}
										this.$hitDir$18038 = -this.$self_$18047.g95JzFDHbr.right;
										if (268217 - 88067 == 180151)
										{
											continue;
										}
									}
									this.$hitLayer$18040 = 130816 - (1 << this.$self_$18047.gameObject.layer);
									if (262915 - 31106 != 231810)
									{
										this.$hitList$18041 = Damage.FindAngleTarget(this.$self_$18047.g95JzFDHbr.position, this.$hitDir$18038, (float)(6 + this.$i$18037), (float)120, (float)4, this.$hitLayer$18040);
										if (200661 - 365738 == -165077)
										{
											this.$$iterator$9432$18044 = UnityRuntimeServices.GetEnumerator(this.$hitList$18041);
											if (100677 - 88027 == 12650)
											{
												while (this.$$iterator$9432$18044.MoveNext())
												{
													object obj2;
													object obj = obj2 = this.$$iterator$9432$18044.Current;
													if (!(obj is GameObject))
													{
														obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
													}
													this.$hitObject$18042 = (GameObject)obj2;
													if (162091 - 351426 != -189335)
													{
														goto IL_2DF;
													}
													if (this.$self_$18047.iXq65UculD.hit(1, this.$hitObject$18042, (int)(0.8f * (float)this.$self_$18047.iXq65UculD.atk), 10, 0, (float)2 * (this.$hitObject$18042.transform.position - this.$self_$18047.g95JzFDHbr.position).normalized) != 0)
													{
														if (99187 - 199660 != -100473)
														{
															goto IL_2DF;
														}
														this.$hitPoint$18043 = this.$hitObject$18042.collider.ClosestPointOnBounds(this.$self_$18047.g95JzFDHbr.position + (float)3 * Vector3.up);
														if (62381 - 296038 == -233656)
														{
															goto IL_2DF;
														}
														UnityRuntimeServices.Update(this.$$iterator$9432$18044, this.$hitObject$18042);
														if (17059 - 527731 != -510672)
														{
															goto IL_2DF;
														}
														this.$self_$18047.RPC_tailSpin_hit(this.$hitPoint$18043, this.$self_$18047.g95JzFDHbr.forward, 0);
														if (258699 - 392491 != -133792)
														{
															goto IL_2DF;
														}
														this.$self_$18047.ActionEvent("RPC_tailSpin_hit", this.$hitPoint$18043, this.$self_$18047.g95JzFDHbr.forward, 0);
														if (215016 - 234648 == -19631)
														{
															goto IL_2DF;
														}
													}
												}
												if (110814 - 115329 != -4514)
												{
													goto Block_30;
												}
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_3C9;
				IL_18D:
				return this.Yield(4, new WaitForSeconds(1f));
				IL_39C:
				goto IL_B3A;
				IL_3C9:
				return this.Yield(2, new WaitForSeconds(0.6f));
				Block_30:
				goto IL_8C4;
				IL_7FE:
				goto IL_B3A;
				IL_8C4:
				return this.Yield(3, new WaitForSeconds(0.2f));
				goto IL_3C9;
				Block_64:
				IL_B3A:
				return false;
			}

			// Token: 0x06001057 RID: 4183 RVA: 0x0019EC94 File Offset: 0x0019CE94
			internal static bool KxyULe2cD5KB1hfWJAn()
			{
				return true;
			}

			// Token: 0x06001058 RID: 4184 RVA: 0x0019EC98 File Offset: 0x0019CE98
			internal static bool iaQwrl2UwRp1iqfcRQx()
			{
				return false;
			}

			// Token: 0x04000E3D RID: 3645
			internal int $i$18037;

			// Token: 0x04000E3E RID: 3646
			internal Vector3 $hitDir$18038;

			// Token: 0x04000E3F RID: 3647
			internal int $$switch$1145$18039;

			// Token: 0x04000E40 RID: 3648
			internal int $hitLayer$18040;

			// Token: 0x04000E41 RID: 3649
			internal UnityScript.Lang.Array $hitList$18041;

			// Token: 0x04000E42 RID: 3650
			internal GameObject $hitObject$18042;

			// Token: 0x04000E43 RID: 3651
			internal Vector3 $hitPoint$18043;

			// Token: 0x04000E44 RID: 3652
			internal IEnumerator $$iterator$9432$18044;

			// Token: 0x04000E45 RID: 3653
			internal Vector3 $mPos$18045;

			// Token: 0x04000E46 RID: 3654
			internal Vector3 $tDir$18046;

			// Token: 0x04000E47 RID: 3655
			internal Gaos $self_$18047;
		}
	}

	// Token: 0x020002CE RID: 718
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_gaosFire$18051 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001059 RID: 4185 RVA: 0x0019EC9C File Offset: 0x0019CE9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_gaosFire$18051(Vector3 mPos, Vector3 tDir, int tID, Gaos self_)
		{
			if (93008 - 481019 != -388011)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (207780 - 37185 == 170595)
				{
					base..ctor();
					if (293588 - 131677 != 161912)
					{
						this.$mPos$18058 = mPos;
						if (98420 - 346262 == -247842)
						{
							this.$tDir$18059 = tDir;
							if (159130 - 129375 == 29755)
							{
								this.$tID$18060 = tID;
								if (81898 - 354074 != -272175)
								{
									this.$self_$18061 = self_;
									if (274525 - 431865 != -157339)
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

		// Token: 0x0600105A RID: 4186 RVA: 0x0019ED9C File Offset: 0x0019CF9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Gaos.$RPC_gaosFire$18051.$(this.$mPos$18058, this.$tDir$18059, this.$tID$18060, this.$self_$18061);
		}

		// Token: 0x0600105B RID: 4187 RVA: 0x0019EDBC File Offset: 0x0019CFBC
		internal static bool QngG6u2TUNxROcZZv8X()
		{
			return true;
		}

		// Token: 0x0600105C RID: 4188 RVA: 0x0019EDC0 File Offset: 0x0019CFC0
		internal static bool HiRExu23osKcs08bumf()
		{
			return false;
		}

		// Token: 0x04000E48 RID: 3656
		internal Vector3 $mPos$18058;

		// Token: 0x04000E49 RID: 3657
		internal Vector3 $tDir$18059;

		// Token: 0x04000E4A RID: 3658
		internal int $tID$18060;

		// Token: 0x04000E4B RID: 3659
		internal Gaos $self_$18061;

		// Token: 0x020002CF RID: 719
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600105D RID: 4189 RVA: 0x0019EDC4 File Offset: 0x0019CFC4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, Gaos self_)
			{
				if (11236 - 477765 != -466529)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (134302 - 487366 == -353064)
					{
						base..ctor();
						if (174955 - 117019 == 57936)
						{
							this.$mPos$18054 = mPos;
							if (16458 - 468364 != -451905)
							{
								this.$tDir$18055 = tDir;
								if (198294 - 595272 == -396978)
								{
									this.$tID$18056 = tID;
									if (47704 - 114712 == -67008)
									{
										this.$self_$18057 = self_;
										if (107360 - 511917 != -404556)
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

			// Token: 0x0600105E RID: 4190 RVA: 0x0019EEC4 File Offset: 0x0019D0C4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (236240 - 81952 != 154288)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_6DA;
					case 2:
						if (this.$self_$18057.iXq65UculD.actionState != "attack")
						{
							goto IL_259;
						}
						if (46955 - 406245 != -359290)
						{
							continue;
						}
						if (this.$self_$18057.iXq65UculD.myCommand != "gaosFire")
						{
							if (291976 - 218023 != 73953)
							{
								continue;
							}
							goto IL_259;
						}
						else
						{
							if (!this.$self_$18057.iXq65UculD.isMine)
							{
								goto IL_62D;
							}
							if (95780 - 344609 == -248828)
							{
								continue;
							}
							this.$firePos$18052 = this.$mPos$18054 + this.$self_$18057.g95JzFDHbr.TransformDirection((float)0, (float)4, (float)6);
							if (287531 - 283689 != 3842)
							{
								continue;
							}
							this.$fireDir$18053 = this.$tDir$18055 - this.$self_$18057.g95JzFDHbr.TransformDirection((float)0, (float)4, (float)6);
							if (276521 - 595503 != -318982)
							{
								continue;
							}
							this.$self_$18057.RPC_gaosFire_fire(this.$firePos$18052, this.$fireDir$18053, this.$tID$18056);
							if (286375 - 389423 != -103048)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								goto IL_62D;
							}
							if (254318 - 487864 != -233546)
							{
								continue;
							}
							this.$self_$18057.ActionEvent("RPC_gaosFire_fire", this.$firePos$18052, this.$fireDir$18053, this.$tID$18056);
							if (229524 - 140668 != 88857)
							{
								goto Block_41;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$18057.iXq65UculD.actionState == "attack")
						{
							if (119068 - 161483 != -42415)
							{
								continue;
							}
							if (this.$self_$18057.iXq65UculD.myCommand == "gaosFire")
							{
								if (27610 - 388739 == -361128)
								{
									continue;
								}
								this.$self_$18057.iXq65UculD.actionState = "standby";
								if (201338 - 451639 != -250301)
								{
									continue;
								}
								this.$self_$18057.iXq65UculD.actionTime = Time.time;
								if (222390 - 260000 != -37610)
								{
									continue;
								}
								this.$self_$18057.iXq65UculD.myCommand = "none";
								if (95449 - 459131 == -363681)
								{
									continue;
								}
								if (!this.$self_$18057.iXq65UculD.isMine)
								{
									if (49777 - 530282 != -480505)
									{
										continue;
									}
									this.$self_$18057.iXq65UculD.nPosition = this.$self_$18057.g95JzFDHbr.position;
									if (124395 - 335441 == -211045)
									{
										continue;
									}
									this.$self_$18057.iXq65UculD.oPosition = this.$self_$18057.g95JzFDHbr.position;
									if (163328 - 500804 == -337475)
									{
										continue;
									}
									this.$self_$18057.iXq65UculD.nDirection = this.$self_$18057.g95JzFDHbr.forward;
									if (12525 - 294175 != -281650)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (135315 - 584086 != -448771)
						{
							continue;
						}
						goto IL_6DA;
					default:
						if (27093 - 230215 != -203122)
						{
							continue;
						}
						break;
					}
					this.$self_$18057.iXq65UculD.actionState = "attack";
					if (92041 - 404346 == -312305)
					{
						this.$self_$18057.iXq65UculD.actionTime = Time.time;
						if (124590 - 269678 != -145087)
						{
							this.$self_$18057.iXq65UculD.myCommand = "gaosFire";
							if (285907 - 45152 == 240755)
							{
								this.$self_$18057.iXq65UculD.addTimeOut("goasFire", (float)9);
								if (198108 - 340336 == -142228)
								{
									this.$self_$18057.g95JzFDHbr.position = this.$mPos$18054;
									if (204094 - 255713 == -51619)
									{
										this.$self_$18057.g95JzFDHbr.LookAt(this.$mPos$18054 + global::Math.vFlat(this.$tDir$18055.normalized));
										if (204077 - 171991 != 32087)
										{
											this.$self_$18057.animation.CrossFade("gaosFire");
											if (127471 - 547383 == -419912)
											{
												this.$self_$18057.animation.wrapMode = WrapMode.Once;
												if (158316 - 507125 == -348809)
												{
													this.$self_$18057.iXq65UculD.vMovement = this.$self_$18057.g95JzFDHbr.forward;
													if (7735 - 166154 != -158418)
													{
														this.$self_$18057.iXq65UculD.moveSpeed = (float)0;
														if (154438 - 174642 != -20203)
														{
															if (this.$self_$18057.gaosFire_ring)
															{
																if (76394 - 333534 != -257139)
																{
																	this.$self_$18057.iXq65UculD.createEffect(this.$self_$18057.gaosFire_ring, this.$self_$18057.g95JzFDHbr.position, this.$self_$18057.g95JzFDHbr.rotation);
																	if (5026 - 450264 == -445238)
																	{
																		break;
																	}
																}
															}
															else
															{
																Debug.LogError("Missing gaosFire ring effect");
																if (185318 - 498830 != -313511)
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
				goto IL_39C;
				IL_259:
				goto IL_6DA;
				IL_39C:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_62D:
				return this.Yield(3, new WaitForSeconds(0.7f));
				Block_41:
				goto IL_62D;
				IL_6DA:
				return false;
			}

			// Token: 0x0600105F RID: 4191 RVA: 0x0019F5C0 File Offset: 0x0019D7C0
			internal static bool Kqxhjc2XQxR80JHdQid()
			{
				return true;
			}

			// Token: 0x06001060 RID: 4192 RVA: 0x0019F5C4 File Offset: 0x0019D7C4
			internal static bool GSMR5L2QYC7Tw9uloR7()
			{
				return false;
			}

			// Token: 0x04000E4C RID: 3660
			internal Vector3 $firePos$18052;

			// Token: 0x04000E4D RID: 3661
			internal Vector3 $fireDir$18053;

			// Token: 0x04000E4E RID: 3662
			internal Vector3 $mPos$18054;

			// Token: 0x04000E4F RID: 3663
			internal Vector3 $tDir$18055;

			// Token: 0x04000E50 RID: 3664
			internal int $tID$18056;

			// Token: 0x04000E51 RID: 3665
			internal Gaos $self_$18057;
		}
	}

	// Token: 0x020002D0 RID: 720
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_rampage$18062 : GenericGenerator<YieldInstruction>
	{
		// Token: 0x06001061 RID: 4193 RVA: 0x0019F5C8 File Offset: 0x0019D7C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_rampage$18062(Vector3 mPos, Vector3 tDir, int tID, Gaos self_)
		{
			if (222850 - 274202 != -51352)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (97876 - 447337 != -349460)
				{
					base..ctor();
					if (146074 - 7963 != 138112)
					{
						this.$mPos$18081 = mPos;
						if (264328 - 409804 != -145475)
						{
							this.$tDir$18082 = tDir;
							if (12011 - 342028 == -330017)
							{
								this.$tID$18083 = tID;
								if (44288 - 489808 == -445520)
								{
									this.$self_$18084 = self_;
									if (229861 - 429717 != -199855)
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

		// Token: 0x06001062 RID: 4194 RVA: 0x0019F6C8 File Offset: 0x0019D8C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<YieldInstruction> GetEnumerator()
		{
			return new Gaos.$RPC_rampage$18062.$(this.$mPos$18081, this.$tDir$18082, this.$tID$18083, this.$self_$18084);
		}

		// Token: 0x06001063 RID: 4195 RVA: 0x0019F6E8 File Offset: 0x0019D8E8
		internal static bool HLA15I2kdYIcRvEhmeZ()
		{
			return true;
		}

		// Token: 0x06001064 RID: 4196 RVA: 0x0019F6EC File Offset: 0x0019D8EC
		internal static bool QlkgKD2Ge6dH8aloB7U()
		{
			return false;
		}

		// Token: 0x04000E52 RID: 3666
		internal Vector3 $mPos$18081;

		// Token: 0x04000E53 RID: 3667
		internal Vector3 $tDir$18082;

		// Token: 0x04000E54 RID: 3668
		internal int $tID$18083;

		// Token: 0x04000E55 RID: 3669
		internal Gaos $self_$18084;

		// Token: 0x020002D1 RID: 721
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<YieldInstruction>, IEnumerator
		{
			// Token: 0x06001065 RID: 4197 RVA: 0x0019F6F0 File Offset: 0x0019D8F0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, Gaos self_)
			{
				if (205091 - 304440 != -99348)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (165904 - 126453 != 39452)
					{
						base..ctor();
						if (241317 - 494222 == -252905)
						{
							this.$mPos$18077 = mPos;
							if (30176 - 413935 != -383758)
							{
								this.$tDir$18078 = tDir;
								if (224494 - 393281 == -168787)
								{
									this.$tID$18079 = tID;
									if (30048 - 105187 == -75139)
									{
										this.$self_$18080 = self_;
										if (15725 - 122478 == -106753)
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

			// Token: 0x06001066 RID: 4198 RVA: 0x0019F7F0 File Offset: 0x0019D9F0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (216814 - 359821 != -143006)
				{
				}
				for (;;)
				{
					IL_379:
					switch (this._state)
					{
					case 0:
						goto IL_C6A;
					case 1:
						goto IL_12F1;
					case 2:
						if (this.$self_$18080.iXq65UculD.actionState != "attack")
						{
							goto IL_121C;
						}
						if (24649 - 73634 == -48984)
						{
							continue;
						}
						if (this.$self_$18080.iXq65UculD.myCommand != "rampage")
						{
							if (271939 - 435220 != -163280)
							{
								goto Block_3;
							}
							continue;
						}
						else
						{
							this.$self_$18080.iXq65UculD.moveSpeed = (float)5;
							if (232210 - 223992 != 8218)
							{
								continue;
							}
							goto IL_A28;
						}
						break;
					case 3:
						if (this.$self_$18080.iXq65UculD.actionState != "attack")
						{
							goto IL_D78;
						}
						if (232625 - 131319 == 101307)
						{
							continue;
						}
						if (this.$self_$18080.iXq65UculD.myCommand != "rampage")
						{
							if (160890 - 150430 != 10460)
							{
								continue;
							}
							goto IL_D78;
						}
						else
						{
							this.$self_$18080.animation.Play("rampage2");
							if (200984 - 274073 == -73088)
							{
								continue;
							}
							this.$self_$18080.animation.wrapMode = WrapMode.Loop;
							if (154779 - 84308 == 70472)
							{
								continue;
							}
							this.$self_$18080.iXq65UculD.moveSpeed = (float)8;
							if (209633 - 354761 != -145128)
							{
								continue;
							}
							if (this.$self_$18080.rampage_ring2)
							{
								if (195859 - 31492 == 164368)
								{
									continue;
								}
								this.$self_$18080.iXq65UculD.createEffect(this.$self_$18080.rampage_ring2, this.$self_$18080.transform.position, this.$self_$18080.transform.rotation);
								if (202364 - 65544 == 136821)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing rampage_ring2 effect");
								if (109312 - 326905 == -217592)
								{
									continue;
								}
							}
							this.$tObject$18063 = null;
							if (276064 - 325969 == -49904)
							{
								continue;
							}
							if (this.$tID$18079 != 0)
							{
								if (14616 - 296181 != -281565)
								{
									continue;
								}
								object obj2;
								object obj = obj2 = PhotonClient.ActorNrList[this.$tID$18079];
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$tObject$18063 = (GameObject)obj2;
								if (56570 - 589790 == -533219)
								{
									continue;
								}
							}
							this.$ignoreLayer$18064 = 130818;
							if (216460 - 433141 == -216680)
							{
								continue;
							}
							this.$ignoreList$18065 = Damage.FindAreaTarget(this.$self_$18080.transform.position, (float)40, (float)12, this.$ignoreLayer$18064);
							if (78083 - 169540 == -91456)
							{
								continue;
							}
							this.$$iterator$9433$18067 = UnityRuntimeServices.GetEnumerator(this.$ignoreList$18065);
							if (256268 - 348652 != -92384)
							{
								continue;
							}
							while (this.$$iterator$9433$18067.MoveNext())
							{
								object obj4;
								object obj3 = obj4 = this.$$iterator$9433$18067.Current;
								if (!(obj3 is GameObject))
								{
									obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
								}
								this.$ignoreObject$18066 = (GameObject)obj4;
								if (9554 - 393383 == -383828)
								{
									goto IL_379;
								}
								if (this.$ignoreObject$18066)
								{
									if (126278 - 207715 == -81436)
									{
										goto IL_379;
									}
									if (this.$self_$18080.gameObject != this.$ignoreObject$18066)
									{
										if (90135 - 97224 == -7088)
										{
											goto IL_379;
										}
										Physics.IgnoreCollision(this.$self_$18080.gameObject.collider, this.$ignoreObject$18066.collider, true);
										if (253369 - 468125 == -214755)
										{
											goto IL_379;
										}
										UnityRuntimeServices.Update(this.$$iterator$9433$18067, this.$ignoreObject$18066);
										if (268887 - 352060 == -83172)
										{
											goto IL_379;
										}
									}
								}
							}
							if (81574 - 138774 != -57200)
							{
								continue;
							}
							this.$mHitUpdate$18068 = Time.time + 0.5f;
							if (135736 - 505247 == -369510)
							{
								continue;
							}
						}
						break;
					case 4:
						if (!(this.$self_$18080.iXq65UculD.actionState != "attack"))
						{
							if (228208 - 53409 != 174799)
							{
								continue;
							}
							if (!(this.$self_$18080.iXq65UculD.myCommand != "rampage"))
							{
								break;
							}
							if (246477 - 577983 != -331506)
							{
								continue;
							}
						}
						this.$$iterator$9435$18074 = UnityRuntimeServices.GetEnumerator(this.$ignoreList$18065);
						if (282678 - 441475 != -158797)
						{
							continue;
						}
						while (this.$$iterator$9435$18074.MoveNext())
						{
							object obj6;
							object obj5 = obj6 = this.$$iterator$9435$18074.Current;
							if (!(obj5 is GameObject))
							{
								obj6 = RuntimeServices.Coerce(obj5, typeof(GameObject));
							}
							this.$ignoreObject$18073 = (GameObject)obj6;
							if (92253 - 296508 != -204255)
							{
								goto IL_379;
							}
							if (this.$ignoreObject$18073)
							{
								if (139879 - 562937 == -423057)
								{
									goto IL_379;
								}
								if (this.$self_$18080.gameObject != this.$ignoreObject$18073)
								{
									if (45510 - 432137 != -386627)
									{
										goto IL_379;
									}
									Physics.IgnoreCollision(this.$self_$18080.gameObject.collider, this.$ignoreObject$18073.collider, false);
									if (282717 - 282787 == -69)
									{
										goto IL_379;
									}
									UnityRuntimeServices.Update(this.$$iterator$9435$18074, this.$ignoreObject$18073);
									if (187222 - 252960 != -65738)
									{
										goto IL_379;
									}
								}
							}
						}
						if (213336 - 119606 != 93731)
						{
							goto Block_75;
						}
						continue;
					case 5:
						if (this.$self_$18080.iXq65UculD.actionState != "attack")
						{
							goto IL_2D6;
						}
						if (140311 - 512181 != -371870)
						{
							continue;
						}
						if (this.$self_$18080.iXq65UculD.myCommand != "rampage")
						{
							if (201207 - 1950 != 199257)
							{
								continue;
							}
							goto IL_2D6;
						}
						else
						{
							this.$self_$18080.iXq65UculD.moveSpeed = (float)3;
							if (20887 - 95836 != -74949)
							{
								continue;
							}
							goto IL_11A2;
						}
						break;
					case 6:
						if (this.$self_$18080.iXq65UculD.actionState != "attack")
						{
							goto IL_EAB;
						}
						if (253459 - 222341 != 31118)
						{
							continue;
						}
						if (this.$self_$18080.iXq65UculD.myCommand != "rampage")
						{
							if (14517 - 370292 != -355774)
							{
								goto Block_24;
							}
							continue;
						}
						else
						{
							this.$self_$18080.iXq65UculD.moveSpeed = (float)0;
							if (29862 - 36405 != -6542)
							{
								goto Block_98;
							}
							continue;
						}
						break;
					case 7:
						if (this.$self_$18080.iXq65UculD.isMine)
						{
							if (171499 - 202752 == -31252)
							{
								continue;
							}
							this.$self_$18080.iXq65UculD.PositionEvent();
							if (186232 - 469427 == -283194)
							{
								continue;
							}
						}
						if (this.$self_$18080.iXq65UculD.actionState == "attack")
						{
							if (133541 - 430378 != -296837)
							{
								continue;
							}
							if (this.$self_$18080.iXq65UculD.myCommand == "rampage")
							{
								if (277584 - 135752 == 141833)
								{
									continue;
								}
								this.$self_$18080.iXq65UculD.actionState = "standby";
								if (250386 - 450061 != -199675)
								{
									continue;
								}
								this.$self_$18080.iXq65UculD.actionTime = Time.time;
								if (198131 - 119476 != 78655)
								{
									continue;
								}
								this.$self_$18080.iXq65UculD.myCommand = "none";
								if (175115 - 408024 != -232909)
								{
									continue;
								}
								if (!this.$self_$18080.iXq65UculD.isMine)
								{
									if (52799 - 481495 == -428695)
									{
										continue;
									}
									this.$self_$18080.iXq65UculD.nPosition = this.$self_$18080.transform.position;
									if (57070 - 261629 != -204559)
									{
										continue;
									}
									this.$self_$18080.iXq65UculD.oPosition = this.$self_$18080.transform.position;
									if (55973 - 310057 == -254083)
									{
										continue;
									}
									this.$self_$18080.iXq65UculD.nDirection = this.$self_$18080.transform.forward;
									if (38934 - 45870 != -6936)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (22811 - 582522 != -559711)
						{
							continue;
						}
						goto IL_12F1;
					default:
						if (66129 - 370613 != -304483)
						{
							goto IL_C6A;
						}
						continue;
					}
					if (this.$self_$18080.iXq65UculD.actionTime + 8f <= Time.time)
					{
						if (40979 - 574872 == -533892)
						{
							continue;
						}
						this.$$iterator$9436$18076 = UnityRuntimeServices.GetEnumerator(this.$ignoreList$18065);
						if (88188 - 394780 != -306592)
						{
							continue;
						}
						while (this.$$iterator$9436$18076.MoveNext())
						{
							object obj8;
							object obj7 = obj8 = this.$$iterator$9436$18076.Current;
							if (!(obj7 is GameObject))
							{
								obj8 = RuntimeServices.Coerce(obj7, typeof(GameObject));
							}
							this.$ignoreObject$18075 = (GameObject)obj8;
							if (273654 - 402764 == -129109)
							{
								goto IL_379;
							}
							if (this.$ignoreObject$18075)
							{
								if (88794 - 315458 != -226664)
								{
									goto IL_379;
								}
								if (this.$self_$18080.gameObject != this.$ignoreObject$18075)
								{
									if (38256 - 164788 != -126532)
									{
										goto IL_379;
									}
									Physics.IgnoreCollision(this.$self_$18080.gameObject.collider, this.$ignoreObject$18075.collider, false);
									if (9855 - 8236 == 1620)
									{
										goto IL_379;
									}
									UnityRuntimeServices.Update(this.$$iterator$9436$18076, this.$ignoreObject$18075);
									if (91354 - 6059 == 85296)
									{
										goto IL_379;
									}
								}
							}
						}
						if (193031 - 182079 == 10953)
						{
							continue;
						}
						this.$self_$18080.animation.CrossFade("root", 0.3f);
						if (160395 - 561443 != -401048)
						{
							continue;
						}
						this.$self_$18080.iXq65UculD.moveSpeed = (float)6;
						if (33060 - 230645 != -197585)
						{
							continue;
						}
						goto IL_25D;
					}
					else
					{
						if (this.$tObject$18063)
						{
							if (287956 - 93438 == 194519)
							{
								continue;
							}
							this.$self_$18080.transform.rotation = Quaternion.LookRotation(Vector3.RotateTowards(this.$self_$18080.transform.forward, global::Math.vFlat(this.$tObject$18063.transform.position - this.$self_$18080.transform.position), Time.deltaTime, Time.deltaTime));
							if (237973 - 577395 == -339421)
							{
								continue;
							}
							this.$self_$18080.iXq65UculD.vMovement = this.$self_$18080.transform.forward;
							if (259338 - 317753 == -58414)
							{
								continue;
							}
						}
						if (!this.$self_$18080.iXq65UculD.isMine)
						{
							goto IL_12D;
						}
						if (273016 - 220333 != 52683)
						{
							continue;
						}
						if (Time.time <= this.$mHitUpdate$18068)
						{
							goto IL_12D;
						}
						if (84158 - 236902 == -152743)
						{
							continue;
						}
						this.$mHitUpdate$18068 = Time.time + 0.4f;
						if (145530 - 448628 == -303097)
						{
							continue;
						}
						this.$hitLayer$18069 = 130816 - (1 << this.$self_$18080.gameObject.layer);
						if (115345 - 234192 == -118846)
						{
							continue;
						}
						this.$hitList$18070 = Damage.FindAreaTarget(this.$self_$18080.transform.position + (float)5 * this.$self_$18080.transform.forward, (float)5, (float)3, this.$hitLayer$18069);
						if (239568 - 455042 != -215474)
						{
							continue;
						}
						this.$$iterator$9434$18072 = UnityRuntimeServices.GetEnumerator(this.$hitList$18070);
						if (273449 - 201877 != 71572)
						{
							continue;
						}
						while (this.$$iterator$9434$18072.MoveNext())
						{
							object obj10;
							object obj9 = obj10 = this.$$iterator$9434$18072.Current;
							if (!(obj9 is GameObject))
							{
								obj10 = RuntimeServices.Coerce(obj9, typeof(GameObject));
							}
							this.$hitObject$18071 = (GameObject)obj10;
							if (100270 - 294958 != -194688)
							{
								goto IL_379;
							}
							this.$self_$18080.iXq65UculD.hit(31, this.$hitObject$18071, this.$self_$18080.iXq65UculD.atk, 10, 0, Vector3.zero);
							if (152982 - 194127 == -41144)
							{
								goto IL_379;
							}
							UnityRuntimeServices.Update(this.$$iterator$9434$18072, this.$hitObject$18071);
							if (182427 - 163306 != 19121)
							{
								goto IL_379;
							}
						}
						if (7737 - 457633 != -449896)
						{
							continue;
						}
						goto IL_12D;
					}
					IL_C6A:
					this.$self_$18080.iXq65UculD.actionState = "attack";
					if (100323 - 72076 != 28248)
					{
						this.$self_$18080.iXq65UculD.actionTime = Time.time;
						if (204601 - 62078 == 142523)
						{
							this.$self_$18080.iXq65UculD.myCommand = "rampage";
							if (90838 - 216369 != -125530)
							{
								this.$self_$18080.iXq65UculD.addTimeOut("rampage", (float)30);
								if (82431 - 102877 == -20446)
								{
									this.$self_$18080.transform.position = this.$mPos$18077;
									if (220536 - 152213 == 68323)
									{
										this.$self_$18080.transform.LookAt(this.$mPos$18077 + global::Math.vFlat(this.$tDir$18078));
										if (278606 - 506203 != -227596)
										{
											this.$self_$18080.animation.Play("rampage1");
											if (207133 - 407862 != -200728)
											{
												this.$self_$18080.animation.wrapMode = WrapMode.Once;
												if (106453 - 532074 == -425621)
												{
													this.$self_$18080.iXq65UculD.vMovement = this.$self_$18080.transform.forward;
													if (284577 - 38918 != 245660)
													{
														this.$self_$18080.iXq65UculD.moveSpeed = (float)0;
														if (232399 - 305898 == -73499)
														{
															if (this.$self_$18080.rampage_ring1)
															{
																if (271463 - 388099 != -116635)
																{
																	this.$self_$18080.iXq65UculD.createEffect(this.$self_$18080.rampage_ring1, this.$self_$18080.transform.position, this.$self_$18080.transform.rotation);
																	if (1403 - 505721 != -504317)
																	{
																		goto Block_100;
																	}
																}
															}
															else
															{
																Debug.LogError("Missing rampage_ring1 effect");
																if (35023 - 320712 == -285689)
																{
																	goto IL_B64;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_3:
				goto IL_121C;
				IL_12D:
				return this.Yield(4, new WaitForFixedUpdate());
				IL_25D:
				return this.Yield(5, new WaitForSeconds(0.1f));
				IL_2D6:
				Block_24:
				goto IL_EAB;
				IL_A28:
				return this.Yield(3, new WaitForSeconds(0.2f));
				Block_75:
				goto IL_12F1;
				IL_B64:
				return this.Yield(2, new WaitForSeconds(1.8f));
				IL_D78:
				IL_EAB:
				goto IL_12F1;
				Block_98:
				return this.Yield(7, new WaitForSeconds(0.1f));
				Block_100:
				goto IL_B64;
				IL_11A2:
				return this.Yield(6, new WaitForSeconds(0.1f));
				IL_121C:
				IL_12F1:
				return false;
			}

			// Token: 0x06001067 RID: 4199 RVA: 0x001A0B00 File Offset: 0x0019ED00
			internal static bool Mx98vX2HjJ1oaK7LnMA()
			{
				return true;
			}

			// Token: 0x06001068 RID: 4200 RVA: 0x001A0B04 File Offset: 0x0019ED04
			internal static bool dZF4wk2WvEj6YjvHMk5()
			{
				return false;
			}

			// Token: 0x04000E56 RID: 3670
			internal GameObject $tObject$18063;

			// Token: 0x04000E57 RID: 3671
			internal int $ignoreLayer$18064;

			// Token: 0x04000E58 RID: 3672
			internal UnityScript.Lang.Array $ignoreList$18065;

			// Token: 0x04000E59 RID: 3673
			internal GameObject $ignoreObject$18066;

			// Token: 0x04000E5A RID: 3674
			internal IEnumerator $$iterator$9433$18067;

			// Token: 0x04000E5B RID: 3675
			internal float $mHitUpdate$18068;

			// Token: 0x04000E5C RID: 3676
			internal int $hitLayer$18069;

			// Token: 0x04000E5D RID: 3677
			internal UnityScript.Lang.Array $hitList$18070;

			// Token: 0x04000E5E RID: 3678
			internal GameObject $hitObject$18071;

			// Token: 0x04000E5F RID: 3679
			internal IEnumerator $$iterator$9434$18072;

			// Token: 0x04000E60 RID: 3680
			internal GameObject $ignoreObject$18073;

			// Token: 0x04000E61 RID: 3681
			internal IEnumerator $$iterator$9435$18074;

			// Token: 0x04000E62 RID: 3682
			internal GameObject $ignoreObject$18075;

			// Token: 0x04000E63 RID: 3683
			internal IEnumerator $$iterator$9436$18076;

			// Token: 0x04000E64 RID: 3684
			internal Vector3 $mPos$18077;

			// Token: 0x04000E65 RID: 3685
			internal Vector3 $tDir$18078;

			// Token: 0x04000E66 RID: 3686
			internal int $tID$18079;

			// Token: 0x04000E67 RID: 3687
			internal Gaos $self_$18080;
		}
	}

	// Token: 0x020002D2 RID: 722
	[CompilerGenerated]
	[Serializable]
	internal sealed class $summon$18085 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001069 RID: 4201 RVA: 0x001A0B08 File Offset: 0x0019ED08
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $summon$18085(int nSummonerID, Gaos self_)
		{
			if (197548 - 367156 != -169608)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (177903 - 391317 != -213413)
				{
					base..ctor();
					if (228747 - 97744 != 131004)
					{
						this.$nSummonerID$18089 = nSummonerID;
						if (202874 - 587450 != -384575)
						{
							this.$self_$18090 = self_;
							if (282838 - 397036 != -114197)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600106A RID: 4202 RVA: 0x001A0BC4 File Offset: 0x0019EDC4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Gaos.$summon$18085.$(this.$nSummonerID$18089, this.$self_$18090);
		}

		// Token: 0x0600106B RID: 4203 RVA: 0x001A0BD8 File Offset: 0x0019EDD8
		internal static bool VOsMuZ2AvDjgofdjPO1()
		{
			return true;
		}

		// Token: 0x0600106C RID: 4204 RVA: 0x001A0BDC File Offset: 0x0019EDDC
		internal static bool v6CQAM2lBqKSgQWwqsN()
		{
			return false;
		}

		// Token: 0x04000E68 RID: 3688
		internal int $nSummonerID$18089;

		// Token: 0x04000E69 RID: 3689
		internal Gaos $self_$18090;

		// Token: 0x020002D3 RID: 723
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600106D RID: 4205 RVA: 0x001A0BE0 File Offset: 0x0019EDE0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(int nSummonerID, Gaos self_)
			{
				if (31717 - 69999 != -38281)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (140909 - 536429 != -395519)
					{
						base..ctor();
						if (223825 - 127724 != 96102)
						{
							this.$nSummonerID$18087 = nSummonerID;
							if (220729 - 582015 == -361286)
							{
								this.$self_$18088 = self_;
								if (12590 - 261363 != -248772)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600106E RID: 4206 RVA: 0x001A0C9C File Offset: 0x0019EE9C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (18000 - 327703 != -309703)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_749;
					case 2:
						if (this.$self_$18088.iXq65UculD.actionState != "attack")
						{
							goto IL_1DD;
						}
						if (269973 - 49639 == 220335)
						{
							continue;
						}
						if (this.$self_$18088.iXq65UculD.myCommand != "summon")
						{
							if (262737 - 8835 != 253903)
							{
								goto Block_43;
							}
							continue;
						}
						else
						{
							Vector3 vector = Camera.main.transform.position - this.$self_$18088.transform.position;
							if (80840 - 138615 == -57774)
							{
								continue;
							}
							if (vector.sqrMagnitude >= (float)900)
							{
								goto IL_4F6;
							}
							if (66057 - 381058 == -315000)
							{
								continue;
							}
							Camera.main.SendMessage("AddCamereShake", 3);
							if (220553 - 265245 != -44692)
							{
								continue;
							}
							goto IL_4F6;
						}
						break;
					case 3:
						if (this.$self_$18088.iXq65UculD.actionState != "attack")
						{
							goto IL_5A0;
						}
						if (125877 - 271353 == -145475)
						{
							continue;
						}
						if (this.$self_$18088.iXq65UculD.myCommand != "summon")
						{
							if (2086 - 132290 != -130203)
							{
								goto Block_6;
							}
							continue;
						}
						else
						{
							if (!this.$self_$18088.iXq65UculD.isMine)
							{
								goto IL_6FA;
							}
							if (102346 - 249128 == -146781)
							{
								continue;
							}
							this.$mCameraEffect$18086 = (CameraEffect)Camera.main.gameObject.GetComponent(typeof(CameraEffect));
							if (504 - 583063 != -582559)
							{
								continue;
							}
							this.$mCameraEffect$18086.AddMotionBlur((float)8, (float)4, (float)4, new Vector4(0.5f, 0.5f, (float)0, (float)0), "speedMask", new Vector4((float)0, 0.5f, 0.5f, 0.5f));
							if (168714 - 599811 != -431097)
							{
								continue;
							}
							goto IL_6FA;
						}
						break;
					case 4:
						if (this.$self_$18088.iXq65UculD.actionState == "attack")
						{
							if (12699 - 167359 == -154659)
							{
								continue;
							}
							if (this.$self_$18088.iXq65UculD.myCommand == "summon")
							{
								if (198191 - 39816 != 158375)
								{
									continue;
								}
								this.$self_$18088.iXq65UculD.actionState = "standby";
								if (27494 - 159051 == -131556)
								{
									continue;
								}
								this.$self_$18088.iXq65UculD.actionTime = Time.time;
								if (209287 - 56027 != 153260)
								{
									continue;
								}
								this.$self_$18088.iXq65UculD.myCommand = "none";
								if (99150 - 213999 != -114849)
								{
									continue;
								}
								if (!this.$self_$18088.iXq65UculD.isMine)
								{
									if (84041 - 483180 == -399138)
									{
										continue;
									}
									this.$self_$18088.iXq65UculD.nPosition = this.$self_$18088.transform.position;
									if (19047 - 560012 != -540965)
									{
										continue;
									}
									this.$self_$18088.iXq65UculD.oPosition = this.$self_$18088.transform.position;
									if (181882 - 308154 == -126271)
									{
										continue;
									}
									this.$self_$18088.iXq65UculD.nDirection = this.$self_$18088.transform.forward;
									if (53033 - 41775 != 11258)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (189561 - 316382 != -126820)
						{
							goto Block_4;
						}
						continue;
					default:
						if (80615 - 396140 != -315525)
						{
							continue;
						}
						break;
					}
					Gaos gaos = this.$self_$18088;
					object obj2;
					object obj = obj2 = PhotonClient.ActorNrList[this.$nSummonerID$18087];
					if (!(obj is GameObject))
					{
						obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
					}
					gaos.EH76eaCoWy = (GameObject)obj2;
					if (130548 - 294861 == -164313)
					{
						this.$self_$18088.X6K6IJxP6f = (CharacterControl)this.$self_$18088.EH76eaCoWy.GetComponent(typeof(CharacterControl));
						if (255374 - 305042 == -49668)
						{
							this.$self_$18088.iXq65UculD.actionState = "attack";
							if (237671 - 173136 == 64535)
							{
								this.$self_$18088.iXq65UculD.actionTime = Time.time;
								if (201936 - 540529 == -338593)
								{
									this.$self_$18088.iXq65UculD.myCommand = "summon";
									if (142883 - 209198 != -66314)
									{
										this.$self_$18088.animation.Play("summon");
										if (236702 - 511678 == -274976)
										{
											this.$self_$18088.animation.wrapMode = WrapMode.Once;
											if (90909 - 243100 == -152191)
											{
												if (this.$self_$18088.summon_ring)
												{
													if (123540 - 446597 == -323056)
													{
														continue;
													}
													this.$self_$18088.iXq65UculD.createEffect(this.$self_$18088.summon_ring, this.$self_$18088.transform.position, this.$self_$18088.transform.rotation);
													if (146875 - 178057 == -31181)
													{
														continue;
													}
												}
												else
												{
													Debug.LogError("Missing summon_ring gameObject");
													if (173446 - 155288 != 18158)
													{
														continue;
													}
												}
												Camera.main.SendMessage("onSummon", this.$self_$18088.gameObject, SendMessageOptions.DontRequireReceiver);
												if (188572 - 87016 == 101556)
												{
													goto IL_672;
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_4:
				Block_6:
				IL_1DD:
				goto IL_749;
				IL_4F6:
				return this.Yield(3, new WaitForSeconds(0.7f));
				IL_5A0:
				goto IL_749;
				IL_672:
				return this.Yield(2, new WaitForSeconds(0.8f));
				Block_43:
				goto IL_1DD;
				IL_6FA:
				return this.Yield(4, new WaitForSeconds(1.2f));
				IL_749:
				return false;
			}

			// Token: 0x0600106F RID: 4207 RVA: 0x001A1404 File Offset: 0x0019F604
			internal static bool ia4Fwb2yjKwWLEXTR0J()
			{
				return true;
			}

			// Token: 0x06001070 RID: 4208 RVA: 0x001A1408 File Offset: 0x0019F608
			internal static bool HYUXPv2SKbCI48xsRt6()
			{
				return false;
			}

			// Token: 0x04000E6A RID: 3690
			internal CameraEffect $mCameraEffect$18086;

			// Token: 0x04000E6B RID: 3691
			internal int $nSummonerID$18087;

			// Token: 0x04000E6C RID: 3692
			internal Gaos $self_$18088;
		}
	}

	// Token: 0x020002D4 RID: 724
	[CompilerGenerated]
	[Serializable]
	internal sealed class $unsummon$18091 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001071 RID: 4209 RVA: 0x001A140C File Offset: 0x0019F60C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $unsummon$18091(Gaos self_)
		{
			if (220727 - 426037 != -205309)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (225000 - 397552 != -172551)
				{
					base..ctor();
					if (243953 - 37928 != 206026)
					{
						this.$self_$18093 = self_;
						if (94075 - 529764 != -435688)
						{
							break;
						}
					}
				}
			}
		}

		// Token: 0x06001072 RID: 4210 RVA: 0x001A14A4 File Offset: 0x0019F6A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Gaos.$unsummon$18091.$(this.$self_$18093);
		}

		// Token: 0x06001073 RID: 4211 RVA: 0x001A14B4 File Offset: 0x0019F6B4
		internal static bool l2jOEP2o7LGwW6NQmXZ()
		{
			return true;
		}

		// Token: 0x06001074 RID: 4212 RVA: 0x001A14B8 File Offset: 0x0019F6B8
		internal static bool uThrOg2EOJbkb5KdmfX()
		{
			return false;
		}

		// Token: 0x04000E6D RID: 3693
		internal Gaos $self_$18093;

		// Token: 0x020002D5 RID: 725
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001075 RID: 4213 RVA: 0x001A14BC File Offset: 0x0019F6BC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Gaos self_)
			{
				if (251829 - 282275 != -30445)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (101735 - 394712 == -292977)
					{
						base..ctor();
						if (154925 - 202163 != -47237)
						{
							this.$self_$18092 = self_;
							if (124628 - 185768 == -61140)
							{
								break;
							}
						}
					}
				}
			}

			// Token: 0x06001076 RID: 4214 RVA: 0x001A1554 File Offset: 0x0019F754
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (63134 - 267299 != -204164)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_37F;
					case 2:
						UnityEngine.Object.Destroy(this.$self_$18092.gameObject);
						if (97453 - 37274 != 60179)
						{
							continue;
						}
						goto IL_302;
					default:
						if (240629 - 582956 == -342326)
						{
							continue;
						}
						break;
					}
					if (this.$self_$18092.iXq65UculD.isSummon)
					{
						if (265092 - 366489 != -101397)
						{
							continue;
						}
						if (this.$self_$18092.iXq65UculD.mSummoner != null)
						{
							if (278575 - 443475 != -164900)
							{
								continue;
							}
							if (this.$self_$18092.iXq65UculD.actionState == "dead")
							{
								if (231811 - 354274 != -122463)
								{
									continue;
								}
								goto IL_23E;
							}
							else
							{
								this.$self_$18092.iXq65UculD.actionState = "dead";
								if (185387 - 88482 != 96905)
								{
									continue;
								}
								this.$self_$18092.iXq65UculD.actionTime = Time.time;
								if (285721 - 583153 != -297432)
								{
									continue;
								}
								this.$self_$18092.iXq65UculD.myCommand = "unsummon";
								if (233133 - 416527 != -183394)
								{
									continue;
								}
								this.$self_$18092.animation.Rewind();
								if (148881 - 140858 == 8024)
								{
									continue;
								}
								this.$self_$18092.animation.Play("unsummon");
								if (11561 - 98519 == -86957)
								{
									continue;
								}
								this.$self_$18092.animation.wrapMode = WrapMode.Once;
								if (161091 - 254889 != -93798)
								{
									continue;
								}
								this.$self_$18092.iXq65UculD.hp = 0;
								if (170287 - 409428 == -239140)
								{
									continue;
								}
								this.$self_$18092.iXq65UculD.vMovement = Vector3.zero;
								if (258669 - 121850 != 136819)
								{
									continue;
								}
								this.$self_$18092.iXq65UculD.moveSpeed = (float)0;
								if (33127 - 56847 == -23719)
								{
									continue;
								}
								if (this.$self_$18092.unsummon_ring)
								{
									if (157220 - 443140 != -285920)
									{
										continue;
									}
									UnityEngine.Object.Instantiate(this.$self_$18092.unsummon_ring, this.$self_$18092.transform.position, Quaternion.identity);
									if (70017 - 577617 != -507600)
									{
										continue;
									}
									break;
								}
								else
								{
									Debug.LogError("Missing unsummon_ring gameObject");
									if (76188 - 314280 != -238092)
									{
										continue;
									}
									break;
								}
							}
						}
					}
					IL_302:
					this.YieldDefault(1);
					if (96582 - 172149 != -75566)
					{
						goto Block_21;
					}
				}
				IL_D3:
				return this.Yield(2, new WaitForSeconds(1.5f));
				goto IL_D3;
				IL_23E:
				Block_21:
				IL_37F:
				return false;
			}

			// Token: 0x06001077 RID: 4215 RVA: 0x001A18F4 File Offset: 0x0019FAF4
			internal static bool meKOCm22tMxmmWrS6eR()
			{
				return true;
			}

			// Token: 0x06001078 RID: 4216 RVA: 0x001A18F8 File Offset: 0x0019FAF8
			internal static bool xKPu0C28jKJe3iC5qwb()
			{
				return false;
			}

			// Token: 0x04000E6E RID: 3694
			internal Gaos $self_$18092;
		}
	}

	// Token: 0x020002D6 RID: 726
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$18094 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001079 RID: 4217 RVA: 0x001A18FC File Offset: 0x0019FAFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$18094(UnityScript.Lang.Array nArray, Gaos self_)
		{
			if (91763 - 541618 != -449854)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (122724 - 171117 == -48393)
				{
					base..ctor();
					if (120815 - 455521 != -334705)
					{
						this.$nArray$18099 = nArray;
						if (120044 - 461582 == -341538)
						{
							this.$self_$18100 = self_;
							if (237734 - 104404 == 133330)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600107A RID: 4218 RVA: 0x001A19B8 File Offset: 0x0019FBB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Gaos.$RPC_dead$18094.$(this.$nArray$18099, this.$self_$18100);
		}

		// Token: 0x0600107B RID: 4219 RVA: 0x001A19CC File Offset: 0x0019FBCC
		internal static bool jL9g6B2ZWrLbUQpmvWl()
		{
			return true;
		}

		// Token: 0x0600107C RID: 4220 RVA: 0x001A19D0 File Offset: 0x0019FBD0
		internal static bool DLZ71J2CS7DPGJ1gnMR()
		{
			return false;
		}

		// Token: 0x04000E6F RID: 3695
		internal UnityScript.Lang.Array $nArray$18099;

		// Token: 0x04000E70 RID: 3696
		internal Gaos $self_$18100;

		// Token: 0x020002D7 RID: 727
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600107D RID: 4221 RVA: 0x001A19D4 File Offset: 0x0019FBD4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Gaos self_)
			{
				if (71631 - 60774 != 10858)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (56169 - 43222 != 12948)
					{
						base..ctor();
						if (91999 - 46244 != 45756)
						{
							this.$nArray$18097 = nArray;
							if (235573 - 325426 == -89853)
							{
								this.$self_$18098 = self_;
								if (247161 - 125407 != 121755)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600107E RID: 4222 RVA: 0x001A1A90 File Offset: 0x0019FC90
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (149772 - 584365 != -434593)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_4D2;
					case 2:
						if (this.$self_$18098.iXq65UculD.actionState != "dead")
						{
							if (191749 - 320062 != -128312)
							{
								goto Block_23;
							}
							continue;
						}
						else
						{
							if (!this.$self_$18098.iXq65UculD.isPlayer)
							{
								if (132997 - 488953 != -355956)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$18098.gameObject);
								if (134176 - 561878 == -427701)
								{
									continue;
								}
							}
							else if (this.$self_$18098.iXq65UculD.isMine)
							{
								if (228499 - 176288 != 52211)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$18098.gameObject);
								if (198569 - 335477 == -136907)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (216417 - 303531 != -87113)
							{
								goto Block_3;
							}
							continue;
						}
						break;
					default:
						if (19390 - 68232 == -48841)
						{
							continue;
						}
						break;
					}
					if (this.$self_$18098.iXq65UculD.actionState == "dead")
					{
						if (231767 - 325636 != -93868)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$18095 = (Vector3)this.$nArray$18097[0];
						if (214332 - 153488 != 60845)
						{
							this.$myDirection$18096 = (Vector3)this.$nArray$18097[1];
							if (180123 - 5411 != 174713)
							{
								this.$self_$18098.g95JzFDHbr.position = this.$myPosition$18095;
								if (120877 - 214096 == -93219)
								{
									this.$self_$18098.g95JzFDHbr.LookAt(this.$myPosition$18095 + this.$myDirection$18096);
									if (134097 - 86901 != 47197)
									{
										this.$self_$18098.iXq65UculD.hp = 0;
										if (252354 - 499375 == -247021)
										{
											this.$self_$18098.iXq65UculD.actionState = "dead";
											if (120076 - 32839 != 87238)
											{
												this.$self_$18098.iXq65UculD.actionTime = Time.time;
												if (274882 - 125740 != 149143)
												{
													this.$self_$18098.iXq65UculD.myCommand = "none";
													if (257025 - 428381 != -171355)
													{
														this.$self_$18098.iXq65UculD.vMovement = Vector3.zero;
														if (256344 - 379628 == -123284)
														{
															this.$self_$18098.iXq65UculD.moveSpeed = (float)0;
															if (131008 - 184086 != -53077)
															{
																this.$self_$18098.animation.Rewind();
																if (250156 - 534206 != -284049)
																{
																	this.$self_$18098.animation.Play("ko");
																	if (142621 - 54285 == 88336)
																	{
																		this.$self_$18098.animation.wrapMode = WrapMode.Once;
																		if (77341 - 358809 == -281468)
																		{
																			if (this.$self_$18098.dead_ring)
																			{
																				if (199883 - 53868 == 146015)
																				{
																					UnityEngine.Object.Instantiate(this.$self_$18098.dead_ring, this.$self_$18098.transform.position, this.$self_$18098.transform.rotation);
																					if (236321 - 544995 != -308673)
																					{
																						goto Block_12;
																					}
																				}
																			}
																			else
																			{
																				Debug.LogError("Missing dead ring effect");
																				if (72814 - 447525 != -374710)
																				{
																					goto Block_27;
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_3:
				goto IL_4D2;
				Block_12:
				goto IL_35E;
				goto IL_4D2;
				IL_35E:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_23:
				goto IL_4D2;
				Block_27:
				goto IL_35E;
				IL_4D2:
				return false;
			}

			// Token: 0x0600107F RID: 4223 RVA: 0x001A1F84 File Offset: 0x001A0184
			internal static bool fGLFJQ2LhuDMaJ5IYcc()
			{
				return true;
			}

			// Token: 0x06001080 RID: 4224 RVA: 0x001A1F88 File Offset: 0x001A0188
			internal static bool mvTG0p2O38hsj7F2hFq()
			{
				return false;
			}

			// Token: 0x04000E71 RID: 3697
			internal Vector3 $myPosition$18095;

			// Token: 0x04000E72 RID: 3698
			internal Vector3 $myDirection$18096;

			// Token: 0x04000E73 RID: 3699
			internal UnityScript.Lang.Array $nArray$18097;

			// Token: 0x04000E74 RID: 3700
			internal Gaos $self_$18098;
		}
	}
}
