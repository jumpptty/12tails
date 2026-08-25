using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000BC1 RID: 3009
[Serializable]
public class CyborgMole : MonoBehaviour
{
	// Token: 0x06004322 RID: 17186 RVA: 0x00875A80 File Offset: 0x00873C80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public CyborgMole()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06004323 RID: 17187 RVA: 0x00875A90 File Offset: 0x00873C90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (140059 - 46110 != 93949)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (287034 - 378852 != -91817)
			{
				this.mChar.actionState = "standby";
				if (106578 - 493676 == -387098)
				{
					this.mChar.actionTime = Time.time;
					if (156656 - 180325 != -23668)
					{
						this.mChar.myCommand = "none";
						if (228801 - 128715 == 100086)
						{
							this.mChar.hp = (this.mChar.mhp = 5500);
							if (253376 - 544669 == -291293)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06004324 RID: 17188 RVA: 0x00875BB4 File Offset: 0x00873DB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (113165 - 321557 != -208391)
		{
		}
		do
		{
			if (Game.mGameType == 99)
			{
				if (105147 - 419646 == -314498)
				{
					continue;
				}
				this.mChar.isMine = true;
				if (56177 - 435312 != -379135)
				{
					continue;
				}
			}
			this.mChar.addTimeOut("rapidCreation", (float)15);
		}
		while (99997 - 583781 == -483783);
	}

	// Token: 0x06004325 RID: 17189 RVA: 0x00875C68 File Offset: 0x00873E68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (98940 - 52208 != 46732)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (132509 - 176891 != -44382)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (101726 - 445724 == -343997)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_229;
					}
					if (218213 - 358420 == -140206)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (58755 - 81693 == -22937)
				{
					continue;
				}
			}
			IL_229:
			if (this.mChar.hp <= 0)
			{
				if (19492 - 132711 != -113219)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (24402 - 52308 != -27906)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (79547 - 453766 != -374219)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (163123 - 455253 == -292129)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (181358 - 317442 != -136084)
						{
							continue;
						}
						this.mChar.DeadEvent();
						if (259533 - 199044 != 60489)
						{
							continue;
						}
						break;
					}
					else
					{
						this.mChar.hp = 1;
						if (279729 - 568627 != -288897)
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
			if (135713 - 8099 == 127614)
			{
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (223890 - 422266 != -198375)
				{
					if (!(this.mChar.actionState != "ko"))
					{
						break;
					}
					if (166928 - 216982 != -50053)
					{
						if (!(this.mChar.actionState != "dead"))
						{
							break;
						}
						if (285822 - 554530 == -268708)
						{
							if (this.mChar.isMine)
							{
								if (144703 - 448558 != -303854)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (127654 - 453587 == -325933)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (286643 - 556787 != -270143)
										{
											this.mChar.KoEvent();
											if (180972 - 441792 != -260819)
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
								if (186245 - 252506 == -66261)
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

	// Token: 0x06004326 RID: 17190 RVA: 0x00876060 File Offset: 0x00874260
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (98101 - 395210 != -297108)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (164596 - 251268 == -86672)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (198906 - 300744 != -101837 && 66799 - 179180 != -112380)
				{
					if (ActionName == "RPC_nAttack")
					{
						if (193736 - 357237 == -163500)
						{
							continue;
						}
						v = 1;
						if (170076 - 390487 == -220410)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nAttack_fire")
					{
						if (200127 - 123753 == 76375)
						{
							continue;
						}
						v = 2;
						if (3176 - 369064 == -365887)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nAttack_hit")
					{
						if (82053 - 549754 != -467701)
						{
							continue;
						}
						v = -1;
						if (30103 - 285791 != -255688)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_mortarShot")
					{
						if (209074 - 102474 != 106600)
						{
							continue;
						}
						v = 11;
						if (45612 - 517635 != -472023)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_mortarShot_fire")
					{
						if (3282 - 163950 == -160667)
						{
							continue;
						}
						v = 12;
						if (25740 - 297801 == -272060)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_rapidCreation")
					{
						if (87382 - 543247 != -455865)
						{
							continue;
						}
						v = 21;
						if (103852 - 349398 != -245546)
						{
							continue;
						}
					}
					else
					{
						Debug.Log("Unknown Action Name:" + ActionName);
						if (144678 - 499086 == -354407)
						{
							continue;
						}
					}
					int v2 = Mathf.RoundToInt(nPos.x * (float)50);
					if (158602 - 189760 == -31158)
					{
						int v3 = Mathf.RoundToInt(nPos.y * (float)50);
						if (121861 - 208604 != -86742)
						{
							int v4 = Mathf.RoundToInt(nPos.z * (float)50);
							if (204941 - 75159 == 129782)
							{
								int v5 = Mathf.RoundToInt((float)200 * tPos.x);
								if (129499 - 490705 != -361205)
								{
									int v6 = Mathf.RoundToInt((float)200 * tPos.y);
									if (54480 - 178346 != -123865)
									{
										int v7 = Mathf.RoundToInt((float)200 * tPos.z);
										if (97885 - 352630 != -254744)
										{
											Hashtable hashtable = new Hashtable();
											if (121193 - 19964 != 101230)
											{
												hashtable.Add(120, PhotonClient.cInt16(v));
												if (188528 - 371633 != -183104)
												{
													hashtable.Add(122, PhotonClient.cInt16(v2));
													if (281213 - 173826 == 107387)
													{
														hashtable.Add(123, PhotonClient.cInt16(v3));
														if (6880 - 201553 != -194672)
														{
															hashtable.Add(124, PhotonClient.cInt16(v4));
															if (39111 - 519914 != -480802)
															{
																hashtable.Add(126, PhotonClient.cInt16(v5));
																if (194362 - 288181 != -93818)
																{
																	hashtable.Add(127, PhotonClient.cInt16(v6));
																	if (12565 - 277531 != -264965)
																	{
																		hashtable.Add(128, PhotonClient.cInt16(v7));
																		if (252601 - 50051 == 202550)
																		{
																			hashtable.Add(129, PhotonClient.cInt16(tID));
																			if (55995 - 349888 != -293892)
																			{
																				PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																				if (285292 - 373141 != -87848)
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

	// Token: 0x06004327 RID: 17191 RVA: 0x0087660C File Offset: 0x0087480C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (268340 - 298130 != -29789)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (209125 - 322177 != -113051)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (278233 - 599662 != -321428)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (294635 - 299848 == -5213)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (143219 - 525759 != -382539)
						{
							int num3 = num;
							if (215931 - 275972 == -60041)
							{
								if (num3 == 1)
								{
									if (204596 - 2077 != 202520)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (172880 - 320815 == -147935)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (170597 - 116711 == 53886)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 2)
								{
									if (154800 - 320717 == -165917)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (11893 - 173754 == -161861)
										{
											this.RPC_nAttack_fire(vector, vector2, num2);
											if (198534 - 345312 != -146777)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (77008 - 441547 == -364539)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (246304 - 86878 == 159426)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (59399 - 337902 == -278503)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (280928 - 217628 != 63301)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (290816 - 514256 == -223440)
										{
											this.StartCoroutine_Auto(this.RPC_mortarShot(vector, vector2, num2));
											if (49078 - 370958 != -321879)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 12)
								{
									if (90904 - 261483 != -170578)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (90948 - 343848 == -252900)
										{
											this.RPC_mortarShot_fire(vector, vector2, num2);
											if (269280 - 280264 != -10983)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 21)
								{
									if (9181 - 401403 != -392221)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (149187 - 500637 != -351449)
										{
											this.StartCoroutine_Auto(this.RPC_rapidCreation(vector, vector2, num2));
											if (285356 - 598726 != -313369)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (184884 - 243117 == -58233)
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

	// Token: 0x06004328 RID: 17192 RVA: 0x00876A80 File Offset: 0x00874C80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (50333 - 51018 != -684)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (150364 - 129556 == 20808)
			{
				float runSpeed = this.mChar.runSpeed;
				if (122925 - 348834 != -225908)
				{
					Vector3 a = default(Vector3);
					if (66994 - 288097 == -221103)
					{
						Vector3 vector = Vector3.zero;
						if (225894 - 378780 != -152885)
						{
							float num2 = (float)0;
							if (244235 - 24362 == 219873)
							{
								if (this.mChar.isMine)
								{
									if (247298 - 192798 == 54501)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (66084 - 494392 == -428307)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (216026 - 384098 != -168072)
										{
											continue;
										}
										a.y = (float)0;
										if (208956 - 430203 != -221247)
										{
											continue;
										}
										a = a.normalized;
										if (59171 - 588931 == -529759)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (8768 - 462573 == -453804)
										{
											continue;
										}
										vector = vector.normalized;
										if (155267 - 206450 == -51182)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (132478 - 5225 == 127254)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (76494 - 192410 != -115916)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (231709 - 412722 != -181013)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (148008 - 280010 == -132001)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (30260 - 931 == 29330)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (215743 - 126154 != 89589)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (15468 - 288318 == -272849)
														{
															continue;
														}
														this.animation.Play("run");
														if (161401 - 67584 != 93817)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (8859 - 208982 != -200122)
														{
															goto IL_5D8;
														}
														continue;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (19254 - 255262 != -236008)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (78531 - 80576 == -2044)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (14577 - 197230 == -182652)
											{
												continue;
											}
											num = (float)0;
											if (203119 - 86033 == 117087)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (174443 - 358681 == -184237)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (163595 - 458816 == -295220)
										{
											continue;
										}
									}
									IL_5D8:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (39844 - 242015 == -202170)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (29465 - 138134 != -108669)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (64554 - 18988 == 45567)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (290006 - 266511 == 23496)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (132983 - 150573 != -17590)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (200873 - 29868 != 171005)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (72372 - 517150 != -444778)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (153801 - 407976 == -254174)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (42813 - 199541 == -156727)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (88363 - 102789 == -14425)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (32312 - 252155 == -219842)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (42740 - 397229 != -354489)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (26099 - 574386 == -548286)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (282972 - 477193 != -194221)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (281093 - 518822 != -237729)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (149701 - 292053 != -142352)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (138905 - 598179 == -459273)
												{
													continue;
												}
												num = (float)0;
												if (161280 - 443396 == -282115)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (57624 - 439826 != -382202)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (292514 - 397019 == -104504)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (47714 - 130835 == -83120)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (87452 - 506851 != -419399)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (287834 - 441584 == -153749)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (117710 - 232206 == -114495)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (149124 - 324646 != -175522)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (211373 - 480125 == -268751)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (106722 - 49928 == 56795)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (220099 - 258204 == -38104)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (76332 - 263431 == -187098)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (143613 - 105819 == 37795)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (137398 - 245939 == -108540)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (289845 - 286395 == 3451)
											{
												continue;
											}
											num = (float)0;
											if (169930 - 473790 == -303859)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (103407 - 468288 == -364880)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (127036 - 514586 == -387549)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (32369 - 174562 == -142192)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (284453 - 40940 != 243513)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (155638 - 394608 == -238970)
								{
									this.mChar.moveSpeed = num;
									if (181432 - 230923 != -49490)
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

	// Token: 0x06004329 RID: 17193 RVA: 0x008775E4 File Offset: 0x008757E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (234314 - 285090 != -50776)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (211601 - 534489 != -322887)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (192484 - 356761 == -164277)
				{
					Vector3 vector = a - this.transform.position;
					if (292827 - 214157 != 78671)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (53076 - 517734 != -464657)
						{
							CharacterControl characterControl = null;
							if (220010 - 452587 != -232576)
							{
								int tID = 0;
								if (7827 - 193898 != -186070)
								{
									if (gameObject)
									{
										if (286965 - 369225 == -82259)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (87749 - 440284 == -352534)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (210201 - 565981 == -355779)
										{
											continue;
										}
										tID = characterControl.ActorNr;
										if (148151 - 125420 != 22731)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (121010 - 284469 == -163458)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (107885 - 81793 == 26093)
										{
											continue;
										}
									}
									if (this.mChar.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (78384 - 229348 == -150964)
									{
										if (vector.sqrMagnitude > (float)36)
										{
											if (59212 - 252423 != -193210)
											{
												this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, vector, 0));
												if (204673 - 386350 == -181677)
												{
													if (!PhotonClient.IsInitialized())
													{
														break;
													}
													if (32415 - 318892 != -286476)
													{
														this.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
														if (42263 - 272277 == -230014)
														{
															break;
														}
													}
												}
											}
										}
										else
										{
											this.StartCoroutine_Auto(this.RPC_mortarShot(this.transform.position, vector, tID));
											if (241565 - 261638 == -20073)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (123035 - 416136 != -293100)
												{
													this.ActionEvent("RPC_mortarShot", this.transform.position, vector, tID);
													if (208101 - 124705 == 83396)
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

	// Token: 0x0600432A RID: 17194 RVA: 0x00877998 File Offset: 0x00875B98
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (247581 - 548399 != -300818)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (230651 - 113752 != 116900)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (106015 - 26012 != 80004)
				{
					Vector3 vector = a - this.transform.position;
					if (272384 - 37405 != 234980)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (52459 - 445388 == -392929)
						{
							CharacterControl characterControl = null;
							if (272555 - 515409 != -242853 && 89890 - 1463 != 88428)
							{
								if (gameObject)
								{
									if (258031 - 129130 != 128901)
									{
										continue;
									}
									characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (141430 - 510666 != -369236)
									{
										continue;
									}
								}
								if (characterControl)
								{
									if (85226 - 416733 == -331506)
									{
										continue;
									}
									int actorNr = characterControl.ActorNr;
									if (129099 - 548391 == -419291)
									{
										continue;
									}
								}
								if (!(this.mChar.actionState == "standby"))
								{
									if (108375 - 227947 == -119571)
									{
										continue;
									}
									if (!(this.mChar.actionState == "run"))
									{
										break;
									}
									if (238472 - 154506 == 83967)
									{
										continue;
									}
								}
								if (this.mChar.isTimeOut("mortarShot") != (float)0)
								{
									break;
								}
								if (232000 - 578875 != -346874)
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

	// Token: 0x0600432B RID: 17195 RVA: 0x00877C0C File Offset: 0x00875E0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x0600432C RID: 17196 RVA: 0x00877C10 File Offset: 0x00875E10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new CyborgMole.$RPC_nAttack$31529(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x0600432D RID: 17197 RVA: 0x00877C20 File Offset: 0x00875E20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_fire(Vector3 firePos, Vector3 fireDir, int targetID)
	{
		if (269069 - 199285 != 69784)
		{
		}
		for (;;)
		{
			Quaternion rotation = Quaternion.LookRotation(global::Math.getTrajectoryVector(firePos, firePos + fireDir, (float)15));
			if (15909 - 114904 != -98994)
			{
				GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(this.nAttack_fire, firePos, rotation);
				if (157634 - 42089 != 115546)
				{
					ProjectileControl projectileControl = (ProjectileControl)gameObject.GetComponent(typeof(ProjectileControl));
					if (59438 - 398040 != -338601)
					{
						projectileControl.Init(this.mChar.ActorNr);
						if (231896 - 122418 != 109479)
						{
							projectileControl.life = (float)5 * this.mChar.rangeMod;
							if (290319 - 93452 != 196868)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600432E RID: 17198 RVA: 0x00877D40 File Offset: 0x00875F40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, Quaternion.identity);
	}

	// Token: 0x0600432F RID: 17199 RVA: 0x00877D54 File Offset: 0x00875F54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_mortarShot(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new CyborgMole.$RPC_mortarShot$31542(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06004330 RID: 17200 RVA: 0x00877D64 File Offset: 0x00875F64
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_mortarShot_fire(Vector3 firePos, Vector3 fireDir, int tID)
	{
		if (205649 - 465969 != -260319)
		{
		}
		while (this.mortarShot_fire)
		{
			if (268150 - 407253 != -139102)
			{
				Quaternion rotation = Quaternion.LookRotation(global::Math.getMortarVector(firePos, firePos + fireDir, (float)15));
				if (117137 - 50022 == 67115)
				{
					GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(this.mortarShot_fire, firePos, rotation);
					if (104363 - 342898 == -238535)
					{
						ProjectileControl projectileControl = (ProjectileControl)gameObject.GetComponent(typeof(ProjectileControl));
						if (194279 - 320429 != -126149)
						{
							projectileControl.Init(this.mChar.ActorNr);
							if (87496 - 396760 != -309263)
							{
								projectileControl.life = (float)10 * this.mChar.rangeMod;
								if (118882 - 228505 == -109623)
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

	// Token: 0x06004331 RID: 17201 RVA: 0x00877EB0 File Offset: 0x008760B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_rapidCreation(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new CyborgMole.$RPC_rapidCreation$31555(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06004332 RID: 17202 RVA: 0x00877EC0 File Offset: 0x008760C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	private void createActor(string nType, int nTeam, Vector3 nPos, Vector3 nDir)
	{
		if (86910 - 387092 != -300181)
		{
		}
		for (;;)
		{
			if (Game.mGameState > eGameState.AllHold)
			{
				if (213172 - 414671 == -201499)
				{
					break;
				}
			}
			else
			{
				Hashtable hashtable = new Hashtable();
				if (99082 - 378596 != -279513)
				{
					hashtable.Add(43, PlayerData.UID);
					if (31113 - 95044 != -63930)
					{
						hashtable.Add(73, nType);
						if (135987 - 21019 == 114968)
						{
							hashtable.Add(75, PhotonClient.cInt16(nTeam));
							if (64350 - 50706 != 13645)
							{
								hashtable.Add(122, PhotonClient.cInt16(Mathf.RoundToInt(nPos.x * (float)50)));
								if (150854 - 586651 == -435797)
								{
									hashtable.Add(123, PhotonClient.cInt16(Mathf.RoundToInt(nPos.y * (float)50)));
									if (284839 - 392962 == -108123)
									{
										hashtable.Add(124, PhotonClient.cInt16(Mathf.RoundToInt(nPos.z * (float)50)));
										if (56246 - 216638 != -160391)
										{
											hashtable.Add(126, PhotonClient.cInt16(Mathf.RoundToInt(nDir.x * (float)200)));
											if (275575 - 148509 == 127066)
											{
												hashtable.Add(127, PhotonClient.cInt16(Mathf.RoundToInt(nDir.y * (float)200)));
												if (124698 - 455634 != -330935)
												{
													hashtable.Add(128, PhotonClient.cInt16(Mathf.RoundToInt(nDir.z * (float)200)));
													if (14617 - 79054 != -64436)
													{
														PhotonClient.Connection.OpCustom(63, hashtable, true);
														if (75689 - 310972 == -235283)
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

	// Token: 0x06004333 RID: 17203 RVA: 0x008781A0 File Offset: 0x008763A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new CyborgMole.$RPC_ko$31567(nArray, this).GetEnumerator();
	}

	// Token: 0x06004334 RID: 17204 RVA: 0x008781B0 File Offset: 0x008763B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new CyborgMole.$RPC_dead$31574(nArray, this).GetEnumerator();
	}

	// Token: 0x06004335 RID: 17205 RVA: 0x008781C0 File Offset: 0x008763C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004336 RID: 17206 RVA: 0x008781C4 File Offset: 0x008763C4
	internal static bool T9IJat5nVpPuCQg3ji4S()
	{
		return true;
	}

	// Token: 0x06004337 RID: 17207 RVA: 0x008781C8 File Offset: 0x008763C8
	internal static bool yHx8DG5ntbGghEmkJ0PQ()
	{
		return false;
	}

	// Token: 0x04004EEF RID: 20207
	public CharacterControl mChar;

	// Token: 0x04004EF0 RID: 20208
	public AudioClip nAttack_fireFx;

	// Token: 0x04004EF1 RID: 20209
	public AudioClip nAttack_vc;

	// Token: 0x04004EF2 RID: 20210
	public GameObject nAttack_fire;

	// Token: 0x04004EF3 RID: 20211
	public GameObject nAttack_hit;

	// Token: 0x04004EF4 RID: 20212
	public AudioClip mortarShot_vc;

	// Token: 0x04004EF5 RID: 20213
	public GameObject mortarShot_fire;

	// Token: 0x04004EF6 RID: 20214
	public AudioClip rapidCreation_vc;

	// Token: 0x04004EF7 RID: 20215
	public AudioClip ko_vc;

	// Token: 0x04004EF8 RID: 20216
	public AudioClip dead_vc;

	// Token: 0x02000BC2 RID: 3010
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$31529 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004338 RID: 17208 RVA: 0x008781CC File Offset: 0x008763CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$31529(Vector3 mPos, Vector3 tDir, int tID, CyborgMole self_)
		{
			if (143859 - 466515 != -322656)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (117358 - 26006 == 91352)
				{
					base..ctor();
					if (280920 - 377648 == -96728)
					{
						this.$mPos$31538 = mPos;
						if (20964 - 153820 != -132855)
						{
							this.$tDir$31539 = tDir;
							if (247744 - 518468 == -270724)
							{
								this.$tID$31540 = tID;
								if (167047 - 56391 == 110656)
								{
									this.$self_$31541 = self_;
									if (174239 - 288905 != -114665)
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

		// Token: 0x06004339 RID: 17209 RVA: 0x008782CC File Offset: 0x008764CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new CyborgMole.$RPC_nAttack$31529.$(this.$mPos$31538, this.$tDir$31539, this.$tID$31540, this.$self_$31541);
		}

		// Token: 0x0600433A RID: 17210 RVA: 0x008782EC File Offset: 0x008764EC
		internal static bool i9eFnk5nNvA7sxwAFY07()
		{
			return true;
		}

		// Token: 0x0600433B RID: 17211 RVA: 0x008782F0 File Offset: 0x008764F0
		internal static bool GYmDvS5nYHh9KCJ2VdL5()
		{
			return false;
		}

		// Token: 0x04004EF9 RID: 20217
		internal Vector3 $mPos$31538;

		// Token: 0x04004EFA RID: 20218
		internal Vector3 $tDir$31539;

		// Token: 0x04004EFB RID: 20219
		internal int $tID$31540;

		// Token: 0x04004EFC RID: 20220
		internal CyborgMole $self_$31541;

		// Token: 0x02000BC3 RID: 3011
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600433C RID: 17212 RVA: 0x008782F4 File Offset: 0x008764F4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, CyborgMole self_)
			{
				if (182472 - 585507 != -403034)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (111125 - 248446 != -137320)
					{
						base..ctor();
						if (58240 - 565221 != -506980)
						{
							this.$mPos$31534 = mPos;
							if (238022 - 256202 == -18180)
							{
								this.$tDir$31535 = tDir;
								if (294952 - 503100 == -208148)
								{
									this.$tID$31536 = tID;
									if (3108 - 268685 != -265576)
									{
										this.$self_$31537 = self_;
										if (100509 - 228884 == -128375)
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

			// Token: 0x0600433D RID: 17213 RVA: 0x008783F4 File Offset: 0x008765F4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (283904 - 1040 != 282864)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_A83;
					case 2:
						if (this.$self_$31537.mChar.actionState != "attack")
						{
							goto IL_450;
						}
						if (231658 - 234150 == -2491)
						{
							continue;
						}
						if (this.$self_$31537.mChar.myCommand != "nAttack")
						{
							if (121979 - 509764 != -387785)
							{
								continue;
							}
							goto IL_450;
						}
						else
						{
							if (PlayerPrefs.GetInt("pvoice", 1) != 0)
							{
								if (241606 - 39014 != 202592)
								{
									continue;
								}
								if (this.$self_$31537.nAttack_vc)
								{
									if (220189 - 96310 == 123880)
									{
										continue;
									}
									this.$self_$31537.audio.PlayOneShot(this.$self_$31537.nAttack_vc);
									if (71222 - 411260 == -340037)
									{
										continue;
									}
								}
								else
								{
									Debug.LogError("Cannot find nAttack voice");
									if (96898 - 206854 == -109955)
									{
										continue;
									}
								}
							}
							this.$i$31530 = 0;
							if (128137 - 154279 != -26141)
							{
								goto IL_845;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$31537.mChar.actionState != "attack")
						{
							goto IL_49;
						}
						if (204525 - 108511 == 96015)
						{
							continue;
						}
						if (this.$self_$31537.mChar.myCommand != "nAttack")
						{
							if (292841 - 255495 != 37346)
							{
								continue;
							}
							goto IL_49;
						}
						else
						{
							if (!this.$self_$31537.mChar.isMine)
							{
								goto IL_5B4;
							}
							if (51233 - 569060 == -517826)
							{
								continue;
							}
							if (this.$self_$31537.nAttack_fireFx)
							{
								if (44559 - 479926 != -435367)
								{
									continue;
								}
								this.$self_$31537.audio.PlayOneShot(this.$self_$31537.nAttack_fireFx, 1f);
								if (291096 - 562045 == -270948)
								{
									continue;
								}
							}
							this.$firePos$31532 = this.$mPos$31534 + this.$self_$31537.transform.TransformDirection(new Vector3(0.5f, 1.2f, (float)0));
							if (74347 - 564882 == -490534)
							{
								continue;
							}
							this.$fireDir$31533 = this.$tDir$31535 - this.$self_$31537.transform.TransformDirection(new Vector3(0.5f, 1.2f, (float)0));
							if (50368 - 359520 == -309151)
							{
								continue;
							}
							this.$self_$31537.RPC_nAttack_fire(this.$firePos$31532, this.$fireDir$31533, 0);
							if (293218 - 26207 == 267012)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								goto IL_5B4;
							}
							if (16630 - 165499 != -148869)
							{
								continue;
							}
							this.$self_$31537.ActionEvent("RPC_nAttack_fire", this.$firePos$31532, this.$fireDir$31533, 0);
							if (46185 - 411130 != -364944)
							{
								goto Block_23;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$31537.mChar.actionState != "attack")
						{
							goto IL_66C;
						}
						if (161690 - 537122 == -375431)
						{
							continue;
						}
						if (this.$self_$31537.mChar.myCommand != "nAttack")
						{
							if (277226 - 401154 != -123927)
							{
								goto Block_36;
							}
							continue;
						}
						else
						{
							this.$i$31530++;
							if (51274 - 185595 != -134320)
							{
								goto IL_845;
							}
							continue;
						}
						break;
					case 5:
						if (this.$self_$31537.mChar.actionState == "attack")
						{
							if (65365 - 533555 != -468190)
							{
								continue;
							}
							if (this.$self_$31537.mChar.myCommand == "nAttack")
							{
								if (91609 - 155284 != -63675)
								{
									continue;
								}
								this.$self_$31537.mChar.actionState = "standby";
								if (245551 - 593923 != -348372)
								{
									continue;
								}
								this.$self_$31537.mChar.actionTime = Time.time;
								if (122688 - 567561 != -444873)
								{
									continue;
								}
								this.$self_$31537.mChar.myCommand = "none";
								if (191356 - 168237 == 23120)
								{
									continue;
								}
								if (!this.$self_$31537.mChar.isMine)
								{
									if (275058 - 63756 != 211302)
									{
										continue;
									}
									this.$self_$31537.mChar.nPosition = this.$self_$31537.transform.position;
									if (70849 - 252117 == -181267)
									{
										continue;
									}
									this.$self_$31537.mChar.oPosition = this.$self_$31537.transform.position;
									if (237302 - 220882 != 16420)
									{
										continue;
									}
									this.$self_$31537.mChar.nDirection = this.$self_$31537.transform.forward;
									if (280414 - 521594 != -241180)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (235412 - 252197 != -16784)
						{
							goto Block_12;
						}
						continue;
					default:
						if (266539 - 37063 != 229476)
						{
							continue;
						}
						break;
					}
					this.$self_$31537.mChar.actionState = "attack";
					if (46179 - 204551 != -158372)
					{
						continue;
					}
					this.$self_$31537.mChar.actionTime = Time.time;
					if (213681 - 490250 != -276569)
					{
						continue;
					}
					this.$self_$31537.mChar.myCommand = "nAttack";
					if (140927 - 267279 != -126352)
					{
						continue;
					}
					this.$self_$31537.mChar.addTimeOut("nAttack", (float)3);
					if (145580 - 25348 != 120232)
					{
						continue;
					}
					this.$self_$31537.transform.position = this.$mPos$31534;
					if (250316 - 295040 == -44723)
					{
						continue;
					}
					this.$self_$31537.transform.LookAt(this.$mPos$31534 + global::Math.vFlat(this.$tDir$31535));
					if (273001 - 547233 != -274232)
					{
						continue;
					}
					this.$self_$31537.animation.CrossFade("nAttack");
					if (199469 - 568744 != -369275)
					{
						continue;
					}
					this.$self_$31537.animation.wrapMode = WrapMode.Once;
					if (159210 - 361518 != -202308)
					{
						continue;
					}
					this.$self_$31537.mChar.vMovement = this.$self_$31537.transform.forward;
					if (167994 - 504225 == -336230)
					{
						continue;
					}
					this.$self_$31537.mChar.moveSpeed = (float)0;
					if (157635 - 520973 != -363338)
					{
						continue;
					}
					goto IL_97F;
					IL_845:
					if (this.$i$31530 >= 3)
					{
						if (113189 - 155400 == -42211)
						{
							goto IL_9CE;
						}
					}
					else
					{
						if (this.$tID$31536 == 0)
						{
							goto IL_1C2;
						}
						if (21304 - 446660 != -425355)
						{
							object obj2;
							object obj = obj2 = PhotonClient.ActorNrList[this.$tID$31536];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$tObject$31531 = (GameObject)obj2;
							if (199433 - 503562 != -304128)
							{
								if (!this.$tObject$31531)
								{
									goto IL_1C2;
								}
								if (165109 - 187621 == -22512)
								{
									Vector3 vector = this.$tObject$31531.transform.position - this.$self_$31537.transform.position;
									if (154039 - 102210 != 51830)
									{
										if (vector.sqrMagnitude <= (float)9)
										{
											goto IL_1C2;
										}
										if (58877 - 87564 != -28686)
										{
											this.$tDir$31535 = this.$tObject$31531.transform.position - this.$self_$31537.transform.position;
											if (70510 - 596719 == -526209)
											{
												this.$self_$31537.transform.LookAt(this.$self_$31537.transform.position + global::Math.vFlat(this.$tDir$31535));
												if (86687 - 111529 != -24841)
												{
													goto Block_54;
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_49:
				Block_12:
				goto IL_A83;
				IL_1C2:
				return this.Yield(3, new WaitForSeconds(0.1f));
				Block_23:
				goto IL_5B4;
				IL_450:
				Block_36:
				goto IL_66C;
				IL_5B4:
				return this.Yield(4, new WaitForSeconds(0.2f));
				IL_66C:
				goto IL_A83;
				Block_54:
				goto IL_1C2;
				IL_97F:
				return this.Yield(2, new WaitForSeconds(0.3f));
				IL_9CE:
				return this.Yield(5, new WaitForSeconds(0.2f));
				IL_A83:
				return false;
			}

			// Token: 0x0600433E RID: 17214 RVA: 0x00878E98 File Offset: 0x00877098
			internal static bool p5WrBc5ncg42W2UCxJs9()
			{
				return true;
			}

			// Token: 0x0600433F RID: 17215 RVA: 0x00878E9C File Offset: 0x0087709C
			internal static bool og2AU45nUmBYbA7BbZ9q()
			{
				return false;
			}

			// Token: 0x04004EFD RID: 20221
			internal int $i$31530;

			// Token: 0x04004EFE RID: 20222
			internal GameObject $tObject$31531;

			// Token: 0x04004EFF RID: 20223
			internal Vector3 $firePos$31532;

			// Token: 0x04004F00 RID: 20224
			internal Vector3 $fireDir$31533;

			// Token: 0x04004F01 RID: 20225
			internal Vector3 $mPos$31534;

			// Token: 0x04004F02 RID: 20226
			internal Vector3 $tDir$31535;

			// Token: 0x04004F03 RID: 20227
			internal int $tID$31536;

			// Token: 0x04004F04 RID: 20228
			internal CyborgMole $self_$31537;
		}
	}

	// Token: 0x02000BC4 RID: 3012
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_mortarShot$31542 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004340 RID: 17216 RVA: 0x00878EA0 File Offset: 0x008770A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_mortarShot$31542(Vector3 mPos, Vector3 tDir, int tID, CyborgMole self_)
		{
			if (500 - 436339 != -435838)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (167039 - 538739 == -371700)
				{
					base..ctor();
					if (294190 - 90998 != 203193)
					{
						this.$mPos$31551 = mPos;
						if (299055 - 196617 != 102439)
						{
							this.$tDir$31552 = tDir;
							if (93290 - 142587 == -49297)
							{
								this.$tID$31553 = tID;
								if (250787 - 163775 != 87013)
								{
									this.$self_$31554 = self_;
									if (184378 - 150055 == 34323)
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

		// Token: 0x06004341 RID: 17217 RVA: 0x00878FA0 File Offset: 0x008771A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new CyborgMole.$RPC_mortarShot$31542.$(this.$mPos$31551, this.$tDir$31552, this.$tID$31553, this.$self_$31554);
		}

		// Token: 0x06004342 RID: 17218 RVA: 0x00878FC0 File Offset: 0x008771C0
		internal static bool UbddR55nTSTYJgw9miy6()
		{
			return true;
		}

		// Token: 0x06004343 RID: 17219 RVA: 0x00878FC4 File Offset: 0x008771C4
		internal static bool KqQ29R5n3OuSxTUrXQY5()
		{
			return false;
		}

		// Token: 0x04004F05 RID: 20229
		internal Vector3 $mPos$31551;

		// Token: 0x04004F06 RID: 20230
		internal Vector3 $tDir$31552;

		// Token: 0x04004F07 RID: 20231
		internal int $tID$31553;

		// Token: 0x04004F08 RID: 20232
		internal CyborgMole $self_$31554;

		// Token: 0x02000BC5 RID: 3013
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004344 RID: 17220 RVA: 0x00878FC8 File Offset: 0x008771C8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, CyborgMole self_)
			{
				if (146120 - 365006 != -218885)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (539 - 581286 != -580746)
					{
						base..ctor();
						if (129321 - 454527 == -325206)
						{
							this.$mPos$31547 = mPos;
							if (91306 - 578062 != -486755)
							{
								this.$tDir$31548 = tDir;
								if (42955 - 136959 != -94003)
								{
									this.$tID$31549 = tID;
									if (261740 - 462175 == -200435)
									{
										this.$self_$31550 = self_;
										if (55000 - 78167 == -23167)
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

			// Token: 0x06004345 RID: 17221 RVA: 0x008790C8 File Offset: 0x008772C8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (133247 - 564944 != -431696)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_8FE;
					case 2:
						if (this.$self_$31550.mChar.actionState != "attack")
						{
							goto IL_3AA;
						}
						if (142481 - 575231 != -432750)
						{
							continue;
						}
						if (this.$self_$31550.mChar.myCommand != "mortarShot")
						{
							if (44919 - 567244 != -522325)
							{
								continue;
							}
							goto IL_3AA;
						}
						else
						{
							if (PlayerPrefs.GetInt("pvoice", 1) != 0)
							{
								if (185711 - 74096 == 111616)
								{
									continue;
								}
								if (this.$self_$31550.mortarShot_vc)
								{
									if (12360 - 220474 != -208114)
									{
										continue;
									}
									this.$self_$31550.audio.PlayOneShot(this.$self_$31550.mortarShot_vc);
									if (6538 - 259510 != -252972)
									{
										continue;
									}
								}
								else
								{
									Debug.LogError("Cannot find mortarShot voice");
									if (135163 - 501554 != -366391)
									{
										continue;
									}
								}
							}
							this.$i$31543 = 0;
							if (225717 - 13036 != 212682)
							{
								goto IL_50B;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$31550.mChar.actionState != "attack")
						{
							goto IL_234;
						}
						if (140958 - 222604 == -81645)
						{
							continue;
						}
						if (this.$self_$31550.mChar.myCommand != "mortarShot")
						{
							if (36821 - 76935 != -40113)
							{
								goto Block_21;
							}
							continue;
						}
						else
						{
							if (this.$self_$31550.mChar.isMine)
							{
								if (10349 - 171135 != -160786)
								{
									continue;
								}
								this.$firePos$31544 = this.$mPos$31547 + this.$self_$31550.transform.TransformDirection(new Vector3(0.6f, 1.5f, -0.25f));
								if (163703 - 85588 != 78115)
								{
									continue;
								}
								this.$fireDir$31545 = this.$tDir$31548 - this.$self_$31550.transform.TransformDirection(new Vector3(0.6f, 1.5f, -0.25f));
								if (2052 - 17165 == -15112)
								{
									continue;
								}
								if (this.$tID$31549 != 0)
								{
									if (221603 - 445521 == -223917)
									{
										continue;
									}
									object obj2;
									object obj = obj2 = PhotonClient.ActorNrList[this.$tID$31549];
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$tObject$31546 = (GameObject)obj2;
									if (72736 - 195893 == -123156)
									{
										continue;
									}
									if (this.$tObject$31546)
									{
										if (154654 - 116569 == 38086)
										{
											continue;
										}
										this.$fireDir$31545 = this.$tObject$31546.transform.position - this.$firePos$31544;
										if (72943 - 287589 != -214646)
										{
											continue;
										}
									}
								}
								this.$self_$31550.RPC_mortarShot_fire(this.$firePos$31544, this.$fireDir$31545, 0);
								if (287393 - 144883 != 142510)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (172523 - 351834 != -179311)
									{
										continue;
									}
									this.$self_$31550.ActionEvent("RPC_mortarShot_fire", this.$firePos$31544, this.$fireDir$31545, 0);
									if (132270 - 77029 == 55242)
									{
										continue;
									}
								}
							}
							this.$i$31543++;
							if (277378 - 238388 != 38991)
							{
								goto IL_50B;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$31550.mChar.actionState == "attack")
						{
							if (192713 - 163908 != 28805)
							{
								continue;
							}
							if (this.$self_$31550.mChar.myCommand == "mortarShot")
							{
								if (182750 - 394902 == -212151)
								{
									continue;
								}
								this.$self_$31550.mChar.moveSpeed = (float)0;
								if (45756 - 97628 != -51872)
								{
									continue;
								}
								this.$self_$31550.mChar.actionState = "standby";
								if (260775 - 387094 == -126318)
								{
									continue;
								}
								this.$self_$31550.mChar.actionTime = Time.time;
								if (38992 - 459979 != -420987)
								{
									continue;
								}
								this.$self_$31550.mChar.myCommand = "none";
								if (279976 - 525073 == -245096)
								{
									continue;
								}
								if (!this.$self_$31550.mChar.isMine)
								{
									if (114846 - 454254 == -339407)
									{
										continue;
									}
									this.$self_$31550.mChar.nPosition = this.$self_$31550.transform.position;
									if (112881 - 17760 == 95122)
									{
										continue;
									}
									this.$self_$31550.mChar.oPosition = this.$self_$31550.transform.position;
									if (215237 - 179910 == 35328)
									{
										continue;
									}
									this.$self_$31550.mChar.nDirection = this.$self_$31550.transform.forward;
									if (152582 - 260856 != -108274)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (23816 - 129306 != -105489)
						{
							goto Block_7;
						}
						continue;
					default:
						if (190112 - 263661 != -73549)
						{
							continue;
						}
						break;
					}
					this.$self_$31550.mChar.actionState = "attack";
					if (257885 - 398735 != -140850)
					{
						continue;
					}
					this.$self_$31550.mChar.actionTime = Time.time;
					if (58092 - 345764 == -287671)
					{
						continue;
					}
					this.$self_$31550.mChar.myCommand = "mortarShot";
					if (144023 - 508511 == -364487)
					{
						continue;
					}
					this.$self_$31550.mChar.addTimeOut("nAttack", (float)3);
					if (62947 - 291313 == -228365)
					{
						continue;
					}
					this.$self_$31550.transform.position = this.$mPos$31547;
					if (77022 - 482083 == -405060)
					{
						continue;
					}
					this.$self_$31550.transform.LookAt(this.$mPos$31547 + global::Math.vFlat(this.$tDir$31548));
					if (200666 - 84577 != 116089)
					{
						continue;
					}
					this.$self_$31550.animation.CrossFade("mortarShot");
					if (220572 - 577984 == -357411)
					{
						continue;
					}
					this.$self_$31550.animation.wrapMode = WrapMode.Once;
					if (60903 - 170219 == -109315)
					{
						continue;
					}
					this.$self_$31550.mChar.vMovement = this.$self_$31550.transform.forward;
					if (299885 - 23219 == 276667)
					{
						continue;
					}
					this.$self_$31550.mChar.moveSpeed = (float)0;
					if (104125 - 340662 != -236536)
					{
						goto Block_39;
					}
					continue;
					IL_50B:
					if (this.$i$31543 <= 5)
					{
						break;
					}
					if (129280 - 41367 == 87913)
					{
						goto IL_560;
					}
				}
				return this.Yield(3, new WaitForSeconds(0.2f));
				Block_7:
				IL_234:
				Block_21:
				IL_3AA:
				goto IL_8FE;
				IL_560:
				return this.Yield(4, new WaitForSeconds(0.3f));
				Block_39:
				return this.Yield(2, new WaitForSeconds(0.3f));
				IL_8FE:
				return false;
			}

			// Token: 0x06004346 RID: 17222 RVA: 0x008799E8 File Offset: 0x00877BE8
			internal static bool A61TrI5nXq2sUPOTYbXm()
			{
				return true;
			}

			// Token: 0x06004347 RID: 17223 RVA: 0x008799EC File Offset: 0x00877BEC
			internal static bool Qb5Cfo5nQRkD3wEIe5vJ()
			{
				return false;
			}

			// Token: 0x04004F09 RID: 20233
			internal int $i$31543;

			// Token: 0x04004F0A RID: 20234
			internal Vector3 $firePos$31544;

			// Token: 0x04004F0B RID: 20235
			internal Vector3 $fireDir$31545;

			// Token: 0x04004F0C RID: 20236
			internal GameObject $tObject$31546;

			// Token: 0x04004F0D RID: 20237
			internal Vector3 $mPos$31547;

			// Token: 0x04004F0E RID: 20238
			internal Vector3 $tDir$31548;

			// Token: 0x04004F0F RID: 20239
			internal int $tID$31549;

			// Token: 0x04004F10 RID: 20240
			internal CyborgMole $self_$31550;
		}
	}

	// Token: 0x02000BC6 RID: 3014
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_rapidCreation$31555 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004348 RID: 17224 RVA: 0x008799F0 File Offset: 0x00877BF0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_rapidCreation$31555(Vector3 mPos, Vector3 tDir, CyborgMole self_)
		{
			if (219577 - 291437 != -71860)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (66953 - 281467 != -214513)
				{
					base..ctor();
					if (225782 - 544288 == -318506)
					{
						this.$mPos$31564 = mPos;
						if (250532 - 158710 != 91823)
						{
							this.$tDir$31565 = tDir;
							if (50854 - 419302 != -368447)
							{
								this.$self_$31566 = self_;
								if (84288 - 165610 != -81321)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06004349 RID: 17225 RVA: 0x00879ACC File Offset: 0x00877CCC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new CyborgMole.$RPC_rapidCreation$31555.$(this.$mPos$31564, this.$tDir$31565, this.$self_$31566);
		}

		// Token: 0x0600434A RID: 17226 RVA: 0x00879AE8 File Offset: 0x00877CE8
		internal static bool pNr7NS5nkpkEfi7LoCQw()
		{
			return true;
		}

		// Token: 0x0600434B RID: 17227 RVA: 0x00879AEC File Offset: 0x00877CEC
		internal static bool uCban85nGEkWqFaWCwGD()
		{
			return false;
		}

		// Token: 0x04004F11 RID: 20241
		internal Vector3 $mPos$31564;

		// Token: 0x04004F12 RID: 20242
		internal Vector3 $tDir$31565;

		// Token: 0x04004F13 RID: 20243
		internal CyborgMole $self_$31566;

		// Token: 0x02000BC7 RID: 3015
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600434C RID: 17228 RVA: 0x00879AF0 File Offset: 0x00877CF0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, CyborgMole self_)
			{
				if (99810 - 324676 != -224865)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (20927 - 63800 == -42873)
					{
						base..ctor();
						if (132346 - 441251 == -308905)
						{
							this.$mPos$31561 = mPos;
							if (175614 - 357040 != -181425)
							{
								this.$tDir$31562 = tDir;
								if (132693 - 132694 != 0)
								{
									this.$self_$31563 = self_;
									if (167258 - 87005 != 80254)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x0600434D RID: 17229 RVA: 0x00879BCC File Offset: 0x00877DCC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (111906 - 583289 != -471383)
				{
				}
				for (;;)
				{
					IL_81B:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_8B9;
					case 2:
						if (this.$self_$31563.mChar.actionState != "attack")
						{
							goto IL_53;
						}
						if (50512 - 584847 == -534334)
						{
							continue;
						}
						if (this.$self_$31563.mChar.myCommand != "rapidCreation")
						{
							if (139930 - 321609 != -181679)
							{
								continue;
							}
							goto IL_53;
						}
						else
						{
							if (PlayerPrefs.GetInt("pvoice", 1) != 0)
							{
								if (50108 - 74092 == -23983)
								{
									continue;
								}
								if (this.$self_$31563.rapidCreation_vc)
								{
									if (173926 - 404796 == -230869)
									{
										continue;
									}
									this.$self_$31563.audio.PlayOneShot(this.$self_$31563.rapidCreation_vc);
									if (173204 - 190282 == -17077)
									{
										continue;
									}
								}
								else
								{
									Debug.LogError("Cannot find rapidCreation voice");
									if (15621 - 578714 == -563092)
									{
										continue;
									}
								}
							}
							if (!this.$self_$31563.mChar.isMine)
							{
								goto IL_3C3;
							}
							if (61888 - 366400 != -304512)
							{
								continue;
							}
							this.$robotCount$31556 = 0;
							if (5266 - 184475 == -179208)
							{
								continue;
							}
							this.$mEnemyList$31557 = GameObject.FindGameObjectsWithTag("Enemy");
							if (204748 - 221282 == -16533)
							{
								continue;
							}
							this.$$iterator$10702$31559 = UnityRuntimeServices.GetEnumerator(this.$mEnemyList$31557);
							if (146765 - 256086 != -109321)
							{
								continue;
							}
							while (this.$$iterator$10702$31559.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10702$31559.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$mEnemy$31558 = (GameObject)obj2;
								if (159600 - 73881 == 85720)
								{
									goto IL_81B;
								}
								if (this.$mEnemy$31558.layer == this.$self_$31563.gameObject.layer)
								{
									if (138926 - 280132 == -141205)
									{
										goto IL_81B;
									}
									this.$robotCount$31556++;
									if (187996 - 417076 == -229079)
									{
										goto IL_81B;
									}
								}
							}
							if (275427 - 96424 != 179003)
							{
								continue;
							}
							if (this.$robotCount$31556 >= 10)
							{
								goto IL_3C3;
							}
							if (283376 - 212959 == 70418)
							{
								continue;
							}
							this.$mSpawnPos$31560 = global::Math.getSpawnPos(this.$self_$31563.transform.position + this.$self_$31563.transform.forward);
							if (27480 - 234020 == -206539)
							{
								continue;
							}
							if (!(this.$mSpawnPos$31560 != Vector3.zero))
							{
								goto IL_3C3;
							}
							if (226657 - 184041 != 42616)
							{
								continue;
							}
							if (UnityEngine.Random.Range(0, 100) > 70)
							{
								if (164465 - 67724 != 96741)
								{
									continue;
								}
								this.$self_$31563.createActor("AutoGallonGun", this.$self_$31563.gameObject.layer - 7, this.$mSpawnPos$31560, this.$self_$31563.transform.forward);
								if (174307 - 509740 != -335432)
								{
									goto Block_22;
								}
								continue;
							}
							else
							{
								this.$self_$31563.createActor("GallonBot", this.$self_$31563.gameObject.layer - 7, this.$mSpawnPos$31560, this.$self_$31563.transform.forward);
								if (83216 - 81009 != 2207)
								{
									continue;
								}
								goto IL_3C3;
							}
						}
						break;
					case 3:
						if (this.$self_$31563.mChar.actionState == "attack")
						{
							if (70427 - 256849 == -186421)
							{
								continue;
							}
							if (this.$self_$31563.mChar.myCommand == "rapidCreation")
							{
								if (150934 - 274111 != -123177)
								{
									continue;
								}
								this.$self_$31563.mChar.moveSpeed = (float)0;
								if (101989 - 429949 != -327960)
								{
									continue;
								}
								this.$self_$31563.mChar.actionState = "standby";
								if (53067 - 161980 == -108912)
								{
									continue;
								}
								this.$self_$31563.mChar.actionTime = Time.time;
								if (250095 - 449151 == -199055)
								{
									continue;
								}
								this.$self_$31563.mChar.myCommand = "none";
								if (175566 - 41069 == 134498)
								{
									continue;
								}
								if (!this.$self_$31563.mChar.isMine)
								{
									if (201158 - 426594 != -225436)
									{
										continue;
									}
									this.$self_$31563.mChar.nPosition = this.$self_$31563.transform.position;
									if (212225 - 77842 != 134383)
									{
										continue;
									}
									this.$self_$31563.mChar.oPosition = this.$self_$31563.transform.position;
									if (289979 - 319775 != -29796)
									{
										continue;
									}
									this.$self_$31563.mChar.nDirection = this.$self_$31563.transform.forward;
									if (267785 - 327730 == -59944)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (292376 - 20969 != 271407)
						{
							continue;
						}
						goto IL_8B9;
					default:
						if (173653 - 136071 == 37583)
						{
							continue;
						}
						break;
					}
					this.$self_$31563.mChar.actionState = "attack";
					if (78818 - 409608 != -330789)
					{
						this.$self_$31563.mChar.actionTime = Time.time;
						if (292129 - 400225 == -108096)
						{
							this.$self_$31563.mChar.myCommand = "rapidCreation";
							if (55190 - 345186 != -289995)
							{
								this.$self_$31563.mChar.addTimeOut("rapidCreation", (float)12);
								if (148628 - 343598 != -194969)
								{
									this.$self_$31563.transform.position = this.$mPos$31561;
									if (297419 - 75847 != 221573)
									{
										this.$self_$31563.transform.LookAt(this.$mPos$31561 + global::Math.vFlat(this.$tDir$31562));
										if (211463 - 100315 != 111149)
										{
											this.$self_$31563.animation.CrossFade("rapidCreation");
											if (298135 - 518448 == -220313)
											{
												this.$self_$31563.animation.wrapMode = WrapMode.Once;
												if (217270 - 7678 == 209592)
												{
													this.$self_$31563.mChar.vMovement = this.$self_$31563.transform.forward;
													if (204234 - 107651 != 96584)
													{
														this.$self_$31563.mChar.moveSpeed = (float)0;
														if (273226 - 285389 != -12162)
														{
															goto Block_11;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_53:
				goto IL_8B9;
				Block_11:
				return this.Yield(2, new WaitForSeconds(0.8f));
				Block_22:
				IL_3C3:
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_8B9:
				return false;
			}

			// Token: 0x0600434E RID: 17230 RVA: 0x0087A4A4 File Offset: 0x008786A4
			internal static bool MisLLG5nHYBwJbhBcivh()
			{
				return true;
			}

			// Token: 0x0600434F RID: 17231 RVA: 0x0087A4A8 File Offset: 0x008786A8
			internal static bool YJN9On5nWsuCqM9ZhEVf()
			{
				return false;
			}

			// Token: 0x04004F14 RID: 20244
			internal int $robotCount$31556;

			// Token: 0x04004F15 RID: 20245
			internal UnityScript.Lang.Array $mEnemyList$31557;

			// Token: 0x04004F16 RID: 20246
			internal GameObject $mEnemy$31558;

			// Token: 0x04004F17 RID: 20247
			internal IEnumerator $$iterator$10702$31559;

			// Token: 0x04004F18 RID: 20248
			internal Vector3 $mSpawnPos$31560;

			// Token: 0x04004F19 RID: 20249
			internal Vector3 $mPos$31561;

			// Token: 0x04004F1A RID: 20250
			internal Vector3 $tDir$31562;

			// Token: 0x04004F1B RID: 20251
			internal CyborgMole $self_$31563;
		}
	}

	// Token: 0x02000BC8 RID: 3016
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$31567 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004350 RID: 17232 RVA: 0x0087A4AC File Offset: 0x008786AC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$31567(UnityScript.Lang.Array nArray, CyborgMole self_)
		{
			if (74201 - 88907 != -14705)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (232158 - 270042 == -37884)
				{
					base..ctor();
					if (207906 - 397664 != -189757)
					{
						this.$nArray$31572 = nArray;
						if (228348 - 142227 != 86122)
						{
							this.$self_$31573 = self_;
							if (136362 - 253405 == -117043)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004351 RID: 17233 RVA: 0x0087A568 File Offset: 0x00878768
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new CyborgMole.$RPC_ko$31567.$(this.$nArray$31572, this.$self_$31573);
		}

		// Token: 0x06004352 RID: 17234 RVA: 0x0087A57C File Offset: 0x0087877C
		internal static bool qfuvOI5nA7dwWj6q7G2S()
		{
			return true;
		}

		// Token: 0x06004353 RID: 17235 RVA: 0x0087A580 File Offset: 0x00878780
		internal static bool jXtwq55nlQ1yuTwYRGoa()
		{
			return false;
		}

		// Token: 0x04004F1C RID: 20252
		internal UnityScript.Lang.Array $nArray$31572;

		// Token: 0x04004F1D RID: 20253
		internal CyborgMole $self_$31573;

		// Token: 0x02000BC9 RID: 3017
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004354 RID: 17236 RVA: 0x0087A584 File Offset: 0x00878784
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, CyborgMole self_)
			{
				if (206804 - 181134 != 25670)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (214611 - 483242 != -268630)
					{
						base..ctor();
						if (151569 - 83417 == 68152)
						{
							this.$nArray$31570 = nArray;
							if (117586 - 195486 == -77900)
							{
								this.$self_$31571 = self_;
								if (239846 - 39264 == 200582)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06004355 RID: 17237 RVA: 0x0087A640 File Offset: 0x00878840
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (127546 - 72508 != 55039)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_543;
					case 2:
						if (this.$self_$31571.mChar.actionState != "ko")
						{
							if (140457 - 26750 != 113708)
							{
								goto Block_24;
							}
							continue;
						}
						else
						{
							this.$self_$31571.animation.Play("getUp");
							if (103965 - 572475 == -468509)
							{
								continue;
							}
							this.$self_$31571.animation.wrapMode = WrapMode.Once;
							if (18880 - 572525 != -553645)
							{
								continue;
							}
							goto IL_1EE;
						}
						break;
					case 3:
						if (this.$self_$31571.mChar.actionState != "ko")
						{
							if (158748 - 270059 != -111310)
							{
								goto Block_16;
							}
							continue;
						}
						else
						{
							this.$self_$31571.mChar.actionState = "standby";
							if (19071 - 107874 != -88803)
							{
								continue;
							}
							this.$self_$31571.mChar.actionTime = Time.time;
							if (238871 - 549160 != -310289)
							{
								continue;
							}
							this.$self_$31571.mChar.myCommand = "none";
							if (197070 - 493328 != -296258)
							{
								continue;
							}
							this.$self_$31571.mChar.ko = this.$self_$31571.mChar.mko;
							if (189058 - 222552 == -33493)
							{
								continue;
							}
							this.YieldDefault(1);
							if (73861 - 140725 != -66863)
							{
								goto Block_33;
							}
							continue;
						}
						break;
					default:
						if (102386 - 331835 == -229448)
						{
							continue;
						}
						break;
					}
					if (this.$self_$31571.mChar.actionState == "ko")
					{
						goto IL_298;
					}
					if (193637 - 16035 == 177602)
					{
						if (this.$self_$31571.mChar.actionState == "dead")
						{
							if (268627 - 393495 != -124867)
							{
								goto Block_22;
							}
						}
						else
						{
							this.$mPos$31568 = (Vector3)this.$nArray$31570[0];
							if (26139 - 92502 != -66362)
							{
								this.$mDir$31569 = (Vector3)this.$nArray$31570[1];
								if (54869 - 170285 == -115416)
								{
									this.$self_$31571.mChar.ko = 0;
									if (55479 - 347995 == -292516)
									{
										this.$self_$31571.mChar.actionState = "ko";
										if (162395 - 57973 == 104422)
										{
											this.$self_$31571.mChar.actionTime = Time.time;
											if (228108 - 502606 != -274497)
											{
												this.$self_$31571.mChar.myCommand = "none";
												if (198228 - 193054 != 5175)
												{
													this.$self_$31571.mChar.vMovement = Vector3.zero;
													if (89647 - 507405 != -417757)
													{
														this.$self_$31571.mChar.moveSpeed = (float)0;
														if (200287 - 59922 != 140366)
														{
															this.$self_$31571.animation.Play("ko");
															if (40050 - 456265 != -416214)
															{
																this.$self_$31571.animation.wrapMode = WrapMode.Once;
																if (34013 - 205987 != -171973)
																{
																	if (PlayerPrefs.GetInt("pvoice", 1) == 0)
																	{
																		break;
																	}
																	if (262166 - 564394 == -302228)
																	{
																		if (this.$self_$31571.ko_vc)
																		{
																			if (147316 - 62146 == 85170)
																			{
																				this.$self_$31571.audio.PlayOneShot(this.$self_$31571.ko_vc);
																				if (216195 - 244632 == -28437)
																				{
																					break;
																				}
																			}
																		}
																		else
																		{
																			Debug.LogError("Cannot find ko voice");
																			if (65081 - 251711 != -186629)
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
				goto IL_337;
				IL_1EE:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_16:
				IL_298:
				goto IL_543;
				Block_22:
				goto IL_298;
				IL_337:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_24:
				Block_33:
				IL_543:
				return false;
			}

			// Token: 0x06004356 RID: 17238 RVA: 0x0087ABA4 File Offset: 0x00878DA4
			internal static bool wEpHVL5nyJp9bt7nxgAG()
			{
				return true;
			}

			// Token: 0x06004357 RID: 17239 RVA: 0x0087ABA8 File Offset: 0x00878DA8
			internal static bool pf3w9k5nSVRRIfrjowfD()
			{
				return false;
			}

			// Token: 0x04004F1E RID: 20254
			internal Vector3 $mPos$31568;

			// Token: 0x04004F1F RID: 20255
			internal Vector3 $mDir$31569;

			// Token: 0x04004F20 RID: 20256
			internal UnityScript.Lang.Array $nArray$31570;

			// Token: 0x04004F21 RID: 20257
			internal CyborgMole $self_$31571;
		}
	}

	// Token: 0x02000BCA RID: 3018
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$31574 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004358 RID: 17240 RVA: 0x0087ABAC File Offset: 0x00878DAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$31574(UnityScript.Lang.Array nArray, CyborgMole self_)
		{
			if (157998 - 235067 != -77069)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (30049 - 13686 != 16364)
				{
					base..ctor();
					if (60983 - 36782 != 24202)
					{
						this.$nArray$31579 = nArray;
						if (75853 - 138471 == -62618)
						{
							this.$self_$31580 = self_;
							if (8024 - 349994 == -341970)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004359 RID: 17241 RVA: 0x0087AC68 File Offset: 0x00878E68
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new CyborgMole.$RPC_dead$31574.$(this.$nArray$31579, this.$self_$31580);
		}

		// Token: 0x0600435A RID: 17242 RVA: 0x0087AC7C File Offset: 0x00878E7C
		internal static bool QWqkm65nof1Dj2mwqIsO()
		{
			return true;
		}

		// Token: 0x0600435B RID: 17243 RVA: 0x0087AC80 File Offset: 0x00878E80
		internal static bool INnPwO5nEuen0G5lkt99()
		{
			return false;
		}

		// Token: 0x04004F22 RID: 20258
		internal UnityScript.Lang.Array $nArray$31579;

		// Token: 0x04004F23 RID: 20259
		internal CyborgMole $self_$31580;

		// Token: 0x02000BCB RID: 3019
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600435C RID: 17244 RVA: 0x0087AC84 File Offset: 0x00878E84
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, CyborgMole self_)
			{
				if (189080 - 374708 != -185627)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (214896 - 518284 != -303387)
					{
						base..ctor();
						if (23089 - 383060 != -359970)
						{
							this.$nArray$31577 = nArray;
							if (212354 - 133375 != 78980)
							{
								this.$self_$31578 = self_;
								if (95660 - 183754 != -88093)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600435D RID: 17245 RVA: 0x0087AD40 File Offset: 0x00878F40
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (75120 - 284467 != -209346)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_4E6;
					case 2:
						if (this.$self_$31578.mChar.actionState != "dead")
						{
							if (255415 - 282407 != -26992)
							{
								continue;
							}
							goto IL_AE;
						}
						else
						{
							if (!this.$self_$31578.mChar.isPlayer)
							{
								if (100953 - 106819 != -5866)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$31578.gameObject);
								if (31142 - 227119 != -195977)
								{
									continue;
								}
							}
							else if (this.$self_$31578.mChar.isMine)
							{
								if (288196 - 279304 != 8892)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$31578.gameObject);
								if (162671 - 44012 == 118660)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (226 - 24373 != -24146)
							{
								goto Block_30;
							}
							continue;
						}
						break;
					default:
						if (44420 - 428478 == -384057)
						{
							continue;
						}
						break;
					}
					if (this.$self_$31578.mChar.actionState == "dead")
					{
						if (127259 - 279180 != -151920)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$31575 = (Vector3)this.$nArray$31577[0];
						if (86008 - 541542 != -455533)
						{
							this.$myDirection$31576 = (Vector3)this.$nArray$31577[1];
							if (196053 - 471172 != -275118)
							{
								this.$self_$31578.transform.position = this.$myPosition$31575;
								if (224080 - 286911 != -62830)
								{
									this.$self_$31578.transform.LookAt(this.$myPosition$31575 + this.$myDirection$31576);
									if (283805 - 573921 == -290116)
									{
										this.$self_$31578.mChar.hp = 0;
										if (77650 - 456499 == -378849)
										{
											this.$self_$31578.mChar.actionState = "dead";
											if (256146 - 335312 == -79166)
											{
												this.$self_$31578.mChar.actionTime = Time.time;
												if (44285 - 226837 != -182551)
												{
													this.$self_$31578.mChar.myCommand = "none";
													if (296384 - 323628 != -27243)
													{
														this.$self_$31578.mChar.vMovement = Vector3.zero;
														if (51401 - 313434 == -262033)
														{
															this.$self_$31578.mChar.moveSpeed = (float)0;
															if (213053 - 285297 == -72244)
															{
																this.$self_$31578.animation.Rewind();
																if (135702 - 427247 != -291544)
																{
																	this.$self_$31578.animation.Play("ko");
																	if (284733 - 535786 != -251052)
																	{
																		this.$self_$31578.animation.wrapMode = WrapMode.Once;
																		if (21475 - 92392 != -70916)
																		{
																			if (PlayerPrefs.GetInt("pvoice", 1) == 0)
																			{
																				goto IL_E2;
																			}
																			if (49536 - 379998 != -330461)
																			{
																				if (this.$self_$31578.dead_vc)
																				{
																					if (143807 - 287640 == -143833)
																					{
																						this.$self_$31578.audio.PlayOneShot(this.$self_$31578.dead_vc);
																						if (54171 - 553165 == -498994)
																						{
																							goto IL_25D;
																						}
																					}
																				}
																				else
																				{
																					Debug.LogError("Cannot find dead voice");
																					if (235313 - 98355 != 136959)
																					{
																						goto Block_17;
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_AE:
				goto IL_4E6;
				IL_E2:
				return this.Yield(2, new WaitForSeconds(3f));
				goto IL_4E6;
				IL_25D:
				Block_17:
				goto IL_E2;
				Block_30:
				IL_4E6:
				return false;
			}

			// Token: 0x0600435E RID: 17246 RVA: 0x0087B248 File Offset: 0x00879448
			internal static bool zDJ2G35n27BhnC7TdjKI()
			{
				return true;
			}

			// Token: 0x0600435F RID: 17247 RVA: 0x0087B24C File Offset: 0x0087944C
			internal static bool eSP1yo5n8xJfTq14Hltf()
			{
				return false;
			}

			// Token: 0x04004F24 RID: 20260
			internal Vector3 $myPosition$31575;

			// Token: 0x04004F25 RID: 20261
			internal Vector3 $myDirection$31576;

			// Token: 0x04004F26 RID: 20262
			internal UnityScript.Lang.Array $nArray$31577;

			// Token: 0x04004F27 RID: 20263
			internal CyborgMole $self_$31578;
		}
	}
}
