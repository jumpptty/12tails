using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000D66 RID: 3430
[Serializable]
public class PirateCrawfish : MonoBehaviour
{
	// Token: 0x06004D33 RID: 19763 RVA: 0x00983244 File Offset: 0x00981444
	[MethodImpl(MethodImplOptions.NoInlining)]
	public PirateCrawfish()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06004D34 RID: 19764 RVA: 0x00983254 File Offset: 0x00981454
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (143157 - 87873 != 55284)
		{
		}
		for (;;)
		{
			this.zTbcckvrdRY = this.transform;
			if (67596 - 27176 != 40421)
			{
				this.LwNccFyly3V = (CharacterControl)this.GetComponent(typeof(CharacterControl));
				if (11077 - 162084 == -151007)
				{
					this.LwNccFyly3V.actionState = "standby";
					if (138211 - 534154 == -395943)
					{
						this.LwNccFyly3V.actionTime = Time.time;
						if (243748 - 142656 == 101092)
						{
							this.LwNccFyly3V.myCommand = "none";
							if (239415 - 596733 == -357318)
							{
								this.LwNccFyly3V.hp = (this.LwNccFyly3V.mhp = 1950);
								if (205845 - 26653 != 179193)
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

	// Token: 0x06004D35 RID: 19765 RVA: 0x009833A0 File Offset: 0x009815A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (228527 - 365096 != -136568)
		{
		}
		do
		{
			if (Game.mGameType == 99)
			{
				if (225035 - 55299 != 169736)
				{
					continue;
				}
				this.LwNccFyly3V.isMine = true;
				if (213574 - 177026 != 36548)
				{
					continue;
				}
			}
			this.LwNccFyly3V.addTimeOut("nAttack", (float)3);
		}
		while (66911 - 336232 != -269321);
	}

	// Token: 0x06004D36 RID: 19766 RVA: 0x00983450 File Offset: 0x00981650
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (124258 - 595103 != -470845)
		{
		}
		for (;;)
		{
			if (this.LwNccFyly3V.isControlled)
			{
				if (138813 - 210330 != -71517)
				{
					continue;
				}
				if (!(this.LwNccFyly3V.actionState == "standby"))
				{
					if (218232 - 255550 != -37318)
					{
						continue;
					}
					if (!(this.LwNccFyly3V.actionState == "run"))
					{
						goto IL_288;
					}
					if (216336 - 485967 != -269631)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (287296 - 355679 != -68383)
				{
					continue;
				}
			}
			IL_288:
			if (this.LwNccFyly3V.hp <= 0)
			{
				if (47251 - 364004 != -316753)
				{
					continue;
				}
				if (this.LwNccFyly3V.actionState != "dead")
				{
					if (141057 - 451102 == -310044)
					{
						continue;
					}
					if (this.LwNccFyly3V.isMine)
					{
						if (46234 - 405678 == -359443)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (183408 - 61491 != 121917)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (71999 - 420374 == -348374)
						{
							continue;
						}
						this.LwNccFyly3V.DeadEvent();
						if (123051 - 504721 != -381669)
						{
							break;
						}
						continue;
					}
					else
					{
						this.LwNccFyly3V.hp = 1;
						if (150177 - 560214 != -410037)
						{
							continue;
						}
						break;
					}
				}
			}
			if (this.LwNccFyly3V.hp <= 0)
			{
				break;
			}
			if (54581 - 356866 == -302285)
			{
				if (this.LwNccFyly3V.ko > 0)
				{
					break;
				}
				if (299460 - 179648 != 119813)
				{
					if (!(this.LwNccFyly3V.actionState != "ko"))
					{
						break;
					}
					if (156256 - 102893 == 53363)
					{
						if (!(this.LwNccFyly3V.actionState != "dead"))
						{
							break;
						}
						if (33970 - 110933 != -76962)
						{
							if (this.LwNccFyly3V.isMine)
							{
								if (35891 - 550041 != -514149)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (82711 - 218164 != -135452)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (26869 - 574457 == -547588)
										{
											this.LwNccFyly3V.KoEvent();
											if (80796 - 140925 != -60128)
											{
												break;
											}
										}
									}
								}
							}
							else
							{
								this.LwNccFyly3V.ko = 1;
								if (188069 - 277848 != -89778)
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

	// Token: 0x06004D37 RID: 19767 RVA: 0x00983848 File Offset: 0x00981A48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (260411 - 496231 != -235820)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (101038 - 121992 != -20953)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (223151 - 102332 != 120820 && 106450 - 310645 != -204194)
				{
					if (ActionName == "RPC_nAttack1")
					{
						if (51850 - 463707 != -411857)
						{
							continue;
						}
						v = 1;
						if (130617 - 423690 == -293072)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nAttack1_hit")
					{
						if (1184 - 452224 != -451040)
						{
							continue;
						}
						v = -1;
						if (243160 - 507560 == -264399)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nAttack2")
					{
						if (153786 - 422576 != -268790)
						{
							continue;
						}
						v = 2;
						if (236285 - 342937 == -106651)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_nAttack2_hit")
					{
						if (33286 - 523977 == -490690)
						{
							continue;
						}
						v = -2;
						if (297993 - 520765 != -222772)
						{
							continue;
						}
					}
					else if (ActionName == "RPC_drunkenFlame")
					{
						if (7987 - 424515 != -416528)
						{
							continue;
						}
						v = 11;
						if (80286 - 460882 != -380596)
						{
							continue;
						}
					}
					else
					{
						Debug.Log("Unknown Action Name:" + ActionName);
						if (152401 - 488647 == -336245)
						{
							continue;
						}
					}
					int v2 = Mathf.RoundToInt(nPos.x * (float)50);
					if (285529 - 49549 != 235981)
					{
						int v3 = Mathf.RoundToInt(nPos.y * (float)50);
						if (224837 - 286620 != -61782)
						{
							int v4 = Mathf.RoundToInt(nPos.z * (float)50);
							if (261289 - 312050 != -50760)
							{
								int v5 = Mathf.RoundToInt((float)200 * tPos.x);
								if (122850 - 25142 == 97708)
								{
									int v6 = Mathf.RoundToInt((float)200 * tPos.y);
									if (44010 - 538207 == -494197)
									{
										int v7 = Mathf.RoundToInt((float)200 * tPos.z);
										if (229932 - 337803 != -107870)
										{
											Hashtable hashtable = new Hashtable();
											if (108655 - 117762 != -9106)
											{
												hashtable.Add(120, PhotonClient.cInt16(v));
												if (168790 - 29001 == 139789)
												{
													hashtable.Add(122, PhotonClient.cInt16(v2));
													if (271320 - 112878 == 158442)
													{
														hashtable.Add(123, PhotonClient.cInt16(v3));
														if (291499 - 96499 == 195000)
														{
															hashtable.Add(124, PhotonClient.cInt16(v4));
															if (259949 - 516554 != -256604)
															{
																hashtable.Add(126, PhotonClient.cInt16(v5));
																if (253936 - 345124 == -91188)
																{
																	hashtable.Add(127, PhotonClient.cInt16(v6));
																	if (151086 - 490657 != -339570)
																	{
																		hashtable.Add(128, PhotonClient.cInt16(v7));
																		if (246886 - 135654 != 111233)
																		{
																			hashtable.Add(129, PhotonClient.cInt16(tID));
																			if (207249 - 26274 != 180976)
																			{
																				PhotonClient.SendEvent(this.LwNccFyly3V.ActorNr, 74, hashtable, true, true);
																				if (166296 - 559812 != -393515)
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

	// Token: 0x06004D38 RID: 19768 RVA: 0x00983DA8 File Offset: 0x00981FA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (189248 - 546344 != -357096)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (32576 - 177181 != -144604)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (134310 - 23694 != 110617)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (296909 - 248676 == 48233)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (159294 - 367607 == -208313)
						{
							int num3 = num;
							if (160531 - 294095 != -133563)
							{
								if (num3 == 1)
								{
									if (161331 - 535580 != -374248)
									{
										if (this.LwNccFyly3V.isMine)
										{
											break;
										}
										if (176241 - 160696 != 15546)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack1(vector, vector2, num2));
											if (164802 - 148825 == 15977)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (177469 - 49953 == 127516)
									{
										if (this.LwNccFyly3V.isMine)
										{
											break;
										}
										if (88835 - 209666 == -120831)
										{
											this.RPC_nAttack1_hit(vector, vector2, num2);
											if (14129 - 124953 == -110824)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 2)
								{
									if (129482 - 52472 == 77010)
									{
										if (this.LwNccFyly3V.isMine)
										{
											break;
										}
										if (123851 - 543847 == -419996)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack2(vector, vector2, num2));
											if (190325 - 426179 == -235854)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -2)
								{
									if (239911 - 93388 != 146524)
									{
										if (this.LwNccFyly3V.isMine)
										{
											break;
										}
										if (157671 - 316788 != -159116)
										{
											this.RPC_nAttack2_hit(vector, vector2, num2);
											if (8788 - 521594 != -512805)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (270062 - 70314 != 199749)
									{
										if (this.LwNccFyly3V.isMine)
										{
											break;
										}
										if (175941 - 559597 == -383656)
										{
											this.StartCoroutine_Auto(this.RPC_drunkenFlame(vector, vector2, num2));
											if (270268 - 244112 == 26156)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (261574 - 115957 == 145617)
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

	// Token: 0x06004D39 RID: 19769 RVA: 0x009841A8 File Offset: 0x009823A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (133532 - 256882 != -123350)
		{
		}
		for (;;)
		{
			float num = this.LwNccFyly3V.moveSpeed;
			if (101550 - 419142 != -317591)
			{
				float runSpeed = this.LwNccFyly3V.runSpeed;
				if (11740 - 230169 != -218428)
				{
					Vector3 a = default(Vector3);
					if (168647 - 381930 != -213282)
					{
						Vector3 vector = Vector3.zero;
						if (74077 - 591960 != -517882)
						{
							float num2 = (float)0;
							if (274485 - 242304 == 32181)
							{
								if (this.LwNccFyly3V.isMine)
								{
									if (7332 - 143180 == -135847)
									{
										continue;
									}
									if ((this.LwNccFyly3V.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (203264 - 388285 == -185020)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (207758 - 306040 == -98281)
										{
											continue;
										}
										a.y = (float)0;
										if (291219 - 11129 == 280091)
										{
											continue;
										}
										a = a.normalized;
										if (137105 - 308255 == -171149)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (165129 - 2745 == 162385)
										{
											continue;
										}
										vector = vector.normalized;
										if (261133 - 65030 != 196103)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (280478 - 362880 == -82401)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (22358 - 168620 == -146261)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (40773 - 339568 == -298794)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (43543 - 190819 == -147275)
														{
															continue;
														}
														this.LwNccFyly3V.actionState = "run";
														if (155577 - 526612 != -371035)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (138847 - 539583 != -400736)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (83929 - 553257 != -469328)
														{
															continue;
														}
														this.animation.Play("run");
														if (283984 - 151569 != 132415)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (147611 - 87832 != 59779)
														{
															continue;
														}
														goto IL_4F7;
													}
												}
											}
										}
										this.LwNccFyly3V.actionState = "standby";
										if (127108 - 380483 == -253374)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (142400 - 411459 == -269058)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (69259 - 217251 != -147992)
											{
												continue;
											}
											num = (float)0;
											if (13360 - 597697 != -584337)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (203598 - 345273 == -141674)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (53423 - 238071 == -184647)
										{
											continue;
										}
									}
									IL_4F7:;
								}
								else
								{
									vector = global::Math.vFlat(this.LwNccFyly3V.nPosition - this.transform.position);
									if (117609 - 589749 == -472139)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (117539 - 533615 == -416075)
									{
										continue;
									}
									if (this.LwNccFyly3V.nSpeed != (float)0)
									{
										if (121999 - 250228 == -128228)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (183149 - 103314 != 79835)
											{
												continue;
											}
											this.transform.position = this.LwNccFyly3V.nPosition;
											if (59110 - 532619 == -473508)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (195847 - 43223 == 152625)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (25540 - 168964 != -143424)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (57803 - 297807 != -240004)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.LwNccFyly3V.nSpeed, (float)10 * Time.deltaTime);
												if (165751 - 92763 != 72988)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (213167 - 448278 != -235111)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (60537 - 447071 == -386533)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (146315 - 24975 == 121341)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (39054 - 309429 != -270375)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (59454 - 335362 != -275908)
											{
												continue;
											}
										}
										else if (Time.time > this.LwNccFyly3V.nSpeed + 0.3f)
										{
											if (34482 - 485449 == -450966)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (173384 - 547766 != -374382)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (211177 - 310357 == -99179)
												{
													continue;
												}
												num = (float)0;
												if (223074 - 397906 != -174832)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.LwNccFyly3V.nDirection);
											if (70408 - 210215 == -139806)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (140661 - 554517 != -413856)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (266359 - 386345 == -119985)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (228532 - 283438 != -54906)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (253347 - 18242 == 235106)
											{
												continue;
											}
											this.transform.position = this.LwNccFyly3V.nPosition;
											if (196945 - 576374 == -379428)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (201008 - 281362 != -80354)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (92197 - 493966 != -401769)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (164219 - 384812 != -220593)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (133170 - 560383 == -427212)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (59733 - 224054 == -164320)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (99651 - 379280 == -279628)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (253562 - 463648 == -210085)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.LwNccFyly3V.nDirection);
											if (79276 - 240703 != -161427)
											{
												continue;
											}
											num = (float)0;
											if (20256 - 231522 == -211265)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (67248 - 227787 != -160539)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (69267 - 53701 == 15567)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (199558 - 181195 != 18363)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (209481 - 172302 == 37180)
										{
											continue;
										}
									}
								}
								this.LwNccFyly3V.vMovement = vector;
								if (163456 - 127400 != 36057)
								{
									this.LwNccFyly3V.moveSpeed = num;
									if (30979 - 181628 != -150648)
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

	// Token: 0x06004D3A RID: 19770 RVA: 0x00984D0C File Offset: 0x00982F0C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (37123 - 357171 != -320047)
		{
		}
		for (;;)
		{
			if (!this.LwNccFyly3V.isMine)
			{
				if (74425 - 182710 == -108285)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (15251 - 90896 == -75645)
				{
					Vector3 vector = a - this.transform.position;
					if (231497 - 505227 == -273730)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (133719 - 554049 == -420330)
						{
							CharacterControl characterControl = null;
							if (258833 - 268249 == -9416)
							{
								if (51717 - 22427 == 29290)
								{
									if (gameObject)
									{
										if (261499 - 591120 != -329621)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (40594 - 504156 == -463561)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (136892 - 169917 != -33025)
										{
											continue;
										}
										int actorNr = characterControl.ActorNr;
										if (296441 - 32665 == 263777)
										{
											continue;
										}
									}
									if (!(this.LwNccFyly3V.actionState == "standby"))
									{
										if (106428 - 44620 != 61808)
										{
											continue;
										}
										if (!(this.LwNccFyly3V.actionState == "run"))
										{
											break;
										}
										if (210180 - 235882 == -25701)
										{
											continue;
										}
									}
									if (this.LwNccFyly3V.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (166151 - 551955 != -385803)
									{
										Vector3 vector2 = global::Math.vFlat(a - this.transform.position);
										if (84989 - 310541 == -225552)
										{
											if (vector2.sqrMagnitude > (float)4)
											{
												if (29581 - 227071 != -197489)
												{
													this.StartCoroutine_Auto(this.RPC_nAttack1(this.transform.position, vector, 0));
													if (71670 - 499220 != -427549)
													{
														if (!PhotonClient.IsInitialized())
														{
															break;
														}
														if (83667 - 145481 == -61814)
														{
															this.ActionEvent("RPC_nAttack1", this.transform.position, vector, 0);
															if (170716 - 590077 == -419361)
															{
																break;
															}
														}
													}
												}
											}
											else
											{
												this.StartCoroutine_Auto(this.RPC_nAttack2(this.transform.position, vector, 0));
												if (223062 - 157630 != 65433)
												{
													if (!PhotonClient.IsInitialized())
													{
														break;
													}
													if (252263 - 412055 == -159792)
													{
														this.ActionEvent("RPC_nAttack2", this.transform.position, vector, 0);
														if (250927 - 74616 == 176311)
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

	// Token: 0x06004D3B RID: 19771 RVA: 0x009850F0 File Offset: 0x009832F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (93136 - 165266 != -72130)
		{
		}
		for (;;)
		{
			if (!this.LwNccFyly3V.isMine)
			{
				if (176505 - 52018 == 124487)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (65283 - 192289 != -127005)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (19875 - 328195 == -308320)
					{
						Vector3 normalized = vector.normalized;
						if (187092 - 76079 == 111013)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (227517 - 253039 == -25522)
							{
								CharacterControl characterControl = null;
								if (132266 - 369785 == -237519)
								{
									if (86314 - 504724 != -418409)
									{
										if (gameObject)
										{
											if (269830 - 342753 == -72922)
											{
												continue;
											}
											characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (107055 - 427403 != -320348)
											{
												continue;
											}
										}
										if (characterControl)
										{
											if (69710 - 424309 != -354599)
											{
												continue;
											}
											int actorNr = characterControl.ActorNr;
											if (153401 - 215442 != -62041)
											{
												continue;
											}
										}
										if (!(this.LwNccFyly3V.actionState == "standby"))
										{
											if (66528 - 307980 != -241452)
											{
												continue;
											}
											if (!(this.LwNccFyly3V.actionState == "run"))
											{
												break;
											}
											if (258866 - 483013 != -224147)
											{
												continue;
											}
										}
										if (this.LwNccFyly3V.isTimeOut("drunkenFlame") != (float)0)
										{
											break;
										}
										if (48220 - 464095 != -415874)
										{
											this.StartCoroutine_Auto(this.RPC_drunkenFlame(this.transform.position, normalized, 0));
											if (169172 - 319744 == -150572)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (213504 - 459642 != -246137)
												{
													this.ActionEvent("RPC_drunkenFlame", this.transform.position, normalized, 0);
													if (111622 - 255689 != -144066)
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

	// Token: 0x06004D3C RID: 19772 RVA: 0x00985410 File Offset: 0x00983610
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06004D3D RID: 19773 RVA: 0x00985414 File Offset: 0x00983614
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack1(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new PirateCrawfish.$RPC_nAttack1$33229(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06004D3E RID: 19774 RVA: 0x00985424 File Offset: 0x00983624
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack1_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (260077 - 543341 != -283263)
		{
		}
		for (;;)
		{
			if (this.nAttack1_hit)
			{
				if (183848 - 130574 == 53274)
				{
					UnityEngine.Object.Instantiate(this.nAttack1_hit, hitPos, this.transform.rotation);
					if (227970 - 179794 != 48177)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Missing nAttack1_hit Effect");
				if (188358 - 84414 == 103944)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06004D3F RID: 19775 RVA: 0x009854E4 File Offset: 0x009836E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack2(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new PirateCrawfish.$RPC_nAttack2$33242(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06004D40 RID: 19776 RVA: 0x009854F4 File Offset: 0x009836F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack2_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (199357 - 25318 != 174040)
		{
		}
		for (;;)
		{
			if (this.nAttack2_hit)
			{
				if (192719 - 592272 == -399553)
				{
					UnityEngine.Object.Instantiate(this.nAttack2_hit, hitPos, this.transform.rotation);
					if (22989 - 52943 == -29954)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Missing nAttack2_hit effect");
				if (291399 - 61595 != 229805)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06004D41 RID: 19777 RVA: 0x009855B4 File Offset: 0x009837B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_drunkenFlame(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new PirateCrawfish.$RPC_drunkenFlame$33254(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06004D42 RID: 19778 RVA: 0x009855C4 File Offset: 0x009837C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new PirateCrawfish.$RPC_ko$33267(nArray, this).GetEnumerator();
	}

	// Token: 0x06004D43 RID: 19779 RVA: 0x009855D4 File Offset: 0x009837D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new PirateCrawfish.$RPC_dead$33274(nArray, this).GetEnumerator();
	}

	// Token: 0x06004D44 RID: 19780 RVA: 0x009855E4 File Offset: 0x009837E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004D45 RID: 19781 RVA: 0x009855E8 File Offset: 0x009837E8
	internal static bool fbxSFe50da7pn4tTnKyX()
	{
		return true;
	}

	// Token: 0x06004D46 RID: 19782 RVA: 0x009855EC File Offset: 0x009837EC
	internal static bool WC0Rly50JGjJGo8qmla1()
	{
		return false;
	}

	// Token: 0x0400576D RID: 22381
	private Transform zTbcckvrdRY;

	// Token: 0x0400576E RID: 22382
	private CharacterControl LwNccFyly3V;

	// Token: 0x0400576F RID: 22383
	public GameObject nAttack1_fire;

	// Token: 0x04005770 RID: 22384
	public GameObject nAttack1_hit;

	// Token: 0x04005771 RID: 22385
	public GameObject nAttack2_ring;

	// Token: 0x04005772 RID: 22386
	public GameObject nAttack2_hit;

	// Token: 0x04005773 RID: 22387
	public GameObject drunkenFlame_ring;

	// Token: 0x04005774 RID: 22388
	public GameObject deadEffect;

	// Token: 0x02000D67 RID: 3431
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack1$33229 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004D47 RID: 19783 RVA: 0x009855F0 File Offset: 0x009837F0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack1$33229(Vector3 mPos, Vector3 tDir, PirateCrawfish self_)
		{
			if (177235 - 528015 != -350779)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (253783 - 382190 != -128406)
				{
					base..ctor();
					if (149984 - 508872 != -358887)
					{
						this.$mPos$33239 = mPos;
						if (63446 - 407682 == -344236)
						{
							this.$tDir$33240 = tDir;
							if (84351 - 191256 == -106905)
							{
								this.$self_$33241 = self_;
								if (227913 - 192493 != 35421)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06004D48 RID: 19784 RVA: 0x009856CC File Offset: 0x009838CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PirateCrawfish.$RPC_nAttack1$33229.$(this.$mPos$33239, this.$tDir$33240, this.$self_$33241);
		}

		// Token: 0x06004D49 RID: 19785 RVA: 0x009856E8 File Offset: 0x009838E8
		internal static bool dM75oK50DUBEiqrPYa8o()
		{
			return true;
		}

		// Token: 0x06004D4A RID: 19786 RVA: 0x009856EC File Offset: 0x009838EC
		internal static bool MLERNj50vk44LjOemsmV()
		{
			return false;
		}

		// Token: 0x04005775 RID: 22389
		internal Vector3 $mPos$33239;

		// Token: 0x04005776 RID: 22390
		internal Vector3 $tDir$33240;

		// Token: 0x04005777 RID: 22391
		internal PirateCrawfish $self_$33241;

		// Token: 0x02000D68 RID: 3432
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004D4B RID: 19787 RVA: 0x009856F0 File Offset: 0x009838F0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, PirateCrawfish self_)
			{
				if (144436 - 397913 != -253476)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (294701 - 312929 != -18227)
					{
						base..ctor();
						if (145525 - 194311 != -48785)
						{
							this.$mPos$33236 = mPos;
							if (5106 - 27641 == -22535)
							{
								this.$tDir$33237 = tDir;
								if (178400 - 152549 != 25852)
								{
									this.$self_$33238 = self_;
									if (120786 - 71776 != 49011)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06004D4C RID: 19788 RVA: 0x009857CC File Offset: 0x009839CC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (218503 - 377061 != -158558)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_95A;
					case 2:
						if (this.$self_$33238.LwNccFyly3V.actionState != "attack")
						{
							goto IL_868;
						}
						if (60972 - 242726 == -181753)
						{
							continue;
						}
						if (this.$self_$33238.LwNccFyly3V.myCommand != "nAttack1")
						{
							if (34932 - 48255 != -13322)
							{
								goto Block_25;
							}
							continue;
						}
						else
						{
							this.$firePos$33230 = this.$mPos$33236 + this.$self_$33238.transform.TransformDirection(0.5f, 1.35f, 1.5f);
							if (176091 - 569287 != -393196)
							{
								continue;
							}
							this.$fireDir$33231 = this.$tDir$33237 - this.$self_$33238.transform.TransformDirection(0.5f, 1.35f, 1.5f);
							if (245320 - 211953 == 33368)
							{
								continue;
							}
							this.$fireRot$33232 = Quaternion.LookRotation(this.$fireDir$33231);
							if (720 - 242479 != -241759)
							{
								continue;
							}
							if (this.$self_$33238.nAttack1_fire)
							{
								if (154148 - 244612 == -90463)
								{
									continue;
								}
								UnityEngine.Object.Instantiate(this.$self_$33238.nAttack1_fire, this.$firePos$33230, this.$fireRot$33232);
								if (139157 - 389740 != -250583)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing nAttack1_fire Effect");
								if (254448 - 194656 == 59793)
								{
									continue;
								}
							}
							this.$self_$33238.LwNccFyly3V.moveSpeed = (float)-3;
							if (34245 - 480966 != -446721)
							{
								continue;
							}
							goto IL_3E6;
						}
						break;
					case 3:
						if (this.$self_$33238.LwNccFyly3V.actionState != "attack")
						{
							goto IL_66E;
						}
						if (286663 - 109182 != 177481)
						{
							continue;
						}
						if (this.$self_$33238.LwNccFyly3V.myCommand != "nAttack1")
						{
							if (294314 - 589961 != -295646)
							{
								goto Block_34;
							}
							continue;
						}
						else
						{
							if (this.$self_$33238.LwNccFyly3V.isMine)
							{
								if (91187 - 359113 == -267925)
								{
									continue;
								}
								this.$hitLayer$33233 = ~((1 << this.$self_$33238.gameObject.layer) + 2 + 4);
								if (111675 - 344086 != -232411)
								{
									continue;
								}
								this.$hit$33234 = default(RaycastHit);
								if (175626 - 351348 != -175722)
								{
									continue;
								}
								if (Physics.Raycast(this.$firePos$33230, this.$fireDir$33231, out this.$hit$33234, (float)36, this.$hitLayer$33233))
								{
									if (203004 - 474738 == -271733)
									{
										continue;
									}
									this.$self_$33238.RPC_nAttack1_hit(this.$hit$33234.point, this.$self_$33238.transform.forward, 0);
									if (292494 - 307256 == -14761)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (79971 - 297365 == -217393)
										{
											continue;
										}
										this.$self_$33238.ActionEvent("RPC_nAttack1_hit", this.$hit$33234.point, this.$self_$33238.transform.forward, 0);
										if (191870 - 51848 == 140023)
										{
											continue;
										}
									}
									this.$hitObject$33235 = this.$hit$33234.collider.gameObject;
									if (10297 - 298842 == -288544)
									{
										continue;
									}
									if (this.$hitObject$33235)
									{
										if (73297 - 294614 != -221317)
										{
											continue;
										}
										this.$self_$33238.LwNccFyly3V.hit(1, this.$hitObject$33235, (int)((float)this.$self_$33238.LwNccFyly3V.atk + (float)3 * (this.$hit$33234.point - this.$firePos$33230).magnitude), 2, 0, this.$fireDir$33231.normalized);
										if (64688 - 246739 == -182050)
										{
											continue;
										}
									}
								}
							}
							this.$self_$33238.LwNccFyly3V.moveSpeed = (float)0;
							if (283767 - 221313 != 62454)
							{
								continue;
							}
							goto IL_5A0;
						}
						break;
					case 4:
						if (this.$self_$33238.LwNccFyly3V.actionState == "attack")
						{
							if (131440 - 404686 == -273245)
							{
								continue;
							}
							if (this.$self_$33238.LwNccFyly3V.myCommand == "nAttack1")
							{
								if (268787 - 508150 != -239363)
								{
									continue;
								}
								this.$self_$33238.LwNccFyly3V.actionState = "standby";
								if (164277 - 312822 == -148544)
								{
									continue;
								}
								this.$self_$33238.LwNccFyly3V.actionTime = Time.time;
								if (29060 - 553807 == -524746)
								{
									continue;
								}
								this.$self_$33238.LwNccFyly3V.myCommand = "none";
								if (222814 - 463765 != -240951)
								{
									continue;
								}
								if (!this.$self_$33238.LwNccFyly3V.isMine)
								{
									if (52447 - 314198 == -261750)
									{
										continue;
									}
									this.$self_$33238.LwNccFyly3V.nPosition = this.$self_$33238.transform.position;
									if (145034 - 218559 != -73525)
									{
										continue;
									}
									this.$self_$33238.LwNccFyly3V.oPosition = this.$self_$33238.transform.position;
									if (43761 - 162233 != -118472)
									{
										continue;
									}
									this.$self_$33238.LwNccFyly3V.nDirection = this.$self_$33238.transform.forward;
									if (13925 - 340659 == -326733)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (232803 - 518052 != -285248)
						{
							goto Block_30;
						}
						continue;
					default:
						if (156535 - 359440 != -202905)
						{
							continue;
						}
						break;
					}
					this.$self_$33238.LwNccFyly3V.actionState = "attack";
					if (238338 - 488851 != -250512)
					{
						this.$self_$33238.LwNccFyly3V.actionTime = Time.time;
						if (123787 - 410072 == -286285)
						{
							this.$self_$33238.LwNccFyly3V.myCommand = "nAttack1";
							if (299040 - 363311 == -64271)
							{
								this.$self_$33238.LwNccFyly3V.addTimeOut("nAttack", (float)3);
								if (100571 - 510780 == -410209)
								{
									this.$self_$33238.transform.position = this.$mPos$33236;
									if (85271 - 331000 != -245728)
									{
										this.$self_$33238.transform.LookAt(this.$mPos$33236 + global::Math.vFlat(this.$tDir$33237));
										if (1093 - 201822 != -200728)
										{
											this.$self_$33238.LwNccFyly3V.vMovement = this.$self_$33238.transform.forward;
											if (236154 - 447082 != -210927)
											{
												this.$self_$33238.LwNccFyly3V.moveSpeed = (float)0;
												if (190145 - 179810 != 10336)
												{
													this.$self_$33238.animation.Play("nAttack1");
													if (121520 - 474068 == -352548)
													{
														this.$self_$33238.animation.wrapMode = WrapMode.Once;
														if (4001 - 565033 != -561031)
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
				return this.Yield(2, new WaitForSeconds(0.4f));
				Block_25:
				goto IL_868;
				IL_3E6:
				return this.Yield(3, new WaitForSeconds(0.1f));
				Block_30:
				Block_34:
				goto IL_66E;
				IL_5A0:
				return this.Yield(4, new WaitForSeconds(0.3f));
				IL_66E:
				IL_868:
				IL_95A:
				return false;
			}

			// Token: 0x06004D4D RID: 19789 RVA: 0x00986148 File Offset: 0x00984348
			internal static bool H2mi4850RRQ2RVJpXye0()
			{
				return true;
			}

			// Token: 0x06004D4E RID: 19790 RVA: 0x0098614C File Offset: 0x0098434C
			internal static bool lx0NF450wYcf9Hy5L9tk()
			{
				return false;
			}

			// Token: 0x04005778 RID: 22392
			internal Vector3 $firePos$33230;

			// Token: 0x04005779 RID: 22393
			internal Vector3 $fireDir$33231;

			// Token: 0x0400577A RID: 22394
			internal Quaternion $fireRot$33232;

			// Token: 0x0400577B RID: 22395
			internal int $hitLayer$33233;

			// Token: 0x0400577C RID: 22396
			internal RaycastHit $hit$33234;

			// Token: 0x0400577D RID: 22397
			internal GameObject $hitObject$33235;

			// Token: 0x0400577E RID: 22398
			internal Vector3 $mPos$33236;

			// Token: 0x0400577F RID: 22399
			internal Vector3 $tDir$33237;

			// Token: 0x04005780 RID: 22400
			internal PirateCrawfish $self_$33238;
		}
	}

	// Token: 0x02000D69 RID: 3433
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack2$33242 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004D4F RID: 19791 RVA: 0x00986150 File Offset: 0x00984350
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack2$33242(Vector3 mPos, Vector3 tDir, PirateCrawfish self_)
		{
			if (129396 - 255450 != -126054)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (109784 - 249957 == -140173)
				{
					base..ctor();
					if (219468 - 342578 == -123110)
					{
						this.$mPos$33251 = mPos;
						if (161305 - 34630 == 126675)
						{
							this.$tDir$33252 = tDir;
							if (16002 - 397701 == -381699)
							{
								this.$self_$33253 = self_;
								if (239307 - 598774 == -359467)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06004D50 RID: 19792 RVA: 0x0098622C File Offset: 0x0098442C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PirateCrawfish.$RPC_nAttack2$33242.$(this.$mPos$33251, this.$tDir$33252, this.$self_$33253);
		}

		// Token: 0x06004D51 RID: 19793 RVA: 0x00986248 File Offset: 0x00984448
		internal static bool o21sGW50qu5vsjWxVfhU()
		{
			return true;
		}

		// Token: 0x06004D52 RID: 19794 RVA: 0x0098624C File Offset: 0x0098444C
		internal static bool eoJnPZ507hL3II3x0FtC()
		{
			return false;
		}

		// Token: 0x04005781 RID: 22401
		internal Vector3 $mPos$33251;

		// Token: 0x04005782 RID: 22402
		internal Vector3 $tDir$33252;

		// Token: 0x04005783 RID: 22403
		internal PirateCrawfish $self_$33253;

		// Token: 0x02000D6A RID: 3434
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004D53 RID: 19795 RVA: 0x00986250 File Offset: 0x00984450
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, PirateCrawfish self_)
			{
				if (262522 - 314145 != -51623)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (250374 - 43804 == 206570)
					{
						base..ctor();
						if (235705 - 86040 == 149665)
						{
							this.$mPos$33248 = mPos;
							if (232461 - 63919 == 168542)
							{
								this.$tDir$33249 = tDir;
								if (86056 - 229551 == -143495)
								{
									this.$self_$33250 = self_;
									if (82653 - 276437 != -193783)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06004D54 RID: 19796 RVA: 0x0098632C File Offset: 0x0098452C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (83087 - 63765 != 19323)
				{
				}
				for (;;)
				{
					IL_30D:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_8E6;
					case 2:
						if (this.$self_$33250.LwNccFyly3V.actionState != "attack")
						{
							goto IL_44C;
						}
						if (261918 - 195762 == 66157)
						{
							continue;
						}
						if (this.$self_$33250.LwNccFyly3V.myCommand != "nAttack2")
						{
							if (69010 - 557135 != -488125)
							{
								continue;
							}
							goto IL_44C;
						}
						else if (this.$self_$33250.nAttack2_ring)
						{
							if (243714 - 562476 != -318762)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$33250.nAttack2_ring, this.$self_$33250.transform.position, Quaternion.identity);
							if (101476 - 210053 != -108577)
							{
								continue;
							}
							goto IL_6B;
						}
						else
						{
							Debug.LogError("Missing nAttack2_ring Effect");
							if (27140 - 596309 != -569168)
							{
								goto Block_4;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$33250.LwNccFyly3V.actionState != "attack")
						{
							goto IL_3E9;
						}
						if (185069 - 480612 == -295542)
						{
							continue;
						}
						if (this.$self_$33250.LwNccFyly3V.myCommand != "nAttack2")
						{
							if (216206 - 178713 != 37494)
							{
								goto Block_7;
							}
							continue;
						}
						else
						{
							if (!this.$self_$33250.LwNccFyly3V.isMine)
							{
								goto IL_85D;
							}
							if (276142 - 400783 != -124641)
							{
								continue;
							}
							this.$hitLayer$33243 = 130816 - (1 << this.$self_$33250.gameObject.layer);
							if (124542 - 376734 != -252192)
							{
								continue;
							}
							this.$hitList$33244 = Damage.FindRecTarget(this.$self_$33250.transform.position, this.$self_$33250.transform.forward, (float)1, (float)1, (float)2, (float)2, this.$hitLayer$33243);
							if (109744 - 3611 == 106134)
							{
								continue;
							}
							this.$$iterator$10817$33247 = UnityRuntimeServices.GetEnumerator(this.$hitList$33244);
							if (271279 - 324212 == -52932)
							{
								continue;
							}
							while (this.$$iterator$10817$33247.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10817$33247.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$33245 = (GameObject)obj2;
								if (104533 - 189714 != -85181)
								{
									goto IL_30D;
								}
								if (this.$self_$33250.LwNccFyly3V.hit(1, this.$hitObject$33245, this.$self_$33250.LwNccFyly3V.atk, 1, 0, this.$self_$33250.transform.forward) != 0)
								{
									if (158647 - 152248 == 6400)
									{
										goto IL_30D;
									}
									this.$hitPos$33246 = this.$hitObject$33245.collider.ClosestPointOnBounds(this.$self_$33250.transform.position + 1.5f * Vector3.up);
									if (47532 - 390786 != -343254)
									{
										goto IL_30D;
									}
									UnityRuntimeServices.Update(this.$$iterator$10817$33247, this.$hitObject$33245);
									if (152860 - 505618 == -352757)
									{
										goto IL_30D;
									}
									this.$self_$33250.RPC_nAttack2_hit(this.$hitPos$33246, this.$self_$33250.transform.forward, 0);
									if (252004 - 495206 != -243202)
									{
										goto IL_30D;
									}
									this.$self_$33250.ActionEvent("RPC_nAttack2_hit", this.$hitPos$33246, this.$self_$33250.transform.forward, 0);
									if (122475 - 539321 != -416846)
									{
										goto IL_30D;
									}
								}
							}
							if (297611 - 328792 != -31180)
							{
								goto Block_19;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$33250.LwNccFyly3V.actionState == "attack")
						{
							if (161216 - 459641 != -298425)
							{
								continue;
							}
							if (this.$self_$33250.LwNccFyly3V.myCommand == "nAttack2")
							{
								if (198819 - 420479 == -221659)
								{
									continue;
								}
								this.$self_$33250.LwNccFyly3V.moveSpeed = (float)0;
								if (154334 - 255224 != -100890)
								{
									continue;
								}
								this.$self_$33250.LwNccFyly3V.actionState = "standby";
								if (282624 - 536166 != -253542)
								{
									continue;
								}
								this.$self_$33250.LwNccFyly3V.actionTime = Time.time;
								if (290853 - 252492 != 38361)
								{
									continue;
								}
								this.$self_$33250.LwNccFyly3V.myCommand = "none";
								if (277190 - 364422 != -87232)
								{
									continue;
								}
								if (!this.$self_$33250.LwNccFyly3V.isMine)
								{
									if (98570 - 565590 == -467019)
									{
										continue;
									}
									this.$self_$33250.LwNccFyly3V.nPosition = this.$self_$33250.transform.position;
									if (167670 - 140911 != 26759)
									{
										continue;
									}
									this.$self_$33250.LwNccFyly3V.oPosition = this.$self_$33250.transform.position;
									if (46736 - 19106 == 27631)
									{
										continue;
									}
									this.$self_$33250.LwNccFyly3V.nDirection = this.$self_$33250.transform.forward;
									if (219314 - 340725 != -121411)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (25518 - 372505 != -346987)
						{
							continue;
						}
						goto IL_8E6;
					default:
						if (167443 - 596446 == -429002)
						{
							continue;
						}
						break;
					}
					this.$self_$33250.LwNccFyly3V.actionState = "attack";
					if (193958 - 148682 != 45277)
					{
						this.$self_$33250.LwNccFyly3V.actionTime = Time.time;
						if (164447 - 147374 != 17074)
						{
							this.$self_$33250.LwNccFyly3V.myCommand = "nAttack2";
							if (287897 - 508171 == -220274)
							{
								this.$self_$33250.LwNccFyly3V.addTimeOut("nAttack", (float)3);
								if (46156 - 419452 == -373296)
								{
									this.$self_$33250.transform.position = this.$mPos$33248;
									if (184462 - 382849 == -198387)
									{
										this.$self_$33250.transform.LookAt(this.$mPos$33248 + global::Math.vFlat(this.$tDir$33249));
										if (1208 - 510613 == -509405)
										{
											this.$self_$33250.LwNccFyly3V.vMovement = this.$self_$33250.transform.forward;
											if (76505 - 298507 == -222002)
											{
												this.$self_$33250.LwNccFyly3V.moveSpeed = (float)0;
												if (281969 - 576808 != -294838)
												{
													this.$self_$33250.animation.Play("nAttack2");
													if (122827 - 270576 != -147748)
													{
														this.$self_$33250.animation.wrapMode = WrapMode.Once;
														if (124936 - 309207 != -184270)
														{
															goto Block_9;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_6B:
				Block_4:
				goto IL_735;
				Block_7:
				goto IL_3E9;
				Block_9:
				return this.Yield(2, new WaitForSeconds(0.2f));
				Block_19:
				goto IL_85D;
				IL_3E9:
				IL_44C:
				goto IL_8E6;
				IL_735:
				return this.Yield(3, new WaitForSeconds(0.2f));
				IL_85D:
				return this.Yield(4, new WaitForSeconds(0.2f));
				IL_8E6:
				return false;
			}

			// Token: 0x06004D55 RID: 19797 RVA: 0x00986C34 File Offset: 0x00984E34
			internal static bool sLk6ba50PgZ8VhkJFrQl()
			{
				return true;
			}

			// Token: 0x06004D56 RID: 19798 RVA: 0x00986C38 File Offset: 0x00984E38
			internal static bool TJ6DbY500r39a7KNDv6K()
			{
				return false;
			}

			// Token: 0x04005784 RID: 22404
			internal int $hitLayer$33243;

			// Token: 0x04005785 RID: 22405
			internal UnityScript.Lang.Array $hitList$33244;

			// Token: 0x04005786 RID: 22406
			internal GameObject $hitObject$33245;

			// Token: 0x04005787 RID: 22407
			internal Vector3 $hitPos$33246;

			// Token: 0x04005788 RID: 22408
			internal IEnumerator $$iterator$10817$33247;

			// Token: 0x04005789 RID: 22409
			internal Vector3 $mPos$33248;

			// Token: 0x0400578A RID: 22410
			internal Vector3 $tDir$33249;

			// Token: 0x0400578B RID: 22411
			internal PirateCrawfish $self_$33250;
		}
	}

	// Token: 0x02000D6B RID: 3435
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_drunkenFlame$33254 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004D57 RID: 19799 RVA: 0x00986C3C File Offset: 0x00984E3C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_drunkenFlame$33254(Vector3 mPos, Vector3 tDir, PirateCrawfish self_)
		{
			if (57543 - 516372 != -458829)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (295994 - 59207 != 236788)
				{
					base..ctor();
					if (202626 - 577329 != -374702)
					{
						this.$mPos$33264 = mPos;
						if (144228 - 347361 == -203133)
						{
							this.$tDir$33265 = tDir;
							if (139504 - 353602 == -214098)
							{
								this.$self_$33266 = self_;
								if (282736 - 519106 == -236370)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06004D58 RID: 19800 RVA: 0x00986D18 File Offset: 0x00984F18
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PirateCrawfish.$RPC_drunkenFlame$33254.$(this.$mPos$33264, this.$tDir$33265, this.$self_$33266);
		}

		// Token: 0x06004D59 RID: 19801 RVA: 0x00986D34 File Offset: 0x00984F34
		internal static bool JbV0ON50bZTTUJIda2ph()
		{
			return true;
		}

		// Token: 0x06004D5A RID: 19802 RVA: 0x00986D38 File Offset: 0x00984F38
		internal static bool wGZMC550un1HIiAb2auk()
		{
			return false;
		}

		// Token: 0x0400578C RID: 22412
		internal Vector3 $mPos$33264;

		// Token: 0x0400578D RID: 22413
		internal Vector3 $tDir$33265;

		// Token: 0x0400578E RID: 22414
		internal PirateCrawfish $self_$33266;

		// Token: 0x02000D6C RID: 3436
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004D5B RID: 19803 RVA: 0x00986D3C File Offset: 0x00984F3C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, PirateCrawfish self_)
			{
				if (42793 - 382214 != -339421)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (105371 - 224639 == -119268)
					{
						base..ctor();
						if (145032 - 278123 != -133090)
						{
							this.$mPos$33261 = mPos;
							if (38060 - 181322 == -143262)
							{
								this.$tDir$33262 = tDir;
								if (222831 - 180681 != 42151)
								{
									this.$self_$33263 = self_;
									if (233090 - 170928 == 62162)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06004D5C RID: 19804 RVA: 0x00986E18 File Offset: 0x00985018
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (49441 - 475187 != -425746)
				{
				}
				for (;;)
				{
					IL_570:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_9EA;
					case 2:
						if (this.$self_$33263.LwNccFyly3V.actionState != "attack")
						{
							goto IL_32C;
						}
						if (134075 - 151097 != -17022)
						{
							continue;
						}
						if (!(this.$self_$33263.LwNccFyly3V.myCommand != "drunkenFlame"))
						{
							goto IL_331;
						}
						if (282348 - 477720 != -195372)
						{
							continue;
						}
						goto IL_32C;
					case 3:
						if (this.$self_$33263.LwNccFyly3V.actionState != "attack")
						{
							goto IL_1A;
						}
						if (24797 - 235873 == -211075)
						{
							continue;
						}
						if (this.$self_$33263.LwNccFyly3V.myCommand != "drunkenFlame")
						{
							if (140526 - 100592 != 39935)
							{
								goto Block_5;
							}
							continue;
						}
						else
						{
							this.$i$33255 = 0;
							if (43876 - 16712 != 27165)
							{
								goto IL_2AC;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$33263.LwNccFyly3V.actionState != "attack")
						{
							goto IL_5D8;
						}
						if (66599 - 91510 == -24910)
						{
							continue;
						}
						if (this.$self_$33263.LwNccFyly3V.myCommand != "drunkenFlame")
						{
							if (127250 - 568862 != -441611)
							{
								goto Block_62;
							}
							continue;
						}
						else
						{
							this.$i$33255++;
							if (268710 - 139230 != 129480)
							{
								continue;
							}
							goto IL_2AC;
						}
						break;
					case 5:
						if (this.$self_$33263.LwNccFyly3V.actionState == "attack")
						{
							if (192255 - 192340 != -85)
							{
								continue;
							}
							if (this.$self_$33263.LwNccFyly3V.myCommand == "drunkenFlame")
							{
								if (52526 - 598716 == -546189)
								{
									continue;
								}
								this.$self_$33263.LwNccFyly3V.moveSpeed = (float)0;
								if (243609 - 280947 == -37337)
								{
									continue;
								}
								this.$self_$33263.LwNccFyly3V.actionState = "standby";
								if (254352 - 68141 == 186212)
								{
									continue;
								}
								this.$self_$33263.LwNccFyly3V.actionTime = Time.time;
								if (14193 - 424350 != -410157)
								{
									continue;
								}
								this.$self_$33263.LwNccFyly3V.myCommand = "none";
								if (15470 - 538393 == -522922)
								{
									continue;
								}
								if (!this.$self_$33263.LwNccFyly3V.isMine)
								{
									if (15532 - 369221 == -353688)
									{
										continue;
									}
									this.$self_$33263.LwNccFyly3V.nPosition = this.$self_$33263.transform.position;
									if (36724 - 62753 != -26029)
									{
										continue;
									}
									this.$self_$33263.LwNccFyly3V.oPosition = this.$self_$33263.transform.position;
									if (185698 - 120288 != 65410)
									{
										continue;
									}
									this.$self_$33263.LwNccFyly3V.nDirection = this.$self_$33263.transform.forward;
									if (156568 - 409320 == -252751)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (132509 - 83702 != 48808)
						{
							goto Block_15;
						}
						continue;
					default:
						if (136423 - 511281 != -374858)
						{
							continue;
						}
						break;
					}
					this.$self_$33263.LwNccFyly3V.actionState = "attack";
					if (275292 - 485560 != -210268)
					{
						continue;
					}
					this.$self_$33263.LwNccFyly3V.actionTime = Time.time;
					if (132842 - 471035 == -338192)
					{
						continue;
					}
					this.$self_$33263.LwNccFyly3V.myCommand = "drunkenFlame";
					if (184140 - 120694 == 63447)
					{
						continue;
					}
					this.$self_$33263.LwNccFyly3V.addTimeOut("drunkenFlame", (float)12);
					if (299338 - 270990 == 28349)
					{
						continue;
					}
					this.$self_$33263.transform.position = this.$mPos$33261;
					if (18131 - 330171 != -312040)
					{
						continue;
					}
					this.$self_$33263.transform.LookAt(this.$mPos$33261 + global::Math.vFlat(this.$tDir$33262));
					if (3568 - 475146 == -471577)
					{
						continue;
					}
					this.$self_$33263.LwNccFyly3V.vMovement = this.$self_$33263.transform.forward;
					if (243081 - 340135 != -97054)
					{
						continue;
					}
					this.$self_$33263.LwNccFyly3V.moveSpeed = (float)0;
					if (191082 - 7131 != 183951)
					{
						continue;
					}
					this.$self_$33263.animation.Play("drunkenFlame");
					if (78306 - 348386 == -270079)
					{
						continue;
					}
					this.$self_$33263.animation.wrapMode = WrapMode.Once;
					if (141556 - 398144 != -256588)
					{
						continue;
					}
					if (this.$self_$33263.drunkenFlame_ring)
					{
						if (19807 - 119549 == -99741)
						{
							continue;
						}
						this.$self_$33263.LwNccFyly3V.createEffect(this.$self_$33263.drunkenFlame_ring, this.$self_$33263.transform.position, this.$self_$33263.transform.rotation);
						if (193268 - 329089 != -135820)
						{
							goto Block_52;
						}
						continue;
					}
					else
					{
						Debug.LogError("Cannot find drunkenFlame_ring Effect");
						if (180711 - 221455 != -40744)
						{
							continue;
						}
						goto IL_81E;
					}
					IL_2AC:
					if (this.$i$33255 >= 2)
					{
						if (25179 - 347670 != -322490)
						{
							goto Block_20;
						}
					}
					else
					{
						if (!this.$self_$33263.LwNccFyly3V.isMine)
						{
							goto IL_6E7;
						}
						if (117652 - 464780 != -347127)
						{
							this.$hitLayer$33256 = 130816 - (1 << this.$self_$33263.gameObject.layer);
							if (180628 - 494149 == -313521)
							{
								this.$hitList$33257 = Damage.FindRecTarget(this.$self_$33263.transform.position, this.$self_$33263.transform.forward, (float)2, (float)5, (float)6, (float)2, this.$hitLayer$33256);
								if (49613 - 390547 != -340933)
								{
									this.$$iterator$10818$33260 = UnityRuntimeServices.GetEnumerator(this.$hitList$33257);
									if (290133 - 256310 == 33823)
									{
										while (this.$$iterator$10818$33260.MoveNext())
										{
											object obj2;
											object obj = obj2 = this.$$iterator$10818$33260.Current;
											if (!(obj is GameObject))
											{
												obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
											}
											this.$hitObject$33258 = (GameObject)obj2;
											if (141423 - 101041 != 40382)
											{
												goto IL_570;
											}
											if (this.$self_$33263.LwNccFyly3V.hit(1, this.$hitObject$33258, this.$self_$33263.LwNccFyly3V.talAdjust(60), 1, 0, Vector3.zero) != 0)
											{
												if (292300 - 574086 != -281786)
												{
													goto IL_570;
												}
												this.$hitChar$33259 = (CharacterControl)this.$hitObject$33258.GetComponent(typeof(CharacterControl));
												if (11824 - 309311 == -297486)
												{
													goto IL_570;
												}
												UnityRuntimeServices.Update(this.$$iterator$10818$33260, this.$hitObject$33258);
												if (120492 - 501542 != -381050)
												{
													goto IL_570;
												}
												if (this.$hitChar$33259)
												{
													if (76516 - 396051 != -319535)
													{
														goto IL_570;
													}
													this.$hitChar$33259.RPC_AddStatus("burn", 3, Damage.getDebuff((float)4, this.$self_$33263.LwNccFyly3V.cha, this.$hitChar$33259.cha), 0, this.$self_$33263.LwNccFyly3V.ActorNr);
													if (299452 - 538873 != -239421)
													{
														goto IL_570;
													}
												}
											}
										}
										if (58474 - 331252 == -272778)
										{
											goto IL_6E7;
										}
									}
								}
							}
						}
					}
				}
				IL_1A:
				Block_5:
				Block_15:
				goto IL_9EA;
				Block_20:
				return this.Yield(5, new WaitForSeconds(0.2f));
				IL_32C:
				goto IL_9EA;
				IL_331:
				return this.Yield(3, new WaitForSeconds(0.1f));
				IL_5D8:
				goto IL_9EA;
				IL_6E7:
				return this.Yield(4, new WaitForSeconds(0.1f));
				Block_52:
				IL_81E:
				return this.Yield(2, new WaitForSeconds(0.6f));
				Block_62:
				IL_9EA:
				return false;
			}

			// Token: 0x06004D5D RID: 19805 RVA: 0x00987824 File Offset: 0x00985A24
			internal static bool pKKr6750IVEQYAB9IwCt()
			{
				return true;
			}

			// Token: 0x06004D5E RID: 19806 RVA: 0x00987828 File Offset: 0x00985A28
			internal static bool WkyJsE50B3bVBPKElV9w()
			{
				return false;
			}

			// Token: 0x0400578F RID: 22415
			internal int $i$33255;

			// Token: 0x04005790 RID: 22416
			internal int $hitLayer$33256;

			// Token: 0x04005791 RID: 22417
			internal UnityScript.Lang.Array $hitList$33257;

			// Token: 0x04005792 RID: 22418
			internal GameObject $hitObject$33258;

			// Token: 0x04005793 RID: 22419
			internal CharacterControl $hitChar$33259;

			// Token: 0x04005794 RID: 22420
			internal IEnumerator $$iterator$10818$33260;

			// Token: 0x04005795 RID: 22421
			internal Vector3 $mPos$33261;

			// Token: 0x04005796 RID: 22422
			internal Vector3 $tDir$33262;

			// Token: 0x04005797 RID: 22423
			internal PirateCrawfish $self_$33263;
		}
	}

	// Token: 0x02000D6D RID: 3437
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$33267 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004D5F RID: 19807 RVA: 0x0098782C File Offset: 0x00985A2C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$33267(UnityScript.Lang.Array nArray, PirateCrawfish self_)
		{
			if (77147 - 281311 != -204164)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (81340 - 403637 == -322297)
				{
					base..ctor();
					if (250287 - 508086 == -257799)
					{
						this.$nArray$33272 = nArray;
						if (257885 - 397168 == -139283)
						{
							this.$self_$33273 = self_;
							if (220339 - 74624 != 145716)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004D60 RID: 19808 RVA: 0x009878E8 File Offset: 0x00985AE8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PirateCrawfish.$RPC_ko$33267.$(this.$nArray$33272, this.$self_$33273);
		}

		// Token: 0x06004D61 RID: 19809 RVA: 0x009878FC File Offset: 0x00985AFC
		internal static bool o8lA7a50esdQjtvlkMPY()
		{
			return true;
		}

		// Token: 0x06004D62 RID: 19810 RVA: 0x00987900 File Offset: 0x00985B00
		internal static bool sTROHg50ryqQ2n8buDF0()
		{
			return false;
		}

		// Token: 0x04005798 RID: 22424
		internal UnityScript.Lang.Array $nArray$33272;

		// Token: 0x04005799 RID: 22425
		internal PirateCrawfish $self_$33273;

		// Token: 0x02000D6E RID: 3438
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004D63 RID: 19811 RVA: 0x00987904 File Offset: 0x00985B04
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, PirateCrawfish self_)
			{
				if (240779 - 527172 != -286392)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (7907 - 271570 != -263662)
					{
						base..ctor();
						if (112560 - 368835 == -256275)
						{
							this.$nArray$33270 = nArray;
							if (225683 - 477147 != -251463)
							{
								this.$self_$33271 = self_;
								if (106034 - 114138 == -8104)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06004D64 RID: 19812 RVA: 0x009879C0 File Offset: 0x00985BC0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (224589 - 425912 != -201322)
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
						if (this.$self_$33271.LwNccFyly3V.actionState != "ko")
						{
							if (48311 - 77289 != -28978)
							{
								continue;
							}
							goto IL_12D;
						}
						else
						{
							this.$self_$33271.animation.Play("getUp");
							if (227831 - 87556 == 140276)
							{
								continue;
							}
							this.$self_$33271.animation.wrapMode = WrapMode.Once;
							if (296077 - 257338 != 38739)
							{
								continue;
							}
							goto IL_224;
						}
						break;
					case 3:
						if (this.$self_$33271.LwNccFyly3V.actionState != "ko")
						{
							if (168247 - 176941 != -8694)
							{
								continue;
							}
							goto IL_99;
						}
						else
						{
							this.$self_$33271.LwNccFyly3V.actionState = "standby";
							if (236730 - 498790 == -262059)
							{
								continue;
							}
							this.$self_$33271.LwNccFyly3V.actionTime = Time.time;
							if (145554 - 383814 == -238259)
							{
								continue;
							}
							this.$self_$33271.LwNccFyly3V.myCommand = "none";
							if (241418 - 51133 != 190285)
							{
								continue;
							}
							this.$self_$33271.LwNccFyly3V.ko = this.$self_$33271.LwNccFyly3V.mko;
							if (164992 - 206221 != -41229)
							{
								continue;
							}
							this.YieldDefault(1);
							if (80293 - 340365 != -260072)
							{
								continue;
							}
							goto IL_48C;
						}
						break;
					default:
						if (259050 - 194314 == 64737)
						{
							continue;
						}
						break;
					}
					if (this.$self_$33271.LwNccFyly3V.actionState == "ko")
					{
						goto IL_3CB;
					}
					if (258356 - 273512 != -15155)
					{
						if (this.$self_$33271.LwNccFyly3V.actionState == "dead")
						{
							if (76998 - 100148 != -23149)
							{
								goto Block_11;
							}
						}
						else
						{
							this.$mPos$33268 = (Vector3)this.$nArray$33270[0];
							if (107399 - 447389 == -339990)
							{
								this.$mDir$33269 = (Vector3)this.$nArray$33270[1];
								if (264133 - 354804 != -90670)
								{
									this.$self_$33271.LwNccFyly3V.ko = 0;
									if (58638 - 573854 != -515215)
									{
										this.$self_$33271.LwNccFyly3V.actionState = "ko";
										if (73695 - 159169 != -85473)
										{
											this.$self_$33271.LwNccFyly3V.actionTime = Time.time;
											if (297964 - 502096 != -204131)
											{
												this.$self_$33271.LwNccFyly3V.myCommand = "none";
												if (158896 - 226863 == -67967)
												{
													this.$self_$33271.LwNccFyly3V.vMovement = Vector3.zero;
													if (12360 - 129891 != -117530)
													{
														this.$self_$33271.LwNccFyly3V.moveSpeed = (float)0;
														if (127222 - 17570 != 109653)
														{
															this.$self_$33271.animation.Play("ko");
															if (225998 - 103442 != 122557)
															{
																this.$self_$33271.animation.wrapMode = WrapMode.Once;
																if (279623 - 597939 == -318316)
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
				IL_99:
				IL_12D:
				Block_11:
				goto IL_3CB;
				IL_224:
				return this.Yield(3, new WaitForSeconds(1f));
				IL_3CB:
				IL_48C:
				return false;
			}

			// Token: 0x06004D65 RID: 19813 RVA: 0x00987E6C File Offset: 0x0098606C
			internal static bool IvCijG50j99ffJTN9ZIX()
			{
				return true;
			}

			// Token: 0x06004D66 RID: 19814 RVA: 0x00987E70 File Offset: 0x00986070
			internal static bool LJc7Bf50hKNxy4K6jsrZ()
			{
				return false;
			}

			// Token: 0x0400579A RID: 22426
			internal Vector3 $mPos$33268;

			// Token: 0x0400579B RID: 22427
			internal Vector3 $mDir$33269;

			// Token: 0x0400579C RID: 22428
			internal UnityScript.Lang.Array $nArray$33270;

			// Token: 0x0400579D RID: 22429
			internal PirateCrawfish $self_$33271;
		}
	}

	// Token: 0x02000D6F RID: 3439
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$33274 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004D67 RID: 19815 RVA: 0x00987E74 File Offset: 0x00986074
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$33274(UnityScript.Lang.Array nArray, PirateCrawfish self_)
		{
			if (129887 - 574668 != -444780)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (241740 - 45556 != 196185)
				{
					base..ctor();
					if (7568 - 304267 != -296698)
					{
						this.$nArray$33279 = nArray;
						if (201056 - 16484 == 184572)
						{
							this.$self_$33280 = self_;
							if (269543 - 452858 != -183314)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004D68 RID: 19816 RVA: 0x00987F30 File Offset: 0x00986130
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PirateCrawfish.$RPC_dead$33274.$(this.$nArray$33279, this.$self_$33280);
		}

		// Token: 0x06004D69 RID: 19817 RVA: 0x00987F44 File Offset: 0x00986144
		internal static bool CJAjNv50sY447WCBddbY()
		{
			return true;
		}

		// Token: 0x06004D6A RID: 19818 RVA: 0x00987F48 File Offset: 0x00986148
		internal static bool GmKHhE509OCpPsD8hg2d()
		{
			return false;
		}

		// Token: 0x0400579E RID: 22430
		internal UnityScript.Lang.Array $nArray$33279;

		// Token: 0x0400579F RID: 22431
		internal PirateCrawfish $self_$33280;

		// Token: 0x02000D70 RID: 3440
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004D6B RID: 19819 RVA: 0x00987F4C File Offset: 0x0098614C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, PirateCrawfish self_)
			{
				if (199374 - 200794 != -1419)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (264224 - 214363 != 49862)
					{
						base..ctor();
						if (250141 - 563733 != -313591)
						{
							this.$nArray$33277 = nArray;
							if (257044 - 411132 != -154087)
							{
								this.$self_$33278 = self_;
								if (119207 - 299035 != -179827)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06004D6C RID: 19820 RVA: 0x00988008 File Offset: 0x00986208
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (179742 - 300260 != -120518)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_4D2;
					case 2:
						if (this.$self_$33278.LwNccFyly3V.actionState != "dead")
						{
							if (6421 - 429168 != -422747)
							{
								continue;
							}
							goto IL_132;
						}
						else
						{
							if (!this.$self_$33278.LwNccFyly3V.isPlayer)
							{
								if (24928 - 466645 == -441716)
								{
									continue;
								}
								if (this.$self_$33278.deadEffect)
								{
									if (269880 - 516006 != -246126)
									{
										continue;
									}
									UnityEngine.Object.Instantiate(this.$self_$33278.deadEffect, this.$self_$33278.transform.position, this.$self_$33278.transform.rotation);
									if (274664 - 260417 != 14247)
									{
										continue;
									}
								}
								else
								{
									Debug.LogError("Missing deadEffect Effect");
									if (243065 - 108530 != 134535)
									{
										continue;
									}
								}
								UnityEngine.Object.Destroy(this.$self_$33278.gameObject);
								if (184009 - 1477 != 182532)
								{
									continue;
								}
							}
							else if (this.$self_$33278.LwNccFyly3V.isMine)
							{
								if (196044 - 55879 == 140166)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$33278.gameObject);
								if (127093 - 359065 == -231971)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (234778 - 136836 != 97943)
							{
								goto Block_28;
							}
							continue;
						}
						break;
					default:
						if (44256 - 430748 != -386492)
						{
							continue;
						}
						break;
					}
					if (this.$self_$33278.LwNccFyly3V.actionState == "dead")
					{
						if (110082 - 207478 == -97396)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$33275 = (Vector3)this.$nArray$33277[0];
						if (16069 - 112035 == -95966)
						{
							this.$myDirection$33276 = (Vector3)this.$nArray$33277[1];
							if (97495 - 553160 != -455664)
							{
								this.$self_$33278.transform.position = this.$myPosition$33275;
								if (226036 - 8480 == 217556)
								{
									this.$self_$33278.transform.LookAt(this.$myPosition$33275 + this.$myDirection$33276);
									if (93232 - 365661 == -272429)
									{
										this.$self_$33278.LwNccFyly3V.hp = 0;
										if (10673 - 113968 != -103294)
										{
											this.$self_$33278.LwNccFyly3V.actionState = "dead";
											if (178928 - 181883 == -2955)
											{
												this.$self_$33278.LwNccFyly3V.actionTime = Time.time;
												if (278560 - 20934 != 257627)
												{
													this.$self_$33278.LwNccFyly3V.myCommand = "none";
													if (154175 - 474220 == -320045)
													{
														this.$self_$33278.LwNccFyly3V.vMovement = Vector3.zero;
														if (280906 - 554597 == -273691)
														{
															this.$self_$33278.LwNccFyly3V.moveSpeed = (float)0;
															if (238943 - 305096 == -66153)
															{
																this.$self_$33278.animation.Rewind();
																if (179468 - 231951 != -52482)
																{
																	this.$self_$33278.animation.Play("ko");
																	if (265442 - 188082 == 77360)
																	{
																		this.$self_$33278.animation.wrapMode = WrapMode.Once;
																		if (293303 - 35431 == 257872)
																		{
																			goto IL_20D;
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_132:
				goto IL_4D2;
				IL_20D:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_28:
				IL_4D2:
				return false;
			}

			// Token: 0x06004D6D RID: 19821 RVA: 0x009884FC File Offset: 0x009866FC
			internal static bool mQAbHe501d0YncHTVdiU()
			{
				return true;
			}

			// Token: 0x06004D6E RID: 19822 RVA: 0x00988500 File Offset: 0x00986700
			internal static bool o9hOCN504fnnCbfoXXv3()
			{
				return false;
			}

			// Token: 0x040057A0 RID: 22432
			internal Vector3 $myPosition$33275;

			// Token: 0x040057A1 RID: 22433
			internal Vector3 $myDirection$33276;

			// Token: 0x040057A2 RID: 22434
			internal UnityScript.Lang.Array $nArray$33277;

			// Token: 0x040057A3 RID: 22435
			internal PirateCrawfish $self_$33278;
		}
	}
}
