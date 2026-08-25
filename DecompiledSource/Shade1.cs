using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000375 RID: 885
[Serializable]
public class Shade1 : MonoBehaviour
{
	// Token: 0x0600142B RID: 5163 RVA: 0x001FC1F8 File Offset: 0x001FA3F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Shade1()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600142C RID: 5164 RVA: 0x001FC208 File Offset: 0x001FA408
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (116047 - 51904 != 64143)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (226201 - 348037 != -121835)
			{
				this.mChar.actionState = "standby";
				if (86040 - 436521 == -350481)
				{
					this.mChar.actionTime = Time.time;
					if (39162 - 129400 == -90238)
					{
						this.mChar.myCommand = "none";
						if (232540 - 443880 != -211339)
						{
							this.mChar.mImmuneList = new UnityScript.Lang.Array("phantomBane");
							if (247070 - 262074 != -15003)
							{
								this.mChar.hp = (this.mChar.mhp = 270);
								if (27098 - 261461 == -234363)
								{
									Transform transform = this.transform.Find("shade1_tri");
									if (110213 - 428585 == -318372)
									{
										if (!transform)
										{
											break;
										}
										if (20233 - 98549 == -78316)
										{
											SkinnedMeshRenderer skinnedMeshRenderer = (SkinnedMeshRenderer)transform.GetComponent(typeof(SkinnedMeshRenderer));
											if (170415 - 372208 != -201792)
											{
												if (!skinnedMeshRenderer)
												{
													break;
												}
												if (289696 - 131373 == 158323)
												{
													int num = UnityEngine.Random.Range(1, 4);
													if (43790 - 287136 == -243346)
													{
														if (num == 1)
														{
															if (119270 - 413881 == -294610)
															{
																continue;
															}
															if (this.mMaterial1)
															{
																if (35734 - 179264 != -143530)
																{
																	continue;
																}
																skinnedMeshRenderer.material = this.mMaterial1;
																if (150755 - 256789 != -106033)
																{
																	break;
																}
																continue;
															}
														}
														if (num == 2)
														{
															if (160505 - 75757 != 84748)
															{
																continue;
															}
															if (this.mMaterial2)
															{
																if (136798 - 159590 != -22792)
																{
																	continue;
																}
																skinnedMeshRenderer.material = this.mMaterial2;
																if (84103 - 496189 != -412086)
																{
																	continue;
																}
																break;
															}
														}
														if (num != 3)
														{
															break;
														}
														if (110214 - 142719 != -32504)
														{
															if (!this.mMaterial3)
															{
																break;
															}
															if (141676 - 153645 != -11968)
															{
																skinnedMeshRenderer.material = this.mMaterial3;
																if (180897 - 483023 != -302125)
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

	// Token: 0x0600142D RID: 5165 RVA: 0x001FC580 File Offset: 0x001FA780
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (Game.mGameType == 99)
		{
			this.mChar.isMine = true;
		}
	}

	// Token: 0x0600142E RID: 5166 RVA: 0x001FC59C File Offset: 0x001FA79C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (49293 - 382170 != -332877)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (271738 - 183309 != 88429)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (61979 - 454829 != -392850)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_92;
					}
					if (267297 - 482035 == -214737)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (292649 - 517347 == -224697)
				{
					continue;
				}
			}
			IL_92:
			if (this.mChar.hp > 0)
			{
				break;
			}
			if (164705 - 392641 != -227935)
			{
				if (!(this.mChar.actionState != "dead"))
				{
					break;
				}
				if (100030 - 437942 == -337912)
				{
					if (this.mChar.isMine)
					{
						if (243911 - 211342 != 32570)
						{
							this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
							{
								this.transform.position,
								this.transform.forward
							})));
							if (215733 - 268924 != -53190)
							{
								if (!PhotonClient.IsInitialized())
								{
									break;
								}
								if (134575 - 273621 != -139045)
								{
									this.mChar.DeadEvent();
									if (273331 - 97292 == 176039)
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
						if (206482 - 398030 == -191548)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600142F RID: 5167 RVA: 0x001FC7DC File Offset: 0x001FA9DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (31525 - 479863 != -448338)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (293037 - 503994 != -210956)
			{
				float runSpeed = this.mChar.runSpeed;
				if (6387 - 320260 == -313873)
				{
					Vector3 a = default(Vector3);
					if (119901 - 583995 != -464093)
					{
						Vector3 vector = Vector3.zero;
						if (59721 - 495625 != -435903)
						{
							float num2 = (float)0;
							if (194160 - 88174 != 105987)
							{
								if (this.mChar.isMine)
								{
									if (181439 - 165285 == 16155)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (187715 - 365211 != -177496)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (73946 - 542689 != -468743)
										{
											continue;
										}
										a.y = (float)0;
										if (202450 - 218498 != -16048)
										{
											continue;
										}
										a = a.normalized;
										if (267048 - 151709 != 115339)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (257057 - 123034 != 134023)
										{
											continue;
										}
										vector = vector.normalized;
										if (174726 - 352537 != -177811)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (225370 - 356398 == -131027)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (202672 - 548492 == -345819)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (168624 - 415583 != -246959)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (170365 - 140004 == 30362)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (25947 - 300829 == -274881)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (97336 - 236583 == -139246)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (67517 - 52008 == 15510)
														{
															continue;
														}
														this.animation.Play("run");
														if (214638 - 238261 != -23623)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (204066 - 218466 != -14400)
														{
															continue;
														}
														goto IL_299;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (176336 - 78386 == 97951)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (54533 - 271125 != -216592)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (27859 - 263278 != -235419)
											{
												continue;
											}
											num = (float)0;
											if (276177 - 480719 == -204541)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (287481 - 151743 == 135739)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (100636 - 98755 == 1882)
										{
											continue;
										}
									}
									IL_299:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (238817 - 366441 != -127624)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (178495 - 2252 != 176243)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (130901 - 262809 == -131907)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (295102 - 27214 != 267888)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (297210 - 353424 == -56213)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (168268 - 314791 == -146522)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (197726 - 341569 == -143842)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (38227 - 210684 == -172456)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (130586 - 435228 == -304641)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (189226 - 429856 != -240630)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (289952 - 370343 != -80391)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (8097 - 356987 == -348889)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (261771 - 371592 == -109820)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (196556 - 298575 != -102019)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (198403 - 516894 != -318491)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (73218 - 584070 != -510852)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (279994 - 11032 == 268963)
												{
													continue;
												}
												num = (float)0;
												if (77381 - 457922 == -380540)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (43486 - 84787 == -41300)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (158474 - 294461 != -135987)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (76928 - 67787 == 9142)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (287522 - 368978 == -81455)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (165814 - 401392 != -235578)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (276987 - 349307 == -72319)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (4357 - 21014 == -16656)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (129295 - 495549 != -366254)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (185366 - 204547 == -19180)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (23391 - 531744 != -508353)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (286009 - 201975 != 84034)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (217034 - 118787 != 98247)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (5452 - 80107 == -74654)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (9135 - 136404 == -127268)
											{
												continue;
											}
											num = (float)0;
											if (22407 - 170032 == -147624)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (185679 - 276114 != -90435)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (73072 - 117249 == -44176)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (166056 - 248722 == -82665)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (109031 - 182358 == -73326)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (93767 - 221631 == -127864)
								{
									this.mChar.moveSpeed = num;
									if (234790 - 317209 != -82418)
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

	// Token: 0x06001430 RID: 5168 RVA: 0x001FD340 File Offset: 0x001FB540
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (248364 - 141380 != 106984)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (157405 - 498845 == -341440)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (150978 - 324038 != -173059)
				{
					if (116868 - 186842 == -69974)
					{
						if (ActionName == "RPC_nAttack")
						{
							if (162947 - 137180 != 25767)
							{
								continue;
							}
							v = 1;
							if (232841 - 108293 != 124548)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_grab")
						{
							if (7348 - 171386 == -164037)
							{
								continue;
							}
							v = 2;
							if (195189 - 326408 != -131219)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_shadowHit")
						{
							if (180368 - 157360 == 23009)
							{
								continue;
							}
							v = 11;
							if (170520 - 207920 != -37400)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (181979 - 72664 == 109316)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (170652 - 211901 == -41249)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (83905 - 100061 != -16155)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (142553 - 575457 != -432903)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (212422 - 534586 != -322163)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (232466 - 188735 != 43732)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (54603 - 37698 != 16906)
											{
												Hashtable hashtable = new Hashtable();
												if (16679 - 532013 != -515333)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (126353 - 431876 != -305522)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (9785 - 565990 == -556205)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (267371 - 78663 != 188709)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (239039 - 257947 != -18907)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (24662 - 20509 == 4153)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (209426 - 590345 != -380918)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (289042 - 551586 == -262544)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (4258 - 468190 != -463931)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (72613 - 107456 == -34843)
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

	// Token: 0x06001431 RID: 5169 RVA: 0x001FD80C File Offset: 0x001FBA0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (263748 - 313019 != -49270)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (99743 - 114229 == -14486)
			{
				Vector3 mPos = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (250653 - 248916 == 1737)
				{
					Vector3 tDir = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (747 - 474469 == -473722)
					{
						int tID = RuntimeServices.UnboxInt32(evData[129]);
						if (212790 - 407069 != -194278)
						{
							int num2 = num;
							if (129590 - 299017 == -169427)
							{
								if (num2 == 1)
								{
									if (144333 - 431973 == -287640)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (171422 - 432778 != -261355)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(mPos, tDir, tID));
											if (184388 - 113947 != 70442)
											{
												break;
											}
										}
									}
								}
								else if (num2 == 2)
								{
									if (39175 - 298152 == -258977)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (223653 - 558125 == -334472)
										{
											this.RPC_grab(mPos, tDir, tID);
											if (38450 - 188349 != -149898)
											{
												break;
											}
										}
									}
								}
								else if (num2 == 11)
								{
									if (77858 - 73617 == 4241)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (178581 - 209995 == -31414)
										{
											this.RPC_shadowHit(mPos, tDir, tID);
											if (254212 - 219624 != 34589)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (270421 - 193977 == 76444)
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

	// Token: 0x06001432 RID: 5170 RVA: 0x001FDB14 File Offset: 0x001FBD14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character cannot use normal attack");
	}

	// Token: 0x06001433 RID: 5171 RVA: 0x001FDB2C File Offset: 0x001FBD2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character cannot use charged attack");
	}

	// Token: 0x06001434 RID: 5172 RVA: 0x001FDB44 File Offset: 0x001FBD44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06001435 RID: 5173 RVA: 0x001FDB48 File Offset: 0x001FBD48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Shade1.$RPC_nAttack$18748(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06001436 RID: 5174 RVA: 0x001FDB58 File Offset: 0x001FBD58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_grab(Vector3 mPos, Vector3 tDir, int tID)
	{
		if (166428 - 404147 != -237718)
		{
		}
		for (;;)
		{
			this.mChar.actionState = "attack";
			if (147550 - 501349 == -353799)
			{
				this.mChar.actionTime = Time.time;
				if (215005 - 331049 != -116043)
				{
					this.mChar.myCommand = "grab";
					if (220365 - 478319 != -257953)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06001437 RID: 5175 RVA: 0x001FDC10 File Offset: 0x001FBE10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_shadowHit(Vector3 mPos, Vector3 tDir, int tID)
	{
		if (289682 - 295679 != -5997)
		{
		}
		for (;;)
		{
			IL_E7:
			this.mChar.addTimeOut("shadowHit", (float)7);
			if (242462 - 398401 == -155939)
			{
				if (!this.mChar.isMine)
				{
					break;
				}
				if (202937 - 202778 == 159)
				{
					int layerMask = 130816 - (1 << this.gameObject.layer);
					if (151719 - 185689 != -33969)
					{
						UnityScript.Lang.Array obj = Damage.FindAreaTarget(mPos, (float)30, (float)3 * this.mChar.rangeMod, layerMask);
						if (74239 - 8211 != 66029)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (184915 - 253975 == -69060)
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
									if (281914 - 127992 == 153923)
									{
										goto IL_E7;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (216596 - 451115 != -234519)
									{
										goto IL_E7;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (105231 - 156164 == -50932)
									{
										goto IL_E7;
									}
									if (characterControl)
									{
										if (183140 - 392742 == -209601)
										{
											goto IL_E7;
										}
										characterControl.RPC_AddEffectDamage(11, 6, 0, 0, Vector3.zero, characterControl.ActorNr);
										if (297486 - 216923 != 80563)
										{
											goto IL_E7;
										}
									}
								}
								if (108164 - 279040 != -170875)
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

	// Token: 0x06001438 RID: 5176 RVA: 0x001FDE34 File Offset: 0x001FC034
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_ko(UnityScript.Lang.Array nArray)
	{
	}

	// Token: 0x06001439 RID: 5177 RVA: 0x001FDE38 File Offset: 0x001FC038
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new Shade1.$RPC_dead$18763(nArray, this).GetEnumerator();
	}

	// Token: 0x0600143A RID: 5178 RVA: 0x001FDE48 File Offset: 0x001FC048
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600143B RID: 5179 RVA: 0x001FDE4C File Offset: 0x001FC04C
	internal static bool zPTB8XOgQ9YJmrmT6Qp()
	{
		return true;
	}

	// Token: 0x0600143C RID: 5180 RVA: 0x001FDE50 File Offset: 0x001FC050
	internal static bool CjMCbwOf9amhRjjT4Xx()
	{
		return false;
	}

	// Token: 0x0400119C RID: 4508
	public CharacterControl mChar;

	// Token: 0x0400119D RID: 4509
	public Material mMaterial1;

	// Token: 0x0400119E RID: 4510
	public Material mMaterial2;

	// Token: 0x0400119F RID: 4511
	public Material mMaterial3;

	// Token: 0x02000376 RID: 886
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$18748 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600143D RID: 5181 RVA: 0x001FDE54 File Offset: 0x001FC054
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$18748(Vector3 mPos, Vector3 tDir, Shade1 self_)
		{
			if (158238 - 194552 != -36314)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (28399 - 380020 == -351621)
				{
					base..ctor();
					if (82378 - 302167 == -219789)
					{
						this.$mPos$18760 = mPos;
						if (275712 - 567606 != -291893)
						{
							this.$tDir$18761 = tDir;
							if (30538 - 459020 != -428481)
							{
								this.$self_$18762 = self_;
								if (86653 - 102027 != -15373)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600143E RID: 5182 RVA: 0x001FDF30 File Offset: 0x001FC130
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Shade1.$RPC_nAttack$18748.$(this.$mPos$18760, this.$tDir$18761, this.$self_$18762);
		}

		// Token: 0x0600143F RID: 5183 RVA: 0x001FDF4C File Offset: 0x001FC14C
		internal static bool zqLg3hOnPue5yOyOgFf()
		{
			return true;
		}

		// Token: 0x06001440 RID: 5184 RVA: 0x001FDF50 File Offset: 0x001FC150
		internal static bool BbdNAPO6U89fCAZ73cl()
		{
			return false;
		}

		// Token: 0x040011A0 RID: 4512
		internal Vector3 $mPos$18760;

		// Token: 0x040011A1 RID: 4513
		internal Vector3 $tDir$18761;

		// Token: 0x040011A2 RID: 4514
		internal Shade1 $self_$18762;

		// Token: 0x02000377 RID: 887
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001441 RID: 5185 RVA: 0x001FDF54 File Offset: 0x001FC154
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Shade1 self_)
			{
				if (18685 - 96551 != -77865)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (50859 - 402467 == -351608)
					{
						base..ctor();
						if (50022 - 119620 != -69597)
						{
							this.$mPos$18757 = mPos;
							if (250606 - 305187 != -54580)
							{
								this.$tDir$18758 = tDir;
								if (112394 - 166315 == -53921)
								{
									this.$self_$18759 = self_;
									if (75630 - 204348 != -128717)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06001442 RID: 5186 RVA: 0x001FE030 File Offset: 0x001FC230
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (162872 - 185930 != -23058)
				{
				}
				for (;;)
				{
					IL_4F9:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_ACF;
					case 2:
						if (this.$self_$18759.mChar.actionState != "attack")
						{
							goto IL_5F9;
						}
						if (165093 - 585909 == -420815)
						{
							continue;
						}
						if (this.$self_$18759.mChar.myCommand != "nAttack")
						{
							if (57108 - 427350 != -370242)
							{
								continue;
							}
							goto IL_5F9;
						}
						else
						{
							this.$self_$18759.mChar.moveSpeed = (float)6;
							if (272852 - 10595 != 262257)
							{
								continue;
							}
							this.$i$18749 = 0;
							if (286209 - 429874 != -143664)
							{
								goto IL_6E2;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$18759.mChar.actionState != "attack")
						{
							goto IL_4C5;
						}
						if (47515 - 15230 != 32285)
						{
							continue;
						}
						if (this.$self_$18759.mChar.myCommand != "nAttack")
						{
							if (9641 - 296640 != -286999)
							{
								continue;
							}
							goto IL_4C5;
						}
						else
						{
							if (this.$self_$18759.mChar.isMine)
							{
								if (270369 - 143259 != 127110)
								{
									continue;
								}
								this.$hitLayer$18750 = 130816 - (1 << this.$self_$18759.gameObject.layer);
								if (209540 - 555844 != -346304)
								{
									continue;
								}
								this.$hitList$18751 = Damage.FindRecTarget(this.$self_$18759.transform.position, this.$self_$18759.transform.forward, (float)1, (float)1, (float)3, (float)3, this.$hitLayer$18750);
								if (206608 - 275202 == -68593)
								{
									continue;
								}
								this.$hitPos$18752 = default(Vector3);
								if (284769 - 113472 != 171297)
								{
									continue;
								}
								this.$$iterator$10481$18756 = UnityRuntimeServices.GetEnumerator(this.$hitList$18751);
								if (143103 - 335928 == -192824)
								{
									continue;
								}
								while (this.$$iterator$10481$18756.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$10481$18756.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$18753 = (GameObject)obj2;
									if (133002 - 526663 != -393661)
									{
										goto IL_4F9;
									}
									if (this.$hitObject$18753)
									{
										if (151008 - 17323 != 133685)
										{
											goto IL_4F9;
										}
										this.$hitChar$18754 = (CharacterControl)this.$hitObject$18753.GetComponent(typeof(CharacterControl));
										if (239926 - 406999 == -167072)
										{
											goto IL_4F9;
										}
										UnityRuntimeServices.Update(this.$$iterator$10481$18756, this.$hitObject$18753);
										if (29265 - 114078 != -84813)
										{
											goto IL_4F9;
										}
										if (this.$hitChar$18754)
										{
											if (287509 - 86275 != 201234)
											{
												goto IL_4F9;
											}
											this.$hitDir$18755 = global::Math.vFlat(this.$hitObject$18753.transform.position - this.$self_$18759.transform.position).normalized;
											if (231438 - 329008 == -97569)
											{
												goto IL_4F9;
											}
											UnityRuntimeServices.Update(this.$$iterator$10481$18756, this.$hitObject$18753);
											if (125320 - 219135 != -93815)
											{
												goto IL_4F9;
											}
											this.$self_$18759.RPC_grab(this.$self_$18759.transform.position, this.$hitDir$18755, this.$hitChar$18754.ActorNr);
											if (166346 - 232480 != -66134)
											{
												goto IL_4F9;
											}
											this.$self_$18759.ActionEvent("RPC_grab", this.$hitPos$18752, this.$hitDir$18755, this.$hitChar$18754.ActorNr);
											if (99550 - 152396 != -52846)
											{
												goto IL_4F9;
											}
											goto IL_9A6;
										}
									}
								}
								if (299044 - 120882 != 178162)
								{
									continue;
								}
							}
							this.$i$18749++;
							if (5564 - 302265 != -296700)
							{
								goto IL_6E2;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$18759.mChar.actionState != "attack")
						{
							goto IL_245;
						}
						if (122290 - 563995 != -441705)
						{
							continue;
						}
						if (this.$self_$18759.mChar.myCommand != "nAttack")
						{
							if (208266 - 31717 != 176549)
							{
								continue;
							}
							goto IL_245;
						}
						else
						{
							this.$self_$18759.mChar.moveSpeed = (float)1;
							if (19473 - 235627 != -216154)
							{
								continue;
							}
							goto IL_3B0;
						}
						break;
					case 5:
						if (this.$self_$18759.mChar.actionState != "attack")
						{
							goto IL_276;
						}
						if (226103 - 77693 == 148411)
						{
							continue;
						}
						if (this.$self_$18759.mChar.myCommand != "nAttack")
						{
							if (275670 - 405851 != -130180)
							{
								goto Block_39;
							}
							continue;
						}
						else
						{
							this.$self_$18759.mChar.moveSpeed = (float)0;
							if (40533 - 75448 != -34915)
							{
								continue;
							}
							goto IL_693;
						}
						break;
					case 6:
						if (this.$self_$18759.mChar.actionState == "attack")
						{
							if (117449 - 567212 != -449763)
							{
								continue;
							}
							if (this.$self_$18759.mChar.myCommand == "nAttack")
							{
								if (49900 - 312072 == -262171)
								{
									continue;
								}
								this.$self_$18759.mChar.actionState = "standby";
								if (267359 - 245406 == 21954)
								{
									continue;
								}
								this.$self_$18759.mChar.actionTime = Time.time;
								if (128991 - 375503 != -246512)
								{
									continue;
								}
								this.$self_$18759.mChar.myCommand = "none";
								if (151144 - 290021 == -138876)
								{
									continue;
								}
								if (!this.$self_$18759.mChar.isMine)
								{
									if (109941 - 29550 == 80392)
									{
										continue;
									}
									this.$self_$18759.mChar.nPosition = this.$self_$18759.transform.position;
									if (186225 - 176845 != 9380)
									{
										continue;
									}
									this.$self_$18759.mChar.oPosition = this.$self_$18759.transform.position;
									if (191745 - 265508 != -73763)
									{
										continue;
									}
									this.$self_$18759.mChar.nDirection = this.$self_$18759.transform.forward;
									if (148917 - 90795 != 58122)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (101894 - 423399 != -321504)
						{
							goto Block_63;
						}
						continue;
					default:
						if (108340 - 127884 == -19543)
						{
							continue;
						}
						break;
					}
					this.$self_$18759.mChar.actionState = "attack";
					if (125823 - 404926 != -279103)
					{
						continue;
					}
					this.$self_$18759.mChar.actionTime = Time.time;
					if (250194 - 178111 == 72084)
					{
						continue;
					}
					this.$self_$18759.mChar.myCommand = "nAttack";
					if (165146 - 389776 != -224630)
					{
						continue;
					}
					this.$self_$18759.mChar.addTimeOut("nAttack", (float)3);
					if (137209 - 372864 == -235654)
					{
						continue;
					}
					this.$self_$18759.transform.position = this.$mPos$18757;
					if (192994 - 297921 == -104926)
					{
						continue;
					}
					this.$self_$18759.transform.LookAt(this.$mPos$18757 + global::Math.vFlat(this.$tDir$18758));
					if (234368 - 525730 == -291361)
					{
						continue;
					}
					this.$self_$18759.animation.CrossFade("nAttack");
					if (175691 - 379545 == -203853)
					{
						continue;
					}
					this.$self_$18759.animation.wrapMode = WrapMode.Once;
					if (272233 - 74462 == 197772)
					{
						continue;
					}
					this.$self_$18759.mChar.vMovement = this.$self_$18759.transform.forward;
					if (57262 - 398725 == -341462)
					{
						continue;
					}
					this.$self_$18759.mChar.moveSpeed = (float)3;
					if (165669 - 199528 != -33859)
					{
						continue;
					}
					goto IL_A46;
					IL_6E2:
					if (this.$i$18749 < 2)
					{
						goto IL_91E;
					}
					if (89917 - 423502 != -333584)
					{
						goto Block_44;
					}
				}
				IL_245:
				IL_276:
				goto IL_ACF;
				IL_3B0:
				return this.Yield(5, new WaitForSeconds(0.1f));
				IL_4C5:
				IL_5F9:
				Block_39:
				goto IL_276;
				IL_693:
				return this.Yield(6, new WaitForSeconds(0.1f));
				Block_44:
				return this.Yield(4, new WaitForSeconds(0.1f));
				IL_91E:
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_9A6:
				Block_63:
				goto IL_ACF;
				IL_A46:
				return this.Yield(2, new WaitForSeconds(0.1f));
				IL_ACF:
				return false;
			}

			// Token: 0x06001443 RID: 5187 RVA: 0x001FEB20 File Offset: 0x001FCD20
			internal static bool EhydGyOiKpBtyonvi4T()
			{
				return true;
			}

			// Token: 0x06001444 RID: 5188 RVA: 0x001FEB24 File Offset: 0x001FCD24
			internal static bool sPdYpHOKGUOZFtVsNvv()
			{
				return false;
			}

			// Token: 0x040011A3 RID: 4515
			internal int $i$18749;

			// Token: 0x040011A4 RID: 4516
			internal int $hitLayer$18750;

			// Token: 0x040011A5 RID: 4517
			internal UnityScript.Lang.Array $hitList$18751;

			// Token: 0x040011A6 RID: 4518
			internal Vector3 $hitPos$18752;

			// Token: 0x040011A7 RID: 4519
			internal GameObject $hitObject$18753;

			// Token: 0x040011A8 RID: 4520
			internal CharacterControl $hitChar$18754;

			// Token: 0x040011A9 RID: 4521
			internal Vector3 $hitDir$18755;

			// Token: 0x040011AA RID: 4522
			internal IEnumerator $$iterator$10481$18756;

			// Token: 0x040011AB RID: 4523
			internal Vector3 $mPos$18757;

			// Token: 0x040011AC RID: 4524
			internal Vector3 $tDir$18758;

			// Token: 0x040011AD RID: 4525
			internal Shade1 $self_$18759;
		}
	}

	// Token: 0x02000378 RID: 888
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$18763 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001445 RID: 5189 RVA: 0x001FEB28 File Offset: 0x001FCD28
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$18763(UnityScript.Lang.Array nArray, Shade1 self_)
		{
			if (238111 - 284488 != -46376)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (134127 - 135552 == -1425)
				{
					base..ctor();
					if (225916 - 53793 != 172124)
					{
						this.$nArray$18768 = nArray;
						if (181127 - 61805 == 119322)
						{
							this.$self_$18769 = self_;
							if (291987 - 69992 == 221995)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06001446 RID: 5190 RVA: 0x001FEBE4 File Offset: 0x001FCDE4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Shade1.$RPC_dead$18763.$(this.$nArray$18768, this.$self_$18769);
		}

		// Token: 0x06001447 RID: 5191 RVA: 0x001FEBF8 File Offset: 0x001FCDF8
		internal static bool AgoWQ6OdQr19wml38V6()
		{
			return true;
		}

		// Token: 0x06001448 RID: 5192 RVA: 0x001FEBFC File Offset: 0x001FCDFC
		internal static bool LxnJ71OJsxDhpeeE0UW()
		{
			return false;
		}

		// Token: 0x040011AE RID: 4526
		internal UnityScript.Lang.Array $nArray$18768;

		// Token: 0x040011AF RID: 4527
		internal Shade1 $self_$18769;

		// Token: 0x02000379 RID: 889
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001449 RID: 5193 RVA: 0x001FEC00 File Offset: 0x001FCE00
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Shade1 self_)
			{
				if (38280 - 356498 != -318217)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (164883 - 597579 == -432696)
					{
						base..ctor();
						if (107401 - 179785 == -72384)
						{
							this.$nArray$18766 = nArray;
							if (204307 - 462339 != -258031)
							{
								this.$self_$18767 = self_;
								if (272930 - 588100 != -315169)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600144A RID: 5194 RVA: 0x001FECBC File Offset: 0x001FCEBC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (167466 - 136604 != 30863)
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
						if (this.$self_$18767.mChar.actionState != "dead")
						{
							if (17464 - 172369 != -154904)
							{
								goto Block_23;
							}
							continue;
						}
						else
						{
							if (!this.$self_$18767.mChar.isPlayer)
							{
								if (88748 - 291302 != -202554)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$18767.gameObject);
								if (236673 - 207311 == 29363)
								{
									continue;
								}
							}
							else if (this.$self_$18767.mChar.isMine)
							{
								if (31184 - 233144 == -201959)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$18767.gameObject);
								if (288333 - 35584 != 252749)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (145899 - 492064 != -346165)
							{
								continue;
							}
							goto IL_42F;
						}
						break;
					default:
						if (216177 - 26794 != 189383)
						{
							continue;
						}
						break;
					}
					if (this.$self_$18767.mChar.actionState == "dead")
					{
						if (1781 - 293082 != -291300)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$18764 = (Vector3)this.$nArray$18766[0];
						if (192388 - 331053 != -138664)
						{
							this.$myDirection$18765 = (Vector3)this.$nArray$18766[1];
							if (205503 - 199389 == 6114)
							{
								this.$self_$18767.transform.position = this.$myPosition$18764;
								if (108872 - 46945 != 61928)
								{
									this.$self_$18767.transform.LookAt(this.$myPosition$18764 + this.$myDirection$18765);
									if (28068 - 277708 == -249640)
									{
										this.$self_$18767.mChar.hp = 0;
										if (61495 - 448350 != -386854)
										{
											this.$self_$18767.mChar.actionState = "dead";
											if (160497 - 271176 != -110678)
											{
												this.$self_$18767.mChar.actionTime = Time.time;
												if (158255 - 389635 == -231380)
												{
													this.$self_$18767.mChar.myCommand = "none";
													if (280732 - 118581 != 162152)
													{
														this.$self_$18767.mChar.vMovement = Vector3.zero;
														if (103098 - 487304 != -384205)
														{
															this.$self_$18767.mChar.moveSpeed = (float)0;
															if (282358 - 271910 != 10449)
															{
																this.$self_$18767.animation.Rewind();
																if (36704 - 297246 == -260542)
																{
																	this.$self_$18767.animation.Play("ko");
																	if (157158 - 25515 != 131644)
																	{
																		this.$self_$18767.animation.wrapMode = WrapMode.Once;
																		if (115743 - 131476 == -15733)
																		{
																			goto IL_345;
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_42F;
				IL_345:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_23:
				IL_42F:
				return false;
			}

			// Token: 0x0600144B RID: 5195 RVA: 0x001FF10C File Offset: 0x001FD30C
			internal static bool jlsWltODduHSa6ty3X6()
			{
				return true;
			}

			// Token: 0x0600144C RID: 5196 RVA: 0x001FF110 File Offset: 0x001FD310
			internal static bool c5WYiJOvNq7D1d6CGu5()
			{
				return false;
			}

			// Token: 0x040011B0 RID: 4528
			internal Vector3 $myPosition$18764;

			// Token: 0x040011B1 RID: 4529
			internal Vector3 $myDirection$18765;

			// Token: 0x040011B2 RID: 4530
			internal UnityScript.Lang.Array $nArray$18766;

			// Token: 0x040011B3 RID: 4531
			internal Shade1 $self_$18767;
		}
	}
}
