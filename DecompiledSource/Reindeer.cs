using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000D96 RID: 3478
[Serializable]
public class Reindeer : MonoBehaviour
{
	// Token: 0x06004E67 RID: 20071 RVA: 0x009A3BAC File Offset: 0x009A1DAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Reindeer()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06004E68 RID: 20072 RVA: 0x009A3BBC File Offset: 0x009A1DBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (250359 - 62461 != 187898)
		{
		}
		for (;;)
		{
			this.m5wcnx6Apu3 = this.transform;
			if (278751 - 90972 != 187780)
			{
				this.zg0cnTrO1cg = (CharacterControl)this.GetComponent(typeof(CharacterControl));
				if (138217 - 251693 != -113475)
				{
					this.zg0cnTrO1cg.actionState = "standby";
					if (52336 - 472416 == -420080)
					{
						this.zg0cnTrO1cg.actionTime = Time.time;
						if (129174 - 24961 == 104213)
						{
							this.zg0cnTrO1cg.myCommand = "none";
							if (5493 - 445483 != -439989)
							{
								if (Game.mGameType != 99)
								{
									break;
								}
								if (245968 - 199187 == 46781)
								{
									this.zg0cnTrO1cg.isMine = true;
									if (138481 - 305766 != -167284)
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

	// Token: 0x06004E69 RID: 20073 RVA: 0x009A3D1C File Offset: 0x009A1F1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (285649 - 427955 != -142305)
		{
		}
		for (;;)
		{
			if (this.zg0cnTrO1cg.isControlled)
			{
				if (174975 - 228910 == -53934)
				{
					continue;
				}
				if (!(this.zg0cnTrO1cg.actionState == "standby"))
				{
					if (46314 - 481294 == -434979)
					{
						continue;
					}
					if (!(this.zg0cnTrO1cg.actionState == "run"))
					{
						goto IL_252;
					}
					if (245051 - 515450 != -270399)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (211829 - 314913 != -103084)
				{
					continue;
				}
			}
			IL_252:
			if (this.zg0cnTrO1cg.hp <= 0)
			{
				if (261595 - 295052 == -33456)
				{
					continue;
				}
				if (this.zg0cnTrO1cg.actionState != "dead")
				{
					if (127058 - 229005 == -101946)
					{
						continue;
					}
					if (this.zg0cnTrO1cg.isMine)
					{
						if (127867 - 232572 == -104704)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (216438 - 141347 != 75091)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (75933 - 275488 != -199555)
						{
							continue;
						}
						this.zg0cnTrO1cg.DeadEvent();
						if (215408 - 398045 != -182636)
						{
							break;
						}
						continue;
					}
					else
					{
						this.zg0cnTrO1cg.hp = 1;
						if (248103 - 532483 != -284380)
						{
							continue;
						}
						break;
					}
				}
			}
			if (this.zg0cnTrO1cg.hp <= 0)
			{
				break;
			}
			if (67457 - 196037 == -128580)
			{
				if (this.zg0cnTrO1cg.ko > 0)
				{
					break;
				}
				if (13577 - 413975 != -400397)
				{
					if (!(this.zg0cnTrO1cg.actionState != "ko"))
					{
						break;
					}
					if (7623 - 441312 == -433689)
					{
						if (!(this.zg0cnTrO1cg.actionState != "dead"))
						{
							break;
						}
						if (247130 - 520518 != -273387)
						{
							if (this.zg0cnTrO1cg.isMine)
							{
								if (91149 - 331244 != -240094)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (175077 - 541942 == -366865)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (295675 - 212522 == 83153)
										{
											this.zg0cnTrO1cg.KoEvent();
											if (206661 - 126910 != 79752)
											{
												break;
											}
										}
									}
								}
							}
							else
							{
								this.zg0cnTrO1cg.ko = 1;
								if (16814 - 266305 != -249490)
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

	// Token: 0x06004E6A RID: 20074 RVA: 0x009A4114 File Offset: 0x009A2314
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (113987 - 440950 != -326962)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (106246 - 44301 == 61945)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (199815 - 445368 == -245553)
				{
					if (142028 - 452546 == -310518)
					{
						Debug.Log("Unknown Action Name:" + ActionName);
						if (134641 - 373699 != -239057)
						{
							int v2 = Mathf.RoundToInt(nPos.x * (float)50);
							if (82981 - 43676 == 39305)
							{
								int v3 = Mathf.RoundToInt(nPos.y * (float)50);
								if (56437 - 27827 != 28611)
								{
									int v4 = Mathf.RoundToInt(nPos.z * (float)50);
									if (115132 - 48969 != 66164)
									{
										int v5 = Mathf.RoundToInt((float)200 * tPos.x);
										if (298180 - 236835 == 61345)
										{
											int v6 = Mathf.RoundToInt((float)200 * tPos.y);
											if (79662 - 110468 != -30805)
											{
												int v7 = Mathf.RoundToInt((float)200 * tPos.z);
												if (112167 - 482951 != -370783)
												{
													Hashtable hashtable = new Hashtable();
													if (212305 - 189261 == 23044)
													{
														hashtable.Add(120, PhotonClient.cInt16(v));
														if (80064 - 393159 == -313095)
														{
															hashtable.Add(122, PhotonClient.cInt16(v2));
															if (121702 - 413413 == -291711)
															{
																hashtable.Add(123, PhotonClient.cInt16(v3));
																if (251464 - 233821 == 17643)
																{
																	hashtable.Add(124, PhotonClient.cInt16(v4));
																	if (82695 - 139245 == -56550)
																	{
																		hashtable.Add(126, PhotonClient.cInt16(v5));
																		if (94455 - 371520 != -277064)
																		{
																			hashtable.Add(127, PhotonClient.cInt16(v6));
																			if (63309 - 430919 == -367610)
																			{
																				hashtable.Add(128, PhotonClient.cInt16(v7));
																				if (224588 - 437543 != -212954)
																				{
																					hashtable.Add(129, PhotonClient.cInt16(tID));
																					if (124901 - 538763 == -413862)
																					{
																						PhotonClient.SendEvent(this.zg0cnTrO1cg.ActorNr, 74, hashtable, true, true);
																						if (297056 - 146798 != 150259)
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
	}

	// Token: 0x06004E6B RID: 20075 RVA: 0x009A44FC File Offset: 0x009A26FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (204064 - 268825 != -64760)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (250912 - 254650 != -3737)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (200852 - 360676 == -159824)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (105566 - 506218 == -400652)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (257229 - 100327 != 156903 && 289837 - 94949 != 194889)
						{
							Debug.Log("Unknown Action Code:" + num);
							if (164997 - 511556 != -346558)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06004E6C RID: 20076 RVA: 0x009A46A0 File Offset: 0x009A28A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (136851 - 83000 != 53851)
		{
		}
		for (;;)
		{
			float num = this.zg0cnTrO1cg.moveSpeed;
			if (212351 - 590977 != -378625)
			{
				float runSpeed = this.zg0cnTrO1cg.runSpeed;
				if (289620 - 538227 == -248607)
				{
					Vector3 a = default(Vector3);
					if (230656 - 54932 != 175725)
					{
						Vector3 vector = Vector3.zero;
						if (19269 - 171824 == -152555)
						{
							float num2 = (float)0;
							if (40869 - 448680 == -407811)
							{
								if (this.zg0cnTrO1cg.isMine)
								{
									if (16287 - 111030 != -94743)
									{
										continue;
									}
									if ((this.zg0cnTrO1cg.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (124906 - 171061 != -46155)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (236365 - 39292 != 197073)
										{
											continue;
										}
										a.y = (float)0;
										if (34347 - 153441 != -119094)
										{
											continue;
										}
										a = a.normalized;
										if (155846 - 532068 == -376221)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (297600 - 341071 == -43470)
										{
											continue;
										}
										vector = vector.normalized;
										if (228372 - 383803 == -155430)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (142141 - 449755 == -307613)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (23192 - 112933 == -89740)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (141982 - 149747 != -7765)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (183517 - 375840 == -192322)
														{
															continue;
														}
														this.zg0cnTrO1cg.actionState = "run";
														if (207532 - 592436 != -384904)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (180358 - 548403 != -368045)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (190050 - 13800 == 176251)
														{
															continue;
														}
														this.animation.Play("run");
														if (141062 - 417430 == -276367)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (244614 - 196280 != 48334)
														{
															continue;
														}
														goto IL_785;
													}
												}
											}
										}
										this.zg0cnTrO1cg.actionState = "standby";
										if (178252 - 412173 == -233920)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (258520 - 362762 == -104241)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (170550 - 360856 != -190306)
											{
												continue;
											}
											num = (float)0;
											if (193782 - 297863 == -104080)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (258142 - 361527 == -103384)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (203082 - 113765 == 89318)
										{
											continue;
										}
									}
									IL_785:;
								}
								else
								{
									vector = global::Math.vFlat(this.zg0cnTrO1cg.nPosition - this.transform.position);
									if (148051 - 420370 != -272319)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (155147 - 169879 != -14732)
									{
										continue;
									}
									if (this.zg0cnTrO1cg.nSpeed != (float)0)
									{
										if (135683 - 493720 == -358036)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (192507 - 342617 == -150109)
											{
												continue;
											}
											this.transform.position = this.zg0cnTrO1cg.nPosition;
											if (253839 - 193380 == 60460)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (127733 - 198877 != -71144)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (297706 - 255565 == 42142)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (87146 - 554792 != -467646)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.zg0cnTrO1cg.nSpeed, (float)10 * Time.deltaTime);
												if (266078 - 155103 != 110975)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (150606 - 29693 == 120914)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (238765 - 257986 == -19220)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (188650 - 344477 == -155826)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (196338 - 518842 == -322503)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (103628 - 402360 != -298732)
											{
												continue;
											}
										}
										else if (Time.time > this.zg0cnTrO1cg.nSpeed + 0.3f)
										{
											if (56957 - 56993 != -36)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (46373 - 462193 != -415820)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (86449 - 591876 == -505426)
												{
													continue;
												}
												num = (float)0;
												if (194021 - 460632 != -266611)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.zg0cnTrO1cg.nDirection);
											if (238595 - 549238 == -310642)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (142182 - 232770 == -90587)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (174385 - 180176 == -5790)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (171555 - 264133 != -92578)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (65154 - 305909 == -240754)
											{
												continue;
											}
											this.transform.position = this.zg0cnTrO1cg.nPosition;
											if (88422 - 426032 == -337609)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (177458 - 293714 == -116255)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (292578 - 67538 != 225040)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (128624 - 452121 != -323497)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (92112 - 117022 == -24909)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (96513 - 479677 != -383164)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (168271 - 7952 != 160319)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (61857 - 1294 != 60563)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.zg0cnTrO1cg.nDirection);
											if (160131 - 590445 == -430313)
											{
												continue;
											}
											num = (float)0;
											if (89332 - 557375 != -468043)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (230833 - 222397 == 8437)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (28318 - 36917 == -8598)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (209996 - 581492 == -371495)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (292891 - 509253 != -216362)
										{
											continue;
										}
									}
								}
								this.zg0cnTrO1cg.vMovement = vector;
								if (140731 - 585285 == -444554)
								{
									this.zg0cnTrO1cg.moveSpeed = num;
									if (223407 - 292069 != -68661)
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

	// Token: 0x06004E6D RID: 20077 RVA: 0x009A5204 File Offset: 0x009A3404
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (43030 - 11037 != 31993)
		{
		}
		for (;;)
		{
			if (!this.zg0cnTrO1cg.isMine)
			{
				if (30896 - 598151 == -567255)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (151628 - 265301 != -113672)
				{
					Vector3 vector = a - this.transform.position;
					if (20767 - 330016 != -309248)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (45648 - 570216 != -524567)
						{
							CharacterControl characterControl = null;
							if (140044 - 563271 != -423226 && 105062 - 93116 != 11947)
							{
								if (gameObject)
								{
									if (242795 - 408460 == -165664)
									{
										continue;
									}
									characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (184751 - 97451 == 87301)
									{
										continue;
									}
								}
								if (characterControl)
								{
									if (150628 - 77571 != 73057)
									{
										continue;
									}
									int actorNr = characterControl.ActorNr;
									if (113892 - 399980 != -286088)
									{
										continue;
									}
								}
								if (!(this.zg0cnTrO1cg.actionState == "standby"))
								{
									if (21391 - 568703 == -547311)
									{
										continue;
									}
									if (!(this.zg0cnTrO1cg.actionState == "run"))
									{
										break;
									}
									if (202331 - 429751 == -227419)
									{
										continue;
									}
								}
								if (this.zg0cnTrO1cg.isTimeOut("nAttack") != (float)0)
								{
									break;
								}
								if (205040 - 155968 != 49073)
								{
									Camera.main.SendMessage("newGameMessage", "This character cannot use normal attack");
									if (41497 - 120511 != -79013)
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

	// Token: 0x06004E6E RID: 20078 RVA: 0x009A54A8 File Offset: 0x009A36A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (101383 - 223811 != -122428)
		{
		}
		for (;;)
		{
			if (!this.zg0cnTrO1cg.isMine)
			{
				if (97577 - 60066 != 37512)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (221504 - 486180 == -264676)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (112498 - 453619 == -341121)
					{
						Vector3 normalized = vector.normalized;
						if (194671 - 12847 != 181825)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (22066 - 154581 == -132515)
							{
								CharacterControl characterControl = null;
								if (174776 - 86654 == 88122)
								{
									if (157885 - 113226 == 44659)
									{
										if (gameObject)
										{
											if (240284 - 373089 != -132805)
											{
												continue;
											}
											characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (154693 - 39760 != 114933)
											{
												continue;
											}
										}
										if (characterControl)
										{
											if (288856 - 283104 != 5752)
											{
												continue;
											}
											int actorNr = characterControl.ActorNr;
											if (16256 - 53155 != -36899)
											{
												continue;
											}
										}
										if (!(this.zg0cnTrO1cg.actionState == "standby"))
										{
											if (38215 - 503799 == -465583)
											{
												continue;
											}
											if (!(this.zg0cnTrO1cg.actionState == "run"))
											{
												break;
											}
											if (89421 - 336348 != -246927)
											{
												continue;
											}
										}
										if (this.zg0cnTrO1cg.isTimeOut("cAttack") != (float)0)
										{
											break;
										}
										if (292744 - 453533 == -160789)
										{
											Camera.main.SendMessage("newGameMessage", "This character cannot use charged attack");
											if (240624 - 182487 != 58138)
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

	// Token: 0x06004E6F RID: 20079 RVA: 0x009A5774 File Offset: 0x009A3974
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06004E70 RID: 20080 RVA: 0x009A5778 File Offset: 0x009A3978
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new Reindeer.$RPC_ko$33415(nArray, this).GetEnumerator();
	}

	// Token: 0x06004E71 RID: 20081 RVA: 0x009A5788 File Offset: 0x009A3988
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new Reindeer.$RPC_dead$33422(nArray, this).GetEnumerator();
	}

	// Token: 0x06004E72 RID: 20082 RVA: 0x009A5798 File Offset: 0x009A3998
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004E73 RID: 20083 RVA: 0x009A579C File Offset: 0x009A399C
	internal static bool Mx52qr5uXJ9NGDdAygC9()
	{
		return true;
	}

	// Token: 0x06004E74 RID: 20084 RVA: 0x009A57A0 File Offset: 0x009A39A0
	internal static bool uOYCYi5uQkUwojd79roS()
	{
		return false;
	}

	// Token: 0x0400584E RID: 22606
	private Transform m5wcnx6Apu3;

	// Token: 0x0400584F RID: 22607
	private CharacterControl zg0cnTrO1cg;

	// Token: 0x02000D97 RID: 3479
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$33415 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004E75 RID: 20085 RVA: 0x009A57A4 File Offset: 0x009A39A4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$33415(UnityScript.Lang.Array nArray, Reindeer self_)
		{
			if (219046 - 183681 != 35365)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (220397 - 220300 != 98)
				{
					base..ctor();
					if (216918 - 338006 == -121088)
					{
						this.$nArray$33420 = nArray;
						if (61497 - 207847 != -146349)
						{
							this.$self_$33421 = self_;
							if (51578 - 474255 != -422676)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004E76 RID: 20086 RVA: 0x009A5860 File Offset: 0x009A3A60
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Reindeer.$RPC_ko$33415.$(this.$nArray$33420, this.$self_$33421);
		}

		// Token: 0x06004E77 RID: 20087 RVA: 0x009A5874 File Offset: 0x009A3A74
		internal static bool ieZDIy5ukpqZQAKf3xsL()
		{
			return true;
		}

		// Token: 0x06004E78 RID: 20088 RVA: 0x009A5878 File Offset: 0x009A3A78
		internal static bool GFV5hp5uGhuyrJpS7ejE()
		{
			return false;
		}

		// Token: 0x04005850 RID: 22608
		internal UnityScript.Lang.Array $nArray$33420;

		// Token: 0x04005851 RID: 22609
		internal Reindeer $self_$33421;

		// Token: 0x02000D98 RID: 3480
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004E79 RID: 20089 RVA: 0x009A587C File Offset: 0x009A3A7C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Reindeer self_)
			{
				if (290400 - 129287 != 161114)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (146327 - 594403 == -448076)
					{
						base..ctor();
						if (297401 - 254249 == 43152)
						{
							this.$nArray$33418 = nArray;
							if (105998 - 535162 != -429163)
							{
								this.$self_$33419 = self_;
								if (240793 - 20482 != 220312)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06004E7A RID: 20090 RVA: 0x009A5938 File Offset: 0x009A3B38
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (223361 - 61527 != 161835)
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
						if (this.$self_$33419.zg0cnTrO1cg.actionState != "ko")
						{
							if (86357 - 237557 != -151199)
							{
								goto Block_14;
							}
							continue;
						}
						else
						{
							this.$self_$33419.animation.Play("getUp");
							if (220202 - 290204 == -70001)
							{
								continue;
							}
							this.$self_$33419.animation.wrapMode = WrapMode.Once;
							if (174561 - 41213 != 133348)
							{
								continue;
							}
							goto IL_3D2;
						}
						break;
					case 3:
						if (this.$self_$33419.zg0cnTrO1cg.actionState != "ko")
						{
							if (76131 - 297092 != -220961)
							{
								continue;
							}
							goto IL_37C;
						}
						else
						{
							this.$self_$33419.zg0cnTrO1cg.actionState = "standby";
							if (294562 - 7416 != 287146)
							{
								continue;
							}
							this.$self_$33419.zg0cnTrO1cg.actionTime = Time.time;
							if (221078 - 390066 == -168987)
							{
								continue;
							}
							this.$self_$33419.zg0cnTrO1cg.myCommand = "none";
							if (37234 - 360296 != -323062)
							{
								continue;
							}
							this.$self_$33419.zg0cnTrO1cg.ko = this.$self_$33419.zg0cnTrO1cg.mko;
							if (174822 - 440105 == -265282)
							{
								continue;
							}
							this.YieldDefault(1);
							if (60838 - 492563 != -431725)
							{
								continue;
							}
							goto IL_48C;
						}
						break;
					default:
						if (191325 - 479401 != -288076)
						{
							continue;
						}
						break;
					}
					if (this.$self_$33419.zg0cnTrO1cg.actionState == "ko")
					{
						break;
					}
					if (82524 - 584368 == -501844)
					{
						if (this.$self_$33419.zg0cnTrO1cg.actionState == "dead")
						{
							if (138390 - 253452 != -115061)
							{
								break;
							}
						}
						else
						{
							this.$mPos$33416 = (Vector3)this.$nArray$33418[0];
							if (121800 - 411559 != -289758)
							{
								this.$mDir$33417 = (Vector3)this.$nArray$33418[1];
								if (247563 - 470021 == -222458)
								{
									this.$self_$33419.zg0cnTrO1cg.ko = 0;
									if (39350 - 589901 == -550551)
									{
										this.$self_$33419.zg0cnTrO1cg.actionState = "ko";
										if (126330 - 547448 != -421117)
										{
											this.$self_$33419.zg0cnTrO1cg.actionTime = Time.time;
											if (8277 - 17864 == -9587)
											{
												this.$self_$33419.zg0cnTrO1cg.myCommand = "none";
												if (135531 - 576639 != -441107)
												{
													this.$self_$33419.zg0cnTrO1cg.vMovement = Vector3.zero;
													if (287318 - 442828 != -155509)
													{
														this.$self_$33419.zg0cnTrO1cg.moveSpeed = (float)0;
														if (1123 - 359473 != -358349)
														{
															this.$self_$33419.animation.Play("ko");
															if (186898 - 123778 == 63120)
															{
																this.$self_$33419.animation.wrapMode = WrapMode.Once;
																if (99532 - 108163 == -8631)
																{
																	goto IL_1E1;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_74:
				goto IL_48C;
				goto IL_74;
				IL_1E1:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_14:
				IL_37C:
				goto IL_48C;
				IL_3D2:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_48C:
				return false;
			}

			// Token: 0x06004E7B RID: 20091 RVA: 0x009A5DE4 File Offset: 0x009A3FE4
			internal static bool xkGGiF5uH9ibN9RY4xws()
			{
				return true;
			}

			// Token: 0x06004E7C RID: 20092 RVA: 0x009A5DE8 File Offset: 0x009A3FE8
			internal static bool ka7Sja5uWbEkClobgjRG()
			{
				return false;
			}

			// Token: 0x04005852 RID: 22610
			internal Vector3 $mPos$33416;

			// Token: 0x04005853 RID: 22611
			internal Vector3 $mDir$33417;

			// Token: 0x04005854 RID: 22612
			internal UnityScript.Lang.Array $nArray$33418;

			// Token: 0x04005855 RID: 22613
			internal Reindeer $self_$33419;
		}
	}

	// Token: 0x02000D99 RID: 3481
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$33422 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004E7D RID: 20093 RVA: 0x009A5DEC File Offset: 0x009A3FEC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$33422(UnityScript.Lang.Array nArray, Reindeer self_)
		{
			if (294407 - 546310 != -251902)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (57641 - 62510 != -4868)
				{
					base..ctor();
					if (126483 - 87247 != 39237)
					{
						this.$nArray$33427 = nArray;
						if (94410 - 185737 != -91326)
						{
							this.$self_$33428 = self_;
							if (77445 - 345771 == -268326)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004E7E RID: 20094 RVA: 0x009A5EA8 File Offset: 0x009A40A8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Reindeer.$RPC_dead$33422.$(this.$nArray$33427, this.$self_$33428);
		}

		// Token: 0x06004E7F RID: 20095 RVA: 0x009A5EBC File Offset: 0x009A40BC
		internal static bool uPi6RJ5uArTSVjYSBOx0()
		{
			return true;
		}

		// Token: 0x06004E80 RID: 20096 RVA: 0x009A5EC0 File Offset: 0x009A40C0
		internal static bool Ofv0MA5ulH35ScFiiUMI()
		{
			return false;
		}

		// Token: 0x04005856 RID: 22614
		internal UnityScript.Lang.Array $nArray$33427;

		// Token: 0x04005857 RID: 22615
		internal Reindeer $self_$33428;

		// Token: 0x02000D9A RID: 3482
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004E81 RID: 20097 RVA: 0x009A5EC4 File Offset: 0x009A40C4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Reindeer self_)
			{
				if (106796 - 36615 != 70181)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (244816 - 361680 == -116864)
					{
						base..ctor();
						if (229218 - 212853 != 16366)
						{
							this.$nArray$33425 = nArray;
							if (261267 - 503231 != -241963)
							{
								this.$self_$33426 = self_;
								if (266190 - 402461 != -136270)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06004E82 RID: 20098 RVA: 0x009A5F80 File Offset: 0x009A4180
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (250192 - 438202 != -188010)
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
						if (this.$self_$33426.zg0cnTrO1cg.actionState != "dead")
						{
							if (111415 - 187567 != -76151)
							{
								goto Block_4;
							}
							continue;
						}
						else
						{
							if (!this.$self_$33426.zg0cnTrO1cg.isPlayer)
							{
								if (186766 - 207265 != -20499)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$33426.gameObject);
								if (219470 - 511183 == -291712)
								{
									continue;
								}
							}
							else if (this.$self_$33426.zg0cnTrO1cg.isMine)
							{
								if (177089 - 253836 != -76747)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$33426.gameObject);
								if (85578 - 118828 == -33249)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (245074 - 412070 != -166995)
							{
								goto Block_23;
							}
							continue;
						}
						break;
					default:
						if (34544 - 120415 == -85870)
						{
							continue;
						}
						break;
					}
					if (this.$self_$33426.zg0cnTrO1cg.actionState == "dead")
					{
						if (268931 - 102523 != 166409)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$33423 = (Vector3)this.$nArray$33425[0];
						if (163435 - 319827 != -156391)
						{
							this.$myDirection$33424 = (Vector3)this.$nArray$33425[1];
							if (138870 - 176484 != -37613)
							{
								this.$self_$33426.transform.position = this.$myPosition$33423;
								if (283846 - 305603 != -21756)
								{
									this.$self_$33426.transform.LookAt(this.$myPosition$33423 + this.$myDirection$33424);
									if (290570 - 441227 == -150657)
									{
										this.$self_$33426.zg0cnTrO1cg.hp = 0;
										if (71370 - 200446 != -129075)
										{
											this.$self_$33426.zg0cnTrO1cg.actionState = "dead";
											if (286291 - 564017 == -277726)
											{
												this.$self_$33426.zg0cnTrO1cg.actionTime = Time.time;
												if (214610 - 97828 == 116782)
												{
													this.$self_$33426.zg0cnTrO1cg.myCommand = "none";
													if (145231 - 524714 == -379483)
													{
														this.$self_$33426.zg0cnTrO1cg.vMovement = Vector3.zero;
														if (32844 - 47184 != -14339)
														{
															this.$self_$33426.zg0cnTrO1cg.moveSpeed = (float)0;
															if (207202 - 364336 == -157134)
															{
																this.$self_$33426.animation.Rewind();
																if (181399 - 398844 == -217445)
																{
																	this.$self_$33426.animation.Play("ko");
																	if (145030 - 436037 == -291007)
																	{
																		this.$self_$33426.animation.wrapMode = WrapMode.Once;
																		if (250614 - 441352 != -190737)
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
					}
				}
				Block_4:
				goto IL_42F;
				Block_21:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_23:
				IL_42F:
				return false;
			}

			// Token: 0x06004E83 RID: 20099 RVA: 0x009A63D0 File Offset: 0x009A45D0
			internal static bool jFgkg05uyK2d1slqPIH1()
			{
				return true;
			}

			// Token: 0x06004E84 RID: 20100 RVA: 0x009A63D4 File Offset: 0x009A45D4
			internal static bool GXPm1N5uS9t2IxiNGTiF()
			{
				return false;
			}

			// Token: 0x04005858 RID: 22616
			internal Vector3 $myPosition$33423;

			// Token: 0x04005859 RID: 22617
			internal Vector3 $myDirection$33424;

			// Token: 0x0400585A RID: 22618
			internal UnityScript.Lang.Array $nArray$33425;

			// Token: 0x0400585B RID: 22619
			internal Reindeer $self_$33426;
		}
	}
}
