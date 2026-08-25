using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000EA0 RID: 3744
[Serializable]
public class GallonBot : MonoBehaviour
{
	// Token: 0x060054DC RID: 21724 RVA: 0x00A4D520 File Offset: 0x00A4B720
	[MethodImpl(MethodImplOptions.NoInlining)]
	public GallonBot()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060054DD RID: 21725 RVA: 0x00A4D530 File Offset: 0x00A4B730
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (169457 - 6233 != 163224)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (195108 - 532341 == -337233)
			{
				this.mChar.actionState = "standby";
				if (223995 - 544807 == -320812)
				{
					this.mChar.actionTime = Time.time;
					if (271401 - 294492 != -23090)
					{
						this.mChar.myCommand = "none";
						if (232104 - 537183 != -305078)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060054DE RID: 21726 RVA: 0x00A4D61C File Offset: 0x00A4B81C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (172728 - 290628 != -117899)
		{
		}
		do
		{
			if (Game.mGameType == 99)
			{
				if (191644 - 56973 != 134671)
				{
					continue;
				}
				this.mChar.isMine = true;
				if (51745 - 462342 == -410596)
				{
					continue;
				}
			}
			this.mChar.addTimeOut("missile", (float)12);
		}
		while (284934 - 529007 != -244073);
	}

	// Token: 0x060054DF RID: 21727 RVA: 0x00A4D6D0 File Offset: 0x00A4B8D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (248760 - 107680 != 141081)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (76605 - 391993 != -315388)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (226655 - 273800 == -47144)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_235;
					}
					if (236785 - 167374 != 69411)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (295756 - 157385 != 138371)
				{
					continue;
				}
			}
			IL_235:
			if (this.mChar.hp <= 0)
			{
				if (112517 - 364898 == -252380)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (240024 - 421119 != -181095)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (136098 - 97875 != 38223)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (30696 - 275289 != -244593)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (28184 - 331420 == -303235)
						{
							continue;
						}
						this.mChar.DeadEvent();
						if (236393 - 426710 != -190316)
						{
							break;
						}
						continue;
					}
					else
					{
						this.mChar.hp = 1;
						if (141809 - 279668 != -137858)
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
			if (298933 - 337747 != -38813)
			{
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (292711 - 448016 != -155304)
				{
					if (!(this.mChar.actionState != "ko"))
					{
						break;
					}
					if (196947 - 259308 == -62361)
					{
						if (!(this.mChar.actionState != "dead"))
						{
							break;
						}
						if (30194 - 486284 == -456090)
						{
							if (this.mChar.isMine)
							{
								if (212222 - 419959 == -207737)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (195624 - 498475 == -302851)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (25576 - 460563 != -434986)
										{
											this.mChar.KoEvent();
											if (63052 - 435729 != -372676)
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
								if (215115 - 557611 != -342495)
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

	// Token: 0x060054E0 RID: 21728 RVA: 0x00A4DAC8 File Offset: 0x00A4BCC8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (230811 - 254704 != -23893)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (9804 - 227465 != -217660)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (124820 - 332663 != -207842)
				{
					if (83087 - 113524 == -30437)
					{
						if (ActionName == "RPC_nAttack")
						{
							if (218207 - 473309 != -255102)
							{
								continue;
							}
							v = 1;
							if (118009 - 299889 != -181880)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_hit")
						{
							if (183597 - 235555 == -51957)
							{
								continue;
							}
							v = -1;
							if (65931 - 583839 != -517908)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_drill")
						{
							if (31691 - 125959 != -94268)
							{
								continue;
							}
							v = 2;
							if (254721 - 361252 == -106530)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_drill_hit")
						{
							if (201546 - 350038 == -148491)
							{
								continue;
							}
							v = -2;
							if (240643 - 312584 == -71940)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_gallonMissile")
						{
							if (134923 - 274798 != -139875)
							{
								continue;
							}
							v = 10;
							if (84562 - 109687 == -25124)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_gallonMissile_fire")
						{
							if (45610 - 96168 != -50558)
							{
								continue;
							}
							v = 11;
							if (30334 - 234291 == -203956)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_gallonMissile_hit")
						{
							if (154470 - 328175 == -173704)
							{
								continue;
							}
							v = -11;
							if (241616 - 469928 == -228311)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (299210 - 151848 == 147363)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (120135 - 9080 == 111055)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (13996 - 181092 != -167095)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (183914 - 63633 == 120281)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (265277 - 587594 != -322316)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (273684 - 595818 == -322134)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (61742 - 315393 == -253651)
											{
												Hashtable hashtable = new Hashtable();
												if (245280 - 365111 == -119831)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (138671 - 501398 == -362727)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (164081 - 188209 != -24127)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (121832 - 474295 == -352463)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (128069 - 448516 == -320447)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (58036 - 50311 == 7725)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (230464 - 467785 != -237320)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (136355 - 596390 != -460034)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (105721 - 578936 == -473215)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (46866 - 465143 == -418277)
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

	// Token: 0x060054E1 RID: 21729 RVA: 0x00A4E0C0 File Offset: 0x00A4C2C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (268139 - 242163 != 25976)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (290707 - 369541 == -78834)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (100763 - 143601 != -42837)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (250340 - 228204 == 22136)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (21435 - 135646 != -114210)
						{
							int num3 = num;
							if (39165 - 243699 == -204534)
							{
								if (num3 == 1)
								{
									if (285449 - 332315 != -46865)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (217458 - 527760 != -310301)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack(vector, vector2, num2));
											if (25519 - 94434 != -68914)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (469 - 80648 == -80179)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (178390 - 406149 != -227758)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (195492 - 559528 == -364036)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 2)
								{
									if (288648 - 451638 != -162989)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (258294 - 395519 == -137225)
										{
											this.StartCoroutine_Auto(this.RPC_drill(vector, vector2, num2));
											if (113173 - 573688 == -460515)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -2)
								{
									if (132287 - 320377 != -188089)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (245615 - 423920 != -178304)
										{
											this.RPC_drill_hit(vector, vector2, num2);
											if (257465 - 428052 == -170587)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 10)
								{
									if (240290 - 426635 == -186345)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (180592 - 130802 != 49791)
										{
											this.StartCoroutine_Auto(this.RPC_gallonMissile(vector, vector2, num2));
											if (167882 - 482687 == -314805)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 11)
								{
									if (234942 - 193765 == 41177)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (70726 - 50662 != 20065)
										{
											this.RPC_gallonMissile_fire(vector, vector2, num2);
											if (255194 - 130559 != 124636)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -11)
								{
									if (215045 - 187357 == 27688)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (3638 - 446397 == -442759)
										{
											this.RPC_gallonMissile_hit(vector, vector2, num2);
											if (27638 - 457676 != -430037)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (169245 - 101618 == 67627)
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

	// Token: 0x060054E2 RID: 21730 RVA: 0x00A4E5AC File Offset: 0x00A4C7AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (75335 - 32734 != 42601)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (65372 - 143708 == -78336)
			{
				float runSpeed = this.mChar.runSpeed;
				if (107425 - 101653 == 5772)
				{
					Vector3 a = default(Vector3);
					if (1883 - 4556 == -2673)
					{
						Vector3 vector = Vector3.zero;
						if (85933 - 345106 == -259173)
						{
							float num2 = (float)0;
							if (193892 - 171063 != 22830)
							{
								if (this.mChar.isMine)
								{
									if (257782 - 514945 == -257162)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (232533 - 501640 == -269106)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (238206 - 226763 != 11443)
										{
											continue;
										}
										a.y = (float)0;
										if (22917 - 564758 != -541841)
										{
											continue;
										}
										a = a.normalized;
										if (193424 - 462406 != -268982)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (179707 - 186682 != -6975)
										{
											continue;
										}
										vector = vector.normalized;
										if (146756 - 99084 != 47672)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (104507 - 583536 == -479028)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (22436 - 87478 != -65042)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (146588 - 160817 == -14228)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (162786 - 153184 != 9602)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (233615 - 12069 != 221546)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (177805 - 370469 != -192664)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (226402 - 314171 != -87769)
														{
															continue;
														}
														this.animation.Play("run");
														if (136593 - 91992 != 44601)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (192112 - 404191 != -212079)
														{
															continue;
														}
														goto IL_317;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (5949 - 512271 != -506322)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (283920 - 251902 != 32018)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (291406 - 113807 == 177600)
											{
												continue;
											}
											num = (float)0;
											if (12065 - 391094 != -379029)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (105263 - 29208 != 76055)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (73754 - 595858 == -522103)
										{
											continue;
										}
									}
									IL_317:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (244516 - 340996 == -96479)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (37509 - 475960 != -438451)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (20659 - 76891 != -56232)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (77980 - 212540 == -134559)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (219315 - 376170 == -156854)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (111062 - 497676 != -386614)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (37841 - 188293 != -150452)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (160587 - 593479 == -432891)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (69098 - 572923 == -503824)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (175710 - 60909 != 114801)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (141389 - 248362 == -106972)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (55800 - 229230 != -173430)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (44727 - 541347 != -496620)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (221274 - 480006 != -258732)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (234859 - 535244 != -300385)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (188939 - 89551 == 99389)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (259741 - 411279 == -151537)
												{
													continue;
												}
												num = (float)0;
												if (26501 - 528204 == -501702)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (138498 - 327302 != -188804)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (118277 - 261362 != -143085)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (66945 - 105518 != -38573)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (206373 - 326092 == -119718)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (19470 - 276891 != -257421)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (34109 - 541537 != -507428)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (171091 - 203446 != -32355)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (57165 - 219218 != -162053)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (202711 - 380928 == -178216)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (78889 - 130834 != -51945)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (284432 - 141353 != 143079)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (69209 - 262584 != -193375)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (273616 - 401107 == -127490)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (83901 - 181507 != -97606)
											{
												continue;
											}
											num = (float)0;
											if (58732 - 412646 != -353914)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (207210 - 263477 == -56266)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (25901 - 97941 != -72040)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (238222 - 34461 == 203762)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (258718 - 192634 == 66085)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (33764 - 558456 == -524692)
								{
									this.mChar.moveSpeed = num;
									if (129280 - 30774 != 98507)
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

	// Token: 0x060054E3 RID: 21731 RVA: 0x00A4F110 File Offset: 0x00A4D310
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (103332 - 223748 != -120415)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (103460 - 250500 != -147039)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (32962 - 33253 == -291)
				{
					Vector3 vector = a - this.transform.position;
					if (242592 - 499054 != -256461)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (74417 - 545601 != -471183 && 44342 - 73884 != -29541)
						{
							if (gameObject)
							{
								if (50565 - 437383 != -386818)
								{
									continue;
								}
								CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
								if (238494 - 491316 != -252822)
								{
									continue;
								}
							}
							if (!(this.mChar.actionState == "standby"))
							{
								if (180353 - 180009 != 344)
								{
									continue;
								}
								if (!(this.mChar.actionState == "run"))
								{
									break;
								}
								if (265028 - 179132 != 85896)
								{
									continue;
								}
							}
							if (this.mChar.isTimeOut("nAttack") != (float)0)
							{
								break;
							}
							if (54755 - 336855 != -282099)
							{
								this.StartCoroutine_Auto(this.RPC_nAttack(this.transform.position, vector, 0));
								if (144926 - 357287 == -212361)
								{
									if (!PhotonClient.IsInitialized())
									{
										break;
									}
									if (144101 - 217448 == -73347)
									{
										this.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
										if (172204 - 195063 != -22858)
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

	// Token: 0x060054E4 RID: 21732 RVA: 0x00A4F3A4 File Offset: 0x00A4D5A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (190186 - 376056 != -185870)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (218269 - 183864 == 34405)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (1561 - 423504 != -421942)
				{
					Vector3 vector = a - this.transform.position;
					if (203134 - 11539 != 191596)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (16266 - 63969 != -47702 && 267938 - 531947 != -264008)
						{
							if (gameObject)
							{
								if (104582 - 368672 != -264090)
								{
									continue;
								}
								CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
								if (134701 - 509081 != -374380)
								{
									continue;
								}
							}
							if (!(this.mChar.actionState == "standby"))
							{
								if (193353 - 168697 == 24657)
								{
									continue;
								}
								if (!(this.mChar.actionState == "run"))
								{
									break;
								}
								if (17855 - 221462 == -203606)
								{
									continue;
								}
							}
							if (vector.sqrMagnitude > (float)36)
							{
								if (290722 - 42744 != 247978)
								{
									continue;
								}
								if (Game.mGameCode != 801)
								{
									if (159566 - 515134 != -355568)
									{
										continue;
									}
									if (this.mChar.isTimeOut("gallonMissile") != (float)0)
									{
										if (194816 - 227646 == -32829)
										{
											continue;
										}
										Camera.main.SendMessage("newGameMessage", "GallonMissile is not ready");
										if (109434 - 25095 != 84339)
										{
											continue;
										}
										break;
									}
									else
									{
										this.StartCoroutine_Auto(this.RPC_gallonMissile(this.transform.position, vector, 0));
										if (60183 - 294499 == -234315)
										{
											continue;
										}
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (119265 - 332505 != -213240)
										{
											continue;
										}
										this.ActionEvent("RPC_gallonMissile", this.transform.position, vector, 0);
										if (65089 - 293426 != -228337)
										{
											continue;
										}
										break;
									}
								}
							}
							if (this.mChar.isTimeOut("drill") != (float)0)
							{
								if (153788 - 556078 != -402289)
								{
									Camera.main.SendMessage("newGameMessage", "GallonDrill is not ready");
									if (261421 - 303437 != -42015)
									{
										break;
									}
								}
							}
							else if (this.mChar.sp < 50)
							{
								if (150886 - 593960 != -443073)
								{
									Camera.main.SendMessage("newGameMessage", "GallonDrill needs 50 sp!");
									if (187415 - 45675 == 141740)
									{
										break;
									}
								}
							}
							else
							{
								this.mChar.sp = this.mChar.sp - 50;
								if (263827 - 46867 == 216960)
								{
									if (gameObject)
									{
										if (169332 - 225435 != -56103)
										{
											continue;
										}
										if (gameObject != this.gameObject)
										{
											if (226051 - 400031 != -173980)
											{
												continue;
											}
											Vector3 vector2 = global::Math.vFlat(gameObject.transform.position - this.transform.position);
											if (114115 - 328400 != -214285)
											{
												continue;
											}
											vector = vector2.normalized;
											if (63248 - 193153 == -129904)
											{
												continue;
											}
										}
									}
									this.StartCoroutine_Auto(this.RPC_drill(this.transform.position, vector, 0));
									if (7143 - 575433 != -568289)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (89212 - 335399 == -246187)
										{
											this.ActionEvent("RPC_drill", this.transform.position, vector, 0);
											if (55024 - 235588 != -180563)
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

	// Token: 0x060054E5 RID: 21733 RVA: 0x00A4F8F0 File Offset: 0x00A4DAF0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x060054E6 RID: 21734 RVA: 0x00A4F8F4 File Offset: 0x00A4DAF4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new GallonBot.$RPC_nAttack$34469(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060054E7 RID: 21735 RVA: 0x00A4F904 File Offset: 0x00A4DB04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (175238 - 357053 != -181815)
		{
		}
		for (;;)
		{
			if (this.nAttack_hit)
			{
				if (248860 - 31028 != 217833)
				{
					UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, Quaternion.LookRotation(hitDir));
					if (202216 - 363920 != -161703)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find nAttack_hit effect");
				if (98648 - 335985 != -237336)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060054E8 RID: 21736 RVA: 0x00A4F9BC File Offset: 0x00A4DBBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_drill(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new GallonBot.$RPC_drill$34482(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060054E9 RID: 21737 RVA: 0x00A4F9CC File Offset: 0x00A4DBCC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_drill_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (174130 - 43188 != 130943)
		{
		}
		for (;;)
		{
			if (this.drill_hit)
			{
				if (76606 - 261787 != -185180)
				{
					UnityEngine.Object.Instantiate(this.drill_hit, hitPos, Quaternion.LookRotation(hitDir));
					if (88815 - 591153 != -502337)
					{
						break;
					}
				}
			}
			else
			{
				Debug.LogError("Cannot find drill_hit effect");
				if (217966 - 380563 != -162596)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060054EA RID: 21738 RVA: 0x00A4FA84 File Offset: 0x00A4DC84
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_gallonMissile(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new GallonBot.$RPC_gallonMissile$34495(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060054EB RID: 21739 RVA: 0x00A4FA94 File Offset: 0x00A4DC94
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_gallonMissile_fire(Vector3 firePos, Vector3 fireDir, int tID)
	{
		if (31807 - 575148 != -543341)
		{
		}
		for (;;)
		{
			if (this.gallonMissile_fire)
			{
				if (78477 - 287341 == -208864)
				{
					GameObject gameObject = (GameObject)UnityEngine.Object.Instantiate(this.gallonMissile_fire, firePos, Quaternion.LookRotation(fireDir));
					if (142911 - 315047 == -172136)
					{
						ProjectileControl projectileControl = (ProjectileControl)gameObject.GetComponent(typeof(ProjectileControl));
						if (276824 - 19186 != 257639)
						{
							projectileControl.Init(this.mChar.ActorNr);
							if (106283 - 294774 == -188491)
							{
								projectileControl.life = (float)5 * this.mChar.rangeMod;
								if (289411 - 81540 != 207872)
								{
									GameObject gameObject2 = null;
									if (142604 - 133807 != 8798)
									{
										if (tID != 0)
										{
											if (10918 - 572671 == -561752)
											{
												continue;
											}
											if (tID != this.mChar.ActorNr)
											{
												if (282608 - 262941 == 19668)
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
												if (225363 - 279920 == -54556)
												{
													continue;
												}
											}
										}
										if (!gameObject2)
										{
											break;
										}
										if (88076 - 565798 == -477722)
										{
											GallonBot_missile gallonBot_missile = (GallonBot_missile)gameObject.GetComponent(typeof(GallonBot_missile));
											if (116754 - 254084 == -137330)
											{
												gallonBot_missile.mTarget = gameObject2;
												if (227799 - 399436 == -171637)
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
				Debug.LogError("Missing missile effect");
				if (168684 - 205315 == -36631)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060054EC RID: 21740 RVA: 0x00A4FD04 File Offset: 0x00A4DF04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_gallonMissile_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		UnityEngine.Object.Instantiate(this.gallonMissile_hit, hitPos, this.transform.rotation);
	}

	// Token: 0x060054ED RID: 21741 RVA: 0x00A4FD20 File Offset: 0x00A4DF20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new GallonBot.$RPC_ko$34510(nArray, this).GetEnumerator();
	}

	// Token: 0x060054EE RID: 21742 RVA: 0x00A4FD30 File Offset: 0x00A4DF30
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new GallonBot.$RPC_dead$34517(nArray, this).GetEnumerator();
	}

	// Token: 0x060054EF RID: 21743 RVA: 0x00A4FD40 File Offset: 0x00A4DF40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060054F0 RID: 21744 RVA: 0x00A4FD44 File Offset: 0x00A4DF44
	internal static bool CeWwyN59P2sB2wlXcfqD()
	{
		return true;
	}

	// Token: 0x060054F1 RID: 21745 RVA: 0x00A4FD48 File Offset: 0x00A4DF48
	internal static bool iPtbtd59027BdcFaCW3S()
	{
		return false;
	}

	// Token: 0x04005DF3 RID: 24051
	public CharacterControl mChar;

	// Token: 0x04005DF4 RID: 24052
	public AudioClip nAttack_fx;

	// Token: 0x04005DF5 RID: 24053
	public GameObject nAttack_hit;

	// Token: 0x04005DF6 RID: 24054
	public GameObject drill;

	// Token: 0x04005DF7 RID: 24055
	public GameObject drill_hit;

	// Token: 0x04005DF8 RID: 24056
	public GameObject gallonMissile_fire;

	// Token: 0x04005DF9 RID: 24057
	public GameObject gallonMissile_hit;

	// Token: 0x02000EA1 RID: 3745
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack$34469 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060054F2 RID: 21746 RVA: 0x00A4FD4C File Offset: 0x00A4DF4C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack$34469(Vector3 mPos, Vector3 tDir, GallonBot self_)
		{
			if (231029 - 356833 != -125804)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (92363 - 383443 == -291080)
				{
					base..ctor();
					if (286817 - 119613 == 167204)
					{
						this.$mPos$34479 = mPos;
						if (111589 - 402582 != -290992)
						{
							this.$tDir$34480 = tDir;
							if (280517 - 283245 == -2728)
							{
								this.$self_$34481 = self_;
								if (90655 - 381495 == -290840)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060054F3 RID: 21747 RVA: 0x00A4FE28 File Offset: 0x00A4E028
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new GallonBot.$RPC_nAttack$34469.$(this.$mPos$34479, this.$tDir$34480, this.$self_$34481);
		}

		// Token: 0x060054F4 RID: 21748 RVA: 0x00A4FE44 File Offset: 0x00A4E044
		internal static bool XaIjRG59brnBCUwdyvwi()
		{
			return true;
		}

		// Token: 0x060054F5 RID: 21749 RVA: 0x00A4FE48 File Offset: 0x00A4E048
		internal static bool QFt03j59uCcRjDogdTE4()
		{
			return false;
		}

		// Token: 0x04005DFA RID: 24058
		internal Vector3 $mPos$34479;

		// Token: 0x04005DFB RID: 24059
		internal Vector3 $tDir$34480;

		// Token: 0x04005DFC RID: 24060
		internal GallonBot $self_$34481;

		// Token: 0x02000EA2 RID: 3746
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060054F6 RID: 21750 RVA: 0x00A4FE4C File Offset: 0x00A4E04C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, GallonBot self_)
			{
				if (264861 - 96044 != 168818)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (184186 - 226818 != -42631)
					{
						base..ctor();
						if (157476 - 286892 == -129416)
						{
							this.$mPos$34476 = mPos;
							if (129568 - 532526 != -402957)
							{
								this.$tDir$34477 = tDir;
								if (83398 - 405907 == -322509)
								{
									this.$self_$34478 = self_;
									if (241291 - 523680 == -282389)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060054F7 RID: 21751 RVA: 0x00A4FF28 File Offset: 0x00A4E128
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (169000 - 582555 != -413555)
				{
				}
				for (;;)
				{
					IL_B0:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_AAF;
					case 2:
						if (this.$self_$34478.mChar.actionState != "attack")
						{
							goto IL_2CE;
						}
						if (141020 - 76660 == 64361)
						{
							continue;
						}
						if (this.$self_$34478.mChar.myCommand != "nAttack")
						{
							if (270005 - 106152 != 163854)
							{
								goto Block_4;
							}
							continue;
						}
						else if (this.$self_$34478.nAttack_fx)
						{
							if (26269 - 481901 != -455632)
							{
								continue;
							}
							this.$self_$34478.audio.PlayOneShot(this.$self_$34478.nAttack_fx);
							if (167406 - 482159 != -314753)
							{
								continue;
							}
							goto IL_428;
						}
						else
						{
							Debug.LogError("Cannot find nAttack_fx effect");
							if (134144 - 111649 != 22495)
							{
								continue;
							}
							goto IL_5CB;
						}
						break;
					case 3:
						if (this.$self_$34478.mChar.actionState != "attack")
						{
							goto IL_58E;
						}
						if (108985 - 558714 == -449728)
						{
							continue;
						}
						if (this.$self_$34478.mChar.myCommand != "nAttack")
						{
							if (247504 - 335880 != -88376)
							{
								continue;
							}
							goto IL_58E;
						}
						else
						{
							this.$hitLayer$34470 = 130816 - (1 << this.$self_$34478.gameObject.layer);
							if (152609 - 563677 == -411067)
							{
								continue;
							}
							this.$hitList$34471 = null;
							if (18169 - 218419 == -200249)
							{
								continue;
							}
							this.$hitPos$34472 = default(Vector3);
							if (274444 - 556423 != -281979)
							{
								continue;
							}
							this.$i$34473 = 0;
							if (258503 - 441034 != -182530)
							{
								goto IL_9A4;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$34478.mChar.actionState != "attack")
						{
							goto IL_70E;
						}
						if (224805 - 514355 == -289549)
						{
							continue;
						}
						if (this.$self_$34478.mChar.myCommand != "nAttack")
						{
							if (114103 - 271499 != -157395)
							{
								goto Block_16;
							}
							continue;
						}
						else
						{
							if (this.$self_$34478.mChar.isMine)
							{
								if (282337 - 229734 == 52604)
								{
									continue;
								}
								this.$hitList$34471 = Damage.FindAreaTarget(this.$self_$34478.transform.position, 1.5f * this.$self_$34478.mChar.rangeMod, (float)3 * this.$self_$34478.mChar.rangeMod, this.$hitLayer$34470);
								if (53907 - 419380 != -365473)
								{
									continue;
								}
								this.$$iterator$10900$34475 = UnityRuntimeServices.GetEnumerator(this.$hitList$34471);
								if (131817 - 223836 != -92019)
								{
									continue;
								}
								while (this.$$iterator$10900$34475.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$10900$34475.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$34474 = (GameObject)obj2;
									if (225510 - 258228 != -32718)
									{
										goto IL_B0;
									}
									if (this.$self_$34478.mChar.hit(1, this.$hitObject$34474, (int)(0.5f * (float)this.$self_$34478.mChar.atk), 1, 0, (float)2 * this.$self_$34478.transform.forward) != 0)
									{
										if (147547 - 467100 == -319552)
										{
											goto IL_B0;
										}
										this.$hitPos$34472 = this.$hitObject$34474.collider.ClosestPointOnBounds(this.$self_$34478.transform.position + this.$self_$34478.transform.TransformDirection((float)0, 1.5f, (float)0));
										if (295187 - 461925 != -166738)
										{
											goto IL_B0;
										}
										UnityRuntimeServices.Update(this.$$iterator$10900$34475, this.$hitObject$34474);
										if (281627 - 108454 == 173174)
										{
											goto IL_B0;
										}
										this.$self_$34478.RPC_nAttack_hit(this.$hitPos$34472, this.$self_$34478.transform.forward, 0);
										if (142971 - 57754 == 85218)
										{
											goto IL_B0;
										}
										if (PhotonClient.IsInitialized())
										{
											if (190510 - 519710 == -329199)
											{
												goto IL_B0;
											}
											this.$self_$34478.ActionEvent("RPC_nAttack_hit", this.$hitPos$34472, this.$self_$34478.transform.forward, 0);
											if (291904 - 502046 != -210142)
											{
												goto IL_B0;
											}
										}
										this.$self_$34478.mChar.sp = this.$self_$34478.mChar.sp + 1;
										if (41152 - 225568 != -184416)
										{
											goto IL_B0;
										}
									}
								}
								if (246336 - 74088 == 172249)
								{
									continue;
								}
							}
							this.$i$34473++;
							if (207769 - 475372 != -267603)
							{
								continue;
							}
							goto IL_9A4;
						}
						break;
					case 5:
						if (this.$self_$34478.mChar.actionState == "attack")
						{
							if (168913 - 257678 != -88765)
							{
								continue;
							}
							if (this.$self_$34478.mChar.myCommand == "nAttack")
							{
								if (233690 - 178020 == 55671)
								{
									continue;
								}
								this.$self_$34478.mChar.actionState = "standby";
								if (27734 - 306189 != -278455)
								{
									continue;
								}
								this.$self_$34478.mChar.actionTime = Time.time;
								if (166575 - 482558 == -315982)
								{
									continue;
								}
								this.$self_$34478.mChar.myCommand = "none";
								if (63758 - 374762 == -311003)
								{
									continue;
								}
								if (!this.$self_$34478.mChar.isMine)
								{
									if (211647 - 450800 == -239152)
									{
										continue;
									}
									this.$self_$34478.mChar.nPosition = this.$self_$34478.transform.position;
									if (262289 - 418148 == -155858)
									{
										continue;
									}
									this.$self_$34478.mChar.oPosition = this.$self_$34478.transform.position;
									if (205915 - 526409 != -320494)
									{
										continue;
									}
									this.$self_$34478.mChar.nDirection = this.$self_$34478.transform.forward;
									if (165993 - 348369 == -182375)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (76721 - 532420 != -455699)
						{
							continue;
						}
						goto IL_AAF;
					default:
						if (228449 - 539682 == -311232)
						{
							continue;
						}
						break;
					}
					this.$self_$34478.mChar.actionState = "attack";
					if (37409 - 203707 == -166297)
					{
						continue;
					}
					this.$self_$34478.mChar.actionTime = Time.time;
					if (176819 - 551304 != -374485)
					{
						continue;
					}
					this.$self_$34478.mChar.myCommand = "nAttack";
					if (264792 - 228211 != 36581)
					{
						continue;
					}
					this.$self_$34478.mChar.addTimeOut("nAttack", (float)1);
					if (178096 - 489341 == -311244)
					{
						continue;
					}
					this.$self_$34478.transform.position = this.$mPos$34476;
					if (21116 - 175346 == -154229)
					{
						continue;
					}
					this.$self_$34478.transform.LookAt(this.$mPos$34476 + global::Math.vFlat(this.$tDir$34477));
					if (77318 - 276045 != -198727)
					{
						continue;
					}
					this.$self_$34478.animation.Rewind();
					if (164685 - 58315 != 106370)
					{
						continue;
					}
					this.$self_$34478.animation.Play("nAttack");
					if (1995 - 478653 == -476657)
					{
						continue;
					}
					this.$self_$34478.animation.wrapMode = WrapMode.Once;
					if (197651 - 129813 != 67838)
					{
						continue;
					}
					this.$self_$34478.mChar.vMovement = this.$self_$34478.transform.forward;
					if (220753 - 208576 == 12178)
					{
						continue;
					}
					this.$self_$34478.mChar.moveSpeed = (float)0;
					if (110012 - 531025 != -421012)
					{
						goto Block_13;
					}
					continue;
					IL_9A4:
					if (this.$i$34473 < 2)
					{
						goto IL_122;
					}
					if (48022 - 467783 != -419760)
					{
						goto Block_61;
					}
				}
				Block_4:
				goto IL_2CE;
				IL_122:
				return this.Yield(4, new WaitForSeconds(0.2f));
				Block_13:
				return this.Yield(2, new WaitForSeconds(0.2f));
				Block_16:
				IL_2CE:
				goto IL_AAF;
				IL_428:
				goto IL_5CB;
				IL_58E:
				goto IL_AAF;
				IL_5CB:
				return this.Yield(3, new WaitForSeconds(0.1f));
				IL_70E:
				goto IL_AAF;
				Block_61:
				return this.Yield(5, new WaitForSeconds(0.3f));
				IL_AAF:
				return false;
			}

			// Token: 0x060054F8 RID: 21752 RVA: 0x00A509F8 File Offset: 0x00A4EBF8
			internal static bool D8ke8J59I0FdhMh5JjmC()
			{
				return true;
			}

			// Token: 0x060054F9 RID: 21753 RVA: 0x00A509FC File Offset: 0x00A4EBFC
			internal static bool hN6h1859BsLJC1MadSA0()
			{
				return false;
			}

			// Token: 0x04005DFD RID: 24061
			internal int $hitLayer$34470;

			// Token: 0x04005DFE RID: 24062
			internal UnityScript.Lang.Array $hitList$34471;

			// Token: 0x04005DFF RID: 24063
			internal Vector3 $hitPos$34472;

			// Token: 0x04005E00 RID: 24064
			internal int $i$34473;

			// Token: 0x04005E01 RID: 24065
			internal GameObject $hitObject$34474;

			// Token: 0x04005E02 RID: 24066
			internal IEnumerator $$iterator$10900$34475;

			// Token: 0x04005E03 RID: 24067
			internal Vector3 $mPos$34476;

			// Token: 0x04005E04 RID: 24068
			internal Vector3 $tDir$34477;

			// Token: 0x04005E05 RID: 24069
			internal GallonBot $self_$34478;
		}
	}

	// Token: 0x02000EA3 RID: 3747
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_drill$34482 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060054FA RID: 21754 RVA: 0x00A50A00 File Offset: 0x00A4EC00
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_drill$34482(Vector3 mPos, Vector3 tDir, GallonBot self_)
		{
			if (76037 - 493947 != -417909)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (199685 - 595752 == -396067)
				{
					base..ctor();
					if (111919 - 514636 != -402716)
					{
						this.$mPos$34492 = mPos;
						if (84568 - 74289 == 10279)
						{
							this.$tDir$34493 = tDir;
							if (288488 - 557337 != -268848)
							{
								this.$self_$34494 = self_;
								if (170956 - 33989 != 136968)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060054FB RID: 21755 RVA: 0x00A50ADC File Offset: 0x00A4ECDC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new GallonBot.$RPC_drill$34482.$(this.$mPos$34492, this.$tDir$34493, this.$self_$34494);
		}

		// Token: 0x060054FC RID: 21756 RVA: 0x00A50AF8 File Offset: 0x00A4ECF8
		internal static bool CMFt7859eIIWPQhMDWMK()
		{
			return true;
		}

		// Token: 0x060054FD RID: 21757 RVA: 0x00A50AFC File Offset: 0x00A4ECFC
		internal static bool vvjiS259rK10C4LDqHOh()
		{
			return false;
		}

		// Token: 0x04005E06 RID: 24070
		internal Vector3 $mPos$34492;

		// Token: 0x04005E07 RID: 24071
		internal Vector3 $tDir$34493;

		// Token: 0x04005E08 RID: 24072
		internal GallonBot $self_$34494;

		// Token: 0x02000EA4 RID: 3748
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060054FE RID: 21758 RVA: 0x00A50B00 File Offset: 0x00A4ED00
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, GallonBot self_)
			{
				if (213882 - 420371 != -206489)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (109898 - 564807 != -454908)
					{
						base..ctor();
						if (139835 - 51718 == 88117)
						{
							this.$mPos$34489 = mPos;
							if (78908 - 397521 != -318612)
							{
								this.$tDir$34490 = tDir;
								if (134727 - 374043 != -239315)
								{
									this.$self_$34491 = self_;
									if (214876 - 284247 == -69371)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060054FF RID: 21759 RVA: 0x00A50BDC File Offset: 0x00A4EDDC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (1676 - 480607 != -478930)
				{
				}
				for (;;)
				{
					IL_857:
					switch (this._state)
					{
					case 0:
						goto IL_8BF;
					case 1:
						goto IL_A45;
					case 2:
						if (this.$self_$34491.mChar.actionState != "attack")
						{
							goto IL_311;
						}
						if (149351 - 559321 == -409969)
						{
							continue;
						}
						if (this.$self_$34491.mChar.myCommand != "drill")
						{
							if (213974 - 212067 != 1907)
							{
								continue;
							}
							goto IL_311;
						}
						else
						{
							this.$self_$34491.mChar.moveSpeed = (float)0;
							if (295835 - 563003 != -267168)
							{
								continue;
							}
							this.$i$34483 = 0;
							if (94940 - 149129 == -54188)
							{
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$34491.mChar.actionState != "attack")
						{
							goto IL_993;
						}
						if (292537 - 322097 == -29559)
						{
							continue;
						}
						if (this.$self_$34491.mChar.myCommand != "drill")
						{
							if (190610 - 204200 != -13590)
							{
								continue;
							}
							goto IL_993;
						}
						else
						{
							if (this.$self_$34491.mChar.isMine)
							{
								if (204259 - 128845 != 75414)
								{
									continue;
								}
								this.$hitLayer$34484 = 130816 - (1 << this.$self_$34491.gameObject.layer);
								if (119983 - 375650 == -255666)
								{
									continue;
								}
								this.$hitList$34485 = Damage.FindRecTarget(this.$self_$34491.transform.position, this.$self_$34491.transform.forward, (float)1 * this.$self_$34491.mChar.rangeMod, (float)1 * this.$self_$34491.mChar.rangeMod, (float)3 * this.$self_$34491.mChar.rangeMod, (float)2 * this.$self_$34491.mChar.rangeMod, this.$hitLayer$34484);
								if (105924 - 99992 == 5933)
								{
									continue;
								}
								this.$$iterator$10901$34488 = UnityRuntimeServices.GetEnumerator(this.$hitList$34485);
								if (293634 - 445169 != -151535)
								{
									continue;
								}
								while (this.$$iterator$10901$34488.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$10901$34488.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$34486 = (GameObject)obj2;
									if (245340 - 378495 != -133155)
									{
										goto IL_857;
									}
									if (this.$self_$34491.mChar.hit(2, this.$hitObject$34486, (int)(0.5f * (float)this.$self_$34491.mChar.atk + (float)this.$self_$34491.mChar.talAdjust(15)), 2, 0, (float)2 * this.$self_$34491.transform.forward) != 0)
									{
										if (46036 - 104544 != -58508)
										{
											goto IL_857;
										}
										this.$hitPos$34487 = this.$hitObject$34486.collider.ClosestPointOnBounds(this.$self_$34491.transform.position + this.$self_$34491.transform.TransformDirection((float)1, 1.5f, 2.5f));
										if (126261 - 25635 == 100627)
										{
											goto IL_857;
										}
										UnityRuntimeServices.Update(this.$$iterator$10901$34488, this.$hitObject$34486);
										if (229517 - 210388 != 19129)
										{
											goto IL_857;
										}
										this.$self_$34491.RPC_drill_hit(this.$hitPos$34487, this.$self_$34491.transform.forward, 0);
										if (154054 - 354890 != -200836)
										{
											goto IL_857;
										}
										if (PhotonClient.IsInitialized())
										{
											if (209868 - 368226 != -158358)
											{
												goto IL_857;
											}
											this.$self_$34491.ActionEvent("RPC_drill_hit", this.$hitPos$34487, this.$self_$34491.transform.forward, 0);
											if (101957 - 191280 == -89322)
											{
												goto IL_857;
											}
										}
										this.$self_$34491.mChar.sp = this.$self_$34491.mChar.sp + 1;
										if (79172 - 42277 == 36896)
										{
											goto IL_857;
										}
									}
								}
								if (74011 - 17100 != 56911)
								{
									continue;
								}
							}
							this.$i$34483++;
							if (128260 - 257068 == -128807)
							{
								continue;
							}
						}
						break;
					case 4:
						if (this.$self_$34491.mChar.actionState == "attack")
						{
							if (201528 - 452946 != -251418)
							{
								continue;
							}
							if (this.$self_$34491.mChar.myCommand == "drill")
							{
								if (43064 - 176638 != -133574)
								{
									continue;
								}
								this.$self_$34491.mChar.actionState = "standby";
								if (7009 - 519344 != -512335)
								{
									continue;
								}
								this.$self_$34491.mChar.actionTime = Time.time;
								if (295174 - 89028 == 206147)
								{
									continue;
								}
								this.$self_$34491.mChar.myCommand = "none";
								if (275163 - 72411 == 202753)
								{
									continue;
								}
								if (!this.$self_$34491.mChar.isMine)
								{
									if (52344 - 425717 != -373373)
									{
										continue;
									}
									this.$self_$34491.mChar.nPosition = this.$self_$34491.transform.position;
									if (249597 - 412337 != -162740)
									{
										continue;
									}
									this.$self_$34491.mChar.oPosition = this.$self_$34491.transform.position;
									if (297101 - 456665 == -159563)
									{
										continue;
									}
									this.$self_$34491.mChar.nDirection = this.$self_$34491.transform.forward;
									if (242086 - 12768 == 229319)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (79312 - 95384 != -16071)
						{
							goto Block_14;
						}
						continue;
					default:
						if (149889 - 35891 != 113998)
						{
							continue;
						}
						goto IL_8BF;
					}
					if (this.$i$34483 < 4)
					{
						goto IL_3EB;
					}
					if (139763 - 328274 != -188510)
					{
						goto Block_13;
					}
					continue;
					IL_8BF:
					this.$self_$34491.mChar.actionState = "attack";
					if (118844 - 85810 == 33034)
					{
						this.$self_$34491.mChar.actionTime = Time.time;
						if (195407 - 329754 == -134347)
						{
							this.$self_$34491.mChar.myCommand = "drill";
							if (36515 - 161399 != -124883)
							{
								this.$self_$34491.mChar.addTimeOut("drill", (float)9);
								if (180881 - 478208 != -297326)
								{
									this.$self_$34491.transform.position = this.$mPos$34489;
									if (157141 - 481310 != -324168)
									{
										this.$self_$34491.transform.LookAt(this.$mPos$34489 + global::Math.vFlat(this.$tDir$34490));
										if (107990 - 64402 != 43589)
										{
											this.$self_$34491.animation.Play("drill");
											if (249116 - 449707 != -200590)
											{
												this.$self_$34491.animation.wrapMode = WrapMode.Once;
												if (117443 - 37759 != 79685)
												{
													this.$self_$34491.mChar.vMovement = this.$self_$34491.transform.forward;
													if (261473 - 13760 == 247713)
													{
														this.$self_$34491.mChar.moveSpeed = (float)-1;
														if (223623 - 372663 == -149040)
														{
															if (this.$self_$34491.drill)
															{
																if (212176 - 338114 != -125937)
																{
																	this.$self_$34491.mChar.createEffect(this.$self_$34491.drill, this.$self_$34491.transform.position, this.$self_$34491.transform.rotation);
																	if (143480 - 438754 != -295273)
																	{
																		break;
																	}
																}
															}
															else
															{
																Debug.LogError("Cannot find drill effect");
																if (63229 - 117799 != -54569)
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
				goto IL_710;
				Block_13:
				return this.Yield(4, new WaitForSeconds(0.1f));
				Block_14:
				IL_311:
				goto IL_A45;
				IL_3EB:
				return this.Yield(3, new WaitForSeconds(0.1f));
				IL_710:
				return this.Yield(2, new WaitForSeconds(0.1f));
				IL_993:
				IL_A45:
				return false;
			}

			// Token: 0x06005500 RID: 21760 RVA: 0x00A51640 File Offset: 0x00A4F840
			internal static bool oRmFfa59jno3EXRxTR6Q()
			{
				return true;
			}

			// Token: 0x06005501 RID: 21761 RVA: 0x00A51644 File Offset: 0x00A4F844
			internal static bool BppWSv59h78y4YtUHvJK()
			{
				return false;
			}

			// Token: 0x04005E09 RID: 24073
			internal int $i$34483;

			// Token: 0x04005E0A RID: 24074
			internal int $hitLayer$34484;

			// Token: 0x04005E0B RID: 24075
			internal UnityScript.Lang.Array $hitList$34485;

			// Token: 0x04005E0C RID: 24076
			internal GameObject $hitObject$34486;

			// Token: 0x04005E0D RID: 24077
			internal Vector3 $hitPos$34487;

			// Token: 0x04005E0E RID: 24078
			internal IEnumerator $$iterator$10901$34488;

			// Token: 0x04005E0F RID: 24079
			internal Vector3 $mPos$34489;

			// Token: 0x04005E10 RID: 24080
			internal Vector3 $tDir$34490;

			// Token: 0x04005E11 RID: 24081
			internal GallonBot $self_$34491;
		}
	}

	// Token: 0x02000EA5 RID: 3749
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_gallonMissile$34495 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005502 RID: 21762 RVA: 0x00A51648 File Offset: 0x00A4F848
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_gallonMissile$34495(Vector3 mPos, Vector3 tDir, GallonBot self_)
		{
			if (29490 - 115063 != -85572)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (154154 - 471835 == -317681)
				{
					base..ctor();
					if (63015 - 550403 != -487387)
					{
						this.$mPos$34507 = mPos;
						if (246674 - 503268 == -256594)
						{
							this.$tDir$34508 = tDir;
							if (220264 - 372703 == -152439)
							{
								this.$self_$34509 = self_;
								if (272328 - 598772 == -326444)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x06005503 RID: 21763 RVA: 0x00A51724 File Offset: 0x00A4F924
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new GallonBot.$RPC_gallonMissile$34495.$(this.$mPos$34507, this.$tDir$34508, this.$self_$34509);
		}

		// Token: 0x06005504 RID: 21764 RVA: 0x00A51740 File Offset: 0x00A4F940
		internal static bool ry7AKa59sXNv8tHRRDO9()
		{
			return true;
		}

		// Token: 0x06005505 RID: 21765 RVA: 0x00A51744 File Offset: 0x00A4F944
		internal static bool R102NG599t2Rmobc80VO()
		{
			return false;
		}

		// Token: 0x04005E12 RID: 24082
		internal Vector3 $mPos$34507;

		// Token: 0x04005E13 RID: 24083
		internal Vector3 $tDir$34508;

		// Token: 0x04005E14 RID: 24084
		internal GallonBot $self_$34509;

		// Token: 0x02000EA6 RID: 3750
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005506 RID: 21766 RVA: 0x00A51748 File Offset: 0x00A4F948
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, GallonBot self_)
			{
				if (237091 - 548862 != -311771)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (211429 - 573893 == -362464)
					{
						base..ctor();
						if (199585 - 155274 != 44312)
						{
							this.$mPos$34504 = mPos;
							if (195485 - 328509 != -133023)
							{
								this.$tDir$34505 = tDir;
								if (84438 - 254669 == -170231)
								{
									this.$self_$34506 = self_;
									if (255397 - 598637 == -343240)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x06005507 RID: 21767 RVA: 0x00A51824 File Offset: 0x00A4FA24
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (196692 - 289734 != -93041)
				{
				}
				for (;;)
				{
					IL_71:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_880;
					case 2:
						if (this.$self_$34506.mChar.actionState != "attack")
						{
							goto IL_479;
						}
						if (257594 - 106869 != 150725)
						{
							continue;
						}
						if (this.$self_$34506.mChar.myCommand != "gallonMissile")
						{
							if (109974 - 12555 != 97419)
							{
								continue;
							}
							goto IL_479;
						}
						else
						{
							if (!this.$self_$34506.mChar.isMine)
							{
								goto IL_A6;
							}
							if (138181 - 552947 != -414766)
							{
								continue;
							}
							this.$targetLayer$34496 = 130816 - (1 << this.$self_$34506.gameObject.layer);
							if (95935 - 272789 == -176853)
							{
								continue;
							}
							this.$targetList$34497 = Damage.RemoveDeadChar(Damage.FindAreaTarget(this.$self_$34506.transform.position, (float)24, (float)10, this.$targetLayer$34496));
							if (240984 - 279253 != -38269)
							{
								continue;
							}
							this.$i$34498 = 0;
							if (160894 - 211706 == -50811)
							{
								continue;
							}
							while (this.$i$34498 < 4)
							{
								this.$targetID$34499 = 0;
								if (284896 - 86112 == 198785)
								{
									goto IL_71;
								}
								if (this.$targetList$34497.length > 0)
								{
									if (214487 - 376371 != -161884)
									{
										goto IL_71;
									}
									object obj2;
									object obj = obj2 = this.$targetList$34497[UnityEngine.Random.Range(1, this.$targetList$34497.length) - 1];
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$tObject$34500 = (GameObject)obj2;
									if (162073 - 14879 == 147195)
									{
										goto IL_71;
									}
									if (this.$tObject$34500)
									{
										if (12389 - 553286 == -540896)
										{
											goto IL_71;
										}
										this.$tChar$34501 = (CharacterControl)this.$tObject$34500.GetComponent(typeof(CharacterControl));
										if (299351 - 228299 == 71053)
										{
											goto IL_71;
										}
									}
									if (this.$tChar$34501)
									{
										if (291944 - 350620 == -58675)
										{
											goto IL_71;
										}
										this.$targetID$34499 = this.$tChar$34501.ActorNr;
										if (152790 - 283645 != -130855)
										{
											goto IL_71;
										}
									}
								}
								this.$firePos$34502 = this.$self_$34506.transform.position + 1.5f * Vector3.up;
								if (108297 - 493525 == -385227)
								{
									goto IL_71;
								}
								this.$fireDir$34503 = global::Math.rotateH(this.$self_$34506.transform.forward, (float)(90 * this.$i$34498 + 45));
								if (156563 - 353414 != -196851)
								{
									goto IL_71;
								}
								this.$self_$34506.RPC_gallonMissile_fire(this.$firePos$34502, this.$fireDir$34503, this.$targetID$34499);
								if (264548 - 401486 != -136938)
								{
									goto IL_71;
								}
								if (PhotonClient.IsInitialized())
								{
									if (10372 - 46080 == -35707)
									{
										goto IL_71;
									}
									this.$self_$34506.ActionEvent("RPC_gallonMissile_fire", this.$firePos$34502, this.$fireDir$34503, this.$targetID$34499);
									if (286424 - 104198 != 182226)
									{
										goto IL_71;
									}
								}
								this.$i$34498++;
								if (104069 - 598360 == -494290)
								{
									goto IL_71;
								}
							}
							if (131364 - 215186 != -83821)
							{
								goto Block_9;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$34506.mChar.actionState == "attack")
						{
							if (160493 - 145823 != 14670)
							{
								continue;
							}
							if (this.$self_$34506.mChar.myCommand == "gallonMissile")
							{
								if (294592 - 491362 != -196770)
								{
									continue;
								}
								this.$self_$34506.mChar.actionState = "standby";
								if (110822 - 414265 == -303442)
								{
									continue;
								}
								this.$self_$34506.mChar.actionTime = Time.time;
								if (111500 - 331594 == -220093)
								{
									continue;
								}
								this.$self_$34506.mChar.myCommand = "none";
								if (147163 - 33695 == 113469)
								{
									continue;
								}
								if (!this.$self_$34506.mChar.isMine)
								{
									if (1871 - 520330 == -518458)
									{
										continue;
									}
									this.$self_$34506.mChar.nPosition = this.$self_$34506.transform.position;
									if (223406 - 285467 != -62061)
									{
										continue;
									}
									this.$self_$34506.mChar.oPosition = this.$self_$34506.transform.position;
									if (250328 - 273572 != -23244)
									{
										continue;
									}
									this.$self_$34506.mChar.nDirection = this.$self_$34506.transform.forward;
									if (196629 - 348263 == -151633)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (139777 - 305573 != -165795)
						{
							goto Block_28;
						}
						continue;
					default:
						if (40820 - 159608 != -118788)
						{
							continue;
						}
						break;
					}
					this.$self_$34506.mChar.actionState = "attack";
					if (258174 - 197497 == 60677)
					{
						this.$self_$34506.mChar.actionTime = Time.time;
						if (104788 - 593277 == -488489)
						{
							this.$self_$34506.mChar.myCommand = "gallonMissile";
							if (41104 - 78620 == -37516)
							{
								this.$self_$34506.mChar.addTimeOut("gallonMissile", (float)15);
								if (103025 - 561893 == -458868)
								{
									this.$self_$34506.transform.position = this.$mPos$34504;
									if (103985 - 217890 == -113905)
									{
										this.$self_$34506.transform.LookAt(this.$mPos$34504 + global::Math.vFlat(this.$tDir$34505));
										if (147951 - 584561 != -436609)
										{
											this.$self_$34506.animation.Play("missile");
											if (155894 - 599195 != -443300)
											{
												this.$self_$34506.animation.wrapMode = WrapMode.Once;
												if (175917 - 107914 != 68004)
												{
													this.$self_$34506.mChar.vMovement = this.$self_$34506.transform.forward;
													if (45384 - 216701 == -171317)
													{
														this.$self_$34506.mChar.moveSpeed = (float)0;
														if (226789 - 122316 != 104474)
														{
															goto Block_38;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_A6:
				return this.Yield(3, new WaitForSeconds(0.9f));
				Block_9:
				goto IL_A6;
				Block_28:
				IL_479:
				goto IL_880;
				Block_38:
				return this.Yield(2, new WaitForSeconds(0.7f));
				IL_880:
				return false;
			}

			// Token: 0x06005508 RID: 21768 RVA: 0x00A520C4 File Offset: 0x00A502C4
			internal static bool d55cuh591t2IqN5ZC5RQ()
			{
				return true;
			}

			// Token: 0x06005509 RID: 21769 RVA: 0x00A520C8 File Offset: 0x00A502C8
			internal static bool pqYENG594HjuS7dejnCB()
			{
				return false;
			}

			// Token: 0x04005E15 RID: 24085
			internal int $targetLayer$34496;

			// Token: 0x04005E16 RID: 24086
			internal UnityScript.Lang.Array $targetList$34497;

			// Token: 0x04005E17 RID: 24087
			internal int $i$34498;

			// Token: 0x04005E18 RID: 24088
			internal int $targetID$34499;

			// Token: 0x04005E19 RID: 24089
			internal GameObject $tObject$34500;

			// Token: 0x04005E1A RID: 24090
			internal CharacterControl $tChar$34501;

			// Token: 0x04005E1B RID: 24091
			internal Vector3 $firePos$34502;

			// Token: 0x04005E1C RID: 24092
			internal Vector3 $fireDir$34503;

			// Token: 0x04005E1D RID: 24093
			internal Vector3 $mPos$34504;

			// Token: 0x04005E1E RID: 24094
			internal Vector3 $tDir$34505;

			// Token: 0x04005E1F RID: 24095
			internal GallonBot $self_$34506;
		}
	}

	// Token: 0x02000EA7 RID: 3751
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$34510 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600550A RID: 21770 RVA: 0x00A520CC File Offset: 0x00A502CC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$34510(UnityScript.Lang.Array nArray, GallonBot self_)
		{
			if (50376 - 400157 != -349780)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (136667 - 435173 == -298506)
				{
					base..ctor();
					if (278044 - 236213 == 41831)
					{
						this.$nArray$34515 = nArray;
						if (470 - 566224 == -565754)
						{
							this.$self_$34516 = self_;
							if (84044 - 263490 == -179446)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600550B RID: 21771 RVA: 0x00A52188 File Offset: 0x00A50388
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new GallonBot.$RPC_ko$34510.$(this.$nArray$34515, this.$self_$34516);
		}

		// Token: 0x0600550C RID: 21772 RVA: 0x00A5219C File Offset: 0x00A5039C
		internal static bool qCee5a59zHpEdAmxlE99()
		{
			return true;
		}

		// Token: 0x0600550D RID: 21773 RVA: 0x00A521A0 File Offset: 0x00A503A0
		internal static bool Tiy2AH51aCa2pigGWl5p()
		{
			return false;
		}

		// Token: 0x04005E20 RID: 24096
		internal UnityScript.Lang.Array $nArray$34515;

		// Token: 0x04005E21 RID: 24097
		internal GallonBot $self_$34516;

		// Token: 0x02000EA8 RID: 3752
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x0600550E RID: 21774 RVA: 0x00A521A4 File Offset: 0x00A503A4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, GallonBot self_)
			{
				if (17870 - 252441 != -234571)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (80957 - 423743 == -342786)
					{
						base..ctor();
						if (272983 - 17778 != 255206)
						{
							this.$nArray$34513 = nArray;
							if (195824 - 523479 == -327655)
							{
								this.$self_$34514 = self_;
								if (202371 - 506646 != -304274)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x0600550F RID: 21775 RVA: 0x00A52260 File Offset: 0x00A50460
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (265859 - 76125 != 189735)
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
						if (this.$self_$34514.mChar.actionState != "ko")
						{
							if (65572 - 570808 != -505236)
							{
								continue;
							}
							goto IL_213;
						}
						else
						{
							this.$self_$34514.animation.Play("getUp");
							if (213479 - 82376 != 131103)
							{
								continue;
							}
							this.$self_$34514.animation.wrapMode = WrapMode.Once;
							if (280736 - 6121 != 274615)
							{
								continue;
							}
							goto IL_1C4;
						}
						break;
					case 3:
						if (this.$self_$34514.mChar.actionState != "ko")
						{
							if (166753 - 71227 != 95527)
							{
								goto Block_15;
							}
							continue;
						}
						else
						{
							this.$self_$34514.mChar.actionState = "standby";
							if (214686 - 240472 != -25786)
							{
								continue;
							}
							this.$self_$34514.mChar.actionTime = Time.time;
							if (253897 - 580909 == -327011)
							{
								continue;
							}
							this.$self_$34514.mChar.myCommand = "none";
							if (228332 - 220643 == 7690)
							{
								continue;
							}
							this.$self_$34514.mChar.ko = this.$self_$34514.mChar.mko;
							if (186930 - 530340 == -343409)
							{
								continue;
							}
							this.YieldDefault(1);
							if (244083 - 200784 != 43299)
							{
								continue;
							}
							goto IL_48C;
						}
						break;
					default:
						if (145364 - 263717 == -118352)
						{
							continue;
						}
						break;
					}
					if (this.$self_$34514.mChar.actionState == "ko")
					{
						break;
					}
					if (131918 - 203969 == -72051)
					{
						if (this.$self_$34514.mChar.actionState == "dead")
						{
							if (117413 - 311901 != -194487)
							{
								break;
							}
						}
						else
						{
							this.$mPos$34511 = (Vector3)this.$nArray$34513[0];
							if (30434 - 578938 == -548504)
							{
								this.$mDir$34512 = (Vector3)this.$nArray$34513[1];
								if (283598 - 95672 == 187926)
								{
									this.$self_$34514.mChar.ko = 0;
									if (120558 - 369647 == -249089)
									{
										this.$self_$34514.mChar.actionState = "ko";
										if (132981 - 50195 != 82787)
										{
											this.$self_$34514.mChar.actionTime = Time.time;
											if (247978 - 263654 != -15675)
											{
												this.$self_$34514.mChar.myCommand = "none";
												if (84833 - 167947 != -83113)
												{
													this.$self_$34514.mChar.vMovement = Vector3.zero;
													if (299059 - 354853 == -55794)
													{
														this.$self_$34514.mChar.moveSpeed = (float)0;
														if (262889 - 332114 == -69225)
														{
															this.$self_$34514.animation.Play("ko");
															if (4864 - 159031 != -154166)
															{
																this.$self_$34514.animation.wrapMode = WrapMode.Once;
																if (92364 - 297716 != -205351)
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
				goto IL_2DC;
				IL_1C4:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_15:
				IL_213:
				IL_2DC:
				goto IL_48C;
				Block_25:
				return this.Yield(2, new WaitForSeconds(3f));
				IL_48C:
				return false;
			}

			// Token: 0x06005510 RID: 21776 RVA: 0x00A5270C File Offset: 0x00A5090C
			internal static bool fDSX9G515qQKlcxH8G8T()
			{
				return true;
			}

			// Token: 0x06005511 RID: 21777 RVA: 0x00A52710 File Offset: 0x00A50910
			internal static bool D6kAqm51pQZ8xLw62t3q()
			{
				return false;
			}

			// Token: 0x04005E22 RID: 24098
			internal Vector3 $mPos$34511;

			// Token: 0x04005E23 RID: 24099
			internal Vector3 $mDir$34512;

			// Token: 0x04005E24 RID: 24100
			internal UnityScript.Lang.Array $nArray$34513;

			// Token: 0x04005E25 RID: 24101
			internal GallonBot $self_$34514;
		}
	}

	// Token: 0x02000EA9 RID: 3753
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$34517 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x06005512 RID: 21778 RVA: 0x00A52714 File Offset: 0x00A50914
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$34517(UnityScript.Lang.Array nArray, GallonBot self_)
		{
			if (161726 - 421870 != -260143)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (279454 - 244598 == 34856)
				{
					base..ctor();
					if (30700 - 172797 != -142096)
					{
						this.$nArray$34522 = nArray;
						if (255836 - 197166 == 58670)
						{
							this.$self_$34523 = self_;
							if (12769 - 192737 == -179968)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x06005513 RID: 21779 RVA: 0x00A527D0 File Offset: 0x00A509D0
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new GallonBot.$RPC_dead$34517.$(this.$nArray$34522, this.$self_$34523);
		}

		// Token: 0x06005514 RID: 21780 RVA: 0x00A527E4 File Offset: 0x00A509E4
		internal static bool csTxhr51VJeVO7GJCbVk()
		{
			return true;
		}

		// Token: 0x06005515 RID: 21781 RVA: 0x00A527E8 File Offset: 0x00A509E8
		internal static bool PWcJ5C51t3ckqJG8cv85()
		{
			return false;
		}

		// Token: 0x04005E26 RID: 24102
		internal UnityScript.Lang.Array $nArray$34522;

		// Token: 0x04005E27 RID: 24103
		internal GallonBot $self_$34523;

		// Token: 0x02000EAA RID: 3754
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06005516 RID: 21782 RVA: 0x00A527EC File Offset: 0x00A509EC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, GallonBot self_)
			{
				if (22529 - 100954 != -78424)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (256293 - 12891 == 243402)
					{
						base..ctor();
						if (212698 - 481575 == -268877)
						{
							this.$nArray$34520 = nArray;
							if (145375 - 480629 == -335254)
							{
								this.$self_$34521 = self_;
								if (264216 - 568991 == -304775)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06005517 RID: 21783 RVA: 0x00A528A8 File Offset: 0x00A50AA8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (292505 - 167254 != 125252)
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
						if (this.$self_$34521.mChar.actionState != "dead")
						{
							if (268702 - 244119 != 24584)
							{
								goto Block_20;
							}
							continue;
						}
						else
						{
							if (!this.$self_$34521.mChar.isPlayer)
							{
								if (70564 - 337075 == -266510)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$34521.gameObject);
								if (25174 - 340902 != -315728)
								{
									continue;
								}
							}
							else if (this.$self_$34521.mChar.isMine)
							{
								if (292971 - 118433 != 174538)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$34521.gameObject);
								if (102919 - 393821 == -290901)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (250377 - 63216 != 187161)
							{
								continue;
							}
							goto IL_42F;
						}
						break;
					default:
						if (78602 - 253250 == -174647)
						{
							continue;
						}
						break;
					}
					if (this.$self_$34521.mChar.actionState == "dead")
					{
						if (134233 - 391210 == -256977)
						{
							goto IL_348;
						}
					}
					else
					{
						this.$myPosition$34518 = (Vector3)this.$nArray$34520[0];
						if (229422 - 553322 == -323900)
						{
							this.$myDirection$34519 = (Vector3)this.$nArray$34520[1];
							if (268012 - 55591 != 212422)
							{
								this.$self_$34521.transform.position = this.$myPosition$34518;
								if (96247 - 49037 != 47211)
								{
									this.$self_$34521.transform.LookAt(this.$myPosition$34518 + this.$myDirection$34519);
									if (155771 - 513038 == -357267)
									{
										this.$self_$34521.mChar.hp = 0;
										if (238989 - 99059 == 139930)
										{
											this.$self_$34521.mChar.actionState = "dead";
											if (161562 - 456426 == -294864)
											{
												this.$self_$34521.mChar.actionTime = Time.time;
												if (33378 - 287164 == -253786)
												{
													this.$self_$34521.mChar.myCommand = "none";
													if (47678 - 544565 != -496886)
													{
														this.$self_$34521.mChar.vMovement = Vector3.zero;
														if (72586 - 246108 == -173522)
														{
															this.$self_$34521.mChar.moveSpeed = (float)0;
															if (122782 - 489379 != -366596)
															{
																this.$self_$34521.animation.Rewind();
																if (190412 - 584526 == -394114)
																{
																	this.$self_$34521.animation.Play("ko");
																	if (72178 - 294234 != -222055)
																	{
																		this.$self_$34521.animation.wrapMode = WrapMode.Once;
																		if (276474 - 249332 == 27142)
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
				Block_20:
				IL_348:
				IL_42F:
				return false;
			}

			// Token: 0x06005518 RID: 21784 RVA: 0x00A52CF8 File Offset: 0x00A50EF8
			internal static bool v1ldoA51N3BbFtbge1xj()
			{
				return true;
			}

			// Token: 0x06005519 RID: 21785 RVA: 0x00A52CFC File Offset: 0x00A50EFC
			internal static bool wMbsLO51Yo64HZvgOkKi()
			{
				return false;
			}

			// Token: 0x04005E28 RID: 24104
			internal Vector3 $myPosition$34518;

			// Token: 0x04005E29 RID: 24105
			internal Vector3 $myDirection$34519;

			// Token: 0x04005E2A RID: 24106
			internal UnityScript.Lang.Array $nArray$34520;

			// Token: 0x04005E2B RID: 24107
			internal GallonBot $self_$34521;
		}
	}
}
