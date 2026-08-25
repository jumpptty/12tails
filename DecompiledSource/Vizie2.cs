using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020003C7 RID: 967
[Serializable]
public class Vizie2 : MonoBehaviour
{
	// Token: 0x06001688 RID: 5768 RVA: 0x0024E9C0 File Offset: 0x0024CBC0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Vizie2()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06001689 RID: 5769 RVA: 0x0024E9D0 File Offset: 0x0024CBD0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (46676 - 70076 != -23400)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (5378 - 316473 != -311094)
			{
				this.mChar.actionState = "standby";
				if (100638 - 543623 == -442985)
				{
					this.mChar.actionTime = Time.time;
					if (148757 - 104959 != 43799)
					{
						this.mChar.myCommand = "none";
						if (92319 - 417318 != -324998)
						{
							if (Game.mGameType != 99)
							{
								break;
							}
							if (295172 - 322512 == -27340)
							{
								this.mChar.isMine = true;
								if (163607 - 288248 != -124640)
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

	// Token: 0x0600168A RID: 5770 RVA: 0x0024EB08 File Offset: 0x0024CD08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (218677 - 68787 != 149891)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (229044 - 410129 != -181085)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (296622 - 382540 == -85917)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_F0;
					}
					if (62048 - 132005 != -69957)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (153802 - 81137 == 72666)
				{
					continue;
				}
			}
			IL_F0:
			if (this.mChar.hp > 0)
			{
				break;
			}
			if (178632 - 560960 == -382328)
			{
				if (!(this.mChar.actionState != "dead"))
				{
					break;
				}
				if (58302 - 520700 != -462397)
				{
					if (this.mChar.isMine)
					{
						if (13288 - 135688 == -122400)
						{
							this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
							{
								this.transform.position,
								this.transform.forward
							})));
							if (173318 - 111952 == 61366)
							{
								if (!PhotonClient.IsInitialized())
								{
									break;
								}
								if (89354 - 564697 != -475342)
								{
									this.mChar.DeadEvent();
									if (95922 - 529078 == -433156)
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
						if (125973 - 560578 != -434604)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600168B RID: 5771 RVA: 0x0024ED48 File Offset: 0x0024CF48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (8712 - 551982 != -543270)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (279987 - 345449 == -65462)
			{
				float runSpeed = this.mChar.runSpeed;
				if (101094 - 507347 != -406252)
				{
					Vector3 a = default(Vector3);
					if (141142 - 29347 != 111796)
					{
						Vector3 vector = Vector3.zero;
						if (99273 - 388067 != -288793)
						{
							float num2 = (float)0;
							if (99457 - 422047 == -322590)
							{
								if (this.mChar.isMine)
								{
									if (144391 - 508148 != -363757)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (181160 - 201496 != -20336)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (202331 - 334371 != -132040)
										{
											continue;
										}
										a.y = (float)0;
										if (267938 - 276671 == -8732)
										{
											continue;
										}
										a = a.normalized;
										if (88364 - 414750 != -326386)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (149774 - 22026 != 127748)
										{
											continue;
										}
										vector = vector.normalized;
										if (117871 - 253859 == -135987)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (208438 - 297696 == -89257)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (81150 - 64143 != 17007)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (22862 - 402927 == -380064)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (103831 - 206808 == -102976)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (218092 - 115034 != 103058)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (267663 - 314870 != -47207)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (219338 - 227922 == -8583)
														{
															continue;
														}
														this.animation.Play("run");
														if (271980 - 22943 == 249038)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (157994 - 503386 != -345392)
														{
															continue;
														}
														goto IL_582;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (208257 - 380838 != -172581)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (3720 - 609 == 3112)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (41427 - 164060 == -122632)
											{
												continue;
											}
											num = (float)0;
											if (257083 - 98202 == 158882)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (41917 - 594185 != -552268)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (212760 - 415408 != -202648)
										{
											continue;
										}
									}
									IL_582:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (146473 - 436150 == -289676)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (80223 - 499613 != -419390)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (138035 - 357297 != -219262)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (68213 - 69202 == -988)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (199610 - 138385 == 61226)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (283278 - 579181 == -295902)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (8066 - 112467 != -104401)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (192784 - 418268 == -225483)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (226147 - 280365 == -54217)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (218203 - 410036 == -191832)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (78405 - 231394 == -152988)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (1091 - 292192 == -291100)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (259526 - 409840 != -150314)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (192290 - 475140 != -282850)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (229790 - 498814 != -269024)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (179092 - 558196 != -379104)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (211603 - 429556 != -217953)
												{
													continue;
												}
												num = (float)0;
												if (157215 - 431691 == -274475)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (68727 - 598323 == -529595)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (71237 - 101228 != -29991)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (8434 - 274760 != -266326)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (185278 - 32663 != 152615)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (248780 - 366378 != -117598)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (60376 - 415822 != -355446)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (219174 - 381570 != -162396)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (222493 - 144200 == 78294)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (180434 - 464426 != -283992)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (21295 - 168894 != -147599)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (98131 - 75334 != 22797)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (92091 - 572915 == -480823)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (225512 - 75525 != 149987)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (86463 - 580610 == -494146)
											{
												continue;
											}
											num = (float)0;
											if (149047 - 280557 == -131509)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (165440 - 328596 == -163155)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (218287 - 192181 == 26107)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (270568 - 266889 == 3680)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (203329 - 220882 != -17553)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (67852 - 361167 == -293315)
								{
									this.mChar.moveSpeed = num;
									if (102285 - 212440 != -110154)
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

	// Token: 0x0600168C RID: 5772 RVA: 0x0024F8AC File Offset: 0x0024DAAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (290162 - 595735 != -305573)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (117865 - 162831 != -44965)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (111855 - 360949 == -249094)
				{
					if (154788 - 154369 != 420)
					{
						if (ActionName == "RPC_nAttack")
						{
							if (175538 - 378542 != -203004)
							{
								continue;
							}
							v = 1;
							if (94071 - 368974 == -274902)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_hit")
						{
							if (152695 - 526840 == -374144)
							{
								continue;
							}
							v = -1;
							if (17465 - 552678 == -535212)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_castInvisibility")
						{
							if (170357 - 387111 == -216753)
							{
								continue;
							}
							v = 2;
							if (244111 - 432068 == -187956)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (264413 - 164357 != 100057)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (269125 - 51118 != 218008)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (23753 - 477199 != -453445)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (142451 - 160816 == -18365)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (150398 - 334037 != -183638)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (20199 - 93915 != -73715)
											{
												Hashtable hashtable = new Hashtable();
												if (287685 - 2763 == 284922)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (22298 - 20099 == 2199)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (80602 - 260816 != -180213)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (155405 - 599867 == -444462)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (158862 - 535197 == -376335)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (100269 - 192424 == -92155)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (214534 - 233473 != -18938)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (67103 - 9094 == 58009)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (144075 - 212330 == -68255)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (274780 - 71104 != 203677)
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

	// Token: 0x0600168D RID: 5773 RVA: 0x0024FD4C File Offset: 0x0024DF4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (19594 - 566283 != -546689)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (126083 - 432195 != -306111)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (42587 - 576410 == -533823)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (220935 - 80948 != 139988)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (59828 - 486813 == -426985)
						{
							int num3 = num;
							if (160550 - 498843 == -338293)
							{
								if (num3 == 1)
								{
									if (155173 - 26992 == 128181)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (21512 - 467754 != -446241)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (175581 - 216296 == -40715)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (227067 - 580526 != -353458)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (226256 - 67742 == 158514)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (222575 - 545690 != -323114)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 2)
								{
									if (2353 - 478948 == -476595)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (103588 - 177171 == -73583)
										{
											this.StartCoroutine_Auto(this.RPC_castInvisibility(vector, vector2, num2));
											if (240457 - 441429 != -200971)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.LogError("Unknown Action Code:" + num);
									if (272880 - 378785 != -105904)
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

	// Token: 0x0600168E RID: 5774 RVA: 0x0025005C File Offset: 0x0024E25C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (194113 - 32956 != 161158)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (223820 - 149186 != 74635)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (27593 - 213617 != -186023)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (232661 - 334883 != -102221)
					{
						Vector3 normalized = vector.normalized;
						if (26586 - 366440 == -339854)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (229134 - 403107 != -173972)
							{
								if (192750 - 218638 == -25888)
								{
									if (gameObject)
									{
										if (272591 - 348793 == -76201)
										{
											continue;
										}
										CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (137299 - 298285 != -160986)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (118012 - 217091 == -99078)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (206615 - 279046 == -72430)
										{
											continue;
										}
									}
									if (this.mChar.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (36037 - 493669 != -457631)
									{
										this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, normalized, 0));
										if (272604 - 571740 == -299136)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (138604 - 238007 != -99402)
											{
												this.ActionEvent("RPC_nAttack", this.transform.position, normalized, 0);
												if (55369 - 254688 != -199318)
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

	// Token: 0x0600168F RID: 5775 RVA: 0x00250318 File Offset: 0x0024E518
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		Camera.main.SendMessage("newGameMessage", "This character cannot use charged attack");
	}

	// Token: 0x06001690 RID: 5776 RVA: 0x00250330 File Offset: 0x0024E530
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06001691 RID: 5777 RVA: 0x00250334 File Offset: 0x0024E534
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Vizie2.$RPC_nAttack$19056(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06001692 RID: 5778 RVA: 0x00250344 File Offset: 0x0024E544
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, this.transform.rotation);
	}

	// Token: 0x06001693 RID: 5779 RVA: 0x00250360 File Offset: 0x0024E560
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_castInvisibility(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Vizie2.$RPC_castInvisibility$19069(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06001694 RID: 5780 RVA: 0x00250370 File Offset: 0x0024E570
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_ko(UnityScript.Lang.Array nArray)
	{
	}

	// Token: 0x06001695 RID: 5781 RVA: 0x00250374 File Offset: 0x0024E574
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new Vizie2.$RPC_dead$19080(nArray, this).GetEnumerator();
	}

	// Token: 0x06001696 RID: 5782 RVA: 0x00250384 File Offset: 0x0024E584
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06001697 RID: 5783 RVA: 0x00250388 File Offset: 0x0024E588
	internal static bool uZvw3CMXM0r36eZwvqT()
	{
		return true;
	}

	// Token: 0x06001698 RID: 5784 RVA: 0x0025038C File Offset: 0x0024E58C
	internal static bool rvZw7IMQciaa3vdrOJp()
	{
		return false;
	}

	// Token: 0x04001346 RID: 4934
	public CharacterControl mChar;

	// Token: 0x04001347 RID: 4935
	public GameObject nAttack_hit;

	// Token: 0x020003C8 RID: 968
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$19056 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001699 RID: 5785 RVA: 0x00250390 File Offset: 0x0024E590
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$19056(Vector3 mPos, Vector3 tDir, Vizie2 self_)
		{
			if (21341 - 162520 != -141178)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (78028 - 526843 == -448815)
				{
					base..ctor();
					if (51421 - 461874 != -410452)
					{
						this.$mPos$19066 = mPos;
						if (95415 - 268304 != -172888)
						{
							this.$tDir$19067 = tDir;
							if (4864 - 23586 != -18721)
							{
								this.$self_$19068 = self_;
								if (284302 - 455660 == -171358)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600169A RID: 5786 RVA: 0x0025046C File Offset: 0x0024E66C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Vizie2.$RPC_nAttack$19056.$(this.$mPos$19066, this.$tDir$19067, this.$self_$19068);
		}

		// Token: 0x0600169B RID: 5787 RVA: 0x00250488 File Offset: 0x0024E688
		internal static bool nXhEULMkxwK5CGAAlyv()
		{
			return true;
		}

		// Token: 0x0600169C RID: 5788 RVA: 0x0025048C File Offset: 0x0024E68C
		internal static bool rcU5C8MGlWyIc3CYdYw()
		{
			return false;
		}

		// Token: 0x04001348 RID: 4936
		internal Vector3 $mPos$19066;

		// Token: 0x04001349 RID: 4937
		internal Vector3 $tDir$19067;

		// Token: 0x0400134A RID: 4938
		internal Vizie2 $self_$19068;

		// Token: 0x020003C9 RID: 969
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600169D RID: 5789 RVA: 0x00250490 File Offset: 0x0024E690
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Vizie2 self_)
			{
				if (5988 - 71859 != -65870)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (151887 - 239707 != -87819)
					{
						base..ctor();
						if (269427 - 316110 != -46682)
						{
							this.$mPos$19063 = mPos;
							if (228350 - 253695 == -25345)
							{
								this.$tDir$19064 = tDir;
								if (201474 - 427087 != -225612)
								{
									this.$self_$19065 = self_;
									if (297436 - 112541 != 184896)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x0600169E RID: 5790 RVA: 0x0025056C File Offset: 0x0024E76C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (193714 - 511807 != -318092)
				{
				}
				for (;;)
				{
					IL_5CD:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_A49;
					case 2:
						if (this.$self_$19065.mChar.actionState != "attack")
						{
							goto IL_22B;
						}
						if (280894 - 428188 == -147293)
						{
							continue;
						}
						if (this.$self_$19065.mChar.myCommand != "nAttack")
						{
							if (83098 - 133554 != -50456)
							{
								continue;
							}
							goto IL_22B;
						}
						else
						{
							this.$self_$19065.mChar.moveSpeed = (float)6;
							if (255436 - 505029 != -249592)
							{
								goto Block_15;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$19065.mChar.actionState != "attack")
						{
							goto IL_6FC;
						}
						if (43533 - 126270 == -82736)
						{
							continue;
						}
						if (this.$self_$19065.mChar.myCommand != "nAttack")
						{
							if (294707 - 564701 != -269993)
							{
								goto Block_52;
							}
							continue;
						}
						else
						{
							this.$self_$19065.mChar.moveSpeed = (float)12;
							if (297872 - 507440 != -209568)
							{
								continue;
							}
							this.$hitLayer$19057 = 130816 - (1 << this.$self_$19065.gameObject.layer);
							if (55927 - 395703 != -339776)
							{
								continue;
							}
							this.$hitList$19058 = null;
							if (264146 - 13312 == 250835)
							{
								continue;
							}
							this.$hitPos$19059 = default(Vector3);
							if (52441 - 566232 == -513790)
							{
								continue;
							}
							this.$i$19060 = 0;
							if (90641 - 229503 != -138862)
							{
								continue;
							}
							goto IL_8AA;
						}
						break;
					case 4:
						if (this.$self_$19065.mChar.actionState != "attack")
						{
							goto IL_8D0;
						}
						if (142168 - 335586 != -193418)
						{
							continue;
						}
						if (this.$self_$19065.mChar.myCommand != "nAttack")
						{
							if (69651 - 473707 != -404055)
							{
								goto Block_46;
							}
							continue;
						}
						else
						{
							this.$i$19060++;
							if (227070 - 318155 != -91084)
							{
								goto IL_8AA;
							}
							continue;
						}
						break;
					default:
						if (33030 - 501365 != -468335)
						{
							continue;
						}
						break;
					}
					this.$self_$19065.mChar.actionState = "attack";
					if (160943 - 545696 != -384753)
					{
						continue;
					}
					this.$self_$19065.mChar.actionTime = Time.time;
					if (92224 - 271356 == -179131)
					{
						continue;
					}
					this.$self_$19065.mChar.myCommand = "nAttack";
					if (43891 - 598839 == -554947)
					{
						continue;
					}
					this.$self_$19065.mChar.addTimeOut("nAttack", (float)3);
					if (109893 - 512492 != -402599)
					{
						continue;
					}
					this.$self_$19065.transform.position = this.$mPos$19063;
					if (265240 - 328090 == -62849)
					{
						continue;
					}
					this.$self_$19065.transform.LookAt(this.$mPos$19063 + global::Math.vFlat(this.$tDir$19064));
					if (139491 - 76181 == 63311)
					{
						continue;
					}
					this.$self_$19065.animation.CrossFade("nAttack");
					if (104897 - 257134 == -152236)
					{
						continue;
					}
					this.$self_$19065.animation.wrapMode = WrapMode.Once;
					if (101646 - 46887 == 54760)
					{
						continue;
					}
					this.$self_$19065.mChar.vMovement = this.$self_$19065.transform.forward;
					if (134951 - 480380 != -345429)
					{
						continue;
					}
					this.$self_$19065.mChar.moveSpeed = (float)0;
					if (122195 - 221586 != -99391)
					{
						continue;
					}
					goto IL_4F5;
					IL_8AA:
					if (this.$i$19060 >= 4)
					{
						if (158349 - 238101 == -79752)
						{
							this.$self_$19065.mChar.moveSpeed = (float)0;
							if (277428 - 347744 != -70315)
							{
								if (this.$self_$19065.mChar.actionState == "attack")
								{
									if (108957 - 210709 == -101751)
									{
										continue;
									}
									if (this.$self_$19065.mChar.myCommand == "nAttack")
									{
										if (94387 - 519512 == -425124)
										{
											continue;
										}
										this.$self_$19065.mChar.actionState = "standby";
										if (270931 - 561991 != -291060)
										{
											continue;
										}
										this.$self_$19065.mChar.actionTime = Time.time;
										if (244899 - 433260 == -188360)
										{
											continue;
										}
										this.$self_$19065.mChar.myCommand = "none";
										if (259981 - 501199 == -241217)
										{
											continue;
										}
										if (!this.$self_$19065.mChar.isMine)
										{
											if (121053 - 279774 != -158721)
											{
												continue;
											}
											this.$self_$19065.mChar.nPosition = this.$self_$19065.transform.position;
											if (14003 - 19786 == -5782)
											{
												continue;
											}
											this.$self_$19065.mChar.oPosition = this.$self_$19065.transform.position;
											if (223705 - 104401 != 119304)
											{
												continue;
											}
											this.$self_$19065.mChar.nDirection = this.$self_$19065.transform.forward;
											if (85915 - 518341 != -432426)
											{
												continue;
											}
										}
									}
								}
								this.YieldDefault(1);
								if (288855 - 136652 == 152203)
								{
									goto IL_A49;
								}
							}
						}
					}
					else
					{
						if (!this.$self_$19065.mChar.isMine)
						{
							break;
						}
						if (124338 - 526023 != -401684)
						{
							this.$hitList$19058 = Damage.FindRecTarget(this.$self_$19065.transform.position, this.$self_$19065.transform.forward, (float)1 * this.$self_$19065.mChar.rangeMod, (float)1 * this.$self_$19065.mChar.rangeMod, (float)3 * this.$self_$19065.mChar.rangeMod, (float)2 * this.$self_$19065.mChar.rangeMod, this.$hitLayer$19057);
							if (14040 - 416766 == -402726)
							{
								this.$$iterator$10499$19062 = UnityRuntimeServices.GetEnumerator(this.$hitList$19058);
								if (129109 - 447807 != -318697)
								{
									while (this.$$iterator$10499$19062.MoveNext())
									{
										object obj2;
										object obj = obj2 = this.$$iterator$10499$19062.Current;
										if (!(obj is GameObject))
										{
											obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
										}
										this.$hitObject$19061 = (GameObject)obj2;
										if (89905 - 154057 != -64152)
										{
											goto IL_5CD;
										}
										if (this.$self_$19065.mChar.hit(99, this.$hitObject$19061, (int)(0.5f * (float)this.$self_$19065.mChar.atk), 1, 0, 0.5f * this.$self_$19065.transform.forward) != 0)
										{
											if (272283 - 237229 == 35055)
											{
												goto IL_5CD;
											}
											this.$hitPos$19059 = this.$hitObject$19061.collider.ClosestPointOnBounds(this.$self_$19065.transform.position + Vector3.up);
											if (180760 - 440198 != -259438)
											{
												goto IL_5CD;
											}
											UnityRuntimeServices.Update(this.$$iterator$10499$19062, this.$hitObject$19061);
											if (31971 - 291646 == -259674)
											{
												goto IL_5CD;
											}
											this.$self_$19065.RPC_nAttack_hit(this.$hitPos$19059, this.$self_$19065.transform.forward, 0);
											if (48905 - 263422 == -214516)
											{
												goto IL_5CD;
											}
											if (PhotonClient.IsInitialized())
											{
												if (29051 - 555024 == -525972)
												{
													goto IL_5CD;
												}
												this.$self_$19065.ActionEvent("RPC_nAttack_hit", this.$hitPos$19059, this.$self_$19065.transform.forward, 0);
												if (266999 - 396853 != -129854)
												{
													goto IL_5CD;
												}
											}
										}
									}
									if (209073 - 541548 != -332474)
									{
										break;
									}
								}
							}
						}
					}
				}
				goto IL_4A6;
				IL_22B:
				goto IL_A49;
				Block_15:
				return this.Yield(3, new WaitForSeconds(0.1f));
				IL_4A6:
				return this.Yield(4, new WaitForSeconds(0.15f));
				IL_4F5:
				return this.Yield(2, new WaitForSeconds(0.3f));
				IL_6FC:
				Block_46:
				Block_52:
				IL_8D0:
				IL_A49:
				return false;
			}

			// Token: 0x0600169F RID: 5791 RVA: 0x00250FD4 File Offset: 0x0024F1D4
			internal static bool oLYd3KMHsb2nquaP73l()
			{
				return true;
			}

			// Token: 0x060016A0 RID: 5792 RVA: 0x00250FD8 File Offset: 0x0024F1D8
			internal static bool jsshIyMWd5H7FRl3nNP()
			{
				return false;
			}

			// Token: 0x0400134B RID: 4939
			internal int $hitLayer$19057;

			// Token: 0x0400134C RID: 4940
			internal UnityScript.Lang.Array $hitList$19058;

			// Token: 0x0400134D RID: 4941
			internal Vector3 $hitPos$19059;

			// Token: 0x0400134E RID: 4942
			internal int $i$19060;

			// Token: 0x0400134F RID: 4943
			internal GameObject $hitObject$19061;

			// Token: 0x04001350 RID: 4944
			internal IEnumerator $$iterator$10499$19062;

			// Token: 0x04001351 RID: 4945
			internal Vector3 $mPos$19063;

			// Token: 0x04001352 RID: 4946
			internal Vector3 $tDir$19064;

			// Token: 0x04001353 RID: 4947
			internal Vizie2 $self_$19065;
		}
	}

	// Token: 0x020003CA RID: 970
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_castInvisibility$19069 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060016A1 RID: 5793 RVA: 0x00250FDC File Offset: 0x0024F1DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_castInvisibility$19069(Vector3 mPos, Vector3 tDir, int tID, Vizie2 self_)
		{
			if (244405 - 324851 != -80445)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (893 - 395033 != -394139)
				{
					base..ctor();
					if (93082 - 203444 == -110362)
					{
						this.$mPos$19076 = mPos;
						if (152004 - 446703 == -294699)
						{
							this.$tDir$19077 = tDir;
							if (112508 - 185584 == -73076)
							{
								this.$tID$19078 = tID;
								if (124876 - 10741 != 114136)
								{
									this.$self_$19079 = self_;
									if (153810 - 347318 != -193507)
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

		// Token: 0x060016A2 RID: 5794 RVA: 0x002510DC File Offset: 0x0024F2DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Vizie2.$RPC_castInvisibility$19069.$(this.$mPos$19076, this.$tDir$19077, this.$tID$19078, this.$self_$19079);
		}

		// Token: 0x060016A3 RID: 5795 RVA: 0x002510FC File Offset: 0x0024F2FC
		internal static bool of51MGMA2sWhbx9CLaD()
		{
			return true;
		}

		// Token: 0x060016A4 RID: 5796 RVA: 0x00251100 File Offset: 0x0024F300
		internal static bool J4cuFtMlZ4qDxRMjrNt()
		{
			return false;
		}

		// Token: 0x04001354 RID: 4948
		internal Vector3 $mPos$19076;

		// Token: 0x04001355 RID: 4949
		internal Vector3 $tDir$19077;

		// Token: 0x04001356 RID: 4950
		internal int $tID$19078;

		// Token: 0x04001357 RID: 4951
		internal Vizie2 $self_$19079;

		// Token: 0x020003CB RID: 971
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060016A5 RID: 5797 RVA: 0x00251104 File Offset: 0x0024F304
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, Vizie2 self_)
			{
				if (196803 - 355675 != -158871)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (291667 - 519304 == -227637)
					{
						base..ctor();
						if (15654 - 550944 != -535289)
						{
							this.$mPos$19072 = mPos;
							if (102409 - 317061 == -214652)
							{
								this.$tDir$19073 = tDir;
								if (244520 - 364810 == -120290)
								{
									this.$tID$19074 = tID;
									if (8283 - 349559 != -341275)
									{
										this.$self_$19075 = self_;
										if (12455 - 301987 != -289531)
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

			// Token: 0x060016A6 RID: 5798 RVA: 0x00251204 File Offset: 0x0024F404
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (34697 - 47202 != -12505)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_676;
					case 2:
						if (this.$self_$19075.mChar.actionState != "attack")
						{
							goto IL_DA;
						}
						if (140383 - 359796 != -219413)
						{
							continue;
						}
						if (this.$self_$19075.mChar.myCommand != "castInvisibility")
						{
							if (139935 - 207764 != -67829)
							{
								continue;
							}
							goto IL_DA;
						}
						else
						{
							if (!this.$self_$19075.mChar.isMine)
							{
								goto IL_378;
							}
							if (82815 - 289679 != -206864)
							{
								continue;
							}
							object obj2;
							object obj = obj2 = PhotonClient.ActorNrList[this.$tID$19074];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$tObject$19070 = (GameObject)obj2;
							if (293965 - 542462 == -248496)
							{
								continue;
							}
							this.$tChar$19071 = null;
							if (96907 - 235259 == -138351)
							{
								continue;
							}
							if (this.$tObject$19070)
							{
								if (219642 - 243572 == -23929)
								{
									continue;
								}
								this.$tChar$19071 = (CharacterControl)this.$tObject$19070.GetComponent(typeof(CharacterControl));
								if (148366 - 395509 == -247142)
								{
									continue;
								}
							}
							if (!this.$tChar$19071)
							{
								goto IL_378;
							}
							if (116953 - 463334 != -346381)
							{
								continue;
							}
							this.$tChar$19071.RPC_AddStatus("invisible", 2, 15, 0, this.$tChar$19071.ActorNr);
							if (112408 - 214084 != -101675)
							{
								goto Block_19;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$19075.mChar.actionState == "attack")
						{
							if (122006 - 205487 == -83480)
							{
								continue;
							}
							if (this.$self_$19075.mChar.myCommand == "castInvisibility")
							{
								if (283553 - 297638 != -14085)
								{
									continue;
								}
								this.$self_$19075.mChar.moveSpeed = (float)0;
								if (193167 - 557836 == -364668)
								{
									continue;
								}
								this.$self_$19075.mChar.actionState = "standby";
								if (110466 - 200164 == -89697)
								{
									continue;
								}
								this.$self_$19075.mChar.actionTime = Time.time;
								if (190448 - 528206 != -337758)
								{
									continue;
								}
								this.$self_$19075.mChar.myCommand = "none";
								if (85980 - 475449 != -389469)
								{
									continue;
								}
								if (!this.$self_$19075.mChar.isMine)
								{
									if (265610 - 222362 != 43248)
									{
										continue;
									}
									this.$self_$19075.mChar.nPosition = this.$self_$19075.transform.position;
									if (167948 - 203153 == -35204)
									{
										continue;
									}
									this.$self_$19075.mChar.oPosition = this.$self_$19075.transform.position;
									if (51032 - 83843 != -32811)
									{
										continue;
									}
									this.$self_$19075.mChar.nDirection = this.$self_$19075.transform.forward;
									if (206548 - 582481 == -375932)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (157965 - 144630 != 13335)
						{
							continue;
						}
						goto IL_676;
					default:
						if (43591 - 538409 != -494818)
						{
							continue;
						}
						break;
					}
					this.$self_$19075.mChar.actionState = "attack";
					if (27677 - 392410 == -364733)
					{
						this.$self_$19075.mChar.actionTime = Time.time;
						if (162301 - 258161 == -95860)
						{
							this.$self_$19075.mChar.myCommand = "castInvisibility";
							if (67672 - 172595 == -104923)
							{
								this.$self_$19075.mChar.addTimeOut("castInvisibility", (float)10);
								if (146446 - 441639 != -295192)
								{
									this.$self_$19075.transform.position = this.$mPos$19072;
									if (299974 - 146892 == 153082)
									{
										this.$self_$19075.transform.LookAt(this.$mPos$19072 + global::Math.vFlat(this.$tDir$19073));
										if (285910 - 509056 == -223146)
										{
											this.$self_$19075.animation.CrossFade("cast");
											if (195945 - 363282 == -167337)
											{
												this.$self_$19075.animation.wrapMode = WrapMode.Once;
												if (222220 - 444115 == -221895)
												{
													this.$self_$19075.mChar.vMovement = this.$self_$19075.transform.forward;
													if (266274 - 215375 != 50900)
													{
														this.$self_$19075.mChar.moveSpeed = (float)0;
														if (261941 - 596088 != -334146)
														{
															goto Block_18;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_DA:
				goto IL_676;
				Block_18:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_19:
				IL_378:
				return this.Yield(3, new WaitForSeconds(0.3f));
				IL_676:
				return false;
			}

			// Token: 0x060016A7 RID: 5799 RVA: 0x0025189C File Offset: 0x0024FA9C
			internal static bool gMgJxUMy0MrOclC4tCw()
			{
				return true;
			}

			// Token: 0x060016A8 RID: 5800 RVA: 0x002518A0 File Offset: 0x0024FAA0
			internal static bool AV2u22MSRCQmi1vigOM()
			{
				return false;
			}

			// Token: 0x04001358 RID: 4952
			internal GameObject $tObject$19070;

			// Token: 0x04001359 RID: 4953
			internal CharacterControl $tChar$19071;

			// Token: 0x0400135A RID: 4954
			internal Vector3 $mPos$19072;

			// Token: 0x0400135B RID: 4955
			internal Vector3 $tDir$19073;

			// Token: 0x0400135C RID: 4956
			internal int $tID$19074;

			// Token: 0x0400135D RID: 4957
			internal Vizie2 $self_$19075;
		}
	}

	// Token: 0x020003CC RID: 972
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$19080 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060016A9 RID: 5801 RVA: 0x002518A4 File Offset: 0x0024FAA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$19080(UnityScript.Lang.Array nArray, Vizie2 self_)
		{
			if (269647 - 233242 != 36405)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (18730 - 81374 == -62644)
				{
					base..ctor();
					if (193847 - 272999 != -79151)
					{
						this.$nArray$19085 = nArray;
						if (76547 - 414608 == -338061)
						{
							this.$self_$19086 = self_;
							if (64099 - 539594 != -475494)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060016AA RID: 5802 RVA: 0x00251960 File Offset: 0x0024FB60
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Vizie2.$RPC_dead$19080.$(this.$nArray$19085, this.$self_$19086);
		}

		// Token: 0x060016AB RID: 5803 RVA: 0x00251974 File Offset: 0x0024FB74
		internal static bool YFZodhMojkTn5lnGwJJ()
		{
			return true;
		}

		// Token: 0x060016AC RID: 5804 RVA: 0x00251978 File Offset: 0x0024FB78
		internal static bool dFhvo2ME29V7Zbx05gu()
		{
			return false;
		}

		// Token: 0x0400135E RID: 4958
		internal UnityScript.Lang.Array $nArray$19085;

		// Token: 0x0400135F RID: 4959
		internal Vizie2 $self_$19086;

		// Token: 0x020003CD RID: 973
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060016AD RID: 5805 RVA: 0x0025197C File Offset: 0x0024FB7C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Vizie2 self_)
			{
				if (58616 - 303195 != -244578)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (249444 - 450149 == -200705)
					{
						base..ctor();
						if (256510 - 488785 == -232275)
						{
							this.$nArray$19083 = nArray;
							if (129896 - 397812 == -267916)
							{
								this.$self_$19084 = self_;
								if (117663 - 472842 != -355178)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060016AE RID: 5806 RVA: 0x00251A38 File Offset: 0x0024FC38
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (253694 - 27042 != 226653)
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
						if (this.$self_$19084.mChar.actionState != "dead")
						{
							if (76720 - 560537 != -483817)
							{
								continue;
							}
							goto IL_FE;
						}
						else
						{
							if (!this.$self_$19084.mChar.isPlayer)
							{
								if (233066 - 133527 == 99540)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$19084.gameObject);
								if (297411 - 99597 != 197814)
								{
									continue;
								}
							}
							else if (this.$self_$19084.mChar.isMine)
							{
								if (26898 - 434614 != -407716)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$19084.gameObject);
								if (173242 - 63999 == 109244)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (18126 - 128191 != -110065)
							{
								continue;
							}
							goto IL_42F;
						}
						break;
					default:
						if (299629 - 461620 == -161990)
						{
							continue;
						}
						break;
					}
					if (this.$self_$19084.mChar.actionState == "dead")
					{
						if (174124 - 66386 == 107738)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$19081 = (Vector3)this.$nArray$19083[0];
						if (35946 - 138451 != -102504)
						{
							this.$myDirection$19082 = (Vector3)this.$nArray$19083[1];
							if (211561 - 485653 == -274092)
							{
								this.$self_$19084.transform.position = this.$myPosition$19081;
								if (145265 - 331786 != -186520)
								{
									this.$self_$19084.transform.LookAt(this.$myPosition$19081 + this.$myDirection$19082);
									if (292601 - 105109 == 187492)
									{
										this.$self_$19084.mChar.hp = 0;
										if (223873 - 140588 == 83285)
										{
											this.$self_$19084.mChar.actionState = "dead";
											if (10879 - 584195 == -573316)
											{
												this.$self_$19084.mChar.actionTime = Time.time;
												if (224370 - 567215 != -342844)
												{
													this.$self_$19084.mChar.myCommand = "none";
													if (291620 - 567470 != -275849)
													{
														this.$self_$19084.mChar.vMovement = Vector3.zero;
														if (186371 - 406064 != -219692)
														{
															this.$self_$19084.mChar.moveSpeed = (float)0;
															if (231320 - 41147 == 190173)
															{
																this.$self_$19084.animation.Rewind();
																if (245015 - 120084 == 124931)
																{
																	this.$self_$19084.animation.Play("ko");
																	if (40163 - 204487 != -164323)
																	{
																		this.$self_$19084.animation.wrapMode = WrapMode.Once;
																		if (32915 - 41245 == -8330)
																		{
																			goto IL_132;
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_FE:
				goto IL_42F;
				IL_132:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_42F:
				return false;
			}

			// Token: 0x060016AF RID: 5807 RVA: 0x00251E88 File Offset: 0x00250088
			internal static bool aPWf8PM2axpaQcLgH04()
			{
				return true;
			}

			// Token: 0x060016B0 RID: 5808 RVA: 0x00251E8C File Offset: 0x0025008C
			internal static bool wgh4eeM81pcNZKuotBb()
			{
				return false;
			}

			// Token: 0x04001360 RID: 4960
			internal Vector3 $myPosition$19081;

			// Token: 0x04001361 RID: 4961
			internal Vector3 $myDirection$19082;

			// Token: 0x04001362 RID: 4962
			internal UnityScript.Lang.Array $nArray$19083;

			// Token: 0x04001363 RID: 4963
			internal Vizie2 $self_$19084;
		}
	}
}
