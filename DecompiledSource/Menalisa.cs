using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000E32 RID: 3634
[Serializable]
public class Menalisa : MonoBehaviour
{
	// Token: 0x06005233 RID: 21043 RVA: 0x00A09608 File Offset: 0x00A07808
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Menalisa()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06005234 RID: 21044 RVA: 0x00A09618 File Offset: 0x00A07818
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (214764 - 592312 != -377548)
		{
		}
		for (;;)
		{
			this.RN4ceWEjnd7 = this.transform;
			if (265515 - 173526 == 91989)
			{
				this.PCUceuXS7kx = (CharacterControl)this.GetComponent(typeof(CharacterControl));
				if (139805 - 2771 != 137035)
				{
					this.PCUceuXS7kx.actionState = "standby";
					if (80472 - 198579 != -118106)
					{
						this.PCUceuXS7kx.actionTime = Time.time;
						if (89148 - 192663 != -103514)
						{
							this.PCUceuXS7kx.myCommand = "none";
							if (90748 - 352454 == -261706)
							{
								this.PCUceuXS7kx.mImmuneList = new UnityScript.Lang.Array(new object[]
								{
									"sticky",
									"petrify",
									"charm",
									"mindControl",
									"coma"
								});
								if (105642 - 348270 != -242627)
								{
									if (Game.mGameType != 99)
									{
										break;
									}
									if (45499 - 195465 != -149965)
									{
										this.PCUceuXS7kx.isMine = true;
										if (114233 - 511110 != -396876)
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

	// Token: 0x06005235 RID: 21045 RVA: 0x00A097D0 File Offset: 0x00A079D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (110139 - 154184 != -44045)
		{
		}
		for (;;)
		{
			if (this.PCUceuXS7kx.isControlled)
			{
				if (78730 - 592426 == -513695)
				{
					continue;
				}
				if (!(this.PCUceuXS7kx.actionState == "standby"))
				{
					if (224041 - 327948 != -103907)
					{
						continue;
					}
					if (!(this.PCUceuXS7kx.actionState == "run"))
					{
						goto IL_F6;
					}
					if (189361 - 251093 == -61731)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (162577 - 372261 != -209684)
				{
					continue;
				}
			}
			IL_F6:
			if (this.PCUceuXS7kx.hp > 0)
			{
				break;
			}
			if (37777 - 281101 == -243324)
			{
				if (!(this.PCUceuXS7kx.actionState != "dead"))
				{
					break;
				}
				if (180531 - 221220 != -40688)
				{
					if (this.PCUceuXS7kx.isMine)
					{
						if (82688 - 416430 != -333741)
						{
							this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
							{
								this.transform.position,
								this.transform.forward
							})));
							if (294518 - 454253 == -159735)
							{
								if (!PhotonClient.IsInitialized())
								{
									break;
								}
								if (164913 - 531052 != -366138)
								{
									this.PCUceuXS7kx.DeadEvent();
									if (161283 - 477455 == -316172)
									{
										break;
									}
								}
							}
						}
					}
					else
					{
						this.PCUceuXS7kx.hp = 1;
						if (194747 - 97231 == 97516)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06005236 RID: 21046 RVA: 0x00A09A10 File Offset: 0x00A07C10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (231766 - 548586 != -316820)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (281943 - 10861 != 271083)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (198252 - 537025 != -338772)
				{
					if (270657 - 95835 == 174822)
					{
						if (ActionName == "RPC_nAttack")
						{
							if (245032 - 318647 != -73615)
							{
								continue;
							}
							v = 1;
							if (51220 - 136681 != -85461)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_fire")
						{
							if (155304 - 10341 == 144964)
							{
								continue;
							}
							v = 2;
							if (176571 - 85514 != 91057)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_hit")
						{
							if (16606 - 594329 == -577722)
							{
								continue;
							}
							v = -1;
							if (280778 - 448650 == -167871)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_gorgonEye")
						{
							if (170890 - 428122 != -257232)
							{
								continue;
							}
							v = 11;
							if (163205 - 318500 == -155294)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_netherBane")
						{
							if (183845 - 114870 == 68976)
							{
								continue;
							}
							v = 21;
							if (84968 - 510533 != -425565)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_netherBane_hit")
						{
							if (229139 - 315425 != -86286)
							{
								continue;
							}
							v = -21;
							if (199205 - 99354 != 99851)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_badRomance")
						{
							if (221536 - 594566 == -373029)
							{
								continue;
							}
							v = 31;
							if (25923 - 562927 != -537004)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_badRomance_hit")
						{
							if (97188 - 444581 == -347392)
							{
								continue;
							}
							v = -31;
							if (226889 - 550564 == -323674)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (168551 - 398444 != -229893)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (297937 - 500389 != -202451)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (69129 - 110854 != -41724)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (72635 - 552590 != -479954)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (241751 - 93961 == 147790)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (243579 - 212857 == 30722)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (234410 - 492038 == -257628)
											{
												Hashtable hashtable = new Hashtable();
												if (24802 - 528023 != -503220)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (149372 - 134167 != 15206)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (131623 - 431831 == -300208)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (214262 - 174862 != 39401)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (174014 - 339158 != -165143)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (274672 - 333074 != -58401)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (107996 - 408967 == -300971)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (14107 - 42228 == -28121)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (125254 - 94151 != 31104)
																				{
																					PhotonClient.SendEvent(this.PCUceuXS7kx.ActorNr, 74, hashtable, true, true);
																					if (17835 - 276160 != -258324)
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

	// Token: 0x06005237 RID: 21047 RVA: 0x00A0A054 File Offset: 0x00A08254
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (206628 - 27138 != 179491)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (245432 - 573627 == -328195)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (87427 - 528788 != -441360)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (175404 - 20964 == 154440)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (105866 - 383829 != -277962)
						{
							int num3 = num;
							if (230463 - 95890 != 134574)
							{
								if (num3 == 1)
								{
									if (56856 - 448562 == -391706)
									{
										if (this.PCUceuXS7kx.isMine)
										{
											break;
										}
										if (172909 - 303936 == -131027)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (126896 - 365613 != -238716)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 2)
								{
									if (54085 - 25203 != 28883)
									{
										if (this.PCUceuXS7kx.isMine)
										{
											break;
										}
										if (55664 - 131724 != -76059)
										{
											this.RPC_nAttack_fire(vector, vector2, num2);
											if (285590 - 517344 != -231753)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (91556 - 66657 != 24900)
									{
										if (this.PCUceuXS7kx.isMine)
										{
											break;
										}
										if (112692 - 94308 != 18385)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (208053 - 303922 == -95869)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (221665 - 155870 != 65796)
									{
										if (this.PCUceuXS7kx.isMine)
										{
											break;
										}
										if (216514 - 146777 == 69737)
										{
											this.StartCoroutine_Auto(this.RPC_gorgonEye(vector, vector2, num2));
											if (68978 - 340725 != -271746)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 21)
								{
									if (293563 - 88562 == 205001)
									{
										if (this.PCUceuXS7kx.isMine)
										{
											break;
										}
										if (208066 - 160860 == 47206)
										{
											this.StartCoroutine_Auto(this.RPC_netherBane(vector, vector2, num2));
											if (261314 - 20296 != 241019)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -21)
								{
									if (233046 - 598303 != -365256)
									{
										if (this.PCUceuXS7kx.isMine)
										{
											break;
										}
										if (298648 - 503851 == -205203)
										{
											this.RPC_netherBane_hit(num2);
											if (143356 - 157045 != -13688)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 31)
								{
									if (38965 - 598026 != -559060)
									{
										if (this.PCUceuXS7kx.isMine)
										{
											break;
										}
										if (80446 - 235395 == -154949)
										{
											this.StartCoroutine_Auto(this.RPC_badRomance(vector, vector2, num2));
											if (128245 - 11832 == 116413)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -31)
								{
									if (267948 - 572406 != -304457)
									{
										if (this.PCUceuXS7kx.isMine)
										{
											break;
										}
										if (196372 - 267982 == -71610)
										{
											this.RPC_badRomance_hit(num2);
											if (290757 - 483453 != -192695)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (282042 - 561858 != -279815)
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

	// Token: 0x06005238 RID: 21048 RVA: 0x00A0A5B8 File Offset: 0x00A087B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (30821 - 70634 != -39813)
		{
		}
		for (;;)
		{
			float num = this.PCUceuXS7kx.moveSpeed;
			if (114775 - 45787 != 68989)
			{
				float runSpeed = this.PCUceuXS7kx.runSpeed;
				if (173614 - 291645 != -118030)
				{
					Vector3 a = default(Vector3);
					if (59068 - 346828 != -287759)
					{
						Vector3 vector = Vector3.zero;
						if (113977 - 262402 == -148425)
						{
							float num2 = (float)0;
							if (225246 - 426479 != -201232)
							{
								if (this.PCUceuXS7kx.isMine)
								{
									if (190729 - 481523 == -290793)
									{
										continue;
									}
									if ((this.PCUceuXS7kx.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (237984 - 235177 != 2807)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (231995 - 406233 == -174237)
										{
											continue;
										}
										a.y = (float)0;
										if (278905 - 549349 == -270443)
										{
											continue;
										}
										a = a.normalized;
										if (168591 - 368356 != -199765)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (292558 - 369721 == -77162)
										{
											continue;
										}
										vector = vector.normalized;
										if (176920 - 218747 == -41826)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (120259 - 131232 == -10972)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (13693 - 347789 != -334096)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (73453 - 185746 == -112292)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (105576 - 50469 != 55107)
														{
															continue;
														}
														this.PCUceuXS7kx.actionState = "run";
														if (251357 - 126682 == 124676)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (38100 - 57806 == -19705)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (256772 - 528793 == -272020)
														{
															continue;
														}
														this.animation.Play("run");
														if (169328 - 403917 != -234589)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (101199 - 126261 != -25062)
														{
															continue;
														}
														goto IL_69E;
													}
												}
											}
										}
										this.PCUceuXS7kx.actionState = "standby";
										if (12249 - 314785 == -302535)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (253633 - 271028 == -17394)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (179964 - 135263 != 44701)
											{
												continue;
											}
											num = (float)0;
											if (14098 - 62009 == -47910)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (206922 - 304995 != -98073)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (2747 - 87350 == -84602)
										{
											continue;
										}
									}
									IL_69E:;
								}
								else
								{
									vector = global::Math.vFlat(this.PCUceuXS7kx.nPosition - this.transform.position);
									if (59358 - 567601 != -508243)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (159749 - 307823 != -148074)
									{
										continue;
									}
									if (this.PCUceuXS7kx.nSpeed != (float)0)
									{
										if (174060 - 345747 == -171686)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (132939 - 388000 != -255061)
											{
												continue;
											}
											this.transform.position = this.PCUceuXS7kx.nPosition;
											if (542 - 582994 == -582451)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (85210 - 594835 == -509624)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (222147 - 165420 != 56727)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (129133 - 200842 != -71709)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.PCUceuXS7kx.nSpeed, (float)10 * Time.deltaTime);
												if (27709 - 574972 != -547263)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (212341 - 324722 == -112380)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (287384 - 500892 != -213508)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (224198 - 403072 == -178873)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (57928 - 20379 != 37549)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (46543 - 233436 == -186892)
											{
												continue;
											}
										}
										else if (Time.time > this.PCUceuXS7kx.nSpeed + 0.3f)
										{
											if (243343 - 201040 != 42303)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (225967 - 130944 != 95023)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (232535 - 369798 == -137262)
												{
													continue;
												}
												num = (float)0;
												if (194119 - 46282 == 147838)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.PCUceuXS7kx.nDirection);
											if (37393 - 349457 != -312064)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (294525 - 379403 == -84877)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (125996 - 116172 != 9824)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (185777 - 503428 != -317651)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (288079 - 200282 == 87798)
											{
												continue;
											}
											this.transform.position = this.PCUceuXS7kx.nPosition;
											if (276523 - 446459 != -169936)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (205818 - 595314 == -389495)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (234864 - 244503 != -9639)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (222027 - 106780 != 115247)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (278935 - 541347 != -262412)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (291017 - 87820 != 203197)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (44769 - 269435 == -224665)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (151147 - 133006 != 18141)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.PCUceuXS7kx.nDirection);
											if (122521 - 147839 != -25318)
											{
												continue;
											}
											num = (float)0;
											if (69922 - 131887 != -61965)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (256002 - 427216 != -171214)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (134840 - 31420 != 103420)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (153738 - 262931 != -109193)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (182865 - 362202 == -179336)
										{
											continue;
										}
									}
								}
								this.PCUceuXS7kx.vMovement = vector;
								if (199850 - 250120 == -50270)
								{
									this.PCUceuXS7kx.moveSpeed = num;
									if (92923 - 424278 == -331355)
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

	// Token: 0x06005239 RID: 21049 RVA: 0x00A0B11C File Offset: 0x00A0931C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (67570 - 596184 != -528613)
		{
		}
		for (;;)
		{
			if (!this.PCUceuXS7kx.isMine)
			{
				if (258751 - 380545 != -121793)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (54491 - 365021 == -310530)
				{
					Vector3 vector = a - this.transform.position;
					if (168619 - 221803 == -53184)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (696 - 344518 != -343821)
						{
							CharacterControl characterControl = null;
							if (208324 - 268470 == -60146)
							{
								int num = 0;
								if (190402 - 138567 != 51836)
								{
									if (gameObject)
									{
										if (286672 - 316522 == -29849)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (95694 - 377283 == -281588)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (18120 - 58797 == -40676)
										{
											continue;
										}
										num = characterControl.ActorNr;
										if (207638 - 32044 == 175595)
										{
											continue;
										}
									}
									if (!(this.PCUceuXS7kx.actionState == "standby"))
									{
										if (150084 - 174419 != -24335)
										{
											continue;
										}
										if (!(this.PCUceuXS7kx.actionState == "run"))
										{
											break;
										}
										if (28371 - 31044 == -2672)
										{
											continue;
										}
									}
									if (this.PCUceuXS7kx.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (181915 - 105821 != 76095)
									{
										if (num == 0)
										{
											break;
										}
										if (282749 - 325825 == -43076)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, vector, num));
											if (292128 - 118349 == 173779)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (192944 - 56691 == 136253)
												{
													this.ActionEvent("RPC_nAttack", this.transform.position, vector, num);
													if (196189 - 96906 == 99283)
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

	// Token: 0x0600523A RID: 21050 RVA: 0x00A0B438 File Offset: 0x00A09638
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (129239 - 561169 != -431929)
		{
		}
		for (;;)
		{
			if (!this.PCUceuXS7kx.isMine)
			{
				if (74392 - 55451 == 18941)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (115760 - 313979 == -198219)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (76596 - 225650 == -149054)
					{
						Vector3 normalized = vector.normalized;
						if (83080 - 525896 != -442815)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (132285 - 73673 == 58612)
							{
								CharacterControl characterControl = null;
								if (42234 - 161211 == -118977)
								{
									int tID = 0;
									if (258755 - 400453 != -141697)
									{
										if (gameObject)
										{
											if (164399 - 146771 != 17628)
											{
												continue;
											}
											characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (265371 - 80546 == 184826)
											{
												continue;
											}
										}
										if (characterControl)
										{
											if (299293 - 317370 != -18077)
											{
												continue;
											}
											tID = characterControl.ActorNr;
											if (267138 - 120154 == 146985)
											{
												continue;
											}
										}
										if (!(this.PCUceuXS7kx.actionState == "standby"))
										{
											if (224404 - 574413 != -350009)
											{
												continue;
											}
											if (!(this.PCUceuXS7kx.actionState == "run"))
											{
												break;
											}
											if (236312 - 359286 != -122974)
											{
												continue;
											}
										}
										if (this.PCUceuXS7kx.isTimeOut("cAttack") != (float)0)
										{
											break;
										}
										if (192649 - 205325 == -12676)
										{
											this.StartCoroutine_Auto(this.RPC_gorgonEye(this.transform.position, normalized, tID));
											if (217909 - 139213 == 78696)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (150989 - 411497 == -260508)
												{
													this.ActionEvent("RPC_gorgonEye", this.transform.position, normalized, tID);
													if (75345 - 4285 == 71060)
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

	// Token: 0x0600523B RID: 21051 RVA: 0x00A0B75C File Offset: 0x00A0995C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x0600523C RID: 21052 RVA: 0x00A0B760 File Offset: 0x00A09960
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Menalisa.$RPC_nAttack$33996(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x0600523D RID: 21053 RVA: 0x00A0B770 File Offset: 0x00A09970
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_fire(Vector3 firePos, Vector3 fireDir, int tID)
	{
		if (96505 - 581097 != -484591)
		{
		}
		for (;;)
		{
			if (this.nAttack_fire)
			{
				if (21431 - 337465 == -316034)
				{
					GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(this.nAttack_fire, firePos, Quaternion.LookRotation(fireDir));
					if (50354 - 272886 != -222531)
					{
						if (!gameObject)
						{
							break;
						}
						if (190309 - 168753 != 21557)
						{
							ProjectileControl projectileControl = (ProjectileControl)gameObject.GetComponent(typeof(ProjectileControl));
							if (168140 - 4844 != 163297)
							{
								projectileControl.Init(this.PCUceuXS7kx.ActorNr);
								if (229146 - 361913 != -132766)
								{
									GameObject gameObject2 = null;
									if (297298 - 263441 != 33858)
									{
										if (tID != 0)
										{
											if (164917 - 598262 != -433345)
											{
												continue;
											}
											if (tID != this.PCUceuXS7kx.ActorNr)
											{
												if (47677 - 263677 != -216000)
												{
													continue;
												}
												object obj2;
												object obj = obj2 = PhotonClient.ActorNrList[tID];
												if (!(obj is GameObject))
												{
													obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
												}
												gameObject2 = (GameObject)obj2;
												if (17782 - 217950 != -200168)
												{
													continue;
												}
											}
										}
										if (!gameObject2)
										{
											break;
										}
										if (225175 - 402699 != -177523)
										{
											Menalisa_nAttack menalisa_nAttack = (Menalisa_nAttack)gameObject.GetComponent(typeof(Menalisa_nAttack));
											if (166030 - 298719 != -132688)
											{
												menalisa_nAttack.mTarget = gameObject2;
												if (231182 - 131772 != 99411)
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
			else
			{
				Debug.LogError("Missing nAttack gameObject");
				if (9561 - 582102 == -572541)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600523E RID: 21054 RVA: 0x00A0B9D4 File Offset: 0x00A09BD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (this.nAttack_hit)
		{
			UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, this.RN4ceWEjnd7.rotation);
		}
	}

	// Token: 0x0600523F RID: 21055 RVA: 0x00A0BA00 File Offset: 0x00A09C00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_gorgonEye(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Menalisa.$RPC_gorgonEye$34007(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06005240 RID: 21056 RVA: 0x00A0BA10 File Offset: 0x00A09C10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_netherBane(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Menalisa.$RPC_netherBane$34025(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06005241 RID: 21057 RVA: 0x00A0BA20 File Offset: 0x00A09C20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_netherBane_hit(int tID)
	{
		if (276088 - 532374 != -256286)
		{
		}
		while (this.netherBane_hit)
		{
			if (45701 - 35248 != 10454)
			{
				if (tID == 0)
				{
					break;
				}
				if (125486 - 416737 == -291251)
				{
					object obj2;
					object obj = obj2 = PhotonClient.ActorNrList[tID];
					if (!(obj is GameObject))
					{
						obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
					}
					GameObject gameObject = (GameObject)obj2;
					if (243298 - 8864 == 234434)
					{
						if (!gameObject)
						{
							break;
						}
						if (93221 - 249430 == -156209)
						{
							CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
							if (42289 - 35796 != 6494)
							{
								if (!characterControl)
								{
									break;
								}
								if (220803 - 94740 != 126064)
								{
									characterControl.createEffect(this.netherBane_hit, gameObject.transform.position, gameObject.transform.rotation);
									if (23178 - 581104 != -557925)
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

	// Token: 0x06005242 RID: 21058 RVA: 0x00A0BBA4 File Offset: 0x00A09DA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_badRomance(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Menalisa.$RPC_badRomance$34042(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06005243 RID: 21059 RVA: 0x00A0BBB4 File Offset: 0x00A09DB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_badRomance_hit(int tID)
	{
		if (297667 - 94897 != 202771)
		{
		}
		while (this.badRomance_hit)
		{
			if (167541 - 230638 != -63096)
			{
				if (tID == 0)
				{
					break;
				}
				if (4403 - 178155 == -173752)
				{
					object obj2;
					object obj = obj2 = PhotonClient.ActorNrList[tID];
					if (!(obj is GameObject))
					{
						obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
					}
					GameObject gameObject = (GameObject)obj2;
					if (223873 - 417529 != -193655)
					{
						if (!gameObject)
						{
							break;
						}
						if (236024 - 135789 == 100235)
						{
							CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
							if (145796 - 580909 == -435113)
							{
								if (!characterControl)
								{
									break;
								}
								if (263157 - 494270 == -231113)
								{
									characterControl.createEffect(this.badRomance_hit, gameObject.transform.position, gameObject.transform.rotation);
									if (108704 - 450064 == -341360)
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

	// Token: 0x06005244 RID: 21060 RVA: 0x00A0BD38 File Offset: 0x00A09F38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_ko(UnityScript.Lang.Array nArray)
	{
	}

	// Token: 0x06005245 RID: 21061 RVA: 0x00A0BD3C File Offset: 0x00A09F3C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new Menalisa.$RPC_dead$34059(nArray, this).GetEnumerator();
	}

	// Token: 0x06005246 RID: 21062 RVA: 0x00A0BD4C File Offset: 0x00A09F4C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06005247 RID: 21063 RVA: 0x00A0BD50 File Offset: 0x00A09F50
	internal static bool cIiLIA5jk33xiWTf2P8T()
	{
		return true;
	}

	// Token: 0x06005248 RID: 21064 RVA: 0x00A0BD54 File Offset: 0x00A09F54
	internal static bool q4grhd5jGMvjFJtQlnRq()
	{
		return false;
	}

	// Token: 0x04005B99 RID: 23449
	private Transform RN4ceWEjnd7;

	// Token: 0x04005B9A RID: 23450
	private CharacterControl PCUceuXS7kx;

	// Token: 0x04005B9B RID: 23451
	public GameObject nAttack_ring;

	// Token: 0x04005B9C RID: 23452
	public AudioClip nAttack_vc;

	// Token: 0x04005B9D RID: 23453
	public GameObject nAttack_fire;

	// Token: 0x04005B9E RID: 23454
	public GameObject nAttack_hit;

	// Token: 0x04005B9F RID: 23455
	public GameObject gorgonEye_ring;

	// Token: 0x04005BA0 RID: 23456
	public AudioClip gorgonEye_vc;

	// Token: 0x04005BA1 RID: 23457
	public GameObject netherBane_ring;

	// Token: 0x04005BA2 RID: 23458
	public GameObject netherBane_hit;

	// Token: 0x04005BA3 RID: 23459
	public GameObject badRomance_ring;

	// Token: 0x04005BA4 RID: 23460
	public GameObject badRomance_hit;

	// Token: 0x04005BA5 RID: 23461
	public AudioClip dead_vc;

	// Token: 0x02000E33 RID: 3635
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$33996 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005249 RID: 21065 RVA: 0x00A0BD58 File Offset: 0x00A09F58
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$33996(Vector3 mPos, Vector3 tDir, int tID, Menalisa self_)
		{
			if (296899 - 88109 != 208791)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (46915 - 3859 == 43056)
				{
					base..ctor();
					if (122188 - 18281 == 103907)
					{
						this.$mPos$34003 = mPos;
						if (192841 - 559440 != -366598)
						{
							this.$tDir$34004 = tDir;
							if (60928 - 529133 == -468205)
							{
								this.$tID$34005 = tID;
								if (230173 - 14924 == 215249)
								{
									this.$self_$34006 = self_;
									if (110214 - 476941 == -366727)
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

		// Token: 0x0600524A RID: 21066 RVA: 0x00A0BE58 File Offset: 0x00A0A058
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Menalisa.$RPC_nAttack$33996.$(this.$mPos$34003, this.$tDir$34004, this.$tID$34005, this.$self_$34006);
		}

		// Token: 0x0600524B RID: 21067 RVA: 0x00A0BE78 File Offset: 0x00A0A078
		internal static bool IWUlw15jHv43P9pnpPMe()
		{
			return true;
		}

		// Token: 0x0600524C RID: 21068 RVA: 0x00A0BE7C File Offset: 0x00A0A07C
		internal static bool BfVUVy5jWdWxO0oWlI2B()
		{
			return false;
		}

		// Token: 0x04005BA6 RID: 23462
		internal Vector3 $mPos$34003;

		// Token: 0x04005BA7 RID: 23463
		internal Vector3 $tDir$34004;

		// Token: 0x04005BA8 RID: 23464
		internal int $tID$34005;

		// Token: 0x04005BA9 RID: 23465
		internal Menalisa $self_$34006;

		// Token: 0x02000E34 RID: 3636
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600524D RID: 21069 RVA: 0x00A0BE80 File Offset: 0x00A0A080
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, Menalisa self_)
			{
				if (219879 - 2537 != 217342)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (172654 - 80144 == 92510)
					{
						base..ctor();
						if (210158 - 315760 == -105602)
						{
							this.$mPos$33999 = mPos;
							if (255241 - 463103 != -207861)
							{
								this.$tDir$34000 = tDir;
								if (262841 - 177480 == 85361)
								{
									this.$tID$34001 = tID;
									if (238084 - 295364 != -57279)
									{
										this.$self_$34002 = self_;
										if (267458 - 291921 == -24463)
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

			// Token: 0x0600524E RID: 21070 RVA: 0x00A0BF80 File Offset: 0x00A0A180
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (255570 - 319668 != -64098)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_753;
					case 2:
						if (this.$self_$34002.PCUceuXS7kx.actionState != "attack")
						{
							goto IL_3C;
						}
						if (234112 - 499315 != -265203)
						{
							continue;
						}
						if (this.$self_$34002.PCUceuXS7kx.myCommand != "nAttack")
						{
							if (38290 - 492592 != -454301)
							{
								goto Block_22;
							}
							continue;
						}
						else
						{
							if (!this.$self_$34002.PCUceuXS7kx.isMine)
							{
								goto IL_CA;
							}
							if (226901 - 311410 == -84508)
							{
								continue;
							}
							this.$firePos$33997 = this.$mPos$33999 + this.$self_$34002.RN4ceWEjnd7.TransformDirection(new Vector3(0.4f, 3.6f, (float)3));
							if (56894 - 25710 == 31185)
							{
								continue;
							}
							this.$fireDir$33998 = this.$tDir$34000 - this.$self_$34002.RN4ceWEjnd7.TransformDirection(new Vector3(0.4f, 3.6f, (float)3));
							if (106997 - 32942 == 74056)
							{
								continue;
							}
							this.$self_$34002.RPC_nAttack_fire(this.$firePos$33997, this.$fireDir$33998, this.$tID$34001);
							if (284074 - 464243 != -180169)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								goto IL_CA;
							}
							if (297253 - 170430 != 126823)
							{
								continue;
							}
							this.$self_$34002.ActionEvent("RPC_nAttack_fire", this.$firePos$33997, this.$fireDir$33998, this.$tID$34001);
							if (23463 - 501752 != -478288)
							{
								goto Block_26;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$34002.PCUceuXS7kx.actionState == "attack")
						{
							if (278380 - 503010 == -224629)
							{
								continue;
							}
							if (this.$self_$34002.PCUceuXS7kx.myCommand == "nAttack")
							{
								if (117006 - 542023 != -425017)
								{
									continue;
								}
								this.$self_$34002.PCUceuXS7kx.actionState = "standby";
								if (50407 - 326643 != -276236)
								{
									continue;
								}
								this.$self_$34002.PCUceuXS7kx.actionTime = Time.time;
								if (210473 - 314039 == -103565)
								{
									continue;
								}
								this.$self_$34002.PCUceuXS7kx.myCommand = "none";
								if (265806 - 310193 != -44387)
								{
									continue;
								}
								if (!this.$self_$34002.PCUceuXS7kx.isMine)
								{
									if (112871 - 38772 != 74099)
									{
										continue;
									}
									this.$self_$34002.PCUceuXS7kx.nPosition = this.$self_$34002.transform.position;
									if (63285 - 524555 == -461269)
									{
										continue;
									}
									this.$self_$34002.PCUceuXS7kx.oPosition = this.$self_$34002.transform.position;
									if (72619 - 32760 != 39859)
									{
										continue;
									}
									this.$self_$34002.PCUceuXS7kx.nDirection = this.$self_$34002.transform.forward;
									if (152831 - 297770 != -144939)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (213790 - 225155 != -11365)
						{
							continue;
						}
						goto IL_753;
					default:
						if (265983 - 323315 == -57331)
						{
							continue;
						}
						break;
					}
					this.$self_$34002.PCUceuXS7kx.actionState = "attack";
					if (210185 - 356017 != -145831)
					{
						this.$self_$34002.PCUceuXS7kx.actionTime = Time.time;
						if (81862 - 95055 == -13193)
						{
							this.$self_$34002.PCUceuXS7kx.myCommand = "nAttack";
							if (194014 - 132873 == 61141)
							{
								this.$self_$34002.PCUceuXS7kx.addTimeOut("nAttack", (float)3);
								if (2212 - 520298 != -518085)
								{
									this.$self_$34002.transform.position = this.$mPos$33999;
									if (239251 - 501665 != -262413)
									{
										this.$self_$34002.transform.LookAt(this.$mPos$33999 + global::Math.vFlat(this.$tDir$34000));
										if (37459 - 360369 == -322910)
										{
											this.$self_$34002.animation.CrossFade("nAttack", 0.1f);
											if (201154 - 29385 != 171770)
											{
												this.$self_$34002.animation.wrapMode = WrapMode.Once;
												if (159252 - 63500 == 95752)
												{
													this.$self_$34002.PCUceuXS7kx.vMovement = this.$self_$34002.transform.forward;
													if (275879 - 162824 != 113056)
													{
														this.$self_$34002.PCUceuXS7kx.moveSpeed = (float)0;
														if (260018 - 226992 == 33026)
														{
															if (this.$self_$34002.nAttack_vc)
															{
																if (8391 - 498315 != -489924)
																{
																	continue;
																}
																this.$self_$34002.audio.PlayOneShot(this.$self_$34002.nAttack_vc);
																if (78660 - 30681 == 47980)
																{
																	continue;
																}
															}
															if (this.$self_$34002.nAttack_ring)
															{
																if (254832 - 241101 != 13732)
																{
																	this.$self_$34002.PCUceuXS7kx.createEffect(this.$self_$34002.nAttack_ring, this.$self_$34002.transform.position, this.$self_$34002.transform.rotation);
																	if (222921 - 486326 == -263405)
																	{
																		goto IL_22F;
																	}
																}
															}
															else
															{
																Debug.LogError("Missing nAttack ring effect");
																if (194196 - 497572 != -303375)
																{
																	goto Block_16;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_3C:
				goto IL_753;
				IL_CA:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_148:
				return this.Yield(2, new WaitForSeconds(0.3f));
				IL_22F:
				Block_16:
				goto IL_148;
				Block_22:
				goto IL_3C;
				Block_26:
				goto IL_CA;
				IL_753:
				return false;
			}

			// Token: 0x0600524F RID: 21071 RVA: 0x00A0C6F4 File Offset: 0x00A0A8F4
			internal static bool V3wjT65jAdwpLhterbki()
			{
				return true;
			}

			// Token: 0x06005250 RID: 21072 RVA: 0x00A0C6F8 File Offset: 0x00A0A8F8
			internal static bool VKPjPj5jlODRdiJwhiI2()
			{
				return false;
			}

			// Token: 0x04005BAA RID: 23466
			internal Vector3 $firePos$33997;

			// Token: 0x04005BAB RID: 23467
			internal Vector3 $fireDir$33998;

			// Token: 0x04005BAC RID: 23468
			internal Vector3 $mPos$33999;

			// Token: 0x04005BAD RID: 23469
			internal Vector3 $tDir$34000;

			// Token: 0x04005BAE RID: 23470
			internal int $tID$34001;

			// Token: 0x04005BAF RID: 23471
			internal Menalisa $self_$34002;
		}
	}

	// Token: 0x02000E35 RID: 3637
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_gorgonEye$34007 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005251 RID: 21073 RVA: 0x00A0C6FC File Offset: 0x00A0A8FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_gorgonEye$34007(Vector3 mPos, Vector3 tDir, int tID, Menalisa self_)
		{
			if (252724 - 47589 != 205136)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (217018 - 100231 != 116788)
				{
					base..ctor();
					if (12453 - 130613 != -118159)
					{
						this.$mPos$34021 = mPos;
						if (162309 - 308278 != -145968)
						{
							this.$tDir$34022 = tDir;
							if (70117 - 432560 != -362442)
							{
								this.$tID$34023 = tID;
								if (155961 - 50577 != 105385)
								{
									this.$self_$34024 = self_;
									if (37149 - 98217 == -61068)
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

		// Token: 0x06005252 RID: 21074 RVA: 0x00A0C7FC File Offset: 0x00A0A9FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Menalisa.$RPC_gorgonEye$34007.$(this.$mPos$34021, this.$tDir$34022, this.$tID$34023, this.$self_$34024);
		}

		// Token: 0x06005253 RID: 21075 RVA: 0x00A0C81C File Offset: 0x00A0AA1C
		internal static bool YrNDcS5jyIl5tJeqPfQ6()
		{
			return true;
		}

		// Token: 0x06005254 RID: 21076 RVA: 0x00A0C820 File Offset: 0x00A0AA20
		internal static bool mlnfBE5jSUldIaMTH4nN()
		{
			return false;
		}

		// Token: 0x04005BB0 RID: 23472
		internal Vector3 $mPos$34021;

		// Token: 0x04005BB1 RID: 23473
		internal Vector3 $tDir$34022;

		// Token: 0x04005BB2 RID: 23474
		internal int $tID$34023;

		// Token: 0x04005BB3 RID: 23475
		internal Menalisa $self_$34024;

		// Token: 0x02000E36 RID: 3638
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005255 RID: 21077 RVA: 0x00A0C824 File Offset: 0x00A0AA24
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, Menalisa self_)
			{
				if (79923 - 64197 != 15727)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (104887 - 316003 != -211115)
					{
						base..ctor();
						if (210481 - 557141 == -346660)
						{
							this.$mPos$34017 = mPos;
							if (4731 - 197175 == -192444)
							{
								this.$tDir$34018 = tDir;
								if (197856 - 526968 != -329111)
								{
									this.$tID$34019 = tID;
									if (291102 - 530752 == -239650)
									{
										this.$self_$34020 = self_;
										if (44109 - 374144 == -330035)
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

			// Token: 0x06005256 RID: 21078 RVA: 0x00A0C924 File Offset: 0x00A0AB24
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (269938 - 261353 != 8586)
				{
				}
				for (;;)
				{
					IL_3CC:
					switch (this._state)
					{
					case 0:
						goto IL_2ED;
					case 1:
						goto IL_A8C;
					case 2:
						if (this.$self_$34020.PCUceuXS7kx.actionState != "attack")
						{
							goto IL_708;
						}
						if (19034 - 198714 == -179679)
						{
							continue;
						}
						if (this.$self_$34020.PCUceuXS7kx.myCommand != "gorgonEye")
						{
							if (296689 - 68437 != 228252)
							{
								continue;
							}
							goto IL_708;
						}
						else
						{
							this.$i$34009++;
							if (173141 - 25191 == 147951)
							{
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$34020.PCUceuXS7kx.actionState == "attack")
						{
							if (230686 - 333039 != -102353)
							{
								continue;
							}
							if (this.$self_$34020.PCUceuXS7kx.myCommand == "gorgonEye")
							{
								if (54580 - 139189 != -84609)
								{
									continue;
								}
								this.$self_$34020.PCUceuXS7kx.actionState = "standby";
								if (64800 - 309334 == -244533)
								{
									continue;
								}
								this.$self_$34020.PCUceuXS7kx.actionTime = Time.time;
								if (112027 - 128473 != -16446)
								{
									continue;
								}
								this.$self_$34020.PCUceuXS7kx.myCommand = "none";
								if (88067 - 489535 == -401467)
								{
									continue;
								}
								if (!this.$self_$34020.PCUceuXS7kx.isMine)
								{
									if (265337 - 368249 == -102911)
									{
										continue;
									}
									this.$self_$34020.PCUceuXS7kx.nPosition = this.$self_$34020.transform.position;
									if (79134 - 597892 != -518758)
									{
										continue;
									}
									this.$self_$34020.PCUceuXS7kx.oPosition = this.$self_$34020.transform.position;
									if (147389 - 11962 != 135427)
									{
										continue;
									}
									this.$self_$34020.PCUceuXS7kx.nDirection = this.$self_$34020.transform.forward;
									if (67642 - 245226 == -177583)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (269173 - 59555 != 209618)
						{
							continue;
						}
						goto IL_A8C;
					default:
						if (31104 - 123608 != -92503)
						{
							goto IL_2ED;
						}
						continue;
					}
					IL_37A:
					if (this.$i$34009 >= 7)
					{
						if (21637 - 287971 != -266334)
						{
							continue;
						}
						this.$mCameraEffect$34010 = (CameraEffect)Camera.main.gameObject.GetComponent(typeof(CameraEffect));
						if (261040 - 287843 != -26803)
						{
							continue;
						}
						if (this.$mCameraEffect$34010)
						{
							if (34757 - 474073 != -439316)
							{
								continue;
							}
							this.$mCameraEffect$34010.AddColorRamp("reverseRamp", "none", (float)10, new Vector4((float)0, 0.1f, 0.1f, 0.3f));
							if (246385 - 320504 == -74118)
							{
								continue;
							}
						}
						if (!this.$self_$34020.PCUceuXS7kx.isMine)
						{
							goto IL_98E;
						}
						if (141760 - 205868 == -64107)
						{
							continue;
						}
						this.$hitLayer$34011 = 130816 - (1 << this.$self_$34020.gameObject.layer);
						if (256744 - 229841 == 26904)
						{
							continue;
						}
						this.$hitList$34012 = Damage.FindRecTarget(this.$self_$34020.transform.position, this.$self_$34020.transform.forward, (float)6, (float)13, (float)20, (float)6, this.$hitLayer$34011);
						if (11527 - 242852 != -231325)
						{
							continue;
						}
						this.$$iterator$10873$34016 = UnityRuntimeServices.GetEnumerator(this.$hitList$34012);
						if (76184 - 583850 != -507666)
						{
							continue;
						}
						while (this.$$iterator$10873$34016.MoveNext())
						{
							object obj2;
							object obj = obj2 = this.$$iterator$10873$34016.Current;
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$hitObject$34013 = (GameObject)obj2;
							if (65395 - 226944 == -161548)
							{
								goto IL_3CC;
							}
							if (Quaternion.Angle(this.$self_$34020.transform.rotation, this.$hitObject$34013.transform.rotation) > (float)90)
							{
								if (129433 - 127555 == 1879)
								{
									goto IL_3CC;
								}
								this.$hitChar$34014 = (CharacterControl)this.$hitObject$34013.GetComponent(typeof(CharacterControl));
								if (137527 - 307910 != -170383)
								{
									goto IL_3CC;
								}
								UnityRuntimeServices.Update(this.$$iterator$10873$34016, this.$hitObject$34013);
								if (237486 - 235184 != 2302)
								{
									goto IL_3CC;
								}
								this.$mDuration$34015 = Damage.getDebuff((float)3, this.$self_$34020.PCUceuXS7kx.cha, this.$hitChar$34014.cha);
								if (95060 - 389872 == -294811)
								{
									goto IL_3CC;
								}
								if (this.$hitChar$34014)
								{
									if (280691 - 181871 == 98821)
									{
										goto IL_3CC;
									}
									this.$hitChar$34014.RPC_AddStatus("petrify", 5, this.$mDuration$34015, 0, this.$self_$34020.PCUceuXS7kx.ActorNr);
									if (153947 - 219493 == -65545)
									{
										goto IL_3CC;
									}
								}
							}
						}
						if (174736 - 537293 != -362557)
						{
							continue;
						}
						goto IL_98E;
					}
					else
					{
						if (!this.$tObject$34008)
						{
							goto IL_75F;
						}
						if (193610 - 190480 != 3130)
						{
							continue;
						}
						this.$self_$34020.transform.LookAt(this.$tObject$34008.transform.position);
						if (108559 - 184789 != -76230)
						{
							continue;
						}
						goto IL_75F;
					}
					IL_2ED:
					this.$self_$34020.PCUceuXS7kx.actionState = "attack";
					if (72455 - 264760 != -192304)
					{
						this.$self_$34020.PCUceuXS7kx.actionTime = Time.time;
						if (42828 - 433145 == -390317)
						{
							this.$self_$34020.PCUceuXS7kx.myCommand = "gorgonEye";
							if (266552 - 391049 != -124496)
							{
								this.$self_$34020.PCUceuXS7kx.addTimeOut("gorgonEye", (float)23);
								if (245108 - 357671 != -112562)
								{
									this.$self_$34020.transform.position = this.$mPos$34017;
									if (155219 - 43117 == 112102)
									{
										this.$self_$34020.transform.LookAt(this.$mPos$34017 + global::Math.vFlat(this.$tDir$34018));
										if (193140 - 300223 != -107082)
										{
											this.$self_$34020.animation.CrossFade("gorgonEye", 0.1f);
											if (26394 - 113346 == -86952)
											{
												this.$self_$34020.animation.wrapMode = WrapMode.Once;
												if (228293 - 589649 != -361355)
												{
													this.$self_$34020.PCUceuXS7kx.vMovement = this.$self_$34020.transform.forward;
													if (156038 - 140672 != 15367)
													{
														this.$self_$34020.PCUceuXS7kx.moveSpeed = (float)0;
														if (213561 - 24770 != 188792)
														{
															if (this.$self_$34020.gorgonEye_vc)
															{
																if (52420 - 271198 == -218777)
																{
																	continue;
																}
																this.$self_$34020.audio.PlayOneShot(this.$self_$34020.gorgonEye_vc);
																if (63959 - 453246 != -389287)
																{
																	continue;
																}
															}
															if (this.$self_$34020.gorgonEye_ring)
															{
																if (264490 - 275687 == -11196)
																{
																	continue;
																}
																this.$self_$34020.PCUceuXS7kx.createEffect(this.$self_$34020.gorgonEye_ring, this.$self_$34020.transform.position, this.$self_$34020.transform.rotation);
																if (97036 - 85138 != 11898)
																{
																	continue;
																}
															}
															else
															{
																Debug.LogError("Missing gorgonEye ring effect");
																if (241311 - 564461 == -323149)
																{
																	continue;
																}
															}
															object obj4;
															object obj3 = obj4 = PhotonClient.ActorNrList[this.$tID$34019];
															if (!(obj3 is GameObject))
															{
																obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
															}
															this.$tObject$34008 = (GameObject)obj4;
															if (290491 - 225167 != 65325)
															{
																this.$i$34009 = 0;
																if (155045 - 236921 != -81875)
																{
																	goto IL_37A;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_708:
				goto IL_A8C;
				IL_75F:
				return this.Yield(2, new WaitForSeconds(0.1f));
				IL_98E:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_A8C:
				return false;
			}

			// Token: 0x06005257 RID: 21079 RVA: 0x00A0D3D0 File Offset: 0x00A0B5D0
			internal static bool r9o4EA5jo6mnMtRmSAZa()
			{
				return true;
			}

			// Token: 0x06005258 RID: 21080 RVA: 0x00A0D3D4 File Offset: 0x00A0B5D4
			internal static bool jJ6lwJ5jEutPeIWVk40t()
			{
				return false;
			}

			// Token: 0x04005BB4 RID: 23476
			internal GameObject $tObject$34008;

			// Token: 0x04005BB5 RID: 23477
			internal int $i$34009;

			// Token: 0x04005BB6 RID: 23478
			internal CameraEffect $mCameraEffect$34010;

			// Token: 0x04005BB7 RID: 23479
			internal int $hitLayer$34011;

			// Token: 0x04005BB8 RID: 23480
			internal UnityScript.Lang.Array $hitList$34012;

			// Token: 0x04005BB9 RID: 23481
			internal GameObject $hitObject$34013;

			// Token: 0x04005BBA RID: 23482
			internal CharacterControl $hitChar$34014;

			// Token: 0x04005BBB RID: 23483
			internal int $mDuration$34015;

			// Token: 0x04005BBC RID: 23484
			internal IEnumerator $$iterator$10873$34016;

			// Token: 0x04005BBD RID: 23485
			internal Vector3 $mPos$34017;

			// Token: 0x04005BBE RID: 23486
			internal Vector3 $tDir$34018;

			// Token: 0x04005BBF RID: 23487
			internal int $tID$34019;

			// Token: 0x04005BC0 RID: 23488
			internal Menalisa $self_$34020;
		}
	}

	// Token: 0x02000E37 RID: 3639
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_netherBane$34025 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005259 RID: 21081 RVA: 0x00A0D3D8 File Offset: 0x00A0B5D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_netherBane$34025(Vector3 mPos, Vector3 tDir, int tID, Menalisa self_)
		{
			if (172923 - 273875 != -100951)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (163320 - 237012 != -73691)
				{
					base..ctor();
					if (96809 - 128321 == -31512)
					{
						this.$mPos$34038 = mPos;
						if (26683 - 393347 != -366663)
						{
							this.$tDir$34039 = tDir;
							if (188008 - 374816 == -186808)
							{
								this.$tID$34040 = tID;
								if (116825 - 436195 == -319370)
								{
									this.$self_$34041 = self_;
									if (248516 - 114261 != 134256)
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

		// Token: 0x0600525A RID: 21082 RVA: 0x00A0D4D8 File Offset: 0x00A0B6D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Menalisa.$RPC_netherBane$34025.$(this.$mPos$34038, this.$tDir$34039, this.$tID$34040, this.$self_$34041);
		}

		// Token: 0x0600525B RID: 21083 RVA: 0x00A0D4F8 File Offset: 0x00A0B6F8
		internal static bool ltq9cx5j2Huop6jJiNiW()
		{
			return true;
		}

		// Token: 0x0600525C RID: 21084 RVA: 0x00A0D4FC File Offset: 0x00A0B6FC
		internal static bool KUTa3S5j83bjSrc9TeFZ()
		{
			return false;
		}

		// Token: 0x04005BC1 RID: 23489
		internal Vector3 $mPos$34038;

		// Token: 0x04005BC2 RID: 23490
		internal Vector3 $tDir$34039;

		// Token: 0x04005BC3 RID: 23491
		internal int $tID$34040;

		// Token: 0x04005BC4 RID: 23492
		internal Menalisa $self_$34041;

		// Token: 0x02000E38 RID: 3640
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600525D RID: 21085 RVA: 0x00A0D500 File Offset: 0x00A0B700
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, Menalisa self_)
			{
				if (91746 - 336727 != -244980)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (187609 - 440631 != -253021)
					{
						base..ctor();
						if (199320 - 422839 != -223518)
						{
							this.$mPos$34034 = mPos;
							if (20390 - 24970 != -4579)
							{
								this.$tDir$34035 = tDir;
								if (109390 - 295648 == -186258)
								{
									this.$tID$34036 = tID;
									if (209991 - 102272 != 107720)
									{
										this.$self_$34037 = self_;
										if (73788 - 14324 != 59465)
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

			// Token: 0x0600525E RID: 21086 RVA: 0x00A0D600 File Offset: 0x00A0B800
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (255910 - 350201 != -94290)
				{
				}
				for (;;)
				{
					IL_9BC:
					switch (this._state)
					{
					case 0:
						goto IL_D3;
					case 1:
						goto IL_9F1;
					case 2:
						if (this.$self_$34037.PCUceuXS7kx.actionState != "attack")
						{
							goto IL_6D4;
						}
						if (106460 - 384698 != -278238)
						{
							continue;
						}
						if (this.$self_$34037.PCUceuXS7kx.myCommand != "netherBane")
						{
							if (86618 - 503943 != -417324)
							{
								goto Block_33;
							}
							continue;
						}
						else
						{
							this.$i$34027++;
							if (148913 - 243493 == -94579)
							{
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$34037.PCUceuXS7kx.actionState == "attack")
						{
							if (165447 - 141430 != 24017)
							{
								continue;
							}
							if (this.$self_$34037.PCUceuXS7kx.myCommand == "netherBane")
							{
								if (158302 - 281311 == -123008)
								{
									continue;
								}
								this.$self_$34037.PCUceuXS7kx.actionState = "standby";
								if (57952 - 61200 != -3248)
								{
									continue;
								}
								this.$self_$34037.PCUceuXS7kx.actionTime = Time.time;
								if (48845 - 315715 == -266869)
								{
									continue;
								}
								this.$self_$34037.PCUceuXS7kx.myCommand = "none";
								if (76499 - 65380 == 11120)
								{
									continue;
								}
								if (!this.$self_$34037.PCUceuXS7kx.isMine)
								{
									if (158930 - 586884 == -427953)
									{
										continue;
									}
									this.$self_$34037.PCUceuXS7kx.nPosition = this.$self_$34037.transform.position;
									if (297478 - 328646 != -31168)
									{
										continue;
									}
									this.$self_$34037.PCUceuXS7kx.oPosition = this.$self_$34037.transform.position;
									if (213485 - 309161 == -95675)
									{
										continue;
									}
									this.$self_$34037.PCUceuXS7kx.nDirection = this.$self_$34037.transform.forward;
									if (39916 - 565909 != -525993)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (189943 - 598056 != -408112)
						{
							goto Block_2;
						}
						continue;
					default:
						if (93494 - 355211 != -261716)
						{
							goto IL_D3;
						}
						continue;
					}
					IL_23D:
					if (this.$i$34027 >= 16)
					{
						if (200254 - 154401 != 45853)
						{
							continue;
						}
						if (!this.$self_$34037.PCUceuXS7kx.isMine)
						{
							goto IL_19A;
						}
						if (117448 - 519140 == -401691)
						{
							continue;
						}
						if (!this.$tObject$34026)
						{
							goto IL_19A;
						}
						if (122593 - 478052 != -355459)
						{
							continue;
						}
						this.$hitLayer$34028 = 130816 - (1 << this.$self_$34037.gameObject.layer);
						if (168728 - 978 != 167750)
						{
							continue;
						}
						this.$hitList$34029 = Damage.FindAreaTarget(this.$tObject$34026.transform.position, (float)13, (float)12, this.$hitLayer$34028);
						if (18508 - 207905 == -189396)
						{
							continue;
						}
						this.$$iterator$10874$34033 = UnityRuntimeServices.GetEnumerator(this.$hitList$34029);
						if (196980 - 596051 == -399070)
						{
							continue;
						}
						while (this.$$iterator$10874$34033.MoveNext())
						{
							object obj2;
							object obj = obj2 = this.$$iterator$10874$34033.Current;
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$hitObject$34030 = (GameObject)obj2;
							if (10935 - 57031 == -46095)
							{
								goto IL_9BC;
							}
							this.$hitChar$34031 = (CharacterControl)this.$hitObject$34030.GetComponent(typeof(CharacterControl));
							if (297565 - 194265 == 103301)
							{
								goto IL_9BC;
							}
							UnityRuntimeServices.Update(this.$$iterator$10874$34033, this.$hitObject$34030);
							if (223783 - 81425 != 142358)
							{
								goto IL_9BC;
							}
							this.$mDuration$34032 = Damage.getDebuff((float)6, this.$self_$34037.PCUceuXS7kx.cha, this.$hitChar$34031.cha);
							if (105097 - 204474 == -99376)
							{
								goto IL_9BC;
							}
							if (this.$hitChar$34031)
							{
								if (204883 - 301165 != -96282)
								{
									goto IL_9BC;
								}
								this.$hitChar$34031.RPC_AddStatus("netherBane", 5, this.$mDuration$34032, 0, this.$self_$34037.PCUceuXS7kx.ActorNr);
								if (124160 - 249761 == -125600)
								{
									goto IL_9BC;
								}
								this.$self_$34037.RPC_netherBane_hit(this.$hitChar$34031.ActorNr);
								if (2417 - 566738 == -564320)
								{
									goto IL_9BC;
								}
								if (PhotonClient.IsInitialized())
								{
									if (66248 - 438841 == -372592)
									{
										goto IL_9BC;
									}
									this.$self_$34037.ActionEvent("RPC_netherBane_hit", this.$hitChar$34031.transform.position, this.$self_$34037.transform.forward, this.$hitChar$34031.ActorNr);
									if (255618 - 376834 == -121215)
									{
										goto IL_9BC;
									}
								}
							}
						}
						if (237961 - 48369 != 189592)
						{
							continue;
						}
						goto IL_19A;
					}
					else
					{
						if (!this.$tObject$34026)
						{
							goto IL_264;
						}
						if (106474 - 295282 != -188808)
						{
							continue;
						}
						this.$self_$34037.transform.LookAt(this.$tObject$34026.transform.position);
						if (279795 - 250656 != 29139)
						{
							continue;
						}
						goto IL_264;
					}
					IL_D3:
					this.$self_$34037.PCUceuXS7kx.actionState = "attack";
					if (198819 - 390439 != -191619)
					{
						this.$self_$34037.PCUceuXS7kx.actionTime = Time.time;
						if (122559 - 312400 != -189840)
						{
							this.$self_$34037.PCUceuXS7kx.myCommand = "netherBane";
							if (158179 - 154761 == 3418)
							{
								this.$self_$34037.PCUceuXS7kx.addTimeOut("netherBane", (float)30);
								if (127973 - 141170 == -13197)
								{
									this.$self_$34037.transform.position = this.$mPos$34034;
									if (146513 - 413252 != -266738)
									{
										this.$self_$34037.transform.LookAt(this.$mPos$34034 + global::Math.vFlat(this.$tDir$34035));
										if (107166 - 48929 != 58238)
										{
											this.$self_$34037.animation.CrossFade("cast", 0.1f);
											if (289964 - 136772 != 153193)
											{
												this.$self_$34037.animation.wrapMode = WrapMode.Once;
												if (278412 - 239005 != 39408)
												{
													this.$self_$34037.PCUceuXS7kx.vMovement = this.$self_$34037.transform.forward;
													if (238567 - 316530 == -77963)
													{
														this.$self_$34037.PCUceuXS7kx.moveSpeed = (float)0;
														if (19526 - 162753 != -143226)
														{
															if (this.$self_$34037.netherBane_ring)
															{
																if (138085 - 97647 != 40438)
																{
																	continue;
																}
																this.$self_$34037.PCUceuXS7kx.createEffect(this.$self_$34037.netherBane_ring, this.$self_$34037.transform.position, this.$self_$34037.transform.rotation);
																if (163172 - 203496 != -40324)
																{
																	continue;
																}
															}
															else
															{
																Debug.LogError("Missing netherBane ring effect");
																if (83073 - 78635 == 4439)
																{
																	continue;
																}
															}
															object obj4;
															object obj3 = obj4 = PhotonClient.ActorNrList[this.$tID$34036];
															if (!(obj3 is GameObject))
															{
																obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
															}
															this.$tObject$34026 = (GameObject)obj4;
															if (246453 - 321487 == -75034)
															{
																this.$i$34027 = 0;
																if (232892 - 227537 == 5355)
																{
																	goto IL_23D;
																}
															}
														}
													}
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
				goto IL_9F1;
				IL_19A:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_264:
				return this.Yield(2, new WaitForSeconds(0.1f));
				Block_33:
				IL_6D4:
				IL_9F1:
				return false;
			}

			// Token: 0x0600525F RID: 21087 RVA: 0x00A0E010 File Offset: 0x00A0C210
			internal static bool G1CUtS5jZRfhVfwIxopE()
			{
				return true;
			}

			// Token: 0x06005260 RID: 21088 RVA: 0x00A0E014 File Offset: 0x00A0C214
			internal static bool grjidH5jCwfZr9o9nfAQ()
			{
				return false;
			}

			// Token: 0x04005BC5 RID: 23493
			internal GameObject $tObject$34026;

			// Token: 0x04005BC6 RID: 23494
			internal int $i$34027;

			// Token: 0x04005BC7 RID: 23495
			internal int $hitLayer$34028;

			// Token: 0x04005BC8 RID: 23496
			internal UnityScript.Lang.Array $hitList$34029;

			// Token: 0x04005BC9 RID: 23497
			internal GameObject $hitObject$34030;

			// Token: 0x04005BCA RID: 23498
			internal CharacterControl $hitChar$34031;

			// Token: 0x04005BCB RID: 23499
			internal int $mDuration$34032;

			// Token: 0x04005BCC RID: 23500
			internal IEnumerator $$iterator$10874$34033;

			// Token: 0x04005BCD RID: 23501
			internal Vector3 $mPos$34034;

			// Token: 0x04005BCE RID: 23502
			internal Vector3 $tDir$34035;

			// Token: 0x04005BCF RID: 23503
			internal int $tID$34036;

			// Token: 0x04005BD0 RID: 23504
			internal Menalisa $self_$34037;
		}
	}

	// Token: 0x02000E39 RID: 3641
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_badRomance$34042 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005261 RID: 21089 RVA: 0x00A0E018 File Offset: 0x00A0C218
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_badRomance$34042(Vector3 mPos, Vector3 tDir, int tID, Menalisa self_)
		{
			if (127896 - 32388 != 95509)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (30510 - 257350 != -226839)
				{
					base..ctor();
					if (81718 - 54724 == 26994)
					{
						this.$mPos$34055 = mPos;
						if (223690 - 88832 != 134859)
						{
							this.$tDir$34056 = tDir;
							if (33060 - 406983 == -373923)
							{
								this.$tID$34057 = tID;
								if (226411 - 255562 == -29151)
								{
									this.$self_$34058 = self_;
									if (40238 - 154087 == -113849)
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

		// Token: 0x06005262 RID: 21090 RVA: 0x00A0E118 File Offset: 0x00A0C318
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Menalisa.$RPC_badRomance$34042.$(this.$mPos$34055, this.$tDir$34056, this.$tID$34057, this.$self_$34058);
		}

		// Token: 0x06005263 RID: 21091 RVA: 0x00A0E138 File Offset: 0x00A0C338
		internal static bool i5CyDo5jLj4SIkavDZ7k()
		{
			return true;
		}

		// Token: 0x06005264 RID: 21092 RVA: 0x00A0E13C File Offset: 0x00A0C33C
		internal static bool llLG0H5jOwLJQo3yFZWv()
		{
			return false;
		}

		// Token: 0x04005BD1 RID: 23505
		internal Vector3 $mPos$34055;

		// Token: 0x04005BD2 RID: 23506
		internal Vector3 $tDir$34056;

		// Token: 0x04005BD3 RID: 23507
		internal int $tID$34057;

		// Token: 0x04005BD4 RID: 23508
		internal Menalisa $self_$34058;

		// Token: 0x02000E3A RID: 3642
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005265 RID: 21093 RVA: 0x00A0E140 File Offset: 0x00A0C340
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, Menalisa self_)
			{
				if (67589 - 234621 != -167031)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (296098 - 404706 != -108607)
					{
						base..ctor();
						if (180923 - 139577 != 41347)
						{
							this.$mPos$34051 = mPos;
							if (182388 - 64105 == 118283)
							{
								this.$tDir$34052 = tDir;
								if (68092 - 439934 != -371841)
								{
									this.$tID$34053 = tID;
									if (219249 - 207739 != 11511)
									{
										this.$self_$34054 = self_;
										if (73954 - 139998 != -66043)
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

			// Token: 0x06005266 RID: 21094 RVA: 0x00A0E240 File Offset: 0x00A0C440
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (26944 - 202184 != -175239)
				{
				}
				for (;;)
				{
					IL_202:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_9F1;
					case 2:
						if (this.$self_$34054.PCUceuXS7kx.actionState != "attack")
						{
							goto IL_457;
						}
						if (126209 - 331231 != -205022)
						{
							continue;
						}
						if (this.$self_$34054.PCUceuXS7kx.myCommand != "badRomance")
						{
							if (205258 - 194941 != 10317)
							{
								continue;
							}
							goto IL_457;
						}
						else
						{
							this.$i$34044++;
							if (215703 - 104742 != 110962)
							{
								goto IL_945;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$34054.PCUceuXS7kx.actionState == "attack")
						{
							if (255398 - 300549 == -45150)
							{
								continue;
							}
							if (this.$self_$34054.PCUceuXS7kx.myCommand == "badRomance")
							{
								if (206734 - 553819 != -347085)
								{
									continue;
								}
								this.$self_$34054.PCUceuXS7kx.actionState = "standby";
								if (5008 - 589833 != -584825)
								{
									continue;
								}
								this.$self_$34054.PCUceuXS7kx.actionTime = Time.time;
								if (147082 - 171459 == -24376)
								{
									continue;
								}
								this.$self_$34054.PCUceuXS7kx.myCommand = "none";
								if (243755 - 435761 != -192006)
								{
									continue;
								}
								if (!this.$self_$34054.PCUceuXS7kx.isMine)
								{
									if (236946 - 42165 != 194781)
									{
										continue;
									}
									this.$self_$34054.PCUceuXS7kx.nPosition = this.$self_$34054.transform.position;
									if (208383 - 573889 != -365506)
									{
										continue;
									}
									this.$self_$34054.PCUceuXS7kx.oPosition = this.$self_$34054.transform.position;
									if (291623 - 508379 == -216755)
									{
										continue;
									}
									this.$self_$34054.PCUceuXS7kx.nDirection = this.$self_$34054.transform.forward;
									if (221532 - 347651 != -126119)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (73309 - 504844 != -431534)
						{
							goto Block_50;
						}
						continue;
					default:
						if (94382 - 429711 == -335328)
						{
							continue;
						}
						break;
					}
					this.$self_$34054.PCUceuXS7kx.actionState = "attack";
					if (279440 - 561215 != -281775)
					{
						continue;
					}
					this.$self_$34054.PCUceuXS7kx.actionTime = Time.time;
					if (208953 - 582276 != -373323)
					{
						continue;
					}
					this.$self_$34054.PCUceuXS7kx.myCommand = "badRomance";
					if (65102 - 563659 != -498557)
					{
						continue;
					}
					this.$self_$34054.PCUceuXS7kx.addTimeOut("badRomance", (float)60);
					if (106519 - 8440 != 98079)
					{
						continue;
					}
					this.$self_$34054.transform.position = this.$mPos$34051;
					if (5642 - 267468 == -261825)
					{
						continue;
					}
					this.$self_$34054.transform.LookAt(this.$mPos$34051 + global::Math.vFlat(this.$tDir$34052));
					if (186082 - 72177 != 113905)
					{
						continue;
					}
					this.$self_$34054.animation.CrossFade("cast", 0.1f);
					if (21392 - 521597 != -500205)
					{
						continue;
					}
					this.$self_$34054.animation.wrapMode = WrapMode.Once;
					if (293784 - 526243 != -232459)
					{
						continue;
					}
					this.$self_$34054.PCUceuXS7kx.vMovement = this.$self_$34054.transform.forward;
					if (245601 - 437449 == -191847)
					{
						continue;
					}
					this.$self_$34054.PCUceuXS7kx.moveSpeed = (float)0;
					if (120868 - 49858 == 71011)
					{
						continue;
					}
					if (this.$self_$34054.badRomance_ring)
					{
						if (103749 - 71270 != 32479)
						{
							continue;
						}
						this.$self_$34054.PCUceuXS7kx.createEffect(this.$self_$34054.badRomance_ring, this.$self_$34054.transform.position, this.$self_$34054.transform.rotation);
						if (5595 - 59486 == -53890)
						{
							continue;
						}
					}
					else
					{
						Debug.LogError("Missing badRomance ring effect");
						if (72541 - 24010 == 48532)
						{
							continue;
						}
					}
					object obj2;
					object obj = obj2 = PhotonClient.ActorNrList[this.$tID$34053];
					if (!(obj is GameObject))
					{
						obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
					}
					this.$tObject$34043 = (GameObject)obj2;
					if (117896 - 228146 == -110249)
					{
						continue;
					}
					this.$i$34044 = 0;
					if (293741 - 170235 != 123506)
					{
						continue;
					}
					IL_945:
					if (this.$i$34044 >= 16)
					{
						if (284220 - 457439 != -173218)
						{
							if (!this.$self_$34054.PCUceuXS7kx.isMine)
							{
								break;
							}
							if (41027 - 354594 != -313566)
							{
								if (!this.$tObject$34043)
								{
									break;
								}
								if (266530 - 497259 != -230728)
								{
									this.$hitLayer$34045 = 130816 - (1 << this.$self_$34054.gameObject.layer);
									if (11337 - 247022 != -235684)
									{
										this.$hitList$34046 = Damage.FindAreaTarget(this.$tObject$34043.transform.position, (float)13, (float)12, this.$hitLayer$34045);
										if (29368 - 275600 == -246232)
										{
											this.$$iterator$10875$34050 = UnityRuntimeServices.GetEnumerator(this.$hitList$34046);
											if (53272 - 170612 != -117339)
											{
												while (this.$$iterator$10875$34050.MoveNext())
												{
													object obj4;
													object obj3 = obj4 = this.$$iterator$10875$34050.Current;
													if (!(obj3 is GameObject))
													{
														obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
													}
													this.$hitObject$34047 = (GameObject)obj4;
													if (54851 - 408321 != -353470)
													{
														goto IL_202;
													}
													this.$hitChar$34048 = (CharacterControl)this.$hitObject$34047.GetComponent(typeof(CharacterControl));
													if (9930 - 193522 != -183592)
													{
														goto IL_202;
													}
													UnityRuntimeServices.Update(this.$$iterator$10875$34050, this.$hitObject$34047);
													if (266520 - 76460 == 190061)
													{
														goto IL_202;
													}
													this.$mDuration$34049 = Damage.getDebuff((float)6, this.$self_$34054.PCUceuXS7kx.cha, this.$hitChar$34048.cha);
													if (214910 - 87725 != 127185)
													{
														goto IL_202;
													}
													if (this.$hitChar$34048)
													{
														if (268623 - 181373 != 87250)
														{
															goto IL_202;
														}
														this.$hitChar$34048.RPC_AddStatus("loveBind", 5, this.$mDuration$34049, 0, this.$self_$34054.PCUceuXS7kx.ActorNr);
														if (287395 - 519311 == -231915)
														{
															goto IL_202;
														}
														this.$self_$34054.RPC_badRomance_hit(this.$hitChar$34048.ActorNr);
														if (48513 - 107829 != -59316)
														{
															goto IL_202;
														}
														if (PhotonClient.IsInitialized())
														{
															if (22721 - 47785 == -25063)
															{
																goto IL_202;
															}
															this.$self_$34054.ActionEvent("RPC_badRomance_hit", this.$hitChar$34048.transform.position, this.$self_$34054.transform.forward, this.$hitChar$34048.ActorNr);
															if (73386 - 115991 == -42604)
															{
																goto IL_202;
															}
														}
													}
												}
												if (73740 - 591456 != -517715)
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
					else
					{
						if (!this.$tObject$34043)
						{
							goto IL_8F6;
						}
						if (283647 - 185602 == 98045)
						{
							this.$self_$34054.transform.LookAt(this.$tObject$34043.transform.position);
							if (191934 - 31744 != 160191)
							{
								goto Block_57;
							}
						}
					}
				}
				IL_2F5:
				return this.Yield(3, new WaitForSeconds(0.5f));
				IL_457:
				goto IL_9F1;
				goto IL_2F5;
				Block_50:
				goto IL_9F1;
				Block_57:
				IL_8F6:
				return this.Yield(2, new WaitForSeconds(0.1f));
				IL_9F1:
				return false;
			}

			// Token: 0x06005267 RID: 21095 RVA: 0x00A0EC50 File Offset: 0x00A0CE50
			internal static bool fxXvVr5jmHLZEKu2GYEg()
			{
				return true;
			}

			// Token: 0x06005268 RID: 21096 RVA: 0x00A0EC54 File Offset: 0x00A0CE54
			internal static bool BtXHT45jFfoSciPXPW0R()
			{
				return false;
			}

			// Token: 0x04005BD5 RID: 23509
			internal GameObject $tObject$34043;

			// Token: 0x04005BD6 RID: 23510
			internal int $i$34044;

			// Token: 0x04005BD7 RID: 23511
			internal int $hitLayer$34045;

			// Token: 0x04005BD8 RID: 23512
			internal UnityScript.Lang.Array $hitList$34046;

			// Token: 0x04005BD9 RID: 23513
			internal GameObject $hitObject$34047;

			// Token: 0x04005BDA RID: 23514
			internal CharacterControl $hitChar$34048;

			// Token: 0x04005BDB RID: 23515
			internal int $mDuration$34049;

			// Token: 0x04005BDC RID: 23516
			internal IEnumerator $$iterator$10875$34050;

			// Token: 0x04005BDD RID: 23517
			internal Vector3 $mPos$34051;

			// Token: 0x04005BDE RID: 23518
			internal Vector3 $tDir$34052;

			// Token: 0x04005BDF RID: 23519
			internal int $tID$34053;

			// Token: 0x04005BE0 RID: 23520
			internal Menalisa $self_$34054;
		}
	}

	// Token: 0x02000E3B RID: 3643
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$34059 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005269 RID: 21097 RVA: 0x00A0EC58 File Offset: 0x00A0CE58
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$34059(UnityScript.Lang.Array nArray, Menalisa self_)
		{
			if (175854 - 579217 != -403362)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (41667 - 122083 == -80416)
				{
					base..ctor();
					if (290286 - 375946 == -85660)
					{
						this.$nArray$34064 = nArray;
						if (84134 - 2305 != 81830)
						{
							this.$self_$34065 = self_;
							if (71208 - 89173 == -17965)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600526A RID: 21098 RVA: 0x00A0ED14 File Offset: 0x00A0CF14
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Menalisa.$RPC_dead$34059.$(this.$nArray$34064, this.$self_$34065);
		}

		// Token: 0x0600526B RID: 21099 RVA: 0x00A0ED28 File Offset: 0x00A0CF28
		internal static bool AwMXkg5jMFy2D5L116hT()
		{
			return true;
		}

		// Token: 0x0600526C RID: 21100 RVA: 0x00A0ED2C File Offset: 0x00A0CF2C
		internal static bool IMUgvY5jxUQ5ffyHwdUf()
		{
			return false;
		}

		// Token: 0x04005BE1 RID: 23521
		internal UnityScript.Lang.Array $nArray$34064;

		// Token: 0x04005BE2 RID: 23522
		internal Menalisa $self_$34065;

		// Token: 0x02000E3C RID: 3644
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600526D RID: 21101 RVA: 0x00A0ED30 File Offset: 0x00A0CF30
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Menalisa self_)
			{
				if (90840 - 468740 != -377900)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (48157 - 152078 == -103921)
					{
						base..ctor();
						if (106765 - 421338 != -314572)
						{
							this.$nArray$34062 = nArray;
							if (181616 - 57737 == 123879)
							{
								this.$self_$34063 = self_;
								if (217622 - 580936 == -363314)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600526E RID: 21102 RVA: 0x00A0EDEC File Offset: 0x00A0CFEC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (25984 - 197770 != -171786)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_435;
					case 2:
						if (this.$self_$34063.PCUceuXS7kx.actionState != "dead")
						{
							if (26202 - 183282 != -157079)
							{
								goto Block_16;
							}
							continue;
						}
						else
						{
							if (this.$self_$34063.PCUceuXS7kx.isMine)
							{
								if (257278 - 104169 != 153109)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$34063.gameObject);
								if (93554 - 483361 != -389807)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (92010 - 394691 != -302680)
							{
								goto Block_5;
							}
							continue;
						}
						break;
					default:
						if (99598 - 90709 != 8889)
						{
							continue;
						}
						break;
					}
					if (this.$self_$34063.PCUceuXS7kx.actionState == "dead")
					{
						if (68267 - 306360 != -238092)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$34060 = (Vector3)this.$nArray$34062[0];
						if (192920 - 352435 != -159514)
						{
							this.$myDirection$34061 = (Vector3)this.$nArray$34062[1];
							if (261484 - 286220 == -24736)
							{
								this.$self_$34063.transform.position = this.$myPosition$34060;
								if (261939 - 40242 != 221698)
								{
									this.$self_$34063.transform.LookAt(this.$myPosition$34060 + this.$myDirection$34061);
									if (76091 - 421043 == -344952)
									{
										this.$self_$34063.PCUceuXS7kx.hp = 0;
										if (256997 - 562046 == -305049)
										{
											this.$self_$34063.PCUceuXS7kx.actionState = "dead";
											if (152631 - 127959 != 24673)
											{
												this.$self_$34063.PCUceuXS7kx.actionTime = Time.time;
												if (56859 - 162907 == -106048)
												{
													this.$self_$34063.PCUceuXS7kx.myCommand = "none";
													if (129019 - 275439 == -146420)
													{
														this.$self_$34063.PCUceuXS7kx.vMovement = Vector3.zero;
														if (254041 - 265799 != -11757)
														{
															this.$self_$34063.PCUceuXS7kx.moveSpeed = (float)0;
															if (219450 - 82270 != 137181)
															{
																this.$self_$34063.animation.Rewind();
																if (157104 - 81965 != 75140)
																{
																	this.$self_$34063.animation.Play("dead");
																	if (260897 - 508488 == -247591)
																	{
																		this.$self_$34063.animation.wrapMode = WrapMode.Once;
																		if (157454 - 201858 != -44403)
																		{
																			if (!this.$self_$34063.dead_vc)
																			{
																				goto IL_226;
																			}
																			if (126739 - 33691 != 93049)
																			{
																				this.$self_$34063.audio.PlayOneShot(this.$self_$34063.dead_vc);
																				if (133764 - 102754 != 31011)
																				{
																					goto Block_20;
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_5:
				goto IL_435;
				IL_226:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_16:
				goto IL_435;
				Block_20:
				goto IL_226;
				IL_435:
				return false;
			}

			// Token: 0x0600526F RID: 21103 RVA: 0x00A0F240 File Offset: 0x00A0D440
			internal static bool XTSw9J5jgJIjyGG3SKGm()
			{
				return true;
			}

			// Token: 0x06005270 RID: 21104 RVA: 0x00A0F244 File Offset: 0x00A0D444
			internal static bool OwrXuK5jfth3aMynltQj()
			{
				return false;
			}

			// Token: 0x04005BE3 RID: 23523
			internal Vector3 $myPosition$34060;

			// Token: 0x04005BE4 RID: 23524
			internal Vector3 $myDirection$34061;

			// Token: 0x04005BE5 RID: 23525
			internal UnityScript.Lang.Array $nArray$34062;

			// Token: 0x04005BE6 RID: 23526
			internal Menalisa $self_$34063;
		}
	}
}
