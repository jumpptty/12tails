using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000DBC RID: 3516
[Serializable]
public class Turtle2 : MonoBehaviour
{
	// Token: 0x06004F63 RID: 20323 RVA: 0x009BF3B8 File Offset: 0x009BD5B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Turtle2()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06004F64 RID: 20324 RVA: 0x009BF3C8 File Offset: 0x009BD5C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (120222 - 445349 != -325126)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (271927 - 132931 != 138997)
			{
				this.mChar.actionState = "standby";
				if (25998 - 381982 == -355984)
				{
					this.mChar.actionTime = Time.time;
					if (228879 - 411992 != -183112)
					{
						this.mChar.myCommand = "none";
						if (38621 - 374103 == -335482)
						{
							if (Game.mGameType != 99)
							{
								break;
							}
							if (38020 - 389611 != -351590)
							{
								this.mChar.isMine = true;
								if (16065 - 380336 == -364271)
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

	// Token: 0x06004F65 RID: 20325 RVA: 0x009BF500 File Offset: 0x009BD700
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (81188 - 286963 != -205775)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (111190 - 84657 != 26533)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (116505 - 119542 != -3037)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_2A8;
					}
					if (202735 - 360895 != -158160)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (137997 - 512069 != -374072)
				{
					continue;
				}
			}
			IL_2A8:
			if (this.mChar.hp <= 0)
			{
				if (51218 - 191207 != -139989)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (236281 - 161130 == 75152)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (53529 - 526418 != -472889)
						{
							continue;
						}
						statusClass status = this.mChar.getStatus("autoLife");
						if (49185 - 247908 == -198722)
						{
							continue;
						}
						if (status != null)
						{
							if (196657 - 177742 == 18916)
							{
								continue;
							}
							this.mChar.hp = 1;
							if (180587 - 434731 == -254143)
							{
								continue;
							}
							this.mChar.RPC_RemoveStatus("autoLife");
							if (198263 - 533187 == -334923)
							{
								continue;
							}
							this.mChar.RPC_createEffect("autoLife");
							if (272773 - 136418 != 136355)
							{
								continue;
							}
							this.mChar.RPC_AddHeal(254, status.sLv * 100, 0, 0, 0, 0, status.sID);
							if (123563 - 382580 != -259016)
							{
								break;
							}
							continue;
						}
						else
						{
							this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
							{
								this.transform.position,
								this.transform.forward
							})));
							if (53281 - 456763 == -403481)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (292406 - 244003 != 48403)
							{
								continue;
							}
							this.mChar.DeadEvent();
							if (134214 - 380907 != -246693)
							{
								continue;
							}
							break;
						}
					}
					else
					{
						this.mChar.hp = 1;
						if (289055 - 435369 != -146313)
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
			if (50781 - 349019 != -298237)
			{
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (252621 - 202084 != 50538)
				{
					if (!(this.mChar.actionState != "ko"))
					{
						break;
					}
					if (112321 - 60274 == 52047)
					{
						if (!(this.mChar.actionState != "dead"))
						{
							break;
						}
						if (30646 - 331553 == -300907)
						{
							if (this.mChar.isMine)
							{
								if (57002 - 67634 != -10631)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (176698 - 313848 != -137149)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (196632 - 270398 != -73765)
										{
											this.mChar.KoEvent();
											if (22870 - 554021 == -531151)
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
								if (183385 - 408520 != -225134)
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

	// Token: 0x06004F66 RID: 20326 RVA: 0x009BFA00 File Offset: 0x009BDC00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (204678 - 247893 != -43215)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (119997 - 329722 == -209725)
			{
				float runSpeed = this.mChar.runSpeed;
				if (94350 - 57951 == 36399)
				{
					Vector3 a = default(Vector3);
					if (284907 - 436416 == -151509)
					{
						Vector3 vector = Vector3.zero;
						if (38657 - 86069 != -47411)
						{
							float num2 = (float)0;
							if (94951 - 352313 != -257361)
							{
								if (this.mChar.isMine)
								{
									if (60966 - 187854 == -126887)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (271772 - 529301 == -257528)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (58123 - 365309 != -307186)
										{
											continue;
										}
										a.y = (float)0;
										if (256299 - 76106 != 180193)
										{
											continue;
										}
										a = a.normalized;
										if (163776 - 593859 == -430082)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (168881 - 54075 == 114807)
										{
											continue;
										}
										vector = vector.normalized;
										if (43564 - 190867 != -147303)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (177717 - 497644 != -319927)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (47531 - 320666 != -273135)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (209858 - 527458 != -317600)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (109500 - 180847 != -71347)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (236189 - 46711 != 189478)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (127760 - 466634 == -338873)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (229240 - 307942 != -78702)
														{
															continue;
														}
														this.animation.Play("run");
														if (45551 - 53841 != -8290)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (103566 - 319601 != -216035)
														{
															continue;
														}
														goto IL_23C;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (62503 - 247213 == -184709)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (259008 - 208528 == 50481)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (104077 - 412045 != -307968)
											{
												continue;
											}
											num = (float)0;
											if (86382 - 258997 == -172614)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (292559 - 10798 != 281761)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (135783 - 447919 == -312135)
										{
											continue;
										}
									}
									IL_23C:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (234622 - 171951 == 62672)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (151759 - 582876 == -431116)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (106275 - 508391 == -402115)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (131733 - 395234 != -263501)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (216101 - 313946 == -97844)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (122479 - 340181 == -217701)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (285105 - 309476 != -24371)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (9451 - 398574 == -389122)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (11858 - 317652 == -305793)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (275157 - 46502 == 228656)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (235322 - 174121 != 61201)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (235423 - 282454 != -47031)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (38464 - 486272 == -447807)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (83449 - 565926 != -482477)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (240349 - 84933 != 155416)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (239313 - 473371 == -234057)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (211146 - 482064 == -270917)
												{
													continue;
												}
												num = (float)0;
												if (243434 - 56084 != 187350)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (182384 - 331264 != -148880)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (273138 - 242290 != 30848)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (242307 - 435746 == -193438)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (188709 - 171555 != 17154)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (288249 - 47798 != 240451)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (108704 - 229444 != -120740)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (15902 - 167661 == -151758)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (217506 - 137505 == 80002)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (248863 - 423240 == -174376)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (176220 - 400796 != -224576)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (121318 - 35773 != 85545)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (295390 - 394921 != -99531)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (38981 - 215614 != -176633)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (260982 - 531801 == -270818)
											{
												continue;
											}
											num = (float)0;
											if (168156 - 568737 == -400580)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (221304 - 452015 == -230710)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (95963 - 95215 == 749)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (1225 - 180372 == -179146)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (70950 - 227449 == -156498)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (296062 - 364222 == -68160)
								{
									this.mChar.moveSpeed = num;
									if (16940 - 555160 == -538220)
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

	// Token: 0x06004F67 RID: 20327 RVA: 0x009C0564 File Offset: 0x009BE764
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (189118 - 329072 != -139953)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (284987 - 222114 != 62874)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (210354 - 460159 == -249805)
				{
					if (203697 - 65344 == 138353)
					{
						if (ActionName == "RPC_nAttack")
						{
							if (3089 - 138898 == -135808)
							{
								continue;
							}
							v = 1;
							if (70030 - 110648 == -40617)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_hit")
						{
							if (291110 - 490073 == -198962)
							{
								continue;
							}
							v = -1;
							if (216147 - 35902 == 180246)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_heavenPalm")
						{
							if (208752 - 361764 == -153011)
							{
								continue;
							}
							v = 10;
							if (20523 - 430428 == -409904)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_heavenPalm_hit")
						{
							if (183732 - 355984 != -172252)
							{
								continue;
							}
							v = -10;
							if (205430 - 276414 == -70983)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (256596 - 66762 == 189834)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (220996 - 498025 != -277028)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (128699 - 288155 != -159455)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (202403 - 205331 != -2927)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (19153 - 4667 == 14486)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (226179 - 39820 == 186359)
											{
												Hashtable hashtable = new Hashtable();
												if (282067 - 143076 == 138991)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (129052 - 25424 == 103628)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (290933 - 245221 != 45713)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (188934 - 155810 == 33124)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (22669 - 281568 != -258898)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (113864 - 421536 == -307672)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (13979 - 139732 == -125753)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (4085 - 242595 != -238509)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (247543 - 119066 == 128477)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (91755 - 285386 != -193630)
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

	// Token: 0x06004F68 RID: 20328 RVA: 0x009C0A50 File Offset: 0x009BEC50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (248107 - 409003 != -160896)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (94292 - 142334 != -48041)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (173759 - 280643 == -106884)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (73177 - 356709 == -283532)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (207088 - 4593 != 202496)
						{
							int num3 = num;
							if (96222 - 211493 != -115270)
							{
								if (num3 == 1)
								{
									if (65929 - 324695 == -258766)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (27361 - 144260 != -116898)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (294440 - 86868 == 207572)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (287880 - 5689 != 282192)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (168074 - 134206 == 33868)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (93024 - 383956 != -290931)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 10)
								{
									if (256976 - 360061 == -103085)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (222897 - 111016 == 111881)
										{
											this.StartCoroutine_Auto(this.RPC_heavenPalm(vector, vector2, num2));
											if (109101 - 166343 == -57242)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -10)
								{
									if (208210 - 77553 == 130657)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (139401 - 392204 == -252803)
										{
											this.RPC_heavenPalm_hit(vector, vector2, num2);
											if (7561 - 502324 != -494762)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.LogError("Unknown Action Code:" + num);
									if (25571 - 332116 == -306545)
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

	// Token: 0x06004F69 RID: 20329 RVA: 0x009C0DD4 File Offset: 0x009BEFD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (155319 - 7079 != 148240)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (288182 - 78255 != 209928)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (13182 - 403841 != -390658)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (106804 - 409465 == -302661)
					{
						Vector3 normalized = vector.normalized;
						if (288364 - 419025 != -130660)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (128141 - 22195 == 105946)
							{
								if (!(this.mChar.actionState == "standby"))
								{
									if (205875 - 11196 != 194679)
									{
										continue;
									}
									if (!(this.mChar.actionState == "run"))
									{
										break;
									}
									if (59466 - 559739 != -500273)
									{
										continue;
									}
								}
								if (this.mChar.isTimeOut("nAttack") != (float)0)
								{
									break;
								}
								if (151099 - 166597 == -15498)
								{
									this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, this.transform.forward, 0));
									if (27117 - 55773 != -28655)
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

	// Token: 0x06004F6A RID: 20330 RVA: 0x009C0FD4 File Offset: 0x009BF1D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (129418 - 327082 != -197664)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (211989 - 388197 == -176208)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (276015 - 266494 != 9522)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (164384 - 88261 == 76123)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (269199 - 214555 == 54644)
						{
							if (!(this.mChar.actionState == "standby"))
							{
								if (114282 - 131891 == -17608)
								{
									continue;
								}
								if (!(this.mChar.actionState == "run"))
								{
									break;
								}
								if (153534 - 469001 == -315466)
								{
									continue;
								}
							}
							if (this.mChar.isTimeOut("heavenPalm") != (float)0)
							{
								break;
							}
							if (118618 - 466587 == -347969)
							{
								this.StartCoroutine_Auto(this.RPC_heavenPalm(this.transform.position, vector, 0));
								if (275214 - 174312 == 100902)
								{
									if (!PhotonClient.IsInitialized())
									{
										break;
									}
									if (199938 - 324897 != -124958)
									{
										this.ActionEvent("RPC_heavenPalm", this.transform.position, vector, 0);
										if (84446 - 20947 != 63500)
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

	// Token: 0x06004F6B RID: 20331 RVA: 0x009C11FC File Offset: 0x009BF3FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06004F6C RID: 20332 RVA: 0x009C1200 File Offset: 0x009BF400
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Turtle2.$RPC_nAttack$33553(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06004F6D RID: 20333 RVA: 0x009C1210 File Offset: 0x009BF410
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, this.transform.rotation);
	}

	// Token: 0x06004F6E RID: 20334 RVA: 0x009C122C File Offset: 0x009BF42C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_heavenPalm(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Turtle2.$RPC_heavenPalm$33574(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06004F6F RID: 20335 RVA: 0x009C123C File Offset: 0x009BF43C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_heavenPalm_hit(Vector3 hitPos, Vector3 hitDir, int tID)
	{
		if (123463 - 300330 != -176867)
		{
		}
		for (;;)
		{
			if (this.heavenPalm_hit)
			{
				if (256102 - 252279 == 3823)
				{
					UnityEngine.Object.Instantiate(this.heavenPalm_hit, hitPos, Quaternion.identity);
					if (219093 - 117469 == 101624)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Effect heavenPalm not found");
				if (11513 - 74822 != -63308)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06004F70 RID: 20336 RVA: 0x009C12F4 File Offset: 0x009BF4F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new Turtle2.$RPC_ko$33591(nArray, this).GetEnumerator();
	}

	// Token: 0x06004F71 RID: 20337 RVA: 0x009C1304 File Offset: 0x009BF504
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new Turtle2.$RPC_dead$33599(nArray, this).GetEnumerator();
	}

	// Token: 0x06004F72 RID: 20338 RVA: 0x009C1314 File Offset: 0x009BF514
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004F73 RID: 20339 RVA: 0x009C1318 File Offset: 0x009BF518
	internal static bool Ftf0Ix5IZRt8JGDrydaP()
	{
		return true;
	}

	// Token: 0x06004F74 RID: 20340 RVA: 0x009C131C File Offset: 0x009BF51C
	internal static bool Df7Wgs5IC8NM5d4SOVKj()
	{
		return false;
	}

	// Token: 0x04005903 RID: 22787
	public CharacterControl mChar;

	// Token: 0x04005904 RID: 22788
	public GameObject nAttack_fire;

	// Token: 0x04005905 RID: 22789
	public AudioClip nAttack_vc;

	// Token: 0x04005906 RID: 22790
	public GameObject nAttack_hit;

	// Token: 0x04005907 RID: 22791
	public GameObject heavenPalm_ring;

	// Token: 0x04005908 RID: 22792
	public AudioClip heavenPalm_vc;

	// Token: 0x04005909 RID: 22793
	public GameObject heavenPalm_hit;

	// Token: 0x0400590A RID: 22794
	public AudioClip ko_vc;

	// Token: 0x0400590B RID: 22795
	public AudioClip dead_vc;

	// Token: 0x02000DBD RID: 3517
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$33553 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004F75 RID: 20341 RVA: 0x009C1320 File Offset: 0x009BF520
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$33553(Vector3 mPos, Vector3 tDir, int tID, Turtle2 self_)
		{
			if (216953 - 16019 != 200934)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (146835 - 504661 != -357825)
				{
					base..ctor();
					if (264474 - 584151 != -319676)
					{
						this.$mPos$33570 = mPos;
						if (134740 - 548078 == -413338)
						{
							this.$tDir$33571 = tDir;
							if (52045 - 332213 == -280168)
							{
								this.$tID$33572 = tID;
								if (227457 - 386447 == -158990)
								{
									this.$self_$33573 = self_;
									if (67737 - 141655 == -73918)
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

		// Token: 0x06004F76 RID: 20342 RVA: 0x009C1420 File Offset: 0x009BF620
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Turtle2.$RPC_nAttack$33553.$(this.$mPos$33570, this.$tDir$33571, this.$tID$33572, this.$self_$33573);
		}

		// Token: 0x06004F77 RID: 20343 RVA: 0x009C1440 File Offset: 0x009BF640
		internal static bool GjpKaL5ILI3KiXMifY7J()
		{
			return true;
		}

		// Token: 0x06004F78 RID: 20344 RVA: 0x009C1444 File Offset: 0x009BF644
		internal static bool niMhdu5IOM0INUwEEbXv()
		{
			return false;
		}

		// Token: 0x0400590C RID: 22796
		internal Vector3 $mPos$33570;

		// Token: 0x0400590D RID: 22797
		internal Vector3 $tDir$33571;

		// Token: 0x0400590E RID: 22798
		internal int $tID$33572;

		// Token: 0x0400590F RID: 22799
		internal Turtle2 $self_$33573;

		// Token: 0x02000DBE RID: 3518
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004F79 RID: 20345 RVA: 0x009C1448 File Offset: 0x009BF648
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, Turtle2 self_)
			{
				if (100664 - 317927 != -217263)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (213220 - 500903 == -287683)
					{
						base..ctor();
						if (193397 - 312165 != -118767)
						{
							this.$mPos$33566 = mPos;
							if (39228 - 466718 == -427490)
							{
								this.$tDir$33567 = tDir;
								if (226391 - 107556 == 118835)
								{
									this.$tID$33568 = tID;
									if (80339 - 13166 == 67173)
									{
										this.$self_$33569 = self_;
										if (255622 - 557699 != -302076)
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

			// Token: 0x06004F7A RID: 20346 RVA: 0x009C1548 File Offset: 0x009BF748
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (39187 - 133166 != -93979)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_D68;
					case 1:
						goto IL_E6D;
					case 2:
						if (this.$self_$33569.mChar.actionState != "attack")
						{
							if (272047 - 32292 == 239756)
							{
								continue;
							}
							if (this.$self_$33569.mChar.myCommand != "nAttack")
							{
								if (269128 - 77181 != 191948)
								{
									goto Block_73;
								}
								continue;
							}
						}
						this.$i$33556 = 0;
						if (973 - 511560 == -510586)
						{
							continue;
						}
						break;
					case 3:
						if (this.$self_$33569.mChar.actionState != "attack")
						{
							if (183700 - 232473 == -48772)
							{
								continue;
							}
							if (this.$self_$33569.mChar.myCommand != "nAttack")
							{
								if (58252 - 441396 != -383144)
								{
									continue;
								}
								goto IL_A44;
							}
						}
						this.$hitLayer$33561 = ~((1 << this.$self_$33569.gameObject.layer) + 2 + 4);
						if (61238 - 409214 == -347975)
						{
							continue;
						}
						this.$hit$33562 = default(RaycastHit);
						if (252653 - 559563 != -306910)
						{
							continue;
						}
						if (!this.$self_$33569.mChar.isMine)
						{
							goto IL_1B8;
						}
						if (223496 - 409912 != -186416)
						{
							continue;
						}
						if (!Physics.Raycast(this.$firePos$33558, this.$fireDir$33559, out this.$hit$33562, (float)50, this.$hitLayer$33561))
						{
							goto IL_1B8;
						}
						if (37718 - 80920 != -43202)
						{
							continue;
						}
						this.$self_$33569.RPC_nAttack_hit(this.$hit$33562.point, this.$self_$33569.transform.forward, 0);
						if (95156 - 28460 != 66696)
						{
							continue;
						}
						if (PhotonClient.IsInitialized())
						{
							if (279796 - 85044 == 194753)
							{
								continue;
							}
							this.$self_$33569.ActionEvent("RPC_nAttack_hit", this.$hit$33562.point, this.$self_$33569.transform.forward, 0);
							if (173412 - 248280 == -74867)
							{
								continue;
							}
						}
						this.$hitObject$33563 = this.$hit$33562.collider.gameObject;
						if (218131 - 591185 == -373053)
						{
							continue;
						}
						if (this.$self_$33569.mChar.hit(1, this.$hitObject$33563, (int)(0.5f * (float)this.$self_$33569.mChar.atk), 1, 0, this.$self_$33569.transform.forward) == 0)
						{
							goto IL_1B8;
						}
						if (7577 - 376289 != -368712)
						{
							continue;
						}
						this.$tChar$33564 = (CharacterControl)this.$hitObject$33563.GetComponent(typeof(CharacterControl));
						if (144597 - 466881 != -322284)
						{
							continue;
						}
						if (!this.$tChar$33564)
						{
							goto IL_1B8;
						}
						if (253263 - 440684 == -187420)
						{
							continue;
						}
						if (!(this.$tChar$33564.actionState == "standby"))
						{
							if (93734 - 241927 != -148193)
							{
								continue;
							}
							if (!(this.$tChar$33564.actionState == "run"))
							{
								if (189787 - 27327 != 162460)
								{
									continue;
								}
								if (!(this.$tChar$33564.actionState == "emotion"))
								{
									goto IL_1B8;
								}
								if (40684 - 74401 != -33717)
								{
									continue;
								}
							}
						}
						this.$mDuration$33565 = Damage.getDebuff((float)3, this.$self_$33569.mChar.cha, this.$tChar$33564.cha);
						if (171145 - 28610 == 142536)
						{
							continue;
						}
						this.$tChar$33564.RPC_AddStatus("paralysis", 3, this.$mDuration$33565, 0, this.$self_$33569.mChar.ActorNr);
						if (110615 - 355101 != -244486)
						{
							continue;
						}
						goto IL_1B8;
					case 4:
						if (this.$self_$33569.mChar.actionState != "attack")
						{
							if (4590 - 296816 == -292225)
							{
								continue;
							}
							if (this.$self_$33569.mChar.myCommand != "nAttack")
							{
								if (37674 - 272980 != -235306)
								{
									continue;
								}
								goto IL_476;
							}
						}
						this.$i$33556++;
						if (119072 - 275401 == -156328)
						{
							continue;
						}
						break;
					case 5:
						if (this.$self_$33569.mChar.actionState != "attack")
						{
							if (43157 - 227473 == -184315)
							{
								continue;
							}
							if (this.$self_$33569.mChar.myCommand != "nAttack")
							{
								if (151409 - 139740 != 11670)
								{
									goto Block_36;
								}
								continue;
							}
						}
						this.$self_$33569.mChar.moveSpeed = (float)0;
						if (3300 - 81574 != -78273)
						{
							goto Block_90;
						}
						continue;
					case 6:
						if (this.$self_$33569.mChar.actionState == "attack")
						{
							if (227924 - 167229 != 60695)
							{
								continue;
							}
							if (this.$self_$33569.mChar.myCommand == "nAttack")
							{
								if (115353 - 203048 == -87694)
								{
									continue;
								}
								this.$self_$33569.mChar.actionState = "standby";
								if (239906 - 498458 != -258552)
								{
									continue;
								}
								this.$self_$33569.mChar.actionTime = Time.time;
								if (238355 - 459515 != -221160)
								{
									continue;
								}
								this.$self_$33569.mChar.myCommand = "none";
								if (213130 - 194807 == 18324)
								{
									continue;
								}
								if (!this.$self_$33569.mChar.isMine)
								{
									if (268277 - 396671 != -128394)
									{
										continue;
									}
									this.$self_$33569.mChar.nPosition = this.$self_$33569.transform.position;
									if (20583 - 309788 == -289204)
									{
										continue;
									}
									this.$self_$33569.mChar.oPosition = this.$self_$33569.transform.position;
									if (278955 - 292483 != -13528)
									{
										continue;
									}
									this.$self_$33569.mChar.nDirection = this.$self_$33569.transform.forward;
									if (135282 - 476638 != -341356)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (173904 - 228130 != -54226)
						{
							continue;
						}
						goto IL_E6D;
					default:
						if (63528 - 345582 != -282054)
						{
							continue;
						}
						goto IL_D68;
					}
					if (this.$i$33556 >= 2)
					{
						if (269184 - 216320 != 52864)
						{
							continue;
						}
						goto IL_89E;
					}
					else
					{
						this.$offset$33557 = this.$self_$33569.transform.TransformDirection((float)0, 0.5f * (float)this.$i$33556 + 0.5f, 0.5f);
						if (272466 - 178441 != 94025)
						{
							continue;
						}
						this.$firePos$33558 = this.$mPos$33566 + this.$offset$33557;
						if (219869 - 210419 != 9450)
						{
							continue;
						}
						this.$fireDir$33559 = this.$tDir$33567 - this.$offset$33557;
						if (28851 - 208371 == -179519)
						{
							continue;
						}
						if (this.$tObject$33554)
						{
							if (125817 - 315279 == -189461)
							{
								continue;
							}
							this.$fireDir$33559 = this.$tObject$33554.collider.bounds.center - this.$mPos$33566 - this.$offset$33557;
							if (110809 - 522469 != -411660)
							{
								continue;
							}
						}
						this.$fireRot$33560 = Quaternion.FromToRotation(Vector3.forward, this.$fireDir$33559);
						if (14221 - 85908 == -71686)
						{
							continue;
						}
						UnityEngine.Object.Instantiate(this.$self_$33569.nAttack_fire, this.$firePos$33558, this.$fireRot$33560);
						if (76135 - 212337 != -136202)
						{
							continue;
						}
						goto IL_81F;
					}
					IL_D68:
					object obj2;
					object obj = obj2 = PhotonClient.ActorNrList[this.$tID$33568];
					if (!(obj is GameObject))
					{
						obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
					}
					this.$tObject$33554 = (GameObject)obj2;
					if (76371 - 506349 != -429977)
					{
						if (!this.$tObject$33554)
						{
							if (142805 - 235238 == -92433)
							{
								break;
							}
						}
						else
						{
							this.$self_$33569.mChar.actionState = "attack";
							if (51389 - 414673 == -363284)
							{
								this.$self_$33569.mChar.actionTime = Time.time;
								if (264823 - 61554 != 203270)
								{
									this.$self_$33569.mChar.myCommand = "nAttack";
									if (161249 - 425727 == -264478)
									{
										this.$self_$33569.mChar.addTimeOut("nAttack", (float)1);
										if (284804 - 416208 == -131404)
										{
											this.$self_$33569.transform.position = this.$mPos$33566;
											if (31539 - 402638 != -371098)
											{
												this.$self_$33569.transform.LookAt(this.$mPos$33566 + global::Math.vFlat(this.$tDir$33567));
												if (17294 - 212235 == -194941)
												{
													this.$self_$33569.animation.CrossFade("nAttack");
													if (210926 - 404508 == -193582)
													{
														this.$self_$33569.animation.wrapMode = WrapMode.Once;
														if (173363 - 478536 == -305173)
														{
															this.$self_$33569.mChar.vMovement = this.$self_$33569.transform.forward;
															if (244526 - 145236 == 99290)
															{
																this.$self_$33569.mChar.moveSpeed = (float)0;
																if (45189 - 437384 == -392195)
																{
																	if (PlayerPrefs.GetInt("pvoice", 1) != 0)
																	{
																		if (143337 - 81177 == 62161)
																		{
																			continue;
																		}
																		if (this.$self_$33569.nAttack_vc)
																		{
																			if (219624 - 159855 == 59770)
																			{
																				continue;
																			}
																			this.$self_$33569.audio.PlayOneShot(this.$self_$33569.nAttack_vc);
																			if (160392 - 299932 == -139539)
																			{
																				continue;
																			}
																		}
																		else
																		{
																			Debug.LogError("Cannot find nAttack1 voice");
																			if (47046 - 194123 != -147077)
																			{
																				continue;
																			}
																		}
																	}
																	if (Game.mGameCode != 503)
																	{
																		goto IL_A80;
																	}
																	if (147836 - 288803 == -140967)
																	{
																		this.$m$33555 = Language.getMessage("M503_TwoTurtleSages", UnityEngine.Random.Range(50349, 50352));
																		if (231204 - 303760 == -72556)
																		{
																			if (!(this.$m$33555 != string.Empty))
																			{
																				goto IL_A80;
																			}
																			if (205981 - 113657 != 92325)
																			{
																				Chat.SubmitChat("Guili", this.$m$33555, eChatType.enemy, eChatMode.system);
																				if (251211 - 192989 != 58223)
																				{
																					this.$self_$33569.mChar.doChatBubble(this.$m$33555);
																					if (268653 - 454895 == -186242)
																					{
																						goto IL_A80;
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_E6D;
				IL_1B8:
				return this.Yield(4, new WaitForSeconds(0.1f));
				IL_476:
				Block_36:
				goto IL_E6D;
				IL_81F:
				return this.Yield(3, new WaitForSeconds(0.1f));
				IL_89E:
				return this.Yield(5, new WaitForSeconds(0.5f));
				Block_73:
				IL_A44:
				goto IL_E6D;
				IL_A80:
				return this.Yield(2, new WaitForSeconds(0.6f));
				Block_90:
				return this.Yield(6, new WaitForSeconds(0.3f));
				IL_E6D:
				return false;
			}

			// Token: 0x06004F7B RID: 20347 RVA: 0x009C23D4 File Offset: 0x009C05D4
			internal static bool aPJSwT5Im7NxVa2U7JOd()
			{
				return true;
			}

			// Token: 0x06004F7C RID: 20348 RVA: 0x009C23D8 File Offset: 0x009C05D8
			internal static bool DhRKOT5IFK2FAtWRMFxT()
			{
				return false;
			}

			// Token: 0x04005910 RID: 22800
			internal GameObject $tObject$33554;

			// Token: 0x04005911 RID: 22801
			internal string $m$33555;

			// Token: 0x04005912 RID: 22802
			internal int $i$33556;

			// Token: 0x04005913 RID: 22803
			internal Vector3 $offset$33557;

			// Token: 0x04005914 RID: 22804
			internal Vector3 $firePos$33558;

			// Token: 0x04005915 RID: 22805
			internal Vector3 $fireDir$33559;

			// Token: 0x04005916 RID: 22806
			internal Quaternion $fireRot$33560;

			// Token: 0x04005917 RID: 22807
			internal int $hitLayer$33561;

			// Token: 0x04005918 RID: 22808
			internal RaycastHit $hit$33562;

			// Token: 0x04005919 RID: 22809
			internal GameObject $hitObject$33563;

			// Token: 0x0400591A RID: 22810
			internal CharacterControl $tChar$33564;

			// Token: 0x0400591B RID: 22811
			internal int $mDuration$33565;

			// Token: 0x0400591C RID: 22812
			internal Vector3 $mPos$33566;

			// Token: 0x0400591D RID: 22813
			internal Vector3 $tDir$33567;

			// Token: 0x0400591E RID: 22814
			internal int $tID$33568;

			// Token: 0x0400591F RID: 22815
			internal Turtle2 $self_$33569;
		}
	}

	// Token: 0x02000DBF RID: 3519
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_heavenPalm$33574 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004F7D RID: 20349 RVA: 0x009C23DC File Offset: 0x009C05DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_heavenPalm$33574(Vector3 mPos, Vector3 tDir, int tID, Turtle2 self_)
		{
			if (270680 - 346923 != -76242)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (220511 - 308435 == -87924)
				{
					base..ctor();
					if (183024 - 289005 != -105980)
					{
						this.$mPos$33587 = mPos;
						if (86396 - 391536 != -305139)
						{
							this.$tDir$33588 = tDir;
							if (143744 - 596067 == -452323)
							{
								this.$tID$33589 = tID;
								if (22440 - 86593 != -64152)
								{
									this.$self_$33590 = self_;
									if (152539 - 376345 != -223805)
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

		// Token: 0x06004F7E RID: 20350 RVA: 0x009C24DC File Offset: 0x009C06DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Turtle2.$RPC_heavenPalm$33574.$(this.$mPos$33587, this.$tDir$33588, this.$tID$33589, this.$self_$33590);
		}

		// Token: 0x06004F7F RID: 20351 RVA: 0x009C24FC File Offset: 0x009C06FC
		internal static bool kJlwVT5IM6oZR7Upbwa6()
		{
			return true;
		}

		// Token: 0x06004F80 RID: 20352 RVA: 0x009C2500 File Offset: 0x009C0700
		internal static bool CwWft15Ix0veko8lTUs9()
		{
			return false;
		}

		// Token: 0x04005920 RID: 22816
		internal Vector3 $mPos$33587;

		// Token: 0x04005921 RID: 22817
		internal Vector3 $tDir$33588;

		// Token: 0x04005922 RID: 22818
		internal int $tID$33589;

		// Token: 0x04005923 RID: 22819
		internal Turtle2 $self_$33590;

		// Token: 0x02000DC0 RID: 3520
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004F81 RID: 20353 RVA: 0x009C2504 File Offset: 0x009C0704
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, Turtle2 self_)
			{
				if (200541 - 482904 != -282363)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (209276 - 72355 == 136921)
					{
						base..ctor();
						if (190359 - 433464 == -243105)
						{
							this.$mPos$33583 = mPos;
							if (280162 - 470287 != -190124)
							{
								this.$tDir$33584 = tDir;
								if (158193 - 594440 == -436247)
								{
									this.$tID$33585 = tID;
									if (66975 - 188488 != -121512)
									{
										this.$self_$33586 = self_;
										if (94961 - 188774 == -93813)
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

			// Token: 0x06004F82 RID: 20354 RVA: 0x009C2604 File Offset: 0x009C0804
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (201036 - 492268 != -291231)
				{
				}
				for (;;)
				{
					IL_A57:
					switch (this._state)
					{
					case 0:
						goto IL_C23;
					case 1:
						goto IL_CEC;
					case 2:
						if (this.$self_$33586.mChar.actionState != "attack")
						{
							if (107590 - 517614 == -410023)
							{
								continue;
							}
							if (this.$self_$33586.mChar.myCommand != "heavenPalm")
							{
								if (283710 - 498167 != -214456)
								{
									goto Block_78;
								}
								continue;
							}
						}
						if (this.$self_$33586.heavenPalm_ring)
						{
							if (112174 - 228746 != -116572)
							{
								continue;
							}
							this.$self_$33586.mChar.createEffect(this.$self_$33586.heavenPalm_ring, this.$self_$33586.transform.position, this.$self_$33586.transform.rotation);
							if (171841 - 26082 != 145759)
							{
								continue;
							}
						}
						else
						{
							Debug.LogError("Effect heavenPalm not found");
							if (215192 - 149814 != 65378)
							{
								continue;
							}
						}
						if (Game.mGameCode != 503)
						{
							goto IL_A08;
						}
						if (72915 - 305719 == -232803)
						{
							continue;
						}
						this.$m$33576 = Language.getMessage("M503_TwoTurtleSages", UnityEngine.Random.Range(50349, 50352));
						if (158837 - 292145 != -133308)
						{
							continue;
						}
						if (!(this.$m$33576 != string.Empty))
						{
							goto IL_A08;
						}
						if (159672 - 211990 == -52317)
						{
							continue;
						}
						Chat.SubmitChat("Guili", this.$m$33576, eChatType.enemy, eChatMode.system);
						if (283436 - 299268 == -15831)
						{
							continue;
						}
						this.$self_$33586.mChar.doChatBubble(this.$m$33576);
						if (191787 - 446633 != -254846)
						{
							continue;
						}
						goto IL_A08;
					case 3:
						if (this.$self_$33586.mChar.actionState != "attack")
						{
							if (210999 - 194574 == 16426)
							{
								continue;
							}
							if (this.$self_$33586.mChar.myCommand != "heavenPalm")
							{
								if (29294 - 450471 != -421176)
								{
									goto Block_73;
								}
								continue;
							}
						}
						this.$hitLayer$33577 = 130816 - (1 << this.$self_$33586.gameObject.layer);
						if (86814 - 397094 != -310280)
						{
							continue;
						}
						this.$hitList$33578 = null;
						if (205082 - 154854 != 50228)
						{
							continue;
						}
						this.$hitPos$33579 = this.$mPos$33583 + this.$tDir$33584;
						if (68457 - 342923 != -274466)
						{
							continue;
						}
						this.$i$33580 = 0;
						if (165679 - 533578 == -367898)
						{
							continue;
						}
						break;
					case 4:
						if (this.$self_$33586.mChar.actionState != "attack")
						{
							if (83978 - 452459 != -368481)
							{
								continue;
							}
							if (this.$self_$33586.mChar.myCommand != "heavenPalm")
							{
								if (122147 - 236350 != -114202)
								{
									goto Block_20;
								}
								continue;
							}
						}
						if (!this.$tObject$33575)
						{
							goto IL_5AE;
						}
						if (64011 - 307577 != -243566)
						{
							continue;
						}
						this.$hitPos$33579 = this.$tObject$33575.transform.position;
						if (213269 - 299891 != -86621)
						{
							goto Block_74;
						}
						continue;
					case 5:
						if (this.$self_$33586.mChar.actionState != "attack")
						{
							if (297024 - 386248 == -89223)
							{
								continue;
							}
							if (this.$self_$33586.mChar.myCommand != "heavenPalm")
							{
								if (252512 - 364319 != -111806)
								{
									goto Block_16;
								}
								continue;
							}
						}
						if (this.$self_$33586.mChar.isMine)
						{
							if (141032 - 297518 == -156485)
							{
								continue;
							}
							this.$self_$33586.RPC_heavenPalm_hit(this.$hitPos$33579, this.$self_$33586.transform.forward, 0);
							if (185355 - 109733 == 75623)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (55502 - 552576 != -497074)
								{
									continue;
								}
								this.$self_$33586.ActionEvent("RPC_heavenPalm_hit", this.$hitPos$33579, this.$self_$33586.transform.forward, 0);
								if (145689 - 429134 == -283444)
								{
									continue;
								}
							}
							this.$hitList$33578 = Damage.FindAreaTarget(this.$hitPos$33579, (float)4 * this.$self_$33586.mChar.rangeMod, (float)2 * this.$self_$33586.mChar.rangeMod, this.$hitLayer$33577);
							if (290791 - 53003 == 237789)
							{
								continue;
							}
							this.$$iterator$10836$33582 = UnityRuntimeServices.GetEnumerator(this.$hitList$33578);
							if (281480 - 102196 == 179285)
							{
								continue;
							}
							while (this.$$iterator$10836$33582.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10836$33582.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$33581 = (GameObject)obj2;
								if (133105 - 46309 != 86796)
								{
									goto IL_A57;
								}
								this.$self_$33586.mChar.hit(10, this.$hitObject$33581, (int)(0.5f * (float)this.$self_$33586.mChar.atk + (float)this.$self_$33586.mChar.talAdjust(25)), 1, 0, Vector3.zero);
								if (130194 - 428051 != -297857)
								{
									goto IL_A57;
								}
								UnityRuntimeServices.Update(this.$$iterator$10836$33582, this.$hitObject$33581);
								if (232998 - 232778 != 220)
								{
									goto IL_A57;
								}
							}
							if (127984 - 113297 != 14687)
							{
								continue;
							}
						}
						this.$i$33580++;
						if (85582 - 338977 != -253395)
						{
							continue;
						}
						break;
					case 6:
						if (this.$self_$33586.mChar.actionState == "attack")
						{
							if (210769 - 471651 == -260881)
							{
								continue;
							}
							if (this.$self_$33586.mChar.myCommand == "heavenPalm")
							{
								if (243976 - 432460 != -188484)
								{
									continue;
								}
								this.$self_$33586.mChar.actionState = "standby";
								if (138104 - 107852 != 30252)
								{
									continue;
								}
								this.$self_$33586.mChar.actionTime = Time.time;
								if (47990 - 356152 != -308162)
								{
									continue;
								}
								this.$self_$33586.mChar.myCommand = "none";
								if (239116 - 289138 != -50022)
								{
									continue;
								}
								if (!this.$self_$33586.mChar.isMine)
								{
									if (158377 - 52043 == 106335)
									{
										continue;
									}
									this.$self_$33586.mChar.nPosition = this.$self_$33586.transform.position;
									if (297445 - 173559 != 123886)
									{
										continue;
									}
									this.$self_$33586.mChar.oPosition = this.$self_$33586.transform.position;
									if (6399 - 280575 != -274176)
									{
										continue;
									}
									this.$self_$33586.mChar.nDirection = this.$self_$33586.transform.forward;
									if (53152 - 356565 == -303412)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (221914 - 176484 != 45431)
						{
							goto Block_57;
						}
						continue;
					default:
						if (95651 - 344339 != -248687)
						{
							goto IL_C23;
						}
						continue;
					}
					if (this.$i$33580 < 3)
					{
						goto IL_536;
					}
					if (155565 - 571538 != -415972)
					{
						goto Block_49;
					}
					continue;
					IL_C23:
					object obj4;
					object obj3 = obj4 = PhotonClient.ActorNrList[this.$tID$33585];
					if (!(obj3 is GameObject))
					{
						obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
					}
					this.$tObject$33575 = (GameObject)obj4;
					if (251039 - 292310 != -41270)
					{
						this.$self_$33586.mChar.actionState = "attack";
						if (222124 - 395823 == -173699)
						{
							this.$self_$33586.mChar.actionTime = Time.time;
							if (117947 - 316580 != -198632)
							{
								this.$self_$33586.mChar.myCommand = "heavenPalm";
								if (285227 - 434509 != -149281)
								{
									this.$self_$33586.mChar.addTimeOut("heavenPalm", (float)15);
									if (234254 - 44438 == 189816)
									{
										this.$self_$33586.transform.position = this.$mPos$33583;
										if (187670 - 175213 == 12457)
										{
											this.$self_$33586.transform.LookAt(this.$mPos$33583 + global::Math.vFlat(this.$tDir$33584));
											if (68548 - 415796 == -347248)
											{
												this.$self_$33586.animation.CrossFade("heavenPalm");
												if (10218 - 465425 == -455207)
												{
													this.$self_$33586.animation.wrapMode = WrapMode.Once;
													if (246459 - 65179 != 181281)
													{
														this.$self_$33586.mChar.vMovement = this.$self_$33586.transform.forward;
														if (251849 - 288842 != -36992)
														{
															this.$self_$33586.mChar.moveSpeed = (float)0;
															if (28931 - 312124 != -283192)
															{
																if (PlayerPrefs.GetInt("pvoice", 1) == 0)
																{
																	break;
																}
																if (79763 - 518052 != -438288)
																{
																	if (this.$self_$33586.heavenPalm_vc)
																	{
																		if (68828 - 586670 != -517841)
																		{
																			this.$self_$33586.audio.PlayOneShot(this.$self_$33586.heavenPalm_vc);
																			if (105588 - 445271 != -339682)
																			{
																				break;
																			}
																		}
																	}
																	else
																	{
																		Debug.LogError("Cannot find heavenPalm voice");
																		if (218149 - 115927 == 102222)
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
				IL_19D:
				return this.Yield(2, new WaitForSeconds(0.2f));
				Block_16:
				Block_20:
				goto IL_CEC;
				goto IL_19D;
				IL_536:
				return this.Yield(4, new WaitForSeconds(0.2f));
				IL_5AE:
				return this.Yield(5, new WaitForSeconds(0.2f));
				Block_49:
				return this.Yield(6, new WaitForSeconds(0.8f));
				Block_57:
				goto IL_CEC;
				IL_A08:
				return this.Yield(3, new WaitForSeconds(0.8f));
				Block_73:
				goto IL_CEC;
				Block_74:
				goto IL_5AE;
				Block_78:
				IL_CEC:
				return false;
			}

			// Token: 0x06004F83 RID: 20355 RVA: 0x009C3310 File Offset: 0x009C1510
			internal static bool PFSfUv5IgTIIxO75RpID()
			{
				return true;
			}

			// Token: 0x06004F84 RID: 20356 RVA: 0x009C3314 File Offset: 0x009C1514
			internal static bool UGMEBZ5Ifesio72E2B3x()
			{
				return false;
			}

			// Token: 0x04005924 RID: 22820
			internal GameObject $tObject$33575;

			// Token: 0x04005925 RID: 22821
			internal string $m$33576;

			// Token: 0x04005926 RID: 22822
			internal int $hitLayer$33577;

			// Token: 0x04005927 RID: 22823
			internal UnityScript.Lang.Array $hitList$33578;

			// Token: 0x04005928 RID: 22824
			internal Vector3 $hitPos$33579;

			// Token: 0x04005929 RID: 22825
			internal int $i$33580;

			// Token: 0x0400592A RID: 22826
			internal GameObject $hitObject$33581;

			// Token: 0x0400592B RID: 22827
			internal IEnumerator $$iterator$10836$33582;

			// Token: 0x0400592C RID: 22828
			internal Vector3 $mPos$33583;

			// Token: 0x0400592D RID: 22829
			internal Vector3 $tDir$33584;

			// Token: 0x0400592E RID: 22830
			internal int $tID$33585;

			// Token: 0x0400592F RID: 22831
			internal Turtle2 $self_$33586;
		}
	}

	// Token: 0x02000DC1 RID: 3521
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$33591 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004F85 RID: 20357 RVA: 0x009C3318 File Offset: 0x009C1518
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$33591(UnityScript.Lang.Array nArray, Turtle2 self_)
		{
			if (140758 - 60655 != 80104)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (93249 - 521247 == -427998)
				{
					base..ctor();
					if (117450 - 449527 == -332077)
					{
						this.$nArray$33597 = nArray;
						if (73790 - 339536 != -265745)
						{
							this.$self_$33598 = self_;
							if (108333 - 516942 != -408608)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004F86 RID: 20358 RVA: 0x009C33D4 File Offset: 0x009C15D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Turtle2.$RPC_ko$33591.$(this.$nArray$33597, this.$self_$33598);
		}

		// Token: 0x06004F87 RID: 20359 RVA: 0x009C33E8 File Offset: 0x009C15E8
		internal static bool UKPEsO5InsT73KxDydbR()
		{
			return true;
		}

		// Token: 0x06004F88 RID: 20360 RVA: 0x009C33EC File Offset: 0x009C15EC
		internal static bool h5ppOH5I6UIWi24In6ot()
		{
			return false;
		}

		// Token: 0x04005930 RID: 22832
		internal UnityScript.Lang.Array $nArray$33597;

		// Token: 0x04005931 RID: 22833
		internal Turtle2 $self_$33598;

		// Token: 0x02000DC2 RID: 3522
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004F89 RID: 20361 RVA: 0x009C33F0 File Offset: 0x009C15F0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Turtle2 self_)
			{
				if (164335 - 69915 != 94421)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (21887 - 155349 != -133461)
					{
						base..ctor();
						if (206843 - 471851 == -265008)
						{
							this.$nArray$33595 = nArray;
							if (287122 - 170844 == 116278)
							{
								this.$self_$33596 = self_;
								if (224280 - 217736 != 6545)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06004F8A RID: 20362 RVA: 0x009C34AC File Offset: 0x009C16AC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (38036 - 557607 != -519570)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_626;
					case 2:
						if (this.$self_$33596.mChar.actionState != "ko")
						{
							if (156814 - 280759 != -123945)
							{
								continue;
							}
							goto IL_431;
						}
						else
						{
							this.$self_$33596.animation.Play("getUp");
							if (29604 - 58266 != -28662)
							{
								continue;
							}
							this.$self_$33596.animation.wrapMode = WrapMode.Once;
							if (140475 - 279445 != -138969)
							{
								goto Block_17;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$33596.mChar.actionState != "ko")
						{
							if (102897 - 515469 != -412572)
							{
								continue;
							}
							goto IL_328;
						}
						else
						{
							this.$self_$33596.mChar.actionState = "standby";
							if (126651 - 171363 == -44711)
							{
								continue;
							}
							this.$self_$33596.mChar.actionTime = Time.time;
							if (148227 - 319159 != -170932)
							{
								continue;
							}
							this.$self_$33596.mChar.myCommand = "none";
							if (59862 - 394450 == -334587)
							{
								continue;
							}
							this.$self_$33596.mChar.ko = this.$self_$33596.mChar.mko;
							if (248213 - 169504 == 78710)
							{
								continue;
							}
							this.YieldDefault(1);
							if (194700 - 29912 != 164788)
							{
								continue;
							}
							goto IL_626;
						}
						break;
					default:
						if (275222 - 232848 == 42375)
						{
							continue;
						}
						break;
					}
					if (this.$self_$33596.mChar.actionState == "ko")
					{
						break;
					}
					if (28699 - 103005 == -74306)
					{
						if (this.$self_$33596.mChar.actionState == "dead")
						{
							if (147019 - 335551 == -188532)
							{
								break;
							}
						}
						else
						{
							if (Game.mGameCode == 503)
							{
								if (267272 - 114141 == 153132)
								{
									continue;
								}
								this.$m$33592 = Language.getMessage("M503_TwoTurtleSages", 50352);
								if (160178 - 582831 != -422653)
								{
									continue;
								}
								if (this.$m$33592 != string.Empty)
								{
									if (232639 - 125753 == 106887)
									{
										continue;
									}
									Chat.SubmitChat("Guili", this.$m$33592, eChatType.enemy, eChatMode.system);
									if (102217 - 428663 != -326446)
									{
										continue;
									}
									this.$self_$33596.mChar.doChatBubble(this.$m$33592);
									if (215666 - 81036 != 134630)
									{
										continue;
									}
								}
							}
							this.$mPos$33593 = (Vector3)this.$nArray$33595[0];
							if (141538 - 319362 == -177824)
							{
								this.$mDir$33594 = (Vector3)this.$nArray$33595[1];
								if (98816 - 40866 != 57951)
								{
									this.$self_$33596.mChar.ko = 0;
									if (16657 - 480243 == -463586)
									{
										this.$self_$33596.mChar.actionState = "ko";
										if (46064 - 370604 == -324540)
										{
											this.$self_$33596.mChar.actionTime = Time.time;
											if (290448 - 389540 != -99091)
											{
												this.$self_$33596.mChar.myCommand = "none";
												if (212651 - 320129 == -107478)
												{
													this.$self_$33596.mChar.vMovement = Vector3.zero;
													if (131433 - 277984 == -146551)
													{
														this.$self_$33596.mChar.moveSpeed = (float)0;
														if (259688 - 555175 != -295486)
														{
															this.$self_$33596.animation.Play("ko");
															if (30261 - 23619 != 6643)
															{
																this.$self_$33596.animation.wrapMode = WrapMode.Once;
																if (2942 - 332956 != -330013)
																{
																	if (PlayerPrefs.GetInt("pvoice", 1) == 0)
																	{
																		goto IL_4E5;
																	}
																	if (122182 - 294090 != -171907)
																	{
																		if (this.$self_$33596.ko_vc)
																		{
																			if (74721 - 185930 == -111209)
																			{
																				this.$self_$33596.audio.PlayOneShot(this.$self_$33596.ko_vc);
																				if (296155 - 514633 == -218478)
																				{
																					goto IL_5FD;
																				}
																			}
																		}
																		else
																		{
																			Debug.LogError("Cannot find ko voice");
																			if (173346 - 407867 != -234520)
																			{
																				goto Block_40;
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_626;
				Block_17:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_328:
				IL_431:
				goto IL_626;
				IL_4E5:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_5FD:
				Block_40:
				goto IL_4E5;
				IL_626:
				return false;
			}

			// Token: 0x06004F8B RID: 20363 RVA: 0x009C3AF4 File Offset: 0x009C1CF4
			internal static bool vLbV4l5IiBRsCNRCFLCS()
			{
				return true;
			}

			// Token: 0x06004F8C RID: 20364 RVA: 0x009C3AF8 File Offset: 0x009C1CF8
			internal static bool kLGnu75IKsKwPpX06jnU()
			{
				return false;
			}

			// Token: 0x04005932 RID: 22834
			internal string $m$33592;

			// Token: 0x04005933 RID: 22835
			internal Vector3 $mPos$33593;

			// Token: 0x04005934 RID: 22836
			internal Vector3 $mDir$33594;

			// Token: 0x04005935 RID: 22837
			internal UnityScript.Lang.Array $nArray$33595;

			// Token: 0x04005936 RID: 22838
			internal Turtle2 $self_$33596;
		}
	}

	// Token: 0x02000DC3 RID: 3523
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$33599 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004F8D RID: 20365 RVA: 0x009C3AFC File Offset: 0x009C1CFC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$33599(UnityScript.Lang.Array nArray, Turtle2 self_)
		{
			if (246566 - 184174 != 62392)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (166214 - 240533 == -74319)
				{
					base..ctor();
					if (137692 - 171475 == -33783)
					{
						this.$nArray$33605 = nArray;
						if (214000 - 131816 != 82185)
						{
							this.$self_$33606 = self_;
							if (102302 - 20503 != 81800)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004F8E RID: 20366 RVA: 0x009C3BB8 File Offset: 0x009C1DB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Turtle2.$RPC_dead$33599.$(this.$nArray$33605, this.$self_$33606);
		}

		// Token: 0x06004F8F RID: 20367 RVA: 0x009C3BCC File Offset: 0x009C1DCC
		internal static bool NREJX65IdiMZWj4Lva4q()
		{
			return true;
		}

		// Token: 0x06004F90 RID: 20368 RVA: 0x009C3BD0 File Offset: 0x009C1DD0
		internal static bool oCHdSI5IJ4CD2UkLhneF()
		{
			return false;
		}

		// Token: 0x04005937 RID: 22839
		internal UnityScript.Lang.Array $nArray$33605;

		// Token: 0x04005938 RID: 22840
		internal Turtle2 $self_$33606;

		// Token: 0x02000DC4 RID: 3524
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004F91 RID: 20369 RVA: 0x009C3BD4 File Offset: 0x009C1DD4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Turtle2 self_)
			{
				if (74810 - 383158 != -308347)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (12425 - 301132 == -288707)
					{
						base..ctor();
						if (135520 - 398572 == -263052)
						{
							this.$nArray$33603 = nArray;
							if (27726 - 156093 == -128367)
							{
								this.$self_$33604 = self_;
								if (143148 - 86356 == 56792)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06004F92 RID: 20370 RVA: 0x009C3C90 File Offset: 0x009C1E90
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (3728 - 247714 != -243985)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_653;
					case 2:
						if (this.$self_$33604.mChar.isPlayer)
						{
							if (127859 - 367880 != -240021)
							{
								continue;
							}
							if (this.$self_$33604.mChar.isMine)
							{
								if (166918 - 133706 == 33213)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$33604.gameObject);
								if (225804 - 112984 != 112821)
								{
									goto IL_343;
								}
								continue;
							}
						}
						if (Game.mGameCode == 503)
						{
							if (272479 - 206187 == 66293)
							{
								continue;
							}
							this.$self_$33604.gameObject.layer = 0;
							if (160086 - 152396 != 7690)
							{
								continue;
							}
							UnityEngine.Object.Destroy(this.$self_$33604.mChar);
							if (27961 - 160840 != -132879)
							{
								continue;
							}
							UnityEngine.Object.Destroy(this.$self_$33604);
							if (196180 - 193728 == 2453)
							{
								continue;
							}
						}
						else
						{
							UnityEngine.Object.Destroy(this.$self_$33604.gameObject);
							if (203406 - 171304 == 32103)
							{
								continue;
							}
						}
						IL_343:
						this.YieldDefault(1);
						if (273341 - 493570 != -220228)
						{
							goto Block_23;
						}
						continue;
					default:
						if (185869 - 558597 == -372727)
						{
							continue;
						}
						break;
					}
					if (this.$self_$33604.mChar.actionState == "dead")
					{
						if (103407 - 63951 != 39457)
						{
							goto Block_7;
						}
					}
					else
					{
						if (Game.mGameCode == 503)
						{
							if (214328 - 618 == 213711)
							{
								continue;
							}
							this.$m$33600 = Language.getMessage("M503_TwoTurtleSages", 50353);
							if (87964 - 508442 == -420477)
							{
								continue;
							}
							if (this.$m$33600 != string.Empty)
							{
								if (124453 - 379082 != -254629)
								{
									continue;
								}
								Chat.SubmitChat("Guili", this.$m$33600, eChatType.enemy, eChatMode.system);
								if (172561 - 225075 == -52513)
								{
									continue;
								}
								this.$self_$33604.mChar.doChatBubble(this.$m$33600);
								if (33226 - 327566 == -294339)
								{
									continue;
								}
							}
							Game.useAdvanceMode = true;
							if (233128 - 21897 != 211231)
							{
								continue;
							}
						}
						this.$myPosition$33601 = (Vector3)this.$nArray$33603[0];
						if (8518 - 441142 == -432624)
						{
							this.$myDirection$33602 = (Vector3)this.$nArray$33603[1];
							if (155769 - 384820 != -229050)
							{
								this.$self_$33604.transform.position = this.$myPosition$33601;
								if (227206 - 92923 == 134283)
								{
									this.$self_$33604.transform.LookAt(this.$myPosition$33601 + this.$myDirection$33602);
									if (4066 - 496207 != -492140)
									{
										this.$self_$33604.mChar.hp = 0;
										if (222273 - 292002 == -69729)
										{
											this.$self_$33604.mChar.actionState = "dead";
											if (150820 - 222812 != -71991)
											{
												this.$self_$33604.mChar.actionTime = Time.time;
												if (196359 - 449389 == -253030)
												{
													this.$self_$33604.mChar.myCommand = "none";
													if (133656 - 408306 != -274649)
													{
														this.$self_$33604.mChar.vMovement = Vector3.zero;
														if (96260 - 183015 == -86755)
														{
															this.$self_$33604.mChar.moveSpeed = (float)0;
															if (45318 - 205905 != -160586)
															{
																this.$self_$33604.animation.Rewind();
																if (16202 - 173844 == -157642)
																{
																	this.$self_$33604.animation.Play("dead");
																	if (291877 - 244639 == 47238)
																	{
																		this.$self_$33604.animation.wrapMode = WrapMode.Once;
																		if (82429 - 120506 != -38076)
																		{
																			if (PlayerPrefs.GetInt("pvoice", 1) == 0)
																			{
																				break;
																			}
																			if (61983 - 477768 != -415784)
																			{
																				if (this.$self_$33604.dead_vc)
																				{
																					if (129515 - 283488 == -153973)
																					{
																						this.$self_$33604.audio.PlayOneShot(this.$self_$33604.dead_vc);
																						if (26739 - 224813 != -198073)
																						{
																							break;
																						}
																					}
																				}
																				else
																				{
																					Debug.LogError("Cannot find dead voice");
																					if (142754 - 538878 == -396124)
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
				goto IL_240;
				Block_7:
				goto IL_653;
				IL_240:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_23:
				IL_653:
				return false;
			}

			// Token: 0x06004F93 RID: 20371 RVA: 0x009C4304 File Offset: 0x009C2504
			internal static bool IiFf6v5IDFwcK45yrELM()
			{
				return true;
			}

			// Token: 0x06004F94 RID: 20372 RVA: 0x009C4308 File Offset: 0x009C2508
			internal static bool ogYefK5IvEuffUDIx8RP()
			{
				return false;
			}

			// Token: 0x04005939 RID: 22841
			internal string $m$33600;

			// Token: 0x0400593A RID: 22842
			internal Vector3 $myPosition$33601;

			// Token: 0x0400593B RID: 22843
			internal Vector3 $myDirection$33602;

			// Token: 0x0400593C RID: 22844
			internal UnityScript.Lang.Array $nArray$33603;

			// Token: 0x0400593D RID: 22845
			internal Turtle2 $self_$33604;
		}
	}
}
