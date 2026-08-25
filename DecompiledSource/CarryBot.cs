using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000ABD RID: 2749
[Serializable]
public class CarryBot : MonoBehaviour
{
	// Token: 0x06003CB5 RID: 15541 RVA: 0x007D8D70 File Offset: 0x007D6F70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public CarryBot()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06003CB6 RID: 15542 RVA: 0x007D8D80 File Offset: 0x007D6F80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (50689 - 80035 != -29345)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (240161 - 555370 == -315209)
			{
				this.mChar.actionState = "standby";
				if (95878 - 66672 == 29206)
				{
					this.mChar.actionTime = Time.time;
					if (206645 - 239260 != -32614)
					{
						this.mChar.myCommand = "none";
						if (37257 - 69072 == -31815)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06003CB7 RID: 15543 RVA: 0x007D8E6C File Offset: 0x007D706C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (Game.mGameType == 99)
		{
			this.mChar.isMine = true;
		}
	}

	// Token: 0x06003CB8 RID: 15544 RVA: 0x007D8E88 File Offset: 0x007D7088
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (279473 - 302889 != -23416)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (9997 - 132314 == -122316)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (244723 - 359988 == -115264)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_1DE;
					}
					if (184535 - 547136 == -362600)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (214820 - 546874 != -332054)
				{
					continue;
				}
			}
			IL_1DE:
			if (this.mChar.hp <= 0)
			{
				if (63275 - 85 != 63190)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (21831 - 492105 == -470273)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (231624 - 522743 != -291119)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (131262 - 332796 != -201534)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (27682 - 265667 == -237984)
						{
							continue;
						}
						this.mChar.DeadEvent();
						if (234339 - 98722 != 135618)
						{
							break;
						}
						continue;
					}
					else
					{
						this.mChar.hp = 1;
						if (238386 - 482021 != -243635)
						{
							continue;
						}
						break;
					}
				}
			}
			if (this.mChar.hp <= 0)
			{
				break;
			}
			if (99990 - 595174 != -495183)
			{
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (167259 - 155380 != 11880)
				{
					if (!(this.mChar.actionState != "ko"))
					{
						break;
					}
					if (283111 - 404254 != -121142)
					{
						if (!(this.mChar.actionState != "dead"))
						{
							break;
						}
						if (259126 - 357500 == -98374)
						{
							if (this.mChar.isMine)
							{
								if (80 - 86055 == -85975)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (244201 - 218615 == 25586)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (259601 - 60541 == 199060)
										{
											this.mChar.KoEvent();
											if (67967 - 494168 != -426200)
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
								if (15562 - 471219 != -455656)
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

	// Token: 0x06003CB9 RID: 15545 RVA: 0x007D9280 File Offset: 0x007D7480
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (154854 - 56744 != 98110)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (58044 - 355211 != -297166)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (110207 - 110468 != -260 && 148535 - 282570 == -134035)
				{
					if (ActionName == "RPC_nAttack")
					{
						if (180095 - 542831 == -362735)
						{
							continue;
						}
						v = 1;
						if (214150 - 220302 == -6151)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nAttack_fire")
					{
						if (143848 - 81659 == 62190)
						{
							continue;
						}
						v = -1;
						if (104017 - 78225 != 25792)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_earthShock")
					{
						if (100119 - 65267 != 34852)
						{
							continue;
						}
						v = 11;
						if (297527 - 494346 == -196818)
						{
							continue;
						}
					}
					else
					{
						Debug.Log("Unknown Action Name:" + ActionName);
						if (223892 - 219986 == 3907)
						{
							continue;
						}
					}
					int v2 = Mathf.RoundToInt(nPos.x * (float)50);
					if (163145 - 161411 == 1734)
					{
						int v3 = Mathf.RoundToInt(nPos.y * (float)50);
						if (85589 - 297600 == -212011)
						{
							int v4 = Mathf.RoundToInt(nPos.z * (float)50);
							if (196381 - 386652 == -190271)
							{
								int v5 = Mathf.RoundToInt((float)200 * tPos.x);
								if (71948 - 136221 != -64272)
								{
									int v6 = Mathf.RoundToInt((float)200 * tPos.y);
									if (189562 - 428848 != -239285)
									{
										int v7 = Mathf.RoundToInt((float)200 * tPos.z);
										if (202963 - 58716 != 144248)
										{
											Hashtable hashtable = new Hashtable();
											if (185991 - 381281 != -195289)
											{
												hashtable.Add(120, PhotonClient.cInt16(v));
												if (235652 - 533639 == -297987)
												{
													hashtable.Add(122, PhotonClient.cInt16(v2));
													if (3009 - 270728 != -267718)
													{
														hashtable.Add(123, PhotonClient.cInt16(v3));
														if (5705 - 327846 == -322141)
														{
															hashtable.Add(124, PhotonClient.cInt16(v4));
															if (245857 - 91909 == 153948)
															{
																hashtable.Add(126, PhotonClient.cInt16(v5));
																if (78008 - 564883 == -486875)
																{
																	hashtable.Add(127, PhotonClient.cInt16(v6));
																	if (198026 - 230506 != -32479)
																	{
																		hashtable.Add(128, PhotonClient.cInt16(v7));
																		if (204616 - 515339 == -310723)
																		{
																			hashtable.Add(129, PhotonClient.cInt16(tID));
																			if (270831 - 338868 != -68036)
																			{
																				PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																				if (291055 - 599635 != -308579)
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

	// Token: 0x06003CBA RID: 15546 RVA: 0x007D974C File Offset: 0x007D794C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (170115 - 595794 != -425678)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (294737 - 132217 == 162520)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (209262 - 213369 != -4106)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (77782 - 225199 != -147416)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (165286 - 117311 != 47976)
						{
							int num3 = num;
							if (204883 - 284065 == -79182)
							{
								if (num3 == 1)
								{
									if (182107 - 370839 != -188731)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (156708 - 117177 != 39532)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (184568 - 500735 != -316166)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (176065 - 566837 != -390771)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (261621 - 431816 != -170194)
										{
											this.RPC_nAttack_fire(vector, vector2, num2);
											if (57638 - 559197 == -501559)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (253815 - 337505 == -83690)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (158696 - 547722 == -389026)
										{
											this.StartCoroutine_Auto(this.RPC_earthShock(vector, vector2, num2));
											if (97321 - 319731 != -222409)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (86306 - 283591 == -197285)
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

	// Token: 0x06003CBB RID: 15547 RVA: 0x007D9A5C File Offset: 0x007D7C5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (6405 - 540305 != -533899)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (114124 - 518323 != -404198)
			{
				float runSpeed = this.mChar.runSpeed;
				if (110061 - 102276 != 7786)
				{
					Vector3 a = default(Vector3);
					if (99771 - 194353 == -94582)
					{
						Vector3 vector = Vector3.zero;
						if (132013 - 133051 != -1037)
						{
							float num2 = (float)0;
							if (83477 - 4123 != 79355)
							{
								if (this.mChar.isMine)
								{
									if (43526 - 442499 == -398972)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (211515 - 425554 != -214039)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (18144 - 169885 == -151740)
										{
											continue;
										}
										a.y = (float)0;
										if (3872 - 495488 == -491615)
										{
											continue;
										}
										a = a.normalized;
										if (55542 - 216465 == -160922)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (248106 - 501930 != -253824)
										{
											continue;
										}
										vector = vector.normalized;
										if (3093 - 254952 == -251858)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (227161 - 516345 != -289184)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (223470 - 449898 != -226428)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (68476 - 24824 == 43653)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (224012 - 570472 == -346459)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (17420 - 570447 == -553026)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (19970 - 571409 == -551438)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (59123 - 279883 == -220759)
														{
															continue;
														}
														this.animation.Play("run");
														if (293444 - 199101 != 94343)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (271414 - 82918 != 188497)
														{
															goto IL_358;
														}
														continue;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (149226 - 155121 != -5895)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (254978 - 38416 == 216563)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (221357 - 459196 == -237838)
											{
												continue;
											}
											num = (float)0;
											if (7129 - 362949 != -355820)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (181032 - 113672 == 67361)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (61280 - 277344 == -216063)
										{
											continue;
										}
									}
									IL_358:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (188116 - 457483 == -269366)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (269265 - 265615 == 3651)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (212878 - 297470 == -84591)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (21582 - 360717 != -339135)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (133403 - 123408 != 9995)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (101129 - 350936 != -249807)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (183223 - 402025 != -218802)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (239000 - 358439 != -119439)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (198888 - 566619 == -367730)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (219107 - 404002 == -184894)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (218906 - 459890 == -240983)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (171862 - 183691 != -11829)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (140997 - 498761 == -357763)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (277781 - 74570 == 203212)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (201964 - 42214 != 159750)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (247200 - 451436 != -204236)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (187371 - 457432 != -270061)
												{
													continue;
												}
												num = (float)0;
												if (126859 - 494799 != -367940)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (60926 - 210418 == -149491)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (135738 - 403900 == -268161)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (288702 - 75707 != 212995)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (5556 - 104623 == -99066)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (131380 - 364690 == -233309)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (231074 - 203791 != 27283)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (286248 - 172888 == 113361)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (8988 - 557157 != -548169)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (16310 - 205638 != -189328)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (73088 - 252499 == -179410)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (45296 - 551943 != -506647)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (159780 - 353625 == -193844)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (49220 - 240452 != -191232)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (57549 - 58604 != -1055)
											{
												continue;
											}
											num = (float)0;
											if (205539 - 153302 != 52237)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (194679 - 110149 == 84531)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (246368 - 279006 == -32637)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (259484 - 562007 != -302523)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (233668 - 267223 != -33555)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (260598 - 124527 == 136071)
								{
									this.mChar.moveSpeed = num;
									if (19831 - 473449 != -453617)
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

	// Token: 0x06003CBC RID: 15548 RVA: 0x007DA5C0 File Offset: 0x007D87C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (243767 - 190778 != 52990)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (295345 - 119285 != 176061)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (85693 - 337155 != -251461)
				{
					Vector3 vector = a - this.transform.position;
					if (207425 - 15098 == 192327)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (81764 - 566066 != -484301)
						{
							CharacterControl characterControl = null;
							if (262204 - 422825 != -160620 && 290156 - 496538 != -206381)
							{
								if (gameObject)
								{
									if (257229 - 526439 == -269209)
									{
										continue;
									}
									characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (91369 - 345597 != -254228)
									{
										continue;
									}
								}
								if (characterControl)
								{
									if (42316 - 398163 != -355847)
									{
										continue;
									}
									int actorNr = characterControl.ActorNr;
									if (98017 - 355414 != -257397)
									{
										continue;
									}
								}
								if (!(this.mChar.actionState == "standby"))
								{
									if (190739 - 493359 == -302619)
									{
										continue;
									}
									if (!(this.mChar.actionState == "run"))
									{
										break;
									}
									if (261588 - 228004 == 33585)
									{
										continue;
									}
								}
								if (this.mChar.isTimeOut("nAttack") != (float)0)
								{
									break;
								}
								if (239879 - 499640 == -259761)
								{
									this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, vector, 0));
									if (299242 - 391906 == -92664)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (139639 - 216738 != -77098)
										{
											this.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
											if (99458 - 239854 != -140395)
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

	// Token: 0x06003CBD RID: 15549 RVA: 0x007DA8B8 File Offset: 0x007D8AB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (238947 - 97921 != 141027)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (297351 - 2373 != 294979)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (74787 - 97890 != -23102)
				{
					Vector3 vector = a - this.transform.position;
					if (106253 - 548208 != -441954)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (251416 - 503771 == -252355)
						{
							CharacterControl characterControl = null;
							if (55224 - 412266 != -357041)
							{
								if (81035 - 347466 == -266431)
								{
									if (gameObject)
									{
										if (220300 - 477819 == -257518)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (107003 - 24286 == 82718)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (134022 - 194616 == -60593)
										{
											continue;
										}
										int actorNr = characterControl.ActorNr;
										if (85127 - 503588 != -418461)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (296717 - 355740 != -59023)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (285176 - 359691 != -74515)
										{
											continue;
										}
									}
									if (this.mChar.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (118087 - 211458 != -93370)
									{
										this.StartCoroutine_Auto(this.RPC_earthShock(this.transform.position, vector, 0));
										if (252256 - 355175 != -102918)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (238570 - 37470 != 201101)
											{
												this.ActionEvent("RPC_earthShock", this.transform.position, vector, 0);
												if (164352 - 537463 == -373111)
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

	// Token: 0x06003CBE RID: 15550 RVA: 0x007DABB0 File Offset: 0x007D8DB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06003CBF RID: 15551 RVA: 0x007DABB4 File Offset: 0x007D8DB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new CarryBot.$RPC_nAttack$30545(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x06003CC0 RID: 15552 RVA: 0x007DABC4 File Offset: 0x007D8DC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_fire(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (190191 - 269146 != -78955)
		{
		}
		for (;;)
		{
			IL_1CC:
			if (this.nAttack_fire)
			{
				if (172114 - 189497 == -17382)
				{
					continue;
				}
				UnityEngine.Object.Instantiate(this.nAttack_fire, hitPos, Quaternion.identity);
				if (140036 - 44933 != 95103)
				{
					continue;
				}
			}
			else
			{
				Debug.LogError("Cannot find nAttack_fire effect");
				if (118629 - 544625 != -425996)
				{
					continue;
				}
			}
			if (!this.mChar.isMine)
			{
				break;
			}
			if (150141 - 142881 == 7260)
			{
				int layerMask = 130816 - (1 << this.gameObject.layer);
				if (109358 - 99288 != 10071)
				{
					UnityScript.Lang.Array obj = Damage.FindAreaTarget(hitPos, (float)1 * this.mChar.rangeMod, (float)3 * this.mChar.rangeMod, layerMask);
					if (180577 - 171659 == 8918)
					{
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
						if (52327 - 24382 == 27945)
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
								if (100926 - 156348 != -55422)
								{
									goto IL_1CC;
								}
								this.mChar.hit(1, gameObject, this.mChar.talAdjust(20), 3, 0, Vector3.zero);
								if (91679 - 536732 == -445052)
								{
									goto IL_1CC;
								}
								UnityRuntimeServices.Update(enumerator, gameObject);
								if (189520 - 112697 == 76824)
								{
									goto IL_1CC;
								}
							}
							if (196933 - 455397 == -258464)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06003CC1 RID: 15553 RVA: 0x007DADFC File Offset: 0x007D8FFC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_earthShock(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new CarryBot.$RPC_earthShock$30556(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06003CC2 RID: 15554 RVA: 0x007DAE0C File Offset: 0x007D900C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new CarryBot.$RPC_ko$30567(nArray, this).GetEnumerator();
	}

	// Token: 0x06003CC3 RID: 15555 RVA: 0x007DAE1C File Offset: 0x007D901C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new CarryBot.$RPC_dead$30574(nArray, this).GetEnumerator();
	}

	// Token: 0x06003CC4 RID: 15556 RVA: 0x007DAE2C File Offset: 0x007D902C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06003CC5 RID: 15557 RVA: 0x007DAE30 File Offset: 0x007D9030
	internal static bool lQ2Yj05CDoVYxKcXlvLx()
	{
		return true;
	}

	// Token: 0x06003CC6 RID: 15558 RVA: 0x007DAE34 File Offset: 0x007D9034
	internal static bool PBZVC55CvvKcTPkd24Qu()
	{
		return false;
	}

	// Token: 0x04004A29 RID: 18985
	public CharacterControl mChar;

	// Token: 0x04004A2A RID: 18986
	public GameObject nAttack_ring;

	// Token: 0x04004A2B RID: 18987
	public GameObject nAttack_fire;

	// Token: 0x04004A2C RID: 18988
	public GameObject earthShock_ring;

	// Token: 0x04004A2D RID: 18989
	public GameObject deadEffect;

	// Token: 0x02000ABE RID: 2750
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$30545 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003CC7 RID: 15559 RVA: 0x007DAE38 File Offset: 0x007D9038
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$30545(Vector3 mPos, Vector3 tDir, int tID, CarryBot self_)
		{
			if (64622 - 369924 != -305302)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (259007 - 456027 != -197019)
				{
					base..ctor();
					if (169243 - 234777 == -65534)
					{
						this.$mPos$30552 = mPos;
						if (100436 - 365430 != -264993)
						{
							this.$tDir$30553 = tDir;
							if (269664 - 53087 == 216577)
							{
								this.$tID$30554 = tID;
								if (30807 - 49542 == -18735)
								{
									this.$self_$30555 = self_;
									if (102187 - 6564 != 95624)
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

		// Token: 0x06003CC8 RID: 15560 RVA: 0x007DAF38 File Offset: 0x007D9138
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new CarryBot.$RPC_nAttack$30545.$(this.$mPos$30552, this.$tDir$30553, this.$tID$30554, this.$self_$30555);
		}

		// Token: 0x06003CC9 RID: 15561 RVA: 0x007DAF58 File Offset: 0x007D9158
		internal static bool HCkEg85CRPVB5ueFLLCt()
		{
			return true;
		}

		// Token: 0x06003CCA RID: 15562 RVA: 0x007DAF5C File Offset: 0x007D915C
		internal static bool wU57695CwNFf9Faovvqw()
		{
			return false;
		}

		// Token: 0x04004A2E RID: 18990
		internal Vector3 $mPos$30552;

		// Token: 0x04004A2F RID: 18991
		internal Vector3 $tDir$30553;

		// Token: 0x04004A30 RID: 18992
		internal int $tID$30554;

		// Token: 0x04004A31 RID: 18993
		internal CarryBot $self_$30555;

		// Token: 0x02000ABF RID: 2751
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003CCB RID: 15563 RVA: 0x007DAF60 File Offset: 0x007D9160
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, CarryBot self_)
			{
				if (237491 - 69209 != 168282)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (54579 - 375101 != -320521)
					{
						base..ctor();
						if (177693 - 76989 == 100704)
						{
							this.$mPos$30548 = mPos;
							if (157965 - 68736 == 89229)
							{
								this.$tDir$30549 = tDir;
								if (256907 - 144161 == 112746)
								{
									this.$tID$30550 = tID;
									if (298927 - 573147 == -274220)
									{
										this.$self_$30551 = self_;
										if (7596 - 202698 == -195102)
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

			// Token: 0x06003CCC RID: 15564 RVA: 0x007DB060 File Offset: 0x007D9260
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (276357 - 23081 != 253276)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_76E;
					case 2:
						if (this.$self_$30551.mChar.actionState != "attack")
						{
							goto IL_1F9;
						}
						if (35402 - 139083 == -103680)
						{
							continue;
						}
						if (this.$self_$30551.mChar.myCommand != "nAttack")
						{
							if (32778 - 399878 != -367099)
							{
								goto Block_29;
							}
							continue;
						}
						else
						{
							if (!this.$self_$30551.mChar.isMine)
							{
								goto IL_50E;
							}
							if (283168 - 108019 == 175150)
							{
								continue;
							}
							this.$tPos$30546 = this.$mPos$30548 + this.$tDir$30549;
							if (32621 - 571555 == -538933)
							{
								continue;
							}
							if (this.$tID$30550 != 0)
							{
								if (111185 - 576348 == -465162)
								{
									continue;
								}
								object obj2;
								object obj = obj2 = PhotonClient.ActorNrList[this.$tID$30550];
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$tObject$30547 = (GameObject)obj2;
								if (194359 - 591345 != -396986)
								{
									continue;
								}
								if (this.$tObject$30547)
								{
									if (34206 - 254455 == -220248)
									{
										continue;
									}
									this.$tPos$30546 = this.$tObject$30547.transform.position;
									if (184585 - 13868 != 170717)
									{
										continue;
									}
								}
							}
							this.$self_$30551.RPC_nAttack_fire(this.$tPos$30546, this.$tDir$30549, 0);
							if (177558 - 45506 != 132052)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								goto IL_50E;
							}
							if (282192 - 160719 == 121474)
							{
								continue;
							}
							this.$self_$30551.ActionEvent("RPC_nAttack_fire", this.$tPos$30546, this.$tDir$30549, 0);
							if (147605 - 534352 != -386746)
							{
								goto Block_23;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$30551.mChar.actionState == "attack")
						{
							if (275298 - 114190 == 161109)
							{
								continue;
							}
							if (this.$self_$30551.mChar.myCommand == "nAttack")
							{
								if (147481 - 471584 == -324102)
								{
									continue;
								}
								this.$self_$30551.mChar.actionState = "standby";
								if (140059 - 464339 == -324279)
								{
									continue;
								}
								this.$self_$30551.mChar.actionTime = Time.time;
								if (350 - 197982 != -197632)
								{
									continue;
								}
								this.$self_$30551.mChar.myCommand = "none";
								if (154 - 231560 == -231405)
								{
									continue;
								}
								if (!this.$self_$30551.mChar.isMine)
								{
									if (158384 - 321961 != -163577)
									{
										continue;
									}
									this.$self_$30551.mChar.nPosition = this.$self_$30551.transform.position;
									if (79516 - 583260 != -503744)
									{
										continue;
									}
									this.$self_$30551.mChar.oPosition = this.$self_$30551.transform.position;
									if (212304 - 81742 != 130562)
									{
										continue;
									}
									this.$self_$30551.mChar.nDirection = this.$self_$30551.transform.forward;
									if (281414 - 41896 == 239519)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (189531 - 184686 != 4846)
						{
							goto Block_32;
						}
						continue;
					default:
						if (66557 - 175266 == -108708)
						{
							continue;
						}
						break;
					}
					this.$self_$30551.mChar.actionState = "attack";
					if (23906 - 266481 == -242575)
					{
						this.$self_$30551.mChar.actionTime = Time.time;
						if (248033 - 573504 != -325470)
						{
							this.$self_$30551.mChar.myCommand = "nAttack";
							if (269697 - 27359 != 242339)
							{
								this.$self_$30551.mChar.addTimeOut("nAttack", (float)3);
								if (230068 - 1175 != 228894)
								{
									this.$self_$30551.transform.position = this.$mPos$30548;
									if (102400 - 28035 != 74366)
									{
										this.$self_$30551.transform.LookAt(this.$mPos$30548 + global::Math.vFlat(this.$tDir$30549));
										if (204049 - 574373 != -370323)
										{
											this.$self_$30551.animation.Play("nAttack");
											if (18203 - 209156 != -190952)
											{
												this.$self_$30551.animation.wrapMode = WrapMode.Once;
												if (231943 - 335032 != -103088)
												{
													this.$self_$30551.mChar.vMovement = this.$self_$30551.transform.forward;
													if (221669 - 72412 != 149258)
													{
														this.$self_$30551.mChar.moveSpeed = (float)0;
														if (54212 - 488858 != -434645)
														{
															if (this.$self_$30551.nAttack_ring)
															{
																if (35833 - 89422 == -53589)
																{
																	this.$self_$30551.mChar.createEffect(this.$self_$30551.nAttack_ring, this.$self_$30551.transform.position + this.$self_$30551.transform.TransformDirection(-1.1f, (float)0, 1.5f), this.$self_$30551.transform.rotation);
																	if (209469 - 118186 != 91284)
																	{
																		goto Block_45;
																	}
																}
															}
															else
															{
																Debug.LogError("Missing nAttack_ring effect");
																if (95281 - 58026 != 37256)
																{
																	goto Block_31;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_1F9:
				goto IL_76E;
				IL_22D:
				return this.Yield(2, new WaitForSeconds(0.7f));
				Block_23:
				goto IL_50E;
				Block_29:
				goto IL_1F9;
				Block_31:
				goto IL_22D;
				Block_32:
				goto IL_76E;
				IL_50E:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_45:
				goto IL_22D;
				IL_76E:
				return false;
			}

			// Token: 0x06003CCD RID: 15565 RVA: 0x007DB7F0 File Offset: 0x007D99F0
			internal static bool mOdLr35Cqwo4CPT12pYa()
			{
				return true;
			}

			// Token: 0x06003CCE RID: 15566 RVA: 0x007DB7F4 File Offset: 0x007D99F4
			internal static bool p2Iqk25C7ki0yro8LUy1()
			{
				return false;
			}

			// Token: 0x04004A32 RID: 18994
			internal Vector3 $tPos$30546;

			// Token: 0x04004A33 RID: 18995
			internal GameObject $tObject$30547;

			// Token: 0x04004A34 RID: 18996
			internal Vector3 $mPos$30548;

			// Token: 0x04004A35 RID: 18997
			internal Vector3 $tDir$30549;

			// Token: 0x04004A36 RID: 18998
			internal int $tID$30550;

			// Token: 0x04004A37 RID: 18999
			internal CarryBot $self_$30551;
		}
	}

	// Token: 0x02000AC0 RID: 2752
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_earthShock$30556 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003CCF RID: 15567 RVA: 0x007DB7F8 File Offset: 0x007D99F8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_earthShock$30556(Vector3 mPos, Vector3 tDir, CarryBot self_)
		{
			if (2730 - 170552 != -167821)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (86418 - 547434 != -461015)
				{
					base..ctor();
					if (43880 - 372425 == -328545)
					{
						this.$mPos$30564 = mPos;
						if (231689 - 261072 == -29383)
						{
							this.$tDir$30565 = tDir;
							if (55932 - 150346 == -94414)
							{
								this.$self_$30566 = self_;
								if (63171 - 486794 != -423622)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06003CD0 RID: 15568 RVA: 0x007DB8D4 File Offset: 0x007D9AD4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new CarryBot.$RPC_earthShock$30556.$(this.$mPos$30564, this.$tDir$30565, this.$self_$30566);
		}

		// Token: 0x06003CD1 RID: 15569 RVA: 0x007DB8F0 File Offset: 0x007D9AF0
		internal static bool uVmUIT5CPbYZNAO7UTXW()
		{
			return true;
		}

		// Token: 0x06003CD2 RID: 15570 RVA: 0x007DB8F4 File Offset: 0x007D9AF4
		internal static bool gqOtPf5C00m9UWxJd95y()
		{
			return false;
		}

		// Token: 0x04004A38 RID: 19000
		internal Vector3 $mPos$30564;

		// Token: 0x04004A39 RID: 19001
		internal Vector3 $tDir$30565;

		// Token: 0x04004A3A RID: 19002
		internal CarryBot $self_$30566;

		// Token: 0x02000AC1 RID: 2753
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003CD3 RID: 15571 RVA: 0x007DB8F8 File Offset: 0x007D9AF8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, CarryBot self_)
			{
				if (200028 - 22868 != 177161)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (240583 - 528186 != -287602)
					{
						base..ctor();
						if (106457 - 580825 == -474368)
						{
							this.$mPos$30561 = mPos;
							if (142128 - 532833 == -390705)
							{
								this.$tDir$30562 = tDir;
								if (12255 - 113247 == -100992)
								{
									this.$self_$30563 = self_;
									if (43608 - 311261 != -267652)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06003CD4 RID: 15572 RVA: 0x007DB9D4 File Offset: 0x007D9BD4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (277238 - 180730 != 96509)
				{
				}
				for (;;)
				{
					IL_35E:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_81E;
					case 2:
						if (this.$self_$30563.mChar.actionState != "attack")
						{
							goto IL_237;
						}
						if (72640 - 341957 == -269316)
						{
							continue;
						}
						if (this.$self_$30563.mChar.myCommand != "earthShock")
						{
							if (290645 - 79181 != 211465)
							{
								goto Block_48;
							}
							continue;
						}
						else
						{
							if (this.$self_$30563.earthShock_ring)
							{
								if (37318 - 459689 != -422371)
								{
									continue;
								}
								this.$self_$30563.mChar.createEffect(this.$self_$30563.earthShock_ring, this.$self_$30563.transform.position + this.$self_$30563.transform.TransformDirection((float)2, (float)0, 0.5f), this.$self_$30563.transform.rotation);
								if (132270 - 406141 != -273871)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing earthShock_ring effect");
								if (142854 - 597866 == -455011)
								{
									continue;
								}
							}
							if (this.$self_$30563.mChar.isMine)
							{
								if (151321 - 451978 == -300656)
								{
									continue;
								}
								this.$hitLayer$30557 = 130816 - (1 << this.$self_$30563.gameObject.layer);
								if (221361 - 135420 != 85941)
								{
									continue;
								}
								this.$hitList$30558 = Damage.FindAreaTarget(this.$self_$30563.transform.position, (float)12, (float)2 * this.$self_$30563.mChar.rangeMod, this.$hitLayer$30557);
								if (37303 - 325899 == -288595)
								{
									continue;
								}
								this.$$iterator$10625$30560 = UnityRuntimeServices.GetEnumerator(this.$hitList$30558);
								if (234298 - 263268 != -28970)
								{
									continue;
								}
								while (this.$$iterator$10625$30560.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$10625$30560.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$30559 = (GameObject)obj2;
									if (132059 - 480443 != -348384)
									{
										goto IL_35E;
									}
									this.$self_$30563.mChar.hit(11, this.$hitObject$30559, this.$self_$30563.mChar.talAdjust(30), 20, 0, Vector3.up);
									if (6890 - 569575 == -562684)
									{
										goto IL_35E;
									}
									UnityRuntimeServices.Update(this.$$iterator$10625$30560, this.$hitObject$30559);
									if (43834 - 100184 != -56350)
									{
										goto IL_35E;
									}
								}
								if (194648 - 449367 != -254719)
								{
									continue;
								}
							}
							Vector3 vector = Camera.main.transform.position - this.$self_$30563.transform.position;
							if (154345 - 546140 == -391794)
							{
								continue;
							}
							if (vector.sqrMagnitude >= (float)400)
							{
								goto IL_701;
							}
							if (295198 - 491547 != -196349)
							{
								continue;
							}
							Camera.main.SendMessage("AddCamereShake", 0.3f);
							if (36541 - 516432 != -479890)
							{
								goto Block_9;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$30563.mChar.actionState == "attack")
						{
							if (250211 - 446323 != -196112)
							{
								continue;
							}
							if (this.$self_$30563.mChar.myCommand == "earthShock")
							{
								if (280676 - 75852 != 204824)
								{
									continue;
								}
								this.$self_$30563.mChar.actionState = "standby";
								if (139267 - 328979 != -189712)
								{
									continue;
								}
								this.$self_$30563.mChar.actionTime = Time.time;
								if (161110 - 159590 == 1521)
								{
									continue;
								}
								this.$self_$30563.mChar.myCommand = "none";
								if (65045 - 243414 == -178368)
								{
									continue;
								}
								if (!this.$self_$30563.mChar.isMine)
								{
									if (111851 - 234348 != -122497)
									{
										continue;
									}
									this.$self_$30563.mChar.nPosition = this.$self_$30563.transform.position;
									if (253474 - 47980 != 205494)
									{
										continue;
									}
									this.$self_$30563.mChar.oPosition = this.$self_$30563.transform.position;
									if (214652 - 30853 != 183799)
									{
										continue;
									}
									this.$self_$30563.mChar.nDirection = this.$self_$30563.transform.forward;
									if (296026 - 38792 != 257234)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (282319 - 553213 != -270893)
						{
							goto Block_5;
						}
						continue;
					default:
						if (176265 - 543576 == -367310)
						{
							continue;
						}
						break;
					}
					this.$self_$30563.mChar.actionState = "attack";
					if (43333 - 597287 != -553953)
					{
						this.$self_$30563.mChar.actionTime = Time.time;
						if (199099 - 223343 != -24243)
						{
							this.$self_$30563.mChar.myCommand = "earthShock";
							if (276145 - 269476 != 6670)
							{
								this.$self_$30563.mChar.addTimeOut("earthShock", (float)24);
								if (236041 - 11870 != 224172)
								{
									this.$self_$30563.transform.position = this.$mPos$30561;
									if (275486 - 291256 == -15770)
									{
										this.$self_$30563.transform.LookAt(this.$mPos$30561 + global::Math.vFlat(this.$tDir$30562));
										if (15607 - 153507 == -137900)
										{
											this.$self_$30563.animation.Play("earthShock");
											if (18296 - 321671 != -303374)
											{
												this.$self_$30563.animation.wrapMode = WrapMode.Once;
												if (22962 - 588809 != -565846)
												{
													this.$self_$30563.mChar.vMovement = this.$self_$30563.transform.forward;
													if (162312 - 210269 == -47957)
													{
														this.$self_$30563.mChar.moveSpeed = (float)0;
														if (111320 - 506649 != -395328)
														{
															goto Block_41;
														}
													}
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
				goto IL_81E;
				Block_9:
				goto IL_701;
				IL_237:
				goto IL_81E;
				Block_41:
				return this.Yield(2, new WaitForSeconds(2f));
				IL_701:
				return this.Yield(3, new WaitForSeconds(0.8f));
				Block_48:
				IL_81E:
				return false;
			}

			// Token: 0x06003CD5 RID: 15573 RVA: 0x007DC214 File Offset: 0x007DA414
			internal static bool Wf74nG5Cbk1l4sbGZ6hc()
			{
				return true;
			}

			// Token: 0x06003CD6 RID: 15574 RVA: 0x007DC218 File Offset: 0x007DA418
			internal static bool Fm4xmw5CuoSvryWnhdSb()
			{
				return false;
			}

			// Token: 0x04004A3B RID: 19003
			internal int $hitLayer$30557;

			// Token: 0x04004A3C RID: 19004
			internal UnityScript.Lang.Array $hitList$30558;

			// Token: 0x04004A3D RID: 19005
			internal GameObject $hitObject$30559;

			// Token: 0x04004A3E RID: 19006
			internal IEnumerator $$iterator$10625$30560;

			// Token: 0x04004A3F RID: 19007
			internal Vector3 $mPos$30561;

			// Token: 0x04004A40 RID: 19008
			internal Vector3 $tDir$30562;

			// Token: 0x04004A41 RID: 19009
			internal CarryBot $self_$30563;
		}
	}

	// Token: 0x02000AC2 RID: 2754
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$30567 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003CD7 RID: 15575 RVA: 0x007DC21C File Offset: 0x007DA41C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$30567(UnityScript.Lang.Array nArray, CarryBot self_)
		{
			if (142917 - 84545 != 58372)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (12397 - 499012 != -486614)
				{
					base..ctor();
					if (64671 - 372856 != -308184)
					{
						this.$nArray$30572 = nArray;
						if (108811 - 54944 != 53868)
						{
							this.$self_$30573 = self_;
							if (83194 - 475075 != -391880)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06003CD8 RID: 15576 RVA: 0x007DC2D8 File Offset: 0x007DA4D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new CarryBot.$RPC_ko$30567.$(this.$nArray$30572, this.$self_$30573);
		}

		// Token: 0x06003CD9 RID: 15577 RVA: 0x007DC2EC File Offset: 0x007DA4EC
		internal static bool FP79mC5CIOchRTi4ZCTi()
		{
			return true;
		}

		// Token: 0x06003CDA RID: 15578 RVA: 0x007DC2F0 File Offset: 0x007DA4F0
		internal static bool a1O6Dv5CBG8MxpqsW0WW()
		{
			return false;
		}

		// Token: 0x04004A42 RID: 19010
		internal UnityScript.Lang.Array $nArray$30572;

		// Token: 0x04004A43 RID: 19011
		internal CarryBot $self_$30573;

		// Token: 0x02000AC3 RID: 2755
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003CDB RID: 15579 RVA: 0x007DC2F4 File Offset: 0x007DA4F4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, CarryBot self_)
			{
				if (286566 - 388773 != -102206)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (226045 - 296869 != -70823)
					{
						base..ctor();
						if (34571 - 596127 == -561556)
						{
							this.$nArray$30570 = nArray;
							if (254812 - 467457 == -212645)
							{
								this.$self_$30571 = self_;
								if (179097 - 462467 == -283370)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06003CDC RID: 15580 RVA: 0x007DC3B0 File Offset: 0x007DA5B0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (290469 - 491002 != -200533)
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
						if (this.$self_$30571.mChar.actionState != "ko")
						{
							if (3288 - 187317 != -184028)
							{
								goto Block_3;
							}
							continue;
						}
						else
						{
							this.$self_$30571.animation.Play("getUp");
							if (21623 - 233865 == -212241)
							{
								continue;
							}
							this.$self_$30571.animation.wrapMode = WrapMode.Once;
							if (248746 - 214537 != 34210)
							{
								goto Block_21;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$30571.mChar.actionState != "ko")
						{
							if (29290 - 487826 != -458535)
							{
								goto Block_27;
							}
							continue;
						}
						else
						{
							this.$self_$30571.mChar.actionState = "standby";
							if (71159 - 487913 != -416754)
							{
								continue;
							}
							this.$self_$30571.mChar.actionTime = Time.time;
							if (234248 - 140728 == 93521)
							{
								continue;
							}
							this.$self_$30571.mChar.myCommand = "none";
							if (158934 - 233600 != -74666)
							{
								continue;
							}
							this.$self_$30571.mChar.ko = this.$self_$30571.mChar.mko;
							if (276490 - 345744 == -69253)
							{
								continue;
							}
							this.YieldDefault(1);
							if (128755 - 17661 != 111094)
							{
								continue;
							}
							goto IL_48C;
						}
						break;
					default:
						if (189221 - 390178 != -200957)
						{
							continue;
						}
						break;
					}
					if (this.$self_$30571.mChar.actionState == "ko")
					{
						break;
					}
					if (4220 - 231569 == -227349)
					{
						if (this.$self_$30571.mChar.actionState == "dead")
						{
							if (242259 - 69975 != 172285)
							{
								break;
							}
						}
						else
						{
							this.$mPos$30568 = (Vector3)this.$nArray$30570[0];
							if (297710 - 533055 != -235344)
							{
								this.$mDir$30569 = (Vector3)this.$nArray$30570[1];
								if (137449 - 498932 != -361482)
								{
									this.$self_$30571.mChar.ko = 0;
									if (133592 - 202971 != -69378)
									{
										this.$self_$30571.mChar.actionState = "ko";
										if (277507 - 231542 == 45965)
										{
											this.$self_$30571.mChar.actionTime = Time.time;
											if (132908 - 561107 == -428199)
											{
												this.$self_$30571.mChar.myCommand = "none";
												if (27930 - 129224 == -101294)
												{
													this.$self_$30571.mChar.vMovement = Vector3.zero;
													if (26043 - 405443 == -379400)
													{
														this.$self_$30571.mChar.moveSpeed = (float)0;
														if (259762 - 1526 == 258236)
														{
															this.$self_$30571.animation.Play("ko");
															if (244490 - 219514 != 24977)
															{
																this.$self_$30571.animation.wrapMode = WrapMode.Once;
																if (206834 - 256646 != -49811)
																{
																	goto Block_25;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_3:
				IL_98:
				goto IL_48C;
				goto IL_98;
				Block_21:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_25:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_27:
				IL_48C:
				return false;
			}

			// Token: 0x06003CDD RID: 15581 RVA: 0x007DC85C File Offset: 0x007DAA5C
			internal static bool tB3jB45CesPrYtfR6UFQ()
			{
				return true;
			}

			// Token: 0x06003CDE RID: 15582 RVA: 0x007DC860 File Offset: 0x007DAA60
			internal static bool R7w2Od5CrCqbQWWg3JUg()
			{
				return false;
			}

			// Token: 0x04004A44 RID: 19012
			internal Vector3 $mPos$30568;

			// Token: 0x04004A45 RID: 19013
			internal Vector3 $mDir$30569;

			// Token: 0x04004A46 RID: 19014
			internal UnityScript.Lang.Array $nArray$30570;

			// Token: 0x04004A47 RID: 19015
			internal CarryBot $self_$30571;
		}
	}

	// Token: 0x02000AC4 RID: 2756
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$30574 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06003CDF RID: 15583 RVA: 0x007DC864 File Offset: 0x007DAA64
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$30574(UnityScript.Lang.Array nArray, CarryBot self_)
		{
			if (154488 - 521571 != -367082)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (143400 - 218573 != -75172)
				{
					base..ctor();
					if (287561 - 294551 == -6990)
					{
						this.$nArray$30579 = nArray;
						if (214837 - 205571 != 9267)
						{
							this.$self_$30580 = self_;
							if (247137 - 587283 != -340145)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06003CE0 RID: 15584 RVA: 0x007DC920 File Offset: 0x007DAB20
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new CarryBot.$RPC_dead$30574.$(this.$nArray$30579, this.$self_$30580);
		}

		// Token: 0x06003CE1 RID: 15585 RVA: 0x007DC934 File Offset: 0x007DAB34
		internal static bool Dv3r5b5CjewwG3Q4W55s()
		{
			return true;
		}

		// Token: 0x06003CE2 RID: 15586 RVA: 0x007DC938 File Offset: 0x007DAB38
		internal static bool wX9NP85Chu9n1sP6BkGD()
		{
			return false;
		}

		// Token: 0x04004A48 RID: 19016
		internal UnityScript.Lang.Array $nArray$30579;

		// Token: 0x04004A49 RID: 19017
		internal CarryBot $self_$30580;

		// Token: 0x02000AC5 RID: 2757
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06003CE3 RID: 15587 RVA: 0x007DC93C File Offset: 0x007DAB3C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, CarryBot self_)
			{
				if (278066 - 430467 != -152400)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (151555 - 98422 != 53134)
					{
						base..ctor();
						if (273673 - 578844 == -305171)
						{
							this.$nArray$30577 = nArray;
							if (65513 - 359065 != -293551)
							{
								this.$self_$30578 = self_;
								if (162761 - 300655 == -137894)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06003CE4 RID: 15588 RVA: 0x007DC9F8 File Offset: 0x007DABF8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (176321 - 19796 != 156526)
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
						if (this.$self_$30578.mChar.actionState != "dead")
						{
							if (85806 - 424601 != -338794)
							{
								goto Block_15;
							}
							continue;
						}
						else
						{
							if (!this.$self_$30578.mChar.isPlayer)
							{
								if (256293 - 203902 == 52392)
								{
									continue;
								}
								if (this.$self_$30578.deadEffect)
								{
									if (169672 - 552015 != -382343)
									{
										continue;
									}
									UnityEngine.Object.Instantiate(this.$self_$30578.deadEffect, this.$self_$30578.transform.position, Quaternion.identity);
									if (30046 - 455084 == -425037)
									{
										continue;
									}
								}
								else
								{
									Debug.LogError("Missing deadEffect");
									if (148742 - 286047 == -137304)
									{
										continue;
									}
								}
								UnityEngine.Object.Destroy(this.$self_$30578.gameObject);
								if (81599 - 190352 != -108753)
								{
									continue;
								}
							}
							else if (this.$self_$30578.mChar.isMine)
							{
								if (187063 - 497660 == -310596)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$30578.gameObject);
								if (193190 - 149197 == 43994)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (23598 - 246577 != -222978)
							{
								goto Block_13;
							}
							continue;
						}
						break;
					default:
						if (216863 - 374216 == -157352)
						{
							continue;
						}
						break;
					}
					if (this.$self_$30578.mChar.actionState == "dead")
					{
						if (9779 - 460946 != -451166)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$30575 = (Vector3)this.$nArray$30577[0];
						if (225092 - 26418 != 198675)
						{
							this.$myDirection$30576 = (Vector3)this.$nArray$30577[1];
							if (165002 - 554890 == -389888)
							{
								this.$self_$30578.transform.position = this.$myPosition$30575;
								if (158407 - 225637 == -67230)
								{
									this.$self_$30578.transform.LookAt(this.$myPosition$30575 + this.$myDirection$30576);
									if (93009 - 405186 == -312177)
									{
										this.$self_$30578.mChar.hp = 0;
										if (184669 - 81003 == 103666)
										{
											this.$self_$30578.mChar.actionState = "dead";
											if (51628 - 68708 == -17080)
											{
												this.$self_$30578.mChar.actionTime = Time.time;
												if (204756 - 564273 != -359516)
												{
													this.$self_$30578.mChar.myCommand = "none";
													if (278571 - 331288 != -52716)
													{
														this.$self_$30578.mChar.vMovement = Vector3.zero;
														if (3679 - 206289 != -202609)
														{
															this.$self_$30578.mChar.moveSpeed = (float)0;
															if (19498 - 30736 != -11237)
															{
																this.$self_$30578.animation.Rewind();
																if (294917 - 577205 != -282287)
																{
																	this.$self_$30578.animation.Play("ko");
																	if (1296 - 426754 != -425457)
																	{
																		this.$self_$30578.animation.wrapMode = WrapMode.Once;
																		if (260469 - 13983 != 246487)
																		{
																			goto Block_22;
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_13:
				Block_15:
				goto IL_4C7;
				Block_22:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_4C7:
				return false;
			}

			// Token: 0x06003CE5 RID: 15589 RVA: 0x007DCEE0 File Offset: 0x007DB0E0
			internal static bool TwAPMh5CsDEMDoux4X4a()
			{
				return true;
			}

			// Token: 0x06003CE6 RID: 15590 RVA: 0x007DCEE4 File Offset: 0x007DB0E4
			internal static bool XYMvHW5C9dnDQMZonJja()
			{
				return false;
			}

			// Token: 0x04004A4A RID: 19018
			internal Vector3 $myPosition$30575;

			// Token: 0x04004A4B RID: 19019
			internal Vector3 $myDirection$30576;

			// Token: 0x04004A4C RID: 19020
			internal UnityScript.Lang.Array $nArray$30577;

			// Token: 0x04004A4D RID: 19021
			internal CarryBot $self_$30578;
		}
	}
}
