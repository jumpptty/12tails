using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000E0D RID: 3597
[Serializable]
public class Doov : MonoBehaviour
{
	// Token: 0x06005152 RID: 20818 RVA: 0x009F19B8 File Offset: 0x009EFBB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Doov()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06005153 RID: 20819 RVA: 0x009F19C8 File Offset: 0x009EFBC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (151185 - 244551 != -93365)
		{
		}
		for (;;)
		{
			this.ksAce7oJkpG = this.transform;
			if (10607 - 337751 != -327143)
			{
				this.t5tceZe82RJ = (CharacterControl)this.GetComponent(typeof(CharacterControl));
				if (240257 - 406173 != -165915)
				{
					this.t5tceZe82RJ.actionState = "standby";
					if (10148 - 556590 == -546442)
					{
						this.t5tceZe82RJ.actionTime = Time.time;
						if (262003 - 340499 != -78495)
						{
							this.t5tceZe82RJ.myCommand = "none";
							if (241630 - 326027 == -84397)
							{
								if (Game.mGameType != 99)
								{
									break;
								}
								if (143828 - 120130 != 23699)
								{
									this.t5tceZe82RJ.isMine = true;
									if (176282 - 116598 != 59685)
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

	// Token: 0x06005154 RID: 20820 RVA: 0x009F1B28 File Offset: 0x009EFD28
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (59923 - 15878 != 44046)
		{
		}
		for (;;)
		{
			if (this.t5tceZe82RJ.isControlled)
			{
				if (203928 - 335568 != -131640)
				{
					continue;
				}
				if (!(this.t5tceZe82RJ.actionState == "standby"))
				{
					if (35829 - 355252 != -319423)
					{
						continue;
					}
					if (!(this.t5tceZe82RJ.actionState == "run"))
					{
						goto IL_F5;
					}
					if (50925 - 405862 == -354936)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (55276 - 380490 != -325214)
				{
					continue;
				}
			}
			IL_F5:
			if (this.t5tceZe82RJ.hp <= 0)
			{
				if (189349 - 497974 == -308624)
				{
					continue;
				}
				if (this.t5tceZe82RJ.actionState != "dead")
				{
					if (218727 - 437341 != -218614)
					{
						continue;
					}
					if (this.t5tceZe82RJ.isMine)
					{
						if (38641 - 430016 != -391375)
						{
							continue;
						}
						if (PhotonClient.IsInitialized())
						{
							if (143110 - 339074 != -195964)
							{
								continue;
							}
							this.t5tceZe82RJ.DeadEvent();
							if (260190 - 216877 != 43313)
							{
								continue;
							}
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (128367 - 337443 != -209076)
						{
							continue;
						}
						break;
					}
					else
					{
						this.t5tceZe82RJ.hp = 1;
						if (294099 - 460715 != -166616)
						{
							continue;
						}
						break;
					}
				}
			}
			if (this.t5tceZe82RJ.hp <= 0)
			{
				break;
			}
			if (237035 - 316921 == -79886)
			{
				if (this.t5tceZe82RJ.ko > 0)
				{
					break;
				}
				if (31124 - 582171 == -551047)
				{
					if (!(this.t5tceZe82RJ.actionState != "ko"))
					{
						break;
					}
					if (20274 - 264473 == -244199)
					{
						if (!(this.t5tceZe82RJ.actionState != "dead"))
						{
							break;
						}
						if (242857 - 426746 == -183889)
						{
							if (this.t5tceZe82RJ.isMine)
							{
								if (158669 - 411953 != -253283)
								{
									if (PhotonClient.IsInitialized())
									{
										if (272196 - 151658 != 120538)
										{
											continue;
										}
										this.t5tceZe82RJ.DeadEvent();
										if (106315 - 300340 != -194025)
										{
											continue;
										}
									}
									this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (117536 - 585162 != -467625)
									{
										break;
									}
								}
							}
							else
							{
								this.t5tceZe82RJ.ko = this.t5tceZe82RJ.mko;
								if (158586 - 306324 != -147737)
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

	// Token: 0x06005155 RID: 20821 RVA: 0x009F1F2C File Offset: 0x009F012C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (134353 - 337865 != -203511)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (95390 - 30915 != 64476)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (150803 - 529709 == -378906)
				{
					if (219523 - 165626 != 53898)
					{
						if (ActionName == "RPC_nAttack")
						{
							if (90383 - 250089 != -159706)
							{
								continue;
							}
							v = 1;
							if (181015 - 494560 == -313544)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_hit")
						{
							if (236428 - 561469 == -325040)
							{
								continue;
							}
							v = -1;
							if (178884 - 198989 == -20104)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (73061 - 320448 != -247387)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (116898 - 359579 == -242681)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (107947 - 134617 == -26670)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (43750 - 350286 == -306536)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (160552 - 18116 == 142436)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (277711 - 259664 != 18048)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (117447 - 191788 == -74341)
											{
												Hashtable hashtable = new Hashtable();
												if (127220 - 483051 != -355830)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (35032 - 30504 != 4529)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (177000 - 406341 != -229340)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (265712 - 92748 == 172964)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (134391 - 296313 != -161921)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (98025 - 195904 == -97879)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (241276 - 408185 != -166908)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (140859 - 397070 != -256210)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (295080 - 56685 != 238396)
																				{
																					PhotonClient.SendEvent(this.t5tceZe82RJ.ActorNr, 74, hashtable, true, true);
																					if (165161 - 67443 == 97718)
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

	// Token: 0x06005156 RID: 20822 RVA: 0x009F23AC File Offset: 0x009F05AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (114188 - 585489 != -471300)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (188233 - 164945 == 23288)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (213685 - 50329 == 163356)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (234345 - 419866 != -185520)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (224398 - 423039 != -198640)
						{
							int num3 = num;
							if (181970 - 451215 != -269244)
							{
								if (num3 == 1)
								{
									if (168934 - 174122 == -5188)
									{
										if (this.t5tceZe82RJ.isMine)
										{
											break;
										}
										if (178253 - 177532 == 721)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (127462 - 49831 != 77632)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (64028 - 298692 == -234664)
									{
										if (this.t5tceZe82RJ.isMine)
										{
											break;
										}
										if (263461 - 484568 != -221106)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (267865 - 347023 != -79157)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (206373 - 572876 == -366503)
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

	// Token: 0x06005157 RID: 20823 RVA: 0x009F2640 File Offset: 0x009F0840
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (158218 - 156166 != 2053)
		{
		}
		for (;;)
		{
			float num = this.t5tceZe82RJ.moveSpeed;
			if (100704 - 469288 != -368583)
			{
				float runSpeed = this.t5tceZe82RJ.runSpeed;
				if (60941 - 58263 == 2678)
				{
					Vector3 a = default(Vector3);
					if (21985 - 79576 != -57590)
					{
						Vector3 vector = Vector3.zero;
						if (17148 - 25789 == -8641)
						{
							float num2 = (float)0;
							if (187817 - 448238 == -260421)
							{
								if (this.t5tceZe82RJ.isMine)
								{
									if (91691 - 459976 != -368285)
									{
										continue;
									}
									if ((this.t5tceZe82RJ.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (108540 - 526635 != -418095)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (246471 - 279357 == -32885)
										{
											continue;
										}
										a.y = (float)0;
										if (134000 - 122791 == 11210)
										{
											continue;
										}
										a = a.normalized;
										if (116656 - 506145 != -389489)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (184112 - 374659 != -190547)
										{
											continue;
										}
										vector = vector.normalized;
										if (251083 - 399745 != -148662)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (9943 - 484945 != -475002)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (183768 - 275122 == -91353)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (58894 - 94983 != -36089)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (286145 - 471823 == -185677)
														{
															continue;
														}
														this.t5tceZe82RJ.actionState = "run";
														if (235554 - 205294 != 30260)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (224064 - 288367 != -64303)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (236361 - 552520 != -316159)
														{
															continue;
														}
														this.animation.Play("run");
														if (70365 - 235968 != -165603)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (275152 - 325035 != -49882)
														{
															goto IL_918;
														}
														continue;
													}
												}
											}
										}
										this.t5tceZe82RJ.actionState = "standby";
										if (299785 - 274495 != 25290)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (139579 - 1888 != 137691)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (167427 - 87093 != 80334)
											{
												continue;
											}
											num = (float)0;
											if (11806 - 294515 == -282708)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (38485 - 420971 == -382485)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (144545 - 528801 != -384256)
										{
											continue;
										}
									}
									IL_918:;
								}
								else
								{
									vector = global::Math.vFlat(this.t5tceZe82RJ.nPosition - this.transform.position);
									if (172065 - 105924 != 66141)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (127739 - 219028 == -91288)
									{
										continue;
									}
									if (this.t5tceZe82RJ.nSpeed != (float)0)
									{
										if (180477 - 599372 != -418895)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (89435 - 507043 == -417607)
											{
												continue;
											}
											this.transform.position = this.t5tceZe82RJ.nPosition;
											if (26668 - 488390 != -461722)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (116172 - 289937 != -173765)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (98856 - 91266 != 7590)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (189523 - 96274 != 93249)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.t5tceZe82RJ.nSpeed, (float)10 * Time.deltaTime);
												if (170368 - 528886 != -358518)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (12847 - 354337 == -341489)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (216682 - 18124 == 198559)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (24218 - 350079 != -325861)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (169957 - 488111 == -318153)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (127431 - 457377 != -329946)
											{
												continue;
											}
										}
										else if (Time.time > this.t5tceZe82RJ.nSpeed + 0.3f)
										{
											if (2955 - 300991 == -298035)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (98852 - 287931 == -189078)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (75684 - 451940 != -376256)
												{
													continue;
												}
												num = (float)0;
												if (99424 - 435930 == -336505)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.t5tceZe82RJ.nDirection);
											if (104025 - 416742 != -312717)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (15081 - 263089 != -248008)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (93805 - 397878 != -304073)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (247438 - 531226 != -283788)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (261715 - 78292 == 183424)
											{
												continue;
											}
											this.transform.position = this.t5tceZe82RJ.nPosition;
											if (157271 - 593893 != -436622)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (111324 - 290518 != -179194)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (157087 - 77061 != 80026)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (281435 - 50112 != 231323)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (219723 - 21514 == 198210)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (137186 - 122835 == 14352)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (142734 - 320515 == -177780)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (90132 - 195452 != -105320)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.t5tceZe82RJ.nDirection);
											if (99150 - 198858 != -99708)
											{
												continue;
											}
											num = (float)0;
											if (227607 - 175053 == 52555)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (163174 - 312143 != -148969)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (263900 - 361126 == -97225)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (112407 - 114404 == -1996)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (283980 - 570094 == -286113)
										{
											continue;
										}
									}
								}
								this.t5tceZe82RJ.vMovement = vector;
								if (66659 - 260945 != -194285)
								{
									this.t5tceZe82RJ.moveSpeed = num;
									if (135892 - 161838 != -25945)
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

	// Token: 0x06005158 RID: 20824 RVA: 0x009F31A4 File Offset: 0x009F13A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (96868 - 540581 != -443713)
		{
		}
		for (;;)
		{
			if (!this.t5tceZe82RJ.isMine)
			{
				if (132877 - 248887 != -116009)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (17575 - 232924 == -215349)
				{
					Vector3 tDir = a - this.transform.position;
					if (152200 - 273707 == -121507)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (142969 - 599633 != -456663)
						{
							CharacterControl characterControl = null;
							if (235824 - 420109 == -184285)
							{
								if (216982 - 350849 == -133867)
								{
									if (gameObject)
									{
										if (8592 - 587726 != -579134)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (214724 - 51914 != 162810)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (265181 - 336255 != -71074)
										{
											continue;
										}
										int actorNr = characterControl.ActorNr;
										if (269091 - 177584 != 91507)
										{
											continue;
										}
									}
									if (!(this.t5tceZe82RJ.actionState == "standby"))
									{
										if (248158 - 128219 == 119940)
										{
											continue;
										}
										if (!(this.t5tceZe82RJ.actionState == "run"))
										{
											break;
										}
										if (228488 - 20026 == 208463)
										{
											continue;
										}
									}
									if (this.t5tceZe82RJ.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (88364 - 209410 == -121046)
									{
										this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, tDir, 0));
										if (223322 - 471950 != -248627)
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

	// Token: 0x06005159 RID: 20825 RVA: 0x009F344C File Offset: 0x009F164C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (21561 - 351107 != -329545)
		{
		}
		for (;;)
		{
			if (!this.t5tceZe82RJ.isMine)
			{
				if (34914 - 142134 != -107219)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (12695 - 186844 == -174149)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (280037 - 184376 != 95662)
					{
						Vector3 normalized = vector.normalized;
						if (293631 - 407671 == -114040)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (150468 - 595444 == -444976)
							{
								CharacterControl characterControl = null;
								if (92356 - 592557 == -500201)
								{
									if (131962 - 154847 != -22884)
									{
										if (gameObject)
										{
											if (130683 - 457071 == -326387)
											{
												continue;
											}
											characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (29566 - 198964 == -169397)
											{
												continue;
											}
										}
										if (characterControl)
										{
											if (227330 - 34271 != 193059)
											{
												continue;
											}
											int actorNr = characterControl.ActorNr;
											if (299777 - 503281 == -203503)
											{
												continue;
											}
										}
										if (!(this.t5tceZe82RJ.actionState == "standby"))
										{
											if (73124 - 436354 == -363229)
											{
												continue;
											}
											if (!(this.t5tceZe82RJ.actionState == "run"))
											{
												break;
											}
											if (170838 - 366614 != -195776)
											{
												continue;
											}
										}
										if (this.t5tceZe82RJ.isTimeOut("cAttack") != (float)0)
										{
											break;
										}
										if (229877 - 49141 != 180737)
										{
											Camera.main.SendMessage("newGameMessage", "This character cannot use charged attack");
											if (110115 - 492537 == -382422)
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

	// Token: 0x0600515A RID: 20826 RVA: 0x009F3718 File Offset: 0x009F1918
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x0600515B RID: 20827 RVA: 0x009F371C File Offset: 0x009F191C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Doov.$RPC_nAttack$33827(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x0600515C RID: 20828 RVA: 0x009F372C File Offset: 0x009F192C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (this.nAttack_hit)
		{
			UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, this.transform.rotation);
		}
	}

	// Token: 0x0600515D RID: 20829 RVA: 0x009F3758 File Offset: 0x009F1958
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_ko(UnityScript.Lang.Array nArray)
	{
	}

	// Token: 0x0600515E RID: 20830 RVA: 0x009F375C File Offset: 0x009F195C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new Doov.$RPC_dead$33840(nArray, this).GetEnumerator();
	}

	// Token: 0x0600515F RID: 20831 RVA: 0x009F376C File Offset: 0x009F196C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06005160 RID: 20832 RVA: 0x009F3770 File Offset: 0x009F1970
	internal static bool a64Buv5r5ewXLFsZ4jQu()
	{
		return true;
	}

	// Token: 0x06005161 RID: 20833 RVA: 0x009F3774 File Offset: 0x009F1974
	internal static bool SJ1MTC5rpWXPbU1e5SEg()
	{
		return false;
	}

	// Token: 0x04005ACC RID: 23244
	private Transform ksAce7oJkpG;

	// Token: 0x04005ACD RID: 23245
	private CharacterControl t5tceZe82RJ;

	// Token: 0x04005ACE RID: 23246
	public AudioClip nAttack_vc;

	// Token: 0x04005ACF RID: 23247
	public GameObject nAttack_hit;

	// Token: 0x04005AD0 RID: 23248
	public GameObject dead_spaltter;

	// Token: 0x02000E0E RID: 3598
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$33827 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005162 RID: 20834 RVA: 0x009F3778 File Offset: 0x009F1978
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$33827(Vector3 mPos, Vector3 tDir, Doov self_)
		{
			if (208839 - 282871 != -74031)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (296243 - 533269 != -237025)
				{
					base..ctor();
					if (10531 - 410480 != -399948)
					{
						this.$mPos$33837 = mPos;
						if (133530 - 366912 != -233381)
						{
							this.$tDir$33838 = tDir;
							if (48579 - 474572 != -425992)
							{
								this.$self_$33839 = self_;
								if (18027 - 313999 != -295971)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06005163 RID: 20835 RVA: 0x009F3854 File Offset: 0x009F1A54
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Doov.$RPC_nAttack$33827.$(this.$mPos$33837, this.$tDir$33838, this.$self_$33839);
		}

		// Token: 0x06005164 RID: 20836 RVA: 0x009F3870 File Offset: 0x009F1A70
		internal static bool mxDTJB5rVNf0IFmxGEKa()
		{
			return true;
		}

		// Token: 0x06005165 RID: 20837 RVA: 0x009F3874 File Offset: 0x009F1A74
		internal static bool l69DUd5rtnS57eD09MkZ()
		{
			return false;
		}

		// Token: 0x04005AD1 RID: 23249
		internal Vector3 $mPos$33837;

		// Token: 0x04005AD2 RID: 23250
		internal Vector3 $tDir$33838;

		// Token: 0x04005AD3 RID: 23251
		internal Doov $self_$33839;

		// Token: 0x02000E0F RID: 3599
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005166 RID: 20838 RVA: 0x009F3878 File Offset: 0x009F1A78
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Doov self_)
			{
				if (252860 - 575589 != -322728)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (21776 - 574133 == -552357)
					{
						base..ctor();
						if (181482 - 78283 == 103199)
						{
							this.$mPos$33834 = mPos;
							if (199536 - 513566 != -314029)
							{
								this.$tDir$33835 = tDir;
								if (92310 - 484705 == -392395)
								{
									this.$self_$33836 = self_;
									if (299263 - 361669 == -62406)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06005167 RID: 20839 RVA: 0x009F3954 File Offset: 0x009F1B54
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (70796 - 446429 != -375633)
				{
				}
				for (;;)
				{
					IL_641:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_935;
					case 2:
						if (this.$self_$33836.t5tceZe82RJ.actionState != "attack")
						{
							goto IL_69;
						}
						if (165960 - 278143 == -112182)
						{
							continue;
						}
						if (this.$self_$33836.t5tceZe82RJ.myCommand != "nAttack")
						{
							if (44458 - 218138 != -173680)
							{
								continue;
							}
							goto IL_69;
						}
						else
						{
							this.$self_$33836.t5tceZe82RJ.moveSpeed = (float)7;
							if (105988 - 598529 == -492540)
							{
								continue;
							}
							if (!this.$self_$33836.nAttack_vc)
							{
								goto IL_442;
							}
							if (101027 - 301689 == -200661)
							{
								continue;
							}
							this.$self_$33836.audio.PlayOneShot(this.$self_$33836.nAttack_vc);
							if (226307 - 136593 != 89714)
							{
								continue;
							}
							goto IL_442;
						}
						break;
					case 3:
						if (this.$self_$33836.t5tceZe82RJ.actionState != "attack")
						{
							goto IL_9A;
						}
						if (39523 - 28540 == 10984)
						{
							continue;
						}
						if (this.$self_$33836.t5tceZe82RJ.myCommand != "nAttack")
						{
							if (73291 - 487928 != -414636)
							{
								goto Block_20;
							}
							continue;
						}
						else
						{
							this.$hitDamage$33828 = (int)(0.66f * (float)this.$self_$33836.t5tceZe82RJ.atk);
							if (65467 - 217944 != -152477)
							{
								continue;
							}
							this.$hitLayer$33829 = 130816 - (1 << this.$self_$33836.gameObject.layer);
							if (252197 - 30492 != 221705)
							{
								continue;
							}
							this.$hitList$33830 = null;
							if (3254 - 295529 != -292275)
							{
								continue;
							}
							this.$hitPos$33831 = default(Vector3);
							if (90643 - 281839 == -191195)
							{
								continue;
							}
							if (!this.$self_$33836.t5tceZe82RJ.isMine)
							{
								goto IL_1A;
							}
							if (6427 - 307964 != -301537)
							{
								continue;
							}
							this.$hitList$33830 = Damage.FindRecTarget(this.$self_$33836.transform.position, this.$self_$33836.transform.forward, (float)1, (float)1, (float)3, (float)3, this.$hitLayer$33829);
							if (109088 - 434770 != -325682)
							{
								continue;
							}
							this.$$iterator$10860$33833 = UnityRuntimeServices.GetEnumerator(this.$hitList$33830);
							if (103820 - 416328 == -312507)
							{
								continue;
							}
							while (this.$$iterator$10860$33833.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10860$33833.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$33832 = (GameObject)obj2;
								if (195229 - 149278 == 45952)
								{
									goto IL_641;
								}
								this.$self_$33836.t5tceZe82RJ.hit(1, this.$hitObject$33832, this.$hitDamage$33828, 0, 0, 0.3f * (this.$hitObject$33832.transform.position - this.$self_$33836.transform.position).normalized);
								if (4579 - 225475 != -220896)
								{
									goto IL_641;
								}
								UnityRuntimeServices.Update(this.$$iterator$10860$33833, this.$hitObject$33832);
								if (239867 - 332715 != -92848)
								{
									goto IL_641;
								}
							}
							if (72734 - 330938 != -258203)
							{
								goto Block_36;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$33836.t5tceZe82RJ.actionState != "attack")
						{
							goto IL_275;
						}
						if (244872 - 241974 != 2898)
						{
							continue;
						}
						if (this.$self_$33836.t5tceZe82RJ.myCommand != "nAttack")
						{
							if (64396 - 180865 != -116468)
							{
								goto Block_39;
							}
							continue;
						}
						else
						{
							this.$self_$33836.t5tceZe82RJ.moveSpeed = (float)0;
							if (45435 - 329251 != -283816)
							{
								continue;
							}
							goto IL_33D;
						}
						break;
					case 5:
						if (this.$self_$33836.t5tceZe82RJ.actionState == "attack")
						{
							if (16646 - 9598 != 7048)
							{
								continue;
							}
							if (this.$self_$33836.t5tceZe82RJ.myCommand == "nAttack")
							{
								if (94991 - 594179 == -499187)
								{
									continue;
								}
								this.$self_$33836.t5tceZe82RJ.actionState = "standby";
								if (266425 - 476059 == -209633)
								{
									continue;
								}
								this.$self_$33836.t5tceZe82RJ.actionTime = Time.time;
								if (151464 - 410325 == -258860)
								{
									continue;
								}
								this.$self_$33836.t5tceZe82RJ.myCommand = "none";
								if (38955 - 379358 != -340403)
								{
									continue;
								}
								if (!this.$self_$33836.t5tceZe82RJ.isMine)
								{
									if (146698 - 421600 != -274902)
									{
										continue;
									}
									this.$self_$33836.t5tceZe82RJ.nPosition = this.$self_$33836.transform.position;
									if (183063 - 353185 != -170122)
									{
										continue;
									}
									this.$self_$33836.t5tceZe82RJ.oPosition = this.$self_$33836.transform.position;
									if (269317 - 483057 == -213739)
									{
										continue;
									}
									this.$self_$33836.t5tceZe82RJ.nDirection = this.$self_$33836.transform.forward;
									if (246619 - 443576 != -196957)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (156871 - 452638 != -295767)
						{
							continue;
						}
						goto IL_935;
					default:
						if (166092 - 593441 != -427349)
						{
							continue;
						}
						break;
					}
					this.$self_$33836.t5tceZe82RJ.actionState = "attack";
					if (260781 - 321096 == -60315)
					{
						this.$self_$33836.t5tceZe82RJ.actionTime = Time.time;
						if (200435 - 112842 == 87593)
						{
							this.$self_$33836.t5tceZe82RJ.myCommand = "nAttack";
							if (83871 - 383199 == -299328)
							{
								this.$self_$33836.t5tceZe82RJ.addTimeOut("nAttack", (float)3);
								if (254396 - 35968 == 218428)
								{
									this.$self_$33836.transform.position = this.$mPos$33834;
									if (160576 - 597815 != -437238)
									{
										this.$self_$33836.transform.LookAt(this.$mPos$33834 + global::Math.vFlat(this.$tDir$33835));
										if (214004 - 31767 != 182238)
										{
											this.$self_$33836.animation.CrossFade("nAttack");
											if (226149 - 317288 != -91138)
											{
												this.$self_$33836.animation.wrapMode = WrapMode.Once;
												if (98872 - 182379 == -83507)
												{
													this.$self_$33836.t5tceZe82RJ.vMovement = this.$self_$33836.transform.forward;
													if (254654 - 289235 == -34581)
													{
														this.$self_$33836.t5tceZe82RJ.moveSpeed = (float)0;
														if (236600 - 226040 == 10560)
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
				IL_1A:
				return this.Yield(4, new WaitForSeconds(0.1f));
				IL_69:
				IL_9A:
				goto IL_935;
				IL_132:
				return this.Yield(2, new WaitForSeconds(0.2f));
				IL_275:
				Block_20:
				goto IL_9A;
				IL_33D:
				return this.Yield(5, new WaitForSeconds(0.2f));
				IL_442:
				return this.Yield(3, new WaitForSeconds(0.1f));
				Block_36:
				goto IL_1A;
				Block_39:
				IL_935:
				return false;
			}

			// Token: 0x06005168 RID: 20840 RVA: 0x009F42A8 File Offset: 0x009F24A8
			internal static bool FN0bdE5rNyelDYYZWgch()
			{
				return true;
			}

			// Token: 0x06005169 RID: 20841 RVA: 0x009F42AC File Offset: 0x009F24AC
			internal static bool ru0reW5rY68HUAYhwJRp()
			{
				return false;
			}

			// Token: 0x04005AD4 RID: 23252
			internal int $hitDamage$33828;

			// Token: 0x04005AD5 RID: 23253
			internal int $hitLayer$33829;

			// Token: 0x04005AD6 RID: 23254
			internal UnityScript.Lang.Array $hitList$33830;

			// Token: 0x04005AD7 RID: 23255
			internal Vector3 $hitPos$33831;

			// Token: 0x04005AD8 RID: 23256
			internal GameObject $hitObject$33832;

			// Token: 0x04005AD9 RID: 23257
			internal IEnumerator $$iterator$10860$33833;

			// Token: 0x04005ADA RID: 23258
			internal Vector3 $mPos$33834;

			// Token: 0x04005ADB RID: 23259
			internal Vector3 $tDir$33835;

			// Token: 0x04005ADC RID: 23260
			internal Doov $self_$33836;
		}
	}

	// Token: 0x02000E10 RID: 3600
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$33840 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600516A RID: 20842 RVA: 0x009F42B0 File Offset: 0x009F24B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$33840(UnityScript.Lang.Array nArray, Doov self_)
		{
			if (109876 - 454793 != -344916)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (80201 - 35263 != 44939)
				{
					base..ctor();
					if (177462 - 192060 == -14598)
					{
						this.$nArray$33850 = nArray;
						if (216245 - 199784 != 16462)
						{
							this.$self_$33851 = self_;
							if (35665 - 363741 == -328076)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600516B RID: 20843 RVA: 0x009F436C File Offset: 0x009F256C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Doov.$RPC_dead$33840.$(this.$nArray$33850, this.$self_$33851);
		}

		// Token: 0x0600516C RID: 20844 RVA: 0x009F4380 File Offset: 0x009F2580
		internal static bool q0soMP5rcanO7GwQtJdF()
		{
			return true;
		}

		// Token: 0x0600516D RID: 20845 RVA: 0x009F4384 File Offset: 0x009F2584
		internal static bool Oo6HHK5rUgyny51BDUIC()
		{
			return false;
		}

		// Token: 0x04005ADD RID: 23261
		internal UnityScript.Lang.Array $nArray$33850;

		// Token: 0x04005ADE RID: 23262
		internal Doov $self_$33851;

		// Token: 0x02000E11 RID: 3601
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600516E RID: 20846 RVA: 0x009F4388 File Offset: 0x009F2588
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Doov self_)
			{
				if (134338 - 279232 != -144894)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (256296 - 441735 != -185438)
					{
						base..ctor();
						if (103682 - 86503 == 17179)
						{
							this.$nArray$33848 = nArray;
							if (231031 - 195489 != 35543)
							{
								this.$self_$33849 = self_;
								if (157637 - 259316 != -101678)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600516F RID: 20847 RVA: 0x009F4444 File Offset: 0x009F2644
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (221054 - 343223 != -122169)
				{
				}
				for (;;)
				{
					IL_339:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_51C;
					case 2:
						if (!this.$self_$33849.t5tceZe82RJ.isPlayer)
						{
							if (150221 - 38023 == 112199)
							{
								continue;
							}
							UnityEngine.Object.Destroy(this.$self_$33849.gameObject);
							if (33780 - 70438 == -36657)
							{
								continue;
							}
						}
						else if (this.$self_$33849.t5tceZe82RJ.isMine)
						{
							if (88065 - 473961 != -385896)
							{
								continue;
							}
							Camera.main.SendMessage("onDeadPlayer", this.$self_$33849.gameObject);
							if (91188 - 124030 != -32842)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (118577 - 402844 != -284266)
						{
							goto Block_25;
						}
						continue;
					default:
						if (244798 - 290632 == -45833)
						{
							continue;
						}
						break;
					}
					if (this.$self_$33849.t5tceZe82RJ.actionState == "dead")
					{
						if (229484 - 124223 != 105262)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$33841 = (Vector3)this.$nArray$33848[0];
						if (265245 - 440878 != -175632)
						{
							this.$myDirection$33842 = (Vector3)this.$nArray$33848[1];
							if (255468 - 312183 == -56715)
							{
								this.$self_$33849.transform.position = this.$myPosition$33841;
								if (44553 - 2049 == 42504)
								{
									this.$self_$33849.transform.LookAt(this.$myPosition$33841 + this.$myDirection$33842);
									if (92919 - 184768 != -91848)
									{
										this.$self_$33849.t5tceZe82RJ.hp = 0;
										if (259568 - 465077 == -205509)
										{
											this.$self_$33849.t5tceZe82RJ.actionState = "dead";
											if (216225 - 356283 != -140057)
											{
												this.$self_$33849.t5tceZe82RJ.actionTime = Time.time;
												if (151760 - 75381 != 76380)
												{
													this.$self_$33849.t5tceZe82RJ.myCommand = "none";
													if (280483 - 248587 == 31896)
													{
														this.$self_$33849.t5tceZe82RJ.vMovement = Vector3.zero;
														if (293652 - 491972 != -198319)
														{
															this.$self_$33849.t5tceZe82RJ.moveSpeed = (float)0;
															if (203625 - 592831 != -389205)
															{
																this.$mHideRendererList$33843 = this.$self_$33849.gameObject.GetComponentsInChildren(typeof(Renderer));
																if (294099 - 159282 != 134818)
																{
																	this.$$11504$33845 = 0;
																	if (226697 - 331250 != -104552)
																	{
																		this.$$11505$33846 = this.$mHideRendererList$33843;
																		if (61800 - 227999 != -166198)
																		{
																			this.$$11506$33847 = this.$$11505$33846.Length;
																			if (98858 - 309114 != -210255)
																			{
																				while (this.$$11504$33845 < this.$$11506$33847)
																				{
																					((Renderer)this.$$11505$33846[this.$$11504$33845]).enabled = false;
																					if (169807 - 64250 != 105557)
																					{
																						goto IL_339;
																					}
																					this.$$11504$33845++;
																					if (183697 - 137092 != 46605)
																					{
																						goto IL_339;
																					}
																				}
																				if (78503 - 500800 != -422296)
																				{
																					if (!this.$self_$33849.dead_spaltter)
																					{
																						goto IL_36A;
																					}
																					if (266386 - 176999 != 89388)
																					{
																						UnityEngine.Object.Instantiate(this.$self_$33849.dead_spaltter, this.$self_$33849.transform.position, this.$self_$33849.transform.rotation);
																						if (22780 - 280748 == -257968)
																						{
																							goto IL_36A;
																						}
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				goto IL_51C;
				IL_36A:
				return this.Yield(2, new WaitForSeconds(1f));
				Block_25:
				IL_51C:
				return false;
			}

			// Token: 0x06005170 RID: 20848 RVA: 0x009F4980 File Offset: 0x009F2B80
			internal static bool mIvc9c5rTIXNQjlwHhuq()
			{
				return true;
			}

			// Token: 0x06005171 RID: 20849 RVA: 0x009F4984 File Offset: 0x009F2B84
			internal static bool hik6ss5r3L0nv8raMF2o()
			{
				return false;
			}

			// Token: 0x04005ADF RID: 23263
			internal Vector3 $myPosition$33841;

			// Token: 0x04005AE0 RID: 23264
			internal Vector3 $myDirection$33842;

			// Token: 0x04005AE1 RID: 23265
			internal Component[] $mHideRendererList$33843;

			// Token: 0x04005AE2 RID: 23266
			internal Renderer $mHideRendererer$33844;

			// Token: 0x04005AE3 RID: 23267
			internal int $$11504$33845;

			// Token: 0x04005AE4 RID: 23268
			internal Component[] $$11505$33846;

			// Token: 0x04005AE5 RID: 23269
			internal int $$11506$33847;

			// Token: 0x04005AE6 RID: 23270
			internal UnityScript.Lang.Array $nArray$33848;

			// Token: 0x04005AE7 RID: 23271
			internal Doov $self_$33849;
		}
	}
}
