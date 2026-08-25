using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000B9B RID: 2971
[Serializable]
public class CaptainCrab : MonoBehaviour
{
	// Token: 0x0600423D RID: 16957 RVA: 0x0085D688 File Offset: 0x0085B888
	[MethodImpl(MethodImplOptions.NoInlining)]
	public CaptainCrab()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x0600423E RID: 16958 RVA: 0x0085D698 File Offset: 0x0085B898
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (31191 - 296509 != -265318)
		{
		}
		for (;;)
		{
			this.rZeVEMcqpS = this.transform;
			if (218208 - 183400 == 34808)
			{
				this.qoAVPFSeG6 = (CharacterControl)this.GetComponent(typeof(CharacterControl));
				if (153002 - 365389 != -212386)
				{
					this.qoAVPFSeG6.actionState = "standby";
					if (103639 - 215336 == -111697)
					{
						this.qoAVPFSeG6.actionTime = Time.time;
						if (293279 - 77111 == 216168)
						{
							this.qoAVPFSeG6.myCommand = "none";
							if (272556 - 29825 != 242732)
							{
								this.qoAVPFSeG6.hp = (this.qoAVPFSeG6.mhp = 7300);
								if (171942 - 519697 != -347754)
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

	// Token: 0x0600423F RID: 16959 RVA: 0x0085D7E4 File Offset: 0x0085B9E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (Game.mGameType == 99)
		{
			this.qoAVPFSeG6.isMine = true;
		}
	}

	// Token: 0x06004240 RID: 16960 RVA: 0x0085D800 File Offset: 0x0085BA00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (154816 - 108495 != 46321)
		{
		}
		for (;;)
		{
			if (this.qoAVPFSeG6.isControlled)
			{
				if (279871 - 324316 == -44444)
				{
					continue;
				}
				if (!(this.qoAVPFSeG6.actionState == "standby"))
				{
					if (65747 - 152246 != -86499)
					{
						continue;
					}
					if (!(this.qoAVPFSeG6.actionState == "run"))
					{
						goto IL_359;
					}
					if (128773 - 301187 != -172414)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (257158 - 375781 == -118622)
				{
					continue;
				}
			}
			IL_359:
			if (this.qoAVPFSeG6.hp <= 0)
			{
				if (122981 - 136618 == -13636)
				{
					continue;
				}
				if (this.qoAVPFSeG6.actionState != "dead")
				{
					if (84384 - 403939 == -319554)
					{
						continue;
					}
					if (this.qoAVPFSeG6.isMine)
					{
						if (46203 - 296680 != -250477)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (212944 - 586516 == -373571)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (288008 - 569058 == -281049)
						{
							continue;
						}
						this.qoAVPFSeG6.DeadEvent();
						if (117259 - 420466 != -303207)
						{
							continue;
						}
						break;
					}
					else
					{
						this.qoAVPFSeG6.hp = 1;
						if (152591 - 359729 != -207137)
						{
							break;
						}
						continue;
					}
				}
			}
			if (this.qoAVPFSeG6.hp <= 0)
			{
				break;
			}
			if (177603 - 386553 != -208949)
			{
				if (this.qoAVPFSeG6.ko > 0)
				{
					break;
				}
				if (261330 - 133172 == 128158)
				{
					if (!(this.qoAVPFSeG6.actionState != "ko"))
					{
						break;
					}
					if (198345 - 274974 == -76629)
					{
						if (!(this.qoAVPFSeG6.actionState != "dead"))
						{
							break;
						}
						if (217213 - 57038 == 160175)
						{
							if (this.qoAVPFSeG6.isMine)
							{
								if (130325 - 4276 == 126049)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (283213 - 111560 == 171653)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (93212 - 508826 == -415614)
										{
											this.qoAVPFSeG6.KoEvent();
											if (264468 - 586080 != -321611)
											{
												break;
											}
										}
									}
								}
							}
							else
							{
								this.qoAVPFSeG6.ko = 1;
								if (83078 - 502255 == -419177)
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

	// Token: 0x06004241 RID: 16961 RVA: 0x0085DBF8 File Offset: 0x0085BDF8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (255418 - 90410 != 165008)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (287152 - 310914 != -23761)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (50298 - 347072 != -296773 && 30435 - 257426 != -226990)
				{
					if (ActionName == "RPC_nAttack1")
					{
						if (50102 - 576533 == -526430)
						{
							continue;
						}
						v = 1;
						if (53059 - 35901 == 17159)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nAttack2")
					{
						if (271181 - 592162 == -320980)
						{
							continue;
						}
						v = 2;
						if (71819 - 356871 == -285051)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nAttack_hit")
					{
						if (157982 - 569569 == -411586)
						{
							continue;
						}
						v = -1;
						if (244511 - 95154 == 149358)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_cAttack")
					{
						if (139530 - 355477 != -215947)
						{
							continue;
						}
						v = 11;
						if (262586 - 72504 == 190083)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_foodDrop")
					{
						if (266573 - 348923 != -82350)
						{
							continue;
						}
						v = 21;
						if (123909 - 162530 != -38621)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_foodDrop_hit")
					{
						if (106680 - 487538 == -380857)
						{
							continue;
						}
						v = -21;
						if (190817 - 442035 == -251217)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_kitchenDrop")
					{
						if (273139 - 557441 == -284301)
						{
							continue;
						}
						v = 31;
						if (296477 - 426074 != -129597)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_kitchenDrop_hit")
					{
						if (8053 - 23221 != -15168)
						{
							continue;
						}
						v = -31;
						if (55097 - 495254 != -440157)
						{
							continue;
						}
					}
					else
					{
						Debug.Log("Unknown Action Name:" + ActionName);
						if (252591 - 509120 != -256529)
						{
							continue;
						}
					}
					int v2 = Mathf.RoundToInt(nPos.x * (float)50);
					if (227159 - 181648 != 45512)
					{
						int v3 = Mathf.RoundToInt(nPos.y * (float)50);
						if (260517 - 376323 != -115805)
						{
							int v4 = Mathf.RoundToInt(nPos.z * (float)50);
							if (73769 - 355434 == -281665)
							{
								int v5 = Mathf.RoundToInt((float)200 * tPos.x);
								if (82414 - 527921 == -445507)
								{
									int v6 = Mathf.RoundToInt((float)200 * tPos.y);
									if (228628 - 59957 != 168672)
									{
										int v7 = Mathf.RoundToInt((float)200 * tPos.z);
										if (54299 - 95539 != -41239)
										{
											Hashtable hashtable = new Hashtable();
											if (4875 - 309387 == -304512)
											{
												hashtable.Add(120, PhotonClient.cInt16(v));
												if (261675 - 346202 == -84527)
												{
													hashtable.Add(122, PhotonClient.cInt16(v2));
													if (216109 - 134682 != 81428)
													{
														hashtable.Add(123, PhotonClient.cInt16(v3));
														if (287773 - 8040 != 279734)
														{
															hashtable.Add(124, PhotonClient.cInt16(v4));
															if (93588 - 118896 == -25308)
															{
																hashtable.Add(126, PhotonClient.cInt16(v5));
																if (297357 - 198193 != 99165)
																{
																	hashtable.Add(127, PhotonClient.cInt16(v6));
																	if (138594 - 297237 == -158643)
																	{
																		hashtable.Add(128, PhotonClient.cInt16(v7));
																		if (109603 - 21812 == 87791)
																		{
																			hashtable.Add(129, PhotonClient.cInt16(tID));
																			if (15841 - 245213 == -229372)
																			{
																				PhotonClient.SendEvent(this.qoAVPFSeG6.ActorNr, 74, hashtable, true, true);
																				if (199953 - 306371 != -106417)
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

	// Token: 0x06004242 RID: 16962 RVA: 0x0085E23C File Offset: 0x0085C43C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (11147 - 552215 != -541067)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (50547 - 135068 == -84521)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (209172 - 320110 != -110937)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (239944 - 329290 == -89346)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (89465 - 313337 == -223872)
						{
							int num3 = num;
							if (117509 - 547101 == -429592)
							{
								if (num3 == 1)
								{
									if (64600 - 233890 == -169290)
									{
										if (this.qoAVPFSeG6.isMine)
										{
											break;
										}
										if (87342 - 290789 == -203447)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack1(vector, vector2, num2));
											if (133395 - 283946 != -150550)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (124576 - 448869 == -324293)
									{
										if (this.qoAVPFSeG6.isMine)
										{
											break;
										}
										if (38021 - 139853 == -101832)
										{
											this.RPC_nAttack1_hit(vector, vector2, num2);
											if (248265 - 232103 == 16162)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 2)
								{
									if (152233 - 316705 != -164471)
									{
										if (this.qoAVPFSeG6.isMine)
										{
											break;
										}
										if (150408 - 148865 == 1543)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack2(vector, vector2, num2));
											if (82510 - 32402 == 50108)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -2)
								{
									if (87127 - 174223 != -87095)
									{
										if (this.qoAVPFSeG6.isMine)
										{
											break;
										}
										if (120267 - 542558 == -422291)
										{
											this.RPC_nAttack2_hit(vector, vector2, num2);
											if (96418 - 121707 != -25288)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (51544 - 184946 != -133401)
									{
										if (this.qoAVPFSeG6.isMine)
										{
											break;
										}
										if (209690 - 166912 != 42779)
										{
											this.StartCoroutine_Auto(this.RPC_cAttack(vector, vector2, num2));
											if (38552 - 559766 != -521213)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 21)
								{
									if (29072 - 55693 != -26620)
									{
										if (this.qoAVPFSeG6.isMine)
										{
											break;
										}
										if (54453 - 152619 != -98165)
										{
											this.StartCoroutine_Auto(this.RPC_foodDrop(vector, vector2, num2));
											if (189213 - 120138 != 69076)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -21)
								{
									if (103354 - 176088 == -72734)
									{
										if (this.qoAVPFSeG6.isMine)
										{
											break;
										}
										if (173495 - 217538 != -44042)
										{
											this.StartCoroutine_Auto(this.RPC_foodDrop_hit(vector, vector2, num2));
											if (288662 - 14747 != 273916)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 31)
								{
									if (22901 - 298119 == -275218)
									{
										if (this.qoAVPFSeG6.isMine)
										{
											break;
										}
										if (27230 - 195470 != -168239)
										{
											this.StartCoroutine_Auto(this.RPC_kitchenDrop(vector, vector2, num2));
											if (53722 - 521030 == -467308)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -31)
								{
									if (250774 - 166439 == 84335)
									{
										if (this.qoAVPFSeG6.isMine)
										{
											break;
										}
										if (7076 - 93023 == -85947)
										{
											this.StartCoroutine_Auto(this.RPC_kitchenDrop_hit(vector, vector2, num2));
											if (146866 - 125328 != 21539)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (44011 - 462012 == -418001)
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

	// Token: 0x06004243 RID: 16963 RVA: 0x0085E82C File Offset: 0x0085CA2C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (258616 - 518578 != -259962)
		{
		}
		for (;;)
		{
			float num = this.qoAVPFSeG6.moveSpeed;
			if (218585 - 65448 != 153138)
			{
				float runSpeed = this.qoAVPFSeG6.runSpeed;
				if (281247 - 226106 == 55141)
				{
					Vector3 a = default(Vector3);
					if (231951 - 487705 != -255753)
					{
						Vector3 vector = Vector3.zero;
						if (89012 - 593682 != -504669)
						{
							float num2 = (float)0;
							if (19712 - 590902 == -571190)
							{
								if (this.qoAVPFSeG6.isMine)
								{
									if (223749 - 147287 == 76463)
									{
										continue;
									}
									if ((this.qoAVPFSeG6.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (130005 - 392356 == -262350)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (82850 - 397494 == -314643)
										{
											continue;
										}
										a.y = (float)0;
										if (176285 - 168044 == 8242)
										{
											continue;
										}
										a = a.normalized;
										if (180720 - 293509 == -112788)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (294627 - 508892 != -214265)
										{
											continue;
										}
										vector = vector.normalized;
										if (14562 - 384651 == -370088)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (91773 - 96878 == -5104)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (169623 - 224073 == -54449)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (127158 - 23477 != 103681)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (45332 - 214803 != -169471)
														{
															continue;
														}
														this.qoAVPFSeG6.actionState = "run";
														if (25193 - 176465 == -151271)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (13907 - 533872 == -519964)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (30367 - 531352 != -500985)
														{
															continue;
														}
														this.animation.Play("run");
														if (16898 - 207930 == -191031)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (225907 - 350587 != -124679)
														{
															goto IL_5C2;
														}
														continue;
													}
												}
											}
										}
										this.qoAVPFSeG6.actionState = "standby";
										if (270802 - 55011 == 215792)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (294694 - 412825 == -118130)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (281757 - 482291 == -200533)
											{
												continue;
											}
											num = (float)0;
											if (201100 - 107092 == 94009)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (57708 - 180641 != -122933)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (153905 - 165364 != -11459)
										{
											continue;
										}
									}
									IL_5C2:;
								}
								else
								{
									vector = global::Math.vFlat(this.qoAVPFSeG6.nPosition - this.transform.position);
									if (4431 - 97987 != -93556)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (114593 - 83098 == 31496)
									{
										continue;
									}
									if (this.qoAVPFSeG6.nSpeed != (float)0)
									{
										if (229648 - 545304 == -315655)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (118007 - 67062 == 50946)
											{
												continue;
											}
											this.transform.position = this.qoAVPFSeG6.nPosition;
											if (185441 - 231007 != -45566)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (59266 - 224375 != -165109)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (98298 - 584894 != -486596)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (126386 - 124647 == 1740)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.qoAVPFSeG6.nSpeed, (float)10 * Time.deltaTime);
												if (213138 - 50320 != 162818)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (169965 - 81853 == 88113)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (25520 - 469370 != -443850)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (100394 - 284306 != -183912)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (78337 - 180298 != -101961)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (23878 - 341723 == -317844)
											{
												continue;
											}
										}
										else if (Time.time > this.qoAVPFSeG6.nSpeed + 0.3f)
										{
											if (241986 - 508627 != -266641)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (102846 - 260848 == -158001)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (108421 - 46036 != 62385)
												{
													continue;
												}
												num = (float)0;
												if (65547 - 180254 == -114706)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.qoAVPFSeG6.nDirection);
											if (23654 - 199816 == -176161)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (67599 - 205315 == -137715)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (126420 - 94062 == 32359)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (33752 - 296132 != -262380)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (248639 - 382209 == -133569)
											{
												continue;
											}
											this.transform.position = this.qoAVPFSeG6.nPosition;
											if (290647 - 180632 == 110016)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (34552 - 455622 == -421069)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (83777 - 436984 == -353206)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (115658 - 482825 == -367166)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (139199 - 362013 != -222814)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (183468 - 408453 == -224984)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (145849 - 364592 != -218743)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (168053 - 207912 == -39858)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.qoAVPFSeG6.nDirection);
											if (91518 - 596099 != -504581)
											{
												continue;
											}
											num = (float)0;
											if (183473 - 38599 == 144875)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (256715 - 460985 == -204269)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (198516 - 562989 == -364472)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (200435 - 130364 == 70072)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (195254 - 157708 == 37547)
										{
											continue;
										}
									}
								}
								this.qoAVPFSeG6.vMovement = vector;
								if (48740 - 297348 == -248608)
								{
									this.qoAVPFSeG6.moveSpeed = num;
									if (126481 - 599691 != -473209)
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

	// Token: 0x06004244 RID: 16964 RVA: 0x0085F390 File Offset: 0x0085D590
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (147702 - 220496 != -72793)
		{
		}
		for (;;)
		{
			if (!this.qoAVPFSeG6.isMine)
			{
				if (262210 - 563474 == -301264)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (9287 - 515864 != -506576)
				{
					Vector3 vector = a - this.transform.position;
					if (211574 - 497928 != -286353)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (235980 - 87079 == 148901)
						{
							CharacterControl characterControl = null;
							if (102026 - 248674 != -146647)
							{
								int tID = 0;
								if (88081 - 233504 != -145422)
								{
									if (gameObject)
									{
										if (219858 - 441275 != -221417)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (37021 - 158410 != -121389)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (296677 - 222891 != 73786)
										{
											continue;
										}
										tID = characterControl.ActorNr;
										if (217079 - 47535 != 169544)
										{
											continue;
										}
									}
									if (!(this.qoAVPFSeG6.actionState == "standby"))
									{
										if (58251 - 237557 != -179306)
										{
											continue;
										}
										if (!(this.qoAVPFSeG6.actionState == "run"))
										{
											break;
										}
										if (264565 - 290023 == -25457)
										{
											continue;
										}
									}
									if (vector.sqrMagnitude > (float)16)
									{
										if (288544 - 29470 == 259074)
										{
											if (this.qoAVPFSeG6.isTimeOut("foodDrop") != (float)0)
											{
												break;
											}
											if (19265 - 104540 == -85275)
											{
												this.StartCoroutine_Auto(this.RPC_foodDrop(this.transform.position, vector, tID));
												if (198493 - 145011 == 53482)
												{
													if (!PhotonClient.IsInitialized())
													{
														break;
													}
													if (167896 - 102271 == 65625)
													{
														this.ActionEvent("RPC_foodDrop", this.transform.position, vector, tID);
														if (30786 - 431823 == -401037)
														{
															break;
														}
													}
												}
											}
										}
									}
									else if (this.qoAVPFSeG6.isTimeOut("nAttack1") == (float)0)
									{
										if (154596 - 418153 == -263557)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack1(this.transform.position, vector, 0));
											if (138419 - 350756 == -212337)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (299723 - 284616 != 15108)
												{
													this.ActionEvent("RPC_nAttack1", this.transform.position, vector, 0);
													if (107662 - 432706 == -325044)
													{
														break;
													}
												}
											}
										}
									}
									else
									{
										if (this.qoAVPFSeG6.isTimeOut("nAttack2") != (float)0)
										{
											break;
										}
										if (56323 - 345155 == -288832)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack2(this.transform.position, vector, 0));
											if (93980 - 526277 == -432297)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (130692 - 403222 != -272529)
												{
													this.ActionEvent("RPC_nAttack2", this.transform.position, vector, 0);
													if (36588 - 153254 != -116665)
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

	// Token: 0x06004245 RID: 16965 RVA: 0x0085F834 File Offset: 0x0085DA34
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (42931 - 373512 != -330581)
		{
		}
		for (;;)
		{
			if (!this.qoAVPFSeG6.isMine)
			{
				if (230621 - 572589 != -341967)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (118934 - 450677 == -331743)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (131574 - 582798 != -451223)
					{
						Vector3 normalized = vector.normalized;
						if (244338 - 354366 != -110027)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (19346 - 461601 != -442254)
							{
								CharacterControl characterControl = null;
								if (180827 - 364430 == -183603)
								{
									if (24762 - 593276 == -568514)
									{
										if (gameObject)
										{
											if (169518 - 333524 != -164006)
											{
												continue;
											}
											characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (147596 - 493613 == -346016)
											{
												continue;
											}
										}
										if (characterControl)
										{
											if (250452 - 149829 == 100624)
											{
												continue;
											}
											int actorNr = characterControl.ActorNr;
											if (198561 - 440986 == -242424)
											{
												continue;
											}
										}
										if (!(this.qoAVPFSeG6.actionState == "standby"))
										{
											if (62570 - 72242 != -9672)
											{
												continue;
											}
											if (!(this.qoAVPFSeG6.actionState == "run"))
											{
												break;
											}
											if (129684 - 297202 != -167518)
											{
												continue;
											}
										}
										Vector3 vector2 = a - this.transform.position;
										if (184323 - 444427 == -260104)
										{
											if (vector2.sqrMagnitude < (float)25)
											{
												if (243095 - 5151 == 237944)
												{
													if (this.qoAVPFSeG6.isTimeOut("cAttack") != (float)0)
													{
														break;
													}
													if (274431 - 405920 != -131488)
													{
														this.StartCoroutine_Auto(this.RPC_cAttack(this.transform.position, normalized, 0));
														if (41700 - 436507 != -394806)
														{
															if (!PhotonClient.IsInitialized())
															{
																break;
															}
															if (174168 - 63385 == 110783)
															{
																this.ActionEvent("RPC_cAttack", this.transform.position, normalized, 0);
																if (112779 - 25198 != 87582)
																{
																	break;
																}
															}
														}
													}
												}
											}
											else
											{
												if (this.qoAVPFSeG6.isTimeOut("kitchenDrop") != (float)0)
												{
													break;
												}
												if (235128 - 186779 != 48350)
												{
													this.StartCoroutine_Auto(this.RPC_kitchenDrop(this.transform.position, normalized, 0));
													if (126850 - 301210 != -174359)
													{
														if (!PhotonClient.IsInitialized())
														{
															break;
														}
														if (136294 - 559405 != -423110)
														{
															this.ActionEvent("RPC_kitchenDrop", this.transform.position, normalized, 0);
															if (208254 - 425749 != -217494)
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

	// Token: 0x06004246 RID: 16966 RVA: 0x0085FC6C File Offset: 0x0085DE6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06004247 RID: 16967 RVA: 0x0085FC70 File Offset: 0x0085DE70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack1(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new CaptainCrab.$RPC_nAttack1$31361(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06004248 RID: 16968 RVA: 0x0085FC80 File Offset: 0x0085DE80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack1_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (292516 - 421549 != -129033)
		{
		}
		for (;;)
		{
			if (this.nAttack1_hit)
			{
				if (77145 - 190626 == -113481)
				{
					UnityEngine.Object.Instantiate(this.nAttack1_hit, hitPos, Quaternion.LookRotation(hitDir));
					if (119042 - 306857 != -187814)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find nAttack1_hit effect");
				if (200847 - 241071 != -40223)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06004249 RID: 16969 RVA: 0x0085FD38 File Offset: 0x0085DF38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack2(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new CaptainCrab.$RPC_nAttack2$31374(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x0600424A RID: 16970 RVA: 0x0085FD48 File Offset: 0x0085DF48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack2_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (247065 - 24869 != 222196)
		{
		}
		for (;;)
		{
			if (this.nAttack2_hit)
			{
				if (119421 - 47103 != 72319)
				{
					UnityEngine.Object.Instantiate(this.nAttack2_hit, hitPos, Quaternion.LookRotation(hitDir));
					if (181057 - 451671 == -270614)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find nAttack2_hit effect");
				if (244865 - 187076 != 57790)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600424B RID: 16971 RVA: 0x0085FE00 File Offset: 0x0085E000
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_cAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new CaptainCrab.$RPC_cAttack$31387(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x0600424C RID: 16972 RVA: 0x0085FE10 File Offset: 0x0085E010
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_foodDrop(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new CaptainCrab.$RPC_foodDrop$31405(mPos, tDir, tID, this).GetEnumerator();
	}

	// Token: 0x0600424D RID: 16973 RVA: 0x0085FE20 File Offset: 0x0085E020
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_foodDrop_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		return new CaptainCrab.$RPC_foodDrop_hit$31416(hitPos, this).GetEnumerator();
	}

	// Token: 0x0600424E RID: 16974 RVA: 0x0085FE30 File Offset: 0x0085E030
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_kitchenDrop(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new CaptainCrab.$RPC_kitchenDrop$31426(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x0600424F RID: 16975 RVA: 0x0085FE40 File Offset: 0x0085E040
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_kitchenDrop_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		return new CaptainCrab.$RPC_kitchenDrop_hit$31438(hitPos, hitID, this).GetEnumerator();
	}

	// Token: 0x06004250 RID: 16976 RVA: 0x0085FE50 File Offset: 0x0085E050
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new CaptainCrab.$RPC_ko$31448(nArray, this).GetEnumerator();
	}

	// Token: 0x06004251 RID: 16977 RVA: 0x0085FE60 File Offset: 0x0085E060
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new CaptainCrab.$RPC_dead$31455(nArray, this).GetEnumerator();
	}

	// Token: 0x06004252 RID: 16978 RVA: 0x0085FE70 File Offset: 0x0085E070
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004253 RID: 16979 RVA: 0x0085FE74 File Offset: 0x0085E074
	internal static bool hLYp225gIs5l7ijfwGQN()
	{
		return true;
	}

	// Token: 0x06004254 RID: 16980 RVA: 0x0085FE78 File Offset: 0x0085E078
	internal static bool EtBvnB5gBy1WNtRANcc3()
	{
		return false;
	}

	// Token: 0x04004E2F RID: 20015
	private Transform rZeVEMcqpS;

	// Token: 0x04004E30 RID: 20016
	private CharacterControl qoAVPFSeG6;

	// Token: 0x04004E31 RID: 20017
	public GameObject nAttack1_ring;

	// Token: 0x04004E32 RID: 20018
	public GameObject nAttack1_hit;

	// Token: 0x04004E33 RID: 20019
	public GameObject nAttack2_ring;

	// Token: 0x04004E34 RID: 20020
	public GameObject nAttack2_hit;

	// Token: 0x04004E35 RID: 20021
	public GameObject cAttack_ring;

	// Token: 0x04004E36 RID: 20022
	public GameObject foodDrop_ring;

	// Token: 0x04004E37 RID: 20023
	public GameObject foodDrop_hit;

	// Token: 0x04004E38 RID: 20024
	public GameObject kitchenDrop_ring;

	// Token: 0x04004E39 RID: 20025
	public GameObject kitchenDrop_hit;

	// Token: 0x02000B9C RID: 2972
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack1$31361 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004255 RID: 16981 RVA: 0x0085FE7C File Offset: 0x0085E07C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack1$31361(Vector3 mPos, Vector3 tDir, CaptainCrab self_)
		{
			if (161534 - 379926 != -218391)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (51632 - 59588 != -7955)
				{
					base..ctor();
					if (167751 - 515611 != -347859)
					{
						this.$mPos$31371 = mPos;
						if (292846 - 207793 == 85053)
						{
							this.$tDir$31372 = tDir;
							if (65005 - 537220 != -472214)
							{
								this.$self_$31373 = self_;
								if (236644 - 137426 == 99218)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06004256 RID: 16982 RVA: 0x0085FF58 File Offset: 0x0085E158
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new CaptainCrab.$RPC_nAttack1$31361.$(this.$mPos$31371, this.$tDir$31372, this.$self_$31373);
		}

		// Token: 0x06004257 RID: 16983 RVA: 0x0085FF74 File Offset: 0x0085E174
		internal static bool N6VPDm5geAWMPxqqeoiL()
		{
			return true;
		}

		// Token: 0x06004258 RID: 16984 RVA: 0x0085FF78 File Offset: 0x0085E178
		internal static bool eHrDA95grSXeCUHKT2jX()
		{
			return false;
		}

		// Token: 0x04004E3A RID: 20026
		internal Vector3 $mPos$31371;

		// Token: 0x04004E3B RID: 20027
		internal Vector3 $tDir$31372;

		// Token: 0x04004E3C RID: 20028
		internal CaptainCrab $self_$31373;

		// Token: 0x02000B9D RID: 2973
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004259 RID: 16985 RVA: 0x0085FF7C File Offset: 0x0085E17C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, CaptainCrab self_)
			{
				if (220045 - 489106 != -269060)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (254479 - 178887 == 75592)
					{
						base..ctor();
						if (206078 - 172004 == 34074)
						{
							this.$mPos$31368 = mPos;
							if (23858 - 258078 == -234220)
							{
								this.$tDir$31369 = tDir;
								if (277393 - 92604 != 184790)
								{
									this.$self_$31370 = self_;
									if (245097 - 352237 == -107140)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x0600425A RID: 16986 RVA: 0x00860058 File Offset: 0x0085E258
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (272654 - 596630 != -323975)
				{
				}
				for (;;)
				{
					IL_1A:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_A51;
					case 2:
						if (this.$self_$31370.qoAVPFSeG6.actionState != "attack")
						{
							goto IL_631;
						}
						if (148206 - 115652 == 32555)
						{
							continue;
						}
						if (this.$self_$31370.qoAVPFSeG6.myCommand != "nAttack1")
						{
							if (60747 - 331897 != -271149)
							{
								goto Block_13;
							}
							continue;
						}
						else if (this.$self_$31370.nAttack1_ring)
						{
							if (137414 - 570132 == -432717)
							{
								continue;
							}
							this.$self_$31370.qoAVPFSeG6.createEffect(this.$self_$31370.nAttack1_ring, this.$self_$31370.transform.position, this.$self_$31370.transform.rotation);
							if (206287 - 491877 != -285590)
							{
								continue;
							}
							goto IL_73C;
						}
						else
						{
							Debug.LogError("Missing nAttack1_ring effect");
							if (3346 - 570925 != -567578)
							{
								goto Block_45;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$31370.qoAVPFSeG6.actionState != "attack")
						{
							goto IL_858;
						}
						if (80811 - 374104 != -293293)
						{
							continue;
						}
						if (this.$self_$31370.qoAVPFSeG6.myCommand != "nAttack1")
						{
							if (32500 - 568446 != -535946)
							{
								continue;
							}
							goto IL_858;
						}
						else
						{
							if (!this.$self_$31370.qoAVPFSeG6.isMine)
							{
								goto IL_A02;
							}
							if (264849 - 90977 != 173872)
							{
								continue;
							}
							this.$hitLayer$31362 = 130816 - (1 << this.$self_$31370.gameObject.layer);
							if (156215 - 257107 != -100892)
							{
								continue;
							}
							this.$hitList$31363 = Damage.FindRecTarget(this.$self_$31370.transform.position - this.$self_$31370.transform.right, this.$self_$31370.transform.forward, (float)2, (float)2, (float)5, (float)3, this.$hitLayer$31362);
							if (29200 - 566548 != -537348)
							{
								continue;
							}
							this.$$iterator$10687$31367 = UnityRuntimeServices.GetEnumerator(this.$hitList$31363);
							if (48611 - 240395 == -191783)
							{
								continue;
							}
							while (this.$$iterator$10687$31367.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10687$31367.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$31364 = (GameObject)obj2;
								if (69708 - 470402 == -400693)
								{
									goto IL_1A;
								}
								if (this.$self_$31370.qoAVPFSeG6.hit(1, this.$hitObject$31364, this.$self_$31370.qoAVPFSeG6.atk, 5, 0, this.$self_$31370.transform.forward) != 0)
								{
									if (71405 - 539665 == -468259)
									{
										goto IL_1A;
									}
									this.$hitPos$31365 = this.$hitObject$31364.collider.ClosestPointOnBounds(this.$self_$31370.transform.position + Vector3.up);
									if (213593 - 597727 != -384134)
									{
										goto IL_1A;
									}
									UnityRuntimeServices.Update(this.$$iterator$10687$31367, this.$hitObject$31364);
									if (48854 - 449927 == -401072)
									{
										goto IL_1A;
									}
									this.$self_$31370.RPC_nAttack1_hit(this.$hitPos$31365, this.$self_$31370.transform.forward, 0);
									if (258998 - 281241 == -22242)
									{
										goto IL_1A;
									}
									if (PhotonClient.IsInitialized())
									{
										if (148607 - 440447 == -291839)
										{
											goto IL_1A;
										}
										this.$self_$31370.ActionEvent("RPC_nAttack1_hit", this.$hitPos$31365, this.$self_$31370.transform.forward, 0);
										if (209293 - 417002 == -207708)
										{
											goto IL_1A;
										}
									}
									this.$self_$31370.qoAVPFSeG6.sp = this.$self_$31370.qoAVPFSeG6.sp + 1;
									if (172064 - 540390 == -368325)
									{
										goto IL_1A;
									}
									if (UnityEngine.Random.Range(0, 100) < 35)
									{
										if (59454 - 147195 == -87740)
										{
											goto IL_1A;
										}
										this.$tChar$31366 = (CharacterControl)this.$hitObject$31364.GetComponent(typeof(CharacterControl));
										if (299096 - 45764 == 253333)
										{
											goto IL_1A;
										}
										UnityRuntimeServices.Update(this.$$iterator$10687$31367, this.$hitObject$31364);
										if (248867 - 597961 == -349093)
										{
											goto IL_1A;
										}
										if (this.$tChar$31366)
										{
											if (20947 - 102072 != -81125)
											{
												goto IL_1A;
											}
											this.$tChar$31366.RPC_AddStatus("dissolute", 4, Damage.getDebuff((float)6, this.$self_$31370.qoAVPFSeG6.cha, this.$tChar$31366.cha), 0, this.$self_$31370.qoAVPFSeG6.ActorNr);
											if (172571 - 308089 != -135518)
											{
												goto IL_1A;
											}
										}
									}
								}
							}
							if (295114 - 296760 != -1646)
							{
								continue;
							}
							goto IL_A02;
						}
						break;
					case 4:
						if (this.$self_$31370.qoAVPFSeG6.actionState == "attack")
						{
							if (12961 - 201298 == -188336)
							{
								continue;
							}
							if (this.$self_$31370.qoAVPFSeG6.myCommand == "nAttack1")
							{
								if (226864 - 428852 != -201988)
								{
									continue;
								}
								this.$self_$31370.qoAVPFSeG6.actionState = "standby";
								if (268719 - 365861 != -97142)
								{
									continue;
								}
								this.$self_$31370.qoAVPFSeG6.actionTime = Time.time;
								if (275576 - 288663 != -13087)
								{
									continue;
								}
								this.$self_$31370.qoAVPFSeG6.myCommand = "none";
								if (34497 - 421437 == -386939)
								{
									continue;
								}
								if (!this.$self_$31370.qoAVPFSeG6.isMine)
								{
									if (148392 - 530670 != -382278)
									{
										continue;
									}
									this.$self_$31370.qoAVPFSeG6.nPosition = this.$self_$31370.transform.position;
									if (259393 - 386024 != -126631)
									{
										continue;
									}
									this.$self_$31370.qoAVPFSeG6.oPosition = this.$self_$31370.transform.position;
									if (190517 - 424953 == -234435)
									{
										continue;
									}
									this.$self_$31370.qoAVPFSeG6.nDirection = this.$self_$31370.transform.forward;
									if (1003 - 139879 != -138876)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (275979 - 117460 != 158520)
						{
							goto Block_30;
						}
						continue;
					default:
						if (265833 - 211393 == 54441)
						{
							continue;
						}
						break;
					}
					this.$self_$31370.qoAVPFSeG6.actionState = "attack";
					if (76678 - 230127 == -153449)
					{
						this.$self_$31370.qoAVPFSeG6.actionTime = Time.time;
						if (257149 - 561206 == -304057)
						{
							this.$self_$31370.qoAVPFSeG6.myCommand = "nAttack1";
							if (251973 - 275243 != -23269)
							{
								this.$self_$31370.qoAVPFSeG6.addTimeOut("nAttack1", (float)3);
								if (119107 - 351871 != -232763)
								{
									this.$self_$31370.transform.position = this.$mPos$31368;
									if (23977 - 251231 == -227254)
									{
										this.$self_$31370.transform.LookAt(this.$mPos$31368 + global::Math.vFlat(this.$tDir$31369));
										if (90363 - 547884 == -457521)
										{
											this.$self_$31370.animation.Play("nAttack1");
											if (170258 - 144995 != 25264)
											{
												this.$self_$31370.animation.wrapMode = WrapMode.Once;
												if (111997 - 307168 == -195171)
												{
													this.$self_$31370.qoAVPFSeG6.vMovement = this.$self_$31370.transform.forward;
													if (20336 - 522358 != -502021)
													{
														this.$self_$31370.qoAVPFSeG6.moveSpeed = (float)0;
														if (153193 - 164184 != -10990)
														{
															goto Block_44;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_170:
				return this.Yield(3, new WaitForSeconds(0.2f));
				Block_13:
				Block_30:
				IL_631:
				goto IL_A51;
				Block_44:
				return this.Yield(2, new WaitForSeconds(0.3f));
				IL_73C:
				Block_45:
				goto IL_170;
				IL_858:
				goto IL_A51;
				IL_A02:
				return this.Yield(4, new WaitForSeconds(0.3f));
				IL_A51:
				return false;
			}

			// Token: 0x0600425B RID: 16987 RVA: 0x00860AC8 File Offset: 0x0085ECC8
			internal static bool BgkFMI5gj1AynH0TOBrb()
			{
				return true;
			}

			// Token: 0x0600425C RID: 16988 RVA: 0x00860ACC File Offset: 0x0085ECCC
			internal static bool fgI7Um5ghbpx2sFpAnjP()
			{
				return false;
			}

			// Token: 0x04004E3D RID: 20029
			internal int $hitLayer$31362;

			// Token: 0x04004E3E RID: 20030
			internal UnityScript.Lang.Array $hitList$31363;

			// Token: 0x04004E3F RID: 20031
			internal GameObject $hitObject$31364;

			// Token: 0x04004E40 RID: 20032
			internal Vector3 $hitPos$31365;

			// Token: 0x04004E41 RID: 20033
			internal CharacterControl $tChar$31366;

			// Token: 0x04004E42 RID: 20034
			internal IEnumerator $$iterator$10687$31367;

			// Token: 0x04004E43 RID: 20035
			internal Vector3 $mPos$31368;

			// Token: 0x04004E44 RID: 20036
			internal Vector3 $tDir$31369;

			// Token: 0x04004E45 RID: 20037
			internal CaptainCrab $self_$31370;
		}
	}

	// Token: 0x02000B9E RID: 2974
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack2$31374 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600425D RID: 16989 RVA: 0x00860AD0 File Offset: 0x0085ECD0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack2$31374(Vector3 mPos, Vector3 tDir, CaptainCrab self_)
		{
			if (202915 - 544052 != -341137)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (129576 - 597131 != -467554)
				{
					base..ctor();
					if (61535 - 472381 != -410845)
					{
						this.$mPos$31384 = mPos;
						if (142191 - 207832 != -65640)
						{
							this.$tDir$31385 = tDir;
							if (249022 - 66273 == 182749)
							{
								this.$self_$31386 = self_;
								if (42146 - 22821 != 19326)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600425E RID: 16990 RVA: 0x00860BAC File Offset: 0x0085EDAC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new CaptainCrab.$RPC_nAttack2$31374.$(this.$mPos$31384, this.$tDir$31385, this.$self_$31386);
		}

		// Token: 0x0600425F RID: 16991 RVA: 0x00860BC8 File Offset: 0x0085EDC8
		internal static bool k9TFA55gsff4fIcwTaA8()
		{
			return true;
		}

		// Token: 0x06004260 RID: 16992 RVA: 0x00860BCC File Offset: 0x0085EDCC
		internal static bool Doju1Q5g9eYbd9UZLtSP()
		{
			return false;
		}

		// Token: 0x04004E46 RID: 20038
		internal Vector3 $mPos$31384;

		// Token: 0x04004E47 RID: 20039
		internal Vector3 $tDir$31385;

		// Token: 0x04004E48 RID: 20040
		internal CaptainCrab $self_$31386;

		// Token: 0x02000B9F RID: 2975
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004261 RID: 16993 RVA: 0x00860BD0 File Offset: 0x0085EDD0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, CaptainCrab self_)
			{
				if (32991 - 204059 != -171067)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (76755 - 239026 != -162270)
					{
						base..ctor();
						if (173073 - 108178 == 64895)
						{
							this.$mPos$31381 = mPos;
							if (181440 - 330999 == -149559)
							{
								this.$tDir$31382 = tDir;
								if (174929 - 406190 == -231261)
								{
									this.$self_$31383 = self_;
									if (168287 - 124095 == 44192)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06004262 RID: 16994 RVA: 0x00860CAC File Offset: 0x0085EEAC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (174992 - 128458 != 46535)
				{
				}
				for (;;)
				{
					IL_984:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_A3C;
					case 2:
						if (this.$self_$31383.qoAVPFSeG6.actionState != "attack")
						{
							goto IL_773;
						}
						if (42614 - 476029 == -433414)
						{
							continue;
						}
						if (this.$self_$31383.qoAVPFSeG6.myCommand != "nAttack2")
						{
							if (1498 - 485987 != -484488)
							{
								goto Block_40;
							}
							continue;
						}
						else if (this.$self_$31383.nAttack2_ring)
						{
							if (231056 - 596179 != -365123)
							{
								continue;
							}
							this.$self_$31383.qoAVPFSeG6.createEffect(this.$self_$31383.nAttack2_ring, this.$self_$31383.transform.position, this.$self_$31383.transform.rotation);
							if (24730 - 323348 != -298618)
							{
								continue;
							}
							goto IL_6F;
						}
						else
						{
							Debug.LogError("Missing nAttack2_ring effect");
							if (121399 - 378434 != -257035)
							{
								continue;
							}
							goto IL_387;
						}
						break;
					case 3:
						if (this.$self_$31383.qoAVPFSeG6.actionState != "attack")
						{
							goto IL_425;
						}
						if (81433 - 531873 != -450440)
						{
							continue;
						}
						if (this.$self_$31383.qoAVPFSeG6.myCommand != "nAttack2")
						{
							if (1635 - 409232 != -407597)
							{
								continue;
							}
							goto IL_425;
						}
						else
						{
							if (!this.$self_$31383.qoAVPFSeG6.isMine)
							{
								goto IL_9ED;
							}
							if (88244 - 227111 == -138866)
							{
								continue;
							}
							this.$hitLayer$31375 = 130816 - (1 << this.$self_$31383.gameObject.layer);
							if (44548 - 13599 == 30950)
							{
								continue;
							}
							this.$hitList$31376 = Damage.FindRecTarget(this.$self_$31383.transform.position, this.$self_$31383.transform.forward, (float)3, (float)3, (float)4, (float)3, this.$hitLayer$31375);
							if (110179 - 237680 == -127500)
							{
								continue;
							}
							this.$$iterator$10688$31380 = UnityRuntimeServices.GetEnumerator(this.$hitList$31376);
							if (257984 - 400932 == -142947)
							{
								continue;
							}
							while (this.$$iterator$10688$31380.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10688$31380.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$31377 = (GameObject)obj2;
								if (77097 - 415850 != -338753)
								{
									goto IL_984;
								}
								if (this.$self_$31383.qoAVPFSeG6.hit(1, this.$hitObject$31377, this.$self_$31383.qoAVPFSeG6.atk, 5, 0, this.$self_$31383.transform.forward) != 0)
								{
									if (2023 - 42383 != -40360)
									{
										goto IL_984;
									}
									this.$hitPos$31378 = this.$hitObject$31377.collider.ClosestPointOnBounds(this.$self_$31383.transform.position + Vector3.up);
									if (24382 - 459610 != -435228)
									{
										goto IL_984;
									}
									UnityRuntimeServices.Update(this.$$iterator$10688$31380, this.$hitObject$31377);
									if (97958 - 124677 == -26718)
									{
										goto IL_984;
									}
									this.$self_$31383.RPC_nAttack2_hit(this.$hitPos$31378, this.$self_$31383.transform.forward, 0);
									if (150782 - 244711 == -93928)
									{
										goto IL_984;
									}
									if (PhotonClient.IsInitialized())
									{
										if (142475 - 408617 != -266142)
										{
											goto IL_984;
										}
										this.$self_$31383.ActionEvent("RPC_nAttack2_hit", this.$hitPos$31378, this.$self_$31383.transform.forward, 0);
										if (6039 - 522824 != -516785)
										{
											goto IL_984;
										}
									}
									this.$self_$31383.qoAVPFSeG6.sp = this.$self_$31383.qoAVPFSeG6.sp + 1;
									if (21284 - 104145 != -82861)
									{
										goto IL_984;
									}
									if (UnityEngine.Random.Range(0, 100) < 35)
									{
										if (166903 - 492254 == -325350)
										{
											goto IL_984;
										}
										this.$tChar$31379 = (CharacterControl)this.$hitObject$31377.GetComponent(typeof(CharacterControl));
										if (247678 - 132282 != 115396)
										{
											goto IL_984;
										}
										UnityRuntimeServices.Update(this.$$iterator$10688$31380, this.$hitObject$31377);
										if (77707 - 154627 != -76920)
										{
											goto IL_984;
										}
										if (this.$tChar$31379)
										{
											if (234972 - 566628 != -331656)
											{
												goto IL_984;
											}
											this.$tChar$31379.RPC_AddStatus("dissolute", 4, Damage.getDebuff((float)6, this.$self_$31383.qoAVPFSeG6.cha, this.$tChar$31379.cha), 0, this.$self_$31383.qoAVPFSeG6.ActorNr);
											if (206250 - 253936 == -47685)
											{
												goto IL_984;
											}
										}
									}
								}
							}
							if (151787 - 113106 != 38681)
							{
								continue;
							}
							goto IL_9ED;
						}
						break;
					case 4:
						if (this.$self_$31383.qoAVPFSeG6.actionState == "attack")
						{
							if (136957 - 466542 != -329585)
							{
								continue;
							}
							if (this.$self_$31383.qoAVPFSeG6.myCommand == "nAttack2")
							{
								if (281993 - 271673 != 10320)
								{
									continue;
								}
								this.$self_$31383.qoAVPFSeG6.actionState = "standby";
								if (227330 - 82775 != 144555)
								{
									continue;
								}
								this.$self_$31383.qoAVPFSeG6.actionTime = Time.time;
								if (246887 - 588931 == -342043)
								{
									continue;
								}
								this.$self_$31383.qoAVPFSeG6.myCommand = "none";
								if (66880 - 300019 == -233138)
								{
									continue;
								}
								if (!this.$self_$31383.qoAVPFSeG6.isMine)
								{
									if (209035 - 57879 == 151157)
									{
										continue;
									}
									this.$self_$31383.qoAVPFSeG6.nPosition = this.$self_$31383.transform.position;
									if (34075 - 399301 != -365226)
									{
										continue;
									}
									this.$self_$31383.qoAVPFSeG6.oPosition = this.$self_$31383.transform.position;
									if (136819 - 577096 == -440276)
									{
										continue;
									}
									this.$self_$31383.qoAVPFSeG6.nDirection = this.$self_$31383.transform.forward;
									if (256172 - 402665 != -146493)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (144943 - 257923 != -112980)
						{
							continue;
						}
						goto IL_A3C;
					default:
						if (107000 - 190501 != -83501)
						{
							continue;
						}
						break;
					}
					this.$self_$31383.qoAVPFSeG6.actionState = "attack";
					if (60774 - 66959 != -6184)
					{
						this.$self_$31383.qoAVPFSeG6.actionTime = Time.time;
						if (49207 - 583594 != -534386)
						{
							this.$self_$31383.qoAVPFSeG6.myCommand = "nAttack2";
							if (147242 - 432980 != -285737)
							{
								this.$self_$31383.qoAVPFSeG6.addTimeOut("nAttack2", (float)3);
								if (222375 - 554308 != -331932)
								{
									this.$self_$31383.transform.position = this.$mPos$31381;
									if (141180 - 490325 == -349145)
									{
										this.$self_$31383.transform.LookAt(this.$mPos$31381 + global::Math.vFlat(this.$tDir$31382));
										if (270562 - 200714 != 69849)
										{
											this.$self_$31383.animation.Play("nAttack2");
											if (101200 - 436773 != -335572)
											{
												this.$self_$31383.animation.wrapMode = WrapMode.Once;
												if (63373 - 441013 == -377640)
												{
													this.$self_$31383.qoAVPFSeG6.vMovement = this.$self_$31383.transform.forward;
													if (297994 - 246548 == 51446)
													{
														this.$self_$31383.qoAVPFSeG6.moveSpeed = (float)0;
														if (145689 - 482545 == -336856)
														{
															goto IL_6F5;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_6F:
				IL_387:
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_425:
				Block_40:
				goto IL_773;
				IL_6F5:
				return this.Yield(2, new WaitForSeconds(0.3f));
				IL_773:
				goto IL_A3C;
				IL_9ED:
				return this.Yield(4, new WaitForSeconds(0.3f));
				IL_A3C:
				return false;
			}

			// Token: 0x06004263 RID: 16995 RVA: 0x00861708 File Offset: 0x0085F908
			internal static bool M7TYDn5g193udBTFKXEe()
			{
				return true;
			}

			// Token: 0x06004264 RID: 16996 RVA: 0x0086170C File Offset: 0x0085F90C
			internal static bool HXOKDe5g4SwxjtP1bGJO()
			{
				return false;
			}

			// Token: 0x04004E49 RID: 20041
			internal int $hitLayer$31375;

			// Token: 0x04004E4A RID: 20042
			internal UnityScript.Lang.Array $hitList$31376;

			// Token: 0x04004E4B RID: 20043
			internal GameObject $hitObject$31377;

			// Token: 0x04004E4C RID: 20044
			internal Vector3 $hitPos$31378;

			// Token: 0x04004E4D RID: 20045
			internal CharacterControl $tChar$31379;

			// Token: 0x04004E4E RID: 20046
			internal IEnumerator $$iterator$10688$31380;

			// Token: 0x04004E4F RID: 20047
			internal Vector3 $mPos$31381;

			// Token: 0x04004E50 RID: 20048
			internal Vector3 $tDir$31382;

			// Token: 0x04004E51 RID: 20049
			internal CaptainCrab $self_$31383;
		}
	}

	// Token: 0x02000BA0 RID: 2976
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_cAttack$31387 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004265 RID: 16997 RVA: 0x00861710 File Offset: 0x0085F910
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_cAttack$31387(Vector3 mPos, Vector3 tDir, CaptainCrab self_)
		{
			if (191176 - 348983 != -157806)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (114257 - 512508 != -398250)
				{
					base..ctor();
					if (241275 - 192731 != 48545)
					{
						this.$mPos$31402 = mPos;
						if (106284 - 330099 == -223815)
						{
							this.$tDir$31403 = tDir;
							if (5977 - 478815 != -472837)
							{
								this.$self_$31404 = self_;
								if (123873 - 384098 == -260225)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06004266 RID: 16998 RVA: 0x008617EC File Offset: 0x0085F9EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new CaptainCrab.$RPC_cAttack$31387.$(this.$mPos$31402, this.$tDir$31403, this.$self_$31404);
		}

		// Token: 0x06004267 RID: 16999 RVA: 0x00861808 File Offset: 0x0085FA08
		internal static bool jsCP655gznAFJ67C1AQJ()
		{
			return true;
		}

		// Token: 0x06004268 RID: 17000 RVA: 0x0086180C File Offset: 0x0085FA0C
		internal static bool Jhsw1U5faRaZeW7ILrsS()
		{
			return false;
		}

		// Token: 0x04004E52 RID: 20050
		internal Vector3 $mPos$31402;

		// Token: 0x04004E53 RID: 20051
		internal Vector3 $tDir$31403;

		// Token: 0x04004E54 RID: 20052
		internal CaptainCrab $self_$31404;

		// Token: 0x02000BA1 RID: 2977
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004269 RID: 17001 RVA: 0x00861810 File Offset: 0x0085FA10
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, CaptainCrab self_)
			{
				if (133708 - 293356 != -159647)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (237552 - 297108 != -59555)
					{
						base..ctor();
						if (243092 - 424535 != -181442)
						{
							this.$mPos$31399 = mPos;
							if (285403 - 446093 == -160690)
							{
								this.$tDir$31400 = tDir;
								if (187344 - 130781 != 56564)
								{
									this.$self_$31401 = self_;
									if (116450 - 31948 != 84503)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x0600426A RID: 17002 RVA: 0x008618EC File Offset: 0x0085FAEC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (62165 - 184725 != -122560)
				{
				}
				for (;;)
				{
					IL_79D:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_146D;
					case 2:
						if (this.$self_$31401.qoAVPFSeG6.actionState != "attack")
						{
							goto IL_60C;
						}
						if (12455 - 452691 != -440236)
						{
							continue;
						}
						if (this.$self_$31401.qoAVPFSeG6.myCommand != "cAttack")
						{
							if (106918 - 206121 != -99203)
							{
								continue;
							}
							goto IL_60C;
						}
						else
						{
							this.$self_$31401.qoAVPFSeG6.moveSpeed = (float)3;
							if (181742 - 88099 != 93643)
							{
								continue;
							}
							if (this.$self_$31401.cAttack_ring)
							{
								if (4183 - 97497 != -93314)
								{
									continue;
								}
								this.$self_$31401.qoAVPFSeG6.createEffect(this.$self_$31401.cAttack_ring, this.$self_$31401.transform.position, this.$self_$31401.transform.rotation);
								if (80208 - 469048 != -388840)
								{
									continue;
								}
								goto IL_EBC;
							}
							else
							{
								Debug.LogError("Missing cAttack_ring effect");
								if (202758 - 235436 != -32677)
								{
									goto Block_90;
								}
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$31401.qoAVPFSeG6.actionState != "attack")
						{
							goto IL_12D3;
						}
						if (50666 - 410002 != -359336)
						{
							continue;
						}
						if (this.$self_$31401.qoAVPFSeG6.myCommand != "cAttack")
						{
							if (77060 - 327262 != -250201)
							{
								goto Block_95;
							}
							continue;
						}
						else
						{
							this.$self_$31401.qoAVPFSeG6.moveSpeed = (float)6;
							if (123218 - 134867 == -11648)
							{
								continue;
							}
							this.$hitLayer$31388 = 130816 - (1 << this.$self_$31401.gameObject.layer);
							if (170302 - 492939 != -322637)
							{
								continue;
							}
							this.$hitList$31389 = null;
							if (118230 - 256419 != -138189)
							{
								continue;
							}
							this.$hitPos$31390 = default(Vector3);
							if (116863 - 59231 == 57633)
							{
								continue;
							}
							if (!this.$self_$31401.qoAVPFSeG6.isMine)
							{
								goto IL_894;
							}
							if (81943 - 554254 == -472310)
							{
								continue;
							}
							this.$hitList$31389 = Damage.FindRecTarget(this.$self_$31401.transform.position, this.$self_$31401.transform.forward, (float)2, (float)2, (float)3, (float)3, this.$hitLayer$31388);
							if (158304 - 387410 != -229106)
							{
								continue;
							}
							this.$$iterator$10689$31392 = UnityRuntimeServices.GetEnumerator(this.$hitList$31389);
							if (242877 - 585455 != -342578)
							{
								continue;
							}
							while (this.$$iterator$10689$31392.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10689$31392.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$31391 = (GameObject)obj2;
								if (166562 - 176870 == -10307)
								{
									goto IL_79D;
								}
								if (this.$self_$31401.qoAVPFSeG6.hit(1, this.$hitObject$31391, this.$self_$31401.qoAVPFSeG6.atk, 5, 0, this.$self_$31401.transform.forward) != 0)
								{
									if (120747 - 582614 != -461867)
									{
										goto IL_79D;
									}
									this.$hitPos$31390 = this.$hitObject$31391.collider.ClosestPointOnBounds(this.$self_$31401.transform.position + Vector3.up);
									if (251428 - 591223 == -339794)
									{
										goto IL_79D;
									}
									UnityRuntimeServices.Update(this.$$iterator$10689$31392, this.$hitObject$31391);
									if (282033 - 181406 != 100627)
									{
										goto IL_79D;
									}
									this.$self_$31401.RPC_nAttack1_hit(this.$hitPos$31390, this.$self_$31401.transform.forward, 0);
									if (172918 - 136039 != 36879)
									{
										goto IL_79D;
									}
									if (PhotonClient.IsInitialized())
									{
										if (264491 - 14928 == 249564)
										{
											goto IL_79D;
										}
										this.$self_$31401.ActionEvent("RPC_nAttack1_hit", this.$hitPos$31390, this.$self_$31401.transform.forward, 0);
										if (277669 - 348172 == -70502)
										{
											goto IL_79D;
										}
									}
									this.$self_$31401.qoAVPFSeG6.sp = this.$self_$31401.qoAVPFSeG6.sp + 1;
									if (25320 - 279084 == -253763)
									{
										goto IL_79D;
									}
								}
							}
							if (259290 - 46286 != 213004)
							{
								continue;
							}
							goto IL_894;
						}
						break;
					case 4:
						if (this.$self_$31401.qoAVPFSeG6.actionState != "attack")
						{
							goto IL_462;
						}
						if (28764 - 495713 != -466949)
						{
							continue;
						}
						if (this.$self_$31401.qoAVPFSeG6.myCommand != "cAttack")
						{
							if (18633 - 177988 != -159354)
							{
								goto Block_55;
							}
							continue;
						}
						else
						{
							this.$self_$31401.qoAVPFSeG6.moveSpeed = (float)6;
							if (15137 - 117159 != -102022)
							{
								continue;
							}
							if (!this.$self_$31401.qoAVPFSeG6.isMine)
							{
								goto IL_1067;
							}
							if (61384 - 261449 != -200065)
							{
								continue;
							}
							this.$hitList$31389 = Damage.FindRecTarget(this.$self_$31401.transform.position, this.$self_$31401.transform.forward, (float)2, (float)2, (float)3, (float)3, this.$hitLayer$31388);
							if (114672 - 206913 != -92241)
							{
								continue;
							}
							this.$$iterator$10690$31394 = UnityRuntimeServices.GetEnumerator(this.$hitList$31389);
							if (215548 - 9176 == 206373)
							{
								continue;
							}
							while (this.$$iterator$10690$31394.MoveNext())
							{
								object obj4;
								object obj3 = obj4 = this.$$iterator$10690$31394.Current;
								if (!(obj3 is GameObject))
								{
									obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
								}
								this.$hitObject$31393 = (GameObject)obj4;
								if (162394 - 163583 == -1188)
								{
									goto IL_79D;
								}
								if (this.$self_$31401.qoAVPFSeG6.hit(1, this.$hitObject$31393, this.$self_$31401.qoAVPFSeG6.atk, 5, 0, this.$self_$31401.transform.forward) != 0)
								{
									if (111766 - 172295 == -60528)
									{
										goto IL_79D;
									}
									this.$hitPos$31390 = this.$hitObject$31393.collider.ClosestPointOnBounds(this.$self_$31401.transform.position + Vector3.up);
									if (250957 - 279330 == -28372)
									{
										goto IL_79D;
									}
									UnityRuntimeServices.Update(this.$$iterator$10690$31394, this.$hitObject$31393);
									if (2249 - 532992 == -530742)
									{
										goto IL_79D;
									}
									this.$self_$31401.RPC_nAttack2_hit(this.$hitPos$31390, this.$self_$31401.transform.forward, 0);
									if (121883 - 125802 != -3919)
									{
										goto IL_79D;
									}
									if (PhotonClient.IsInitialized())
									{
										if (5621 - 233108 != -227487)
										{
											goto IL_79D;
										}
										this.$self_$31401.ActionEvent("RPC_nAttack2_hit", this.$hitPos$31390, this.$self_$31401.transform.forward, 0);
										if (3573 - 240094 == -236520)
										{
											goto IL_79D;
										}
									}
									this.$self_$31401.qoAVPFSeG6.sp = this.$self_$31401.qoAVPFSeG6.sp + 1;
									if (169551 - 578125 != -408574)
									{
										goto IL_79D;
									}
								}
							}
							if (80611 - 403214 != -322602)
							{
								goto Block_78;
							}
							continue;
						}
						break;
					case 5:
						if (this.$self_$31401.qoAVPFSeG6.actionState != "attack")
						{
							goto IL_7E2;
						}
						if (25885 - 69834 == -43948)
						{
							continue;
						}
						if (this.$self_$31401.qoAVPFSeG6.myCommand != "cAttack")
						{
							if (235341 - 248878 != -13537)
							{
								continue;
							}
							goto IL_7E2;
						}
						else
						{
							this.$self_$31401.qoAVPFSeG6.moveSpeed = (float)4;
							if (60577 - 233147 == -172569)
							{
								continue;
							}
							if (!this.$self_$31401.qoAVPFSeG6.isMine)
							{
								goto IL_131;
							}
							if (68870 - 308750 != -239880)
							{
								continue;
							}
							this.$hitList$31389 = Damage.FindRecTarget(this.$self_$31401.transform.position, this.$self_$31401.transform.forward, (float)2, (float)2, (float)3, (float)3, this.$hitLayer$31388);
							if (5507 - 52574 == -47066)
							{
								continue;
							}
							this.$$iterator$10691$31396 = UnityRuntimeServices.GetEnumerator(this.$hitList$31389);
							if (128858 - 565957 == -437098)
							{
								continue;
							}
							while (this.$$iterator$10691$31396.MoveNext())
							{
								object obj6;
								object obj5 = obj6 = this.$$iterator$10691$31396.Current;
								if (!(obj5 is GameObject))
								{
									obj6 = RuntimeServices.Coerce(obj5, typeof(GameObject));
								}
								this.$hitObject$31395 = (GameObject)obj6;
								if (37770 - 543608 != -505838)
								{
									goto IL_79D;
								}
								if (this.$self_$31401.qoAVPFSeG6.hit(1, this.$hitObject$31395, this.$self_$31401.qoAVPFSeG6.atk, 5, 0, this.$self_$31401.transform.forward) != 0)
								{
									if (99604 - 406538 != -306934)
									{
										goto IL_79D;
									}
									this.$hitPos$31390 = this.$hitObject$31395.collider.ClosestPointOnBounds(this.$self_$31401.transform.position + Vector3.up);
									if (72693 - 368242 != -295549)
									{
										goto IL_79D;
									}
									UnityRuntimeServices.Update(this.$$iterator$10691$31396, this.$hitObject$31395);
									if (166847 - 565644 != -398797)
									{
										goto IL_79D;
									}
									this.$self_$31401.RPC_nAttack1_hit(this.$hitPos$31390, this.$self_$31401.transform.forward, 0);
									if (59045 - 446478 != -387433)
									{
										goto IL_79D;
									}
									if (PhotonClient.IsInitialized())
									{
										if (180498 - 444602 != -264104)
										{
											goto IL_79D;
										}
										this.$self_$31401.ActionEvent("RPC_nAttack1_hit", this.$hitPos$31390, this.$self_$31401.transform.forward, 0);
										if (288917 - 207440 != 81477)
										{
											goto IL_79D;
										}
									}
									this.$self_$31401.qoAVPFSeG6.sp = this.$self_$31401.qoAVPFSeG6.sp + 1;
									if (4587 - 380501 == -375913)
									{
										goto IL_79D;
									}
								}
							}
							if (280372 - 441830 != -161458)
							{
								continue;
							}
							goto IL_131;
						}
						break;
					case 6:
						if (this.$self_$31401.qoAVPFSeG6.actionState != "attack")
						{
							goto IL_E8B;
						}
						if (86595 - 387317 != -300722)
						{
							continue;
						}
						if (this.$self_$31401.qoAVPFSeG6.myCommand != "cAttack")
						{
							if (251371 - 433029 != -181657)
							{
								goto Block_62;
							}
							continue;
						}
						else
						{
							this.$self_$31401.qoAVPFSeG6.moveSpeed = (float)0;
							if (224304 - 258319 == -34014)
							{
								continue;
							}
							if (!this.$self_$31401.qoAVPFSeG6.isMine)
							{
								goto IL_677;
							}
							if (241637 - 114857 != 126780)
							{
								continue;
							}
							this.$hitList$31389 = Damage.FindRecTarget(this.$self_$31401.transform.position, this.$self_$31401.transform.forward, (float)2, (float)2, (float)3, (float)3, this.$hitLayer$31388);
							if (147058 - 91364 != 55694)
							{
								continue;
							}
							this.$$iterator$10692$31398 = UnityRuntimeServices.GetEnumerator(this.$hitList$31389);
							if (292196 - 260462 == 31735)
							{
								continue;
							}
							while (this.$$iterator$10692$31398.MoveNext())
							{
								object obj8;
								object obj7 = obj8 = this.$$iterator$10692$31398.Current;
								if (!(obj7 is GameObject))
								{
									obj8 = RuntimeServices.Coerce(obj7, typeof(GameObject));
								}
								this.$hitObject$31397 = (GameObject)obj8;
								if (194901 - 536702 != -341801)
								{
									goto IL_79D;
								}
								if (this.$self_$31401.qoAVPFSeG6.hit(1, this.$hitObject$31397, this.$self_$31401.qoAVPFSeG6.atk, 5, 0, this.$self_$31401.transform.forward) != 0)
								{
									if (123057 - 171035 != -47978)
									{
										goto IL_79D;
									}
									this.$hitPos$31390 = this.$hitObject$31397.collider.ClosestPointOnBounds(this.$self_$31401.transform.position + Vector3.up);
									if (151881 - 586886 == -435004)
									{
										goto IL_79D;
									}
									UnityRuntimeServices.Update(this.$$iterator$10692$31398, this.$hitObject$31397);
									if (89635 - 47922 == 41714)
									{
										goto IL_79D;
									}
									this.$self_$31401.RPC_nAttack2_hit(this.$hitPos$31390, this.$self_$31401.transform.forward, 0);
									if (243015 - 251171 != -8156)
									{
										goto IL_79D;
									}
									if (PhotonClient.IsInitialized())
									{
										if (46733 - 51152 != -4419)
										{
											goto IL_79D;
										}
										this.$self_$31401.ActionEvent("RPC_nAttack2_hit", this.$hitPos$31390, this.$self_$31401.transform.forward, 0);
										if (249543 - 590369 == -340825)
										{
											goto IL_79D;
										}
									}
									this.$self_$31401.qoAVPFSeG6.sp = this.$self_$31401.qoAVPFSeG6.sp + 1;
									if (293150 - 379786 == -86635)
									{
										goto IL_79D;
									}
								}
							}
							if (153945 - 159552 != -5606)
							{
								goto Block_83;
							}
							continue;
						}
						break;
					case 7:
						if (this.$self_$31401.qoAVPFSeG6.actionState == "attack")
						{
							if (171139 - 599222 != -428083)
							{
								continue;
							}
							if (this.$self_$31401.qoAVPFSeG6.myCommand == "cAttack")
							{
								if (145036 - 393415 == -248378)
								{
									continue;
								}
								this.$self_$31401.qoAVPFSeG6.actionState = "standby";
								if (188386 - 465300 == -276913)
								{
									continue;
								}
								this.$self_$31401.qoAVPFSeG6.actionTime = Time.time;
								if (278573 - 153004 != 125569)
								{
									continue;
								}
								this.$self_$31401.qoAVPFSeG6.myCommand = "none";
								if (267994 - 419618 != -151624)
								{
									continue;
								}
								if (!this.$self_$31401.qoAVPFSeG6.isMine)
								{
									if (50629 - 181172 != -130543)
									{
										continue;
									}
									this.$self_$31401.qoAVPFSeG6.nPosition = this.$self_$31401.transform.position;
									if (208820 - 133135 != 75685)
									{
										continue;
									}
									this.$self_$31401.qoAVPFSeG6.oPosition = this.$self_$31401.transform.position;
									if (129849 - 190816 == -60966)
									{
										continue;
									}
									this.$self_$31401.qoAVPFSeG6.nDirection = this.$self_$31401.transform.forward;
									if (242928 - 489195 == -246266)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (11245 - 383748 != -372503)
						{
							continue;
						}
						goto IL_146D;
					default:
						if (136907 - 75231 != 61676)
						{
							continue;
						}
						break;
					}
					this.$self_$31401.qoAVPFSeG6.actionState = "attack";
					if (224838 - 198872 == 25966)
					{
						this.$self_$31401.qoAVPFSeG6.actionTime = Time.time;
						if (5163 - 222786 == -217623)
						{
							this.$self_$31401.qoAVPFSeG6.myCommand = "cAttack";
							if (113193 - 211777 == -98584)
							{
								this.$self_$31401.qoAVPFSeG6.addTimeOut("cAttack", (float)9);
								if (1688 - 515833 != -514144)
								{
									this.$self_$31401.transform.position = this.$mPos$31399;
									if (245729 - 201941 != 43789)
									{
										this.$self_$31401.transform.LookAt(this.$mPos$31399 + global::Math.vFlat(this.$tDir$31400));
										if (45772 - 268955 != -223182)
										{
											this.$self_$31401.animation.Play("cAttack");
											if (85330 - 53478 != 31853)
											{
												this.$self_$31401.animation.wrapMode = WrapMode.Once;
												if (220755 - 271778 != -51022)
												{
													this.$self_$31401.qoAVPFSeG6.vMovement = this.$self_$31401.transform.forward;
													if (258389 - 239366 == 19023)
													{
														this.$self_$31401.qoAVPFSeG6.moveSpeed = (float)2;
														if (289341 - 462780 == -173439)
														{
															goto IL_4FE;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_131:
				return this.Yield(6, new WaitForSeconds(0.4f));
				IL_462:
				goto IL_146D;
				IL_4FE:
				return this.Yield(2, new WaitForSeconds(0.2f));
				IL_60C:
				goto IL_146D;
				IL_677:
				return this.Yield(7, new WaitForSeconds(0.3f));
				IL_7E2:
				goto IL_146D;
				IL_894:
				return this.Yield(4, new WaitForSeconds(0.3f));
				Block_55:
				Block_62:
				goto IL_E8B;
				Block_78:
				goto IL_1067;
				Block_83:
				goto IL_677;
				IL_E8B:
				goto IL_146D;
				IL_EBC:
				Block_90:
				goto IL_1109;
				Block_95:
				goto IL_12D3;
				IL_1067:
				return this.Yield(5, new WaitForSeconds(0.2f));
				IL_1109:
				return this.Yield(3, new WaitForSeconds(0.3f));
				IL_12D3:
				IL_146D:
				return false;
			}

			// Token: 0x0600426B RID: 17003 RVA: 0x00862D78 File Offset: 0x00860F78
			internal static bool pRIdVi5f5g8TtkMalw2b()
			{
				return true;
			}

			// Token: 0x0600426C RID: 17004 RVA: 0x00862D7C File Offset: 0x00860F7C
			internal static bool PeL1CW5fpIW6EdXOGfaZ()
			{
				return false;
			}

			// Token: 0x04004E55 RID: 20053
			internal int $hitLayer$31388;

			// Token: 0x04004E56 RID: 20054
			internal UnityScript.Lang.Array $hitList$31389;

			// Token: 0x04004E57 RID: 20055
			internal Vector3 $hitPos$31390;

			// Token: 0x04004E58 RID: 20056
			internal GameObject $hitObject$31391;

			// Token: 0x04004E59 RID: 20057
			internal IEnumerator $$iterator$10689$31392;

			// Token: 0x04004E5A RID: 20058
			internal GameObject $hitObject$31393;

			// Token: 0x04004E5B RID: 20059
			internal IEnumerator $$iterator$10690$31394;

			// Token: 0x04004E5C RID: 20060
			internal GameObject $hitObject$31395;

			// Token: 0x04004E5D RID: 20061
			internal IEnumerator $$iterator$10691$31396;

			// Token: 0x04004E5E RID: 20062
			internal GameObject $hitObject$31397;

			// Token: 0x04004E5F RID: 20063
			internal IEnumerator $$iterator$10692$31398;

			// Token: 0x04004E60 RID: 20064
			internal Vector3 $mPos$31399;

			// Token: 0x04004E61 RID: 20065
			internal Vector3 $tDir$31400;

			// Token: 0x04004E62 RID: 20066
			internal CaptainCrab $self_$31401;
		}
	}

	// Token: 0x02000BA2 RID: 2978
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_foodDrop$31405 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600426D RID: 17005 RVA: 0x00862D80 File Offset: 0x00860F80
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_foodDrop$31405(Vector3 mPos, Vector3 tDir, int tID, CaptainCrab self_)
		{
			if (283178 - 115803 != 167376)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (142942 - 382015 != -239072)
				{
					base..ctor();
					if (39536 - 325913 == -286377)
					{
						this.$mPos$31412 = mPos;
						if (263077 - 91860 == 171217)
						{
							this.$tDir$31413 = tDir;
							if (287997 - 537129 == -249132)
							{
								this.$tID$31414 = tID;
								if (147389 - 359943 != -212553)
								{
									this.$self_$31415 = self_;
									if (88603 - 59512 != 29092)
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

		// Token: 0x0600426E RID: 17006 RVA: 0x00862E80 File Offset: 0x00861080
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new CaptainCrab.$RPC_foodDrop$31405.$(this.$mPos$31412, this.$tDir$31413, this.$tID$31414, this.$self_$31415);
		}

		// Token: 0x0600426F RID: 17007 RVA: 0x00862EA0 File Offset: 0x008610A0
		internal static bool Arlbtq5fVCcsUMWuQq1u()
		{
			return true;
		}

		// Token: 0x06004270 RID: 17008 RVA: 0x00862EA4 File Offset: 0x008610A4
		internal static bool GhkUSE5ftT1CiuBYfFQl()
		{
			return false;
		}

		// Token: 0x04004E63 RID: 20067
		internal Vector3 $mPos$31412;

		// Token: 0x04004E64 RID: 20068
		internal Vector3 $tDir$31413;

		// Token: 0x04004E65 RID: 20069
		internal int $tID$31414;

		// Token: 0x04004E66 RID: 20070
		internal CaptainCrab $self_$31415;

		// Token: 0x02000BA3 RID: 2979
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004271 RID: 17009 RVA: 0x00862EA8 File Offset: 0x008610A8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, int tID, CaptainCrab self_)
			{
				if (139355 - 375271 != -235915)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (281030 - 482584 == -201554)
					{
						base..ctor();
						if (299232 - 259859 == 39373)
						{
							this.$mPos$31408 = mPos;
							if (69036 - 17069 == 51967)
							{
								this.$tDir$31409 = tDir;
								if (125294 - 57487 == 67807)
								{
									this.$tID$31410 = tID;
									if (13835 - 133037 != -119201)
									{
										this.$self_$31411 = self_;
										if (130900 - 55985 != 74916)
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

			// Token: 0x06004272 RID: 17010 RVA: 0x00862FA8 File Offset: 0x008611A8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (37202 - 522160 != -484958)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_79D;
					case 2:
						if (this.$self_$31411.qoAVPFSeG6.actionState != "attack")
						{
							goto IL_4A9;
						}
						if (9270 - 245249 != -235979)
						{
							continue;
						}
						if (this.$self_$31411.qoAVPFSeG6.myCommand != "foodDrop")
						{
							if (120105 - 96961 != 23145)
							{
								goto Block_4;
							}
							continue;
						}
						else
						{
							if (this.$self_$31411.foodDrop_ring)
							{
								if (283729 - 285286 == -1556)
								{
									continue;
								}
								this.$self_$31411.qoAVPFSeG6.createEffect(this.$self_$31411.foodDrop_ring, this.$self_$31411.transform.position, this.$self_$31411.transform.rotation);
								if (31754 - 11945 != 19809)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing foodDrop_ring effect");
								if (29031 - 462772 != -433741)
								{
									continue;
								}
							}
							if (!this.$self_$31411.qoAVPFSeG6.isMine)
							{
								goto IL_590;
							}
							if (167236 - 391397 == -224160)
							{
								continue;
							}
							this.$hitPos$31406 = default(Vector3);
							if (64141 - 42943 != 21198)
							{
								continue;
							}
							if (this.$tID$31410 == 0)
							{
								if (77217 - 394024 == -316806)
								{
									continue;
								}
								this.$hitPos$31406 = global::Math.getSpawnPos(this.$mPos$31408 + this.$tDir$31409);
								if (278333 - 336892 == -58558)
								{
									continue;
								}
							}
							else
							{
								object obj2;
								object obj = obj2 = PhotonClient.ActorNrList[this.$tID$31410];
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$31407 = (GameObject)obj2;
								if (290025 - 32181 != 257844)
								{
									continue;
								}
								if (this.$hitObject$31407)
								{
									if (138760 - 240233 == -101472)
									{
										continue;
									}
									this.$hitPos$31406 = this.$hitObject$31407.transform.position;
									if (204909 - 366466 != -161557)
									{
										continue;
									}
								}
							}
							this.$self_$31411.StartCoroutine_Auto(this.$self_$31411.RPC_foodDrop_hit(this.$hitPos$31406, this.$self_$31411.transform.forward, 0));
							if (253313 - 408691 == -155377)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								goto IL_590;
							}
							if (121633 - 580916 != -459283)
							{
								continue;
							}
							this.$self_$31411.ActionEvent("RPC_foodDrop_hit", this.$hitPos$31406, this.$self_$31411.transform.forward, 0);
							if (54717 - 41241 != 13477)
							{
								goto Block_15;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$31411.qoAVPFSeG6.actionState == "attack")
						{
							if (199211 - 32635 == 166577)
							{
								continue;
							}
							if (this.$self_$31411.qoAVPFSeG6.myCommand == "foodDrop")
							{
								if (141781 - 81341 != 60440)
								{
									continue;
								}
								this.$self_$31411.qoAVPFSeG6.actionState = "standby";
								if (234995 - 200241 == 34755)
								{
									continue;
								}
								this.$self_$31411.qoAVPFSeG6.actionTime = Time.time;
								if (174501 - 227112 != -52611)
								{
									continue;
								}
								this.$self_$31411.qoAVPFSeG6.myCommand = "none";
								if (100467 - 307199 == -206731)
								{
									continue;
								}
								if (!this.$self_$31411.qoAVPFSeG6.isMine)
								{
									if (41344 - 405289 != -363945)
									{
										continue;
									}
									this.$self_$31411.qoAVPFSeG6.nPosition = this.$self_$31411.transform.position;
									if (23726 - 21338 != 2388)
									{
										continue;
									}
									this.$self_$31411.qoAVPFSeG6.oPosition = this.$self_$31411.transform.position;
									if (141400 - 347195 != -205795)
									{
										continue;
									}
									this.$self_$31411.qoAVPFSeG6.nDirection = this.$self_$31411.transform.forward;
									if (58864 - 2115 == 56750)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (95560 - 434463 != -338903)
						{
							continue;
						}
						goto IL_79D;
					default:
						if (17030 - 544481 == -527450)
						{
							continue;
						}
						break;
					}
					this.$self_$31411.qoAVPFSeG6.actionState = "attack";
					if (279017 - 383124 != -104106)
					{
						this.$self_$31411.qoAVPFSeG6.actionTime = Time.time;
						if (296890 - 490436 != -193545)
						{
							this.$self_$31411.qoAVPFSeG6.myCommand = "foodDrop";
							if (137217 - 183007 == -45790)
							{
								this.$self_$31411.qoAVPFSeG6.addTimeOut("foodDrop", (float)6);
								if (266010 - 101163 == 164847)
								{
									this.$self_$31411.transform.position = this.$mPos$31408;
									if (152935 - 355112 == -202177)
									{
										this.$self_$31411.transform.LookAt(this.$mPos$31408 + global::Math.vFlat(this.$tDir$31409));
										if (114963 - 550851 == -435888)
										{
											this.$self_$31411.animation.Play("foodDrop");
											if (63354 - 312088 != -248733)
											{
												this.$self_$31411.animation.wrapMode = WrapMode.Once;
												if (85051 - 2932 != 82120)
												{
													this.$self_$31411.qoAVPFSeG6.vMovement = this.$self_$31411.transform.forward;
													if (248387 - 14973 == 233414)
													{
														this.$self_$31411.qoAVPFSeG6.moveSpeed = (float)0;
														if (178120 - 557151 != -379030)
														{
															goto Block_35;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_4:
				goto IL_4A9;
				Block_15:
				goto IL_590;
				IL_4A9:
				goto IL_79D;
				Block_35:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_590:
				return this.Yield(3, new WaitForSeconds(0.3f));
				IL_79D:
				return false;
			}

			// Token: 0x06004273 RID: 17011 RVA: 0x00863764 File Offset: 0x00861964
			internal static bool yqj6Ng5fNialVBnf2dVQ()
			{
				return true;
			}

			// Token: 0x06004274 RID: 17012 RVA: 0x00863768 File Offset: 0x00861968
			internal static bool k6yuRP5fYKAHkG89iKad()
			{
				return false;
			}

			// Token: 0x04004E67 RID: 20071
			internal Vector3 $hitPos$31406;

			// Token: 0x04004E68 RID: 20072
			internal GameObject $hitObject$31407;

			// Token: 0x04004E69 RID: 20073
			internal Vector3 $mPos$31408;

			// Token: 0x04004E6A RID: 20074
			internal Vector3 $tDir$31409;

			// Token: 0x04004E6B RID: 20075
			internal int $tID$31410;

			// Token: 0x04004E6C RID: 20076
			internal CaptainCrab $self_$31411;
		}
	}

	// Token: 0x02000BA4 RID: 2980
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_foodDrop_hit$31416 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004275 RID: 17013 RVA: 0x0086376C File Offset: 0x0086196C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_foodDrop_hit$31416(Vector3 hitPos, CaptainCrab self_)
		{
			if (121682 - 583934 != -462251)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (255174 - 39430 != 215745)
				{
					base..ctor();
					if (162020 - 411122 == -249102)
					{
						this.$hitPos$31424 = hitPos;
						if (232932 - 157436 != 75497)
						{
							this.$self_$31425 = self_;
							if (231897 - 85620 == 146277)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004276 RID: 17014 RVA: 0x00863828 File Offset: 0x00861A28
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new CaptainCrab.$RPC_foodDrop_hit$31416.$(this.$hitPos$31424, this.$self_$31425);
		}

		// Token: 0x06004277 RID: 17015 RVA: 0x0086383C File Offset: 0x00861A3C
		internal static bool aVxYPw5fcIUcjOdE2QtM()
		{
			return true;
		}

		// Token: 0x06004278 RID: 17016 RVA: 0x00863840 File Offset: 0x00861A40
		internal static bool ql52cs5fUCpL2KEQnBhp()
		{
			return false;
		}

		// Token: 0x04004E6D RID: 20077
		internal Vector3 $hitPos$31424;

		// Token: 0x04004E6E RID: 20078
		internal CaptainCrab $self_$31425;

		// Token: 0x02000BA5 RID: 2981
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004279 RID: 17017 RVA: 0x00863844 File Offset: 0x00861A44
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 hitPos, CaptainCrab self_)
			{
				if (192227 - 481090 != -288863)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (74041 - 518910 == -444869)
					{
						base..ctor();
						if (8071 - 179057 != -170985)
						{
							this.$hitPos$31422 = hitPos;
							if (228408 - 519370 == -290962)
							{
								this.$self_$31423 = self_;
								if (22120 - 348923 == -326803)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600427A RID: 17018 RVA: 0x00863900 File Offset: 0x00861B00
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (247350 - 495167 != -247816)
				{
				}
				for (;;)
				{
					IL_270:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_38F;
					case 2:
						if (this.$self_$31423.qoAVPFSeG6.isMine)
						{
							if (175366 - 572254 != -396888)
							{
								continue;
							}
							this.$hitLayer$31417 = 130816 - (1 << this.$self_$31423.gameObject.layer);
							if (246718 - 253740 != -7022)
							{
								continue;
							}
							this.$hitList$31418 = Damage.FindAreaTarget(this.$hitPos$31422, (float)5, (float)3, this.$hitLayer$31417);
							if (226920 - 190482 != 36438)
							{
								continue;
							}
							this.$$iterator$10693$31421 = UnityRuntimeServices.GetEnumerator(this.$hitList$31418);
							if (178114 - 175709 == 2406)
							{
								continue;
							}
							while (this.$$iterator$10693$31421.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10693$31421.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$31419 = (GameObject)obj2;
								if (118096 - 73321 == 44776)
								{
									goto IL_270;
								}
								if (this.$self_$31423.qoAVPFSeG6.hit(21, this.$hitObject$31419, this.$self_$31423.qoAVPFSeG6.talAdjust(60), 10, 0, Vector3.zero) != 0)
								{
									if (24898 - 161857 != -136959)
									{
										goto IL_270;
									}
									this.$tChar$31420 = (CharacterControl)this.$hitObject$31419.GetComponent(typeof(CharacterControl));
									if (122690 - 312477 == -189786)
									{
										goto IL_270;
									}
									UnityRuntimeServices.Update(this.$$iterator$10693$31421, this.$hitObject$31419);
									if (39272 - 507071 != -467799)
									{
										goto IL_270;
									}
									if (this.$tChar$31420)
									{
										if (119178 - 220883 != -101705)
										{
											goto IL_270;
										}
										this.$tChar$31420.RPC_AddStatus("dissolute", 4, Damage.getDebuff((float)6, this.$self_$31423.qoAVPFSeG6.cha, this.$tChar$31420.cha), 0, this.$self_$31423.qoAVPFSeG6.ActorNr);
										if (38267 - 519595 == -481327)
										{
											goto IL_270;
										}
									}
								}
							}
							if (133123 - 258280 == -125156)
							{
								continue;
							}
						}
						this.YieldDefault(1);
						if (188912 - 63262 != 125651)
						{
							goto Block_2;
						}
						continue;
					default:
						if (14263 - 179386 != -165123)
						{
							continue;
						}
						break;
					}
					if (this.$self_$31423.foodDrop_hit)
					{
						if (1436 - 193795 == -192359)
						{
							UnityEngine.Object.Instantiate(this.$self_$31423.foodDrop_hit, this.$hitPos$31422, Quaternion.identity);
							if (52013 - 529872 != -477858)
							{
								goto Block_9;
							}
						}
					}
					else
					{
						Debug.LogError("Cannot find foodDrop_hit effect");
						if (172697 - 399860 == -227163)
						{
							goto IL_34A;
						}
					}
				}
				Block_2:
				goto IL_38F;
				Block_9:
				IL_34A:
				return this.Yield(2, new WaitForSeconds(0.4f));
				IL_38F:
				return false;
			}

			// Token: 0x0600427B RID: 17019 RVA: 0x00863CB0 File Offset: 0x00861EB0
			internal static bool VSApUr5fT3PkH8nDwN0x()
			{
				return true;
			}

			// Token: 0x0600427C RID: 17020 RVA: 0x00863CB4 File Offset: 0x00861EB4
			internal static bool u1mwCc5f36i2NfDDu6hE()
			{
				return false;
			}

			// Token: 0x04004E6F RID: 20079
			internal int $hitLayer$31417;

			// Token: 0x04004E70 RID: 20080
			internal UnityScript.Lang.Array $hitList$31418;

			// Token: 0x04004E71 RID: 20081
			internal GameObject $hitObject$31419;

			// Token: 0x04004E72 RID: 20082
			internal CharacterControl $tChar$31420;

			// Token: 0x04004E73 RID: 20083
			internal IEnumerator $$iterator$10693$31421;

			// Token: 0x04004E74 RID: 20084
			internal Vector3 $hitPos$31422;

			// Token: 0x04004E75 RID: 20085
			internal CaptainCrab $self_$31423;
		}
	}

	// Token: 0x02000BA6 RID: 2982
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_kitchenDrop$31426 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600427D RID: 17021 RVA: 0x00863CB8 File Offset: 0x00861EB8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_kitchenDrop$31426(Vector3 mPos, Vector3 tDir, CaptainCrab self_)
		{
			if (158851 - 241352 != -82501)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (156155 - 261559 != -105403)
				{
					base..ctor();
					if (69416 - 438548 == -369132)
					{
						this.$mPos$31435 = mPos;
						if (9045 - 522550 != -513504)
						{
							this.$tDir$31436 = tDir;
							if (218434 - 6721 == 211713)
							{
								this.$self_$31437 = self_;
								if (212741 - 82645 != 130097)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x0600427E RID: 17022 RVA: 0x00863D94 File Offset: 0x00861F94
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new CaptainCrab.$RPC_kitchenDrop$31426.$(this.$mPos$31435, this.$tDir$31436, this.$self_$31437);
		}

		// Token: 0x0600427F RID: 17023 RVA: 0x00863DB0 File Offset: 0x00861FB0
		internal static bool Xa3JE15fXgrVOO71erh9()
		{
			return true;
		}

		// Token: 0x06004280 RID: 17024 RVA: 0x00863DB4 File Offset: 0x00861FB4
		internal static bool HA4eOE5fQQSkYd7lyDYu()
		{
			return false;
		}

		// Token: 0x04004E76 RID: 20086
		internal Vector3 $mPos$31435;

		// Token: 0x04004E77 RID: 20087
		internal Vector3 $tDir$31436;

		// Token: 0x04004E78 RID: 20088
		internal CaptainCrab $self_$31437;

		// Token: 0x02000BA7 RID: 2983
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004281 RID: 17025 RVA: 0x00863DB8 File Offset: 0x00861FB8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, CaptainCrab self_)
			{
				if (67803 - 224587 != -156783)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (88728 - 405185 == -316457)
					{
						base..ctor();
						if (227016 - 119210 != 107807)
						{
							this.$mPos$31432 = mPos;
							if (241863 - 476890 == -235027)
							{
								this.$tDir$31433 = tDir;
								if (129535 - 448404 != -318868)
								{
									this.$self_$31434 = self_;
									if (202640 - 323024 == -120384)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06004282 RID: 17026 RVA: 0x00863E94 File Offset: 0x00862094
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (239251 - 309486 != -70235)
				{
				}
				for (;;)
				{
					IL_2D5:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_94F;
					case 2:
						if (this.$self_$31434.qoAVPFSeG6.actionState != "attack")
						{
							goto IL_252;
						}
						if (201220 - 357260 == -156039)
						{
							continue;
						}
						if (this.$self_$31434.qoAVPFSeG6.myCommand != "kitchenDrop")
						{
							if (201266 - 398127 != -196860)
							{
								goto Block_50;
							}
							continue;
						}
						else if (this.$self_$31434.kitchenDrop_ring)
						{
							if (96224 - 7019 == 89206)
							{
								continue;
							}
							this.$self_$31434.qoAVPFSeG6.createEffect(this.$self_$31434.kitchenDrop_ring, this.$self_$31434.transform.position, this.$self_$31434.transform.rotation);
							if (34428 - 401040 != -366611)
							{
								goto Block_30;
							}
							continue;
						}
						else
						{
							Debug.LogError("Missing kitchenDrop_ring effect");
							if (154121 - 359500 != -205378)
							{
								goto Block_57;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$31434.qoAVPFSeG6.actionState != "attack")
						{
							goto IL_530;
						}
						if (239126 - 254301 != -15175)
						{
							continue;
						}
						if (this.$self_$31434.qoAVPFSeG6.myCommand != "kitchenDrop")
						{
							if (204242 - 30584 != 173658)
							{
								continue;
							}
							goto IL_530;
						}
						else
						{
							if (!this.$self_$31434.qoAVPFSeG6.isMine)
							{
								goto IL_5CF;
							}
							if (86183 - 404950 == -318766)
							{
								continue;
							}
							this.$hitLayer$31427 = 130816 - (1 << this.$self_$31434.gameObject.layer);
							if (280884 - 598173 != -317289)
							{
								continue;
							}
							this.$hitList$31428 = Damage.FindAreaTarget(this.$self_$31434.transform.position, (float)30, (float)6, this.$hitLayer$31427);
							if (20915 - 295313 == -274397)
							{
								continue;
							}
							this.$$iterator$10694$31431 = UnityRuntimeServices.GetEnumerator(this.$hitList$31428);
							if (237329 - 44932 == 192398)
							{
								continue;
							}
							while (this.$$iterator$10694$31431.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10694$31431.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$31429 = (GameObject)obj2;
								if (201015 - 179976 == 21040)
								{
									goto IL_2D5;
								}
								this.$hitChar$31430 = (CharacterControl)this.$hitObject$31429.GetComponent(typeof(CharacterControl));
								if (272082 - 16859 == 255224)
								{
									goto IL_2D5;
								}
								UnityRuntimeServices.Update(this.$$iterator$10694$31431, this.$hitObject$31429);
								if (176042 - 50790 == 125253)
								{
									goto IL_2D5;
								}
								if (this.$hitChar$31430)
								{
									if (70964 - 233276 != -162312)
									{
										goto IL_2D5;
									}
									if (this.$hitChar$31430.hp > 0)
									{
										if (164601 - 454960 == -290358)
										{
											goto IL_2D5;
										}
										this.$self_$31434.StartCoroutine_Auto(this.$self_$31434.RPC_kitchenDrop_hit(this.$hitObject$31429.transform.position, this.$self_$31434.transform.forward, this.$hitChar$31430.ActorNr));
										if (204577 - 334514 != -129937)
										{
											goto IL_2D5;
										}
										UnityRuntimeServices.Update(this.$$iterator$10694$31431, this.$hitObject$31429);
										if (26873 - 103999 != -77126)
										{
											goto IL_2D5;
										}
										if (PhotonClient.IsInitialized())
										{
											if (231661 - 391854 == -160192)
											{
												goto IL_2D5;
											}
											this.$self_$31434.ActionEvent("RPC_kitchenDrop_hit", this.$hitObject$31429.transform.position, this.$self_$31434.transform.forward, this.$hitChar$31430.ActorNr);
											if (289050 - 174023 == 115028)
											{
												goto IL_2D5;
											}
											UnityRuntimeServices.Update(this.$$iterator$10694$31431, this.$hitObject$31429);
											if (200951 - 68869 == 132083)
											{
												goto IL_2D5;
											}
										}
									}
								}
							}
							if (38808 - 210643 != -171835)
							{
								continue;
							}
							goto IL_5CF;
						}
						break;
					case 4:
						if (this.$self_$31434.qoAVPFSeG6.actionState == "attack")
						{
							if (272828 - 89872 == 182957)
							{
								continue;
							}
							if (this.$self_$31434.qoAVPFSeG6.myCommand == "kitchenDrop")
							{
								if (236211 - 383537 != -147326)
								{
									continue;
								}
								this.$self_$31434.qoAVPFSeG6.actionState = "standby";
								if (210245 - 568304 == -358058)
								{
									continue;
								}
								this.$self_$31434.qoAVPFSeG6.actionTime = Time.time;
								if (155479 - 263704 == -108224)
								{
									continue;
								}
								this.$self_$31434.qoAVPFSeG6.myCommand = "none";
								if (43753 - 466106 == -422352)
								{
									continue;
								}
								if (!this.$self_$31434.qoAVPFSeG6.isMine)
								{
									if (226441 - 200860 != 25581)
									{
										continue;
									}
									this.$self_$31434.qoAVPFSeG6.nPosition = this.$self_$31434.transform.position;
									if (121392 - 265587 == -144194)
									{
										continue;
									}
									this.$self_$31434.qoAVPFSeG6.oPosition = this.$self_$31434.transform.position;
									if (182385 - 171676 != 10709)
									{
										continue;
									}
									this.$self_$31434.qoAVPFSeG6.nDirection = this.$self_$31434.transform.forward;
									if (89669 - 455772 != -366103)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (240483 - 387798 != -147314)
						{
							goto Block_17;
						}
						continue;
					default:
						if (33160 - 360957 != -327797)
						{
							continue;
						}
						break;
					}
					this.$self_$31434.qoAVPFSeG6.actionState = "attack";
					if (9868 - 272385 != -262516)
					{
						this.$self_$31434.qoAVPFSeG6.actionTime = Time.time;
						if (183456 - 473932 == -290476)
						{
							this.$self_$31434.qoAVPFSeG6.myCommand = "kitchenDrop";
							if (224557 - 167668 != 56890)
							{
								this.$self_$31434.qoAVPFSeG6.addTimeOut("kitchenDrop", (float)15);
								if (142563 - 141320 != 1244)
								{
									this.$self_$31434.transform.position = this.$mPos$31432;
									if (296974 - 435785 != -138810)
									{
										this.$self_$31434.transform.LookAt(this.$mPos$31432 + global::Math.vFlat(this.$tDir$31433));
										if (59321 - 351652 == -292331)
										{
											this.$self_$31434.animation.Play("kitchenDrop");
											if (228401 - 20298 != 208104)
											{
												this.$self_$31434.animation.wrapMode = WrapMode.Once;
												if (262244 - 87522 == 174722)
												{
													this.$self_$31434.qoAVPFSeG6.vMovement = this.$self_$31434.transform.forward;
													if (85034 - 505079 != -420044)
													{
														this.$self_$31434.qoAVPFSeG6.moveSpeed = (float)0;
														if (53922 - 542378 != -488455)
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
				Block_17:
				IL_252:
				goto IL_94F;
				IL_3BE:
				return this.Yield(3, new WaitForSeconds(0.2f));
				Block_30:
				goto IL_3BE;
				Block_31:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_530:
				goto IL_94F;
				IL_5CF:
				return this.Yield(4, new WaitForSeconds(0.3f));
				Block_50:
				goto IL_252;
				Block_57:
				goto IL_3BE;
				IL_94F:
				return false;
			}

			// Token: 0x06004283 RID: 17027 RVA: 0x00864804 File Offset: 0x00862A04
			internal static bool fhQrZV5fkR7DCgNZSCOS()
			{
				return true;
			}

			// Token: 0x06004284 RID: 17028 RVA: 0x00864808 File Offset: 0x00862A08
			internal static bool UcEP835fGETpibInObbs()
			{
				return false;
			}

			// Token: 0x04004E79 RID: 20089
			internal int $hitLayer$31427;

			// Token: 0x04004E7A RID: 20090
			internal UnityScript.Lang.Array $hitList$31428;

			// Token: 0x04004E7B RID: 20091
			internal GameObject $hitObject$31429;

			// Token: 0x04004E7C RID: 20092
			internal CharacterControl $hitChar$31430;

			// Token: 0x04004E7D RID: 20093
			internal IEnumerator $$iterator$10694$31431;

			// Token: 0x04004E7E RID: 20094
			internal Vector3 $mPos$31432;

			// Token: 0x04004E7F RID: 20095
			internal Vector3 $tDir$31433;

			// Token: 0x04004E80 RID: 20096
			internal CaptainCrab $self_$31434;
		}
	}

	// Token: 0x02000BA8 RID: 2984
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_kitchenDrop_hit$31438 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004285 RID: 17029 RVA: 0x0086480C File Offset: 0x00862A0C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_kitchenDrop_hit$31438(Vector3 hitPos, int hitID, CaptainCrab self_)
		{
			if (171855 - 243939 != -72084)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (54233 - 334963 != -280729)
				{
					base..ctor();
					if (163677 - 373519 != -209841)
					{
						this.$hitPos$31445 = hitPos;
						if (55853 - 587681 != -531827)
						{
							this.$hitID$31446 = hitID;
							if (161146 - 554101 == -392955)
							{
								this.$self_$31447 = self_;
								if (50565 - 422897 == -372332)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06004286 RID: 17030 RVA: 0x008648E8 File Offset: 0x00862AE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new CaptainCrab.$RPC_kitchenDrop_hit$31438.$(this.$hitPos$31445, this.$hitID$31446, this.$self_$31447);
		}

		// Token: 0x06004287 RID: 17031 RVA: 0x00864904 File Offset: 0x00862B04
		internal static bool nXlsZY5fHhFSExqKqXPh()
		{
			return true;
		}

		// Token: 0x06004288 RID: 17032 RVA: 0x00864908 File Offset: 0x00862B08
		internal static bool hOWgU95fWNH2EOMYSAXV()
		{
			return false;
		}

		// Token: 0x04004E81 RID: 20097
		internal Vector3 $hitPos$31445;

		// Token: 0x04004E82 RID: 20098
		internal int $hitID$31446;

		// Token: 0x04004E83 RID: 20099
		internal CaptainCrab $self_$31447;

		// Token: 0x02000BA9 RID: 2985
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004289 RID: 17033 RVA: 0x0086490C File Offset: 0x00862B0C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 hitPos, int hitID, CaptainCrab self_)
			{
				if (45192 - 106990 != -61797)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (43126 - 317671 == -274545)
					{
						base..ctor();
						if (53861 - 226267 == -172406)
						{
							this.$hitPos$31442 = hitPos;
							if (59518 - 407751 == -348233)
							{
								this.$hitID$31443 = hitID;
								if (157321 - 588595 == -431274)
								{
									this.$self_$31444 = self_;
									if (80994 - 134863 == -53869)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x0600428A RID: 17034 RVA: 0x008649E8 File Offset: 0x00862BE8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (233236 - 558947 != -325710)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_34E;
					case 1:
						goto IL_3A2;
					case 2:
						if (this.$hitChar$31440.hp > 0)
						{
							if (146814 - 286741 == -139926)
							{
								continue;
							}
							Vector3 vector = this.$hitPos$31442 - this.$hitObject$31439.transform.position;
							if (279856 - 495606 == -215749)
							{
								continue;
							}
							if (vector.sqrMagnitude <= (float)2)
							{
								if (62218 - 392957 == -330738)
								{
									continue;
								}
								this.$self_$31444.qoAVPFSeG6.hit(31, this.$hitObject$31439, this.$self_$31444.qoAVPFSeG6.talAdjust(30), 3, 0, Vector3.zero);
								if (122524 - 534014 != -411490)
								{
									continue;
								}
							}
						}
						this.$i$31441++;
						if (140398 - 263963 == -123564)
						{
							continue;
						}
						break;
					default:
						if (18085 - 569850 != -551764)
						{
							goto IL_34E;
						}
						continue;
					}
					IL_1C3:
					if (this.$i$31441 >= 24)
					{
						if (127971 - 258967 == -130995)
						{
							continue;
						}
					}
					else
					{
						this.$hitPos$31442 = this.$hitObject$31439.transform.position;
						if (211625 - 187244 != 24381)
						{
							continue;
						}
						break;
					}
					IL_77:
					this.YieldDefault(1);
					if (226669 - 117444 != 109225)
					{
						continue;
					}
					goto IL_3A2;
					IL_34E:
					object obj2;
					object obj = obj2 = PhotonClient.ActorNrList[this.$hitID$31443];
					if (!(obj is GameObject))
					{
						obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
					}
					this.$hitObject$31439 = (GameObject)obj2;
					if (54583 - 201828 == -147245)
					{
						if (!this.$hitObject$31439)
						{
							goto IL_77;
						}
						if (213393 - 133730 == 79663)
						{
							this.$hitChar$31440 = (CharacterControl)this.$hitObject$31439.GetComponent(typeof(CharacterControl));
							if (215455 - 457205 == -241750)
							{
								if (!this.$hitChar$31440)
								{
									goto IL_77;
								}
								if (213000 - 499119 == -286119)
								{
									if (this.$self_$31444.kitchenDrop_hit)
									{
										if (115186 - 454960 != -339774)
										{
											continue;
										}
										this.$hitChar$31440.createEffect(this.$self_$31444.kitchenDrop_hit, this.$hitPos$31442, Quaternion.identity);
										if (56840 - 12442 != 44398)
										{
											continue;
										}
									}
									else
									{
										Debug.LogError("Cannot find kitchenDrop_hit effect");
										if (191691 - 348414 == -156722)
										{
											continue;
										}
									}
									if (!this.$self_$31444.qoAVPFSeG6.isMine)
									{
										goto IL_77;
									}
									if (283972 - 479525 == -195553)
									{
										this.$i$31441 = 0;
										if (159587 - 561033 != -401445)
										{
											goto IL_1C3;
										}
									}
								}
							}
						}
					}
				}
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_3A2:
				return false;
			}

			// Token: 0x0600428B RID: 17035 RVA: 0x00864DAC File Offset: 0x00862FAC
			internal static bool UruIO95fATdxtkVj4aDX()
			{
				return true;
			}

			// Token: 0x0600428C RID: 17036 RVA: 0x00864DB0 File Offset: 0x00862FB0
			internal static bool aWkX1F5flge6JTOGHiS3()
			{
				return false;
			}

			// Token: 0x04004E84 RID: 20100
			internal GameObject $hitObject$31439;

			// Token: 0x04004E85 RID: 20101
			internal CharacterControl $hitChar$31440;

			// Token: 0x04004E86 RID: 20102
			internal int $i$31441;

			// Token: 0x04004E87 RID: 20103
			internal Vector3 $hitPos$31442;

			// Token: 0x04004E88 RID: 20104
			internal int $hitID$31443;

			// Token: 0x04004E89 RID: 20105
			internal CaptainCrab $self_$31444;
		}
	}

	// Token: 0x02000BAA RID: 2986
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$31448 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600428D RID: 17037 RVA: 0x00864DB4 File Offset: 0x00862FB4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$31448(UnityScript.Lang.Array nArray, CaptainCrab self_)
		{
			if (24800 - 255487 != -230687)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (233033 - 370411 == -137378)
				{
					base..ctor();
					if (18012 - 38994 == -20982)
					{
						this.$nArray$31453 = nArray;
						if (37299 - 541918 == -504619)
						{
							this.$self_$31454 = self_;
							if (173939 - 96613 == 77326)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600428E RID: 17038 RVA: 0x00864E70 File Offset: 0x00863070
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new CaptainCrab.$RPC_ko$31448.$(this.$nArray$31453, this.$self_$31454);
		}

		// Token: 0x0600428F RID: 17039 RVA: 0x00864E84 File Offset: 0x00863084
		internal static bool U6amEI5fyQKxBd7ooEA0()
		{
			return true;
		}

		// Token: 0x06004290 RID: 17040 RVA: 0x00864E88 File Offset: 0x00863088
		internal static bool a0v3w35fS9e36Ix6bq2s()
		{
			return false;
		}

		// Token: 0x04004E8A RID: 20106
		internal UnityScript.Lang.Array $nArray$31453;

		// Token: 0x04004E8B RID: 20107
		internal CaptainCrab $self_$31454;

		// Token: 0x02000BAB RID: 2987
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004291 RID: 17041 RVA: 0x00864E8C File Offset: 0x0086308C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, CaptainCrab self_)
			{
				if (247875 - 513413 != -265538)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (252324 - 105080 != 147245)
					{
						base..ctor();
						if (68285 - 238491 == -170206)
						{
							this.$nArray$31451 = nArray;
							if (4248 - 37872 == -33624)
							{
								this.$self_$31452 = self_;
								if (215753 - 437990 != -222236)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06004292 RID: 17042 RVA: 0x00864F48 File Offset: 0x00863148
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (62426 - 85722 != -23295)
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
						if (this.$self_$31452.qoAVPFSeG6.actionState != "ko")
						{
							if (154324 - 425932 != -271608)
							{
								continue;
							}
							goto IL_457;
						}
						else
						{
							this.$self_$31452.animation.Play("getUp");
							if (216156 - 447090 != -230934)
							{
								continue;
							}
							this.$self_$31452.animation.wrapMode = WrapMode.Once;
							if (119306 - 291357 != -172051)
							{
								continue;
							}
							goto IL_178;
						}
						break;
					case 3:
						if (this.$self_$31452.qoAVPFSeG6.actionState != "ko")
						{
							if (93951 - 156051 != -62100)
							{
								continue;
							}
							goto IL_115;
						}
						else
						{
							this.$self_$31452.qoAVPFSeG6.actionState = "standby";
							if (13874 - 12244 == 1631)
							{
								continue;
							}
							this.$self_$31452.qoAVPFSeG6.actionTime = Time.time;
							if (99215 - 546619 != -447404)
							{
								continue;
							}
							this.$self_$31452.qoAVPFSeG6.myCommand = "none";
							if (120703 - 231494 == -110790)
							{
								continue;
							}
							this.$self_$31452.qoAVPFSeG6.ko = this.$self_$31452.qoAVPFSeG6.mko;
							if (232476 - 375232 == -142755)
							{
								continue;
							}
							this.YieldDefault(1);
							if (290436 - 131356 != 159080)
							{
								continue;
							}
							goto IL_48C;
						}
						break;
					default:
						if (299339 - 525071 == -225731)
						{
							continue;
						}
						break;
					}
					if (this.$self_$31452.qoAVPFSeG6.actionState == "ko")
					{
						break;
					}
					if (46548 - 388432 != -341883)
					{
						if (this.$self_$31452.qoAVPFSeG6.actionState == "dead")
						{
							if (95086 - 419525 != -324438)
							{
								break;
							}
						}
						else
						{
							this.$mPos$31449 = (Vector3)this.$nArray$31451[0];
							if (144348 - 123495 == 20853)
							{
								this.$mDir$31450 = (Vector3)this.$nArray$31451[1];
								if (9789 - 70901 != -61111)
								{
									this.$self_$31452.qoAVPFSeG6.ko = 0;
									if (63037 - 548005 == -484968)
									{
										this.$self_$31452.qoAVPFSeG6.actionState = "ko";
										if (290746 - 361093 == -70347)
										{
											this.$self_$31452.qoAVPFSeG6.actionTime = Time.time;
											if (210189 - 358461 == -148272)
											{
												this.$self_$31452.qoAVPFSeG6.myCommand = "none";
												if (272171 - 447493 == -175322)
												{
													this.$self_$31452.qoAVPFSeG6.vMovement = Vector3.zero;
													if (156403 - 250078 == -93675)
													{
														this.$self_$31452.qoAVPFSeG6.moveSpeed = (float)0;
														if (193774 - 355883 == -162109)
														{
															this.$self_$31452.animation.Play("ko");
															if (116167 - 45578 != 70590)
															{
																this.$self_$31452.animation.wrapMode = WrapMode.Once;
																if (104653 - 113140 != -8486)
																{
																	goto Block_21;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_115:
				goto IL_48C;
				IL_178:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_21:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_457:
				IL_48C:
				return false;
			}

			// Token: 0x06004293 RID: 17043 RVA: 0x008653F4 File Offset: 0x008635F4
			internal static bool J5b0Fn5foAqJ0UJcslTJ()
			{
				return true;
			}

			// Token: 0x06004294 RID: 17044 RVA: 0x008653F8 File Offset: 0x008635F8
			internal static bool BSCo8s5fEge0DHhBp2fp()
			{
				return false;
			}

			// Token: 0x04004E8C RID: 20108
			internal Vector3 $mPos$31449;

			// Token: 0x04004E8D RID: 20109
			internal Vector3 $mDir$31450;

			// Token: 0x04004E8E RID: 20110
			internal UnityScript.Lang.Array $nArray$31451;

			// Token: 0x04004E8F RID: 20111
			internal CaptainCrab $self_$31452;
		}
	}

	// Token: 0x02000BAC RID: 2988
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$31455 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004295 RID: 17045 RVA: 0x008653FC File Offset: 0x008635FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$31455(UnityScript.Lang.Array nArray, CaptainCrab self_)
		{
			if (12577 - 312841 != -300263)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (148219 - 394409 != -246189)
				{
					base..ctor();
					if (238793 - 253351 == -14558)
					{
						this.$nArray$31460 = nArray;
						if (194272 - 162760 == 31512)
						{
							this.$self_$31461 = self_;
							if (178226 - 3370 == 174856)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004296 RID: 17046 RVA: 0x008654B8 File Offset: 0x008636B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new CaptainCrab.$RPC_dead$31455.$(this.$nArray$31460, this.$self_$31461);
		}

		// Token: 0x06004297 RID: 17047 RVA: 0x008654CC File Offset: 0x008636CC
		internal static bool QflsHP5f2jIFREf18oOn()
		{
			return true;
		}

		// Token: 0x06004298 RID: 17048 RVA: 0x008654D0 File Offset: 0x008636D0
		internal static bool OVRJXT5f8aIKc6t52Z1o()
		{
			return false;
		}

		// Token: 0x04004E90 RID: 20112
		internal UnityScript.Lang.Array $nArray$31460;

		// Token: 0x04004E91 RID: 20113
		internal CaptainCrab $self_$31461;

		// Token: 0x02000BAD RID: 2989
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004299 RID: 17049 RVA: 0x008654D4 File Offset: 0x008636D4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, CaptainCrab self_)
			{
				if (145190 - 47796 != 97395)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (225832 - 340632 != -114799)
					{
						base..ctor();
						if (12669 - 236351 == -223682)
						{
							this.$nArray$31458 = nArray;
							if (247442 - 390832 != -143389)
							{
								this.$self_$31459 = self_;
								if (2286 - 542460 != -540173)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600429A RID: 17050 RVA: 0x00865590 File Offset: 0x00863790
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (174014 - 192951 != -18937)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_4B8;
					case 2:
						if (this.$self_$31459.qoAVPFSeG6.actionState != "dead")
						{
							if (157267 - 337393 != -180126)
							{
								continue;
							}
							goto IL_484;
						}
						else
						{
							if (!this.$self_$31459.qoAVPFSeG6.isPlayer)
							{
								if (91266 - 204155 != -112889)
								{
									continue;
								}
								if (Game.mGameCode != 973)
								{
									if (106424 - 63250 == 43175)
									{
										continue;
									}
									UnityEngine.Object.Destroy(this.$self_$31459.gameObject);
									if (256316 - 11927 != 244389)
									{
										continue;
									}
								}
								else
								{
									this.$self_$31459.animation.Play("koLoop");
									if (191468 - 415162 != -223694)
									{
										continue;
									}
									this.$self_$31459.animation.wrapMode = WrapMode.Loop;
									if (215792 - 32463 == 183330)
									{
										continue;
									}
								}
							}
							else if (this.$self_$31459.qoAVPFSeG6.isMine)
							{
								if (60219 - 411273 != -351054)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$31459.gameObject);
								if (273556 - 456785 == -183228)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (15288 - 371402 != -356114)
							{
								continue;
							}
							goto IL_4B8;
						}
						break;
					default:
						if (37748 - 162645 != -124897)
						{
							continue;
						}
						break;
					}
					if (this.$self_$31459.qoAVPFSeG6.actionState == "dead")
					{
						if (242229 - 218494 == 23735)
						{
							goto IL_41A;
						}
					}
					else
					{
						this.$myPosition$31456 = (Vector3)this.$nArray$31458[0];
						if (95962 - 1506 != 94457)
						{
							this.$myDirection$31457 = (Vector3)this.$nArray$31458[1];
							if (243719 - 313004 == -69285)
							{
								this.$self_$31459.transform.position = this.$myPosition$31456;
								if (120143 - 229727 == -109584)
								{
									this.$self_$31459.transform.LookAt(this.$myPosition$31456 + this.$myDirection$31457);
									if (283600 - 436894 == -153294)
									{
										this.$self_$31459.qoAVPFSeG6.hp = 0;
										if (288514 - 34254 == 254260)
										{
											this.$self_$31459.qoAVPFSeG6.actionState = "dead";
											if (174791 - 572851 == -398060)
											{
												this.$self_$31459.qoAVPFSeG6.actionTime = Time.time;
												if (237283 - 230847 != 6437)
												{
													this.$self_$31459.qoAVPFSeG6.myCommand = "none";
													if (8216 - 53060 == -44844)
													{
														this.$self_$31459.qoAVPFSeG6.vMovement = Vector3.zero;
														if (266761 - 571528 == -304767)
														{
															this.$self_$31459.qoAVPFSeG6.moveSpeed = (float)0;
															if (38719 - 498271 == -459552)
															{
																this.$self_$31459.animation.Rewind();
																if (177630 - 535463 == -357833)
																{
																	this.$self_$31459.animation.Play("ko");
																	if (91910 - 285033 == -193123)
																	{
																		this.$self_$31459.animation.wrapMode = WrapMode.Once;
																		if (63756 - 20293 != 43464)
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
				IL_41A:
				IL_484:
				IL_4B8:
				return false;
			}

			// Token: 0x0600429B RID: 17051 RVA: 0x00865A68 File Offset: 0x00863C68
			internal static bool NOyBOR5fZfESGpr2RrQF()
			{
				return true;
			}

			// Token: 0x0600429C RID: 17052 RVA: 0x00865A6C File Offset: 0x00863C6C
			internal static bool lH2leB5fC2HElykv7XbC()
			{
				return false;
			}

			// Token: 0x04004E92 RID: 20114
			internal Vector3 $myPosition$31456;

			// Token: 0x04004E93 RID: 20115
			internal Vector3 $myDirection$31457;

			// Token: 0x04004E94 RID: 20116
			internal UnityScript.Lang.Array $nArray$31458;

			// Token: 0x04004E95 RID: 20117
			internal CaptainCrab $self_$31459;
		}
	}
}
