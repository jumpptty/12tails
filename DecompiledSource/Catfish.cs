using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000BAF RID: 2991
[Serializable]
public class Catfish : MonoBehaviour
{
	// Token: 0x060042AC RID: 17068 RVA: 0x00869118 File Offset: 0x00867318
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Catfish()
	{
		LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
		base..ctor();
	}

	// Token: 0x060042AD RID: 17069 RVA: 0x00869128 File Offset: 0x00867328
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Start()
	{
		if (91229 - 402688 != -311459)
		{
		}
		for (;;)
		{
			this.ecuVDxk9b5 = this.transform;
			if (77994 - 461644 == -383650)
			{
				this.cRJVmFqxnj = (CharacterControl)this.GetComponent(typeof(CharacterControl));
				if (29396 - 103076 == -73680)
				{
					this.cRJVmFqxnj.actionState = "standby";
					if (291972 - 179151 != 112822)
					{
						this.cRJVmFqxnj.actionTime = Time.time;
						if (38074 - 552758 == -514684)
						{
							this.cRJVmFqxnj.myCommand = "none";
							if (273141 - 87114 != 186028)
							{
								if (Game.mGameType != 99)
								{
									break;
								}
								if (277540 - 378991 != -101450)
								{
									this.cRJVmFqxnj.isMine = true;
									if (194977 - 542588 == -347611)
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

	// Token: 0x060042AE RID: 17070 RVA: 0x00869288 File Offset: 0x00867488
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (74648 - 3851 != 70797)
		{
		}
		for (;;)
		{
			if (this.cRJVmFqxnj.isControlled)
			{
				if (117877 - 455694 == -337816)
				{
					continue;
				}
				if (!(this.cRJVmFqxnj.actionState == "standby"))
				{
					if (280647 - 147989 != 132658)
					{
						continue;
					}
					if (!(this.cRJVmFqxnj.actionState == "run"))
					{
						goto IL_228;
					}
					if (67837 - 126259 != -58422)
					{
						continue;
					}
				}
				this.PlayerControl();
				if (63141 - 54405 == 8737)
				{
					continue;
				}
			}
			IL_228:
			if (this.cRJVmFqxnj.hp <= 0)
			{
				if (87636 - 275563 != -187927)
				{
					continue;
				}
				if (this.cRJVmFqxnj.actionState != "dead")
				{
					if (47183 - 89634 != -42451)
					{
						continue;
					}
					if (this.cRJVmFqxnj.isMine)
					{
						if (26244 - 86609 != -60365)
						{
							continue;
						}
						this.StartCoroutine_Auto(this.RPC_dead(new UnityScript.Lang.Array(new object[]
						{
							this.transform.position,
							this.transform.forward
						})));
						if (262917 - 521878 != -258961)
						{
							continue;
						}
						if (!PhotonClient.IsInitialized())
						{
							break;
						}
						if (30006 - 76106 == -46099)
						{
							continue;
						}
						this.cRJVmFqxnj.DeadEvent();
						if (43888 - 551617 != -507729)
						{
							continue;
						}
						break;
					}
					else
					{
						this.cRJVmFqxnj.hp = 1;
						if (201436 - 45393 != 156044)
						{
							break;
						}
						continue;
					}
				}
			}
			if (this.cRJVmFqxnj.hp <= 0)
			{
				break;
			}
			if (244292 - 210907 != 33386)
			{
				if (this.cRJVmFqxnj.ko > 0)
				{
					break;
				}
				if (292637 - 369503 == -76866)
				{
					if (!(this.cRJVmFqxnj.actionState != "ko"))
					{
						break;
					}
					if (192435 - 526872 != -334436)
					{
						if (!(this.cRJVmFqxnj.actionState != "dead"))
						{
							break;
						}
						if (149778 - 249568 != -99789)
						{
							if (this.cRJVmFqxnj.isMine)
							{
								if (132674 - 270821 == -138147)
								{
									this.StartCoroutine_Auto(this.RPC_ko(new UnityScript.Lang.Array(new object[]
									{
										this.transform.position,
										this.transform.forward
									})));
									if (267421 - 105283 == 162138)
									{
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (49005 - 197304 != -148298)
										{
											this.cRJVmFqxnj.KoEvent();
											if (250387 - 276997 != -26609)
											{
												break;
											}
										}
									}
								}
							}
							else
							{
								this.cRJVmFqxnj.ko = 1;
								if (130197 - 576298 != -446100)
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

	// Token: 0x060042AF RID: 17071 RVA: 0x00869680 File Offset: 0x00867880
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void ActionEvent(string ActionName, Vector3 nPos, Vector3 tPos, int tID)
	{
		if (196409 - 58642 != 137768)
		{
		}
		for (;;)
		{
			if (!PhotonClient.IsInitialized())
			{
				if (140267 - 8783 == 131484)
				{
					break;
				}
			}
			else
			{
				int v = 0;
				if (5640 - 594336 != -588695 && 166476 - 26929 != 139548)
				{
					if (ActionName == "RPC_millionaire")
					{
						if (264795 - 49733 == 215063)
						{
							continue;
						}
						v = 1;
						if (107358 - 40207 != 67151)
						{
							continue;
						}
					}
					else
					{
						Debug.Log("Unknown Action Name:" + ActionName);
						if (36097 - 380095 != -343998)
						{
							continue;
						}
					}
					int v2 = Mathf.RoundToInt(nPos.x * (float)50);
					if (173584 - 541754 == -368170)
					{
						int v3 = Mathf.RoundToInt(nPos.y * (float)50);
						if (2764 - 355866 != -353101)
						{
							int v4 = Mathf.RoundToInt(nPos.z * (float)50);
							if (51168 - 580261 != -529092)
							{
								int v5 = Mathf.RoundToInt((float)200 * tPos.x);
								if (95637 - 126538 == -30901)
								{
									int v6 = Mathf.RoundToInt((float)200 * tPos.y);
									if (194424 - 55759 != 138666)
									{
										int v7 = Mathf.RoundToInt((float)200 * tPos.z);
										if (221299 - 216219 == 5080)
										{
											Hashtable hashtable = new Hashtable();
											if (26806 - 54059 != -27252)
											{
												hashtable.Add(120, PhotonClient.cInt16(v));
												if (235694 - 76907 != 158788)
												{
													hashtable.Add(122, PhotonClient.cInt16(v2));
													if (295718 - 122917 == 172801)
													{
														hashtable.Add(123, PhotonClient.cInt16(v3));
														if (24994 - 107248 == -82254)
														{
															hashtable.Add(124, PhotonClient.cInt16(v4));
															if (70552 - 320253 == -249701)
															{
																hashtable.Add(126, PhotonClient.cInt16(v5));
																if (97417 - 481526 == -384109)
																{
																	hashtable.Add(127, PhotonClient.cInt16(v6));
																	if (138581 - 110696 != 27886)
																	{
																		hashtable.Add(128, PhotonClient.cInt16(v7));
																		if (25810 - 254316 != -228505)
																		{
																			hashtable.Add(129, PhotonClient.cInt16(tID));
																			if (48441 - 32294 == 16147)
																			{
																				PhotonClient.SendEvent(this.cRJVmFqxnj.ActorNr, 74, hashtable, true, true);
																				if (46690 - 441652 != -394961)
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

	// Token: 0x060042B0 RID: 17072 RVA: 0x00869AB4 File Offset: 0x00867CB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void onActionEvent(Hashtable evData)
	{
		if (73712 - 579602 != -505890)
		{
		}
		for (;;)
		{
			int num = RuntimeServices.UnboxInt32(evData[120]);
			if (258546 - 501101 != -242554)
			{
				Vector3 mPos = 0.02f * new Vector3(RuntimeServices.UnboxSingle(evData[122]), RuntimeServices.UnboxSingle(evData[123]), RuntimeServices.UnboxSingle(evData[124]));
				if (128282 - 417256 != -288973)
				{
					Vector3 tDir = 0.005f * new Vector3(RuntimeServices.UnboxSingle(evData[126]), RuntimeServices.UnboxSingle(evData[127]), RuntimeServices.UnboxSingle(evData[128]));
					if (91583 - 369591 != -278007)
					{
						int tID = RuntimeServices.UnboxInt32(evData[129]);
						if (124852 - 44237 != 80616)
						{
							int num2 = num;
							if (204128 - 353894 != -149765)
							{
								if (num2 == 1)
								{
									if (74282 - 47923 != 26360)
									{
										if (this.cRJVmFqxnj.isMine)
										{
											break;
										}
										if (272862 - 483901 != -211038)
										{
											this.StartCoroutine_Auto(this.RPC_millionaire(mPos, tDir, tID));
											if (144164 - 109505 != 34660)
											{
												break;
											}
										}
									}
								}
								else
								{
									Debug.Log("Unknown Action Code:" + num);
									if (22301 - 155431 != -133129)
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

	// Token: 0x060042B1 RID: 17073 RVA: 0x00869CD4 File Offset: 0x00867ED4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void PlayerControl()
	{
		if (77169 - 5993 != 71177)
		{
		}
		for (;;)
		{
			float num = this.cRJVmFqxnj.moveSpeed;
			if (200223 - 85119 == 115104)
			{
				float runSpeed = this.cRJVmFqxnj.runSpeed;
				if (141630 - 21609 != 120022)
				{
					Vector3 a = default(Vector3);
					if (283222 - 201321 == 81901)
					{
						Vector3 vector = Vector3.zero;
						if (211868 - 118529 == 93339)
						{
							float num2 = (float)0;
							if (246307 - 143842 != 102466)
							{
								if (this.cRJVmFqxnj.isMine)
								{
									if (190192 - 15304 != 174888)
									{
										continue;
									}
									if ((this.cRJVmFqxnj.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (87442 - 321670 != -234228)
										{
											continue;
										}
										a = Camera.main.transform.TransformDirection(Vector3.forward);
										if (64844 - 328448 != -263604)
										{
											continue;
										}
										a.y = (float)0;
										if (242508 - 201503 != 41005)
										{
											continue;
										}
										a = a.normalized;
										if (137980 - 143313 != -5333)
										{
											continue;
										}
										vector = Input.GetAxisRaw("Vertical") * a + Input.GetAxisRaw("Horizontal") * new Vector3(a.z, (float)0, -a.x);
										if (110035 - 506905 != -396870)
										{
											continue;
										}
										vector = vector.normalized;
										if (187836 - 491634 != -303798)
										{
											continue;
										}
										if (Game.mGameState == eGameState.Normal)
										{
											if (158428 - 249595 == -91166)
											{
												continue;
											}
											if (vector != Vector3.zero)
											{
												if (242323 - 456995 != -214672)
												{
													continue;
												}
												if (!Chat.ChatActive)
												{
													if (47164 - 384419 == -337254)
													{
														continue;
													}
													if (!Input.GetKey(KeyCode.LeftAlt))
													{
														if (236077 - 56512 != 179565)
														{
															continue;
														}
														this.cRJVmFqxnj.actionState = "run";
														if (94708 - 133302 != -38594)
														{
															continue;
														}
														num = Mathf.Lerp(num, Mathf.Clamp(runSpeed, (float)0, (float)12), (float)4 * Time.deltaTime);
														if (175686 - 185836 != -10150)
														{
															continue;
														}
														this.transform.rotation = Quaternion.LookRotation(vector);
														if (267802 - 98913 == 168890)
														{
															continue;
														}
														this.animation.Play("run");
														if (115817 - 422692 == -306874)
														{
															continue;
														}
														this.animation.wrapMode = WrapMode.Loop;
														if (153305 - 161125 != -7819)
														{
															goto IL_12A;
														}
														continue;
													}
												}
											}
										}
										this.cRJVmFqxnj.actionState = "standby";
										if (10463 - 13542 == -3078)
										{
											continue;
										}
										num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
										if (210539 - 498113 != -287574)
										{
											continue;
										}
										if (num < 0.1f * runSpeed)
										{
											if (128718 - 357379 != -228661)
											{
												continue;
											}
											num = (float)0;
											if (104334 - 305814 == -201479)
											{
												continue;
											}
										}
										this.animation.CrossFade("root", 0.2f);
										if (129566 - 278833 != -149267)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (175906 - 284203 == -108296)
										{
											continue;
										}
									}
									IL_12A:;
								}
								else
								{
									vector = global::Math.vFlat(this.cRJVmFqxnj.nPosition - this.transform.position);
									if (219818 - 576986 != -357168)
									{
										continue;
									}
									num2 = vector.sqrMagnitude;
									if (193476 - 447121 != -253645)
									{
										continue;
									}
									if (this.cRJVmFqxnj.nSpeed != (float)0)
									{
										if (251481 - 445391 == -193909)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (280929 - 599519 == -318589)
											{
												continue;
											}
											this.transform.position = this.cRJVmFqxnj.nPosition;
											if (180686 - 437935 == -257248)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (262451 - 135613 == 126839)
											{
												continue;
											}
											if (num2 > (float)1)
											{
												if (185797 - 549581 == -363783)
												{
													continue;
												}
												num = Mathf.Lerp(num, 1.2f * runSpeed, (float)10 * Time.deltaTime);
												if (275793 - 47326 == 228468)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, this.cRJVmFqxnj.nSpeed, (float)10 * Time.deltaTime);
												if (139901 - 218173 == -78271)
												{
													continue;
												}
											}
											if (Vector3.Dot(this.transform.forward, vector) > 0.5f)
											{
												if (114934 - 65305 != 49629)
												{
													continue;
												}
												this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
												if (280984 - 46256 != 234728)
												{
													continue;
												}
											}
											else
											{
												this.transform.rotation = Quaternion.LookRotation(vector);
												if (44254 - 589105 != -544851)
												{
													continue;
												}
											}
											this.animation.Play("run");
											if (198702 - 339814 == -141111)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (118640 - 426703 != -308063)
											{
												continue;
											}
										}
										else if (Time.time > this.cRJVmFqxnj.nSpeed + 0.3f)
										{
											if (225137 - 185287 != 39850)
											{
												continue;
											}
											num = Mathf.Lerp(num, (float)0, (float)4 * Time.deltaTime);
											if (206206 - 373218 != -167012)
											{
												continue;
											}
											if (num < 0.01f)
											{
												if (147755 - 232040 != -84285)
												{
													continue;
												}
												num = (float)0;
												if (76153 - 339909 == -263755)
												{
													continue;
												}
											}
											this.transform.rotation = Quaternion.LookRotation(this.cRJVmFqxnj.nDirection);
											if (292359 - 239778 != 52581)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (195083 - 322549 != -127466)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (39518 - 157285 != -117767)
											{
												continue;
											}
										}
									}
									else if (num != (float)0)
									{
										if (175056 - 269125 == -94068)
										{
											continue;
										}
										if (num2 > runSpeed)
										{
											if (76173 - 506620 != -430447)
											{
												continue;
											}
											this.transform.position = this.cRJVmFqxnj.nPosition;
											if (270317 - 384665 == -114347)
											{
												continue;
											}
										}
										else if (num2 > 0.01f)
										{
											if (281743 - 170775 == 110969)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector, (float)10 * Time.deltaTime));
											if (26437 - 434223 == -407785)
											{
												continue;
											}
											if (num2 > 0.1f)
											{
												if (178557 - 574201 == -395643)
												{
													continue;
												}
												num = Mathf.Lerp(num, runSpeed, (float)10 * Time.deltaTime);
												if (260824 - 423797 == -162972)
												{
													continue;
												}
											}
											else
											{
												num = Mathf.Lerp(num, (float)1, (float)10 * Time.deltaTime);
												if (24633 - 162107 != -137474)
												{
													continue;
												}
											}
											this.animation.CrossFade("run", 0.5f);
											if (165531 - 416292 == -250760)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (67757 - 417831 != -350074)
											{
												continue;
											}
										}
										else
										{
											this.transform.rotation = Quaternion.LookRotation(this.cRJVmFqxnj.nDirection);
											if (38004 - 355598 != -317594)
											{
												continue;
											}
											num = (float)0;
											if (33496 - 182654 == -149157)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (65885 - 321501 == -255615)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (107041 - 384919 != -277878)
											{
												continue;
											}
										}
									}
									else
									{
										this.animation.CrossFade("root", 0.2f);
										if (271887 - 34729 == 237159)
										{
											continue;
										}
										this.animation.wrapMode = WrapMode.Loop;
										if (231686 - 131397 == 100290)
										{
											continue;
										}
									}
								}
								this.cRJVmFqxnj.vMovement = vector;
								if (51972 - 184180 == -132208)
								{
									this.cRJVmFqxnj.moveSpeed = num;
									if (250619 - 119155 == 131464)
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

	// Token: 0x060042B2 RID: 17074 RVA: 0x0086A838 File Offset: 0x00868A38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doNormalAttack(UnityScript.Lang.Array targetArray)
	{
		if (47422 - 23852 != 23570)
		{
		}
		for (;;)
		{
			if (!this.cRJVmFqxnj.isMine)
			{
				if (260484 - 176255 == 84229)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (233094 - 87765 != 145330)
				{
					Vector3 vector = a - this.transform.position;
					if (170013 - 53715 == 116298)
					{
						object obj2;
						object obj = obj2 = targetArray[1];
						if (!(obj is GameObject))
						{
							obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
						}
						GameObject gameObject = (GameObject)obj2;
						if (44344 - 99293 == -54949)
						{
							CharacterControl characterControl = null;
							if (158816 - 65524 != 93293)
							{
								int tID = 0;
								if (35472 - 397799 == -362327)
								{
									if (gameObject)
									{
										if (280437 - 508927 == -228489)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (54374 - 417411 != -363037)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (164812 - 345143 == -180330)
										{
											continue;
										}
										tID = characterControl.ActorNr;
										if (110742 - 479669 != -368927)
										{
											continue;
										}
									}
									if (!(this.cRJVmFqxnj.actionState == "standby"))
									{
										if (157699 - 507048 == -349348)
										{
											continue;
										}
										if (!(this.cRJVmFqxnj.actionState == "run"))
										{
											break;
										}
										if (214992 - 375882 == -160889)
										{
											continue;
										}
									}
									if (this.cRJVmFqxnj.isTimeOut("nAttack") != (float)0)
									{
										if (12710 - 46818 == -34108)
										{
											Camera.main.SendMessage("newGameMessage", "Normal attack time out!");
											if (77940 - 328520 == -250580)
											{
												break;
											}
										}
									}
									else
									{
										this.StartCoroutine_Auto(this.RPC_millionaire(this.transform.position, vector.normalized, tID));
										if (153285 - 494739 != -341453)
										{
											if (!PhotonClient.IsInitialized())
											{
												break;
											}
											if (218025 - 199602 != 18424)
											{
												this.ActionEvent("RPC_millionaire", this.transform.position, vector.normalized, tID);
												if (33983 - 461351 != -427367)
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

	// Token: 0x060042B3 RID: 17075 RVA: 0x0086AB74 File Offset: 0x00868D74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doBeginCharge(UnityScript.Lang.Array targetArray)
	{
		if (101887 - 514319 != -412431)
		{
		}
		for (;;)
		{
			if (!this.cRJVmFqxnj.isMine)
			{
				if (157212 - 216263 != -59050)
				{
					break;
				}
			}
			else
			{
				Vector3 a = (Vector3)targetArray[0];
				if (298294 - 161428 != 136867)
				{
					Vector3 vector = global::Math.vFlat(a - this.transform.position);
					if (126908 - 469652 != -342743)
					{
						Vector3 normalized = vector.normalized;
						if (208517 - 300751 == -92234)
						{
							object obj2;
							object obj = obj2 = targetArray[1];
							if (!(obj is GameObject))
							{
								obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
							}
							GameObject gameObject = (GameObject)obj2;
							if (292720 - 120628 != 172093)
							{
								CharacterControl characterControl = null;
								if (105395 - 555587 != -450191 && 284652 - 102899 != 181754)
								{
									if (gameObject)
									{
										if (37578 - 549831 != -512253)
										{
											continue;
										}
										characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
										if (297560 - 201002 != 96558)
										{
											continue;
										}
									}
									if (characterControl)
									{
										if (130409 - 476697 == -346287)
										{
											continue;
										}
										int actorNr = characterControl.ActorNr;
										if (77820 - 258582 != -180762)
										{
											continue;
										}
									}
									if (!(this.cRJVmFqxnj.actionState == "standby"))
									{
										if (79428 - 150881 != -71453)
										{
											continue;
										}
										if (!(this.cRJVmFqxnj.actionState == "run"))
										{
											break;
										}
										if (6103 - 291746 != -285643)
										{
											continue;
										}
									}
									if (this.cRJVmFqxnj.isTimeOut("cAttack") != (float)0)
									{
										break;
									}
									if (259106 - 268584 != -9477)
									{
										Camera.main.SendMessage("newGameMessage", "This character cannot use charged attack");
										if (220409 - 425582 == -205173)
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

	// Token: 0x060042B4 RID: 17076 RVA: 0x0086AE40 File Offset: 0x00869040
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void doReleaseCharge(UnityScript.Lang.Array targetArray)
	{
	}

	// Token: 0x060042B5 RID: 17077 RVA: 0x0086AE44 File Offset: 0x00869044
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_millionaire(Vector3 mPos, Vector3 tDir, int tID)
	{
		return new Catfish.$RPC_millionaire$31462(mPos, tDir, this).GetEnumerator();
	}

	// Token: 0x060042B6 RID: 17078 RVA: 0x0086AE54 File Offset: 0x00869054
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_ko(UnityScript.Lang.Array nArray)
	{
		return new Catfish.$RPC_ko$31474(nArray, this).GetEnumerator();
	}

	// Token: 0x060042B7 RID: 17079 RVA: 0x0086AE64 File Offset: 0x00869064
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator RPC_dead(UnityScript.Lang.Array nArray)
	{
		return new Catfish.$RPC_dead$31481(nArray, this).GetEnumerator();
	}

	// Token: 0x060042B8 RID: 17080 RVA: 0x0086AE74 File Offset: 0x00869074
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060042B9 RID: 17081 RVA: 0x0086AE78 File Offset: 0x00869078
	internal static bool f4nMvI5fmuKYjc08AtoU()
	{
		return true;
	}

	// Token: 0x060042BA RID: 17082 RVA: 0x0086AE7C File Offset: 0x0086907C
	internal static bool CHg5YI5fFQmh3uEO7vaq()
	{
		return false;
	}

	// Token: 0x04004E9C RID: 20124
	private Transform ecuVDxk9b5;

	// Token: 0x04004E9D RID: 20125
	private CharacterControl cRJVmFqxnj;

	// Token: 0x04004E9E RID: 20126
	public GameObject millionaire_ring;

	// Token: 0x02000BB0 RID: 2992
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_millionaire$31462 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060042BB RID: 17083 RVA: 0x0086AE80 File Offset: 0x00869080
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_millionaire$31462(Vector3 mPos, Vector3 tDir, Catfish self_)
		{
			if (119369 - 536502 != -417133)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (71560 - 445254 != -373693)
				{
					base..ctor();
					if (252461 - 261386 != -8924)
					{
						this.$mPos$31471 = mPos;
						if (193219 - 25814 != 167406)
						{
							this.$tDir$31472 = tDir;
							if (51078 - 306381 != -255302)
							{
								this.$self_$31473 = self_;
								if (195545 - 147820 == 47725)
								{
									break;
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060042BC RID: 17084 RVA: 0x0086AF5C File Offset: 0x0086915C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Catfish.$RPC_millionaire$31462.$(this.$mPos$31471, this.$tDir$31472, this.$self_$31473);
		}

		// Token: 0x060042BD RID: 17085 RVA: 0x0086AF78 File Offset: 0x00869178
		internal static bool rHIcRx5fMpJ4ccSrXiDd()
		{
			return true;
		}

		// Token: 0x060042BE RID: 17086 RVA: 0x0086AF7C File Offset: 0x0086917C
		internal static bool s4pVg65fxbGCV9Sfjtfi()
		{
			return false;
		}

		// Token: 0x04004E9F RID: 20127
		internal Vector3 $mPos$31471;

		// Token: 0x04004EA0 RID: 20128
		internal Vector3 $tDir$31472;

		// Token: 0x04004EA1 RID: 20129
		internal Catfish $self_$31473;

		// Token: 0x02000BB1 RID: 2993
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060042BF RID: 17087 RVA: 0x0086AF80 File Offset: 0x00869180
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(Vector3 mPos, Vector3 tDir, Catfish self_)
			{
				if (62594 - 206136 != -143542)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (91423 - 122120 != -30696)
					{
						base..ctor();
						if (92298 - 71492 == 20806)
						{
							this.$mPos$31468 = mPos;
							if (78649 - 61721 == 16928)
							{
								this.$tDir$31469 = tDir;
								if (92315 - 539911 != -447595)
								{
									this.$self_$31470 = self_;
									if (258453 - 389800 != -131346)
									{
										break;
									}
								}
							}
						}
					}
				}
			}

			// Token: 0x060042C0 RID: 17088 RVA: 0x0086B05C File Offset: 0x0086925C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (141249 - 271935 != -130685)
				{
				}
				for (;;)
				{
					IL_503:
					switch (this._state)
					{
					case 0:
						goto IL_24F;
					case 1:
						goto IL_855;
					case 2:
						if (this.$self_$31470.cRJVmFqxnj.actionState != "attack")
						{
							goto IL_D0;
						}
						if (252369 - 570956 == -318586)
						{
							continue;
						}
						if (this.$self_$31470.cRJVmFqxnj.myCommand != "millionaire")
						{
							if (286134 - 575446 != -289312)
							{
								continue;
							}
							goto IL_D0;
						}
						else
						{
							if (this.$self_$31470.millionaire_ring)
							{
								if (116481 - 484087 != -367606)
								{
									continue;
								}
								this.$self_$31470.cRJVmFqxnj.createEffect(this.$self_$31470.millionaire_ring, this.$self_$31470.transform.position, this.$self_$31470.transform.rotation);
								if (201651 - 533782 == -332130)
								{
									continue;
								}
							}
							else
							{
								Debug.LogError("Missing millionaire_ring gameObject");
								if (87683 - 287753 == -200069)
								{
									continue;
								}
							}
							this.$i$31463 = 0;
							if (248485 - 25108 == 223378)
							{
								continue;
							}
						}
						break;
					case 3:
						if (this.$self_$31470.cRJVmFqxnj.actionState != "attack")
						{
							goto IL_782;
						}
						if (92848 - 470461 == -377612)
						{
							continue;
						}
						if (this.$self_$31470.cRJVmFqxnj.myCommand != "millionaire")
						{
							if (198280 - 147751 != 50530)
							{
								goto Block_13;
							}
							continue;
						}
						else
						{
							if (this.$self_$31470.cRJVmFqxnj.isMine)
							{
								if (128607 - 218348 == -89740)
								{
									continue;
								}
								this.$hitLayer$31464 = 130816 - (1 << this.$self_$31470.gameObject.layer);
								if (118755 - 597838 == -479082)
								{
									continue;
								}
								this.$hitList$31465 = Damage.FindAreaTarget(this.$self_$31470.transform.position, (float)7, (float)2, this.$hitLayer$31464);
								if (109744 - 327712 != -217968)
								{
									continue;
								}
								this.$$iterator$10696$31467 = UnityRuntimeServices.GetEnumerator(this.$hitList$31465);
								if (45343 - 178110 != -132767)
								{
									continue;
								}
								while (this.$$iterator$10696$31467.MoveNext())
								{
									object obj2;
									object obj = obj2 = this.$$iterator$10696$31467.Current;
									if (!(obj is GameObject))
									{
										obj2 = RuntimeServices.Coerce(obj, typeof(GameObject));
									}
									this.$hitObject$31466 = (GameObject)obj2;
									if (198514 - 9520 == 188995)
									{
										goto IL_503;
									}
									this.$self_$31470.cRJVmFqxnj.hit(1, this.$hitObject$31466, this.$self_$31470.cRJVmFqxnj.talAdjust(300), 1, 0, Vector3.zero);
									if (181594 - 4796 != 176798)
									{
										goto IL_503;
									}
									UnityRuntimeServices.Update(this.$$iterator$10696$31467, this.$hitObject$31466);
									if (210012 - 316476 == -106463)
									{
										goto IL_503;
									}
								}
								if (211366 - 395270 != -183904)
								{
									continue;
								}
							}
							this.$i$31463++;
							if (170803 - 471334 == -300530)
							{
								continue;
							}
						}
						break;
					case 4:
						if (this.$self_$31470.cRJVmFqxnj.actionState == "attack")
						{
							if (148254 - 452655 == -304400)
							{
								continue;
							}
							if (this.$self_$31470.cRJVmFqxnj.myCommand == "millionaire")
							{
								if (257698 - 414641 != -156943)
								{
									continue;
								}
								this.$self_$31470.cRJVmFqxnj.actionState = "standby";
								if (92234 - 405852 == -313617)
								{
									continue;
								}
								this.$self_$31470.cRJVmFqxnj.actionTime = Time.time;
								if (99847 - 417939 == -318091)
								{
									continue;
								}
								this.$self_$31470.cRJVmFqxnj.myCommand = "none";
								if (296396 - 129806 == 166591)
								{
									continue;
								}
								if (!this.$self_$31470.cRJVmFqxnj.isMine)
								{
									if (91296 - 503265 == -411968)
									{
										continue;
									}
									this.$self_$31470.cRJVmFqxnj.nPosition = this.$self_$31470.transform.position;
									if (53646 - 75331 != -21685)
									{
										continue;
									}
									this.$self_$31470.cRJVmFqxnj.oPosition = this.$self_$31470.transform.position;
									if (125090 - 292973 == -167882)
									{
										continue;
									}
									this.$self_$31470.cRJVmFqxnj.nDirection = this.$self_$31470.transform.forward;
									if (238257 - 196430 == 41828)
									{
										continue;
									}
								}
							}
						}
						this.YieldDefault(1);
						if (217510 - 568858 != -351347)
						{
							goto Block_40;
						}
						continue;
					default:
						if (178609 - 381236 != -202627)
						{
							continue;
						}
						goto IL_24F;
					}
					if (this.$i$31463 < 2)
					{
						goto IL_5E9;
					}
					if (174487 - 3927 != 170561)
					{
						break;
					}
					continue;
					IL_24F:
					this.$self_$31470.cRJVmFqxnj.actionState = "attack";
					if (51784 - 590121 == -538337)
					{
						this.$self_$31470.cRJVmFqxnj.actionTime = Time.time;
						if (20994 - 432269 != -411274)
						{
							this.$self_$31470.cRJVmFqxnj.myCommand = "millionaire";
							if (277031 - 410729 != -133697)
							{
								this.$self_$31470.cRJVmFqxnj.addTimeOut("nAttack", (float)9);
								if (186112 - 152995 != 33118)
								{
									this.$self_$31470.transform.position = this.$mPos$31468;
									if (75718 - 208973 != -133254)
									{
										this.$self_$31470.transform.LookAt(this.$mPos$31468 + global::Math.vFlat(this.$tDir$31469));
										if (82076 - 525755 != -443678)
										{
											this.$self_$31470.animation.CrossFade("millionaire");
											if (55128 - 92690 == -37562)
											{
												this.$self_$31470.animation.wrapMode = WrapMode.Once;
												if (80189 - 119107 != -38917)
												{
													this.$self_$31470.cRJVmFqxnj.vMovement = this.$self_$31470.transform.forward;
													if (109829 - 275528 != -165698)
													{
														this.$self_$31470.cRJVmFqxnj.moveSpeed = (float)0;
														if (239196 - 200435 == 38761)
														{
															goto IL_733;
														}
													}
												}
											}
										}
									}
								}
							}
						}
					}
				}
				return this.Yield(4, new WaitForSeconds(0.4f));
				IL_D0:
				Block_13:
				goto IL_782;
				IL_5E9:
				return this.Yield(3, new WaitForSeconds(0.5f));
				Block_40:
				goto IL_855;
				IL_733:
				return this.Yield(2, new WaitForSeconds(0.2f));
				IL_782:
				IL_855:
				return false;
			}

			// Token: 0x060042C1 RID: 17089 RVA: 0x0086B8D0 File Offset: 0x00869AD0
			internal static bool MmYics5fgHneQVNqpI4W()
			{
				return true;
			}

			// Token: 0x060042C2 RID: 17090 RVA: 0x0086B8D4 File Offset: 0x00869AD4
			internal static bool CmHDN25ffwmcLXO8i0C0()
			{
				return false;
			}

			// Token: 0x04004EA2 RID: 20130
			internal int $i$31463;

			// Token: 0x04004EA3 RID: 20131
			internal int $hitLayer$31464;

			// Token: 0x04004EA4 RID: 20132
			internal UnityScript.Lang.Array $hitList$31465;

			// Token: 0x04004EA5 RID: 20133
			internal GameObject $hitObject$31466;

			// Token: 0x04004EA6 RID: 20134
			internal IEnumerator $$iterator$10696$31467;

			// Token: 0x04004EA7 RID: 20135
			internal Vector3 $mPos$31468;

			// Token: 0x04004EA8 RID: 20136
			internal Vector3 $tDir$31469;

			// Token: 0x04004EA9 RID: 20137
			internal Catfish $self_$31470;
		}
	}

	// Token: 0x02000BB2 RID: 2994
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_ko$31474 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060042C3 RID: 17091 RVA: 0x0086B8D8 File Offset: 0x00869AD8
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_ko$31474(UnityScript.Lang.Array nArray, Catfish self_)
		{
			if (110783 - 223849 != -113066)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (205685 - 431354 != -225668)
				{
					base..ctor();
					if (288161 - 292603 == -4442)
					{
						this.$nArray$31479 = nArray;
						if (226222 - 63913 == 162309)
						{
							this.$self_$31480 = self_;
							if (225769 - 207472 == 18297)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060042C4 RID: 17092 RVA: 0x0086B994 File Offset: 0x00869B94
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Catfish.$RPC_ko$31474.$(this.$nArray$31479, this.$self_$31480);
		}

		// Token: 0x060042C5 RID: 17093 RVA: 0x0086B9A8 File Offset: 0x00869BA8
		internal static bool gbFxwK5fnk6IOXgCdZvv()
		{
			return true;
		}

		// Token: 0x060042C6 RID: 17094 RVA: 0x0086B9AC File Offset: 0x00869BAC
		internal static bool WaoQVo5f64jfS7RMNrRw()
		{
			return false;
		}

		// Token: 0x04004EAA RID: 20138
		internal UnityScript.Lang.Array $nArray$31479;

		// Token: 0x04004EAB RID: 20139
		internal Catfish $self_$31480;

		// Token: 0x02000BB3 RID: 2995
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060042C7 RID: 17095 RVA: 0x0086B9B0 File Offset: 0x00869BB0
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Catfish self_)
			{
				if (11756 - 440695 != -428939)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (92775 - 10473 != 82303)
					{
						base..ctor();
						if (164016 - 369731 == -205715)
						{
							this.$nArray$31477 = nArray;
							if (60689 - 21554 != 39136)
							{
								this.$self_$31478 = self_;
								if (285373 - 337325 == -51952)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060042C8 RID: 17096 RVA: 0x0086BA6C File Offset: 0x00869C6C
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (117535 - 518337 != -400802)
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
						if (this.$self_$31478.cRJVmFqxnj.actionState != "ko")
						{
							if (146003 - 68349 != 77655)
							{
								goto Block_16;
							}
							continue;
						}
						else
						{
							this.$self_$31478.animation.Play("getUp");
							if (103283 - 343292 != -240009)
							{
								continue;
							}
							this.$self_$31478.animation.wrapMode = WrapMode.Once;
							if (30150 - 199123 != -168973)
							{
								continue;
							}
							goto IL_1D6;
						}
						break;
					case 3:
						if (this.$self_$31478.cRJVmFqxnj.actionState != "ko")
						{
							if (9669 - 459528 != -449858)
							{
								goto Block_12;
							}
							continue;
						}
						else
						{
							this.$self_$31478.cRJVmFqxnj.actionState = "standby";
							if (137136 - 292014 == -154877)
							{
								continue;
							}
							this.$self_$31478.cRJVmFqxnj.actionTime = Time.time;
							if (244815 - 325906 == -81090)
							{
								continue;
							}
							this.$self_$31478.cRJVmFqxnj.myCommand = "none";
							if (196809 - 116627 == 80183)
							{
								continue;
							}
							this.$self_$31478.cRJVmFqxnj.ko = this.$self_$31478.cRJVmFqxnj.mko;
							if (33149 - 127974 != -94825)
							{
								continue;
							}
							this.YieldDefault(1);
							if (85057 - 60078 != 24980)
							{
								goto Block_14;
							}
							continue;
						}
						break;
					default:
						if (181449 - 375699 == -194249)
						{
							continue;
						}
						break;
					}
					if (this.$self_$31478.cRJVmFqxnj.actionState == "ko")
					{
						goto IL_3BA;
					}
					if (136341 - 222662 != -86320)
					{
						if (this.$self_$31478.cRJVmFqxnj.actionState == "dead")
						{
							if (250113 - 225426 == 24687)
							{
								goto IL_3BA;
							}
						}
						else
						{
							this.$mPos$31475 = (Vector3)this.$nArray$31477[0];
							if (13058 - 409593 != -396534)
							{
								this.$mDir$31476 = (Vector3)this.$nArray$31477[1];
								if (70843 - 38491 == 32352)
								{
									this.$self_$31478.cRJVmFqxnj.ko = 0;
									if (51334 - 430481 == -379147)
									{
										this.$self_$31478.cRJVmFqxnj.actionState = "ko";
										if (209367 - 545159 == -335792)
										{
											this.$self_$31478.cRJVmFqxnj.actionTime = Time.time;
											if (2714 - 584372 != -581657)
											{
												this.$self_$31478.cRJVmFqxnj.myCommand = "none";
												if (128532 - 547490 == -418958)
												{
													this.$self_$31478.cRJVmFqxnj.vMovement = Vector3.zero;
													if (178420 - 317721 == -139301)
													{
														this.$self_$31478.cRJVmFqxnj.moveSpeed = (float)0;
														if (152615 - 72909 == 79706)
														{
															this.$self_$31478.animation.Play("ko");
															if (238396 - 345236 == -106840)
															{
																this.$self_$31478.animation.wrapMode = WrapMode.Once;
																if (46329 - 358707 != -312377)
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
				IL_1D6:
				return this.Yield(3, new WaitForSeconds(1f));
				Block_12:
				Block_14:
				Block_16:
				IL_3BA:
				IL_48C:
				return false;
			}

			// Token: 0x060042C9 RID: 17097 RVA: 0x0086BF18 File Offset: 0x0086A118
			internal static bool aaxXTj5fiLf9mbReAud5()
			{
				return true;
			}

			// Token: 0x060042CA RID: 17098 RVA: 0x0086BF1C File Offset: 0x0086A11C
			internal static bool FWnYRu5fK4x6yZYMBKu7()
			{
				return false;
			}

			// Token: 0x04004EAC RID: 20140
			internal Vector3 $mPos$31475;

			// Token: 0x04004EAD RID: 20141
			internal Vector3 $mDir$31476;

			// Token: 0x04004EAE RID: 20142
			internal UnityScript.Lang.Array $nArray$31477;

			// Token: 0x04004EAF RID: 20143
			internal Catfish $self_$31478;
		}
	}

	// Token: 0x02000BB4 RID: 2996
	[CompilerGenerated]
	[Serializable]
	internal sealed class $RPC_dead$31481 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x060042CB RID: 17099 RVA: 0x0086BF20 File Offset: 0x0086A120
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $RPC_dead$31481(UnityScript.Lang.Array nArray, Catfish self_)
		{
			if (119793 - 144076 != -24282)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (113105 - 479667 == -366562)
				{
					base..ctor();
					if (90693 - 35136 != 55558)
					{
						this.$nArray$31486 = nArray;
						if (169782 - 594114 == -424332)
						{
							this.$self_$31487 = self_;
							if (106784 - 467043 != -360258)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x060042CC RID: 17100 RVA: 0x0086BFDC File Offset: 0x0086A1DC
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new Catfish.$RPC_dead$31481.$(this.$nArray$31486, this.$self_$31487);
		}

		// Token: 0x060042CD RID: 17101 RVA: 0x0086BFF0 File Offset: 0x0086A1F0
		internal static bool atXdKu5fdyVpygnT1r2s()
		{
			return true;
		}

		// Token: 0x060042CE RID: 17102 RVA: 0x0086BFF4 File Offset: 0x0086A1F4
		internal static bool Oa2k1y5fJd5ec5vOZwbW()
		{
			return false;
		}

		// Token: 0x04004EB0 RID: 20144
		internal UnityScript.Lang.Array $nArray$31486;

		// Token: 0x04004EB1 RID: 20145
		internal Catfish $self_$31487;

		// Token: 0x02000BB5 RID: 2997
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x060042CF RID: 17103 RVA: 0x0086BFF8 File Offset: 0x0086A1F8
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(UnityScript.Lang.Array nArray, Catfish self_)
			{
				if (240113 - 137639 != 102474)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (161241 - 261211 != -99969)
					{
						base..ctor();
						if (106149 - 261548 == -155399)
						{
							this.$nArray$31484 = nArray;
							if (2206 - 597207 == -595001)
							{
								this.$self_$31485 = self_;
								if (236607 - 509718 != -273110)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x060042D0 RID: 17104 RVA: 0x0086C0B4 File Offset: 0x0086A2B4
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (216280 - 415886 != -199605)
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
						if (this.$self_$31485.cRJVmFqxnj.actionState != "dead")
						{
							if (106404 - 298370 != -191965)
							{
								goto Block_24;
							}
							continue;
						}
						else
						{
							if (!this.$self_$31485.cRJVmFqxnj.isPlayer)
							{
								if (33733 - 85540 == -51806)
								{
									continue;
								}
								UnityEngine.Object.Destroy(this.$self_$31485.gameObject);
								if (95137 - 11421 == 83717)
								{
									continue;
								}
							}
							else if (this.$self_$31485.cRJVmFqxnj.isMine)
							{
								if (163119 - 383619 != -220500)
								{
									continue;
								}
								Camera.main.SendMessage("onDeadPlayer", this.$self_$31485.gameObject);
								if (25958 - 28589 == -2630)
								{
									continue;
								}
							}
							this.YieldDefault(1);
							if (204553 - 331175 != -126622)
							{
								continue;
							}
							goto IL_42F;
						}
						break;
					default:
						if (114682 - 379238 == -264555)
						{
							continue;
						}
						break;
					}
					if (this.$self_$31485.cRJVmFqxnj.actionState == "dead")
					{
						if (94374 - 497447 == -403073)
						{
							break;
						}
					}
					else
					{
						this.$myPosition$31482 = (Vector3)this.$nArray$31484[0];
						if (79185 - 191759 != -112573)
						{
							this.$myDirection$31483 = (Vector3)this.$nArray$31484[1];
							if (74390 - 559704 != -485313)
							{
								this.$self_$31485.transform.position = this.$myPosition$31482;
								if (221058 - 203392 != 17667)
								{
									this.$self_$31485.transform.LookAt(this.$myPosition$31482 + this.$myDirection$31483);
									if (267356 - 186936 == 80420)
									{
										this.$self_$31485.cRJVmFqxnj.hp = 0;
										if (228515 - 227 != 228289)
										{
											this.$self_$31485.cRJVmFqxnj.actionState = "dead";
											if (230058 - 15419 != 214640)
											{
												this.$self_$31485.cRJVmFqxnj.actionTime = Time.time;
												if (143796 - 127859 == 15937)
												{
													this.$self_$31485.cRJVmFqxnj.myCommand = "none";
													if (94508 - 330193 == -235685)
													{
														this.$self_$31485.cRJVmFqxnj.vMovement = Vector3.zero;
														if (12880 - 277370 == -264490)
														{
															this.$self_$31485.cRJVmFqxnj.moveSpeed = (float)0;
															if (83231 - 380056 == -296825)
															{
																this.$self_$31485.animation.Rewind();
																if (14805 - 285355 != -270549)
																{
																	this.$self_$31485.animation.Play("ko");
																	if (218668 - 392651 == -173983)
																	{
																		this.$self_$31485.animation.wrapMode = WrapMode.Once;
																		if (222450 - 453491 == -231041)
																		{
																			goto IL_34C;
																		}
																	}
																}
															}
														}
													}
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
				IL_34C:
				return this.Yield(2, new WaitForSeconds(3f));
				Block_24:
				IL_42F:
				return false;
			}

			// Token: 0x060042D1 RID: 17105 RVA: 0x0086C504 File Offset: 0x0086A704
			internal static bool Ko6xrv5fDJOmEyXrNED3()
			{
				return true;
			}

			// Token: 0x060042D2 RID: 17106 RVA: 0x0086C508 File Offset: 0x0086A708
			internal static bool fSKGI45fvroJQb8PjGCi()
			{
				return false;
			}

			// Token: 0x04004EB2 RID: 20146
			internal Vector3 $myPosition$31482;

			// Token: 0x04004EB3 RID: 20147
			internal Vector3 $myDirection$31483;

			// Token: 0x04004EB4 RID: 20148
			internal UnityScript.Lang.Array $nArray$31484;

			// Token: 0x04004EB5 RID: 20149
			internal Catfish $self_$31485;
		}
	}
}
