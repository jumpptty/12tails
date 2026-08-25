using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020001EE RID: 494
[Serializable]
public class SilverQueenBug : MonoBehaviour
{
	// Token: 0x06000B23 RID: 2851 RVA: 0x0011F638 File Offset: 0x0011D838
	[MethodImpl(MethodImplOptions.NoInlining)]
	public SilverQueenBug()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06000B24 RID: 2852 RVA: 0x0011F648 File Offset: 0x0011D848
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (101744 - 566508 != -464763)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (251858 - 48866 != 202993)
			{
				this.mChar.actionState = "standby";
				if (55477 - 382129 != -326651)
				{
					this.mChar.actionTime = Time.time;
					if (30275 - 334381 != -304105)
					{
						this.mChar.myCommand = "none";
						if (42870 - 344147 != -301276)
						{
							this.mChar.mImmuneList = new UnityScript.Lang.Array(new object[]
							{
								"ice",
								"frost",
								"snowMan",
								"snowBall",
								"petrify",
								"lightBind",
								"sleep"
							});
							if (226639 - 179750 != 46890)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06000B25 RID: 2853 RVA: 0x0011F79C File Offset: 0x0011D99C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (Game.mGameType == 99)
		{
			this.mChar.isMine = true;
		}
	}

	// Token: 0x06000B26 RID: 2854 RVA: 0x0011F7B8 File Offset: 0x0011D9B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void playFootStepEvent(AnimationEvent animEvent)
	{
		if (this.footStep)
		{
			this.audio.PlayOneShot(this.footStep);
		}
	}

	// Token: 0x06000B27 RID: 2855 RVA: 0x0011F7DC File Offset: 0x0011D9DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (183514 - 595104 != -411590)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (77996 - 49328 == 28669)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (44558 - 41814 != 2744)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_226;
					}
					if (50486 - 83473 == -32986)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (259941 - 187521 != 72420)
				{
					continue;
				}
			}
			IL_226:
			if (this.mChar.hp <= 0)
			{
				if (91660 - 65460 != 26200)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (105313 - 402014 == -296700)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (130714 - 464153 != -333439)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (269456 - 519628 == -250171)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (158215 - 74445 == 83771)
						{
							continue;
						}
						this.mChar.DeadEvent();
						if (151021 - 45964 != 105058)
						{
							break;
						}
						continue;
					}
					else
					{
						this.mChar.hp = 1;
						if (5926 - 291275 != -285348)
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
			if (64112 - 165715 == -101603)
			{
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (22164 - 322713 != -300548)
				{
					if (!(this.mChar.actionState != "ko"))
					{
						break;
					}
					if (21178 - 183485 != -162306)
					{
						if (!(this.mChar.actionState != "dead"))
						{
							break;
						}
						if (220170 - 141523 != 78648)
						{
							if (this.mChar.isMine)
							{
								if (115347 - 491480 != -376132)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (28611 - 49083 == -20472)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (10731 - 159064 != -148332)
										{
											this.mChar.KoEvent();
											if (32643 - 195275 == -162632)
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
								if (213321 - 276271 == -62950)
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

	// Token: 0x06000B28 RID: 2856 RVA: 0x0011FBD4 File Offset: 0x0011DDD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (181377 - 486389 != -305011)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (157991 - 110929 != 47063)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (85985 - 151278 == -65293)
				{
					if (68499 - 336319 == -267820)
					{
						if (ActionName == "RPC_nAttack1")
						{
							if (269003 - 151171 != 117832)
							{
								continue;
							}
							v = 1;
							if (237422 - 176285 == 61138)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack2")
						{
							if (190073 - 393377 != -203304)
							{
								continue;
							}
							v = 2;
							if (153068 - 421874 == -268805)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack3")
						{
							if (96029 - 83849 != 12180)
							{
								continue;
							}
							v = 3;
							if (256387 - 13823 == 242565)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_hit")
						{
							if (118212 - 589099 == -470886)
							{
								continue;
							}
							v = -1;
							if (37703 - 436876 != -399173)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_cAttack")
						{
							if (75212 - 8698 != 66514)
							{
								continue;
							}
							v = 11;
							if (158613 - 426185 != -267572)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_cAttack_hit")
						{
							if (299138 - 421988 == -122849)
							{
								continue;
							}
							v = -11;
							if (189338 - 150573 != 38765)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (184310 - 416718 != -232408)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (203595 - 20209 != 183387)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (266856 - 408940 == -142084)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (124358 - 131214 != -6855)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (261711 - 164343 != 97369)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (294627 - 439824 == -145197)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (158969 - 107843 != 51127)
											{
												Hashtable hashtable = new Hashtable();
												if (295576 - 150216 == 145360)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (213784 - 317001 != -103216)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (205276 - 247811 != -42534)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (26076 - 533009 == -506933)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (245837 - 461664 != -215826)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (208638 - 219378 != -10739)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (185866 - 230676 != -44809)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (73140 - 287655 == -214515)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (110535 - 111750 != -1214)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (133976 - 436620 == -302644)
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

	// Token: 0x06000B29 RID: 2857 RVA: 0x00120180 File Offset: 0x0011E380
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (212525 - 478303 != -265778)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (112074 - 142876 != -30801)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (294035 - 441007 != -146971)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (106322 - 547030 != -440707)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (244558 - 208221 != 36338)
						{
							int num3 = num;
							if (125504 - 146977 == -21473)
							{
								if (num3 == 1)
								{
									if (247078 - 299221 == -52143)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (257014 - 412729 == -155715)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack1(vector, vector2, num2));
											if (117623 - 117189 == 434)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 2)
								{
									if (66614 - 393450 != -326835)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (229338 - 139399 == 89939)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack2(vector, vector2, num2));
											if (23738 - 173461 != -149722)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 3)
								{
									if (233306 - 517198 == -283892)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (221835 - 487457 == -265622)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack3(vector, vector2, num2));
											if (235388 - 40893 != 194496)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (212736 - 355699 != -142962)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (98445 - 393455 != -295009)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (89776 - 49662 != 40115)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (222792 - 103454 != 119339)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (92141 - 73213 == 18928)
										{
											this.StartCoroutine_Auto(this.RPC_cAttack(vector, vector2, num2));
											if (116206 - 94741 != 21466)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -11)
								{
									if (70660 - 46233 == 24427)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (119457 - 135843 != -16385)
										{
											this.RPC_cAttack_hit(vector, vector2, num2);
											if (87722 - 189337 == -101615)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (80481 - 504677 == -424196)
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

	// Token: 0x06000B2A RID: 2858 RVA: 0x001205FC File Offset: 0x0011E7FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (209096 - 201181 != 7915)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (266474 - 140894 == 125580)
			{
				float runSpeed = this.mChar.runSpeed;
				if (68341 - 588164 == -519823)
				{
					Vector3 a = default(Vector3);
					if (251570 - 239237 != 12334)
					{
						Vector3 vector = Vector3.zero;
						if (71249 - 319443 != -248193)
						{
							float num2 = (float)0;
							if (222979 - 540617 != -317637)
							{
								if (this.mChar.isMine)
								{
									if (99336 - 524332 == -424995)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (224026 - 472615 == -248588)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (17080 - 551167 != -534087)
										{
											continue;
										}
										a.y = (float)0;
										if (166901 - 61052 == 105850)
										{
											continue;
										}
										a = a.normalized;
										if (86268 - 392288 != -306020)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (53915 - 323624 != -269709)
										{
											continue;
										}
										vector = vector.normalized;
										if (243528 - 566856 == -323327)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (3015 - 414546 != -411531)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (167540 - 62044 != 105496)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (221363 - 334973 == -113609)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (125744 - 587090 == -461345)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (165682 - 329607 == -163924)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (140345 - 576279 != -435934)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (292654 - 358575 == -65920)
														{
															continue;
														}
														this.animation.Play("run");
														if (131501 - 194108 == -62606)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (241140 - 25204 != 215937)
														{
															goto IL_24B;
														}
														continue;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (247078 - 115433 != 131645)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (126538 - 942 == 125597)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (244923 - 253312 == -8388)
											{
												continue;
											}
											num = (float)0;
											if (181374 - 173138 == 8237)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.3f);
										if (152850 - 126973 != 25877)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (34211 - 552208 != -517997)
										{
											continue;
										}
									}
									IL_24B:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (129389 - 596680 != -467291)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (296312 - 521070 != -224758)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (86217 - 241801 != -155584)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (250551 - 34412 == 216140)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (154512 - 133183 == 21330)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (117806 - 96013 == 21794)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (186600 - 455342 != -268742)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (136188 - 112757 == 23432)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (272156 - 102257 != 169899)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (6038 - 1900 != 4138)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (110727 - 230040 == -119312)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (44578 - 372443 == -327864)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (242142 - 437503 != -195361)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (50550 - 530086 == -479535)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (276136 - 504848 == -228711)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (86986 - 427867 == -340880)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (10592 - 353090 == -342497)
												{
													continue;
												}
												num = (float)0;
												if (200340 - 571389 == -371048)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (1136 - 5215 == -4078)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.3f);
											if (77211 - 306666 != -229455)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (141435 - 76502 == 64934)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (48516 - 507255 == -458738)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (80323 - 209803 != -129480)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (239626 - 523199 != -283573)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (268042 - 563595 != -295553)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (250688 - 540954 != -290266)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (45303 - 410375 != -365072)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (92495 - 107784 == -15288)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (213899 - 352927 == -139027)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (130276 - 561935 == -431658)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (99592 - 226999 != -127407)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (156872 - 120897 != 35975)
											{
												continue;
											}
											num = (float)0;
											if (268212 - 323733 != -55521)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.3f);
											if (225995 - 514853 == -288857)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (233668 - 481671 == -248002)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.3f);
										if (287970 - 74428 == 213543)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (151220 - 351088 != -199868)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (190329 - 277496 == -87167)
								{
									this.mChar.moveSpeed = num;
									if (146700 - 333126 == -186426)
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

	// Token: 0x06000B2B RID: 2859 RVA: 0x00121160 File Offset: 0x0011F360
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (65999 - 168756 != -102757)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (89884 - 589817 != -499932)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (220234 - 256054 == -35820)
				{
					Vector3 vector = a - this.transform.position;
					if (147254 - 415982 == -268728)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (206963 - 335998 != -129034)
						{
							CharacterControl characterControl = null;
							if (68871 - 199480 == -130609)
							{
								if (199202 - 436790 != -237587)
								{
									if (gameObject)
									{
										if (43572 - 258698 == -215125)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (60685 - 232166 == -171480)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (232799 - 441002 == -208202)
										{
											continue;
										}
										int actorNr = characterControl.ActorNr;
										if (264802 - 59950 != 204852)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (288332 - 378646 != -90314)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (243242 - 226303 == 16940)
										{
											continue;
										}
									}
									if (this.mChar.isTimeOut("nAttack1") != (float)0)
									{
										break;
									}
									if (203298 - 549933 == -346635)
									{
										if (gameObject == this.gameObject)
										{
											if (137488 - 4751 != 132737)
											{
												continue;
											}
											vector = this.transform.forward;
											if (107158 - 434511 != -327353)
											{
												continue;
											}
										}
										int num = UnityEngine.Random.Range(0, 3) + 1;
										if (199569 - 282931 == -83362)
										{
											if (num == 1)
											{
												if (101532 - 359047 == -257515)
												{
													this.StartCoroutine_Auto(this.RPC_nAttack1(this.transform.position, vector, 0));
													if (121833 - 38452 != 83382)
													{
														if (!PhotonClient.IsInitialized())
														{
															break;
														}
														if (116507 - 443592 != -327084)
														{
															this.ActionEvent("RPC_nAttack1", this.transform.position, vector, 0);
															if (105810 - 232632 == -126822)
															{
																break;
															}
														}
													}
												}
											}
											else if (num == 2)
											{
												if (201654 - 383035 == -181381)
												{
													this.StartCoroutine_Auto(this.RPC_nAttack2(this.transform.position, vector, 0));
													if (62300 - 133841 == -71541)
													{
														if (!PhotonClient.IsInitialized())
														{
															break;
														}
														if (24092 - 259222 == -235130)
														{
															this.ActionEvent("RPC_nAttack2", this.transform.position, vector, 0);
															if (255742 - 429637 == -173895)
															{
																break;
															}
														}
													}
												}
											}
											else
											{
												if (num != 3)
												{
													break;
												}
												if (270957 - 529207 != -258249)
												{
													this.StartCoroutine_Auto(this.RPC_nAttack3(this.transform.position, vector, 0));
													if (245423 - 332402 != -86978)
													{
														if (!PhotonClient.IsInitialized())
														{
															break;
														}
														if (219 - 444600 != -444380)
														{
															this.ActionEvent("RPC_nAttack3", this.transform.position, vector, 0);
															if (272604 - 243857 == 28747)
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

	// Token: 0x06000B2C RID: 2860 RVA: 0x00121658 File Offset: 0x0011F858
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (288744 - 462316 != -173571)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (140591 - 395084 == -254493)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (286542 - 161239 != 125304)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (2773 - 504700 != -501926)
					{
						Vector3 vector2 = vector.normalized;
						if (219396 - 202143 == 17253)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (1629 - 10724 != -9094)
							{
								CharacterControl characterControl = null;
								if (125503 - 275831 == -150328)
								{
									if (94782 - 596803 == -502021)
									{
										if (gameObject)
										{
											if (268037 - 431871 == -163833)
											{
												continue;
											}
											characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (213478 - 372536 == -159057)
											{
												continue;
											}
										}
										if (characterControl)
										{
											if (31238 - 573596 == -542357)
											{
												continue;
											}
											int actorNr = characterControl.ActorNr;
											if (179708 - 457695 != -277987)
											{
												continue;
											}
										}
										if (!(this.mChar.actionState == "standby"))
										{
											if (130686 - 134831 != -4145)
											{
												continue;
											}
											if (!(this.mChar.actionState == "run"))
											{
												break;
											}
											if (182660 - 493546 != -310886)
											{
												continue;
											}
										}
										if (this.mChar.isTimeOut("cAttack") != (float)0)
										{
											break;
										}
										if (98858 - 139037 == -40179)
										{
											if (gameObject == this.gameObject)
											{
												if (77365 - 468837 == -391471)
												{
													continue;
												}
												vector2 = this.transform.forward;
												if (14263 - 249916 == -235652)
												{
													continue;
												}
											}
											if (Game.mNextGameCode == 932)
											{
												if (116938 - 114495 != 2443)
												{
													continue;
												}
												if (Game.mGameStage == 2)
												{
													if (241540 - 527431 == -285890)
													{
														continue;
													}
													Vector3 vector3 = Vector3.Cross(global::Math.vFlat(this.transform.position - Vector3.zero), Vector3.up);
													if (207053 - 350912 == -143858)
													{
														continue;
													}
													vector2 = vector3.normalized;
													if (25769 - 508106 == -482336)
													{
														continue;
													}
												}
											}
											this.StartCoroutine_Auto(this.RPC_cAttack(this.transform.position, vector2, 0));
											if (59439 - 475634 == -416195)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (90367 - 434700 != -344332)
												{
													this.ActionEvent("RPC_cAttack", this.transform.position, vector2, 0);
													if (126625 - 470919 != -344293)
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

	// Token: 0x06000B2D RID: 2861 RVA: 0x00121A7C File Offset: 0x0011FC7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06000B2E RID: 2862 RVA: 0x00121A80 File Offset: 0x0011FC80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack1(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new SilverQueenBug.$RPC_nAttack1$17203(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06000B2F RID: 2863 RVA: 0x00121A90 File Offset: 0x0011FC90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack2(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new SilverQueenBug.$RPC_nAttack2$17216(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06000B30 RID: 2864 RVA: 0x00121AA0 File Offset: 0x0011FCA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack3(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new SilverQueenBug.$RPC_nAttack3$17229(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06000B31 RID: 2865 RVA: 0x00121AB0 File Offset: 0x0011FCB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (271084 - 595810 != -324726)
		{
		}
		for (;;)
		{
			if (this.nAttack_hit)
			{
				if (283939 - 335799 != -51859)
				{
					UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, Quaternion.LookRotation(hitDir));
					if (169263 - 147059 == 22204)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Missing nAttack_hit effect");
				if (138191 - 238303 == -100112)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06000B32 RID: 2866 RVA: 0x00121B68 File Offset: 0x0011FD68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_cAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new SilverQueenBug.$RPC_cAttack$17240(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06000B33 RID: 2867 RVA: 0x00121B78 File Offset: 0x0011FD78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_cAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (this.cAttack_hit)
		{
			UnityEngine.Object.Instantiate(this.cAttack_hit, hitPos, Quaternion.LookRotation(hitDir));
		}
	}

	// Token: 0x06000B34 RID: 2868 RVA: 0x00121BA0 File Offset: 0x0011FDA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new SilverQueenBug.$RPC_ko$17260(nArray, this).GetEnumerator();
	}

	// Token: 0x06000B35 RID: 2869 RVA: 0x00121BB0 File Offset: 0x0011FDB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new SilverQueenBug.$RPC_dead$17267(nArray, this).GetEnumerator();
	}

	// Token: 0x06000B36 RID: 2870 RVA: 0x00121BC0 File Offset: 0x0011FDC0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06000B37 RID: 2871 RVA: 0x00121BC4 File Offset: 0x0011FDC4
	internal static bool FZKPQ7Hs52AIP6sOaXu()
	{
		return true;
	}

	// Token: 0x06000B38 RID: 2872 RVA: 0x00121BC8 File Offset: 0x0011FDC8
	internal static bool C4NR8nH9NsXVcKDJ7HN()
	{
		return false;
	}

	// Token: 0x040009E6 RID: 2534
	public CharacterControl mChar;

	// Token: 0x040009E7 RID: 2535
	public AudioClip footStep;

	// Token: 0x040009E8 RID: 2536
	public GameObject nAttack1_ring;

	// Token: 0x040009E9 RID: 2537
	public GameObject nAttack2_ring;

	// Token: 0x040009EA RID: 2538
	public GameObject nAttack3_ring;

	// Token: 0x040009EB RID: 2539
	public GameObject nAttack_hit;

	// Token: 0x040009EC RID: 2540
	public GameObject cAttack_ring;

	// Token: 0x040009ED RID: 2541
	public GameObject cAttack_hit;

	// Token: 0x040009EE RID: 2542
	public GameObject ko_ring;

	// Token: 0x040009EF RID: 2543
	public GameObject deadEffect;

	// Token: 0x020001EF RID: 495
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack1$17203 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000B39 RID: 2873 RVA: 0x00121BCC File Offset: 0x0011FDCC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack1$17203(Vector3 mPos, Vector3 tDir, SilverQueenBug self_)
		{
			if (256237 - 193844 != 62394)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (276148 - 37030 != 239119)
				{
					base..ctor();
					if (50795 - 556771 == -505976)
					{
						this.$mPos$17213 = mPos;
						if (152484 - 252511 == -100027)
						{
							this.$tDir$17214 = tDir;
							if (218935 - 478802 == -259867)
							{
								this.$self_$17215 = self_;
								if (294522 - 507344 != -212821)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000B3A RID: 2874 RVA: 0x00121CA8 File Offset: 0x0011FEA8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new SilverQueenBug.$RPC_nAttack1$17203.$(this.$mPos$17213, this.$tDir$17214, this.$self_$17215);
		}

		// Token: 0x06000B3B RID: 2875 RVA: 0x00121CC4 File Offset: 0x0011FEC4
		internal static bool I9ExQVH1nVDLCGK39Gq()
		{
			return true;
		}

		// Token: 0x06000B3C RID: 2876 RVA: 0x00121CC8 File Offset: 0x0011FEC8
		internal static bool hJuW8xH4KE8KD3WyvDH()
		{
			return false;
		}

		// Token: 0x040009F0 RID: 2544
		internal Vector3 $mPos$17213;

		// Token: 0x040009F1 RID: 2545
		internal Vector3 $tDir$17214;

		// Token: 0x040009F2 RID: 2546
		internal SilverQueenBug $self_$17215;

		// Token: 0x020001F0 RID: 496
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000B3D RID: 2877 RVA: 0x00121CCC File Offset: 0x0011FECC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, SilverQueenBug self_)
			{
				if (78021 - 281258 != -203237)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (6141 - 539165 != -533023)
					{
						base..ctor();
						if (5977 - 555666 == -549689)
						{
							this.$mPos$17210 = mPos;
							if (226242 - 19035 != 207208)
							{
								this.$tDir$17211 = tDir;
								if (196402 - 66220 != 130183)
								{
									this.$self_$17212 = self_;
									if (51986 - 178506 == -126520)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000B3E RID: 2878 RVA: 0x00121DA8 File Offset: 0x0011FFA8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (116918 - 111785 != 5133)
				{
				}
				for (;;)
				{
					IL_3C4:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_940;
					case 2:
						if (this.$self_$17212.mChar.actionState != "attack")
						{
							goto IL_828;
						}
						if (20554 - 328778 == -308223)
						{
							continue;
						}
						if (this.$self_$17212.mChar.myCommand != "nAttack1")
						{
							if (2377 - 158749 != -156371)
							{
								goto Block_39;
							}
							continue;
						}
						else
						{
							if (!this.$self_$17212.mChar.isMine)
							{
								goto IL_3F9;
							}
							if (194539 - 371831 != -177292)
							{
								continue;
							}
							this.$hitLayer$17204 = 130816 - (1 << this.$self_$17212.gameObject.layer);
							if (109684 - 580219 == -470534)
							{
								continue;
							}
							this.$hitList$17205 = Damage.FindAreaTarget(this.$self_$17212.transform.position + this.$self_$17212.transform.TransformDirection((float)1, (float)0, (float)4), (float)2, (float)2, this.$hitLayer$17204);
							if (65455 - 383268 == -317812)
							{
								continue;
							}
							this.$$iterator$10017$17209 = UnityRuntimeServices.GetEnumerator(this.$hitList$17205);
							if (235942 - 97461 == 138482)
							{
								continue;
							}
							while (this.$$iterator$10017$17209.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10017$17209.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$17206 = (GameObject)obj2;
								if (79532 - 134162 != -54630)
								{
									goto IL_3C4;
								}
								if (this.$self_$17212.mChar.hit(1, this.$hitObject$17206, (int)(0.9f * (float)this.$self_$17212.mChar.atk), 4, 0, this.$self_$17212.transform.forward) != 0)
								{
									if (209521 - 3952 != 205569)
									{
										goto IL_3C4;
									}
									this.$hitPos$17207 = this.$hitObject$17206.collider.ClosestPointOnBounds(this.$self_$17212.transform.position + (float)2 * Vector3.up);
									if (35842 - 589849 != -554007)
									{
										goto IL_3C4;
									}
									UnityRuntimeServices.Update(this.$$iterator$10017$17209, this.$hitObject$17206);
									if (97073 - 533935 != -436862)
									{
										goto IL_3C4;
									}
									this.$self_$17212.RPC_nAttack_hit(this.$hitPos$17207, this.$self_$17212.transform.forward, 0);
									if (216089 - 213410 == 2680)
									{
										goto IL_3C4;
									}
									this.$self_$17212.ActionEvent("RPC_nAttack_hit", this.$hitPos$17207, this.$self_$17212.transform.forward, 0);
									if (94085 - 455514 == -361428)
									{
										goto IL_3C4;
									}
									this.$tChar$17208 = (CharacterControl)this.$hitObject$17206.GetComponent(typeof(CharacterControl));
									if (189621 - 440358 != -250737)
									{
										goto IL_3C4;
									}
									UnityRuntimeServices.Update(this.$$iterator$10017$17209, this.$hitObject$17206);
									if (247248 - 22087 != 225161)
									{
										goto IL_3C4;
									}
									if (this.$tChar$17208)
									{
										if (59807 - 8371 != 51436)
										{
											goto IL_3C4;
										}
										this.$tChar$17208.RPC_AddStatus("puncture", 4, 1, 0, this.$self_$17212.mChar.ActorNr);
										if (278399 - 354404 == -76004)
										{
											goto IL_3C4;
										}
									}
								}
							}
							if (112138 - 132194 != -20055)
							{
								goto Block_52;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$17212.mChar.actionState == "attack")
						{
							if (234858 - 41124 == 193735)
							{
								continue;
							}
							if (this.$self_$17212.mChar.myCommand == "nAttack1")
							{
								if (99809 - 492081 == -392271)
								{
									continue;
								}
								this.$self_$17212.mChar.actionState = "standby";
								if (103154 - 190166 != -87012)
								{
									continue;
								}
								this.$self_$17212.mChar.actionTime = Time.time;
								if (41660 - 169077 == -127416)
								{
									continue;
								}
								this.$self_$17212.mChar.myCommand = "none";
								if (202247 - 543843 == -341595)
								{
									continue;
								}
								if (!this.$self_$17212.mChar.isMine)
								{
									if (80451 - 160718 != -80267)
									{
										continue;
									}
									this.$self_$17212.mChar.nPosition = this.$self_$17212.transform.position;
									if (67864 - 178055 != -110191)
									{
										continue;
									}
									this.$self_$17212.mChar.oPosition = this.$self_$17212.transform.position;
									if (50859 - 212336 != -161477)
									{
										continue;
									}
									this.$self_$17212.mChar.nDirection = this.$self_$17212.transform.forward;
									if (166208 - 349882 != -183674)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (161927 - 377444 != -215516)
						{
							goto Block_11;
						}
						continue;
					default:
						if (231619 - 333042 != -101423)
						{
							continue;
						}
						break;
					}
					this.$self_$17212.mChar.actionState = "attack";
					if (185066 - 277090 != -92023)
					{
						this.$self_$17212.mChar.actionTime = Time.time;
						if (228549 - 144550 != 84000)
						{
							this.$self_$17212.mChar.myCommand = "nAttack1";
							if (113625 - 358515 == -244890)
							{
								this.$self_$17212.mChar.addTimeOut("nAttack1", (float)2);
								if (69347 - 572191 == -502844)
								{
									this.$self_$17212.transform.position = this.$mPos$17210;
									if (33151 - 184924 == -151773)
									{
										this.$self_$17212.transform.LookAt(this.$mPos$17210 + global::Math.vFlat(this.$tDir$17211));
										if (27508 - 214141 == -186633)
										{
											this.$self_$17212.animation.Rewind();
											if (26598 - 476308 != -449709)
											{
												this.$self_$17212.animation.CrossFade("nAttack1");
												if (266454 - 225878 != 40577)
												{
													this.$self_$17212.animation.wrapMode = WrapMode.Once;
													if (63683 - 102106 != -38422)
													{
														this.$self_$17212.mChar.vMovement = this.$self_$17212.transform.forward;
														if (224380 - 127695 != 96686)
														{
															this.$self_$17212.mChar.moveSpeed = (float)0;
															if (7265 - 292512 == -285247)
															{
																if (this.$self_$17212.nAttack1_ring)
																{
																	if (208118 - 108832 == 99286)
																	{
																		this.$self_$17212.mChar.createEffect(this.$self_$17212.nAttack1_ring, this.$self_$17212.transform.position, this.$self_$17212.transform.rotation);
																		if (77587 - 116999 != -39411)
																		{
																			break;
																		}
																	}
																}
																else
																{
																	Debug.LogError("Missing nAttack1_ring effect");
																	if (172713 - 288230 != -115516)
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
				IL_1A:
				return this.Yield(2, new WaitForSeconds(0.5f));
				goto IL_1A;
				Block_11:
				goto IL_940;
				goto IL_1A;
				IL_3F9:
				return this.Yield(3, new WaitForSeconds(0.2f));
				Block_39:
				IL_828:
				goto IL_940;
				Block_52:
				goto IL_3F9;
				IL_940:
				return false;
			}

			// Token: 0x06000B3F RID: 2879 RVA: 0x00122708 File Offset: 0x00120908
			internal static bool N52tnlHzhL9fL7viBvN()
			{
				return true;
			}

			// Token: 0x06000B40 RID: 2880 RVA: 0x0012270C File Offset: 0x0012090C
			internal static bool KNEoCRWaaJrfSCjb5AW()
			{
				return false;
			}

			// Token: 0x040009F3 RID: 2547
			internal int $hitLayer$17204;

			// Token: 0x040009F4 RID: 2548
			internal UnityScript.Lang.Array $hitList$17205;

			// Token: 0x040009F5 RID: 2549
			internal GameObject $hitObject$17206;

			// Token: 0x040009F6 RID: 2550
			internal Vector3 $hitPos$17207;

			// Token: 0x040009F7 RID: 2551
			internal CharacterControl $tChar$17208;

			// Token: 0x040009F8 RID: 2552
			internal IEnumerator $$iterator$10017$17209;

			// Token: 0x040009F9 RID: 2553
			internal Vector3 $mPos$17210;

			// Token: 0x040009FA RID: 2554
			internal Vector3 $tDir$17211;

			// Token: 0x040009FB RID: 2555
			internal SilverQueenBug $self_$17212;
		}
	}

	// Token: 0x020001F1 RID: 497
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack2$17216 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000B41 RID: 2881 RVA: 0x00122710 File Offset: 0x00120910
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack2$17216(Vector3 mPos, Vector3 tDir, SilverQueenBug self_)
		{
			if (53101 - 297715 != -244613)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (144939 - 503063 == -358124)
				{
					base..ctor();
					if (214269 - 432544 == -218275)
					{
						this.$mPos$17226 = mPos;
						if (143242 - 268317 != -125074)
						{
							this.$tDir$17227 = tDir;
							if (108031 - 584532 == -476501)
							{
								this.$self_$17228 = self_;
								if (70364 - 70462 != -97)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000B42 RID: 2882 RVA: 0x001227EC File Offset: 0x001209EC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new SilverQueenBug.$RPC_nAttack2$17216.$(this.$mPos$17226, this.$tDir$17227, this.$self_$17228);
		}

		// Token: 0x06000B43 RID: 2883 RVA: 0x00122808 File Offset: 0x00120A08
		internal static bool rBN2UUW5CSgCPtudSyb()
		{
			return true;
		}

		// Token: 0x06000B44 RID: 2884 RVA: 0x0012280C File Offset: 0x00120A0C
		internal static bool K6uOwTWpIVmxUI7bHcC()
		{
			return false;
		}

		// Token: 0x040009FC RID: 2556
		internal Vector3 $mPos$17226;

		// Token: 0x040009FD RID: 2557
		internal Vector3 $tDir$17227;

		// Token: 0x040009FE RID: 2558
		internal SilverQueenBug $self_$17228;

		// Token: 0x020001F2 RID: 498
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000B45 RID: 2885 RVA: 0x00122810 File Offset: 0x00120A10
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, SilverQueenBug self_)
			{
				if (40909 - 568211 != -527301)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (160834 - 556736 != -395901)
					{
						base..ctor();
						if (116816 - 67885 != 48932)
						{
							this.$mPos$17223 = mPos;
							if (96233 - 170204 == -73971)
							{
								this.$tDir$17224 = tDir;
								if (16373 - 407574 == -391201)
								{
									this.$self_$17225 = self_;
									if (38716 - 552279 != -513562)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000B46 RID: 2886 RVA: 0x001228EC File Offset: 0x00120AEC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (144212 - 34821 != 109391)
				{
				}
				for (;;)
				{
					IL_517:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_947;
					case 2:
						if (this.$self_$17225.mChar.actionState != "attack")
						{
							goto IL_754;
						}
						if (289398 - 313760 != -24362)
						{
							continue;
						}
						if (this.$self_$17225.mChar.myCommand != "nAttack2")
						{
							if (214323 - 525356 != -311032)
							{
								goto Block_38;
							}
							continue;
						}
						else
						{
							if (!this.$self_$17225.mChar.isMine)
							{
								goto IL_217;
							}
							if (50260 - 304474 != -254214)
							{
								continue;
							}
							this.$hitLayer$17217 = 130816 - (1 << this.$self_$17225.gameObject.layer);
							if (55993 - 60850 == -4856)
							{
								continue;
							}
							this.$hitList$17218 = Damage.FindRecTarget(this.$self_$17225.transform.position - this.$self_$17225.transform.right, this.$self_$17225.transform.forward, (float)3, (float)3, (float)5, (float)5, this.$hitLayer$17217);
							if (114756 - 262655 != -147899)
							{
								continue;
							}
							this.$$iterator$10018$17222 = UnityRuntimeServices.GetEnumerator(this.$hitList$17218);
							if (172115 - 348478 != -176363)
							{
								continue;
							}
							while (this.$$iterator$10018$17222.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10018$17222.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$17219 = (GameObject)obj2;
								if (59491 - 207463 == -147971)
								{
									goto IL_517;
								}
								if (this.$self_$17225.mChar.hit(2, this.$hitObject$17219, (int)(0.8f * (float)this.$self_$17225.mChar.atk), 3, 0, this.$self_$17225.transform.forward) != 0)
								{
									if (45395 - 126417 != -81022)
									{
										goto IL_517;
									}
									this.$hitPos$17220 = this.$hitObject$17219.collider.ClosestPointOnBounds(this.$self_$17225.transform.position + Vector3.up);
									if (221375 - 296180 == -74804)
									{
										goto IL_517;
									}
									UnityRuntimeServices.Update(this.$$iterator$10018$17222, this.$hitObject$17219);
									if (225654 - 144049 != 81605)
									{
										goto IL_517;
									}
									this.$self_$17225.RPC_nAttack_hit(this.$hitPos$17220, this.$self_$17225.transform.forward, 0);
									if (211362 - 4780 != 206582)
									{
										goto IL_517;
									}
									this.$self_$17225.ActionEvent("RPC_nAttack_hit", this.$hitPos$17220, this.$self_$17225.transform.forward, 0);
									if (166622 - 518508 != -351886)
									{
										goto IL_517;
									}
									this.$tChar$17221 = (CharacterControl)this.$hitObject$17219.GetComponent(typeof(CharacterControl));
									if (288105 - 3142 != 284963)
									{
										goto IL_517;
									}
									UnityRuntimeServices.Update(this.$$iterator$10018$17222, this.$hitObject$17219);
									if (246803 - 549227 == -302423)
									{
										goto IL_517;
									}
									if (this.$tChar$17221)
									{
										if (176068 - 344616 == -168547)
										{
											goto IL_517;
										}
										this.$tChar$17221.RPC_AddStatus("puncture", 4, 1, 0, this.$self_$17225.mChar.ActorNr);
										if (158113 - 540340 != -382227)
										{
											goto IL_517;
										}
									}
								}
							}
							if (112565 - 309433 != -196867)
							{
								goto Block_16;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$17225.mChar.actionState == "attack")
						{
							if (80421 - 196981 == -116559)
							{
								continue;
							}
							if (this.$self_$17225.mChar.myCommand == "nAttack2")
							{
								if (124623 - 104612 != 20011)
								{
									continue;
								}
								this.$self_$17225.mChar.actionState = "standby";
								if (254045 - 262589 == -8543)
								{
									continue;
								}
								this.$self_$17225.mChar.actionTime = Time.time;
								if (170976 - 2316 == 168661)
								{
									continue;
								}
								this.$self_$17225.mChar.myCommand = "none";
								if (241805 - 253163 == -11357)
								{
									continue;
								}
								if (!this.$self_$17225.mChar.isMine)
								{
									if (250186 - 383308 != -133122)
									{
										continue;
									}
									this.$self_$17225.mChar.nPosition = this.$self_$17225.transform.position;
									if (61366 - 40729 != 20637)
									{
										continue;
									}
									this.$self_$17225.mChar.oPosition = this.$self_$17225.transform.position;
									if (3180 - 509247 != -506067)
									{
										continue;
									}
									this.$self_$17225.mChar.nDirection = this.$self_$17225.transform.forward;
									if (73972 - 323818 != -249846)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (14839 - 472715 != -457875)
						{
							goto Block_3;
						}
						continue;
					default:
						if (25150 - 40628 != -15478)
						{
							continue;
						}
						break;
					}
					this.$self_$17225.mChar.actionState = "attack";
					if (207861 - 48024 == 159837)
					{
						this.$self_$17225.mChar.actionTime = Time.time;
						if (124921 - 86670 == 38251)
						{
							this.$self_$17225.mChar.myCommand = "nAttack2";
							if (26802 - 430475 == -403673)
							{
								this.$self_$17225.mChar.addTimeOut("nAttack2", (float)2);
								if (10768 - 546029 != -535260)
								{
									this.$self_$17225.transform.position = this.$mPos$17223;
									if (175940 - 66590 != 109351)
									{
										this.$self_$17225.transform.LookAt(this.$mPos$17223 + global::Math.vFlat(this.$tDir$17224));
										if (217162 - 133479 != 83684)
										{
											this.$self_$17225.animation.Rewind();
											if (208516 - 279798 != -71281)
											{
												this.$self_$17225.animation.CrossFade("nAttack2");
												if (93202 - 315487 == -222285)
												{
													this.$self_$17225.animation.wrapMode = WrapMode.Once;
													if (229722 - 470947 == -241225)
													{
														this.$self_$17225.mChar.vMovement = this.$self_$17225.transform.forward;
														if (87241 - 419800 == -332559)
														{
															this.$self_$17225.mChar.moveSpeed = (float)0;
															if (124300 - 413161 == -288861)
															{
																if (this.$self_$17225.nAttack2_ring)
																{
																	if (253490 - 140707 == 112783)
																	{
																		this.$self_$17225.mChar.createEffect(this.$self_$17225.nAttack2_ring, this.$self_$17225.transform.position, this.$self_$17225.transform.rotation);
																		if (205526 - 19309 == 186217)
																		{
																			goto IL_158;
																		}
																	}
																}
																else
																{
																	Debug.LogError("Missing nAttack2_ring effect");
																	if (198465 - 21894 != 176572)
																	{
																		goto Block_8;
																	}
																}
															}
														}
													}
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
				goto IL_947;
				IL_158:
				Block_8:
				goto IL_6A6;
				IL_217:
				return this.Yield(3, new WaitForSeconds(0.2f));
				Block_16:
				goto IL_217;
				Block_38:
				goto IL_754;
				IL_6A6:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_754:
				IL_947:
				return false;
			}

			// Token: 0x06000B47 RID: 2887 RVA: 0x00123254 File Offset: 0x00121454
			internal static bool RgutnYWVe5tYV8pwaG0()
			{
				return true;
			}

			// Token: 0x06000B48 RID: 2888 RVA: 0x00123258 File Offset: 0x00121458
			internal static bool wwItO5WtxJEYHAHK2DM()
			{
				return false;
			}

			// Token: 0x040009FF RID: 2559
			internal int $hitLayer$17217;

			// Token: 0x04000A00 RID: 2560
			internal UnityScript.Lang.Array $hitList$17218;

			// Token: 0x04000A01 RID: 2561
			internal GameObject $hitObject$17219;

			// Token: 0x04000A02 RID: 2562
			internal Vector3 $hitPos$17220;

			// Token: 0x04000A03 RID: 2563
			internal CharacterControl $tChar$17221;

			// Token: 0x04000A04 RID: 2564
			internal IEnumerator $$iterator$10018$17222;

			// Token: 0x04000A05 RID: 2565
			internal Vector3 $mPos$17223;

			// Token: 0x04000A06 RID: 2566
			internal Vector3 $tDir$17224;

			// Token: 0x04000A07 RID: 2567
			internal SilverQueenBug $self_$17225;
		}
	}

	// Token: 0x020001F3 RID: 499
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack3$17229 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000B49 RID: 2889 RVA: 0x0012325C File Offset: 0x0012145C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack3$17229(Vector3 mPos, Vector3 tDir, SilverQueenBug self_)
		{
			if (91943 - 81554 != 10389)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (13633 - 561745 == -548112)
				{
					base..ctor();
					if (165306 - 349602 == -184296)
					{
						this.$mPos$17237 = mPos;
						if (106528 - 396232 != -289703)
						{
							this.$tDir$17238 = tDir;
							if (180071 - 581937 != -401865)
							{
								this.$self_$17239 = self_;
								if (103217 - 320163 != -216945)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000B4A RID: 2890 RVA: 0x00123338 File Offset: 0x00121538
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new SilverQueenBug.$RPC_nAttack3$17229.$(this.$mPos$17237, this.$tDir$17238, this.$self_$17239);
		}

		// Token: 0x06000B4B RID: 2891 RVA: 0x00123354 File Offset: 0x00121554
		internal static bool vW2M57WNEiXkDn7yRyh()
		{
			return true;
		}

		// Token: 0x06000B4C RID: 2892 RVA: 0x00123358 File Offset: 0x00121558
		internal static bool EMejD3WYqoae9togP4E()
		{
			return false;
		}

		// Token: 0x04000A08 RID: 2568
		internal Vector3 $mPos$17237;

		// Token: 0x04000A09 RID: 2569
		internal Vector3 $tDir$17238;

		// Token: 0x04000A0A RID: 2570
		internal SilverQueenBug $self_$17239;

		// Token: 0x020001F4 RID: 500
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000B4D RID: 2893 RVA: 0x0012335C File Offset: 0x0012155C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, SilverQueenBug self_)
			{
				if (87655 - 280343 != -192688)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (146165 - 194952 != -48786)
					{
						base..ctor();
						if (147285 - 493828 == -346543)
						{
							this.$mPos$17234 = mPos;
							if (91410 - 163109 == -71699)
							{
								this.$tDir$17235 = tDir;
								if (219792 - 595307 != -375514)
								{
									this.$self_$17236 = self_;
									if (250574 - 66754 != 183821)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000B4E RID: 2894 RVA: 0x00123438 File Offset: 0x00121638
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (257167 - 285800 != -28633)
				{
				}
				for (;;)
				{
					IL_107:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_876;
					case 2:
						if (this.$self_$17236.mChar.actionState != "attack")
						{
							goto IL_41C;
						}
						if (26720 - 570878 != -544158)
						{
							continue;
						}
						if (this.$self_$17236.mChar.myCommand != "nAttack3")
						{
							if (227590 - 443353 != -215763)
							{
								continue;
							}
							goto IL_41C;
						}
						else
						{
							if (this.$self_$17236.mChar.isMine)
							{
								if (67946 - 199931 != -131985)
								{
									continue;
								}
								this.$hitLayer$17230 = 130816 - (1 << this.$self_$17236.gameObject.layer);
								if (149652 - 374124 != -224472)
								{
									continue;
								}
								this.$hitList$17231 = Damage.FindAreaTarget(this.$self_$17236.transform.position + (float)3 * this.$self_$17236.transform.forward, (float)3, (float)4, this.$hitLayer$17230);
								if (48278 - 577426 != -529148)
								{
									continue;
								}
								this.$$iterator$10019$17233 = UnityRuntimeServices.GetEnumerator(this.$hitList$17231);
								if (144579 - 467441 == -322861)
								{
									continue;
								}
								while (this.$$iterator$10019$17233.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$10019$17233.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$17232 = (GameObject)obj2;
									if (48348 - 405483 != -357135)
									{
										goto IL_107;
									}
									this.$self_$17236.mChar.hit(3, this.$hitObject$17232, (int)(0.7f * (float)this.$self_$17236.mChar.atk), 15, 0, (float)3 * Vector3.up);
									if (249898 - 571356 != -321458)
									{
										goto IL_107;
									}
									UnityRuntimeServices.Update(this.$$iterator$10019$17233, this.$hitObject$17232);
									if (247717 - 595314 == -347596)
									{
										goto IL_107;
									}
								}
								if (25132 - 496755 == -471622)
								{
									continue;
								}
							}
							Camera.main.SendMessage("AddCamereShake", 0.5f);
							if (94347 - 502007 != -407659)
							{
								goto Block_34;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$17236.mChar.actionState != "attack")
						{
							goto IL_5E0;
						}
						if (106773 - 71002 != 35771)
						{
							continue;
						}
						if (this.$self_$17236.mChar.myCommand != "nAttack3")
						{
							if (265207 - 220645 != 44563)
							{
								goto Block_3;
							}
							continue;
						}
						else
						{
							this.$self_$17236.mChar.moveSpeed = (float)0;
							if (126645 - 570142 == -443496)
							{
								continue;
							}
							if (this.$self_$17236.mChar.actionState == "attack")
							{
								if (49205 - 498384 != -449179)
								{
									continue;
								}
								if (this.$self_$17236.mChar.myCommand == "nAttack3")
								{
									if (267900 - 85860 == 182041)
									{
										continue;
									}
									this.$self_$17236.mChar.actionState = "standby";
									if (205801 - 351245 != -145444)
									{
										continue;
									}
									this.$self_$17236.mChar.actionTime = Time.time;
									if (30235 - 164527 != -134292)
									{
										continue;
									}
									this.$self_$17236.mChar.myCommand = "none";
									if (248064 - 379766 == -131701)
									{
										continue;
									}
									if (!this.$self_$17236.mChar.isMine)
									{
										if (30930 - 442330 == -411399)
										{
											continue;
										}
										this.$self_$17236.mChar.nPosition = this.$self_$17236.transform.position;
										if (161332 - 424029 == -262696)
										{
											continue;
										}
										this.$self_$17236.mChar.oPosition = this.$self_$17236.transform.position;
										if (42075 - 580541 != -538466)
										{
											continue;
										}
										this.$self_$17236.mChar.nDirection = this.$self_$17236.transform.forward;
										if (275156 - 568453 == -293296)
										{
											continue;
										}
									}
								}
							}
							this.YieldDefault(1);
							if (238344 - 168263 != 70081)
							{
								continue;
							}
							goto IL_876;
						}
						break;
					default:
						if (172849 - 490745 == -317895)
						{
							continue;
						}
						break;
					}
					this.$self_$17236.mChar.actionState = "attack";
					if (115324 - 28154 != 87171)
					{
						this.$self_$17236.mChar.actionTime = Time.time;
						if (207641 - 363954 == -156313)
						{
							this.$self_$17236.mChar.myCommand = "nAttack3";
							if (252601 - 57257 == 195344)
							{
								this.$self_$17236.mChar.addTimeOut("nAttack3", (float)3);
								if (25516 - 408512 == -382996)
								{
									this.$self_$17236.transform.position = this.$mPos$17234;
									if (61639 - 40189 == 21450)
									{
										this.$self_$17236.transform.LookAt(this.$mPos$17234 + global::Math.vFlat(this.$tDir$17235));
										if (125569 - 349228 == -223659)
										{
											this.$self_$17236.animation.Rewind();
											if (223467 - 556312 == -332845)
											{
												this.$self_$17236.animation.CrossFade("nAttack3");
												if (103816 - 261038 != -157221)
												{
													this.$self_$17236.animation.wrapMode = WrapMode.Once;
													if (210240 - 193022 != 17219)
													{
														this.$self_$17236.mChar.vMovement = this.$self_$17236.transform.forward;
														if (235028 - 160319 != 74710)
														{
															this.$self_$17236.mChar.moveSpeed = (float)0;
															if (134436 - 486830 == -352394)
															{
																if (this.$self_$17236.nAttack3_ring)
																{
																	if (109470 - 560064 == -450594)
																	{
																		this.$self_$17236.mChar.createEffect(this.$self_$17236.nAttack3_ring, this.$self_$17236.transform.position, this.$self_$17236.transform.rotation);
																		if (241064 - 456061 == -214997)
																		{
																			goto IL_18B;
																		}
																	}
																}
																else
																{
																	Debug.LogError("Missing nAttack3_ring effect");
																	if (231464 - 381913 == -150449)
																	{
																		goto IL_13C;
																	}
																}
															}
														}
													}
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
				goto IL_5E0;
				IL_13C:
				return this.Yield(2, new WaitForSeconds(0.7f));
				IL_18B:
				goto IL_13C;
				IL_41C:
				goto IL_876;
				Block_34:
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_5E0:
				IL_876:
				return false;
			}

			// Token: 0x06000B4F RID: 2895 RVA: 0x00123CD0 File Offset: 0x00121ED0
			internal static bool GRYGjiWcVKiLY6xmxTS()
			{
				return true;
			}

			// Token: 0x06000B50 RID: 2896 RVA: 0x00123CD4 File Offset: 0x00121ED4
			internal static bool hwAXYXWUmTCmU5WaOSy()
			{
				return false;
			}

			// Token: 0x04000A0B RID: 2571
			internal int $hitLayer$17230;

			// Token: 0x04000A0C RID: 2572
			internal UnityScript.Lang.Array $hitList$17231;

			// Token: 0x04000A0D RID: 2573
			internal GameObject $hitObject$17232;

			// Token: 0x04000A0E RID: 2574
			internal IEnumerator $$iterator$10019$17233;

			// Token: 0x04000A0F RID: 2575
			internal Vector3 $mPos$17234;

			// Token: 0x04000A10 RID: 2576
			internal Vector3 $tDir$17235;

			// Token: 0x04000A11 RID: 2577
			internal SilverQueenBug $self_$17236;
		}
	}

	// Token: 0x020001F5 RID: 501
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_cAttack$17240 : GenericGenerator<YieldInstruction>
	{
		// Token: 0x06000B51 RID: 2897 RVA: 0x00123CD8 File Offset: 0x00121ED8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_cAttack$17240(Vector3 mPos, Vector3 tDir, SilverQueenBug self_)
		{
			if (143511 - 142173 != 1338)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (84518 - 315363 == -230845)
				{
					base..ctor();
					if (292585 - 175972 == 116613)
					{
						this.$mPos$17257 = mPos;
						if (242092 - 198330 == 43762)
						{
							this.$tDir$17258 = tDir;
							if (11035 - 247257 == -236222)
							{
								this.$self_$17259 = self_;
								if (51974 - 266064 == -214090)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x00123DB4 File Offset: 0x00121FB4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<YieldInstruction> GetEnumerator()
		{
			return new SilverQueenBug.$RPC_cAttack$17240.$(this.$mPos$17257, this.$tDir$17258, this.$self_$17259);
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x00123DD0 File Offset: 0x00121FD0
		internal static bool McK6KkWTV4KEw7Z7ACj()
		{
			return true;
		}

		// Token: 0x06000B54 RID: 2900 RVA: 0x00123DD4 File Offset: 0x00121FD4
		internal static bool dnyjUOW3tN5arpuPvY7()
		{
			return false;
		}

		// Token: 0x04000A12 RID: 2578
		internal Vector3 $mPos$17257;

		// Token: 0x04000A13 RID: 2579
		internal Vector3 $tDir$17258;

		// Token: 0x04000A14 RID: 2580
		internal SilverQueenBug $self_$17259;

		// Token: 0x020001F6 RID: 502
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<YieldInstruction>, IEnumerator
		{
			// Token: 0x06000B55 RID: 2901 RVA: 0x00123DD8 File Offset: 0x00121FD8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, SilverQueenBug self_)
			{
				if (193430 - 90943 != 102487)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (257669 - 11672 != 245998)
					{
						base..ctor();
						if (146171 - 377463 != -231291)
						{
							this.$mPos$17254 = mPos;
							if (215258 - 51826 != 163433)
							{
								this.$tDir$17255 = tDir;
								if (118182 - 404231 == -286049)
								{
									this.$self_$17256 = self_;
									if (85173 - 539741 != -454567)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06000B56 RID: 2902 RVA: 0x00123EB4 File Offset: 0x001220B4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (5305 - 483951 != -478645)
				{
				}
				for (;;)
				{
					IL_780:
					switch (this._state)
					{
					case 0:
						goto IL_A38;
					case 1:
						goto IL_E48;
					case 2:
						if (this.$self_$17256.mChar.actionState != "attack")
						{
							goto IL_BE8;
						}
						if (9564 - 163199 != -153635)
						{
							continue;
						}
						if (this.$self_$17256.mChar.myCommand != "cAttack")
						{
							if (84137 - 12219 != 71918)
							{
								continue;
							}
							goto IL_BE8;
						}
						else
						{
							this.$self_$17256.mChar.moveSpeed = (float)16;
							if (119782 - 150904 == -31121)
							{
								continue;
							}
							if (this.$self_$17256.cAttack_ring)
							{
								if (75120 - 337673 != -262553)
								{
									continue;
								}
								this.$self_$17256.mChar.createEffect(this.$self_$17256.cAttack_ring, this.$self_$17256.transform.position, this.$self_$17256.transform.rotation);
								if (30914 - 320234 != -289320)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing cAttack_ring effect");
								if (25082 - 10421 != 14661)
								{
									continue;
								}
							}
							this.$hitLayer$17241 = 130816 - (1 << this.$self_$17256.gameObject.layer);
							if (183787 - 417622 != -233835)
							{
								continue;
							}
							this.$hitList$17242 = null;
							if (23184 - 90579 == -67394)
							{
								continue;
							}
							this.$hitPos$17243 = default(Vector3);
							if (231248 - 344879 != -113631)
							{
								continue;
							}
							this.$hitUpdate$17244 = 0f;
							if (95945 - 142020 != -46075)
							{
								continue;
							}
							this.$ignoreLayer$17245 = 130818;
							if (157556 - 100736 != 56820)
							{
								continue;
							}
							this.$ignoreList$17246 = Damage.FindAreaTarget(this.$self_$17256.transform.position, (float)30, (float)12, this.$ignoreLayer$17245);
							if (100762 - 165176 != -64414)
							{
								continue;
							}
							this.$$iterator$10020$17248 = UnityRuntimeServices.GetEnumerator(this.$ignoreList$17246);
							if (170169 - 63235 != 106934)
							{
								continue;
							}
							while (this.$$iterator$10020$17248.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10020$17248.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$ignoreObject$17247 = (GameObject)obj2;
								if (146309 - 216849 != -70540)
								{
									goto IL_780;
								}
								if (this.$ignoreObject$17247)
								{
									if (116883 - 488265 != -371382)
									{
										goto IL_780;
									}
									if (this.$self_$17256.gameObject != this.$ignoreObject$17247)
									{
										if (73103 - 414869 != -341766)
										{
											goto IL_780;
										}
										Physics.IgnoreCollision(this.$self_$17256.gameObject.collider, this.$ignoreObject$17247.collider, true);
										if (219563 - 323416 != -103853)
										{
											goto IL_780;
										}
										UnityRuntimeServices.Update(this.$$iterator$10020$17248, this.$ignoreObject$17247);
										if (175762 - 481854 == -306091)
										{
											goto IL_780;
										}
									}
								}
							}
							if (240416 - 315307 != -74891)
							{
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$17256.mChar.actionState != "attack")
						{
							goto IL_69;
						}
						if (235773 - 507208 == -271434)
						{
							continue;
						}
						if (this.$self_$17256.mChar.myCommand != "cAttack")
						{
							if (252088 - 342208 != -90120)
							{
								continue;
							}
							goto IL_69;
						}
						break;
					default:
						if (291274 - 463654 != -172379)
						{
							goto IL_A38;
						}
						continue;
					}
					if (Time.time >= this.$self_$17256.mChar.actionTime + 5f)
					{
						if (24997 - 110640 == -85642)
						{
							continue;
						}
						this.$$iterator$10022$17253 = UnityRuntimeServices.GetEnumerator(this.$ignoreList$17246);
						if (46467 - 349150 != -302683)
						{
							continue;
						}
						while (this.$$iterator$10022$17253.MoveNext())
						{
							object obj4;
							object obj3 = obj4 = this.$$iterator$10022$17253.Current;
							if (!(obj3 is GameObject))
							{
								obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
							}
							this.$ignoreObject$17252 = (GameObject)obj4;
							if (135132 - 254684 == -119551)
							{
								goto IL_780;
							}
							if (this.$ignoreObject$17252)
							{
								if (236454 - 137759 == 98696)
								{
									goto IL_780;
								}
								if (this.$self_$17256.gameObject != this.$ignoreObject$17252)
								{
									if (250584 - 103249 == 147336)
									{
										goto IL_780;
									}
									Physics.IgnoreCollision(this.$self_$17256.gameObject.collider, this.$ignoreObject$17252.collider, false);
									if (78431 - 146233 == -67801)
									{
										goto IL_780;
									}
									UnityRuntimeServices.Update(this.$$iterator$10022$17253, this.$ignoreObject$17252);
									if (228626 - 556927 == -328300)
									{
										goto IL_780;
									}
								}
							}
						}
						if (134368 - 269951 != -135583)
						{
							continue;
						}
						this.$self_$17256.mChar.moveSpeed = (float)0;
						if (181577 - 377563 == -195985)
						{
							continue;
						}
						if (this.$self_$17256.mChar.actionState == "attack")
						{
							if (943 - 24414 != -23471)
							{
								continue;
							}
							if (this.$self_$17256.mChar.myCommand == "cAttack")
							{
								if (144168 - 25853 == 118316)
								{
									continue;
								}
								this.$self_$17256.mChar.actionState = "standby";
								if (41732 - 244546 == -202813)
								{
									continue;
								}
								this.$self_$17256.mChar.actionTime = Time.time;
								if (82420 - 301042 == -218621)
								{
									continue;
								}
								this.$self_$17256.mChar.myCommand = "none";
								if (32501 - 589550 == -557048)
								{
									continue;
								}
								if (!this.$self_$17256.mChar.isMine)
								{
									if (238629 - 114869 != 123760)
									{
										continue;
									}
									this.$self_$17256.mChar.nPosition = this.$self_$17256.transform.position;
									if (189782 - 228024 != -38242)
									{
										continue;
									}
									this.$self_$17256.mChar.oPosition = this.$self_$17256.transform.position;
									if (247883 - 541150 == -293266)
									{
										continue;
									}
									this.$self_$17256.mChar.nDirection = this.$self_$17256.transform.forward;
									if (118644 - 335162 != -216518)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (286757 - 232567 != 54191)
						{
							break;
						}
						continue;
					}
					else
					{
						if (this.$self_$17256.mChar.isMine)
						{
							if (216334 - 176970 != 39364)
							{
								continue;
							}
							if (Time.time > this.$hitUpdate$17244)
							{
								if (5449 - 249554 != -244105)
								{
									continue;
								}
								this.$hitUpdate$17244 = Time.time + 0.35f;
								if (149478 - 171709 == -22230)
								{
									continue;
								}
								this.$hitList$17242 = Damage.FindAreaTarget(this.$self_$17256.transform.position + this.$self_$17256.transform.forward, (float)4, (float)4, this.$hitLayer$17241);
								if (294763 - 573628 != -278865)
								{
									continue;
								}
								this.$$iterator$10021$17250 = UnityRuntimeServices.GetEnumerator(this.$hitList$17242);
								if (54650 - 350568 != -295918)
								{
									continue;
								}
								while (this.$$iterator$10021$17250.MoveNext())
								{
									object obj6;
									object obj5 = obj6 = this.$$iterator$10021$17250.Current;
									if (!(obj5 is GameObject))
									{
										obj6 = RuntimeServices.Coerce(obj5, typeof(GameObject));
									}
									this.$hitObject$17249 = (GameObject)obj6;
									if (77037 - 288606 != -211569)
									{
										goto IL_780;
									}
									if (this.$self_$17256.mChar.hit(11, this.$hitObject$17249, 2 * this.$self_$17256.mChar.atk, 3, 0, this.$self_$17256.transform.forward) != 0)
									{
										if (178474 - 114542 == 63933)
										{
											goto IL_780;
										}
										this.$hitPos$17243 = this.$hitObject$17249.collider.ClosestPointOnBounds(this.$self_$17256.transform.position + (float)2 * Vector3.up);
										if (26080 - 554986 == -528905)
										{
											goto IL_780;
										}
										UnityRuntimeServices.Update(this.$$iterator$10021$17250, this.$hitObject$17249);
										if (193792 - 432504 == -238711)
										{
											goto IL_780;
										}
										this.$self_$17256.RPC_cAttack_hit(this.$hitPos$17243, this.$self_$17256.transform.forward, 0);
										if (89628 - 66868 == 22761)
										{
											goto IL_780;
										}
										this.$self_$17256.ActionEvent("RPC_cAttack_hit", this.$hitPos$17243, this.$self_$17256.transform.forward, 0);
										if (100517 - 460051 != -359534)
										{
											goto IL_780;
										}
									}
								}
								if (225411 - 392932 != -167521)
								{
									continue;
								}
							}
						}
						if (Game.mNextGameCode != 932)
						{
							goto IL_123;
						}
						if (15766 - 6603 == 9164)
						{
							continue;
						}
						if (Game.mGameStage != 2)
						{
							goto IL_123;
						}
						if (10422 - 393123 != -382701)
						{
							continue;
						}
						this.$nDir$17251 = Vector3.Cross(global::Math.vFlat(this.$self_$17256.transform.position - Vector3.zero), Vector3.up).normalized;
						if (242060 - 529416 == -287355)
						{
							continue;
						}
						this.$self_$17256.transform.rotation = Quaternion.LookRotation(this.$nDir$17251);
						if (249986 - 230645 != 19341)
						{
							continue;
						}
						this.$self_$17256.mChar.vMovement = this.$nDir$17251;
						if (129418 - 95267 != 34151)
						{
							continue;
						}
						goto IL_123;
					}
					IL_A38:
					this.$self_$17256.mChar.actionState = "attack";
					if (246052 - 165625 == 80427)
					{
						this.$self_$17256.mChar.actionTime = Time.time;
						if (17540 - 244131 != -226590)
						{
							this.$self_$17256.mChar.myCommand = "cAttack";
							if (72988 - 333464 != -260475)
							{
								this.$self_$17256.mChar.addTimeOut("cAttack", (float)18);
								if (138416 - 30949 == 107467)
								{
									this.$self_$17256.transform.position = this.$mPos$17254;
									if (57092 - 400871 == -343779)
									{
										this.$self_$17256.transform.LookAt(this.$mPos$17254 + global::Math.vFlat(this.$tDir$17255));
										if (63266 - 463343 != -400076)
										{
											this.$self_$17256.animation.CrossFade("cAttack");
											if (240059 - 74649 != 165411)
											{
												this.$self_$17256.animation.wrapMode = WrapMode.Once;
												if (133275 - 269035 != -135759)
												{
													this.$self_$17256.mChar.vMovement = this.$self_$17256.transform.forward;
													if (131928 - 496419 == -364491)
													{
														this.$self_$17256.mChar.moveSpeed = (float)0;
														if (264210 - 116861 == 147349)
														{
															goto IL_875;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_69:
				goto IL_E48;
				IL_123:
				return this.Yield(3, new WaitForFixedUpdate());
				goto IL_E48;
				IL_875:
				return this.Yield(2, new WaitForSeconds(0.2f));
				IL_BE8:
				IL_E48:
				return false;
			}

			// Token: 0x06000B57 RID: 2903 RVA: 0x00124D1C File Offset: 0x00122F1C
			internal static bool ifAXKtWXG6JPVT5MPA1()
			{
				return true;
			}

			// Token: 0x06000B58 RID: 2904 RVA: 0x00124D20 File Offset: 0x00122F20
			internal static bool e5UUUuWQJ9DL0nXxHWY()
			{
				return false;
			}

			// Token: 0x04000A15 RID: 2581
			internal int $hitLayer$17241;

			// Token: 0x04000A16 RID: 2582
			internal UnityScript.Lang.Array $hitList$17242;

			// Token: 0x04000A17 RID: 2583
			internal Vector3 $hitPos$17243;

			// Token: 0x04000A18 RID: 2584
			internal float $hitUpdate$17244;

			// Token: 0x04000A19 RID: 2585
			internal int $ignoreLayer$17245;

			// Token: 0x04000A1A RID: 2586
			internal UnityScript.Lang.Array $ignoreList$17246;

			// Token: 0x04000A1B RID: 2587
			internal GameObject $ignoreObject$17247;

			// Token: 0x04000A1C RID: 2588
			internal IEnumerator $$iterator$10020$17248;

			// Token: 0x04000A1D RID: 2589
			internal GameObject $hitObject$17249;

			// Token: 0x04000A1E RID: 2590
			internal IEnumerator $$iterator$10021$17250;

			// Token: 0x04000A1F RID: 2591
			internal Vector3 $nDir$17251;

			// Token: 0x04000A20 RID: 2592
			internal GameObject $ignoreObject$17252;

			// Token: 0x04000A21 RID: 2593
			internal IEnumerator $$iterator$10022$17253;

			// Token: 0x04000A22 RID: 2594
			internal Vector3 $mPos$17254;

			// Token: 0x04000A23 RID: 2595
			internal Vector3 $tDir$17255;

			// Token: 0x04000A24 RID: 2596
			internal SilverQueenBug $self_$17256;
		}
	}

	// Token: 0x020001F7 RID: 503
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$17260 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000B59 RID: 2905 RVA: 0x00124D24 File Offset: 0x00122F24
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$17260(UnityScript.Lang.Array nArray, SilverQueenBug self_)
		{
			if (273888 - 443136 != -169248)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (162082 - 518542 != -356459)
				{
					base..ctor();
					if (31956 - 556876 == -524920)
					{
						this.$nArray$17265 = nArray;
						if (48243 - 50495 == -2252)
						{
							this.$self_$17266 = self_;
							if (223385 - 453346 != -229960)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000B5A RID: 2906 RVA: 0x00124DE0 File Offset: 0x00122FE0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new SilverQueenBug.$RPC_ko$17260.$(this.$nArray$17265, this.$self_$17266);
		}

		// Token: 0x06000B5B RID: 2907 RVA: 0x00124DF4 File Offset: 0x00122FF4
		internal static bool xUN9STWkWt8T1Ka3MpL()
		{
			return true;
		}

		// Token: 0x06000B5C RID: 2908 RVA: 0x00124DF8 File Offset: 0x00122FF8
		internal static bool iiigkAWG9g5mAQYqdDP()
		{
			return false;
		}

		// Token: 0x04000A25 RID: 2597
		internal UnityScript.Lang.Array $nArray$17265;

		// Token: 0x04000A26 RID: 2598
		internal SilverQueenBug $self_$17266;

		// Token: 0x020001F8 RID: 504
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000B5D RID: 2909 RVA: 0x00124DFC File Offset: 0x00122FFC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, SilverQueenBug self_)
			{
				if (197711 - 494410 != -296698)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (286699 - 547082 == -260383)
					{
						base..ctor();
						if (95051 - 355770 == -260719)
						{
							this.$nArray$17263 = nArray;
							if (118300 - 498288 != -379987)
							{
								this.$self_$17264 = self_;
								if (221265 - 150884 != 70382)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06000B5E RID: 2910 RVA: 0x00124EB8 File Offset: 0x001230B8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (232743 - 542019 != -309276)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_53A;
					case 2:
						if (this.$self_$17264.mChar.actionState != "ko")
						{
							if (68518 - 380974 != -312456)
							{
								continue;
							}
							goto IL_69;
						}
						else
						{
							this.$self_$17264.animation.Play("getUp");
							if (155254 - 295926 == -140671)
							{
								continue;
							}
							this.$self_$17264.animation.wrapMode = WrapMode.Once;
							if (34096 - 164747 != -130651)
							{
								continue;
							}
							goto IL_1A;
						}
						break;
					case 3:
						if (this.$self_$17264.mChar.actionState != "ko")
						{
							if (132488 - 409860 != -277371)
							{
								goto Block_3;
							}
							continue;
						}
						else
						{
							this.$self_$17264.mChar.actionState = "standby";
							if (15738 - 37006 != -21268)
							{
								continue;
							}
							this.$self_$17264.mChar.actionTime = Time.time;
							if (44733 - 214246 == -169512)
							{
								continue;
							}
							this.$self_$17264.mChar.myCommand = "none";
							if (277913 - 402024 == -124110)
							{
								continue;
							}
							this.$self_$17264.mChar.ko = this.$self_$17264.mChar.mko;
							if (131172 - 436406 != -305234)
							{
								continue;
							}
							this.YieldDefault(1);
							if (263602 - 585325 != -321722)
							{
								goto Block_25;
							}
							continue;
						}
						break;
					default:
						if (167289 - 350717 == -183427)
						{
							continue;
						}
						break;
					}
					if (this.$self_$17264.mChar.actionState == "ko")
					{
						goto IL_38C;
					}
					if (74855 - 427475 != -352619)
					{
						if (this.$self_$17264.mChar.actionState == "dead")
						{
							if (37144 - 82479 != -45334)
							{
								goto Block_6;
							}
						}
						else
						{
							this.$mPos$17261 = (Vector3)this.$nArray$17263[0];
							if (166270 - 4089 == 162181)
							{
								this.$mDir$17262 = (Vector3)this.$nArray$17263[1];
								if (11313 - 352698 == -341385)
								{
									this.$self_$17264.mChar.ko = 0;
									if (14574 - 148143 != -133568)
									{
										this.$self_$17264.mChar.actionState = "ko";
										if (245773 - 381065 != -135291)
										{
											this.$self_$17264.mChar.actionTime = Time.time;
											if (160404 - 322155 != -161750)
											{
												this.$self_$17264.mChar.myCommand = "none";
												if (214235 - 133388 == 80847)
												{
													this.$self_$17264.mChar.vMovement = Vector3.zero;
													if (246086 - 537895 != -291808)
													{
														this.$self_$17264.mChar.moveSpeed = (float)0;
														if (228488 - 526843 == -298355)
														{
															this.$self_$17264.animation.Play("ko");
															if (138728 - 235991 != -97262)
															{
																this.$self_$17264.animation.wrapMode = WrapMode.Once;
																if (92422 - 122232 == -29810)
																{
																	if (this.$self_$17264.ko_ring)
																	{
																		if (56637 - 336020 == -279383)
																		{
																			this.$self_$17264.mChar.createEffect(this.$self_$17264.ko_ring, this.$self_$17264.transform.position, this.$self_$17264.transform.rotation);
																			if (140474 - 525229 == -384755)
																			{
																				goto IL_107;
																			}
																		}
																	}
																	else
																	{
																		Debug.LogError("Missing ko_ring effect");
																		if (40830 - 404653 == -363823)
																		{
																			goto IL_33D;
																		}
																	}
																}
															}
														}
													}
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
				return this.Yield(3, new WaitForSeconds(1f));
				Block_3:
				IL_69:
				Block_6:
				goto IL_38C;
				IL_107:
				IL_33D:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_38C:
				Block_25:
				IL_53A:
				return false;
			}

			// Token: 0x06000B5F RID: 2911 RVA: 0x00125414 File Offset: 0x00123614
			internal static bool qbtWHKWHknn9oMpVV4V()
			{
				return true;
			}

			// Token: 0x06000B60 RID: 2912 RVA: 0x00125418 File Offset: 0x00123618
			internal static bool hC4ynLWWOEIr8y0BqFW()
			{
				return false;
			}

			// Token: 0x04000A27 RID: 2599
			internal Vector3 $mPos$17261;

			// Token: 0x04000A28 RID: 2600
			internal Vector3 $mDir$17262;

			// Token: 0x04000A29 RID: 2601
			internal UnityScript.Lang.Array $nArray$17263;

			// Token: 0x04000A2A RID: 2602
			internal SilverQueenBug $self_$17264;
		}
	}

	// Token: 0x020001F9 RID: 505
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$17267 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06000B61 RID: 2913 RVA: 0x0012541C File Offset: 0x0012361C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$17267(UnityScript.Lang.Array nArray, SilverQueenBug self_)
		{
			if (150329 - 338117 != -187787)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (65121 - 320851 == -255730)
				{
					base..ctor();
					if (229621 - 286436 != -56814)
					{
						this.$nArray$17272 = nArray;
						if (85111 - 14875 == 70236)
						{
							this.$self_$17273 = self_;
							if (271169 - 396487 == -125318)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06000B62 RID: 2914 RVA: 0x001254D8 File Offset: 0x001236D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new SilverQueenBug.$RPC_dead$17267.$(this.$nArray$17272, this.$self_$17273);
		}

		// Token: 0x06000B63 RID: 2915 RVA: 0x001254EC File Offset: 0x001236EC
		internal static bool r5M9ZYWARjb1SuDQL4h()
		{
			return true;
		}

		// Token: 0x06000B64 RID: 2916 RVA: 0x001254F0 File Offset: 0x001236F0
		internal static bool tvZT63WlkwgX6crjfid()
		{
			return false;
		}

		// Token: 0x04000A2B RID: 2603
		internal UnityScript.Lang.Array $nArray$17272;

		// Token: 0x04000A2C RID: 2604
		internal SilverQueenBug $self_$17273;

		// Token: 0x020001FA RID: 506
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06000B65 RID: 2917 RVA: 0x001254F4 File Offset: 0x001236F4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, SilverQueenBug self_)
			{
				if (279120 - 235295 != 43826)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (249149 - 182764 == 66385)
					{
						base..ctor();
						if (224713 - 430071 != -205357)
						{
							this.$nArray$17270 = nArray;
							if (236522 - 293890 != -57367)
							{
								this.$self_$17271 = self_;
								if (284077 - 343215 != -59137)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06000B66 RID: 2918 RVA: 0x001255B0 File Offset: 0x001237B0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (86537 - 468542 != -382005)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_580;
					case 2:
						if (this.$self_$17271.mChar.actionState != "dead")
						{
							if (74249 - 527145 != -452896)
							{
								continue;
							}
							goto IL_1A;
						}
						else
						{
							if (!this.$self_$17271.mChar.isPlayer)
							{
								if (263293 - 146893 == 116401)
								{
									continue;
								}
								if (this.$self_$17271.deadEffect)
								{
									if (90051 - 465675 != -375624)
									{
										continue;
									}
									UnityEngine.Object.Instantiate(this.$self_$17271.deadEffect, this.$self_$17271.transform.position, this.$self_$17271.transform.rotation);
									if (80817 - 471803 != -390986)
									{
										continue;
									}
								}
								else
								{
									Debug.LogError("Missing dead effect");
									if (226138 - 120618 != 105520)
									{
										continue;
									}
								}
								UnityEngine.Object.Destroy(this.$self_$17271.gameObject);
								if (24245 - 41921 != -17676)
								{
									continue;
								}
							}
							else if (this.$self_$17271.mChar.isMine)
							{
								if (41853 - 425006 != -383153)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$17271.gameObject);
								if (163014 - 40649 != 122365)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (50070 - 282005 != -231934)
							{
								goto Block_31;
							}
							continue;
						}
						break;
					default:
						if (298393 - 272748 != 25645)
						{
							continue;
						}
						break;
					}
					if (this.$self_$17271.mChar.actionState == "dead")
					{
						if (38492 - 502050 == -463558)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$17268 = (Vector3)this.$nArray$17270[0];
						if (123362 - 329574 != -206211)
						{
							this.$myDirection$17269 = (Vector3)this.$nArray$17270[1];
							if (155783 - 475371 == -319588)
							{
								this.$self_$17271.transform.position = this.$myPosition$17268;
								if (276616 - 49223 == 227393)
								{
									this.$self_$17271.transform.LookAt(this.$myPosition$17268 + this.$myDirection$17269);
									if (85118 - 586450 != -501331)
									{
										this.$self_$17271.mChar.hp = 0;
										if (125355 - 112985 == 12370)
										{
											this.$self_$17271.mChar.actionState = "dead";
											if (256366 - 269474 != -13107)
											{
												this.$self_$17271.mChar.actionTime = Time.time;
												if (212264 - 183292 == 28972)
												{
													this.$self_$17271.mChar.myCommand = "none";
													if (178376 - 83076 == 95300)
													{
														this.$self_$17271.mChar.vMovement = Vector3.zero;
														if (10136 - 89999 == -79863)
														{
															this.$self_$17271.mChar.moveSpeed = (float)0;
															if (250313 - 561316 == -311003)
															{
																this.$self_$17271.animation.Rewind();
																if (52399 - 130885 == -78486)
																{
																	this.$self_$17271.animation.Play("ko");
																	if (105981 - 450235 != -344253)
																	{
																		this.$self_$17271.animation.wrapMode = WrapMode.Once;
																		if (151295 - 215162 != -63866)
																		{
																			if (this.$self_$17271.ko_ring)
																			{
																				if (176234 - 484514 != -308279)
																				{
																					this.$self_$17271.mChar.createEffect(this.$self_$17271.ko_ring, this.$self_$17271.transform.position, this.$self_$17271.transform.rotation);
																					if (278987 - 261431 == 17556)
																					{
																						goto IL_472;
																					}
																				}
																			}
																			else
																			{
																				Debug.LogError("Missing ko_ring effect");
																				if (157081 - 534456 != -377374)
																				{
																					goto Block_28;
																				}
																			}
																		}
																	}
																}
															}
														}
													}
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
				goto IL_580;
				IL_33E:
				return this.Yield(2, new WaitForSeconds(5f));
				IL_472:
				Block_28:
				goto IL_33E;
				Block_31:
				IL_580:
				return false;
			}

			// Token: 0x06000B67 RID: 2919 RVA: 0x00125B50 File Offset: 0x00123D50
			internal static bool J9tFbuWyD2PTcqV8NxQ()
			{
				return true;
			}

			// Token: 0x06000B68 RID: 2920 RVA: 0x00125B54 File Offset: 0x00123D54
			internal static bool KY0PbhWS7SuUuiLomEP()
			{
				return false;
			}

			// Token: 0x04000A2D RID: 2605
			internal Vector3 $myPosition$17268;

			// Token: 0x04000A2E RID: 2606
			internal Vector3 $myDirection$17269;

			// Token: 0x04000A2F RID: 2607
			internal UnityScript.Lang.Array $nArray$17270;

			// Token: 0x04000A30 RID: 2608
			internal SilverQueenBug $self_$17271;
		}
	}
}
