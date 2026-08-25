using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000F7F RID: 3967
[Serializable]
public class RangerRobotMount : MonoBehaviour
{
	// Token: 0x060059FC RID: 23036 RVA: 0x00ACCA9C File Offset: 0x00ACAC9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public RangerRobotMount()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060059FD RID: 23037 RVA: 0x00ACCAAC File Offset: 0x00ACACAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (82013 - 488205 != -406191)
		{
		}
		for (;;)
		{
			this.yHlcXkPjQKX = this.transform;
			if (106757 - 599962 == -493205)
			{
				this.OQhcXFIIW5A = (CharacterControl)this.GetComponent(typeof(CharacterControl));
				if (91261 - 513460 != -422198)
				{
					this.OQhcXFIIW5A.actionState = "standby";
					if (295771 - 420793 == -125022)
					{
						this.OQhcXFIIW5A.actionTime = Time.time;
						if (115641 - 444191 == -328550)
						{
							this.OQhcXFIIW5A.myCommand = "none";
							if (276101 - 585717 != -309615)
							{
								if (this.OQhcXFIIW5A)
								{
									if (98709 - 236665 == -137955)
									{
										continue;
									}
									this.OQhcXFIIW5A.mImmuneList = new UnityScript.Lang.Array(new object[]
									{
										"powerBreak",
										"armorBreak",
										"burn",
										"paralysis",
										"needlePrison",
										"sticky",
										"petrify",
										"groundLock",
										"ice",
										"frost",
										"snowman",
										"lightBind",
										"sleep",
										"blind",
										"confuse",
										"mindControl"
									});
									if (176422 - 60095 != 116327)
									{
										continue;
									}
								}
								this.QuvcXAi0pqK = Time.time;
								if (44043 - 553535 == -509492)
								{
									this.StartCoroutine_Auto(this.RPC_summon(this.transform.position, this.transform.forward, 0));
									if (50262 - 387370 == -337108)
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

	// Token: 0x060059FE RID: 23038 RVA: 0x00ACCD04 File Offset: 0x00ACAF04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void playLeftFootEvent(AnimationEvent animEvent)
	{
		if (69472 - 576613 != -507140)
		{
		}
		for (;;)
		{
			Vector3 vector = Camera.main.transform.position - this.transform.position;
			if (278282 - 345797 == -67515)
			{
				if (vector.sqrMagnitude >= (float)225)
				{
					break;
				}
				if (244742 - 306970 != -62227)
				{
					Camera.main.SendMessage("AddCamereShake", 0.1f);
					if (194792 - 416055 != -221262)
					{
						if (!this.footStep_left)
						{
							break;
						}
						if (223847 - 488579 == -264732)
						{
							this.audio.PlayOneShot(this.footStep_left);
							if (172845 - 34002 != 138844)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060059FF RID: 23039 RVA: 0x00ACCE2C File Offset: 0x00ACB02C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void playRightFootEvent(AnimationEvent animEvent)
	{
		if (184929 - 415717 != -230787)
		{
		}
		for (;;)
		{
			Vector3 vector = Camera.main.transform.position - this.transform.position;
			if (5565 - 551862 != -546296)
			{
				if (vector.sqrMagnitude >= (float)225)
				{
					break;
				}
				if (294682 - 6522 == 288160)
				{
					Camera.main.SendMessage("AddCamereShake", 0.1f);
					if (106854 - 45609 != 61246)
					{
						if (!this.footStep_right)
						{
							break;
						}
						if (114051 - 183274 != -69222)
						{
							this.audio.PlayOneShot(this.footStep_right);
							if (189717 - 205661 == -15944)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06005A00 RID: 23040 RVA: 0x00ACCF54 File Offset: 0x00ACB154
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (149397 - 342297 != -192899)
		{
		}
		for (;;)
		{
			if (this.OQhcXFIIW5A.isControlled)
			{
				if (168280 - 42414 == 125867)
				{
					continue;
				}
				if (!(this.OQhcXFIIW5A.actionState == "standby"))
				{
					if (126696 - 111534 != 15162)
					{
						continue;
					}
					if (!(this.OQhcXFIIW5A.actionState == "run"))
					{
						goto IL_433;
					}
					if (96805 - 500968 != -404163)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (243360 - 166142 == 77219)
				{
					continue;
				}
			}
			IL_433:
			if (this.OQhcXFIIW5A.hp <= 0)
			{
				if (198023 - 115026 == 82998)
				{
					continue;
				}
				if (this.OQhcXFIIW5A.actionState != "dead")
				{
					if (161785 - 572765 == -410979)
					{
						continue;
					}
					if (this.OQhcXFIIW5A.isMine)
					{
						if (63645 - 473080 == -409434)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (24362 - 206458 == -182095)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (27288 - 193155 == -165866)
						{
							continue;
						}
						this.OQhcXFIIW5A.DeadEvent();
						if (266719 - 446325 != -179606)
						{
							continue;
						}
						break;
					}
					else
					{
						this.OQhcXFIIW5A.hp = 1;
						if (280390 - 457588 != -177198)
						{
							continue;
						}
						break;
					}
				}
			}
			if (this.OQhcXFIIW5A.hp > 0)
			{
				if (185843 - 190240 == -4396)
				{
					continue;
				}
				if (this.OQhcXFIIW5A.ko <= 0)
				{
					if (128143 - 155463 == -27319)
					{
						continue;
					}
					if (this.OQhcXFIIW5A.actionState != "ko")
					{
						if (126073 - 482233 == -356159)
						{
							continue;
						}
						if (this.OQhcXFIIW5A.actionState != "dead")
						{
							if (276528 - 96787 == 179742)
							{
								continue;
							}
							if (this.OQhcXFIIW5A.isMine)
							{
								if (135274 - 219452 != -84178)
								{
									continue;
								}
								this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
								{
									this.transform.position,
									this.transform.forward
								})));
								if (39889 - 98189 == -58299)
								{
									continue;
								}
								if (!PhotonClient.IsInitialized())
								{
									break;
								}
								if (100525 - 133437 == -32911)
								{
									continue;
								}
								this.OQhcXFIIW5A.KoEvent();
								if (281889 - 535995 != -254105)
								{
									break;
								}
								continue;
							}
							else
							{
								this.OQhcXFIIW5A.ko = 1;
								if (90938 - 525720 != -434782)
								{
									continue;
								}
								break;
							}
						}
					}
				}
			}
			if (Time.time <= this.QuvcXAi0pqK + (float)300)
			{
				break;
			}
			if (235251 - 177594 == 57657)
			{
				if (this.OQhcXFIIW5A.hp <= 0)
				{
					break;
				}
				if (100725 - 240308 == -139583)
				{
					Debug.Log("RobotCaller Timeout!");
					if (93908 - 362598 != -268689)
					{
						if (!this.OQhcXFIIW5A.isMine)
						{
							break;
						}
						if (75341 - 11046 == 64295)
						{
							this.OQhcXFIIW5A.RPC_RemoveStatus("mount");
							if (29991 - 30033 != -41)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06005A01 RID: 23041 RVA: 0x00ACD428 File Offset: 0x00ACB628
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (22840 - 305224 != -282383)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (264221 - 71911 != 192311)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (245862 - 564704 != -318841)
				{
					if (269445 - 208172 == 61273)
					{
						if (ActionName == "RPC_nAttack1")
						{
							if (288091 - 289167 == -1075)
							{
								continue;
							}
							v = 1;
							if (206249 - 560810 != -354561)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack2")
						{
							if (200776 - 586927 != -386151)
							{
								continue;
							}
							v = 2;
							if (87350 - 159096 == -71745)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_hit")
						{
							if (280628 - 574840 != -294212)
							{
								continue;
							}
							v = -1;
							if (153762 - 408762 != -255000)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_drillPunch")
						{
							if (169989 - 440939 == -270949)
							{
								continue;
							}
							v = 11;
							if (125531 - 336005 == -210473)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_clawPincer")
						{
							if (291825 - 237387 == 54439)
							{
								continue;
							}
							v = 21;
							if (283668 - 138839 == 144830)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_galaxyBlade")
						{
							if (38465 - 191360 == -152894)
							{
								continue;
							}
							v = 31;
							if (111597 - 547361 != -435764)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (19327 - 358559 != -339232)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (189071 - 150220 != 38852)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (18632 - 47341 != -28708)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (92397 - 270482 == -178085)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (231369 - 172689 == 58680)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (1116 - 447199 != -446082)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (182823 - 6924 == 175899)
											{
												Hashtable hashtable = new Hashtable();
												if (121563 - 548352 == -426789)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (18507 - 430580 != -412072)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (169504 - 472782 == -303278)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (203432 - 56857 == 146575)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (116266 - 32081 != 84186)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (21420 - 460173 != -438752)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (273397 - 453366 != -179968)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (196266 - 100803 == 95463)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (260722 - 377915 == -117193)
																				{
																					PhotonClient.SendEvent(this.OQhcXFIIW5A.ActorNr, 74, hashtable, true, true);
																					if (199946 - 400698 == -200752)
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

	// Token: 0x06005A02 RID: 23042 RVA: 0x00ACD9D4 File Offset: 0x00ACBBD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (167389 - 248229 != -80839)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (210063 - 326885 != -116821)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (174340 - 108795 == 65545)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (218010 - 15761 != 202250)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (31188 - 544914 != -513725)
						{
							int num3 = num;
							if (133854 - 301926 != -168071)
							{
								if (num3 == 1)
								{
									if (274014 - 215869 == 58145)
									{
										if (this.OQhcXFIIW5A.isMine)
										{
											break;
										}
										if (16891 - 291679 != -274787)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack1(vector, vector2, num2));
											if (182727 - 461552 == -278825)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 2)
								{
									if (104592 - 397291 != -292698)
									{
										if (this.OQhcXFIIW5A.isMine)
										{
											break;
										}
										if (131969 - 107107 != 24863)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack2(vector, vector2, num2));
											if (153113 - 61171 == 91942)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (71238 - 598051 == -526813)
									{
										if (this.OQhcXFIIW5A.isMine)
										{
											break;
										}
										if (96886 - 146508 != -49621)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (36727 - 88196 == -51469)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (185748 - 136113 != 49636)
									{
										if (this.OQhcXFIIW5A.isMine)
										{
											break;
										}
										if (72548 - 394441 != -321892)
										{
											this.StartCoroutine_Auto(this.RPC_drillPunch(vector, vector2, num2));
											if (136723 - 24507 != 112217)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 21)
								{
									if (210134 - 363710 == -153576)
									{
										if (this.OQhcXFIIW5A.isMine)
										{
											break;
										}
										if (148180 - 172499 != -24318)
										{
											this.StartCoroutine_Auto(this.RPC_clawPincer(vector, vector2, num2));
											if (104441 - 420461 == -316020)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 31)
								{
									if (179799 - 142834 != 36966)
									{
										if (this.OQhcXFIIW5A.isMine)
										{
											break;
										}
										if (266554 - 49107 == 217447)
										{
											this.StartCoroutine_Auto(this.RPC_galaxyBlade(vector, vector2, num2));
											if (172658 - 521368 == -348710)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (47623 - 48899 != -1275)
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

	// Token: 0x06005A03 RID: 23043 RVA: 0x00ACDE58 File Offset: 0x00ACC058
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (157327 - 317783 != -160456)
		{
		}
		for (;;)
		{
			float num = this.OQhcXFIIW5A.moveSpeed;
			if (170202 - 42990 == 127212)
			{
				float runSpeed = this.OQhcXFIIW5A.runSpeed;
				if (9013 - 296119 != -287105)
				{
					Vector3 a = default(Vector3);
					if (113051 - 558157 == -445106)
					{
						Vector3 vector = Vector3.zero;
						if (149349 - 511244 != -361894)
						{
							float num2 = (float)0;
							if (139321 - 315268 != -175946)
							{
								if (this.OQhcXFIIW5A.isMine)
								{
									if (215482 - 506579 == -291096)
									{
										continue;
									}
									if ((this.OQhcXFIIW5A.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (9027 - 429710 == -420682)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (127550 - 476338 == -348787)
										{
											continue;
										}
										a.y = (float)0;
										if (93848 - 301902 != -208054)
										{
											continue;
										}
										a = a.normalized;
										if (281982 - 25133 != 256849)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (272356 - 540036 != -267680)
										{
											continue;
										}
										vector = vector.normalized;
										if (98865 - 575930 == -477064)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (288278 - 177838 == 110441)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (218362 - 422933 == -204570)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (257897 - 472570 != -214673)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (31080 - 194942 != -163862)
														{
															continue;
														}
														this.OQhcXFIIW5A.actionState = "run";
														if (78897 - 275641 != -196744)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (249571 - 32209 == 217363)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (3824 - 244383 != -240559)
														{
															continue;
														}
														this.animation.Play("run");
														if (78674 - 216081 != -137407)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (155290 - 492566 != -337275)
														{
															goto IL_3CE;
														}
														continue;
													}
												}
											}
										}
										this.OQhcXFIIW5A.actionState = "standby";
										if (71772 - 392963 == -321190)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (269319 - 109614 == 159706)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (244406 - 438644 != -194238)
											{
												continue;
											}
											num = (float)0;
											if (182922 - 112986 != 69936)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (101438 - 272326 != -170888)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (30567 - 129577 != -99010)
										{
											continue;
										}
									}
									IL_3CE:;
								}
								else
								{
									vector = global::Math.vFlat(this.OQhcXFIIW5A.nPosition - this.transform.position);
									if (273353 - 221094 != 52259)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (189428 - 191130 == -1701)
									{
										continue;
									}
									if (this.OQhcXFIIW5A.nSpeed != (float)0)
									{
										if (113626 - 549786 != -436160)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (33099 - 478418 != -445319)
											{
												continue;
											}
											this.transform.position = this.OQhcXFIIW5A.nPosition;
											if (219644 - 193403 != 26241)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (9217 - 478296 != -469079)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (67980 - 490728 != -422748)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (208641 - 368157 != -159516)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.OQhcXFIIW5A.nSpeed, (float)10 * Time.deltaTime);
												if (26402 - 578647 == -552244)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (6728 - 110810 != -104082)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (68431 - 491087 != -422656)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (130164 - 291234 != -161070)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (181003 - 234282 != -53279)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (299368 - 457139 == -157770)
											{
												continue;
											}
										}
										else if (Time.time > this.OQhcXFIIW5A.nSpeed + 0.3f)
										{
											if (49133 - 282042 == -232908)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (24035 - 202410 != -178375)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (26668 - 55084 != -28416)
												{
													continue;
												}
												num = (float)0;
												if (293420 - 530565 != -237145)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.OQhcXFIIW5A.nDirection);
											if (141805 - 353813 != -212008)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (183432 - 552846 != -369414)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (166116 - 101078 != 65038)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (59758 - 436510 != -376752)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (70063 - 586198 != -516135)
											{
												continue;
											}
											this.transform.position = this.OQhcXFIIW5A.nPosition;
											if (20219 - 240925 != -220706)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (3488 - 61809 == -58320)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (139358 - 386630 == -247271)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (152699 - 409597 == -256897)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (248619 - 138709 != 109910)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (167903 - 235719 != -67816)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (281407 - 169005 == 112403)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (170775 - 268530 != -97755)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.OQhcXFIIW5A.nDirection);
											if (165625 - 485192 != -319567)
											{
												continue;
											}
											num = (float)0;
											if (153918 - 388006 == -234087)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (204386 - 345127 == -140740)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (183514 - 274486 == -90971)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (290660 - 408554 != -117894)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (255711 - 67775 == 187937)
										{
											continue;
										}
									}
								}
								this.OQhcXFIIW5A.vMovement = vector;
								if (230558 - 433824 != -203265)
								{
									this.OQhcXFIIW5A.moveSpeed = num;
									if (197926 - 369479 == -171553)
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

	// Token: 0x06005A04 RID: 23044 RVA: 0x00ACE9BC File Offset: 0x00ACCBBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (271484 - 266698 != 4786)
		{
		}
		for (;;)
		{
			if (!this.OQhcXFIIW5A.isMine)
			{
				if (266427 - 192183 != 74245)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (57212 - 9210 != 48003)
				{
					Vector3 vector = a - this.transform.position;
					if (237102 - 247827 == -10725)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (280882 - 439753 != -158870)
						{
							CharacterControl characterControl = null;
							if (38366 - 416264 != -377897)
							{
								int tID = 0;
								if (22891 - 511988 != -489096)
								{
									if (gameObject)
									{
										if (205731 - 589118 != -383387)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (103556 - 304922 != -201366)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (101305 - 595530 != -494225)
										{
											continue;
										}
										tID = characterControl.ActorNr;
										if (214807 - 270888 != -56081)
										{
											continue;
										}
									}
									if (!(this.OQhcXFIIW5A.actionState == "standby"))
									{
										if (14110 - 488298 == -474187)
										{
											continue;
										}
										if (!(this.OQhcXFIIW5A.actionState == "run"))
										{
											break;
										}
										if (118605 - 139139 == -20533)
										{
											continue;
										}
									}
									if (Game.mGameType < 4)
									{
										if (121337 - 408230 != -286892)
										{
											Camera.main.SendMessage("newGameMessage", "Cannot do normal attack here");
											if (189315 - 342187 != -152871)
											{
												break;
											}
										}
									}
									else
									{
										if (this.OQhcXFIIW5A.isTimeOut("nAttack") != (float)0)
										{
											break;
										}
										if (225410 - 10923 != 214488)
										{
											if (UnityEngine.Random.Range(0, 100) > 60)
											{
												if (53325 - 77764 == -24439)
												{
													this.StartCoroutine_Auto(this.RPC_nAttack1(this.transform.position, vector, tID));
													if (231124 - 529071 != -297946)
													{
														if (!PhotonClient.IsInitialized())
														{
															break;
														}
														if (272849 - 592738 == -319889)
														{
															this.ActionEvent("RPC_nAttack1", this.transform.position, vector, tID);
															if (17421 - 152959 == -135538)
															{
																break;
															}
														}
													}
												}
											}
											else
											{
												this.StartCoroutine_Auto(this.RPC_nAttack2(this.transform.position, vector, tID));
												if (256208 - 137782 == 118426)
												{
													if (!PhotonClient.IsInitialized())
													{
														break;
													}
													if (250487 - 9890 != 240598)
													{
														this.ActionEvent("RPC_nAttack2", this.transform.position, vector, tID);
														if (74524 - 47673 != 26852)
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

	// Token: 0x06005A05 RID: 23045 RVA: 0x00ACEDC8 File Offset: 0x00ACCFC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (12446 - 122980 != -110534)
		{
		}
		for (;;)
		{
			if (!this.OQhcXFIIW5A.isMine)
			{
				if (359 - 570905 != -570545)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (240208 - 431401 != -191192)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (223872 - 375993 == -152121)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (238876 - 131997 == 106879)
						{
							CharacterControl characterControl = null;
							if (24618 - 234927 == -210309)
							{
								int tID = 0;
								if (130442 - 252576 == -122134)
								{
									if (gameObject)
									{
										if (190281 - 413183 != -222902)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (123846 - 130813 != -6967)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (260724 - 456367 != -195643)
										{
											continue;
										}
										tID = characterControl.ActorNr;
										if (143415 - 161995 == -18579)
										{
											continue;
										}
									}
									if (!(this.OQhcXFIIW5A.actionState == "standby"))
									{
										if (247435 - 388341 == -140905)
										{
											continue;
										}
										if (!(this.OQhcXFIIW5A.actionState == "run"))
										{
											break;
										}
										if (174662 - 258128 == -83465)
										{
											continue;
										}
									}
									if (Game.mGameType < 4)
									{
										if (245207 - 58035 != 187173)
										{
											Camera.main.SendMessage("newGameMessage", "Cannot do normal attack here");
											if (20953 - 117788 != -96834)
											{
												break;
											}
										}
									}
									else
									{
										if (this.OQhcXFIIW5A.isTimeOut("galaxyBlade") == (float)0)
										{
											if (247948 - 472765 == -224816)
											{
												continue;
											}
											if (this.OQhcXFIIW5A.sp >= 80)
											{
												if (102261 - 106137 != -3876)
												{
													continue;
												}
												this.OQhcXFIIW5A.sp = this.OQhcXFIIW5A.sp - 80;
												if (256296 - 351891 == -95594)
												{
													continue;
												}
												this.StartCoroutine_Auto(this.RPC_galaxyBlade(this.transform.position, vector.normalized, tID));
												if (281033 - 344566 != -63533)
												{
													continue;
												}
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (227280 - 399899 == -172618)
												{
													continue;
												}
												this.ActionEvent("RPC_galaxyBlade", this.transform.position, vector.normalized, tID);
												if (91270 - 66020 != 25251)
												{
													break;
												}
												continue;
											}
										}
										if (this.OQhcXFIIW5A.sp >= 30)
										{
											if (12216 - 199156 != -186939)
											{
												if (vector.sqrMagnitude <= (float)100)
												{
													if (8516 - 246944 != -238427)
													{
														if (this.OQhcXFIIW5A.isTimeOut("drillPunch") != (float)0)
														{
															if (103753 - 291404 == -187651)
															{
																Camera.main.SendMessage("newGameMessage", "DrillPunch timeout!");
																if (248626 - 468383 == -219757)
																{
																	break;
																}
															}
														}
														else
														{
															this.OQhcXFIIW5A.sp = this.OQhcXFIIW5A.sp - 30;
															if (40476 - 444201 != -403724)
															{
																this.StartCoroutine_Auto(this.RPC_drillPunch(this.transform.position, vector.normalized, tID));
																if (58230 - 153023 == -94793)
																{
																	if (!PhotonClient.IsInitialized())
																	{
																		break;
																	}
																	if (146564 - 472758 == -326194)
																	{
																		this.ActionEvent("RPC_drillPunch", this.transform.position, vector.normalized, tID);
																		if (112754 - 353989 == -241235)
																		{
																			break;
																		}
																	}
																}
															}
														}
													}
												}
												else if (this.OQhcXFIIW5A.isTimeOut("clawPincer") != (float)0)
												{
													if (111411 - 307313 == -195902)
													{
														Camera.main.SendMessage("newGameMessage", "ClawPincer timeout!");
														if (72674 - 571775 != -499100)
														{
															break;
														}
													}
												}
												else
												{
													this.OQhcXFIIW5A.sp = this.OQhcXFIIW5A.sp - 30;
													if (137712 - 248695 == -110983)
													{
														this.StartCoroutine_Auto(this.RPC_clawPincer(this.transform.position, vector.normalized, tID));
														if (266441 - 322401 != -55959)
														{
															if (!PhotonClient.IsInitialized())
															{
																break;
															}
															if (16725 - 26815 != -10089)
															{
																this.ActionEvent("RPC_clawPincer", this.transform.position, vector.normalized, tID);
																if (73533 - 72338 == 1195)
																{
																	break;
																}
															}
														}
													}
												}
											}
										}
										else
										{
											Camera.main.SendMessage("newGameMessage", "Not enough sp.");
											if (194689 - 238376 == -43687)
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

	// Token: 0x06005A06 RID: 23046 RVA: 0x00ACF47C File Offset: 0x00ACD67C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06005A07 RID: 23047 RVA: 0x00ACF480 File Offset: 0x00ACD680
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack1(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new RangerRobotMount.$RPC_nAttack1$35496(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06005A08 RID: 23048 RVA: 0x00ACF490 File Offset: 0x00ACD690
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack2(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new RangerRobotMount.$RPC_nAttack2$35509(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06005A09 RID: 23049 RVA: 0x00ACF4A0 File Offset: 0x00ACD6A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (84113 - 271175 != -187062)
		{
		}
		for (;;)
		{
			if (this.nAttack_hit)
			{
				if (297632 - 332369 == -34736)
				{
					continue;
				}
				UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, Quaternion.LookRotation(hitDir));
				if (34751 - 123131 == -88379)
				{
					continue;
				}
			}
			else
			{
				Debug.LogError("Missing nAttack_hit effect");
				if (145668 - 219564 != -73896)
				{
					continue;
				}
			}
			if (Time.time <= this.gAIcX9MpTVM)
			{
				break;
			}
			if (23875 - 15698 != 8178)
			{
				this.gAIcX9MpTVM = Time.time + 0.1f;
				if (100853 - 445550 != -344696)
				{
					if (!this.nAttack_hitFX)
					{
						break;
					}
					if (34904 - 124119 != -89214)
					{
						this.audio.PlayOneShot(this.nAttack_hitFX);
						if (127601 - 128100 != -498)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x06005A0A RID: 23050 RVA: 0x00ACF604 File Offset: 0x00ACD804
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_drillPunch(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new RangerRobotMount.$RPC_drillPunch$35521(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06005A0B RID: 23051 RVA: 0x00ACF614 File Offset: 0x00ACD814
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_clawPincer(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new RangerRobotMount.$RPC_clawPincer$35533(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06005A0C RID: 23052 RVA: 0x00ACF624 File Offset: 0x00ACD824
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_galaxyBlade(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new RangerRobotMount.$RPC_galaxyBlade$35547(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06005A0D RID: 23053 RVA: 0x00ACF634 File Offset: 0x00ACD834
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_summon(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new RangerRobotMount.$RPC_summon$35558(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06005A0E RID: 23054 RVA: 0x00ACF644 File Offset: 0x00ACD844
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new RangerRobotMount.$RPC_ko$35565(nArray, this).GetEnumerator();
	}

	// Token: 0x06005A0F RID: 23055 RVA: 0x00ACF654 File Offset: 0x00ACD854
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new RangerRobotMount.$RPC_dead$35572(nArray, this).GetEnumerator();
	}

	// Token: 0x06005A10 RID: 23056 RVA: 0x00ACF664 File Offset: 0x00ACD864
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06005A11 RID: 23057 RVA: 0x00ACF668 File Offset: 0x00ACD868
	internal static bool R6eAFqpV1hO006TyP3xC()
	{
		return true;
	}

	// Token: 0x06005A12 RID: 23058 RVA: 0x00ACF66C File Offset: 0x00ACD86C
	internal static bool WUuN7KpV4uOK2sBtWiLN()
	{
		return false;
	}

	// Token: 0x04006340 RID: 25408
	private Transform yHlcXkPjQKX;

	// Token: 0x04006341 RID: 25409
	private CharacterControl OQhcXFIIW5A;

	// Token: 0x04006342 RID: 25410
	private float QuvcXAi0pqK;

	// Token: 0x04006343 RID: 25411
	public AudioClip footStep_left;

	// Token: 0x04006344 RID: 25412
	public AudioClip footStep_right;

	// Token: 0x04006345 RID: 25413
	public GameObject nAttack1_ring;

	// Token: 0x04006346 RID: 25414
	public GameObject nAttack2_ring;

	// Token: 0x04006347 RID: 25415
	public GameObject nAttack_hit;

	// Token: 0x04006348 RID: 25416
	public AudioClip nAttack_hitFX;

	// Token: 0x04006349 RID: 25417
	private float gAIcX9MpTVM;

	// Token: 0x0400634A RID: 25418
	public GameObject drillPunch_ring;

	// Token: 0x0400634B RID: 25419
	public GameObject clawPincer_ring;

	// Token: 0x0400634C RID: 25420
	public GameObject clawPincer_hit;

	// Token: 0x0400634D RID: 25421
	public GameObject galaxyBlade_ring;

	// Token: 0x0400634E RID: 25422
	public GameObject summon_ring;

	// Token: 0x0400634F RID: 25423
	public GameObject deadEffect;

	// Token: 0x02000F80 RID: 3968
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack1$35496 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005A13 RID: 23059 RVA: 0x00ACF670 File Offset: 0x00ACD870
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack1$35496(Vector3 mPos, Vector3 tDir, RangerRobotMount self_)
		{
			if (75921 - 107633 != -31712)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (113091 - 245144 == -132053)
				{
					base..ctor();
					if (180624 - 571668 != -391043)
					{
						this.$mPos$35506 = mPos;
						if (257957 - 205469 != 52489)
						{
							this.$tDir$35507 = tDir;
							if (194018 - 311740 == -117722)
							{
								this.$self_$35508 = self_;
								if (39842 - 10029 == 29813)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06005A14 RID: 23060 RVA: 0x00ACF74C File Offset: 0x00ACD94C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new RangerRobotMount.$RPC_nAttack1$35496.$(this.$mPos$35506, this.$tDir$35507, this.$self_$35508);
		}

		// Token: 0x06005A15 RID: 23061 RVA: 0x00ACF768 File Offset: 0x00ACD968
		internal static bool for4NmpVzAhIRhb5COJ2()
		{
			return true;
		}

		// Token: 0x06005A16 RID: 23062 RVA: 0x00ACF76C File Offset: 0x00ACD96C
		internal static bool EY7W7kptaOZkyueHTDsd()
		{
			return false;
		}

		// Token: 0x04006350 RID: 25424
		internal Vector3 $mPos$35506;

		// Token: 0x04006351 RID: 25425
		internal Vector3 $tDir$35507;

		// Token: 0x04006352 RID: 25426
		internal RangerRobotMount $self_$35508;

		// Token: 0x02000F81 RID: 3969
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005A17 RID: 23063 RVA: 0x00ACF770 File Offset: 0x00ACD970
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, RangerRobotMount self_)
			{
				if (220895 - 167779 != 53116)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (67018 - 297025 == -230007)
					{
						base..ctor();
						if (173828 - 110250 == 63578)
						{
							this.$mPos$35503 = mPos;
							if (88325 - 272352 == -184027)
							{
								this.$tDir$35504 = tDir;
								if (189980 - 40958 != 149023)
								{
									this.$self_$35505 = self_;
									if (195637 - 548728 == -353091)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06005A18 RID: 23064 RVA: 0x00ACF84C File Offset: 0x00ACDA4C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (202457 - 303068 != -100611)
				{
				}
				for (;;)
				{
					IL_85:
					switch (this._state)
					{
					case 0:
						goto IL_5AC;
					case 1:
						goto IL_9A3;
					case 2:
						if (this.$self_$35505.OQhcXFIIW5A.actionState != "attack")
						{
							goto IL_5DB;
						}
						if (181535 - 183738 == -2202)
						{
							continue;
						}
						if (this.$self_$35505.OQhcXFIIW5A.myCommand != "nAttack1")
						{
							if (166483 - 194058 != -27575)
							{
								continue;
							}
							goto IL_5DB;
						}
						else
						{
							this.$i$35497 = 0;
							if (107010 - 193833 == -86822)
							{
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$35505.OQhcXFIIW5A.actionState != "attack")
						{
							goto IL_51D;
						}
						if (122146 - 428014 != -305868)
						{
							continue;
						}
						if (this.$self_$35505.OQhcXFIIW5A.myCommand != "nAttack1")
						{
							if (95135 - 533337 != -438202)
							{
								continue;
							}
							goto IL_51D;
						}
						else
						{
							this.$i$35497++;
							if (93334 - 251445 != -158111)
							{
								continue;
							}
						}
						break;
					case 4:
						if (this.$self_$35505.OQhcXFIIW5A.actionState == "attack")
						{
							if (239205 - 283695 != -44490)
							{
								continue;
							}
							if (this.$self_$35505.OQhcXFIIW5A.myCommand == "nAttack1")
							{
								if (10924 - 147599 != -136675)
								{
									continue;
								}
								this.$self_$35505.OQhcXFIIW5A.actionState = "standby";
								if (53847 - 413773 == -359925)
								{
									continue;
								}
								this.$self_$35505.OQhcXFIIW5A.actionTime = Time.time;
								if (286215 - 157719 == 128497)
								{
									continue;
								}
								this.$self_$35505.OQhcXFIIW5A.myCommand = "none";
								if (128935 - 299669 != -170734)
								{
									continue;
								}
								if (!this.$self_$35505.OQhcXFIIW5A.isMine)
								{
									if (193795 - 584508 == -390712)
									{
										continue;
									}
									this.$self_$35505.OQhcXFIIW5A.nPosition = this.$self_$35505.transform.position;
									if (241408 - 338225 == -96816)
									{
										continue;
									}
									this.$self_$35505.OQhcXFIIW5A.oPosition = this.$self_$35505.transform.position;
									if (67890 - 570911 == -503020)
									{
										continue;
									}
									this.$self_$35505.OQhcXFIIW5A.nDirection = this.$self_$35505.transform.forward;
									if (54867 - 228637 == -173769)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (12882 - 423704 != -410821)
						{
							goto Block_34;
						}
						continue;
					default:
						if (149725 - 484077 != -334352)
						{
							continue;
						}
						goto IL_5AC;
					}
					if (this.$i$35497 >= 2)
					{
						if (160727 - 557330 != -396603)
						{
							continue;
						}
						break;
					}
					else
					{
						if (!this.$self_$35505.OQhcXFIIW5A.isMine)
						{
							goto IL_768;
						}
						if (269182 - 138000 == 131183)
						{
							continue;
						}
						this.$hitLayer$35498 = 130816 - (1 << this.$self_$35505.gameObject.layer);
						if (119517 - 74015 != 45502)
						{
							continue;
						}
						this.$hitList$35499 = Damage.FindAreaTarget(this.$mPos$35503 + this.$self_$35505.transform.TransformDirection(-0.5f, (float)0, (float)2), (float)3, (float)3, this.$hitLayer$35498);
						if (42174 - 411388 == -369213)
						{
							continue;
						}
						this.$$iterator$10921$35502 = UnityRuntimeServices.GetEnumerator(this.$hitList$35499);
						if (251924 - 65698 == 186227)
						{
							continue;
						}
						while (this.$$iterator$10921$35502.MoveNext())
						{
							object obj2;
							object obj = obj2 = this.$$iterator$10921$35502.Current;
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$hitObject$35500 = (GameObject)obj2;
							if (2150 - 63871 != -61721)
							{
								goto IL_85;
							}
							if (this.$self_$35505.OQhcXFIIW5A.hit(1, this.$hitObject$35500, this.$self_$35505.OQhcXFIIW5A.atk, 5, 0, Vector3.zero) != 0)
							{
								if (163479 - 90007 == 73473)
								{
									goto IL_85;
								}
								this.$hitPoint$35501 = this.$hitObject$35500.collider.ClosestPointOnBounds(this.$self_$35505.transform.position + (float)2 * Vector3.up);
								if (90915 - 455283 == -364367)
								{
									goto IL_85;
								}
								UnityRuntimeServices.Update(this.$$iterator$10921$35502, this.$hitObject$35500);
								if (233064 - 104689 != 128375)
								{
									goto IL_85;
								}
								this.$self_$35505.RPC_nAttack_hit(this.$hitPoint$35501, this.$self_$35505.transform.forward, 0);
								if (149930 - 431218 != -281288)
								{
									goto IL_85;
								}
								this.$self_$35505.ActionEvent("RPC_nAttack_hit", this.$hitPoint$35501, this.$self_$35505.transform.forward, 0);
								if (249920 - 104200 != 145720)
								{
									goto IL_85;
								}
								this.$self_$35505.OQhcXFIIW5A.sp = this.$self_$35505.OQhcXFIIW5A.sp + 1;
								if (4954 - 564360 == -559405)
								{
									goto IL_85;
								}
							}
						}
						if (268979 - 113731 != 155249)
						{
							goto Block_26;
						}
						continue;
					}
					IL_5AC:
					this.$self_$35505.OQhcXFIIW5A.actionState = "attack";
					if (67545 - 240982 != -173436)
					{
						this.$self_$35505.OQhcXFIIW5A.actionTime = Time.time;
						if (51078 - 22869 == 28209)
						{
							this.$self_$35505.OQhcXFIIW5A.myCommand = "nAttack1";
							if (248233 - 177541 == 70692)
							{
								this.$self_$35505.OQhcXFIIW5A.addTimeOut("nAttack", 1f);
								if (57721 - 281729 != -224007)
								{
									this.$self_$35505.transform.position = this.$mPos$35503;
									if (65104 - 32752 != 32353)
									{
										this.$self_$35505.transform.LookAt(this.$mPos$35503 + global::Math.vFlat(this.$tDir$35504));
										if (200472 - 561261 == -360789)
										{
											this.$self_$35505.animation.Rewind();
											if (243849 - 572578 != -328728)
											{
												this.$self_$35505.animation.CrossFade("nAttack1", 0.1f);
												if (100683 - 100399 == 284)
												{
													this.$self_$35505.animation.wrapMode = WrapMode.Once;
													if (204549 - 409461 == -204912)
													{
														this.$self_$35505.OQhcXFIIW5A.vMovement = this.$self_$35505.transform.forward;
														if (164380 - 164413 != -32)
														{
															this.$self_$35505.OQhcXFIIW5A.moveSpeed = (float)0;
															if (153653 - 80650 != 73004)
															{
																if (this.$self_$35505.nAttack1_ring)
																{
																	if (94827 - 81841 != 12987)
																	{
																		this.$self_$35505.OQhcXFIIW5A.createEffect(this.$self_$35505.nAttack1_ring, this.$self_$35505.transform.position, this.$self_$35505.transform.rotation);
																		if (85879 - 157729 != -71849)
																		{
																			goto Block_58;
																		}
																	}
																}
																else
																{
																	Debug.LogError("Missing nAttack1 ring effect");
																	if (40277 - 103350 != -63072)
																	{
																		goto Block_29;
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				return this.Yield(4, new WaitForSeconds(0.3f));
				IL_13C:
				return this.Yield(2, new WaitForSeconds(0.6f));
				Block_26:
				goto IL_768;
				Block_29:
				goto IL_13C;
				IL_51D:
				Block_34:
				IL_5DB:
				goto IL_9A3;
				IL_768:
				return this.Yield(3, new WaitForSeconds(0.1f));
				Block_58:
				goto IL_13C;
				IL_9A3:
				return false;
			}

			// Token: 0x06005A19 RID: 23065 RVA: 0x00AD0210 File Offset: 0x00ACE410
			internal static bool Aup0jrpt5xqSUX5uDj3m()
			{
				return true;
			}

			// Token: 0x06005A1A RID: 23066 RVA: 0x00AD0214 File Offset: 0x00ACE414
			internal static bool QNWAbfptp2Q7uWo4neU1()
			{
				return false;
			}

			// Token: 0x04006353 RID: 25427
			internal int $i$35497;

			// Token: 0x04006354 RID: 25428
			internal int $hitLayer$35498;

			// Token: 0x04006355 RID: 25429
			internal UnityScript.Lang.Array $hitList$35499;

			// Token: 0x04006356 RID: 25430
			internal GameObject $hitObject$35500;

			// Token: 0x04006357 RID: 25431
			internal Vector3 $hitPoint$35501;

			// Token: 0x04006358 RID: 25432
			internal IEnumerator $$iterator$10921$35502;

			// Token: 0x04006359 RID: 25433
			internal Vector3 $mPos$35503;

			// Token: 0x0400635A RID: 25434
			internal Vector3 $tDir$35504;

			// Token: 0x0400635B RID: 25435
			internal RangerRobotMount $self_$35505;
		}
	}

	// Token: 0x02000F82 RID: 3970
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack2$35509 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005A1B RID: 23067 RVA: 0x00AD0218 File Offset: 0x00ACE418
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack2$35509(Vector3 mPos, Vector3 tDir, RangerRobotMount self_)
		{
			if (80415 - 80826 != -411)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (216543 - 10830 == 205713)
				{
					base..ctor();
					if (174840 - 246238 == -71398)
					{
						this.$mPos$35518 = mPos;
						if (274217 - 557928 == -283711)
						{
							this.$tDir$35519 = tDir;
							if (284317 - 543175 == -258858)
							{
								this.$self_$35520 = self_;
								if (298383 - 592124 != -293740)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06005A1C RID: 23068 RVA: 0x00AD02F4 File Offset: 0x00ACE4F4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new RangerRobotMount.$RPC_nAttack2$35509.$(this.$mPos$35518, this.$tDir$35519, this.$self_$35520);
		}

		// Token: 0x06005A1D RID: 23069 RVA: 0x00AD0310 File Offset: 0x00ACE510
		internal static bool wa2XO3ptV1cNA3Q6PMDc()
		{
			return true;
		}

		// Token: 0x06005A1E RID: 23070 RVA: 0x00AD0314 File Offset: 0x00ACE514
		internal static bool NeNnB6pttpm1Ic5XlsBh()
		{
			return false;
		}

		// Token: 0x0400635C RID: 25436
		internal Vector3 $mPos$35518;

		// Token: 0x0400635D RID: 25437
		internal Vector3 $tDir$35519;

		// Token: 0x0400635E RID: 25438
		internal RangerRobotMount $self_$35520;

		// Token: 0x02000F83 RID: 3971
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005A1F RID: 23071 RVA: 0x00AD0318 File Offset: 0x00ACE518
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, RangerRobotMount self_)
			{
				if (117570 - 42166 != 75405)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (10457 - 565574 == -555117)
					{
						base..ctor();
						if (263913 - 325574 != -61660)
						{
							this.$mPos$35515 = mPos;
							if (168184 - 472896 != -304711)
							{
								this.$tDir$35516 = tDir;
								if (48627 - 307291 != -258663)
								{
									this.$self_$35517 = self_;
									if (229336 - 68750 != 160587)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06005A20 RID: 23072 RVA: 0x00AD03F4 File Offset: 0x00ACE5F4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (86816 - 180122 != -93306)
				{
				}
				for (;;)
				{
					IL_69:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_8AA;
					case 2:
						if (this.$self_$35517.OQhcXFIIW5A.actionState != "attack")
						{
							goto IL_32E;
						}
						if (269179 - 541865 != -272686)
						{
							continue;
						}
						if (this.$self_$35517.OQhcXFIIW5A.myCommand != "nAttack2")
						{
							if (143168 - 18183 != 124986)
							{
								goto Block_36;
							}
							continue;
						}
						else
						{
							if (!this.$self_$35517.OQhcXFIIW5A.isMine)
							{
								goto IL_1A;
							}
							if (261133 - 584546 == -323412)
							{
								continue;
							}
							this.$hitLayer$35510 = 130816 - (1 << this.$self_$35517.gameObject.layer);
							if (180382 - 550823 != -370441)
							{
								continue;
							}
							this.$hitList$35511 = Damage.FindRecTarget(this.$mPos$35515, this.$self_$35517.transform.forward, (float)2, (float)2, (float)5, (float)4, this.$hitLayer$35510);
							if (145345 - 328970 == -183624)
							{
								continue;
							}
							this.$$iterator$10922$35514 = UnityRuntimeServices.GetEnumerator(this.$hitList$35511);
							if (60442 - 276603 == -216160)
							{
								continue;
							}
							while (this.$$iterator$10922$35514.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10922$35514.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$35512 = (GameObject)obj2;
								if (197399 - 11469 == 185931)
								{
									goto IL_69;
								}
								if (this.$self_$35517.OQhcXFIIW5A.hit(11, this.$hitObject$35512, 2 * this.$self_$35517.OQhcXFIIW5A.atk, 10, 0, (float)5 * this.$self_$35517.transform.forward) != 0)
								{
									if (141471 - 160954 == -19482)
									{
										goto IL_69;
									}
									this.$hitPoint$35513 = this.$hitObject$35512.collider.ClosestPointOnBounds(this.$self_$35517.transform.position + (float)4 * Vector3.up);
									if (56849 - 337456 == -280606)
									{
										goto IL_69;
									}
									UnityRuntimeServices.Update(this.$$iterator$10922$35514, this.$hitObject$35512);
									if (183747 - 437947 != -254200)
									{
										goto IL_69;
									}
									this.$self_$35517.RPC_nAttack_hit(this.$hitPoint$35513, this.$self_$35517.transform.forward, 0);
									if (5240 - 585778 != -580538)
									{
										goto IL_69;
									}
									this.$self_$35517.ActionEvent("RPC_nAttack_hit", this.$hitPoint$35513, this.$self_$35517.transform.forward, 0);
									if (203462 - 258057 != -54595)
									{
										goto IL_69;
									}
									this.$self_$35517.OQhcXFIIW5A.sp = this.$self_$35517.OQhcXFIIW5A.sp + 1;
									if (162957 - 521550 != -358593)
									{
										goto IL_69;
									}
								}
							}
							if (126426 - 349723 != -223296)
							{
								goto Block_9;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$35517.OQhcXFIIW5A.actionState == "attack")
						{
							if (32450 - 231810 == -199359)
							{
								continue;
							}
							if (this.$self_$35517.OQhcXFIIW5A.myCommand == "nAttack2")
							{
								if (296853 - 229106 == 67748)
								{
									continue;
								}
								this.$self_$35517.OQhcXFIIW5A.actionState = "standby";
								if (103671 - 78272 == 25400)
								{
									continue;
								}
								this.$self_$35517.OQhcXFIIW5A.actionTime = Time.time;
								if (135409 - 339552 == -204142)
								{
									continue;
								}
								this.$self_$35517.OQhcXFIIW5A.myCommand = "none";
								if (10177 - 72297 != -62120)
								{
									continue;
								}
								if (!this.$self_$35517.OQhcXFIIW5A.isMine)
								{
									if (128310 - 72371 != 55939)
									{
										continue;
									}
									this.$self_$35517.OQhcXFIIW5A.nPosition = this.$self_$35517.transform.position;
									if (209271 - 112706 != 96565)
									{
										continue;
									}
									this.$self_$35517.OQhcXFIIW5A.oPosition = this.$self_$35517.transform.position;
									if (290714 - 552152 == -261437)
									{
										continue;
									}
									this.$self_$35517.OQhcXFIIW5A.nDirection = this.$self_$35517.transform.forward;
									if (15871 - 247699 == -231827)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (127082 - 135351 != -8268)
						{
							goto Block_22;
						}
						continue;
					default:
						if (176537 - 276900 != -100363)
						{
							continue;
						}
						break;
					}
					this.$self_$35517.OQhcXFIIW5A.actionState = "attack";
					if (119356 - 514894 == -395538)
					{
						this.$self_$35517.OQhcXFIIW5A.actionTime = Time.time;
						if (196815 - 32554 == 164261)
						{
							this.$self_$35517.OQhcXFIIW5A.myCommand = "nAttack2";
							if (110255 - 260152 != -149896)
							{
								this.$self_$35517.OQhcXFIIW5A.addTimeOut("nAttack", 1f);
								if (85054 - 438168 != -353113)
								{
									this.$self_$35517.transform.position = this.$mPos$35515;
									if (269989 - 26136 != 243854)
									{
										this.$self_$35517.transform.LookAt(this.$mPos$35515 + global::Math.vFlat(this.$tDir$35516));
										if (294073 - 142438 != 151636)
										{
											this.$self_$35517.animation.Rewind();
											if (5285 - 274807 != -269521)
											{
												this.$self_$35517.animation.CrossFade("nAttack2", 0.1f);
												if (91642 - 220716 != -129073)
												{
													this.$self_$35517.animation.wrapMode = WrapMode.Once;
													if (18732 - 518896 != -500163)
													{
														this.$self_$35517.OQhcXFIIW5A.vMovement = this.$self_$35517.transform.forward;
														if (251087 - 134838 == 116249)
														{
															this.$self_$35517.OQhcXFIIW5A.moveSpeed = (float)0;
															if (263728 - 77180 == 186548)
															{
																if (this.$self_$35517.nAttack2_ring)
																{
																	if (226224 - 156685 != 69540)
																	{
																		this.$self_$35517.OQhcXFIIW5A.createEffect(this.$self_$35517.nAttack2_ring, this.$self_$35517.transform.position, this.$self_$35517.transform.rotation);
																		if (159139 - 61702 != 97438)
																		{
																			goto Block_41;
																		}
																	}
																}
																else
																{
																	Debug.LogError("Missing nAttack2 ring effect");
																	if (181581 - 285838 == -104257)
																	{
																		goto IL_7C3;
																	}
																}
															}
														}
													}
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
				return this.Yield(3, new WaitForSeconds(0.4f));
				Block_9:
				goto IL_1A;
				IL_32E:
				goto IL_8AA;
				Block_22:
				Block_36:
				goto IL_32E;
				Block_41:
				IL_7C3:
				return this.Yield(2, new WaitForSeconds(0.6f));
				IL_8AA:
				return false;
			}

			// Token: 0x06005A21 RID: 23073 RVA: 0x00AD0CC0 File Offset: 0x00ACEEC0
			internal static bool UxqtXVptNGAQ7IZBN3Zo()
			{
				return true;
			}

			// Token: 0x06005A22 RID: 23074 RVA: 0x00AD0CC4 File Offset: 0x00ACEEC4
			internal static bool mkFXLUptYTgT0GaF1S8h()
			{
				return false;
			}

			// Token: 0x0400635F RID: 25439
			internal int $hitLayer$35510;

			// Token: 0x04006360 RID: 25440
			internal UnityScript.Lang.Array $hitList$35511;

			// Token: 0x04006361 RID: 25441
			internal GameObject $hitObject$35512;

			// Token: 0x04006362 RID: 25442
			internal Vector3 $hitPoint$35513;

			// Token: 0x04006363 RID: 25443
			internal IEnumerator $$iterator$10922$35514;

			// Token: 0x04006364 RID: 25444
			internal Vector3 $mPos$35515;

			// Token: 0x04006365 RID: 25445
			internal Vector3 $tDir$35516;

			// Token: 0x04006366 RID: 25446
			internal RangerRobotMount $self_$35517;
		}
	}

	// Token: 0x02000F84 RID: 3972
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_drillPunch$35521 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005A23 RID: 23075 RVA: 0x00AD0CC8 File Offset: 0x00ACEEC8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_drillPunch$35521(Vector3 mPos, Vector3 tDir, RangerRobotMount self_)
		{
			if (75338 - 581244 != -505905)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (125323 - 235518 != -110194)
				{
					base..ctor();
					if (72984 - 521214 != -448229)
					{
						this.$mPos$35530 = mPos;
						if (149542 - 299157 != -149614)
						{
							this.$tDir$35531 = tDir;
							if (53430 - 421847 == -368417)
							{
								this.$self_$35532 = self_;
								if (290261 - 62837 == 227424)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06005A24 RID: 23076 RVA: 0x00AD0DA4 File Offset: 0x00ACEFA4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new RangerRobotMount.$RPC_drillPunch$35521.$(this.$mPos$35530, this.$tDir$35531, this.$self_$35532);
		}

		// Token: 0x06005A25 RID: 23077 RVA: 0x00AD0DC0 File Offset: 0x00ACEFC0
		internal static bool R3JhRHptcEM3Bl10FkUU()
		{
			return true;
		}

		// Token: 0x06005A26 RID: 23078 RVA: 0x00AD0DC4 File Offset: 0x00ACEFC4
		internal static bool pYk3r0ptUxTdUkJ8X7tl()
		{
			return false;
		}

		// Token: 0x04006367 RID: 25447
		internal Vector3 $mPos$35530;

		// Token: 0x04006368 RID: 25448
		internal Vector3 $tDir$35531;

		// Token: 0x04006369 RID: 25449
		internal RangerRobotMount $self_$35532;

		// Token: 0x02000F85 RID: 3973
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005A27 RID: 23079 RVA: 0x00AD0DC8 File Offset: 0x00ACEFC8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, RangerRobotMount self_)
			{
				if (284193 - 510213 != -226020)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (16848 - 534821 != -517972)
					{
						base..ctor();
						if (7128 - 28343 == -21215)
						{
							this.$mPos$35527 = mPos;
							if (81121 - 547399 != -466277)
							{
								this.$tDir$35528 = tDir;
								if (99205 - 514498 != -415292)
								{
									this.$self_$35529 = self_;
									if (113591 - 25721 != 87871)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06005A28 RID: 23080 RVA: 0x00AD0EA4 File Offset: 0x00ACF0A4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (66018 - 85429 != -19411)
				{
				}
				for (;;)
				{
					IL_791:
					switch (this._state)
					{
					case 0:
						goto IL_1C8;
					case 1:
						goto IL_9B8;
					case 2:
						if (this.$self_$35529.OQhcXFIIW5A.actionState != "attack")
						{
							goto IL_639;
						}
						if (139926 - 398479 != -258553)
						{
							continue;
						}
						if (this.$self_$35529.OQhcXFIIW5A.myCommand != "drillPunch")
						{
							if (92125 - 5536 != 86590)
							{
								goto Block_54;
							}
							continue;
						}
						else
						{
							this.$self_$35529.OQhcXFIIW5A.moveSpeed = (float)6;
							if (128831 - 475848 != -347017)
							{
								continue;
							}
							this.$i$35522 = 0;
							if (25145 - 10702 == 14444)
							{
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$35529.OQhcXFIIW5A.actionState != "attack")
						{
							goto IL_1F7;
						}
						if (244876 - 310736 == -65859)
						{
							continue;
						}
						if (this.$self_$35529.OQhcXFIIW5A.myCommand != "drillPunch")
						{
							if (5207 - 238810 != -233602)
							{
								goto Block_33;
							}
							continue;
						}
						else
						{
							if (this.$i$35522 == 4)
							{
								if (169985 - 60862 == 109124)
								{
									continue;
								}
								this.$self_$35529.OQhcXFIIW5A.moveSpeed = (float)4;
								if (170545 - 258217 == -87671)
								{
									continue;
								}
							}
							if (this.$i$35522 == 5)
							{
								if (110026 - 333330 != -223304)
								{
									continue;
								}
								this.$self_$35529.OQhcXFIIW5A.moveSpeed = (float)2;
								if (97379 - 42428 != 54951)
								{
									continue;
								}
							}
							if (this.$i$35522 == 6)
							{
								if (218281 - 111145 == 107137)
								{
									continue;
								}
								this.$self_$35529.OQhcXFIIW5A.moveSpeed = (float)0;
								if (22956 - 322746 != -299790)
								{
									continue;
								}
							}
							this.$i$35522++;
							if (257844 - 284205 != -26361)
							{
								continue;
							}
						}
						break;
					case 4:
						if (this.$self_$35529.OQhcXFIIW5A.actionState == "attack")
						{
							if (270441 - 272825 != -2384)
							{
								continue;
							}
							if (this.$self_$35529.OQhcXFIIW5A.myCommand == "drillPunch")
							{
								if (179740 - 169264 != 10476)
								{
									continue;
								}
								this.$self_$35529.OQhcXFIIW5A.actionState = "standby";
								if (163867 - 46970 == 116898)
								{
									continue;
								}
								this.$self_$35529.OQhcXFIIW5A.actionTime = Time.time;
								if (277685 - 480549 != -202864)
								{
									continue;
								}
								this.$self_$35529.OQhcXFIIW5A.myCommand = "none";
								if (122955 - 109552 != 13403)
								{
									continue;
								}
								if (!this.$self_$35529.OQhcXFIIW5A.isMine)
								{
									if (91136 - 159977 != -68841)
									{
										continue;
									}
									this.$self_$35529.OQhcXFIIW5A.nPosition = this.$self_$35529.transform.position;
									if (190100 - 472109 != -282009)
									{
										continue;
									}
									this.$self_$35529.OQhcXFIIW5A.oPosition = this.$self_$35529.transform.position;
									if (103008 - 125055 != -22047)
									{
										continue;
									}
									this.$self_$35529.OQhcXFIIW5A.nDirection = this.$self_$35529.transform.forward;
									if (269551 - 310806 != -41255)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (124455 - 397943 != -273487)
						{
							goto Block_24;
						}
						continue;
					default:
						if (246876 - 160691 != 86185)
						{
							continue;
						}
						goto IL_1C8;
					}
					if (this.$i$35522 >= 7)
					{
						if (101186 - 445058 != -343871)
						{
							goto Block_42;
						}
						continue;
					}
					else
					{
						if (!this.$self_$35529.OQhcXFIIW5A.isMine)
						{
							goto IL_301;
						}
						if (235805 - 273106 != -37301)
						{
							continue;
						}
						this.$hitLayer$35523 = 130816 - (1 << this.$self_$35529.gameObject.layer);
						if (213327 - 437092 != -223765)
						{
							continue;
						}
						this.$hitList$35524 = Damage.FindRecTarget(this.$mPos$35527, this.$self_$35529.transform.forward, (float)3, (float)3, (float)6, (float)3, this.$hitLayer$35523);
						if (43346 - 456787 != -413441)
						{
							continue;
						}
						this.$$iterator$10923$35526 = UnityRuntimeServices.GetEnumerator(this.$hitList$35524);
						if (235391 - 11364 != 224027)
						{
							continue;
						}
						while (this.$$iterator$10923$35526.MoveNext())
						{
							object obj2;
							object obj = obj2 = this.$$iterator$10923$35526.Current;
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$hitObject$35525 = (GameObject)obj2;
							if (201253 - 345866 != -144613)
							{
								goto IL_791;
							}
							if (this.$self_$35529.OQhcXFIIW5A.hit(11, this.$hitObject$35525, 2 * this.$self_$35529.OQhcXFIIW5A.atk + this.$self_$35529.OQhcXFIIW5A.talAdjust(30), 10, 0, this.$self_$35529.transform.forward) != 0)
							{
								if (168453 - 452732 == -284278)
								{
									goto IL_791;
								}
								this.$self_$35529.OQhcXFIIW5A.sp = this.$self_$35529.OQhcXFIIW5A.sp + 1;
								if (208081 - 466487 != -258406)
								{
									goto IL_791;
								}
							}
						}
						if (258036 - 554370 != -296333)
						{
							goto Block_29;
						}
						continue;
					}
					IL_1C8:
					this.$self_$35529.OQhcXFIIW5A.actionState = "attack";
					if (240188 - 168232 == 71956)
					{
						this.$self_$35529.OQhcXFIIW5A.actionTime = Time.time;
						if (267305 - 318210 != -50904)
						{
							this.$self_$35529.OQhcXFIIW5A.myCommand = "drillPunch";
							if (286935 - 522915 == -235980)
							{
								this.$self_$35529.OQhcXFIIW5A.addTimeOut("drillPunch", (float)10);
								if (251062 - 555640 != -304577)
								{
									this.$self_$35529.transform.position = this.$mPos$35527;
									if (4632 - 133362 == -128730)
									{
										this.$self_$35529.transform.LookAt(this.$mPos$35527 + global::Math.vFlat(this.$tDir$35528));
										if (189820 - 144630 != 45191)
										{
											this.$self_$35529.animation.CrossFade("drillPunch", 0.1f);
											if (95921 - 94504 != 1418)
											{
												this.$self_$35529.animation.wrapMode = WrapMode.Once;
												if (51546 - 395924 == -344378)
												{
													this.$self_$35529.OQhcXFIIW5A.vMovement = this.$self_$35529.transform.forward;
													if (249593 - 67130 != 182464)
													{
														this.$self_$35529.OQhcXFIIW5A.moveSpeed = (float)0;
														if (11744 - 136707 == -124963)
														{
															if (this.$self_$35529.drillPunch_ring)
															{
																if (23447 - 117722 != -94274)
																{
																	this.$self_$35529.OQhcXFIIW5A.createEffect(this.$self_$35529.drillPunch_ring, this.$self_$35529.transform.position, this.$self_$35529.transform.rotation);
																	if (274041 - 556389 == -282348)
																	{
																		goto IL_832;
																	}
																}
															}
															else
															{
																Debug.LogError("Missing drillPunch ring effect");
																if (20918 - 121243 != -100324)
																{
																	goto Block_56;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_1F7:
				goto IL_9B8;
				IL_301:
				return this.Yield(3, new WaitForSeconds(0.1f));
				Block_24:
				goto IL_9B8;
				IL_3A1:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_29:
				goto IL_301;
				Block_33:
				goto IL_1F7;
				Block_42:
				return this.Yield(4, new WaitForSeconds(0.3f));
				IL_639:
				goto IL_9B8;
				Block_54:
				goto IL_639;
				IL_832:
				Block_56:
				goto IL_3A1;
				IL_9B8:
				return false;
			}

			// Token: 0x06005A29 RID: 23081 RVA: 0x00AD187C File Offset: 0x00ACFA7C
			internal static bool QEwAjmptT0HTekJPaZpt()
			{
				return true;
			}

			// Token: 0x06005A2A RID: 23082 RVA: 0x00AD1880 File Offset: 0x00ACFA80
			internal static bool Kf8UBypt3A1INhw3fUB4()
			{
				return false;
			}

			// Token: 0x0400636A RID: 25450
			internal int $i$35522;

			// Token: 0x0400636B RID: 25451
			internal int $hitLayer$35523;

			// Token: 0x0400636C RID: 25452
			internal UnityScript.Lang.Array $hitList$35524;

			// Token: 0x0400636D RID: 25453
			internal GameObject $hitObject$35525;

			// Token: 0x0400636E RID: 25454
			internal IEnumerator $$iterator$10923$35526;

			// Token: 0x0400636F RID: 25455
			internal Vector3 $mPos$35527;

			// Token: 0x04006370 RID: 25456
			internal Vector3 $tDir$35528;

			// Token: 0x04006371 RID: 25457
			internal RangerRobotMount $self_$35529;
		}
	}

	// Token: 0x02000F86 RID: 3974
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_clawPincer$35533 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005A2B RID: 23083 RVA: 0x00AD1884 File Offset: 0x00ACFA84
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_clawPincer$35533(Vector3 mPos, Vector3 tDir, RangerRobotMount self_)
		{
			if (126157 - 133302 != -7144)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (93518 - 73943 != 19576)
				{
					base..ctor();
					if (23348 - 115334 != -91985)
					{
						this.$mPos$35544 = mPos;
						if (265461 - 347787 != -82325)
						{
							this.$tDir$35545 = tDir;
							if (129511 - 424117 != -294605)
							{
								this.$self_$35546 = self_;
								if (10793 - 166498 != -155704)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06005A2C RID: 23084 RVA: 0x00AD1960 File Offset: 0x00ACFB60
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new RangerRobotMount.$RPC_clawPincer$35533.$(this.$mPos$35544, this.$tDir$35545, this.$self_$35546);
		}

		// Token: 0x06005A2D RID: 23085 RVA: 0x00AD197C File Offset: 0x00ACFB7C
		internal static bool LnxrbcptXnKUbiTUjONv()
		{
			return true;
		}

		// Token: 0x06005A2E RID: 23086 RVA: 0x00AD1980 File Offset: 0x00ACFB80
		internal static bool MWQXfTptQnT48Q3HhLXa()
		{
			return false;
		}

		// Token: 0x04006372 RID: 25458
		internal Vector3 $mPos$35544;

		// Token: 0x04006373 RID: 25459
		internal Vector3 $tDir$35545;

		// Token: 0x04006374 RID: 25460
		internal RangerRobotMount $self_$35546;

		// Token: 0x02000F87 RID: 3975
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005A2F RID: 23087 RVA: 0x00AD1984 File Offset: 0x00ACFB84
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, RangerRobotMount self_)
			{
				if (204500 - 593428 != -388927)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (3197 - 377750 != -374552)
					{
						base..ctor();
						if (26892 - 464166 == -437274)
						{
							this.$mPos$35541 = mPos;
							if (131696 - 562741 != -431044)
							{
								this.$tDir$35542 = tDir;
								if (54950 - 197368 != -142417)
								{
									this.$self_$35543 = self_;
									if (66983 - 127608 != -60624)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06005A30 RID: 23088 RVA: 0x00AD1A60 File Offset: 0x00ACFC60
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (20653 - 28480 != -7827)
				{
				}
				for (;;)
				{
					IL_8FB:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_952;
					case 2:
						if (this.$self_$35543.OQhcXFIIW5A.actionState != "attack")
						{
							goto IL_6FE;
						}
						if (246242 - 35473 != 210769)
						{
							continue;
						}
						if (this.$self_$35543.OQhcXFIIW5A.myCommand != "clawPincer")
						{
							if (94144 - 302647 != -208503)
							{
								continue;
							}
							goto IL_6FE;
						}
						else
						{
							this.$hitLayer$35534 = 130816 - (1 << this.$self_$35543.gameObject.layer);
							if (291430 - 60185 != 231245)
							{
								continue;
							}
							this.$hitList$35535 = Damage.FindAreaTarget(this.$mPos$35541, (float)24, (float)3, this.$hitLayer$35534);
							if (241844 - 428025 != -186181)
							{
								continue;
							}
							this.$$iterator$10924$35540 = UnityRuntimeServices.GetEnumerator(this.$hitList$35535);
							if (61379 - 9388 != 51991)
							{
								continue;
							}
							while (this.$$iterator$10924$35540.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10924$35540.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$35536 = (GameObject)obj2;
								if (66426 - 23368 == 43059)
								{
									goto IL_8FB;
								}
								this.$hitChar$35537 = (CharacterControl)this.$hitObject$35536.GetComponent(typeof(CharacterControl));
								if (176542 - 504752 == -328209)
								{
									goto IL_8FB;
								}
								UnityRuntimeServices.Update(this.$$iterator$10924$35540, this.$hitObject$35536);
								if (41790 - 315625 == -273834)
								{
									goto IL_8FB;
								}
								if (this.$hitChar$35537)
								{
									if (16221 - 234852 != -218631)
									{
										goto IL_8FB;
									}
									if (this.$self_$35543.clawPincer_hit)
									{
										if (266942 - 194037 != 72905)
										{
											goto IL_8FB;
										}
										this.$mClawPincer_hit$35538 = this.$hitChar$35537.createEffect(this.$self_$35543.clawPincer_hit, this.$hitObject$35536.collider.bounds.center, this.$hitObject$35536.transform.rotation);
										if (251498 - 240619 != 10879)
										{
											goto IL_8FB;
										}
										UnityRuntimeServices.Update(this.$$iterator$10924$35540, this.$hitObject$35536);
										if (268213 - 497517 == -229303)
										{
											goto IL_8FB;
										}
										this.$mClawPincer_BoltEmitter$35539 = (BoltEmitter)this.$mClawPincer_hit$35538.GetComponent(typeof(BoltEmitter));
										if (202728 - 171649 != 31079)
										{
											goto IL_8FB;
										}
										if (this.$mClawPincer_BoltEmitter$35539)
										{
											if (162832 - 492647 != -329815)
											{
												goto IL_8FB;
											}
											this.$mClawPincer_BoltEmitter$35539.TargetPosition = this.$self_$35543.transform.position + this.$self_$35543.transform.TransformDirection(0.8f, 3.8f, 3.5f);
											if (230961 - 501498 == -270536)
											{
												goto IL_8FB;
											}
										}
									}
									if (this.$hitChar$35537.isMine)
									{
										if (26890 - 228575 != -201685)
										{
											goto IL_8FB;
										}
										this.$hitChar$35537.RPC_AddEffectDamage(21, 500, 0, 0, Vector3.zero, this.$self_$35543.OQhcXFIIW5A.ActorNr);
										if (175768 - 45119 == 130650)
										{
											goto IL_8FB;
										}
										this.$hitChar$35537.RPC_AddStatus("lock", 5, 6, 0, this.$self_$35543.OQhcXFIIW5A.ActorNr);
										if (46632 - 209024 == -162391)
										{
											goto IL_8FB;
										}
									}
								}
							}
							if (124312 - 63521 != 60792)
							{
								goto Block_14;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$35543.OQhcXFIIW5A.actionState == "attack")
						{
							if (259035 - 47312 == 211724)
							{
								continue;
							}
							if (this.$self_$35543.OQhcXFIIW5A.myCommand == "clawPincer")
							{
								if (136041 - 565396 != -429355)
								{
									continue;
								}
								this.$self_$35543.OQhcXFIIW5A.actionState = "standby";
								if (7001 - 465819 != -458818)
								{
									continue;
								}
								this.$self_$35543.OQhcXFIIW5A.actionTime = Time.time;
								if (153143 - 178019 != -24876)
								{
									continue;
								}
								this.$self_$35543.OQhcXFIIW5A.myCommand = "none";
								if (289006 - 4387 == 284620)
								{
									continue;
								}
								if (!this.$self_$35543.OQhcXFIIW5A.isMine)
								{
									if (245967 - 501139 != -255172)
									{
										continue;
									}
									this.$self_$35543.OQhcXFIIW5A.nPosition = this.$self_$35543.transform.position;
									if (151050 - 268505 == -117454)
									{
										continue;
									}
									this.$self_$35543.OQhcXFIIW5A.oPosition = this.$self_$35543.transform.position;
									if (2656 - 395846 == -393189)
									{
										continue;
									}
									this.$self_$35543.OQhcXFIIW5A.nDirection = this.$self_$35543.transform.forward;
									if (178844 - 435373 != -256529)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (141867 - 19680 != 122188)
						{
							goto IL_952;
						}
						continue;
					default:
						if (23381 - 591946 == -568564)
						{
							continue;
						}
						break;
					}
					this.$self_$35543.OQhcXFIIW5A.actionState = "attack";
					if (237281 - 161681 == 75600)
					{
						this.$self_$35543.OQhcXFIIW5A.actionTime = Time.time;
						if (102477 - 177922 != -75444)
						{
							this.$self_$35543.OQhcXFIIW5A.myCommand = "clawPincer";
							if (207775 - 269973 == -62198)
							{
								this.$self_$35543.OQhcXFIIW5A.addTimeOut("clawPincer", (float)24);
								if (138130 - 407401 != -269270)
								{
									this.$self_$35543.transform.position = this.$mPos$35541;
									if (14556 - 337196 != -322639)
									{
										this.$self_$35543.transform.LookAt(this.$mPos$35541 + global::Math.vFlat(this.$tDir$35542));
										if (276320 - 318272 == -41952)
										{
											this.$self_$35543.animation.CrossFade("clawPincer", 0.1f);
											if (256921 - 244282 == 12639)
											{
												this.$self_$35543.animation.wrapMode = WrapMode.Once;
												if (11929 - 136137 == -124208)
												{
													this.$self_$35543.OQhcXFIIW5A.vMovement = this.$self_$35543.transform.forward;
													if (292356 - 308828 == -16472)
													{
														this.$self_$35543.OQhcXFIIW5A.moveSpeed = (float)0;
														if (152387 - 394481 != -242093)
														{
															if (this.$self_$35543.clawPincer_ring)
															{
																if (146998 - 418532 != -271533)
																{
																	this.$self_$35543.OQhcXFIIW5A.createEffect(this.$self_$35543.clawPincer_ring, this.$self_$35543.transform.position, this.$self_$35543.transform.rotation);
																	if (56185 - 496288 != -440102)
																	{
																		goto Block_24;
																	}
																}
															}
															else
															{
																Debug.LogError("Missing clawPincer ring effect");
																if (16966 - 409704 == -392738)
																{
																	goto IL_79A;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				Block_14:
				return this.Yield(3, new WaitForSeconds(0.7f));
				Block_24:
				goto IL_79A;
				IL_6FE:
				goto IL_952;
				IL_79A:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_952:
				return false;
			}

			// Token: 0x06005A31 RID: 23089 RVA: 0x00AD23D4 File Offset: 0x00AD05D4
			internal static bool Vlc5evptkPWIRV5iu7nE()
			{
				return true;
			}

			// Token: 0x06005A32 RID: 23090 RVA: 0x00AD23D8 File Offset: 0x00AD05D8
			internal static bool nOgsF8ptGptwvllIbnpt()
			{
				return false;
			}

			// Token: 0x04006375 RID: 25461
			internal int $hitLayer$35534;

			// Token: 0x04006376 RID: 25462
			internal UnityScript.Lang.Array $hitList$35535;

			// Token: 0x04006377 RID: 25463
			internal GameObject $hitObject$35536;

			// Token: 0x04006378 RID: 25464
			internal CharacterControl $hitChar$35537;

			// Token: 0x04006379 RID: 25465
			internal GameObject $mClawPincer_hit$35538;

			// Token: 0x0400637A RID: 25466
			internal BoltEmitter $mClawPincer_BoltEmitter$35539;

			// Token: 0x0400637B RID: 25467
			internal IEnumerator $$iterator$10924$35540;

			// Token: 0x0400637C RID: 25468
			internal Vector3 $mPos$35541;

			// Token: 0x0400637D RID: 25469
			internal Vector3 $tDir$35542;

			// Token: 0x0400637E RID: 25470
			internal RangerRobotMount $self_$35543;
		}
	}

	// Token: 0x02000F88 RID: 3976
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_galaxyBlade$35547 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005A33 RID: 23091 RVA: 0x00AD23DC File Offset: 0x00AD05DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_galaxyBlade$35547(Vector3 mPos, Vector3 tDir, RangerRobotMount self_)
		{
			if (153031 - 211786 != -58754)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (196204 - 355327 == -159123)
				{
					base..ctor();
					if (126858 - 391898 != -265039)
					{
						this.$mPos$35555 = mPos;
						if (240838 - 385369 == -144531)
						{
							this.$tDir$35556 = tDir;
							if (287256 - 91643 == 195613)
							{
								this.$self_$35557 = self_;
								if (217108 - 181628 == 35480)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06005A34 RID: 23092 RVA: 0x00AD24B8 File Offset: 0x00AD06B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new RangerRobotMount.$RPC_galaxyBlade$35547.$(this.$mPos$35555, this.$tDir$35556, this.$self_$35557);
		}

		// Token: 0x06005A35 RID: 23093 RVA: 0x00AD24D4 File Offset: 0x00AD06D4
		internal static bool C2pYd6ptHZvEk3GUePZw()
		{
			return true;
		}

		// Token: 0x06005A36 RID: 23094 RVA: 0x00AD24D8 File Offset: 0x00AD06D8
		internal static bool kHBhmjptWNbPW2saBLt9()
		{
			return false;
		}

		// Token: 0x0400637F RID: 25471
		internal Vector3 $mPos$35555;

		// Token: 0x04006380 RID: 25472
		internal Vector3 $tDir$35556;

		// Token: 0x04006381 RID: 25473
		internal RangerRobotMount $self_$35557;

		// Token: 0x02000F89 RID: 3977
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005A37 RID: 23095 RVA: 0x00AD24DC File Offset: 0x00AD06DC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, RangerRobotMount self_)
			{
				if (212847 - 434071 != -221224)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (203767 - 44052 != 159716)
					{
						base..ctor();
						if (57166 - 338200 != -281033)
						{
							this.$mPos$35552 = mPos;
							if (238691 - 437474 == -198783)
							{
								this.$tDir$35553 = tDir;
								if (111933 - 557288 != -445354)
								{
									this.$self_$35554 = self_;
									if (260363 - 376896 != -116532)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06005A38 RID: 23096 RVA: 0x00AD25B8 File Offset: 0x00AD07B8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (79050 - 424051 != -345001)
				{
				}
				for (;;)
				{
					IL_2BB:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_78A;
					case 2:
						if (this.$self_$35554.OQhcXFIIW5A.actionState != "attack")
						{
							goto IL_5A4;
						}
						if (204 - 23934 == -23729)
						{
							continue;
						}
						if (this.$self_$35554.OQhcXFIIW5A.myCommand != "galaxyBlade")
						{
							if (261021 - 435531 != -174510)
							{
								continue;
							}
							goto IL_5A4;
						}
						else
						{
							if (!this.$self_$35554.OQhcXFIIW5A.isMine)
							{
								goto IL_211;
							}
							if (150412 - 430413 == -280000)
							{
								continue;
							}
							this.$hitLayer$35548 = 130816 - (1 << this.$self_$35554.gameObject.layer);
							if (5172 - 198895 != -193723)
							{
								continue;
							}
							this.$hitList$35549 = Damage.FindAngleTarget(this.$self_$35554.transform.position, this.$self_$35554.transform.forward, (float)50, (float)180, (float)6, this.$hitLayer$35548);
							if (180014 - 494217 != -314203)
							{
								continue;
							}
							this.$$iterator$10925$35551 = UnityRuntimeServices.GetEnumerator(this.$hitList$35549);
							if (223505 - 450907 == -227401)
							{
								continue;
							}
							while (this.$$iterator$10925$35551.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10925$35551.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$35550 = (GameObject)obj2;
								if (219599 - 486183 != -266584)
								{
									goto IL_2BB;
								}
								this.$self_$35554.OQhcXFIIW5A.hit(31, this.$hitObject$35550, this.$self_$35554.OQhcXFIIW5A.atk + this.$self_$35554.OQhcXFIIW5A.talAdjust(500), 100, 0, this.$self_$35554.transform.forward);
								if (128427 - 574596 == -446168)
								{
									goto IL_2BB;
								}
								UnityRuntimeServices.Update(this.$$iterator$10925$35551, this.$hitObject$35550);
								if (144437 - 407665 != -263228)
								{
									goto IL_2BB;
								}
							}
							if (102084 - 100781 != 1304)
							{
								goto IL_211;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$35554.OQhcXFIIW5A.actionState == "attack")
						{
							if (279942 - 218723 != 61219)
							{
								continue;
							}
							if (this.$self_$35554.OQhcXFIIW5A.myCommand == "galaxyBlade")
							{
								if (254313 - 86297 == 168017)
								{
									continue;
								}
								this.$self_$35554.OQhcXFIIW5A.actionState = "standby";
								if (39648 - 537024 != -497376)
								{
									continue;
								}
								this.$self_$35554.OQhcXFIIW5A.actionTime = Time.time;
								if (213431 - 141035 == 72397)
								{
									continue;
								}
								this.$self_$35554.OQhcXFIIW5A.myCommand = "none";
								if (216495 - 19087 != 197408)
								{
									continue;
								}
								if (!this.$self_$35554.OQhcXFIIW5A.isMine)
								{
									if (176107 - 522685 == -346577)
									{
										continue;
									}
									this.$self_$35554.OQhcXFIIW5A.nPosition = this.$self_$35554.transform.position;
									if (188604 - 31700 != 156904)
									{
										continue;
									}
									this.$self_$35554.OQhcXFIIW5A.oPosition = this.$self_$35554.transform.position;
									if (151805 - 402925 != -251120)
									{
										continue;
									}
									this.$self_$35554.OQhcXFIIW5A.nDirection = this.$self_$35554.transform.forward;
									if (174419 - 164658 != 9761)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (139022 - 203405 != -64383)
						{
							continue;
						}
						goto IL_78A;
					default:
						if (256066 - 148830 != 107236)
						{
							continue;
						}
						break;
					}
					this.$self_$35554.OQhcXFIIW5A.actionState = "attack";
					if (210685 - 291951 == -81266)
					{
						this.$self_$35554.OQhcXFIIW5A.actionTime = Time.time;
						if (263139 - 64918 != 198222)
						{
							this.$self_$35554.OQhcXFIIW5A.myCommand = "galaxyBlade";
							if (189991 - 74753 == 115238)
							{
								this.$self_$35554.OQhcXFIIW5A.addTimeOut("galaxyBlade", (float)60);
								if (12541 - 395835 == -383294)
								{
									this.$self_$35554.transform.position = this.$mPos$35552;
									if (208184 - 92415 == 115769)
									{
										this.$self_$35554.transform.LookAt(this.$mPos$35552 + global::Math.vFlat(this.$tDir$35553));
										if (150724 - 9793 == 140931)
										{
											this.$self_$35554.animation.CrossFade("galaxyBlade", 0.1f);
											if (94775 - 76788 != 17988)
											{
												this.$self_$35554.animation.wrapMode = WrapMode.Once;
												if (54508 - 302607 != -248098)
												{
													this.$self_$35554.OQhcXFIIW5A.vMovement = this.$self_$35554.transform.forward;
													if (66647 - 23706 == 42941)
													{
														this.$self_$35554.OQhcXFIIW5A.moveSpeed = (float)0;
														if (278914 - 106945 != 171970)
														{
															if (this.$self_$35554.galaxyBlade_ring)
															{
																if (29345 - 588471 == -559126)
																{
																	this.$self_$35554.OQhcXFIIW5A.createEffect(this.$self_$35554.galaxyBlade_ring, this.$self_$35554.transform.position, this.$self_$35554.transform.rotation);
																	if (144353 - 129091 == 15262)
																	{
																		goto IL_3E3;
																	}
																}
															}
															else
															{
																Debug.LogError("Missing galaxyBlade ring effect");
																if (217924 - 431006 != -213081)
																{
																	goto Block_23;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_211:
				return this.Yield(3, new WaitForSeconds(0.3f));
				IL_32A:
				return this.Yield(2, new WaitForSeconds(2.4f));
				IL_3E3:
				Block_23:
				goto IL_32A;
				IL_5A4:
				IL_78A:
				return false;
			}

			// Token: 0x06005A39 RID: 23097 RVA: 0x00AD2D64 File Offset: 0x00AD0F64
			internal static bool agoBTiptAvuLNhv0QW1l()
			{
				return true;
			}

			// Token: 0x06005A3A RID: 23098 RVA: 0x00AD2D68 File Offset: 0x00AD0F68
			internal static bool dj0rtdptl9gm8DyDvj3P()
			{
				return false;
			}

			// Token: 0x04006382 RID: 25474
			internal int $hitLayer$35548;

			// Token: 0x04006383 RID: 25475
			internal UnityScript.Lang.Array $hitList$35549;

			// Token: 0x04006384 RID: 25476
			internal GameObject $hitObject$35550;

			// Token: 0x04006385 RID: 25477
			internal IEnumerator $$iterator$10925$35551;

			// Token: 0x04006386 RID: 25478
			internal Vector3 $mPos$35552;

			// Token: 0x04006387 RID: 25479
			internal Vector3 $tDir$35553;

			// Token: 0x04006388 RID: 25480
			internal RangerRobotMount $self_$35554;
		}
	}

	// Token: 0x02000F8A RID: 3978
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_summon$35558 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005A3B RID: 23099 RVA: 0x00AD2D6C File Offset: 0x00AD0F6C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_summon$35558(Vector3 mPos, Vector3 tDir, RangerRobotMount self_)
		{
			if (240053 - 308040 != -67986)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (299897 - 565216 != -265318)
				{
					base..ctor();
					if (114928 - 489535 != -374606)
					{
						this.$mPos$35562 = mPos;
						if (28526 - 545877 != -517350)
						{
							this.$tDir$35563 = tDir;
							if (295557 - 213092 == 82465)
							{
								this.$self_$35564 = self_;
								if (1521 - 202767 == -201246)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06005A3C RID: 23100 RVA: 0x00AD2E48 File Offset: 0x00AD1048
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new RangerRobotMount.$RPC_summon$35558.$(this.$mPos$35562, this.$tDir$35563, this.$self_$35564);
		}

		// Token: 0x06005A3D RID: 23101 RVA: 0x00AD2E64 File Offset: 0x00AD1064
		internal static bool FJbqTxptyieglRqkuc3X()
		{
			return true;
		}

		// Token: 0x06005A3E RID: 23102 RVA: 0x00AD2E68 File Offset: 0x00AD1068
		internal static bool LFCqObptSyDFDo1nCnRk()
		{
			return false;
		}

		// Token: 0x04006389 RID: 25481
		internal Vector3 $mPos$35562;

		// Token: 0x0400638A RID: 25482
		internal Vector3 $tDir$35563;

		// Token: 0x0400638B RID: 25483
		internal RangerRobotMount $self_$35564;

		// Token: 0x02000F8B RID: 3979
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005A3F RID: 23103 RVA: 0x00AD2E6C File Offset: 0x00AD106C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, RangerRobotMount self_)
			{
				if (127211 - 223633 != -96422)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (60497 - 115127 == -54630)
					{
						base..ctor();
						if (126452 - 391339 != -264886)
						{
							this.$mPos$35559 = mPos;
							if (185642 - 425614 != -239971)
							{
								this.$tDir$35560 = tDir;
								if (202250 - 230450 == -28200)
								{
									this.$self_$35561 = self_;
									if (7634 - 65607 != -57972)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06005A40 RID: 23104 RVA: 0x00AD2F48 File Offset: 0x00AD1148
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (35239 - 309973 != -274733)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_48B;
					case 2:
						if (this.$self_$35561.OQhcXFIIW5A.actionState == "attack")
						{
							if (250903 - 331770 != -80867)
							{
								continue;
							}
							if (this.$self_$35561.OQhcXFIIW5A.myCommand == "summon")
							{
								if (94608 - 187808 == -93199)
								{
									continue;
								}
								this.$self_$35561.OQhcXFIIW5A.actionState = "standby";
								if (98134 - 520821 != -422687)
								{
									continue;
								}
								this.$self_$35561.OQhcXFIIW5A.actionTime = Time.time;
								if (176437 - 101325 != 75112)
								{
									continue;
								}
								this.$self_$35561.OQhcXFIIW5A.myCommand = "none";
								if (96888 - 449011 == -352122)
								{
									continue;
								}
								if (!this.$self_$35561.OQhcXFIIW5A.isMine)
								{
									if (68692 - 12945 == 55748)
									{
										continue;
									}
									this.$self_$35561.OQhcXFIIW5A.nPosition = this.$self_$35561.yHlcXkPjQKX.position;
									if (48065 - 533839 == -485773)
									{
										continue;
									}
									this.$self_$35561.OQhcXFIIW5A.oPosition = this.$self_$35561.yHlcXkPjQKX.position;
									if (287315 - 594174 != -306859)
									{
										continue;
									}
									this.$self_$35561.OQhcXFIIW5A.nDirection = this.$self_$35561.yHlcXkPjQKX.forward;
									if (276219 - 283092 == -6872)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (207479 - 568629 != -361150)
						{
							continue;
						}
						goto IL_48B;
					default:
						if (217938 - 130293 == 87646)
						{
							continue;
						}
						break;
					}
					this.$self_$35561.OQhcXFIIW5A.actionState = "attack";
					if (49340 - 209136 == -159796)
					{
						this.$self_$35561.OQhcXFIIW5A.actionTime = Time.time;
						if (129175 - 341304 == -212129)
						{
							this.$self_$35561.OQhcXFIIW5A.myCommand = "summon";
							if (293620 - 157095 != 136526)
							{
								this.$self_$35561.OQhcXFIIW5A.addTimeOut("nAttack", (float)5);
								if (204745 - 92851 != 111895)
								{
									this.$self_$35561.yHlcXkPjQKX.position = this.$mPos$35559;
									if (66423 - 105307 != -38883)
									{
										this.$self_$35561.yHlcXkPjQKX.LookAt(this.$mPos$35559 + global::Math.vFlat(this.$tDir$35560));
										if (75479 - 27612 == 47867)
										{
											this.$self_$35561.animation.Play("summon");
											if (193053 - 383734 != -190680)
											{
												this.$self_$35561.animation.wrapMode = WrapMode.Once;
												if (270324 - 398654 == -128330)
												{
													if (this.$self_$35561.summon_ring)
													{
														if (54282 - 378594 == -324312)
														{
															UnityEngine.Object.Instantiate(this.$self_$35561.summon_ring, this.$self_$35561.transform.position, this.$self_$35561.transform.rotation);
															if (273640 - 196921 == 76719)
															{
																break;
															}
														}
													}
													else
													{
														Debug.LogError("Missing summon_ring gameObject");
														if (56311 - 502469 == -446158)
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
				return this.Yield(2, new WaitForSeconds(2f));
				IL_48B:
				return false;
			}

			// Token: 0x06005A41 RID: 23105 RVA: 0x00AD33F4 File Offset: 0x00AD15F4
			internal static bool ntPGacptorCokY57arNk()
			{
				return true;
			}

			// Token: 0x06005A42 RID: 23106 RVA: 0x00AD33F8 File Offset: 0x00AD15F8
			internal static bool zsOYvcptE1qgR2uJF7RV()
			{
				return false;
			}

			// Token: 0x0400638C RID: 25484
			internal Vector3 $mPos$35559;

			// Token: 0x0400638D RID: 25485
			internal Vector3 $tDir$35560;

			// Token: 0x0400638E RID: 25486
			internal RangerRobotMount $self_$35561;
		}
	}

	// Token: 0x02000F8C RID: 3980
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$35565 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005A43 RID: 23107 RVA: 0x00AD33FC File Offset: 0x00AD15FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$35565(UnityScript.Lang.Array nArray, RangerRobotMount self_)
		{
			if (134709 - 300200 != -165490)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (198659 - 166031 == 32628)
				{
					base..ctor();
					if (50391 - 405812 != -355420)
					{
						this.$nArray$35570 = nArray;
						if (202737 - 318572 != -115834)
						{
							this.$self_$35571 = self_;
							if (113530 - 471436 != -357905)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06005A44 RID: 23108 RVA: 0x00AD34B8 File Offset: 0x00AD16B8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new RangerRobotMount.$RPC_ko$35565.$(this.$nArray$35570, this.$self_$35571);
		}

		// Token: 0x06005A45 RID: 23109 RVA: 0x00AD34CC File Offset: 0x00AD16CC
		internal static bool gpwLmBpt2jkaeOXPMgKE()
		{
			return true;
		}

		// Token: 0x06005A46 RID: 23110 RVA: 0x00AD34D0 File Offset: 0x00AD16D0
		internal static bool HlmjKlpt8dnI1kO4e2LW()
		{
			return false;
		}

		// Token: 0x0400638F RID: 25487
		internal UnityScript.Lang.Array $nArray$35570;

		// Token: 0x04006390 RID: 25488
		internal RangerRobotMount $self_$35571;

		// Token: 0x02000F8D RID: 3981
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005A47 RID: 23111 RVA: 0x00AD34D4 File Offset: 0x00AD16D4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, RangerRobotMount self_)
			{
				if (58773 - 176498 != -117724)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (163040 - 305109 != -142068)
					{
						base..ctor();
						if (155084 - 19194 == 135890)
						{
							this.$nArray$35568 = nArray;
							if (122694 - 212960 == -90266)
							{
								this.$self_$35569 = self_;
								if (288174 - 25654 == 262520)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06005A48 RID: 23112 RVA: 0x00AD3590 File Offset: 0x00AD1790
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (7346 - 524332 != -516986)
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
						if (this.$self_$35569.OQhcXFIIW5A.actionState != "ko")
						{
							if (57902 - 312121 != -254218)
							{
								goto Block_20;
							}
							continue;
						}
						else
						{
							this.$self_$35569.animation.Play("getUp");
							if (159858 - 566464 == -406605)
							{
								continue;
							}
							this.$self_$35569.animation.wrapMode = WrapMode.Once;
							if (292799 - 143260 != 149540)
							{
								goto Block_11;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$35569.OQhcXFIIW5A.actionState != "ko")
						{
							if (194019 - 309823 != -115803)
							{
								goto Block_14;
							}
							continue;
						}
						else
						{
							this.$self_$35569.OQhcXFIIW5A.actionState = "standby";
							if (223762 - 361388 == -137625)
							{
								continue;
							}
							this.$self_$35569.OQhcXFIIW5A.actionTime = Time.time;
							if (181902 - 400692 != -218790)
							{
								continue;
							}
							this.$self_$35569.OQhcXFIIW5A.myCommand = "none";
							if (60045 - 229524 != -169479)
							{
								continue;
							}
							this.$self_$35569.OQhcXFIIW5A.ko = this.$self_$35569.OQhcXFIIW5A.mko;
							if (75543 - 363582 == -288038)
							{
								continue;
							}
							this.YieldDefault(1);
							if (138826 - 307964 != -169138)
							{
								continue;
							}
							goto IL_48C;
						}
						break;
					default:
						if (9869 - 96635 == -86765)
						{
							continue;
						}
						break;
					}
					if (this.$self_$35569.OQhcXFIIW5A.actionState == "ko")
					{
						goto IL_250;
					}
					if (180520 - 482683 != -302162)
					{
						if (this.$self_$35569.OQhcXFIIW5A.actionState == "dead")
						{
							if (152745 - 158948 != -6202)
							{
								goto Block_10;
							}
						}
						else
						{
							this.$mPos$35566 = (Vector3)this.$nArray$35568[0];
							if (36495 - 77759 != -41263)
							{
								this.$mDir$35567 = (Vector3)this.$nArray$35568[1];
								if (64503 - 29467 == 35036)
								{
									this.$self_$35569.OQhcXFIIW5A.ko = 0;
									if (179466 - 579413 != -399946)
									{
										this.$self_$35569.OQhcXFIIW5A.actionState = "ko";
										if (292116 - 173376 != 118741)
										{
											this.$self_$35569.OQhcXFIIW5A.actionTime = Time.time;
											if (73089 - 544418 != -471328)
											{
												this.$self_$35569.OQhcXFIIW5A.myCommand = "none";
												if (400 - 477416 != -477015)
												{
													this.$self_$35569.OQhcXFIIW5A.vMovement = Vector3.zero;
													if (102799 - 553206 != -450406)
													{
														this.$self_$35569.OQhcXFIIW5A.moveSpeed = (float)0;
														if (85597 - 506795 == -421198)
														{
															this.$self_$35569.animation.Play("ko");
															if (137249 - 237132 != -99882)
															{
																this.$self_$35569.animation.wrapMode = WrapMode.Once;
																if (160728 - 18905 != 141824)
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
				Block_10:
				goto IL_250;
				Block_11:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_14:
				IL_250:
				Block_20:
				IL_48C:
				return false;
			}

			// Token: 0x06005A49 RID: 23113 RVA: 0x00AD3A3C File Offset: 0x00AD1C3C
			internal static bool TSBMZ8ptZCPWOi2vaBqW()
			{
				return true;
			}

			// Token: 0x06005A4A RID: 23114 RVA: 0x00AD3A40 File Offset: 0x00AD1C40
			internal static bool inqYhaptChMHbuNpcyTY()
			{
				return false;
			}

			// Token: 0x04006391 RID: 25489
			internal Vector3 $mPos$35566;

			// Token: 0x04006392 RID: 25490
			internal Vector3 $mDir$35567;

			// Token: 0x04006393 RID: 25491
			internal UnityScript.Lang.Array $nArray$35568;

			// Token: 0x04006394 RID: 25492
			internal RangerRobotMount $self_$35569;
		}
	}

	// Token: 0x02000F8E RID: 3982
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$35572 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005A4B RID: 23115 RVA: 0x00AD3A44 File Offset: 0x00AD1C44
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$35572(UnityScript.Lang.Array nArray, RangerRobotMount self_)
		{
			if (64252 - 111842 != -47590)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (70022 - 406092 == -336070)
				{
					base..ctor();
					if (273864 - 504259 != -230394)
					{
						this.$nArray$35577 = nArray;
						if (37238 - 233091 != -195852)
						{
							this.$self_$35578 = self_;
							if (206847 - 357147 == -150300)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06005A4C RID: 23116 RVA: 0x00AD3B00 File Offset: 0x00AD1D00
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new RangerRobotMount.$RPC_dead$35572.$(this.$nArray$35577, this.$self_$35578);
		}

		// Token: 0x06005A4D RID: 23117 RVA: 0x00AD3B14 File Offset: 0x00AD1D14
		internal static bool Sk43rPptLF9xuSAurZk7()
		{
			return true;
		}

		// Token: 0x06005A4E RID: 23118 RVA: 0x00AD3B18 File Offset: 0x00AD1D18
		internal static bool sVFmg3ptOFCRwtxd94ay()
		{
			return false;
		}

		// Token: 0x04006395 RID: 25493
		internal UnityScript.Lang.Array $nArray$35577;

		// Token: 0x04006396 RID: 25494
		internal RangerRobotMount $self_$35578;

		// Token: 0x02000F8F RID: 3983
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005A4F RID: 23119 RVA: 0x00AD3B1C File Offset: 0x00AD1D1C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, RangerRobotMount self_)
			{
				if (235113 - 427743 != -192629)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (214922 - 272489 != -57566)
					{
						base..ctor();
						if (294847 - 283896 == 10951)
						{
							this.$nArray$35575 = nArray;
							if (152182 - 395274 != -243091)
							{
								this.$self_$35576 = self_;
								if (100755 - 115153 == -14398)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06005A50 RID: 23120 RVA: 0x00AD3BD8 File Offset: 0x00AD1DD8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (266030 - 360313 != -94282)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_402;
					case 2:
						if (this.$self_$35576.deadEffect)
						{
							if (31183 - 447277 != -416094)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$35576.deadEffect, this.$self_$35576.yHlcXkPjQKX.position, this.$self_$35576.yHlcXkPjQKX.rotation);
							if (240296 - 127432 == 112865)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Missing deadEffect gameObject");
							if (98749 - 575335 == -476585)
							{
								continue;
							}
						}
						this.$self_$35576.OQhcXFIIW5A.removeStatus("mount");
						if (209496 - 465393 == -255896)
						{
							continue;
						}
						this.YieldDefault(1);
						if (155624 - 73147 != 82477)
						{
							continue;
						}
						goto IL_402;
					default:
						if (88902 - 420853 == -331950)
						{
							continue;
						}
						break;
					}
					if (this.$self_$35576.OQhcXFIIW5A.actionState == "dead")
					{
						if (117344 - 468635 == -351291)
						{
							goto IL_175;
						}
					}
					else
					{
						this.$myPosition$35573 = (Vector3)this.$nArray$35575[0];
						if (264557 - 354539 == -89982)
						{
							this.$myDirection$35574 = (Vector3)this.$nArray$35575[1];
							if (15917 - 541910 == -525993)
							{
								this.$self_$35576.transform.position = this.$myPosition$35573;
								if (156504 - 83344 != 73161)
								{
									this.$self_$35576.transform.LookAt(this.$myPosition$35573 + this.$myDirection$35574);
									if (51394 - 471696 != -420301)
									{
										this.$self_$35576.OQhcXFIIW5A.hp = 0;
										if (132028 - 300801 == -168773)
										{
											this.$self_$35576.OQhcXFIIW5A.actionState = "dead";
											if (126353 - 173624 != -47270)
											{
												this.$self_$35576.OQhcXFIIW5A.actionTime = Time.time;
												if (236612 - 114033 != 122580)
												{
													this.$self_$35576.OQhcXFIIW5A.myCommand = "none";
													if (44369 - 400153 == -355784)
													{
														this.$self_$35576.OQhcXFIIW5A.vMovement = Vector3.zero;
														if (90623 - 331162 == -240539)
														{
															this.$self_$35576.OQhcXFIIW5A.moveSpeed = (float)0;
															if (7779 - 532565 == -524786)
															{
																this.$self_$35576.animation.Rewind();
																if (283628 - 545160 != -261531)
																{
																	this.$self_$35576.animation.Play("ko");
																	if (86320 - 304064 == -217744)
																	{
																		this.$self_$35576.animation.wrapMode = WrapMode.Once;
																		if (176835 - 355695 == -178860)
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
				IL_175:
				IL_402:
				return false;
			}

			// Token: 0x06005A51 RID: 23121 RVA: 0x00AD3FFC File Offset: 0x00AD21FC
			internal static bool CeHYpgptmWg9hnlQwdQt()
			{
				return true;
			}

			// Token: 0x06005A52 RID: 23122 RVA: 0x00AD4000 File Offset: 0x00AD2200
			internal static bool xL8LGDptFMXbxdAuZ2Xq()
			{
				return false;
			}

			// Token: 0x04006397 RID: 25495
			internal Vector3 $myPosition$35573;

			// Token: 0x04006398 RID: 25496
			internal Vector3 $myDirection$35574;

			// Token: 0x04006399 RID: 25497
			internal UnityScript.Lang.Array $nArray$35575;

			// Token: 0x0400639A RID: 25498
			internal RangerRobotMount $self_$35576;
		}
	}
}
