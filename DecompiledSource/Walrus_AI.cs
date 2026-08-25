using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000DD8 RID: 3544
[Serializable]
public class Walrus_AI : MonoBehaviour
{
	// Token: 0x06005003 RID: 20483 RVA: 0x009CEDCC File Offset: 0x009CCFCC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Walrus_AI()
	{
		if (285598 - 231896 != 53703)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (288138 - 397482 == -109344)
			{
				base..ctor();
				if (295058 - 23982 != 271077)
				{
					this.AI_state = "none";
					if (85138 - 578273 != -493134)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06005004 RID: 20484 RVA: 0x009CEE68 File Offset: 0x009CD068
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.amRcQei73ql = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.XDKcQIHMOa6 = (Walrus)this.GetComponent(typeof(Walrus));
	}

	// Token: 0x06005005 RID: 20485 RVA: 0x009CEEA0 File Offset: 0x009CD0A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (113077 - 458195 != -345118)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (226116 - 190233 != 35883)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (14127 - 195015 == -180887)
				{
					continue;
				}
			}
			if (this.amRcQei73ql.isControlled)
			{
				break;
			}
			if (93514 - 114219 != -20704)
			{
				this.AIControl();
				if (83108 - 252536 == -169428)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06005006 RID: 20486 RVA: 0x009CEF6C File Offset: 0x009CD16C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (232230 - 289016 != -56786)
		{
		}
		for (;;)
		{
			this.WVHcQ6FcyiN = (float)0;
			if (194652 - 139374 == 55278)
			{
				if (this.amRcQei73ql.isMine)
				{
					if (15654 - 285935 == -270281)
					{
						if (this.amRcQei73ql.actionState != "standby")
						{
							if (158028 - 196994 != -38966)
							{
								continue;
							}
							if (this.amRcQei73ql.actionState != "run")
							{
								if (274811 - 383165 != -108354)
								{
									continue;
								}
								break;
							}
						}
						if (!this.amRcQei73ql.isAlert)
						{
							if (90722 - 404049 == -313327)
							{
								if (this.amRcQei73ql.isSummon)
								{
									if (129689 - 277625 != -147936)
									{
										continue;
									}
									if (this.amRcQei73ql.mSummoner != null)
									{
										if (228233 - 571929 != -343696)
										{
											continue;
										}
										Vector3 vector = this.amRcQei73ql.mSummoner.transform.position - this.transform.position;
										if (169112 - 151331 != 17782)
										{
											if (vector.sqrMagnitude > (float)36)
											{
												if (215821 - 188174 != 27647)
												{
													continue;
												}
												this.AI_follow(this.amRcQei73ql.mSummoner);
												if (240032 - 82015 != 158017)
												{
													continue;
												}
											}
											else
											{
												this.AI_idle(3f, 1f);
												if (49664 - 282096 == -232431)
												{
													continue;
												}
												this.AI_resetTimer();
												if (170938 - 413926 != -242988)
												{
													continue;
												}
												this.AI_visionCheck();
												if (76299 - 76614 == -314)
												{
													continue;
												}
											}
											goto IL_BE6;
										}
										continue;
									}
								}
								this.AI_idle(3f, 1f);
								if (236156 - 203703 == 32454)
								{
									continue;
								}
								this.AI_resetTimer();
								if (212855 - 197696 != 15159)
								{
									continue;
								}
								this.AI_visionCheck();
								if (98053 - 599095 == -501041)
								{
									continue;
								}
								IL_BE6:
								if (!this.amRcQei73ql.myAttackTarget)
								{
									break;
								}
								if (98948 - 239542 != -140593)
								{
									this.amRcQei73ql.isAlert = true;
									if (296203 - 500563 != -204359)
									{
										this.YTMcQJWi9D9 = Time.time;
										if (283420 - 57765 != 225656)
										{
											break;
										}
									}
								}
							}
						}
						else
						{
							this.AI_selectTarget(1f, (float)0);
							if (80181 - 236469 != -156287)
							{
								this.AI_idle(2f, 1f);
								if (21065 - 25975 != -4909)
								{
									this.AI_patrol(2f, 1f);
									if (283535 - 108368 != 175168)
									{
										this.AI_attack(10f, (float)0);
										if (255211 - 420177 == -164966)
										{
											this.AI_resetTimer();
											if (11618 - 560137 != -548518)
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
				else
				{
					if (this.amRcQei73ql.actionState != "standby")
					{
						if (197686 - 564069 == -366382)
						{
							continue;
						}
						if (this.amRcQei73ql.actionState != "run")
						{
							if (145538 - 218159 != -72621)
							{
								continue;
							}
							break;
						}
					}
					if (this.amRcQei73ql.nSpeed != (float)0)
					{
						if (97180 - 386336 != -289156)
						{
							continue;
						}
						if (this.amRcQei73ql.nPosition != this.amRcQei73ql.oPosition)
						{
							if (113070 - 207976 == -94905)
							{
								continue;
							}
							Vector3 a = this.amRcQei73ql.nPosition + 0.1f * this.amRcQei73ql.runSpeed * this.amRcQei73ql.nDirection;
							if (107655 - 522041 == -414385)
							{
								continue;
							}
							Vector3 vector2 = global::Math.vFlat(a - this.transform.position);
							if (114382 - 501055 == -386672)
							{
								continue;
							}
							Vector3 normalized = vector2.normalized;
							if (147409 - 463587 != -316178)
							{
								continue;
							}
							Vector3 vector3 = global::Math.vFlat(a - this.transform.position);
							if (119415 - 170253 == -50837)
							{
								continue;
							}
							float magnitude = vector3.magnitude;
							if (145459 - 103259 != 42200)
							{
								continue;
							}
							if (magnitude > this.amRcQei73ql.runSpeed)
							{
								if (153084 - 598460 == -445375)
								{
									continue;
								}
								this.transform.position = this.amRcQei73ql.nPosition;
								if (240342 - 150084 != 90258)
								{
									continue;
								}
								break;
							}
							else if (magnitude > 0.1f * this.amRcQei73ql.runSpeed)
							{
								if (115090 - 46335 == 68756)
								{
									continue;
								}
								this.amRcQei73ql.moveSpeed = Mathf.Lerp(this.amRcQei73ql.moveSpeed, 1.1f * this.amRcQei73ql.runSpeed, (float)10 * Time.deltaTime);
								if (177388 - 211175 == -33786)
								{
									continue;
								}
								this.amRcQei73ql.vDirection = normalized;
								if (259921 - 420808 == -160886)
								{
									continue;
								}
								this.amRcQei73ql.vMovement = normalized;
								if (70081 - 300554 == -230472)
								{
									continue;
								}
								if (Vector3.Dot(this.transform.forward, normalized) > (float)0)
								{
									if (32498 - 182422 == -149923)
									{
										continue;
									}
									this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, normalized, (float)10 * Time.deltaTime));
									if (294294 - 140232 == 154063)
									{
										continue;
									}
								}
								else
								{
									this.transform.rotation = Quaternion.LookRotation(normalized);
									if (85571 - 449512 != -363941)
									{
										continue;
									}
								}
								this.animation.CrossFade("run", 0.2f);
								if (151255 - 531265 == -380009)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (12682 - 56928 != -44245)
								{
									break;
								}
								continue;
							}
							else
							{
								this.amRcQei73ql.moveSpeed = Mathf.Lerp(this.amRcQei73ql.moveSpeed, (float)0, (float)5 * Time.deltaTime);
								if (232246 - 221618 != 10628)
								{
									continue;
								}
								this.amRcQei73ql.vDirection = normalized;
								if (168435 - 113797 == 54639)
								{
									continue;
								}
								this.amRcQei73ql.vMovement = normalized;
								if (96474 - 16377 == 80098)
								{
									continue;
								}
								this.animation.CrossFade("root", 0.5f);
								if (148319 - 424157 == -275837)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (69173 - 457886 != -388712)
								{
									break;
								}
								continue;
							}
						}
					}
					if (this.amRcQei73ql.moveSpeed != (float)0)
					{
						if (93871 - 196526 == -102655)
						{
							Vector3 vector4 = global::Math.vFlat(this.amRcQei73ql.nPosition - this.transform.position);
							if (64552 - 426486 != -361933)
							{
								float sqrMagnitude = vector4.sqrMagnitude;
								if (208268 - 98996 != 109273)
								{
									if (sqrMagnitude > this.amRcQei73ql.runSpeed)
									{
										if (202372 - 499373 != -297000)
										{
											this.transform.position = this.amRcQei73ql.nPosition;
											if (87366 - 229210 != -141843)
											{
												break;
											}
										}
									}
									else if (sqrMagnitude > 0.01f)
									{
										if (6112 - 80012 != -73899)
										{
											if (sqrMagnitude > (float)1)
											{
												if (176129 - 94508 == 81622)
												{
													continue;
												}
												this.amRcQei73ql.moveSpeed = Mathf.Lerp(this.amRcQei73ql.moveSpeed, this.amRcQei73ql.runSpeed, (float)10 * Time.deltaTime);
												if (213058 - 155608 == 57451)
												{
													continue;
												}
											}
											else
											{
												this.amRcQei73ql.moveSpeed = Mathf.Lerp(this.amRcQei73ql.moveSpeed, (float)1, (float)10 * Time.deltaTime);
												if (89219 - 308660 != -219441)
												{
													continue;
												}
											}
											this.amRcQei73ql.vMovement = vector4;
											if (162120 - 500146 == -338026)
											{
												this.amRcQei73ql.vDirection = vector4;
												if (70559 - 21493 == 49066)
												{
													this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector4, (float)10 * Time.deltaTime));
													if (20112 - 367965 == -347853)
													{
														this.animation.CrossFade("run", 0.2f);
														if (97168 - 35247 == 61921)
														{
															this.animation.wrapMode = WrapMode.Loop;
															if (215129 - 421532 != -206402)
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
										this.amRcQei73ql.vMovement = vector4;
										if (299580 - 505731 == -206151)
										{
											this.amRcQei73ql.moveSpeed = (float)0;
											if (147684 - 382037 == -234353)
											{
												this.transform.rotation = Quaternion.LookRotation(this.amRcQei73ql.vDirection);
												if (47148 - 237609 != -190460)
												{
													this.animation.CrossFade("root", 0.2f);
													if (161581 - 294511 == -132930)
													{
														this.animation.wrapMode = WrapMode.Loop;
														if (193340 - 140795 != 52546)
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
						if (145240 - 1860 != 143381)
						{
							this.animation.wrapMode = WrapMode.Loop;
							if (156526 - 295662 == -139136)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06005007 RID: 20487 RVA: 0x009CFC50 File Offset: 0x009CDE50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (67643 - 335873 != -268229)
		{
		}
		do
		{
			if (Time.time - this.YTMcQJWi9D9 >= this.WVHcQ6FcyiN)
			{
				if (201676 - 192781 == 8896)
				{
					continue;
				}
				if (Time.time - this.YTMcQJWi9D9 < this.WVHcQ6FcyiN + mTime)
				{
					if (211061 - 524312 != -313251)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (214210 - 500170 != -285960)
						{
							continue;
						}
						this.AI_state = "idle";
						if (295682 - 42199 != 253483)
						{
							continue;
						}
						this.YTMcQJWi9D9 -= UnityEngine.Random.Range((float)0, rTimer);
						if (184132 - 541956 != -357824)
						{
							continue;
						}
						this.amRcQei73ql.vDirection = Vector3.zero;
						if (23567 - 324629 != -301062)
						{
							continue;
						}
						this.amRcQei73ql.vMovement = this.transform.forward;
						if (117955 - 346324 != -228369)
						{
							continue;
						}
						this.amRcQei73ql.actionState = "standby";
						if (186661 - 465880 == -279218)
						{
							continue;
						}
					}
					this.amRcQei73ql.moveSpeed = Mathf.Lerp(this.amRcQei73ql.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (94975 - 320433 == -225457)
					{
						continue;
					}
					if (this.amRcQei73ql.moveSpeed < 0.1f * this.amRcQei73ql.runSpeed)
					{
						if (19724 - 65708 == -45983)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (216589 - 35543 == 181047)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (80553 - 247031 == -166477)
						{
							continue;
						}
						this.amRcQei73ql.moveSpeed = (float)0;
						if (25518 - 440105 == -414586)
						{
							continue;
						}
					}
				}
			}
			this.WVHcQ6FcyiN += mTime;
		}
		while (166326 - 403502 != -237176);
	}

	// Token: 0x06005008 RID: 20488 RVA: 0x009CFF14 File Offset: 0x009CE114
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_follow(GameObject followObject)
	{
		if (87943 - 104595 != -16652)
		{
		}
		for (;;)
		{
			this.amRcQei73ql.vDirection = followObject.transform.position;
			if (180875 - 332765 == -151890)
			{
				this.amRcQei73ql.vDirection.y = this.transform.position.y;
				if (73181 - 230399 == -157218)
				{
					this.amRcQei73ql.vMovement = (this.amRcQei73ql.vDirection - this.transform.position).normalized;
					if (116753 - 476207 != -359453)
					{
						this.transform.rotation = Quaternion.LookRotation(this.amRcQei73ql.vMovement);
						if (5770 - 258307 == -252537)
						{
							this.amRcQei73ql.actionState = "run";
							if (134532 - 50715 == 83817)
							{
								this.animation.Play("run");
								if (286668 - 560981 == -274313)
								{
									this.animation.wrapMode = WrapMode.Loop;
									if (237370 - 458708 == -221338)
									{
										this.amRcQei73ql.moveSpeed = Mathf.Lerp(this.amRcQei73ql.moveSpeed, this.amRcQei73ql.runSpeed, (float)4 * Time.deltaTime);
										if (261953 - 243466 == 18487)
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

	// Token: 0x06005009 RID: 20489 RVA: 0x009D00FC File Offset: 0x009CE2FC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (184336 - 311167 != -126830)
		{
		}
		do
		{
			if (Time.time - this.YTMcQJWi9D9 >= this.WVHcQ6FcyiN)
			{
				if (38043 - 513376 == -475332)
				{
					continue;
				}
				if (Time.time - this.YTMcQJWi9D9 < this.WVHcQ6FcyiN + mTime)
				{
					if (250513 - 157284 == 93230)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (207818 - 168893 != 38925)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (284808 - 580898 != -296090)
						{
							continue;
						}
						this.YTMcQJWi9D9 -= UnityEngine.Random.Range((float)0, rTimer);
						if (48016 - 341577 != -293561)
						{
							continue;
						}
						if (this.amRcQei73ql.isAlert)
						{
							if (270607 - 13248 != 257359)
							{
								continue;
							}
							if ((float)this.amRcQei73ql.hp < 0.6f * (float)this.amRcQei73ql.mhp)
							{
								if (85803 - 578760 == -492956)
								{
									continue;
								}
								if (this.amRcQei73ql.isTimeOut("manaArc") == (float)0)
								{
									if (172994 - 61077 != 111917)
									{
										continue;
									}
									this.XDKcQIHMOa6.RPC_manaArc(this.transform.position, this.transform.forward, 0);
									if (140853 - 38155 == 102699)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (53435 - 514854 == -461418)
										{
											continue;
										}
										this.XDKcQIHMOa6.ActionEvent("RPC_manaArc", this.transform.position, this.transform.forward, 0);
										if (97514 - 428659 != -331145)
										{
											continue;
										}
									}
								}
							}
						}
						this.amRcQei73ql.vDirection = this.amRcQei73ql.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (142494 - 356485 == -213990)
						{
							continue;
						}
						this.amRcQei73ql.vDirection.y = this.transform.position.y;
						if (180680 - 75298 == 105383)
						{
							continue;
						}
						this.amRcQei73ql.vMovement = (this.amRcQei73ql.vDirection - this.transform.position).normalized;
						if (188884 - 173608 == 15277)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.amRcQei73ql.vMovement);
						if (84404 - 365323 == -280918)
						{
							continue;
						}
						this.amRcQei73ql.actionState = "run";
						if (280753 - 346631 == -65877)
						{
							continue;
						}
						this.animation.Play("run");
						if (17083 - 294286 != -277203)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (23848 - 312386 != -288538)
						{
							continue;
						}
					}
					this.amRcQei73ql.moveSpeed = Mathf.Lerp(this.amRcQei73ql.moveSpeed, this.amRcQei73ql.runSpeed, (float)4 * Time.deltaTime);
					if (172360 - 169912 != 2448)
					{
						continue;
					}
				}
			}
			this.WVHcQ6FcyiN += mTime;
		}
		while (285211 - 462130 != -176919);
	}

	// Token: 0x0600500A RID: 20490 RVA: 0x009D053C File Offset: 0x009CE73C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (280200 - 324017 != -43816)
		{
		}
		do
		{
			if (Time.time - this.YTMcQJWi9D9 >= this.WVHcQ6FcyiN)
			{
				if (68341 - 2601 != 65740)
				{
					continue;
				}
				if (Time.time - this.YTMcQJWi9D9 < this.WVHcQ6FcyiN + mTime)
				{
					if (237748 - 286885 == -49136)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (120548 - 388959 != -268411)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (274895 - 298853 != -23958)
						{
							continue;
						}
						this.YTMcQJWi9D9 = Time.time - mTime - this.WVHcQ6FcyiN;
						if (287052 - 300448 == -13395)
						{
							continue;
						}
						this.amRcQei73ql.vDirection = Vector3.zero;
						if (159646 - 525059 != -365413)
						{
							continue;
						}
						this.amRcQei73ql.vMovement = this.transform.forward;
						if (29633 - 176066 != -146433)
						{
							continue;
						}
						this.amRcQei73ql.actionState = "standby";
						if (295372 - 412396 != -117024)
						{
							continue;
						}
						this.amRcQei73ql.myAttackTarget = this.amRcQei73ql.getHateTarget(5, 50);
						if (17690 - 362814 == -345123)
						{
							continue;
						}
						if (!this.amRcQei73ql.myAttackTarget)
						{
							if (149867 - 421375 != -271508)
							{
								continue;
							}
							this.amRcQei73ql.isAlert = false;
							if (28657 - 265075 == -236417)
							{
								continue;
							}
							this.YTMcQJWi9D9 = Time.time;
							if (258456 - 239510 != 18946)
							{
								continue;
							}
							this.amRcQei73ql.myAttackTarget = null;
							if (289790 - 187174 != 102616)
							{
								continue;
							}
							this.amRcQei73ql.mOriginalPosition = this.transform.position;
							if (234951 - 269037 != -34086)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.amRcQei73ql.myAttackTarget;
							if (208271 - 323160 != -114889)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (96293 - 112497 != -16204)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (86336 - 167579 != -81243)
								{
									continue;
								}
								this.amRcQei73ql.isAlert = false;
								if (513 - 104045 != -103532)
								{
									continue;
								}
								this.YTMcQJWi9D9 = Time.time;
								if (268719 - 241393 == 27327)
								{
									continue;
								}
								this.amRcQei73ql.myAttackTarget = null;
								if (98917 - 461116 == -362198)
								{
									continue;
								}
							}
							else
							{
								this.amRcQei73ql.vDirection = myAttackTarget.transform.position;
								if (127729 - 298159 == -170429)
								{
									continue;
								}
								this.amRcQei73ql.vDirection.y = this.transform.position.y;
								if (136612 - 561141 == -424528)
								{
									continue;
								}
								this.amRcQei73ql.vMovement = (this.amRcQei73ql.vDirection - this.transform.position).normalized;
								if (100198 - 436683 == -336484)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.amRcQei73ql.vMovement);
								if (54718 - 291765 == -237046)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.WVHcQ6FcyiN += mTime;
		}
		while (236356 - 252481 == -16124);
	}

	// Token: 0x0600500B RID: 20491 RVA: 0x009D09EC File Offset: 0x009CEBEC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (51915 - 583439 != -531524)
		{
		}
		do
		{
			if (Time.time - this.YTMcQJWi9D9 >= this.WVHcQ6FcyiN)
			{
				if (57875 - 272858 == -214982)
				{
					continue;
				}
				if (Time.time - this.YTMcQJWi9D9 < this.WVHcQ6FcyiN + mTime)
				{
					if (106793 - 269357 != -162564)
					{
						continue;
					}
					if (!this.amRcQei73ql.myAttackTarget)
					{
						if (253672 - 319931 == -66258)
						{
							continue;
						}
						this.YTMcQJWi9D9 = Time.time - mTime - this.WVHcQ6FcyiN;
						if (139894 - 44786 != 95108)
						{
							continue;
						}
						break;
					}
					else
					{
						GameObject myAttackTarget = this.amRcQei73ql.myAttackTarget;
						if (82811 - 118046 != -35235)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (153856 - 353200 != -199344)
						{
							continue;
						}
						Vector3 tDir = myAttackTarget.transform.position - this.transform.position;
						if (270096 - 130734 == 139363)
						{
							continue;
						}
						int tID = 0;
						if (142295 - 161370 == -19074)
						{
							continue;
						}
						if (characterControl)
						{
							if (183202 - 308811 == -125608)
							{
								continue;
							}
							tID = characterControl.ActorNr;
							if (106736 - 258016 == -151279)
							{
								continue;
							}
						}
						float num = tDir.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (46393 - 512783 != -466390)
						{
							continue;
						}
						if (num < (float)30)
						{
							if (71364 - 404837 == -333472)
							{
								continue;
							}
							if (this.amRcQei73ql.isTimeOut("randomCast") == (float)0)
							{
								if (212213 - 393628 == -181414)
								{
									continue;
								}
								this.YTMcQJWi9D9 = Time.time - mTime - this.WVHcQ6FcyiN;
								if (59358 - 120171 != -60813)
								{
									continue;
								}
								this.XDKcQIHMOa6.StartCoroutine_Auto(this.XDKcQIHMOa6.RPC_randomCast(this.transform.position, tDir, tID));
								if (1140 - 23574 != -22433)
								{
									if (PhotonClient.IsInitialized())
									{
										if (94189 - 360694 == -266504)
										{
											continue;
										}
										this.XDKcQIHMOa6.ActionEvent("RPC_randomCast", this.transform.position, tDir, tID);
										if (49567 - 310388 != -260821)
										{
											continue;
										}
									}
									goto IL_554;
								}
								continue;
							}
						}
						if (num < (float)4)
						{
							if (264942 - 394669 == -129726)
							{
								continue;
							}
							if (this.amRcQei73ql.isTimeOut("blink") == (float)0)
							{
								if (106839 - 47138 == 59702)
								{
									continue;
								}
								Vector3 vector = default(Vector3);
								if (39638 - 79085 != -39447)
								{
									continue;
								}
								if (Game.mGameCode == 506)
								{
									if (203400 - 49487 != 153913)
									{
										continue;
									}
									GameObject gameObject = GameObject.Find("SpawnPoint" + UnityEngine.Random.Range(1, 8));
									if (118587 - 163867 != -45280)
									{
										continue;
									}
									if (gameObject)
									{
										if (220623 - 204236 != 16387)
										{
											continue;
										}
										vector = gameObject.transform.position;
										if (152938 - 75338 == 77601)
										{
											continue;
										}
									}
								}
								else
								{
									vector = global::Math.getRandomSpawnPos(this.transform.position, 8);
									if (252655 - 214919 == 37737)
									{
										continue;
									}
								}
								if (vector != Vector3.zero)
								{
									if (150048 - 369440 == -219391)
									{
										continue;
									}
									this.YTMcQJWi9D9 = Time.time - mTime - this.WVHcQ6FcyiN;
									if (15093 - 506987 == -491893)
									{
										continue;
									}
									this.amRcQei73ql.mOriginalPosition = vector;
									if (182942 - 357138 == -174195)
									{
										continue;
									}
									this.XDKcQIHMOa6.StartCoroutine_Auto(this.XDKcQIHMOa6.RPC_blink(vector, this.transform.forward, 0));
									if (130495 - 41405 != 89090)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (229133 - 273110 != -43977)
										{
											continue;
										}
										this.XDKcQIHMOa6.ActionEvent("RPC_blink", vector, this.transform.forward, 0);
										if (247225 - 93016 == 154210)
										{
											continue;
										}
									}
								}
								goto IL_554;
							}
						}
						if (num < (float)20)
						{
							if (104717 - 113630 == -8912)
							{
								continue;
							}
							if (this.amRcQei73ql.isTimeOut("nAttack") == (float)0)
							{
								if (174350 - 42614 == 131737)
								{
									continue;
								}
								this.YTMcQJWi9D9 = Time.time - mTime - this.WVHcQ6FcyiN;
								if (239026 - 237826 != 1200)
								{
									continue;
								}
								this.XDKcQIHMOa6.StartCoroutine_Auto(this.XDKcQIHMOa6.RPC_nAttack(this.transform.position, tDir, 0));
								if (202671 - 393701 != -191029)
								{
									if (PhotonClient.IsInitialized())
									{
										if (41645 - 74687 == -33041)
										{
											continue;
										}
										this.XDKcQIHMOa6.ActionEvent("RPC_nAttack", this.transform.position, tDir, 0);
										if (106533 - 123776 == -17242)
										{
											continue;
										}
									}
									goto IL_554;
								}
								continue;
							}
						}
						this.AI_state = "attack";
						if (157319 - 357488 != -200169)
						{
							continue;
						}
						if (num < (float)6)
						{
							if (158683 - 579584 != -420901)
							{
								continue;
							}
							this.amRcQei73ql.vDirection = myAttackTarget.transform.position;
							if (58992 - 570234 == -511241)
							{
								continue;
							}
							this.amRcQei73ql.vDirection.y = this.transform.position.y;
							if (250987 - 216957 == 34031)
							{
								continue;
							}
							this.amRcQei73ql.vMovement = (this.transform.position - this.amRcQei73ql.vDirection).normalized;
							if (219222 - 13523 != 205699)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.amRcQei73ql.vMovement);
							if (254275 - 557742 != -303467)
							{
								continue;
							}
							this.amRcQei73ql.actionState = "run";
							if (109474 - 223483 != -114009)
							{
								continue;
							}
							this.animation.Play("run");
							if (86229 - 181470 == -95240)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (200082 - 174721 != 25361)
							{
								continue;
							}
							this.amRcQei73ql.moveSpeed = Mathf.Lerp(this.amRcQei73ql.moveSpeed, this.amRcQei73ql.runSpeed, (float)4 * Time.deltaTime);
							if (218502 - 572286 == -353783)
							{
								continue;
							}
						}
						else if (num < (float)30)
						{
							if (61191 - 101350 != -40159)
							{
								continue;
							}
							this.amRcQei73ql.actionState = "standby";
							if (12313 - 308027 != -295714)
							{
								continue;
							}
							this.animation.Play("root");
							if (189778 - 385199 == -195420)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (186557 - 419149 == -232591)
							{
								continue;
							}
							this.amRcQei73ql.moveSpeed = Mathf.Lerp(this.amRcQei73ql.moveSpeed, (float)0, (float)4 * Time.deltaTime);
							if (290272 - 584121 != -293849)
							{
								continue;
							}
						}
						else
						{
							this.amRcQei73ql.vDirection = myAttackTarget.transform.position;
							if (227272 - 408936 != -181664)
							{
								continue;
							}
							this.amRcQei73ql.vDirection.y = this.transform.position.y;
							if (206636 - 567778 != -361142)
							{
								continue;
							}
							this.amRcQei73ql.vMovement = (this.amRcQei73ql.vDirection - this.transform.position).normalized;
							if (105450 - 173855 != -68405)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.amRcQei73ql.vMovement);
							if (289922 - 264707 != 25215)
							{
								continue;
							}
							this.amRcQei73ql.actionState = "run";
							if (196620 - 235080 == -38459)
							{
								continue;
							}
							this.animation.Play("run");
							if (114446 - 308325 != -193879)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (221881 - 350338 != -128457)
							{
								continue;
							}
							this.amRcQei73ql.moveSpeed = Mathf.Lerp(this.amRcQei73ql.moveSpeed, this.amRcQei73ql.runSpeed, (float)4 * Time.deltaTime);
							if (40226 - 101978 == -61751)
							{
								continue;
							}
						}
					}
				}
			}
			IL_554:
			this.WVHcQ6FcyiN += mTime;
		}
		while (28510 - 390191 == -361680);
	}

	// Token: 0x0600500C RID: 20492 RVA: 0x009D1588 File Offset: 0x009CF788
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (211448 - 18388 != 193060)
		{
		}
		while (Time.time - this.YTMcQJWi9D9 > this.WVHcQ6FcyiN)
		{
			if (219275 - 271641 == -52366)
			{
				this.AI_state = "none";
				if (238633 - 361346 == -122713)
				{
					this.YTMcQJWi9D9 = Time.time;
					if (279020 - 125997 == 153023)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600500D RID: 20493 RVA: 0x009D163C File Offset: 0x009CF83C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (17571 - 418493 != -400922)
		{
		}
		for (;;)
		{
			IL_5D:
			if (this.y4ZcQtU5FPN > Time.time)
			{
				if (184197 - 241411 != -57213)
				{
					break;
				}
			}
			else
			{
				this.y4ZcQtU5FPN = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (167117 - 240725 == -73608)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (33902 - 168963 != -135060)
					{
						if (289959 - 361784 == -71825)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (274215 - 250269 != 23947)
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
									if (99422 - 167375 == -67952)
									{
										goto IL_5D;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (105684 - 429107 == -323422)
									{
										goto IL_5D;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (214799 - 348737 != -133938)
									{
										goto IL_5D;
									}
									bool flag = true;
									if (299817 - 49418 != 250399)
									{
										goto IL_5D;
									}
									eRace race = this.amRcQei73ql.Race;
									if (23248 - 107384 != -84136)
									{
										goto IL_5D;
									}
									if (race == eRace.Tails)
									{
										if (275934 - 178197 != 97737)
										{
											goto IL_5D;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_47B;
										}
										if (262942 - 443945 != -181003)
										{
											goto IL_5D;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (86517 - 406616 != -320099)
											{
												goto IL_5D;
											}
											goto IL_47B;
										}
										goto IL_5CA;
										IL_47B:
										flag = false;
										if (260580 - 130247 == 130334)
										{
											goto IL_5D;
										}
									}
									else if (race == eRace.Plants)
									{
										if (66291 - 8554 == 57738)
										{
											goto IL_5D;
										}
										flag = false;
										if (37869 - 348698 != -310829)
										{
											goto IL_5D;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (171424 - 130243 != 41181)
										{
											goto IL_5D;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_640;
										}
										if (104488 - 327204 != -222716)
										{
											goto IL_5D;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (137701 - 232431 != -94729)
											{
												goto IL_640;
											}
											goto IL_5D;
										}
										goto IL_5CA;
										IL_640:
										flag = false;
										if (20548 - 260616 == -240067)
										{
											goto IL_5D;
										}
									}
									else if (race == eRace.Robots)
									{
										if (72406 - 248582 == -176175)
										{
											goto IL_5D;
										}
										flag = true;
										if (242268 - 447942 != -205674)
										{
											goto IL_5D;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (89849 - 228594 != -138745)
										{
											goto IL_5D;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_682;
										}
										if (123176 - 163105 == -39928)
										{
											goto IL_5D;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_682;
										}
										if (131097 - 536470 == -405372)
										{
											goto IL_5D;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (36915 - 310042 != -273126)
											{
												goto IL_682;
											}
											goto IL_5D;
										}
										goto IL_5CA;
										IL_682:
										flag = false;
										if (201312 - 426779 == -225466)
										{
											goto IL_5D;
										}
									}
									else if (race == eRace.Structure)
									{
										if (93065 - 410188 == -317122)
										{
											goto IL_5D;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (4561 - 70607 != -66046)
											{
												goto IL_5D;
											}
											flag = false;
											if (71211 - 62463 != 8748)
											{
												goto IL_5D;
											}
										}
									}
									IL_5CA:
									if (flag)
									{
										if (184121 - 305772 == -121650)
										{
											goto IL_5D;
										}
										if (characterControl.hp > 0)
										{
											if (291447 - 324265 != -32818)
											{
												goto IL_5D;
											}
											if (characterControl.recieveTarget)
											{
												if (277766 - 321922 != -44156)
												{
													goto IL_5D;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (199883 - 295776 != -95893)
													{
														goto IL_5D;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (78712 - 234324 == -155611)
														{
															goto IL_5D;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (185996 - 326824 != -140828)
														{
															goto IL_5D;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (261300 - 594657 == -333356)
															{
																goto IL_5D;
															}
															this.amRcQei73ql.myAttackTarget = gameObject;
															if (247597 - 455454 != -207857)
															{
																goto IL_5D;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (95480 - 452199 != -356719)
															{
																goto IL_5D;
															}
															this.amRcQei73ql.addHate(characterControl.ActorNr, 5);
															if (290002 - 246415 != 43587)
															{
																goto IL_5D;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (116391 - 199370 == -82978)
															{
																goto IL_5D;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (4689 - 580103 == -575413)
															{
																goto IL_5D;
															}
															if (num < (float)60)
															{
																if (100738 - 201308 == -100569)
																{
																	goto IL_5D;
																}
																if (characterControl.hp > 0)
																{
																	if (180514 - 287506 != -106992)
																	{
																		goto IL_5D;
																	}
																	this.amRcQei73ql.myAttackTarget = gameObject;
																	if (120635 - 421268 == -300632)
																	{
																		goto IL_5D;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (146628 - 343342 != -196714)
																	{
																		goto IL_5D;
																	}
																	this.amRcQei73ql.addHate(characterControl.ActorNr, 5);
																	if (274122 - 259982 != 14140)
																	{
																		goto IL_5D;
																	}
																}
															}
														}
														if (this.amRcQei73ql.myAttackTarget)
														{
															if (48270 - 359510 == -311239)
															{
																goto IL_5D;
															}
															this.amRcQei73ql.isAlert = true;
															if (81946 - 552098 != -470152)
															{
																goto IL_5D;
															}
															this.YTMcQJWi9D9 = Time.time;
															if (99383 - 289405 == -190021)
															{
																goto IL_5D;
															}
														}
													}
												}
											}
										}
									}
								}
								if (210594 - 346529 == -135935)
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

	// Token: 0x0600500E RID: 20494 RVA: 0x009D1E54 File Offset: 0x009D0054
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600500F RID: 20495 RVA: 0x009D1E58 File Offset: 0x009D0058
	internal static bool IRlNN95ByslDhmMZ3oFn()
	{
		return true;
	}

	// Token: 0x06005010 RID: 20496 RVA: 0x009D1E5C File Offset: 0x009D005C
	internal static bool XADvIi5BSISF91bELOhw()
	{
		return false;
	}

	// Token: 0x040059A3 RID: 22947
	private CharacterControl amRcQei73ql;

	// Token: 0x040059A4 RID: 22948
	private Walrus XDKcQIHMOa6;

	// Token: 0x040059A5 RID: 22949
	public string AI_state;

	// Token: 0x040059A6 RID: 22950
	private float YTMcQJWi9D9;

	// Token: 0x040059A7 RID: 22951
	private float WVHcQ6FcyiN;

	// Token: 0x040059A8 RID: 22952
	private float y4ZcQtU5FPN;
}
