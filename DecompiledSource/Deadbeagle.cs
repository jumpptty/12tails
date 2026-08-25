using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000BE7 RID: 3047
[Serializable]
public class Deadbeagle : MonoBehaviour
{
	// Token: 0x060043FC RID: 17404 RVA: 0x0088C5FC File Offset: 0x0088A7FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Deadbeagle()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060043FD RID: 17405 RVA: 0x0088C60C File Offset: 0x0088A80C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (35559 - 282432 != -246872)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (158869 - 207020 == -48151)
			{
				this.mChar.actionState = "standby";
				if (124225 - 225822 != -101596)
				{
					this.mChar.actionTime = Time.time;
					if (19404 - 264939 == -245535)
					{
						this.mChar.myCommand = "none";
						if (147027 - 50453 == 96574)
						{
							this.mChar.hp = (this.mChar.mhp = 560);
							if (171531 - 213303 != -41771)
							{
								this.mChar.ko = (this.mChar.mko = 30);
								if (17046 - 225853 != -208806)
								{
									this.mChar.atk = 86;
									if (29423 - 172322 != -142898)
									{
										this.mChar.def = 96;
										if (223996 - 285923 == -61927)
										{
											this.mChar.agi = 40;
											if (69298 - 381165 != -311866)
											{
												this.mChar.vit = 56;
												if (188224 - 337182 != -148957)
												{
													this.mChar.mag = 20;
													if (291601 - 397537 != -105935)
													{
														this.mChar.cha = 45;
														if (205053 - 597213 == -392160)
														{
															this.mChar.tal = 40;
															if (21753 - 247276 == -225523)
															{
																this.mChar.lck = 70;
																if (293991 - 246428 == 47563)
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

	// Token: 0x060043FE RID: 17406 RVA: 0x0088C89C File Offset: 0x0088AA9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (41444 - 212637 != -171193)
		{
		}
		for (;;)
		{
			if (Game.mGameType == 99)
			{
				if (178154 - 203234 == -25079)
				{
					continue;
				}
				this.mChar.isMine = true;
				if (51647 - 316975 != -265328)
				{
					continue;
				}
			}
			if (!this.mChar)
			{
				break;
			}
			if (203827 - 43548 != 160280)
			{
				this.mChar.StartCoroutine_Auto(this.mChar.addStatus("livingDead", 1, 300, 0, this.mChar.ActorNr));
				if (41288 - 582107 != -540818)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060043FF RID: 17407 RVA: 0x0088C994 File Offset: 0x0088AB94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (269467 - 35836 != 233631)
		{
		}
		for (;;)
		{
			if (!this.mChar)
			{
				if (184498 - 547323 == -362825)
				{
					break;
				}
			}
			else
			{
				if (this.mChar.isControlled)
				{
					if (40405 - 141978 != -101573)
					{
						continue;
					}
					if (!(this.mChar.actionState == "standby"))
					{
						if (214886 - 153997 != 60889)
						{
							continue;
						}
						if (!(this.mChar.actionState == "run"))
						{
							goto IL_D9;
						}
						if (231816 - 314403 != -82587)
						{
							continue;
						}
					}
					this.PlayerControl();
					if (20950 - 218687 == -197736)
					{
						continue;
					}
				}
				IL_D9:
				if (this.mChar.hp <= 0)
				{
					if (218383 - 411057 != -192674)
					{
						continue;
					}
					if (this.mChar.actionState != "dead")
					{
						if (90123 - 82919 != 7204)
						{
							continue;
						}
						if (this.mChar.isMine)
						{
							if (223189 - 479556 != -256367)
							{
								continue;
							}
							statusClass status = this.mChar.getStatus("livingDead");
							if (185426 - 309344 != -123918)
							{
								continue;
							}
							if (status != null)
							{
								if (262540 - 397880 != -135340)
								{
									continue;
								}
								this.mChar.hp = 1;
								if (245714 - 280819 != -35105)
								{
									continue;
								}
								this.mChar.RPC_RemoveStatus("livingDead");
								if (120931 - 523810 != -402879)
								{
									continue;
								}
								this.RPC_livingDead_hit(Vector3.zero, Vector3.zero, 0);
								if (71822 - 500554 == -428731)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (40875 - 191599 != -150724)
									{
										continue;
									}
									this.ActionEvent("RPC_livingDead_hit", Vector3.zero, Vector3.zero, 0);
									if (260043 - 572531 == -312487)
									{
										continue;
									}
								}
								this.mChar.RPC_AddHeal(21, this.mChar.mhp, 0, 0, 0, 0, status.sID);
								if (61366 - 493123 != -431756)
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
								if (276354 - 121089 == 155266)
								{
									continue;
								}
								if (!PhotonClient.IsInitialized())
								{
									break;
								}
								if (277691 - 350952 != -73261)
								{
									continue;
								}
								this.mChar.DeadEvent();
								if (261231 - 315353 != -54122)
								{
									continue;
								}
								break;
							}
						}
						else
						{
							this.mChar.hp = 1;
							if (113240 - 544034 != -430794)
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
				if (99990 - 139427 != -39436)
				{
					if (this.mChar.ko > 0)
					{
						break;
					}
					if (115932 - 408042 != -292109)
					{
						if (!(this.mChar.actionState != "ko"))
						{
							break;
						}
						if (186620 - 344057 != -157436)
						{
							if (!(this.mChar.actionState != "dead"))
							{
								break;
							}
							if (247917 - 417357 == -169440)
							{
								if (this.mChar.isMine)
								{
									if (232834 - 243045 != -10210)
									{
										this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
										{
											this.transform.position,
											this.transform.forward
										})));
										if (177350 - 107513 != 69838)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (297792 - 523744 == -225952)
											{
												this.mChar.KoEvent();
												if (7127 - 54044 != -46916)
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
									if (257467 - 273809 != -16341)
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

	// Token: 0x06004400 RID: 17408 RVA: 0x0088CF18 File Offset: 0x0088B118
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (65146 - 555805 != -490659)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (212475 - 145314 == 67161)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (154351 - 427977 == -273626)
				{
					if (26186 - 78753 == -52567)
					{
						if (ActionName == "RPC_nAttack")
						{
							if (187309 - 179879 == 7431)
							{
								continue;
							}
							v = 1;
							if (276663 - 450337 != -173674)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_hit")
						{
							if (166405 - 489466 == -323060)
							{
								continue;
							}
							v = -1;
							if (112681 - 44452 == 68230)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_livingDead_hit")
						{
							if (45385 - 287388 == -242002)
							{
								continue;
							}
							v = -50;
							if (26257 - 538933 != -512676)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (62333 - 232397 == -170063)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (56354 - 308357 != -252002)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (191991 - 90736 == 101255)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (143511 - 264791 != -121279)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (278789 - 84309 == 194480)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (7901 - 524613 == -516712)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (110283 - 393846 != -283562)
											{
												Hashtable hashtable = new Hashtable();
												if (136571 - 572369 == -435798)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (119250 - 162214 != -42963)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (222845 - 486256 != -263410)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (13286 - 595346 != -582059)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (241208 - 270010 == -28802)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (139759 - 70360 == 69399)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (166298 - 553474 == -387176)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (14657 - 457126 == -442469)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (173283 - 332948 != -159664)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (89662 - 105990 != -16327)
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

	// Token: 0x06004401 RID: 17409 RVA: 0x0088D3E4 File Offset: 0x0088B5E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (247965 - 257363 != -9398)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (156962 - 341249 != -184286)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (252436 - 511091 == -258655)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (78059 - 510640 == -432581)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (211470 - 47377 == 164093)
						{
							int num3 = num;
							if (64004 - 78134 != -14129)
							{
								if (num3 == 1)
								{
									if (206494 - 248286 == -41792)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (196742 - 442593 == -245851)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (101314 - 546431 == -445117)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (132888 - 311882 == -178994)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (95468 - 36003 != 59466)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (148896 - 348013 != -199116)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -50)
								{
									if (164294 - 312181 != -147886)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (227494 - 512909 == -285415)
										{
											this.RPC_livingDead_hit(vector, vector2, num2);
											if (89774 - 323143 == -233369)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (71170 - 407115 == -335945)
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

	// Token: 0x06004402 RID: 17410 RVA: 0x0088D6EC File Offset: 0x0088B8EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (73560 - 542806 != -469245)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (70451 - 111669 == -41218)
			{
				float runSpeed = this.mChar.runSpeed;
				if (46916 - 542230 != -495313)
				{
					Vector3 a = default(Vector3);
					if (36811 - 299502 == -262691)
					{
						Vector3 vector = Vector3.zero;
						if (164825 - 524018 != -359192)
						{
							float num2 = (float)0;
							if (218626 - 5143 == 213483)
							{
								if (this.mChar.isMine)
								{
									if (40079 - 535559 == -495479)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (254715 - 241180 == 13536)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (173805 - 354642 != -180837)
										{
											continue;
										}
										a.y = (float)0;
										if (46602 - 113127 != -66525)
										{
											continue;
										}
										a = a.normalized;
										if (217214 - 441683 == -224468)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (98074 - 113836 != -15762)
										{
											continue;
										}
										vector = vector.normalized;
										if (135129 - 391485 == -256355)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (48395 - 78073 == -29677)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (65071 - 298450 != -233379)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (287015 - 586197 == -299181)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (22618 - 436853 == -414234)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (137116 - 1959 != 135157)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (56508 - 169848 != -113340)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (165546 - 296917 != -131371)
														{
															continue;
														}
														this.animation.Play("run");
														if (109235 - 563311 != -454076)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (251289 - 144402 != 106887)
														{
															continue;
														}
														goto IL_267;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (54365 - 301825 == -247459)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (260186 - 496845 == -236658)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (169530 - 288947 == -119416)
											{
												continue;
											}
											num = (float)0;
											if (185228 - 214463 == -29234)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (174218 - 278180 == -103961)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (8538 - 464579 == -456040)
										{
											continue;
										}
									}
									IL_267:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (281635 - 447061 == -165425)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (275174 - 437982 != -162808)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (200326 - 463853 != -263527)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (172087 - 394797 != -222710)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (183871 - 466304 == -282432)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (20295 - 424077 != -403782)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (223956 - 82035 != 141921)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (207194 - 559241 == -352046)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (229455 - 3595 != 225860)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (204954 - 12798 == 192157)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (240334 - 177514 == 62821)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (4773 - 241630 != -236857)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (30411 - 323926 != -293515)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (224297 - 143891 == 80407)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (224787 - 117987 == 106801)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (243564 - 592947 == -349382)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (19268 - 233212 == -213943)
												{
													continue;
												}
												num = (float)0;
												if (147523 - 535916 == -388392)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (82897 - 80471 != 2426)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (232536 - 244453 != -11917)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (186283 - 101409 != 84874)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (288339 - 510191 == -221851)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (133287 - 530931 != -397644)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (149899 - 542141 == -392241)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (148016 - 183192 == -35175)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (105639 - 191228 == -85588)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (99171 - 91649 == 7523)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (25726 - 155334 != -129608)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (139652 - 592111 != -452459)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (247715 - 584274 != -336559)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (176125 - 203739 == -27613)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (104032 - 350096 != -246064)
											{
												continue;
											}
											num = (float)0;
											if (78051 - 96857 != -18806)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (130562 - 585563 == -455000)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (95449 - 265166 == -169716)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (219851 - 264301 == -44449)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (246557 - 421776 == -175218)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (290032 - 30734 == 259298)
								{
									this.mChar.moveSpeed = num;
									if (141047 - 286870 != -145822)
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

	// Token: 0x06004403 RID: 17411 RVA: 0x0088E250 File Offset: 0x0088C450
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (235293 - 479944 != -244650)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (133371 - 594663 == -461292)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (92285 - 163399 != -71113)
				{
					Vector3 vector = a - this.transform.position;
					if (222974 - 36738 != 186237)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (229662 - 203466 == 26196)
						{
							CharacterControl characterControl = null;
							if (45965 - 127197 != -81231 && 199149 - 160498 != 38652)
							{
								if (gameObject)
								{
									if (248185 - 591676 == -343490)
									{
										continue;
									}
									characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (77462 - 501956 == -424493)
									{
										continue;
									}
								}
								if (characterControl)
								{
									if (85707 - 462781 != -377074)
									{
										continue;
									}
									int actorNr = characterControl.ActorNr;
									if (161723 - 512464 == -350740)
									{
										continue;
									}
								}
								if (!(this.mChar.actionState == "standby"))
								{
									if (183666 - 73170 != 110496)
									{
										continue;
									}
									if (!(this.mChar.actionState == "run"))
									{
										break;
									}
									if (219968 - 575896 != -355928)
									{
										continue;
									}
								}
								if (this.mChar.isTimeOut("nAttack") != (float)0)
								{
									break;
								}
								if (57899 - 106009 != -48109)
								{
									this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, vector, 0));
									if (226777 - 421866 != -195088)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (214487 - 198518 != 15970)
										{
											this.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
											if (15331 - 303259 != -287927)
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

	// Token: 0x06004404 RID: 17412 RVA: 0x0088E548 File Offset: 0x0088C748
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (109667 - 189045 != -79378)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (86015 - 443798 == -357783)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (255610 - 376639 == -121029)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (182893 - 415003 == -232110)
					{
						Vector3 normalized = vector.normalized;
						if (115628 - 271073 == -155445)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (101844 - 260051 != -158206)
							{
								CharacterControl characterControl = null;
								if (23752 - 7839 != 15914)
								{
									if (11267 - 134055 == -122788)
									{
										if (gameObject)
										{
											if (207506 - 192220 != 15286)
											{
												continue;
											}
											characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (225540 - 529771 != -304231)
											{
												continue;
											}
										}
										if (characterControl)
										{
											if (234660 - 432830 != -198170)
											{
												continue;
											}
											int actorNr = characterControl.ActorNr;
											if (256320 - 525416 == -269095)
											{
												continue;
											}
										}
										if (!(this.mChar.actionState == "standby"))
										{
											if (250515 - 451456 == -200940)
											{
												continue;
											}
											if (!(this.mChar.actionState == "run"))
											{
												break;
											}
											if (136162 - 338608 == -202445)
											{
												continue;
											}
										}
										if (this.mChar.isTimeOut("cAttack") != (float)0)
										{
											break;
										}
										if (29644 - 534987 == -505343)
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

	// Token: 0x06004405 RID: 17413 RVA: 0x0088E7E4 File Offset: 0x0088C9E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06004406 RID: 17414 RVA: 0x0088E7E8 File Offset: 0x0088C9E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Deadbeagle.$RPC_nAttack$31717(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06004407 RID: 17415 RVA: 0x0088E7F8 File Offset: 0x0088C9F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (85750 - 54831 != 30919)
		{
		}
		for (;;)
		{
			if (this.nAttack_hit)
			{
				if (170860 - 437848 == -266988)
				{
					UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, Quaternion.LookRotation(hitDir));
					if (21489 - 549511 == -528022)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find nAttack_hit effect");
				if (49607 - 326697 == -277090)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06004408 RID: 17416 RVA: 0x0088E8B0 File Offset: 0x0088CAB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_livingDead_hit(Vector3 mPos, Vector3 tDir, int tID)
	{
		if (256500 - 444972 != -188472)
		{
		}
		for (;;)
		{
			if (this.livingDead_hit)
			{
				if (125025 - 436305 == -311280)
				{
					this.mChar.createEffect(this.livingDead_hit, this.transform.position + 2.4f * Vector3.up, this.transform.rotation);
					if (52039 - 464351 == -412312)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Warning cannot find livingDead_hit effect");
				if (59354 - 220213 != -160858)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06004409 RID: 17417 RVA: 0x0088E994 File Offset: 0x0088CB94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new Deadbeagle.$RPC_ko$31732(nArray, this).GetEnumerator();
	}

	// Token: 0x0600440A RID: 17418 RVA: 0x0088E9A4 File Offset: 0x0088CBA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new Deadbeagle.$RPC_dead$31739(nArray, this).GetEnumerator();
	}

	// Token: 0x0600440B RID: 17419 RVA: 0x0088E9B4 File Offset: 0x0088CBB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600440C RID: 17420 RVA: 0x0088E9B8 File Offset: 0x0088CBB8
	internal static bool YwkmUH56AOyQvOFL2mxT()
	{
		return true;
	}

	// Token: 0x0600440D RID: 17421 RVA: 0x0088E9BC File Offset: 0x0088CBBC
	internal static bool ptNihK56l9s0T0tCK9kR()
	{
		return false;
	}

	// Token: 0x04004FD3 RID: 20435
	public CharacterControl mChar;

	// Token: 0x04004FD4 RID: 20436
	public AudioClip nAttack_fx;

	// Token: 0x04004FD5 RID: 20437
	public GameObject nAttack_hit;

	// Token: 0x04004FD6 RID: 20438
	public GameObject plague;

	// Token: 0x04004FD7 RID: 20439
	public GameObject plague_hit;

	// Token: 0x04004FD8 RID: 20440
	public GameObject livingDead_hit;

	// Token: 0x02000BE8 RID: 3048
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$31717 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600440E RID: 17422 RVA: 0x0088E9C0 File Offset: 0x0088CBC0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$31717(Vector3 mPos, Vector3 tDir, Deadbeagle self_)
		{
			if (220154 - 349269 != -129115)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (216104 - 547648 != -331543)
				{
					base..ctor();
					if (279024 - 42219 != 236806)
					{
						this.$mPos$31729 = mPos;
						if (116174 - 155311 == -39137)
						{
							this.$tDir$31730 = tDir;
							if (62405 - 153112 != -90706)
							{
								this.$self_$31731 = self_;
								if (71353 - 31113 != 40241)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600440F RID: 17423 RVA: 0x0088EA9C File Offset: 0x0088CC9C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Deadbeagle.$RPC_nAttack$31717.$(this.$mPos$31729, this.$tDir$31730, this.$self_$31731);
		}

		// Token: 0x06004410 RID: 17424 RVA: 0x0088EAB8 File Offset: 0x0088CCB8
		internal static bool la2d9056yCKjhVanncdB()
		{
			return true;
		}

		// Token: 0x06004411 RID: 17425 RVA: 0x0088EABC File Offset: 0x0088CCBC
		internal static bool B9Tsf056SIc5NrGWxhrv()
		{
			return false;
		}

		// Token: 0x04004FD9 RID: 20441
		internal Vector3 $mPos$31729;

		// Token: 0x04004FDA RID: 20442
		internal Vector3 $tDir$31730;

		// Token: 0x04004FDB RID: 20443
		internal Deadbeagle $self_$31731;

		// Token: 0x02000BE9 RID: 3049
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004412 RID: 17426 RVA: 0x0088EAC0 File Offset: 0x0088CCC0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Deadbeagle self_)
			{
				if (94787 - 297821 != -203033)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (135564 - 130370 == 5194)
					{
						base..ctor();
						if (216436 - 447193 == -230757)
						{
							this.$mPos$31726 = mPos;
							if (181721 - 394721 != -212999)
							{
								this.$tDir$31727 = tDir;
								if (25260 - 7980 != 17281)
								{
									this.$self_$31728 = self_;
									if (122662 - 35260 == 87402)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06004413 RID: 17427 RVA: 0x0088EB9C File Offset: 0x0088CD9C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (204054 - 505075 != -301021)
				{
				}
				for (;;)
				{
					IL_4C7:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_A9F;
					case 2:
						if (this.$self_$31728.mChar.actionState != "attack")
						{
							if (80647 - 345887 != -265240)
							{
								continue;
							}
							if (this.$self_$31728.mChar.myCommand != "nAttack")
							{
								if (86464 - 300339 != -213875)
								{
									continue;
								}
								goto IL_84;
							}
						}
						if (this.$self_$31728.nAttack_fx)
						{
							if (79250 - 168853 != -89603)
							{
								continue;
							}
							this.$self_$31728.audio.PlayOneShot(this.$self_$31728.nAttack_fx);
							if (145337 - 141928 != 3409)
							{
								continue;
							}
						}
						this.$i$31718 = 0;
						if (86870 - 68534 != 18337)
						{
							goto IL_6D8;
						}
						continue;
					case 3:
						if (this.$self_$31728.mChar.actionState != "attack")
						{
							if (189972 - 526284 == -336311)
							{
								continue;
							}
							if (this.$self_$31728.mChar.myCommand != "nAttack")
							{
								if (179746 - 512989 != -333242)
								{
									goto Block_37;
								}
								continue;
							}
						}
						if (this.$self_$31728.mChar.isMine)
						{
							if (13040 - 308926 == -295885)
							{
								continue;
							}
							this.$hitLayer$31719 = 130816 - (1 << this.$self_$31728.gameObject.layer);
							if (208632 - 449002 == -240369)
							{
								continue;
							}
							this.$hitList$31720 = Damage.FindAreaTarget(this.$self_$31728.transform.position + 0.5f * this.$self_$31728.transform.forward, (float)1, (float)2, this.$hitLayer$31719);
							if (158411 - 278522 == -120110)
							{
								continue;
							}
							this.$$iterator$10715$31725 = UnityRuntimeServices.GetEnumerator(this.$hitList$31720);
							if (13447 - 529096 == -515648)
							{
								continue;
							}
							while (this.$$iterator$10715$31725.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10715$31725.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$31721 = (GameObject)obj2;
								if (277624 - 100487 == 177138)
								{
									goto IL_4C7;
								}
								if (this.$self_$31728.mChar.hit(1, this.$hitObject$31721, (int)(0.5f * (float)this.$self_$31728.mChar.atk), 3, 0, 0.2f * this.$self_$31728.transform.forward) != 0)
								{
									if (264685 - 118819 == 145867)
									{
										goto IL_4C7;
									}
									this.$hitPos$31722 = this.$hitObject$31721.collider.ClosestPointOnBounds(this.$self_$31728.transform.position + 1.3f * Vector3.up);
									if (30987 - 37952 != -6965)
									{
										goto IL_4C7;
									}
									UnityRuntimeServices.Update(this.$$iterator$10715$31725, this.$hitObject$31721);
									if (272389 - 287103 != -14714)
									{
										goto IL_4C7;
									}
									this.$self_$31728.RPC_nAttack_hit(this.$hitPos$31722, this.$self_$31728.transform.forward, 0);
									if (8620 - 256359 != -247739)
									{
										goto IL_4C7;
									}
									this.$self_$31728.ActionEvent("RPC_nAttack_hit", this.$hitPos$31722, this.$self_$31728.transform.forward, 0);
									if (43883 - 583441 != -539558)
									{
										goto IL_4C7;
									}
									this.$self_$31728.mChar.sp = this.$self_$31728.mChar.sp + 1;
									if (168701 - 149016 != 19685)
									{
										goto IL_4C7;
									}
									this.$tChar$31723 = (CharacterControl)this.$hitObject$31721.GetComponent(typeof(CharacterControl));
									if (243984 - 574631 != -330647)
									{
										goto IL_4C7;
									}
									UnityRuntimeServices.Update(this.$$iterator$10715$31725, this.$hitObject$31721);
									if (260613 - 355804 == -95190)
									{
										goto IL_4C7;
									}
									if (this.$tChar$31723)
									{
										if (116529 - 380604 == -264074)
										{
											goto IL_4C7;
										}
										if (UnityEngine.Random.Range(0, 100) < this.$self_$31728.mChar.lckAdjust(20))
										{
											if (58237 - 494221 == -435983)
											{
												goto IL_4C7;
											}
											this.$mDuration$31724 = Damage.getDebuff((float)60, this.$self_$31728.mChar.cha, this.$tChar$31723.cha);
											if (151558 - 77130 == 74429)
											{
												goto IL_4C7;
											}
											this.$tChar$31723.RPC_AddStatus("plague", 1, this.$mDuration$31724, 0, this.$self_$31728.mChar.ActorNr);
											if (213593 - 344596 == -131002)
											{
												goto IL_4C7;
											}
										}
									}
								}
							}
							if (291666 - 259969 != 31697)
							{
								continue;
							}
						}
						this.$i$31718++;
						if (243444 - 102299 != 141145)
						{
							continue;
						}
						goto IL_6D8;
					case 4:
						if (this.$self_$31728.mChar.actionState == "attack")
						{
							if (22864 - 257219 != -234355)
							{
								continue;
							}
							if (this.$self_$31728.mChar.myCommand == "nAttack")
							{
								if (109707 - 210448 == -100740)
								{
									continue;
								}
								this.$self_$31728.mChar.actionState = "standby";
								if (150735 - 119496 != 31239)
								{
									continue;
								}
								this.$self_$31728.mChar.actionTime = Time.time;
								if (193541 - 77136 == 116406)
								{
									continue;
								}
								this.$self_$31728.mChar.myCommand = "none";
								if (127697 - 580466 != -452769)
								{
									continue;
								}
								if (!this.$self_$31728.mChar.isMine)
								{
									if (11626 - 388022 != -376396)
									{
										continue;
									}
									this.$self_$31728.mChar.nPosition = this.$self_$31728.transform.position;
									if (51295 - 291637 == -240341)
									{
										continue;
									}
									this.$self_$31728.mChar.oPosition = this.$self_$31728.transform.position;
									if (94660 - 203578 != -108918)
									{
										continue;
									}
									this.$self_$31728.mChar.nDirection = this.$self_$31728.transform.forward;
									if (121970 - 35694 == 86277)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (53053 - 529808 != -476755)
						{
							continue;
						}
						goto IL_A9F;
					default:
						if (194976 - 24559 != 170417)
						{
							continue;
						}
						break;
					}
					this.$self_$31728.mChar.actionState = "attack";
					if (62484 - 363008 == -300523)
					{
						continue;
					}
					this.$self_$31728.mChar.actionTime = Time.time;
					if (101666 - 554062 == -452395)
					{
						continue;
					}
					this.$self_$31728.mChar.myCommand = "nAttack";
					if (281796 - 405616 == -123819)
					{
						continue;
					}
					this.$self_$31728.mChar.addTimeOut("nAttack", (float)1);
					if (149148 - 123754 == 25395)
					{
						continue;
					}
					this.$self_$31728.transform.position = this.$mPos$31726;
					if (114240 - 108833 == 5408)
					{
						continue;
					}
					this.$self_$31728.transform.LookAt(this.$mPos$31726 + global::Math.vFlat(this.$tDir$31727));
					if (246262 - 196458 == 49805)
					{
						continue;
					}
					this.$self_$31728.animation.CrossFade("nAttack");
					if (123359 - 365693 == -242333)
					{
						continue;
					}
					this.$self_$31728.animation.wrapMode = WrapMode.Once;
					if (169527 - 514504 == -344976)
					{
						continue;
					}
					this.$self_$31728.mChar.vMovement = this.$self_$31728.transform.forward;
					if (125936 - 422346 == -296409)
					{
						continue;
					}
					this.$self_$31728.mChar.moveSpeed = (float)0;
					if (147460 - 412105 != -264644)
					{
						goto Block_21;
					}
					continue;
					IL_6D8:
					if (this.$i$31718 < 2)
					{
						goto IL_245;
					}
					if (161859 - 405054 != -243194)
					{
						goto Block_44;
					}
				}
				IL_84:
				goto IL_A9F;
				IL_245:
				return this.Yield(3, new WaitForSeconds(0.2f));
				Block_21:
				return this.Yield(2, new WaitForSeconds(0.2f));
				Block_37:
				goto IL_A9F;
				Block_44:
				return this.Yield(4, new WaitForSeconds(0.2f));
				IL_A9F:
				return false;
			}

			// Token: 0x06004414 RID: 17428 RVA: 0x0088F65C File Offset: 0x0088D85C
			internal static bool pheVPc56okgTVuOMdsPS()
			{
				return true;
			}

			// Token: 0x06004415 RID: 17429 RVA: 0x0088F660 File Offset: 0x0088D860
			internal static bool sx2ynu56E9dp6ORLc8mN()
			{
				return false;
			}

			// Token: 0x04004FDC RID: 20444
			internal int $i$31718;

			// Token: 0x04004FDD RID: 20445
			internal int $hitLayer$31719;

			// Token: 0x04004FDE RID: 20446
			internal UnityScript.Lang.Array $hitList$31720;

			// Token: 0x04004FDF RID: 20447
			internal GameObject $hitObject$31721;

			// Token: 0x04004FE0 RID: 20448
			internal Vector3 $hitPos$31722;

			// Token: 0x04004FE1 RID: 20449
			internal CharacterControl $tChar$31723;

			// Token: 0x04004FE2 RID: 20450
			internal int $mDuration$31724;

			// Token: 0x04004FE3 RID: 20451
			internal IEnumerator $$iterator$10715$31725;

			// Token: 0x04004FE4 RID: 20452
			internal Vector3 $mPos$31726;

			// Token: 0x04004FE5 RID: 20453
			internal Vector3 $tDir$31727;

			// Token: 0x04004FE6 RID: 20454
			internal Deadbeagle $self_$31728;
		}
	}

	// Token: 0x02000BEA RID: 3050
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$31732 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004416 RID: 17430 RVA: 0x0088F664 File Offset: 0x0088D864
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$31732(UnityScript.Lang.Array nArray, Deadbeagle self_)
		{
			if (175815 - 527689 != -351874)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (231028 - 244785 != -13756)
				{
					base..ctor();
					if (84167 - 398615 == -314448)
					{
						this.$nArray$31737 = nArray;
						if (69898 - 546451 != -476552)
						{
							this.$self_$31738 = self_;
							if (49207 - 135345 == -86138)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004417 RID: 17431 RVA: 0x0088F720 File Offset: 0x0088D920
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Deadbeagle.$RPC_ko$31732.$(this.$nArray$31737, this.$self_$31738);
		}

		// Token: 0x06004418 RID: 17432 RVA: 0x0088F734 File Offset: 0x0088D934
		internal static bool qbscCJ562201LIHi0fdr()
		{
			return true;
		}

		// Token: 0x06004419 RID: 17433 RVA: 0x0088F738 File Offset: 0x0088D938
		internal static bool Ee0s6R568wRyjmsiQRYT()
		{
			return false;
		}

		// Token: 0x04004FE7 RID: 20455
		internal UnityScript.Lang.Array $nArray$31737;

		// Token: 0x04004FE8 RID: 20456
		internal Deadbeagle $self_$31738;

		// Token: 0x02000BEB RID: 3051
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600441A RID: 17434 RVA: 0x0088F73C File Offset: 0x0088D93C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Deadbeagle self_)
			{
				if (202337 - 552634 != -350296)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (2820 - 542597 == -539777)
					{
						base..ctor();
						if (295190 - 434411 != -139220)
						{
							this.$nArray$31735 = nArray;
							if (246912 - 9037 != 237876)
							{
								this.$self_$31736 = self_;
								if (13872 - 183497 != -169624)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600441B RID: 17435 RVA: 0x0088F7F8 File Offset: 0x0088D9F8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (192602 - 527112 != -334509)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_48C;
					case 2:
						if (this.$self_$31736.mChar.actionState != "ko")
						{
							if (163863 - 31908 != 131956)
							{
								goto Block_16;
							}
							continue;
						}
						else
						{
							this.$self_$31736.animation.Play("getUp");
							if (264602 - 472622 != -208020)
							{
								continue;
							}
							this.$self_$31736.animation.wrapMode = WrapMode.Once;
							if (125436 - 495954 != -370517)
							{
								goto Block_17;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$31736.mChar.actionState != "ko")
						{
							if (190950 - 356356 != -165405)
							{
								goto Block_14;
							}
							continue;
						}
						else
						{
							this.$self_$31736.mChar.actionState = "standby";
							if (111271 - 269929 != -158658)
							{
								continue;
							}
							this.$self_$31736.mChar.actionTime = Time.time;
							if (199604 - 247588 != -47984)
							{
								continue;
							}
							this.$self_$31736.mChar.myCommand = "none";
							if (251300 - 517582 == -266281)
							{
								continue;
							}
							this.$self_$31736.mChar.ko = this.$self_$31736.mChar.mko;
							if (15156 - 190878 != -175722)
							{
								continue;
							}
							this.YieldDefault(1);
							if (14130 - 284832 != -270701)
							{
								goto Block_18;
							}
							continue;
						}
						break;
					default:
						if (272024 - 358453 == -86428)
						{
							continue;
						}
						break;
					}
					if (this.$self_$31736.mChar.actionState == "ko")
					{
						goto IL_2CA;
					}
					if (45807 - 473064 != -427256)
					{
						if (this.$self_$31736.mChar.actionState == "dead")
						{
							if (283737 - 231243 == 52494)
							{
								goto IL_2CA;
							}
						}
						else
						{
							this.$mPos$31733 = (Vector3)this.$nArray$31735[0];
							if (164059 - 305577 != -141517)
							{
								this.$mDir$31734 = (Vector3)this.$nArray$31735[1];
								if (299743 - 336287 == -36544)
								{
									this.$self_$31736.mChar.ko = 0;
									if (74699 - 301974 != -227274)
									{
										this.$self_$31736.mChar.actionState = "ko";
										if (28692 - 497807 == -469115)
										{
											this.$self_$31736.mChar.actionTime = Time.time;
											if (206262 - 277569 == -71307)
											{
												this.$self_$31736.mChar.myCommand = "none";
												if (297668 - 210643 == 87025)
												{
													this.$self_$31736.mChar.vMovement = Vector3.zero;
													if (254403 - 120991 != 133413)
													{
														this.$self_$31736.mChar.moveSpeed = (float)0;
														if (139926 - 49408 == 90518)
														{
															this.$self_$31736.animation.Play("ko");
															if (167350 - 456049 == -288699)
															{
																this.$self_$31736.animation.wrapMode = WrapMode.Once;
																if (185025 - 232274 != -47248)
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
				return this.Yield(2, new WaitForSeconds(3f));
				Block_14:
				Block_16:
				goto IL_48C;
				Block_17:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_18:
				IL_2CA:
				IL_48C:
				return false;
			}

			// Token: 0x0600441C RID: 17436 RVA: 0x0088FCA4 File Offset: 0x0088DEA4
			internal static bool aOA7nS56Zb8im64RcgkK()
			{
				return true;
			}

			// Token: 0x0600441D RID: 17437 RVA: 0x0088FCA8 File Offset: 0x0088DEA8
			internal static bool Q6mOAl56C7Zx6yayBexI()
			{
				return false;
			}

			// Token: 0x04004FE9 RID: 20457
			internal Vector3 $mPos$31733;

			// Token: 0x04004FEA RID: 20458
			internal Vector3 $mDir$31734;

			// Token: 0x04004FEB RID: 20459
			internal UnityScript.Lang.Array $nArray$31735;

			// Token: 0x04004FEC RID: 20460
			internal Deadbeagle $self_$31736;
		}
	}

	// Token: 0x02000BEC RID: 3052
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$31739 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600441E RID: 17438 RVA: 0x0088FCAC File Offset: 0x0088DEAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$31739(UnityScript.Lang.Array nArray, Deadbeagle self_)
		{
			if (43279 - 291520 != -248240)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (177624 - 468588 == -290964)
				{
					base..ctor();
					if (283662 - 563365 == -279703)
					{
						this.$nArray$31744 = nArray;
						if (237212 - 185204 != 52009)
						{
							this.$self_$31745 = self_;
							if (222320 - 97029 != 125292)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600441F RID: 17439 RVA: 0x0088FD68 File Offset: 0x0088DF68
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Deadbeagle.$RPC_dead$31739.$(this.$nArray$31744, this.$self_$31745);
		}

		// Token: 0x06004420 RID: 17440 RVA: 0x0088FD7C File Offset: 0x0088DF7C
		internal static bool nJ9pRd56Lo6n0xDWQZ2N()
		{
			return true;
		}

		// Token: 0x06004421 RID: 17441 RVA: 0x0088FD80 File Offset: 0x0088DF80
		internal static bool qG98dS56OjpebPSQFKiK()
		{
			return false;
		}

		// Token: 0x04004FED RID: 20461
		internal UnityScript.Lang.Array $nArray$31744;

		// Token: 0x04004FEE RID: 20462
		internal Deadbeagle $self_$31745;

		// Token: 0x02000BED RID: 3053
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004422 RID: 17442 RVA: 0x0088FD84 File Offset: 0x0088DF84
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Deadbeagle self_)
			{
				if (11603 - 321605 != -310002)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (283801 - 480224 == -196423)
					{
						base..ctor();
						if (117328 - 591091 == -473763)
						{
							this.$nArray$31742 = nArray;
							if (174590 - 11374 != 163217)
							{
								this.$self_$31743 = self_;
								if (174551 - 521990 != -347438)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06004423 RID: 17443 RVA: 0x0088FE40 File Offset: 0x0088E040
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (254726 - 348791 != -94065)
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
						if (this.$self_$31743.mChar.actionState != "dead")
						{
							if (109269 - 258172 != -148903)
							{
								continue;
							}
							goto IL_F4;
						}
						else
						{
							if (!this.$self_$31743.mChar.isPlayer)
							{
								if (122297 - 460538 != -338241)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$31743.gameObject);
								if (292432 - 268205 != 24227)
								{
									continue;
								}
							}
							else if (this.$self_$31743.mChar.isMine)
							{
								if (36539 - 416261 == -379721)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$31743.gameObject);
								if (61512 - 215083 != -153571)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (319 - 510712 != -510392)
							{
								goto Block_22;
							}
							continue;
						}
						break;
					default:
						if (272036 - 522377 == -250340)
						{
							continue;
						}
						break;
					}
					if (this.$self_$31743.mChar.actionState == "dead")
					{
						if (294358 - 19221 == 275137)
						{
							goto IL_3F4;
						}
					}
					else
					{
						this.$myPosition$31740 = (Vector3)this.$nArray$31742[0];
						if (296817 - 287660 == 9157)
						{
							this.$myDirection$31741 = (Vector3)this.$nArray$31742[1];
							if (23759 - 410359 == -386600)
							{
								this.$self_$31743.transform.position = this.$myPosition$31740;
								if (277733 - 476299 != -198565)
								{
									this.$self_$31743.transform.LookAt(this.$myPosition$31740 + this.$myDirection$31741);
									if (246623 - 454717 == -208094)
									{
										this.$self_$31743.mChar.hp = 0;
										if (288484 - 438694 == -150210)
										{
											this.$self_$31743.mChar.actionState = "dead";
											if (247454 - 168571 != 78884)
											{
												this.$self_$31743.mChar.actionTime = Time.time;
												if (202256 - 123725 == 78531)
												{
													this.$self_$31743.mChar.myCommand = "none";
													if (299701 - 560433 != -260731)
													{
														this.$self_$31743.mChar.vMovement = Vector3.zero;
														if (154577 - 325487 == -170910)
														{
															this.$self_$31743.mChar.moveSpeed = (float)0;
															if (214279 - 25915 == 188364)
															{
																this.$self_$31743.animation.Rewind();
																if (299326 - 356995 != -57668)
																{
																	this.$self_$31743.animation.Play("ko");
																	if (273263 - 265255 == 8008)
																	{
																		this.$self_$31743.animation.wrapMode = WrapMode.Once;
																		if (133339 - 533222 != -399882)
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
				IL_F4:
				Block_22:
				IL_3F4:
				IL_42F:
				return false;
			}

			// Token: 0x06004424 RID: 17444 RVA: 0x00890290 File Offset: 0x0088E490
			internal static bool iAWYbm56mxcMK4ikyNAP()
			{
				return true;
			}

			// Token: 0x06004425 RID: 17445 RVA: 0x00890294 File Offset: 0x0088E494
			internal static bool UqHH0Y56FHT0etmj3niK()
			{
				return false;
			}

			// Token: 0x04004FEF RID: 20463
			internal Vector3 $myPosition$31740;

			// Token: 0x04004FF0 RID: 20464
			internal Vector3 $myDirection$31741;

			// Token: 0x04004FF1 RID: 20465
			internal UnityScript.Lang.Array $nArray$31742;

			// Token: 0x04004FF2 RID: 20466
			internal Deadbeagle $self_$31743;
		}
	}
}
