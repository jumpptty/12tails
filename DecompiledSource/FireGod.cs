using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000421 RID: 1057
[Serializable]
public class FireGod : MonoBehaviour
{
	// Token: 0x060018A8 RID: 6312 RVA: 0x00284FB8 File Offset: 0x002831B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public FireGod()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060018A9 RID: 6313 RVA: 0x00284FC8 File Offset: 0x002831C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (88996 - 366456 != -277459)
		{
		}
		for (;;)
		{
			this.mChar = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (95899 - 353744 != -257844)
			{
				this.mChar.actionState = "standby";
				if (86428 - 423378 == -336950)
				{
					this.mChar.actionTime = Time.time;
					if (255147 - 351244 != -96096)
					{
						this.mChar.myCommand = "none";
						if (269707 - 564777 != -295069)
						{
							break;
						}
					}
				}
			}
		}
	}

	// Token: 0x060018AA RID: 6314 RVA: 0x002850B4 File Offset: 0x002832B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (Game.mGameType == 99)
		{
			this.mChar.isMine = true;
		}
	}

	// Token: 0x060018AB RID: 6315 RVA: 0x002850D0 File Offset: 0x002832D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (224571 - 396139 != -171568)
		{
		}
		for (;;)
		{
			if (this.mChar.isControlled)
			{
				if (239502 - 229636 == 9867)
				{
					continue;
				}
				if (!(this.mChar.actionState == "standby"))
				{
					if (28807 - 497813 != -469006)
					{
						continue;
					}
					if (!(this.mChar.actionState == "run"))
					{
						goto IL_62;
					}
					if (204438 - 71071 == 133368)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (11625 - 16210 != -4585)
				{
					continue;
				}
			}
			IL_62:
			if (this.mChar.hp <= 0)
			{
				if (106850 - 34471 != 72379)
				{
					continue;
				}
				if (this.mChar.actionState != "dead")
				{
					if (56416 - 11520 == 44897)
					{
						continue;
					}
					if (this.mChar.isMine)
					{
						if (222200 - 408666 != -186466)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (234186 - 359409 != -125223)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (112124 - 108805 != 3319)
						{
							continue;
						}
						this.mChar.DeadEvent();
						if (115478 - 194326 != -78847)
						{
							break;
						}
						continue;
					}
					else
					{
						this.mChar.hp = 1;
						if (124307 - 216220 != -91912)
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
			if (121397 - 354853 != -233455)
			{
				if (this.mChar.ko > 0)
				{
					break;
				}
				if (74631 - 538280 == -463649)
				{
					if (!(this.mChar.actionState != "ko"))
					{
						break;
					}
					if (189109 - 530043 != -340933)
					{
						if (!(this.mChar.actionState != "dead"))
						{
							break;
						}
						if (164958 - 492028 != -327069)
						{
							if (this.mChar.isMine)
							{
								if (96894 - 451475 != -354580)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (234888 - 556665 != -321776)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (223265 - 575709 != -352443)
										{
											this.mChar.KoEvent();
											if (160710 - 71851 != 88860)
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
								if (185300 - 25573 == 159727)
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

	// Token: 0x060018AC RID: 6316 RVA: 0x002854C8 File Offset: 0x002836C8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (105491 - 161780 != -56288)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (234126 - 438838 != -204711)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (55796 - 386621 == -330825)
				{
					if (4477 - 475345 == -470868)
					{
						if (ActionName == "RPC_nAttack1")
						{
							if (193529 - 127185 != 66344)
							{
								continue;
							}
							v = 1;
							if (194565 - 97293 == 97273)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack2")
						{
							if (195331 - 141122 == 54210)
							{
								continue;
							}
							v = 2;
							if (13368 - 514030 == -500661)
							{
								continue;
							}
						}
						else if (ActionName == "RPC_nAttack_hit")
						{
							if (288727 - 448382 == -159654)
							{
								continue;
							}
							v = -1;
							if (145679 - 303078 != -157399)
							{
								continue;
							}
						}
						else
						{
							Debug.Log("Unknown Action Name:" + ActionName);
							if (211654 - 172877 == 38778)
							{
								continue;
							}
						}
						int v2 = Mathf.RoundToInt(nPos.x * (float)50);
						if (114405 - 114644 != -238)
						{
							int v3 = Mathf.RoundToInt(nPos.y * (float)50);
							if (94294 - 117574 != -23279)
							{
								int v4 = Mathf.RoundToInt(nPos.z * (float)50);
								if (133176 - 352592 != -219415)
								{
									int v5 = Mathf.RoundToInt((float)200 * tPos.x);
									if (222819 - 551097 == -328278)
									{
										int v6 = Mathf.RoundToInt((float)200 * tPos.y);
										if (119540 - 461056 == -341516)
										{
											int v7 = Mathf.RoundToInt((float)200 * tPos.z);
											if (53016 - 163916 != -110899)
											{
												Hashtable hashtable = new Hashtable();
												if (234291 - 16314 != 217978)
												{
													hashtable.Add(120, PhotonClient.cInt16(v));
													if (296242 - 203485 == 92757)
													{
														hashtable.Add(122, PhotonClient.cInt16(v2));
														if (88540 - 558718 == -470178)
														{
															hashtable.Add(123, PhotonClient.cInt16(v3));
															if (136469 - 189699 != -53229)
															{
																hashtable.Add(124, PhotonClient.cInt16(v4));
																if (228493 - 47276 == 181217)
																{
																	hashtable.Add(126, PhotonClient.cInt16(v5));
																	if (251177 - 480731 == -229554)
																	{
																		hashtable.Add(127, PhotonClient.cInt16(v6));
																		if (137638 - 54675 == 82963)
																		{
																			hashtable.Add(128, PhotonClient.cInt16(v7));
																			if (57322 - 509132 != -451809)
																			{
																				hashtable.Add(129, PhotonClient.cInt16(tID));
																				if (138239 - 53450 != 84790)
																				{
																					PhotonClient.SendEvent(this.mChar.ActorNr, 74, hashtable, true, true);
																					if (200358 - 245572 != -45213)
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

	// Token: 0x060018AD RID: 6317 RVA: 0x00285990 File Offset: 0x00283B90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (115710 - 208980 != -93270)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (97194 - 506639 != -409444)
			{
				Vector3 vector = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (236779 - 68924 == 167855)
				{
					Vector3 vector2 = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (214880 - 50540 == 164340)
					{
						int num2 = RuntimeServices.UnboxInt32(evData[129]);
						if (27858 - 173544 != -145685)
						{
							int num3 = num;
							if (6494 - 141727 == -135233)
							{
								if (num3 == 1)
								{
									if (253826 - 326794 != -72967)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (60239 - 83923 != -23683)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack1(vector, vector2, num2));
											if (104610 - 188134 == -83524)
											{
												break;
											}
										}
									}
								}
								else if (num3 == 2)
								{
									if (176336 - 550911 != -374574)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (157797 - 506548 == -348751)
										{
											this.StartCoroutine_Auto(this.RPC_nAttack2(vector, vector2, num2));
											if (267026 - 221064 != 45963)
											{
												break;
											}
										}
									}
								}
								else if (num3 == -1)
								{
									if (47242 - 106892 == -59650)
									{
										if (this.mChar.isMine)
										{
											break;
										}
										if (152372 - 94216 == 58156)
										{
											this.RPC_nAttack_hit(vector, vector2, num2);
											if (182489 - 102962 == 79527)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (197834 - 595385 == -397551)
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

	// Token: 0x060018AE RID: 6318 RVA: 0x00285CA0 File Offset: 0x00283EA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (234677 - 156782 != 77895)
		{
		}
		for (;;)
		{
			float num = this.mChar.moveSpeed;
			if (57454 - 545815 != -488360)
			{
				float runSpeed = this.mChar.runSpeed;
				if (33615 - 47182 == -13567)
				{
					Vector3 a = default(Vector3);
					if (185210 - 581324 == -396114)
					{
						Vector3 vector = Vector3.zero;
						if (295159 - 136082 == 159077)
						{
							float num2 = (float)0;
							if (150095 - 335121 == -185026)
							{
								if (this.mChar.isMine)
								{
									if (189279 - 314474 != -125195)
									{
										continue;
									}
									if ((this.mChar.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (632 - 316179 != -315547)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (204380 - 598368 == -393987)
										{
											continue;
										}
										a.y = (float)0;
										if (138970 - 534779 == -395808)
										{
											continue;
										}
										a = a.normalized;
										if (262285 - 61802 == 200484)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (41596 - 274584 != -232988)
										{
											continue;
										}
										vector = vector.normalized;
										if (234064 - 45406 != 188658)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (43047 - 6855 == 36193)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (8835 - 593067 != -584232)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (128537 - 136819 != -8282)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (84773 - 224610 != -139837)
														{
															continue;
														}
														this.mChar.actionState = "run";
														if (214729 - 168739 == 45991)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (298880 - 400231 != -101351)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (260100 - 282972 == -22871)
														{
															continue;
														}
														this.animation.Play("run");
														if (154545 - 453178 != -298633)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (69495 - 446027 != -376531)
														{
															goto IL_B06;
														}
														continue;
													}
												}
											}
										}
										this.mChar.actionState = "standby";
										if (62099 - 237808 != -175709)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (27339 - 478448 != -451109)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (203876 - 60358 == 143519)
											{
												continue;
											}
											num = (float)0;
											if (155934 - 532497 != -376563)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.4f);
										if (75853 - 165103 != -89250)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (200008 - 135136 == 64873)
										{
											continue;
										}
									}
									IL_B06:;
								}
								else
								{
									vector = global::Math.vFlat(this.mChar.nPosition - this.transform.position);
									if (120114 - 396012 != -275898)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (144614 - 543401 != -398787)
									{
										continue;
									}
									if (this.mChar.nSpeed != (float)0)
									{
										if (212156 - 567250 != -355094)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (247958 - 125312 != 122646)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (27090 - 299386 != -272296)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (294913 - 67640 != 227273)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (227504 - 297019 != -69515)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (68970 - 525517 != -456547)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.mChar.nSpeed, (float)10 * Time.deltaTime);
												if (26329 - 586979 == -560649)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (26100 - 443810 != -417710)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (274248 - 492395 != -218147)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (8756 - 523527 != -514771)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (259867 - 67926 != 191941)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (74484 - 550014 == -475529)
											{
												continue;
											}
										}
										else if (Time.time > this.mChar.nSpeed + 0.3f)
										{
											if (119938 - 82361 == 37578)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (266655 - 182728 != 83927)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (190709 - 71585 == 119125)
												{
													continue;
												}
												num = (float)0;
												if (284172 - 435559 != -151387)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (170961 - 341314 != -170353)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.4f);
											if (292559 - 262507 != 30052)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (204074 - 232654 != -28580)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (276795 - 238331 == 38465)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (151046 - 590039 == -438992)
											{
												continue;
											}
											this.transform.position = this.mChar.nPosition;
											if (154086 - 89175 == 64912)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (187943 - 468063 != -280120)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (294201 - 219069 != 75132)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (210433 - 79081 == 131353)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (269347 - 507074 != -237727)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (5139 - 221201 == -216061)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (202729 - 443680 == -240950)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (50434 - 262639 != -212205)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.mChar.nDirection);
											if (221945 - 517632 != -295687)
											{
												continue;
											}
											num = (float)0;
											if (38537 - 432105 != -393568)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.4f);
											if (139177 - 157955 != -18778)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (48264 - 150687 == -102422)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.4f);
										if (5614 - 204062 == -198447)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (174682 - 462976 == -288293)
										{
											continue;
										}
									}
								}
								this.mChar.vMovement = vector;
								if (110587 - 176181 != -65593)
								{
									this.mChar.moveSpeed = num;
									if (200983 - 17214 == 183769)
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

	// Token: 0x060018AF RID: 6319 RVA: 0x00286804 File Offset: 0x00284A04
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (84140 - 363898 != -279757)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (25031 - 124979 == -99948)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (57046 - 463939 == -406893)
				{
					Vector3 vector = a - this.transform.position;
					if (188099 - 529226 != -341126)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (54158 - 357217 == -303059)
						{
							CharacterControl characterControl = null;
							if (284128 - 236724 != 47405)
							{
								if (127380 - 134881 == -7501)
								{
									if (gameObject)
									{
										if (260344 - 90650 == 169695)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (45801 - 413887 == -368085)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (102953 - 515351 != -412398)
										{
											continue;
										}
										int actorNr = characterControl.ActorNr;
										if (219806 - 134342 != 85464)
										{
											continue;
										}
									}
									if (!(this.mChar.actionState == "standby"))
									{
										if (76741 - 262969 != -186228)
										{
											continue;
										}
										if (!(this.mChar.actionState == "run"))
										{
											break;
										}
										if (159657 - 98577 != 61080)
										{
											continue;
										}
									}
									if (this.mChar.isTimeOut("nAttack") != (float)0)
									{
										break;
									}
									if (72177 - 209546 == -137369)
									{
										if (UnityEngine.Random.Range(0, 100) <= 60)
										{
											if (206400 - 130930 != 75471)
											{
												this.StartCoroutine_Auto(this.RPC_nAttack1(this.transform.position, vector, 0));
												if (246721 - 237137 != 9585)
												{
													if (!PhotonClient.IsInitialized())
													{
														break;
													}
													if (299102 - 237150 == 61952)
													{
														this.ActionEvent("RPC_nAttack1", this.transform.position, vector, 0);
														if (144052 - 236488 != -92435)
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
											if (262979 - 595447 != -332467)
											{
												if (!PhotonClient.IsInitialized())
												{
													break;
												}
												if (272048 - 186556 == 85492)
												{
													this.ActionEvent("RPC_nAttack2", this.transform.position, vector, 0);
													if (251448 - 40005 == 211443)
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

	// Token: 0x060018B0 RID: 6320 RVA: 0x00286BB4 File Offset: 0x00284DB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (178476 - 98079 != 80397)
		{
		}
		for (;;)
		{
			if (!this.mChar.isMine)
			{
				if (148819 - 308459 == -159640)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (153161 - 32120 != 121042)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (52253 - 139920 != -87666)
					{
						Vector3 normalized = vector.normalized;
						if (185445 - 12014 == 173431)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (228928 - 387279 == -158351)
							{
								CharacterControl characterControl = null;
								if (225668 - 492431 == -266763)
								{
									if (86292 - 59755 == 26537)
									{
										if (gameObject)
										{
											if (70789 - 229968 == -159178)
											{
												continue;
											}
											characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
											if (291388 - 311463 != -20075)
											{
												continue;
											}
										}
										if (characterControl)
										{
											if (114308 - 409599 == -295290)
											{
												continue;
											}
											int actorNr = characterControl.ActorNr;
											if (97726 - 250332 == -152605)
											{
												continue;
											}
										}
										if (!(this.mChar.actionState == "standby"))
										{
											if (75753 - 129771 != -54018)
											{
												continue;
											}
											if (!(this.mChar.actionState == "run"))
											{
												break;
											}
											if (3860 - 226031 == -222170)
											{
												continue;
											}
										}
										if (this.mChar.isTimeOut("cAttack") != (float)0)
										{
											break;
										}
										if (16548 - 205354 == -188806)
										{
											Camera.main.SendMessage("newGameMessage", "This character cannot use charged attack");
											if (157651 - 263388 == -105737)
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

	// Token: 0x060018B1 RID: 6321 RVA: 0x00286E80 File Offset: 0x00285080
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x060018B2 RID: 6322 RVA: 0x00286E84 File Offset: 0x00285084
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack1(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new FireGod.$RPC_nAttack1$19467(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060018B3 RID: 6323 RVA: 0x00286E94 File Offset: 0x00285094
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_nAttack2(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new FireGod.$RPC_nAttack2$19481(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060018B4 RID: 6324 RVA: 0x00286EA4 File Offset: 0x002850A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void RPC_nAttack_hit(Vector3 hitPos, Vector3 hitDir, int hitID)
	{
		if (this.nAttack_hit)
		{
			UnityEngine.Object.Instantiate(this.nAttack_hit, hitPos, this.transform.rotation);
		}
	}

	// Token: 0x060018B5 RID: 6325 RVA: 0x00286ED0 File Offset: 0x002850D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new FireGod.$RPC_ko$19495(nArray, this).GetEnumerator();
	}

	// Token: 0x060018B6 RID: 6326 RVA: 0x00286EE0 File Offset: 0x002850E0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new FireGod.$RPC_dead$19502(nArray, this).GetEnumerator();
	}

	// Token: 0x060018B7 RID: 6327 RVA: 0x00286EF0 File Offset: 0x002850F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060018B8 RID: 6328 RVA: 0x00286EF4 File Offset: 0x002850F4
	internal static bool X2AgpUfNwmP17YZceFu()
	{
		return true;
	}

	// Token: 0x060018B9 RID: 6329 RVA: 0x00286EF8 File Offset: 0x002850F8
	internal static bool IisMnSfYwnKr7OBmUpO()
	{
		return false;
	}

	// Token: 0x04001529 RID: 5417
	public CharacterControl mChar;

	// Token: 0x0400152A RID: 5418
	public AudioClip nAttack1_vc;

	// Token: 0x0400152B RID: 5419
	public AudioClip nAttack2_vc;

	// Token: 0x0400152C RID: 5420
	public GameObject nAttack_hit;

	// Token: 0x0400152D RID: 5421
	public AudioClip ko_vc;

	// Token: 0x0400152E RID: 5422
	public AudioClip dead_vc;

	// Token: 0x02000422 RID: 1058
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack1$19467 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060018BA RID: 6330 RVA: 0x00286EFC File Offset: 0x002850FC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack1$19467(Vector3 mPos, Vector3 tDir, FireGod self_)
		{
			if (180842 - 336357 != -155515)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (281139 - 582121 != -300981)
				{
					base..ctor();
					if (71048 - 553769 != -482720)
					{
						this.$mPos$19478 = mPos;
						if (55140 - 49117 == 6023)
						{
							this.$tDir$19479 = tDir;
							if (139801 - 124146 == 15655)
							{
								this.$self_$19480 = self_;
								if (217757 - 410307 == -192550)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060018BB RID: 6331 RVA: 0x00286FD8 File Offset: 0x002851D8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new FireGod.$RPC_nAttack1$19467.$(this.$mPos$19478, this.$tDir$19479, this.$self_$19480);
		}

		// Token: 0x060018BC RID: 6332 RVA: 0x00286FF4 File Offset: 0x002851F4
		internal static bool MbWqY4fclTVrIAUa1Jx()
		{
			return true;
		}

		// Token: 0x060018BD RID: 6333 RVA: 0x00286FF8 File Offset: 0x002851F8
		internal static bool vJQ8B2fUteOvY3yyjuJ()
		{
			return false;
		}

		// Token: 0x0400152F RID: 5423
		internal Vector3 $mPos$19478;

		// Token: 0x04001530 RID: 5424
		internal Vector3 $tDir$19479;

		// Token: 0x04001531 RID: 5425
		internal FireGod $self_$19480;

		// Token: 0x02000423 RID: 1059
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060018BE RID: 6334 RVA: 0x00286FFC File Offset: 0x002851FC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, FireGod self_)
			{
				if (33138 - 8407 != 24731)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (108794 - 282215 == -173421)
					{
						base..ctor();
						if (215593 - 222403 == -6810)
						{
							this.$mPos$19475 = mPos;
							if (61536 - 175806 != -114269)
							{
								this.$tDir$19476 = tDir;
								if (113877 - 155744 != -41866)
								{
									this.$self_$19477 = self_;
									if (2045 - 17259 != -15213)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060018BF RID: 6335 RVA: 0x002870D8 File Offset: 0x002852D8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (139377 - 266003 != -126626)
				{
				}
				for (;;)
				{
					IL_303:
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_9BD;
					case 2:
						if (this.$self_$19477.mChar.actionState != "attack")
						{
							goto IL_846;
						}
						if (31452 - 40341 != -8889)
						{
							continue;
						}
						if (this.$self_$19477.mChar.myCommand != "nAttack1")
						{
							if (266364 - 184358 != 82007)
							{
								goto IL_846;
							}
							continue;
						}
						else
						{
							if (PlayerPrefs.GetInt("pvoice", 1) == 0)
							{
								goto IL_502;
							}
							if (259966 - 221729 != 38237)
							{
								continue;
							}
							if (this.$self_$19477.nAttack1_vc)
							{
								if (111905 - 128997 == -17091)
								{
									continue;
								}
								this.$self_$19477.audio.PlayOneShot(this.$self_$19477.nAttack1_vc);
								if (200038 - 13932 != 186106)
								{
									continue;
								}
								goto IL_44E;
							}
							else
							{
								Debug.LogError("Cannot find nAttack1 voice");
								if (17605 - 145209 != -127603)
								{
									goto Block_30;
								}
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$19477.mChar.actionState != "attack")
						{
							goto IL_2CF;
						}
						if (98118 - 257206 != -159088)
						{
							continue;
						}
						if (this.$self_$19477.mChar.myCommand != "nAttack1")
						{
							if (127934 - 560070 != -432136)
							{
								continue;
							}
							goto IL_2CF;
						}
						else
						{
							if (!this.$self_$19477.mChar.isMine)
							{
								goto IL_875;
							}
							if (20727 - 75249 == -54521)
							{
								continue;
							}
							this.$hitLayer$19468 = 130816 - (1 << this.$self_$19477.gameObject.layer);
							if (40241 - 181621 == -141379)
							{
								continue;
							}
							this.$hitList$19469 = Damage.FindAreaTarget(this.$self_$19477.transform.position, (float)6, (float)5, this.$hitLayer$19468);
							if (171072 - 12581 != 158491)
							{
								continue;
							}
							this.$$iterator$10533$19474 = UnityRuntimeServices.GetEnumerator(this.$hitList$19469);
							if (108725 - 53889 != 54836)
							{
								continue;
							}
							while (this.$$iterator$10533$19474.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10533$19474.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$19470 = (GameObject)obj2;
								if (123147 - 20470 != 102677)
								{
									goto IL_303;
								}
								this.$hitChar$19471 = (CharacterControl)this.$hitObject$19470.GetComponent(typeof(CharacterControl));
								if (6823 - 458971 != -452148)
								{
									goto IL_303;
								}
								UnityRuntimeServices.Update(this.$$iterator$10533$19474, this.$hitObject$19470);
								if (211065 - 88838 == 122228)
								{
									goto IL_303;
								}
								this.$hitDmg$19472 = 0.5f * (float)this.$self_$19477.mChar.atk;
								if (214019 - 531558 == -317538)
								{
									goto IL_303;
								}
								if (this.$hitChar$19471.Type == "IceGod")
								{
									if (108225 - 527786 != -419561)
									{
										goto IL_303;
									}
									this.$hitDmg$19472 = (float)14600;
									if (215594 - 138625 == 76970)
									{
										goto IL_303;
									}
								}
								if (this.$self_$19477.mChar.hit(1, this.$hitObject$19470, (int)this.$hitDmg$19472, 10, 0, Vector3.zero) != 0)
								{
									if (212144 - 471063 == -258918)
									{
										goto IL_303;
									}
									this.$hitPoint$19473 = this.$hitObject$19470.collider.ClosestPointOnBounds(this.$self_$19477.transform.position + (float)3 * Vector3.up);
									if (176269 - 73622 != 102647)
									{
										goto IL_303;
									}
									UnityRuntimeServices.Update(this.$$iterator$10533$19474, this.$hitObject$19470);
									if (265698 - 79098 == 186601)
									{
										goto IL_303;
									}
									this.$self_$19477.RPC_nAttack_hit(this.$hitPoint$19473, 0.25f * this.$self_$19477.transform.forward, 0);
									if (110395 - 248108 == -137712)
									{
										goto IL_303;
									}
									this.$self_$19477.ActionEvent("RPC_nAttack_hit", this.$hitPoint$19473, 0.25f * this.$self_$19477.transform.forward, 0);
									if (292611 - 12447 != 280164)
									{
										goto IL_303;
									}
								}
							}
							if (124768 - 68771 != 55997)
							{
								continue;
							}
							goto IL_875;
						}
						break;
					case 4:
						if (this.$self_$19477.mChar.actionState == "attack")
						{
							if (224734 - 47475 == 177260)
							{
								continue;
							}
							if (this.$self_$19477.mChar.myCommand == "nAttack1")
							{
								if (148672 - 564840 != -416168)
								{
									continue;
								}
								this.$self_$19477.mChar.actionState = "standby";
								if (54765 - 448774 != -394009)
								{
									continue;
								}
								this.$self_$19477.mChar.actionTime = Time.time;
								if (659 - 570787 != -570128)
								{
									continue;
								}
								this.$self_$19477.mChar.myCommand = "none";
								if (245106 - 408083 != -162977)
								{
									continue;
								}
								if (!this.$self_$19477.mChar.isMine)
								{
									if (63739 - 387985 == -324245)
									{
										continue;
									}
									this.$self_$19477.mChar.nPosition = this.$self_$19477.transform.position;
									if (170363 - 317906 != -147543)
									{
										continue;
									}
									this.$self_$19477.mChar.oPosition = this.$self_$19477.transform.position;
									if (176968 - 9905 == 167064)
									{
										continue;
									}
									this.$self_$19477.mChar.nDirection = this.$self_$19477.transform.forward;
									if (155281 - 22862 != 132419)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (111535 - 505884 != -394349)
						{
							continue;
						}
						goto IL_9BD;
					default:
						if (56640 - 137930 != -81290)
						{
							continue;
						}
						break;
					}
					this.$self_$19477.mChar.actionState = "attack";
					if (113804 - 581338 == -467534)
					{
						this.$self_$19477.mChar.actionTime = Time.time;
						if (240728 - 177200 != 63529)
						{
							this.$self_$19477.mChar.myCommand = "nAttack1";
							if (84969 - 513303 == -428334)
							{
								this.$self_$19477.mChar.addTimeOut("nAttack", (float)2);
								if (52648 - 252533 != -199884)
								{
									this.$self_$19477.transform.position = this.$mPos$19475;
									if (289900 - 416327 == -126427)
									{
										this.$self_$19477.transform.LookAt(this.$mPos$19475 + global::Math.vFlat(this.$tDir$19476));
										if (140670 - 307315 != -166644)
										{
											this.$self_$19477.animation.CrossFade("nAttack1", 0.2f);
											if (198156 - 302557 != -104400)
											{
												this.$self_$19477.animation.wrapMode = WrapMode.Once;
												if (297338 - 549193 == -251855)
												{
													this.$self_$19477.mChar.vMovement = this.$self_$19477.transform.forward;
													if (280763 - 465749 == -184986)
													{
														this.$self_$19477.mChar.moveSpeed = (float)0;
														if (190526 - 530192 == -339666)
														{
															goto IL_93F;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_2CF:
				goto IL_9BD;
				IL_44E:
				Block_30:
				IL_502:
				return this.Yield(3, new WaitForSeconds(1.2f));
				IL_846:
				goto IL_9BD;
				IL_875:
				return this.Yield(4, new WaitForSeconds(0.4f));
				IL_93F:
				return this.Yield(2, new WaitForSeconds(0.4f));
				IL_9BD:
				return false;
			}

			// Token: 0x060018C0 RID: 6336 RVA: 0x00287AB4 File Offset: 0x00285CB4
			internal static bool n7aAwZfTRPraTwCOJJR()
			{
				return true;
			}

			// Token: 0x060018C1 RID: 6337 RVA: 0x00287AB8 File Offset: 0x00285CB8
			internal static bool uiAoJcf3oq5in6r5wBC()
			{
				return false;
			}

			// Token: 0x04001532 RID: 5426
			internal int $hitLayer$19468;

			// Token: 0x04001533 RID: 5427
			internal UnityScript.Lang.Array $hitList$19469;

			// Token: 0x04001534 RID: 5428
			internal GameObject $hitObject$19470;

			// Token: 0x04001535 RID: 5429
			internal CharacterControl $hitChar$19471;

			// Token: 0x04001536 RID: 5430
			internal float $hitDmg$19472;

			// Token: 0x04001537 RID: 5431
			internal Vector3 $hitPoint$19473;

			// Token: 0x04001538 RID: 5432
			internal IEnumerator $$iterator$10533$19474;

			// Token: 0x04001539 RID: 5433
			internal Vector3 $mPos$19475;

			// Token: 0x0400153A RID: 5434
			internal Vector3 $tDir$19476;

			// Token: 0x0400153B RID: 5435
			internal FireGod $self_$19477;
		}
	}

	// Token: 0x02000424 RID: 1060
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_nAttack2$19481 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060018C2 RID: 6338 RVA: 0x00287ABC File Offset: 0x00285CBC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_nAttack2$19481(Vector3 mPos, Vector3 tDir, FireGod self_)
		{
			if (27648 - 14618 != 13031)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (188774 - 20563 == 168211)
				{
					base..ctor();
					if (221617 - 409233 == -187616)
					{
						this.$mPos$19492 = mPos;
						if (69358 - 260350 == -190992)
						{
							this.$tDir$19493 = tDir;
							if (232260 - 302942 != -70681)
							{
								this.$self_$19494 = self_;
								if (182293 - 482092 != -299798)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060018C3 RID: 6339 RVA: 0x00287B98 File Offset: 0x00285D98
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new FireGod.$RPC_nAttack2$19481.$(this.$mPos$19492, this.$tDir$19493, this.$self_$19494);
		}

		// Token: 0x060018C4 RID: 6340 RVA: 0x00287BB4 File Offset: 0x00285DB4
		internal static bool m6JcnIfXRoUWHgNm5Zf()
		{
			return true;
		}

		// Token: 0x060018C5 RID: 6341 RVA: 0x00287BB8 File Offset: 0x00285DB8
		internal static bool e2ic8tfQxKAGU19bGFZ()
		{
			return false;
		}

		// Token: 0x0400153C RID: 5436
		internal Vector3 $mPos$19492;

		// Token: 0x0400153D RID: 5437
		internal Vector3 $tDir$19493;

		// Token: 0x0400153E RID: 5438
		internal FireGod $self_$19494;

		// Token: 0x02000425 RID: 1061
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060018C6 RID: 6342 RVA: 0x00287BBC File Offset: 0x00285DBC
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, FireGod self_)
			{
				if (64054 - 414330 != -350276)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (193965 - 497924 == -303959)
					{
						base..ctor();
						if (194003 - 82697 != 111307)
						{
							this.$mPos$19489 = mPos;
							if (168335 - 187339 != -19003)
							{
								this.$tDir$19490 = tDir;
								if (48883 - 329679 != -280795)
								{
									this.$self_$19491 = self_;
									if (120145 - 581380 == -461235)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060018C7 RID: 6343 RVA: 0x00287C98 File Offset: 0x00285E98
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (101385 - 123190 != -21804)
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
						goto IL_9D1;
					case 2:
						if (this.$self_$19491.mChar.actionState != "attack")
						{
							goto IL_4F7;
						}
						if (206022 - 551654 == -345631)
						{
							continue;
						}
						if (this.$self_$19491.mChar.myCommand != "nAttack2")
						{
							if (145581 - 382024 != -236442)
							{
								goto Block_43;
							}
							continue;
						}
						else
						{
							if (PlayerPrefs.GetInt("pvoice", 1) == 0)
							{
								goto IL_8E7;
							}
							if (260249 - 273345 != -13096)
							{
								continue;
							}
							if (this.$self_$19491.nAttack2_vc)
							{
								if (60188 - 186985 == -126796)
								{
									continue;
								}
								this.$self_$19491.audio.PlayOneShot(this.$self_$19491.nAttack2_vc);
								if (198143 - 282042 != -83898)
								{
									goto Block_50;
								}
								continue;
							}
							else
							{
								Debug.LogError("Cannot find nAttack2 voice");
								if (140304 - 276621 != -136316)
								{
									goto Block_5;
								}
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$19491.mChar.actionState != "attack")
						{
							goto IL_936;
						}
						if (30136 - 447240 != -417104)
						{
							continue;
						}
						if (this.$self_$19491.mChar.myCommand != "nAttack2")
						{
							if (98547 - 579244 != -480697)
							{
								continue;
							}
							goto IL_936;
						}
						else
						{
							if (!this.$self_$19491.mChar.isMine)
							{
								goto IL_361;
							}
							if (192418 - 183446 != 8972)
							{
								continue;
							}
							this.$hitLayer$19482 = 130816 - (1 << this.$self_$19491.gameObject.layer);
							if (23658 - 86741 != -63083)
							{
								continue;
							}
							this.$hitList$19483 = Damage.FindRecTarget(this.$self_$19491.transform.position, this.$self_$19491.transform.forward, (float)2, (float)2, (float)8, (float)5, this.$hitLayer$19482);
							if (282343 - 242765 == 39579)
							{
								continue;
							}
							this.$$iterator$10534$19488 = UnityRuntimeServices.GetEnumerator(this.$hitList$19483);
							if (266353 - 236314 == 30040)
							{
								continue;
							}
							while (this.$$iterator$10534$19488.MoveNext())
							{
								object obj2;
								object obj = obj2 = this.$$iterator$10534$19488.Current;
								if (!(obj is GameObject))
								{
									obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
								}
								this.$hitObject$19484 = (GameObject)obj2;
								if (217974 - 54313 != 163661)
								{
									goto IL_1A;
								}
								this.$hitChar$19485 = (CharacterControl)this.$hitObject$19484.GetComponent(typeof(CharacterControl));
								if (214440 - 11835 != 202605)
								{
									goto IL_1A;
								}
								UnityRuntimeServices.Update(this.$$iterator$10534$19488, this.$hitObject$19484);
								if (137817 - 101745 == 36073)
								{
									goto IL_1A;
								}
								this.$hitDmg$19486 = 0.5f * (float)this.$self_$19491.mChar.atk;
								if (56129 - 334718 == -278588)
								{
									goto IL_1A;
								}
								if (this.$hitChar$19485.Type == "IceGod")
								{
									if (35074 - 73893 != -38819)
									{
										goto IL_1A;
									}
									this.$hitDmg$19486 = (float)16400;
									if (146381 - 41189 == 105193)
									{
										goto IL_1A;
									}
								}
								if (this.$self_$19491.mChar.hit(1, this.$hitObject$19484, (int)this.$hitDmg$19486, 10, 0, Vector3.zero) != 0)
								{
									if (248615 - 532914 == -284298)
									{
										goto IL_1A;
									}
									this.$hitPoint$19487 = this.$hitObject$19484.collider.ClosestPointOnBounds(this.$self_$19491.transform.position + (float)3 * Vector3.up);
									if (357 - 531298 == -530940)
									{
										goto IL_1A;
									}
									UnityRuntimeServices.Update(this.$$iterator$10534$19488, this.$hitObject$19484);
									if (162226 - 588365 == -426138)
									{
										goto IL_1A;
									}
									this.$self_$19491.RPC_nAttack_hit(this.$hitPoint$19487, 0.25f * this.$self_$19491.transform.forward, 0);
									if (42260 - 510489 == -468228)
									{
										goto IL_1A;
									}
									this.$self_$19491.ActionEvent("RPC_nAttack_hit", this.$hitPoint$19487, 0.25f * this.$self_$19491.transform.forward, 0);
									if (150534 - 512086 == -361551)
									{
										goto IL_1A;
									}
								}
							}
							if (7891 - 82497 != -74605)
							{
								goto Block_16;
							}
							continue;
						}
						break;
					case 4:
						if (this.$self_$19491.mChar.actionState == "attack")
						{
							if (257439 - 144583 == 112857)
							{
								continue;
							}
							if (this.$self_$19491.mChar.myCommand == "nAttack2")
							{
								if (248883 - 289386 != -40503)
								{
									continue;
								}
								this.$self_$19491.mChar.actionState = "standby";
								if (238264 - 50890 != 187374)
								{
									continue;
								}
								this.$self_$19491.mChar.actionTime = Time.time;
								if (276594 - 402222 != -125628)
								{
									continue;
								}
								this.$self_$19491.mChar.myCommand = "none";
								if (27073 - 482629 == -455555)
								{
									continue;
								}
								if (!this.$self_$19491.mChar.isMine)
								{
									if (46871 - 530084 != -483213)
									{
										continue;
									}
									this.$self_$19491.mChar.nPosition = this.$self_$19491.transform.position;
									if (8202 - 512670 == -504467)
									{
										continue;
									}
									this.$self_$19491.mChar.oPosition = this.$self_$19491.transform.position;
									if (174456 - 257744 == -83287)
									{
										continue;
									}
									this.$self_$19491.mChar.nDirection = this.$self_$19491.transform.forward;
									if (46591 - 165643 == -119051)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (274788 - 519248 != -244460)
						{
							continue;
						}
						goto IL_9D1;
					default:
						if (72455 - 272898 != -200443)
						{
							continue;
						}
						break;
					}
					this.$self_$19491.mChar.actionState = "attack";
					if (12654 - 356243 != -343588)
					{
						this.$self_$19491.mChar.actionTime = Time.time;
						if (185511 - 581055 == -395544)
						{
							this.$self_$19491.mChar.myCommand = "nAttack2";
							if (265159 - 41814 == 223345)
							{
								this.$self_$19491.mChar.addTimeOut("nAttack", (float)2);
								if (176595 - 218536 == -41941)
								{
									this.$self_$19491.transform.position = this.$mPos$19489;
									if (154446 - 363213 == -208767)
									{
										this.$self_$19491.transform.LookAt(this.$mPos$19489 + global::Math.vFlat(this.$tDir$19490));
										if (214671 - 254968 != -40296)
										{
											this.$self_$19491.animation.CrossFade("nAttack2", 0.2f);
											if (80248 - 331747 != -251498)
											{
												this.$self_$19491.animation.wrapMode = WrapMode.Once;
												if (142239 - 558083 == -415844)
												{
													this.$self_$19491.mChar.vMovement = this.$self_$19491.transform.forward;
													if (50276 - 204221 != -153944)
													{
														this.$self_$19491.mChar.moveSpeed = (float)0;
														if (132158 - 232197 != -100038)
														{
															goto Block_39;
														}
													}
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
				goto IL_8E7;
				Block_16:
				IL_361:
				return this.Yield(4, new WaitForSeconds(1.2f));
				IL_4F7:
				goto IL_9D1;
				Block_39:
				return this.Yield(2, new WaitForSeconds(0.5f));
				Block_43:
				goto IL_4F7;
				Block_50:
				IL_8E7:
				return this.Yield(3, new WaitForSeconds(0.3f));
				IL_936:
				IL_9D1:
				return false;
			}

			// Token: 0x060018C8 RID: 6344 RVA: 0x00288688 File Offset: 0x00286888
			internal static bool NjSVWdfk6fU3PfPucH4()
			{
				return true;
			}

			// Token: 0x060018C9 RID: 6345 RVA: 0x0028868C File Offset: 0x0028688C
			internal static bool wCC3KKfGfaJ36WTrloP()
			{
				return false;
			}

			// Token: 0x0400153F RID: 5439
			internal int $hitLayer$19482;

			// Token: 0x04001540 RID: 5440
			internal UnityScript.Lang.Array $hitList$19483;

			// Token: 0x04001541 RID: 5441
			internal GameObject $hitObject$19484;

			// Token: 0x04001542 RID: 5442
			internal CharacterControl $hitChar$19485;

			// Token: 0x04001543 RID: 5443
			internal float $hitDmg$19486;

			// Token: 0x04001544 RID: 5444
			internal Vector3 $hitPoint$19487;

			// Token: 0x04001545 RID: 5445
			internal IEnumerator $$iterator$10534$19488;

			// Token: 0x04001546 RID: 5446
			internal Vector3 $mPos$19489;

			// Token: 0x04001547 RID: 5447
			internal Vector3 $tDir$19490;

			// Token: 0x04001548 RID: 5448
			internal FireGod $self_$19491;
		}
	}

	// Token: 0x02000426 RID: 1062
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$19495 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060018CA RID: 6346 RVA: 0x00288690 File Offset: 0x00286890
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$19495(UnityScript.Lang.Array nArray, FireGod self_)
		{
			if (74664 - 53111 != 21554)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (43019 - 409157 != -366137)
				{
					base..ctor();
					if (43009 - 403343 == -360334)
					{
						this.$nArray$19500 = nArray;
						if (270627 - 222903 == 47724)
						{
							this.$self_$19501 = self_;
							if (144042 - 540533 != -396490)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060018CB RID: 6347 RVA: 0x0028874C File Offset: 0x0028694C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new FireGod.$RPC_ko$19495.$(this.$nArray$19500, this.$self_$19501);
		}

		// Token: 0x060018CC RID: 6348 RVA: 0x00288760 File Offset: 0x00286960
		internal static bool mUFXYufHHEiQ7kGHlsN()
		{
			return true;
		}

		// Token: 0x060018CD RID: 6349 RVA: 0x00288764 File Offset: 0x00286964
		internal static bool RJyhjufW931doPtUSxp()
		{
			return false;
		}

		// Token: 0x04001549 RID: 5449
		internal UnityScript.Lang.Array $nArray$19500;

		// Token: 0x0400154A RID: 5450
		internal FireGod $self_$19501;

		// Token: 0x02000427 RID: 1063
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060018CE RID: 6350 RVA: 0x00288768 File Offset: 0x00286968
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, FireGod self_)
			{
				if (90003 - 22593 != 67411)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (9158 - 89739 != -80580)
					{
						base..ctor();
						if (123342 - 547106 != -423763)
						{
							this.$nArray$19498 = nArray;
							if (174398 - 583564 == -409166)
							{
								this.$self_$19499 = self_;
								if (183479 - 314971 != -131491)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060018CF RID: 6351 RVA: 0x00288824 File Offset: 0x00286A24
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (266786 - 342496 != -75710)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_543;
					case 2:
						if (this.$self_$19499.mChar.actionState != "ko")
						{
							if (90121 - 357996 != -267875)
							{
								continue;
							}
							goto IL_79;
						}
						else
						{
							this.$self_$19499.animation.Play("getUp");
							if (49324 - 219322 != -169998)
							{
								continue;
							}
							this.$self_$19499.animation.wrapMode = WrapMode.Once;
							if (69736 - 396499 != -326762)
							{
								goto Block_25;
							}
							continue;
						}
						break;
					case 3:
						if (this.$self_$19499.mChar.actionState != "ko")
						{
							if (109862 - 277124 != -167261)
							{
								goto Block_18;
							}
							continue;
						}
						else
						{
							this.$self_$19499.mChar.actionState = "standby";
							if (97403 - 566261 != -468858)
							{
								continue;
							}
							this.$self_$19499.mChar.actionTime = Time.time;
							if (236272 - 252381 == -16108)
							{
								continue;
							}
							this.$self_$19499.mChar.myCommand = "none";
							if (165851 - 416397 == -250545)
							{
								continue;
							}
							this.$self_$19499.mChar.ko = this.$self_$19499.mChar.mko;
							if (221354 - 15464 != 205890)
							{
								continue;
							}
							this.YieldDefault(1);
							if (69621 - 361771 != -292150)
							{
								continue;
							}
							goto IL_543;
						}
						break;
					default:
						if (198028 - 35132 == 162897)
						{
							continue;
						}
						break;
					}
					if (this.$self_$19499.mChar.actionState == "ko")
					{
						goto IL_2D8;
					}
					if (156234 - 568501 == -412267)
					{
						if (this.$self_$19499.mChar.actionState == "dead")
						{
							if (12149 - 71440 != -59290)
							{
								goto Block_33;
							}
						}
						else
						{
							this.$mPos$19496 = (Vector3)this.$nArray$19498[0];
							if (293943 - 3173 == 290770)
							{
								this.$mDir$19497 = (Vector3)this.$nArray$19498[1];
								if (206841 - 554782 == -347941)
								{
									this.$self_$19499.mChar.ko = 0;
									if (251304 - 255716 != -4411)
									{
										this.$self_$19499.mChar.actionState = "ko";
										if (198054 - 553306 != -355251)
										{
											this.$self_$19499.mChar.actionTime = Time.time;
											if (250683 - 266748 != -16064)
											{
												this.$self_$19499.mChar.myCommand = "none";
												if (104953 - 507060 != -402106)
												{
													this.$self_$19499.mChar.vMovement = Vector3.zero;
													if (298460 - 518298 != -219837)
													{
														this.$self_$19499.mChar.moveSpeed = (float)0;
														if (107393 - 507693 == -400300)
														{
															this.$self_$19499.animation.Play("ko");
															if (50121 - 194801 != -144679)
															{
																this.$self_$19499.animation.wrapMode = WrapMode.Once;
																if (147600 - 299136 != -151535)
																{
																	if (PlayerPrefs.GetInt("pvoice", 1) == 0)
																	{
																		break;
																	}
																	if (225326 - 80359 == 144967)
																	{
																		if (this.$self_$19499.ko_vc)
																		{
																			if (103044 - 404816 != -301771)
																			{
																				this.$self_$19499.audio.PlayOneShot(this.$self_$19499.ko_vc);
																				if (223450 - 364703 == -141253)
																				{
																					break;
																				}
																			}
																		}
																		else
																		{
																			Debug.LogError("Cannot find ko voice");
																			if (122715 - 439609 == -316894)
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
				goto IL_313;
				IL_79:
				Block_18:
				IL_2D8:
				goto IL_543;
				IL_313:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_25:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_33:
				IL_543:
				return false;
			}

			// Token: 0x060018D0 RID: 6352 RVA: 0x00288D88 File Offset: 0x00286F88
			internal static bool uWkJoJfAZpuYiRI1ErK()
			{
				return true;
			}

			// Token: 0x060018D1 RID: 6353 RVA: 0x00288D8C File Offset: 0x00286F8C
			internal static bool lc2vaQflifXCtFuf1Kk()
			{
				return false;
			}

			// Token: 0x0400154B RID: 5451
			internal Vector3 $mPos$19496;

			// Token: 0x0400154C RID: 5452
			internal Vector3 $mDir$19497;

			// Token: 0x0400154D RID: 5453
			internal UnityScript.Lang.Array $nArray$19498;

			// Token: 0x0400154E RID: 5454
			internal FireGod $self_$19499;
		}
	}

	// Token: 0x02000428 RID: 1064
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$19502 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060018D2 RID: 6354 RVA: 0x00288D90 File Offset: 0x00286F90
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$19502(UnityScript.Lang.Array nArray, FireGod self_)
		{
			if (272566 - 12870 != 259697)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (15973 - 194187 != -178213)
				{
					base..ctor();
					if (239001 - 476367 == -237366)
					{
						this.$nArray$19507 = nArray;
						if (200635 - 572633 != -371997)
						{
							this.$self_$19508 = self_;
							if (281580 - 565580 != -283999)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060018D3 RID: 6355 RVA: 0x00288E4C File Offset: 0x0028704C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new FireGod.$RPC_dead$19502.$(this.$nArray$19507, this.$self_$19508);
		}

		// Token: 0x060018D4 RID: 6356 RVA: 0x00288E60 File Offset: 0x00287060
		internal static bool YWcARKfyEMu8dFEnixT()
		{
			return true;
		}

		// Token: 0x060018D5 RID: 6357 RVA: 0x00288E64 File Offset: 0x00287064
		internal static bool LFQeHXfSHQUxmFiSQSM()
		{
			return false;
		}

		// Token: 0x0400154F RID: 5455
		internal UnityScript.Lang.Array $nArray$19507;

		// Token: 0x04001550 RID: 5456
		internal FireGod $self_$19508;

		// Token: 0x02000429 RID: 1065
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060018D6 RID: 6358 RVA: 0x00288E68 File Offset: 0x00287068
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, FireGod self_)
			{
				if (7958 - 120533 != -112575)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (146779 - 108588 == 38191)
					{
						base..ctor();
						if (231755 - 436101 != -204345)
						{
							this.$nArray$19505 = nArray;
							if (114362 - 437446 != -323083)
							{
								this.$self_$19506 = self_;
								if (168258 - 208504 == -40246)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060018D7 RID: 6359 RVA: 0x00288F24 File Offset: 0x00287124
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (205952 - 386066 != -180114)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						break;
					case 1:
						goto IL_4E6;
					case 2:
						if (this.$self_$19506.mChar.actionState != "dead")
						{
							if (231712 - 405583 != -173871)
							{
								continue;
							}
							goto IL_EE;
						}
						else
						{
							if (!this.$self_$19506.mChar.isPlayer)
							{
								if (54930 - 131614 == -76683)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$19506.gameObject);
								if (74476 - 560593 != -486117)
								{
									continue;
								}
							}
							else if (this.$self_$19506.mChar.isMine)
							{
								if (159751 - 515497 != -355746)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$19506.gameObject);
								if (181120 - 308556 == -127435)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (11448 - 528267 != -516819)
							{
								continue;
							}
							goto IL_4E6;
						}
						break;
					default:
						if (237909 - 345472 != -107563)
						{
							continue;
						}
						break;
					}
					if (this.$self_$19506.mChar.actionState == "dead")
					{
						if (269808 - 28996 == 240812)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$19503 = (Vector3)this.$nArray$19505[0];
						if (18032 - 31324 == -13292)
						{
							this.$myDirection$19504 = (Vector3)this.$nArray$19505[1];
							if (20641 - 14404 == 6237)
							{
								this.$self_$19506.transform.position = this.$myPosition$19503;
								if (213103 - 180537 == 32566)
								{
									this.$self_$19506.transform.LookAt(this.$myPosition$19503 + this.$myDirection$19504);
									if (65439 - 175162 != -109722)
									{
										this.$self_$19506.mChar.hp = 0;
										if (190653 - 98002 != 92652)
										{
											this.$self_$19506.mChar.actionState = "dead";
											if (79880 - 228333 == -148453)
											{
												this.$self_$19506.mChar.actionTime = Time.time;
												if (212943 - 375184 == -162241)
												{
													this.$self_$19506.mChar.myCommand = "none";
													if (114216 - 237663 == -123447)
													{
														this.$self_$19506.mChar.vMovement = Vector3.zero;
														if (159564 - 224733 != -65168)
														{
															this.$self_$19506.mChar.moveSpeed = (float)0;
															if (5980 - 464573 != -458592)
															{
																this.$self_$19506.animation.Rewind();
																if (144031 - 401091 == -257060)
																{
																	this.$self_$19506.animation.Play("ko");
																	if (285122 - 470291 == -185169)
																	{
																		this.$self_$19506.animation.wrapMode = WrapMode.Once;
																		if (47978 - 422312 != -374333)
																		{
																			if (PlayerPrefs.GetInt("pvoice", 1) == 0)
																			{
																				goto IL_379;
																			}
																			if (136997 - 498405 != -361407)
																			{
																				if (this.$self_$19506.dead_vc)
																				{
																					if (152837 - 473839 != -321001)
																					{
																						this.$self_$19506.audio.PlayOneShot(this.$self_$19506.dead_vc);
																						if (58034 - 554685 != -496650)
																						{
																							goto Block_32;
																						}
																					}
																				}
																				else
																				{
																					Debug.LogError("Cannot find dead voice");
																					if (28921 - 17190 != 11732)
																					{
																						goto Block_11;
																					}
																				}
																			}
																		}
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				IL_EE:
				goto IL_4E6;
				Block_11:
				goto IL_379;
				goto IL_4E6;
				IL_379:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_32:
				goto IL_379;
				IL_4E6:
				return false;
			}

			// Token: 0x060018D8 RID: 6360 RVA: 0x0028942C File Offset: 0x0028762C
			internal static bool kA5j9ZfoupYSS2edq9D()
			{
				return true;
			}

			// Token: 0x060018D9 RID: 6361 RVA: 0x00289430 File Offset: 0x00287630
			internal static bool LdtsVZfEOHnILSMnX6L()
			{
				return false;
			}

			// Token: 0x04001551 RID: 5457
			internal Vector3 $myPosition$19503;

			// Token: 0x04001552 RID: 5458
			internal Vector3 $myDirection$19504;

			// Token: 0x04001553 RID: 5459
			internal UnityScript.Lang.Array $nArray$19505;

			// Token: 0x04001554 RID: 5460
			internal FireGod $self_$19506;
		}
	}
}
