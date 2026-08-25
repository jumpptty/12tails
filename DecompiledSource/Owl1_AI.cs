using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000D23 RID: 3363
[Serializable]
public class Owl1_AI : MonoBehaviour
{
	// Token: 0x06004B93 RID: 19347 RVA: 0x00956C48 File Offset: 0x00954E48
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Owl1_AI()
	{
		if (41624 - 598188 != -556564)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (99708 - 224172 != -124463)
			{
				base..ctor();
				if (52604 - 503965 != -451360)
				{
					this.AI_state = "none";
					if (54039 - 71406 == -17367)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004B94 RID: 19348 RVA: 0x00956CE4 File Offset: 0x00954EE4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (128612 - 222202 != -93590)
		{
		}
		for (;;)
		{
			this.SW0ccc4XHxn = this.transform;
			if (11593 - 364973 == -353380)
			{
				this.UwFccn18UGC = (CharacterControl)this.GetComponent(typeof(CharacterControl));
				if (19981 - 142762 == -122781)
				{
					this.TLyccQpgvhP = (Owl1)this.GetComponent(typeof(Owl1));
					if (43168 - 196366 != -153197)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004B95 RID: 19349 RVA: 0x00956DAC File Offset: 0x00954FAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (241762 - 296257 != -54495)
		{
		}
		for (;;)
		{
			if (!this.SW0ccc4XHxn)
			{
				if (222523 - 65971 != 156553)
				{
					break;
				}
			}
			else
			{
				if (Game.mGameState != eGameState.Normal)
				{
					if (21700 - 428848 == -407147)
					{
						continue;
					}
					if (Game.mGameState != eGameState.Hold)
					{
						break;
					}
					if (238750 - 592778 != -354028)
					{
						continue;
					}
				}
				if (this.UwFccn18UGC.isControlled)
				{
					break;
				}
				if (298682 - 551914 == -253232)
				{
					this.AIControl();
					if (272042 - 55441 != 216602)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004B96 RID: 19350 RVA: 0x00956EA8 File Offset: 0x009550A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (185894 - 595355 != -409460)
		{
		}
		for (;;)
		{
			this.MA3ccIf1WFH = (float)0;
			if (155589 - 42058 != 113532)
			{
				if (this.UwFccn18UGC.isMine)
				{
					if (15351 - 375899 == -360548)
					{
						if (this.UwFccn18UGC.actionState != "standby")
						{
							if (224029 - 299298 == -75268)
							{
								continue;
							}
							if (this.UwFccn18UGC.actionState != "run")
							{
								if (134864 - 346205 != -211341)
								{
									continue;
								}
								break;
							}
						}
						if (!this.UwFccn18UGC.isAlert)
						{
							if (174293 - 174843 != -549)
							{
								if (this.UwFccn18UGC.isSummon)
								{
									if (250334 - 352848 == -102513)
									{
										continue;
									}
									if (this.UwFccn18UGC.mSummoner != null)
									{
										if (134008 - 197840 == -63831)
										{
											continue;
										}
										Vector3 vector = this.UwFccn18UGC.mSummoner.transform.position - this.transform.position;
										if (215424 - 38137 != 177287)
										{
											continue;
										}
										if (vector.sqrMagnitude > (float)36)
										{
											if (253951 - 483933 == -229981)
											{
												continue;
											}
											this.AI_follow(this.UwFccn18UGC.mSummoner);
											if (284754 - 336254 != -51500)
											{
												continue;
											}
										}
										else
										{
											this.AI_idle(3f, 1f);
											if (114938 - 291152 != -176214)
											{
												continue;
											}
											this.AI_resetTimer();
											if (279640 - 101498 == 178143)
											{
												continue;
											}
											this.AI_visionCheck();
											if (59496 - 522328 != -462832)
											{
												continue;
											}
										}
										goto IL_214;
									}
								}
								if (Game.mGameCode == 916)
								{
									if (118683 - 292941 != -174258)
									{
										continue;
									}
									this.AI_idle(2f, 1f);
									if (74582 - 255205 == -180622)
									{
										continue;
									}
									this.AI_goToPosition(this.UwFccn18UGC.mOriginalPosition, 4f, 1f);
									if (116277 - 289374 != -173097)
									{
										continue;
									}
									this.AI_resetTimer();
									if (284490 - 211526 == 72965)
									{
										continue;
									}
									this.AI_visionCheck();
									if (97790 - 446299 != -348509)
									{
										continue;
									}
								}
								else
								{
									this.AI_idle(3f, 1f);
									if (3245 - 467520 != -464275)
									{
										continue;
									}
									this.AI_patrol(1f, 0.25f);
									if (87659 - 227870 == -140210)
									{
										continue;
									}
									this.AI_resetTimer();
									if (170018 - 413976 == -243957)
									{
										continue;
									}
									this.AI_visionCheck();
									if (239565 - 576114 == -336548)
									{
										continue;
									}
								}
								IL_214:
								if (!this.UwFccn18UGC.myAttackTarget)
								{
									break;
								}
								if (69347 - 357878 != -288530)
								{
									this.UwFccn18UGC.isAlert = true;
									if (222281 - 560185 != -337903)
									{
										this.pVTcceBuyRf = Time.time;
										if (119791 - 402077 == -282286)
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
							if (264117 - 150075 != 114043)
							{
								this.AI_idle(3f, 1f);
								if (121961 - 308350 == -186389)
								{
									this.AI_attack(10f, (float)0);
									if (111223 - 378602 == -267379)
									{
										this.AI_resetTimer();
										if (76836 - 205213 == -128377)
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
					if (this.UwFccn18UGC.actionState != "standby")
					{
						if (155448 - 181210 != -25762)
						{
							continue;
						}
						if (this.UwFccn18UGC.actionState != "run")
						{
							if (183256 - 95650 != 87607)
							{
								break;
							}
							continue;
						}
					}
					float num = this.UwFccn18UGC.moveSpeed;
					if (133603 - 542514 == -408911)
					{
						float runSpeed = this.UwFccn18UGC.runSpeed;
						if (282222 - 345244 == -63022)
						{
							Vector3 vector2 = default(Vector3);
							if (152643 - 488658 == -336015)
							{
								Vector3 vector3 = Vector3.zero;
								if (178035 - 74929 != 103107)
								{
									if ((this.UwFccn18UGC.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (65647 - 478670 == -413022)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.UwFccn18UGC.nPosition - this.SW0ccc4XHxn.position, new Vector3((float)1, (float)0, (float)1));
										if (127703 - 267376 == -139672)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (159150 - 79392 == 79759)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (225669 - 148914 != 76755)
											{
												continue;
											}
											num = (float)0;
											if (245554 - 307315 != -61761)
											{
												continue;
											}
											this.SW0ccc4XHxn.position = this.UwFccn18UGC.nPosition;
											if (259587 - 222153 != 37434)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (6917 - 464451 == -457533)
											{
												continue;
											}
											vector3 = lhs.normalized;
											if (75808 - 295242 != -219434)
											{
												continue;
											}
											this.SW0ccc4XHxn.rotation = Quaternion.LookRotation(vector3);
											if (92294 - 326184 != -233890)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (192573 - 589434 == -396860)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (112447 - 207664 == -95216)
											{
												continue;
											}
										}
										else
										{
											vector3 = this.SW0ccc4XHxn.forward;
											if (99707 - 407947 == -308239)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (146422 - 307645 == -161222)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (27043 - 599371 == -572327)
											{
												continue;
											}
										}
									}
									this.UwFccn18UGC.vMovement = vector3;
									if (97225 - 511087 != -413861)
									{
										this.UwFccn18UGC.moveSpeed = num;
										if (261258 - 123068 == 138190)
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

	// Token: 0x06004B97 RID: 19351 RVA: 0x00957750 File Offset: 0x00955950
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (251987 - 407328 != -155340)
		{
		}
		do
		{
			if (Time.time - this.pVTcceBuyRf >= this.MA3ccIf1WFH)
			{
				if (106081 - 413287 != -307206)
				{
					continue;
				}
				if (Time.time - this.pVTcceBuyRf < this.MA3ccIf1WFH + mTime)
				{
					if (40549 - 203355 == -162805)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (28270 - 550109 == -521838)
						{
							continue;
						}
						this.AI_state = "idle";
						if (18410 - 546827 != -528417)
						{
							continue;
						}
						this.pVTcceBuyRf -= UnityEngine.Random.Range((float)0, rTimer);
						if (254570 - 285910 != -31340)
						{
							continue;
						}
						this.UwFccn18UGC.vDirection = Vector3.zero;
						if (151016 - 314740 == -163723)
						{
							continue;
						}
						this.UwFccn18UGC.vMovement = this.SW0ccc4XHxn.forward;
						if (173656 - 534440 == -360783)
						{
							continue;
						}
						this.UwFccn18UGC.actionState = "standby";
						if (263041 - 27438 == 235604)
						{
							continue;
						}
					}
					this.UwFccn18UGC.moveSpeed = Mathf.Lerp(this.UwFccn18UGC.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (201182 - 582792 != -381610)
					{
						continue;
					}
					if (this.UwFccn18UGC.moveSpeed < 0.1f * this.UwFccn18UGC.runSpeed)
					{
						if (139762 - 437463 == -297700)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (162244 - 527367 == -365122)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (7369 - 61281 == -53911)
						{
							continue;
						}
						this.UwFccn18UGC.moveSpeed = (float)0;
						if (240950 - 310411 != -69461)
						{
							continue;
						}
					}
				}
			}
			this.MA3ccIf1WFH += mTime;
		}
		while (183147 - 417771 != -234624);
	}

	// Token: 0x06004B98 RID: 19352 RVA: 0x00957A14 File Offset: 0x00955C14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_goToPosition(Vector3 tPosition, float mTime, float rTimer)
	{
		if (73200 - 569308 != -496108)
		{
		}
		do
		{
			if (Time.time - this.pVTcceBuyRf >= this.MA3ccIf1WFH)
			{
				if (121509 - 560096 != -438587)
				{
					continue;
				}
				if (Time.time - this.pVTcceBuyRf < this.MA3ccIf1WFH + mTime)
				{
					if (236085 - 109955 == 126131)
					{
						continue;
					}
					if (this.AI_state != "goToPosition")
					{
						if (240344 - 393870 == -153525)
						{
							continue;
						}
						this.AI_state = "goToPosition";
						if (237653 - 464480 != -226827)
						{
							continue;
						}
						this.pVTcceBuyRf -= UnityEngine.Random.Range((float)0, rTimer);
						if (4829 - 408539 == -403709)
						{
							continue;
						}
					}
					Vector3 vector = this.SW0ccc4XHxn.position - tPosition;
					if (222699 - 156856 == 65844)
					{
						continue;
					}
					if (vector.sqrMagnitude > (float)1)
					{
						if (151410 - 268622 != -117212)
						{
							continue;
						}
						this.UwFccn18UGC.vDirection = tPosition;
						if (65299 - 52676 == 12624)
						{
							continue;
						}
						this.UwFccn18UGC.vDirection.y = this.SW0ccc4XHxn.position.y;
						if (65962 - 469687 != -403725)
						{
							continue;
						}
						this.UwFccn18UGC.vMovement = (tPosition - this.SW0ccc4XHxn.position).normalized;
						if (166745 - 588036 == -421290)
						{
							continue;
						}
						this.SW0ccc4XHxn.rotation = Quaternion.LookRotation(this.UwFccn18UGC.vMovement);
						if (134835 - 403324 == -268488)
						{
							continue;
						}
						this.UwFccn18UGC.actionState = "run";
						if (106433 - 193821 == -87387)
						{
							continue;
						}
						this.animation.Play("run");
						if (30922 - 499361 == -468438)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (202573 - 410399 == -207825)
						{
							continue;
						}
						this.UwFccn18UGC.moveSpeed = Mathf.Lerp(this.UwFccn18UGC.moveSpeed, this.UwFccn18UGC.runSpeed, (float)4 * Time.deltaTime);
						if (289404 - 443383 == -153978)
						{
							continue;
						}
					}
					else
					{
						this.UwFccn18UGC.vDirection = this.SW0ccc4XHxn.position + this.UwFccn18UGC.mOriginalDirection;
						if (159109 - 512859 != -353750)
						{
							continue;
						}
						this.UwFccn18UGC.vMovement = this.UwFccn18UGC.mOriginalDirection;
						if (275592 - 218145 == 57448)
						{
							continue;
						}
						this.UwFccn18UGC.moveSpeed = (float)0;
						if (164467 - 15661 == 148807)
						{
							continue;
						}
						this.SW0ccc4XHxn.rotation = Quaternion.LookRotation(this.UwFccn18UGC.vMovement);
						if (113126 - 108688 != 4438)
						{
							continue;
						}
						this.pVTcceBuyRf = Time.time - mTime - this.MA3ccIf1WFH;
						if (251910 - 564852 == -312941)
						{
							continue;
						}
					}
				}
			}
			this.MA3ccIf1WFH += mTime;
		}
		while (202290 - 487389 == -285098);
	}

	// Token: 0x06004B99 RID: 19353 RVA: 0x00957E48 File Offset: 0x00956048
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_follow(GameObject followObject)
	{
		if (20751 - 530951 != -510199)
		{
		}
		for (;;)
		{
			this.UwFccn18UGC.vDirection = followObject.transform.position;
			if (10116 - 420958 != -410841)
			{
				this.UwFccn18UGC.vDirection.y = this.transform.position.y;
				if (299540 - 539859 != -240318)
				{
					this.UwFccn18UGC.vMovement = (this.UwFccn18UGC.vDirection - this.transform.position).normalized;
					if (275965 - 473358 == -197393)
					{
						this.transform.rotation = Quaternion.LookRotation(this.UwFccn18UGC.vMovement);
						if (237160 - 480787 == -243627)
						{
							this.UwFccn18UGC.actionState = "run";
							if (31988 - 494563 == -462575)
							{
								this.animation.Play("run");
								if (252753 - 343835 != -91081)
								{
									this.animation.wrapMode = WrapMode.Loop;
									if (49335 - 320919 != -271583)
									{
										this.UwFccn18UGC.moveSpeed = Mathf.Lerp(this.UwFccn18UGC.moveSpeed, this.UwFccn18UGC.runSpeed, (float)4 * Time.deltaTime);
										if (51595 - 481769 == -430174)
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

	// Token: 0x06004B9A RID: 19354 RVA: 0x00958030 File Offset: 0x00956230
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (65368 - 512009 != -446640)
		{
		}
		do
		{
			if (Time.time - this.pVTcceBuyRf >= this.MA3ccIf1WFH)
			{
				if (204243 - 392225 != -187982)
				{
					continue;
				}
				if (Time.time - this.pVTcceBuyRf < this.MA3ccIf1WFH + mTime)
				{
					if (4713 - 541246 != -536533)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (146669 - 197639 != -50970)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (119592 - 207213 != -87621)
						{
							continue;
						}
						this.pVTcceBuyRf -= UnityEngine.Random.Range((float)0, rTimer);
						if (210661 - 447285 != -236624)
						{
							continue;
						}
						this.UwFccn18UGC.vDirection = this.UwFccn18UGC.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (234526 - 234908 != -382)
						{
							continue;
						}
						this.UwFccn18UGC.vDirection.y = this.SW0ccc4XHxn.position.y;
						if (63723 - 579707 == -515983)
						{
							continue;
						}
						this.UwFccn18UGC.vMovement = (this.UwFccn18UGC.vDirection - this.SW0ccc4XHxn.position).normalized;
						if (175556 - 390563 == -215006)
						{
							continue;
						}
						this.SW0ccc4XHxn.rotation = Quaternion.LookRotation(this.UwFccn18UGC.vMovement);
						if (171395 - 264509 != -93114)
						{
							continue;
						}
						this.UwFccn18UGC.actionState = "run";
						if (247788 - 185697 != 62091)
						{
							continue;
						}
						this.animation.Play("run");
						if (96270 - 39822 != 56448)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (237543 - 407055 != -169512)
						{
							continue;
						}
					}
					this.UwFccn18UGC.moveSpeed = Mathf.Lerp(this.UwFccn18UGC.moveSpeed, this.UwFccn18UGC.runSpeed, (float)4 * Time.deltaTime);
					if (840 - 250410 == -249569)
					{
						continue;
					}
				}
			}
			this.MA3ccIf1WFH += mTime;
		}
		while (285262 - 183811 != 101451);
	}

	// Token: 0x06004B9B RID: 19355 RVA: 0x00958338 File Offset: 0x00956538
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (257010 - 69177 != 187833)
		{
		}
		do
		{
			if (Time.time - this.pVTcceBuyRf >= this.MA3ccIf1WFH)
			{
				if (35576 - 154963 == -119386)
				{
					continue;
				}
				if (Time.time - this.pVTcceBuyRf < this.MA3ccIf1WFH + mTime)
				{
					if (10118 - 470778 == -460659)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (119474 - 296582 == -177107)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (13213 - 569575 == -556361)
						{
							continue;
						}
						this.pVTcceBuyRf = Time.time - mTime - this.MA3ccIf1WFH;
						if (201593 - 346965 != -145372)
						{
							continue;
						}
						this.UwFccn18UGC.vDirection = Vector3.zero;
						if (6075 - 374740 == -368664)
						{
							continue;
						}
						this.UwFccn18UGC.vMovement = this.SW0ccc4XHxn.forward;
						if (173864 - 551333 == -377468)
						{
							continue;
						}
						this.UwFccn18UGC.actionState = "standby";
						if (16401 - 269419 == -253017)
						{
							continue;
						}
						this.UwFccn18UGC.myAttackTarget = this.UwFccn18UGC.getHateTarget(5, 50);
						if (148166 - 312865 == -164698)
						{
							continue;
						}
						if (!this.UwFccn18UGC.myAttackTarget)
						{
							if (288265 - 577968 == -289702)
							{
								continue;
							}
							this.UwFccn18UGC.isAlert = false;
							if (185214 - 335406 != -150192)
							{
								continue;
							}
							this.pVTcceBuyRf = Time.time;
							if (143458 - 303276 != -159818)
							{
								continue;
							}
							this.UwFccn18UGC.myAttackTarget = null;
							if (85729 - 237742 != -152013)
							{
								continue;
							}
							if (Game.mGameCode == 916)
							{
								break;
							}
							if (19741 - 239639 != -219898)
							{
								continue;
							}
							this.UwFccn18UGC.mOriginalPosition = this.SW0ccc4XHxn.position;
							if (167932 - 213339 != -45406)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.UwFccn18UGC.myAttackTarget;
							if (66024 - 516004 != -449980)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (5562 - 316660 != -311098)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (164131 - 262722 == -98590)
								{
									continue;
								}
								this.UwFccn18UGC.isAlert = false;
								if (9413 - 593180 == -583766)
								{
									continue;
								}
								this.pVTcceBuyRf = Time.time;
								if (15462 - 167840 == -152377)
								{
									continue;
								}
								this.UwFccn18UGC.myAttackTarget = null;
								if (195022 - 91478 == 103545)
								{
									continue;
								}
							}
							else
							{
								this.UwFccn18UGC.vDirection = myAttackTarget.transform.position;
								if (16938 - 569063 != -552125)
								{
									continue;
								}
								this.UwFccn18UGC.vDirection.y = this.SW0ccc4XHxn.position.y;
								if (277017 - 157470 != 119547)
								{
									continue;
								}
								this.UwFccn18UGC.vMovement = (this.UwFccn18UGC.vDirection - this.SW0ccc4XHxn.position).normalized;
								if (19439 - 539193 != -519754)
								{
									continue;
								}
								this.SW0ccc4XHxn.rotation = Quaternion.LookRotation(this.UwFccn18UGC.vMovement);
								if (122679 - 480355 != -357676)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.MA3ccIf1WFH += mTime;
		}
		while (16830 - 56908 == -40077);
	}

	// Token: 0x06004B9C RID: 19356 RVA: 0x00958810 File Offset: 0x00956A10
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (176542 - 558635 != -382092)
		{
		}
		do
		{
			IL_196:
			if (Time.time - this.pVTcceBuyRf >= this.MA3ccIf1WFH)
			{
				if (36860 - 437768 == -400907)
				{
					continue;
				}
				if (Time.time - this.pVTcceBuyRf < this.MA3ccIf1WFH + mTime)
				{
					if (117816 - 508487 != -390671)
					{
						continue;
					}
					if (!this.UwFccn18UGC.myAttackTarget)
					{
						if (198777 - 315592 == -116814)
						{
							continue;
						}
						this.pVTcceBuyRf = Time.time - mTime - this.MA3ccIf1WFH;
						if (49893 - 296366 != -246473)
						{
							continue;
						}
						break;
					}
					else
					{
						GameObject myAttackTarget = this.UwFccn18UGC.myAttackTarget;
						if (67226 - 322545 != -255319)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (293807 - 107061 == 186747)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.SW0ccc4XHxn.position;
						if (26866 - 198277 == -171410 || 263384 - 373464 == -110079)
						{
							continue;
						}
						if (characterControl)
						{
							if (201335 - 153918 == 47418)
							{
								continue;
							}
							int actorNr = characterControl.ActorNr;
							if (249936 - 29316 == 220621)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (245459 - 135572 == 109888)
						{
							continue;
						}
						if (this.UwFccn18UGC.isTimeOut("potion") == (float)0)
						{
							if (226128 - 444886 == -218757)
							{
								continue;
							}
							UnityScript.Lang.Array obj = Hate.findFriends(this.transform.position, (float)24, this.gameObject.layer);
							if (106076 - 94554 == 11523)
							{
								continue;
							}
							GameObject gameObject = this.gameObject;
							if (17552 - 265550 == -247997)
							{
								continue;
							}
							CharacterControl characterControl2 = (CharacterControl)this.GetComponent(typeof(CharacterControl));
							if (43967 - 582310 != -538343)
							{
								continue;
							}
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (97705 - 188351 != -90646)
							{
								continue;
							}
							while (enumerator.MoveNext())
							{
								object obj2 = enumerator.Current;
								object obj4;
								object obj3 = obj4 = obj2;
								if (!(obj3 is GameObject))
								{
									obj4 = RuntimeServices.Coerce(obj3, typeof(GameObject));
								}
								GameObject gameObject2 = (GameObject)obj4;
								if (97454 - 4403 == 93052)
								{
									goto IL_196;
								}
								CharacterControl characterControl3 = (CharacterControl)gameObject2.GetComponent(typeof(CharacterControl));
								if (138245 - 255472 != -117227)
								{
									goto IL_196;
								}
								UnityRuntimeServices.Update(enumerator, gameObject2);
								if (273765 - 222246 == 51520)
								{
									goto IL_196;
								}
								if (characterControl3.hp / characterControl3.mhp < characterControl2.hp / characterControl2.mhp)
								{
									if (280573 - 528676 == -248102)
									{
										goto IL_196;
									}
									gameObject = gameObject2;
									if (128606 - 529367 == -400760)
									{
										goto IL_196;
									}
									UnityRuntimeServices.Update(enumerator, gameObject2);
									if (217141 - 79260 != 137881)
									{
										goto IL_196;
									}
									characterControl2 = characterControl3;
									if (140372 - 351022 == -210649)
									{
										goto IL_196;
									}
								}
							}
							if (65583 - 18462 == 47122)
							{
								continue;
							}
							if (gameObject)
							{
								if (222067 - 119545 != 102522)
								{
									continue;
								}
								if (characterControl2)
								{
									if (47088 - 259071 == -211982)
									{
										continue;
									}
									if (characterControl2.hp < characterControl2.mhp)
									{
										if (41906 - 296996 == -255089)
										{
											continue;
										}
										this.pVTcceBuyRf = Time.time - mTime - this.MA3ccIf1WFH;
										if (244504 - 540076 == -295571)
										{
											continue;
										}
										Vector3 vector2 = global::Math.vFlat(gameObject.transform.position - this.SW0ccc4XHxn.position);
										if (113308 - 352422 == -239113)
										{
											continue;
										}
										vector = vector2.normalized;
										if (55696 - 476157 == -420460)
										{
											continue;
										}
										this.TLyccQpgvhP.StartCoroutine_Auto(this.TLyccQpgvhP.RPC_potion(this.transform.position, vector, characterControl2.ActorNr));
										if (107004 - 180269 != -73265)
										{
											continue;
										}
										if (PhotonClient.IsInitialized())
										{
											if (277974 - 479551 != -201577)
											{
												continue;
											}
											this.TLyccQpgvhP.ActionEvent("RPC_potion", this.SW0ccc4XHxn.position, vector, characterControl2.ActorNr);
											if (161581 - 465160 != -303579)
											{
												continue;
											}
										}
									}
									else
									{
										this.UwFccn18UGC.addTimeOut("potion", (float)6);
										if (190695 - 136350 != 54345)
										{
											continue;
										}
									}
								}
							}
						}
						else
						{
							this.AI_state = "attack";
							if (216656 - 474068 == -257411)
							{
								continue;
							}
							if (num < (float)12)
							{
								if (111055 - 555912 != -444857)
								{
									continue;
								}
								this.UwFccn18UGC.vDirection = myAttackTarget.transform.position;
								if (250494 - 395056 == -144561)
								{
									continue;
								}
								this.UwFccn18UGC.vDirection.y = this.SW0ccc4XHxn.position.y;
								if (76529 - 373056 != -296527)
								{
									continue;
								}
								this.UwFccn18UGC.vMovement = (this.transform.position - this.UwFccn18UGC.vDirection).normalized;
								if (278644 - 519326 == -240681)
								{
									continue;
								}
								this.SW0ccc4XHxn.rotation = Quaternion.LookRotation(this.UwFccn18UGC.vMovement);
								if (262992 - 136877 == 126116)
								{
									continue;
								}
								this.UwFccn18UGC.actionState = "run";
								if (167028 - 119707 == 47322)
								{
									continue;
								}
								this.animation.Play("run");
								if (42493 - 351242 == -308748)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (211486 - 315140 == -103653)
								{
									continue;
								}
								this.UwFccn18UGC.moveSpeed = Mathf.Lerp(this.UwFccn18UGC.moveSpeed, this.UwFccn18UGC.runSpeed, (float)4 * Time.deltaTime);
								if (208189 - 436566 != -228377)
								{
									continue;
								}
								this.TLyccQpgvhP.helpEvent();
								if (168098 - 8618 != 159480)
								{
									continue;
								}
							}
							else
							{
								this.UwFccn18UGC.vDirection = myAttackTarget.transform.position;
								if (81147 - 164877 != -83730)
								{
									continue;
								}
								this.UwFccn18UGC.vDirection.y = this.SW0ccc4XHxn.position.y;
								if (210213 - 37288 == 172926)
								{
									continue;
								}
								this.UwFccn18UGC.vMovement = (this.transform.position - this.UwFccn18UGC.vDirection).normalized;
								if (13814 - 427558 != -413744)
								{
									continue;
								}
								this.SW0ccc4XHxn.rotation = Quaternion.LookRotation(this.UwFccn18UGC.vMovement);
								if (84628 - 32764 != 51864)
								{
									continue;
								}
								this.UwFccn18UGC.actionState = "standby";
								if (75503 - 417637 != -342134)
								{
									continue;
								}
								this.animation.CrossFade("root");
								if (37268 - 114337 == -77068)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (113508 - 49842 == 63667)
								{
									continue;
								}
								this.UwFccn18UGC.moveSpeed = Mathf.Lerp(this.UwFccn18UGC.moveSpeed, (float)0, (float)4 * Time.deltaTime);
								if (100924 - 499850 == -398925)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.MA3ccIf1WFH += mTime;
		}
		while (56481 - 366513 != -310032);
	}

	// Token: 0x06004B9D RID: 19357 RVA: 0x0095924C File Offset: 0x0095744C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (249047 - 557780 != -308732)
		{
		}
		while (Time.time - this.pVTcceBuyRf > this.MA3ccIf1WFH)
		{
			if (215332 - 175311 == 40021)
			{
				this.AI_state = "none";
				if (217801 - 35047 != 182755)
				{
					this.pVTcceBuyRf = Time.time;
					if (171747 - 577723 != -405975)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004B9E RID: 19358 RVA: 0x00959300 File Offset: 0x00957500
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (289386 - 329686 != -40300)
		{
		}
		for (;;)
		{
			IL_3D1:
			if (this.ocTccJoHBIq > Time.time)
			{
				if (22670 - 248337 == -225667)
				{
					break;
				}
			}
			else
			{
				this.ocTccJoHBIq = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (261446 - 36196 == 225250)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (4625 - 45067 == -40442)
					{
						if (57774 - 376985 == -319211)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (141983 - 109990 != 31994)
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
									if (279244 - 492215 == -212970)
									{
										goto IL_3D1;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (237629 - 249323 != -11694)
									{
										goto IL_3D1;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (138665 - 310116 != -171451)
									{
										goto IL_3D1;
									}
									bool flag = true;
									if (98944 - 443107 != -344163)
									{
										goto IL_3D1;
									}
									eRace race = this.UwFccn18UGC.Race;
									if (175252 - 422265 != -247013)
									{
										goto IL_3D1;
									}
									if (race == eRace.Tails)
									{
										if (157788 - 264920 == -107131)
										{
											goto IL_3D1;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_626;
										}
										if (243834 - 292675 != -48841)
										{
											goto IL_3D1;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (76799 - 5827 != 70973)
											{
												goto IL_626;
											}
											goto IL_3D1;
										}
										goto IL_5E1;
										IL_626:
										flag = false;
										if (186448 - 353864 != -167416)
										{
											goto IL_3D1;
										}
									}
									else if (race == eRace.Plants)
									{
										if (11413 - 161745 == -150331)
										{
											goto IL_3D1;
										}
										flag = false;
										if (255297 - 139008 == 116290)
										{
											goto IL_3D1;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (89196 - 152252 == -63055)
										{
											goto IL_3D1;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_7DE;
										}
										if (98844 - 570217 == -471372)
										{
											goto IL_3D1;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (16735 - 368275 != -351539)
											{
												goto IL_7DE;
											}
											goto IL_3D1;
										}
										goto IL_5E1;
										IL_7DE:
										flag = false;
										if (52001 - 66391 == -14389)
										{
											goto IL_3D1;
										}
									}
									else if (race == eRace.Robots)
									{
										if (120272 - 423383 != -303111)
										{
											goto IL_3D1;
										}
										flag = true;
										if (9008 - 259210 == -250201)
										{
											goto IL_3D1;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (251865 - 410515 != -158650)
										{
											goto IL_3D1;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_9C;
										}
										if (220865 - 31398 == 189468)
										{
											goto IL_3D1;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_9C;
										}
										if (184031 - 539093 != -355062)
										{
											goto IL_3D1;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (142384 - 428701 != -286317)
											{
												goto IL_3D1;
											}
											goto IL_9C;
										}
										goto IL_5E1;
										IL_9C:
										flag = false;
										if (67242 - 158921 == -91678)
										{
											goto IL_3D1;
										}
									}
									else if (race == eRace.Structure)
									{
										if (5415 - 129917 != -124502)
										{
											goto IL_3D1;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (232723 - 124492 == 108232)
											{
												goto IL_3D1;
											}
											flag = false;
											if (299288 - 304733 == -5444)
											{
												goto IL_3D1;
											}
										}
									}
									IL_5E1:
									if (flag)
									{
										if (5854 - 521079 == -515224)
										{
											goto IL_3D1;
										}
										if (characterControl.hp > 0)
										{
											if (33538 - 561655 == -528116)
											{
												goto IL_3D1;
											}
											if (characterControl.recieveTarget)
											{
												if (129116 - 314610 != -185494)
												{
													goto IL_3D1;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (222662 - 445449 == -222786)
													{
														goto IL_3D1;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (22535 - 391987 != -369452)
														{
															goto IL_3D1;
														}
														Vector3 vector = gameObject.transform.position - this.SW0ccc4XHxn.position;
														if (137681 - 414164 == -276482)
														{
															goto IL_3D1;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (153918 - 40546 != 113372)
															{
																goto IL_3D1;
															}
															this.UwFccn18UGC.myAttackTarget = gameObject;
															if (217506 - 309930 == -92423)
															{
																goto IL_3D1;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (67307 - 209783 != -142476)
															{
																goto IL_3D1;
															}
															this.UwFccn18UGC.addHate(characterControl.ActorNr, 5);
															if (80791 - 17514 == 63278)
															{
																goto IL_3D1;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.SW0ccc4XHxn.position);
															if (77436 - 337475 == -260038)
															{
																goto IL_3D1;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (266346 - 2401 == 263946)
															{
																goto IL_3D1;
															}
															if (num < (float)60)
															{
																if (115466 - 451410 == -335943)
																{
																	goto IL_3D1;
																}
																if (characterControl.hp > 0)
																{
																	if (78872 - 225247 != -146375)
																	{
																		goto IL_3D1;
																	}
																	this.UwFccn18UGC.myAttackTarget = gameObject;
																	if (181381 - 426745 == -245363)
																	{
																		goto IL_3D1;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (271207 - 168413 == 102795)
																	{
																		goto IL_3D1;
																	}
																	this.UwFccn18UGC.addHate(characterControl.ActorNr, 5);
																	if (177777 - 5695 == 172083)
																	{
																		goto IL_3D1;
																	}
																}
															}
														}
														if (this.UwFccn18UGC.myAttackTarget)
														{
															if (11673 - 3915 != 7758)
															{
																goto IL_3D1;
															}
															this.UwFccn18UGC.isAlert = true;
															if (62825 - 331341 == -268515)
															{
																goto IL_3D1;
															}
															this.pVTcceBuyRf = Time.time;
															if (158402 - 188082 != -29680)
															{
																goto IL_3D1;
															}
														}
													}
												}
											}
										}
									}
								}
								if (244315 - 31413 != 212903)
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

	// Token: 0x06004B9F RID: 19359 RVA: 0x00959B18 File Offset: 0x00957D18
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004BA0 RID: 19360 RVA: 0x00959B1C File Offset: 0x00957D1C
	internal static bool PQocvG57mgdR1nDUwIWH()
	{
		return true;
	}

	// Token: 0x06004BA1 RID: 19361 RVA: 0x00959B20 File Offset: 0x00957D20
	internal static bool aabY2U57FKVlbNFRENK7()
	{
		return false;
	}

	// Token: 0x04005613 RID: 22035
	private Transform SW0ccc4XHxn;

	// Token: 0x04005614 RID: 22036
	private CharacterControl UwFccn18UGC;

	// Token: 0x04005615 RID: 22037
	private Owl1 TLyccQpgvhP;

	// Token: 0x04005616 RID: 22038
	public string AI_state;

	// Token: 0x04005617 RID: 22039
	private float pVTcceBuyRf;

	// Token: 0x04005618 RID: 22040
	private float MA3ccIf1WFH;

	// Token: 0x04005619 RID: 22041
	private float ocTccJoHBIq;
}
