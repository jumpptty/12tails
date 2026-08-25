using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000353 RID: 851
[Serializable]
public class LightPanther : MonoBehaviour
{
	// Token: 0x0600135A RID: 4954 RVA: 0x001E6050 File Offset: 0x001E4250
	[MethodImpl(MethodImplOptions.NoInlining)]
	public LightPanther()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600135B RID: 4955 RVA: 0x001E6060 File Offset: 0x001E4260
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (226617 - 245051 != -18433)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (75405 - 327801 != -252395)
			{
				this.mChar.actionState = "standby";
				if (148569 - 589320 == -440751)
				{
					this.mChar.actionTime = Time.time;
					if (138559 - 120350 == 18209)
					{
						this.mChar.myCommand = "none";
						if (72121 - 412383 != -340261)
						{
							this.iLbtx364rH = Time.time + (float)300;
							if (232660 - 381277 != -148616)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600135C RID: 4956 RVA: 0x001E6178 File Offset: 0x001E4378
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (61430 - 193010 != -131580)
		{
		}
		for (;;)
		{
			if (Game.mGameType == 99)
			{
				if (11657 - 227034 != -215377)
				{
					continue;
				}
				this.mChar.isMine = true;
				if (283398 - 253613 != 29785)
				{
					continue;
				}
			}
			if (!this.mChar)
			{
				break;
			}
			if (296380 - 392454 == -96074)
			{
				if (this.gameObject.layer == 9)
				{
					if (149759 - 469140 == -319380)
					{
						continue;
					}
					this.mChar.mTargetAvartar = this.LightPantherIcon2;
					if (177010 - 426261 != -249251)
					{
						continue;
					}
				}
				if (QualitySettings.GetQualityLevel() > 1)
				{
					if (63854 - 455140 != -391285)
					{
						this.SetTransparentSkin();
						if (265747 - 148390 == 117357)
						{
							break;
						}
					}
				}
				else
				{
					this.SetSolidSkin();
					if (7794 - 485307 != -477512)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600135D RID: 4957 RVA: 0x001E62E8 File Offset: 0x001E44E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetTransparentSkin()
	{
		if (249322 - 303404 != -54081)
		{
		}
		while (this.gameObject.layer == 9)
		{
			if (151202 - 221561 != -70358)
			{
				Transform transform = this.transform.Find("Panther_tri");
				if (146678 - 477674 != -330995)
				{
					if (transform)
					{
						if (178199 - 429460 == -251261)
						{
							SkinnedMeshRenderer skinnedMeshRenderer = (SkinnedMeshRenderer)transform.GetComponent(typeof(SkinnedMeshRenderer));
							if (32303 - 3786 != 28518)
							{
								if (skinnedMeshRenderer)
								{
									if (261982 - 150693 == 111290)
									{
										continue;
									}
									skinnedMeshRenderer.material.SetColor("_Emission", Color.red);
									if (117679 - 479859 != -362180)
									{
										continue;
									}
								}
								else
								{
									Debug.LogError("Cannot find Panther SkinnedMeshRenderer");
									if (256121 - 536481 != -280360)
									{
										continue;
									}
								}
								break;
							}
						}
					}
					else
					{
						Debug.LogError("Cannot find Panther_tri model");
						if (195204 - 19647 == 175557)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x0600135E RID: 4958 RVA: 0x001E6474 File Offset: 0x001E4674
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void SetSolidSkin()
	{
		if (131217 - 103320 != 27898)
		{
		}
		for (;;)
		{
			Transform transform = this.transform.Find("Panther_tri");
			if (274709 - 156515 == 118194)
			{
				if (transform)
				{
					if (5943 - 426373 == -420430)
					{
						SkinnedMeshRenderer skinnedMeshRenderer = (SkinnedMeshRenderer)transform.GetComponent(typeof(SkinnedMeshRenderer));
						if (21140 - 311231 == -290091)
						{
							if (skinnedMeshRenderer)
							{
								if (203644 - 559898 != -356253)
								{
									if (this.gameObject.layer == 8)
									{
										if (125953 - 566971 != -441017)
										{
											skinnedMeshRenderer.material = this.LightPanther1;
											if (244766 - 230109 != 14658)
											{
												break;
											}
										}
									}
									else
									{
										skinnedMeshRenderer.material = this.LightPanther2;
										if (264550 - 450773 == -186223)
										{
											break;
										}
									}
								}
							}
							else
							{
								Debug.LogError("Cannot find LightPanther SkinnedMeshRenderer");
								if (97020 - 180731 == -83711)
								{
									break;
								}
							}
						}
					}
				}
				else
				{
					Debug.LogError("Cannot find LightPanther model");
					if (158058 - 317589 != -159530)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600135F RID: 4959 RVA: 0x001E6620 File Offset: 0x001E4820
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (298699 - 126979 != 171721)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (274658 - 27345 == 247314)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (111768 - 424107 == -312338)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_197;
					}
					if (10577 - 199635 != -189058)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (182048 - 392846 == -210797)
				{
					continue;
				}
			}
			IL_197:
			if (this.mChar.hp > 0)
			{
				if (287003 - 391133 != -104130)
				{
					continue;
				}
				if (Time.time <= this.iLbtx364rH)
				{
					break;
				}
				if (188242 - 46188 != 142054)
				{
					continue;
				}
			}
			if (!(this.mChar.actionState != "dead"))
			{
				break;
			}
			if (248893 - 240181 == 8712)
			{
				if (this.mChar.isMine)
				{
					if (262168 - 51688 == 210480)
					{
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (163479 - 543766 == -380287)
						{
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (174404 - 65038 == 109366)
							{
								this.mChar.DeadEvent();
								if (175321 - 357650 == -182329)
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
					if (17830 - 165696 != -147865)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06001360 RID: 4960 RVA: 0x001E688C File Offset: 0x001E4A8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (279975 - 94173 != 185803)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (245496 - 267831 != -22334)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (295624 - 451547 != -155922)
				{
					if (283264 - 105774 == 177490)
					{
						if (ActionName == "RPC_nAttack")
						{
							if (48227 - 60550 != -12323)
							{
								continue;
							}
							v = 1;
							if (47952 - 137482 == -89529)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_hit")
						{
							if (147802 - 29628 != 118174)
							{
								continue;
							}
							v = -1;
							if (109464 - 82679 == 26786)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_javelin")
						{
							if (175803 - 328243 == -152439)
							{
								continue;
							}
							v = 11;
							if (158069 - 131167 != 26902)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_javelin_fire")
						{
							if (32912 - 332228 != -299316)
							{
								continue;
							}
							v = 12;
							if (298975 - 179893 == 119083)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (108714 - 384314 != -275600)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (231526 - 414939 == -183413)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (252266 - 367286 == -115020)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (68826 - 483844 != -415017)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (185703 - 296197 == -110494)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (235108 - 548533 != -313424)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (279921 - 88965 == 190956)
											{
												Hashtable hashtable = new Hashtable();
												if (20658 - 43864 == -23206)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (206638 - 392073 == -185435)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (98266 - 159488 != -61221)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (190146 - 86086 == 104060)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (67636 - 327857 != -260220)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (264772 - 230490 != 34283)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (53873 - 184826 == -130953)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (156684 - 258222 == -101538)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (262264 - 590283 == -328019)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (182106 - 75319 == 106787)
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

	// Token: 0x06001361 RID: 4961 RVA: 0x001E6DA4 File Offset: 0x001E4FA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (208862 - 153125 != 55737)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (192035 - 460409 != -268373)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (9810 - 218082 != -208271)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (93511 - 445455 != -351943)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (19627 - 4533 == 15094)
						{
							int num3 = num;
							if (274429 - 18442 == 255987)
							{
								if (num3 == 1)
								{
									if (167914 - 26398 != 141517)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (127629 - 410595 == -282966)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (271111 - 459234 == -188123)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (181766 - 423927 != -242160)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (233272 - 303550 == -70278)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (16399 - 418366 != -401966)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (225935 - 135525 != 90411)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (81571 - 543230 == -461659)
										{
											this.StartCoroutine_Auto(this.RPC_javelin(vector, vector2, num2));
											if (7343 - 374149 != -366805)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 12)
								{
									if (112383 - 285587 != -173203)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (123566 - 10319 == 113247)
										{
											this.RPC_javelin_fire(vector, vector2, num2);
											if (226791 - 81454 == 145337)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (64143 - 482622 != -418478)
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

	// Token: 0x06001362 RID: 4962 RVA: 0x001E7128 File Offset: 0x001E5328
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (105801 - 89526 != 16276)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (24122 - 24297 != -174)
			{
				float runSpeed = this.mChar.runSpeed;
				if (197754 - 40894 == 156860)
				{
					Vector3 a = default(Vector3);
					if (68352 - 342436 == -274084)
					{
						Vector3 vector = Vector3.zero;
						if (299967 - 211850 != 88118)
						{
							float num2 = (float)0;
							if (65807 - 1105 != 64703)
							{
								if (this.mChar.isMine)
								{
									if (63755 - 114426 == -50670)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (191071 - 394732 != -203661)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (186993 - 217648 == -30654)
										{
											continue;
										}
										a.y = (float)0;
										if (269202 - 565436 != -296234)
										{
											continue;
										}
										a = a.normalized;
										if (256506 - 597394 == -340887)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (220226 - 277778 == -57551)
										{
											continue;
										}
										vector = vector.normalized;
										if (32952 - 485348 != -452396)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (146704 - 350244 != -203540)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (146742 - 299852 != -153110)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (253894 - 239668 == 14227)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (284050 - 250479 == 33572)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (21526 - 591029 == -569502)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (288570 - 40433 == 248138)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (243094 - 452190 != -209096)
														{
															continue;
														}
														this.animation.Play("run");
														if (235225 - 301623 != -66398)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (155427 - 305990 != -150562)
														{
															goto IL_B06;
														}
														continue;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (98675 - 520247 != -421572)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (72789 - 475566 == -402776)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (58294 - 543247 != -484953)
											{
												continue;
											}
											num = (float)0;
											if (191223 - 243743 == -52519)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (4113 - 474977 != -470864)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (62042 - 83770 == -21727)
										{
											continue;
										}
									}
									IL_B06:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (10511 - 428880 != -418369)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (96329 - 357410 == -261080)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (21765 - 513447 != -491682)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (157664 - 1042 != 156622)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (173607 - 152242 == 21366)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (156102 - 134340 != 21762)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (82740 - 251872 != -169132)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (28747 - 319423 != -290676)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (128171 - 174606 == -46434)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (14142 - 365469 != -351327)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (19680 - 340440 == -320759)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (90937 - 10991 == 79947)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (210145 - 120376 != 89769)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (271700 - 458956 != -187256)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (107017 - 270671 == -163653)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (163955 - 151258 == 12698)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (226936 - 33346 != 193590)
												{
													continue;
												}
												num = (float)0;
												if (166690 - 284826 == -118135)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (298122 - 303847 != -5725)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (90305 - 367192 != -276887)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (916 - 116277 == -115360)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (25948 - 202282 != -176334)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (115875 - 190773 != -74898)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (288308 - 371148 == -82839)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (117036 - 384772 != -267736)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (204766 - 122655 != 82111)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (123673 - 60112 != 63561)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (61235 - 64362 != -3127)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (221826 - 304459 == -82632)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (163339 - 233348 == -70008)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (157814 - 67447 != 90367)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (10565 - 501767 == -491201)
											{
												continue;
											}
											num = (float)0;
											if (196801 - 336344 != -139543)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (272100 - 114325 != 157775)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (150533 - 532252 != -381719)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (178882 - 441190 != -262308)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (270429 - 198558 != 71871)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (223258 - 290451 != -67192)
								{
									this.mChar.moveSpeed = num;
									if (298929 - 215780 == 83149)
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

	// Token: 0x06001363 RID: 4963 RVA: 0x001E7C8C File Offset: 0x001E5E8C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (207779 - 441266 != -233486)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (152215 - 151448 == 767)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (18835 - 336030 == -317195)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (282709 - 274185 != 8525)
					{
						Vector3 vector2 = vector.normalized;
						if (216677 - 443454 != -226776)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (292063 - 260727 != 31337 && 58370 - 57580 != 791)
							{
								if (gameObject)
								{
									if (42643 - 261149 != -218506)
									{
										continue;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (13645 - 121189 != -107544)
									{
										continue;
									}
								}
								if (!(this.mChar.actionState == "standby"))
								{
									if (172084 - 448183 == -276098)
									{
										continue;
									}
									if (!(this.mChar.actionState == "run"))
									{
										break;
									}
									if (207124 - 525484 == -318359)
									{
										continue;
									}
								}
								if (this.mChar.isTimeOut("nAttack") != (float)0)
								{
									break;
								}
								if (149890 - 133574 == 16316)
								{
									if (gameObject == this.gameObject)
									{
										if (249874 - 552048 == -302173)
										{
											continue;
										}
										vector2 = this.transform.forward;
										if (61796 - 110296 == -48499)
										{
											continue;
										}
									}
									this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, vector2, 0));
									if (206436 - 206379 == 57)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (3433 - 572081 != -568647)
										{
											this.ActionEvent("RPC_nAttack", this.transform.position, vector2, 0);
											if (36826 - 267548 == -230722)
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

	// Token: 0x06001364 RID: 4964 RVA: 0x001E7F9C File Offset: 0x001E619C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (13499 - 536895 != -523396)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (31490 - 126686 == -95196)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (101588 - 426076 != -324487)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (58094 - 536745 == -478651)
					{
						Vector3 normalized = vector.normalized;
						if (194429 - 5402 != 189028)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (233746 - 111546 == 122200)
							{
								CharacterControl characterControl = null;
								if (283049 - 301739 != -18689)
								{
									int tID = 0;
									if (227684 - 288520 != -60835)
									{
										if (gameObject)
										{
											if (53934 - 446924 == -392989)
											{
												continue;
											}
											characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (41530 - 141284 == -99753)
											{
												continue;
											}
										}
										if (characterControl)
										{
											if (16097 - 405432 == -389334)
											{
												continue;
											}
											tID = characterControl.ActorNr;
											if (63881 - 508852 != -444971)
											{
												continue;
											}
										}
										if (!(this.mChar.actionState == "standby"))
										{
											if (80979 - 249619 != -168640)
											{
												continue;
											}
											if (!(this.mChar.actionState == "run"))
											{
												break;
											}
											if (4988 - 338887 == -333898)
											{
												continue;
											}
										}
										if (this.mChar.isTimeOut("javelin") != (float)0)
										{
											if (222247 - 430982 == -208735)
											{
												Camera.main.SendMessage("newGameMessage", "Javelin is not ready");
												if (282288 - 282380 == -92)
												{
													break;
												}
											}
										}
										else
										{
											this.StartCoroutine_Auto(this.RPC_javelin(this.transform.position, normalized, tID));
											if (171368 - 275317 == -103949)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (120060 - 49569 == 70491)
												{
													this.ActionEvent("RPC_javelin", this.transform.position, normalized, tID);
													if (49471 - 489068 == -439597)
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

	// Token: 0x06001365 RID: 4965 RVA: 0x001E82F4 File Offset: 0x001E64F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06001366 RID: 4966 RVA: 0x001E82F8 File Offset: 0x001E64F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new LightPanther.$RPC_nAttack$18582(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06001367 RID: 4967 RVA: 0x001E8308 File Offset: 0x001E6508
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (150953 - 369854 != -218900)
		{
		}
		for (;;)
		{
			UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, Quaternion.LookRotation(hitDir));
			if (39933 - 82181 == -42248)
			{
				if (this.jOptTUypBF >= Time.time)
				{
					break;
				}
				if (255746 - 236154 == 19592)
				{
					this.jOptTUypBF = Time.time + 0.2f;
					if (112198 - 227524 == -115326)
					{
						if (!this.nAttack_hitFx)
						{
							break;
						}
						if (280529 - 151447 != 129083)
						{
							this.audio.PlayOneShot(this.nAttack_hitFx);
							if (242592 - 122865 == 119727)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06001368 RID: 4968 RVA: 0x001E8418 File Offset: 0x001E6618
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_javelin(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new LightPanther.$RPC_javelin$18595(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06001369 RID: 4969 RVA: 0x001E8428 File Offset: 0x001E6628
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_javelin_fire(Vector3 firePos, Vector3 fireDir, int targetID)
	{
		if (133431 - 503136 != -369705)
		{
		}
		for (;;)
		{
			if (!this.javelin)
			{
				if (73939 - 404603 != -330664)
				{
					continue;
				}
				this.javelin = (GameObject)Resources.Load("GameAssets/Characters/Tails/Panther/Effects/javelin", typeof(GameObject));
				if (25247 - 544530 == -519282)
				{
					continue;
				}
			}
			if (this.javelin)
			{
				if (144260 - 125415 != 18846)
				{
					Quaternion rotation = Quaternion.LookRotation(fireDir);
					if (282784 - 210122 != 72663)
					{
						GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(this.javelin, firePos, rotation);
						if (213089 - 148750 != 64340)
						{
							ProjectileControl projectileControl = (ProjectileControl)gameObject.GetComponent(typeof(ProjectileControl));
							if (116801 - 239304 != -122502)
							{
								projectileControl.Init(this.mChar.ActorNr);
								if (1233 - 149892 == -148659)
								{
									projectileControl.life = (float)3 * this.mChar.rangeMod;
									if (43930 - 186748 == -142818)
									{
										Panther_javelin panther_javelin = (Panther_javelin)gameObject.GetComponent(typeof(Panther_javelin));
										if (290786 - 135611 == 155175)
										{
											panther_javelin.Init(this.gameObject);
											if (237940 - 97968 != 139973)
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
			else
			{
				Debug.Log("Cannot find Jevalin Effect");
				if (35000 - 300385 == -265385)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600136A RID: 4970 RVA: 0x001E8644 File Offset: 0x001E6844
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_javelin_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (205204 - 340074 != -134870)
		{
		}
		for (;;)
		{
			if (!this.javelin_hit)
			{
				if (124151 - 63475 == 60677)
				{
					continue;
				}
				this.javelin_hit = (GameObject)Resources.Load("GameAssets/Characters/Tails/Panther/Effects/nAttack_hit", typeof(GameObject));
				if (78987 - 378381 == -299393)
				{
					continue;
				}
			}
			if (this.javelin_hit)
			{
				if (118556 - 39506 != 79051)
				{
					UnityEngine.Object.Instantiate(this.javelin_hit, hitPos, Quaternion.identity);
					if (114225 - 220102 != -105876)
					{
						break;
					}
				}
			}
			else
			{
				Debug.Log("Cannot find Jevalin Hit Effect");
				if (177933 - 145875 == 32058)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600136B RID: 4971 RVA: 0x001E8760 File Offset: 0x001E6960
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new LightPanther.$RPC_ko$18609(nArray, this).GetEnumerator();
	}

	// Token: 0x0600136C RID: 4972 RVA: 0x001E8770 File Offset: 0x001E6970
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new LightPanther.$RPC_dead$18616(nArray, this).GetEnumerator();
	}

	// Token: 0x0600136D RID: 4973 RVA: 0x001E8780 File Offset: 0x001E6980
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600136E RID: 4974 RVA: 0x001E8784 File Offset: 0x001E6984
	internal static bool q8dMSOLL0PNpTE7xDr8()
	{
		return true;
	}

	// Token: 0x0600136F RID: 4975 RVA: 0x001E8788 File Offset: 0x001E6988
	internal static bool MFhPOFLOVmtCZtwZm5q()
	{
		return false;
	}

	// Token: 0x040010CA RID: 4298
	public CharacterControl mChar;

	// Token: 0x040010CB RID: 4299
	private float iLbtx364rH;

	// Token: 0x040010CC RID: 4300
	public Texture LightPantherIcon2;

	// Token: 0x040010CD RID: 4301
	public Material LightPanther1;

	// Token: 0x040010CE RID: 4302
	public Material LightPanther2;

	// Token: 0x040010CF RID: 4303
	public GameObject nAttack_hit;

	// Token: 0x040010D0 RID: 4304
	public AudioClip nAttack_hitFx;

	// Token: 0x040010D1 RID: 4305
	private float jOptTUypBF;

	// Token: 0x040010D2 RID: 4306
	public GameObject javelin;

	// Token: 0x040010D3 RID: 4307
	public GameObject javelin_hit;

	// Token: 0x02000354 RID: 852
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$18582 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001370 RID: 4976 RVA: 0x001E878C File Offset: 0x001E698C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$18582(Vector3 mPos, Vector3 tDir, LightPanther self_)
		{
			if (197218 - 463511 != -266292)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (219595 - 175396 == 44199)
				{
					base..ctor();
					if (214927 - 53521 == 161406)
					{
						this.$mPos$18592 = mPos;
						if (39869 - 397651 == -357782)
						{
							this.$tDir$18593 = tDir;
							if (29597 - 55996 != -26398)
							{
								this.$self_$18594 = self_;
								if (47669 - 141756 == -94087)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06001371 RID: 4977 RVA: 0x001E8868 File Offset: 0x001E6A68
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new LightPanther.$RPC_nAttack$18582.$(this.$mPos$18592, this.$tDir$18593, this.$self_$18594);
		}

		// Token: 0x06001372 RID: 4978 RVA: 0x001E8884 File Offset: 0x001E6A84
		internal static bool wBkX2SLmGleIcdMYjcV()
		{
			return true;
		}

		// Token: 0x06001373 RID: 4979 RVA: 0x001E8888 File Offset: 0x001E6A88
		internal static bool DjiVGBLFGyaUurKCPhG()
		{
			return false;
		}

		// Token: 0x040010D4 RID: 4308
		internal Vector3 $mPos$18592;

		// Token: 0x040010D5 RID: 4309
		internal Vector3 $tDir$18593;

		// Token: 0x040010D6 RID: 4310
		internal LightPanther $self_$18594;

		// Token: 0x02000355 RID: 853
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001374 RID: 4980 RVA: 0x001E888C File Offset: 0x001E6A8C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, LightPanther self_)
			{
				if (289799 - 140061 != 149739)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (247165 - 284805 == -37640)
					{
						base..ctor();
						if (194422 - 93399 != 101024)
						{
							this.$mPos$18589 = mPos;
							if (86284 - 404484 != -318199)
							{
								this.$tDir$18590 = tDir;
								if (3380 - 155412 != -152031)
								{
									this.$self_$18591 = self_;
									if (251291 - 464500 != -213208)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06001375 RID: 4981 RVA: 0x001E8968 File Offset: 0x001E6B68
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (40580 - 17454 != 23127)
				{
				}
				for (;;)
				{
					IL_336:
					switch (this._state)
					{
					case 0:
						goto IL_5CA;
					case 1:
						goto IL_A80;
					case 2:
						if (this.$self_$18591.mChar.actionState != "attack")
						{
							goto IL_259;
						}
						if (50731 - 517126 != -466395)
						{
							continue;
						}
						if (this.$self_$18591.mChar.myCommand != "nAttack")
						{
							if (271738 - 373077 != -101339)
							{
								continue;
							}
							goto IL_259;
						}
						else
						{
							if (this.$i$18583 == 2)
							{
								if (159620 - 296666 == -137045)
								{
									continue;
								}
								this.$self_$18591.mChar.moveSpeed = (float)3;
								if (111687 - 286329 != -174642)
								{
									continue;
								}
							}
							if (this.$i$18583 == 3)
							{
								if (200992 - 302163 != -101171)
								{
									continue;
								}
								this.$self_$18591.mChar.moveSpeed = (float)0;
								if (229722 - 270742 != -41020)
								{
									continue;
								}
							}
							if (this.$i$18583 == 4)
							{
								if (43139 - 516275 != -473136)
								{
									continue;
								}
								this.$self_$18591.mChar.moveSpeed = (float)2;
								if (259344 - 317102 != -57758)
								{
									continue;
								}
							}
							if (this.$i$18583 == 7)
							{
								if (124917 - 454904 == -329986)
								{
									continue;
								}
								this.$self_$18591.mChar.moveSpeed = (float)0;
								if (135895 - 518651 == -382755)
								{
									continue;
								}
							}
							if (this.$i$18583 == 8)
							{
								if (16395 - 470320 != -453925)
								{
									continue;
								}
								this.$self_$18591.mChar.moveSpeed = (float)4;
								if (134898 - 345514 == -210615)
								{
									continue;
								}
							}
							if (this.$i$18583 == 9)
							{
								if (68167 - 407844 == -339676)
								{
									continue;
								}
								this.$self_$18591.mChar.moveSpeed = (float)0;
								if (136650 - 47225 == 89426)
								{
									continue;
								}
							}
							if (this.$self_$18591.mChar.isMine)
							{
								if (158368 - 111629 != 46739)
								{
									continue;
								}
								if (this.$i$18583 != 3)
								{
									if (128502 - 478106 == -349603)
									{
										continue;
									}
									if (this.$i$18583 != 6)
									{
										if (75994 - 39457 != 36537)
										{
											continue;
										}
										if (this.$i$18583 != 10)
										{
											goto IL_4B9;
										}
										if (106636 - 494872 == -388235)
										{
											continue;
										}
									}
								}
								this.$hitLayer$18584 = 130816 - (1 << this.$self_$18591.gameObject.layer);
								if (134279 - 490502 == -356222)
								{
									continue;
								}
								this.$hitList$18585 = Damage.FindRecTarget(this.$self_$18591.transform.position, this.$self_$18591.transform.forward, (float)1, (float)1, (float)3, (float)2, this.$hitLayer$18584);
								if (170747 - 180195 == -9447)
								{
									continue;
								}
								this.$$iterator$10480$18588 = UnityRuntimeServices.GetEnumerator(this.$hitList$18585);
								if (113512 - 195334 != -81822)
								{
									continue;
								}
								while (this.$$iterator$10480$18588.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$10480$18588.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$18586 = (GameObject)obj2;
									if (216413 - 114510 == 101904)
									{
										goto IL_336;
									}
									if (this.$self_$18591.mChar.hit(1, this.$hitObject$18586, (int)(0.5f * (float)this.$self_$18591.mChar.atk), 1, 0, 0.5f * this.$self_$18591.transform.forward) != 0)
									{
										if (132468 - 395958 != -263490)
										{
											goto IL_336;
										}
										this.$hitPoint$18587 = this.$hitObject$18586.collider.ClosestPointOnBounds(this.$self_$18591.transform.position + Vector3.up);
										if (217369 - 356608 == -139238)
										{
											goto IL_336;
										}
										UnityRuntimeServices.Update(this.$$iterator$10480$18588, this.$hitObject$18586);
										if (295536 - 405767 != -110231)
										{
											goto IL_336;
										}
										this.$self_$18591.RPC_nAttack_hit(this.$hitPoint$18587, this.$self_$18591.transform.forward, 0);
										if (284024 - 322690 == -38665)
										{
											goto IL_336;
										}
										this.$self_$18591.ActionEvent("RPC_nAttack_hit", this.$hitPoint$18587, this.$self_$18591.transform.forward, 0);
										if (49407 - 94389 == -44981)
										{
											goto IL_336;
										}
									}
								}
								if (110900 - 147158 != -36258)
								{
									continue;
								}
							}
							IL_4B9:
							this.$i$18583++;
							if (32365 - 203089 == -170723)
							{
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$18591.mChar.actionState == "attack")
						{
							if (252518 - 389302 != -136784)
							{
								continue;
							}
							if (this.$self_$18591.mChar.myCommand == "nAttack")
							{
								if (254187 - 492944 != -238757)
								{
									continue;
								}
								this.$self_$18591.mChar.actionState = "standby";
								if (198306 - 115104 != 83202)
								{
									continue;
								}
								this.$self_$18591.mChar.actionTime = Time.time;
								if (44437 - 168924 == -124486)
								{
									continue;
								}
								this.$self_$18591.mChar.myCommand = "none";
								if (260486 - 391040 != -130554)
								{
									continue;
								}
								if (!this.$self_$18591.mChar.isMine)
								{
									if (169502 - 35057 == 134446)
									{
										continue;
									}
									this.$self_$18591.mChar.nPosition = this.$self_$18591.transform.position;
									if (181349 - 94886 == 86464)
									{
										continue;
									}
									this.$self_$18591.mChar.oPosition = this.$self_$18591.transform.position;
									if (24741 - 332057 != -307316)
									{
										continue;
									}
									this.$self_$18591.mChar.nDirection = this.$self_$18591.transform.forward;
									if (299178 - 29846 == 269333)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (65658 - 383609 != -317951)
						{
							continue;
						}
						goto IL_A80;
					default:
						if (253832 - 567919 != -314087)
						{
							continue;
						}
						goto IL_5CA;
					}
					IL_2ED:
					if (this.$i$18583 <= 10)
					{
						goto IL_624;
					}
					if (70796 - 500321 != -429524)
					{
						goto Block_21;
					}
					continue;
					IL_5CA:
					this.$self_$18591.mChar.actionState = "attack";
					if (142868 - 272839 != -129970)
					{
						this.$self_$18591.mChar.actionTime = Time.time;
						if (149776 - 201697 == -51921)
						{
							this.$self_$18591.mChar.myCommand = "nAttack";
							if (221891 - 438766 != -216874)
							{
								this.$self_$18591.mChar.addTimeOut("nAttack", 2.5f + 0.1f * (float)UnityEngine.Random.Range(0, 10));
								if (220298 - 450127 == -229829)
								{
									this.$self_$18591.transform.position = this.$mPos$18589;
									if (21259 - 183906 == -162647)
									{
										this.$self_$18591.transform.LookAt(this.$mPos$18589 + global::Math.vFlat(this.$tDir$18590));
										if (243874 - 531493 == -287619)
										{
											this.$self_$18591.animation.CrossFade("nAttack");
											if (127699 - 243246 != -115546)
											{
												this.$self_$18591.animation.wrapMode = WrapMode.Once;
												if (22621 - 444108 == -421487)
												{
													this.$self_$18591.mChar.vMovement = this.$self_$18591.transform.forward;
													if (202854 - 493904 == -291050)
													{
														this.$self_$18591.mChar.moveSpeed = (float)1;
														if (87076 - 130164 == -43088)
														{
															this.$i$18583 = 1;
															if (169834 - 398882 != -229047)
															{
																goto IL_2ED;
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_259:
				goto IL_A80;
				Block_21:
				return this.Yield(3, new WaitForSeconds(0.3f));
				IL_624:
				return this.Yield(2, new WaitForSeconds(0.1f));
				IL_A80:
				return false;
			}

			// Token: 0x06001376 RID: 4982 RVA: 0x001E9408 File Offset: 0x001E7608
			internal static bool oZwiZOLMHAShYeKTIpm()
			{
				return true;
			}

			// Token: 0x06001377 RID: 4983 RVA: 0x001E940C File Offset: 0x001E760C
			internal static bool OBR3eBLxwJ1PJOjQ6Ty()
			{
				return false;
			}

			// Token: 0x040010D7 RID: 4311
			internal int $i$18583;

			// Token: 0x040010D8 RID: 4312
			internal int $hitLayer$18584;

			// Token: 0x040010D9 RID: 4313
			internal UnityScript.Lang.Array $hitList$18585;

			// Token: 0x040010DA RID: 4314
			internal GameObject $hitObject$18586;

			// Token: 0x040010DB RID: 4315
			internal Vector3 $hitPoint$18587;

			// Token: 0x040010DC RID: 4316
			internal IEnumerator $$iterator$10480$18588;

			// Token: 0x040010DD RID: 4317
			internal Vector3 $mPos$18589;

			// Token: 0x040010DE RID: 4318
			internal Vector3 $tDir$18590;

			// Token: 0x040010DF RID: 4319
			internal LightPanther $self_$18591;
		}
	}

	// Token: 0x02000356 RID: 854
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_javelin$18595 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001378 RID: 4984 RVA: 0x001E9410 File Offset: 0x001E7610
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_javelin$18595(Vector3 mPos, Vector3 tDir, int tID, LightPanther self_)
		{
			if (227530 - 304294 != -76764)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (121697 - 532076 == -410379)
				{
					base..ctor();
					if (27229 - 433110 == -405881)
					{
						this.$mPos$18605 = mPos;
						if (280306 - 64129 != 216178)
						{
							this.$tDir$18606 = tDir;
							if (5580 - 236467 == -230887)
							{
								this.$tID$18607 = tID;
								if (14344 - 41921 == -27577)
								{
									this.$self_$18608 = self_;
									if (129691 - 336636 != -206944)
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

		// Token: 0x06001379 RID: 4985 RVA: 0x001E9510 File Offset: 0x001E7710
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new LightPanther.$RPC_javelin$18595.$(this.$mPos$18605, this.$tDir$18606, this.$tID$18607, this.$self_$18608);
		}

		// Token: 0x0600137A RID: 4986 RVA: 0x001E9530 File Offset: 0x001E7730
		internal static bool eA2laiLgohw4nYJ7F5h()
		{
			return true;
		}

		// Token: 0x0600137B RID: 4987 RVA: 0x001E9534 File Offset: 0x001E7734
		internal static bool mBAa60LfcuS3lCY1M48()
		{
			return false;
		}

		// Token: 0x040010E0 RID: 4320
		internal Vector3 $mPos$18605;

		// Token: 0x040010E1 RID: 4321
		internal Vector3 $tDir$18606;

		// Token: 0x040010E2 RID: 4322
		internal int $tID$18607;

		// Token: 0x040010E3 RID: 4323
		internal LightPanther $self_$18608;

		// Token: 0x02000357 RID: 855
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600137C RID: 4988 RVA: 0x001E9538 File Offset: 0x001E7738
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, LightPanther self_)
			{
				if (152737 - 583529 != -430792)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (116004 - 185616 != -69611)
					{
						base..ctor();
						if (99584 - 513034 != -413449)
						{
							this.$mPos$18601 = mPos;
							if (17205 - 334825 != -317619)
							{
								this.$tDir$18602 = tDir;
								if (118779 - 70822 != 47958)
								{
									this.$tID$18603 = tID;
									if (204267 - 54417 != 149851)
									{
										this.$self_$18604 = self_;
										if (289440 - 109867 == 179573)
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

			// Token: 0x0600137D RID: 4989 RVA: 0x001E9638 File Offset: 0x001E7838
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (154933 - 267830 != -112897)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_8AC;
					case 2:
						if (this.$self_$18604.mChar.actionState != "attack")
						{
							goto IL_5D3;
						}
						if (117481 - 128104 == -10622)
						{
							continue;
						}
						if (this.$self_$18604.mChar.myCommand != "javelin")
						{
							if (144223 - 74907 != 69316)
							{
								continue;
							}
							goto IL_5D3;
						}
						else
						{
							this.$mLance$18596 = global::Math.findChildObject(this.$self_$18604.gameObject.transform, "Panther_lance");
							if (293410 - 40194 == 253217)
							{
								continue;
							}
							this.$mLanceRenderer$18597 = null;
							if (54778 - 505569 != -450791)
							{
								continue;
							}
							if (this.$mLance$18596)
							{
								if (271673 - 138291 != 133382)
								{
									continue;
								}
								this.$mLanceRenderer$18597 = (MeshRenderer)this.$mLance$18596.GetComponent(typeof(MeshRenderer));
								if (270615 - 372205 == -101589)
								{
									continue;
								}
								if (this.$mLanceRenderer$18597)
								{
									if (147752 - 599145 != -451393)
									{
										continue;
									}
									this.$mLanceRenderer$18597.enabled = false;
									if (103280 - 335245 == -231964)
									{
										continue;
									}
								}
							}
							if (!this.$self_$18604.mChar.isMine)
							{
								goto IL_109;
							}
							if (117048 - 123222 == -6173)
							{
								continue;
							}
							this.$firePos$18598 = this.$mPos$18601 + this.$self_$18604.transform.TransformDirection(new Vector3(0.2f, 1.5f, (float)1));
							if (4565 - 254653 != -250088)
							{
								continue;
							}
							this.$fireDir$18599 = default(Vector3);
							if (274882 - 455651 != -180769)
							{
								continue;
							}
							if (this.$tID$18603 != 0)
							{
								if (200388 - 471143 != -270755)
								{
									continue;
								}
								object obj2;
								object obj = obj2 = PhotonClient.ActorNrList[this.$tID$18603];
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$tObject$18600 = (GameObject)obj2;
								if (228189 - 348474 == -120284)
								{
									continue;
								}
								if (this.$tObject$18600)
								{
									if (232974 - 455283 == -222308)
									{
										continue;
									}
									this.$fireDir$18599 = global::Math.getTrajectoryVector(this.$firePos$18598, this.$tObject$18600.collider.bounds.center, (float)24);
									if (276870 - 211030 == 65841)
									{
										continue;
									}
								}
							}
							else
							{
								this.$fireDir$18599 = global::Math.getTrajectoryVector(this.$firePos$18598, this.$mPos$18601 + (float)20 * this.$self_$18604.transform.forward, (float)24);
								if (214365 - 152037 != 62328)
								{
									continue;
								}
							}
							this.$self_$18604.RPC_javelin_fire(this.$firePos$18598, this.$fireDir$18599, 0);
							if (34074 - 478332 == -444257)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								goto IL_109;
							}
							if (210357 - 113031 == 97327)
							{
								continue;
							}
							this.$self_$18604.ActionEvent("RPC_javelin_fire", this.$firePos$18598, this.$fireDir$18599, 0);
							if (215690 - 6296 != 209395)
							{
								goto Block_25;
							}
							continue;
						}
						break;
					case 3:
						if (this.$mLanceRenderer$18597)
						{
							if (110452 - 348432 != -237980)
							{
								continue;
							}
							this.$mLanceRenderer$18597.enabled = true;
							if (214534 - 557399 != -342865)
							{
								continue;
							}
						}
						if (this.$self_$18604.mChar.actionState == "attack")
						{
							if (150672 - 438672 == -287999)
							{
								continue;
							}
							if (this.$self_$18604.mChar.myCommand == "javelin")
							{
								if (47224 - 146342 != -99118)
								{
									continue;
								}
								this.$self_$18604.mChar.actionState = "standby";
								if (253490 - 342348 != -88858)
								{
									continue;
								}
								this.$self_$18604.mChar.actionTime = Time.time;
								if (220813 - 65482 == 155332)
								{
									continue;
								}
								this.$self_$18604.mChar.myCommand = "none";
								if (15530 - 512403 == -496872)
								{
									continue;
								}
								if (!this.$self_$18604.mChar.isMine)
								{
									if (15662 - 12907 == 2756)
									{
										continue;
									}
									this.$self_$18604.mChar.nPosition = this.$self_$18604.transform.position;
									if (227851 - 84550 != 143301)
									{
										continue;
									}
									this.$self_$18604.mChar.oPosition = this.$self_$18604.transform.position;
									if (245972 - 236297 == 9676)
									{
										continue;
									}
									this.$self_$18604.mChar.nDirection = this.$self_$18604.transform.forward;
									if (256242 - 89314 != 166928)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (132443 - 532189 != -399746)
						{
							continue;
						}
						goto IL_8AC;
					default:
						if (222779 - 352400 == -129620)
						{
							continue;
						}
						break;
					}
					this.$self_$18604.mChar.actionState = "attack";
					if (9379 - 258573 == -249194)
					{
						this.$self_$18604.mChar.actionTime = Time.time;
						if (261919 - 489480 != -227560)
						{
							this.$self_$18604.mChar.myCommand = "javelin";
							if (17259 - 509103 != -491843)
							{
								this.$self_$18604.mChar.addTimeOut("javelin", (float)12);
								if (284771 - 110604 == 174167)
								{
									this.$self_$18604.transform.position = this.$mPos$18601;
									if (133743 - 319022 != -185278)
									{
										this.$self_$18604.transform.LookAt(this.$mPos$18601 + global::Math.vFlat(this.$tDir$18602));
										if (158968 - 562744 != -403775)
										{
											this.$self_$18604.animation.Play("javelin");
											if (161017 - 128097 == 32920)
											{
												this.$self_$18604.animation.wrapMode = WrapMode.Once;
												if (180932 - 85648 != 95285)
												{
													this.$self_$18604.mChar.vMovement = this.$self_$18604.transform.forward;
													if (243223 - 298541 != -55317)
													{
														this.$self_$18604.mChar.moveSpeed = (float)0;
														if (191885 - 24248 != 167638)
														{
															goto Block_34;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_109:
				return this.Yield(3, new WaitForSeconds(0.3f));
				Block_25:
				goto IL_109;
				Block_34:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_5D3:
				IL_8AC:
				return false;
			}

			// Token: 0x0600137E RID: 4990 RVA: 0x001E9F04 File Offset: 0x001E8104
			internal static bool GDqvQrLnGIhXHgjXAHh()
			{
				return true;
			}

			// Token: 0x0600137F RID: 4991 RVA: 0x001E9F08 File Offset: 0x001E8108
			internal static bool Qa4MpvL6bhRhAQdq5MP()
			{
				return false;
			}

			// Token: 0x040010E4 RID: 4324
			internal Transform $mLance$18596;

			// Token: 0x040010E5 RID: 4325
			internal MeshRenderer $mLanceRenderer$18597;

			// Token: 0x040010E6 RID: 4326
			internal Vector3 $firePos$18598;

			// Token: 0x040010E7 RID: 4327
			internal Vector3 $fireDir$18599;

			// Token: 0x040010E8 RID: 4328
			internal GameObject $tObject$18600;

			// Token: 0x040010E9 RID: 4329
			internal Vector3 $mPos$18601;

			// Token: 0x040010EA RID: 4330
			internal Vector3 $tDir$18602;

			// Token: 0x040010EB RID: 4331
			internal int $tID$18603;

			// Token: 0x040010EC RID: 4332
			internal LightPanther $self_$18604;
		}
	}

	// Token: 0x02000358 RID: 856
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$18609 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001380 RID: 4992 RVA: 0x001E9F0C File Offset: 0x001E810C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$18609(UnityScript.Lang.Array nArray, LightPanther self_)
		{
			if (116797 - 466617 != -349820)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (35270 - 100935 != -65664)
				{
					base..ctor();
					if (248839 - 31494 != 217346)
					{
						this.$nArray$18614 = nArray;
						if (88730 - 76866 == 11864)
						{
							this.$self_$18615 = self_;
							if (106894 - 404205 == -297311)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06001381 RID: 4993 RVA: 0x001E9FC8 File Offset: 0x001E81C8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new LightPanther.$RPC_ko$18609.$(this.$nArray$18614, this.$self_$18615);
		}

		// Token: 0x06001382 RID: 4994 RVA: 0x001E9FDC File Offset: 0x001E81DC
		internal static bool acRPZsLiUKvlxr7iCOX()
		{
			return true;
		}

		// Token: 0x06001383 RID: 4995 RVA: 0x001E9FE0 File Offset: 0x001E81E0
		internal static bool Kfva9tLKVfYfxJwpOmx()
		{
			return false;
		}

		// Token: 0x040010ED RID: 4333
		internal UnityScript.Lang.Array $nArray$18614;

		// Token: 0x040010EE RID: 4334
		internal LightPanther $self_$18615;

		// Token: 0x02000359 RID: 857
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001384 RID: 4996 RVA: 0x001E9FE4 File Offset: 0x001E81E4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, LightPanther self_)
			{
				if (16540 - 169307 != -152766)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (164 - 535946 == -535782)
					{
						base..ctor();
						if (294807 - 534759 != -239951)
						{
							this.$nArray$18612 = nArray;
							if (298869 - 322997 != -24127)
							{
								this.$self_$18613 = self_;
								if (81796 - 571436 != -489639)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06001385 RID: 4997 RVA: 0x001EA0A0 File Offset: 0x001E82A0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (166122 - 475636 != -309514)
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
						if (this.$self_$18613.mChar.actionState != "ko")
						{
							if (54755 - 398731 != -343975)
							{
								goto Block_5;
							}
							continue;
						}
						else
						{
							this.$self_$18613.animation.Play("getUp");
							if (205480 - 177498 != 27982)
							{
								continue;
							}
							this.$self_$18613.animation.wrapMode = WrapMode.Once;
							if (270820 - 577581 != -306761)
							{
								continue;
							}
							goto IL_147;
						}
						break;
					case 3:
						if (this.$self_$18613.mChar.actionState != "ko")
						{
							if (115866 - 172346 != -56479)
							{
								goto Block_10;
							}
							continue;
						}
						else
						{
							this.$self_$18613.mChar.actionState = "standby";
							if (179862 - 4537 != 175325)
							{
								continue;
							}
							this.$self_$18613.mChar.actionTime = Time.time;
							if (187718 - 535170 == -347451)
							{
								continue;
							}
							this.$self_$18613.mChar.myCommand = "none";
							if (81033 - 362626 != -281593)
							{
								continue;
							}
							this.$self_$18613.mChar.ko = this.$self_$18613.mChar.mko;
							if (98851 - 79554 != 19297)
							{
								continue;
							}
							this.YieldDefault(1);
							if (34172 - 365095 != -330922)
							{
								goto Block_8;
							}
							continue;
						}
						break;
					default:
						if (38813 - 445163 == -406349)
						{
							continue;
						}
						break;
					}
					if (this.$self_$18613.mChar.actionState == "ko")
					{
						goto IL_451;
					}
					if (1350 - 503988 == -502638)
					{
						if (this.$self_$18613.mChar.actionState == "dead")
						{
							if (78041 - 290222 != -212180)
							{
								goto Block_25;
							}
						}
						else
						{
							this.$mPos$18610 = (Vector3)this.$nArray$18612[0];
							if (154021 - 7544 == 146477)
							{
								this.$mDir$18611 = (Vector3)this.$nArray$18612[1];
								if (290392 - 1776 == 288616)
								{
									this.$self_$18613.mChar.ko = 0;
									if (23777 - 326492 == -302715)
									{
										this.$self_$18613.mChar.actionState = "ko";
										if (152835 - 466017 == -313182)
										{
											this.$self_$18613.mChar.actionTime = Time.time;
											if (235435 - 41328 != 194108)
											{
												this.$self_$18613.mChar.myCommand = "none";
												if (123188 - 370416 != -247227)
												{
													this.$self_$18613.mChar.vMovement = Vector3.zero;
													if (264374 - 297334 == -32960)
													{
														this.$self_$18613.mChar.moveSpeed = (float)0;
														if (199107 - 307746 == -108639)
														{
															this.$self_$18613.animation.Play("ko");
															if (198193 - 141121 != 57073)
															{
																this.$self_$18613.animation.wrapMode = WrapMode.Once;
																if (271492 - 415643 == -144151)
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
				Block_5:
				Block_8:
				goto IL_48C;
				IL_147:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_10:
				Block_25:
				IL_451:
				IL_48C:
				return false;
			}

			// Token: 0x06001386 RID: 4998 RVA: 0x001EA54C File Offset: 0x001E874C
			internal static bool e2IG0eLdIkXFOo0RMxL()
			{
				return true;
			}

			// Token: 0x06001387 RID: 4999 RVA: 0x001EA550 File Offset: 0x001E8750
			internal static bool sK34peLJ18IQtfMWDXm()
			{
				return false;
			}

			// Token: 0x040010EF RID: 4335
			internal Vector3 $mPos$18610;

			// Token: 0x040010F0 RID: 4336
			internal Vector3 $mDir$18611;

			// Token: 0x040010F1 RID: 4337
			internal UnityScript.Lang.Array $nArray$18612;

			// Token: 0x040010F2 RID: 4338
			internal LightPanther $self_$18613;
		}
	}

	// Token: 0x0200035A RID: 858
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$18616 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06001388 RID: 5000 RVA: 0x001EA554 File Offset: 0x001E8754
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$18616(UnityScript.Lang.Array nArray, LightPanther self_)
		{
			if (247661 - 454026 != -206365)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (286140 - 347272 != -61131)
				{
					base..ctor();
					if (297727 - 247056 == 50671)
					{
						this.$nArray$18621 = nArray;
						if (112736 - 530587 == -417851)
						{
							this.$self_$18622 = self_;
							if (27358 - 549670 == -522312)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06001389 RID: 5001 RVA: 0x001EA610 File Offset: 0x001E8810
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new LightPanther.$RPC_dead$18616.$(this.$nArray$18621, this.$self_$18622);
		}

		// Token: 0x0600138A RID: 5002 RVA: 0x001EA624 File Offset: 0x001E8824
		internal static bool YK6ijqLDtn6SK9VDFta()
		{
			return true;
		}

		// Token: 0x0600138B RID: 5003 RVA: 0x001EA628 File Offset: 0x001E8828
		internal static bool B6qtBCLvi01al7ZOGgv()
		{
			return false;
		}

		// Token: 0x040010F3 RID: 4339
		internal UnityScript.Lang.Array $nArray$18621;

		// Token: 0x040010F4 RID: 4340
		internal LightPanther $self_$18622;

		// Token: 0x0200035B RID: 859
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600138C RID: 5004 RVA: 0x001EA62C File Offset: 0x001E882C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, LightPanther self_)
			{
				if (24616 - 446012 != -421396)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (253149 - 453858 == -200709)
					{
						base..ctor();
						if (204116 - 222980 != -18863)
						{
							this.$nArray$18619 = nArray;
							if (238775 - 24802 == 213973)
							{
								this.$self_$18620 = self_;
								if (57112 - 567523 != -510410)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600138D RID: 5005 RVA: 0x001EA6E8 File Offset: 0x001E88E8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (33542 - 428897 != -395355)
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
						if (this.$self_$18620.mChar.actionState != "dead")
						{
							if (170881 - 54623 != 116258)
							{
								continue;
							}
							goto IL_207;
						}
						else
						{
							if (!this.$self_$18620.mChar.isPlayer)
							{
								if (243216 - 493116 == -249899)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$18620.gameObject);
								if (262667 - 273969 != -11302)
								{
									continue;
								}
							}
							else if (this.$self_$18620.mChar.isMine)
							{
								if (15043 - 471859 != -456816)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$18620.gameObject);
								if (299635 - 153258 != 146377)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (67800 - 162582 != -94781)
							{
								goto Block_25;
							}
							continue;
						}
						break;
					default:
						if (276213 - 24924 == 251290)
						{
							continue;
						}
						break;
					}
					if (this.$self_$18620.mChar.actionState == "dead")
					{
						if (291458 - 330645 != -39186)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$18617 = (Vector3)this.$nArray$18619[0];
						if (195216 - 564120 == -368904)
						{
							this.$myDirection$18618 = (Vector3)this.$nArray$18619[1];
							if (76600 - 174580 == -97980)
							{
								this.$self_$18620.transform.position = this.$myPosition$18617;
								if (98004 - 596279 != -498274)
								{
									this.$self_$18620.transform.LookAt(this.$myPosition$18617 + this.$myDirection$18618);
									if (239448 - 351400 != -111951)
									{
										this.$self_$18620.mChar.hp = 0;
										if (94957 - 146302 != -51344)
										{
											this.$self_$18620.mChar.actionState = "dead";
											if (67997 - 201720 == -133723)
											{
												this.$self_$18620.mChar.actionTime = Time.time;
												if (208560 - 434768 != -226207)
												{
													this.$self_$18620.mChar.myCommand = "none";
													if (213642 - 451888 != -238245)
													{
														this.$self_$18620.mChar.vMovement = Vector3.zero;
														if (51092 - 548790 != -497697)
														{
															this.$self_$18620.mChar.moveSpeed = (float)0;
															if (281529 - 41564 != 239966)
															{
																this.$self_$18620.animation.Rewind();
																if (256096 - 457017 == -200921)
																{
																	this.$self_$18620.animation.Play("ko");
																	if (104571 - 476803 != -372231)
																	{
																		this.$self_$18620.animation.wrapMode = WrapMode.Once;
																		if (194404 - 70160 == 124244)
																		{
																			goto IL_EE;
																		}
																	}
																}
															}
														}
													}
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
				IL_EE:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_207:
				Block_25:
				IL_42F:
				return false;
			}

			// Token: 0x0600138E RID: 5006 RVA: 0x001EAB38 File Offset: 0x001E8D38
			internal static bool HgsWU6LRs5tydteAvsJ()
			{
				return true;
			}

			// Token: 0x0600138F RID: 5007 RVA: 0x001EAB3C File Offset: 0x001E8D3C
			internal static bool BpJlFGLwGBtIwX2OjYR()
			{
				return false;
			}

			// Token: 0x040010F5 RID: 4341
			internal Vector3 $myPosition$18617;

			// Token: 0x040010F6 RID: 4342
			internal Vector3 $myDirection$18618;

			// Token: 0x040010F7 RID: 4343
			internal UnityScript.Lang.Array $nArray$18619;

			// Token: 0x040010F8 RID: 4344
			internal LightPanther $self_$18620;
		}
	}
}
