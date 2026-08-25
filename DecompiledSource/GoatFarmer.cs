using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000C43 RID: 3139
[Serializable]
public class GoatFarmer : MonoBehaviour
{
	// Token: 0x06004630 RID: 17968 RVA: 0x008C6694 File Offset: 0x008C4894
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GoatFarmer()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06004631 RID: 17969 RVA: 0x008C66A4 File Offset: 0x008C48A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (278838 - 597464 != -318625)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (53711 - 174520 != -120808)
			{
				this.mChar.actionState = "standby";
				if (265295 - 236426 == 28869)
				{
					this.mChar.actionTime = Time.time;
					if (282378 - 16303 == 266075)
					{
						this.mChar.myCommand = "none";
						if (286117 - 416536 != -130418)
						{
							if (Game.mGameType != 99)
							{
								break;
							}
							if (214966 - 285636 != -70669)
							{
								this.mChar.isMine = true;
								if (76774 - 280227 != -203452)
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

	// Token: 0x06004632 RID: 17970 RVA: 0x008C67DC File Offset: 0x008C49DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (88073 - 490336 != -402263)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (212077 - 453473 == -241395)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (252979 - 386319 != -133340)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_10C;
					}
					if (207257 - 241441 != -34184)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (147075 - 44188 == 102888)
				{
					continue;
				}
			}
			IL_10C:
			if (this.mChar.hp <= 0)
			{
				if (142803 - 31000 == 111804)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (196749 - 257 != 196492)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (64423 - 418246 != -353823)
						{
							continue;
						}
						statusClass status = this.mChar.getStatus("autoLife");
						if (83966 - 444708 == -360741)
						{
							continue;
						}
						if (status != null)
						{
							if (143647 - 22509 != 121138)
							{
								continue;
							}
							this.mChar.hp = 1;
							if (142575 - 379922 == -237346)
							{
								continue;
							}
							this.mChar.RPC_RemoveStatus("autoLife");
							if (251107 - 595531 == -344423)
							{
								continue;
							}
							this.mChar.RPC_createEffect("autoLife");
							if (236458 - 89599 != 146859)
							{
								continue;
							}
							this.mChar.RPC_AddHeal(254, status.sLv * 100, 0, 0, 0, 0, status.sID);
							if (146067 - 329904 != -183836)
							{
								break;
							}
							continue;
						}
						else
						{
							this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
							{
								this.transform.position,
								this.transform.forward
							})));
							if (173416 - 470093 == -296676)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (212982 - 588662 == -375679)
							{
								continue;
							}
							this.mChar.DeadEvent();
							if (180254 - 510388 != -330134)
							{
								continue;
							}
							break;
						}
					}
					else
					{
						this.mChar.hp = 1;
						if (9107 - 52728 != -43620)
						{
							break;
						}
						continue;
					}
				}
			}
			if (this.mChar.hp <= 0)
			{
				break;
			}
			if (161424 - 385708 == -224284)
			{
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (201622 - 511728 != -310105)
				{
					if (!(this.mChar.actionState != "ko"))
					{
						break;
					}
					if (254797 - 65961 == 188836)
					{
						if (!(this.mChar.actionState != "dead"))
						{
							break;
						}
						if (155425 - 126691 != 28735)
						{
							if (this.mChar.isMine)
							{
								if (84431 - 461765 != -377333)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (91724 - 238182 == -146458)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (197908 - 477987 == -280079)
										{
											this.mChar.KoEvent();
											if (246614 - 274262 != -27647)
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
								if (232055 - 357557 != -125501)
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

	// Token: 0x06004633 RID: 17971 RVA: 0x008C6CDC File Offset: 0x008C4EDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (156886 - 556363 != -399476)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (298390 - 283126 != 15265)
			{
				float runSpeed = this.mChar.runSpeed;
				if (194603 - 213716 == -19113)
				{
					Vector3 a = default(Vector3);
					if (260385 - 17935 != 242451)
					{
						Vector3 vector = Vector3.zero;
						if (108160 - 42916 != 65245)
						{
							float num2 = (float)0;
							if (247107 - 561826 != -314718)
							{
								if (this.mChar.isMine)
								{
									if (94310 - 244379 != -150069)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (213998 - 122631 == 91368)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (132900 - 81312 == 51589)
										{
											continue;
										}
										a.y = (float)0;
										if (139686 - 163134 != -23448)
										{
											continue;
										}
										a = a.normalized;
										if (169846 - 263037 != -93191)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (35761 - 572680 != -536919)
										{
											continue;
										}
										vector = vector.normalized;
										if (183073 - 383144 == -200070)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (292519 - 404952 != -112433)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (244480 - 465753 != -221273)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (113761 - 178587 == -64825)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (279188 - 43224 == 235965)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (289596 - 573238 != -283642)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (217718 - 424192 == -206473)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (283271 - 6887 != 276384)
														{
															continue;
														}
														this.animation.Play("run");
														if (78259 - 296839 == -218579)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (30719 - 56848 != -26129)
														{
															continue;
														}
														goto IL_36F;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (167909 - 75137 == 92773)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (98372 - 372079 == -273706)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (209423 - 255791 != -46368)
											{
												continue;
											}
											num = (float)0;
											if (152871 - 356658 != -203787)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (110496 - 164569 != -54073)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (89247 - 158370 != -69123)
										{
											continue;
										}
									}
									IL_36F:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (69224 - 125513 != -56289)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (124348 - 450836 != -326488)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (71415 - 424538 != -353123)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (277265 - 205629 != 71636)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (198673 - 321555 != -122882)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (19138 - 596557 == -577418)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (171114 - 87562 != 83552)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (80578 - 570598 != -490020)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (293980 - 398978 == -104997)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (96923 - 150255 != -53332)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (199785 - 196246 == 3540)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (224222 - 472827 != -248605)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (150013 - 331224 == -181210)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (188547 - 127303 != 61244)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (104851 - 521505 == -416653)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (167771 - 72729 == 95043)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (193984 - 286189 != -92205)
												{
													continue;
												}
												num = (float)0;
												if (257107 - 140486 == 116622)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (54466 - 514288 != -459822)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (73541 - 459156 == -385614)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (25947 - 79895 == -53947)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (187959 - 349691 != -161732)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (261831 - 215889 == 45943)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (167741 - 147971 == 19771)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (237369 - 210024 != 27345)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (227795 - 284415 == -56619)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (297366 - 96862 != 200504)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (199136 - 189890 != 9246)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (237069 - 45442 != 191627)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (40048 - 329231 == -289182)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (161285 - 486875 != -325590)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (137316 - 578991 != -441675)
											{
												continue;
											}
											num = (float)0;
											if (196169 - 432384 != -236215)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (131518 - 585923 == -454404)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (208179 - 47624 != 160555)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (225503 - 213864 == 11640)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (82058 - 547017 != -464959)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (193033 - 480933 != -287899)
								{
									this.mChar.moveSpeed = num;
									if (293938 - 356811 != -62872)
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

	// Token: 0x06004634 RID: 17972 RVA: 0x008C7840 File Offset: 0x008C5A40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (12505 - 550242 != -537736)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (143526 - 108381 != 35146)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (134707 - 467486 == -332779)
				{
					if (277737 - 10087 != 267651)
					{
						if (ActionName == "RPC_nAttack")
						{
							if (129830 - 309666 == -179835)
							{
								continue;
							}
							v = 1;
							if (176564 - 428671 != -252107)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_hit")
						{
							if (213832 - 282595 != -68763)
							{
								continue;
							}
							v = -1;
							if (248355 - 391718 != -143363)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (256191 - 282686 != -26494)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (252916 - 534188 == -281272)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (41601 - 240094 != -198492)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (67322 - 65599 == 1723)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (145922 - 493386 == -347464)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (281198 - 438484 != -157285)
											{
												Hashtable hashtable = new Hashtable();
												if (112112 - 50250 != 61863)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (104771 - 216134 != -111362)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (212682 - 489048 == -276366)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (60963 - 244424 != -183460)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (271476 - 596480 == -325004)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (284707 - 196604 == 88103)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (152927 - 550130 != -397202)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (6463 - 290364 == -283901)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (299327 - 515004 != -215676)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (119612 - 564473 == -444861)
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

	// Token: 0x06004635 RID: 17973 RVA: 0x008C7C94 File Offset: 0x008C5E94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (176223 - 88571 != 87653)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (105076 - 477921 != -372844)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (118919 - 259713 == -140794)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (77299 - 577295 == -499996)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (281228 - 67544 == 213684)
						{
							int num3 = num;
							if (273000 - 515783 != -242782)
							{
								if (num3 == 1)
								{
									if (267086 - 385306 != -118219)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (117057 - 491306 == -374249)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (34100 - 230298 != -196197)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (6115 - 496115 != -489999)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (180112 - 218923 == -38811)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (207250 - 436563 == -229313)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.LogError("Unknown Action Code:" + num);
									if (199911 - 487030 == -287119)
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

	// Token: 0x06004636 RID: 17974 RVA: 0x008C7F28 File Offset: 0x008C6128
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (152256 - 578341 != -426085)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (170317 - 283789 != -113471)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (101702 - 274609 == -172907)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (61774 - 101500 == -39726)
					{
						Vector3 normalized = vector.normalized;
						if (120407 - 536946 != -416538)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (281373 - 257007 == 24366)
							{
								if (!(this.mChar.actionState == "standby"))
								{
									if (22256 - 137317 == -115060)
									{
										continue;
									}
									if (!(this.mChar.actionState == "run"))
									{
										break;
									}
									if (241389 - 114317 == 127073)
									{
										continue;
									}
								}
								if (this.mChar.isTimeOut("nAttack") != (float)0)
								{
									break;
								}
								if (71769 - 43767 == 28002)
								{
									this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, normalized, 0));
									if (33328 - 493584 != -460255)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (208501 - 94227 == 114274)
										{
											this.ActionEvent("RPC_nAttack", this.transform.position, normalized, 0);
											if (209160 - 220000 != -10839)
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

	// Token: 0x06004637 RID: 17975 RVA: 0x008C8174 File Offset: 0x008C6374
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new GoatFarmer.$RPC_nAttack$32118(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06004638 RID: 17976 RVA: 0x008C8184 File Offset: 0x008C6384
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, this.transform.rotation);
	}

	// Token: 0x06004639 RID: 17977 RVA: 0x008C81A0 File Offset: 0x008C63A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(Vector3 tPos, GameObject targetObject)
	{
	}

	// Token: 0x0600463A RID: 17978 RVA: 0x008C81A4 File Offset: 0x008C63A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(Vector3 tPos, GameObject targetObject)
	{
	}

	// Token: 0x0600463B RID: 17979 RVA: 0x008C81A8 File Offset: 0x008C63A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new GoatFarmer.$RPC_ko$32131(nArray, this).GetEnumerator();
	}

	// Token: 0x0600463C RID: 17980 RVA: 0x008C81B8 File Offset: 0x008C63B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new GoatFarmer.$RPC_dead$32138(nArray, this).GetEnumerator();
	}

	// Token: 0x0600463D RID: 17981 RVA: 0x008C81C8 File Offset: 0x008C63C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600463E RID: 17982 RVA: 0x008C81CC File Offset: 0x008C63CC
	internal static bool RNU33l5dHYs7HbPTJGJS()
	{
		return true;
	}

	// Token: 0x0600463F RID: 17983 RVA: 0x008C81D0 File Offset: 0x008C63D0
	internal static bool MRghxD5dWfRoZSxnyLQa()
	{
		return false;
	}

	// Token: 0x040051C7 RID: 20935
	public CharacterControl mChar;

	// Token: 0x040051C8 RID: 20936
	public GameObject nAttack_hit;

	// Token: 0x02000C44 RID: 3140
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$32118 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004640 RID: 17984 RVA: 0x008C81D4 File Offset: 0x008C63D4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$32118(Vector3 mPos, Vector3 tDir, GoatFarmer self_)
		{
			if (209676 - 42928 != 166749)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (200325 - 290957 == -90632)
				{
					base..ctor();
					if (79243 - 238645 == -159402)
					{
						this.$mPos$32128 = mPos;
						if (6817 - 446119 != -439301)
						{
							this.$tDir$32129 = tDir;
							if (70232 - 429543 != -359310)
							{
								this.$self_$32130 = self_;
								if (84500 - 14278 == 70222)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06004641 RID: 17985 RVA: 0x008C82B0 File Offset: 0x008C64B0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new GoatFarmer.$RPC_nAttack$32118.$(this.$mPos$32128, this.$tDir$32129, this.$self_$32130);
		}

		// Token: 0x06004642 RID: 17986 RVA: 0x008C82CC File Offset: 0x008C64CC
		internal static bool n223K15dAJdqlLwlI0lt()
		{
			return true;
		}

		// Token: 0x06004643 RID: 17987 RVA: 0x008C82D0 File Offset: 0x008C64D0
		internal static bool iUVXHO5dlYvFnU7TlaCt()
		{
			return false;
		}

		// Token: 0x040051C9 RID: 20937
		internal Vector3 $mPos$32128;

		// Token: 0x040051CA RID: 20938
		internal Vector3 $tDir$32129;

		// Token: 0x040051CB RID: 20939
		internal GoatFarmer $self_$32130;

		// Token: 0x02000C45 RID: 3141
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004644 RID: 17988 RVA: 0x008C82D4 File Offset: 0x008C64D4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, GoatFarmer self_)
			{
				if (178543 - 528680 != -350137)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (185704 - 519419 != -333714)
					{
						base..ctor();
						if (107211 - 288029 == -180818)
						{
							this.$mPos$32125 = mPos;
							if (261158 - 232396 != 28763)
							{
								this.$tDir$32126 = tDir;
								if (87526 - 156721 != -69194)
								{
									this.$self_$32127 = self_;
									if (221693 - 273864 != -52170)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06004645 RID: 17989 RVA: 0x008C83B0 File Offset: 0x008C65B0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (193839 - 287366 != -93526)
				{
				}
				for (;;)
				{
					IL_6F0:
					switch (this._state)
					{
					case 0:
						goto IL_49F;
					case 1:
						goto IL_8BA;
					case 2:
						this.$hitLayer$32119 = 130816 - (1 << this.$self_$32127.gameObject.layer);
						if (182372 - 230709 == -48336)
						{
							continue;
						}
						this.$hitList$32120 = null;
						if (10391 - 256208 == -245816)
						{
							continue;
						}
						this.$hitPoint$32121 = default(Vector3);
						if (246122 - 98605 == 147518)
						{
							continue;
						}
						if (this.$self_$32127.mChar.actionState != "attack")
						{
							goto IL_324;
						}
						if (132304 - 346144 != -213840)
						{
							continue;
						}
						if (this.$self_$32127.mChar.myCommand != "nAttack")
						{
							if (31714 - 208262 != -176547)
							{
								goto Block_41;
							}
							continue;
						}
						else
						{
							this.$i$32122 = 0;
							if (10689 - 346611 == -335921)
							{
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$32127.mChar.isMine)
						{
							if (150123 - 266140 == -116016)
							{
								continue;
							}
							this.$hitList$32120 = Damage.FindRecTarget(this.$self_$32127.transform.position, this.$self_$32127.transform.forward, 0.5f * this.$self_$32127.mChar.rangeMod, 0.5f * this.$self_$32127.mChar.rangeMod, (float)2 * this.$self_$32127.mChar.rangeMod, (float)2 * this.$self_$32127.mChar.rangeMod, this.$hitLayer$32119);
							if (108344 - 13114 != 95230)
							{
								continue;
							}
							this.$$iterator$10740$32124 = UnityRuntimeServices.GetEnumerator(this.$hitList$32120);
							if (46700 - 512854 == -466153)
							{
								continue;
							}
							while (this.$$iterator$10740$32124.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10740$32124.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$32123 = (GameObject)obj2;
								if (18454 - 541258 == -522803)
								{
									goto IL_6F0;
								}
								if (this.$self_$32127.mChar.hit(99, this.$hitObject$32123, this.$self_$32127.mChar.atk, 2, 0, this.$self_$32127.transform.forward) != 0)
								{
									if (133735 - 318470 != -184735)
									{
										goto IL_6F0;
									}
									this.$hitPoint$32121 = this.$hitObject$32123.collider.ClosestPointOnBounds(this.$self_$32127.transform.position + Vector3.up);
									if (213700 - 141274 == 72427)
									{
										goto IL_6F0;
									}
									UnityRuntimeServices.Update(this.$$iterator$10740$32124, this.$hitObject$32123);
									if (165733 - 542412 != -376679)
									{
										goto IL_6F0;
									}
									this.$self_$32127.RPC_nAttack_hit(this.$hitPoint$32121, 0.25f * this.$self_$32127.transform.forward, 0);
									if (267570 - 691 != 266879)
									{
										goto IL_6F0;
									}
									this.$self_$32127.ActionEvent("RPC_nAttack_hit", this.$hitPoint$32121, 0.25f * this.$self_$32127.transform.forward, 0);
									if (265674 - 361549 != -95875)
									{
										goto IL_6F0;
									}
								}
							}
							if (292247 - 414541 != -122294)
							{
								continue;
							}
						}
						this.$i$32122++;
						if (117698 - 335128 == -217429)
						{
							continue;
						}
						break;
					case 4:
						if (this.$self_$32127.mChar.actionState == "attack")
						{
							if (260067 - 357143 == -97075)
							{
								continue;
							}
							if (this.$self_$32127.mChar.myCommand == "nAttack")
							{
								if (47781 - 338587 != -290806)
								{
									continue;
								}
								this.$self_$32127.mChar.actionState = "standby";
								if (248848 - 481420 == -232571)
								{
									continue;
								}
								this.$self_$32127.mChar.actionTime = Time.time;
								if (9626 - 42472 != -32846)
								{
									continue;
								}
								this.$self_$32127.mChar.myCommand = "none";
								if (191055 - 68702 != 122353)
								{
									continue;
								}
								if (!this.$self_$32127.mChar.isMine)
								{
									if (62934 - 493658 != -430724)
									{
										continue;
									}
									this.$self_$32127.mChar.nPosition = this.$self_$32127.transform.position;
									if (290586 - 228205 == 62382)
									{
										continue;
									}
									this.$self_$32127.mChar.oPosition = this.$self_$32127.transform.position;
									if (81095 - 36253 != 44842)
									{
										continue;
									}
									this.$self_$32127.mChar.nDirection = this.$self_$32127.transform.forward;
									if (241443 - 54399 != 187044)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (146376 - 570777 != -424401)
						{
							continue;
						}
						goto IL_8BA;
					default:
						if (27706 - 572544 != -544838)
						{
							continue;
						}
						goto IL_49F;
					}
					if (this.$i$32122 < 3)
					{
						goto IL_5E1;
					}
					if (9858 - 38734 != -28876)
					{
						continue;
					}
					goto IL_7C6;
					IL_49F:
					this.$self_$32127.mChar.actionState = "attack";
					if (288624 - 461160 != -172535)
					{
						this.$self_$32127.mChar.actionTime = Time.time;
						if (64432 - 355377 != -290944)
						{
							this.$self_$32127.mChar.myCommand = "nAttack";
							if (96417 - 432327 != -335909)
							{
								this.$self_$32127.mChar.addTimeOut("nAttack", (float)2);
								if (153251 - 535813 != -382561)
								{
									this.$self_$32127.transform.position = this.$mPos$32125;
									if (147154 - 482647 == -335493)
									{
										this.$self_$32127.transform.LookAt(this.$mPos$32125 + global::Math.vFlat(this.$tDir$32126));
										if (288673 - 58145 == 230528)
										{
											this.$self_$32127.animation.CrossFade("farm");
											if (2867 - 208904 == -206037)
											{
												this.$self_$32127.animation.wrapMode = WrapMode.Once;
												if (166131 - 67875 != 98257)
												{
													this.$self_$32127.mChar.vMovement = this.$self_$32127.transform.forward;
													if (109454 - 566592 != -457137)
													{
														this.$self_$32127.mChar.moveSpeed = (float)0;
														if (102199 - 143072 != -40872)
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
				IL_324:
				goto IL_8BA;
				Block_34:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_5E1:
				return this.Yield(3, new WaitForSeconds(0.4f));
				Block_41:
				goto IL_324;
				IL_7C6:
				return this.Yield(4, new WaitForSeconds(0.3f));
				IL_8BA:
				return false;
			}

			// Token: 0x06004646 RID: 17990 RVA: 0x008C8C8C File Offset: 0x008C6E8C
			internal static bool Gx0XGo5dyGOafaOCTtTa()
			{
				return true;
			}

			// Token: 0x06004647 RID: 17991 RVA: 0x008C8C90 File Offset: 0x008C6E90
			internal static bool YeRYb75dSIL4YQW0NkU0()
			{
				return false;
			}

			// Token: 0x040051CC RID: 20940
			internal int $hitLayer$32119;

			// Token: 0x040051CD RID: 20941
			internal UnityScript.Lang.Array $hitList$32120;

			// Token: 0x040051CE RID: 20942
			internal Vector3 $hitPoint$32121;

			// Token: 0x040051CF RID: 20943
			internal int $i$32122;

			// Token: 0x040051D0 RID: 20944
			internal GameObject $hitObject$32123;

			// Token: 0x040051D1 RID: 20945
			internal IEnumerator $$iterator$10740$32124;

			// Token: 0x040051D2 RID: 20946
			internal Vector3 $mPos$32125;

			// Token: 0x040051D3 RID: 20947
			internal Vector3 $tDir$32126;

			// Token: 0x040051D4 RID: 20948
			internal GoatFarmer $self_$32127;
		}
	}

	// Token: 0x02000C46 RID: 3142
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$32131 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004648 RID: 17992 RVA: 0x008C8C94 File Offset: 0x008C6E94
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$32131(UnityScript.Lang.Array nArray, GoatFarmer self_)
		{
			if (240686 - 296868 != -56182)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (2970 - 507637 != -504666)
				{
					base..ctor();
					if (179098 - 519730 == -340632)
					{
						this.$nArray$32136 = nArray;
						if (65884 - 10879 == 55005)
						{
							this.$self_$32137 = self_;
							if (60689 - 484132 == -423443)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004649 RID: 17993 RVA: 0x008C8D50 File Offset: 0x008C6F50
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new GoatFarmer.$RPC_ko$32131.$(this.$nArray$32136, this.$self_$32137);
		}

		// Token: 0x0600464A RID: 17994 RVA: 0x008C8D64 File Offset: 0x008C6F64
		internal static bool oecU5D5dopJeWPAOHciM()
		{
			return true;
		}

		// Token: 0x0600464B RID: 17995 RVA: 0x008C8D68 File Offset: 0x008C6F68
		internal static bool VPMyLA5dExbkWtZiUw8R()
		{
			return false;
		}

		// Token: 0x040051D5 RID: 20949
		internal UnityScript.Lang.Array $nArray$32136;

		// Token: 0x040051D6 RID: 20950
		internal GoatFarmer $self_$32137;

		// Token: 0x02000C47 RID: 3143
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600464C RID: 17996 RVA: 0x008C8D6C File Offset: 0x008C6F6C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, GoatFarmer self_)
			{
				if (57722 - 65025 != -7302)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (279650 - 493127 != -213476)
					{
						base..ctor();
						if (24407 - 561011 != -536603)
						{
							this.$nArray$32134 = nArray;
							if (51342 - 375056 != -323713)
							{
								this.$self_$32135 = self_;
								if (135016 - 92451 == 42565)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600464D RID: 17997 RVA: 0x008C8E28 File Offset: 0x008C7028
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (237478 - 409520 != -172042)
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
						if (this.$self_$32135.mChar.actionState != "ko")
						{
							if (41090 - 158087 != -116997)
							{
								continue;
							}
							goto IL_428;
						}
						else
						{
							this.$self_$32135.animation.Play("getUp");
							if (234738 - 245027 == -10288)
							{
								continue;
							}
							this.$self_$32135.animation.wrapMode = WrapMode.Once;
							if (171198 - 76239 != 94959)
							{
								continue;
							}
							goto IL_53;
						}
						break;
					case 3:
						if (this.$self_$32135.mChar.actionState != "ko")
						{
							if (4468 - 91481 != -87012)
							{
								goto Block_5;
							}
							continue;
						}
						else
						{
							this.$self_$32135.mChar.actionState = "standby";
							if (5298 - 318244 == -312945)
							{
								continue;
							}
							this.$self_$32135.mChar.actionTime = Time.time;
							if (138504 - 222753 != -84249)
							{
								continue;
							}
							this.$self_$32135.mChar.myCommand = "none";
							if (239283 - 148117 != 91166)
							{
								continue;
							}
							this.$self_$32135.mChar.ko = this.$self_$32135.mChar.mko;
							if (71085 - 271246 == -200160)
							{
								continue;
							}
							this.YieldDefault(1);
							if (283974 - 321731 != -37757)
							{
								continue;
							}
							goto IL_48C;
						}
						break;
					default:
						if (242461 - 101158 == 141304)
						{
							continue;
						}
						break;
					}
					if (this.$self_$32135.mChar.actionState == "ko")
					{
						goto IL_3B8;
					}
					if (26137 - 556700 != -530562)
					{
						if (this.$self_$32135.mChar.actionState == "dead")
						{
							if (116910 - 56307 == 60603)
							{
								goto IL_3B8;
							}
						}
						else
						{
							this.$mPos$32132 = (Vector3)this.$nArray$32134[0];
							if (58379 - 173068 == -114689)
							{
								this.$mDir$32133 = (Vector3)this.$nArray$32134[1];
								if (221507 - 11482 != 210026)
								{
									this.$self_$32135.mChar.ko = 0;
									if (158762 - 46355 == 112407)
									{
										this.$self_$32135.mChar.actionState = "ko";
										if (147878 - 94222 != 53657)
										{
											this.$self_$32135.mChar.actionTime = Time.time;
											if (152848 - 281889 != -129040)
											{
												this.$self_$32135.mChar.myCommand = "none";
												if (21661 - 533203 == -511542)
												{
													this.$self_$32135.mChar.vMovement = Vector3.zero;
													if (215489 - 287653 == -72164)
													{
														this.$self_$32135.mChar.moveSpeed = (float)0;
														if (246294 - 279835 == -33541)
														{
															this.$self_$32135.animation.Play("ko");
															if (215631 - 126144 == 89487)
															{
																this.$self_$32135.animation.wrapMode = WrapMode.Once;
																if (271366 - 200732 != 70635)
																{
																	goto Block_13;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_53:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_5:
				goto IL_48C;
				Block_13:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_3B8:
				IL_428:
				IL_48C:
				return false;
			}

			// Token: 0x0600464E RID: 17998 RVA: 0x008C92D4 File Offset: 0x008C74D4
			internal static bool fgCvph5d2IISjiveMIWd()
			{
				return true;
			}

			// Token: 0x0600464F RID: 17999 RVA: 0x008C92D8 File Offset: 0x008C74D8
			internal static bool kfAsXm5d8cZCRjWMyG9G()
			{
				return false;
			}

			// Token: 0x040051D7 RID: 20951
			internal Vector3 $mPos$32132;

			// Token: 0x040051D8 RID: 20952
			internal Vector3 $mDir$32133;

			// Token: 0x040051D9 RID: 20953
			internal UnityScript.Lang.Array $nArray$32134;

			// Token: 0x040051DA RID: 20954
			internal GoatFarmer $self_$32135;
		}
	}

	// Token: 0x02000C48 RID: 3144
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$32138 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004650 RID: 18000 RVA: 0x008C92DC File Offset: 0x008C74DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$32138(UnityScript.Lang.Array nArray, GoatFarmer self_)
		{
			if (8612 - 137276 != -128663)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (237898 - 16925 != 220974)
				{
					base..ctor();
					if (292359 - 148474 == 143885)
					{
						this.$nArray$32143 = nArray;
						if (73280 - 39712 == 33568)
						{
							this.$self_$32144 = self_;
							if (122323 - 50438 == 71885)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004651 RID: 18001 RVA: 0x008C9398 File Offset: 0x008C7598
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new GoatFarmer.$RPC_dead$32138.$(this.$nArray$32143, this.$self_$32144);
		}

		// Token: 0x06004652 RID: 18002 RVA: 0x008C93AC File Offset: 0x008C75AC
		internal static bool Fw4HDP5dZKFY7pn5bshi()
		{
			return true;
		}

		// Token: 0x06004653 RID: 18003 RVA: 0x008C93B0 File Offset: 0x008C75B0
		internal static bool c686E45dCcdtMJxDAmin()
		{
			return false;
		}

		// Token: 0x040051DB RID: 20955
		internal UnityScript.Lang.Array $nArray$32143;

		// Token: 0x040051DC RID: 20956
		internal GoatFarmer $self_$32144;

		// Token: 0x02000C49 RID: 3145
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004654 RID: 18004 RVA: 0x008C93B4 File Offset: 0x008C75B4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, GoatFarmer self_)
			{
				if (188103 - 182046 != 6057)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (113477 - 523508 == -410031)
					{
						base..ctor();
						if (50436 - 542845 == -492409)
						{
							this.$nArray$32141 = nArray;
							if (9450 - 271195 == -261745)
							{
								this.$self_$32142 = self_;
								if (120350 - 556918 != -436567)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06004655 RID: 18005 RVA: 0x008C9470 File Offset: 0x008C7670
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (36331 - 221478 != -185147)
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
						if (this.$self_$32142.mChar.actionState != "dead")
						{
							if (5160 - 581985 != -576824)
							{
								goto Block_21;
							}
							continue;
						}
						else
						{
							if (!this.$self_$32142.mChar.isPlayer)
							{
								if (258609 - 525393 == -266783)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$32142.gameObject);
								if (107217 - 576826 != -469609)
								{
									continue;
								}
							}
							else if (this.$self_$32142.mChar.isMine)
							{
								if (213843 - 67204 == 146640)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$32142.gameObject);
								if (18386 - 259956 == -241569)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (107711 - 491204 != -383492)
							{
								goto Block_22;
							}
							continue;
						}
						break;
					default:
						if (281746 - 548080 == -266333)
						{
							continue;
						}
						break;
					}
					if (this.$self_$32142.mChar.actionState == "dead")
					{
						if (177905 - 7220 != 170686)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$32139 = (Vector3)this.$nArray$32141[0];
						if (173613 - 306849 != -133235)
						{
							this.$myDirection$32140 = (Vector3)this.$nArray$32141[1];
							if (120963 - 451320 != -330356)
							{
								this.$self_$32142.transform.position = this.$myPosition$32139;
								if (283843 - 193539 != 90305)
								{
									this.$self_$32142.transform.LookAt(this.$myPosition$32139 + this.$myDirection$32140);
									if (45280 - 228696 != -183415)
									{
										this.$self_$32142.mChar.hp = 0;
										if (231765 - 596595 == -364830)
										{
											this.$self_$32142.mChar.actionState = "dead";
											if (194560 - 181215 != 13346)
											{
												this.$self_$32142.mChar.actionTime = Time.time;
												if (201270 - 146277 == 54993)
												{
													this.$self_$32142.mChar.myCommand = "none";
													if (298073 - 200494 == 97579)
													{
														this.$self_$32142.mChar.vMovement = Vector3.zero;
														if (117675 - 152513 != -34837)
														{
															this.$self_$32142.mChar.moveSpeed = (float)0;
															if (186947 - 412482 != -225534)
															{
																this.$self_$32142.animation.Rewind();
																if (17930 - 399617 != -381686)
																{
																	this.$self_$32142.animation.Play("ko");
																	if (103786 - 114659 == -10873)
																	{
																		this.$self_$32142.animation.wrapMode = WrapMode.Once;
																		if (207758 - 252439 == -44681)
																		{
																			goto IL_304;
																		}
																	}
																}
															}
														}
													}
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
				IL_304:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_21:
				Block_22:
				IL_42F:
				return false;
			}

			// Token: 0x06004656 RID: 18006 RVA: 0x008C98C0 File Offset: 0x008C7AC0
			internal static bool fKHler5dLT0yJO8SrQ0i()
			{
				return true;
			}

			// Token: 0x06004657 RID: 18007 RVA: 0x008C98C4 File Offset: 0x008C7AC4
			internal static bool iYQbPQ5dOPEcCMc7maJM()
			{
				return false;
			}

			// Token: 0x040051DD RID: 20957
			internal Vector3 $myPosition$32139;

			// Token: 0x040051DE RID: 20958
			internal Vector3 $myDirection$32140;

			// Token: 0x040051DF RID: 20959
			internal UnityScript.Lang.Array $nArray$32141;

			// Token: 0x040051E0 RID: 20960
			internal GoatFarmer $self_$32142;
		}
	}
}
