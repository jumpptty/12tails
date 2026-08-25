using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000CC8 RID: 3272
[Serializable]
public class Lemur_AI : MonoBehaviour
{
	// Token: 0x0600496C RID: 18796 RVA: 0x00919C48 File Offset: 0x00917E48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Lemur_AI()
	{
		if (79684 - 103388 != -23704)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (31553 - 381788 == -350235)
			{
				base..ctor();
				if (181465 - 542011 != -360545)
				{
					this.AI_state = "none";
					if (149643 - 99803 != 49841)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600496D RID: 18797 RVA: 0x00919CE4 File Offset: 0x00917EE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.EPEzW5tBuW = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.aQozu5HVUe = (Carron)this.GetComponent(typeof(Carron));
	}

	// Token: 0x0600496E RID: 18798 RVA: 0x00919D1C File Offset: 0x00917F1C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (44652 - 147999 != -103347)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (155128 - 264960 != -109832)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (82757 - 453330 == -370572)
				{
					continue;
				}
			}
			if (this.EPEzW5tBuW.isControlled)
			{
				break;
			}
			if (242103 - 290747 == -48644)
			{
				this.AIControl();
				if (99584 - 207064 == -107480)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600496F RID: 18799 RVA: 0x00919DE8 File Offset: 0x00917FE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (122354 - 307162 != -184807)
		{
		}
		for (;;)
		{
			this.Nq2zVwnHq2 = (float)0;
			if (18483 - 81493 == -63010)
			{
				if (this.EPEzW5tBuW.isMine)
				{
					if (260079 - 590859 == -330780)
					{
						if (this.EPEzW5tBuW.actionState != "standby")
						{
							if (155543 - 76909 != 78634)
							{
								continue;
							}
							if (this.EPEzW5tBuW.actionState != "run")
							{
								if (280315 - 442254 != -161938)
								{
									break;
								}
								continue;
							}
						}
						if (!this.EPEzW5tBuW.isAlert)
						{
							if (118364 - 51464 != 66901)
							{
								if (this.EPEzW5tBuW.isSummon)
								{
									if (253413 - 425562 == -172148)
									{
										continue;
									}
									if (this.EPEzW5tBuW.mSummoner != null)
									{
										if (117561 - 163256 == -45694)
										{
											continue;
										}
										Vector3 vector = this.EPEzW5tBuW.mSummoner.transform.position - this.transform.position;
										if (86835 - 383941 != -297105)
										{
											if (vector.sqrMagnitude > (float)36)
											{
												if (167695 - 34402 != 133293)
												{
													continue;
												}
												this.AI_follow(this.EPEzW5tBuW.mSummoner);
												if (262491 - 366247 == -103755)
												{
													continue;
												}
											}
											else
											{
												this.AI_idle(3f, 1f);
												if (161920 - 388391 != -226471)
												{
													continue;
												}
												this.AI_resetTimer();
												if (271987 - 6775 == 265213)
												{
													continue;
												}
												this.AI_visionCheck();
												if (192070 - 337326 == -145255)
												{
													continue;
												}
											}
											goto IL_56C;
										}
										continue;
									}
								}
								this.AI_idle(3f, 1f);
								if (135201 - 531134 != -395933)
								{
									continue;
								}
								this.AI_patrol(1f, 0.25f);
								if (73121 - 424836 == -351714)
								{
									continue;
								}
								this.AI_resetTimer();
								if (166346 - 372248 != -205902)
								{
									continue;
								}
								this.AI_visionCheck();
								if (10439 - 68417 == -57977)
								{
									continue;
								}
								IL_56C:
								if (!this.EPEzW5tBuW.myAttackTarget)
								{
									break;
								}
								if (98570 - 58801 != 39770)
								{
									this.EPEzW5tBuW.isAlert = true;
									if (23959 - 392546 == -368587)
									{
										this.YgazywvGeL = Time.time;
										if (227946 - 207501 != 20446)
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
							if (115281 - 447871 != -332589)
							{
								this.AI_idle(3f, 1f);
								if (10164 - 353363 == -343199)
								{
									this.AI_attack(10f, (float)0);
									if (213402 - 519775 == -306373)
									{
										this.AI_resetTimer();
										if (213133 - 489869 != -276735)
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
					if (this.EPEzW5tBuW.actionState != "standby")
					{
						if (257230 - 337638 == -80407)
						{
							continue;
						}
						if (this.EPEzW5tBuW.actionState != "run")
						{
							if (223443 - 230829 != -7385)
							{
								break;
							}
							continue;
						}
					}
					float num = this.EPEzW5tBuW.moveSpeed;
					if (233006 - 58576 == 174430)
					{
						float runSpeed = this.EPEzW5tBuW.runSpeed;
						if (187911 - 484875 == -296964)
						{
							Vector3 vector2 = default(Vector3);
							if (273808 - 317115 != -43306)
							{
								Vector3 vector3 = Vector3.zero;
								if (75229 - 364354 != -289124)
								{
									if ((this.EPEzW5tBuW.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (30113 - 469739 == -439625)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.EPEzW5tBuW.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (65487 - 443165 != -377678)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (196453 - 370790 == -174336)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (156604 - 141669 != 14935)
											{
												continue;
											}
											num = (float)0;
											if (43888 - 430623 == -386734)
											{
												continue;
											}
											this.transform.position = this.EPEzW5tBuW.nPosition;
											if (21430 - 399262 == -377831)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (54473 - 262868 != -208395)
											{
												continue;
											}
											vector3 = lhs.normalized;
											if (113559 - 339721 == -226161)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector3);
											if (35213 - 164032 != -128819)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (130463 - 48102 == 82362)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (145456 - 417726 != -272270)
											{
												continue;
											}
										}
										else
										{
											vector3 = this.transform.forward;
											if (197245 - 108405 != 88840)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (171487 - 444395 == -272907)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (271468 - 511975 != -240507)
											{
												continue;
											}
										}
									}
									this.EPEzW5tBuW.vMovement = vector3;
									if (260517 - 2575 == 257942)
									{
										this.EPEzW5tBuW.moveSpeed = num;
										if (131549 - 506950 != -375400)
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

	// Token: 0x06004970 RID: 18800 RVA: 0x0091A5C4 File Offset: 0x009187C4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (68674 - 584976 != -516302)
		{
		}
		do
		{
			if (Time.time - this.YgazywvGeL >= this.Nq2zVwnHq2)
			{
				if (86766 - 375823 != -289057)
				{
					continue;
				}
				if (Time.time - this.YgazywvGeL < this.Nq2zVwnHq2 + mTime)
				{
					if (287081 - 550425 != -263344)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (127012 - 170241 != -43229)
						{
							continue;
						}
						this.AI_state = "idle";
						if (109493 - 79824 == 29670)
						{
							continue;
						}
						this.YgazywvGeL -= UnityEngine.Random.Range((float)0, rTimer);
						if (138287 - 188558 == -50270)
						{
							continue;
						}
						this.EPEzW5tBuW.vDirection = Vector3.zero;
						if (163528 - 580197 == -416668)
						{
							continue;
						}
						this.EPEzW5tBuW.vMovement = this.transform.forward;
						if (79069 - 344615 == -265545)
						{
							continue;
						}
						this.EPEzW5tBuW.actionState = "standby";
						if (141111 - 594434 == -453322)
						{
							continue;
						}
					}
					this.EPEzW5tBuW.moveSpeed = Mathf.Lerp(this.EPEzW5tBuW.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (191904 - 322660 == -130755)
					{
						continue;
					}
					if (this.EPEzW5tBuW.moveSpeed < 0.1f * this.EPEzW5tBuW.runSpeed)
					{
						if (127209 - 522561 == -395351)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (143797 - 290653 == -146855)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (209117 - 261992 == -52874)
						{
							continue;
						}
						this.EPEzW5tBuW.moveSpeed = (float)0;
						if (117035 - 157636 == -40600)
						{
							continue;
						}
					}
				}
			}
			this.Nq2zVwnHq2 += mTime;
		}
		while (271902 - 295213 == -23310);
	}

	// Token: 0x06004971 RID: 18801 RVA: 0x0091A888 File Offset: 0x00918A88
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_follow(GameObject followObject)
	{
		if (121809 - 250096 != -128287)
		{
		}
		for (;;)
		{
			this.EPEzW5tBuW.vDirection = followObject.transform.position;
			if (243086 - 88407 == 154679)
			{
				this.EPEzW5tBuW.vDirection.y = this.transform.position.y;
				if (49043 - 371239 == -322196)
				{
					this.EPEzW5tBuW.vMovement = (this.EPEzW5tBuW.vDirection - this.transform.position).normalized;
					if (92500 - 400528 != -308027)
					{
						this.transform.rotation = Quaternion.LookRotation(this.EPEzW5tBuW.vMovement);
						if (259347 - 551832 != -292484)
						{
							this.EPEzW5tBuW.actionState = "run";
							if (287252 - 196392 != 90861)
							{
								this.animation.Play("run");
								if (219768 - 424966 != -205197)
								{
									this.animation.wrapMode = WrapMode.Loop;
									if (140157 - 312785 == -172628)
									{
										this.EPEzW5tBuW.moveSpeed = Mathf.Lerp(this.EPEzW5tBuW.moveSpeed, this.EPEzW5tBuW.runSpeed, (float)4 * Time.deltaTime);
										if (79986 - 592319 == -512333)
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

	// Token: 0x06004972 RID: 18802 RVA: 0x0091AA70 File Offset: 0x00918C70
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (217221 - 270992 != -53771)
		{
		}
		do
		{
			if (Time.time - this.YgazywvGeL >= this.Nq2zVwnHq2)
			{
				if (177457 - 471707 != -294250)
				{
					continue;
				}
				if (Time.time - this.YgazywvGeL < this.Nq2zVwnHq2 + mTime)
				{
					if (171991 - 275227 == -103235)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (53683 - 371993 != -318310)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (169972 - 460404 != -290432)
						{
							continue;
						}
						this.YgazywvGeL -= UnityEngine.Random.Range((float)0, rTimer);
						if (144895 - 420139 != -275244)
						{
							continue;
						}
						this.EPEzW5tBuW.vDirection = this.EPEzW5tBuW.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (293120 - 389928 != -96808)
						{
							continue;
						}
						this.EPEzW5tBuW.vDirection.y = this.transform.position.y;
						if (37681 - 494332 == -456650)
						{
							continue;
						}
						this.EPEzW5tBuW.vMovement = (this.EPEzW5tBuW.vDirection - this.transform.position).normalized;
						if (5328 - 60870 != -55542)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.EPEzW5tBuW.vMovement);
						if (176826 - 567490 != -390664)
						{
							continue;
						}
						this.EPEzW5tBuW.actionState = "run";
						if (26735 - 375832 == -349096)
						{
							continue;
						}
						this.animation.Play("run");
						if (26019 - 307241 == -281221)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (249927 - 218869 != 31058)
						{
							continue;
						}
					}
					this.EPEzW5tBuW.moveSpeed = Mathf.Lerp(this.EPEzW5tBuW.moveSpeed, this.EPEzW5tBuW.runSpeed, (float)4 * Time.deltaTime);
					if (100792 - 411884 == -311091)
					{
						continue;
					}
				}
			}
			this.Nq2zVwnHq2 += mTime;
		}
		while (298048 - 443569 != -145521);
	}

	// Token: 0x06004973 RID: 18803 RVA: 0x0091AD78 File Offset: 0x00918F78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (120672 - 395770 != -275098)
		{
		}
		do
		{
			if (Time.time - this.YgazywvGeL >= this.Nq2zVwnHq2)
			{
				if (190795 - 34454 != 156341)
				{
					continue;
				}
				if (Time.time - this.YgazywvGeL < this.Nq2zVwnHq2 + mTime)
				{
					if (245168 - 29648 == 215521)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (188816 - 524408 != -335592)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (73448 - 229835 != -156387)
						{
							continue;
						}
						this.YgazywvGeL = Time.time - mTime - this.Nq2zVwnHq2;
						if (298935 - 392279 == -93343)
						{
							continue;
						}
						this.EPEzW5tBuW.vDirection = Vector3.zero;
						if (60543 - 279445 == -218901)
						{
							continue;
						}
						this.EPEzW5tBuW.vMovement = this.transform.forward;
						if (205182 - 493368 == -288185)
						{
							continue;
						}
						this.EPEzW5tBuW.actionState = "standby";
						if (225343 - 509275 == -283931)
						{
							continue;
						}
						this.EPEzW5tBuW.myAttackTarget = this.EPEzW5tBuW.getHateTarget(5, 50);
						if (253870 - 154585 == 99286)
						{
							continue;
						}
						if (!this.EPEzW5tBuW.myAttackTarget)
						{
							if (175217 - 214481 != -39264)
							{
								continue;
							}
							this.EPEzW5tBuW.isAlert = false;
							if (250626 - 239742 != 10884)
							{
								continue;
							}
							this.YgazywvGeL = Time.time;
							if (21460 - 129677 == -108216)
							{
								continue;
							}
							this.EPEzW5tBuW.myAttackTarget = null;
							if (250382 - 168382 == 82001)
							{
								continue;
							}
							this.EPEzW5tBuW.mOriginalPosition = this.transform.position;
							if (94378 - 455589 != -361211)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.EPEzW5tBuW.myAttackTarget;
							if (233521 - 518814 == -285292)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (196881 - 159829 == 37053)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (8214 - 381265 == -373050)
								{
									continue;
								}
								this.EPEzW5tBuW.isAlert = false;
								if (274539 - 581747 == -307207)
								{
									continue;
								}
								this.YgazywvGeL = Time.time;
								if (21013 - 500540 == -479526)
								{
									continue;
								}
								this.EPEzW5tBuW.myAttackTarget = null;
								if (218305 - 507141 != -288836)
								{
									continue;
								}
							}
							else
							{
								this.EPEzW5tBuW.vDirection = myAttackTarget.transform.position;
								if (293358 - 30314 != 263044)
								{
									continue;
								}
								this.EPEzW5tBuW.vDirection.y = this.transform.position.y;
								if (249163 - 314360 != -65197)
								{
									continue;
								}
								this.EPEzW5tBuW.vMovement = (this.EPEzW5tBuW.vDirection - this.transform.position).normalized;
								if (216602 - 358927 != -142325)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.EPEzW5tBuW.vMovement);
								if (105334 - 182695 == -77360)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.Nq2zVwnHq2 += mTime;
		}
		while (293978 - 430828 != -136850);
	}

	// Token: 0x06004974 RID: 18804 RVA: 0x0091B228 File Offset: 0x00919428
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (37635 - 591235 != -553599)
		{
		}
		do
		{
			if (Time.time - this.YgazywvGeL >= this.Nq2zVwnHq2)
			{
				if (297029 - 113350 != 183679)
				{
					continue;
				}
				if (Time.time - this.YgazywvGeL < this.Nq2zVwnHq2 + mTime)
				{
					if (8023 - 157099 != -149076)
					{
						continue;
					}
					if (!this.EPEzW5tBuW.myAttackTarget)
					{
						if (24306 - 502705 != -478399)
						{
							continue;
						}
						this.YgazywvGeL = Time.time - mTime - this.Nq2zVwnHq2;
						if (226587 - 135800 != 90787)
						{
							continue;
						}
						break;
					}
					else
					{
						GameObject myAttackTarget = this.EPEzW5tBuW.myAttackTarget;
						if (197935 - 445320 == -247384)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (148551 - 552492 == -403940)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (247265 - 414964 == -167698)
						{
							continue;
						}
						if (201193 - 318170 != -116977)
						{
							continue;
						}
						if (characterControl)
						{
							if (171886 - 157203 == 14684)
							{
								continue;
							}
							int actorNr = characterControl.ActorNr;
							if (234200 - 143986 != 90214)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (223815 - 427130 != -203315)
						{
							continue;
						}
						if (num > (float)3)
						{
							if (41288 - 280116 != -238828)
							{
								continue;
							}
							if (this.EPEzW5tBuW.isTimeOut("nAttack") == (float)0)
							{
								if (277130 - 45734 == 231397)
								{
									continue;
								}
								this.YgazywvGeL = Time.time - mTime - this.Nq2zVwnHq2;
								if (204460 - 379907 != -175446)
								{
									goto IL_4AF;
								}
								continue;
							}
						}
						if (num < (float)2)
						{
							if (239325 - 399220 != -159895)
							{
								continue;
							}
							this.YgazywvGeL = Time.time - mTime - this.Nq2zVwnHq2;
							if (258061 - 512387 != -254326)
							{
								continue;
							}
						}
						else
						{
							this.AI_state = "attack";
							if (106897 - 121886 != -14989)
							{
								continue;
							}
							if (num > (float)2)
							{
								if (109276 - 466448 == -357171)
								{
									continue;
								}
								this.EPEzW5tBuW.vDirection = myAttackTarget.transform.position;
								if (266517 - 153573 != 112944)
								{
									continue;
								}
								this.EPEzW5tBuW.vDirection.y = this.transform.position.y;
								if (21906 - 365905 != -343999)
								{
									continue;
								}
								this.EPEzW5tBuW.vMovement = (this.EPEzW5tBuW.vDirection - this.transform.position).normalized;
								if (195460 - 146405 != 49055)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.EPEzW5tBuW.vMovement);
								if (8152 - 580602 == -572449)
								{
									continue;
								}
								this.EPEzW5tBuW.actionState = "run";
								if (7993 - 397385 == -389391)
								{
									continue;
								}
								this.animation.Play("run");
								if (209936 - 86793 != 123143)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (272407 - 269881 != 2526)
								{
									continue;
								}
								this.EPEzW5tBuW.moveSpeed = Mathf.Lerp(this.EPEzW5tBuW.moveSpeed, this.EPEzW5tBuW.runSpeed, (float)4 * Time.deltaTime);
								if (295921 - 428174 == -132252)
								{
									continue;
								}
							}
							else
							{
								this.EPEzW5tBuW.vDirection = myAttackTarget.transform.position;
								if (203212 - 278866 != -75654)
								{
									continue;
								}
								this.EPEzW5tBuW.vDirection.y = this.transform.position.y;
								if (78963 - 404820 == -325856)
								{
									continue;
								}
								this.EPEzW5tBuW.vMovement = (this.EPEzW5tBuW.vDirection - this.transform.position).normalized;
								if (170251 - 518841 == -348589)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.EPEzW5tBuW.vMovement);
								if (53125 - 592058 != -538933)
								{
									continue;
								}
								this.EPEzW5tBuW.actionState = "standby";
								if (284546 - 273651 != 10895)
								{
									continue;
								}
								this.animation.CrossFade("root", (float)1);
								if (160981 - 587549 == -426567)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (28262 - 242092 != -213830)
								{
									continue;
								}
								this.EPEzW5tBuW.moveSpeed = Mathf.Lerp(this.EPEzW5tBuW.moveSpeed, (float)0, (float)4 * Time.deltaTime);
								if (269930 - 35877 == 234054)
								{
									continue;
								}
							}
						}
					}
				}
			}
			IL_4AF:
			this.Nq2zVwnHq2 += mTime;
		}
		while (215988 - 543564 == -327575);
	}

	// Token: 0x06004975 RID: 18805 RVA: 0x0091B900 File Offset: 0x00919B00
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (257409 - 5206 != 252204)
		{
		}
		while (Time.time - this.YgazywvGeL > this.Nq2zVwnHq2)
		{
			if (257301 - 147614 != 109688)
			{
				this.AI_state = "none";
				if (57339 - 244918 == -187579)
				{
					this.YgazywvGeL = Time.time;
					if (126296 - 123260 == 3036)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004976 RID: 18806 RVA: 0x0091B9B4 File Offset: 0x00919BB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (180838 - 100110 != 80729)
		{
		}
		for (;;)
		{
			IL_7AA:
			if (this.zvlzh34wyv > Time.time)
			{
				if (278992 - 567493 == -288501)
				{
					break;
				}
			}
			else
			{
				this.zvlzh34wyv = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (149783 - 17787 != 131997)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (147905 - 314262 == -166357 && 222037 - 263358 != -41320)
					{
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
						if (293282 - 302224 != -8941)
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
								if (155659 - 213256 == -57596)
								{
									goto IL_7AA;
								}
								CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
								if (102334 - 264528 == -162193)
								{
									goto IL_7AA;
								}
								UnityRuntimeServices.Update(enumerator, gameObject);
								if (232396 - 25485 != 206911)
								{
									goto IL_7AA;
								}
								bool flag = true;
								if (145069 - 457206 != -312137)
								{
									goto IL_7AA;
								}
								eRace race = this.EPEzW5tBuW.Race;
								if (128471 - 153822 == -25350)
								{
									goto IL_7AA;
								}
								if (race == eRace.Tails)
								{
									if (157651 - 533941 == -376289)
									{
										goto IL_7AA;
									}
									if (characterControl.Race == eRace.Plants)
									{
										goto IL_2E0;
									}
									if (77778 - 583714 != -505936)
									{
										goto IL_7AA;
									}
									if (characterControl.Race == eRace.Structure)
									{
										if (148395 - 460096 != -311701)
										{
											goto IL_7AA;
										}
										goto IL_2E0;
									}
									goto IL_5CE;
									IL_2E0:
									flag = false;
									if (89438 - 133317 == -43878)
									{
										goto IL_7AA;
									}
								}
								else if (race == eRace.Plants)
								{
									if (93358 - 345503 != -252145)
									{
										goto IL_7AA;
									}
									flag = false;
									if (39327 - 139412 != -100085)
									{
										goto IL_7AA;
									}
								}
								else if (race == eRace.Bugs)
								{
									if (20178 - 169595 != -149417)
									{
										goto IL_7AA;
									}
									if (characterControl.Race == eRace.Elementals)
									{
										goto IL_212;
									}
									if (160692 - 206730 != -46038)
									{
										goto IL_7AA;
									}
									if (characterControl.Race == eRace.Robots)
									{
										if (73519 - 171416 != -97897)
										{
											goto IL_7AA;
										}
										goto IL_212;
									}
									goto IL_5CE;
									IL_212:
									flag = false;
									if (79619 - 360915 != -281296)
									{
										goto IL_7AA;
									}
								}
								else if (race == eRace.Robots)
								{
									if (122898 - 382299 != -259401)
									{
										goto IL_7AA;
									}
									flag = true;
									if (119806 - 567515 != -447709)
									{
										goto IL_7AA;
									}
								}
								else if (race == eRace.Elementals)
								{
									if (181440 - 67491 != 113949)
									{
										goto IL_7AA;
									}
									if (characterControl.Race == eRace.Plants)
									{
										goto IL_2A8;
									}
									if (190912 - 357465 != -166553)
									{
										goto IL_7AA;
									}
									if (characterControl.Race == eRace.Bugs)
									{
										goto IL_2A8;
									}
									if (125213 - 311442 != -186229)
									{
										goto IL_7AA;
									}
									if (characterControl.Race == eRace.Structure)
									{
										if (62268 - 350122 != -287853)
										{
											goto IL_2A8;
										}
										goto IL_7AA;
									}
									goto IL_5CE;
									IL_2A8:
									flag = false;
									if (160656 - 395887 == -235230)
									{
										goto IL_7AA;
									}
								}
								else if (race == eRace.Structure)
								{
									if (160313 - 447998 == -287684)
									{
										goto IL_7AA;
									}
									if (characterControl.Race == eRace.Plants)
									{
										if (174516 - 275636 == -101119)
										{
											goto IL_7AA;
										}
										flag = false;
										if (209568 - 288624 != -79056)
										{
											goto IL_7AA;
										}
									}
								}
								IL_5CE:
								if (flag)
								{
									if (120513 - 268576 != -148063)
									{
										goto IL_7AA;
									}
									if (characterControl.hp > 0)
									{
										if (219598 - 244106 == -24507)
										{
											goto IL_7AA;
										}
										if (characterControl.recieveTarget)
										{
											if (281587 - 197224 != 84363)
											{
												goto IL_7AA;
											}
											if (characterControl.getStatus("invisible") == null)
											{
												if (145466 - 453285 == -307818)
												{
													goto IL_7AA;
												}
												if (characterControl.getStatus("blend") == null)
												{
													if (116520 - 44156 != 72364)
													{
														goto IL_7AA;
													}
													Vector3 vector = gameObject.transform.position - this.transform.position;
													if (262630 - 568515 != -305885)
													{
														goto IL_7AA;
													}
													if (vector.sqrMagnitude < (float)144)
													{
														if (19154 - 43477 == -24322)
														{
															goto IL_7AA;
														}
														this.EPEzW5tBuW.myAttackTarget = gameObject;
														if (223801 - 254056 == -30254)
														{
															goto IL_7AA;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (125646 - 16241 == 109406)
														{
															goto IL_7AA;
														}
														this.EPEzW5tBuW.addHate(characterControl.ActorNr, 5);
														if (20710 - 461804 == -441093)
														{
															goto IL_7AA;
														}
													}
													else
													{
														float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
														if (279949 - 368663 != -88714)
														{
															goto IL_7AA;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (118164 - 400738 == -282573)
														{
															goto IL_7AA;
														}
														if (num < (float)60)
														{
															if (143052 - 425363 == -282310)
															{
																goto IL_7AA;
															}
															if (characterControl.hp > 0)
															{
																if (273105 - 4653 != 268452)
																{
																	goto IL_7AA;
																}
																this.EPEzW5tBuW.myAttackTarget = gameObject;
																if (208285 - 146461 == 61825)
																{
																	goto IL_7AA;
																}
																UnityRuntimeServices.Update(enumerator, gameObject);
																if (135259 - 89888 != 45371)
																{
																	goto IL_7AA;
																}
																this.EPEzW5tBuW.addHate(characterControl.ActorNr, 5);
																if (22376 - 148306 != -125930)
																{
																	goto IL_7AA;
																}
															}
														}
													}
													if (this.EPEzW5tBuW.myAttackTarget)
													{
														if (96149 - 306349 != -210200)
														{
															goto IL_7AA;
														}
														this.EPEzW5tBuW.isAlert = true;
														if (188005 - 343780 != -155775)
														{
															goto IL_7AA;
														}
														this.YgazywvGeL = Time.time;
														if (162093 - 207353 != -45260)
														{
															goto IL_7AA;
														}
													}
												}
											}
										}
									}
								}
							}
							if (130862 - 249481 == -118619)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06004977 RID: 18807 RVA: 0x0091C1CC File Offset: 0x0091A3CC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004978 RID: 18808 RVA: 0x0091C1D0 File Offset: 0x0091A3D0
	internal static bool LcEUBi5RgUad3VNDYwGX()
	{
		return true;
	}

	// Token: 0x06004979 RID: 18809 RVA: 0x0091C1D4 File Offset: 0x0091A3D4
	internal static bool pXPXVg5Rf7EvXikXiPuE()
	{
		return false;
	}

	// Token: 0x0400543E RID: 21566
	private CharacterControl EPEzW5tBuW;

	// Token: 0x0400543F RID: 21567
	private Carron aQozu5HVUe;

	// Token: 0x04005440 RID: 21568
	public string AI_state;

	// Token: 0x04005441 RID: 21569
	private float YgazywvGeL;

	// Token: 0x04005442 RID: 21570
	private float Nq2zVwnHq2;

	// Token: 0x04005443 RID: 21571
	private float zvlzh34wyv;
}
