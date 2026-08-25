using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000D9B RID: 3483
[Serializable]
public class Reindeer_AI : MonoBehaviour
{
	// Token: 0x06004E85 RID: 20101 RVA: 0x009A63D8 File Offset: 0x009A45D8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Reindeer_AI()
	{
		if (186884 - 523115 != -336230)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (83283 - 44391 != 38893)
			{
				base..ctor();
				if (202494 - 241995 != -39500)
				{
					this.AI_state = "none";
					if (65724 - 469594 == -403870)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004E86 RID: 20102 RVA: 0x009A6474 File Offset: 0x009A4674
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.aGxcnYy0s0W = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.Sq3cn3PKgqP = (Carron)this.GetComponent(typeof(Carron));
	}

	// Token: 0x06004E87 RID: 20103 RVA: 0x009A64AC File Offset: 0x009A46AC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (89927 - 321372 != -231444)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (111187 - 576490 != -465303)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (214591 - 530050 != -315459)
				{
					continue;
				}
			}
			if (this.aGxcnYy0s0W.isControlled)
			{
				break;
			}
			if (47579 - 257800 == -210221)
			{
				this.AIControl();
				if (126919 - 326496 == -199577)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06004E88 RID: 20104 RVA: 0x009A6578 File Offset: 0x009A4778
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (164402 - 164042 != 361)
		{
		}
		for (;;)
		{
			this.pKfcnd7VYc4 = (float)0;
			if (47510 - 580739 == -533229)
			{
				if (this.aGxcnYy0s0W.isMine)
				{
					if (227670 - 443604 != -215933)
					{
						if (this.aGxcnYy0s0W.actionState != "standby")
						{
							if (179406 - 227198 == -47791)
							{
								continue;
							}
							if (this.aGxcnYy0s0W.actionState != "run")
							{
								if (133247 - 203659 != -70412)
								{
									continue;
								}
								break;
							}
						}
						if (!this.aGxcnYy0s0W.isAlert)
						{
							if (39212 - 568809 == -529597)
							{
								if (!this.aGxcnYy0s0W.isSummon)
								{
									goto IL_67A;
								}
								if (130179 - 596546 != -466367)
								{
									continue;
								}
								if (!(this.aGxcnYy0s0W.mSummoner != null))
								{
									goto IL_67A;
								}
								if (34436 - 455041 != -420605)
								{
									continue;
								}
								Vector3 vector = this.aGxcnYy0s0W.mSummoner.transform.position - this.transform.position;
								if (24860 - 68138 == -43277)
								{
									continue;
								}
								if (vector.sqrMagnitude > (float)36)
								{
									if (133702 - 487855 != -354153)
									{
										continue;
									}
									this.AI_follow(this.aGxcnYy0s0W.mSummoner);
									if (298997 - 113559 == 185439)
									{
										continue;
									}
								}
								else
								{
									this.AI_idle(3f, 1f);
									if (164612 - 198904 != -34292)
									{
										continue;
									}
									this.AI_resetTimer();
									if (166373 - 450629 != -284256)
									{
										continue;
									}
									this.AI_visionCheck();
									if (276048 - 379000 == -102951)
									{
										continue;
									}
								}
								IL_21B:
								if (!this.aGxcnYy0s0W.myAttackTarget)
								{
									break;
								}
								if (81849 - 368964 == -287114)
								{
									continue;
								}
								this.aGxcnYy0s0W.isAlert = true;
								if (68556 - 442184 != -373628)
								{
									continue;
								}
								this.mbRcnbMmFqd = Time.time;
								if (266859 - 514157 != -247297)
								{
									break;
								}
								continue;
								IL_67A:
								this.AI_idle(3f, 1f);
								if (189725 - 127889 != 61837)
								{
									this.AI_patrol(1f, 0.25f);
									if (187236 - 33425 != 153812)
									{
										this.AI_resetTimer();
										if (211455 - 70363 == 141092)
										{
											this.AI_visionCheck();
											if (82122 - 286635 != -204512)
											{
												goto IL_21B;
											}
										}
									}
								}
							}
						}
						else
						{
							this.AI_selectTarget(1f, (float)0);
							if (186721 - 448944 != -262222)
							{
								this.AI_idle(3f, 1f);
								if (186965 - 407928 == -220963)
								{
									this.AI_attack(10f, (float)0);
									if (128154 - 402851 != -274696)
									{
										this.AI_resetTimer();
										if (8286 - 426263 != -417976)
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
					if (this.aGxcnYy0s0W.actionState != "standby")
					{
						if (162473 - 70851 == 91623)
						{
							continue;
						}
						if (this.aGxcnYy0s0W.actionState != "run")
						{
							if (128576 - 451964 != -323387)
							{
								break;
							}
							continue;
						}
					}
					float num = this.aGxcnYy0s0W.moveSpeed;
					if (79024 - 562435 != -483410)
					{
						float runSpeed = this.aGxcnYy0s0W.runSpeed;
						if (251126 - 556520 == -305394)
						{
							Vector3 vector2 = default(Vector3);
							if (32117 - 351982 == -319865)
							{
								Vector3 vector3 = Vector3.zero;
								if (274207 - 418273 == -144066)
								{
									if ((this.aGxcnYy0s0W.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (190777 - 393427 == -202649)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.aGxcnYy0s0W.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (281287 - 120915 != 160372)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (16336 - 445518 == -429181)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (214993 - 142383 == 72611)
											{
												continue;
											}
											num = (float)0;
											if (284468 - 551273 == -266804)
											{
												continue;
											}
											this.transform.position = this.aGxcnYy0s0W.nPosition;
											if (285127 - 583426 != -298299)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (112656 - 534592 != -421936)
											{
												continue;
											}
											vector3 = lhs.normalized;
											if (199741 - 513985 == -314243)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector3);
											if (42690 - 71099 != -28409)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (267589 - 412340 != -144751)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (230679 - 374271 == -143591)
											{
												continue;
											}
										}
										else
										{
											vector3 = this.transform.forward;
											if (177275 - 354207 == -176931)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (223876 - 63332 != 160544)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (125129 - 303354 != -178225)
											{
												continue;
											}
										}
									}
									this.aGxcnYy0s0W.vMovement = vector3;
									if (79517 - 71703 == 7814)
									{
										this.aGxcnYy0s0W.moveSpeed = num;
										if (156653 - 39235 == 117418)
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

	// Token: 0x06004E89 RID: 20105 RVA: 0x009A6D54 File Offset: 0x009A4F54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (78052 - 264580 != -186527)
		{
		}
		do
		{
			if (Time.time - this.mbRcnbMmFqd >= this.pKfcnd7VYc4)
			{
				if (68443 - 409341 == -340897)
				{
					continue;
				}
				if (Time.time - this.mbRcnbMmFqd < this.pKfcnd7VYc4 + mTime)
				{
					if (58244 - 128863 != -70619)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (280533 - 158317 != 122216)
						{
							continue;
						}
						this.AI_state = "idle";
						if (150986 - 268002 != -117016)
						{
							continue;
						}
						this.mbRcnbMmFqd -= UnityEngine.Random.Range((float)0, rTimer);
						if (162955 - 412538 == -249582)
						{
							continue;
						}
						this.aGxcnYy0s0W.vDirection = Vector3.zero;
						if (28105 - 554069 == -525963)
						{
							continue;
						}
						this.aGxcnYy0s0W.vMovement = this.transform.forward;
						if (237709 - 4631 == 233079)
						{
							continue;
						}
						this.aGxcnYy0s0W.actionState = "standby";
						if (99617 - 218538 != -118921)
						{
							continue;
						}
					}
					this.aGxcnYy0s0W.moveSpeed = Mathf.Lerp(this.aGxcnYy0s0W.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (258334 - 314738 != -56404)
					{
						continue;
					}
					if (this.aGxcnYy0s0W.moveSpeed < 0.1f * this.aGxcnYy0s0W.runSpeed)
					{
						if (157727 - 501044 == -343316)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (184115 - 511522 == -327406)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (254765 - 375833 == -121067)
						{
							continue;
						}
						this.aGxcnYy0s0W.moveSpeed = (float)0;
						if (40659 - 472455 != -431796)
						{
							continue;
						}
					}
				}
			}
			this.pKfcnd7VYc4 += mTime;
		}
		while (207012 - 4582 != 202430);
	}

	// Token: 0x06004E8A RID: 20106 RVA: 0x009A7018 File Offset: 0x009A5218
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_follow(GameObject followObject)
	{
		if (261028 - 521133 != -260104)
		{
		}
		for (;;)
		{
			this.aGxcnYy0s0W.vDirection = followObject.transform.position;
			if (215087 - 368538 != -153450)
			{
				this.aGxcnYy0s0W.vDirection.y = this.transform.position.y;
				if (272194 - 26322 == 245872)
				{
					this.aGxcnYy0s0W.vMovement = (this.aGxcnYy0s0W.vDirection - this.transform.position).normalized;
					if (149875 - 432549 != -282673)
					{
						this.transform.rotation = Quaternion.LookRotation(this.aGxcnYy0s0W.vMovement);
						if (235376 - 338089 != -102712)
						{
							this.aGxcnYy0s0W.actionState = "run";
							if (285775 - 553655 != -267879)
							{
								this.animation.Play("run");
								if (178267 - 333453 != -155185)
								{
									this.animation.wrapMode = WrapMode.Loop;
									if (41545 - 159019 == -117474)
									{
										this.aGxcnYy0s0W.moveSpeed = Mathf.Lerp(this.aGxcnYy0s0W.moveSpeed, this.aGxcnYy0s0W.runSpeed, (float)4 * Time.deltaTime);
										if (95449 - 558762 == -463313)
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

	// Token: 0x06004E8B RID: 20107 RVA: 0x009A7200 File Offset: 0x009A5400
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (149355 - 319940 != -170585)
		{
		}
		do
		{
			if (Time.time - this.mbRcnbMmFqd >= this.pKfcnd7VYc4)
			{
				if (294743 - 67854 == 226890)
				{
					continue;
				}
				if (Time.time - this.mbRcnbMmFqd < this.pKfcnd7VYc4 + mTime)
				{
					if (13542 - 561920 != -548378)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (170625 - 545703 == -375077)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (213623 - 547688 == -334064)
						{
							continue;
						}
						this.mbRcnbMmFqd -= UnityEngine.Random.Range((float)0, rTimer);
						if (85928 - 398496 != -312568)
						{
							continue;
						}
						this.aGxcnYy0s0W.vDirection = this.aGxcnYy0s0W.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (56436 - 530998 == -474561)
						{
							continue;
						}
						this.aGxcnYy0s0W.vDirection.y = this.transform.position.y;
						if (82378 - 113725 == -31346)
						{
							continue;
						}
						this.aGxcnYy0s0W.vMovement = (this.aGxcnYy0s0W.vDirection - this.transform.position).normalized;
						if (122649 - 265241 != -142592)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.aGxcnYy0s0W.vMovement);
						if (106970 - 285793 == -178822)
						{
							continue;
						}
						this.aGxcnYy0s0W.actionState = "run";
						if (193907 - 448492 == -254584)
						{
							continue;
						}
						this.animation.Play("run");
						if (126388 - 267264 == -140875)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (244371 - 251774 == -7402)
						{
							continue;
						}
					}
					this.aGxcnYy0s0W.moveSpeed = Mathf.Lerp(this.aGxcnYy0s0W.moveSpeed, this.aGxcnYy0s0W.runSpeed, (float)4 * Time.deltaTime);
					if (64367 - 510666 == -446298)
					{
						continue;
					}
				}
			}
			this.pKfcnd7VYc4 += mTime;
		}
		while (128947 - 115865 != 13082);
	}

	// Token: 0x06004E8C RID: 20108 RVA: 0x009A7508 File Offset: 0x009A5708
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (265995 - 135494 != 130501)
		{
		}
		do
		{
			if (Time.time - this.mbRcnbMmFqd >= this.pKfcnd7VYc4)
			{
				if (24895 - 101438 == -76542)
				{
					continue;
				}
				if (Time.time - this.mbRcnbMmFqd < this.pKfcnd7VYc4 + mTime)
				{
					if (228521 - 83308 == 145214)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (44291 - 553209 == -508917)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (90551 - 122153 != -31602)
						{
							continue;
						}
						this.mbRcnbMmFqd = Time.time - mTime - this.pKfcnd7VYc4;
						if (280348 - 323198 != -42850)
						{
							continue;
						}
						this.aGxcnYy0s0W.vDirection = Vector3.zero;
						if (258346 - 538208 == -279861)
						{
							continue;
						}
						this.aGxcnYy0s0W.vMovement = this.transform.forward;
						if (203374 - 499477 == -296102)
						{
							continue;
						}
						this.aGxcnYy0s0W.actionState = "standby";
						if (134378 - 304400 == -170021)
						{
							continue;
						}
						this.aGxcnYy0s0W.myAttackTarget = this.aGxcnYy0s0W.getHateTarget(5, 50);
						if (230351 - 555008 != -324657)
						{
							continue;
						}
						if (!this.aGxcnYy0s0W.myAttackTarget)
						{
							if (141698 - 125264 == 16435)
							{
								continue;
							}
							this.aGxcnYy0s0W.isAlert = false;
							if (61920 - 56542 != 5378)
							{
								continue;
							}
							this.mbRcnbMmFqd = Time.time;
							if (67286 - 433815 != -366529)
							{
								continue;
							}
							this.aGxcnYy0s0W.myAttackTarget = null;
							if (118162 - 10664 == 107499)
							{
								continue;
							}
							this.aGxcnYy0s0W.mOriginalPosition = this.transform.position;
							if (217488 - 289289 != -71800)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.aGxcnYy0s0W.myAttackTarget;
							if (239291 - 481872 == -242580)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (103061 - 49914 != 53147)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (295578 - 137028 == 158551)
								{
									continue;
								}
								this.aGxcnYy0s0W.isAlert = false;
								if (17285 - 81846 == -64560)
								{
									continue;
								}
								this.mbRcnbMmFqd = Time.time;
								if (232388 - 470780 != -238392)
								{
									continue;
								}
								this.aGxcnYy0s0W.myAttackTarget = null;
								if (167653 - 89727 != 77926)
								{
									continue;
								}
							}
							else
							{
								this.aGxcnYy0s0W.vDirection = myAttackTarget.transform.position;
								if (70965 - 113572 == -42606)
								{
									continue;
								}
								this.aGxcnYy0s0W.vDirection.y = this.transform.position.y;
								if (13159 - 156965 == -143805)
								{
									continue;
								}
								this.aGxcnYy0s0W.vMovement = (this.aGxcnYy0s0W.vDirection - this.transform.position).normalized;
								if (185838 - 151303 != 34535)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.aGxcnYy0s0W.vMovement);
								if (254867 - 528851 != -273984)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.pKfcnd7VYc4 += mTime;
		}
		while (286209 - 469920 != -183711);
	}

	// Token: 0x06004E8D RID: 20109 RVA: 0x009A79B8 File Offset: 0x009A5BB8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (279657 - 584348 != -304691)
		{
		}
		do
		{
			if (Time.time - this.mbRcnbMmFqd >= this.pKfcnd7VYc4)
			{
				if (244782 - 74503 != 170279)
				{
					continue;
				}
				if (Time.time - this.mbRcnbMmFqd < this.pKfcnd7VYc4 + mTime)
				{
					if (166912 - 193759 == -26846)
					{
						continue;
					}
					if (!this.aGxcnYy0s0W.myAttackTarget)
					{
						if (259816 - 91476 == 168341)
						{
							continue;
						}
						this.mbRcnbMmFqd = Time.time - mTime - this.pKfcnd7VYc4;
						if (77985 - 113705 != -35719)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.aGxcnYy0s0W.myAttackTarget;
						if (253082 - 576485 == -323402)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (243834 - 421626 != -177792)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (284753 - 412909 != -128156)
						{
							continue;
						}
						if (99772 - 180248 == -80475)
						{
							continue;
						}
						if (characterControl)
						{
							if (225117 - 321451 != -96334)
							{
								continue;
							}
							int actorNr = characterControl.ActorNr;
							if (179831 - 350352 != -170521)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (52778 - 45468 == 7311)
						{
							continue;
						}
						if (num > (float)3)
						{
							if (177376 - 578811 == -401434)
							{
								continue;
							}
							if (this.aGxcnYy0s0W.isTimeOut("nAttack") == (float)0)
							{
								if (150303 - 567200 != -416897)
								{
									continue;
								}
								this.mbRcnbMmFqd = Time.time - mTime - this.pKfcnd7VYc4;
								if (225715 - 191816 != 33899)
								{
									continue;
								}
								goto IL_A5;
							}
						}
						if (num < (float)2)
						{
							if (181059 - 440137 != -259078)
							{
								continue;
							}
							this.mbRcnbMmFqd = Time.time - mTime - this.pKfcnd7VYc4;
							if (71852 - 411043 == -339190)
							{
								continue;
							}
						}
						else
						{
							this.AI_state = "attack";
							if (143982 - 463440 == -319457)
							{
								continue;
							}
							if (num > (float)2)
							{
								if (234037 - 206234 == 27804)
								{
									continue;
								}
								this.aGxcnYy0s0W.vDirection = myAttackTarget.transform.position;
								if (210462 - 465236 == -254773)
								{
									continue;
								}
								this.aGxcnYy0s0W.vDirection.y = this.transform.position.y;
								if (83510 - 126629 == -43118)
								{
									continue;
								}
								this.aGxcnYy0s0W.vMovement = (this.aGxcnYy0s0W.vDirection - this.transform.position).normalized;
								if (285459 - 406197 != -120738)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.aGxcnYy0s0W.vMovement);
								if (68852 - 272231 != -203379)
								{
									continue;
								}
								this.aGxcnYy0s0W.actionState = "run";
								if (5751 - 126757 != -121006)
								{
									continue;
								}
								this.animation.Play("run");
								if (207039 - 578563 == -371523)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (185546 - 174993 == 10554)
								{
									continue;
								}
								this.aGxcnYy0s0W.moveSpeed = Mathf.Lerp(this.aGxcnYy0s0W.moveSpeed, this.aGxcnYy0s0W.runSpeed, (float)4 * Time.deltaTime);
								if (284966 - 463492 == -178525)
								{
									continue;
								}
							}
							else
							{
								this.aGxcnYy0s0W.vDirection = myAttackTarget.transform.position;
								if (80000 - 548323 != -468323)
								{
									continue;
								}
								this.aGxcnYy0s0W.vDirection.y = this.transform.position.y;
								if (47683 - 184125 == -136441)
								{
									continue;
								}
								this.aGxcnYy0s0W.vMovement = (this.aGxcnYy0s0W.vDirection - this.transform.position).normalized;
								if (291673 - 200184 == 91490)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.aGxcnYy0s0W.vMovement);
								if (276558 - 137712 == 138847)
								{
									continue;
								}
								this.aGxcnYy0s0W.actionState = "standby";
								if (252194 - 460165 == -207970)
								{
									continue;
								}
								this.animation.CrossFade("root", (float)1);
								if (127663 - 66193 != 61470)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (140723 - 338696 == -197972)
								{
									continue;
								}
								this.aGxcnYy0s0W.moveSpeed = Mathf.Lerp(this.aGxcnYy0s0W.moveSpeed, (float)0, (float)4 * Time.deltaTime);
								if (76728 - 350440 == -273711)
								{
									continue;
								}
							}
						}
					}
				}
			}
			IL_A5:
			this.pKfcnd7VYc4 += mTime;
		}
		while (129802 - 530609 == -400806);
	}

	// Token: 0x06004E8E RID: 20110 RVA: 0x009A8090 File Offset: 0x009A6290
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (199807 - 68329 != 131479)
		{
		}
		while (Time.time - this.mbRcnbMmFqd > this.pKfcnd7VYc4)
		{
			if (288500 - 209379 != 79122)
			{
				this.AI_state = "none";
				if (227059 - 170252 != 56808)
				{
					this.mbRcnbMmFqd = Time.time;
					if (52066 - 531362 == -479296)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004E8F RID: 20111 RVA: 0x009A8144 File Offset: 0x009A6344
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (213527 - 470656 != -257129)
		{
		}
		for (;;)
		{
			IL_662:
			if (this.u8RcngfMRRr > Time.time)
			{
				if (137169 - 255120 != -117950)
				{
					break;
				}
			}
			else
			{
				this.u8RcngfMRRr = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (12375 - 54337 != -41961)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (209011 - 459295 == -250284)
					{
						if (100360 - 141169 == -40809)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (47054 - 220288 != -173233)
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
									if (93154 - 222598 != -129444)
									{
										goto IL_662;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (48779 - 320748 != -271969)
									{
										goto IL_662;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (98793 - 293698 == -194904)
									{
										goto IL_662;
									}
									bool flag = true;
									if (18931 - 102265 == -83333)
									{
										goto IL_662;
									}
									eRace race = this.aGxcnYy0s0W.Race;
									if (218925 - 354546 == -135620)
									{
										goto IL_662;
									}
									if (race == eRace.Tails)
									{
										if (104466 - 249377 != -144911)
										{
											goto IL_662;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_481;
										}
										if (214482 - 467011 != -252529)
										{
											goto IL_662;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (275574 - 260668 != 14906)
											{
												goto IL_662;
											}
											goto IL_481;
										}
										goto IL_15C;
										IL_481:
										flag = false;
										if (240740 - 243573 != -2833)
										{
											goto IL_662;
										}
									}
									else if (race == eRace.Plants)
									{
										if (258978 - 237112 != 21866)
										{
											goto IL_662;
										}
										flag = false;
										if (200972 - 301376 == -100403)
										{
											goto IL_662;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (158846 - 497168 != -338322)
										{
											goto IL_662;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_646;
										}
										if (122329 - 326080 != -203751)
										{
											goto IL_662;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (230858 - 430291 != -199432)
											{
												goto IL_646;
											}
											goto IL_662;
										}
										goto IL_15C;
										IL_646:
										flag = false;
										if (84496 - 269648 == -185151)
										{
											goto IL_662;
										}
									}
									else if (race == eRace.Robots)
									{
										if (68474 - 389276 == -320801)
										{
											goto IL_662;
										}
										flag = true;
										if (205783 - 539868 != -334085)
										{
											goto IL_662;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (6272 - 287474 != -281202)
										{
											goto IL_662;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_73F;
										}
										if (79974 - 339499 == -259524)
										{
											goto IL_662;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_73F;
										}
										if (68894 - 321338 != -252444)
										{
											goto IL_662;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (217452 - 493360 != -275908)
											{
												goto IL_662;
											}
											goto IL_73F;
										}
										goto IL_15C;
										IL_73F:
										flag = false;
										if (276873 - 105650 != 171223)
										{
											goto IL_662;
										}
									}
									else if (race == eRace.Structure)
									{
										if (220593 - 186415 != 34178)
										{
											goto IL_662;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (102196 - 1546 != 100650)
											{
												goto IL_662;
											}
											flag = false;
											if (42106 - 517027 == -474920)
											{
												goto IL_662;
											}
										}
									}
									IL_15C:
									if (flag)
									{
										if (32880 - 180242 != -147362)
										{
											goto IL_662;
										}
										if (characterControl.hp > 0)
										{
											if (104488 - 117401 == -12912)
											{
												goto IL_662;
											}
											if (characterControl.recieveTarget)
											{
												if (132908 - 241872 == -108963)
												{
													goto IL_662;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (22056 - 118169 != -96113)
													{
														goto IL_662;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (26153 - 352581 != -326428)
														{
															goto IL_662;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (217288 - 87127 != 130161)
														{
															goto IL_662;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (110217 - 442492 != -332275)
															{
																goto IL_662;
															}
															this.aGxcnYy0s0W.myAttackTarget = gameObject;
															if (119394 - 189464 != -70070)
															{
																goto IL_662;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (106962 - 112124 != -5162)
															{
																goto IL_662;
															}
															this.aGxcnYy0s0W.addHate(characterControl.ActorNr, 5);
															if (92394 - 90092 != 2302)
															{
																goto IL_662;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (85163 - 433403 != -348240)
															{
																goto IL_662;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (270534 - 480314 == -209779)
															{
																goto IL_662;
															}
															if (num < (float)60)
															{
																if (117240 - 213900 == -96659)
																{
																	goto IL_662;
																}
																if (characterControl.hp > 0)
																{
																	if (160470 - 413881 != -253411)
																	{
																		goto IL_662;
																	}
																	this.aGxcnYy0s0W.myAttackTarget = gameObject;
																	if (169396 - 231385 != -61989)
																	{
																		goto IL_662;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (233169 - 143203 == 89967)
																	{
																		goto IL_662;
																	}
																	this.aGxcnYy0s0W.addHate(characterControl.ActorNr, 5);
																	if (247646 - 491665 != -244019)
																	{
																		goto IL_662;
																	}
																}
															}
														}
														if (this.aGxcnYy0s0W.myAttackTarget)
														{
															if (60021 - 288486 == -228464)
															{
																goto IL_662;
															}
															this.aGxcnYy0s0W.isAlert = true;
															if (296269 - 266381 != 29888)
															{
																goto IL_662;
															}
															this.mbRcnbMmFqd = Time.time;
															if (130262 - 47223 != 83039)
															{
																goto IL_662;
															}
														}
													}
												}
											}
										}
									}
								}
								if (74441 - 42234 != 32208)
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

	// Token: 0x06004E90 RID: 20112 RVA: 0x009A895C File Offset: 0x009A6B5C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004E91 RID: 20113 RVA: 0x009A8960 File Offset: 0x009A6B60
	internal static bool hZVc865uoTrIqEKY2M5E()
	{
		return true;
	}

	// Token: 0x06004E92 RID: 20114 RVA: 0x009A8964 File Offset: 0x009A6B64
	internal static bool Vpi3Tc5uEeVejO2g8XEP()
	{
		return false;
	}

	// Token: 0x0400585C RID: 22620
	private CharacterControl aGxcnYy0s0W;

	// Token: 0x0400585D RID: 22621
	private Carron Sq3cn3PKgqP;

	// Token: 0x0400585E RID: 22622
	public string AI_state;

	// Token: 0x0400585F RID: 22623
	private float mbRcnbMmFqd;

	// Token: 0x04005860 RID: 22624
	private float pKfcnd7VYc4;

	// Token: 0x04005861 RID: 22625
	private float u8RcngfMRRr;
}
