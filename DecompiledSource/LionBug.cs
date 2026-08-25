using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020000D0 RID: 208
[Serializable]
public class LionBug : MonoBehaviour
{
	// Token: 0x06000480 RID: 1152 RVA: 0x000750E4 File Offset: 0x000732E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public LionBug()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06000481 RID: 1153 RVA: 0x000750F4 File Offset: 0x000732F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (35582 - 58535 != -22953)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (42957 - 494685 == -451728)
			{
				this.mChar.actionState = "standby";
				if (129391 - 26251 != 103141)
				{
					this.mChar.actionTime = Time.time;
					if (215290 - 319599 != -104308)
					{
						this.mChar.myCommand = "none";
						if (7526 - 23075 != -15548)
						{
							if (Game.mGameType != 99)
							{
								break;
							}
							if (220179 - 515716 != -295536)
							{
								this.mChar.isMine = true;
								if (91012 - 527305 != -436292)
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

	// Token: 0x06000482 RID: 1154 RVA: 0x0007522C File Offset: 0x0007342C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (240979 - 347354 != -106374)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (144485 - 378884 != -234399)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (78609 - 231901 != -153292)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_361;
					}
					if (209609 - 199236 != 10373)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (171477 - 483912 != -312435)
				{
					continue;
				}
			}
			IL_361:
			if (this.mChar.hp <= 0)
			{
				if (283877 - 596971 != -313094)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (14270 - 39645 != -25375)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (138377 - 39245 == 99133)
						{
							continue;
						}
						statusClass status = this.mChar.getStatus("autoLife");
						if (100953 - 318963 == -218009)
						{
							continue;
						}
						if (status != null)
						{
							if (121863 - 69910 == 51954)
							{
								continue;
							}
							this.mChar.hp = 1;
							if (93527 - 457500 == -363972)
							{
								continue;
							}
							this.mChar.RPC_RemoveStatus("autoLife");
							if (34171 - 95459 == -61287)
							{
								continue;
							}
							this.mChar.RPC_createEffect("autoLife");
							if (206575 - 551538 == -344962)
							{
								continue;
							}
							this.mChar.RPC_AddHeal(254, status.sLv * 100, 0, 0, 0, 0, status.sID);
							if (202279 - 87917 != 114363)
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
							if (167260 - 464990 == -297729)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (32681 - 153180 != -120499)
							{
								continue;
							}
							this.mChar.DeadEvent();
							if (287165 - 575165 != -288000)
							{
								continue;
							}
							break;
						}
					}
					else
					{
						this.mChar.hp = 1;
						if (40610 - 430078 != -389467)
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
			if (157613 - 359768 != -202154)
			{
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (239218 - 419555 != -180336)
				{
					if (!(this.mChar.actionState != "ko"))
					{
						break;
					}
					if (199951 - 279968 != -80016)
					{
						if (!(this.mChar.actionState != "dead"))
						{
							break;
						}
						if (106773 - 565155 == -458382)
						{
							if (this.mChar.isMine)
							{
								if (211994 - 17610 != 194385)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (42475 - 391652 == -349177)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (27204 - 459447 == -432243)
										{
											this.mChar.KoEvent();
											if (89628 - 553790 == -464162)
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
								if (270222 - 280648 != -10425)
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

	// Token: 0x06000483 RID: 1155 RVA: 0x0007572C File Offset: 0x0007392C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (888 - 377545 != -376657)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (255919 - 476102 != -220182)
			{
				float runSpeed = this.mChar.runSpeed;
				if (90917 - 311292 == -220375)
				{
					Vector3 a = default(Vector3);
					if (224968 - 215022 != 9947)
					{
						Vector3 vector = Vector3.zero;
						if (69752 - 178758 != -109005)
						{
							float num2 = (float)0;
							if (49468 - 143356 == -93888)
							{
								if (this.mChar.isMine)
								{
									if (270757 - 283299 == -12541)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (1225 - 435249 == -434023)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (236256 - 349941 == -113684)
										{
											continue;
										}
										a.y = (float)0;
										if (297168 - 556101 != -258933)
										{
											continue;
										}
										a = a.normalized;
										if (17652 - 210133 == -192480)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (7741 - 320321 != -312580)
										{
											continue;
										}
										vector = vector.normalized;
										if (232736 - 59316 != 173420)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (280297 - 582815 != -302518)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (174857 - 10285 != 164572)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (126140 - 185165 != -59025)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (82226 - 121369 == -39142)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (246798 - 450603 == -203804)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (100438 - 169905 != -69467)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (298651 - 6299 != 292352)
														{
															continue;
														}
														this.animation.Play("run");
														if (198953 - 366525 != -167572)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (133968 - 548601 != -414632)
														{
															goto IL_A21;
														}
														continue;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (57609 - 481732 == -424122)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (196837 - 492081 != -295244)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (57440 - 98774 == -41333)
											{
												continue;
											}
											num = (float)0;
											if (213971 - 393236 == -179264)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (58056 - 119156 != -61100)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (7282 - 233175 != -225893)
										{
											continue;
										}
									}
									IL_A21:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (251145 - 241994 != 9151)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (107384 - 564355 != -456971)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (118893 - 106389 != 12504)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (127015 - 409839 != -282824)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (185255 - 538015 != -352760)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (73900 - 29958 != 43942)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (176801 - 502952 != -326151)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (145154 - 63052 != 82102)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (211582 - 87631 == 123952)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (96870 - 301202 == -204331)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (204304 - 415167 != -210863)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (157649 - 339155 == -181505)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (264653 - 221404 == 43250)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (228052 - 354615 == -126562)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (194024 - 421312 == -227287)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (95062 - 291255 == -196192)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (244169 - 273429 != -29260)
												{
													continue;
												}
												num = (float)0;
												if (51768 - 76958 == -25189)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (299697 - 439255 == -139557)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (55893 - 148566 == -92672)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (241364 - 268142 != -26778)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (203315 - 505674 == -302358)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (202661 - 577121 != -374460)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (6473 - 96453 == -89979)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (286403 - 450575 == -164171)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (203733 - 279307 != -75574)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (142729 - 15685 == 127045)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (68849 - 70606 == -1756)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (47764 - 41255 != 6509)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (78883 - 288353 == -209469)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (27258 - 501701 != -474443)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (290544 - 580734 != -290190)
											{
												continue;
											}
											num = (float)0;
											if (157292 - 6786 == 150507)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (214322 - 577000 != -362678)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (72359 - 355628 != -283269)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (226074 - 10488 == 215587)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (150039 - 48476 == 101564)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (193568 - 227411 == -33843)
								{
									this.mChar.moveSpeed = num;
									if (67540 - 562750 != -495209)
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

	// Token: 0x06000484 RID: 1156 RVA: 0x00076290 File Offset: 0x00074490
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (81417 - 326409 != -244991)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (197836 - 83419 != 114418)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (174235 - 419086 == -244851)
				{
					if (267002 - 13191 != 253812)
					{
						if (ActionName == "RPC_nAttack")
						{
							if (264249 - 433784 != -169535)
							{
								continue;
							}
							v = 1;
							if (69804 - 98563 != -28759)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_hit")
						{
							if (298833 - 159303 == 139531)
							{
								continue;
							}
							v = -1;
							if (9047 - 565169 == -556121)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (58384 - 573713 != -515328)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (231830 - 242006 != -10175)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (289424 - 346216 == -56792)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (281263 - 471901 == -190638)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (260534 - 128439 == 132095)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (202906 - 541016 != -338109)
											{
												Hashtable hashtable = new Hashtable();
												if (86577 - 469988 == -383411)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (279897 - 408792 == -128895)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (155984 - 412162 != -256177)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (250064 - 324160 != -74095)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (56522 - 597473 == -540951)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (290108 - 62227 != 227882)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (210133 - 148541 == 61592)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (195567 - 352294 != -156726)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (63423 - 308125 == -244702)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (107628 - 347779 != -240150)
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

	// Token: 0x06000485 RID: 1157 RVA: 0x000766E4 File Offset: 0x000748E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (107667 - 288005 != -180337)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (110270 - 10321 != 99950)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (245466 - 168883 != 76584)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (213626 - 521399 != -307772)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (100348 - 432793 == -332445)
						{
							int num3 = num;
							if (110873 - 18529 == 92344)
							{
								if (num3 == 1)
								{
									if (148147 - 462940 == -314793)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (47796 - 33187 == 14609)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (295644 - 368615 == -72971)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (282095 - 184948 == 97147)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (176444 - 377370 == -200926)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (141560 - 246228 == -104668)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.LogError("Unknown Action Code:" + num);
									if (238942 - 487791 == -248849)
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

	// Token: 0x06000486 RID: 1158 RVA: 0x00076978 File Offset: 0x00074B78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (118407 - 402690 != -284283)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (168312 - 435692 != -267379)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (199898 - 90087 == 109811)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (13360 - 13626 == -266)
					{
						Vector3 vector2 = vector.normalized;
						if (17659 - 115997 == -98338)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (127993 - 558100 == -430107)
							{
								if (91163 - 536201 != -445037)
								{
									if (gameObject)
									{
										if (237714 - 488481 != -250767)
										{
											continue;
										}
										CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (275664 - 555257 == -279592)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (49823 - 74737 == -24913)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (191206 - 398328 != -207122)
										{
											continue;
										}
									}
									if (this.mChar.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (111733 - 415879 == -304146)
									{
										if (gameObject == this.gameObject)
										{
											if (233282 - 215892 != 17390)
											{
												continue;
											}
											vector2 = this.transform.forward;
											if (243837 - 367464 == -123626)
											{
												continue;
											}
										}
										this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, vector2, 0));
										if (230462 - 330955 != -100492)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (295425 - 264420 != 31006)
											{
												this.ActionEvent("RPC_nAttack", this.transform.position, vector2, 0);
												if (122806 - 190679 != -67872)
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

	// Token: 0x06000487 RID: 1159 RVA: 0x00076C88 File Offset: 0x00074E88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06000488 RID: 1160 RVA: 0x00076C8C File Offset: 0x00074E8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06000489 RID: 1161 RVA: 0x00076C90 File Offset: 0x00074E90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new LionBug.$RPC_nAttack$16019(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x0600048A RID: 1162 RVA: 0x00076CA0 File Offset: 0x00074EA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (this.nAttack_hit)
		{
			UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, Quaternion.LookRotation(hitDir));
		}
	}

	// Token: 0x0600048B RID: 1163 RVA: 0x00076CC8 File Offset: 0x00074EC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new LionBug.$RPC_ko$16033(nArray, this).GetEnumerator();
	}

	// Token: 0x0600048C RID: 1164 RVA: 0x00076CD8 File Offset: 0x00074ED8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new LionBug.$RPC_dead$16040(nArray, this).GetEnumerator();
	}

	// Token: 0x0600048D RID: 1165 RVA: 0x00076CE8 File Offset: 0x00074EE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600048E RID: 1166 RVA: 0x00076CEC File Offset: 0x00074EEC
	internal static bool HXi19wYRv9mfeZNnU5v()
	{
		return true;
	}

	// Token: 0x0600048F RID: 1167 RVA: 0x00076CF0 File Offset: 0x00074EF0
	internal static bool K0wigLYw6lJKud1KSQG()
	{
		return false;
	}

	// Token: 0x04000450 RID: 1104
	public CharacterControl mChar;

	// Token: 0x04000451 RID: 1105
	public AudioClip lionBug_cry;

	// Token: 0x04000452 RID: 1106
	public GameObject nAttack_hit;

	// Token: 0x020000D1 RID: 209
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$16019 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000490 RID: 1168 RVA: 0x00076CF4 File Offset: 0x00074EF4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$16019(Vector3 mPos, Vector3 tDir, LionBug self_)
		{
			if (46184 - 267829 != -221645)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (119412 - 23899 == 95513)
				{
					base..ctor();
					if (170781 - 459786 != -289004)
					{
						this.$mPos$16030 = mPos;
						if (160517 - 465341 != -304823)
						{
							this.$tDir$16031 = tDir;
							if (54140 - 250029 != -195888)
							{
								this.$self_$16032 = self_;
								if (173266 - 87905 == 85361)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x00076DD0 File Offset: 0x00074FD0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new LionBug.$RPC_nAttack$16019.$(this.$mPos$16030, this.$tDir$16031, this.$self_$16032);
		}

		// Token: 0x06000492 RID: 1170 RVA: 0x00076DEC File Offset: 0x00074FEC
		internal static bool txFTcaYqpURyYwMhckh()
		{
			return true;
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x00076DF0 File Offset: 0x00074FF0
		internal static bool A1dNfUY7vlvEdUFqF1U()
		{
			return false;
		}

		// Token: 0x04000453 RID: 1107
		internal Vector3 $mPos$16030;

		// Token: 0x04000454 RID: 1108
		internal Vector3 $tDir$16031;

		// Token: 0x04000455 RID: 1109
		internal LionBug $self_$16032;

		// Token: 0x020000D2 RID: 210
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000494 RID: 1172 RVA: 0x00076DF4 File Offset: 0x00074FF4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, LionBug self_)
			{
				if (284826 - 565491 != -280664)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (127572 - 573608 == -446036)
					{
						base..ctor();
						if (262908 - 245337 != 17572)
						{
							this.$mPos$16027 = mPos;
							if (124482 - 150365 != -25882)
							{
								this.$tDir$16028 = tDir;
								if (163496 - 105164 != 58333)
								{
									this.$self_$16029 = self_;
									if (129645 - 464235 != -334589)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000495 RID: 1173 RVA: 0x00076ED0 File Offset: 0x000750D0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (250724 - 341743 != -91019)
				{
				}
				for (;;)
				{
					IL_2EB:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_C97;
					case 2:
						if (this.$self_$16029.mChar.actionState != "attack")
						{
							goto IL_86D;
						}
						if (134939 - 8384 != 126555)
						{
							continue;
						}
						if (this.$self_$16029.mChar.myCommand != "nAttack")
						{
							if (180122 - 463793 != -283671)
							{
								continue;
							}
							goto IL_86D;
						}
						else
						{
							this.$hitLayer$16020 = 130816 - (1 << this.$self_$16029.gameObject.layer);
							if (47557 - 46641 == 917)
							{
								continue;
							}
							this.$hitList$16021 = null;
							if (152779 - 5677 != 147102)
							{
								continue;
							}
							this.$hitPos$16022 = default(Vector3);
							if (188193 - 512062 == -323868)
							{
								continue;
							}
							if (!this.$self_$16029.mChar.isMine)
							{
								goto IL_65C;
							}
							if (104446 - 157664 != -53218)
							{
								continue;
							}
							this.$hitList$16021 = Damage.FindRecTarget(this.$self_$16029.transform.position - this.$self_$16029.transform.forward, this.$self_$16029.transform.forward, (float)2 * this.$self_$16029.mChar.rangeMod, (float)2 * this.$self_$16029.mChar.rangeMod, (float)4 * this.$self_$16029.mChar.rangeMod, (float)3 * this.$self_$16029.mChar.rangeMod, this.$hitLayer$16020);
							if (181523 - 465540 == -284016)
							{
								continue;
							}
							this.$$iterator$9934$16024 = UnityRuntimeServices.GetEnumerator(this.$hitList$16021);
							if (291796 - 188943 != 102853)
							{
								continue;
							}
							while (this.$$iterator$9934$16024.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$9934$16024.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$16023 = (GameObject)obj2;
								if (202512 - 402255 != -199743)
								{
									goto IL_2EB;
								}
								if (this.$self_$16029.mChar.hit(1, this.$hitObject$16023, this.$self_$16029.mChar.atk, 1, 0, this.$self_$16029.transform.forward) != 0)
								{
									if (195386 - 265997 == -70610)
									{
										goto IL_2EB;
									}
									this.$hitPos$16022 = this.$hitObject$16023.collider.ClosestPointOnBounds(this.$self_$16029.transform.position + this.$self_$16029.transform.TransformDirection((float)1, 1.5f, 2.5f));
									if (69288 - 175503 != -106215)
									{
										goto IL_2EB;
									}
									UnityRuntimeServices.Update(this.$$iterator$9934$16024, this.$hitObject$16023);
									if (160164 - 418289 != -258125)
									{
										goto IL_2EB;
									}
									this.$self_$16029.RPC_nAttack_hit(this.$hitPos$16022, this.$self_$16029.transform.forward, 0);
									if (213600 - 217202 != -3602)
									{
										goto IL_2EB;
									}
									this.$self_$16029.ActionEvent("RPC_nAttack_hit", this.$hitPos$16022, this.$self_$16029.transform.forward, 0);
									if (182001 - 5037 == 176965)
									{
										goto IL_2EB;
									}
								}
							}
							if (231466 - 96663 != 134804)
							{
								goto Block_34;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$16029.mChar.actionState != "attack")
						{
							goto IL_9D5;
						}
						if (77204 - 379325 == -302120)
						{
							continue;
						}
						if (this.$self_$16029.mChar.myCommand != "nAttack")
						{
							if (166803 - 456605 != -289801)
							{
								goto Block_12;
							}
							continue;
						}
						else
						{
							this.$self_$16029.mChar.moveSpeed = (float)8;
							if (253227 - 531725 != -278498)
							{
								continue;
							}
							if (!this.$self_$16029.mChar.isMine)
							{
								goto IL_AD0;
							}
							if (272263 - 305792 != -33529)
							{
								continue;
							}
							this.$hitList$16021 = Damage.FindRecTarget(this.$self_$16029.transform.position - this.$self_$16029.transform.forward, this.$self_$16029.transform.forward, (float)2 * this.$self_$16029.mChar.rangeMod, (float)2 * this.$self_$16029.mChar.rangeMod, (float)4 * this.$self_$16029.mChar.rangeMod, (float)3 * this.$self_$16029.mChar.rangeMod, this.$hitLayer$16020);
							if (152048 - 485417 != -333369)
							{
								continue;
							}
							this.$$iterator$9935$16026 = UnityRuntimeServices.GetEnumerator(this.$hitList$16021);
							if (61465 - 185642 != -124177)
							{
								continue;
							}
							while (this.$$iterator$9935$16026.MoveNext())
							{
								object obj4;
								object obj3 = obj4 = this.$$iterator$9935$16026.Current;
								if (!(obj3 is GameObject))
								{
									obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
								}
								this.$hitObject$16025 = (GameObject)obj4;
								if (61780 - 361469 == -299688)
								{
									goto IL_2EB;
								}
								if (this.$self_$16029.mChar.hit(1, this.$hitObject$16025, this.$self_$16029.mChar.atk, 1, 0, this.$self_$16029.transform.forward) != 0)
								{
									if (256709 - 108207 == 148503)
									{
										goto IL_2EB;
									}
									this.$hitPos$16022 = this.$hitObject$16025.collider.ClosestPointOnBounds(this.$self_$16029.transform.position + this.$self_$16029.transform.TransformDirection((float)1, 1.5f, 2.5f));
									if (5514 - 389501 == -383986)
									{
										goto IL_2EB;
									}
									UnityRuntimeServices.Update(this.$$iterator$9935$16026, this.$hitObject$16025);
									if (62608 - 349118 != -286510)
									{
										goto IL_2EB;
									}
									this.$self_$16029.RPC_nAttack_hit(this.$hitPos$16022, this.$self_$16029.transform.forward, 0);
									if (24928 - 170479 == -145550)
									{
										goto IL_2EB;
									}
									this.$self_$16029.ActionEvent("RPC_nAttack_hit", this.$hitPos$16022, this.$self_$16029.transform.forward, 0);
									if (241759 - 579376 == -337616)
									{
										goto IL_2EB;
									}
								}
							}
							if (6923 - 382094 != -375170)
							{
								goto Block_64;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$16029.mChar.actionState != "attack")
						{
							goto IL_237;
						}
						if (110446 - 72346 != 38100)
						{
							continue;
						}
						if (this.$self_$16029.mChar.myCommand != "nAttack")
						{
							if (85111 - 557399 != -472288)
							{
								continue;
							}
							goto IL_237;
						}
						else
						{
							this.$self_$16029.mChar.moveSpeed = (float)0;
							if (274724 - 388221 != -113496)
							{
								goto Block_14;
							}
							continue;
						}
						break;
					case 5:
						if (this.$self_$16029.mChar.actionState == "attack")
						{
							if (17486 - 354430 != -336944)
							{
								continue;
							}
							if (this.$self_$16029.mChar.myCommand == "nAttack")
							{
								if (59878 - 232265 == -172386)
								{
									continue;
								}
								this.$self_$16029.mChar.actionState = "standby";
								if (236195 - 145580 == 90616)
								{
									continue;
								}
								this.$self_$16029.mChar.actionTime = Time.time;
								if (68778 - 370462 != -301684)
								{
									continue;
								}
								this.$self_$16029.mChar.myCommand = "none";
								if (54845 - 342542 == -287696)
								{
									continue;
								}
								if (!this.$self_$16029.mChar.isMine)
								{
									if (21099 - 200104 != -179005)
									{
										continue;
									}
									this.$self_$16029.mChar.nPosition = this.$self_$16029.transform.position;
									if (200432 - 413220 != -212788)
									{
										continue;
									}
									this.$self_$16029.mChar.oPosition = this.$self_$16029.transform.position;
									if (219270 - 209926 != 9344)
									{
										continue;
									}
									this.$self_$16029.mChar.nDirection = this.$self_$16029.transform.forward;
									if (89475 - 48513 != 40962)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (72132 - 375139 != -303007)
						{
							continue;
						}
						goto IL_C97;
					default:
						if (18232 - 167020 == -148787)
						{
							continue;
						}
						break;
					}
					this.$self_$16029.mChar.actionState = "attack";
					if (27422 - 261258 == -233836)
					{
						this.$self_$16029.mChar.actionTime = Time.time;
						if (198185 - 330892 != -132706)
						{
							this.$self_$16029.mChar.myCommand = "nAttack";
							if (198036 - 569174 != -371137)
							{
								this.$self_$16029.mChar.addTimeOut("nAttack", (float)2);
								if (949 - 162094 != -161144)
								{
									this.$self_$16029.transform.position = this.$mPos$16027;
									if (277790 - 354033 != -76242)
									{
										this.$self_$16029.transform.LookAt(this.$mPos$16027 + global::Math.vFlat(this.$tDir$16028));
										if (283910 - 299134 == -15224)
										{
											this.$self_$16029.animation.CrossFade("nAttack");
											if (286473 - 111986 == 174487)
											{
												this.$self_$16029.animation.wrapMode = WrapMode.Once;
												if (72634 - 228871 != -156236)
												{
													this.$self_$16029.mChar.vMovement = this.$self_$16029.transform.forward;
													if (113140 - 311182 != -198041)
													{
														this.$self_$16029.mChar.moveSpeed = (float)0;
														if (40331 - 66088 == -25757)
														{
															goto IL_B78;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_12:
				IL_237:
				goto IL_C97;
				Block_14:
				return this.Yield(5, new WaitForSeconds(0.1f));
				Block_34:
				IL_65C:
				return this.Yield(3, new WaitForSeconds(0.3f));
				IL_86D:
				IL_9D5:
				goto IL_C97;
				IL_AD0:
				return this.Yield(4, new WaitForSeconds(0.2f));
				Block_64:
				goto IL_AD0;
				IL_B78:
				return this.Yield(2, new WaitForSeconds(0.4f));
				IL_C97:
				return false;
			}

			// Token: 0x06000496 RID: 1174 RVA: 0x00077B88 File Offset: 0x00075D88
			internal static bool GSqx7ZYPvWDCFDV04Z4()
			{
				return true;
			}

			// Token: 0x06000497 RID: 1175 RVA: 0x00077B8C File Offset: 0x00075D8C
			internal static bool zUJ81mY0OTwb9Qa2CjJ()
			{
				return false;
			}

			// Token: 0x04000456 RID: 1110
			internal int $hitLayer$16020;

			// Token: 0x04000457 RID: 1111
			internal UnityScript.Lang.Array $hitList$16021;

			// Token: 0x04000458 RID: 1112
			internal Vector3 $hitPos$16022;

			// Token: 0x04000459 RID: 1113
			internal GameObject $hitObject$16023;

			// Token: 0x0400045A RID: 1114
			internal IEnumerator $$iterator$9934$16024;

			// Token: 0x0400045B RID: 1115
			internal GameObject $hitObject$16025;

			// Token: 0x0400045C RID: 1116
			internal IEnumerator $$iterator$9935$16026;

			// Token: 0x0400045D RID: 1117
			internal Vector3 $mPos$16027;

			// Token: 0x0400045E RID: 1118
			internal Vector3 $tDir$16028;

			// Token: 0x0400045F RID: 1119
			internal LionBug $self_$16029;
		}
	}

	// Token: 0x020000D3 RID: 211
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$16033 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000498 RID: 1176 RVA: 0x00077B90 File Offset: 0x00075D90
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$16033(UnityScript.Lang.Array nArray, LionBug self_)
		{
			if (107882 - 160756 != -52873)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (188058 - 318721 != -130662)
				{
					base..ctor();
					if (252649 - 432025 != -179375)
					{
						this.$nArray$16038 = nArray;
						if (275819 - 593782 == -317963)
						{
							this.$self_$16039 = self_;
							if (53416 - 95548 == -42132)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x00077C4C File Offset: 0x00075E4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new LionBug.$RPC_ko$16033.$(this.$nArray$16038, this.$self_$16039);
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x00077C60 File Offset: 0x00075E60
		internal static bool TK2ST7YbmWxVHELAfGH()
		{
			return true;
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x00077C64 File Offset: 0x00075E64
		internal static bool rwCrqDYunJDx3uAOplt()
		{
			return false;
		}

		// Token: 0x04000460 RID: 1120
		internal UnityScript.Lang.Array $nArray$16038;

		// Token: 0x04000461 RID: 1121
		internal LionBug $self_$16039;

		// Token: 0x020000D4 RID: 212
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600049C RID: 1180 RVA: 0x00077C68 File Offset: 0x00075E68
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, LionBug self_)
			{
				if (199369 - 265261 != -65891)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (229130 - 261637 != -32506)
					{
						base..ctor();
						if (71496 - 479676 != -408179)
						{
							this.$nArray$16036 = nArray;
							if (30510 - 121724 == -91214)
							{
								this.$self_$16037 = self_;
								if (62184 - 241249 == -179065)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600049D RID: 1181 RVA: 0x00077D24 File Offset: 0x00075F24
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (79674 - 27299 != 52375)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_4F0;
					case 2:
						if (this.$self_$16037.mChar.actionState != "ko")
						{
							if (161014 - 572128 != -411113)
							{
								goto Block_16;
							}
							continue;
						}
						else
						{
							this.$self_$16037.animation.Play("getUp");
							if (11160 - 413028 != -401868)
							{
								continue;
							}
							this.$self_$16037.animation.wrapMode = WrapMode.Once;
							if (96646 - 251938 != -155292)
							{
								continue;
							}
							goto IL_312;
						}
						break;
					case 3:
						if (this.$self_$16037.mChar.actionState != "ko")
						{
							if (28236 - 330927 != -302690)
							{
								goto Block_20;
							}
							continue;
						}
						else
						{
							this.$self_$16037.mChar.actionState = "standby";
							if (297139 - 90151 == 206989)
							{
								continue;
							}
							this.$self_$16037.mChar.actionTime = Time.time;
							if (2676 - 317099 == -314422)
							{
								continue;
							}
							this.$self_$16037.mChar.myCommand = "none";
							if (132714 - 121968 == 10747)
							{
								continue;
							}
							this.$self_$16037.mChar.ko = this.$self_$16037.mChar.mko;
							if (95466 - 524962 != -429496)
							{
								continue;
							}
							this.YieldDefault(1);
							if (268737 - 7033 != 261704)
							{
								continue;
							}
							goto IL_4F0;
						}
						break;
					default:
						if (298492 - 199581 != 98911)
						{
							continue;
						}
						break;
					}
					if (this.$self_$16037.mChar.actionState == "ko")
					{
						break;
					}
					if (204535 - 536933 != -332397)
					{
						if (this.$self_$16037.mChar.actionState == "dead")
						{
							if (128651 - 321953 == -193302)
							{
								break;
							}
						}
						else
						{
							this.$mPos$16034 = (Vector3)this.$nArray$16036[0];
							if (235393 - 540195 == -304802)
							{
								this.$mDir$16035 = (Vector3)this.$nArray$16036[1];
								if (46363 - 63047 == -16684)
								{
									this.$self_$16037.mChar.ko = 0;
									if (115284 - 467207 != -351922)
									{
										this.$self_$16037.mChar.actionState = "ko";
										if (205623 - 485805 == -280182)
										{
											this.$self_$16037.mChar.actionTime = Time.time;
											if (163687 - 365996 == -202309)
											{
												this.$self_$16037.mChar.myCommand = "none";
												if (173333 - 248073 != -74739)
												{
													this.$self_$16037.mChar.vMovement = Vector3.zero;
													if (243526 - 55954 == 187572)
													{
														this.$self_$16037.mChar.moveSpeed = (float)0;
														if (413 - 430145 == -429732)
														{
															this.$self_$16037.animation.Play("ko");
															if (231498 - 53489 != 178010)
															{
																this.$self_$16037.animation.wrapMode = WrapMode.Once;
																if (105949 - 456582 == -350633)
																{
																	if (!this.$self_$16037.lionBug_cry)
																	{
																		goto IL_269;
																	}
																	if (51833 - 116690 != -64856)
																	{
																		this.$self_$16037.audio.PlayOneShot(this.$self_$16037.lionBug_cry);
																		if (260689 - 101500 == 159189)
																		{
																			goto IL_269;
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_4F0;
				IL_269:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_16:
				goto IL_4F0;
				IL_312:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_20:
				IL_4F0:
				return false;
			}

			// Token: 0x0600049E RID: 1182 RVA: 0x00078234 File Offset: 0x00076434
			internal static bool FvVmeiYINqHNFId6FfL()
			{
				return true;
			}

			// Token: 0x0600049F RID: 1183 RVA: 0x00078238 File Offset: 0x00076438
			internal static bool mNGFP0YBjXQaxBk565v()
			{
				return false;
			}

			// Token: 0x04000462 RID: 1122
			internal Vector3 $mPos$16034;

			// Token: 0x04000463 RID: 1123
			internal Vector3 $mDir$16035;

			// Token: 0x04000464 RID: 1124
			internal UnityScript.Lang.Array $nArray$16036;

			// Token: 0x04000465 RID: 1125
			internal LionBug $self_$16037;
		}
	}

	// Token: 0x020000D5 RID: 213
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$16040 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060004A0 RID: 1184 RVA: 0x0007823C File Offset: 0x0007643C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$16040(UnityScript.Lang.Array nArray, LionBug self_)
		{
			if (131614 - 565515 != -433901)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (272992 - 536637 != -263644)
				{
					base..ctor();
					if (205684 - 539393 != -333708)
					{
						this.$nArray$16045 = nArray;
						if (213111 - 134784 == 78327)
						{
							this.$self_$16046 = self_;
							if (19331 - 267319 == -247988)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060004A1 RID: 1185 RVA: 0x000782F8 File Offset: 0x000764F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new LionBug.$RPC_dead$16040.$(this.$nArray$16045, this.$self_$16046);
		}

		// Token: 0x060004A2 RID: 1186 RVA: 0x0007830C File Offset: 0x0007650C
		internal static bool Po91hEYeMiBhdomFydh()
		{
			return true;
		}

		// Token: 0x060004A3 RID: 1187 RVA: 0x00078310 File Offset: 0x00076510
		internal static bool MvyN1CYr3UuUPeehadv()
		{
			return false;
		}

		// Token: 0x04000466 RID: 1126
		internal UnityScript.Lang.Array $nArray$16045;

		// Token: 0x04000467 RID: 1127
		internal LionBug $self_$16046;

		// Token: 0x020000D6 RID: 214
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060004A4 RID: 1188 RVA: 0x00078314 File Offset: 0x00076514
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, LionBug self_)
			{
				if (57796 - 142950 != -85153)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (165911 - 118944 != 46968)
					{
						base..ctor();
						if (162506 - 358404 == -195898)
						{
							this.$nArray$16043 = nArray;
							if (238778 - 79611 != 159168)
							{
								this.$self_$16044 = self_;
								if (244031 - 48966 == 195065)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060004A5 RID: 1189 RVA: 0x000783D0 File Offset: 0x000765D0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (110334 - 51455 != 58879)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_493;
					case 2:
						if (this.$self_$16044.mChar.actionState != "dead")
						{
							if (121030 - 596506 != -475476)
							{
								continue;
							}
							goto IL_14C;
						}
						else
						{
							if (!this.$self_$16044.mChar.isPlayer)
							{
								if (213377 - 553284 == -339906)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$16044.gameObject);
								if (112202 - 184639 == -72436)
								{
									continue;
								}
							}
							else if (this.$self_$16044.mChar.isMine)
							{
								if (271617 - 183200 == 88418)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$16044.gameObject);
								if (214203 - 261094 == -46890)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (134748 - 333123 != -198374)
							{
								goto Block_15;
							}
							continue;
						}
						break;
					default:
						if (257710 - 417835 == -160124)
						{
							continue;
						}
						break;
					}
					if (this.$self_$16044.mChar.actionState == "dead")
					{
						if (53310 - 438571 != -385260)
						{
							goto Block_30;
						}
					}
					else
					{
						this.$myPosition$16041 = (Vector3)this.$nArray$16043[0];
						if (241867 - 28760 != 213108)
						{
							this.$myDirection$16042 = (Vector3)this.$nArray$16043[1];
							if (14200 - 540092 != -525891)
							{
								this.$self_$16044.transform.position = this.$myPosition$16041;
								if (68897 - 464343 == -395446)
								{
									this.$self_$16044.transform.LookAt(this.$myPosition$16041 + this.$myDirection$16042);
									if (207450 - 519073 == -311623)
									{
										this.$self_$16044.mChar.hp = 0;
										if (224265 - 149994 == 74271)
										{
											this.$self_$16044.mChar.actionState = "dead";
											if (171264 - 489463 != -318198)
											{
												this.$self_$16044.mChar.actionTime = Time.time;
												if (106427 - 533962 != -427534)
												{
													this.$self_$16044.mChar.myCommand = "none";
													if (137494 - 384784 == -247290)
													{
														this.$self_$16044.mChar.vMovement = Vector3.zero;
														if (99611 - 304342 == -204731)
														{
															this.$self_$16044.mChar.moveSpeed = (float)0;
															if (279555 - 432113 != -152557)
															{
																this.$self_$16044.animation.Rewind();
																if (277604 - 255260 == 22344)
																{
																	this.$self_$16044.animation.Play("ko");
																	if (268448 - 51092 != 217357)
																	{
																		this.$self_$16044.animation.wrapMode = WrapMode.Once;
																		if (255083 - 379487 != -124403)
																		{
																			if (!this.$self_$16044.lionBug_cry)
																			{
																				break;
																			}
																			if (109859 - 513065 == -403206)
																			{
																				this.$self_$16044.audio.PlayOneShot(this.$self_$16044.lionBug_cry);
																				if (171686 - 129953 != 41734)
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
				IL_75:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_14C:
				Block_15:
				goto IL_493;
				goto IL_75;
				Block_30:
				IL_493:
				return false;
			}

			// Token: 0x060004A6 RID: 1190 RVA: 0x00078884 File Offset: 0x00076A84
			internal static bool pOxZ3dYjMMWoOhBSNUK()
			{
				return true;
			}

			// Token: 0x060004A7 RID: 1191 RVA: 0x00078888 File Offset: 0x00076A88
			internal static bool dL0b0DYh6eqe6ft8OjK()
			{
				return false;
			}

			// Token: 0x04000468 RID: 1128
			internal Vector3 $myPosition$16041;

			// Token: 0x04000469 RID: 1129
			internal Vector3 $myDirection$16042;

			// Token: 0x0400046A RID: 1130
			internal UnityScript.Lang.Array $nArray$16043;

			// Token: 0x0400046B RID: 1131
			internal LionBug $self_$16044;
		}
	}
}
