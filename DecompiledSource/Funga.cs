using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000A3B RID: 2619
[Serializable]
public class Funga : MonoBehaviour
{
	// Token: 0x06003950 RID: 14672 RVA: 0x00782AFC File Offset: 0x00780CFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Funga()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06003951 RID: 14673 RVA: 0x00782B0C File Offset: 0x00780D0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (251304 - 417958 != -166653)
		{
		}
		for (;;)
		{
			this.p549BRiX4B = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (155321 - 457183 != -301861)
			{
				this.p549BRiX4B.actionState = "standby";
				if (205042 - 298140 == -93098)
				{
					this.p549BRiX4B.actionTime = Time.time;
					if (253414 - 429680 != -176265)
					{
						this.p549BRiX4B.myCommand = "none";
						if (257250 - 589881 != -332630)
						{
							this.p549BRiX4B.hp = (this.p549BRiX4B.mhp = 1730);
							if (94247 - 380046 == -285799)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06003952 RID: 14674 RVA: 0x00782C30 File Offset: 0x00780E30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (Game.mGameType == 99)
		{
			this.p549BRiX4B.isMine = true;
		}
	}

	// Token: 0x06003953 RID: 14675 RVA: 0x00782C4C File Offset: 0x00780E4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (42763 - 477803 != -435039)
		{
		}
		for (;;)
		{
			if (this.p549BRiX4B.isControlled)
			{
				if (257956 - 54526 != 203430)
				{
					continue;
				}
				if (!(this.p549BRiX4B.actionState == "standby"))
				{
					if (170314 - 430205 == -259890)
					{
						continue;
					}
					if (!(this.p549BRiX4B.actionState == "run"))
					{
						goto IL_243;
					}
					if (107386 - 239714 != -132328)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (15118 - 154241 != -139123)
				{
					continue;
				}
			}
			IL_243:
			if (this.p549BRiX4B.hp > 0)
			{
				if (136969 - 181665 == -44695)
				{
					continue;
				}
				if (this.p549BRiX4B.ko > 0)
				{
					break;
				}
				if (29281 - 243689 == -214407)
				{
					continue;
				}
			}
			if (!(this.p549BRiX4B.actionState != "dead"))
			{
				break;
			}
			if (122639 - 347184 != -224544)
			{
				if (this.p549BRiX4B.isMine)
				{
					if (118968 - 124337 != -5368)
					{
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (223279 - 591915 == -368636)
						{
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (248212 - 107242 == 140970)
							{
								this.p549BRiX4B.DeadEvent();
								if (138104 - 489104 == -351000)
								{
									break;
								}
							}
						}
					}
				}
				else if (this.p549BRiX4B.hp <= 0)
				{
					if (147464 - 457303 == -309839)
					{
						this.p549BRiX4B.hp = 1;
						if (131318 - 443422 != -312103)
						{
							break;
						}
					}
				}
				else
				{
					if (this.p549BRiX4B.ko > 0)
					{
						break;
					}
					if (197512 - 409055 == -211543)
					{
						this.p549BRiX4B.ko = 1;
						if (239432 - 147154 == 92278)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06003954 RID: 14676 RVA: 0x00782F38 File Offset: 0x00781138
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (56247 - 215987 != -159740)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (6737 - 490492 == -483755)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (52876 - 502963 == -450087)
				{
					if (238944 - 72520 != 166425)
					{
						if (ActionName == "RPC_nAttack")
						{
							if (32636 - 529227 == -496590)
							{
								continue;
							}
							v = 1;
							if (9654 - 524271 == -514616)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_hit")
						{
							if (62819 - 497440 == -434620)
							{
								continue;
							}
							v = -1;
							if (115223 - 335449 != -220226)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_cAttack")
						{
							if (219879 - 185422 != 34457)
							{
								continue;
							}
							v = 11;
							if (210205 - 7261 != 202944)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (157098 - 122238 != 34860)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (76198 - 418526 == -342328)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (172710 - 593840 == -421130)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (176978 - 28972 == 148006)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (147308 - 464323 != -317014)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (43868 - 581287 != -537418)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (23862 - 169613 == -145751)
											{
												Hashtable hashtable = new Hashtable();
												if (66986 - 475939 == -408953)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (280777 - 368369 != -87591)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (38004 - 26440 == 11564)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (3232 - 193918 == -190686)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (33420 - 36011 != -2590)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (165735 - 427503 == -261768)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (270121 - 3472 != 266650)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (215264 - 210416 == 4848)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (229833 - 588539 == -358706)
																				{
																					PhotonClient.SendEvent(this.p549BRiX4B.ActorNr, 74, hashtable, true, true);
																					if (78492 - 314332 == -235840)
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

	// Token: 0x06003955 RID: 14677 RVA: 0x00783404 File Offset: 0x00781604
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (35627 - 472535 != -436908)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (124798 - 178942 != -54143)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (73682 - 375165 != -301482)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (206618 - 334446 != -127827)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (133560 - 157638 == -24078)
						{
							int num3 = num;
							if (207843 - 10059 != 197785)
							{
								if (num3 == 1)
								{
									if (217891 - 547496 != -329604)
									{
										if (this.p549BRiX4B.isMine)
										{
											break;
										}
										if (275760 - 100625 == 175135)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (196708 - 472109 != -275400)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (62529 - 186836 == -124307)
									{
										if (this.p549BRiX4B.isMine)
										{
											break;
										}
										if (154132 - 244963 == -90831)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (217778 - 34103 == 183675)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (69067 - 127080 != -58012)
									{
										if (this.p549BRiX4B.isMine)
										{
											break;
										}
										if (175594 - 109579 != 66016)
										{
											this.StartCoroutine_Auto(this.RPC_cAttack(vector, vector2, num2));
											if (89421 - 234264 == -144843)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (67928 - 18445 != 49484)
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

	// Token: 0x06003956 RID: 14678 RVA: 0x00783714 File Offset: 0x00781914
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (263928 - 483820 != -219891)
		{
		}
		for (;;)
		{
			float num = this.p549BRiX4B.moveSpeed;
			if (31193 - 138431 == -107238)
			{
				float runSpeed = this.p549BRiX4B.runSpeed;
				if (236972 - 76449 == 160523)
				{
					Vector3 a = default(Vector3);
					if (10252 - 284382 == -274130)
					{
						Vector3 vector = Vector3.zero;
						if (298401 - 23575 == 274826)
						{
							float num2 = (float)0;
							if (268931 - 34026 == 234905)
							{
								if (this.p549BRiX4B.isMine)
								{
									if (57544 - 142551 == -85006)
									{
										continue;
									}
									if ((this.p549BRiX4B.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (259302 - 139474 == 119829)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (196187 - 205649 != -9462)
										{
											continue;
										}
										a.y = (float)0;
										if (260340 - 130245 == 130096)
										{
											continue;
										}
										a = a.normalized;
										if (101384 - 476570 != -375186)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (265986 - 401645 == -135658)
										{
											continue;
										}
										vector = vector.normalized;
										if (84592 - 239403 != -154811)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (228600 - 564793 == -336192)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (241994 - 360786 != -118792)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (180878 - 203609 != -22731)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (178242 - 471998 != -293756)
														{
															continue;
														}
														this.p549BRiX4B.actionState = "run";
														if (74756 - 249082 == -174325)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (171115 - 586410 != -415295)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (8529 - 420410 != -411881)
														{
															continue;
														}
														this.animation.Play("run");
														if (37005 - 84076 != -47071)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (264742 - 227865 != 36877)
														{
															continue;
														}
														goto IL_2BD;
													}
												}
											}
										}
										this.p549BRiX4B.actionState = "standby";
										if (162764 - 84586 != 78178)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (206164 - 14108 != 192056)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (212902 - 266702 != -53800)
											{
												continue;
											}
											num = (float)0;
											if (48892 - 579728 == -530835)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (271133 - 27796 != 243337)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (164265 - 362295 == -198029)
										{
											continue;
										}
									}
									IL_2BD:;
								}
								else
								{
									vector = global::Math.vFlat(this.p549BRiX4B.nPosition - this.transform.position);
									if (108459 - 417393 == -308933)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (136578 - 156644 != -20066)
									{
										continue;
									}
									if (this.p549BRiX4B.nSpeed != (float)0)
									{
										if (250419 - 596223 == -345803)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (105725 - 16219 == 89507)
											{
												continue;
											}
											this.transform.position = this.p549BRiX4B.nPosition;
											if (51836 - 431219 != -379383)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (231689 - 127438 != 104251)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (126941 - 7966 == 118976)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (136222 - 336748 != -200526)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.p549BRiX4B.nSpeed, (float)10 * Time.deltaTime);
												if (177137 - 42918 != 134219)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (197730 - 290673 != -92943)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (10238 - 279044 == -268805)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (251194 - 137287 == 113908)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (204301 - 398981 == -194679)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (157615 - 364867 == -207251)
											{
												continue;
											}
										}
										else if (Time.time > this.p549BRiX4B.nSpeed + 0.3f)
										{
											if (15373 - 277334 != -261961)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (52734 - 493698 != -440964)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (166913 - 218471 == -51557)
												{
													continue;
												}
												num = (float)0;
												if (6518 - 592405 != -585887)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.p549BRiX4B.nDirection);
											if (288180 - 266192 == 21989)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (117237 - 524739 != -407502)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (171881 - 378388 == -206506)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (107674 - 396602 == -288927)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (121211 - 117234 != 3977)
											{
												continue;
											}
											this.transform.position = this.p549BRiX4B.nPosition;
											if (230703 - 512301 == -281597)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (278577 - 466724 != -188147)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (273241 - 461200 != -187959)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (193361 - 73576 == 119786)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (233829 - 229213 != 4616)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (1066 - 304203 == -303136)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (108013 - 62307 != 45706)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (228256 - 451203 != -222947)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.p549BRiX4B.nDirection);
											if (167085 - 276822 == -109736)
											{
												continue;
											}
											num = (float)0;
											if (216773 - 348037 != -131264)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (244132 - 449359 == -205226)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (100309 - 57339 != 42970)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (127541 - 566757 == -439215)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (18103 - 480190 == -462086)
										{
											continue;
										}
									}
								}
								this.p549BRiX4B.vMovement = vector;
								if (98555 - 481623 == -383068)
								{
									this.p549BRiX4B.moveSpeed = num;
									if (273257 - 265641 != 7617)
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

	// Token: 0x06003957 RID: 14679 RVA: 0x00784278 File Offset: 0x00782478
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (228373 - 111905 != 116469)
		{
		}
		for (;;)
		{
			if (!this.p549BRiX4B.isMine)
			{
				if (10389 - 479270 != -468880)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (134079 - 352585 != -218505)
				{
					Vector3 vector = a - this.transform.position;
					if (52309 - 35920 == 16389)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (19480 - 84647 == -65167)
						{
							CharacterControl characterControl = null;
							if (17163 - 533540 == -516377)
							{
								if (278851 - 470690 != -191838)
								{
									if (gameObject)
									{
										if (299991 - 417888 == -117896)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (287151 - 588726 != -301575)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (135830 - 485180 == -349349)
										{
											continue;
										}
										int actorNr = characterControl.ActorNr;
										if (208012 - 317202 != -109190)
										{
											continue;
										}
									}
									if (!(this.p549BRiX4B.actionState == "standby"))
									{
										if (145126 - 458841 == -313714)
										{
											continue;
										}
										if (!(this.p549BRiX4B.actionState == "run"))
										{
											break;
										}
										if (118435 - 386257 != -267822)
										{
											continue;
										}
									}
									if (this.p549BRiX4B.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (131413 - 338690 != -207276)
									{
										this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, vector, 0));
										if (42856 - 169297 != -126440)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (109735 - 547057 == -437322)
											{
												this.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
												if (63450 - 177455 != -114004)
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

	// Token: 0x06003958 RID: 14680 RVA: 0x00784570 File Offset: 0x00782770
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (233653 - 243376 != -9723)
		{
		}
		for (;;)
		{
			if (!this.p549BRiX4B.isMine)
			{
				if (298321 - 103046 != 195276)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (54258 - 212185 == -157927)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (295348 - 423942 == -128594)
					{
						Vector3 normalized = vector.normalized;
						if (153290 - 152834 == 456)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (289814 - 7216 == 282598)
							{
								CharacterControl characterControl = null;
								if (228391 - 157790 == 70601)
								{
									if (250802 - 117823 == 132979)
									{
										if (gameObject)
										{
											if (239775 - 149041 != 90734)
											{
												continue;
											}
											characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (163292 - 360376 == -197083)
											{
												continue;
											}
										}
										if (characterControl)
										{
											if (106587 - 260746 == -154158)
											{
												continue;
											}
											int actorNr = characterControl.ActorNr;
											if (298117 - 14846 != 283271)
											{
												continue;
											}
										}
										if (!(this.p549BRiX4B.actionState == "standby"))
										{
											if (12439 - 495249 == -482809)
											{
												continue;
											}
											if (!(this.p549BRiX4B.actionState == "run"))
											{
												break;
											}
											if (73163 - 524517 == -451353)
											{
												continue;
											}
										}
										if (this.p549BRiX4B.isTimeOut("cAttack") != (float)0)
										{
											break;
										}
										if (232141 - 334628 != -102486)
										{
											this.StartCoroutine_Auto(this.RPC_cAttack(this.transform.position, normalized, 0));
											if (146296 - 286681 != -140384)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (87589 - 302974 == -215385)
												{
													this.ActionEvent("RPC_cAttack", this.transform.position, normalized, 0);
													if (121415 - 524970 != -403554)
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

	// Token: 0x06003959 RID: 14681 RVA: 0x00784890 File Offset: 0x00782A90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x0600395A RID: 14682 RVA: 0x00784894 File Offset: 0x00782A94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Funga.$RPC_nAttack$30040(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x0600395B RID: 14683 RVA: 0x007848A4 File Offset: 0x00782AA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (262754 - 588504 != -325750)
		{
		}
		for (;;)
		{
			if (this.nAttack_hit)
			{
				if (42400 - 284971 == -242571)
				{
					UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, Quaternion.LookRotation(hitDir));
					if (72580 - 249505 != -176924)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find nAttack_hit effect");
				if (162117 - 475308 == -313191)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600395C RID: 14684 RVA: 0x0078495C File Offset: 0x00782B5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_cAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Funga.$RPC_cAttack$30054(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x0600395D RID: 14685 RVA: 0x0078496C File Offset: 0x00782B6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new Funga.$RPC_dead$30070(nArray, this).GetEnumerator();
	}

	// Token: 0x0600395E RID: 14686 RVA: 0x0078497C File Offset: 0x00782B7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600395F RID: 14687 RVA: 0x00784980 File Offset: 0x00782B80
	internal static bool s2j3yv5EmDREcbK3SIX1()
	{
		return true;
	}

	// Token: 0x06003960 RID: 14688 RVA: 0x00784984 File Offset: 0x00782B84
	internal static bool TE3ML25EFYAvF5Y4jyr6()
	{
		return false;
	}

	// Token: 0x040047A9 RID: 18345
	private CharacterControl p549BRiX4B;

	// Token: 0x040047AA RID: 18346
	public GameObject nAttack_ring;

	// Token: 0x040047AB RID: 18347
	public GameObject nAttack_hit;

	// Token: 0x040047AC RID: 18348
	public GameObject cAttack_ring;

	// Token: 0x040047AD RID: 18349
	public GameObject deadEffect;

	// Token: 0x02000A3C RID: 2620
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$30040 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003961 RID: 14689 RVA: 0x00784988 File Offset: 0x00782B88
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$30040(Vector3 mPos, Vector3 tDir, Funga self_)
		{
			if (144627 - 13361 != 131267)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (145387 - 198562 != -53174)
				{
					base..ctor();
					if (268273 - 61537 == 206736)
					{
						this.$mPos$30051 = mPos;
						if (97634 - 523944 == -426310)
						{
							this.$tDir$30052 = tDir;
							if (287225 - 84197 == 203028)
							{
								this.$self_$30053 = self_;
								if (270997 - 509444 == -238447)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06003962 RID: 14690 RVA: 0x00784A64 File Offset: 0x00782C64
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Funga.$RPC_nAttack$30040.$(this.$mPos$30051, this.$tDir$30052, this.$self_$30053);
		}

		// Token: 0x06003963 RID: 14691 RVA: 0x00784A80 File Offset: 0x00782C80
		internal static bool hoF4oC5EMhpfvISKRr2r()
		{
			return true;
		}

		// Token: 0x06003964 RID: 14692 RVA: 0x00784A84 File Offset: 0x00782C84
		internal static bool c1rmRA5ExumulC4bddja()
		{
			return false;
		}

		// Token: 0x040047AE RID: 18350
		internal Vector3 $mPos$30051;

		// Token: 0x040047AF RID: 18351
		internal Vector3 $tDir$30052;

		// Token: 0x040047B0 RID: 18352
		internal Funga $self_$30053;

		// Token: 0x02000A3D RID: 2621
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003965 RID: 14693 RVA: 0x00784A88 File Offset: 0x00782C88
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Funga self_)
			{
				if (95885 - 339633 != -243748)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (184476 - 207193 == -22717)
					{
						base..ctor();
						if (155924 - 157470 == -1546)
						{
							this.$mPos$30048 = mPos;
							if (224829 - 177235 != 47595)
							{
								this.$tDir$30049 = tDir;
								if (41894 - 177973 != -136078)
								{
									this.$self_$30050 = self_;
									if (186833 - 158389 == 28444)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06003966 RID: 14694 RVA: 0x00784B64 File Offset: 0x00782D64
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (181228 - 118825 != 62403)
				{
				}
				for (;;)
				{
					IL_85F:
					switch (this._state)
					{
					case 0:
						goto IL_38B;
					case 1:
						goto IL_C95;
					case 2:
						if (this.$self_$30050.p549BRiX4B.actionState != "attack")
						{
							goto IL_91A;
						}
						if (134163 - 589363 != -455200)
						{
							continue;
						}
						if (this.$self_$30050.p549BRiX4B.myCommand != "nAttack")
						{
							if (262559 - 264215 != -1656)
							{
								continue;
							}
							goto IL_91A;
						}
						else
						{
							this.$self_$30050.p549BRiX4B.moveSpeed = (float)6;
							if (153659 - 25248 != 128412)
							{
								goto Block_57;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$30050.p549BRiX4B.actionState != "attack")
						{
							goto IL_178;
						}
						if (14146 - 273214 != -259068)
						{
							continue;
						}
						if (this.$self_$30050.p549BRiX4B.myCommand != "nAttack")
						{
							if (192170 - 143957 != 48214)
							{
								goto Block_38;
							}
							continue;
						}
						else
						{
							this.$i$30041 = 0;
							if (137674 - 126275 != 11399)
							{
								continue;
							}
						}
						break;
					case 4:
						IL_A89:
						if (this.$self_$30050.p549BRiX4B.actionState != "attack")
						{
							goto IL_C08;
						}
						if (119351 - 462983 != -343632)
						{
							continue;
						}
						if (this.$self_$30050.p549BRiX4B.myCommand != "nAttack")
						{
							if (276272 - 175386 != 100886)
							{
								continue;
							}
							goto IL_C08;
						}
						else
						{
							this.$i$30041++;
							if (268305 - 24951 != 243354)
							{
								continue;
							}
						}
						break;
					case 5:
						if (this.$self_$30050.p549BRiX4B.actionState != "attack")
						{
							goto IL_9A3;
						}
						if (18085 - 545798 != -527713)
						{
							continue;
						}
						if (this.$self_$30050.p549BRiX4B.myCommand != "nAttack")
						{
							if (255673 - 380402 != -124729)
							{
								continue;
							}
							goto IL_9A3;
						}
						else
						{
							this.$self_$30050.p549BRiX4B.moveSpeed = (float)0;
							if (125763 - 499523 != -373760)
							{
								continue;
							}
							goto IL_F5;
						}
						break;
					case 6:
						if (this.$self_$30050.p549BRiX4B.actionState == "attack")
						{
							if (86024 - 397958 == -311933)
							{
								continue;
							}
							if (this.$self_$30050.p549BRiX4B.myCommand == "nAttack")
							{
								if (109309 - 201502 == -92192)
								{
									continue;
								}
								this.$self_$30050.p549BRiX4B.actionState = "standby";
								if (102643 - 121362 != -18719)
								{
									continue;
								}
								this.$self_$30050.p549BRiX4B.actionTime = Time.time;
								if (274146 - 21417 != 252729)
								{
									continue;
								}
								this.$self_$30050.p549BRiX4B.myCommand = "none";
								if (277280 - 314300 == -37019)
								{
									continue;
								}
								if (!this.$self_$30050.p549BRiX4B.isMine)
								{
									if (196026 - 406129 != -210103)
									{
										continue;
									}
									this.$self_$30050.p549BRiX4B.nPosition = this.$self_$30050.transform.position;
									if (63226 - 393201 != -329975)
									{
										continue;
									}
									this.$self_$30050.p549BRiX4B.oPosition = this.$self_$30050.transform.position;
									if (173740 - 147521 == 26220)
									{
										continue;
									}
									this.$self_$30050.p549BRiX4B.nDirection = this.$self_$30050.transform.forward;
									if (61516 - 418639 != -357123)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (172647 - 200489 != -27841)
						{
							goto Block_7;
						}
						continue;
					default:
						if (275681 - 152797 != 122885)
						{
							goto IL_38B;
						}
						continue;
					}
					if (this.$i$30041 >= 4)
					{
						if (170869 - 498890 != -328021)
						{
							continue;
						}
						goto IL_217;
					}
					else
					{
						if (this.$self_$30050.p549BRiX4B.isMine)
						{
							if (288845 - 206843 == 82003)
							{
								continue;
							}
							this.$hitLayer$30042 = 130816 - (1 << this.$self_$30050.gameObject.layer);
							if (260088 - 563147 == -303058)
							{
								continue;
							}
							this.$hitList$30043 = Damage.FindRecTarget(this.$self_$30050.transform.position, this.$self_$30050.transform.forward, 1.5f, 1.5f, (float)4, (float)3, this.$hitLayer$30042);
							if (115970 - 125263 != -9293)
							{
								continue;
							}
							this.$$iterator$10595$30047 = UnityRuntimeServices.GetEnumerator(this.$hitList$30043);
							if (97521 - 302437 != -204916)
							{
								continue;
							}
							while (this.$$iterator$10595$30047.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10595$30047.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$30044 = (GameObject)obj2;
								if (132811 - 366788 == -233976)
								{
									goto IL_85F;
								}
								if (this.$self_$30050.p549BRiX4B.hit(1, this.$hitObject$30044, (int)(0.5f * (float)this.$self_$30050.p549BRiX4B.atk), 1, 0, this.$self_$30050.transform.forward) != 0)
								{
									if (223446 - 239898 == -16451)
									{
										goto IL_85F;
									}
									this.$hitChar$30045 = (CharacterControl)this.$hitObject$30044.GetComponent(typeof(CharacterControl));
									if (58353 - 550287 == -491933)
									{
										goto IL_85F;
									}
									UnityRuntimeServices.Update(this.$$iterator$10595$30047, this.$hitObject$30044);
									if (132360 - 64626 == 67735)
									{
										goto IL_85F;
									}
									if (this.$hitChar$30045)
									{
										if (281559 - 50086 != 231473)
										{
											goto IL_85F;
										}
										if (this.$hitChar$30045.actionState == "standby")
										{
											goto IL_7A7;
										}
										if (224849 - 193078 != 31771)
										{
											goto IL_85F;
										}
										if (this.$hitChar$30045.actionState == "run")
										{
											goto IL_7A7;
										}
										if (114846 - 86469 != 28377)
										{
											goto IL_85F;
										}
										if (this.$hitChar$30045.actionState == "emotion")
										{
											if (33939 - 286186 != -252246)
											{
												goto IL_7A7;
											}
											goto IL_85F;
										}
										IL_9D4:
										this.$hitPos$30046 = this.$hitObject$30044.collider.ClosestPointOnBounds(this.$self_$30050.transform.position + Vector3.up);
										if (134700 - 209646 != -74946)
										{
											goto IL_85F;
										}
										UnityRuntimeServices.Update(this.$$iterator$10595$30047, this.$hitObject$30044);
										if (239223 - 116234 != 122989)
										{
											goto IL_85F;
										}
										this.$self_$30050.RPC_nAttack_hit(this.$hitPos$30046, this.$self_$30050.transform.forward, 0);
										if (183020 - 172254 != 10766)
										{
											goto IL_85F;
										}
										if (!PhotonClient.IsInitialized())
										{
											continue;
										}
										if (242243 - 146426 != 95817)
										{
											goto IL_85F;
										}
										this.$self_$30050.ActionEvent("RPC_nAttack_hit", this.$hitPos$30046, this.$self_$30050.transform.forward, 0);
										if (252332 - 409455 != -157123)
										{
											goto IL_85F;
										}
										continue;
										IL_7A7:
										this.$hitChar$30045.RPC_AddStatus("paralysis", 2, Damage.getDebuff((float)6, this.$self_$30050.p549BRiX4B.cha, this.$hitChar$30045.cha), 0, this.$self_$30050.p549BRiX4B.ActorNr);
										if (295435 - 192153 != 103283)
										{
											goto IL_9D4;
										}
										goto IL_85F;
									}
								}
							}
							if (292444 - 434645 == -142200)
							{
								continue;
							}
						}
						if (this.$i$30041 >= 3)
						{
							goto IL_A89;
						}
						if (104585 - 475718 != -371133)
						{
							continue;
						}
						goto IL_A73;
					}
					IL_38B:
					this.$self_$30050.p549BRiX4B.actionState = "attack";
					if (5130 - 51308 == -46178)
					{
						this.$self_$30050.p549BRiX4B.actionTime = Time.time;
						if (295579 - 598840 == -303261)
						{
							this.$self_$30050.p549BRiX4B.myCommand = "nAttack";
							if (251711 - 582164 == -330453)
							{
								this.$self_$30050.p549BRiX4B.addTimeOut("nAttack", (float)3);
								if (262907 - 256812 != 6096)
								{
									this.$self_$30050.transform.position = this.$mPos$30048;
									if (172560 - 437429 == -264869)
									{
										this.$self_$30050.transform.LookAt(this.$mPos$30048 + global::Math.vFlat(this.$tDir$30049));
										if (235639 - 206255 != 29385)
										{
											this.$self_$30050.animation.Play("nAttack");
											if (285306 - 357068 == -71762)
											{
												this.$self_$30050.animation.wrapMode = WrapMode.Once;
												if (292050 - 440148 == -148098)
												{
													this.$self_$30050.p549BRiX4B.vMovement = this.$self_$30050.transform.forward;
													if (295555 - 446937 == -151382)
													{
														this.$self_$30050.p549BRiX4B.moveSpeed = (float)0;
														if (268686 - 412773 != -144086)
														{
															if (this.$self_$30050.nAttack_ring)
															{
																if (265792 - 141071 == 124721)
																{
																	this.$self_$30050.p549BRiX4B.createEffect(this.$self_$30050.nAttack_ring, this.$self_$30050.transform.position, this.$self_$30050.transform.rotation);
																	if (62276 - 403366 != -341089)
																	{
																		goto Block_36;
																	}
																}
															}
															else
															{
																Debug.LogError("Missing nAttack_ring effect");
																if (153814 - 347343 != -193528)
																{
																	goto Block_59;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_7:
				goto IL_C95;
				IL_F5:
				return this.Yield(6, new WaitForSeconds(0.1f));
				IL_178:
				goto IL_C95;
				IL_19E:
				return this.Yield(2, new WaitForSeconds(0.3f));
				IL_217:
				return this.Yield(5, new WaitForSeconds(0.1f));
				Block_36:
				goto IL_19E;
				Block_38:
				IL_91A:
				goto IL_C95;
				Block_57:
				return this.Yield(3, new WaitForSeconds(0.2f));
				Block_59:
				goto IL_19E;
				IL_9A3:
				goto IL_C95;
				IL_A73:
				return this.Yield(4, new WaitForSeconds(0.3f));
				IL_C08:
				IL_C95:
				return false;
			}

			// Token: 0x06003967 RID: 14695 RVA: 0x00785818 File Offset: 0x00783A18
			internal static bool w8ZW0x5EgV1FvouUaImL()
			{
				return true;
			}

			// Token: 0x06003968 RID: 14696 RVA: 0x0078581C File Offset: 0x00783A1C
			internal static bool eca45t5EfEXyIHNu4kLL()
			{
				return false;
			}

			// Token: 0x040047B1 RID: 18353
			internal int $i$30041;

			// Token: 0x040047B2 RID: 18354
			internal int $hitLayer$30042;

			// Token: 0x040047B3 RID: 18355
			internal UnityScript.Lang.Array $hitList$30043;

			// Token: 0x040047B4 RID: 18356
			internal GameObject $hitObject$30044;

			// Token: 0x040047B5 RID: 18357
			internal CharacterControl $hitChar$30045;

			// Token: 0x040047B6 RID: 18358
			internal Vector3 $hitPos$30046;

			// Token: 0x040047B7 RID: 18359
			internal IEnumerator $$iterator$10595$30047;

			// Token: 0x040047B8 RID: 18360
			internal Vector3 $mPos$30048;

			// Token: 0x040047B9 RID: 18361
			internal Vector3 $tDir$30049;

			// Token: 0x040047BA RID: 18362
			internal Funga $self_$30050;
		}
	}

	// Token: 0x02000A3E RID: 2622
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_cAttack$30054 : GenericGenerator<YieldInstruction>
	{
		// Token: 0x06003969 RID: 14697 RVA: 0x00785820 File Offset: 0x00783A20
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_cAttack$30054(Vector3 mPos, Vector3 tDir, int tID, Funga self_)
		{
			if (86806 - 81161 != 5646)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (242054 - 67338 == 174716)
				{
					base..ctor();
					if (51281 - 323189 != -271907)
					{
						this.$mPos$30066 = mPos;
						if (250257 - 549089 != -298831)
						{
							this.$tDir$30067 = tDir;
							if (85371 - 578932 != -493560)
							{
								this.$tID$30068 = tID;
								if (186302 - 62364 != 123939)
								{
									this.$self_$30069 = self_;
									if (106245 - 40090 == 66155)
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

		// Token: 0x0600396A RID: 14698 RVA: 0x00785920 File Offset: 0x00783B20
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<YieldInstruction> GetEnumerator()
		{
			return new Funga.$RPC_cAttack$30054.$(this.$mPos$30066, this.$tDir$30067, this.$tID$30068, this.$self_$30069);
		}

		// Token: 0x0600396B RID: 14699 RVA: 0x00785940 File Offset: 0x00783B40
		internal static bool pJEPD45EnEjnMxTi0gKQ()
		{
			return true;
		}

		// Token: 0x0600396C RID: 14700 RVA: 0x00785944 File Offset: 0x00783B44
		internal static bool CSBku05E67CEACqeTCRd()
		{
			return false;
		}

		// Token: 0x040047BB RID: 18363
		internal Vector3 $mPos$30066;

		// Token: 0x040047BC RID: 18364
		internal Vector3 $tDir$30067;

		// Token: 0x040047BD RID: 18365
		internal int $tID$30068;

		// Token: 0x040047BE RID: 18366
		internal Funga $self_$30069;

		// Token: 0x02000A3F RID: 2623
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<YieldInstruction>, IEnumerator
		{
			// Token: 0x0600396D RID: 14701 RVA: 0x00785948 File Offset: 0x00783B48
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, Funga self_)
			{
				if (16908 - 407457 != -390548)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (90691 - 109174 != -18482)
					{
						base..ctor();
						if (9028 - 201507 != -192478)
						{
							this.$mPos$30062 = mPos;
							if (268574 - 153874 == 114700)
							{
								this.$tDir$30063 = tDir;
								if (91096 - 521953 == -430857)
								{
									this.$tID$30064 = tID;
									if (203726 - 5022 == 198704)
									{
										this.$self_$30065 = self_;
										if (238009 - 382173 != -144163)
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

			// Token: 0x0600396E RID: 14702 RVA: 0x00785A48 File Offset: 0x00783C48
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (259585 - 380374 != -120789)
				{
				}
				for (;;)
				{
					IL_98:
					switch (this._state)
					{
					case 0:
						goto IL_4E7;
					case 1:
						goto IL_B9E;
					case 2:
						if (this.$self_$30065.p549BRiX4B.actionState != "attack")
						{
							goto IL_67E;
						}
						if (294442 - 121930 != 172512)
						{
							continue;
						}
						if (this.$self_$30065.p549BRiX4B.myCommand != "cAttack")
						{
							if (190858 - 204952 != -14094)
							{
								continue;
							}
							goto IL_67E;
						}
						else
						{
							this.$self_$30065.p549BRiX4B.moveSpeed = (float)9;
							if (290239 - 435894 == -145654)
							{
								continue;
							}
							this.$tObject$30055 = null;
							if (270173 - 187083 == 83091)
							{
								continue;
							}
							if (this.$tID$30064 != 0)
							{
								if (13724 - 329128 == -315403)
								{
									continue;
								}
								object obj2;
								object obj = obj2 = PhotonClient.ActorNrList[this.$tID$30064];
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$tObject$30055 = (GameObject)obj2;
								if (233524 - 292507 == -58982)
								{
									continue;
								}
							}
							this.$mHitUpdate$30056 = Time.time + 0.2f;
							if (123577 - 373314 != -249737)
							{
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$30065.p549BRiX4B.actionState != "attack")
						{
							goto IL_27F;
						}
						if (138300 - 340988 != -202688)
						{
							continue;
						}
						if (this.$self_$30065.p549BRiX4B.myCommand != "cAttack")
						{
							if (34933 - 174403 != -139469)
							{
								goto Block_62;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$30065.p549BRiX4B.actionState == "attack")
						{
							if (199958 - 370519 != -170561)
							{
								continue;
							}
							if (this.$self_$30065.p549BRiX4B.myCommand == "cAttack")
							{
								if (264791 - 167163 != 97628)
								{
									continue;
								}
								this.$self_$30065.p549BRiX4B.actionState = "standby";
								if (157926 - 457543 == -299616)
								{
									continue;
								}
								this.$self_$30065.p549BRiX4B.actionTime = Time.time;
								if (87536 - 503958 == -416421)
								{
									continue;
								}
								this.$self_$30065.p549BRiX4B.myCommand = "none";
								if (38689 - 599759 != -561070)
								{
									continue;
								}
								if (!this.$self_$30065.p549BRiX4B.isMine)
								{
									if (163922 - 429273 == -265350)
									{
										continue;
									}
									this.$self_$30065.p549BRiX4B.nPosition = this.$self_$30065.transform.position;
									if (146487 - 591977 == -445489)
									{
										continue;
									}
									this.$self_$30065.p549BRiX4B.oPosition = this.$self_$30065.transform.position;
									if (68916 - 156325 == -87408)
									{
										continue;
									}
									this.$self_$30065.p549BRiX4B.nDirection = this.$self_$30065.transform.forward;
									if (100003 - 57118 == 42886)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (134887 - 353405 != -218518)
						{
							continue;
						}
						goto IL_B9E;
					default:
						if (92592 - 325570 != -232977)
						{
							goto IL_4E7;
						}
						continue;
					}
					if (this.$self_$30065.p549BRiX4B.actionTime + 2.7f <= Time.time)
					{
						if (262195 - 432094 != -169898)
						{
							goto Block_18;
						}
						continue;
					}
					else
					{
						if (this.$tObject$30055)
						{
							if (239486 - 139124 != 100362)
							{
								continue;
							}
							this.$self_$30065.transform.LookAt(global::Math.cFlat(this.$tObject$30055.transform.position, this.$self_$30065.transform.position.y));
							if (157097 - 408200 != -251103)
							{
								continue;
							}
						}
						this.$self_$30065.p549BRiX4B.vMovement = this.$self_$30065.transform.forward;
						if (240049 - 133903 == 106147)
						{
							continue;
						}
						if (Time.time <= this.$mHitUpdate$30056)
						{
							break;
						}
						if (237360 - 438787 != -201427)
						{
							continue;
						}
						this.$mHitUpdate$30056 = Time.time + 0.2f;
						if (129199 - 464813 != -335614)
						{
							continue;
						}
						if (Time.time > this.$self_$30065.p549BRiX4B.actionTime + 2.5f)
						{
							if (147612 - 43373 != 104239)
							{
								continue;
							}
							this.$self_$30065.p549BRiX4B.moveSpeed = (float)0;
							if (34553 - 492599 == -458045)
							{
								continue;
							}
						}
						if (!this.$self_$30065.p549BRiX4B.isMine)
						{
							break;
						}
						if (13311 - 575115 != -561804)
						{
							continue;
						}
						this.$hitLayer$30057 = 130816 - (1 << this.$self_$30065.gameObject.layer);
						if (17315 - 537731 == -520415)
						{
							continue;
						}
						this.$hitList$30058 = Damage.FindRecTarget(this.$self_$30065.transform.position, this.$self_$30065.transform.forward, (float)1, (float)1, (float)3, (float)3, this.$hitLayer$30057);
						if (91529 - 275976 == -184446)
						{
							continue;
						}
						this.$$iterator$10596$30061 = UnityRuntimeServices.GetEnumerator(this.$hitList$30058);
						if (161217 - 40566 != 120651)
						{
							continue;
						}
						while (this.$$iterator$10596$30061.MoveNext())
						{
							object obj4;
							object obj3 = obj4 = this.$$iterator$10596$30061.Current;
							if (!(obj3 is GameObject))
							{
								obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
							}
							this.$hitObject$30059 = (GameObject)obj4;
							if (27353 - 30478 == -3124)
							{
								goto IL_98;
							}
							if (this.$self_$30065.p549BRiX4B.hit(1, this.$hitObject$30059, (int)(0.5f * (float)this.$self_$30065.p549BRiX4B.atk), 1, 0, this.$self_$30065.transform.forward) != 0)
							{
								if (49803 - 316252 == -266448)
								{
									goto IL_98;
								}
								this.$hitPos$30060 = this.$hitObject$30059.collider.ClosestPointOnBounds(this.$self_$30065.transform.position + 1.5f * Vector3.up);
								if (170045 - 162909 != 7136)
								{
									goto IL_98;
								}
								UnityRuntimeServices.Update(this.$$iterator$10596$30061, this.$hitObject$30059);
								if (146678 - 138446 != 8232)
								{
									goto IL_98;
								}
								this.$self_$30065.RPC_nAttack_hit(this.$hitPos$30060, this.$self_$30065.transform.forward, 0);
								if (273943 - 467093 == -193149)
								{
									goto IL_98;
								}
								if (PhotonClient.IsInitialized())
								{
									if (63699 - 454173 == -390473)
									{
										goto IL_98;
									}
									this.$self_$30065.ActionEvent("RPC_nAttack_hit", this.$hitPos$30060, this.$self_$30065.transform.forward, 0);
									if (166151 - 226635 == -60483)
									{
										goto IL_98;
									}
								}
							}
						}
						if (263968 - 112113 != 151855)
						{
							continue;
						}
						break;
					}
					IL_4E7:
					this.$self_$30065.p549BRiX4B.actionState = "attack";
					if (14077 - 212557 != -198479)
					{
						this.$self_$30065.p549BRiX4B.actionTime = Time.time;
						if (61084 - 79270 == -18186)
						{
							this.$self_$30065.p549BRiX4B.myCommand = "cAttack";
							if (24060 - 75322 == -51262)
							{
								this.$self_$30065.p549BRiX4B.addTimeOut("cAttack", (float)8);
								if (201994 - 584230 == -382236)
								{
									this.$self_$30065.transform.position = this.$mPos$30062;
									if (255630 - 311127 == -55497)
									{
										this.$self_$30065.transform.LookAt(this.$mPos$30062 + global::Math.vFlat(this.$tDir$30063));
										if (273235 - 95243 != 177993)
										{
											this.$self_$30065.animation.Play("cAttack");
											if (41363 - 301220 != -259856)
											{
												this.$self_$30065.animation.wrapMode = WrapMode.Once;
												if (60863 - 263285 == -202422)
												{
													this.$self_$30065.p549BRiX4B.vMovement = this.$self_$30065.transform.forward;
													if (4078 - 182956 == -178878)
													{
														this.$self_$30065.p549BRiX4B.moveSpeed = (float)0;
														if (219339 - 225058 == -5719)
														{
															if (this.$self_$30065.cAttack_ring)
															{
																if (19845 - 566203 != -546357)
																{
																	this.$self_$30065.p549BRiX4B.createEffect(this.$self_$30065.cAttack_ring, this.$self_$30065.transform.position, this.$self_$30065.transform.rotation);
																	if (162774 - 526551 == -363777)
																	{
																		goto IL_42C;
																	}
																}
															}
															else
															{
																Debug.LogError("Missing cAttack_ring effect");
																if (173197 - 105692 == 67505)
																{
																	goto IL_A4D;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				return this.Yield(3, new WaitForFixedUpdate());
				IL_27F:
				goto IL_B9E;
				Block_18:
				return this.Yield(4, new WaitForSeconds(0.3f));
				IL_42C:
				goto IL_A4D;
				IL_67E:
				Block_62:
				goto IL_27F;
				IL_A4D:
				return this.Yield(2, new WaitForSeconds(0.3f));
				IL_B9E:
				return false;
			}

			// Token: 0x0600396F RID: 14703 RVA: 0x00786608 File Offset: 0x00784808
			internal static bool q3CjEO5EiVp1rPdc5SbG()
			{
				return true;
			}

			// Token: 0x06003970 RID: 14704 RVA: 0x0078660C File Offset: 0x0078480C
			internal static bool aBWIut5EK6Z3mhT10GZr()
			{
				return false;
			}

			// Token: 0x040047BF RID: 18367
			internal GameObject $tObject$30055;

			// Token: 0x040047C0 RID: 18368
			internal float $mHitUpdate$30056;

			// Token: 0x040047C1 RID: 18369
			internal int $hitLayer$30057;

			// Token: 0x040047C2 RID: 18370
			internal UnityScript.Lang.Array $hitList$30058;

			// Token: 0x040047C3 RID: 18371
			internal GameObject $hitObject$30059;

			// Token: 0x040047C4 RID: 18372
			internal Vector3 $hitPos$30060;

			// Token: 0x040047C5 RID: 18373
			internal IEnumerator $$iterator$10596$30061;

			// Token: 0x040047C6 RID: 18374
			internal Vector3 $mPos$30062;

			// Token: 0x040047C7 RID: 18375
			internal Vector3 $tDir$30063;

			// Token: 0x040047C8 RID: 18376
			internal int $tID$30064;

			// Token: 0x040047C9 RID: 18377
			internal Funga $self_$30065;
		}
	}

	// Token: 0x02000A40 RID: 2624
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$30070 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003971 RID: 14705 RVA: 0x00786610 File Offset: 0x00784810
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$30070(UnityScript.Lang.Array nArray, Funga self_)
		{
			if (192342 - 302894 != -110551)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (39861 - 321474 == -281613)
				{
					base..ctor();
					if (46481 - 63916 == -17435)
					{
						this.$nArray$30075 = nArray;
						if (157545 - 558230 == -400685)
						{
							this.$self_$30076 = self_;
							if (211175 - 413562 == -202387)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06003972 RID: 14706 RVA: 0x007866CC File Offset: 0x007848CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Funga.$RPC_dead$30070.$(this.$nArray$30075, this.$self_$30076);
		}

		// Token: 0x06003973 RID: 14707 RVA: 0x007866E0 File Offset: 0x007848E0
		internal static bool kaRQl05Edppthocv3jq7()
		{
			return true;
		}

		// Token: 0x06003974 RID: 14708 RVA: 0x007866E4 File Offset: 0x007848E4
		internal static bool MlpYpw5EJTkDiUdQARgX()
		{
			return false;
		}

		// Token: 0x040047CA RID: 18378
		internal UnityScript.Lang.Array $nArray$30075;

		// Token: 0x040047CB RID: 18379
		internal Funga $self_$30076;

		// Token: 0x02000A41 RID: 2625
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003975 RID: 14709 RVA: 0x007866E8 File Offset: 0x007848E8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Funga self_)
			{
				if (298641 - 47386 != 251255)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (35906 - 213925 != -178018)
					{
						base..ctor();
						if (287007 - 576060 == -289053)
						{
							this.$nArray$30073 = nArray;
							if (72639 - 310525 == -237886)
							{
								this.$self_$30074 = self_;
								if (155340 - 214341 != -59000)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06003976 RID: 14710 RVA: 0x007867A4 File Offset: 0x007849A4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (14071 - 258574 != -244503)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_4D2;
					case 2:
						if (this.$self_$30074.deadEffect)
						{
							if (7048 - 423095 == -416046)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$30074.deadEffect, this.$self_$30074.transform.position, this.$self_$30074.transform.rotation);
							if (162519 - 341790 != -179271)
							{
								continue;
							}
						}
						else
						{
							Debug.LogError("Missing deadEffect gameObject");
							if (50834 - 509057 == -458222)
							{
								continue;
							}
						}
						if (this.$self_$30074.p549BRiX4B.actionState != "dead")
						{
							if (278697 - 451312 != -172615)
							{
								continue;
							}
							goto IL_49E;
						}
						else
						{
							if (!this.$self_$30074.p549BRiX4B.isPlayer)
							{
								if (293164 - 312395 != -19231)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$30074.gameObject);
								if (203147 - 5340 == 197808)
								{
									continue;
								}
							}
							else if (this.$self_$30074.p549BRiX4B.isMine)
							{
								if (243827 - 408784 != -164957)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$30074.gameObject);
								if (90161 - 62423 != 27738)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (55128 - 532669 != -477541)
							{
								continue;
							}
							goto IL_4D2;
						}
						break;
					default:
						if (196255 - 436544 != -240289)
						{
							continue;
						}
						break;
					}
					if (this.$self_$30074.p549BRiX4B.actionState == "dead")
					{
						if (165416 - 557876 != -392459)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$30071 = (Vector3)this.$nArray$30073[0];
						if (81799 - 579699 != -497899)
						{
							this.$myDirection$30072 = (Vector3)this.$nArray$30073[1];
							if (142075 - 205607 != -63531)
							{
								this.$self_$30074.transform.position = this.$myPosition$30071;
								if (116621 - 591065 != -474443)
								{
									this.$self_$30074.transform.LookAt(this.$myPosition$30071 + this.$myDirection$30072);
									if (86928 - 27683 != 59246)
									{
										this.$self_$30074.p549BRiX4B.hp = 0;
										if (135063 - 204699 != -69635)
										{
											this.$self_$30074.p549BRiX4B.actionState = "dead";
											if (93190 - 123254 != -30063)
											{
												this.$self_$30074.p549BRiX4B.actionTime = Time.time;
												if (194230 - 467932 == -273702)
												{
													this.$self_$30074.p549BRiX4B.myCommand = "none";
													if (92377 - 62437 != 29941)
													{
														this.$self_$30074.p549BRiX4B.vMovement = Vector3.zero;
														if (217349 - 205353 == 11996)
														{
															this.$self_$30074.p549BRiX4B.moveSpeed = (float)0;
															if (161949 - 580372 != -418422)
															{
																this.$self_$30074.animation.Rewind();
																if (76723 - 208205 != -131481)
																{
																	this.$self_$30074.animation.Play("ko");
																	if (241426 - 177170 == 64256)
																	{
																		this.$self_$30074.animation.wrapMode = WrapMode.Once;
																		if (147482 - 341590 == -194108)
																		{
																			goto IL_312;
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_4D2;
				IL_312:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_49E:
				IL_4D2:
				return false;
			}

			// Token: 0x06003977 RID: 14711 RVA: 0x00786C98 File Offset: 0x00784E98
			internal static bool ygk90q5EDC37MIJIJOkK()
			{
				return true;
			}

			// Token: 0x06003978 RID: 14712 RVA: 0x00786C9C File Offset: 0x00784E9C
			internal static bool wqNapK5EvSipjNV2NUeZ()
			{
				return false;
			}

			// Token: 0x040047CC RID: 18380
			internal Vector3 $myPosition$30071;

			// Token: 0x040047CD RID: 18381
			internal Vector3 $myDirection$30072;

			// Token: 0x040047CE RID: 18382
			internal UnityScript.Lang.Array $nArray$30073;

			// Token: 0x040047CF RID: 18383
			internal Funga $self_$30074;
		}
	}
}
