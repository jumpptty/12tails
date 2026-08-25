using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000DE1 RID: 3553
[Serializable]
public class ZombieCrawfish : MonoBehaviour
{
	// Token: 0x06005047 RID: 20551 RVA: 0x009D8074 File Offset: 0x009D6274
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ZombieCrawfish()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06005048 RID: 20552 RVA: 0x009D8084 File Offset: 0x009D6284
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (272133 - 233790 != 38343)
		{
		}
		for (;;)
		{
			this.R9xcQpxH9a2 = this.transform;
			if (120709 - 178216 != -57506)
			{
				this.c0ZcQRsd0uE = (CharacterControl)this.GetComponent(typeof(CharacterControl));
				if (21125 - 299963 != -278837)
				{
					this.c0ZcQRsd0uE.actionState = "standby";
					if (289343 - 492307 != -202963)
					{
						this.c0ZcQRsd0uE.actionTime = Time.time;
						if (74288 - 580401 != -506112)
						{
							this.c0ZcQRsd0uE.myCommand = "none";
							if (163994 - 340858 != -176863)
							{
								this.c0ZcQRsd0uE.hp = (this.c0ZcQRsd0uE.mhp = 950);
								if (189607 - 380903 != -191295)
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

	// Token: 0x06005049 RID: 20553 RVA: 0x009D81D0 File Offset: 0x009D63D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (197231 - 148133 != 49099)
		{
		}
		do
		{
			if (Game.mGameType == 99)
			{
				if (160315 - 186975 == -26659)
				{
					continue;
				}
				this.c0ZcQRsd0uE.isMine = true;
				if (291063 - 64768 != 226295)
				{
					continue;
				}
			}
			this.c0ZcQRsd0uE.addTimeOut("nAttack", (float)UnityEngine.Random.Range(1, 4));
		}
		while (202325 - 400353 == -198027);
	}

	// Token: 0x0600504A RID: 20554 RVA: 0x009D8288 File Offset: 0x009D6488
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (156321 - 97437 != 58885)
		{
		}
		for (;;)
		{
			if (this.c0ZcQRsd0uE.isControlled)
			{
				if (72984 - 367684 != -294700)
				{
					continue;
				}
				if (!(this.c0ZcQRsd0uE.actionState == "standby"))
				{
					if (114116 - 233070 == -118953)
					{
						continue;
					}
					if (!(this.c0ZcQRsd0uE.actionState == "run"))
					{
						goto IL_481;
					}
					if (175195 - 594532 != -419337)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (220255 - 110274 == 109982)
				{
					continue;
				}
			}
			IL_481:
			if (this.c0ZcQRsd0uE.ko <= 0)
			{
				if (120095 - 152851 != -32756)
				{
					continue;
				}
				if (this.c0ZcQRsd0uE.actionState != "dead")
				{
					if (200872 - 47560 == 153313)
					{
						continue;
					}
					if (this.c0ZcQRsd0uE.isMine)
					{
						if (219445 - 208843 != 10602)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (228433 - 253728 == -25294)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (165561 - 145861 != 19700)
						{
							continue;
						}
						this.c0ZcQRsd0uE.DeadEvent();
						if (288090 - 160939 != 127152)
						{
							break;
						}
						continue;
					}
					else
					{
						this.c0ZcQRsd0uE.ko = 1;
						if (6218 - 154947 != -148729)
						{
							continue;
						}
						break;
					}
				}
			}
			if (this.c0ZcQRsd0uE.ko <= 0)
			{
				break;
			}
			if (204389 - 510788 != -306398)
			{
				if (this.c0ZcQRsd0uE.hp > 0)
				{
					break;
				}
				if (216896 - 213343 != 3554)
				{
					if (!(this.c0ZcQRsd0uE.actionState != "ko"))
					{
						break;
					}
					if (173750 - 306474 == -132724)
					{
						if (!(this.c0ZcQRsd0uE.actionState != "dead"))
						{
							break;
						}
						if (90038 - 587475 == -497437)
						{
							if (this.c0ZcQRsd0uE.isMine)
							{
								if (185456 - 287904 != -102447)
								{
									if (this.c0ZcQRsd0uE.ko > 10)
									{
										if (277394 - 297462 == -20068)
										{
											this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
											{
												this.transform.position,
												this.transform.forward
											})));
											if (158117 - 463100 == -304983)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (296323 - 39169 == 257154)
												{
													this.c0ZcQRsd0uE.KoEvent();
													if (71904 - 93296 != -21391)
													{
														break;
													}
												}
											}
										}
									}
									else
									{
										this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
										{
											this.transform.position,
											this.transform.forward
										})));
										if (20332 - 563493 == -543161)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (94827 - 332127 == -237300)
											{
												this.c0ZcQRsd0uE.DeadEvent();
												if (245105 - 514593 != -269487)
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
								this.c0ZcQRsd0uE.hp = 1;
								if (261853 - 186958 == 74895)
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

	// Token: 0x0600504B RID: 20555 RVA: 0x009D8754 File Offset: 0x009D6954
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (29033 - 276078 != -247045)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (116685 - 170153 != -53467)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (128554 - 366415 != -237860 && 241683 - 139164 != 102520)
				{
					if (ActionName == "RPC_nAttack")
					{
						if (149366 - 200124 == -50757)
						{
							continue;
						}
						v = 1;
						if (125388 - 434003 == -308614)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nAttack_hit")
					{
						if (282858 - 243611 != 39247)
						{
							continue;
						}
						v = -1;
						if (119804 - 257430 != -137626)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_cAttack")
					{
						if (210330 - 22733 != 187597)
						{
							continue;
						}
						v = 11;
						if (146677 - 47386 != 99291)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_cAttack_hit")
					{
						if (217484 - 347996 != -130512)
						{
							continue;
						}
						v = -11;
						if (142176 - 268694 == -126517)
						{
							continue;
						}
					}
					else
					{
						Debug.Log("Unknown Action Name:" + ActionName);
						if (180258 - 278572 == -98313)
						{
							continue;
						}
					}
					int v2 = Mathf.RoundToInt(nPos.x * (float)50);
					if (43142 - 103910 != -60767)
					{
						int v3 = Mathf.RoundToInt(nPos.y * (float)50);
						if (218800 - 61626 == 157174)
						{
							int v4 = Mathf.RoundToInt(nPos.z * (float)50);
							if (133504 - 234462 == -100958)
							{
								int v5 = Mathf.RoundToInt((float)200 * tPos.x);
								if (167966 - 362589 != -194622)
								{
									int v6 = Mathf.RoundToInt((float)200 * tPos.y);
									if (295423 - 499827 == -204404)
									{
										int v7 = Mathf.RoundToInt((float)200 * tPos.z);
										if (270197 - 513481 == -243284)
										{
											Hashtable hashtable = new Hashtable();
											if (111604 - 122972 != -11367)
											{
												hashtable.Add(120, PhotonClient.cInt16(v));
												if (156279 - 133502 != 22778)
												{
													hashtable.Add(122, PhotonClient.cInt16(v2));
													if (155234 - 523419 == -368185)
													{
														hashtable.Add(123, PhotonClient.cInt16(v3));
														if (232342 - 596586 != -364243)
														{
															hashtable.Add(124, PhotonClient.cInt16(v4));
															if (258846 - 139097 == 119749)
															{
																hashtable.Add(126, PhotonClient.cInt16(v5));
																if (50207 - 582914 == -532707)
																{
																	hashtable.Add(127, PhotonClient.cInt16(v6));
																	if (43631 - 482998 != -439366)
																	{
																		hashtable.Add(128, PhotonClient.cInt16(v7));
																		if (3705 - 591860 == -588155)
																		{
																			hashtable.Add(129, PhotonClient.cInt16(tID));
																			if (49573 - 231357 == -181784)
																			{
																				PhotonClient.SendEvent(this.c0ZcQRsd0uE.ActorNr, 74, hashtable, true, true);
																				if (43636 - 231234 == -187598)
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

	// Token: 0x0600504C RID: 20556 RVA: 0x009D8C6C File Offset: 0x009D6E6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (161404 - 188676 != -27272)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (152800 - 489413 == -336613)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (6586 - 363011 == -356425)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (296579 - 37390 == 259189)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (239036 - 340797 == -101761)
						{
							int num3 = num;
							if (250132 - 481352 != -231219)
							{
								if (num3 == 1)
								{
									if (116576 - 85809 != 30768)
									{
										if (this.c0ZcQRsd0uE.isMine)
										{
											break;
										}
										if (117461 - 495613 == -378152)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (27523 - 407235 != -379711)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (125399 - 360803 == -235404)
									{
										if (this.c0ZcQRsd0uE.isMine)
										{
											break;
										}
										if (33680 - 242578 != -208897)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (213323 - 166722 != 46602)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (235693 - 129725 != 105969)
									{
										if (this.c0ZcQRsd0uE.isMine)
										{
											break;
										}
										if (40608 - 549482 != -508873)
										{
											this.StartCoroutine_Auto(this.RPC_cAttack(vector, vector2, num2));
											if (100762 - 151178 != -50415)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -11)
								{
									if (288184 - 299246 != -11061)
									{
										if (this.c0ZcQRsd0uE.isMine)
										{
											break;
										}
										if (163208 - 97045 != 66164)
										{
											this.RPC_cAttack_hit(vector, vector2, num2);
											if (185404 - 149061 != 36344)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (283058 - 523628 != -240569)
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

	// Token: 0x0600504D RID: 20557 RVA: 0x009D8FF0 File Offset: 0x009D71F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (176295 - 330032 != -153737)
		{
		}
		for (;;)
		{
			float num = this.c0ZcQRsd0uE.moveSpeed;
			if (30600 - 33010 == -2410)
			{
				float runSpeed = this.c0ZcQRsd0uE.runSpeed;
				if (16089 - 571652 != -555562)
				{
					Vector3 a = default(Vector3);
					if (224161 - 235333 != -11171)
					{
						Vector3 vector = Vector3.zero;
						if (132545 - 322807 == -190262)
						{
							float num2 = (float)0;
							if (50154 - 305310 == -255156)
							{
								if (this.c0ZcQRsd0uE.isMine)
								{
									if (60562 - 286295 != -225733)
									{
										continue;
									}
									if ((this.c0ZcQRsd0uE.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (286669 - 430737 != -144068)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (178032 - 367196 != -189164)
										{
											continue;
										}
										a.y = (float)0;
										if (181805 - 191191 == -9385)
										{
											continue;
										}
										a = a.normalized;
										if (232072 - 155189 != 76883)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (246996 - 216025 != 30971)
										{
											continue;
										}
										vector = vector.normalized;
										if (144991 - 301670 != -156679)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (1735 - 423060 != -421325)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (161405 - 189909 != -28504)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (210506 - 541308 != -330802)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (46716 - 361067 != -314351)
														{
															continue;
														}
														this.c0ZcQRsd0uE.actionState = "run";
														if (245137 - 69341 != 175796)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (229827 - 253669 != -23842)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (63816 - 17400 != 46416)
														{
															continue;
														}
														this.animation.Play("run");
														if (193959 - 123124 != 70835)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (56881 - 328833 != -271951)
														{
															goto IL_A9C;
														}
														continue;
													}
												}
											}
										}
										this.c0ZcQRsd0uE.actionState = "standby";
										if (281282 - 333794 != -52512)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (132223 - 435611 == -303387)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (291383 - 109352 == 182032)
											{
												continue;
											}
											num = (float)0;
											if (210077 - 242817 == -32739)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (244037 - 158896 == 85142)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (13331 - 111940 != -98609)
										{
											continue;
										}
									}
									IL_A9C:;
								}
								else
								{
									vector = global::Math.vFlat(this.c0ZcQRsd0uE.nPosition - this.transform.position);
									if (232769 - 480981 == -248211)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (288489 - 134080 != 154409)
									{
										continue;
									}
									if (this.c0ZcQRsd0uE.nSpeed != (float)0)
									{
										if (18744 - 348795 == -330050)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (237574 - 118488 == 119087)
											{
												continue;
											}
											this.transform.position = this.c0ZcQRsd0uE.nPosition;
											if (176561 - 327858 == -151296)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (165030 - 169562 != -4532)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (260515 - 472737 != -212222)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (142904 - 499376 == -356471)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.c0ZcQRsd0uE.nSpeed, (float)10 * Time.deltaTime);
												if (173359 - 289381 != -116022)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (199470 - 186155 == 13316)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (81902 - 204075 != -122173)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (120077 - 141311 == -21233)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (180821 - 168176 != 12645)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (90777 - 449450 == -358672)
											{
												continue;
											}
										}
										else if (Time.time > this.c0ZcQRsd0uE.nSpeed + 0.3f)
										{
											if (3604 - 587765 != -584161)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (115275 - 588039 == -472763)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (50828 - 436039 == -385210)
												{
													continue;
												}
												num = (float)0;
												if (78576 - 350197 == -271620)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.c0ZcQRsd0uE.nDirection);
											if (122463 - 152444 == -29980)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (2940 - 259702 != -256762)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (294096 - 551611 == -257514)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (253754 - 338288 != -84534)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (282551 - 231673 != 50878)
											{
												continue;
											}
											this.transform.position = this.c0ZcQRsd0uE.nPosition;
											if (2797 - 37994 == -35196)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (79143 - 206698 != -127555)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (111116 - 200321 != -89205)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (87784 - 364467 != -276683)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (206122 - 379902 == -173779)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (128903 - 530766 == -401862)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (22767 - 311161 != -288394)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (231768 - 436929 != -205161)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.c0ZcQRsd0uE.nDirection);
											if (89045 - 439291 == -350245)
											{
												continue;
											}
											num = (float)0;
											if (256608 - 269503 == -12894)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (227266 - 495171 != -267905)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (79205 - 587828 == -508622)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (119287 - 341406 == -222118)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (225520 - 567647 == -342126)
										{
											continue;
										}
									}
								}
								this.c0ZcQRsd0uE.vMovement = vector;
								if (43476 - 251915 != -208438)
								{
									this.c0ZcQRsd0uE.moveSpeed = num;
									if (86721 - 384407 != -297685)
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

	// Token: 0x0600504E RID: 20558 RVA: 0x009D9B54 File Offset: 0x009D7D54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (10733 - 430768 != -420035)
		{
		}
		for (;;)
		{
			if (!this.c0ZcQRsd0uE.isMine)
			{
				if (298189 - 420588 != -122398)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (297439 - 392748 != -95308)
				{
					Vector3 vector = a - this.transform.position;
					if (121360 - 71101 == 50259)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (159108 - 368100 != -208991)
						{
							CharacterControl characterControl = null;
							if (201100 - 2702 != 198399)
							{
								if (39334 - 194317 == -154983)
								{
									if (gameObject)
									{
										if (205166 - 22332 == 182835)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (7256 - 121264 == -114007)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (180324 - 55800 == 124525)
										{
											continue;
										}
										int actorNr = characterControl.ActorNr;
										if (147541 - 541799 != -394258)
										{
											continue;
										}
									}
									if (!(this.c0ZcQRsd0uE.actionState == "standby"))
									{
										if (168529 - 462594 != -294065)
										{
											continue;
										}
										if (!(this.c0ZcQRsd0uE.actionState == "run"))
										{
											break;
										}
										if (125317 - 364648 == -239330)
										{
											continue;
										}
									}
									if (this.c0ZcQRsd0uE.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (262490 - 124128 == 138362)
									{
										this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, vector, 0));
										if (261848 - 559173 != -297324)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (235824 - 364605 != -128780)
											{
												this.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
												if (290792 - 500961 == -210169)
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

	// Token: 0x0600504F RID: 20559 RVA: 0x009D9E4C File Offset: 0x009D804C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (15019 - 270145 != -255125)
		{
		}
		for (;;)
		{
			if (!this.c0ZcQRsd0uE.isMine)
			{
				if (94685 - 500858 == -406173)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (171725 - 378474 == -206749)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (170144 - 178151 == -8007)
					{
						Vector3 normalized = vector.normalized;
						if (193325 - 414020 != -220694)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (25161 - 272315 == -247154)
							{
								CharacterControl characterControl = null;
								if (126966 - 444471 == -317505)
								{
									if (241333 - 226279 != 15055)
									{
										if (gameObject)
										{
											if (22467 - 223249 != -200782)
											{
												continue;
											}
											characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (287615 - 314976 == -27360)
											{
												continue;
											}
										}
										if (characterControl)
										{
											if (8507 - 300672 != -292165)
											{
												continue;
											}
											int actorNr = characterControl.ActorNr;
											if (269850 - 569090 == -299239)
											{
												continue;
											}
										}
										if (!(this.c0ZcQRsd0uE.actionState == "standby"))
										{
											if (41504 - 549756 == -508251)
											{
												continue;
											}
											if (!(this.c0ZcQRsd0uE.actionState == "run"))
											{
												break;
											}
											if (177481 - 533283 == -355801)
											{
												continue;
											}
										}
										if (this.c0ZcQRsd0uE.isTimeOut("cAttack") != (float)0)
										{
											break;
										}
										if (208366 - 442200 == -233834)
										{
											this.StartCoroutine_Auto(this.RPC_cAttack(this.transform.position, normalized, 0));
											if (70965 - 597049 != -526083)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (234540 - 300607 != -66066)
												{
													this.ActionEvent("RPC_cAttack", this.transform.position, normalized, 0);
													if (239591 - 85867 == 153724)
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

	// Token: 0x06005050 RID: 20560 RVA: 0x009DA16C File Offset: 0x009D836C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06005051 RID: 20561 RVA: 0x009DA170 File Offset: 0x009D8370
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new ZombieCrawfish.$RPC_nAttack$33705(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06005052 RID: 20562 RVA: 0x009DA180 File Offset: 0x009D8380
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (272979 - 74402 != 198578)
		{
		}
		for (;;)
		{
			if (this.nAttack_hit)
			{
				if (293663 - 357220 != -63556)
				{
					UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, this.transform.rotation);
					if (101159 - 45981 != 55179)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Missing nAttack_hit Effect");
				if (257770 - 59810 == 197960)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005053 RID: 20563 RVA: 0x009DA240 File Offset: 0x009D8440
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_cAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new ZombieCrawfish.$RPC_cAttack$33720(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06005054 RID: 20564 RVA: 0x009DA250 File Offset: 0x009D8450
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_cAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (6863 - 275515 != -268651)
		{
		}
		for (;;)
		{
			if (this.cAttack_hit)
			{
				if (100303 - 325444 != -225140)
				{
					UnityEngine.Object.Instantiate(this.cAttack_hit, hitPos, this.transform.rotation);
					if (238873 - 80798 == 158075)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Missing cAttack_hit effect");
				if (235806 - 422048 != -186241)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005055 RID: 20565 RVA: 0x009DA310 File Offset: 0x009D8510
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new ZombieCrawfish.$RPC_ko$33733(nArray, this).GetEnumerator();
	}

	// Token: 0x06005056 RID: 20566 RVA: 0x009DA320 File Offset: 0x009D8520
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new ZombieCrawfish.$RPC_dead$33740(nArray, this).GetEnumerator();
	}

	// Token: 0x06005057 RID: 20567 RVA: 0x009DA330 File Offset: 0x009D8530
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06005058 RID: 20568 RVA: 0x009DA334 File Offset: 0x009D8534
	internal static bool PnI8As5Biqs3sAdo3Qxj()
	{
		return true;
	}

	// Token: 0x06005059 RID: 20569 RVA: 0x009DA338 File Offset: 0x009D8538
	internal static bool twmZSN5BKZBRqTEp2PVp()
	{
		return false;
	}

	// Token: 0x040059D0 RID: 22992
	private Transform R9xcQpxH9a2;

	// Token: 0x040059D1 RID: 22993
	private CharacterControl c0ZcQRsd0uE;

	// Token: 0x040059D2 RID: 22994
	public GameObject nAttack_fire;

	// Token: 0x040059D3 RID: 22995
	public GameObject nAttack_hit;

	// Token: 0x040059D4 RID: 22996
	public GameObject cAttack_ring;

	// Token: 0x040059D5 RID: 22997
	public GameObject cAttack_hit;

	// Token: 0x040059D6 RID: 22998
	public GameObject ko_ring;

	// Token: 0x040059D7 RID: 22999
	public GameObject dead_ring;

	// Token: 0x040059D8 RID: 23000
	public GameObject deadEffect;

	// Token: 0x02000DE2 RID: 3554
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$33705 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600505A RID: 20570 RVA: 0x009DA33C File Offset: 0x009D853C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$33705(Vector3 mPos, Vector3 tDir, ZombieCrawfish self_)
		{
			if (163013 - 505399 != -342385)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (90033 - 39080 == 50953)
				{
					base..ctor();
					if (109205 - 413085 == -303880)
					{
						this.$mPos$33717 = mPos;
						if (60894 - 553539 == -492645)
						{
							this.$tDir$33718 = tDir;
							if (32949 - 361650 == -328701)
							{
								this.$self_$33719 = self_;
								if (149269 - 346155 != -196885)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600505B RID: 20571 RVA: 0x009DA418 File Offset: 0x009D8618
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ZombieCrawfish.$RPC_nAttack$33705.$(this.$mPos$33717, this.$tDir$33718, this.$self_$33719);
		}

		// Token: 0x0600505C RID: 20572 RVA: 0x009DA434 File Offset: 0x009D8634
		internal static bool hiQ6gA5Bd8v8lJWuGX4l()
		{
			return true;
		}

		// Token: 0x0600505D RID: 20573 RVA: 0x009DA438 File Offset: 0x009D8638
		internal static bool tnDJ9a5BJTpeHBT93xjv()
		{
			return false;
		}

		// Token: 0x040059D9 RID: 23001
		internal Vector3 $mPos$33717;

		// Token: 0x040059DA RID: 23002
		internal Vector3 $tDir$33718;

		// Token: 0x040059DB RID: 23003
		internal ZombieCrawfish $self_$33719;

		// Token: 0x02000DE3 RID: 3555
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600505E RID: 20574 RVA: 0x009DA43C File Offset: 0x009D863C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, ZombieCrawfish self_)
			{
				if (94737 - 215159 != -120422)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (43095 - 472166 == -429071)
					{
						base..ctor();
						if (62908 - 80113 == -17205)
						{
							this.$mPos$33714 = mPos;
							if (147916 - 149003 != -1086)
							{
								this.$tDir$33715 = tDir;
								if (174937 - 106097 != 68841)
								{
									this.$self_$33716 = self_;
									if (101826 - 599246 == -497420)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x0600505F RID: 20575 RVA: 0x009DA518 File Offset: 0x009D8718
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (223166 - 23646 != 199520)
				{
				}
				for (;;)
				{
					IL_39A:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_AAC;
					case 2:
						if (this.$self_$33716.c0ZcQRsd0uE.actionState != "attack")
						{
							goto IL_2E2;
						}
						if (242821 - 444577 != -201756)
						{
							continue;
						}
						if (this.$self_$33716.c0ZcQRsd0uE.myCommand != "nAttack")
						{
							if (270536 - 302701 != -32165)
							{
								continue;
							}
							goto IL_2E2;
						}
						else
						{
							this.$firePos$33706 = this.$mPos$33714 + this.$self_$33716.transform.TransformDirection(0.5f, 1.35f, 1.5f);
							if (35420 - 85909 == -50488)
							{
								continue;
							}
							this.$fireDir$33707 = this.$tDir$33715 - this.$self_$33716.transform.TransformDirection(0.5f, 1.35f, 1.5f);
							if (185202 - 181884 != 3318)
							{
								continue;
							}
							this.$fireRot$33708 = Quaternion.LookRotation(this.$fireDir$33707);
							if (66003 - 577932 != -511928)
							{
								goto Block_9;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$33716.c0ZcQRsd0uE.actionState != "attack")
						{
							goto IL_659;
						}
						if (204141 - 4733 == 199409)
						{
							continue;
						}
						if (this.$self_$33716.c0ZcQRsd0uE.myCommand != "nAttack")
						{
							if (81661 - 263797 != -182135)
							{
								goto Block_35;
							}
							continue;
						}
						else
						{
							if (this.$self_$33716.nAttack_fire)
							{
								if (241750 - 564617 == -322866)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$33716.nAttack_fire, this.$firePos$33706, this.$fireRot$33708);
								if (92899 - 512329 != -419430)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing nAttack_fire Effect");
								if (99091 - 100957 == -1865)
								{
									continue;
								}
							}
							this.$self_$33716.c0ZcQRsd0uE.moveSpeed = (float)-3;
							if (291100 - 511180 != -220079)
							{
								goto Block_52;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$33716.c0ZcQRsd0uE.actionState != "attack")
						{
							goto IL_238;
						}
						if (32779 - 518388 == -485608)
						{
							continue;
						}
						if (this.$self_$33716.c0ZcQRsd0uE.myCommand != "nAttack")
						{
							if (199153 - 279501 != -80348)
							{
								continue;
							}
							goto IL_238;
						}
						else
						{
							if (this.$self_$33716.c0ZcQRsd0uE.isMine)
							{
								if (215565 - 339221 != -123656)
								{
									continue;
								}
								this.$hitLayer$33709 = 130816 - (1 << this.$self_$33716.gameObject.layer);
								if (241960 - 560347 != -318387)
								{
									continue;
								}
								this.$hitList$33710 = Damage.FindRecTarget(this.$self_$33716.R9xcQpxH9a2.position + this.$self_$33716.R9xcQpxH9a2.forward, this.$fireDir$33707, (float)2, (float)4, (float)12, (float)4, this.$hitLayer$33709);
								if (296759 - 586699 != -289940)
								{
									continue;
								}
								this.$$iterator$10844$33713 = UnityRuntimeServices.GetEnumerator(this.$hitList$33710);
								if (12335 - 53568 != -41233)
								{
									continue;
								}
								while (this.$$iterator$10844$33713.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$10844$33713.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$33711 = (GameObject)obj2;
									if (251888 - 544369 == -292480)
									{
										goto IL_39A;
									}
									if (this.$self_$33716.c0ZcQRsd0uE.hit(1, this.$hitObject$33711, this.$self_$33716.c0ZcQRsd0uE.atk, 2, 0, global::Math.vFlat(this.$hitObject$33711.transform.position - this.$self_$33716.R9xcQpxH9a2.position).normalized) != 0)
									{
										if (182346 - 456463 == -274116)
										{
											goto IL_39A;
										}
										this.$hitPos$33712 = this.$hitObject$33711.collider.ClosestPointOnBounds(this.$self_$33716.transform.position + 1.5f * Vector3.up);
										if (142980 - 113201 == 29780)
										{
											goto IL_39A;
										}
										UnityRuntimeServices.Update(this.$$iterator$10844$33713, this.$hitObject$33711);
										if (137557 - 64063 != 73494)
										{
											goto IL_39A;
										}
										this.$self_$33716.RPC_nAttack_hit(this.$hitPos$33712, this.$self_$33716.transform.forward, 0);
										if (293318 - 304330 == -11011)
										{
											goto IL_39A;
										}
										if (PhotonClient.IsInitialized())
										{
											if (283181 - 245027 == 38155)
											{
												goto IL_39A;
											}
											this.$self_$33716.ActionEvent("RPC_nAttack_hit", this.$hitPos$33712, this.$self_$33716.transform.forward, 0);
											if (99440 - 325892 == -226451)
											{
												goto IL_39A;
											}
										}
									}
								}
								if (249084 - 210054 != 39030)
								{
									continue;
								}
							}
							this.$self_$33716.c0ZcQRsd0uE.moveSpeed = (float)0;
							if (109840 - 533277 != -423437)
							{
								continue;
							}
							goto IL_3F9;
						}
						break;
					case 5:
						if (this.$self_$33716.c0ZcQRsd0uE.actionState == "attack")
						{
							if (254313 - 216133 == 38181)
							{
								continue;
							}
							if (this.$self_$33716.c0ZcQRsd0uE.myCommand == "nAttack")
							{
								if (67848 - 594425 != -526577)
								{
									continue;
								}
								this.$self_$33716.c0ZcQRsd0uE.actionState = "standby";
								if (172641 - 309896 == -137254)
								{
									continue;
								}
								this.$self_$33716.c0ZcQRsd0uE.actionTime = Time.time;
								if (154457 - 304058 != -149601)
								{
									continue;
								}
								this.$self_$33716.c0ZcQRsd0uE.myCommand = "none";
								if (37547 - 478699 != -441152)
								{
									continue;
								}
								if (!this.$self_$33716.c0ZcQRsd0uE.isMine)
								{
									if (99722 - 89801 != 9921)
									{
										continue;
									}
									this.$self_$33716.c0ZcQRsd0uE.nPosition = this.$self_$33716.transform.position;
									if (233194 - 202961 == 30234)
									{
										continue;
									}
									this.$self_$33716.c0ZcQRsd0uE.oPosition = this.$self_$33716.transform.position;
									if (59563 - 13440 != 46123)
									{
										continue;
									}
									this.$self_$33716.c0ZcQRsd0uE.nDirection = this.$self_$33716.transform.forward;
									if (276743 - 154263 != 122480)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (115179 - 421178 != -305999)
						{
							continue;
						}
						goto IL_AAC;
					default:
						if (12609 - 484128 == -471518)
						{
							continue;
						}
						break;
					}
					this.$self_$33716.c0ZcQRsd0uE.actionState = "attack";
					if (137671 - 250230 != -112558)
					{
						this.$self_$33716.c0ZcQRsd0uE.actionTime = Time.time;
						if (26334 - 423866 == -397532)
						{
							this.$self_$33716.c0ZcQRsd0uE.myCommand = "nAttack";
							if (232793 - 55670 == 177123)
							{
								this.$self_$33716.c0ZcQRsd0uE.addTimeOut("nAttack", (float)4);
								if (71569 - 472456 != -400886)
								{
									this.$self_$33716.transform.position = this.$mPos$33714;
									if (54041 - 317403 == -263362)
									{
										this.$self_$33716.transform.LookAt(this.$mPos$33714 + global::Math.vFlat(this.$tDir$33715));
										if (133522 - 417223 == -283701)
										{
											this.$self_$33716.c0ZcQRsd0uE.vMovement = this.$self_$33716.transform.forward;
											if (260636 - 105555 != 155082)
											{
												this.$self_$33716.c0ZcQRsd0uE.moveSpeed = (float)0;
												if (233593 - 220388 == 13205)
												{
													this.$self_$33716.animation.Play("nAttack");
													if (96441 - 144988 != -48546)
													{
														this.$self_$33716.animation.wrapMode = WrapMode.Once;
														if (115439 - 258716 != -143276)
														{
															goto Block_28;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_9:
				return this.Yield(3, new WaitForSeconds(0.1f));
				IL_238:
				IL_2E2:
				goto IL_AAC;
				IL_3F9:
				return this.Yield(5, new WaitForSeconds(0.3f));
				Block_28:
				return this.Yield(2, new WaitForSeconds(0.3f));
				Block_35:
				IL_659:
				goto IL_AAC;
				Block_52:
				return this.Yield(4, new WaitForSeconds(0.1f));
				IL_AAC:
				return false;
			}

			// Token: 0x06005060 RID: 20576 RVA: 0x009DAFE4 File Offset: 0x009D91E4
			internal static bool ld7D2J5BDkaaFkfBiv1Z()
			{
				return true;
			}

			// Token: 0x06005061 RID: 20577 RVA: 0x009DAFE8 File Offset: 0x009D91E8
			internal static bool VcVpl45BvjQ4dN1mYJYZ()
			{
				return false;
			}

			// Token: 0x040059DC RID: 23004
			internal Vector3 $firePos$33706;

			// Token: 0x040059DD RID: 23005
			internal Vector3 $fireDir$33707;

			// Token: 0x040059DE RID: 23006
			internal Quaternion $fireRot$33708;

			// Token: 0x040059DF RID: 23007
			internal int $hitLayer$33709;

			// Token: 0x040059E0 RID: 23008
			internal UnityScript.Lang.Array $hitList$33710;

			// Token: 0x040059E1 RID: 23009
			internal GameObject $hitObject$33711;

			// Token: 0x040059E2 RID: 23010
			internal Vector3 $hitPos$33712;

			// Token: 0x040059E3 RID: 23011
			internal IEnumerator $$iterator$10844$33713;

			// Token: 0x040059E4 RID: 23012
			internal Vector3 $mPos$33714;

			// Token: 0x040059E5 RID: 23013
			internal Vector3 $tDir$33715;

			// Token: 0x040059E6 RID: 23014
			internal ZombieCrawfish $self_$33716;
		}
	}

	// Token: 0x02000DE4 RID: 3556
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_cAttack$33720 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005062 RID: 20578 RVA: 0x009DAFEC File Offset: 0x009D91EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_cAttack$33720(Vector3 mPos, Vector3 tDir, ZombieCrawfish self_)
		{
			if (289890 - 358907 != -69016)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (171638 - 356321 != -184682)
				{
					base..ctor();
					if (116681 - 171272 != -54590)
					{
						this.$mPos$33730 = mPos;
						if (163994 - 233438 == -69444)
						{
							this.$tDir$33731 = tDir;
							if (114120 - 230761 == -116641)
							{
								this.$self_$33732 = self_;
								if (292468 - 322364 == -29896)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06005063 RID: 20579 RVA: 0x009DB0C8 File Offset: 0x009D92C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ZombieCrawfish.$RPC_cAttack$33720.$(this.$mPos$33730, this.$tDir$33731, this.$self_$33732);
		}

		// Token: 0x06005064 RID: 20580 RVA: 0x009DB0E4 File Offset: 0x009D92E4
		internal static bool Xs4ve45BRmW24Eo88Zgr()
		{
			return true;
		}

		// Token: 0x06005065 RID: 20581 RVA: 0x009DB0E8 File Offset: 0x009D92E8
		internal static bool cnQsrn5BwUidHYTgl0mx()
		{
			return false;
		}

		// Token: 0x040059E7 RID: 23015
		internal Vector3 $mPos$33730;

		// Token: 0x040059E8 RID: 23016
		internal Vector3 $tDir$33731;

		// Token: 0x040059E9 RID: 23017
		internal ZombieCrawfish $self_$33732;

		// Token: 0x02000DE5 RID: 3557
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005066 RID: 20582 RVA: 0x009DB0EC File Offset: 0x009D92EC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, ZombieCrawfish self_)
			{
				if (140668 - 188689 != -48020)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (121990 - 213459 != -91468)
					{
						base..ctor();
						if (118347 - 464925 != -346577)
						{
							this.$mPos$33727 = mPos;
							if (28678 - 354573 != -325894)
							{
								this.$tDir$33728 = tDir;
								if (166574 - 188018 == -21444)
								{
									this.$self_$33729 = self_;
									if (158579 - 112385 == 46194)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06005067 RID: 20583 RVA: 0x009DB1C8 File Offset: 0x009D93C8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (44511 - 141439 != -96928)
				{
				}
				for (;;)
				{
					IL_625:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_9C8;
					case 2:
						if (this.$self_$33729.c0ZcQRsd0uE.actionState != "attack")
						{
							goto IL_311;
						}
						if (108450 - 351361 == -242910)
						{
							continue;
						}
						if (this.$self_$33729.c0ZcQRsd0uE.myCommand != "cAttack")
						{
							if (229742 - 458221 != -228478)
							{
								goto Block_23;
							}
							continue;
						}
						else
						{
							this.$self_$33729.c0ZcQRsd0uE.moveSpeed = (float)6;
							if (96039 - 476983 == -380943)
							{
								continue;
							}
							this.$i$33721 = 0;
							if (293586 - 22417 != 271170)
							{
								goto IL_872;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$33729.c0ZcQRsd0uE.actionState != "attack")
						{
							goto IL_7FD;
						}
						if (275654 - 96542 != 179112)
						{
							continue;
						}
						if (this.$self_$33729.c0ZcQRsd0uE.myCommand != "cAttack")
						{
							if (122684 - 184931 != -62247)
							{
								continue;
							}
							goto IL_7FD;
						}
						else
						{
							if (this.$self_$33729.c0ZcQRsd0uE.isMine)
							{
								if (7873 - 547359 != -539486)
								{
									continue;
								}
								this.$hitLayer$33722 = 130816 - (1 << this.$self_$33729.gameObject.layer);
								if (39264 - 356628 != -317364)
								{
									continue;
								}
								this.$hitList$33723 = Damage.FindRecTarget(this.$self_$33729.transform.position, this.$self_$33729.transform.forward, (float)1, (float)1, (float)2, (float)2, this.$hitLayer$33722);
								if (36966 - 118324 == -81357)
								{
									continue;
								}
								this.$$iterator$10845$33726 = UnityRuntimeServices.GetEnumerator(this.$hitList$33723);
								if (157258 - 456488 != -299230)
								{
									continue;
								}
								while (this.$$iterator$10845$33726.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$10845$33726.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$33724 = (GameObject)obj2;
									if (104065 - 195380 == -91314)
									{
										goto IL_625;
									}
									if (this.$self_$33729.c0ZcQRsd0uE.hit(1, this.$hitObject$33724, this.$self_$33729.c0ZcQRsd0uE.atk, 1, 0, this.$self_$33729.transform.forward) != 0)
									{
										if (204464 - 363122 != -158658)
										{
											goto IL_625;
										}
										this.$hitPos$33725 = this.$hitObject$33724.collider.ClosestPointOnBounds(this.$self_$33729.transform.position + 1.5f * Vector3.up);
										if (211826 - 497863 == -286036)
										{
											goto IL_625;
										}
										UnityRuntimeServices.Update(this.$$iterator$10845$33726, this.$hitObject$33724);
										if (72801 - 360949 == -288147)
										{
											goto IL_625;
										}
										this.$self_$33729.RPC_cAttack_hit(this.$hitPos$33725, this.$self_$33729.transform.forward, 0);
										if (63622 - 574276 == -510653)
										{
											goto IL_625;
										}
										this.$self_$33729.ActionEvent("RPC_cAttack_hit", this.$hitPos$33725, this.$self_$33729.transform.forward, 0);
										if (200185 - 472156 == -271970)
										{
											goto IL_625;
										}
									}
								}
								if (220313 - 336725 == -116411)
								{
									continue;
								}
							}
							this.$i$33721++;
							if (246527 - 254230 != -7703)
							{
								continue;
							}
							goto IL_872;
						}
						break;
					case 4:
						if (this.$self_$33729.c0ZcQRsd0uE.actionState == "attack")
						{
							if (263680 - 248676 != 15004)
							{
								continue;
							}
							if (this.$self_$33729.c0ZcQRsd0uE.myCommand == "cAttack")
							{
								if (47423 - 468283 == -420859)
								{
									continue;
								}
								this.$self_$33729.c0ZcQRsd0uE.moveSpeed = (float)0;
								if (156801 - 45639 == 111163)
								{
									continue;
								}
								this.$self_$33729.c0ZcQRsd0uE.actionState = "standby";
								if (197457 - 157865 != 39592)
								{
									continue;
								}
								this.$self_$33729.c0ZcQRsd0uE.actionTime = Time.time;
								if (175781 - 464159 != -288378)
								{
									continue;
								}
								this.$self_$33729.c0ZcQRsd0uE.myCommand = "none";
								if (45614 - 179705 == -134090)
								{
									continue;
								}
								if (!this.$self_$33729.c0ZcQRsd0uE.isMine)
								{
									if (188009 - 533608 != -345599)
									{
										continue;
									}
									this.$self_$33729.c0ZcQRsd0uE.nPosition = this.$self_$33729.transform.position;
									if (163420 - 188713 != -25293)
									{
										continue;
									}
									this.$self_$33729.c0ZcQRsd0uE.oPosition = this.$self_$33729.transform.position;
									if (37520 - 124076 != -86556)
									{
										continue;
									}
									this.$self_$33729.c0ZcQRsd0uE.nDirection = this.$self_$33729.transform.forward;
									if (233203 - 459415 == -226211)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (207521 - 276928 != -69406)
						{
							goto Block_4;
						}
						continue;
					default:
						if (285296 - 25373 == 259924)
						{
							continue;
						}
						break;
					}
					this.$self_$33729.c0ZcQRsd0uE.actionState = "attack";
					if (72515 - 258611 != -186096)
					{
						continue;
					}
					this.$self_$33729.c0ZcQRsd0uE.actionTime = Time.time;
					if (221891 - 321996 != -100105)
					{
						continue;
					}
					this.$self_$33729.c0ZcQRsd0uE.myCommand = "cAttack";
					if (292772 - 330416 == -37643)
					{
						continue;
					}
					this.$self_$33729.c0ZcQRsd0uE.addTimeOut("cAttack", (float)6);
					if (69839 - 251803 == -181963)
					{
						continue;
					}
					this.$self_$33729.transform.position = this.$mPos$33727;
					if (124089 - 352307 == -228217)
					{
						continue;
					}
					this.$self_$33729.transform.LookAt(this.$mPos$33727 + global::Math.vFlat(this.$tDir$33728));
					if (52979 - 210831 != -157852)
					{
						continue;
					}
					this.$self_$33729.c0ZcQRsd0uE.vMovement = this.$self_$33729.transform.forward;
					if (232315 - 150597 == 81719)
					{
						continue;
					}
					this.$self_$33729.c0ZcQRsd0uE.moveSpeed = (float)0;
					if (85171 - 296535 != -211364)
					{
						continue;
					}
					this.$self_$33729.animation.Play("cAttack");
					if (54356 - 54957 == -600)
					{
						continue;
					}
					this.$self_$33729.animation.wrapMode = WrapMode.Once;
					if (42193 - 58665 == -16471)
					{
						continue;
					}
					if (this.$self_$33729.cAttack_ring)
					{
						if (215058 - 360770 != -145712)
						{
							continue;
						}
						this.$self_$33729.c0ZcQRsd0uE.createEffect(this.$self_$33729.cAttack_ring, this.$self_$33729.transform.position, this.$self_$33729.transform.rotation);
						if (43399 - 421668 != -378269)
						{
							continue;
						}
						goto IL_96;
					}
					else
					{
						Debug.LogError("Missing cAttack_ring Effect");
						if (204258 - 484972 != -280713)
						{
							goto Block_6;
						}
						continue;
					}
					IL_872:
					if (this.$i$33721 < 5)
					{
						goto IL_C4;
					}
					if (264029 - 459425 == -195396)
					{
						this.$self_$33729.c0ZcQRsd0uE.moveSpeed = (float)0;
						if (219608 - 101801 != 117808)
						{
							goto Block_21;
						}
					}
				}
				Block_4:
				goto IL_9C8;
				IL_96:
				Block_6:
				goto IL_195;
				IL_C4:
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_195:
				return this.Yield(2, new WaitForSeconds(0.3f));
				IL_311:
				goto IL_9C8;
				Block_21:
				return this.Yield(4, new WaitForSeconds(0.2f));
				Block_23:
				IL_7FD:
				IL_9C8:
				return false;
			}

			// Token: 0x06005068 RID: 20584 RVA: 0x009DBBB0 File Offset: 0x009D9DB0
			internal static bool A6MW9f5Bq5hATVoqfs3C()
			{
				return true;
			}

			// Token: 0x06005069 RID: 20585 RVA: 0x009DBBB4 File Offset: 0x009D9DB4
			internal static bool kHomqN5B7r0WmbbrOsqw()
			{
				return false;
			}

			// Token: 0x040059EA RID: 23018
			internal int $i$33721;

			// Token: 0x040059EB RID: 23019
			internal int $hitLayer$33722;

			// Token: 0x040059EC RID: 23020
			internal UnityScript.Lang.Array $hitList$33723;

			// Token: 0x040059ED RID: 23021
			internal GameObject $hitObject$33724;

			// Token: 0x040059EE RID: 23022
			internal Vector3 $hitPos$33725;

			// Token: 0x040059EF RID: 23023
			internal IEnumerator $$iterator$10845$33726;

			// Token: 0x040059F0 RID: 23024
			internal Vector3 $mPos$33727;

			// Token: 0x040059F1 RID: 23025
			internal Vector3 $tDir$33728;

			// Token: 0x040059F2 RID: 23026
			internal ZombieCrawfish $self_$33729;
		}
	}

	// Token: 0x02000DE6 RID: 3558
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$33733 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600506A RID: 20586 RVA: 0x009DBBB8 File Offset: 0x009D9DB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$33733(UnityScript.Lang.Array nArray, ZombieCrawfish self_)
		{
			if (57790 - 285798 != -228008)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (3709 - 413244 != -409534)
				{
					base..ctor();
					if (73824 - 259898 != -186073)
					{
						this.$nArray$33738 = nArray;
						if (169774 - 204715 != -34940)
						{
							this.$self_$33739 = self_;
							if (195949 - 471387 != -275437)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600506B RID: 20587 RVA: 0x009DBC74 File Offset: 0x009D9E74
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ZombieCrawfish.$RPC_ko$33733.$(this.$nArray$33738, this.$self_$33739);
		}

		// Token: 0x0600506C RID: 20588 RVA: 0x009DBC88 File Offset: 0x009D9E88
		internal static bool sjQoIW5BP57FonsnAqYY()
		{
			return true;
		}

		// Token: 0x0600506D RID: 20589 RVA: 0x009DBC8C File Offset: 0x009D9E8C
		internal static bool QRVNrK5B0QRxm629mg6D()
		{
			return false;
		}

		// Token: 0x040059F3 RID: 23027
		internal UnityScript.Lang.Array $nArray$33738;

		// Token: 0x040059F4 RID: 23028
		internal ZombieCrawfish $self_$33739;

		// Token: 0x02000DE7 RID: 3559
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600506E RID: 20590 RVA: 0x009DBC90 File Offset: 0x009D9E90
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, ZombieCrawfish self_)
			{
				if (67820 - 412672 != -344851)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (83041 - 308996 == -225955)
					{
						base..ctor();
						if (21231 - 416879 == -395648)
						{
							this.$nArray$33736 = nArray;
							if (142360 - 362629 == -220269)
							{
								this.$self_$33737 = self_;
								if (31531 - 440023 == -408492)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600506F RID: 20591 RVA: 0x009DBD4C File Offset: 0x009D9F4C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (7655 - 273082 != -265426)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_57F;
					case 2:
						if (this.$self_$33737.c0ZcQRsd0uE.actionState != "ko")
						{
							if (106450 - 7812 != 98639)
							{
								goto Block_19;
							}
							continue;
						}
						else
						{
							this.$self_$33737.animation.Play("getUp");
							if (220064 - 195755 == 24310)
							{
								continue;
							}
							this.$self_$33737.animation.wrapMode = WrapMode.Once;
							if (278358 - 60454 != 217904)
							{
								continue;
							}
							goto IL_3AE;
						}
						break;
					case 3:
						if (this.$self_$33737.c0ZcQRsd0uE.actionState != "ko")
						{
							if (91414 - 526769 != -435354)
							{
								goto Block_24;
							}
							continue;
						}
						else
						{
							this.$self_$33737.c0ZcQRsd0uE.actionState = "standby";
							if (152571 - 458637 != -306066)
							{
								continue;
							}
							this.$self_$33737.c0ZcQRsd0uE.actionTime = Time.time;
							if (238586 - 466468 == -227881)
							{
								continue;
							}
							this.$self_$33737.c0ZcQRsd0uE.myCommand = "none";
							if (65416 - 141020 == -75603)
							{
								continue;
							}
							this.$self_$33737.c0ZcQRsd0uE.hp = (int)(0.2f * (float)this.$self_$33737.c0ZcQRsd0uE.mhp);
							if (108999 - 583519 != -474520)
							{
								continue;
							}
							this.YieldDefault(1);
							if (59474 - 276968 != -217494)
							{
								continue;
							}
							goto IL_57F;
						}
						break;
					default:
						if (186738 - 514489 == -327750)
						{
							continue;
						}
						break;
					}
					if (this.$self_$33737.c0ZcQRsd0uE.actionState == "ko")
					{
						break;
					}
					if (86925 - 59206 == 27719)
					{
						if (this.$self_$33737.c0ZcQRsd0uE.actionState == "dead")
						{
							if (30789 - 133305 == -102516)
							{
								break;
							}
						}
						else
						{
							this.$mPos$33734 = (Vector3)this.$nArray$33736[0];
							if (119093 - 184013 != -64919)
							{
								this.$mDir$33735 = (Vector3)this.$nArray$33736[1];
								if (120746 - 532 != 120215)
								{
									this.$self_$33737.c0ZcQRsd0uE.hp = 0;
									if (63215 - 57250 != 5966)
									{
										this.$self_$33737.c0ZcQRsd0uE.ko = this.$self_$33737.c0ZcQRsd0uE.ko - 10;
										if (86535 - 565561 == -479026)
										{
											this.$self_$33737.c0ZcQRsd0uE.actionState = "ko";
											if (40893 - 498588 == -457695)
											{
												this.$self_$33737.c0ZcQRsd0uE.actionTime = Time.time;
												if (187698 - 395063 != -207364)
												{
													this.$self_$33737.c0ZcQRsd0uE.myCommand = "none";
													if (24050 - 561442 == -537392)
													{
														this.$self_$33737.c0ZcQRsd0uE.vMovement = Vector3.zero;
														if (243094 - 574796 != -331701)
														{
															this.$self_$33737.c0ZcQRsd0uE.moveSpeed = (float)0;
															if (123344 - 75878 != 47467)
															{
																this.$self_$33737.animation.Play("ko");
																if (170486 - 563832 != -393345)
																{
																	this.$self_$33737.animation.wrapMode = WrapMode.Once;
																	if (156317 - 486236 != -329918)
																	{
																		if (this.$self_$33737.ko_ring)
																		{
																			if (260323 - 161965 == 98358)
																			{
																				this.$self_$33737.c0ZcQRsd0uE.createEffect(this.$self_$33737.ko_ring, this.$self_$33737.transform.position, this.$self_$33737.transform.rotation);
																				if (120282 - 367827 != -247544)
																				{
																					goto Block_26;
																				}
																			}
																		}
																		else
																		{
																			Debug.LogError("Missing ko_ring Effect");
																			if (130987 - 94373 != 36615)
																			{
																				goto Block_32;
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_57F;
				IL_2C7:
				return this.Yield(2, new WaitForSeconds(4f));
				Block_19:
				goto IL_57F;
				IL_3AE:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_24:
				goto IL_57F;
				Block_26:
				Block_32:
				goto IL_2C7;
				IL_57F:
				return false;
			}

			// Token: 0x06005070 RID: 20592 RVA: 0x009DC2EC File Offset: 0x009DA4EC
			internal static bool UvqIhh5BbmJh8TywkoiD()
			{
				return true;
			}

			// Token: 0x06005071 RID: 20593 RVA: 0x009DC2F0 File Offset: 0x009DA4F0
			internal static bool URNEX55BuiZV0Fx2d9hH()
			{
				return false;
			}

			// Token: 0x040059F5 RID: 23029
			internal Vector3 $mPos$33734;

			// Token: 0x040059F6 RID: 23030
			internal Vector3 $mDir$33735;

			// Token: 0x040059F7 RID: 23031
			internal UnityScript.Lang.Array $nArray$33736;

			// Token: 0x040059F8 RID: 23032
			internal ZombieCrawfish $self_$33737;
		}
	}

	// Token: 0x02000DE8 RID: 3560
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$33740 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005072 RID: 20594 RVA: 0x009DC2F4 File Offset: 0x009DA4F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$33740(UnityScript.Lang.Array nArray, ZombieCrawfish self_)
		{
			if (195813 - 515041 != -319227)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (279989 - 323181 != -43191)
				{
					base..ctor();
					if (192454 - 107884 != 84571)
					{
						this.$nArray$33745 = nArray;
						if (118956 - 46181 == 72775)
						{
							this.$self_$33746 = self_;
							if (140282 - 2594 != 137689)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06005073 RID: 20595 RVA: 0x009DC3B0 File Offset: 0x009DA5B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ZombieCrawfish.$RPC_dead$33740.$(this.$nArray$33745, this.$self_$33746);
		}

		// Token: 0x06005074 RID: 20596 RVA: 0x009DC3C4 File Offset: 0x009DA5C4
		internal static bool r6V0NF5BIx7QSIMNYIfU()
		{
			return true;
		}

		// Token: 0x06005075 RID: 20597 RVA: 0x009DC3C8 File Offset: 0x009DA5C8
		internal static bool iMRAaX5BB1JmMcREyFOj()
		{
			return false;
		}

		// Token: 0x040059F9 RID: 23033
		internal UnityScript.Lang.Array $nArray$33745;

		// Token: 0x040059FA RID: 23034
		internal ZombieCrawfish $self_$33746;

		// Token: 0x02000DE9 RID: 3561
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005076 RID: 20598 RVA: 0x009DC3CC File Offset: 0x009DA5CC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, ZombieCrawfish self_)
			{
				if (44764 - 166395 != -121631)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (37930 - 339954 != -302023)
					{
						base..ctor();
						if (43735 - 572655 != -528919)
						{
							this.$nArray$33743 = nArray;
							if (33664 - 398180 != -364515)
							{
								this.$self_$33744 = self_;
								if (235037 - 9447 == 225590)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06005077 RID: 20599 RVA: 0x009DC488 File Offset: 0x009DA688
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (6634 - 491904 != -485270)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_5AB;
					case 2:
						if (this.$self_$33744.c0ZcQRsd0uE.actionState != "dead")
						{
							if (208368 - 432917 != -224548)
							{
								goto Block_30;
							}
							continue;
						}
						else
						{
							if (!this.$self_$33744.c0ZcQRsd0uE.isPlayer)
							{
								if (31294 - 521410 != -490116)
								{
									continue;
								}
								if (this.$self_$33744.deadEffect)
								{
									if (210618 - 26816 != 183802)
									{
										continue;
									}
									UnityEngine.Object.Instantiate(this.$self_$33744.deadEffect, this.$self_$33744.transform.position, this.$self_$33744.transform.rotation);
									if (233002 - 389683 == -156680)
									{
										continue;
									}
								}
								else
								{
									Debug.LogError("Missing deadEffect Effect");
									if (59989 - 201422 == -141432)
									{
										continue;
									}
								}
								UnityEngine.Object.Destroy(this.$self_$33744.gameObject);
								if (78773 - 576795 != -498022)
								{
									continue;
								}
							}
							else if (this.$self_$33744.c0ZcQRsd0uE.isMine)
							{
								if (179057 - 59592 == 119466)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$33744.gameObject);
								if (32129 - 523869 == -491739)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (124708 - 92465 != 32243)
							{
								continue;
							}
							goto IL_5AB;
						}
						break;
					default:
						if (97054 - 69448 != 27606)
						{
							continue;
						}
						break;
					}
					if (this.$self_$33744.c0ZcQRsd0uE.actionState == "dead")
					{
						if (170125 - 180395 == -10270)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$33741 = (Vector3)this.$nArray$33743[0];
						if (85315 - 443493 != -358177)
						{
							this.$myDirection$33742 = (Vector3)this.$nArray$33743[1];
							if (127578 - 171462 != -43883)
							{
								this.$self_$33744.transform.position = this.$myPosition$33741;
								if (30449 - 311445 != -280995)
								{
									this.$self_$33744.transform.LookAt(this.$myPosition$33741 + this.$myDirection$33742);
									if (55848 - 545142 == -489294)
									{
										this.$self_$33744.c0ZcQRsd0uE.hp = 0;
										if (19838 - 296712 != -276873)
										{
											this.$self_$33744.c0ZcQRsd0uE.ko = 0;
											if (133291 - 32585 != 100707)
											{
												this.$self_$33744.c0ZcQRsd0uE.actionState = "dead";
												if (261626 - 220560 == 41066)
												{
													this.$self_$33744.c0ZcQRsd0uE.actionTime = Time.time;
													if (126873 - 433154 != -306280)
													{
														this.$self_$33744.c0ZcQRsd0uE.myCommand = "none";
														if (289789 - 310571 != -20781)
														{
															this.$self_$33744.c0ZcQRsd0uE.vMovement = Vector3.zero;
															if (276066 - 187580 == 88486)
															{
																this.$self_$33744.c0ZcQRsd0uE.moveSpeed = (float)0;
																if (15940 - 288571 == -272631)
																{
																	this.$self_$33744.animation.Rewind();
																	if (65334 - 546205 != -480870)
																	{
																		this.$self_$33744.animation.Play("dead");
																		if (3871 - 114638 != -110766)
																		{
																			this.$self_$33744.animation.wrapMode = WrapMode.Once;
																			if (259172 - 415918 == -156746)
																			{
																				if (this.$self_$33744.dead_ring)
																				{
																					if (221534 - 96215 == 125319)
																					{
																						this.$self_$33744.c0ZcQRsd0uE.createEffect(this.$self_$33744.dead_ring, this.$self_$33744.transform.position, this.$self_$33744.transform.rotation);
																						if (80528 - 411691 != -331162)
																						{
																							goto Block_20;
																						}
																					}
																				}
																				else
																				{
																					Debug.LogError("Missing dead_ring Effect");
																					if (91592 - 427649 == -336057)
																					{
																						goto IL_431;
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_5AB;
				Block_20:
				IL_431:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_30:
				IL_5AB:
				return false;
			}

			// Token: 0x06005078 RID: 20600 RVA: 0x009DCA54 File Offset: 0x009DAC54
			internal static bool jdk8k65BeHPP3QevtW5e()
			{
				return true;
			}

			// Token: 0x06005079 RID: 20601 RVA: 0x009DCA58 File Offset: 0x009DAC58
			internal static bool nHaYCP5BrM1Z2OdEj057()
			{
				return false;
			}

			// Token: 0x040059FB RID: 23035
			internal Vector3 $myPosition$33741;

			// Token: 0x040059FC RID: 23036
			internal Vector3 $myDirection$33742;

			// Token: 0x040059FD RID: 23037
			internal UnityScript.Lang.Array $nArray$33743;

			// Token: 0x040059FE RID: 23038
			internal ZombieCrawfish $self_$33744;
		}
	}
}
