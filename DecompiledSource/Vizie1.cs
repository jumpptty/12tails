using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020003C1 RID: 961
[Serializable]
public class Vizie1 : MonoBehaviour
{
	// Token: 0x0600165B RID: 5723 RVA: 0x002494BC File Offset: 0x002476BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vizie1()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600165C RID: 5724 RVA: 0x002494CC File Offset: 0x002476CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (203125 - 224915 != -21789)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (290978 - 599147 != -308168)
			{
				this.mChar.actionState = "standby";
				if (154198 - 44529 != 109670)
				{
					this.mChar.actionTime = Time.time;
					if (163150 - 376893 == -213743)
					{
						this.mChar.myCommand = "none";
						if (227617 - 329308 != -101690)
						{
							if (Game.mGameType != 99)
							{
								break;
							}
							if (245785 - 482362 != -236576)
							{
								this.mChar.isMine = true;
								if (167270 - 440042 != -272771)
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

	// Token: 0x0600165D RID: 5725 RVA: 0x00249604 File Offset: 0x00247804
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (142975 - 305082 != -162107)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (145725 - 31320 != 114405)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (294897 - 202279 != 92618)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_4E;
					}
					if (171314 - 156594 != 14720)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (88405 - 210574 == -122168)
				{
					continue;
				}
			}
			IL_4E:
			if (this.mChar.hp > 0)
			{
				break;
			}
			if (39797 - 546300 == -506503)
			{
				if (!(this.mChar.actionState != "dead"))
				{
					break;
				}
				if (174152 - 64981 != 109172)
				{
					if (this.mChar.isMine)
					{
						if (203107 - 506392 != -303284)
						{
							this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
							{
								this.transform.position,
								this.transform.forward
							})));
							if (37978 - 14655 != 23324)
							{
								if (!PhotonClient.IsInitialized())
								{
									break;
								}
								if (233280 - 379750 == -146470)
								{
									this.mChar.DeadEvent();
									if (152559 - 456113 == -303554)
									{
										break;
									}
								}
							}
						}
					}
					else
					{
						this.mChar.hp = 1;
						if (142360 - 306983 != -164622)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600165E RID: 5726 RVA: 0x00249844 File Offset: 0x00247A44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (265603 - 291553 != -25949)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (167376 - 157545 == 9831)
			{
				float runSpeed = this.mChar.runSpeed;
				if (53699 - 144421 != -90721)
				{
					Vector3 a = default(Vector3);
					if (270121 - 223196 == 46925)
					{
						Vector3 vector = Vector3.zero;
						if (196483 - 167299 == 29184)
						{
							float num2 = (float)0;
							if (289895 - 6700 == 283195)
							{
								if (this.mChar.isMine)
								{
									if (140747 - 327566 == -186818)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (113666 - 482756 == -369089)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (45438 - 414473 == -369034)
										{
											continue;
										}
										a.y = (float)0;
										if (20826 - 9683 != 11143)
										{
											continue;
										}
										a = a.normalized;
										if (65025 - 28018 == 37008)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (2667 - 517149 == -514481)
										{
											continue;
										}
										vector = vector.normalized;
										if (26090 - 78375 == -52284)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (59266 - 148093 != -88827)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (135269 - 502111 != -366842)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (258189 - 521215 != -263026)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (247941 - 368283 != -120342)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (127774 - 80245 == 47530)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (147774 - 203625 != -55851)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (233290 - 280224 != -46934)
														{
															continue;
														}
														this.animation.Play("run");
														if (25008 - 163845 == -138836)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (164780 - 78005 != 86775)
														{
															continue;
														}
														goto IL_D5;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (250344 - 446461 == -196116)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (19968 - 450310 != -430342)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (159736 - 470369 != -310633)
											{
												continue;
											}
											num = (float)0;
											if (46435 - 501871 == -455435)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (22489 - 473572 != -451083)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (82741 - 496650 == -413908)
										{
											continue;
										}
									}
									IL_D5:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (200161 - 122933 == 77229)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (60716 - 578931 != -518215)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (50483 - 235509 == -185025)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (273882 - 227704 != 46178)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (11475 - 196366 != -184891)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (158843 - 507380 == -348536)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (70736 - 538364 != -467628)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (18907 - 472164 != -453257)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (140571 - 272833 != -132262)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (5622 - 491058 == -485435)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (103649 - 148196 != -44547)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (76827 - 330359 != -253532)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (255360 - 526657 == -271296)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (296752 - 239943 != 56809)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (28204 - 130750 == -102545)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (81273 - 503778 == -422504)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (112620 - 579721 != -467101)
												{
													continue;
												}
												num = (float)0;
												if (119705 - 497937 != -378232)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (188396 - 579216 != -390820)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (57816 - 335829 != -278013)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (214933 - 126156 == 88778)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (204779 - 220777 != -15998)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (74806 - 240390 != -165584)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (125805 - 583026 != -457221)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (65962 - 317070 == -251107)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (187888 - 504196 == -316307)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (82162 - 153005 == -70842)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (118131 - 467967 == -349835)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (158957 - 342658 != -183701)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (283767 - 195281 == 88487)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (92913 - 331663 == -238749)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (6661 - 2685 == 3977)
											{
												continue;
											}
											num = (float)0;
											if (100635 - 96131 != 4504)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (45453 - 271683 == -226229)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (146164 - 37793 == 108372)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (283695 - 221772 == 61924)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (231151 - 318584 == -87432)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (8282 - 149598 != -141315)
								{
									this.mChar.moveSpeed = num;
									if (4569 - 331861 == -327292)
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

	// Token: 0x0600165F RID: 5727 RVA: 0x0024A3A8 File Offset: 0x002485A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (289297 - 46139 != 243159)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (106963 - 157259 != -50295)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (197705 - 450548 != -252842 && 100963 - 198121 != -97157)
				{
					if (ActionName == "RPC_nAttack")
					{
						if (237248 - 379934 == -142685)
						{
							continue;
						}
						v = 1;
						if (162932 - 518494 != -355562)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nAttack_hit")
					{
						if (140899 - 439422 != -298523)
						{
							continue;
						}
						v = -1;
						if (128398 - 476533 != -348135)
						{
							continue;
						}
					}
					int v2 = Mathf.RoundToInt(nPos.x * (float)50);
					if (287567 - 72523 == 215044)
					{
						int v3 = Mathf.RoundToInt(nPos.y * (float)50);
						if (68190 - 558726 != -490535)
						{
							int v4 = Mathf.RoundToInt(nPos.z * (float)50);
							if (137051 - 481093 != -344041)
							{
								int v5 = Mathf.RoundToInt((float)200 * tPos.x);
								if (142145 - 354442 != -212296)
								{
									int v6 = Mathf.RoundToInt((float)200 * tPos.y);
									if (85645 - 192982 != -107336)
									{
										int v7 = Mathf.RoundToInt((float)200 * tPos.z);
										if (115412 - 314263 != -198850)
										{
											Hashtable hashtable = new Hashtable();
											if (52032 - 405265 != -353232)
											{
												hashtable.Add(120, PhotonClient.cInt16(v));
												if (283735 - 546727 == -262992)
												{
													hashtable.Add(122, PhotonClient.cInt16(v2));
													if (113923 - 235175 != -121251)
													{
														hashtable.Add(123, PhotonClient.cInt16(v3));
														if (259280 - 10751 == 248529)
														{
															hashtable.Add(124, PhotonClient.cInt16(v4));
															if (295517 - 84699 == 210818)
															{
																hashtable.Add(126, PhotonClient.cInt16(v5));
																if (262571 - 287333 == -24762)
																{
																	hashtable.Add(127, PhotonClient.cInt16(v6));
																	if (189360 - 143865 != 45496)
																	{
																		hashtable.Add(128, PhotonClient.cInt16(v7));
																		if (127458 - 297410 == -169952)
																		{
																			hashtable.Add(129, PhotonClient.cInt16(tID));
																			if (258445 - 409448 != -151002)
																			{
																				PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																				if (150289 - 33207 == 117082)
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

	// Token: 0x06001660 RID: 5728 RVA: 0x0024A7FC File Offset: 0x002489FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (256320 - 61337 != 194983)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (45994 - 104768 == -58774)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (196153 - 291469 != -95315)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (214338 - 5870 == 208468)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (9328 - 317368 == -308040)
						{
							int num3 = num;
							if (95340 - 583485 == -488145)
							{
								if (num3 == 1)
								{
									if (230478 - 169830 != 60649)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (291938 - 210743 != 81196)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (223374 - 416060 == -192686)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (93074 - 53479 == 39595)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (40951 - 33721 == 7230)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (284505 - 220825 == 63680)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.LogError("Unknown Action Code:" + num);
									if (293588 - 116604 != 176985)
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

	// Token: 0x06001661 RID: 5729 RVA: 0x0024AA90 File Offset: 0x00248C90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (290093 - 13493 != 276600)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (119368 - 479206 != -359837)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (280818 - 247474 == 33344)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (200688 - 170225 != 30464)
					{
						Vector3 normalized = vector.normalized;
						if (283399 - 194957 == 88442)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (220374 - 527103 != -306728)
							{
								if (202290 - 291918 == -89628)
								{
									if (gameObject)
									{
										if (79655 - 56842 != 22813)
										{
											continue;
										}
										CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (52362 - 396737 == -344374)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (82484 - 67227 != 15257)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (100387 - 25617 != 74770)
										{
											continue;
										}
									}
									if (this.mChar.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (91302 - 204203 != -112900)
									{
										this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, normalized, 0));
										if (276730 - 552607 != -275876)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (278526 - 91711 == 186815)
											{
												this.ActionEvent("RPC_nAttack", this.transform.position, normalized, 0);
												if (283537 - 274534 == 9003)
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

	// Token: 0x06001662 RID: 5730 RVA: 0x0024AD4C File Offset: 0x00248F4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character cannot use charged attack");
	}

	// Token: 0x06001663 RID: 5731 RVA: 0x0024AD64 File Offset: 0x00248F64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06001664 RID: 5732 RVA: 0x0024AD68 File Offset: 0x00248F68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Vizie1.$RPC_nAttack$19030(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06001665 RID: 5733 RVA: 0x0024AD78 File Offset: 0x00248F78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, this.transform.rotation);
	}

	// Token: 0x06001666 RID: 5734 RVA: 0x0024AD94 File Offset: 0x00248F94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_ko(UnityScript.Lang.Array nArray)
	{
	}

	// Token: 0x06001667 RID: 5735 RVA: 0x0024AD98 File Offset: 0x00248F98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new Vizie1.$RPC_dead$19049(nArray, this).GetEnumerator();
	}

	// Token: 0x06001668 RID: 5736 RVA: 0x0024ADA8 File Offset: 0x00248FA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06001669 RID: 5737 RVA: 0x0024ADAC File Offset: 0x00248FAC
	internal static bool MOXoKNFzhOvAlKm8Xvp()
	{
		return true;
	}

	// Token: 0x0600166A RID: 5738 RVA: 0x0024ADB0 File Offset: 0x00248FB0
	internal static bool eFIwoiMa3tLmYLEJv8f()
	{
		return false;
	}

	// Token: 0x04001325 RID: 4901
	public CharacterControl mChar;

	// Token: 0x04001326 RID: 4902
	public GameObject nAttack_trail;

	// Token: 0x04001327 RID: 4903
	public GameObject nAttack_hit;

	// Token: 0x020003C2 RID: 962
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$19030 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600166B RID: 5739 RVA: 0x0024ADB4 File Offset: 0x00248FB4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$19030(Vector3 mPos, Vector3 tDir, Vizie1 self_)
		{
			if (25781 - 21849 != 3932)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (275561 - 594193 == -318632)
				{
					base..ctor();
					if (173266 - 194553 != -21286)
					{
						this.$mPos$19046 = mPos;
						if (147391 - 137333 == 10058)
						{
							this.$tDir$19047 = tDir;
							if (250563 - 363971 != -113407)
							{
								this.$self_$19048 = self_;
								if (171641 - 456518 != -284876)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600166C RID: 5740 RVA: 0x0024AE90 File Offset: 0x00249090
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Vizie1.$RPC_nAttack$19030.$(this.$mPos$19046, this.$tDir$19047, this.$self_$19048);
		}

		// Token: 0x0600166D RID: 5741 RVA: 0x0024AEAC File Offset: 0x002490AC
		internal static bool k3YV41M5n2gD7P8scVJ()
		{
			return true;
		}

		// Token: 0x0600166E RID: 5742 RVA: 0x0024AEB0 File Offset: 0x002490B0
		internal static bool s7SMHVMpykM9nGPxNlj()
		{
			return false;
		}

		// Token: 0x04001328 RID: 4904
		internal Vector3 $mPos$19046;

		// Token: 0x04001329 RID: 4905
		internal Vector3 $tDir$19047;

		// Token: 0x0400132A RID: 4906
		internal Vizie1 $self_$19048;

		// Token: 0x020003C3 RID: 963
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600166F RID: 5743 RVA: 0x0024AEB4 File Offset: 0x002490B4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Vizie1 self_)
			{
				if (236914 - 424671 != -187757)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (242033 - 195005 != 47029)
					{
						base..ctor();
						if (2405 - 310972 != -308566)
						{
							this.$mPos$19043 = mPos;
							if (292084 - 338572 != -46487)
							{
								this.$tDir$19044 = tDir;
								if (119135 - 252119 != -132983)
								{
									this.$self_$19045 = self_;
									if (27636 - 135674 != -108037)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06001670 RID: 5744 RVA: 0x0024AF90 File Offset: 0x00249190
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (229872 - 372080 != -142208)
				{
				}
				for (;;)
				{
					IL_BCE:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_EF2;
					case 2:
						if (this.$self_$19045.mChar.actionState != "attack")
						{
							goto IL_5A6;
						}
						if (225099 - 14954 == 210146)
						{
							continue;
						}
						if (this.$self_$19045.mChar.myCommand != "nAttack")
						{
							if (265210 - 334421 != -69211)
							{
								continue;
							}
							goto IL_5A6;
						}
						else
						{
							this.$self_$19045.mChar.moveSpeed = (float)4;
							if (18879 - 267272 != -248393)
							{
								continue;
							}
							this.$mMallet$19031 = global::Math.findChildObject(this.$self_$19045.transform, "Mallet");
							if (33463 - 557669 != -524206)
							{
								continue;
							}
							if (!this.$mMallet$19031)
							{
								goto IL_13F;
							}
							if (115094 - 34223 != 80871)
							{
								continue;
							}
							this.$mAttack_trail$19032 = (GameObject)UnityEngine.Object.Instantiate(this.$self_$19045.nAttack_trail, Vector3.zero, Quaternion.identity);
							if (107519 - 330056 == -222536)
							{
								continue;
							}
							this.$mAttack_trail$19032.transform.parent = this.$mMallet$19031;
							if (280499 - 176555 == 103945)
							{
								continue;
							}
							this.$mAttack_trail$19032.transform.localPosition = new Vector3(-0.5f, (float)0, (float)0);
							if (265075 - 493407 == -228331)
							{
								continue;
							}
							this.$mAttack_trail$19032.transform.localRotation = Quaternion.identity;
							if (63548 - 150638 == -87089)
							{
								continue;
							}
							this.$mAttack_trail_control$19033 = (EffectControl)this.$mAttack_trail$19032.GetComponent(typeof(EffectControl));
							if (224102 - 214180 != 9922)
							{
								continue;
							}
							this.$mAttack_trail_control$19033.InitEffectControl(this.$self_$19045.gameObject);
							if (223824 - 524630 != -300805)
							{
								goto Block_37;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$19045.mChar.actionState != "attack")
						{
							goto IL_C0F;
						}
						if (255049 - 374207 != -119158)
						{
							continue;
						}
						if (this.$self_$19045.mChar.myCommand != "nAttack")
						{
							if (262222 - 86332 != 175890)
							{
								continue;
							}
							goto IL_C0F;
						}
						else
						{
							this.$hitLayer$19034 = 130816 - (1 << this.$self_$19045.gameObject.layer);
							if (32273 - 523563 != -491290)
							{
								continue;
							}
							this.$hitList$19035 = null;
							if (98770 - 67093 == 31678)
							{
								continue;
							}
							this.$hitPos$19036 = default(Vector3);
							if (219694 - 400171 != -180477)
							{
								continue;
							}
							if (!this.$self_$19045.mChar.isMine)
							{
								goto IL_901;
							}
							if (189829 - 519309 != -329480)
							{
								continue;
							}
							this.$hitList$19035 = Damage.FindRecTarget(this.$self_$19045.transform.position, this.$self_$19045.transform.forward, (float)1, (float)1, (float)3, (float)3, this.$hitLayer$19034);
							if (148147 - 135184 != 12963)
							{
								continue;
							}
							this.$$iterator$10496$19038 = UnityRuntimeServices.GetEnumerator(this.$hitList$19035);
							if (275168 - 486890 == -211721)
							{
								continue;
							}
							while (this.$$iterator$10496$19038.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10496$19038.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$19037 = (GameObject)obj2;
								if (145763 - 554061 != -408298)
								{
									goto IL_BCE;
								}
								if (this.$self_$19045.mChar.hit(99, this.$hitObject$19037, (int)(0.5f * (float)this.$self_$19045.mChar.atk), 2, 0, 0.3f * (this.$hitObject$19037.transform.position - this.$self_$19045.transform.position).normalized) != 0)
								{
									if (174189 - 588820 != -414631)
									{
										goto IL_BCE;
									}
									this.$hitPos$19036 = this.$hitObject$19037.collider.ClosestPointOnBounds(this.$self_$19045.transform.position + Vector3.up);
									if (263443 - 203424 == 60020)
									{
										goto IL_BCE;
									}
									UnityRuntimeServices.Update(this.$$iterator$10496$19038, this.$hitObject$19037);
									if (157200 - 51699 == 105502)
									{
										goto IL_BCE;
									}
									this.$self_$19045.RPC_nAttack_hit(this.$hitPos$19036, this.$self_$19045.transform.forward, 0);
									if (109605 - 592617 == -483011)
									{
										goto IL_BCE;
									}
									this.$self_$19045.ActionEvent("RPC_nAttack_hit", this.$hitPos$19036, this.$self_$19045.transform.forward, 0);
									if (115329 - 6285 != 109044)
									{
										goto IL_BCE;
									}
								}
							}
							if (287506 - 464498 != -176991)
							{
								goto Block_63;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$19045.mChar.actionState != "attack")
						{
							goto IL_AAF;
						}
						if (113056 - 77229 != 35827)
						{
							continue;
						}
						if (this.$self_$19045.mChar.myCommand != "nAttack")
						{
							if (170108 - 143826 != 26282)
							{
								continue;
							}
							goto IL_AAF;
						}
						else
						{
							this.$self_$19045.mChar.moveSpeed = (float)3;
							if (291246 - 112303 != 178943)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$19045.nAttack_hit, this.$self_$19045.transform.position + this.$self_$19045.transform.forward, Quaternion.identity);
							if (211825 - 268817 != -56992)
							{
								continue;
							}
							goto IL_829;
						}
						break;
					case 5:
						if (this.$self_$19045.mChar.actionState != "attack")
						{
							goto IL_7A2;
						}
						if (209472 - 52920 == 156553)
						{
							continue;
						}
						if (this.$self_$19045.mChar.myCommand != "nAttack")
						{
							if (150963 - 118620 != 32343)
							{
								continue;
							}
							goto IL_7A2;
						}
						else
						{
							this.$self_$19045.mChar.moveSpeed = (float)0;
							if (80477 - 203812 != -123335)
							{
								continue;
							}
							if (!this.$self_$19045.mChar.isMine)
							{
								goto IL_EA3;
							}
							if (47423 - 22611 != 24812)
							{
								continue;
							}
							this.$hitList$19035 = Damage.FindAreaTarget(this.$self_$19045.transform.position, 2.5f * this.$self_$19045.mChar.rangeMod, (float)2 * this.$self_$19045.mChar.rangeMod, this.$hitLayer$19034);
							if (190306 - 125438 != 64868)
							{
								continue;
							}
							this.$$iterator$10497$19042 = UnityRuntimeServices.GetEnumerator(this.$hitList$19035);
							if (60043 - 435889 == -375845)
							{
								continue;
							}
							while (this.$$iterator$10497$19042.MoveNext())
							{
								object obj4;
								object obj3 = obj4 = this.$$iterator$10497$19042.Current;
								if (!(obj3 is GameObject))
								{
									obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
								}
								this.$hitObject$19039 = (GameObject)obj4;
								if (159176 - 192629 != -33453)
								{
									goto IL_BCE;
								}
								if (this.$self_$19045.mChar.hit(99, this.$hitObject$19039, this.$self_$19045.mChar.atk, 3, 0, 0.5f * (this.$hitObject$19039.transform.position - this.$self_$19045.transform.position).normalized) != 0)
								{
									if (6966 - 90497 == -83530)
									{
										goto IL_BCE;
									}
									this.$tChar$19040 = (CharacterControl)this.$hitObject$19039.GetComponent(typeof(CharacterControl));
									if (77093 - 475323 != -398230)
									{
										goto IL_BCE;
									}
									UnityRuntimeServices.Update(this.$$iterator$10497$19042, this.$hitObject$19039);
									if (278167 - 542801 == -264633)
									{
										goto IL_BCE;
									}
									this.$mDuration$19041 = Damage.getDebuff((float)3, this.$self_$19045.mChar.cha, this.$tChar$19040.cha);
									if (32571 - 9182 == 23390)
									{
										goto IL_BCE;
									}
									if (this.$tChar$19040)
									{
										if (295792 - 441116 == -145323)
										{
											goto IL_BCE;
										}
										this.$tChar$19040.RPC_AddStatus("maim", 3, this.$mDuration$19041, 0, this.$self_$19045.mChar.ActorNr);
										if (85591 - 562846 != -477255)
										{
											goto IL_BCE;
										}
									}
								}
							}
							if (114054 - 243542 != -129488)
							{
								continue;
							}
							goto IL_EA3;
						}
						break;
					case 6:
						if (this.$self_$19045.mChar.actionState == "attack")
						{
							if (278486 - 41492 != 236994)
							{
								continue;
							}
							if (this.$self_$19045.mChar.myCommand == "nAttack")
							{
								if (148310 - 417994 == -269683)
								{
									continue;
								}
								this.$self_$19045.mChar.actionState = "standby";
								if (214190 - 449425 == -235234)
								{
									continue;
								}
								this.$self_$19045.mChar.actionTime = Time.time;
								if (59490 - 412855 != -353365)
								{
									continue;
								}
								this.$self_$19045.mChar.myCommand = "none";
								if (47289 - 13764 == 33526)
								{
									continue;
								}
								if (!this.$self_$19045.mChar.isMine)
								{
									if (24752 - 547719 != -522967)
									{
										continue;
									}
									this.$self_$19045.mChar.nPosition = this.$self_$19045.transform.position;
									if (63452 - 506404 == -442951)
									{
										continue;
									}
									this.$self_$19045.mChar.oPosition = this.$self_$19045.transform.position;
									if (120508 - 286323 != -165815)
									{
										continue;
									}
									this.$self_$19045.mChar.nDirection = this.$self_$19045.transform.forward;
									if (250698 - 74887 == 175812)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (18672 - 425107 != -406434)
						{
							goto Block_56;
						}
						continue;
					default:
						if (232518 - 152589 != 79929)
						{
							continue;
						}
						break;
					}
					this.$self_$19045.mChar.actionState = "attack";
					if (174988 - 602 == 174386)
					{
						this.$self_$19045.mChar.actionTime = Time.time;
						if (257225 - 509681 == -252456)
						{
							this.$self_$19045.mChar.myCommand = "nAttack";
							if (95908 - 272217 == -176309)
							{
								this.$self_$19045.mChar.addTimeOut("nAttack", (float)3);
								if (200146 - 150341 != 49806)
								{
									this.$self_$19045.transform.position = this.$mPos$19043;
									if (149266 - 304585 != -155318)
									{
										this.$self_$19045.transform.LookAt(this.$mPos$19043 + global::Math.vFlat(this.$tDir$19044));
										if (196202 - 84788 == 111414)
										{
											this.$self_$19045.animation.CrossFade("nAttack");
											if (145139 - 426383 != -281243)
											{
												this.$self_$19045.animation.wrapMode = WrapMode.Once;
												if (193971 - 34064 == 159907)
												{
													this.$self_$19045.mChar.vMovement = this.$self_$19045.transform.forward;
													if (159338 - 34841 == 124497)
													{
														this.$self_$19045.mChar.moveSpeed = (float)6;
														if (212175 - 569033 != -356857)
														{
															goto Block_64;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_13F:
				return this.Yield(3, new WaitForSeconds(0.1f));
				IL_5A6:
				goto IL_EF2;
				Block_37:
				goto IL_13F;
				IL_7A2:
				goto IL_EF2;
				IL_829:
				return this.Yield(5, new WaitForSeconds(0.1f));
				IL_901:
				return this.Yield(4, new WaitForSeconds(0.2f));
				Block_56:
				goto IL_EF2;
				Block_63:
				goto IL_901;
				Block_64:
				return this.Yield(2, new WaitForSeconds(0.2f));
				IL_AAF:
				IL_C0F:
				goto IL_EF2;
				IL_EA3:
				return this.Yield(6, new WaitForSeconds(0.2f));
				IL_EF2:
				return false;
			}

			// Token: 0x06001671 RID: 5745 RVA: 0x0024BEA4 File Offset: 0x0024A0A4
			internal static bool fhyP00MVODUuAsG9QfA()
			{
				return true;
			}

			// Token: 0x06001672 RID: 5746 RVA: 0x0024BEA8 File Offset: 0x0024A0A8
			internal static bool suD2UZMtD9HBcpe5AxH()
			{
				return false;
			}

			// Token: 0x0400132B RID: 4907
			internal Transform $mMallet$19031;

			// Token: 0x0400132C RID: 4908
			internal GameObject $mAttack_trail$19032;

			// Token: 0x0400132D RID: 4909
			internal EffectControl $mAttack_trail_control$19033;

			// Token: 0x0400132E RID: 4910
			internal int $hitLayer$19034;

			// Token: 0x0400132F RID: 4911
			internal UnityScript.Lang.Array $hitList$19035;

			// Token: 0x04001330 RID: 4912
			internal Vector3 $hitPos$19036;

			// Token: 0x04001331 RID: 4913
			internal GameObject $hitObject$19037;

			// Token: 0x04001332 RID: 4914
			internal IEnumerator $$iterator$10496$19038;

			// Token: 0x04001333 RID: 4915
			internal GameObject $hitObject$19039;

			// Token: 0x04001334 RID: 4916
			internal CharacterControl $tChar$19040;

			// Token: 0x04001335 RID: 4917
			internal int $mDuration$19041;

			// Token: 0x04001336 RID: 4918
			internal IEnumerator $$iterator$10497$19042;

			// Token: 0x04001337 RID: 4919
			internal Vector3 $mPos$19043;

			// Token: 0x04001338 RID: 4920
			internal Vector3 $tDir$19044;

			// Token: 0x04001339 RID: 4921
			internal Vizie1 $self_$19045;
		}
	}

	// Token: 0x020003C4 RID: 964
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$19049 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001673 RID: 5747 RVA: 0x0024BEAC File Offset: 0x0024A0AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$19049(UnityScript.Lang.Array nArray, Vizie1 self_)
		{
			if (22838 - 316613 != -293774)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (137595 - 336582 != -198986)
				{
					base..ctor();
					if (7106 - 81435 == -74329)
					{
						this.$nArray$19054 = nArray;
						if (17820 - 327123 != -309302)
						{
							this.$self_$19055 = self_;
							if (50554 - 308378 != -257823)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06001674 RID: 5748 RVA: 0x0024BF68 File Offset: 0x0024A168
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Vizie1.$RPC_dead$19049.$(this.$nArray$19054, this.$self_$19055);
		}

		// Token: 0x06001675 RID: 5749 RVA: 0x0024BF7C File Offset: 0x0024A17C
		internal static bool HIotAxMNkEnhUjvFj1e()
		{
			return true;
		}

		// Token: 0x06001676 RID: 5750 RVA: 0x0024BF80 File Offset: 0x0024A180
		internal static bool of128yMY3cSiS8SPUpR()
		{
			return false;
		}

		// Token: 0x0400133A RID: 4922
		internal UnityScript.Lang.Array $nArray$19054;

		// Token: 0x0400133B RID: 4923
		internal Vizie1 $self_$19055;

		// Token: 0x020003C5 RID: 965
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001677 RID: 5751 RVA: 0x0024BF84 File Offset: 0x0024A184
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Vizie1 self_)
			{
				if (246534 - 161419 != 85116)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (44024 - 574574 != -530549)
					{
						base..ctor();
						if (101440 - 584003 != -482562)
						{
							this.$nArray$19052 = nArray;
							if (60311 - 62472 != -2160)
							{
								this.$self_$19053 = self_;
								if (217863 - 114178 == 103685)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06001678 RID: 5752 RVA: 0x0024C040 File Offset: 0x0024A240
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (202746 - 152635 != 50112)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_42F;
					case 2:
						if (this.$self_$19053.mChar.actionState != "dead")
						{
							if (118496 - 33773 != 84723)
							{
								continue;
							}
							goto IL_3FB;
						}
						else
						{
							if (!this.$self_$19053.mChar.isPlayer)
							{
								if (232600 - 180447 == 52154)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$19053.gameObject);
								if (201863 - 320037 == -118173)
								{
									continue;
								}
							}
							else if (this.$self_$19053.mChar.isMine)
							{
								if (177395 - 122027 == 55369)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$19053.gameObject);
								if (190940 - 115908 != 75032)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (190640 - 295062 != -104422)
							{
								continue;
							}
							goto IL_42F;
						}
						break;
					default:
						if (183911 - 86928 == 96984)
						{
							continue;
						}
						break;
					}
					if (this.$self_$19053.mChar.actionState == "dead")
					{
						if (63597 - 101150 == -37553)
						{
							goto IL_2C9;
						}
					}
					else
					{
						this.$myPosition$19050 = (Vector3)this.$nArray$19052[0];
						if (77206 - 224287 == -147081)
						{
							this.$myDirection$19051 = (Vector3)this.$nArray$19052[1];
							if (88597 - 61120 != 27478)
							{
								this.$self_$19053.transform.position = this.$myPosition$19050;
								if (249215 - 180900 == 68315)
								{
									this.$self_$19053.transform.LookAt(this.$myPosition$19050 + this.$myDirection$19051);
									if (132949 - 552135 == -419186)
									{
										this.$self_$19053.mChar.hp = 0;
										if (125834 - 302626 == -176792)
										{
											this.$self_$19053.mChar.actionState = "dead";
											if (239032 - 391572 == -152540)
											{
												this.$self_$19053.mChar.actionTime = Time.time;
												if (64624 - 129615 == -64991)
												{
													this.$self_$19053.mChar.myCommand = "none";
													if (68315 - 89977 != -21661)
													{
														this.$self_$19053.mChar.vMovement = Vector3.zero;
														if (42709 - 159217 != -116507)
														{
															this.$self_$19053.mChar.moveSpeed = (float)0;
															if (70758 - 323232 != -252473)
															{
																this.$self_$19053.animation.Rewind();
																if (190457 - 350362 == -159905)
																{
																	this.$self_$19053.animation.Play("ko");
																	if (119165 - 578117 != -458951)
																	{
																		this.$self_$19053.animation.wrapMode = WrapMode.Once;
																		if (175194 - 264907 == -89713)
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
				return this.Yield(2, new WaitForSeconds(3f));
				IL_2C9:
				IL_3FB:
				IL_42F:
				return false;
			}

			// Token: 0x06001679 RID: 5753 RVA: 0x0024C490 File Offset: 0x0024A690
			internal static bool WOoi2sMcOB4q2sgSlI8()
			{
				return true;
			}

			// Token: 0x0600167A RID: 5754 RVA: 0x0024C494 File Offset: 0x0024A694
			internal static bool K6sjktMUv1le31bfES5()
			{
				return false;
			}

			// Token: 0x0400133C RID: 4924
			internal Vector3 $myPosition$19050;

			// Token: 0x0400133D RID: 4925
			internal Vector3 $myDirection$19051;

			// Token: 0x0400133E RID: 4926
			internal UnityScript.Lang.Array $nArray$19052;

			// Token: 0x0400133F RID: 4927
			internal Vizie1 $self_$19053;
		}
	}
}
