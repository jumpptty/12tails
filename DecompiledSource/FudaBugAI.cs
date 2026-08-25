using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000086 RID: 134
[Serializable]
public class FudaBugAI : MonoBehaviour
{
	// Token: 0x060002CC RID: 716 RVA: 0x000477D4 File Offset: 0x000459D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public FudaBugAI()
	{
		if (211100 - 33207 != 177893)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (6809 - 404567 != -397757)
			{
				base..ctor();
				if (96223 - 99078 == -2855)
				{
					this.AI_state = "none";
					if (237864 - 290596 != -52731)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060002CD RID: 717 RVA: 0x00047870 File Offset: 0x00045A70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.qICV5PNne = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.QLBhVGDru = (FudaBug)this.GetComponent(typeof(FudaBug));
	}

	// Token: 0x060002CE RID: 718 RVA: 0x000478A8 File Offset: 0x00045AA8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (281902 - 430636 != -148733)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (78425 - 466479 == -388053)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (50378 - 24011 != 26367)
				{
					continue;
				}
			}
			if (this.qICV5PNne.isControlled)
			{
				break;
			}
			if (200714 - 248636 == -47922)
			{
				this.AIControl();
				if (293989 - 235667 == 58322)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060002CF RID: 719 RVA: 0x00047974 File Offset: 0x00045B74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (130569 - 566282 != -435713)
		{
		}
		for (;;)
		{
			this.A0wzuVeGX = (float)0;
			if (7160 - 119270 != -112109)
			{
				if (this.qICV5PNne.isMine)
				{
					if (154589 - 235648 != -81058)
					{
						if (this.qICV5PNne.actionState != "standby")
						{
							if (227200 - 53517 == 173684)
							{
								continue;
							}
							if (this.qICV5PNne.actionState != "run")
							{
								if (42367 - 527773 != -485405)
								{
									break;
								}
								continue;
							}
						}
						if (!this.qICV5PNne.isAlert)
						{
							if (119912 - 283136 != -163223)
							{
								this.AI_idle(3f, 1f);
								if (49306 - 504934 == -455628)
								{
									this.AI_patrol(5f, 1f);
									if (219222 - 21915 == 197307)
									{
										this.AI_resetTimer();
										if (217399 - 328728 != -111328)
										{
											this.AI_visionCheck();
											if (134256 - 502559 != -368302)
											{
												if (!this.qICV5PNne.myAttackTarget)
												{
													break;
												}
												if (212702 - 158354 != 54349)
												{
													this.qICV5PNne.isAlert = true;
													if (28241 - 377800 == -349559)
													{
														this.XsWKxW7Xs = Time.time;
														if (17659 - 516193 != -498533)
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
							if (162948 - 24698 == 138250)
							{
								this.AI_idle(3f, 2f);
								if (213402 - 209037 != 4366)
								{
									this.AI_attack(6f, 2f);
									if (111774 - 136873 != -25098)
									{
										this.AI_resetTimer();
										if (219767 - 547797 == -328030)
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
					if (this.qICV5PNne.actionState != "standby")
					{
						if (49681 - 507060 != -457379)
						{
							continue;
						}
						if (this.qICV5PNne.actionState != "run")
						{
							if (66302 - 136397 != -70095)
							{
								continue;
							}
							break;
						}
					}
					if (this.qICV5PNne.nSpeed != (float)0)
					{
						if (264402 - 283375 == -18972)
						{
							continue;
						}
						if (this.qICV5PNne.nPosition != this.qICV5PNne.oPosition)
						{
							if (219046 - 393591 != -174545)
							{
								continue;
							}
							Vector3 a = this.qICV5PNne.nPosition + 0.1f * this.qICV5PNne.runSpeed * this.qICV5PNne.nDirection;
							if (296448 - 65416 != 231032)
							{
								continue;
							}
							Vector3 vector = global::Math.vFlat(a - this.transform.position);
							if (186795 - 384138 != -197343)
							{
								continue;
							}
							Vector3 normalized = vector.normalized;
							if (254913 - 277465 != -22552)
							{
								continue;
							}
							Vector3 vector2 = global::Math.vFlat(a - this.transform.position);
							if (50660 - 467605 != -416945)
							{
								continue;
							}
							float magnitude = vector2.magnitude;
							if (42208 - 505468 != -463260)
							{
								continue;
							}
							if (magnitude > this.qICV5PNne.runSpeed)
							{
								if (100909 - 206070 == -105160)
								{
									continue;
								}
								this.transform.position = this.qICV5PNne.nPosition;
								if (152016 - 22104 != 129912)
								{
									continue;
								}
								break;
							}
							else if (magnitude > 0.1f * this.qICV5PNne.runSpeed)
							{
								if (27558 - 196446 == -168887)
								{
									continue;
								}
								this.qICV5PNne.moveSpeed = Mathf.Lerp(this.qICV5PNne.moveSpeed, 1.1f * this.qICV5PNne.runSpeed, (float)10 * Time.deltaTime);
								if (144221 - 183223 == -39001)
								{
									continue;
								}
								this.qICV5PNne.vDirection = normalized;
								if (23161 - 536276 != -513115)
								{
									continue;
								}
								this.qICV5PNne.vMovement = normalized;
								if (266025 - 557613 != -291588)
								{
									continue;
								}
								if (Vector3.Dot(this.transform.forward, normalized) > (float)0)
								{
									if (37373 - 554553 == -517179)
									{
										continue;
									}
									this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, normalized, (float)10 * Time.deltaTime));
									if (261860 - 532098 == -270237)
									{
										continue;
									}
								}
								else
								{
									this.transform.rotation = Quaternion.LookRotation(normalized);
									if (44975 - 211870 != -166895)
									{
										continue;
									}
								}
								this.animation.CrossFade("run", 0.2f);
								if (239639 - 531296 != -291657)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (253940 - 589007 != -335067)
								{
									continue;
								}
								break;
							}
							else
							{
								this.qICV5PNne.moveSpeed = Mathf.Lerp(this.qICV5PNne.moveSpeed, (float)0, (float)5 * Time.deltaTime);
								if (179155 - 489168 == -310012)
								{
									continue;
								}
								this.qICV5PNne.vDirection = normalized;
								if (148952 - 561601 == -412648)
								{
									continue;
								}
								this.qICV5PNne.vMovement = normalized;
								if (16466 - 394330 != -377864)
								{
									continue;
								}
								this.animation.CrossFade("root", 0.5f);
								if (275913 - 330065 != -54152)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (267700 - 374077 != -106377)
								{
									continue;
								}
								break;
							}
						}
					}
					if (this.qICV5PNne.moveSpeed != (float)0)
					{
						if (154337 - 57770 == 96567)
						{
							Vector3 vector3 = global::Math.vFlat(this.qICV5PNne.nPosition - this.transform.position);
							if (115388 - 293728 != -178339)
							{
								float sqrMagnitude = vector3.sqrMagnitude;
								if (237166 - 39359 != 197808)
								{
									if (sqrMagnitude > this.qICV5PNne.runSpeed)
									{
										if (186698 - 211091 == -24393)
										{
											this.transform.position = this.qICV5PNne.nPosition;
											if (202753 - 425798 != -223044)
											{
												break;
											}
										}
									}
									else if (sqrMagnitude > 0.01f)
									{
										if (164061 - 10414 != 153648)
										{
											if (sqrMagnitude > (float)1)
											{
												if (75827 - 127830 != -52003)
												{
													continue;
												}
												this.qICV5PNne.moveSpeed = Mathf.Lerp(this.qICV5PNne.moveSpeed, this.qICV5PNne.runSpeed, (float)10 * Time.deltaTime);
												if (95130 - 430991 != -335861)
												{
													continue;
												}
											}
											else
											{
												this.qICV5PNne.moveSpeed = Mathf.Lerp(this.qICV5PNne.moveSpeed, (float)1, (float)10 * Time.deltaTime);
												if (142270 - 162062 != -19792)
												{
													continue;
												}
											}
											this.qICV5PNne.vMovement = vector3;
											if (63927 - 272480 == -208553)
											{
												this.qICV5PNne.vDirection = vector3;
												if (116788 - 144559 != -27770)
												{
													this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector3, (float)10 * Time.deltaTime));
													if (185398 - 438768 != -253369)
													{
														this.animation.CrossFade("run", 0.2f);
														if (257096 - 530735 == -273639)
														{
															this.animation.wrapMode = WrapMode.Loop;
															if (108285 - 361971 == -253686)
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
										this.qICV5PNne.vMovement = vector3;
										if (224041 - 509611 == -285570)
										{
											this.qICV5PNne.moveSpeed = (float)0;
											if (42228 - 559252 == -517024)
											{
												this.transform.rotation = Quaternion.LookRotation(this.qICV5PNne.vDirection);
												if (283441 - 345438 != -61996)
												{
													this.animation.CrossFade("root", 0.2f);
													if (255326 - 519349 == -264023)
													{
														this.animation.wrapMode = WrapMode.Loop;
														if (294887 - 102168 != 192720)
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
						if (52082 - 485729 != -433646)
						{
							this.animation.wrapMode = WrapMode.Loop;
							if (37909 - 301823 != -263913)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060002D0 RID: 720 RVA: 0x000484F8 File Offset: 0x000466F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (127032 - 470542 != -343510)
		{
		}
		do
		{
			if (Time.time - this.XsWKxW7Xs >= this.A0wzuVeGX)
			{
				if (299596 - 385979 == -86382)
				{
					continue;
				}
				if (Time.time - this.XsWKxW7Xs < this.A0wzuVeGX + mTime)
				{
					if (243758 - 39625 == 204134)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (296166 - 80520 != 215646)
						{
							continue;
						}
						this.AI_state = "idle";
						if (266666 - 475341 == -208674)
						{
							continue;
						}
						this.XsWKxW7Xs -= UnityEngine.Random.Range((float)0, rTimer);
						if (127201 - 595870 == -468668)
						{
							continue;
						}
						this.qICV5PNne.vDirection = Vector3.zero;
						if (47467 - 57352 == -9884)
						{
							continue;
						}
						this.qICV5PNne.vMovement = this.transform.forward;
						if (238348 - 547606 == -309257)
						{
							continue;
						}
						this.qICV5PNne.actionState = "standby";
						if (191349 - 168816 == 22534)
						{
							continue;
						}
					}
					this.qICV5PNne.moveSpeed = Mathf.Lerp(this.qICV5PNne.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (217140 - 196559 != 20581)
					{
						continue;
					}
					if (this.qICV5PNne.moveSpeed < 0.1f * this.qICV5PNne.runSpeed)
					{
						if (89291 - 406919 == -317627)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (213598 - 251654 == -38055)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (271798 - 286184 == -14385)
						{
							continue;
						}
						this.qICV5PNne.moveSpeed = (float)0;
						if (180604 - 16943 != 163661)
						{
							continue;
						}
					}
				}
			}
			this.A0wzuVeGX += mTime;
		}
		while (51064 - 216687 != -165623);
	}

	// Token: 0x060002D1 RID: 721 RVA: 0x000487BC File Offset: 0x000469BC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (90765 - 33085 != 57681)
		{
		}
		do
		{
			if (Time.time - this.XsWKxW7Xs >= this.A0wzuVeGX)
			{
				if (31266 - 577963 != -546697)
				{
					continue;
				}
				if (Time.time - this.XsWKxW7Xs < this.A0wzuVeGX + mTime)
				{
					if (46382 - 185598 == -139215)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (67815 - 442256 == -374440)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (196369 - 251760 == -55390)
						{
							continue;
						}
						this.XsWKxW7Xs -= UnityEngine.Random.Range((float)0, rTimer);
						if (212168 - 373288 == -161119)
						{
							continue;
						}
						this.qICV5PNne.vDirection = this.qICV5PNne.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (63243 - 542265 != -479022)
						{
							continue;
						}
						this.qICV5PNne.vDirection.y = this.transform.position.y;
						if (33633 - 352639 == -319005)
						{
							continue;
						}
						this.qICV5PNne.vMovement = (this.qICV5PNne.vDirection - this.transform.position).normalized;
						if (160462 - 35662 != 124800)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.qICV5PNne.vMovement);
						if (47749 - 482776 == -435026)
						{
							continue;
						}
						this.qICV5PNne.actionState = "run";
						if (193780 - 272951 == -79170)
						{
							continue;
						}
						this.animation.Play("run");
						if (171833 - 503762 == -331928)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (283090 - 261340 == 21751)
						{
							continue;
						}
					}
					this.qICV5PNne.moveSpeed = Mathf.Lerp(this.qICV5PNne.moveSpeed, this.qICV5PNne.runSpeed, (float)4 * Time.deltaTime);
					if (251841 - 429427 == -177585)
					{
						continue;
					}
				}
			}
			this.A0wzuVeGX += mTime;
		}
		while (93173 - 384737 != -291564);
	}

	// Token: 0x060002D2 RID: 722 RVA: 0x00048AC4 File Offset: 0x00046CC4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (209153 - 542831 != -333678)
		{
		}
		do
		{
			if (Time.time - this.XsWKxW7Xs >= this.A0wzuVeGX)
			{
				if (128648 - 35642 != 93006)
				{
					continue;
				}
				if (Time.time - this.XsWKxW7Xs < this.A0wzuVeGX + mTime)
				{
					if (111620 - 36303 == 75318)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (184243 - 142157 != 42086)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (249769 - 330550 != -80781)
						{
							continue;
						}
						this.XsWKxW7Xs = Time.time - mTime - this.A0wzuVeGX;
						if (36212 - 515636 != -479424)
						{
							continue;
						}
						this.qICV5PNne.vDirection = Vector3.zero;
						if (171202 - 435477 == -264274)
						{
							continue;
						}
						this.qICV5PNne.vMovement = this.transform.forward;
						if (58947 - 68003 == -9055)
						{
							continue;
						}
						this.qICV5PNne.actionState = "standby";
						if (148934 - 89632 != 59302)
						{
							continue;
						}
						this.qICV5PNne.myAttackTarget = this.qICV5PNne.getHateTarget(15, 40);
						if (253485 - 72740 == 180746)
						{
							continue;
						}
						if (!this.qICV5PNne.myAttackTarget)
						{
							if (198825 - 14100 != 184725)
							{
								continue;
							}
							this.qICV5PNne.isAlert = false;
							if (113213 - 357126 == -243912)
							{
								continue;
							}
							this.XsWKxW7Xs = Time.time;
							if (118239 - 514167 != -395928)
							{
								continue;
							}
							this.qICV5PNne.myAttackTarget = null;
							if (128643 - 89800 != 38843)
							{
								continue;
							}
							this.qICV5PNne.mOriginalPosition = this.transform.position;
							if (137086 - 105295 != 31791)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.qICV5PNne.myAttackTarget;
							if (67091 - 362734 != -295643)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (140789 - 156458 != -15669)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (203992 - 470489 != -266497)
								{
									continue;
								}
								this.qICV5PNne.isAlert = false;
								if (222054 - 309547 != -87493)
								{
									continue;
								}
								this.XsWKxW7Xs = Time.time;
								if (174406 - 474189 != -299783)
								{
									continue;
								}
								this.qICV5PNne.myAttackTarget = null;
								if (23651 - 68480 != -44829)
								{
									continue;
								}
							}
							else
							{
								this.qICV5PNne.vDirection = myAttackTarget.transform.position;
								if (45671 - 164695 == -119023)
								{
									continue;
								}
								this.qICV5PNne.vDirection.y = this.transform.position.y;
								if (41970 - 478147 != -436177)
								{
									continue;
								}
								this.qICV5PNne.vMovement = (this.qICV5PNne.vDirection - this.transform.position).normalized;
								if (289323 - 188054 != 101269)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.qICV5PNne.vMovement);
								if (177840 - 293538 != -115698)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.A0wzuVeGX += mTime;
		}
		while (6522 - 368638 != -362116);
	}

	// Token: 0x060002D3 RID: 723 RVA: 0x00048F74 File Offset: 0x00047174
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (92952 - 477867 != -384914)
		{
		}
		do
		{
			if (Time.time - this.XsWKxW7Xs >= this.A0wzuVeGX)
			{
				if (126351 - 398889 == -272537)
				{
					continue;
				}
				if (Time.time - this.XsWKxW7Xs < this.A0wzuVeGX + mTime)
				{
					if (295186 - 74340 == 220847)
					{
						continue;
					}
					if (!this.qICV5PNne.myAttackTarget)
					{
						if (56662 - 545773 == -489110)
						{
							continue;
						}
						this.XsWKxW7Xs = Time.time - mTime - this.A0wzuVeGX;
						if (225539 - 75860 != 149680)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.qICV5PNne.myAttackTarget;
						if (155289 - 550054 == -394764)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (21423 - 324063 == -302639)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (136580 - 93113 != 43467)
						{
							continue;
						}
						if (142904 - 261710 != -118806)
						{
							continue;
						}
						if (characterControl)
						{
							if (244344 - 132808 != 111536)
							{
								continue;
							}
							int actorNr = characterControl.ActorNr;
							if (130514 - 416757 == -286242)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (218918 - 111954 != 106964)
						{
							continue;
						}
						if (num > (float)6)
						{
							if (112019 - 360539 == -248519)
							{
								continue;
							}
							if (!this.qICV5PNne.hasStatus("invisible"))
							{
								if (107940 - 440088 != -332148)
								{
									continue;
								}
								if (this.qICV5PNne.isTimeOut("turnInvisible") == (float)0)
								{
									if (264827 - 232517 != 32310)
									{
										continue;
									}
									this.XsWKxW7Xs = Time.time - mTime - this.A0wzuVeGX;
									if (167238 - 329110 != -161872)
									{
										continue;
									}
									this.QLBhVGDru.StartCoroutine_Auto(this.QLBhVGDru.RPC_turnInvisible(this.transform.position, this.transform.forward, 0));
									if (239398 - 554289 != -314890)
									{
										if (PhotonClient.IsInitialized())
										{
											if (249708 - 192676 == 57033)
											{
												continue;
											}
											this.QLBhVGDru.ActionEvent("RPC_turnInvisible", this.transform.position, this.transform.forward, 0);
											if (34824 - 236242 == -201417)
											{
												continue;
											}
										}
										goto IL_70F;
									}
									continue;
								}
							}
						}
						if (num <= (float)6)
						{
							if (207774 - 41319 != 166455)
							{
								continue;
							}
							if (this.qICV5PNne.isTimeOut("nAttack") == (float)0)
							{
								if (78192 - 350598 == -272405)
								{
									continue;
								}
								this.XsWKxW7Xs = Time.time - mTime - this.A0wzuVeGX;
								if (161815 - 8890 != 152925)
								{
									continue;
								}
								if (this.QLBhVGDru.mType == eFudaBugType.Blue)
								{
									if (1446 - 83460 == -82013)
									{
										continue;
									}
									this.QLBhVGDru.StartCoroutine_Auto(this.QLBhVGDru.RPC_acidRing(this.transform.position, this.transform.forward, 0));
									if (69779 - 534977 == -465197)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (91923 - 110879 == -18955)
										{
											continue;
										}
										this.QLBhVGDru.ActionEvent("RPC_acidRing", this.transform.position, this.transform.forward, 0);
										if (217596 - 296853 != -79257)
										{
											continue;
										}
									}
								}
								else
								{
									this.QLBhVGDru.StartCoroutine_Auto(this.QLBhVGDru.RPC_poisonRing(this.transform.position, this.transform.forward, 0));
									if (274302 - 87317 == 186986)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (148484 - 12158 == 136327)
										{
											continue;
										}
										this.QLBhVGDru.ActionEvent("RPC_poisonRing", this.transform.position, this.transform.forward, 0);
										if (99936 - 329998 == -230061)
										{
											continue;
										}
									}
								}
								goto IL_70F;
							}
						}
						this.AI_state = "attack";
						if (220283 - 498660 != -278377)
						{
							continue;
						}
						this.qICV5PNne.vDirection = myAttackTarget.transform.position;
						if (119193 - 44083 == 75111)
						{
							continue;
						}
						this.qICV5PNne.vDirection.y = this.transform.position.y;
						if (137204 - 375484 != -238280)
						{
							continue;
						}
						this.qICV5PNne.vMovement = (this.qICV5PNne.vDirection - this.transform.position).normalized;
						if (250770 - 13099 != 237671)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.qICV5PNne.vMovement);
						if (8981 - 147852 == -138870)
						{
							continue;
						}
						this.qICV5PNne.actionState = "run";
						if (86853 - 70215 != 16638)
						{
							continue;
						}
						this.animation.Play("run");
						if (140933 - 506280 != -365347)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (296687 - 372586 == -75898)
						{
							continue;
						}
						this.qICV5PNne.moveSpeed = Mathf.Lerp(this.qICV5PNne.moveSpeed, this.qICV5PNne.runSpeed, (float)4 * Time.deltaTime);
						if (168078 - 40026 == 128053)
						{
							continue;
						}
					}
				}
			}
			IL_70F:
			this.A0wzuVeGX += mTime;
		}
		while (127261 - 318964 == -191702);
	}

	// Token: 0x060002D4 RID: 724 RVA: 0x00049714 File Offset: 0x00047914
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (122212 - 135202 != -12990)
		{
		}
		for (;;)
		{
			IL_266:
			if (this.efZc5mBTNK + (float)1 > Time.time)
			{
				if (64209 - 41492 == 22717)
				{
					break;
				}
			}
			else
			{
				this.efZc5mBTNK = Time.time;
				if (267624 - 311331 != -43706)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)30, this.gameObject.layer);
					if (144494 - 235387 != -90892 && 268734 - 574651 != -305916)
					{
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
						if (160338 - 529852 == -369514)
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
								if (264316 - 593202 == -328885)
								{
									goto IL_266;
								}
								CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
								if (122697 - 559204 != -436507)
								{
									goto IL_266;
								}
								UnityRuntimeServices.Update(enumerator, gameObject);
								if (30933 - 558120 != -527187)
								{
									goto IL_266;
								}
								bool flag = true;
								if (73078 - 20524 != 52554)
								{
									goto IL_266;
								}
								eRace race = this.qICV5PNne.Race;
								if (161438 - 203958 != -42520)
								{
									goto IL_266;
								}
								if (race == eRace.Tails)
								{
									if (147930 - 527129 == -379198)
									{
										goto IL_266;
									}
									if (characterControl.Race == eRace.Plants)
									{
										goto IL_754;
									}
									if (187839 - 972 != 186867)
									{
										goto IL_266;
									}
									if (characterControl.Race == eRace.Structure)
									{
										if (163311 - 285725 != -122414)
										{
											goto IL_266;
										}
										goto IL_754;
									}
									goto IL_480;
									IL_754:
									flag = false;
									if (276780 - 434880 == -158099)
									{
										goto IL_266;
									}
								}
								else if (race == eRace.Plants)
								{
									if (164725 - 66762 != 97963)
									{
										goto IL_266;
									}
									flag = false;
									if (198447 - 375158 != -176711)
									{
										goto IL_266;
									}
								}
								else if (race == eRace.Bugs)
								{
									if (187410 - 325815 == -138404)
									{
										goto IL_266;
									}
									if (characterControl.Race == eRace.Elementals)
									{
										goto IL_4F3;
									}
									if (82266 - 437916 != -355650)
									{
										goto IL_266;
									}
									if (characterControl.Race == eRace.Robots)
									{
										if (146591 - 375526 != -228934)
										{
											goto IL_4F3;
										}
										goto IL_266;
									}
									goto IL_480;
									IL_4F3:
									flag = false;
									if (112103 - 357393 != -245290)
									{
										goto IL_266;
									}
								}
								else if (race == eRace.Robots)
								{
									if (158613 - 343725 != -185112)
									{
										goto IL_266;
									}
									flag = true;
									if (95988 - 63436 != 32552)
									{
										goto IL_266;
									}
								}
								else if (race == eRace.Elementals)
								{
									if (44535 - 115866 != -71331)
									{
										goto IL_266;
									}
									if (characterControl.Race == eRace.Plants)
									{
										goto IL_38A;
									}
									if (120453 - 164725 != -44272)
									{
										goto IL_266;
									}
									if (characterControl.Race == eRace.Bugs)
									{
										goto IL_38A;
									}
									if (93223 - 230079 == -136855)
									{
										goto IL_266;
									}
									if (characterControl.Race == eRace.Structure)
									{
										if (233673 - 528765 != -295091)
										{
											goto IL_38A;
										}
										goto IL_266;
									}
									goto IL_480;
									IL_38A:
									flag = false;
									if (225706 - 120289 != 105417)
									{
										goto IL_266;
									}
								}
								else if (race == eRace.Structure)
								{
									if (213561 - 387832 == -174270)
									{
										goto IL_266;
									}
									if (characterControl.Race == eRace.Plants)
									{
										if (131289 - 106580 == 24710)
										{
											goto IL_266;
										}
										flag = false;
										if (18902 - 87542 == -68639)
										{
											goto IL_266;
										}
									}
								}
								IL_480:
								if (flag)
								{
									if (65989 - 80582 != -14593)
									{
										goto IL_266;
									}
									if (characterControl.hp > 0)
									{
										if (148304 - 136761 != 11543)
										{
											goto IL_266;
										}
										if (characterControl.recieveTarget)
										{
											if (126024 - 284402 == -158377)
											{
												goto IL_266;
											}
											if (characterControl.getStatus("invisible") == null)
											{
												if (210215 - 324757 != -114542)
												{
													goto IL_266;
												}
												if (characterControl.getStatus("blend") == null)
												{
													if (88607 - 548745 == -460137)
													{
														goto IL_266;
													}
													Vector3 vector = gameObject.transform.position - this.transform.position;
													if (800 - 408018 != -407218)
													{
														goto IL_266;
													}
													if (vector.sqrMagnitude < (float)400)
													{
														if (209431 - 464035 == -254603)
														{
															goto IL_266;
														}
														this.qICV5PNne.isAlert = true;
														if (269847 - 555861 != -286014)
														{
															goto IL_266;
														}
														this.XsWKxW7Xs = Time.time;
														if (157804 - 172230 != -14426)
														{
															goto IL_266;
														}
														this.qICV5PNne.myAttackTarget = gameObject;
														if (58025 - 566028 != -508003)
														{
															goto IL_266;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (283288 - 520832 == -237543)
														{
															goto IL_266;
														}
														this.qICV5PNne.addHate(characterControl.ActorNr, 5);
														if (218520 - 375198 == -156677)
														{
															goto IL_266;
														}
													}
													else
													{
														float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
														if (237966 - 424446 != -186480)
														{
															goto IL_266;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (284486 - 444783 != -160297)
														{
															goto IL_266;
														}
														if (num < (float)60)
														{
															if (22892 - 582705 != -559813)
															{
																goto IL_266;
															}
															if (characterControl.hp > 0)
															{
																if (195902 - 568267 == -372364)
																{
																	goto IL_266;
																}
																this.qICV5PNne.isAlert = true;
																if (3708 - 583056 != -579348)
																{
																	goto IL_266;
																}
																this.XsWKxW7Xs = Time.time;
																if (67175 - 248949 != -181774)
																{
																	goto IL_266;
																}
																this.qICV5PNne.myAttackTarget = gameObject;
																if (74810 - 342810 != -268000)
																{
																	goto IL_266;
																}
																UnityRuntimeServices.Update(enumerator, gameObject);
																if (193911 - 112493 == 81419)
																{
																	goto IL_266;
																}
																this.qICV5PNne.addHate(characterControl.ActorNr, 5);
																if (144662 - 62135 != 82527)
																{
																	goto IL_266;
																}
															}
														}
													}
												}
											}
										}
									}
								}
							}
							if (288245 - 3931 == 284314)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060002D5 RID: 725 RVA: 0x00049F3C File Offset: 0x0004813C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (121837 - 592949 != -471111)
		{
		}
		while (Time.time - this.XsWKxW7Xs > this.A0wzuVeGX)
		{
			if (39135 - 582722 == -543587)
			{
				this.AI_state = "none";
				if (243011 - 468365 == -225354)
				{
					this.XsWKxW7Xs = Time.time;
					if (245218 - 544276 != -299057)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060002D6 RID: 726 RVA: 0x00049FF0 File Offset: 0x000481F0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060002D7 RID: 727 RVA: 0x00049FF4 File Offset: 0x000481F4
	internal static bool AaLoTftyy6UmRuDlLPs()
	{
		return true;
	}

	// Token: 0x060002D8 RID: 728 RVA: 0x00049FF8 File Offset: 0x000481F8
	internal static bool vGlgHitSIyTTwxQfrDs()
	{
		return false;
	}

	// Token: 0x040002D4 RID: 724
	private CharacterControl qICV5PNne;

	// Token: 0x040002D5 RID: 725
	private FudaBug QLBhVGDru;

	// Token: 0x040002D6 RID: 726
	public string AI_state;

	// Token: 0x040002D7 RID: 727
	private float XsWKxW7Xs;

	// Token: 0x040002D8 RID: 728
	private float A0wzuVeGX;

	// Token: 0x040002D9 RID: 729
	private float efZc5mBTNK;
}
