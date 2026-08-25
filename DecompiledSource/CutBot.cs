using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000AC7 RID: 2759
[Serializable]
public class CutBot : MonoBehaviour
{
	// Token: 0x06003CF5 RID: 15605 RVA: 0x007DFB5C File Offset: 0x007DDD5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public CutBot()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06003CF6 RID: 15606 RVA: 0x007DFB6C File Offset: 0x007DDD6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (153202 - 404012 != -250810)
		{
		}
		for (;;)
		{
			this.XjYusoZZqx = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (284096 - 407581 == -123485)
			{
				this.XjYusoZZqx.actionState = "standby";
				if (219826 - 92422 != 127405)
				{
					this.XjYusoZZqx.actionTime = Time.time;
					if (250163 - 454214 == -204051)
					{
						this.XjYusoZZqx.myCommand = "none";
						if (143351 - 239553 == -96202)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06003CF7 RID: 15607 RVA: 0x007DFC58 File Offset: 0x007DDE58
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (Game.mGameType == 99)
		{
			this.XjYusoZZqx.isMine = true;
		}
	}

	// Token: 0x06003CF8 RID: 15608 RVA: 0x007DFC74 File Offset: 0x007DDE74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (72167 - 511868 != -439701)
		{
		}
		for (;;)
		{
			if (this.XjYusoZZqx.isControlled)
			{
				if (250642 - 152934 == 97709)
				{
					continue;
				}
				if (!(this.XjYusoZZqx.actionState == "standby"))
				{
					if (97495 - 325926 != -228431)
					{
						continue;
					}
					if (!(this.XjYusoZZqx.actionState == "run"))
					{
						goto IL_1C3;
					}
					if (130765 - 410714 != -279949)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (8049 - 508712 == -500662)
				{
					continue;
				}
			}
			IL_1C3:
			if (this.XjYusoZZqx.hp <= 0)
			{
				if (246684 - 91244 != 155440)
				{
					continue;
				}
				if (this.XjYusoZZqx.actionState != "dead")
				{
					if (88807 - 338789 != -249982)
					{
						continue;
					}
					if (this.XjYusoZZqx.isMine)
					{
						if (102332 - 221322 != -118990)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (45949 - 542544 != -496595)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (76888 - 469486 != -392598)
						{
							continue;
						}
						this.XjYusoZZqx.DeadEvent();
						if (37171 - 436460 != -399289)
						{
							continue;
						}
						break;
					}
					else
					{
						this.XjYusoZZqx.hp = 1;
						if (106805 - 312174 != -205369)
						{
							continue;
						}
						break;
					}
				}
			}
			if (this.XjYusoZZqx.hp <= 0)
			{
				break;
			}
			if (60378 - 171778 == -111400)
			{
				if (this.XjYusoZZqx.ko > 0)
				{
					break;
				}
				if (235401 - 499935 != -264533)
				{
					if (!(this.XjYusoZZqx.actionState != "ko"))
					{
						break;
					}
					if (9874 - 455243 == -445369)
					{
						if (!(this.XjYusoZZqx.actionState != "dead"))
						{
							break;
						}
						if (299231 - 373849 != -74617)
						{
							if (this.XjYusoZZqx.isMine)
							{
								if (290265 - 473350 == -183085)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (249513 - 410582 != -161068)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (190478 - 111558 == 78920)
										{
											this.XjYusoZZqx.KoEvent();
											if (173068 - 236173 == -63105)
											{
												break;
											}
										}
									}
								}
							}
							else
							{
								this.XjYusoZZqx.ko = 1;
								if (264981 - 28114 == 236867)
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

	// Token: 0x06003CF9 RID: 15609 RVA: 0x007E006C File Offset: 0x007DE26C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (102973 - 36314 != 66659)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (223123 - 70323 != 152801)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (106585 - 497528 == -390943)
				{
					if (214763 - 179086 == 35677)
					{
						if (ActionName == "RPC_nAttack")
						{
							if (287144 - 223234 != 63910)
							{
								continue;
							}
							v = 1;
							if (229396 - 24847 == 204550)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_hit")
						{
							if (130736 - 397815 != -267079)
							{
								continue;
							}
							v = -1;
							if (261025 - 485510 == -224484)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_cAttack")
						{
							if (172545 - 380821 != -208276)
							{
								continue;
							}
							v = 11;
							if (208334 - 474076 == -265741)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (198734 - 81642 != 117092)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (126573 - 276353 == -149780)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (21296 - 256138 == -234842)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (61647 - 161442 != -99794)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (212712 - 207897 != 4816)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (268500 - 183469 != 85032)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (77547 - 187626 == -110079)
											{
												Hashtable hashtable = new Hashtable();
												if (111667 - 285643 != -173975)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (229442 - 480474 != -251031)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (137121 - 538952 != -401830)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (14496 - 257344 != -242847)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (187975 - 212839 != -24863)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (115393 - 594139 != -478745)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (287979 - 205061 == 82918)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (53853 - 127798 != -73944)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (195937 - 96460 == 99477)
																				{
																					PhotonClient.SendEvent(this.XjYusoZZqx.ActorNr, 74, hashtable, true, true);
																					if (266983 - 524036 != -257052)
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

	// Token: 0x06003CFA RID: 15610 RVA: 0x007E0538 File Offset: 0x007DE738
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (176244 - 468966 != -292721)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (13104 - 424997 == -411893)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (248544 - 399334 == -150790)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (59059 - 217369 == -158310)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (132031 - 261826 == -129795)
						{
							int num3 = num;
							if (76923 - 237326 == -160403)
							{
								if (num3 == 1)
								{
									if (193160 - 467273 == -274113)
									{
										if (this.XjYusoZZqx.isMine)
										{
											break;
										}
										if (75488 - 151743 == -76255)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (90866 - 208672 != -117805)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (61523 - 96147 == -34624)
									{
										if (this.XjYusoZZqx.isMine)
										{
											break;
										}
										if (26341 - 83010 != -56668)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (8379 - 454928 != -446548)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (171695 - 376497 == -204802)
									{
										if (this.XjYusoZZqx.isMine)
										{
											break;
										}
										if (150206 - 36166 == 114040)
										{
											this.StartCoroutine_Auto(this.RPC_cAttack(vector, vector2, num2));
											if (230064 - 104609 == 125455)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (274717 - 445166 != -170448)
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

	// Token: 0x06003CFB RID: 15611 RVA: 0x007E0848 File Offset: 0x007DEA48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (198587 - 572090 != -373502)
		{
		}
		for (;;)
		{
			float num = this.XjYusoZZqx.moveSpeed;
			if (161216 - 338754 != -177537)
			{
				float runSpeed = this.XjYusoZZqx.runSpeed;
				if (294529 - 532769 == -238240)
				{
					Vector3 a = default(Vector3);
					if (104969 - 11551 != 93419)
					{
						Vector3 vector = Vector3.zero;
						if (17874 - 450898 != -433023)
						{
							float num2 = (float)0;
							if (35204 - 55708 == -20504)
							{
								if (this.XjYusoZZqx.isMine)
								{
									if (12454 - 150655 != -138201)
									{
										continue;
									}
									if ((this.XjYusoZZqx.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (218230 - 424693 == -206462)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (69415 - 170316 != -100901)
										{
											continue;
										}
										a.y = (float)0;
										if (229382 - 57994 == 171389)
										{
											continue;
										}
										a = a.normalized;
										if (181779 - 417554 == -235774)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (27079 - 298690 == -271610)
										{
											continue;
										}
										vector = vector.normalized;
										if (41158 - 546729 != -505571)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (63886 - 554548 == -490661)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (235809 - 520907 == -285097)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (160530 - 324679 != -164149)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (231420 - 410270 == -178849)
														{
															continue;
														}
														this.XjYusoZZqx.actionState = "run";
														if (106586 - 174724 == -68137)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (34676 - 539256 != -504580)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (194191 - 6356 != 187835)
														{
															continue;
														}
														this.animation.Play("run");
														if (117975 - 257206 == -139230)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (197835 - 406816 != -208981)
														{
															continue;
														}
														goto IL_38C;
													}
												}
											}
										}
										this.XjYusoZZqx.actionState = "standby";
										if (278651 - 475185 == -196533)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (246899 - 294118 != -47219)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (158219 - 497893 == -339673)
											{
												continue;
											}
											num = (float)0;
											if (299740 - 235432 == 64309)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (186726 - 211619 != -24893)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (117994 - 159275 != -41281)
										{
											continue;
										}
									}
									IL_38C:;
								}
								else
								{
									vector = global::Math.vFlat(this.XjYusoZZqx.nPosition - this.transform.position);
									if (62854 - 494565 == -431710)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (80012 - 241248 == -161235)
									{
										continue;
									}
									if (this.XjYusoZZqx.nSpeed != (float)0)
									{
										if (238617 - 435789 != -197172)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (165092 - 413466 != -248374)
											{
												continue;
											}
											this.transform.position = this.XjYusoZZqx.nPosition;
											if (297344 - 280089 == 17256)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (100653 - 276650 != -175997)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (202678 - 506587 == -303908)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (233356 - 576307 != -342951)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.XjYusoZZqx.nSpeed, (float)10 * Time.deltaTime);
												if (224857 - 268788 == -43930)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (168201 - 127509 != 40692)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (167379 - 153174 == 14206)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (264710 - 474391 == -209680)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (256234 - 104898 == 151337)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (76658 - 380485 != -303827)
											{
												continue;
											}
										}
										else if (Time.time > this.XjYusoZZqx.nSpeed + 0.3f)
										{
											if (94694 - 150917 != -56223)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (269585 - 463822 == -194236)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (80478 - 595030 != -514552)
												{
													continue;
												}
												num = (float)0;
												if (33755 - 146592 == -112836)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.XjYusoZZqx.nDirection);
											if (93541 - 142189 != -48648)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (217755 - 236758 == -19002)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (255132 - 552988 == -297855)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (294011 - 356233 != -62222)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (216999 - 216025 != 974)
											{
												continue;
											}
											this.transform.position = this.XjYusoZZqx.nPosition;
											if (90063 - 353122 == -263058)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (299095 - 243393 != 55702)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (91946 - 233922 != -141976)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (100993 - 430067 != -329074)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (210635 - 353042 != -142407)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (238344 - 321590 != -83246)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (78301 - 340618 == -262316)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (89807 - 313403 != -223596)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.XjYusoZZqx.nDirection);
											if (283910 - 401654 != -117744)
											{
												continue;
											}
											num = (float)0;
											if (248593 - 32908 != 215685)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (82274 - 307280 == -225005)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (91137 - 380842 != -289705)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (288458 - 338146 != -49688)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (6113 - 468213 != -462100)
										{
											continue;
										}
									}
								}
								this.XjYusoZZqx.vMovement = vector;
								if (227573 - 292528 != -64954)
								{
									this.XjYusoZZqx.moveSpeed = num;
									if (37395 - 181197 == -143802)
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

	// Token: 0x06003CFC RID: 15612 RVA: 0x007E13AC File Offset: 0x007DF5AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (266415 - 510058 != -243642)
		{
		}
		for (;;)
		{
			if (!this.XjYusoZZqx.isMine)
			{
				if (208657 - 546082 == -337425)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (24244 - 468782 != -444537)
				{
					Vector3 vector = a - this.transform.position;
					if (137721 - 534209 == -396488)
					{
						Vector3 normalized = vector.normalized;
						if (280879 - 426339 != -145459)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (213448 - 78915 != 134534)
							{
								if (140140 - 537039 == -396899)
								{
									if (gameObject)
									{
										if (158355 - 154066 != 4289)
										{
											continue;
										}
										CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (181129 - 50590 != 130539)
										{
											continue;
										}
									}
									if (!(this.XjYusoZZqx.actionState == "standby"))
									{
										if (102661 - 185253 != -82592)
										{
											continue;
										}
										if (!(this.XjYusoZZqx.actionState == "run"))
										{
											break;
										}
										if (175959 - 47061 != 128898)
										{
											continue;
										}
									}
									if (this.XjYusoZZqx.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (104975 - 583512 != -478536)
									{
										this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, normalized, 0));
										if (123879 - 343183 != -219303)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (299081 - 133880 == 165201)
											{
												this.ActionEvent("RPC_nAttack", this.transform.position, normalized, 0);
												if (71437 - 282821 == -211384)
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

	// Token: 0x06003CFD RID: 15613 RVA: 0x007E1664 File Offset: 0x007DF864
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (124096 - 265742 != -141645)
		{
		}
		for (;;)
		{
			if (!this.XjYusoZZqx.isMine)
			{
				if (31035 - 208548 == -177513)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (43378 - 527760 != -484381)
				{
					Vector3 vector = a - this.transform.position;
					if (142480 - 292987 != -150506)
					{
						Vector3 normalized = vector.normalized;
						if (287234 - 92968 == 194266)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (249229 - 587717 != -338487)
							{
								if (172900 - 109087 == 63813)
								{
									if (gameObject)
									{
										if (286289 - 112812 != 173477)
										{
											continue;
										}
										CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (74435 - 403394 == -328958)
										{
											continue;
										}
									}
									if (!(this.XjYusoZZqx.actionState == "standby"))
									{
										if (139000 - 255266 != -116266)
										{
											continue;
										}
										if (!(this.XjYusoZZqx.actionState == "run"))
										{
											break;
										}
										if (24518 - 326335 == -301816)
										{
											continue;
										}
									}
									if (this.XjYusoZZqx.isTimeOut("cAttack") != (float)0)
									{
										break;
									}
									if (64978 - 157736 == -92758)
									{
										this.StartCoroutine_Auto(this.RPC_cAttack(this.transform.position, normalized, 0));
										if (267415 - 160973 != 106443)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (14855 - 241143 != -226287)
											{
												this.ActionEvent("RPC_cAttack", this.transform.position, normalized, 0);
												if (146140 - 60368 != 85773)
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

	// Token: 0x06003CFE RID: 15614 RVA: 0x007E191C File Offset: 0x007DFB1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06003CFF RID: 15615 RVA: 0x007E1920 File Offset: 0x007DFB20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new CutBot.$RPC_nAttack$30581(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06003D00 RID: 15616 RVA: 0x007E1930 File Offset: 0x007DFB30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (95084 - 580268 != -485184)
		{
		}
		for (;;)
		{
			if (this.nAttack_hit)
			{
				if (20277 - 211774 == -191496)
				{
					continue;
				}
				UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, Quaternion.LookRotation(hitDir));
				if (45204 - 212580 == -167375)
				{
					continue;
				}
			}
			else
			{
				Debug.LogError("Missing nAttack_hit effect");
				if (174545 - 99574 != 74971)
				{
					continue;
				}
			}
			if (this.V1xuHrLqP0 >= Time.time)
			{
				break;
			}
			if (193295 - 449943 == -256648)
			{
				this.V1xuHrLqP0 = Time.time + 0.1f;
				if (108316 - 248246 != -139929)
				{
					if (!this.nAttack_hitFx)
					{
						break;
					}
					if (83720 - 251112 != -167391)
					{
						this.audio.PlayOneShot(this.nAttack_hitFx);
						if (106287 - 349481 != -243193)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06003D01 RID: 15617 RVA: 0x007E1A94 File Offset: 0x007DFC94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_cAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new CutBot.$RPC_cAttack$30595(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06003D02 RID: 15618 RVA: 0x007E1AA4 File Offset: 0x007DFCA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new CutBot.$RPC_ko$30608(nArray, this).GetEnumerator();
	}

	// Token: 0x06003D03 RID: 15619 RVA: 0x007E1AB4 File Offset: 0x007DFCB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new CutBot.$RPC_dead$30615(nArray, this).GetEnumerator();
	}

	// Token: 0x06003D04 RID: 15620 RVA: 0x007E1AC4 File Offset: 0x007DFCC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06003D05 RID: 15621 RVA: 0x007E1AC8 File Offset: 0x007DFCC8
	internal static bool YZoecY5CzmHGwrdQfoWJ()
	{
		return true;
	}

	// Token: 0x06003D06 RID: 15622 RVA: 0x007E1ACC File Offset: 0x007DFCCC
	internal static bool t3T58q5Law5fwV5C6LBW()
	{
		return false;
	}

	// Token: 0x04004A54 RID: 19028
	private CharacterControl XjYusoZZqx;

	// Token: 0x04004A55 RID: 19029
	public GameObject nAttack_ring;

	// Token: 0x04004A56 RID: 19030
	public GameObject nAttack_hit;

	// Token: 0x04004A57 RID: 19031
	public AudioClip nAttack_hitFx;

	// Token: 0x04004A58 RID: 19032
	private float V1xuHrLqP0;

	// Token: 0x04004A59 RID: 19033
	public GameObject deadEffect;

	// Token: 0x02000AC8 RID: 2760
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$30581 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003D07 RID: 15623 RVA: 0x007E1AD0 File Offset: 0x007DFCD0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$30581(Vector3 mPos, Vector3 tDir, CutBot self_)
		{
			if (156026 - 427533 != -271507)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (217596 - 71272 != 146325)
				{
					base..ctor();
					if (241124 - 5895 == 235229)
					{
						this.$mPos$30592 = mPos;
						if (24332 - 482145 != -457812)
						{
							this.$tDir$30593 = tDir;
							if (272578 - 528071 == -255493)
							{
								this.$self_$30594 = self_;
								if (191525 - 315172 == -123647)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06003D08 RID: 15624 RVA: 0x007E1BAC File Offset: 0x007DFDAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new CutBot.$RPC_nAttack$30581.$(this.$mPos$30592, this.$tDir$30593, this.$self_$30594);
		}

		// Token: 0x06003D09 RID: 15625 RVA: 0x007E1BC8 File Offset: 0x007DFDC8
		internal static bool ookcmR5L5ne8BdlWHvCP()
		{
			return true;
		}

		// Token: 0x06003D0A RID: 15626 RVA: 0x007E1BCC File Offset: 0x007DFDCC
		internal static bool n1I3df5LpTV8IlYCgkLH()
		{
			return false;
		}

		// Token: 0x04004A5A RID: 19034
		internal Vector3 $mPos$30592;

		// Token: 0x04004A5B RID: 19035
		internal Vector3 $tDir$30593;

		// Token: 0x04004A5C RID: 19036
		internal CutBot $self_$30594;

		// Token: 0x02000AC9 RID: 2761
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003D0B RID: 15627 RVA: 0x007E1BD0 File Offset: 0x007DFDD0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, CutBot self_)
			{
				if (124490 - 229622 != -105132)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (288666 - 168275 == 120391)
					{
						base..ctor();
						if (147406 - 99248 == 48158)
						{
							this.$mPos$30589 = mPos;
							if (216592 - 334913 != -118320)
							{
								this.$tDir$30590 = tDir;
								if (9010 - 87092 != -78081)
								{
									this.$self_$30591 = self_;
									if (228541 - 166789 == 61752)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06003D0C RID: 15628 RVA: 0x007E1CAC File Offset: 0x007DFEAC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (69033 - 210675 != -141641)
				{
				}
				for (;;)
				{
					IL_A21:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_D0A;
					case 2:
						if (this.$self_$30591.XjYusoZZqx.actionState != "attack")
						{
							goto IL_639;
						}
						if (25251 - 470043 == -444791)
						{
							continue;
						}
						if (this.$self_$30591.XjYusoZZqx.myCommand != "nAttack")
						{
							if (55037 - 212536 != -157499)
							{
								continue;
							}
							goto IL_639;
						}
						else
						{
							this.$hitLayer$30582 = 130816 - (1 << this.$self_$30591.gameObject.layer);
							if (148017 - 546681 != -398664)
							{
								continue;
							}
							this.$hitList$30583 = null;
							if (103138 - 191395 != -88257)
							{
								continue;
							}
							this.$hitPos$30584 = default(Vector3);
							if (27036 - 201695 != -174659)
							{
								continue;
							}
							if (!this.$self_$30591.XjYusoZZqx.isMine)
							{
								goto IL_5BA;
							}
							if (8022 - 305385 == -297362)
							{
								continue;
							}
							this.$hitList$30583 = Damage.FindRecTarget(this.$self_$30591.transform.position, this.$self_$30591.transform.forward, (float)1 * this.$self_$30591.XjYusoZZqx.rangeMod, (float)1 * this.$self_$30591.XjYusoZZqx.rangeMod, (float)6 * this.$self_$30591.XjYusoZZqx.rangeMod, (float)2 * this.$self_$30591.XjYusoZZqx.rangeMod, this.$hitLayer$30582);
							if (265873 - 92390 != 173483)
							{
								continue;
							}
							this.$$iterator$10628$30586 = UnityRuntimeServices.GetEnumerator(this.$hitList$30583);
							if (20467 - 573369 != -552902)
							{
								continue;
							}
							while (this.$$iterator$10628$30586.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10628$30586.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$30585 = (GameObject)obj2;
								if (192531 - 28967 != 163564)
								{
									goto IL_A21;
								}
								if (this.$self_$30591.XjYusoZZqx.hit(1, this.$hitObject$30585, (int)(0.5f * (float)this.$self_$30591.XjYusoZZqx.atk), 1, 0, 0.5f * (this.$hitObject$30585.transform.position - this.$self_$30591.transform.position).normalized) != 0)
								{
									if (99786 - 396527 != -296741)
									{
										goto IL_A21;
									}
									this.$hitPos$30584 = this.$hitObject$30585.collider.ClosestPointOnBounds(this.$self_$30591.transform.position + Vector3.up);
									if (132961 - 41097 == 91865)
									{
										goto IL_A21;
									}
									UnityRuntimeServices.Update(this.$$iterator$10628$30586, this.$hitObject$30585);
									if (82756 - 357385 != -274629)
									{
										goto IL_A21;
									}
									this.$self_$30591.RPC_nAttack_hit(this.$hitPos$30584, this.$self_$30591.transform.forward, 0);
									if (50179 - 372947 != -322768)
									{
										goto IL_A21;
									}
									this.$self_$30591.ActionEvent("RPC_nAttack_hit", this.$hitPos$30584, global::Math.vFlat(this.$hitPos$30584 - this.$self_$30591.transform.position).normalized, 0);
									if (78779 - 542570 != -463791)
									{
										goto IL_A21;
									}
									this.$self_$30591.XjYusoZZqx.sp = this.$self_$30591.XjYusoZZqx.sp + 1;
									if (214284 - 133941 != 80343)
									{
										goto IL_A21;
									}
								}
							}
							if (172051 - 592828 != -420776)
							{
								goto Block_27;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$30591.XjYusoZZqx.actionState != "attack")
						{
							goto IL_72B;
						}
						if (212425 - 411439 != -199014)
						{
							continue;
						}
						if (this.$self_$30591.XjYusoZZqx.myCommand != "nAttack")
						{
							if (30926 - 317671 != -286745)
							{
								continue;
							}
							goto IL_72B;
						}
						else
						{
							if (!this.$self_$30591.XjYusoZZqx.isMine)
							{
								goto IL_17D;
							}
							if (52852 - 94454 == -41601)
							{
								continue;
							}
							this.$hitList$30583 = Damage.FindRecTarget(this.$self_$30591.transform.position, this.$self_$30591.transform.forward, (float)3 * this.$self_$30591.XjYusoZZqx.rangeMod, (float)3 * this.$self_$30591.XjYusoZZqx.rangeMod, (float)6 * this.$self_$30591.XjYusoZZqx.rangeMod, (float)2 * this.$self_$30591.XjYusoZZqx.rangeMod, this.$hitLayer$30582);
							if (133831 - 337994 != -204163)
							{
								continue;
							}
							this.$$iterator$10629$30588 = UnityRuntimeServices.GetEnumerator(this.$hitList$30583);
							if (81029 - 396326 != -315297)
							{
								continue;
							}
							while (this.$$iterator$10629$30588.MoveNext())
							{
								object obj4;
								object obj3 = obj4 = this.$$iterator$10629$30588.Current;
								if (!(obj3 is GameObject))
								{
									obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
								}
								this.$hitObject$30587 = (GameObject)obj4;
								if (265101 - 335011 != -69910)
								{
									goto IL_A21;
								}
								if (this.$self_$30591.XjYusoZZqx.hit(1, this.$hitObject$30587, (int)(0.5f * (float)this.$self_$30591.XjYusoZZqx.atk), 1, 0, 0.5f * (this.$hitObject$30587.transform.position - this.$self_$30591.transform.position).normalized) != 0)
								{
									if (271787 - 462083 != -190296)
									{
										goto IL_A21;
									}
									this.$hitPos$30584 = this.$hitObject$30587.collider.ClosestPointOnBounds(this.$self_$30591.transform.position + Vector3.up);
									if (38823 - 376542 != -337719)
									{
										goto IL_A21;
									}
									UnityRuntimeServices.Update(this.$$iterator$10629$30588, this.$hitObject$30587);
									if (265899 - 474233 == -208333)
									{
										goto IL_A21;
									}
									this.$self_$30591.RPC_nAttack_hit(this.$hitPos$30584, this.$self_$30591.transform.forward, 0);
									if (133009 - 392565 == -259555)
									{
										goto IL_A21;
									}
									this.$self_$30591.ActionEvent("RPC_nAttack_hit", this.$hitPos$30584, global::Math.vFlat(this.$hitPos$30584 - this.$self_$30591.transform.position).normalized, 0);
									if (205689 - 515740 != -310051)
									{
										goto IL_A21;
									}
									this.$self_$30591.XjYusoZZqx.sp = this.$self_$30591.XjYusoZZqx.sp + 1;
									if (123727 - 554196 != -430469)
									{
										goto IL_A21;
									}
								}
							}
							if (167915 - 150179 != 17737)
							{
								goto Block_64;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$30591.XjYusoZZqx.actionState == "attack")
						{
							if (141450 - 436350 == -294899)
							{
								continue;
							}
							if (this.$self_$30591.XjYusoZZqx.myCommand == "nAttack")
							{
								if (110442 - 310782 == -200339)
								{
									continue;
								}
								this.$self_$30591.XjYusoZZqx.actionState = "standby";
								if (197261 - 5263 == 191999)
								{
									continue;
								}
								this.$self_$30591.XjYusoZZqx.actionTime = Time.time;
								if (294161 - 566201 == -272039)
								{
									continue;
								}
								this.$self_$30591.XjYusoZZqx.myCommand = "none";
								if (52470 - 570894 == -518423)
								{
									continue;
								}
								if (!this.$self_$30591.XjYusoZZqx.isMine)
								{
									if (158165 - 356513 != -198348)
									{
										continue;
									}
									this.$self_$30591.XjYusoZZqx.nPosition = this.$self_$30591.transform.position;
									if (156323 - 448771 != -292448)
									{
										continue;
									}
									this.$self_$30591.XjYusoZZqx.oPosition = this.$self_$30591.transform.position;
									if (37292 - 414693 != -377401)
									{
										continue;
									}
									this.$self_$30591.XjYusoZZqx.nDirection = this.$self_$30591.transform.forward;
									if (260440 - 200182 != 60258)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (185960 - 414404 != -228444)
						{
							continue;
						}
						goto IL_D0A;
					default:
						if (117150 - 68325 == 48826)
						{
							continue;
						}
						break;
					}
					this.$self_$30591.XjYusoZZqx.actionState = "attack";
					if (149473 - 517568 != -368094)
					{
						this.$self_$30591.XjYusoZZqx.actionTime = Time.time;
						if (79328 - 215334 == -136006)
						{
							this.$self_$30591.XjYusoZZqx.myCommand = "nAttack";
							if (75819 - 334532 != -258712)
							{
								this.$self_$30591.XjYusoZZqx.addTimeOut("nAttack", (float)2);
								if (217684 - 228061 == -10377)
								{
									this.$self_$30591.transform.position = this.$mPos$30589;
									if (26312 - 378175 != -351862)
									{
										this.$self_$30591.transform.LookAt(this.$mPos$30589 + global::Math.vFlat(this.$tDir$30590));
										if (283025 - 282458 == 567)
										{
											this.$self_$30591.animation.CrossFade("nAttack");
											if (115983 - 328229 != -212245)
											{
												this.$self_$30591.animation.wrapMode = WrapMode.Once;
												if (172947 - 135683 == 37264)
												{
													this.$self_$30591.XjYusoZZqx.vMovement = this.$self_$30591.transform.forward;
													if (150781 - 425424 == -274643)
													{
														this.$self_$30591.XjYusoZZqx.moveSpeed = (float)0;
														if (117244 - 414163 == -296919)
														{
															if (this.$self_$30591.nAttack_ring)
															{
																if (10225 - 35780 != -25554)
																{
																	this.$self_$30591.XjYusoZZqx.createEffect(this.$self_$30591.nAttack_ring, this.$self_$30591.transform.position, this.$self_$30591.transform.rotation);
																	if (227010 - 12510 != 214501)
																	{
																		break;
																	}
																}
															}
															else
															{
																Debug.LogError("Missing nAttack_ring effect");
																if (261329 - 389598 != -128268)
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
				goto IL_7D7;
				IL_17D:
				return this.Yield(4, new WaitForSeconds(0.8f));
				Block_27:
				IL_5BA:
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_639:
				IL_72B:
				goto IL_D0A;
				IL_7D7:
				return this.Yield(2, new WaitForSeconds(0.8f));
				Block_64:
				goto IL_17D;
				IL_D0A:
				return false;
			}

			// Token: 0x06003D0D RID: 15629 RVA: 0x007E29D8 File Offset: 0x007E0BD8
			internal static bool PbyiPc5LVO7s6Fm8iIUk()
			{
				return true;
			}

			// Token: 0x06003D0E RID: 15630 RVA: 0x007E29DC File Offset: 0x007E0BDC
			internal static bool U81eur5LtdjepVVkt3EV()
			{
				return false;
			}

			// Token: 0x04004A5D RID: 19037
			internal int $hitLayer$30582;

			// Token: 0x04004A5E RID: 19038
			internal UnityScript.Lang.Array $hitList$30583;

			// Token: 0x04004A5F RID: 19039
			internal Vector3 $hitPos$30584;

			// Token: 0x04004A60 RID: 19040
			internal GameObject $hitObject$30585;

			// Token: 0x04004A61 RID: 19041
			internal IEnumerator $$iterator$10628$30586;

			// Token: 0x04004A62 RID: 19042
			internal GameObject $hitObject$30587;

			// Token: 0x04004A63 RID: 19043
			internal IEnumerator $$iterator$10629$30588;

			// Token: 0x04004A64 RID: 19044
			internal Vector3 $mPos$30589;

			// Token: 0x04004A65 RID: 19045
			internal Vector3 $tDir$30590;

			// Token: 0x04004A66 RID: 19046
			internal CutBot $self_$30591;
		}
	}

	// Token: 0x02000ACA RID: 2762
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_cAttack$30595 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003D0F RID: 15631 RVA: 0x007E29E0 File Offset: 0x007E0BE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_cAttack$30595(Vector3 mPos, Vector3 tDir, CutBot self_)
		{
			if (55911 - 514691 != -458779)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (104681 - 464780 == -360099)
				{
					base..ctor();
					if (67483 - 599277 == -531794)
					{
						this.$mPos$30605 = mPos;
						if (65269 - 448014 != -382744)
						{
							this.$tDir$30606 = tDir;
							if (204178 - 23294 == 180884)
							{
								this.$self_$30607 = self_;
								if (60692 - 150386 == -89694)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06003D10 RID: 15632 RVA: 0x007E2ABC File Offset: 0x007E0CBC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new CutBot.$RPC_cAttack$30595.$(this.$mPos$30605, this.$tDir$30606, this.$self_$30607);
		}

		// Token: 0x06003D11 RID: 15633 RVA: 0x007E2AD8 File Offset: 0x007E0CD8
		internal static bool u0MAom5LNcE5CbAORerS()
		{
			return true;
		}

		// Token: 0x06003D12 RID: 15634 RVA: 0x007E2ADC File Offset: 0x007E0CDC
		internal static bool KbE51F5LYP4TVe4iuslj()
		{
			return false;
		}

		// Token: 0x04004A67 RID: 19047
		internal Vector3 $mPos$30605;

		// Token: 0x04004A68 RID: 19048
		internal Vector3 $tDir$30606;

		// Token: 0x04004A69 RID: 19049
		internal CutBot $self_$30607;

		// Token: 0x02000ACB RID: 2763
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003D13 RID: 15635 RVA: 0x007E2AE0 File Offset: 0x007E0CE0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, CutBot self_)
			{
				if (60225 - 299908 != -239683)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (3590 - 43468 == -39878)
					{
						base..ctor();
						if (287011 - 273363 == 13648)
						{
							this.$mPos$30602 = mPos;
							if (75312 - 527062 != -451749)
							{
								this.$tDir$30603 = tDir;
								if (288214 - 353029 == -64815)
								{
									this.$self_$30604 = self_;
									if (159832 - 577622 != -417789)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06003D14 RID: 15636 RVA: 0x007E2BBC File Offset: 0x007E0DBC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (232279 - 450536 != -218257)
				{
				}
				for (;;)
				{
					IL_944:
					switch (this._state)
					{
					case 0:
						goto IL_9DF;
					case 1:
						goto IL_A0E;
					case 2:
						if (this.$self_$30604.XjYusoZZqx.actionState != "attack")
						{
							goto IL_796;
						}
						if (91736 - 99983 != -8247)
						{
							continue;
						}
						if (this.$self_$30604.XjYusoZZqx.myCommand != "cAttack")
						{
							if (247373 - 519771 != -272397)
							{
								goto Block_49;
							}
							continue;
						}
						else
						{
							this.$self_$30604.XjYusoZZqx.moveSpeed = (float)5;
							if (272690 - 317810 != -45120)
							{
								continue;
							}
							this.$i$30596 = 0;
							if (58595 - 175914 == -117318)
							{
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$30604.XjYusoZZqx.actionState != "attack")
						{
							goto IL_762;
						}
						if (228607 - 571212 == -342604)
						{
							continue;
						}
						if (this.$self_$30604.XjYusoZZqx.myCommand != "cAttack")
						{
							if (193425 - 466706 != -273281)
							{
								continue;
							}
							goto IL_762;
						}
						else
						{
							if (this.$self_$30604.XjYusoZZqx.isMine)
							{
								if (208770 - 233906 != -25136)
								{
									continue;
								}
								this.$hitLayer$30597 = 130816 - (1 << this.$self_$30604.gameObject.layer);
								if (44868 - 378564 != -333696)
								{
									continue;
								}
								this.$hitList$30598 = Damage.FindAreaTarget(this.$self_$30604.transform.position, (float)(2 + this.$i$30596 * 2) * this.$self_$30604.XjYusoZZqx.rangeMod, (float)2 * this.$self_$30604.XjYusoZZqx.rangeMod, this.$hitLayer$30597);
								if (119878 - 32204 != 87674)
								{
									continue;
								}
								this.$$iterator$10630$30601 = UnityRuntimeServices.GetEnumerator(this.$hitList$30598);
								if (241990 - 577289 != -335299)
								{
									continue;
								}
								while (this.$$iterator$10630$30601.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$10630$30601.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$30599 = (GameObject)obj2;
									if (25909 - 88446 == -62536)
									{
										goto IL_944;
									}
									if (this.$self_$30604.XjYusoZZqx.hit(1, this.$hitObject$30599, (int)(0.65f * (float)this.$self_$30604.XjYusoZZqx.atk), 1, 0, 0.5f * (this.$hitObject$30599.transform.position - this.$self_$30604.transform.position).normalized) != 0)
									{
										if (181046 - 253589 != -72543)
										{
											goto IL_944;
										}
										this.$hitPos$30600 = this.$hitObject$30599.collider.ClosestPointOnBounds(this.$self_$30604.transform.position + Vector3.up);
										if (156115 - 560623 != -404508)
										{
											goto IL_944;
										}
										UnityRuntimeServices.Update(this.$$iterator$10630$30601, this.$hitObject$30599);
										if (201418 - 337985 == -136566)
										{
											goto IL_944;
										}
										this.$self_$30604.RPC_nAttack_hit(this.$hitPos$30600, this.$self_$30604.transform.forward, 0);
										if (244497 - 296949 != -52452)
										{
											goto IL_944;
										}
										this.$self_$30604.ActionEvent("RPC_nAttack_hit", this.$hitPos$30600, global::Math.vFlat(this.$hitPos$30600 - this.$self_$30604.transform.position).normalized, 0);
										if (195319 - 260607 == -65287)
										{
											goto IL_944;
										}
										this.$self_$30604.XjYusoZZqx.sp = this.$self_$30604.XjYusoZZqx.sp + 1;
										if (152069 - 164293 != -12224)
										{
											goto IL_944;
										}
									}
								}
								if (48072 - 323051 != -274979)
								{
									continue;
								}
							}
							this.$i$30596++;
							if (288906 - 568469 == -279562)
							{
								continue;
							}
						}
						break;
					case 4:
						if (this.$self_$30604.XjYusoZZqx.actionState != "attack")
						{
							goto IL_2D7;
						}
						if (276532 - 369716 == -93183)
						{
							continue;
						}
						if (this.$self_$30604.XjYusoZZqx.myCommand != "cAttack")
						{
							if (201198 - 325407 != -124208)
							{
								goto Block_54;
							}
							continue;
						}
						else
						{
							this.$self_$30604.XjYusoZZqx.moveSpeed = (float)0;
							if (139344 - 221739 != -82395)
							{
								continue;
							}
							goto IL_487;
						}
						break;
					case 5:
						if (this.$self_$30604.XjYusoZZqx.actionState == "attack")
						{
							if (209760 - 314927 == -105166)
							{
								continue;
							}
							if (this.$self_$30604.XjYusoZZqx.myCommand == "cAttack")
							{
								if (266361 - 389942 == -123580)
								{
									continue;
								}
								this.$self_$30604.XjYusoZZqx.actionState = "standby";
								if (14051 - 421082 != -407031)
								{
									continue;
								}
								this.$self_$30604.XjYusoZZqx.actionTime = Time.time;
								if (123621 - 334416 == -210794)
								{
									continue;
								}
								this.$self_$30604.XjYusoZZqx.myCommand = "none";
								if (138024 - 564121 == -426096)
								{
									continue;
								}
								if (!this.$self_$30604.XjYusoZZqx.isMine)
								{
									if (204304 - 536224 == -331919)
									{
										continue;
									}
									this.$self_$30604.XjYusoZZqx.nPosition = this.$self_$30604.transform.position;
									if (228720 - 512708 != -283988)
									{
										continue;
									}
									this.$self_$30604.XjYusoZZqx.oPosition = this.$self_$30604.transform.position;
									if (146883 - 508824 == -361940)
									{
										continue;
									}
									this.$self_$30604.XjYusoZZqx.nDirection = this.$self_$30604.transform.forward;
									if (299627 - 138392 == 161236)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (92136 - 460449 != -368312)
						{
							goto Block_33;
						}
						continue;
					default:
						if (103877 - 108991 != -5113)
						{
							goto IL_9DF;
						}
						continue;
					}
					if (this.$i$30596 < 2)
					{
						goto IL_52C;
					}
					if (110034 - 559906 != -449872)
					{
						continue;
					}
					break;
					IL_9DF:
					this.$self_$30604.XjYusoZZqx.actionState = "attack";
					if (197566 - 493631 != -296064)
					{
						this.$self_$30604.XjYusoZZqx.actionTime = Time.time;
						if (8999 - 54439 == -45440)
						{
							this.$self_$30604.XjYusoZZqx.myCommand = "cAttack";
							if (237521 - 382841 != -145319)
							{
								this.$self_$30604.XjYusoZZqx.addTimeOut("cAttack", (float)6);
								if (259777 - 254928 != 4850)
								{
									this.$self_$30604.transform.position = this.$mPos$30602;
									if (211474 - 7673 != 203802)
									{
										this.$self_$30604.transform.LookAt(this.$mPos$30602 + global::Math.vFlat(this.$tDir$30603));
										if (56793 - 112367 != -55573)
										{
											this.$self_$30604.animation.CrossFade("cAttack");
											if (97940 - 499641 != -401700)
											{
												this.$self_$30604.animation.wrapMode = WrapMode.Once;
												if (284579 - 137825 != 146755)
												{
													this.$self_$30604.XjYusoZZqx.vMovement = this.$self_$30604.transform.forward;
													if (294479 - 418269 == -123790)
													{
														this.$self_$30604.XjYusoZZqx.moveSpeed = (float)0;
														if (146205 - 504953 == -358748)
														{
															goto IL_7C7;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				return this.Yield(4, new WaitForSeconds(0.2f));
				IL_2D7:
				goto IL_A0E;
				IL_487:
				return this.Yield(5, new WaitForSeconds(0.2f));
				IL_52C:
				return this.Yield(3, new WaitForSeconds(0.2f));
				Block_33:
				IL_762:
				IL_796:
				goto IL_A0E;
				IL_7C7:
				return this.Yield(2, new WaitForSeconds(0.4f));
				Block_49:
				Block_54:
				IL_A0E:
				return false;
			}

			// Token: 0x06003D15 RID: 15637 RVA: 0x007E35EC File Offset: 0x007E17EC
			internal static bool DKdOZe5Lc0b0dHZD3khb()
			{
				return true;
			}

			// Token: 0x06003D16 RID: 15638 RVA: 0x007E35F0 File Offset: 0x007E17F0
			internal static bool l9ii2P5LUSdQHFEbBhuj()
			{
				return false;
			}

			// Token: 0x04004A6A RID: 19050
			internal int $i$30596;

			// Token: 0x04004A6B RID: 19051
			internal int $hitLayer$30597;

			// Token: 0x04004A6C RID: 19052
			internal UnityScript.Lang.Array $hitList$30598;

			// Token: 0x04004A6D RID: 19053
			internal GameObject $hitObject$30599;

			// Token: 0x04004A6E RID: 19054
			internal Vector3 $hitPos$30600;

			// Token: 0x04004A6F RID: 19055
			internal IEnumerator $$iterator$10630$30601;

			// Token: 0x04004A70 RID: 19056
			internal Vector3 $mPos$30602;

			// Token: 0x04004A71 RID: 19057
			internal Vector3 $tDir$30603;

			// Token: 0x04004A72 RID: 19058
			internal CutBot $self_$30604;
		}
	}

	// Token: 0x02000ACC RID: 2764
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$30608 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003D17 RID: 15639 RVA: 0x007E35F4 File Offset: 0x007E17F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$30608(UnityScript.Lang.Array nArray, CutBot self_)
		{
			if (204590 - 415506 != -210915)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (143090 - 283207 == -140117)
				{
					base..ctor();
					if (169168 - 131495 == 37673)
					{
						this.$nArray$30613 = nArray;
						if (212357 - 598954 == -386597)
						{
							this.$self_$30614 = self_;
							if (264635 - 536353 != -271717)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06003D18 RID: 15640 RVA: 0x007E36B0 File Offset: 0x007E18B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new CutBot.$RPC_ko$30608.$(this.$nArray$30613, this.$self_$30614);
		}

		// Token: 0x06003D19 RID: 15641 RVA: 0x007E36C4 File Offset: 0x007E18C4
		internal static bool M3nkQr5LTm9YmIMBMgnc()
		{
			return true;
		}

		// Token: 0x06003D1A RID: 15642 RVA: 0x007E36C8 File Offset: 0x007E18C8
		internal static bool yk92K55L3wEciCsnTeLI()
		{
			return false;
		}

		// Token: 0x04004A73 RID: 19059
		internal UnityScript.Lang.Array $nArray$30613;

		// Token: 0x04004A74 RID: 19060
		internal CutBot $self_$30614;

		// Token: 0x02000ACD RID: 2765
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003D1B RID: 15643 RVA: 0x007E36CC File Offset: 0x007E18CC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, CutBot self_)
			{
				if (233257 - 312038 != -78780)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (36816 - 315064 == -278248)
					{
						base..ctor();
						if (290953 - 421835 != -130881)
						{
							this.$nArray$30611 = nArray;
							if (122235 - 409621 != -287385)
							{
								this.$self_$30612 = self_;
								if (56187 - 113986 == -57799)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06003D1C RID: 15644 RVA: 0x007E3788 File Offset: 0x007E1988
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (260375 - 375127 != -114751)
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
						if (this.$self_$30612.XjYusoZZqx.actionState != "ko")
						{
							if (154926 - 506176 != -351249)
							{
								goto Block_8;
							}
							continue;
						}
						else
						{
							this.$self_$30612.animation.Play("getUp");
							if (151212 - 385894 == -234681)
							{
								continue;
							}
							this.$self_$30612.animation.wrapMode = WrapMode.Once;
							if (116334 - 386806 != -270472)
							{
								continue;
							}
							goto IL_B1;
						}
						break;
					case 3:
						if (this.$self_$30612.XjYusoZZqx.actionState != "ko")
						{
							if (15941 - 158751 != -142809)
							{
								goto Block_6;
							}
							continue;
						}
						else
						{
							this.$self_$30612.XjYusoZZqx.actionState = "standby";
							if (129367 - 428039 != -298672)
							{
								continue;
							}
							this.$self_$30612.XjYusoZZqx.actionTime = Time.time;
							if (271486 - 410229 == -138742)
							{
								continue;
							}
							this.$self_$30612.XjYusoZZqx.myCommand = "none";
							if (242494 - 266278 == -23783)
							{
								continue;
							}
							this.$self_$30612.XjYusoZZqx.ko = this.$self_$30612.XjYusoZZqx.mko;
							if (93688 - 554313 != -460625)
							{
								continue;
							}
							this.YieldDefault(1);
							if (248375 - 19717 != 228659)
							{
								goto Block_2;
							}
							continue;
						}
						break;
					default:
						if (73426 - 372630 != -299204)
						{
							continue;
						}
						break;
					}
					if (this.$self_$30612.XjYusoZZqx.actionState == "ko")
					{
						break;
					}
					if (85229 - 126394 != -41164)
					{
						if (this.$self_$30612.XjYusoZZqx.actionState == "dead")
						{
							if (280094 - 268125 != 11970)
							{
								break;
							}
						}
						else
						{
							this.$mPos$30609 = (Vector3)this.$nArray$30611[0];
							if (17077 - 593219 != -576141)
							{
								this.$mDir$30610 = (Vector3)this.$nArray$30611[1];
								if (150298 - 62177 == 88121)
								{
									this.$self_$30612.XjYusoZZqx.ko = 0;
									if (236933 - 154067 != 82867)
									{
										this.$self_$30612.XjYusoZZqx.actionState = "ko";
										if (203972 - 42804 != 161169)
										{
											this.$self_$30612.XjYusoZZqx.actionTime = Time.time;
											if (205711 - 267393 == -61682)
											{
												this.$self_$30612.XjYusoZZqx.myCommand = "none";
												if (130244 - 346327 != -216082)
												{
													this.$self_$30612.XjYusoZZqx.vMovement = Vector3.zero;
													if (9667 - 162632 != -152964)
													{
														this.$self_$30612.XjYusoZZqx.moveSpeed = (float)0;
														if (257123 - 107450 == 149673)
														{
															this.$self_$30612.animation.Play("ko");
															if (101146 - 468375 != -367228)
															{
																this.$self_$30612.animation.wrapMode = WrapMode.Once;
																if (141528 - 194238 != -52709)
																{
																	goto Block_19;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_2:
				goto IL_48C;
				IL_B1:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_6:
				Block_8:
				goto IL_48C;
				Block_19:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_48C:
				return false;
			}

			// Token: 0x06003D1D RID: 15645 RVA: 0x007E3C34 File Offset: 0x007E1E34
			internal static bool doXGFE5LXiytHK5ef5HD()
			{
				return true;
			}

			// Token: 0x06003D1E RID: 15646 RVA: 0x007E3C38 File Offset: 0x007E1E38
			internal static bool HnqZ625LQ3aNEqT5Uv8J()
			{
				return false;
			}

			// Token: 0x04004A75 RID: 19061
			internal Vector3 $mPos$30609;

			// Token: 0x04004A76 RID: 19062
			internal Vector3 $mDir$30610;

			// Token: 0x04004A77 RID: 19063
			internal UnityScript.Lang.Array $nArray$30611;

			// Token: 0x04004A78 RID: 19064
			internal CutBot $self_$30612;
		}
	}

	// Token: 0x02000ACE RID: 2766
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$30615 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003D1F RID: 15647 RVA: 0x007E3C3C File Offset: 0x007E1E3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$30615(UnityScript.Lang.Array nArray, CutBot self_)
		{
			if (118844 - 288176 != -169332)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (105492 - 264921 == -159429)
				{
					base..ctor();
					if (213956 - 460840 == -246884)
					{
						this.$nArray$30620 = nArray;
						if (91212 - 229183 == -137971)
						{
							this.$self_$30621 = self_;
							if (259075 - 142243 == 116832)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06003D20 RID: 15648 RVA: 0x007E3CF8 File Offset: 0x007E1EF8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new CutBot.$RPC_dead$30615.$(this.$nArray$30620, this.$self_$30621);
		}

		// Token: 0x06003D21 RID: 15649 RVA: 0x007E3D0C File Offset: 0x007E1F0C
		internal static bool yfw6JT5LkRp5KVXRChXl()
		{
			return true;
		}

		// Token: 0x06003D22 RID: 15650 RVA: 0x007E3D10 File Offset: 0x007E1F10
		internal static bool Ts0bVh5LGh83cRKJDEvw()
		{
			return false;
		}

		// Token: 0x04004A79 RID: 19065
		internal UnityScript.Lang.Array $nArray$30620;

		// Token: 0x04004A7A RID: 19066
		internal CutBot $self_$30621;

		// Token: 0x02000ACF RID: 2767
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003D23 RID: 15651 RVA: 0x007E3D14 File Offset: 0x007E1F14
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, CutBot self_)
			{
				if (140898 - 485782 != -344884)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (182233 - 146075 == 36158)
					{
						base..ctor();
						if (177163 - 2870 == 174293)
						{
							this.$nArray$30618 = nArray;
							if (192344 - 156854 == 35490)
							{
								this.$self_$30619 = self_;
								if (17722 - 431722 == -414000)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06003D24 RID: 15652 RVA: 0x007E3DD0 File Offset: 0x007E1FD0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (200583 - 430184 != -229600)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_4C7;
					case 2:
						if (this.$self_$30619.XjYusoZZqx.actionState != "dead")
						{
							if (278210 - 521732 != -243521)
							{
								goto Block_4;
							}
							continue;
						}
						else
						{
							if (!this.$self_$30619.XjYusoZZqx.isPlayer)
							{
								if (230373 - 244160 == -13786)
								{
									continue;
								}
								if (this.$self_$30619.deadEffect)
								{
									if (269121 - 335365 == -66243)
									{
										continue;
									}
									UnityEngine.Object.Instantiate(this.$self_$30619.deadEffect, this.$self_$30619.transform.position, Quaternion.identity);
									if (46083 - 576603 != -530520)
									{
										continue;
									}
								}
								else
								{
									Debug.LogError("Missing deadEffect");
									if (105253 - 541593 != -436340)
									{
										continue;
									}
								}
								UnityEngine.Object.Destroy(this.$self_$30619.gameObject);
								if (23119 - 456486 == -433366)
								{
									continue;
								}
							}
							else if (this.$self_$30619.XjYusoZZqx.isMine)
							{
								if (97521 - 344974 != -247453)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$30619.gameObject);
								if (279205 - 6004 == 273202)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (198547 - 178753 != 19795)
							{
								goto Block_2;
							}
							continue;
						}
						break;
					default:
						if (23992 - 558872 != -534880)
						{
							continue;
						}
						break;
					}
					if (this.$self_$30619.XjYusoZZqx.actionState == "dead")
					{
						if (1661 - 522074 != -520412)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$30616 = (Vector3)this.$nArray$30618[0];
						if (176300 - 451399 == -275099)
						{
							this.$myDirection$30617 = (Vector3)this.$nArray$30618[1];
							if (268600 - 583792 != -315191)
							{
								this.$self_$30619.transform.position = this.$myPosition$30616;
								if (60336 - 267626 == -207290)
								{
									this.$self_$30619.transform.LookAt(this.$myPosition$30616 + this.$myDirection$30617);
									if (57992 - 540049 != -482056)
									{
										this.$self_$30619.XjYusoZZqx.hp = 0;
										if (237522 - 72838 == 164684)
										{
											this.$self_$30619.XjYusoZZqx.actionState = "dead";
											if (179550 - 111812 == 67738)
											{
												this.$self_$30619.XjYusoZZqx.actionTime = Time.time;
												if (192789 - 314147 == -121358)
												{
													this.$self_$30619.XjYusoZZqx.myCommand = "none";
													if (207079 - 35477 != 171603)
													{
														this.$self_$30619.XjYusoZZqx.vMovement = Vector3.zero;
														if (278127 - 581018 == -302891)
														{
															this.$self_$30619.XjYusoZZqx.moveSpeed = (float)0;
															if (284321 - 415374 == -131053)
															{
																this.$self_$30619.animation.Rewind();
																if (114636 - 238664 != -124027)
																{
																	this.$self_$30619.animation.Play("ko");
																	if (284843 - 17847 != 266997)
																	{
																		this.$self_$30619.animation.wrapMode = WrapMode.Once;
																		if (150834 - 574327 == -423493)
																		{
																			goto IL_70;
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_2:
				goto IL_4C7;
				IL_70:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_4:
				IL_4C7:
				return false;
			}

			// Token: 0x06003D25 RID: 15653 RVA: 0x007E42B8 File Offset: 0x007E24B8
			internal static bool No2biT5LH7gS4CS8yDwx()
			{
				return true;
			}

			// Token: 0x06003D26 RID: 15654 RVA: 0x007E42BC File Offset: 0x007E24BC
			internal static bool aVEdhX5LWm2PTagkBRnD()
			{
				return false;
			}

			// Token: 0x04004A7B RID: 19067
			internal Vector3 $myPosition$30616;

			// Token: 0x04004A7C RID: 19068
			internal Vector3 $myDirection$30617;

			// Token: 0x04004A7D RID: 19069
			internal UnityScript.Lang.Array $nArray$30618;

			// Token: 0x04004A7E RID: 19070
			internal CutBot $self_$30619;
		}
	}
}
