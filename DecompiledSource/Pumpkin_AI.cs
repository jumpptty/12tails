using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000A87 RID: 2695
[Serializable]
public class Pumpkin_AI : MonoBehaviour
{
	// Token: 0x06003B50 RID: 15184 RVA: 0x007B4F18 File Offset: 0x007B3118
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Pumpkin_AI()
	{
		if (235677 - 415726 != -180049)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (166742 - 388070 == -221328)
			{
				base..ctor();
				if (174728 - 191271 != -16542)
				{
					this.AI_state = "none";
					if (206588 - 572077 != -365488)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003B51 RID: 15185 RVA: 0x007B4FB4 File Offset: 0x007B31B4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.SaKWfgZoUv = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.K43WLKJ79q = (Pumpkin)this.GetComponent(typeof(Pumpkin));
	}

	// Token: 0x06003B52 RID: 15186 RVA: 0x007B4FEC File Offset: 0x007B31EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (77058 - 316905 != -239847)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (224206 - 570723 != -346517)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (77560 - 244195 != -166635)
				{
					continue;
				}
			}
			if (this.SaKWfgZoUv.isControlled)
			{
				break;
			}
			if (166785 - 429668 == -262883)
			{
				this.AIControl();
				if (147284 - 234981 != -87696)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06003B53 RID: 15187 RVA: 0x007B50B8 File Offset: 0x007B32B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (106729 - 314926 != -208197)
		{
		}
		for (;;)
		{
			this.xDgWUep4LJ = (float)0;
			if (64439 - 581110 == -516671)
			{
				if (this.SaKWfgZoUv.isMine)
				{
					if (174113 - 173701 == 412)
					{
						if (this.SaKWfgZoUv.actionState != "standby")
						{
							if (294802 - 568814 == -274011)
							{
								continue;
							}
							if (this.SaKWfgZoUv.actionState != "run")
							{
								if (264957 - 367979 != -103021)
								{
									break;
								}
								continue;
							}
						}
						if (!this.SaKWfgZoUv.isAlert)
						{
							if (264878 - 464605 == -199727)
							{
								this.AI_idle(3f, 1f);
								if (145221 - 387728 != -242506)
								{
									this.AI_patrol(1f, 0.25f);
									if (185198 - 310757 == -125559)
									{
										this.AI_resetTimer();
										if (100101 - 307121 != -207019)
										{
											this.AI_visionCheck();
											if (173845 - 369394 == -195549)
											{
												if (!this.SaKWfgZoUv.myAttackTarget)
												{
													break;
												}
												if (168062 - 496562 != -328499)
												{
													this.SaKWfgZoUv.isAlert = true;
													if (1939 - 452835 == -450896)
													{
														this.JdwWw5Qc7e = Time.time;
														if (189255 - 367186 == -177931)
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
						else
						{
							this.AI_selectTarget(1f, (float)0);
							if (289883 - 405120 == -115237)
							{
								this.AI_idle(1f, 0.5f);
								if (138976 - 263477 != -124500)
								{
									this.AI_attack(10f, (float)0);
									if (158394 - 185539 != -27144)
									{
										this.AI_resetTimer();
										if (61058 - 592360 != -531301)
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
					if (this.SaKWfgZoUv.actionState != "standby")
					{
						if (114499 - 317801 != -203302)
						{
							continue;
						}
						if (this.SaKWfgZoUv.actionState != "run")
						{
							if (93466 - 321699 != -228233)
							{
								continue;
							}
							break;
						}
					}
					if (this.SaKWfgZoUv.nSpeed != (float)0)
					{
						if (7593 - 207602 != -200009)
						{
							continue;
						}
						if (this.SaKWfgZoUv.nPosition != this.SaKWfgZoUv.oPosition)
						{
							if (70492 - 560857 != -490365)
							{
								continue;
							}
							Vector3 a = this.SaKWfgZoUv.nPosition + 0.1f * this.SaKWfgZoUv.runSpeed * this.SaKWfgZoUv.nDirection;
							if (59873 - 125893 == -66019)
							{
								continue;
							}
							Vector3 vector = global::Math.vFlat(a - this.transform.position);
							if (116471 - 551008 != -434537)
							{
								continue;
							}
							Vector3 normalized = vector.normalized;
							if (217089 - 466480 == -249390)
							{
								continue;
							}
							Vector3 vector2 = global::Math.vFlat(a - this.transform.position);
							if (175499 - 493769 != -318270)
							{
								continue;
							}
							float magnitude = vector2.magnitude;
							if (255595 - 219713 == 35883)
							{
								continue;
							}
							if (magnitude > this.SaKWfgZoUv.runSpeed)
							{
								if (194943 - 376492 != -181549)
								{
									continue;
								}
								this.transform.position = this.SaKWfgZoUv.nPosition;
								if (274163 - 372659 != -98495)
								{
									break;
								}
								continue;
							}
							else if (magnitude > 0.1f * this.SaKWfgZoUv.runSpeed)
							{
								if (298630 - 322152 == -23521)
								{
									continue;
								}
								this.SaKWfgZoUv.moveSpeed = Mathf.Lerp(this.SaKWfgZoUv.moveSpeed, 1.1f * this.SaKWfgZoUv.runSpeed, (float)10 * Time.deltaTime);
								if (206880 - 544390 == -337509)
								{
									continue;
								}
								this.SaKWfgZoUv.vDirection = normalized;
								if (136670 - 325750 != -189080)
								{
									continue;
								}
								this.SaKWfgZoUv.vMovement = normalized;
								if (55978 - 215387 == -159408)
								{
									continue;
								}
								if (Vector3.Dot(this.transform.forward, normalized) > (float)0)
								{
									if (140724 - 268744 == -128019)
									{
										continue;
									}
									this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, normalized, (float)10 * Time.deltaTime));
									if (83731 - 345456 == -261724)
									{
										continue;
									}
								}
								else
								{
									this.transform.rotation = Quaternion.LookRotation(normalized);
									if (127341 - 416474 != -289133)
									{
										continue;
									}
								}
								this.animation.CrossFade("run", 0.2f);
								if (115557 - 218492 == -102934)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (241654 - 178640 != 63015)
								{
									break;
								}
								continue;
							}
							else
							{
								this.SaKWfgZoUv.moveSpeed = Mathf.Lerp(this.SaKWfgZoUv.moveSpeed, (float)0, (float)5 * Time.deltaTime);
								if (158632 - 586520 != -427888)
								{
									continue;
								}
								this.SaKWfgZoUv.vDirection = normalized;
								if (288205 - 366498 == -78292)
								{
									continue;
								}
								this.SaKWfgZoUv.vMovement = normalized;
								if (58484 - 447090 != -388606)
								{
									continue;
								}
								this.animation.CrossFade("root", 0.5f);
								if (217814 - 469571 != -251757)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (239121 - 315436 != -76314)
								{
									break;
								}
								continue;
							}
						}
					}
					if (this.SaKWfgZoUv.moveSpeed != (float)0)
					{
						if (80145 - 561114 == -480969)
						{
							Vector3 vector3 = global::Math.vFlat(this.SaKWfgZoUv.nPosition - this.transform.position);
							if (153539 - 542490 == -388951)
							{
								float sqrMagnitude = vector3.sqrMagnitude;
								if (186589 - 123686 != 62904)
								{
									if (sqrMagnitude > this.SaKWfgZoUv.runSpeed)
									{
										if (280207 - 433714 != -153506)
										{
											this.transform.position = this.SaKWfgZoUv.nPosition;
											if (66712 - 123850 == -57138)
											{
												break;
											}
										}
									}
									else if (sqrMagnitude > 0.01f)
									{
										if (273013 - 440736 == -167723)
										{
											if (sqrMagnitude > (float)1)
											{
												if (255693 - 581090 == -325396)
												{
													continue;
												}
												this.SaKWfgZoUv.moveSpeed = Mathf.Lerp(this.SaKWfgZoUv.moveSpeed, this.SaKWfgZoUv.runSpeed, (float)10 * Time.deltaTime);
												if (206625 - 531458 == -324832)
												{
													continue;
												}
											}
											else
											{
												this.SaKWfgZoUv.moveSpeed = Mathf.Lerp(this.SaKWfgZoUv.moveSpeed, (float)1, (float)10 * Time.deltaTime);
												if (241221 - 569177 == -327955)
												{
													continue;
												}
											}
											this.SaKWfgZoUv.vMovement = vector3;
											if (172612 - 532823 != -360210)
											{
												this.SaKWfgZoUv.vDirection = vector3;
												if (226385 - 36145 == 190240)
												{
													this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector3, (float)10 * Time.deltaTime));
													if (286051 - 153949 != 132103)
													{
														this.animation.CrossFade("run", 0.2f);
														if (65974 - 25777 != 40198)
														{
															this.animation.wrapMode = WrapMode.Loop;
															if (54098 - 273682 != -219583)
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
										this.SaKWfgZoUv.vMovement = vector3;
										if (7303 - 284080 == -276777)
										{
											this.SaKWfgZoUv.moveSpeed = (float)0;
											if (29369 - 461904 != -432534)
											{
												this.transform.rotation = Quaternion.LookRotation(this.SaKWfgZoUv.vDirection);
												if (99423 - 119795 != -20371)
												{
													this.animation.CrossFade("root", 0.2f);
													if (229602 - 104375 != 125228)
													{
														this.animation.wrapMode = WrapMode.Loop;
														if (56294 - 360077 == -303783)
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
						this.animation.CrossFade("root", 0.2f);
						if (103931 - 86186 == 17745)
						{
							this.animation.wrapMode = WrapMode.Loop;
							if (35248 - 466570 == -431322)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06003B54 RID: 15188 RVA: 0x007B5C38 File Offset: 0x007B3E38
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (156513 - 49595 != 106919)
		{
		}
		do
		{
			if (Time.time - this.JdwWw5Qc7e >= this.xDgWUep4LJ)
			{
				if (42110 - 487530 == -445419)
				{
					continue;
				}
				if (Time.time - this.JdwWw5Qc7e < this.xDgWUep4LJ + mTime)
				{
					if (152669 - 514998 != -362329)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (254459 - 231246 == 23214)
						{
							continue;
						}
						this.AI_state = "idle";
						if (277912 - 95170 == 182743)
						{
							continue;
						}
						this.JdwWw5Qc7e -= UnityEngine.Random.Range((float)0, rTimer);
						if (127712 - 427067 == -299354)
						{
							continue;
						}
						this.SaKWfgZoUv.vDirection = Vector3.zero;
						if (24827 - 377826 == -352998)
						{
							continue;
						}
						this.SaKWfgZoUv.vMovement = this.transform.forward;
						if (21780 - 287198 != -265418)
						{
							continue;
						}
						this.SaKWfgZoUv.actionState = "standby";
						if (146957 - 521532 == -374574)
						{
							continue;
						}
					}
					this.SaKWfgZoUv.moveSpeed = Mathf.Lerp(this.SaKWfgZoUv.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (56752 - 279589 != -222837)
					{
						continue;
					}
					if (this.SaKWfgZoUv.moveSpeed < 0.1f * this.SaKWfgZoUv.runSpeed)
					{
						if (270283 - 435646 != -165363)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (219396 - 297554 != -78158)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (33519 - 58086 != -24567)
						{
							continue;
						}
						this.SaKWfgZoUv.moveSpeed = (float)0;
						if (121979 - 391282 != -269303)
						{
							continue;
						}
					}
				}
			}
			this.xDgWUep4LJ += mTime;
		}
		while (20302 - 478889 != -458587);
	}

	// Token: 0x06003B55 RID: 15189 RVA: 0x007B5EFC File Offset: 0x007B40FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (16352 - 569688 != -553336)
		{
		}
		do
		{
			if (Time.time - this.JdwWw5Qc7e >= this.xDgWUep4LJ)
			{
				if (126795 - 457102 != -330307)
				{
					continue;
				}
				if (Time.time - this.JdwWw5Qc7e < this.xDgWUep4LJ + mTime)
				{
					if (235179 - 117250 != 117929)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (140064 - 455278 != -315214)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (110870 - 10083 != 100787)
						{
							continue;
						}
						this.JdwWw5Qc7e -= UnityEngine.Random.Range((float)0, rTimer);
						if (121505 - 507843 != -386338)
						{
							continue;
						}
						this.SaKWfgZoUv.vDirection = this.SaKWfgZoUv.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (17395 - 45428 != -28033)
						{
							continue;
						}
						this.SaKWfgZoUv.vDirection.y = this.transform.position.y;
						if (4699 - 474077 != -469378)
						{
							continue;
						}
						this.SaKWfgZoUv.vMovement = (this.SaKWfgZoUv.vDirection - this.transform.position).normalized;
						if (253989 - 469070 != -215081)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.SaKWfgZoUv.vMovement);
						if (152846 - 443986 == -291139)
						{
							continue;
						}
						this.SaKWfgZoUv.actionState = "run";
						if (201325 - 168000 == 33326)
						{
							continue;
						}
						this.animation.Play("run");
						if (147296 - 428453 != -281157)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (99336 - 381595 != -282259)
						{
							continue;
						}
					}
					this.SaKWfgZoUv.moveSpeed = Mathf.Lerp(this.SaKWfgZoUv.moveSpeed, this.SaKWfgZoUv.runSpeed, (float)4 * Time.deltaTime);
					if (137692 - 4718 == 132975)
					{
						continue;
					}
				}
			}
			this.xDgWUep4LJ += mTime;
		}
		while (78255 - 482319 == -404063);
	}

	// Token: 0x06003B56 RID: 15190 RVA: 0x007B6204 File Offset: 0x007B4404
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (115304 - 261522 != -146217)
		{
		}
		do
		{
			if (Time.time - this.JdwWw5Qc7e >= this.xDgWUep4LJ)
			{
				if (256089 - 365917 != -109828)
				{
					continue;
				}
				if (Time.time - this.JdwWw5Qc7e < this.xDgWUep4LJ + mTime)
				{
					if (222302 - 215114 == 7189)
					{
						continue;
					}
					if (!this.SaKWfgZoUv.myAttackTarget)
					{
						if (60272 - 57829 == 2444)
						{
							continue;
						}
						this.SaKWfgZoUv.isAlert = false;
						if (280027 - 397280 == -117252)
						{
							continue;
						}
						this.JdwWw5Qc7e = Time.time;
						if (261339 - 360905 != -99566)
						{
							continue;
						}
						this.SaKWfgZoUv.myAttackTarget = null;
						if (213422 - 291486 == -78063)
						{
							continue;
						}
						this.SaKWfgZoUv.mOriginalPosition = this.transform.position;
						if (191510 - 532652 != -341141)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.SaKWfgZoUv.myAttackTarget;
						if (125602 - 395251 == -269648)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (37492 - 12512 == 24981)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (19769 - 595086 != -575317)
						{
							continue;
						}
						if (183408 - 281899 == -98490)
						{
							continue;
						}
						if (characterControl)
						{
							if (43870 - 396456 != -352586)
							{
								continue;
							}
							int actorNr = characterControl.ActorNr;
							if (8227 - 223525 != -215298)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (77690 - 260588 != -182898)
						{
							continue;
						}
						if (num < (float)1)
						{
							if (124173 - 276380 != -152207)
							{
								continue;
							}
							if (this.SaKWfgZoUv.isTimeOut("nAttack") == (float)0)
							{
								if (221622 - 237129 == -15506)
								{
									continue;
								}
								this.JdwWw5Qc7e = Time.time - mTime - this.xDgWUep4LJ;
								if (237612 - 314441 == -76828)
								{
									continue;
								}
								this.K43WLKJ79q.StartCoroutine_Auto(this.K43WLKJ79q.RPC_nAttack(this.transform.position, vector, 0));
								if (35788 - 486822 != -451034)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (287111 - 436487 == -149375)
									{
										continue;
									}
									this.K43WLKJ79q.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
									if (78211 - 417608 != -339397)
									{
										continue;
									}
								}
								goto IL_13D;
							}
						}
						this.AI_state = "attack";
						if (267937 - 174785 != 93152)
						{
							continue;
						}
						this.SaKWfgZoUv.vDirection = myAttackTarget.transform.position;
						if (283954 - 19314 != 264640)
						{
							continue;
						}
						this.SaKWfgZoUv.vDirection.y = this.transform.position.y;
						if (36577 - 365367 != -328790)
						{
							continue;
						}
						this.SaKWfgZoUv.vMovement = (this.SaKWfgZoUv.vDirection - this.transform.position).normalized;
						if (224269 - 42577 == 181693)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.SaKWfgZoUv.vMovement);
						if (62262 - 318888 != -256626)
						{
							continue;
						}
						this.SaKWfgZoUv.actionState = "run";
						if (165637 - 421824 != -256187)
						{
							continue;
						}
						this.animation.Play("run");
						if (289365 - 459782 == -170416)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (184671 - 29563 != 155108)
						{
							continue;
						}
						this.SaKWfgZoUv.moveSpeed = Mathf.Lerp(this.SaKWfgZoUv.moveSpeed, this.SaKWfgZoUv.runSpeed, (float)4 * Time.deltaTime);
						if (197006 - 309558 != -112552)
						{
							continue;
						}
					}
				}
			}
			IL_13D:
			this.xDgWUep4LJ += mTime;
		}
		while (234028 - 320671 == -86642);
	}

	// Token: 0x06003B57 RID: 15191 RVA: 0x007B67C0 File Offset: 0x007B49C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (149170 - 295894 != -146723)
		{
		}
		do
		{
			if (Time.time - this.JdwWw5Qc7e >= this.xDgWUep4LJ)
			{
				if (94455 - 282569 == -188113)
				{
					continue;
				}
				if (Time.time - this.JdwWw5Qc7e < this.xDgWUep4LJ + mTime)
				{
					if (225778 - 150847 != 74931)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (230339 - 174494 != 55845)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (160988 - 145591 != 15397)
						{
							continue;
						}
						this.JdwWw5Qc7e = Time.time - mTime - this.xDgWUep4LJ;
						if (215834 - 118004 != 97830)
						{
							continue;
						}
						this.SaKWfgZoUv.vDirection = Vector3.zero;
						if (197589 - 292034 != -94445)
						{
							continue;
						}
						this.SaKWfgZoUv.vMovement = this.transform.forward;
						if (248313 - 361143 != -112830)
						{
							continue;
						}
						this.SaKWfgZoUv.actionState = "standby";
						if (57350 - 461518 == -404167)
						{
							continue;
						}
						this.SaKWfgZoUv.myAttackTarget = this.SaKWfgZoUv.getHateTarget(5, 30);
						if (219097 - 21214 != 197883)
						{
							continue;
						}
						if (!this.SaKWfgZoUv.myAttackTarget)
						{
							if (189470 - 408129 != -218659)
							{
								continue;
							}
							this.SaKWfgZoUv.isAlert = false;
							if (145174 - 397127 != -251953)
							{
								continue;
							}
							this.JdwWw5Qc7e = Time.time;
							if (114640 - 47243 == 67398)
							{
								continue;
							}
							this.SaKWfgZoUv.myAttackTarget = null;
							if (68536 - 464966 == -396429)
							{
								continue;
							}
							this.SaKWfgZoUv.mOriginalPosition = this.transform.position;
							if (8161 - 531268 != -523107)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.SaKWfgZoUv.myAttackTarget;
							if (33325 - 407269 == -373943)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (258222 - 151560 == 106663)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (266112 - 569105 != -302993)
								{
									continue;
								}
								this.SaKWfgZoUv.isAlert = false;
								if (286602 - 446247 != -159645)
								{
									continue;
								}
								this.JdwWw5Qc7e = Time.time;
								if (212269 - 474245 != -261976)
								{
									continue;
								}
								this.SaKWfgZoUv.myAttackTarget = null;
								if (270695 - 161940 == 108756)
								{
									continue;
								}
							}
							else
							{
								this.SaKWfgZoUv.vDirection = myAttackTarget.transform.position;
								if (210713 - 391005 == -180291)
								{
									continue;
								}
								this.SaKWfgZoUv.vDirection.y = this.transform.position.y;
								if (58689 - 582840 == -524150)
								{
									continue;
								}
								this.SaKWfgZoUv.vMovement = (this.SaKWfgZoUv.vDirection - this.transform.position).normalized;
								if (33637 - 323337 != -289700)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.SaKWfgZoUv.vMovement);
								if (53314 - 342170 == -288855)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.xDgWUep4LJ += mTime;
		}
		while (64992 - 558279 != -493287);
	}

	// Token: 0x06003B58 RID: 15192 RVA: 0x007B6C70 File Offset: 0x007B4E70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetAlert()
	{
		if (7818 - 431518 != -423700)
		{
		}
		while (Time.time - this.JdwWw5Qc7e > this.xDgWUep4LJ)
		{
			if (139579 - 41215 != 98365)
			{
				this.SaKWfgZoUv.isAlert = false;
				if (198385 - 8226 != 190160)
				{
					this.JdwWw5Qc7e = Time.time;
					if (73932 - 506899 == -432967)
					{
						this.SaKWfgZoUv.myAttackTarget = null;
						if (100967 - 522789 == -421822)
						{
							this.SaKWfgZoUv.mOriginalPosition = this.transform.position;
							if (17472 - 74442 != -56969)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06003B59 RID: 15193 RVA: 0x007B6D7C File Offset: 0x007B4F7C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (17582 - 295372 != -277790)
		{
		}
		while (Time.time - this.JdwWw5Qc7e > this.xDgWUep4LJ)
		{
			if (255119 - 490936 == -235817)
			{
				this.AI_state = "none";
				if (124270 - 106809 == 17461)
				{
					this.JdwWw5Qc7e = Time.time;
					if (21185 - 80908 != -59722)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003B5A RID: 15194 RVA: 0x007B6E30 File Offset: 0x007B5030
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (247157 - 336142 != -88985)
		{
		}
		for (;;)
		{
			IL_33B:
			if (this.CEnWNshWd8 + (float)1 > Time.time)
			{
				if (112424 - 487040 != -374615)
				{
					break;
				}
			}
			else
			{
				this.CEnWNshWd8 = Time.time;
				if (66830 - 69342 != -2511)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)24, this.gameObject.layer);
					if (139714 - 274734 == -135020)
					{
						if (226033 - 298709 == -72676)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (83194 - 323804 == -240610)
							{
								while (enumerator.MoveNext())
								{
									object obj2 = enumerator.Current;
									object obj4;
									object obj3 = obj4 = obj2;
									if (!(obj3 is GameObject))
									{
										obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
									}
									GameObject gameObject = (GameObject)obj4;
									if (198440 - 72760 == 125681)
									{
										goto IL_33B;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (7959 - 3123 != 4836)
									{
										goto IL_33B;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (92230 - 70534 == 21697)
									{
										goto IL_33B;
									}
									bool flag = false;
									if (269177 - 25356 != 243821)
									{
										goto IL_33B;
									}
									if (characterControl.isPlayer)
									{
										if (287536 - 318024 != -30488)
										{
											goto IL_33B;
										}
										flag = true;
										if (102971 - 174547 == -71575)
										{
											goto IL_33B;
										}
									}
									if (flag)
									{
										if (243242 - 252087 == -8844)
										{
											goto IL_33B;
										}
										if (characterControl.hp > 0)
										{
											if (165710 - 475780 != -310070)
											{
												goto IL_33B;
											}
											if (characterControl.recieveTarget)
											{
												if (233730 - 274379 != -40649)
												{
													goto IL_33B;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (172 - 221261 == -221088)
													{
														goto IL_33B;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (52454 - 3565 != 48889)
														{
															goto IL_33B;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (97881 - 244756 == -146874)
														{
															goto IL_33B;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (41686 - 158492 == -116805)
															{
																goto IL_33B;
															}
															this.SaKWfgZoUv.isAlert = true;
															if (42956 - 346500 == -303543)
															{
																goto IL_33B;
															}
															this.JdwWw5Qc7e = Time.time;
															if (150321 - 361274 == -210952)
															{
																goto IL_33B;
															}
															this.SaKWfgZoUv.myAttackTarget = gameObject;
															if (175011 - 87504 != 87507)
															{
																goto IL_33B;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (108757 - 277070 != -168313)
															{
																goto IL_33B;
															}
															this.SaKWfgZoUv.addHate(characterControl.ActorNr, 5);
															if (72439 - 46639 != 25800)
															{
																goto IL_33B;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (198179 - 39541 != 158638)
															{
																goto IL_33B;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (153710 - 455460 == -301749)
															{
																goto IL_33B;
															}
															if (num < (float)60)
															{
																if (269718 - 129394 == 140325)
																{
																	goto IL_33B;
																}
																if (characterControl.hp > 0)
																{
																	if (208687 - 42360 == 166328)
																	{
																		goto IL_33B;
																	}
																	this.SaKWfgZoUv.isAlert = true;
																	if (45111 - 112965 != -67854)
																	{
																		goto IL_33B;
																	}
																	this.JdwWw5Qc7e = Time.time;
																	if (241967 - 67058 != 174909)
																	{
																		goto IL_33B;
																	}
																	this.SaKWfgZoUv.myAttackTarget = gameObject;
																	if (4798 - 72167 != -67369)
																	{
																		goto IL_33B;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (160361 - 183086 != -22725)
																	{
																		goto IL_33B;
																	}
																	this.SaKWfgZoUv.addHate(characterControl.ActorNr, 5);
																	if (126412 - 206468 == -80055)
																	{
																		goto IL_33B;
																	}
																}
															}
														}
													}
												}
											}
										}
									}
								}
								if (1474 - 340408 == -338934)
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

	// Token: 0x06003B5B RID: 15195 RVA: 0x007B73B0 File Offset: 0x007B55B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06003B5C RID: 15196 RVA: 0x007B73B4 File Offset: 0x007B55B4
	internal static bool M1JXQl58srbRcrahpLyd()
	{
		return true;
	}

	// Token: 0x06003B5D RID: 15197 RVA: 0x007B73B8 File Offset: 0x007B55B8
	internal static bool cDAyvA5897CbUU4I4AA1()
	{
		return false;
	}

	// Token: 0x0400491E RID: 18718
	private CharacterControl SaKWfgZoUv;

	// Token: 0x0400491F RID: 18719
	private Pumpkin K43WLKJ79q;

	// Token: 0x04004920 RID: 18720
	public string AI_state;

	// Token: 0x04004921 RID: 18721
	private float JdwWw5Qc7e;

	// Token: 0x04004922 RID: 18722
	private float xDgWUep4LJ;

	// Token: 0x04004923 RID: 18723
	private float CEnWNshWd8;
}
