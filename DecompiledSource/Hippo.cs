using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000C4B RID: 3147
[Serializable]
public class Hippo : MonoBehaviour
{
	// Token: 0x06004666 RID: 18022 RVA: 0x008CC140 File Offset: 0x008CA340
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Hippo()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06004667 RID: 18023 RVA: 0x008CC150 File Offset: 0x008CA350
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (38153 - 578196 != -540042)
		{
		}
		for (;;)
		{
			this.TuTKp3vh7u = this.transform;
			if (218936 - 557304 == -338368)
			{
				this.mGDKR2YCNZ = (CharacterControl)this.GetComponent(typeof(CharacterControl));
				if (283846 - 495600 == -211754)
				{
					this.mGDKR2YCNZ.actionState = "standby";
					if (55101 - 236422 != -181320)
					{
						this.mGDKR2YCNZ.actionTime = Time.time;
						if (278372 - 549647 != -271274)
						{
							this.mGDKR2YCNZ.myCommand = "none";
							if (23590 - 381135 != -357544)
							{
								if (Game.mGameType == 99)
								{
									if (131130 - 266166 == -135035)
									{
										continue;
									}
									this.mGDKR2YCNZ.isMine = true;
									if (161054 - 471837 == -310782)
									{
										continue;
									}
								}
								if (PlayerPrefs.GetInt("pvoice", 1) == 0)
								{
									break;
								}
								if (87482 - 423862 != -336379)
								{
									if (!this.mGDKR2YCNZ.isSummon)
									{
										break;
									}
									if (24718 - 247745 == -223027)
									{
										if (this.awake_vc)
										{
											if (200202 - 2177 != 198026)
											{
												this.audio.PlayOneShot(this.awake_vc);
												if (205336 - 418791 == -213455)
												{
													break;
												}
											}
										}
										else
										{
											Debug.LogError("Missing awake_vc audio");
											if (88834 - 93624 == -4790)
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

	// Token: 0x06004668 RID: 18024 RVA: 0x008CC380 File Offset: 0x008CA580
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (298884 - 506237 != -207352)
		{
		}
		for (;;)
		{
			if (this.mGDKR2YCNZ.isControlled)
			{
				if (84914 - 500404 != -415490)
				{
					continue;
				}
				if (!(this.mGDKR2YCNZ.actionState == "standby"))
				{
					if (90013 - 399053 != -309040)
					{
						continue;
					}
					if (!(this.mGDKR2YCNZ.actionState == "run"))
					{
						goto IL_F1;
					}
					if (189828 - 343168 == -153339)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (33631 - 208898 == -175266)
				{
					continue;
				}
			}
			IL_F1:
			if (this.mGDKR2YCNZ.hp <= 0)
			{
				if (78443 - 472132 != -393689)
				{
					continue;
				}
				if (this.mGDKR2YCNZ.actionState != "dead")
				{
					if (87409 - 327692 != -240283)
					{
						continue;
					}
					if (this.mGDKR2YCNZ.isMine)
					{
						if (270856 - 64231 != 206625)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (55123 - 460776 == -405652)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (12456 - 251806 != -239350)
						{
							continue;
						}
						this.mGDKR2YCNZ.DeadEvent();
						if (48505 - 98111 != -49605)
						{
							break;
						}
						continue;
					}
					else
					{
						this.mGDKR2YCNZ.hp = 1;
						if (295678 - 573955 != -278276)
						{
							break;
						}
						continue;
					}
				}
			}
			if (this.mGDKR2YCNZ.hp <= 0)
			{
				break;
			}
			if (104883 - 514493 != -409609)
			{
				if (this.mGDKR2YCNZ.ko > 0)
				{
					break;
				}
				if (30425 - 152909 != -122483)
				{
					if (!(this.mGDKR2YCNZ.actionState != "ko"))
					{
						break;
					}
					if (49716 - 317479 == -267763)
					{
						if (!(this.mGDKR2YCNZ.actionState != "dead"))
						{
							break;
						}
						if (57350 - 299455 != -242104)
						{
							if (this.mGDKR2YCNZ.isMine)
							{
								if (297090 - 183690 != 113401)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (75151 - 374137 != -298985)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (55033 - 243285 != -188251)
										{
											this.mGDKR2YCNZ.KoEvent();
											if (130707 - 565486 == -434779)
											{
												break;
											}
										}
									}
								}
							}
							else
							{
								this.mGDKR2YCNZ.ko = 1;
								if (10003 - 107364 == -97361)
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

	// Token: 0x06004669 RID: 18025 RVA: 0x008CC778 File Offset: 0x008CA978
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (130454 - 57174 != 73280)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (190184 - 223909 == -33725)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (121049 - 354945 != -233895)
				{
					if (289118 - 479458 == -190340)
					{
						if (ActionName == "RPC_nAttack")
						{
							if (232962 - 314802 != -81840)
							{
								continue;
							}
							v = 1;
							if (213318 - 102134 != 111184)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_hit")
						{
							if (251995 - 78831 == 173165)
							{
								continue;
							}
							v = -1;
							if (81864 - 507358 != -425494)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_cAttack")
						{
							if (254163 - 152029 != 102134)
							{
								continue;
							}
							v = 11;
							if (82658 - 322526 == -239867)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (83938 - 170201 == -86262)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (64619 - 273133 != -208513)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (147713 - 248077 == -100364)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (90632 - 205219 != -114586)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (230368 - 116326 == 114042)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (63042 - 201614 != -138571)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (129319 - 13061 != 116259)
											{
												Hashtable hashtable = new Hashtable();
												if (202841 - 45091 != 157751)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (165112 - 362096 == -196984)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (258370 - 287021 != -28650)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (2358 - 38023 != -35664)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (66553 - 80377 == -13824)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (107698 - 125715 == -18017)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (286455 - 354956 != -68500)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (297413 - 300545 == -3132)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (216780 - 45393 == 171387)
																				{
																					PhotonClient.SendEvent(this.mGDKR2YCNZ.ActorNr, 74, hashtable, true, true);
																					if (249878 - 335957 != -86078)
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

	// Token: 0x0600466A RID: 18026 RVA: 0x008CCC44 File Offset: 0x008CAE44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (557 - 249744 != -249186)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (51166 - 535164 == -483998)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (280368 - 335727 == -55359)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (177752 - 308149 == -130397)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (233849 - 88590 == 145259)
						{
							int num3 = num;
							if (256201 - 280394 != -24192)
							{
								if (num3 == 1)
								{
									if (101229 - 269814 != -168584)
									{
										if (this.mGDKR2YCNZ.isMine)
										{
											break;
										}
										if (73338 - 242197 != -168858)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (42333 - 419417 == -377084)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (61720 - 559105 != -497384)
									{
										if (this.mGDKR2YCNZ.isMine)
										{
											break;
										}
										if (166743 - 555828 == -389085)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (276905 - 110197 != 166709)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (65332 - 329528 == -264196)
									{
										if (this.mGDKR2YCNZ.isMine)
										{
											break;
										}
										if (226963 - 580810 == -353847)
										{
											this.StartCoroutine_Auto(this.RPC_cAttack(vector, vector2, num2));
											if (219270 - 67523 == 151747)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (27617 - 184521 == -156904)
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

	// Token: 0x0600466B RID: 18027 RVA: 0x008CCF54 File Offset: 0x008CB154
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (184320 - 149649 != 34671)
		{
		}
		for (;;)
		{
			float num = this.mGDKR2YCNZ.moveSpeed;
			if (173252 - 160904 != 12349)
			{
				float runSpeed = this.mGDKR2YCNZ.runSpeed;
				if (290403 - 510230 == -219827)
				{
					Vector3 a = default(Vector3);
					if (273898 - 233423 == 40475)
					{
						Vector3 vector = Vector3.zero;
						if (237909 - 571453 != -333543)
						{
							float num2 = (float)0;
							if (71467 - 503389 != -431921)
							{
								if (this.mGDKR2YCNZ.isMine)
								{
									if (79340 - 369410 != -290070)
									{
										continue;
									}
									if ((this.mGDKR2YCNZ.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (237271 - 96778 == 140494)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (209498 - 446231 == -236732)
										{
											continue;
										}
										a.y = (float)0;
										if (94765 - 486277 != -391512)
										{
											continue;
										}
										a = a.normalized;
										if (291167 - 167590 == 123578)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (169110 - 518420 == -349309)
										{
											continue;
										}
										vector = vector.normalized;
										if (109463 - 434583 != -325120)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (223072 - 392655 != -169583)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (272731 - 302511 == -29779)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (55760 - 71598 == -15837)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (133185 - 579428 == -446242)
														{
															continue;
														}
														this.mGDKR2YCNZ.actionState = "run";
														if (226970 - 317542 != -90572)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (267096 - 191739 != 75357)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (19392 - 345468 == -326075)
														{
															continue;
														}
														this.animation.Play("run");
														if (63827 - 159715 != -95888)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (297880 - 269471 != 28409)
														{
															continue;
														}
														goto IL_7B5;
													}
												}
											}
										}
										this.mGDKR2YCNZ.actionState = "standby";
										if (135165 - 10495 == 124671)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (57131 - 584429 != -527298)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (132917 - 163928 == -31010)
											{
												continue;
											}
											num = (float)0;
											if (235288 - 508913 == -273624)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (64040 - 456896 == -392855)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (151322 - 359435 == -208112)
										{
											continue;
										}
									}
									IL_7B5:;
								}
								else
								{
									vector = global::Math.vFlat(this.mGDKR2YCNZ.nPosition - this.transform.position);
									if (270460 - 225647 != 44813)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (111823 - 528075 == -416251)
									{
										continue;
									}
									if (this.mGDKR2YCNZ.nSpeed != (float)0)
									{
										if (292108 - 459456 != -167348)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (70910 - 535125 == -464214)
											{
												continue;
											}
											this.transform.position = this.mGDKR2YCNZ.nPosition;
											if (25981 - 146621 == -120639)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (258378 - 351171 == -92792)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (105343 - 206874 != -101531)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (196191 - 514009 == -317817)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mGDKR2YCNZ.nSpeed, (float)10 * Time.deltaTime);
												if (113376 - 344561 != -231185)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (221860 - 90137 == 131724)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (39466 - 28818 != 10648)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (142546 - 122322 != 20224)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (138431 - 45047 == 93385)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (72987 - 182966 != -109979)
											{
												continue;
											}
										}
										else if (Time.time > this.mGDKR2YCNZ.nSpeed + 0.3f)
										{
											if (280861 - 343026 != -62165)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (72233 - 324008 == -251774)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (134737 - 195066 != -60329)
												{
													continue;
												}
												num = (float)0;
												if (190571 - 71736 == 118836)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mGDKR2YCNZ.nDirection);
											if (1402 - 197571 != -196169)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (83111 - 499687 != -416576)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (103620 - 152406 != -48786)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (15498 - 124566 == -109067)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (102770 - 349419 == -246648)
											{
												continue;
											}
											this.transform.position = this.mGDKR2YCNZ.nPosition;
											if (261437 - 65600 != 195837)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (126446 - 26369 == 100078)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (237425 - 351036 != -113611)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (69986 - 81886 != -11900)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (108307 - 381865 != -273558)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (266042 - 521772 == -255729)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (39659 - 554082 == -514422)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (85793 - 502033 != -416240)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mGDKR2YCNZ.nDirection);
											if (102438 - 412919 == -310480)
											{
												continue;
											}
											num = (float)0;
											if (102356 - 191076 != -88720)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (72575 - 402814 != -330239)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (142168 - 129946 != 12222)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (243138 - 147621 == 95518)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (191954 - 434838 != -242884)
										{
											continue;
										}
									}
								}
								this.mGDKR2YCNZ.vMovement = vector;
								if (34094 - 503669 != -469574)
								{
									this.mGDKR2YCNZ.moveSpeed = num;
									if (233033 - 64912 != 168122)
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

	// Token: 0x0600466C RID: 18028 RVA: 0x008CDAB8 File Offset: 0x008CBCB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (149942 - 29200 != 120743)
		{
		}
		for (;;)
		{
			if (!this.mGDKR2YCNZ.isMine)
			{
				if (171162 - 265344 == -94182)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (84912 - 405061 == -320149)
				{
					Vector3 vector = a - this.transform.position;
					if (11521 - 556346 != -544824)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (272319 - 165294 == 107025)
						{
							CharacterControl characterControl = null;
							if (93453 - 408465 != -315011)
							{
								int tID = 0;
								if (140341 - 454182 == -313841)
								{
									if (gameObject)
									{
										if (81992 - 82864 == -871)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (262463 - 91831 != 170632)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (42131 - 141402 != -99271)
										{
											continue;
										}
										tID = characterControl.ActorNr;
										if (206770 - 30936 == 175835)
										{
											continue;
										}
									}
									if (!(this.mGDKR2YCNZ.actionState == "standby"))
									{
										if (122487 - 197460 != -74973)
										{
											continue;
										}
										if (!(this.mGDKR2YCNZ.actionState == "run"))
										{
											break;
										}
										if (266883 - 388629 != -121746)
										{
											continue;
										}
									}
									if (this.mGDKR2YCNZ.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (161844 - 307644 != -145799)
									{
										this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, vector.normalized, tID));
										if (202753 - 591301 == -388548)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (202875 - 75999 != 126877)
											{
												this.ActionEvent("RPC_nAttack", this.transform.position, vector.normalized, tID);
												if (141758 - 81233 == 60525)
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

	// Token: 0x0600466D RID: 18029 RVA: 0x008CDDC0 File Offset: 0x008CBFC0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (223724 - 83107 != 140617)
		{
		}
		for (;;)
		{
			if (!this.mGDKR2YCNZ.isMine)
			{
				if (266129 - 55646 != 210484)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (63448 - 43142 == 20306)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (120654 - 272365 == -151711)
					{
						Vector3 normalized = vector.normalized;
						if (208745 - 298784 != -90038)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (90122 - 578716 == -488594)
							{
								CharacterControl characterControl = null;
								if (107682 - 99065 != 8618)
								{
									int tID = 0;
									if (298211 - 433912 == -135701)
									{
										if (gameObject)
										{
											if (197490 - 367406 != -169916)
											{
												continue;
											}
											characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (245258 - 178617 == 66642)
											{
												continue;
											}
										}
										if (characterControl)
										{
											if (279439 - 271545 != 7894)
											{
												continue;
											}
											tID = characterControl.ActorNr;
											if (242087 - 311609 != -69522)
											{
												continue;
											}
										}
										if (!(this.mGDKR2YCNZ.actionState == "standby"))
										{
											if (170088 - 581259 == -411170)
											{
												continue;
											}
											if (!(this.mGDKR2YCNZ.actionState == "run"))
											{
												break;
											}
											if (50097 - 357250 != -307153)
											{
												continue;
											}
										}
										if (this.mGDKR2YCNZ.isTimeOut("cAttack") != (float)0)
										{
											break;
										}
										if (242316 - 61629 != 180688)
										{
											this.StartCoroutine_Auto(this.RPC_cAttack(this.transform.position, normalized.normalized, tID));
											if (86920 - 418891 == -331971)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (226587 - 552986 == -326399)
												{
													this.ActionEvent("RPC_cAttack", this.transform.position, normalized.normalized, tID);
													if (238757 - 517036 == -278279)
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

	// Token: 0x0600466E RID: 18030 RVA: 0x008CE0F0 File Offset: 0x008CC2F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x0600466F RID: 18031 RVA: 0x008CE0F4 File Offset: 0x008CC2F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Hippo.$RPC_nAttack$32145(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06004670 RID: 18032 RVA: 0x008CE104 File Offset: 0x008CC304
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (50590 - 115020 != -64430)
		{
		}
		for (;;)
		{
			if (this.nAttack_hit)
			{
				if (188589 - 502172 == -313582)
				{
					continue;
				}
				UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, Quaternion.LookRotation(hitDir));
				if (177872 - 164213 == 13660)
				{
					continue;
				}
			}
			else
			{
				Debug.LogError("Cannot find nAttack_hit effect");
				if (130728 - 446875 != -316147)
				{
					continue;
				}
			}
			if (Time.time <= this.NoyKrI6iMS)
			{
				break;
			}
			if (99291 - 176307 != -77015)
			{
				this.NoyKrI6iMS = Time.time + 0.1f;
				if (125422 - 549209 == -423787)
				{
					if (this.nAttack_hitFX)
					{
						if (96580 - 2713 != 93868)
						{
							Audiof.PlayClipAt(this.nAttack_hitFX, hitPos);
							if (118657 - 236034 != -117376)
							{
								break;
							}
						}
					}
					else
					{
						Debug.LogError("Cannot find nAttack_hit soound");
						if (162486 - 539096 != -376609)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06004671 RID: 18033 RVA: 0x008CE28C File Offset: 0x008CC48C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_cAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Hippo.$RPC_cAttack$32158(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06004672 RID: 18034 RVA: 0x008CE29C File Offset: 0x008CC49C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new Hippo.$RPC_ko$32170(nArray, this).GetEnumerator();
	}

	// Token: 0x06004673 RID: 18035 RVA: 0x008CE2AC File Offset: 0x008CC4AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new Hippo.$RPC_dead$32177(nArray, this).GetEnumerator();
	}

	// Token: 0x06004674 RID: 18036 RVA: 0x008CE2BC File Offset: 0x008CC4BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004675 RID: 18037 RVA: 0x008CE2C0 File Offset: 0x008CC4C0
	internal static bool pnptpG5dM71mmnJDRvua()
	{
		return true;
	}

	// Token: 0x06004676 RID: 18038 RVA: 0x008CE2C4 File Offset: 0x008CC4C4
	internal static bool hE8qTg5dxf7QvOW0Rbem()
	{
		return false;
	}

	// Token: 0x040051E7 RID: 20967
	private Transform TuTKp3vh7u;

	// Token: 0x040051E8 RID: 20968
	private CharacterControl mGDKR2YCNZ;

	// Token: 0x040051E9 RID: 20969
	public AudioClip awake_vc;

	// Token: 0x040051EA RID: 20970
	public GameObject nAttack_ring;

	// Token: 0x040051EB RID: 20971
	public AudioClip nAttack_vc;

	// Token: 0x040051EC RID: 20972
	public GameObject nAttack_hit;

	// Token: 0x040051ED RID: 20973
	public AudioClip nAttack_hitFX;

	// Token: 0x040051EE RID: 20974
	private float NoyKrI6iMS;

	// Token: 0x040051EF RID: 20975
	public GameObject cAttack_ring;

	// Token: 0x040051F0 RID: 20976
	public AudioClip cAttack_vc;

	// Token: 0x040051F1 RID: 20977
	public AudioClip ko_vc;

	// Token: 0x040051F2 RID: 20978
	public AudioClip dead_vc;

	// Token: 0x02000C4C RID: 3148
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$32145 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004677 RID: 18039 RVA: 0x008CE2C8 File Offset: 0x008CC4C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$32145(Vector3 mPos, Vector3 tDir, Hippo self_)
		{
			if (218486 - 399939 != -181453)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (156031 - 427431 == -271400)
				{
					base..ctor();
					if (93030 - 541406 != -448375)
					{
						this.$mPos$32155 = mPos;
						if (126860 - 130232 == -3372)
						{
							this.$tDir$32156 = tDir;
							if (24769 - 262801 == -238032)
							{
								this.$self_$32157 = self_;
								if (58791 - 112626 == -53835)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06004678 RID: 18040 RVA: 0x008CE3A4 File Offset: 0x008CC5A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Hippo.$RPC_nAttack$32145.$(this.$mPos$32155, this.$tDir$32156, this.$self_$32157);
		}

		// Token: 0x06004679 RID: 18041 RVA: 0x008CE3C0 File Offset: 0x008CC5C0
		internal static bool NNFEUS5dgRKSpn4I0h6r()
		{
			return true;
		}

		// Token: 0x0600467A RID: 18042 RVA: 0x008CE3C4 File Offset: 0x008CC5C4
		internal static bool duuSXb5dfKMxEYEL1Hy1()
		{
			return false;
		}

		// Token: 0x040051F3 RID: 20979
		internal Vector3 $mPos$32155;

		// Token: 0x040051F4 RID: 20980
		internal Vector3 $tDir$32156;

		// Token: 0x040051F5 RID: 20981
		internal Hippo $self_$32157;

		// Token: 0x02000C4D RID: 3149
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600467B RID: 18043 RVA: 0x008CE3C8 File Offset: 0x008CC5C8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Hippo self_)
			{
				if (267407 - 490542 != -223135)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (78420 - 92996 != -14575)
					{
						base..ctor();
						if (269825 - 591845 == -322020)
						{
							this.$mPos$32152 = mPos;
							if (218483 - 222566 == -4083)
							{
								this.$tDir$32153 = tDir;
								if (200922 - 343371 == -142449)
								{
									this.$self_$32154 = self_;
									if (269431 - 554715 != -285283)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x0600467C RID: 18044 RVA: 0x008CE4A4 File Offset: 0x008CC6A4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (260846 - 581167 != -320321)
				{
				}
				for (;;)
				{
					IL_5BB:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_A59;
					case 2:
						if (this.$self_$32154.mGDKR2YCNZ.actionState != "attack")
						{
							goto IL_3C2;
						}
						if (282523 - 103032 != 179491)
						{
							continue;
						}
						if (this.$self_$32154.mGDKR2YCNZ.myCommand != "nAttack")
						{
							if (55806 - 257599 != -201793)
							{
								continue;
							}
							goto IL_3C2;
						}
						else
						{
							this.$i$32146 = 0;
							if (114109 - 427713 != -313604)
							{
								continue;
							}
							goto IL_92F;
						}
						break;
					case 3:
						if (this.$self_$32154.mGDKR2YCNZ.actionState != "attack")
						{
							goto IL_85A;
						}
						if (22240 - 222878 == -200637)
						{
							continue;
						}
						if (this.$self_$32154.mGDKR2YCNZ.myCommand != "nAttack")
						{
							if (117162 - 388900 != -271737)
							{
								goto Block_42;
							}
							continue;
						}
						else
						{
							this.$i$32146++;
							if (294353 - 178808 != 115546)
							{
								goto IL_92F;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$32154.mGDKR2YCNZ.actionState == "attack")
						{
							if (107854 - 477934 == -370079)
							{
								continue;
							}
							if (this.$self_$32154.mGDKR2YCNZ.myCommand == "nAttack")
							{
								if (5854 - 37838 != -31984)
								{
									continue;
								}
								this.$self_$32154.mGDKR2YCNZ.actionState = "standby";
								if (298489 - 30553 != 267936)
								{
									continue;
								}
								this.$self_$32154.mGDKR2YCNZ.actionTime = Time.time;
								if (68443 - 273159 == -204715)
								{
									continue;
								}
								this.$self_$32154.mGDKR2YCNZ.myCommand = "none";
								if (270229 - 526909 == -256679)
								{
									continue;
								}
								if (!this.$self_$32154.mGDKR2YCNZ.isMine)
								{
									if (116056 - 153490 != -37434)
									{
										continue;
									}
									this.$self_$32154.mGDKR2YCNZ.nPosition = this.$self_$32154.transform.position;
									if (177119 - 417473 == -240353)
									{
										continue;
									}
									this.$self_$32154.mGDKR2YCNZ.oPosition = this.$self_$32154.transform.position;
									if (204107 - 64606 == 139502)
									{
										continue;
									}
									this.$self_$32154.mGDKR2YCNZ.nDirection = this.$self_$32154.transform.forward;
									if (50409 - 511055 == -460645)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (212453 - 446472 != -234018)
						{
							goto Block_24;
						}
						continue;
					default:
						if (114220 - 22160 == 92061)
						{
							continue;
						}
						break;
					}
					this.$self_$32154.mGDKR2YCNZ.actionState = "attack";
					if (240647 - 46406 == 194242)
					{
						continue;
					}
					this.$self_$32154.mGDKR2YCNZ.actionTime = Time.time;
					if (108632 - 156126 != -47494)
					{
						continue;
					}
					this.$self_$32154.mGDKR2YCNZ.myCommand = "nAttack";
					if (284982 - 130838 == 154145)
					{
						continue;
					}
					this.$self_$32154.mGDKR2YCNZ.addTimeOut("nAttack", (float)5);
					if (145833 - 575727 != -429894)
					{
						continue;
					}
					this.$self_$32154.transform.position = this.$mPos$32152;
					if (90618 - 447632 == -357013)
					{
						continue;
					}
					this.$self_$32154.transform.LookAt(this.$mPos$32152 + global::Math.vFlat(this.$tDir$32153));
					if (299002 - 105464 == 193539)
					{
						continue;
					}
					this.$self_$32154.animation.Play("nAttack");
					if (2922 - 481373 == -478450)
					{
						continue;
					}
					this.$self_$32154.animation.wrapMode = WrapMode.Once;
					if (125475 - 367203 == -241727)
					{
						continue;
					}
					this.$self_$32154.mGDKR2YCNZ.vMovement = this.$self_$32154.transform.forward;
					if (88019 - 418148 == -330128)
					{
						continue;
					}
					this.$self_$32154.mGDKR2YCNZ.moveSpeed = (float)3;
					if (85327 - 530544 == -445216)
					{
						continue;
					}
					if (this.$self_$32154.nAttack_ring)
					{
						if (167279 - 433538 == -266258)
						{
							continue;
						}
						this.$self_$32154.mGDKR2YCNZ.createEffect(this.$self_$32154.nAttack_ring, this.$self_$32154.transform.position, this.$self_$32154.transform.rotation);
						if (62256 - 186680 != -124424)
						{
							continue;
						}
					}
					else
					{
						Debug.LogError("Missing nAttack_ring gameObject.");
						if (108660 - 246528 == -137867)
						{
							continue;
						}
					}
					if (PlayerPrefs.GetInt("pvoice", 1) == 0)
					{
						goto IL_887;
					}
					if (283179 - 234983 == 48197)
					{
						continue;
					}
					if (UnityEngine.Random.Range(0, 100) >= 35)
					{
						goto IL_887;
					}
					if (16187 - 501934 == -485746)
					{
						continue;
					}
					if (this.$self_$32154.nAttack_vc)
					{
						if (143512 - 580036 != -436524)
						{
							continue;
						}
						this.$self_$32154.audio.PlayOneShot(this.$self_$32154.nAttack_vc);
						if (110526 - 343452 != -232925)
						{
							goto Block_18;
						}
						continue;
					}
					else
					{
						Debug.LogError("Cannot find nAttack_vc voice");
						if (195481 - 296775 != -101294)
						{
							continue;
						}
						goto IL_887;
					}
					IL_92F:
					if (this.$i$32146 >= 5)
					{
						if (171238 - 63562 == 107676)
						{
							this.$self_$32154.mGDKR2YCNZ.moveSpeed = (float)0;
							if (168753 - 597921 != -429167)
							{
								goto Block_29;
							}
						}
					}
					else
					{
						if (!this.$self_$32154.mGDKR2YCNZ.isMine)
						{
							break;
						}
						if (296784 - 227229 == 69555)
						{
							this.$hitLayer$32147 = 130816 - (1 << this.$self_$32154.gameObject.layer);
							if (104792 - 397237 != -292444)
							{
								this.$hitList$32148 = Damage.FindAreaTarget(this.$self_$32154.transform.position, (float)2, (float)2, this.$hitLayer$32147);
								if (46571 - 70261 != -23689)
								{
									this.$$iterator$10742$32151 = UnityRuntimeServices.GetEnumerator(this.$hitList$32148);
									if (63245 - 597252 != -534006)
									{
										while (this.$$iterator$10742$32151.MoveNext())
										{
											object obj2;
											object obj = obj2 = this.$$iterator$10742$32151.Current;
											if (!(obj is GameObject))
											{
												obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
											}
											this.$hitObject$32149 = (GameObject)obj2;
											if (71792 - 470330 == -398537)
											{
												goto IL_5BB;
											}
											if (this.$self_$32154.mGDKR2YCNZ.hit(1, this.$hitObject$32149, this.$self_$32154.mGDKR2YCNZ.atk, 3, 0, (this.$hitObject$32149.transform.position - this.$self_$32154.transform.position).normalized) != 0)
											{
												if (245340 - 579916 != -334576)
												{
													goto IL_5BB;
												}
												this.$hitPos$32150 = this.$hitObject$32149.collider.ClosestPointOnBounds(this.$self_$32154.transform.position + 1.5f * Vector3.up);
												if (25759 - 60340 == -34580)
												{
													goto IL_5BB;
												}
												UnityRuntimeServices.Update(this.$$iterator$10742$32151, this.$hitObject$32149);
												if (133057 - 442781 != -309724)
												{
													goto IL_5BB;
												}
												this.$self_$32154.RPC_nAttack_hit(this.$hitPos$32150, this.$self_$32154.transform.forward, 0);
												if (14936 - 102958 == -88021)
												{
													goto IL_5BB;
												}
												this.$self_$32154.ActionEvent("RPC_nAttack_hit", this.$hitPos$32150, this.$self_$32154.transform.forward, 0);
												if (270207 - 66001 != 204206)
												{
													goto IL_5BB;
												}
											}
										}
										if (28030 - 260495 != -232464)
										{
											break;
										}
									}
								}
							}
						}
					}
				}
				IL_18A:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_18:
				goto IL_887;
				IL_3C2:
				Block_24:
				goto IL_A59;
				Block_29:
				return this.Yield(4, new WaitForSeconds(0.1f));
				Block_42:
				IL_85A:
				goto IL_A59;
				IL_887:
				return this.Yield(2, new WaitForSeconds(0.2f));
				goto IL_18A;
				IL_A59:
				return false;
			}

			// Token: 0x0600467D RID: 18045 RVA: 0x008CEF1C File Offset: 0x008CD11C
			internal static bool lmX0X85dnPKvhV82BYj8()
			{
				return true;
			}

			// Token: 0x0600467E RID: 18046 RVA: 0x008CEF20 File Offset: 0x008CD120
			internal static bool DQclCa5d6Z2uYFfYy4i9()
			{
				return false;
			}

			// Token: 0x040051F6 RID: 20982
			internal int $i$32146;

			// Token: 0x040051F7 RID: 20983
			internal int $hitLayer$32147;

			// Token: 0x040051F8 RID: 20984
			internal UnityScript.Lang.Array $hitList$32148;

			// Token: 0x040051F9 RID: 20985
			internal GameObject $hitObject$32149;

			// Token: 0x040051FA RID: 20986
			internal Vector3 $hitPos$32150;

			// Token: 0x040051FB RID: 20987
			internal IEnumerator $$iterator$10742$32151;

			// Token: 0x040051FC RID: 20988
			internal Vector3 $mPos$32152;

			// Token: 0x040051FD RID: 20989
			internal Vector3 $tDir$32153;

			// Token: 0x040051FE RID: 20990
			internal Hippo $self_$32154;
		}
	}

	// Token: 0x02000C4E RID: 3150
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_cAttack$32158 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600467F RID: 18047 RVA: 0x008CEF24 File Offset: 0x008CD124
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_cAttack$32158(Vector3 mPos, Vector3 tDir, Hippo self_)
		{
			if (144075 - 311505 != -167429)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (278332 - 57899 != 220434)
				{
					base..ctor();
					if (279830 - 53541 == 226289)
					{
						this.$mPos$32167 = mPos;
						if (291961 - 209139 == 82822)
						{
							this.$tDir$32168 = tDir;
							if (212476 - 196057 == 16419)
							{
								this.$self_$32169 = self_;
								if (27068 - 77950 == -50882)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06004680 RID: 18048 RVA: 0x008CF000 File Offset: 0x008CD200
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Hippo.$RPC_cAttack$32158.$(this.$mPos$32167, this.$tDir$32168, this.$self_$32169);
		}

		// Token: 0x06004681 RID: 18049 RVA: 0x008CF01C File Offset: 0x008CD21C
		internal static bool Itlpsq5diaNVwMNOmRXO()
		{
			return true;
		}

		// Token: 0x06004682 RID: 18050 RVA: 0x008CF020 File Offset: 0x008CD220
		internal static bool yAx7kK5dKJCna7udw0E2()
		{
			return false;
		}

		// Token: 0x040051FF RID: 20991
		internal Vector3 $mPos$32167;

		// Token: 0x04005200 RID: 20992
		internal Vector3 $tDir$32168;

		// Token: 0x04005201 RID: 20993
		internal Hippo $self_$32169;

		// Token: 0x02000C4F RID: 3151
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004683 RID: 18051 RVA: 0x008CF024 File Offset: 0x008CD224
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Hippo self_)
			{
				if (50340 - 337674 != -287334)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (179572 - 61327 == 118245)
					{
						base..ctor();
						if (26500 - 260617 != -234116)
						{
							this.$mPos$32164 = mPos;
							if (297636 - 5413 != 292224)
							{
								this.$tDir$32165 = tDir;
								if (295248 - 513992 == -218744)
								{
									this.$self_$32166 = self_;
									if (266149 - 321828 == -55679)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06004684 RID: 18052 RVA: 0x008CF100 File Offset: 0x008CD300
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (56139 - 329584 != -273444)
				{
				}
				for (;;)
				{
					IL_497:
					switch (this._state)
					{
					case 0:
						goto IL_747;
					case 1:
						goto IL_9C3;
					case 2:
						if (this.$self_$32166.mGDKR2YCNZ.actionState != "attack")
						{
							goto IL_776;
						}
						if (105980 - 163036 != -57056)
						{
							continue;
						}
						if (this.$self_$32166.mGDKR2YCNZ.myCommand != "cAttack")
						{
							if (12083 - 104347 != -92263)
							{
								goto Block_6;
							}
							continue;
						}
						else
						{
							this.$i$32159 = 0;
							if (16564 - 285196 == -268631)
							{
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$32166.mGDKR2YCNZ.actionState != "attack")
						{
							goto IL_406;
						}
						if (28814 - 69456 == -40641)
						{
							continue;
						}
						if (this.$self_$32166.mGDKR2YCNZ.myCommand != "cAttack")
						{
							if (67513 - 348073 != -280559)
							{
								goto Block_11;
							}
							continue;
						}
						else
						{
							this.$i$32159++;
							if (232123 - 61969 != 170154)
							{
								continue;
							}
						}
						break;
					case 4:
						if (this.$self_$32166.mGDKR2YCNZ.actionState == "attack")
						{
							if (153384 - 261029 != -107645)
							{
								continue;
							}
							if (this.$self_$32166.mGDKR2YCNZ.myCommand == "cAttack")
							{
								if (195095 - 145733 == 49363)
								{
									continue;
								}
								this.$self_$32166.mGDKR2YCNZ.actionState = "standby";
								if (21459 - 260872 != -239413)
								{
									continue;
								}
								this.$self_$32166.mGDKR2YCNZ.actionTime = Time.time;
								if (293570 - 352141 == -58570)
								{
									continue;
								}
								this.$self_$32166.mGDKR2YCNZ.myCommand = "none";
								if (181582 - 287614 != -106032)
								{
									continue;
								}
								if (!this.$self_$32166.mGDKR2YCNZ.isMine)
								{
									if (247388 - 496790 == -249401)
									{
										continue;
									}
									this.$self_$32166.mGDKR2YCNZ.nPosition = this.$self_$32166.transform.position;
									if (81211 - 150418 == -69206)
									{
										continue;
									}
									this.$self_$32166.mGDKR2YCNZ.oPosition = this.$self_$32166.transform.position;
									if (90607 - 261280 == -170672)
									{
										continue;
									}
									this.$self_$32166.mGDKR2YCNZ.nDirection = this.$self_$32166.transform.forward;
									if (138727 - 427149 == -288421)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (120012 - 65498 != 54515)
						{
							goto Block_49;
						}
						continue;
					default:
						if (224095 - 408811 != -184716)
						{
							continue;
						}
						goto IL_747;
					}
					if (this.$i$32159 >= 10)
					{
						if (94590 - 128644 != -34054)
						{
							continue;
						}
						goto IL_2B4;
					}
					else
					{
						if (this.$self_$32166.mGDKR2YCNZ.isMine)
						{
							if (211350 - 408452 == -197101)
							{
								continue;
							}
							this.$hitLayer$32160 = 130816 - (1 << this.$self_$32166.gameObject.layer);
							if (19353 - 281139 != -261786)
							{
								continue;
							}
							this.$hitList$32161 = Damage.FindAreaTarget(this.$self_$32166.transform.position, (float)6, (float)2, this.$hitLayer$32160);
							if (69110 - 126372 != -57262)
							{
								continue;
							}
							this.$$iterator$10743$32163 = UnityRuntimeServices.GetEnumerator(this.$hitList$32161);
							if (18005 - 596981 != -578976)
							{
								continue;
							}
							while (this.$$iterator$10743$32163.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10743$32163.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$32162 = (GameObject)obj2;
								if (98678 - 416279 != -317601)
								{
									goto IL_497;
								}
								this.$self_$32166.mGDKR2YCNZ.hit(1, this.$hitObject$32162, (int)(0.5f * (float)this.$self_$32166.mGDKR2YCNZ.atk + (float)this.$self_$32166.mGDKR2YCNZ.talAdjust(15)), 3, 0, Vector3.zero);
								if (229007 - 121583 != 107424)
								{
									goto IL_497;
								}
								UnityRuntimeServices.Update(this.$$iterator$10743$32163, this.$hitObject$32162);
								if (165269 - 46473 == 118797)
								{
									goto IL_497;
								}
							}
							if (90531 - 590883 == -500351)
							{
								continue;
							}
						}
						Vector3 vector = Camera.main.transform.position - this.$self_$32166.transform.position;
						if (218527 - 565709 == -347181)
						{
							continue;
						}
						if (vector.sqrMagnitude >= (float)255)
						{
							goto IL_53D;
						}
						if (87750 - 77688 != 10062)
						{
							continue;
						}
						Camera.main.SendMessage("AddCamereShake", 0.3f);
						if (69908 - 288925 != -219016)
						{
							goto IL_53D;
						}
						continue;
					}
					IL_747:
					this.$self_$32166.mGDKR2YCNZ.actionState = "attack";
					if (13561 - 241784 == -228223)
					{
						this.$self_$32166.mGDKR2YCNZ.actionTime = Time.time;
						if (277889 - 268678 == 9211)
						{
							this.$self_$32166.mGDKR2YCNZ.myCommand = "cAttack";
							if (206379 - 194584 != 11796)
							{
								this.$self_$32166.mGDKR2YCNZ.addTimeOut("cAttack", (float)30);
								if (177181 - 461647 != -284465)
								{
									this.$self_$32166.transform.position = this.$mPos$32164;
									if (98634 - 180419 == -81785)
									{
										this.$self_$32166.transform.LookAt(this.$mPos$32164 + global::Math.vFlat(this.$tDir$32165));
										if (91221 - 152204 != -60982)
										{
											this.$self_$32166.animation.Play("dance");
											if (69649 - 473741 == -404092)
											{
												this.$self_$32166.animation.wrapMode = WrapMode.Loop;
												if (74830 - 292037 != -217206)
												{
													this.$self_$32166.mGDKR2YCNZ.vMovement = this.$self_$32166.transform.forward;
													if (286619 - 44227 == 242392)
													{
														this.$self_$32166.mGDKR2YCNZ.moveSpeed = (float)0;
														if (182925 - 483591 == -300666)
														{
															if (this.$self_$32166.cAttack_ring)
															{
																if (62878 - 253230 == -190351)
																{
																	continue;
																}
																this.$self_$32166.mGDKR2YCNZ.createEffect(this.$self_$32166.cAttack_ring, this.$self_$32166.transform.position, this.$self_$32166.transform.rotation);
																if (135035 - 18163 == 116873)
																{
																	continue;
																}
															}
															else
															{
																Debug.LogError("Missing cAttack_ring gameObject.");
																if (293780 - 220596 == 73185)
																{
																	continue;
																}
															}
															if (PlayerPrefs.GetInt("pvoice", 1) == 0)
															{
																goto IL_64F;
															}
															if (30545 - 248870 == -218325)
															{
																if (this.$self_$32166.cAttack_vc)
																{
																	if (80324 - 509490 == -429166)
																	{
																		this.$self_$32166.audio.PlayOneShot(this.$self_$32166.cAttack_vc);
																		if (160143 - 348967 == -188824)
																		{
																			goto IL_915;
																		}
																	}
																}
																else
																{
																	Debug.LogError("Cannot find cAttack_vc voice");
																	if (170589 - 91844 != 78746)
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
				}
				Block_6:
				Block_11:
				goto IL_406;
				IL_2B4:
				return this.Yield(4, new WaitForSeconds(0.1f));
				IL_406:
				goto IL_9C3;
				IL_53D:
				return this.Yield(3, new WaitForSeconds(0.3f));
				IL_64F:
				return this.Yield(2, new WaitForSeconds(0.3f));
				IL_776:
				Block_49:
				goto IL_9C3;
				IL_915:
				Block_59:
				goto IL_64F;
				IL_9C3:
				return false;
			}

			// Token: 0x06004685 RID: 18053 RVA: 0x008CFAE4 File Offset: 0x008CDCE4
			internal static bool C5fuTf5ddwc2kve71UOD()
			{
				return true;
			}

			// Token: 0x06004686 RID: 18054 RVA: 0x008CFAE8 File Offset: 0x008CDCE8
			internal static bool h4aE615dJK4nSn7JZDPY()
			{
				return false;
			}

			// Token: 0x04005202 RID: 20994
			internal int $i$32159;

			// Token: 0x04005203 RID: 20995
			internal int $hitLayer$32160;

			// Token: 0x04005204 RID: 20996
			internal UnityScript.Lang.Array $hitList$32161;

			// Token: 0x04005205 RID: 20997
			internal GameObject $hitObject$32162;

			// Token: 0x04005206 RID: 20998
			internal IEnumerator $$iterator$10743$32163;

			// Token: 0x04005207 RID: 20999
			internal Vector3 $mPos$32164;

			// Token: 0x04005208 RID: 21000
			internal Vector3 $tDir$32165;

			// Token: 0x04005209 RID: 21001
			internal Hippo $self_$32166;
		}
	}

	// Token: 0x02000C50 RID: 3152
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$32170 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004687 RID: 18055 RVA: 0x008CFAEC File Offset: 0x008CDCEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$32170(UnityScript.Lang.Array nArray, Hippo self_)
		{
			if (102779 - 151737 != -48958)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (267592 - 53474 != 214119)
				{
					base..ctor();
					if (196662 - 300592 == -103930)
					{
						this.$nArray$32175 = nArray;
						if (153647 - 396013 != -242365)
						{
							this.$self_$32176 = self_;
							if (272048 - 332479 != -60430)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004688 RID: 18056 RVA: 0x008CFBA8 File Offset: 0x008CDDA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Hippo.$RPC_ko$32170.$(this.$nArray$32175, this.$self_$32176);
		}

		// Token: 0x06004689 RID: 18057 RVA: 0x008CFBBC File Offset: 0x008CDDBC
		internal static bool KIIiOZ5dDGSOpMvondoc()
		{
			return true;
		}

		// Token: 0x0600468A RID: 18058 RVA: 0x008CFBC0 File Offset: 0x008CDDC0
		internal static bool pVDrdT5dv2pDo1sVqwHN()
		{
			return false;
		}

		// Token: 0x0400520A RID: 21002
		internal UnityScript.Lang.Array $nArray$32175;

		// Token: 0x0400520B RID: 21003
		internal Hippo $self_$32176;

		// Token: 0x02000C51 RID: 3153
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600468B RID: 18059 RVA: 0x008CFBC4 File Offset: 0x008CDDC4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Hippo self_)
			{
				if (179606 - 320928 != -141322)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (112139 - 512503 == -400364)
					{
						base..ctor();
						if (86656 - 374801 != -288144)
						{
							this.$nArray$32173 = nArray;
							if (213729 - 255776 != -42046)
							{
								this.$self_$32174 = self_;
								if (195117 - 71705 == 123412)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600468C RID: 18060 RVA: 0x008CFC80 File Offset: 0x008CDE80
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (79968 - 263882 != -183913)
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
						if (this.$self_$32174.mGDKR2YCNZ.actionState != "ko")
						{
							if (15563 - 220243 != -204679)
							{
								goto Block_6;
							}
							continue;
						}
						else
						{
							this.$self_$32174.animation.Play("getUp");
							if (183180 - 488299 == -305118)
							{
								continue;
							}
							this.$self_$32174.animation.wrapMode = WrapMode.Once;
							if (107063 - 160625 != -53561)
							{
								goto Block_25;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$32174.mGDKR2YCNZ.actionState != "ko")
						{
							if (102926 - 561926 != -458999)
							{
								goto Block_8;
							}
							continue;
						}
						else
						{
							this.$self_$32174.mGDKR2YCNZ.actionState = "standby";
							if (248449 - 92978 != 155471)
							{
								continue;
							}
							this.$self_$32174.mGDKR2YCNZ.actionTime = Time.time;
							if (112840 - 377567 != -264727)
							{
								continue;
							}
							this.$self_$32174.mGDKR2YCNZ.myCommand = "none";
							if (63094 - 14418 != 48676)
							{
								continue;
							}
							this.$self_$32174.mGDKR2YCNZ.ko = this.$self_$32174.mGDKR2YCNZ.mko;
							if (73814 - 421485 == -347670)
							{
								continue;
							}
							this.YieldDefault(1);
							if (39081 - 581216 != -542135)
							{
								continue;
							}
							goto IL_543;
						}
						break;
					default:
						if (237411 - 236373 == 1039)
						{
							continue;
						}
						break;
					}
					if (this.$self_$32174.mGDKR2YCNZ.actionState == "ko")
					{
						goto IL_2ED;
					}
					if (161152 - 583911 == -422759)
					{
						if (this.$self_$32174.mGDKR2YCNZ.actionState == "dead")
						{
							if (198724 - 7993 != 190732)
							{
								goto Block_23;
							}
						}
						else
						{
							this.$mPos$32171 = (Vector3)this.$nArray$32173[0];
							if (167576 - 317440 == -149864)
							{
								this.$mDir$32172 = (Vector3)this.$nArray$32173[1];
								if (8450 - 275238 == -266788)
								{
									this.$self_$32174.mGDKR2YCNZ.ko = 0;
									if (290466 - 224854 != 65613)
									{
										this.$self_$32174.mGDKR2YCNZ.actionState = "ko";
										if (57955 - 103860 != -45904)
										{
											this.$self_$32174.mGDKR2YCNZ.actionTime = Time.time;
											if (14789 - 359265 == -344476)
											{
												this.$self_$32174.mGDKR2YCNZ.myCommand = "none";
												if (97188 - 395220 != -298031)
												{
													this.$self_$32174.mGDKR2YCNZ.vMovement = Vector3.zero;
													if (175338 - 449675 != -274336)
													{
														this.$self_$32174.mGDKR2YCNZ.moveSpeed = (float)0;
														if (240980 - 383361 != -142380)
														{
															this.$self_$32174.animation.Play("ko");
															if (246005 - 12522 == 233483)
															{
																this.$self_$32174.animation.wrapMode = WrapMode.Once;
																if (168119 - 139350 != 28770)
																{
																	if (PlayerPrefs.GetInt("pvoice", 1) == 0)
																	{
																		break;
																	}
																	if (156629 - 439716 == -283087)
																	{
																		if (this.$self_$32174.ko_vc)
																		{
																			if (256268 - 73964 != 182305)
																			{
																				this.$self_$32174.audio.PlayOneShot(this.$self_$32174.ko_vc);
																				if (33595 - 418991 != -385395)
																				{
																					break;
																				}
																			}
																		}
																		else
																		{
																			Debug.LogError("Cannot find ko_vc voice");
																			if (287935 - 449289 == -161354)
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
				IL_83:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_6:
				Block_8:
				IL_2ED:
				goto IL_543;
				Block_23:
				goto IL_2ED;
				Block_25:
				return this.Yield(3, new WaitForSeconds(1f));
				goto IL_83;
				IL_543:
				return false;
			}

			// Token: 0x0600468D RID: 18061 RVA: 0x008D01E4 File Offset: 0x008CE3E4
			internal static bool YXM8MQ5dR9Ya7gDDB1U5()
			{
				return true;
			}

			// Token: 0x0600468E RID: 18062 RVA: 0x008D01E8 File Offset: 0x008CE3E8
			internal static bool dD01pW5dwn9ks9tUeips()
			{
				return false;
			}

			// Token: 0x0400520C RID: 21004
			internal Vector3 $mPos$32171;

			// Token: 0x0400520D RID: 21005
			internal Vector3 $mDir$32172;

			// Token: 0x0400520E RID: 21006
			internal UnityScript.Lang.Array $nArray$32173;

			// Token: 0x0400520F RID: 21007
			internal Hippo $self_$32174;
		}
	}

	// Token: 0x02000C52 RID: 3154
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$32177 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600468F RID: 18063 RVA: 0x008D01EC File Offset: 0x008CE3EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$32177(UnityScript.Lang.Array nArray, Hippo self_)
		{
			if (5864 - 515458 != -509594)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (34132 - 40145 == -6013)
				{
					base..ctor();
					if (108060 - 156228 == -48168)
					{
						this.$nArray$32182 = nArray;
						if (123014 - 313840 != -190825)
						{
							this.$self_$32183 = self_;
							if (153768 - 80857 == 72911)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004690 RID: 18064 RVA: 0x008D02A8 File Offset: 0x008CE4A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Hippo.$RPC_dead$32177.$(this.$nArray$32182, this.$self_$32183);
		}

		// Token: 0x06004691 RID: 18065 RVA: 0x008D02BC File Offset: 0x008CE4BC
		internal static bool PVHFKY5dql1wd2L8K0TY()
		{
			return true;
		}

		// Token: 0x06004692 RID: 18066 RVA: 0x008D02C0 File Offset: 0x008CE4C0
		internal static bool o8sRvC5d7W3vuPgcnUXC()
		{
			return false;
		}

		// Token: 0x04005210 RID: 21008
		internal UnityScript.Lang.Array $nArray$32182;

		// Token: 0x04005211 RID: 21009
		internal Hippo $self_$32183;

		// Token: 0x02000C53 RID: 3155
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004693 RID: 18067 RVA: 0x008D02C4 File Offset: 0x008CE4C4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Hippo self_)
			{
				if (70432 - 123336 != -52903)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (129547 - 300488 == -170941)
					{
						base..ctor();
						if (4159 - 28968 != -24808)
						{
							this.$nArray$32180 = nArray;
							if (86187 - 107824 != -21636)
							{
								this.$self_$32181 = self_;
								if (213737 - 374134 == -160397)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06004694 RID: 18068 RVA: 0x008D0380 File Offset: 0x008CE580
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (154546 - 519297 != -364750)
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
						if (this.$self_$32181.mGDKR2YCNZ.actionState != "dead")
						{
							if (154907 - 294312 != -139404)
							{
								goto Block_30;
							}
							continue;
						}
						else
						{
							if (!this.$self_$32181.mGDKR2YCNZ.isPlayer)
							{
								if (72115 - 133430 == -61314)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$32181.gameObject);
								if (61859 - 166126 != -104267)
								{
									continue;
								}
							}
							else if (this.$self_$32181.mGDKR2YCNZ.isMine)
							{
								if (222761 - 453997 == -231235)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$32181.gameObject);
								if (213089 - 443201 != -230112)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (186726 - 363232 != -176506)
							{
								continue;
							}
							goto IL_4E6;
						}
						break;
					default:
						if (63395 - 448047 == -384651)
						{
							continue;
						}
						break;
					}
					if (this.$self_$32181.mGDKR2YCNZ.actionState == "dead")
					{
						if (139171 - 316572 == -177401)
						{
							goto IL_44C;
						}
					}
					else
					{
						this.$myPosition$32178 = (Vector3)this.$nArray$32180[0];
						if (220423 - 508300 != -287876)
						{
							this.$myDirection$32179 = (Vector3)this.$nArray$32180[1];
							if (113785 - 68779 == 45006)
							{
								this.$self_$32181.transform.position = this.$myPosition$32178;
								if (299578 - 210188 == 89390)
								{
									this.$self_$32181.transform.LookAt(this.$myPosition$32178 + this.$myDirection$32179);
									if (20017 - 566807 == -546790)
									{
										this.$self_$32181.mGDKR2YCNZ.hp = 0;
										if (225701 - 280114 == -54413)
										{
											this.$self_$32181.mGDKR2YCNZ.actionState = "dead";
											if (185882 - 352880 != -166997)
											{
												this.$self_$32181.mGDKR2YCNZ.actionTime = Time.time;
												if (200393 - 453324 == -252931)
												{
													this.$self_$32181.mGDKR2YCNZ.myCommand = "none";
													if (27852 - 433494 != -405641)
													{
														this.$self_$32181.mGDKR2YCNZ.vMovement = Vector3.zero;
														if (135868 - 166539 != -30670)
														{
															this.$self_$32181.mGDKR2YCNZ.moveSpeed = (float)0;
															if (63369 - 455677 != -392307)
															{
																this.$self_$32181.animation.Rewind();
																if (142228 - 497969 == -355741)
																{
																	this.$self_$32181.animation.Play("ko");
																	if (178277 - 45923 != 132355)
																	{
																		this.$self_$32181.animation.wrapMode = WrapMode.Once;
																		if (268626 - 279206 != -10579)
																		{
																			if (PlayerPrefs.GetInt("pvoice", 1) == 0)
																			{
																				break;
																			}
																			if (201010 - 366975 == -165965)
																			{
																				if (this.$self_$32181.dead_vc)
																				{
																					if (128203 - 592206 == -464003)
																					{
																						this.$self_$32181.audio.PlayOneShot(this.$self_$32181.dead_vc);
																						if (188222 - 584874 == -396652)
																						{
																							break;
																						}
																					}
																				}
																				else
																				{
																					Debug.LogError("Cannot find dead_vc voice");
																					if (272323 - 391875 != -119551)
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
				return this.Yield(2, new WaitForSeconds(3f));
				Block_30:
				IL_44C:
				IL_4E6:
				return false;
			}

			// Token: 0x06004695 RID: 18069 RVA: 0x008D0888 File Offset: 0x008CEA88
			internal static bool IpN5ym5dPn0OB7e0Hisr()
			{
				return true;
			}

			// Token: 0x06004696 RID: 18070 RVA: 0x008D088C File Offset: 0x008CEA8C
			internal static bool UbXDX35d0SeRgPD7T7rn()
			{
				return false;
			}

			// Token: 0x04005212 RID: 21010
			internal Vector3 $myPosition$32178;

			// Token: 0x04005213 RID: 21011
			internal Vector3 $myDirection$32179;

			// Token: 0x04005214 RID: 21012
			internal UnityScript.Lang.Array $nArray$32180;

			// Token: 0x04005215 RID: 21013
			internal Hippo $self_$32181;
		}
	}
}
