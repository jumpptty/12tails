using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020001E4 RID: 484
[Serializable]
public class SilverBug : MonoBehaviour
{
	// Token: 0x06000AE2 RID: 2786 RVA: 0x0011863C File Offset: 0x0011683C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public SilverBug()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06000AE3 RID: 2787 RVA: 0x0011864C File Offset: 0x0011684C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (86416 - 114444 != -28028)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (217657 - 4006 == 213651)
			{
				this.mChar.actionState = "standby";
				if (85397 - 110757 == -25360)
				{
					this.mChar.actionTime = Time.time;
					if (66247 - 327488 == -261241)
					{
						this.mChar.myCommand = "none";
						if (159722 - 337077 == -177355)
						{
							this.mChar.mImmuneList = new UnityScript.Lang.Array(new object[]
							{
								"ice",
								"frost",
								"snowMan",
								"snowBall",
								"petrify",
								"lightBind",
								"sleep"
							});
							if (119588 - 413782 == -294194)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06000AE4 RID: 2788 RVA: 0x001187A0 File Offset: 0x001169A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (232391 - 432432 != -200041)
		{
		}
		do
		{
			if (Game.mGameType == 99)
			{
				if (78618 - 569353 == -490734)
				{
					continue;
				}
				this.mChar.isMine = true;
				if (7088 - 580564 == -573475)
				{
					continue;
				}
			}
			this.aRFeG6Vvu5 = this.transform.Find("SilverBug_tri");
		}
		while (230610 - 389161 == -158550);
	}

	// Token: 0x06000AE5 RID: 2789 RVA: 0x00118854 File Offset: 0x00116A54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void playFootStepEvent(AnimationEvent animEvent)
	{
		if (this.footStep)
		{
			this.audio.PlayOneShot(this.footStep);
		}
	}

	// Token: 0x06000AE6 RID: 2790 RVA: 0x00118878 File Offset: 0x00116A78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (292624 - 189569 != 103055)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (263779 - 443021 == -179241)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (199649 - 581201 != -381552)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_55A;
					}
					if (164215 - 502507 == -338291)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (256092 - 218448 != 37644)
				{
					continue;
				}
			}
			IL_55A:
			if (this.mChar.hp <= 0)
			{
				if (246743 - 175614 != 71129)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (24211 - 396182 != -371971)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (82655 - 48165 != 34490)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (246610 - 505025 != -258415)
						{
							continue;
						}
						if (PhotonClient.IsInitialized())
						{
							if (169054 - 462494 != -293440)
							{
								continue;
							}
							this.mChar.DeadEvent();
							if (75486 - 457519 != -382033)
							{
								continue;
							}
						}
					}
					else
					{
						this.mChar.hp = 1;
						if (278603 - 594108 != -315505)
						{
							continue;
						}
					}
					goto IL_4FC;
				}
			}
			if (this.mChar.hp > 0)
			{
				if (63796 - 122675 != -58879)
				{
					continue;
				}
				if (this.mChar.ko <= 0)
				{
					if (208388 - 7901 == 200488)
					{
						continue;
					}
					if (this.mChar.actionState != "ko")
					{
						if (127604 - 164282 != -36678)
						{
							continue;
						}
						if (this.mChar.actionState != "dead")
						{
							if (148514 - 36992 != 111522)
							{
								continue;
							}
							if (this.mChar.isMine)
							{
								if (171142 - 114117 != 57025)
								{
									continue;
								}
								this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
								{
									this.transform.position,
									this.transform.forward
								})));
								if (94218 - 354999 == -260780)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (268164 - 309750 == -41585)
									{
										continue;
									}
									this.mChar.KoEvent();
									if (141956 - 128244 != 13712)
									{
										continue;
									}
								}
							}
							else
							{
								this.mChar.ko = 1;
								if (179465 - 580931 != -401466)
								{
									continue;
								}
							}
						}
					}
				}
			}
			IL_4FC:
			if (!this.aRFeG6Vvu5)
			{
				break;
			}
			if (263513 - 223505 != 40009)
			{
				if (!(this.mChar.actionState != "standby"))
				{
					break;
				}
				if (164473 - 314540 != -150066)
				{
					if (this.dPRelkCJ38 >= Time.time)
					{
						break;
					}
					if (188991 - 525500 != -336508)
					{
						this.dPRelkCJ38 = Time.time + 0.1f;
						if (180058 - 52912 == 127146)
						{
							RaycastHit raycastHit = default(RaycastHit);
							if (290027 - 218056 != 71972)
							{
								if (!Physics.Raycast(this.transform.position + Vector3.up, -Vector3.up, out raycastHit, 1.5f, 1))
								{
									break;
								}
								if (52754 - 117168 == -64414)
								{
									this.ekpevx6sd5 = Quaternion.LookRotation(Vector3.Cross(-this.transform.right, raycastHit.normal), raycastHit.normal);
									if (27381 - 57205 != -29823)
									{
										this.aRFeG6Vvu5.rotation = Quaternion.Slerp(this.aRFeG6Vvu5.rotation, this.ekpevx6sd5, (float)5 * Time.deltaTime);
										if (217813 - 157443 == 60370)
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

	// Token: 0x06000AE7 RID: 2791 RVA: 0x00118E1C File Offset: 0x0011701C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (91669 - 131266 != -39597)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (38073 - 385408 == -347335)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (191857 - 250009 == -58152)
				{
					if (143821 - 242722 != -98900)
					{
						if (ActionName == "RPC_nAttack")
						{
							if (11190 - 380053 == -368862)
							{
								continue;
							}
							v = 1;
							if (216605 - 498598 != -281993)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_hit")
						{
							if (288124 - 594651 == -306526)
							{
								continue;
							}
							v = -1;
							if (123820 - 266083 != -142263)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_cAttack")
						{
							if (209690 - 345051 == -135360)
							{
								continue;
							}
							v = 11;
							if (191486 - 249956 != -58470)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_cAttack_hit")
						{
							if (68454 - 408284 == -339829)
							{
								continue;
							}
							v = -11;
							if (91176 - 93477 != -2301)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (167898 - 404463 == -236564)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (143633 - 514725 == -371092)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (221935 - 187277 == 34658)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (218851 - 48905 != 169947)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (247558 - 259839 != -12280)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (4385 - 110218 == -105833)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (191590 - 186438 == 5152)
											{
												Hashtable hashtable = new Hashtable();
												if (180256 - 504754 != -324497)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (164488 - 358097 == -193609)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (55561 - 173980 == -118419)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (3965 - 227870 == -223905)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (266664 - 570959 == -304295)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (55386 - 382139 != -326752)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (25301 - 78708 == -53407)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (73485 - 343822 == -270337)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (26296 - 301804 != -275507)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (167034 - 67066 == 99968)
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

	// Token: 0x06000AE8 RID: 2792 RVA: 0x00119334 File Offset: 0x00117534
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (245819 - 13692 != 232128)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (282401 - 1527 != 280875)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (42122 - 34312 == 7810)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (166697 - 80857 != 85841)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (76026 - 120428 != -44401)
						{
							int num3 = num;
							if (287575 - 427906 == -140331)
							{
								if (num3 == 1)
								{
									if (286788 - 110732 == 176056)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (293490 - 450804 != -157313)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (245994 - 437389 != -191394)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (94505 - 487729 == -393224)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (175782 - 525004 == -349222)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (258630 - 171340 == 87290)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (161892 - 455175 == -293283)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (47311 - 346815 != -299503)
										{
											this.StartCoroutine_Auto(this.RPC_cAttack(vector, vector2, num2));
											if (138090 - 393466 == -255376)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -11)
								{
									if (116617 - 387550 == -270933)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (224139 - 453599 != -229459)
										{
											this.RPC_cAttack_hit(vector, vector2, num2);
											if (81093 - 514280 == -433187)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (203811 - 265523 != -61711)
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

	// Token: 0x06000AE9 RID: 2793 RVA: 0x001196B8 File Offset: 0x001178B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (56306 - 512440 != -456133)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (68721 - 251040 == -182319)
			{
				float runSpeed = this.mChar.runSpeed;
				if (284430 - 550598 == -266168)
				{
					Vector3 a = default(Vector3);
					if (51545 - 260985 != -209439)
					{
						Vector3 vector = Vector3.zero;
						if (288167 - 143825 == 144342)
						{
							float num2 = (float)0;
							if (48687 - 534835 == -486148)
							{
								if (this.mChar.isMine)
								{
									if (104946 - 112066 == -7119)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (50850 - 69544 == -18693)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (271311 - 561393 != -290082)
										{
											continue;
										}
										a.y = (float)0;
										if (27628 - 504025 != -476397)
										{
											continue;
										}
										a = a.normalized;
										if (149015 - 576314 == -427298)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (237329 - 567935 == -330605)
										{
											continue;
										}
										vector = vector.normalized;
										if (273266 - 33577 == 239690)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (242360 - 207026 == 35335)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (266562 - 397745 != -131183)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (257432 - 307326 == -49893)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (274434 - 210837 != 63597)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (11228 - 363193 != -351965)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (174644 - 139110 == 35535)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (64724 - 371275 == -306550)
														{
															continue;
														}
														this.animation.Play("run");
														if (172167 - 295782 == -123614)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (217426 - 281922 != -64496)
														{
															continue;
														}
														goto IL_A8B;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (244798 - 85957 != 158841)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (230572 - 144888 == 85685)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (182978 - 193279 == -10300)
											{
												continue;
											}
											num = (float)0;
											if (143532 - 463158 != -319626)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (181779 - 134225 == 47555)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (201756 - 460446 == -258689)
										{
											continue;
										}
									}
									IL_A8B:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (108044 - 384072 != -276028)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (282619 - 133832 != 148787)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (270331 - 184645 == 85687)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (198091 - 132075 != 66016)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (156162 - 229654 == -73491)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (204453 - 135426 != 69027)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (45963 - 123949 != -77986)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (67026 - 508504 == -441477)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (254041 - 264308 != -10267)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (92574 - 502416 == -409841)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (256130 - 254442 != 1688)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (37496 - 150220 == -112723)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (283355 - 50590 == 232766)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (290955 - 203141 != 87814)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (290774 - 154632 != 136142)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (240695 - 115026 == 125670)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (230761 - 105431 != 125330)
												{
													continue;
												}
												num = (float)0;
												if (229406 - 195457 != 33949)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (143181 - 404834 != -261653)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (102608 - 222905 != -120297)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (233813 - 547247 == -313433)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (112869 - 330708 == -217838)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (134026 - 354999 != -220973)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (43114 - 388483 != -345369)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (221117 - 480627 != -259510)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (247421 - 40182 == 207240)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (297322 - 146745 == 150578)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (238678 - 335245 == -96566)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (218135 - 39023 == 179113)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (262940 - 281280 != -18340)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (59244 - 487554 == -428309)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (245832 - 344260 != -98428)
											{
												continue;
											}
											num = (float)0;
											if (283751 - 48187 == 235565)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (230149 - 84300 != 145849)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (280150 - 31552 == 248599)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (241595 - 222392 != 19203)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (193879 - 75442 != 118437)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (61992 - 69546 != -7553)
								{
									this.mChar.moveSpeed = num;
									if (92364 - 170047 == -77683)
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

	// Token: 0x06000AEA RID: 2794 RVA: 0x0011A21C File Offset: 0x0011841C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (290074 - 174348 != 115726)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (157962 - 178947 == -20985)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (45869 - 593080 != -547210)
				{
					Vector3 vector = a - this.transform.position;
					if (228598 - 468359 != -239760)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (179178 - 477367 != -298188)
						{
							CharacterControl characterControl = null;
							if (209206 - 63454 == 145752)
							{
								if (114147 - 593481 == -479334)
								{
									if (gameObject)
									{
										if (59800 - 255980 == -196179)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (296168 - 569520 == -273351)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (37223 - 137983 == -100759)
										{
											continue;
										}
										int actorNr = characterControl.ActorNr;
										if (281318 - 570889 == -289570)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (23971 - 344142 == -320170)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (206193 - 72811 != 133382)
										{
											continue;
										}
									}
									if (this.mChar.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (144859 - 173386 != -28526)
									{
										if (gameObject == this.gameObject)
										{
											if (147391 - 560008 != -412617)
											{
												continue;
											}
											vector = this.transform.forward;
											if (229648 - 333290 == -103641)
											{
												continue;
											}
										}
										this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, vector, 0));
										if (165169 - 573066 != -407896)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (180924 - 358057 == -177133)
											{
												this.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
												if (51436 - 406930 != -355493)
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

	// Token: 0x06000AEB RID: 2795 RVA: 0x0011A568 File Offset: 0x00118768
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (82671 - 581914 != -499242)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (183705 - 313721 != -130015)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (49095 - 383122 != -334026)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (5093 - 13516 == -8423)
					{
						Vector3 vector2 = vector.normalized;
						if (56531 - 564226 != -507694)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (186474 - 158300 == 28174)
							{
								CharacterControl characterControl = null;
								if (75038 - 76179 != -1140 && 165054 - 320984 != -155929)
								{
									if (gameObject)
									{
										if (244816 - 359941 != -115125)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (102728 - 453101 != -350373)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (23425 - 34978 != -11553)
										{
											continue;
										}
										int actorNr = characterControl.ActorNr;
										if (170794 - 248215 == -77420)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (176978 - 570894 == -393915)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (231805 - 299868 != -68063)
										{
											continue;
										}
									}
									if (this.mChar.isTimeOut("cAttack") != (float)0)
									{
										break;
									}
									if (195530 - 53956 != 141575)
									{
										if (gameObject == this.gameObject)
										{
											if (164382 - 585103 != -420721)
											{
												continue;
											}
											vector2 = this.transform.forward;
											if (24435 - 430789 != -406354)
											{
												continue;
											}
										}
										this.StartCoroutine_Auto(this.RPC_cAttack(this.transform.position, vector2, 0));
										if (260050 - 56401 != 203650)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (272420 - 271415 == 1005)
											{
												this.ActionEvent("RPC_cAttack", this.transform.position, vector2, 0);
												if (88817 - 64275 == 24542)
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

	// Token: 0x06000AEC RID: 2796 RVA: 0x0011A8DC File Offset: 0x00118ADC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06000AED RID: 2797 RVA: 0x0011A8E0 File Offset: 0x00118AE0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new SilverBug.$RPC_nAttack$17161(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06000AEE RID: 2798 RVA: 0x0011A8F0 File Offset: 0x00118AF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (this.nAttack_hit)
		{
			UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, Quaternion.LookRotation(hitDir));
		}
	}

	// Token: 0x06000AEF RID: 2799 RVA: 0x0011A918 File Offset: 0x00118B18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_cAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new SilverBug.$RPC_cAttack$17176(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06000AF0 RID: 2800 RVA: 0x0011A928 File Offset: 0x00118B28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_cAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (this.cAttack_hit)
		{
			UnityEngine.Object.Instantiate(this.cAttack_hit, hitPos, Quaternion.LookRotation(hitDir));
		}
	}

	// Token: 0x06000AF1 RID: 2801 RVA: 0x0011A950 File Offset: 0x00118B50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new SilverBug.$RPC_ko$17189(nArray, this).GetEnumerator();
	}

	// Token: 0x06000AF2 RID: 2802 RVA: 0x0011A960 File Offset: 0x00118B60
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new SilverBug.$RPC_dead$17196(nArray, this).GetEnumerator();
	}

	// Token: 0x06000AF3 RID: 2803 RVA: 0x0011A970 File Offset: 0x00118B70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06000AF4 RID: 2804 RVA: 0x0011A974 File Offset: 0x00118B74
	internal static bool tKwQXvHib7Fc9I831eE()
	{
		return true;
	}

	// Token: 0x06000AF5 RID: 2805 RVA: 0x0011A978 File Offset: 0x00118B78
	internal static bool wsegTxHKTJWdwM0Jwn6()
	{
		return false;
	}

	// Token: 0x040009AF RID: 2479
	public CharacterControl mChar;

	// Token: 0x040009B0 RID: 2480
	public AudioClip footStep;

	// Token: 0x040009B1 RID: 2481
	private Quaternion ekpevx6sd5;

	// Token: 0x040009B2 RID: 2482
	private float dPRelkCJ38;

	// Token: 0x040009B3 RID: 2483
	private Transform aRFeG6Vvu5;

	// Token: 0x040009B4 RID: 2484
	public GameObject nAttack_ring;

	// Token: 0x040009B5 RID: 2485
	public GameObject nAttack_hit;

	// Token: 0x040009B6 RID: 2486
	public GameObject cAttack_ring;

	// Token: 0x040009B7 RID: 2487
	public GameObject cAttack_hit;

	// Token: 0x040009B8 RID: 2488
	public GameObject ko_ring;

	// Token: 0x040009B9 RID: 2489
	public GameObject deadEffect;

	// Token: 0x020001E5 RID: 485
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$17161 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000AF6 RID: 2806 RVA: 0x0011A97C File Offset: 0x00118B7C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$17161(Vector3 mPos, Vector3 tDir, SilverBug self_)
		{
			if (178101 - 206081 != -27979)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (134127 - 118001 == 16126)
				{
					base..ctor();
					if (15052 - 513835 != -498782)
					{
						this.$mPos$17173 = mPos;
						if (163769 - 159732 != 4038)
						{
							this.$tDir$17174 = tDir;
							if (150646 - 575703 != -425056)
							{
								this.$self_$17175 = self_;
								if (81599 - 408582 == -326983)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000AF7 RID: 2807 RVA: 0x0011AA58 File Offset: 0x00118C58
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new SilverBug.$RPC_nAttack$17161.$(this.$mPos$17173, this.$tDir$17174, this.$self_$17175);
		}

		// Token: 0x06000AF8 RID: 2808 RVA: 0x0011AA74 File Offset: 0x00118C74
		internal static bool tQ5TV3HdjAWFui6J2Oe()
		{
			return true;
		}

		// Token: 0x06000AF9 RID: 2809 RVA: 0x0011AA78 File Offset: 0x00118C78
		internal static bool cZJhbCHJF3cdPZG8Sxg()
		{
			return false;
		}

		// Token: 0x040009BA RID: 2490
		internal Vector3 $mPos$17173;

		// Token: 0x040009BB RID: 2491
		internal Vector3 $tDir$17174;

		// Token: 0x040009BC RID: 2492
		internal SilverBug $self_$17175;

		// Token: 0x020001E6 RID: 486
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000AFA RID: 2810 RVA: 0x0011AA7C File Offset: 0x00118C7C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, SilverBug self_)
			{
				if (268818 - 117367 != 151452)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (191249 - 235836 != -44586)
					{
						base..ctor();
						if (97709 - 244533 == -146824)
						{
							this.$mPos$17170 = mPos;
							if (235936 - 368041 == -132105)
							{
								this.$tDir$17171 = tDir;
								if (6148 - 234678 != -228529)
								{
									this.$self_$17172 = self_;
									if (211861 - 172480 == 39381)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000AFB RID: 2811 RVA: 0x0011AB58 File Offset: 0x00118D58
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (214354 - 423384 != -209029)
				{
				}
				for (;;)
				{
					IL_881:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_DD9;
					case 2:
						if (this.$self_$17172.mChar.actionState != "attack")
						{
							goto IL_138;
						}
						if (37 - 93032 == -92994)
						{
							continue;
						}
						if (this.$self_$17172.mChar.myCommand != "nAttack")
						{
							if (181846 - 506966 != -325119)
							{
								goto Block_49;
							}
							continue;
						}
						else
						{
							this.$hitLayer$17162 = 130816 - (1 << this.$self_$17172.gameObject.layer);
							if (232232 - 123935 == 108298)
							{
								continue;
							}
							this.$hitList$17163 = null;
							if (186126 - 134520 != 51606)
							{
								continue;
							}
							this.$hitPos$17164 = default(Vector3);
							if (267555 - 536735 == -269179)
							{
								continue;
							}
							if (!this.$self_$17172.mChar.isMine)
							{
								goto IL_45;
							}
							if (283298 - 353845 != -70547)
							{
								continue;
							}
							this.$hitList$17163 = Damage.FindRecTarget(this.$self_$17172.transform.position - this.$self_$17172.transform.forward, this.$self_$17172.transform.forward, (float)2 * this.$self_$17172.mChar.rangeMod, (float)2 * this.$self_$17172.mChar.rangeMod, (float)4 * this.$self_$17172.mChar.rangeMod, (float)3 * this.$self_$17172.mChar.rangeMod, this.$hitLayer$17162);
							if (20506 - 63180 == -42673)
							{
								continue;
							}
							this.$$iterator$10013$17167 = UnityRuntimeServices.GetEnumerator(this.$hitList$17163);
							if (55898 - 456154 == -400255)
							{
								continue;
							}
							while (this.$$iterator$10013$17167.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10013$17167.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$17165 = (GameObject)obj2;
								if (7241 - 415440 == -408198)
								{
									goto IL_881;
								}
								if (this.$self_$17172.mChar.hit(1, this.$hitObject$17165, (int)(0.6f * (float)this.$self_$17172.mChar.atk), 2, 0, this.$self_$17172.transform.forward) != 0)
								{
									if (93294 - 89682 == 3613)
									{
										goto IL_881;
									}
									this.$hitPos$17164 = this.$hitObject$17165.collider.ClosestPointOnBounds(this.$self_$17172.transform.position + Vector3.up);
									if (58406 - 362936 != -304530)
									{
										goto IL_881;
									}
									UnityRuntimeServices.Update(this.$$iterator$10013$17167, this.$hitObject$17165);
									if (236711 - 152449 != 84262)
									{
										goto IL_881;
									}
									this.$self_$17172.RPC_nAttack_hit(this.$hitPos$17164, this.$self_$17172.transform.forward, 0);
									if (46356 - 64435 == -18078)
									{
										goto IL_881;
									}
									this.$self_$17172.ActionEvent("RPC_nAttack_hit", this.$hitPos$17164, this.$self_$17172.transform.forward, 0);
									if (136116 - 85172 == 50945)
									{
										goto IL_881;
									}
									this.$tChar$17166 = (CharacterControl)this.$hitObject$17165.GetComponent(typeof(CharacterControl));
									if (34786 - 188685 != -153899)
									{
										goto IL_881;
									}
									UnityRuntimeServices.Update(this.$$iterator$10013$17167, this.$hitObject$17165);
									if (150620 - 537552 != -386932)
									{
										goto IL_881;
									}
									if (this.$tChar$17166)
									{
										if (175444 - 95931 != 79513)
										{
											goto IL_881;
										}
										this.$tChar$17166.RPC_AddStatus("puncture", 4, 1, 0, this.$self_$17172.mChar.ActorNr);
										if (29079 - 147662 == -118582)
										{
											goto IL_881;
										}
									}
								}
							}
							if (177653 - 30592 != 147062)
							{
								goto Block_33;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$17172.mChar.actionState != "attack")
						{
							goto IL_345;
						}
						if (131887 - 112057 == 19831)
						{
							continue;
						}
						if (this.$self_$17172.mChar.myCommand != "nAttack")
						{
							if (141314 - 193837 != -52522)
							{
								goto Block_6;
							}
							continue;
						}
						else
						{
							this.$self_$17172.mChar.moveSpeed = (float)12;
							if (262641 - 104237 == 158405)
							{
								continue;
							}
							if (!this.$self_$17172.mChar.isMine)
							{
								goto IL_914;
							}
							if (264219 - 579220 != -315001)
							{
								continue;
							}
							this.$hitList$17163 = Damage.FindRecTarget(this.$self_$17172.transform.position - this.$self_$17172.transform.forward, this.$self_$17172.transform.forward, (float)2 * this.$self_$17172.mChar.rangeMod, (float)2 * this.$self_$17172.mChar.rangeMod, (float)5 * this.$self_$17172.mChar.rangeMod, (float)3 * this.$self_$17172.mChar.rangeMod, this.$hitLayer$17162);
							if (38833 - 292413 == -253579)
							{
								continue;
							}
							this.$$iterator$10014$17169 = UnityRuntimeServices.GetEnumerator(this.$hitList$17163);
							if (192543 - 371358 != -178815)
							{
								continue;
							}
							while (this.$$iterator$10014$17169.MoveNext())
							{
								object obj4;
								object obj3 = obj4 = this.$$iterator$10014$17169.Current;
								if (!(obj3 is GameObject))
								{
									obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
								}
								this.$hitObject$17168 = (GameObject)obj4;
								if (104897 - 343198 != -238301)
								{
									goto IL_881;
								}
								if (this.$self_$17172.mChar.hit(1, this.$hitObject$17168, this.$self_$17172.mChar.atk, 3, 0, this.$self_$17172.transform.forward) != 0)
								{
									if (178774 - 511638 != -332864)
									{
										goto IL_881;
									}
									this.$hitPos$17164 = this.$hitObject$17168.collider.ClosestPointOnBounds(this.$self_$17172.transform.position + (float)2 * Vector3.up);
									if (79453 - 424434 == -344980)
									{
										goto IL_881;
									}
									UnityRuntimeServices.Update(this.$$iterator$10014$17169, this.$hitObject$17168);
									if (131459 - 199026 == -67566)
									{
										goto IL_881;
									}
									this.$self_$17172.RPC_nAttack_hit(this.$hitPos$17164, this.$self_$17172.transform.forward, 0);
									if (11578 - 49915 == -38336)
									{
										goto IL_881;
									}
									this.$self_$17172.ActionEvent("RPC_nAttack_hit", this.$hitPos$17164, this.$self_$17172.transform.forward, 0);
									if (169060 - 346381 == -177320)
									{
										goto IL_881;
									}
								}
							}
							if (46490 - 395977 != -349487)
							{
								continue;
							}
							goto IL_914;
						}
						break;
					case 4:
						if (this.$self_$17172.mChar.actionState != "attack")
						{
							goto IL_4C4;
						}
						if (248441 - 343058 == -94616)
						{
							continue;
						}
						if (this.$self_$17172.mChar.myCommand != "nAttack")
						{
							if (156039 - 203949 != -47910)
							{
								continue;
							}
							goto IL_4C4;
						}
						else
						{
							this.$self_$17172.mChar.moveSpeed = (float)0;
							if (2288 - 449225 == -446936)
							{
								continue;
							}
							if (this.$self_$17172.mChar.actionState == "attack")
							{
								if (226145 - 224141 != 2004)
								{
									continue;
								}
								if (this.$self_$17172.mChar.myCommand == "nAttack")
								{
									if (141858 - 244665 != -102807)
									{
										continue;
									}
									this.$self_$17172.mChar.actionState = "standby";
									if (168417 - 367980 == -199562)
									{
										continue;
									}
									this.$self_$17172.mChar.actionTime = Time.time;
									if (206421 - 312736 != -106315)
									{
										continue;
									}
									this.$self_$17172.mChar.myCommand = "none";
									if (67768 - 382080 == -314311)
									{
										continue;
									}
									if (!this.$self_$17172.mChar.isMine)
									{
										if (258664 - 165302 == 93363)
										{
											continue;
										}
										this.$self_$17172.mChar.nPosition = this.$self_$17172.transform.position;
										if (32424 - 52873 != -20449)
										{
											continue;
										}
										this.$self_$17172.mChar.oPosition = this.$self_$17172.transform.position;
										if (83215 - 18580 == 64636)
										{
											continue;
										}
										this.$self_$17172.mChar.nDirection = this.$self_$17172.transform.forward;
										if (296578 - 411870 == -115291)
										{
											continue;
										}
									}
								}
							}
							this.YieldDefault(1);
							if (208345 - 547937 != -339592)
							{
								continue;
							}
							goto IL_DD9;
						}
						break;
					default:
						if (280495 - 25639 != 254856)
						{
							continue;
						}
						break;
					}
					this.$self_$17172.mChar.actionState = "attack";
					if (125080 - 218934 == -93854)
					{
						this.$self_$17172.mChar.actionTime = Time.time;
						if (271121 - 258936 == 12185)
						{
							this.$self_$17172.mChar.myCommand = "nAttack";
							if (59332 - 33849 != 25484)
							{
								this.$self_$17172.mChar.addTimeOut("nAttack", (float)2);
								if (115739 - 214492 == -98753)
								{
									this.$self_$17172.transform.position = this.$mPos$17170;
									if (178943 - 540336 == -361393)
									{
										this.$self_$17172.transform.LookAt(this.$mPos$17170 + global::Math.vFlat(this.$tDir$17171));
										if (40567 - 105405 == -64838)
										{
											this.$self_$17172.animation.CrossFade("nAttack");
											if (247632 - 1186 == 246446)
											{
												this.$self_$17172.animation.wrapMode = WrapMode.Once;
												if (160955 - 512390 == -351435)
												{
													this.$self_$17172.mChar.vMovement = this.$self_$17172.transform.forward;
													if (200116 - 550178 == -350062)
													{
														this.$self_$17172.mChar.moveSpeed = (float)0;
														if (133617 - 581300 == -447683)
														{
															if (this.$self_$17172.nAttack_ring)
															{
																if (52833 - 280302 == -227469)
																{
																	this.$self_$17172.mChar.createEffect(this.$self_$17172.nAttack_ring, this.$self_$17172.transform.position, this.$self_$17172.transform.rotation);
																	if (299418 - 299822 == -404)
																	{
																		goto IL_AF7;
																	}
																}
															}
															else
															{
																Debug.LogError("Missing nAttack_ring effect");
																if (244623 - 96817 == 147806)
																{
																	goto IL_1B1;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_45:
				return this.Yield(3, new WaitForSeconds(0.3f));
				Block_6:
				IL_138:
				goto IL_DD9;
				IL_1B1:
				return this.Yield(2, new WaitForSeconds(0.3f));
				IL_345:
				IL_4C4:
				goto IL_DD9;
				Block_33:
				goto IL_45;
				Block_49:
				goto IL_138;
				IL_914:
				return this.Yield(4, new WaitForSeconds(0.2f));
				IL_AF7:
				goto IL_1B1;
				IL_DD9:
				return false;
			}

			// Token: 0x06000AFC RID: 2812 RVA: 0x0011B950 File Offset: 0x00119B50
			internal static bool IuYAMxHD1UfDFy6sWrt()
			{
				return true;
			}

			// Token: 0x06000AFD RID: 2813 RVA: 0x0011B954 File Offset: 0x00119B54
			internal static bool u1yPE4HvHuwPxjITTri()
			{
				return false;
			}

			// Token: 0x040009BD RID: 2493
			internal int $hitLayer$17162;

			// Token: 0x040009BE RID: 2494
			internal UnityScript.Lang.Array $hitList$17163;

			// Token: 0x040009BF RID: 2495
			internal Vector3 $hitPos$17164;

			// Token: 0x040009C0 RID: 2496
			internal GameObject $hitObject$17165;

			// Token: 0x040009C1 RID: 2497
			internal CharacterControl $tChar$17166;

			// Token: 0x040009C2 RID: 2498
			internal IEnumerator $$iterator$10013$17167;

			// Token: 0x040009C3 RID: 2499
			internal GameObject $hitObject$17168;

			// Token: 0x040009C4 RID: 2500
			internal IEnumerator $$iterator$10014$17169;

			// Token: 0x040009C5 RID: 2501
			internal Vector3 $mPos$17170;

			// Token: 0x040009C6 RID: 2502
			internal Vector3 $tDir$17171;

			// Token: 0x040009C7 RID: 2503
			internal SilverBug $self_$17172;
		}
	}

	// Token: 0x020001E7 RID: 487
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_cAttack$17176 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000AFE RID: 2814 RVA: 0x0011B958 File Offset: 0x00119B58
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_cAttack$17176(Vector3 mPos, Vector3 tDir, SilverBug self_)
		{
			if (213316 - 507728 != -294411)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (4513 - 322696 == -318183)
				{
					base..ctor();
					if (171355 - 223772 != -52416)
					{
						this.$mPos$17186 = mPos;
						if (138625 - 110726 == 27899)
						{
							this.$tDir$17187 = tDir;
							if (4421 - 105695 == -101274)
							{
								this.$self_$17188 = self_;
								if (113418 - 182806 == -69388)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000AFF RID: 2815 RVA: 0x0011BA34 File Offset: 0x00119C34
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new SilverBug.$RPC_cAttack$17176.$(this.$mPos$17186, this.$tDir$17187, this.$self_$17188);
		}

		// Token: 0x06000B00 RID: 2816 RVA: 0x0011BA50 File Offset: 0x00119C50
		internal static bool vkvuQCHRxeSNOYI8sU4()
		{
			return true;
		}

		// Token: 0x06000B01 RID: 2817 RVA: 0x0011BA54 File Offset: 0x00119C54
		internal static bool r055pnHwHGlwGfh9Q45()
		{
			return false;
		}

		// Token: 0x040009C8 RID: 2504
		internal Vector3 $mPos$17186;

		// Token: 0x040009C9 RID: 2505
		internal Vector3 $tDir$17187;

		// Token: 0x040009CA RID: 2506
		internal SilverBug $self_$17188;

		// Token: 0x020001E8 RID: 488
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000B02 RID: 2818 RVA: 0x0011BA58 File Offset: 0x00119C58
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, SilverBug self_)
			{
				if (141053 - 377079 != -236025)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (185674 - 27146 != 158529)
					{
						base..ctor();
						if (183710 - 326469 == -142759)
						{
							this.$mPos$17183 = mPos;
							if (220181 - 16435 != 203747)
							{
								this.$tDir$17184 = tDir;
								if (186357 - 149131 == 37226)
								{
									this.$self_$17185 = self_;
									if (51542 - 315756 != -264213)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000B03 RID: 2819 RVA: 0x0011BB34 File Offset: 0x00119D34
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (36785 - 353477 != -316691)
				{
				}
				for (;;)
				{
					IL_56D:
					switch (this._state)
					{
					case 0:
						goto IL_633;
					case 1:
						goto IL_9C9;
					case 2:
						if (this.$self_$17185.mChar.actionState != "attack")
						{
							goto IL_22B;
						}
						if (196164 - 315538 != -119374)
						{
							continue;
						}
						if (this.$self_$17185.mChar.myCommand != "cAttack")
						{
							if (252008 - 200309 != 51700)
							{
								goto Block_6;
							}
							continue;
						}
						else
						{
							this.$self_$17185.mChar.moveSpeed = (float)8;
							if (113884 - 505736 != -391852)
							{
								continue;
							}
							if (this.$self_$17185.cAttack_ring)
							{
								if (169670 - 311700 == -142029)
								{
									continue;
								}
								this.$self_$17185.mChar.createEffect(this.$self_$17185.cAttack_ring, this.$self_$17185.transform.position, this.$self_$17185.transform.rotation);
								if (12584 - 516660 == -504075)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing cAttack_ring effect");
								if (52693 - 485146 != -432453)
								{
									continue;
								}
							}
							this.$i$17177 = 0;
							if (143583 - 560153 != -416570)
							{
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$17185.mChar.actionState != "attack")
						{
							goto IL_7DB;
						}
						if (164489 - 327293 != -162804)
						{
							continue;
						}
						if (this.$self_$17185.mChar.myCommand != "cAttack")
						{
							if (104451 - 146871 != -42419)
							{
								goto Block_28;
							}
							continue;
						}
						else
						{
							this.$i$17177++;
							if (233506 - 346220 != -112714)
							{
								continue;
							}
						}
						break;
					case 4:
						if (this.$self_$17185.mChar.actionState == "attack")
						{
							if (227386 - 174296 != 53090)
							{
								continue;
							}
							if (this.$self_$17185.mChar.myCommand == "cAttack")
							{
								if (69404 - 421201 == -351796)
								{
									continue;
								}
								this.$self_$17185.mChar.actionState = "standby";
								if (122034 - 374596 == -252561)
								{
									continue;
								}
								this.$self_$17185.mChar.actionTime = Time.time;
								if (258532 - 384360 != -125828)
								{
									continue;
								}
								this.$self_$17185.mChar.myCommand = "none";
								if (221879 - 328067 != -106188)
								{
									continue;
								}
								if (!this.$self_$17185.mChar.isMine)
								{
									if (182263 - 347749 != -165486)
									{
										continue;
									}
									this.$self_$17185.mChar.nPosition = this.$self_$17185.transform.position;
									if (153718 - 206755 != -53037)
									{
										continue;
									}
									this.$self_$17185.mChar.oPosition = this.$self_$17185.transform.position;
									if (85470 - 402195 == -316724)
									{
										continue;
									}
									this.$self_$17185.mChar.nDirection = this.$self_$17185.transform.forward;
									if (167428 - 443722 == -276293)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (20218 - 239924 != -219706)
						{
							continue;
						}
						goto IL_9C9;
					default:
						if (274758 - 499762 != -225004)
						{
							continue;
						}
						goto IL_633;
					}
					if (this.$i$17177 >= 10)
					{
						if (62950 - 533938 != -470988)
						{
							continue;
						}
						goto IL_40E;
					}
					else
					{
						this.$hitLayer$17178 = 130816 - (1 << this.$self_$17185.gameObject.layer);
						if (55544 - 243043 != -187499)
						{
							continue;
						}
						this.$hitList$17179 = null;
						if (265925 - 531667 == -265741)
						{
							continue;
						}
						this.$hitPos$17180 = default(Vector3);
						if (19747 - 338090 == -318342)
						{
							continue;
						}
						if (!this.$self_$17185.mChar.isMine)
						{
							goto IL_343;
						}
						if (270819 - 89338 != 181481)
						{
							continue;
						}
						this.$hitList$17179 = Damage.FindAreaTarget(this.$self_$17185.transform.position + 0.5f * this.$self_$17185.transform.forward, (float)3, (float)2, this.$hitLayer$17178);
						if (192546 - 323420 != -130874)
						{
							continue;
						}
						this.$$iterator$10015$17182 = UnityRuntimeServices.GetEnumerator(this.$hitList$17179);
						if (241436 - 60022 == 181415)
						{
							continue;
						}
						while (this.$$iterator$10015$17182.MoveNext())
						{
							object obj2;
							object obj = obj2 = this.$$iterator$10015$17182.Current;
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$hitObject$17181 = (GameObject)obj2;
							if (175471 - 261175 == -85703)
							{
								goto IL_56D;
							}
							if (this.$self_$17185.mChar.hit(11, this.$hitObject$17181, (int)(0.75f * (float)this.$self_$17185.mChar.atk), 4, 0, this.$self_$17185.transform.forward) != 0)
							{
								if (349 - 278195 != -277846)
								{
									goto IL_56D;
								}
								this.$hitPos$17180 = this.$hitObject$17181.collider.ClosestPointOnBounds(this.$self_$17185.transform.position + (float)2 * Vector3.up);
								if (243220 - 406579 == -163358)
								{
									goto IL_56D;
								}
								UnityRuntimeServices.Update(this.$$iterator$10015$17182, this.$hitObject$17181);
								if (28458 - 427772 == -399313)
								{
									goto IL_56D;
								}
								this.$self_$17185.RPC_cAttack_hit(this.$hitPos$17180, this.$self_$17185.transform.forward, 0);
								if (217632 - 540385 != -322753)
								{
									goto IL_56D;
								}
								this.$self_$17185.ActionEvent("RPC_cAttack_hit", this.$hitPos$17180, this.$self_$17185.transform.forward, 0);
								if (104770 - 201022 == -96251)
								{
									goto IL_56D;
								}
							}
						}
						if (239764 - 407944 != -168179)
						{
							goto IL_343;
						}
						continue;
					}
					IL_633:
					this.$self_$17185.mChar.actionState = "attack";
					if (34993 - 210356 == -175363)
					{
						this.$self_$17185.mChar.actionTime = Time.time;
						if (189543 - 210531 != -20987)
						{
							this.$self_$17185.mChar.myCommand = "cAttack";
							if (37276 - 179222 != -141945)
							{
								this.$self_$17185.mChar.addTimeOut("cAttack", (float)15);
								if (125976 - 35286 == 90690)
								{
									this.$self_$17185.transform.position = this.$mPos$17183;
									if (159604 - 531648 == -372044)
									{
										this.$self_$17185.transform.LookAt(this.$mPos$17183 + global::Math.vFlat(this.$tDir$17184));
										if (250457 - 479516 == -229059)
										{
											this.$self_$17185.animation.CrossFade("cAttack");
											if (243168 - 491106 == -247938)
											{
												this.$self_$17185.animation.wrapMode = WrapMode.Once;
												if (53388 - 535588 == -482200)
												{
													this.$self_$17185.mChar.vMovement = this.$self_$17185.transform.forward;
													if (248623 - 336870 != -88246)
													{
														this.$self_$17185.mChar.moveSpeed = (float)0;
														if (64613 - 392414 != -327800)
														{
															goto Block_51;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_6:
				IL_22B:
				goto IL_9C9;
				IL_343:
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_40E:
				return this.Yield(4, new WaitForSeconds(0.1f));
				Block_28:
				IL_7DB:
				goto IL_9C9;
				Block_51:
				return this.Yield(2, new WaitForSeconds(0.7f));
				IL_9C9:
				return false;
			}

			// Token: 0x06000B04 RID: 2820 RVA: 0x0011C51C File Offset: 0x0011A71C
			internal static bool zYddAAHqwynL9XkiXhw()
			{
				return true;
			}

			// Token: 0x06000B05 RID: 2821 RVA: 0x0011C520 File Offset: 0x0011A720
			internal static bool pAH0cqH7dwcelrBg63w()
			{
				return false;
			}

			// Token: 0x040009CB RID: 2507
			internal int $i$17177;

			// Token: 0x040009CC RID: 2508
			internal int $hitLayer$17178;

			// Token: 0x040009CD RID: 2509
			internal UnityScript.Lang.Array $hitList$17179;

			// Token: 0x040009CE RID: 2510
			internal Vector3 $hitPos$17180;

			// Token: 0x040009CF RID: 2511
			internal GameObject $hitObject$17181;

			// Token: 0x040009D0 RID: 2512
			internal IEnumerator $$iterator$10015$17182;

			// Token: 0x040009D1 RID: 2513
			internal Vector3 $mPos$17183;

			// Token: 0x040009D2 RID: 2514
			internal Vector3 $tDir$17184;

			// Token: 0x040009D3 RID: 2515
			internal SilverBug $self_$17185;
		}
	}

	// Token: 0x020001E9 RID: 489
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$17189 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000B06 RID: 2822 RVA: 0x0011C524 File Offset: 0x0011A724
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$17189(UnityScript.Lang.Array nArray, SilverBug self_)
		{
			if (52723 - 367093 != -314369)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (12220 - 475316 == -463096)
				{
					base..ctor();
					if (40954 - 163731 != -122776)
					{
						this.$nArray$17194 = nArray;
						if (125740 - 517645 == -391905)
						{
							this.$self_$17195 = self_;
							if (258169 - 501004 != -242834)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000B07 RID: 2823 RVA: 0x0011C5E0 File Offset: 0x0011A7E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new SilverBug.$RPC_ko$17189.$(this.$nArray$17194, this.$self_$17195);
		}

		// Token: 0x06000B08 RID: 2824 RVA: 0x0011C5F4 File Offset: 0x0011A7F4
		internal static bool jEua1GHPWttqTTnXRxO()
		{
			return true;
		}

		// Token: 0x06000B09 RID: 2825 RVA: 0x0011C5F8 File Offset: 0x0011A7F8
		internal static bool D2xHt1H0iyeukCWRT4u()
		{
			return false;
		}

		// Token: 0x040009D4 RID: 2516
		internal UnityScript.Lang.Array $nArray$17194;

		// Token: 0x040009D5 RID: 2517
		internal SilverBug $self_$17195;

		// Token: 0x020001EA RID: 490
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000B0A RID: 2826 RVA: 0x0011C5FC File Offset: 0x0011A7FC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, SilverBug self_)
			{
				if (234637 - 329552 != -94914)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (215352 - 425035 != -209682)
					{
						base..ctor();
						if (41278 - 414997 == -373719)
						{
							this.$nArray$17192 = nArray;
							if (226319 - 98371 == 127948)
							{
								this.$self_$17193 = self_;
								if (233749 - 16760 != 216990)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06000B0B RID: 2827 RVA: 0x0011C6B8 File Offset: 0x0011A8B8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (53964 - 465127 != -411162)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_53A;
					case 2:
						if (this.$self_$17193.mChar.actionState != "ko")
						{
							if (135995 - 67699 != 68297)
							{
								goto Block_10;
							}
							continue;
						}
						else
						{
							this.$self_$17193.animation.Play("getUp");
							if (195061 - 427306 != -232245)
							{
								continue;
							}
							this.$self_$17193.animation.wrapMode = WrapMode.Once;
							if (260156 - 537357 != -277201)
							{
								continue;
							}
							goto IL_30A;
						}
						break;
					case 3:
						if (this.$self_$17193.mChar.actionState != "ko")
						{
							if (32016 - 131622 != -99606)
							{
								continue;
							}
							goto IL_A3;
						}
						else
						{
							this.$self_$17193.mChar.actionState = "standby";
							if (235405 - 156872 != 78533)
							{
								continue;
							}
							this.$self_$17193.mChar.actionTime = Time.time;
							if (13226 - 476687 == -463460)
							{
								continue;
							}
							this.$self_$17193.mChar.myCommand = "none";
							if (142847 - 133980 != 8867)
							{
								continue;
							}
							this.$self_$17193.mChar.ko = this.$self_$17193.mChar.mko;
							if (112745 - 121298 != -8553)
							{
								continue;
							}
							this.YieldDefault(1);
							if (214461 - 286420 != -71958)
							{
								goto Block_27;
							}
							continue;
						}
						break;
					default:
						if (220099 - 563696 != -343597)
						{
							continue;
						}
						break;
					}
					if (this.$self_$17193.mChar.actionState == "ko")
					{
						break;
					}
					if (178596 - 395986 == -217390)
					{
						if (this.$self_$17193.mChar.actionState == "dead")
						{
							if (141021 - 502569 != -361547)
							{
								break;
							}
						}
						else
						{
							this.$mPos$17190 = (Vector3)this.$nArray$17192[0];
							if (260069 - 39268 == 220801)
							{
								this.$mDir$17191 = (Vector3)this.$nArray$17192[1];
								if (219969 - 3152 == 216817)
								{
									this.$self_$17193.mChar.ko = 0;
									if (261421 - 481872 != -220450)
									{
										this.$self_$17193.mChar.actionState = "ko";
										if (259085 - 379018 != -119932)
										{
											this.$self_$17193.mChar.actionTime = Time.time;
											if (43584 - 205406 == -161822)
											{
												this.$self_$17193.mChar.myCommand = "none";
												if (291962 - 203313 != 88650)
												{
													this.$self_$17193.mChar.vMovement = Vector3.zero;
													if (267691 - 143859 != 123833)
													{
														this.$self_$17193.mChar.moveSpeed = (float)0;
														if (178502 - 30576 == 147926)
														{
															this.$self_$17193.animation.Play("ko");
															if (108333 - 190004 != -81670)
															{
																this.$self_$17193.animation.wrapMode = WrapMode.Once;
																if (254607 - 26911 != 227697)
																{
																	if (this.$self_$17193.ko_ring)
																	{
																		if (254471 - 72031 == 182440)
																		{
																			this.$self_$17193.mChar.createEffect(this.$self_$17193.ko_ring, this.$self_$17193.transform.position, this.$self_$17193.transform.rotation);
																			if (130996 - 315485 == -184489)
																			{
																				goto IL_D7;
																			}
																		}
																	}
																	else
																	{
																		Debug.LogError("Missing ko_ring effect");
																		if (85858 - 232511 != -146652)
																		{
																			goto Block_7;
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_A3:
				goto IL_53A;
				IL_D7:
				Block_7:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_10:
				goto IL_4D0;
				IL_30A:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_27:
				IL_4D0:
				IL_53A:
				return false;
			}

			// Token: 0x06000B0C RID: 2828 RVA: 0x0011CC14 File Offset: 0x0011AE14
			internal static bool NOyXTXHbiSlaNarFnwy()
			{
				return true;
			}

			// Token: 0x06000B0D RID: 2829 RVA: 0x0011CC18 File Offset: 0x0011AE18
			internal static bool w7W1HrHu6Z3nVNtf9w1()
			{
				return false;
			}

			// Token: 0x040009D6 RID: 2518
			internal Vector3 $mPos$17190;

			// Token: 0x040009D7 RID: 2519
			internal Vector3 $mDir$17191;

			// Token: 0x040009D8 RID: 2520
			internal UnityScript.Lang.Array $nArray$17192;

			// Token: 0x040009D9 RID: 2521
			internal SilverBug $self_$17193;
		}
	}

	// Token: 0x020001EB RID: 491
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$17196 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000B0E RID: 2830 RVA: 0x0011CC1C File Offset: 0x0011AE1C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$17196(UnityScript.Lang.Array nArray, SilverBug self_)
		{
			if (159951 - 145709 != 14243)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (113969 - 18698 == 95271)
				{
					base..ctor();
					if (138796 - 71979 != 66818)
					{
						this.$nArray$17201 = nArray;
						if (55955 - 518098 == -462143)
						{
							this.$self_$17202 = self_;
							if (55383 - 594720 != -539336)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000B0F RID: 2831 RVA: 0x0011CCD8 File Offset: 0x0011AED8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new SilverBug.$RPC_dead$17196.$(this.$nArray$17201, this.$self_$17202);
		}

		// Token: 0x06000B10 RID: 2832 RVA: 0x0011CCEC File Offset: 0x0011AEEC
		internal static bool ALRcopHIfX5hb3fN03C()
		{
			return true;
		}

		// Token: 0x06000B11 RID: 2833 RVA: 0x0011CCF0 File Offset: 0x0011AEF0
		internal static bool HHr3c8HBOeKYgIHLFcY()
		{
			return false;
		}

		// Token: 0x040009DA RID: 2522
		internal UnityScript.Lang.Array $nArray$17201;

		// Token: 0x040009DB RID: 2523
		internal SilverBug $self_$17202;

		// Token: 0x020001EC RID: 492
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000B12 RID: 2834 RVA: 0x0011CCF4 File Offset: 0x0011AEF4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, SilverBug self_)
			{
				if (103541 - 525489 != -421947)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (141293 - 584238 != -442944)
					{
						base..ctor();
						if (2967 - 575084 == -572117)
						{
							this.$nArray$17199 = nArray;
							if (175554 - 499940 != -324385)
							{
								this.$self_$17200 = self_;
								if (205229 - 170316 == 34913)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06000B13 RID: 2835 RVA: 0x0011CDB0 File Offset: 0x0011AFB0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (56048 - 23814 != 32234)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_580;
					case 2:
						if (this.$self_$17200.mChar.actionState != "dead")
						{
							if (264143 - 336319 != -72175)
							{
								goto Block_5;
							}
							continue;
						}
						else
						{
							if (!this.$self_$17200.mChar.isPlayer)
							{
								if (133680 - 400575 == -266894)
								{
									continue;
								}
								if (this.$self_$17200.deadEffect)
								{
									if (212895 - 189883 != 23012)
									{
										continue;
									}
									UnityEngine.Object.Instantiate(this.$self_$17200.deadEffect, this.$self_$17200.transform.position, this.$self_$17200.transform.rotation);
									if (86030 - 380918 != -294888)
									{
										continue;
									}
								}
								else
								{
									Debug.LogError("Missing dead effect");
									if (259624 - 509844 != -250220)
									{
										continue;
									}
								}
								UnityEngine.Object.Destroy(this.$self_$17200.gameObject);
								if (224117 - 141774 == 82344)
								{
									continue;
								}
							}
							else if (this.$self_$17200.mChar.isMine)
							{
								if (129104 - 95365 != 33739)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$17200.gameObject);
								if (17442 - 140463 != -123021)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (51841 - 115741 != -63900)
							{
								continue;
							}
							goto IL_580;
						}
						break;
					default:
						if (291296 - 278818 != 12478)
						{
							continue;
						}
						break;
					}
					if (this.$self_$17200.mChar.actionState == "dead")
					{
						if (211449 - 506544 != -295094)
						{
							goto Block_25;
						}
					}
					else
					{
						this.$myPosition$17197 = (Vector3)this.$nArray$17199[0];
						if (228972 - 19700 != 209273)
						{
							this.$myDirection$17198 = (Vector3)this.$nArray$17199[1];
							if (54942 - 567166 == -512224)
							{
								this.$self_$17200.transform.position = this.$myPosition$17197;
								if (134292 - 186440 == -52148)
								{
									this.$self_$17200.transform.LookAt(this.$myPosition$17197 + this.$myDirection$17198);
									if (19543 - 392367 != -372823)
									{
										this.$self_$17200.mChar.hp = 0;
										if (225287 - 437187 == -211900)
										{
											this.$self_$17200.mChar.actionState = "dead";
											if (135124 - 162824 != -27699)
											{
												this.$self_$17200.mChar.actionTime = Time.time;
												if (234160 - 467058 == -232898)
												{
													this.$self_$17200.mChar.myCommand = "none";
													if (102833 - 58143 != 44691)
													{
														this.$self_$17200.mChar.vMovement = Vector3.zero;
														if (168668 - 514193 == -345525)
														{
															this.$self_$17200.mChar.moveSpeed = (float)0;
															if (71883 - 455984 == -384101)
															{
																this.$self_$17200.animation.Rewind();
																if (45032 - 382076 != -337043)
																{
																	this.$self_$17200.animation.Play("ko");
																	if (287802 - 435458 != -147655)
																	{
																		this.$self_$17200.animation.wrapMode = WrapMode.Once;
																		if (8323 - 171567 != -163243)
																		{
																			if (this.$self_$17200.ko_ring)
																			{
																				if (176563 - 155407 == 21156)
																				{
																					this.$self_$17200.mChar.createEffect(this.$self_$17200.ko_ring, this.$self_$17200.transform.position, this.$self_$17200.transform.rotation);
																					if (120008 - 390115 == -270107)
																					{
																						break;
																					}
																				}
																			}
																			else
																			{
																				Debug.LogError("Missing ko_ring effect");
																				if (86302 - 254795 == -168493)
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
				IL_4E:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_5:
				Block_25:
				goto IL_580;
				goto IL_4E;
				IL_580:
				return false;
			}

			// Token: 0x06000B14 RID: 2836 RVA: 0x0011D350 File Offset: 0x0011B550
			internal static bool HGAEmoHenL9c1YBFygI()
			{
				return true;
			}

			// Token: 0x06000B15 RID: 2837 RVA: 0x0011D354 File Offset: 0x0011B554
			internal static bool o70gvfHrYF62R97ehQU()
			{
				return false;
			}

			// Token: 0x040009DC RID: 2524
			internal Vector3 $myPosition$17197;

			// Token: 0x040009DD RID: 2525
			internal Vector3 $myDirection$17198;

			// Token: 0x040009DE RID: 2526
			internal UnityScript.Lang.Array $nArray$17199;

			// Token: 0x040009DF RID: 2527
			internal SilverBug $self_$17200;
		}
	}
}
