using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000262 RID: 610
[Serializable]
public class CharacterScriptTemplate : MonoBehaviour
{
	// Token: 0x06000DF1 RID: 3569 RVA: 0x001648E4 File Offset: 0x00162AE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public CharacterScriptTemplate()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06000DF2 RID: 3570 RVA: 0x001648F4 File Offset: 0x00162AF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (19829 - 518151 != -498321)
		{
		}
		for (;;)
		{
			this.tTGIyQUlWO = this.transform;
			if (41709 - 259679 == -217970)
			{
				this.yWTIVkFxIr = (CharacterControl)this.GetComponent(typeof(CharacterControl));
				if (152442 - 66489 != 85954)
				{
					this.yWTIVkFxIr.actionState = "standby";
					if (208358 - 372141 != -163782)
					{
						this.yWTIVkFxIr.actionTime = Time.time;
						if (299542 - 99260 != 200283)
						{
							this.yWTIVkFxIr.myCommand = "none";
							if (230146 - 537878 == -307732)
							{
								if (Game.mGameType != 99)
								{
									break;
								}
								if (283055 - 53231 != 229825)
								{
									this.yWTIVkFxIr.isMine = true;
									if (281990 - 193652 != 88339)
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

	// Token: 0x06000DF3 RID: 3571 RVA: 0x00164A54 File Offset: 0x00162C54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (128259 - 502383 != -374124)
		{
		}
		for (;;)
		{
			if (this.yWTIVkFxIr.isControlled)
			{
				if (99650 - 410305 != -310655)
				{
					continue;
				}
				if (!(this.yWTIVkFxIr.actionState == "standby"))
				{
					if (196819 - 423767 != -226948)
					{
						continue;
					}
					if (!(this.yWTIVkFxIr.actionState == "run"))
					{
						goto IL_32D;
					}
					if (255935 - 529979 != -274044)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (271663 - 30780 == 240884)
				{
					continue;
				}
			}
			IL_32D:
			if (this.yWTIVkFxIr.hp <= 0)
			{
				if (295915 - 353262 == -57346)
				{
					continue;
				}
				if (this.yWTIVkFxIr.actionState != "dead")
				{
					if (15541 - 557668 != -542127)
					{
						continue;
					}
					if (this.yWTIVkFxIr.isMine)
					{
						if (198852 - 442279 != -243427)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (166080 - 211445 != -45365)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (237909 - 302154 == -64244)
						{
							continue;
						}
						this.yWTIVkFxIr.DeadEvent();
						if (216574 - 193825 != 22750)
						{
							break;
						}
						continue;
					}
					else
					{
						this.yWTIVkFxIr.hp = 1;
						if (85204 - 325827 != -240623)
						{
							continue;
						}
						break;
					}
				}
			}
			if (this.yWTIVkFxIr.hp <= 0)
			{
				break;
			}
			if (233679 - 90948 != 142732)
			{
				if (this.yWTIVkFxIr.ko > 0)
				{
					break;
				}
				if (115269 - 538132 == -422863)
				{
					if (!(this.yWTIVkFxIr.actionState != "ko"))
					{
						break;
					}
					if (232766 - 155369 == 77397)
					{
						if (!(this.yWTIVkFxIr.actionState != "dead"))
						{
							break;
						}
						if (222256 - 298998 != -76741)
						{
							if (this.yWTIVkFxIr.isMine)
							{
								if (175124 - 255573 != -80448)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (37573 - 114658 == -77085)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (104065 - 17238 != 86828)
										{
											this.yWTIVkFxIr.KoEvent();
											if (262303 - 556864 != -294560)
											{
												break;
											}
										}
									}
								}
							}
							else
							{
								this.yWTIVkFxIr.ko = 1;
								if (239194 - 437799 != -198604)
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

	// Token: 0x06000DF4 RID: 3572 RVA: 0x00164E4C File Offset: 0x0016304C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (247540 - 197401 != 50139)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (167217 - 443324 == -276107)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (285255 - 575093 != -289837 && 161891 - 77974 != 83918)
				{
					Debug.Log("Unknown Action Name:" + ActionName);
					if (139775 - 494410 != -354634)
					{
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (13205 - 172036 == -158831)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (27302 - 134280 != -106977)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (292757 - 331019 != -38261)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (143076 - 32784 == 110292)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (19697 - 502120 != -482422)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (46785 - 150682 != -103896)
											{
												Hashtable hashtable = new Hashtable();
												if (162530 - 469202 != -306671)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (58305 - 118598 == -60293)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (186595 - 396950 != -210354)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (293262 - 428338 != -135075)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (219589 - 153113 == 66476)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (117279 - 483600 == -366321)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (217521 - 158221 != 59301)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (270811 - 406908 != -136096)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (266570 - 438795 == -172225)
																				{
																					PhotonClient.SendEvent(this.yWTIVkFxIr.ActorNr, 74, hashtable, true, true);
																					if (11669 - 79510 == -67841)
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

	// Token: 0x06000DF5 RID: 3573 RVA: 0x00165234 File Offset: 0x00163434
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (190738 - 470888 != -280150)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (28106 - 395361 != -367254)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (234648 - 145390 != 89259)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (125302 - 297420 == -172118)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (41951 - 103171 != -61219 && 110291 - 71874 != 38418)
						{
							Debug.Log("Unknown Action Code:" + num);
							if (251396 - 231663 != 19734)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06000DF6 RID: 3574 RVA: 0x001653D8 File Offset: 0x001635D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (206647 - 192737 != 13911)
		{
		}
		for (;;)
		{
			float num = this.yWTIVkFxIr.moveSpeed;
			if (189274 - 390941 != -201666)
			{
				float runSpeed = this.yWTIVkFxIr.runSpeed;
				if (55385 - 344983 != -289597)
				{
					Vector3 a = default(Vector3);
					if (258086 - 552857 != -294770)
					{
						Vector3 vector = Vector3.zero;
						if (245339 - 496365 == -251026)
						{
							float num2 = (float)0;
							if (30848 - 38848 != -7999)
							{
								if (this.yWTIVkFxIr.isMine)
								{
									if (141545 - 589119 != -447574)
									{
										continue;
									}
									if ((this.yWTIVkFxIr.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (177611 - 391200 == -213588)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (78304 - 394596 != -316292)
										{
											continue;
										}
										a.y = (float)0;
										if (116727 - 408470 == -291742)
										{
											continue;
										}
										a = a.normalized;
										if (231823 - 291781 != -59958)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (52541 - 292821 != -240280)
										{
											continue;
										}
										vector = vector.normalized;
										if (28559 - 361296 != -332737)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (74213 - 487645 != -413432)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (288751 - 247039 == 41713)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (237946 - 22305 != 215641)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (7154 - 406545 == -399390)
														{
															continue;
														}
														this.yWTIVkFxIr.actionState = "run";
														if (87319 - 364235 != -276916)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (146023 - 108766 != 37257)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (246146 - 280754 != -34608)
														{
															continue;
														}
														this.animation.Play("run");
														if (287521 - 288220 == -698)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (31758 - 77415 != -45656)
														{
															goto IL_546;
														}
														continue;
													}
												}
											}
										}
										this.yWTIVkFxIr.actionState = "standby";
										if (9317 - 493357 != -484040)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (267361 - 282321 != -14960)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (184411 - 172332 == 12080)
											{
												continue;
											}
											num = (float)0;
											if (98894 - 81629 != 17265)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (187989 - 551000 == -363010)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (286728 - 8552 == 278177)
										{
											continue;
										}
									}
									IL_546:;
								}
								else
								{
									vector = global::Math.vFlat(this.yWTIVkFxIr.nPosition - this.transform.position);
									if (254933 - 177547 == 77387)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (251914 - 202338 == 49577)
									{
										continue;
									}
									if (this.yWTIVkFxIr.nSpeed != (float)0)
									{
										if (139672 - 69446 == 70227)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (108799 - 199586 != -90787)
											{
												continue;
											}
											this.transform.position = this.yWTIVkFxIr.nPosition;
											if (145760 - 367829 == -222068)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (163720 - 581457 != -417737)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (161142 - 402089 != -240947)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (189030 - 133717 != 55313)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.yWTIVkFxIr.nSpeed, (float)10 * Time.deltaTime);
												if (285755 - 75421 != 210334)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (157606 - 426736 == -269129)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (69911 - 188386 != -118475)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (21060 - 244406 == -223345)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (197992 - 292271 == -94278)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (85605 - 151144 == -65538)
											{
												continue;
											}
										}
										else if (Time.time > this.yWTIVkFxIr.nSpeed + 0.3f)
										{
											if (183296 - 414193 != -230897)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (136362 - 390886 == -254523)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (137357 - 540973 != -403616)
												{
													continue;
												}
												num = (float)0;
												if (294685 - 146100 == 148586)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.yWTIVkFxIr.nDirection);
											if (278380 - 375078 == -96697)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (105911 - 522948 == -417036)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (130804 - 121552 == 9253)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (227528 - 207584 == 19945)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (272737 - 244346 != 28391)
											{
												continue;
											}
											this.transform.position = this.yWTIVkFxIr.nPosition;
											if (6339 - 35107 != -28768)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (34240 - 221531 == -187290)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (222959 - 68219 != 154740)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (149334 - 491813 == -342478)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (146412 - 277513 == -131100)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (233927 - 139060 == 94868)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (241101 - 587004 == -345902)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (175117 - 423880 == -248762)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.yWTIVkFxIr.nDirection);
											if (180358 - 287896 != -107538)
											{
												continue;
											}
											num = (float)0;
											if (199040 - 266961 == -67920)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (249188 - 437852 != -188664)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (177950 - 231447 != -53497)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (296199 - 386293 == -90093)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (210340 - 158837 != 51503)
										{
											continue;
										}
									}
								}
								this.yWTIVkFxIr.vMovement = vector;
								if (81039 - 62703 != 18337)
								{
									this.yWTIVkFxIr.moveSpeed = num;
									if (227418 - 443230 != -215811)
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

	// Token: 0x06000DF7 RID: 3575 RVA: 0x00165F3C File Offset: 0x0016413C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (154400 - 341208 != -186808)
		{
		}
		for (;;)
		{
			if (!this.yWTIVkFxIr.isMine)
			{
				if (103796 - 491801 == -388005)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (257540 - 53197 == 204343)
				{
					Vector3 vector = a - this.transform.position;
					if (23141 - 557122 != -533980)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (178772 - 267065 != -88292)
						{
							CharacterControl characterControl = null;
							if (159601 - 286961 != -127359)
							{
								if (243673 - 474578 == -230905)
								{
									if (gameObject)
									{
										if (230668 - 270182 != -39514)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (38997 - 199822 == -160824)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (49481 - 119713 == -70231)
										{
											continue;
										}
										int actorNr = characterControl.ActorNr;
										if (182602 - 290305 == -107702)
										{
											continue;
										}
									}
									if (!(this.yWTIVkFxIr.actionState == "standby"))
									{
										if (179273 - 345312 != -166039)
										{
											continue;
										}
										if (!(this.yWTIVkFxIr.actionState == "run"))
										{
											break;
										}
										if (125232 - 86896 == 38337)
										{
											continue;
										}
									}
									if (this.yWTIVkFxIr.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (280978 - 248214 != 32765)
									{
										Camera.main.SendMessage("newGameMessage", "This character cannot use normal attack");
										if (258236 - 47980 == 210256)
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

	// Token: 0x06000DF8 RID: 3576 RVA: 0x001661E0 File Offset: 0x001643E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (93917 - 114847 != -20929)
		{
		}
		for (;;)
		{
			if (!this.yWTIVkFxIr.isMine)
			{
				if (196333 - 494311 != -297977)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (226920 - 95589 == 131331)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (167045 - 193365 == -26320)
					{
						Vector3 normalized = vector.normalized;
						if (286699 - 90894 != 195806)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (59387 - 572048 != -512660)
							{
								CharacterControl characterControl = null;
								if (242038 - 351977 == -109939)
								{
									if (21830 - 329866 == -308036)
									{
										if (gameObject)
										{
											if (199367 - 416125 == -216757)
											{
												continue;
											}
											characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (178466 - 115451 != 63015)
											{
												continue;
											}
										}
										if (characterControl)
										{
											if (7785 - 478012 != -470227)
											{
												continue;
											}
											int actorNr = characterControl.ActorNr;
											if (203041 - 333456 != -130415)
											{
												continue;
											}
										}
										if (!(this.yWTIVkFxIr.actionState == "standby"))
										{
											if (212540 - 3967 != 208573)
											{
												continue;
											}
											if (!(this.yWTIVkFxIr.actionState == "run"))
											{
												break;
											}
											if (72063 - 282841 != -210778)
											{
												continue;
											}
										}
										if (this.yWTIVkFxIr.isTimeOut("cAttack") != (float)0)
										{
											break;
										}
										if (70370 - 573023 == -502653)
										{
											Camera.main.SendMessage("newGameMessage", "This character cannot use charged attack");
											if (76616 - 58635 == 17981)
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

	// Token: 0x06000DF9 RID: 3577 RVA: 0x001664AC File Offset: 0x001646AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06000DFA RID: 3578 RVA: 0x001664B0 File Offset: 0x001646B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new CharacterScriptTemplate.$RPC_ko$17645(nArray, this).GetEnumerator();
	}

	// Token: 0x06000DFB RID: 3579 RVA: 0x001664C0 File Offset: 0x001646C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new CharacterScriptTemplate.$RPC_dead$17652(nArray, this).GetEnumerator();
	}

	// Token: 0x06000DFC RID: 3580 RVA: 0x001664D0 File Offset: 0x001646D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06000DFD RID: 3581 RVA: 0x001664D4 File Offset: 0x001646D4
	internal static bool qs9crIyDlMndycBtlNX()
	{
		return true;
	}

	// Token: 0x06000DFE RID: 3582 RVA: 0x001664D8 File Offset: 0x001646D8
	internal static bool JEGmA4yvsgfmnLZiOpR()
	{
		return false;
	}

	// Token: 0x04000C17 RID: 3095
	private Transform tTGIyQUlWO;

	// Token: 0x04000C18 RID: 3096
	private CharacterControl yWTIVkFxIr;

	// Token: 0x02000263 RID: 611
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$17645 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000DFF RID: 3583 RVA: 0x001664DC File Offset: 0x001646DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$17645(UnityScript.Lang.Array nArray, CharacterScriptTemplate self_)
		{
			if (172494 - 69108 != 103386)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (283589 - 553746 == -270157)
				{
					base..ctor();
					if (262274 - 502071 != -239796)
					{
						this.$nArray$17650 = nArray;
						if (218938 - 40075 != 178864)
						{
							this.$self_$17651 = self_;
							if (15330 - 96942 != -81611)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000E00 RID: 3584 RVA: 0x00166598 File Offset: 0x00164798
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new CharacterScriptTemplate.$RPC_ko$17645.$(this.$nArray$17650, this.$self_$17651);
		}

		// Token: 0x06000E01 RID: 3585 RVA: 0x001665AC File Offset: 0x001647AC
		internal static bool wgUVHpyRDVjFF294VZ3()
		{
			return true;
		}

		// Token: 0x06000E02 RID: 3586 RVA: 0x001665B0 File Offset: 0x001647B0
		internal static bool KPyCp6ywwIwwcFXEqWT()
		{
			return false;
		}

		// Token: 0x04000C19 RID: 3097
		internal UnityScript.Lang.Array $nArray$17650;

		// Token: 0x04000C1A RID: 3098
		internal CharacterScriptTemplate $self_$17651;

		// Token: 0x02000264 RID: 612
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000E03 RID: 3587 RVA: 0x001665B4 File Offset: 0x001647B4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, CharacterScriptTemplate self_)
			{
				if (120540 - 514556 != -394016)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (139334 - 575586 == -436252)
					{
						base..ctor();
						if (247360 - 349364 != -102003)
						{
							this.$nArray$17648 = nArray;
							if (74997 - 172657 == -97660)
							{
								this.$self_$17649 = self_;
								if (44373 - 525939 == -481566)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06000E04 RID: 3588 RVA: 0x00166670 File Offset: 0x00164870
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (127973 - 325973 != -197999)
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
						if (this.$self_$17649.yWTIVkFxIr.actionState != "ko")
						{
							if (170927 - 24822 != 146105)
							{
								continue;
							}
							goto IL_83;
						}
						else
						{
							this.$self_$17649.animation.Play("getUp");
							if (27216 - 214965 == -187748)
							{
								continue;
							}
							this.$self_$17649.animation.wrapMode = WrapMode.Once;
							if (153820 - 208415 != -54595)
							{
								continue;
							}
							goto IL_178;
						}
						break;
					case 3:
						if (this.$self_$17649.yWTIVkFxIr.actionState != "ko")
						{
							if (113267 - 580764 != -467497)
							{
								continue;
							}
							goto IL_219;
						}
						else
						{
							this.$self_$17649.yWTIVkFxIr.actionState = "standby";
							if (70914 - 228381 != -157467)
							{
								continue;
							}
							this.$self_$17649.yWTIVkFxIr.actionTime = Time.time;
							if (57491 - 37538 != 19953)
							{
								continue;
							}
							this.$self_$17649.yWTIVkFxIr.myCommand = "none";
							if (236502 - 305920 != -69418)
							{
								continue;
							}
							this.$self_$17649.yWTIVkFxIr.ko = this.$self_$17649.yWTIVkFxIr.mko;
							if (162005 - 466617 != -304612)
							{
								continue;
							}
							this.YieldDefault(1);
							if (245653 - 411702 != -166048)
							{
								goto Block_11;
							}
							continue;
						}
						break;
					default:
						if (51291 - 541017 == -489725)
						{
							continue;
						}
						break;
					}
					if (this.$self_$17649.yWTIVkFxIr.actionState == "ko")
					{
						break;
					}
					if (19610 - 68480 == -48870)
					{
						if (this.$self_$17649.yWTIVkFxIr.actionState == "dead")
						{
							if (173279 - 233722 != -60442)
							{
								break;
							}
						}
						else
						{
							this.$mPos$17646 = (Vector3)this.$nArray$17648[0];
							if (213397 - 484934 == -271537)
							{
								this.$mDir$17647 = (Vector3)this.$nArray$17648[1];
								if (159579 - 574243 != -414663)
								{
									this.$self_$17649.yWTIVkFxIr.ko = 0;
									if (297977 - 42272 != 255706)
									{
										this.$self_$17649.yWTIVkFxIr.actionState = "ko";
										if (279606 - 77012 == 202594)
										{
											this.$self_$17649.yWTIVkFxIr.actionTime = Time.time;
											if (115783 - 162267 != -46483)
											{
												this.$self_$17649.yWTIVkFxIr.myCommand = "none";
												if (287508 - 597675 == -310167)
												{
													this.$self_$17649.yWTIVkFxIr.vMovement = Vector3.zero;
													if (21014 - 216748 != -195733)
													{
														this.$self_$17649.yWTIVkFxIr.moveSpeed = (float)0;
														if (8693 - 230531 == -221838)
														{
															this.$self_$17649.animation.Play("ko");
															if (73819 - 225713 == -151894)
															{
																this.$self_$17649.animation.wrapMode = WrapMode.Once;
																if (96208 - 370254 == -274046)
																{
																	goto IL_355;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_83:
				IL_E3:
				goto IL_48C;
				IL_178:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_11:
				IL_219:
				goto IL_E3;
				IL_355:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_48C:
				return false;
			}

			// Token: 0x06000E05 RID: 3589 RVA: 0x00166B1C File Offset: 0x00164D1C
			internal static bool XBUS84yqURuH1QtcDGB()
			{
				return true;
			}

			// Token: 0x06000E06 RID: 3590 RVA: 0x00166B20 File Offset: 0x00164D20
			internal static bool FZGOKRy7RH34EWx5ydR()
			{
				return false;
			}

			// Token: 0x04000C1B RID: 3099
			internal Vector3 $mPos$17646;

			// Token: 0x04000C1C RID: 3100
			internal Vector3 $mDir$17647;

			// Token: 0x04000C1D RID: 3101
			internal UnityScript.Lang.Array $nArray$17648;

			// Token: 0x04000C1E RID: 3102
			internal CharacterScriptTemplate $self_$17649;
		}
	}

	// Token: 0x02000265 RID: 613
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$17652 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000E07 RID: 3591 RVA: 0x00166B24 File Offset: 0x00164D24
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$17652(UnityScript.Lang.Array nArray, CharacterScriptTemplate self_)
		{
			if (62910 - 237243 != -174332)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (126516 - 93741 == 32775)
				{
					base..ctor();
					if (198898 - 254282 == -55384)
					{
						this.$nArray$17657 = nArray;
						if (215183 - 483544 == -268361)
						{
							this.$self_$17658 = self_;
							if (89797 - 2161 != 87637)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000E08 RID: 3592 RVA: 0x00166BE0 File Offset: 0x00164DE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new CharacterScriptTemplate.$RPC_dead$17652.$(this.$nArray$17657, this.$self_$17658);
		}

		// Token: 0x06000E09 RID: 3593 RVA: 0x00166BF4 File Offset: 0x00164DF4
		internal static bool WLabMAyPBWHWVk4YVh7()
		{
			return true;
		}

		// Token: 0x06000E0A RID: 3594 RVA: 0x00166BF8 File Offset: 0x00164DF8
		internal static bool q2QaIUy0A4D5NgttnFQ()
		{
			return false;
		}

		// Token: 0x04000C1F RID: 3103
		internal UnityScript.Lang.Array $nArray$17657;

		// Token: 0x04000C20 RID: 3104
		internal CharacterScriptTemplate $self_$17658;

		// Token: 0x02000266 RID: 614
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000E0B RID: 3595 RVA: 0x00166BFC File Offset: 0x00164DFC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, CharacterScriptTemplate self_)
			{
				if (86812 - 559264 != -472452)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (284162 - 62569 != 221594)
					{
						base..ctor();
						if (58249 - 80931 != -22681)
						{
							this.$nArray$17655 = nArray;
							if (298630 - 244527 == 54103)
							{
								this.$self_$17656 = self_;
								if (4235 - 211740 != -207504)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06000E0C RID: 3596 RVA: 0x00166CB8 File Offset: 0x00164EB8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (261014 - 559039 != -298025)
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
						if (this.$self_$17656.yWTIVkFxIr.actionState != "dead")
						{
							if (2333 - 252385 != -250051)
							{
								goto Block_10;
							}
							continue;
						}
						else
						{
							if (!this.$self_$17656.yWTIVkFxIr.isPlayer)
							{
								if (280866 - 5847 != 275019)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$17656.gameObject);
								if (49321 - 391898 == -342576)
								{
									continue;
								}
							}
							else if (this.$self_$17656.yWTIVkFxIr.isMine)
							{
								if (235058 - 191615 == 43444)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$17656.gameObject);
								if (43507 - 161870 == -118362)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (211200 - 343178 != -131977)
							{
								goto Block_15;
							}
							continue;
						}
						break;
					default:
						if (253578 - 515030 != -261452)
						{
							continue;
						}
						break;
					}
					if (this.$self_$17656.yWTIVkFxIr.actionState == "dead")
					{
						if (145506 - 444547 != -299040)
						{
							goto Block_21;
						}
					}
					else
					{
						this.$myPosition$17653 = (Vector3)this.$nArray$17655[0];
						if (128324 - 155960 == -27636)
						{
							this.$myDirection$17654 = (Vector3)this.$nArray$17655[1];
							if (298917 - 365412 == -66495)
							{
								this.$self_$17656.transform.position = this.$myPosition$17653;
								if (207356 - 494401 == -287045)
								{
									this.$self_$17656.transform.LookAt(this.$myPosition$17653 + this.$myDirection$17654);
									if (278569 - 492716 != -214146)
									{
										this.$self_$17656.yWTIVkFxIr.hp = 0;
										if (186858 - 451589 == -264731)
										{
											this.$self_$17656.yWTIVkFxIr.actionState = "dead";
											if (52645 - 104786 == -52141)
											{
												this.$self_$17656.yWTIVkFxIr.actionTime = Time.time;
												if (152528 - 475595 == -323067)
												{
													this.$self_$17656.yWTIVkFxIr.myCommand = "none";
													if (85575 - 319800 != -234224)
													{
														this.$self_$17656.yWTIVkFxIr.vMovement = Vector3.zero;
														if (206286 - 475207 != -268920)
														{
															this.$self_$17656.yWTIVkFxIr.moveSpeed = (float)0;
															if (266713 - 45628 == 221085)
															{
																this.$self_$17656.animation.Rewind();
																if (120862 - 153866 == -33004)
																{
																	this.$self_$17656.animation.Play("ko");
																	if (200951 - 511760 == -310809)
																	{
																		this.$self_$17656.animation.wrapMode = WrapMode.Once;
																		if (60 - 299098 == -299038)
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
				Block_10:
				Block_15:
				Block_21:
				IL_42F:
				return false;
			}

			// Token: 0x06000E0D RID: 3597 RVA: 0x00167108 File Offset: 0x00165308
			internal static bool cdWe6CybxgVTiYRYQ4I()
			{
				return true;
			}

			// Token: 0x06000E0E RID: 3598 RVA: 0x0016710C File Offset: 0x0016530C
			internal static bool HLI7ccyu4G3Jh1VC1o3()
			{
				return false;
			}

			// Token: 0x04000C21 RID: 3105
			internal Vector3 $myPosition$17653;

			// Token: 0x04000C22 RID: 3106
			internal Vector3 $myDirection$17654;

			// Token: 0x04000C23 RID: 3107
			internal UnityScript.Lang.Array $nArray$17655;

			// Token: 0x04000C24 RID: 3108
			internal CharacterScriptTemplate $self_$17656;
		}
	}
}
