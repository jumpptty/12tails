using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000D58 RID: 3416
[Serializable]
public class PilotMole : MonoBehaviour
{
	// Token: 0x06004CE3 RID: 19683 RVA: 0x0097BEB8 File Offset: 0x0097A0B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public PilotMole()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x06004CE4 RID: 19684 RVA: 0x0097BEC8 File Offset: 0x0097A0C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (275098 - 231030 != 44068)
		{
		}
		for (;;)
		{
			this.crNcc0yOVg4 = this.transform;
			if (79774 - 411265 != -331490)
			{
				this.LIYcc8hpHfu = (CharacterControl)this.GetComponent(typeof(CharacterControl));
				if (288569 - 85870 != 202700)
				{
					this.LIYcc8hpHfu.actionState = "standby";
					if (298417 - 597255 != -298837)
					{
						this.LIYcc8hpHfu.actionTime = Time.time;
						if (216456 - 276380 == -59924)
						{
							this.LIYcc8hpHfu.myCommand = "none";
							if (45999 - 118590 != -72590)
							{
								if (Game.mGameType == 99)
								{
									if (293403 - 514927 == -221523)
									{
										continue;
									}
									this.LIYcc8hpHfu.isMine = true;
									if (170235 - 368801 == -198565)
									{
										continue;
									}
								}
								if (PlayerPrefs.GetInt("pvoice", 1) == 0)
								{
									break;
								}
								if (191896 - 56098 == 135798)
								{
									if (!this.LIYcc8hpHfu.isSummon)
									{
										break;
									}
									if (7517 - 375035 != -367517)
									{
										if (this.awake_vc)
										{
											if (196751 - 571118 == -374367)
											{
												this.audio.PlayOneShot(this.awake_vc);
												if (167585 - 4495 != 163091)
												{
													break;
												}
											}
										}
										else
										{
											Debug.LogError("Missing awake_vc audio");
											if (70764 - 446773 == -376009)
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

	// Token: 0x06004CE5 RID: 19685 RVA: 0x0097C0F8 File Offset: 0x0097A2F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (99124 - 151305 != -52180)
		{
		}
		for (;;)
		{
			if (this.LIYcc8hpHfu.isControlled)
			{
				if (38054 - 460197 != -422143)
				{
					continue;
				}
				if (!(this.LIYcc8hpHfu.actionState == "standby"))
				{
					if (196973 - 154140 != 42833)
					{
						continue;
					}
					if (!(this.LIYcc8hpHfu.actionState == "run"))
					{
						goto IL_271;
					}
					if (247471 - 504557 == -257085)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (249042 - 261798 != -12756)
				{
					continue;
				}
			}
			IL_271:
			if (this.LIYcc8hpHfu.hp <= 0)
			{
				if (246242 - 89759 != 156483)
				{
					continue;
				}
				if (this.LIYcc8hpHfu.actionState != "dead")
				{
					if (96212 - 307443 != -211231)
					{
						continue;
					}
					if (this.LIYcc8hpHfu.isMine)
					{
						if (58140 - 405145 != -347005)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (174215 - 158294 == 15922)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (77560 - 316808 == -239247)
						{
							continue;
						}
						this.LIYcc8hpHfu.DeadEvent();
						if (188639 - 360240 != -171601)
						{
							continue;
						}
						break;
					}
					else
					{
						this.LIYcc8hpHfu.hp = 1;
						if (81281 - 83347 != -2065)
						{
							break;
						}
						continue;
					}
				}
			}
			if (this.LIYcc8hpHfu.hp <= 0)
			{
				break;
			}
			if (262490 - 286847 != -24356)
			{
				if (this.LIYcc8hpHfu.ko > 0)
				{
					break;
				}
				if (167907 - 379066 != -211158)
				{
					if (!(this.LIYcc8hpHfu.actionState != "ko"))
					{
						break;
					}
					if (27129 - 391588 == -364459)
					{
						if (!(this.LIYcc8hpHfu.actionState != "dead"))
						{
							break;
						}
						if (3315 - 75311 == -71996)
						{
							if (this.LIYcc8hpHfu.isMine)
							{
								if (206515 - 43672 != 162844)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (132203 - 42081 != 90123)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (64766 - 459587 != -394820)
										{
											this.LIYcc8hpHfu.KoEvent();
											if (2023 - 47352 != -45328)
											{
												break;
											}
										}
									}
								}
							}
							else
							{
								this.LIYcc8hpHfu.ko = 1;
								if (143634 - 401197 != -257562)
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

	// Token: 0x06004CE6 RID: 19686 RVA: 0x0097C4F0 File Offset: 0x0097A6F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (140662 - 278321 != -137659)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (167454 - 429363 != -261908)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (222674 - 58314 == 164360)
				{
					if (266786 - 155774 != 111013)
					{
						if (ActionName == "RPC_fireBarrage")
						{
							if (48757 - 322197 == -273439)
							{
								continue;
							}
							v = 11;
							if (40425 - 495967 == -455541)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_fireBarrage_fire")
						{
							if (121131 - 442170 != -321039)
							{
								continue;
							}
							v = 12;
							if (213182 - 147147 != 66035)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_bombardment")
						{
							if (114034 - 318052 != -204018)
							{
								continue;
							}
							v = 21;
							if (47976 - 121805 != -73829)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_bombardment_fire")
						{
							if (13897 - 391494 == -377596)
							{
								continue;
							}
							v = 22;
							if (41312 - 578218 == -536905)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (119453 - 152113 == -32659)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (238228 - 502741 != -264512)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (79635 - 466077 == -386442)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (170349 - 277073 != -106723)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (209716 - 471267 != -261550)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (167624 - 353555 != -185930)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (201442 - 273514 == -72072)
											{
												Hashtable hashtable = new Hashtable();
												if (128026 - 546919 != -418892)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (273265 - 290416 != -17150)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (101174 - 456311 != -355136)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (298054 - 15416 == 282638)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (132043 - 126633 != 5411)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (166405 - 354898 == -188493)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (9996 - 290192 == -280196)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (123637 - 224048 == -100411)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (285502 - 369604 == -84102)
																				{
																					PhotonClient.SendEvent(this.LIYcc8hpHfu.ActorNr, 74, hashtable, true, true);
																					if (249963 - 76624 != 173340)
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

	// Token: 0x06004CE7 RID: 19687 RVA: 0x0097CA08 File Offset: 0x0097AC08
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (278460 - 175573 != 102887)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (37275 - 14504 == 22771)
			{
				Vector3 mPos = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (177865 - 565287 != -387421)
				{
					Vector3 tDir = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (46714 - 327894 != -281179)
					{
						int tID = RuntimeServices.UnboxInt32(evData[129]);
						if (155892 - 160832 == -4940)
						{
							int num2 = num;
							if (228149 - 294291 == -66142)
							{
								if (num2 == 11)
								{
									if (119968 - 87839 == 32129)
									{
										if (this.LIYcc8hpHfu.isMine)
										{
											break;
										}
										if (86660 - 493520 == -406860)
										{
											this.StartCoroutine_Auto(this.RPC_fireBarrage(mPos, tDir, tID));
											if (236514 - 57634 != 178881)
											{
												break;
											}
										}
									}
								}
								else if (num2 == 12)
								{
									if (243811 - 307557 != -63745)
									{
										if (this.LIYcc8hpHfu.isMine)
										{
											break;
										}
										if (296795 - 165109 != 131687)
										{
											this.StartCoroutine_Auto(this.RPC_fireBarrage_fire(mPos, tDir, tID));
											if (213199 - 205243 != 7957)
											{
												break;
											}
										}
									}
								}
								else if (num2 == 21)
								{
									if (34178 - 510089 == -475911)
									{
										if (this.LIYcc8hpHfu.isMine)
										{
											break;
										}
										if (164223 - 456763 != -292539)
										{
											this.StartCoroutine_Auto(this.RPC_bombardment(mPos, tDir, tID));
											if (104975 - 478676 != -373700)
											{
												break;
											}
										}
									}
								}
								else if (num2 == 22)
								{
									if (241733 - 124830 != 116904)
									{
										if (this.LIYcc8hpHfu.isMine)
										{
											break;
										}
										if (73045 - 474232 != -401186)
										{
											this.StartCoroutine_Auto(this.RPC_bombardment_fire(mPos, tDir, tID));
											if (101588 - 450446 == -348858)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (257379 - 37291 == 220088)
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

	// Token: 0x06004CE8 RID: 19688 RVA: 0x0097CD9C File Offset: 0x0097AF9C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (196125 - 269701 != -73575)
		{
		}
		for (;;)
		{
			float num = this.LIYcc8hpHfu.moveSpeed;
			if (22718 - 203570 == -180852)
			{
				float runSpeed = this.LIYcc8hpHfu.runSpeed;
				if (237523 - 452338 == -214815)
				{
					Vector3 a = default(Vector3);
					if (198070 - 67348 != 130723)
					{
						Vector3 vector = Vector3.zero;
						if (20247 - 341790 != -321542)
						{
							float num2 = (float)0;
							if (289370 - 524306 != -234935)
							{
								if (this.LIYcc8hpHfu.isMine)
								{
									if (154046 - 64912 != 89134)
									{
										continue;
									}
									if ((this.LIYcc8hpHfu.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (77481 - 220971 == -143489)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (294236 - 170165 != 124071)
										{
											continue;
										}
										a.y = (float)0;
										if (95658 - 31380 == 64279)
										{
											continue;
										}
										a = a.normalized;
										if (299493 - 393857 != -94364)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (237295 - 447875 != -210580)
										{
											continue;
										}
										vector = vector.normalized;
										if (136311 - 188421 == -52109)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (207416 - 170313 == 37104)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (143474 - 143140 == 335)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (272582 - 525945 == -253362)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (65748 - 9605 == 56144)
														{
															continue;
														}
														this.LIYcc8hpHfu.actionState = "run";
														if (264461 - 34820 != 229641)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (168641 - 24428 != 144213)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (116683 - 409205 != -292522)
														{
															continue;
														}
														this.animation.Play("run");
														if (127639 - 303055 != -175416)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (290409 - 454452 != -164043)
														{
															continue;
														}
														goto IL_978;
													}
												}
											}
										}
										this.LIYcc8hpHfu.actionState = "standby";
										if (206852 - 454623 == -247770)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (51629 - 301142 == -249512)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (228837 - 361955 != -133118)
											{
												continue;
											}
											num = (float)0;
											if (10142 - 582473 != -572331)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (247057 - 540460 == -293402)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (49310 - 253854 == -204543)
										{
											continue;
										}
									}
									IL_978:;
								}
								else
								{
									vector = global::Math.vFlat(this.LIYcc8hpHfu.nPosition - this.transform.position);
									if (267253 - 261482 == 5772)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (125941 - 593637 == -467695)
									{
										continue;
									}
									if (this.LIYcc8hpHfu.nSpeed != (float)0)
									{
										if (104747 - 566611 == -461863)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (260042 - 353965 == -93922)
											{
												continue;
											}
											this.transform.position = this.LIYcc8hpHfu.nPosition;
											if (290118 - 43042 == 247077)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (200104 - 504810 != -304706)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (92498 - 546382 == -453883)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (240085 - 579832 == -339746)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.LIYcc8hpHfu.nSpeed, (float)10 * Time.deltaTime);
												if (98298 - 233452 != -135154)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (78936 - 68687 != 10249)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (198317 - 125316 != 73001)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (108679 - 104766 == 3914)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (194547 - 40265 != 154282)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (85731 - 572313 != -486582)
											{
												continue;
											}
										}
										else if (Time.time > this.LIYcc8hpHfu.nSpeed + 0.3f)
										{
											if (88163 - 153485 != -65322)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (38269 - 430346 != -392077)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (65223 - 204006 == -138782)
												{
													continue;
												}
												num = (float)0;
												if (247122 - 391740 == -144617)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.LIYcc8hpHfu.nDirection);
											if (171113 - 166803 != 4310)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (264846 - 193043 != 71803)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (109152 - 439152 == -329999)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (275129 - 343973 == -68843)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (296380 - 76703 != 219677)
											{
												continue;
											}
											this.transform.position = this.LIYcc8hpHfu.nPosition;
											if (12187 - 449009 != -436822)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (239810 - 574661 == -334850)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (31888 - 482382 != -450494)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (68816 - 339303 != -270487)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (201007 - 209497 != -8490)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (220252 - 89832 != 130420)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (39902 - 33899 == 6004)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (52483 - 245488 != -193005)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.LIYcc8hpHfu.nDirection);
											if (182607 - 593356 != -410749)
											{
												continue;
											}
											num = (float)0;
											if (67287 - 134944 == -67656)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (141068 - 56420 != 84648)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (93092 - 113058 != -19966)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (48185 - 537331 != -489146)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (171731 - 169592 == 2140)
										{
											continue;
										}
									}
								}
								this.LIYcc8hpHfu.vMovement = vector;
								if (154380 - 175601 == -21221)
								{
									this.LIYcc8hpHfu.moveSpeed = num;
									if (174571 - 566846 == -392275)
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

	// Token: 0x06004CE9 RID: 19689 RVA: 0x0097D900 File Offset: 0x0097BB00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (178590 - 499806 != -321215)
		{
		}
		for (;;)
		{
			if (!this.LIYcc8hpHfu.isMine)
			{
				if (8379 - 417203 != -408823)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (257848 - 548177 != -290328)
				{
					Vector3 vector = a - this.transform.position;
					if (74635 - 517699 != -443063)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (149314 - 458617 != -309302)
						{
							CharacterControl characterControl = null;
							if (85807 - 242769 != -156961)
							{
								if (211476 - 138015 == 73461)
								{
									if (gameObject)
									{
										if (180932 - 305850 != -124918)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (81833 - 572927 != -491094)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (271312 - 11332 != 259980)
										{
											continue;
										}
										int actorNr = characterControl.ActorNr;
										if (145353 - 421822 == -276468)
										{
											continue;
										}
									}
									if (!(this.LIYcc8hpHfu.actionState == "standby"))
									{
										if (103793 - 233005 == -129211)
										{
											continue;
										}
										if (!(this.LIYcc8hpHfu.actionState == "run"))
										{
											break;
										}
										if (37933 - 578059 == -540125)
										{
											continue;
										}
									}
									if (this.LIYcc8hpHfu.isTimeOut("nAttack") != (float)0)
									{
										if (11917 - 520293 == -508376)
										{
											Camera.main.SendMessage("newGameMessage", "Normal attack time out!");
											if (64922 - 242800 != -177877)
											{
												break;
											}
										}
									}
									else if (UnityEngine.Random.Range(0, 100) < 50)
									{
										if (142618 - 288088 != -145469)
										{
											Vector3 vector2 = global::Math.vFlat(vector);
											if (176246 - 271227 == -94981)
											{
												vector = vector2.normalized;
												if (173975 - 110017 != 63959)
												{
													this.StartCoroutine_Auto(this.RPC_fireBarrage(this.transform.position, vector, 0));
													if (225015 - 599624 == -374609)
													{
														if (!PhotonClient.IsInitialized())
														{
															break;
														}
														if (57 - 514233 != -514175)
														{
															this.ActionEvent("RPC_fireBarrage", this.transform.position, vector, 0);
															if (253878 - 443724 == -189846)
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
										Vector3 vector3 = global::Math.vFlat(vector);
										if (152197 - 292728 != -140530)
										{
											vector = vector3.normalized;
											if (268249 - 236257 != 31993)
											{
												this.StartCoroutine_Auto(this.RPC_bombardment(this.transform.position, vector, 0));
												if (263293 - 163033 != 100261)
												{
													if (!PhotonClient.IsInitialized())
													{
														break;
													}
													if (130696 - 537080 != -406383)
													{
														this.ActionEvent("RPC_bombardment", this.transform.position, vector, 0);
														if (223746 - 545708 == -321962)
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

	// Token: 0x06004CEA RID: 19690 RVA: 0x0097DD6C File Offset: 0x0097BF6C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (182417 - 105439 != 76979)
		{
		}
		for (;;)
		{
			if (!this.LIYcc8hpHfu.isMine)
			{
				if (112241 - 322236 == -209995)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (3349 - 226125 != -222775)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (36167 - 458903 != -422735)
					{
						Vector3 normalized = vector.normalized;
						if (160163 - 263165 != -103001)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (249954 - 147727 == 102227)
							{
								CharacterControl characterControl = null;
								if (199241 - 85745 != 113497 && 257581 - 205439 != 52143)
								{
									if (gameObject)
									{
										if (211583 - 10143 != 201440)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (36766 - 457198 == -420431)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (184481 - 292043 == -107561)
										{
											continue;
										}
										int actorNr = characterControl.ActorNr;
										if (110537 - 391108 == -280570)
										{
											continue;
										}
									}
									if (this.LIYcc8hpHfu.actionState == "standby")
									{
										break;
									}
									if (286797 - 118407 != 168391)
									{
										if (!(this.LIYcc8hpHfu.actionState == "run"))
										{
											break;
										}
										if (204961 - 309622 != -104660)
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

	// Token: 0x06004CEB RID: 19691 RVA: 0x0097DFD8 File Offset: 0x0097C1D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x06004CEC RID: 19692 RVA: 0x0097DFDC File Offset: 0x0097C1DC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_fireBarrage(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new PilotMole.$RPC_fireBarrage$33172(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06004CED RID: 19693 RVA: 0x0097DFEC File Offset: 0x0097C1EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_fireBarrage_fire(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new PilotMole.$RPC_fireBarrage_fire$33180(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06004CEE RID: 19694 RVA: 0x0097DFFC File Offset: 0x0097C1FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_bombardment(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new PilotMole.$RPC_bombardment$33192(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06004CEF RID: 19695 RVA: 0x0097E00C File Offset: 0x0097C20C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_bombardment_fire(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new PilotMole.$RPC_bombardment_fire$33200(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x06004CF0 RID: 19696 RVA: 0x0097E01C File Offset: 0x0097C21C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new PilotMole.$RPC_ko$33215(nArray, this).GetEnumerator();
	}

	// Token: 0x06004CF1 RID: 19697 RVA: 0x0097E02C File Offset: 0x0097C22C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new PilotMole.$RPC_dead$33222(nArray, this).GetEnumerator();
	}

	// Token: 0x06004CF2 RID: 19698 RVA: 0x0097E03C File Offset: 0x0097C23C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004CF3 RID: 19699 RVA: 0x0097E040 File Offset: 0x0097C240
	internal static bool w757fl50Xr9B7IQ5U1Qb()
	{
		return true;
	}

	// Token: 0x06004CF4 RID: 19700 RVA: 0x0097E044 File Offset: 0x0097C244
	internal static bool wI1ExU50QbIkgf3DY3hj()
	{
		return false;
	}

	// Token: 0x0400572A RID: 22314
	private Transform crNcc0yOVg4;

	// Token: 0x0400572B RID: 22315
	private CharacterControl LIYcc8hpHfu;

	// Token: 0x0400572C RID: 22316
	public AudioClip awake_vc;

	// Token: 0x0400572D RID: 22317
	public AudioClip cast_vc;

	// Token: 0x0400572E RID: 22318
	public GameObject fireBarrage_ring;

	// Token: 0x0400572F RID: 22319
	public GameObject fireBarrage_fire;

	// Token: 0x04005730 RID: 22320
	public GameObject fireBarrage_hit;

	// Token: 0x04005731 RID: 22321
	public GameObject bombardment_ring;

	// Token: 0x04005732 RID: 22322
	public GameObject bombardment_fire;

	// Token: 0x04005733 RID: 22323
	public GameObject bombardment_hit;

	// Token: 0x02000D59 RID: 3417
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_fireBarrage$33172 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004CF5 RID: 19701 RVA: 0x0097E048 File Offset: 0x0097C248
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_fireBarrage$33172(Vector3 mPos, Vector3 tDir, PilotMole self_)
		{
			if (20959 - 32367 != -11408)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (253719 - 517331 != -263611)
				{
					base..ctor();
					if (188645 - 280469 == -91824)
					{
						this.$mPos$33177 = mPos;
						if (168807 - 531428 != -362620)
						{
							this.$tDir$33178 = tDir;
							if (206258 - 161222 == 45036)
							{
								this.$self_$33179 = self_;
								if (22907 - 409697 != -386789)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06004CF6 RID: 19702 RVA: 0x0097E124 File Offset: 0x0097C324
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PilotMole.$RPC_fireBarrage$33172.$(this.$mPos$33177, this.$tDir$33178, this.$self_$33179);
		}

		// Token: 0x06004CF7 RID: 19703 RVA: 0x0097E140 File Offset: 0x0097C340
		internal static bool hSQtgy50kE0AUfxOddbK()
		{
			return true;
		}

		// Token: 0x06004CF8 RID: 19704 RVA: 0x0097E144 File Offset: 0x0097C344
		internal static bool eb6d4E50GcgqwC18ylj6()
		{
			return false;
		}

		// Token: 0x04005734 RID: 22324
		internal Vector3 $mPos$33177;

		// Token: 0x04005735 RID: 22325
		internal Vector3 $tDir$33178;

		// Token: 0x04005736 RID: 22326
		internal PilotMole $self_$33179;

		// Token: 0x02000D5A RID: 3418
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004CF9 RID: 19705 RVA: 0x0097E148 File Offset: 0x0097C348
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, PilotMole self_)
			{
				if (126180 - 567810 != -441629)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (181562 - 350726 != -169163)
					{
						base..ctor();
						if (193778 - 164295 != 29484)
						{
							this.$mPos$33174 = mPos;
							if (293968 - 309026 == -15058)
							{
								this.$tDir$33175 = tDir;
								if (78201 - 249841 != -171639)
								{
									this.$self_$33176 = self_;
									if (3407 - 363711 != -360303)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06004CFA RID: 19706 RVA: 0x0097E224 File Offset: 0x0097C424
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (115322 - 457801 != -342478)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_78B;
					case 2:
						if (this.$self_$33176.LIYcc8hpHfu.actionState != "attack")
						{
							goto IL_52A;
						}
						if (291700 - 505750 == -214049)
						{
							continue;
						}
						if (this.$self_$33176.LIYcc8hpHfu.myCommand != "fireBarrage")
						{
							if (23601 - 438742 != -415141)
							{
								continue;
							}
							goto IL_52A;
						}
						else
						{
							this.$firePos$33173 = global::Math.getSpawnPos(this.$mPos$33174 + this.$tDir$33175);
							if (130255 - 238944 == -108688)
							{
								continue;
							}
							if (!this.$self_$33176.LIYcc8hpHfu.isMine)
							{
								goto IL_A9;
							}
							if (157498 - 523808 == -366309)
							{
								continue;
							}
							if (!(this.$firePos$33173 != Vector3.zero))
							{
								goto IL_A9;
							}
							if (91300 - 539046 == -447745)
							{
								continue;
							}
							this.$self_$33176.StartCoroutine_Auto(this.$self_$33176.RPC_fireBarrage_fire(this.$firePos$33173, global::Math.vFlat(this.$tDir$33175).normalized, 0));
							if (4348 - 20966 != -16618)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								goto IL_A9;
							}
							if (260635 - 269072 == -8436)
							{
								continue;
							}
							this.$self_$33176.ActionEvent("RPC_fireBarrage_fire", this.$firePos$33173, global::Math.vFlat(this.$tDir$33175).normalized, 0);
							if (143586 - 529133 != -385547)
							{
								continue;
							}
							goto IL_A9;
						}
						break;
					case 3:
						if (this.$self_$33176.LIYcc8hpHfu.actionState == "attack")
						{
							if (181084 - 505591 != -324507)
							{
								continue;
							}
							if (this.$self_$33176.LIYcc8hpHfu.myCommand == "fireBarrage")
							{
								if (219700 - 46444 == 173257)
								{
									continue;
								}
								this.$self_$33176.LIYcc8hpHfu.actionState = "standby";
								if (69826 - 195854 == -126027)
								{
									continue;
								}
								this.$self_$33176.LIYcc8hpHfu.actionTime = Time.time;
								if (269555 - 271470 != -1915)
								{
									continue;
								}
								this.$self_$33176.LIYcc8hpHfu.myCommand = "none";
								if (115497 - 409538 != -294041)
								{
									continue;
								}
								if (!this.$self_$33176.LIYcc8hpHfu.isMine)
								{
									if (171543 - 315575 == -144031)
									{
										continue;
									}
									this.$self_$33176.LIYcc8hpHfu.nPosition = this.$self_$33176.transform.position;
									if (62330 - 426945 != -364615)
									{
										continue;
									}
									this.$self_$33176.LIYcc8hpHfu.oPosition = this.$self_$33176.transform.position;
									if (228841 - 273822 == -44980)
									{
										continue;
									}
									this.$self_$33176.LIYcc8hpHfu.nDirection = this.$self_$33176.transform.forward;
									if (236295 - 115299 != 120996)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (15401 - 506914 != -491513)
						{
							continue;
						}
						goto IL_78B;
					default:
						if (192190 - 306563 != -114373)
						{
							continue;
						}
						break;
					}
					this.$self_$33176.LIYcc8hpHfu.actionState = "attack";
					if (119146 - 462724 == -343578)
					{
						this.$self_$33176.LIYcc8hpHfu.actionTime = Time.time;
						if (34759 - 91698 != -56938)
						{
							this.$self_$33176.LIYcc8hpHfu.myCommand = "fireBarrage";
							if (113365 - 130074 == -16709)
							{
								this.$self_$33176.LIYcc8hpHfu.addTimeOut("nAttack", (float)13);
								if (27425 - 339605 == -312180)
								{
									this.$self_$33176.transform.position = this.$mPos$33174;
									if (88538 - 238916 != -150377)
									{
										this.$self_$33176.transform.LookAt(this.$mPos$33174 + global::Math.vFlat(this.$tDir$33175));
										if (4998 - 81106 == -76108)
										{
											this.$self_$33176.animation.CrossFade("cast");
											if (298967 - 535058 == -236091)
											{
												this.$self_$33176.animation.wrapMode = WrapMode.Once;
												if (59998 - 131763 != -71764)
												{
													this.$self_$33176.LIYcc8hpHfu.vMovement = this.$self_$33176.transform.forward;
													if (250704 - 263208 == -12504)
													{
														this.$self_$33176.LIYcc8hpHfu.moveSpeed = (float)0;
														if (194190 - 19566 == 174624)
														{
															if (this.$self_$33176.fireBarrage_ring)
															{
																if (92983 - 167059 == -74075)
																{
																	continue;
																}
																this.$self_$33176.LIYcc8hpHfu.createEffect(this.$self_$33176.fireBarrage_ring, this.$self_$33176.transform.position, this.$self_$33176.transform.rotation);
																if (12706 - 300289 != -287583)
																{
																	continue;
																}
															}
															else
															{
																Debug.LogError("Missing fireBarrage_ring gameObject");
																if (283661 - 168604 != 115057)
																{
																	continue;
																}
															}
															if (PlayerPrefs.GetInt("pvoice", 1) == 0)
															{
																goto IL_2F7;
															}
															if (264090 - 239026 != 25065)
															{
																if (this.$self_$33176.cast_vc)
																{
																	if (264025 - 516464 == -252439)
																	{
																		this.$self_$33176.audio.PlayOneShot(this.$self_$33176.cast_vc);
																		if (29250 - 343923 != -314672)
																		{
																			goto Block_16;
																		}
																	}
																}
																else
																{
																	Debug.LogError("Missing cast_vc audio");
																	if (185403 - 96483 == 88920)
																	{
																		goto IL_2F7;
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_A9:
				return this.Yield(3, new WaitForSeconds(0.7f));
				Block_16:
				IL_2F7:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_52A:
				IL_78B:
				return false;
			}

			// Token: 0x06004CFB RID: 19707 RVA: 0x0097E9D0 File Offset: 0x0097CBD0
			internal static bool AjWSbx50HNxUcd1eS0f2()
			{
				return true;
			}

			// Token: 0x06004CFC RID: 19708 RVA: 0x0097E9D4 File Offset: 0x0097CBD4
			internal static bool jAAFZS50WjeWpDd0dePu()
			{
				return false;
			}

			// Token: 0x04005737 RID: 22327
			internal Vector3 $firePos$33173;

			// Token: 0x04005738 RID: 22328
			internal Vector3 $mPos$33174;

			// Token: 0x04005739 RID: 22329
			internal Vector3 $tDir$33175;

			// Token: 0x0400573A RID: 22330
			internal PilotMole $self_$33176;
		}
	}

	// Token: 0x02000D5B RID: 3419
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_fireBarrage_fire$33180 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004CFD RID: 19709 RVA: 0x0097E9D8 File Offset: 0x0097CBD8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_fireBarrage_fire$33180(Vector3 mPos, Vector3 tDir, PilotMole self_)
		{
			if (13309 - 268338 != -255028)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (30929 - 476870 != -445940)
				{
					base..ctor();
					if (142333 - 165800 != -23466)
					{
						this.$mPos$33189 = mPos;
						if (291695 - 93954 != 197742)
						{
							this.$tDir$33190 = tDir;
							if (49493 - 370022 == -320529)
							{
								this.$self_$33191 = self_;
								if (178971 - 193066 != -14094)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06004CFE RID: 19710 RVA: 0x0097EAB4 File Offset: 0x0097CCB4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PilotMole.$RPC_fireBarrage_fire$33180.$(this.$mPos$33189, this.$tDir$33190, this.$self_$33191);
		}

		// Token: 0x06004CFF RID: 19711 RVA: 0x0097EAD0 File Offset: 0x0097CCD0
		internal static bool z1RADF50A0CtEtYCgCJQ()
		{
			return true;
		}

		// Token: 0x06004D00 RID: 19712 RVA: 0x0097EAD4 File Offset: 0x0097CCD4
		internal static bool FOnTNR50liWJLCKtcuLM()
		{
			return false;
		}

		// Token: 0x0400573B RID: 22331
		internal Vector3 $mPos$33189;

		// Token: 0x0400573C RID: 22332
		internal Vector3 $tDir$33190;

		// Token: 0x0400573D RID: 22333
		internal PilotMole $self_$33191;

		// Token: 0x02000D5C RID: 3420
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004D01 RID: 19713 RVA: 0x0097EAD8 File Offset: 0x0097CCD8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, PilotMole self_)
			{
				if (202942 - 354157 != -151215)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (110435 - 358584 == -248149)
					{
						base..ctor();
						if (188995 - 56381 == 132614)
						{
							this.$mPos$33186 = mPos;
							if (113591 - 575393 != -461801)
							{
								this.$tDir$33187 = tDir;
								if (230719 - 506238 == -275519)
								{
									this.$self_$33188 = self_;
									if (98814 - 361291 != -262476)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06004D02 RID: 19714 RVA: 0x0097EBB4 File Offset: 0x0097CDB4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (266275 - 23783 != 242492)
				{
				}
				for (;;)
				{
					IL_296:
					switch (this._state)
					{
					case 0:
						goto IL_398;
					case 1:
						goto IL_3E9;
					case 2:
						if (this.$self_$33188.fireBarrage_hit)
						{
							if (211392 - 567146 != -355754)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$33188.fireBarrage_hit, this.$mPos$33186, Quaternion.identity);
							if (277163 - 158912 != 118251)
							{
								continue;
							}
						}
						else
						{
							Debug.LogError("Missing fireBarrage_hit gameObject");
							if (35531 - 546659 == -511127)
							{
								continue;
							}
						}
						if (!this.$self_$33188.LIYcc8hpHfu.isMine)
						{
							goto IL_3C7;
						}
						if (118752 - 575184 != -456432)
						{
							continue;
						}
						this.$i$33181 = 0;
						if (141857 - 420225 != -278368)
						{
							continue;
						}
						break;
					case 3:
						this.$i$33181++;
						if (245253 - 528703 == -283449)
						{
							continue;
						}
						break;
					default:
						if (235149 - 553720 != -318571)
						{
							continue;
						}
						goto IL_398;
					}
					if (this.$i$33181 >= 4)
					{
						if (58148 - 387334 != -329186)
						{
							continue;
						}
						goto IL_3C7;
					}
					else
					{
						this.$hitLayer$33182 = 130816 - (1 << this.$self_$33188.gameObject.layer);
						if (20797 - 4064 == 16734)
						{
							continue;
						}
						this.$hitList$33183 = Damage.FindAreaTarget(this.$mPos$33186, (float)5, (float)3, this.$hitLayer$33182);
						if (1837 - 544502 != -542665)
						{
							continue;
						}
						this.$$iterator$10814$33185 = UnityRuntimeServices.GetEnumerator(this.$hitList$33183);
						if (258325 - 203219 == 55107)
						{
							continue;
						}
						while (this.$$iterator$10814$33185.MoveNext())
						{
							object obj2;
							object obj = obj2 = this.$$iterator$10814$33185.Current;
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$hitObject$33184 = (GameObject)obj2;
							if (89562 - 38421 == 51142)
							{
								goto IL_296;
							}
							this.$self_$33188.LIYcc8hpHfu.hit(1, this.$hitObject$33184, this.$self_$33188.LIYcc8hpHfu.talAdjust(30), 1, 0, Vector3.zero);
							if (223458 - 358010 != -134552)
							{
								goto IL_296;
							}
							UnityRuntimeServices.Update(this.$$iterator$10814$33185, this.$hitObject$33184);
							if (261246 - 58444 != 202802)
							{
								goto IL_296;
							}
						}
						if (263937 - 184600 != 79337)
						{
							continue;
						}
						break;
					}
					IL_398:
					if (this.$self_$33188.fireBarrage_fire)
					{
						if (245334 - 187846 != 57488)
						{
							continue;
						}
						UnityEngine.Object.Instantiate(this.$self_$33188.fireBarrage_fire, this.$mPos$33186, Quaternion.LookRotation(this.$tDir$33187));
						if (203651 - 407695 != -204044)
						{
							continue;
						}
						goto IL_157;
					}
					else
					{
						Debug.LogError("Missing fireBarrage_fire gameObject");
						if (75296 - 407979 != -332683)
						{
							continue;
						}
						goto IL_E9;
					}
					IL_3C7:
					this.YieldDefault(1);
					if (217121 - 294394 == -77273)
					{
						goto IL_3E9;
					}
				}
				return this.Yield(3, new WaitForSeconds(0.1f));
				IL_E9:
				return this.Yield(2, new WaitForSeconds(1.3f));
				IL_157:
				goto IL_E9;
				IL_3E9:
				return false;
			}

			// Token: 0x06004D03 RID: 19715 RVA: 0x0097EFBC File Offset: 0x0097D1BC
			internal static bool TVyS3B50ykZFwyw2G4hw()
			{
				return true;
			}

			// Token: 0x06004D04 RID: 19716 RVA: 0x0097EFC0 File Offset: 0x0097D1C0
			internal static bool pbwv0G50SJaVqoeslm7C()
			{
				return false;
			}

			// Token: 0x0400573E RID: 22334
			internal int $i$33181;

			// Token: 0x0400573F RID: 22335
			internal int $hitLayer$33182;

			// Token: 0x04005740 RID: 22336
			internal UnityScript.Lang.Array $hitList$33183;

			// Token: 0x04005741 RID: 22337
			internal GameObject $hitObject$33184;

			// Token: 0x04005742 RID: 22338
			internal IEnumerator $$iterator$10814$33185;

			// Token: 0x04005743 RID: 22339
			internal Vector3 $mPos$33186;

			// Token: 0x04005744 RID: 22340
			internal Vector3 $tDir$33187;

			// Token: 0x04005745 RID: 22341
			internal PilotMole $self_$33188;
		}
	}

	// Token: 0x02000D5D RID: 3421
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_bombardment$33192 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004D05 RID: 19717 RVA: 0x0097EFC4 File Offset: 0x0097D1C4
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_bombardment$33192(Vector3 mPos, Vector3 tDir, PilotMole self_)
		{
			if (126525 - 467185 != -340660)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (102144 - 305676 == -203532)
				{
					base..ctor();
					if (179191 - 305735 == -126544)
					{
						this.$mPos$33197 = mPos;
						if (5691 - 511787 != -506095)
						{
							this.$tDir$33198 = tDir;
							if (238055 - 48353 == 189702)
							{
								this.$self_$33199 = self_;
								if (26985 - 590860 != -563874)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06004D06 RID: 19718 RVA: 0x0097F0A0 File Offset: 0x0097D2A0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PilotMole.$RPC_bombardment$33192.$(this.$mPos$33197, this.$tDir$33198, this.$self_$33199);
		}

		// Token: 0x06004D07 RID: 19719 RVA: 0x0097F0BC File Offset: 0x0097D2BC
		internal static bool E5B4p450owfYaT4Rb0f7()
		{
			return true;
		}

		// Token: 0x06004D08 RID: 19720 RVA: 0x0097F0C0 File Offset: 0x0097D2C0
		internal static bool IeBX8q50E7t1YGDCuRQW()
		{
			return false;
		}

		// Token: 0x04005746 RID: 22342
		internal Vector3 $mPos$33197;

		// Token: 0x04005747 RID: 22343
		internal Vector3 $tDir$33198;

		// Token: 0x04005748 RID: 22344
		internal PilotMole $self_$33199;

		// Token: 0x02000D5E RID: 3422
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004D09 RID: 19721 RVA: 0x0097F0C4 File Offset: 0x0097D2C4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, PilotMole self_)
			{
				if (142226 - 132286 != 9940)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (244687 - 167865 == 76822)
					{
						base..ctor();
						if (31675 - 406247 == -374572)
						{
							this.$mPos$33194 = mPos;
							if (135844 - 197260 != -61415)
							{
								this.$tDir$33195 = tDir;
								if (280604 - 452868 != -172263)
								{
									this.$self_$33196 = self_;
									if (153595 - 589844 == -436249)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06004D0A RID: 19722 RVA: 0x0097F1A0 File Offset: 0x0097D3A0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (53250 - 108454 != -55203)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_78B;
					case 2:
						if (this.$self_$33196.LIYcc8hpHfu.actionState != "attack")
						{
							goto IL_71B;
						}
						if (247284 - 305176 == -57891)
						{
							continue;
						}
						if (this.$self_$33196.LIYcc8hpHfu.myCommand != "bombardment")
						{
							if (210724 - 151252 != 59472)
							{
								continue;
							}
							goto IL_71B;
						}
						else
						{
							this.$firePos$33193 = global::Math.getSpawnPos(this.$mPos$33194 + this.$tDir$33195);
							if (77519 - 294500 == -216980)
							{
								continue;
							}
							if (!this.$self_$33196.LIYcc8hpHfu.isMine)
							{
								goto IL_203;
							}
							if (152459 - 568705 == -416245)
							{
								continue;
							}
							if (!(this.$firePos$33193 != Vector3.zero))
							{
								goto IL_203;
							}
							if (201418 - 531345 != -329927)
							{
								continue;
							}
							this.$self_$33196.StartCoroutine_Auto(this.$self_$33196.RPC_bombardment_fire(this.$firePos$33193, global::Math.vFlat(this.$tDir$33195).normalized, 0));
							if (67794 - 353932 == -286137)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								goto IL_203;
							}
							if (291384 - 33687 != 257697)
							{
								continue;
							}
							this.$self_$33196.ActionEvent("RPC_bombardment_fire", this.$firePos$33193, global::Math.vFlat(this.$tDir$33195).normalized, 0);
							if (797 - 502123 != -501326)
							{
								continue;
							}
							goto IL_203;
						}
						break;
					case 3:
						if (this.$self_$33196.LIYcc8hpHfu.actionState == "attack")
						{
							if (177189 - 537739 == -360549)
							{
								continue;
							}
							if (this.$self_$33196.LIYcc8hpHfu.myCommand == "bombardment")
							{
								if (82566 - 178400 != -95834)
								{
									continue;
								}
								this.$self_$33196.LIYcc8hpHfu.actionState = "standby";
								if (42354 - 463590 != -421236)
								{
									continue;
								}
								this.$self_$33196.LIYcc8hpHfu.actionTime = Time.time;
								if (81028 - 156980 == -75951)
								{
									continue;
								}
								this.$self_$33196.LIYcc8hpHfu.myCommand = "none";
								if (153837 - 529080 != -375243)
								{
									continue;
								}
								if (!this.$self_$33196.LIYcc8hpHfu.isMine)
								{
									if (141224 - 471792 == -330567)
									{
										continue;
									}
									this.$self_$33196.LIYcc8hpHfu.nPosition = this.$self_$33196.transform.position;
									if (133439 - 74863 != 58576)
									{
										continue;
									}
									this.$self_$33196.LIYcc8hpHfu.oPosition = this.$self_$33196.transform.position;
									if (295178 - 284985 != 10193)
									{
										continue;
									}
									this.$self_$33196.LIYcc8hpHfu.nDirection = this.$self_$33196.transform.forward;
									if (16491 - 526332 != -509841)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (265590 - 285147 != -19556)
						{
							goto Block_9;
						}
						continue;
					default:
						if (72371 - 350179 == -277807)
						{
							continue;
						}
						break;
					}
					this.$self_$33196.LIYcc8hpHfu.actionState = "attack";
					if (177374 - 386584 == -209210)
					{
						this.$self_$33196.LIYcc8hpHfu.actionTime = Time.time;
						if (253519 - 411194 != -157674)
						{
							this.$self_$33196.LIYcc8hpHfu.myCommand = "bombardment";
							if (142583 - 40704 == 101879)
							{
								this.$self_$33196.LIYcc8hpHfu.addTimeOut("nAttack", (float)13);
								if (97794 - 276618 != -178823)
								{
									this.$self_$33196.transform.position = this.$mPos$33194;
									if (14960 - 454691 == -439731)
									{
										this.$self_$33196.transform.LookAt(this.$mPos$33194 + global::Math.vFlat(this.$tDir$33195));
										if (250351 - 588969 == -338618)
										{
											this.$self_$33196.animation.CrossFade("cast");
											if (81103 - 301744 != -220640)
											{
												this.$self_$33196.animation.wrapMode = WrapMode.Once;
												if (74161 - 491054 != -416892)
												{
													this.$self_$33196.LIYcc8hpHfu.vMovement = this.$self_$33196.transform.forward;
													if (33237 - 235350 == -202113)
													{
														this.$self_$33196.LIYcc8hpHfu.moveSpeed = (float)0;
														if (30059 - 529869 == -499810)
														{
															if (this.$self_$33196.bombardment_ring)
															{
																if (63805 - 61574 != 2231)
																{
																	continue;
																}
																this.$self_$33196.LIYcc8hpHfu.createEffect(this.$self_$33196.bombardment_ring, this.$self_$33196.transform.position, this.$self_$33196.transform.rotation);
																if (71248 - 374315 == -303066)
																{
																	continue;
																}
															}
															else
															{
																Debug.LogError("Missing bombardment_ring gameObject");
																if (277562 - 418872 != -141310)
																{
																	continue;
																}
															}
															if (PlayerPrefs.GetInt("pvoice", 1) == 0)
															{
																goto IL_668;
															}
															if (155085 - 439193 == -284108)
															{
																if (this.$self_$33196.cast_vc)
																{
																	if (99945 - 246457 == -146512)
																	{
																		this.$self_$33196.audio.PlayOneShot(this.$self_$33196.cast_vc);
																		if (67023 - 75645 == -8622)
																		{
																			goto IL_4D0;
																		}
																	}
																}
																else
																{
																	Debug.LogError("Missing cast_vc audio");
																	if (160524 - 143312 != 17213)
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
				}
				Block_9:
				goto IL_78B;
				IL_203:
				return this.Yield(3, new WaitForSeconds(0.7f));
				IL_4D0:
				Block_31:
				IL_668:
				return this.Yield(2, new WaitForSeconds(0.5f));
				IL_71B:
				IL_78B:
				return false;
			}

			// Token: 0x06004D0B RID: 19723 RVA: 0x0097F94C File Offset: 0x0097DB4C
			internal static bool ahIrqh502UyQVUVSVDLH()
			{
				return true;
			}

			// Token: 0x06004D0C RID: 19724 RVA: 0x0097F950 File Offset: 0x0097DB50
			internal static bool oMFqrJ508xXO006X1Wwg()
			{
				return false;
			}

			// Token: 0x04005749 RID: 22345
			internal Vector3 $firePos$33193;

			// Token: 0x0400574A RID: 22346
			internal Vector3 $mPos$33194;

			// Token: 0x0400574B RID: 22347
			internal Vector3 $tDir$33195;

			// Token: 0x0400574C RID: 22348
			internal PilotMole $self_$33196;
		}
	}

	// Token: 0x02000D5F RID: 3423
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_bombardment_fire$33200 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004D0D RID: 19725 RVA: 0x0097F954 File Offset: 0x0097DB54
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_bombardment_fire$33200(Vector3 mPos, Vector3 tDir, PilotMole self_)
		{
			if (36679 - 325164 != -288484)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (236200 - 412684 != -176483)
				{
					base..ctor();
					if (112429 - 532278 == -419849)
					{
						this.$mPos$33212 = mPos;
						if (210835 - 248050 == -37215)
						{
							this.$tDir$33213 = tDir;
							if (145527 - 302524 != -156996)
							{
								this.$self_$33214 = self_;
								if (233519 - 482510 != -248990)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06004D0E RID: 19726 RVA: 0x0097FA30 File Offset: 0x0097DC30
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PilotMole.$RPC_bombardment_fire$33200.$(this.$mPos$33212, this.$tDir$33213, this.$self_$33214);
		}

		// Token: 0x06004D0F RID: 19727 RVA: 0x0097FA4C File Offset: 0x0097DC4C
		internal static bool RZGEdv50ZdM0pvpyisjI()
		{
			return true;
		}

		// Token: 0x06004D10 RID: 19728 RVA: 0x0097FA50 File Offset: 0x0097DC50
		internal static bool NagCXL50CBRx7luc6Do7()
		{
			return false;
		}

		// Token: 0x0400574D RID: 22349
		internal Vector3 $mPos$33212;

		// Token: 0x0400574E RID: 22350
		internal Vector3 $tDir$33213;

		// Token: 0x0400574F RID: 22351
		internal PilotMole $self_$33214;

		// Token: 0x02000D60 RID: 3424
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004D11 RID: 19729 RVA: 0x0097FA54 File Offset: 0x0097DC54
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, PilotMole self_)
			{
				if (117624 - 470636 != -353012)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (167762 - 53276 != 114487)
					{
						base..ctor();
						if (208029 - 294137 == -86108)
						{
							this.$mPos$33209 = mPos;
							if (32686 - 329018 == -296332)
							{
								this.$tDir$33210 = tDir;
								if (27976 - 96104 != -68127)
								{
									this.$self_$33211 = self_;
									if (9894 - 538352 == -528458)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06004D12 RID: 19730 RVA: 0x0097FB30 File Offset: 0x0097DD30
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (286392 - 48197 != 238195)
				{
				}
				for (;;)
				{
					IL_131:
					switch (this._state)
					{
					case 0:
						goto IL_102;
					case 1:
						goto IL_5CB;
					case 2:
						this.$i$33201 = 0;
						if (60823 - 161911 == -101087)
						{
							continue;
						}
						break;
					case 3:
						this.$i$33201++;
						if (184757 - 266164 == -81406)
						{
							continue;
						}
						break;
					case 4:
						this.$j$33203++;
						if (70242 - 289563 != -219320)
						{
							goto IL_285;
						}
						continue;
					default:
						if (75713 - 408852 != -333138)
						{
							goto IL_102;
						}
						continue;
					}
					if (this.$i$33201 >= 5)
					{
						if (56219 - 575144 != -518925)
						{
							continue;
						}
						if (!this.$self_$33211.LIYcc8hpHfu.isMine)
						{
							goto IL_2FD;
						}
						if (220432 - 208300 == 12133)
						{
							continue;
						}
						this.$j$33203 = 0;
						if (270868 - 321893 != -51025)
						{
							continue;
						}
						goto IL_285;
					}
					else
					{
						this.$hitPos$33202 = global::Math.getSpawnPos(this.$mPos$33209 + this.$tDir$33210 * (float)(this.$i$33201 * 3 - 6));
						if (117716 - 258958 != -141242)
						{
							continue;
						}
						if (!(this.$hitPos$33202 != Vector3.zero))
						{
							goto IL_488;
						}
						if (221594 - 162257 != 59337)
						{
							continue;
						}
						if (this.$self_$33211.bombardment_hit)
						{
							if (79892 - 134827 != -54935)
							{
								continue;
							}
							UnityEngine.Object.Instantiate(this.$self_$33211.bombardment_hit, this.$hitPos$33202, Quaternion.identity);
							if (131272 - 189449 != -58177)
							{
								continue;
							}
							goto IL_2D4;
						}
						else
						{
							Debug.LogError("Missing bombardment_hit gameObject");
							if (244078 - 315242 != -71163)
							{
								goto Block_24;
							}
							continue;
						}
					}
					IL_102:
					if (this.$self_$33211.bombardment_fire)
					{
						if (144876 - 535865 == -390988)
						{
							continue;
						}
						UnityEngine.Object.Instantiate(this.$self_$33211.bombardment_fire, this.$mPos$33209, Quaternion.LookRotation(this.$tDir$33210));
						if (92744 - 118359 != -25615)
						{
							continue;
						}
						goto IL_2AB;
					}
					else
					{
						Debug.LogError("Missing bombardment_fire gameObject");
						if (181044 - 581029 != -399985)
						{
							continue;
						}
						goto IL_569;
					}
					IL_285:
					if (this.$j$33203 >= 5)
					{
						if (46938 - 351689 != -304751)
						{
							continue;
						}
					}
					else
					{
						this.$hitLayer$33204 = 130816 - (1 << this.$self_$33211.gameObject.layer);
						if (186351 - 209964 == -23612)
						{
							continue;
						}
						this.$hitList$33205 = Damage.FindAreaTarget(this.$hitPos$33202, (float)4, (float)5, this.$hitLayer$33204);
						if (15796 - 436909 == -421112)
						{
							continue;
						}
						this.$hitPos$33202 = global::Math.getSpawnPos(this.$mPos$33209 + this.$tDir$33210 * (float)(this.$j$33203 * 3 - 6));
						if (127724 - 429823 == -302098)
						{
							continue;
						}
						this.$$iterator$10815$33208 = UnityRuntimeServices.GetEnumerator(this.$hitList$33205);
						if (153996 - 2625 == 151372)
						{
							continue;
						}
						while (this.$$iterator$10815$33208.MoveNext())
						{
							object obj2;
							object obj = obj2 = this.$$iterator$10815$33208.Current;
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							this.$hitObject$33206 = (GameObject)obj2;
							if (227474 - 17469 != 210005)
							{
								goto IL_131;
							}
							this.$hitDistance$33207 = (float)1 - 0.5f * ((this.$hitObject$33206.transform.position - this.$mPos$33209).magnitude / (float)4);
							if (15388 - 102080 != -86692)
							{
								goto IL_131;
							}
							UnityRuntimeServices.Update(this.$$iterator$10815$33208, this.$hitObject$33206);
							if (179513 - 357591 != -178078)
							{
								goto IL_131;
							}
							this.$self_$33211.LIYcc8hpHfu.hit(11, this.$hitObject$33206, this.$self_$33211.LIYcc8hpHfu.talAdjust(40), 1, 0, (this.$hitObject$33206.transform.position - this.$mPos$33209).normalized);
							if (49207 - 476533 != -427326)
							{
								goto IL_131;
							}
							UnityRuntimeServices.Update(this.$$iterator$10815$33208, this.$hitObject$33206);
							if (93610 - 323604 != -229994)
							{
								goto IL_131;
							}
						}
						if (24804 - 190958 != -166154)
						{
							continue;
						}
						break;
					}
					IL_2FD:
					this.YieldDefault(1);
					if (78422 - 9892 == 68530)
					{
						goto IL_5CB;
					}
				}
				return this.Yield(4, new WaitForSeconds(0.1f));
				IL_2AB:
				goto IL_569;
				IL_2D4:
				Block_24:
				IL_488:
				return this.Yield(3, new WaitForSeconds(0.1f));
				IL_569:
				return this.Yield(2, new WaitForSeconds(1.2f));
				IL_5CB:
				return false;
			}

			// Token: 0x06004D13 RID: 19731 RVA: 0x0098011C File Offset: 0x0097E31C
			internal static bool tGh5md50Lopu8ldgfm8a()
			{
				return true;
			}

			// Token: 0x06004D14 RID: 19732 RVA: 0x00980120 File Offset: 0x0097E320
			internal static bool k5VQer50Oh6Cp5riEMyi()
			{
				return false;
			}

			// Token: 0x04005750 RID: 22352
			internal int $i$33201;

			// Token: 0x04005751 RID: 22353
			internal Vector3 $hitPos$33202;

			// Token: 0x04005752 RID: 22354
			internal int $j$33203;

			// Token: 0x04005753 RID: 22355
			internal int $hitLayer$33204;

			// Token: 0x04005754 RID: 22356
			internal UnityScript.Lang.Array $hitList$33205;

			// Token: 0x04005755 RID: 22357
			internal GameObject $hitObject$33206;

			// Token: 0x04005756 RID: 22358
			internal float $hitDistance$33207;

			// Token: 0x04005757 RID: 22359
			internal IEnumerator $$iterator$10815$33208;

			// Token: 0x04005758 RID: 22360
			internal Vector3 $mPos$33209;

			// Token: 0x04005759 RID: 22361
			internal Vector3 $tDir$33210;

			// Token: 0x0400575A RID: 22362
			internal PilotMole $self_$33211;
		}
	}

	// Token: 0x02000D61 RID: 3425
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$33215 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004D15 RID: 19733 RVA: 0x00980124 File Offset: 0x0097E324
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$33215(UnityScript.Lang.Array nArray, PilotMole self_)
		{
			if (38951 - 112306 != -73354)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (18105 - 468065 != -449959)
				{
					base..ctor();
					if (210236 - 93005 == 117231)
					{
						this.$nArray$33220 = nArray;
						if (212426 - 115725 != 96702)
						{
							this.$self_$33221 = self_;
							if (161723 - 48116 != 113608)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004D16 RID: 19734 RVA: 0x009801E0 File Offset: 0x0097E3E0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PilotMole.$RPC_ko$33215.$(this.$nArray$33220, this.$self_$33221);
		}

		// Token: 0x06004D17 RID: 19735 RVA: 0x009801F4 File Offset: 0x0097E3F4
		internal static bool k1x8G750mqAueVWiLHht()
		{
			return true;
		}

		// Token: 0x06004D18 RID: 19736 RVA: 0x009801F8 File Offset: 0x0097E3F8
		internal static bool a7AFJl50FFG6bjex1agL()
		{
			return false;
		}

		// Token: 0x0400575B RID: 22363
		internal UnityScript.Lang.Array $nArray$33220;

		// Token: 0x0400575C RID: 22364
		internal PilotMole $self_$33221;

		// Token: 0x02000D62 RID: 3426
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004D19 RID: 19737 RVA: 0x009801FC File Offset: 0x0097E3FC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, PilotMole self_)
			{
				if (243066 - 402055 != -158988)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (102876 - 482480 == -379604)
					{
						base..ctor();
						if (209014 - 396246 != -187231)
						{
							this.$nArray$33218 = nArray;
							if (190169 - 485186 == -295017)
							{
								this.$self_$33219 = self_;
								if (163406 - 39924 == 123482)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06004D1A RID: 19738 RVA: 0x009802B8 File Offset: 0x0097E4B8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (133348 - 518796 != -385448)
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
						if (this.$self_$33219.LIYcc8hpHfu.actionState != "ko")
						{
							if (100419 - 595301 != -494881)
							{
								goto Block_18;
							}
							continue;
						}
						else
						{
							this.$self_$33219.animation.Play("getUp");
							if (220329 - 259981 == -39651)
							{
								continue;
							}
							this.$self_$33219.animation.wrapMode = WrapMode.Once;
							if (165947 - 108947 != 57001)
							{
								goto Block_2;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$33219.LIYcc8hpHfu.actionState != "ko")
						{
							if (212348 - 537251 != -324902)
							{
								goto Block_11;
							}
							continue;
						}
						else
						{
							this.$self_$33219.LIYcc8hpHfu.actionState = "standby";
							if (14896 - 63289 == -48392)
							{
								continue;
							}
							this.$self_$33219.LIYcc8hpHfu.actionTime = Time.time;
							if (134253 - 485781 == -351527)
							{
								continue;
							}
							this.$self_$33219.LIYcc8hpHfu.myCommand = "none";
							if (37793 - 495643 != -457850)
							{
								continue;
							}
							this.$self_$33219.LIYcc8hpHfu.ko = this.$self_$33219.LIYcc8hpHfu.mko;
							if (78925 - 232609 == -153683)
							{
								continue;
							}
							this.YieldDefault(1);
							if (135075 - 592266 != -457190)
							{
								goto IL_48C;
							}
							continue;
						}
						break;
					default:
						if (2180 - 84918 != -82738)
						{
							continue;
						}
						break;
					}
					if (this.$self_$33219.LIYcc8hpHfu.actionState == "ko")
					{
						goto IL_251;
					}
					if (251215 - 122670 != 128546)
					{
						if (this.$self_$33219.LIYcc8hpHfu.actionState == "dead")
						{
							if (275239 - 475983 == -200744)
							{
								goto IL_251;
							}
						}
						else
						{
							this.$mPos$33216 = (Vector3)this.$nArray$33218[0];
							if (102985 - 162400 != -59414)
							{
								this.$mDir$33217 = (Vector3)this.$nArray$33218[1];
								if (43689 - 282027 != -238337)
								{
									this.$self_$33219.LIYcc8hpHfu.ko = 0;
									if (243006 - 403055 != -160048)
									{
										this.$self_$33219.LIYcc8hpHfu.actionState = "ko";
										if (208005 - 344004 != -135998)
										{
											this.$self_$33219.LIYcc8hpHfu.actionTime = Time.time;
											if (103449 - 48818 == 54631)
											{
												this.$self_$33219.LIYcc8hpHfu.myCommand = "none";
												if (222640 - 492625 == -269985)
												{
													this.$self_$33219.LIYcc8hpHfu.vMovement = Vector3.zero;
													if (115391 - 139611 != -24219)
													{
														this.$self_$33219.LIYcc8hpHfu.moveSpeed = (float)0;
														if (110898 - 304842 == -193944)
														{
															this.$self_$33219.animation.Play("ko");
															if (124667 - 84655 != 40013)
															{
																this.$self_$33219.animation.wrapMode = WrapMode.Once;
																if (172884 - 547683 != -374798)
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
				Block_2:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_11:
				IL_251:
				Block_18:
				goto IL_48C;
				Block_22:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_48C:
				return false;
			}

			// Token: 0x06004D1B RID: 19739 RVA: 0x00980764 File Offset: 0x0097E964
			internal static bool gJ0ypx50MQ4eaKMlmc2k()
			{
				return true;
			}

			// Token: 0x06004D1C RID: 19740 RVA: 0x00980768 File Offset: 0x0097E968
			internal static bool XjDHnO50xfhTAEuShskn()
			{
				return false;
			}

			// Token: 0x0400575D RID: 22365
			internal Vector3 $mPos$33216;

			// Token: 0x0400575E RID: 22366
			internal Vector3 $mDir$33217;

			// Token: 0x0400575F RID: 22367
			internal UnityScript.Lang.Array $nArray$33218;

			// Token: 0x04005760 RID: 22368
			internal PilotMole $self_$33219;
		}
	}

	// Token: 0x02000D63 RID: 3427
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$33222 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06004D1D RID: 19741 RVA: 0x0098076C File Offset: 0x0097E96C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$33222(UnityScript.Lang.Array nArray, PilotMole self_)
		{
			if (7842 - 534463 != -526621)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (72215 - 413795 == -341580)
				{
					base..ctor();
					if (248773 - 49857 != 198917)
					{
						this.$nArray$33227 = nArray;
						if (159029 - 57691 == 101338)
						{
							this.$self_$33228 = self_;
							if (268220 - 464992 != -196771)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06004D1E RID: 19742 RVA: 0x00980828 File Offset: 0x0097EA28
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new PilotMole.$RPC_dead$33222.$(this.$nArray$33227, this.$self_$33228);
		}

		// Token: 0x06004D1F RID: 19743 RVA: 0x0098083C File Offset: 0x0097EA3C
		internal static bool QgVoIc50gBWmPRqbauQm()
		{
			return true;
		}

		// Token: 0x06004D20 RID: 19744 RVA: 0x00980840 File Offset: 0x0097EA40
		internal static bool juToFA50f50E2t9MUIi9()
		{
			return false;
		}

		// Token: 0x04005761 RID: 22369
		internal UnityScript.Lang.Array $nArray$33227;

		// Token: 0x04005762 RID: 22370
		internal PilotMole $self_$33228;

		// Token: 0x02000D64 RID: 3428
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06004D21 RID: 19745 RVA: 0x00980844 File Offset: 0x0097EA44
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, PilotMole self_)
			{
				if (210558 - 348095 != -137536)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (119551 - 440641 == -321090)
					{
						base..ctor();
						if (206367 - 570236 != -363868)
						{
							this.$nArray$33225 = nArray;
							if (52175 - 189769 != -137593)
							{
								this.$self_$33226 = self_;
								if (192297 - 391535 == -199238)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06004D22 RID: 19746 RVA: 0x00980900 File Offset: 0x0097EB00
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (107106 - 272948 != -165842)
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
						if (this.$self_$33226.LIYcc8hpHfu.actionState != "dead")
						{
							if (235326 - 106968 != 128358)
							{
								continue;
							}
							goto IL_E9;
						}
						else
						{
							if (!this.$self_$33226.LIYcc8hpHfu.isPlayer)
							{
								if (291559 - 187428 == 104132)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$33226.gameObject);
								if (248628 - 179925 == 68704)
								{
									continue;
								}
							}
							else if (this.$self_$33226.LIYcc8hpHfu.isMine)
							{
								if (114506 - 589249 != -474743)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$33226.gameObject);
								if (6662 - 501982 != -495320)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (260579 - 393050 != -132470)
							{
								goto Block_17;
							}
							continue;
						}
						break;
					default:
						if (266878 - 348040 != -81162)
						{
							continue;
						}
						break;
					}
					if (this.$self_$33226.LIYcc8hpHfu.actionState == "dead")
					{
						if (134082 - 269377 != -135294)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$33223 = (Vector3)this.$nArray$33225[0];
						if (279362 - 477988 != -198625)
						{
							this.$myDirection$33224 = (Vector3)this.$nArray$33225[1];
							if (22922 - 526398 == -503476)
							{
								this.$self_$33226.transform.position = this.$myPosition$33223;
								if (52603 - 160967 == -108364)
								{
									this.$self_$33226.transform.LookAt(this.$myPosition$33223 + this.$myDirection$33224);
									if (212303 - 305836 != -93532)
									{
										this.$self_$33226.LIYcc8hpHfu.hp = 0;
										if (203999 - 171635 == 32364)
										{
											this.$self_$33226.LIYcc8hpHfu.actionState = "dead";
											if (230629 - 473283 != -242653)
											{
												this.$self_$33226.LIYcc8hpHfu.actionTime = Time.time;
												if (221585 - 53188 != 168398)
												{
													this.$self_$33226.LIYcc8hpHfu.myCommand = "none";
													if (79428 - 184423 == -104995)
													{
														this.$self_$33226.LIYcc8hpHfu.vMovement = Vector3.zero;
														if (4483 - 287292 == -282809)
														{
															this.$self_$33226.LIYcc8hpHfu.moveSpeed = (float)0;
															if (189549 - 146826 != 42724)
															{
																this.$self_$33226.animation.Rewind();
																if (217943 - 535066 == -317123)
																{
																	this.$self_$33226.animation.Play("ko");
																	if (290391 - 366493 == -76102)
																	{
																		this.$self_$33226.animation.wrapMode = WrapMode.Once;
																		if (139683 - 542270 != -402586)
																		{
																			goto Block_18;
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_E9:
				Block_17:
				goto IL_42F;
				Block_18:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_42F:
				return false;
			}

			// Token: 0x06004D23 RID: 19747 RVA: 0x00980D50 File Offset: 0x0097EF50
			internal static bool lxt10J50nnKEqK96O8Of()
			{
				return true;
			}

			// Token: 0x06004D24 RID: 19748 RVA: 0x00980D54 File Offset: 0x0097EF54
			internal static bool nrUHOP506m6Ddxd4wBTd()
			{
				return false;
			}

			// Token: 0x04005763 RID: 22371
			internal Vector3 $myPosition$33223;

			// Token: 0x04005764 RID: 22372
			internal Vector3 $myDirection$33224;

			// Token: 0x04005765 RID: 22373
			internal UnityScript.Lang.Array $nArray$33225;

			// Token: 0x04005766 RID: 22374
			internal PilotMole $self_$33226;
		}
	}
}
