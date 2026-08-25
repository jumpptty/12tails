using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000DE0 RID: 3552
[Serializable]
public class Warthog_AI : MonoBehaviour
{
	// Token: 0x06005039 RID: 20537 RVA: 0x009D5AA4 File Offset: 0x009D3CA4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Warthog_AI()
	{
		if (296435 - 418103 != -121668)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (230193 - 345206 == -115013)
			{
				base..ctor();
				if (217346 - 22931 != 194416)
				{
					this.AI_state = "none";
					if (251569 - 490924 == -239355)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600503A RID: 20538 RVA: 0x009D5B40 File Offset: 0x009D3D40
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.RZ3cQvXFFoI = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.pqLcQl7nQ4A = (Warthog)this.GetComponent(typeof(Warthog));
	}

	// Token: 0x0600503B RID: 20539 RVA: 0x009D5B78 File Offset: 0x009D3D78
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (100360 - 44250 != 56110)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (7096 - 269252 == -262155)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (147575 - 21434 == 126142)
				{
					continue;
				}
			}
			if (this.RZ3cQvXFFoI.isControlled)
			{
				break;
			}
			if (243722 - 450823 != -207100)
			{
				this.AIControl();
				if (180197 - 357493 == -177296)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600503C RID: 20540 RVA: 0x009D5C44 File Offset: 0x009D3E44
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (258027 - 259748 != -1721)
		{
		}
		for (;;)
		{
			this.lh1cQ13rknZ = (float)0;
			if (79269 - 546396 == -467127)
			{
				if (this.RZ3cQvXFFoI.isMine)
				{
					if (299199 - 358175 != -58975)
					{
						if (this.RZ3cQvXFFoI.actionState != "standby")
						{
							if (106373 - 103560 == 2814)
							{
								continue;
							}
							if (this.RZ3cQvXFFoI.actionState != "run")
							{
								if (141909 - 36681 != 105229)
								{
									break;
								}
								continue;
							}
						}
						if (!this.RZ3cQvXFFoI.isAlert)
						{
							if (63338 - 324865 != -261526)
							{
								if (!this.RZ3cQvXFFoI.isSummon)
								{
									goto IL_2CD;
								}
								if (171370 - 451647 != -280277)
								{
									continue;
								}
								if (!(this.RZ3cQvXFFoI.mSummoner != null))
								{
									goto IL_2CD;
								}
								if (102274 - 93614 != 8660)
								{
									continue;
								}
								Vector3 vector = this.RZ3cQvXFFoI.mSummoner.transform.position - this.transform.position;
								if (70912 - 214000 == -143087)
								{
									continue;
								}
								if (vector.sqrMagnitude > (float)36)
								{
									if (290793 - 517456 != -226663)
									{
										continue;
									}
									this.AI_follow(this.RZ3cQvXFFoI.mSummoner);
									if (65147 - 544292 != -479145)
									{
										continue;
									}
								}
								else
								{
									this.AI_idle(3f, 1f);
									if (259959 - 202649 == 57311)
									{
										continue;
									}
									this.AI_resetTimer();
									if (11961 - 265853 == -253891)
									{
										continue;
									}
									this.AI_visionCheck();
									if (97329 - 598585 != -501256)
									{
										continue;
									}
								}
								IL_593:
								if (!this.RZ3cQvXFFoI.myAttackTarget)
								{
									break;
								}
								if (75665 - 472579 != -396914)
								{
									continue;
								}
								this.RZ3cQvXFFoI.isAlert = true;
								if (191144 - 248114 == -56969)
								{
									continue;
								}
								this.QNlcQGm8pFV = Time.time;
								if (151161 - 455465 != -304304)
								{
									continue;
								}
								break;
								IL_2CD:
								this.AI_idle(3f, 1f);
								if (22261 - 110484 == -88223)
								{
									this.AI_patrol(1f, 0.25f);
									if (33600 - 580890 == -547290)
									{
										this.AI_resetTimer();
										if (154935 - 581440 == -426505)
										{
											this.AI_visionCheck();
											if (278085 - 510059 == -231974)
											{
												goto IL_593;
											}
										}
									}
								}
							}
						}
						else
						{
							this.AI_selectTarget(1f, (float)0);
							if (108823 - 116747 != -7923)
							{
								this.AI_idle(3f, 1f);
								if (272671 - 196293 != 76379)
								{
									this.AI_attack(10f, (float)0);
									if (285312 - 251358 != 33955)
									{
										this.AI_resetTimer();
										if (12696 - 154991 != -142294)
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
					if (this.RZ3cQvXFFoI.actionState != "standby")
					{
						if (81484 - 537010 != -455526)
						{
							continue;
						}
						if (this.RZ3cQvXFFoI.actionState != "run")
						{
							if (1157 - 877 != 280)
							{
								continue;
							}
							break;
						}
					}
					float num = this.RZ3cQvXFFoI.moveSpeed;
					if (65942 - 523774 != -457831)
					{
						float runSpeed = this.RZ3cQvXFFoI.runSpeed;
						if (28956 - 26916 != 2041)
						{
							Vector3 vector2 = default(Vector3);
							if (118950 - 488100 != -369149)
							{
								Vector3 vector3 = Vector3.zero;
								if (65924 - 199311 != -133386)
								{
									if ((this.RZ3cQvXFFoI.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (248466 - 539216 != -290750)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.RZ3cQvXFFoI.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (285809 - 49208 != 236601)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (51842 - 454094 == -402251)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (52998 - 546256 == -493257)
											{
												continue;
											}
											num = (float)0;
											if (2631 - 530085 != -527454)
											{
												continue;
											}
											this.transform.position = this.RZ3cQvXFFoI.nPosition;
											if (285502 - 15658 != 269844)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (61500 - 452675 != -391175)
											{
												continue;
											}
											vector3 = lhs.normalized;
											if (277706 - 4170 != 273536)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector3);
											if (244974 - 568767 != -323793)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (112567 - 550828 != -438261)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (115258 - 274862 == -159603)
											{
												continue;
											}
										}
										else
										{
											vector3 = this.transform.forward;
											if (25473 - 379839 != -354366)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (143491 - 319799 != -176308)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (76952 - 397173 != -320221)
											{
												continue;
											}
										}
									}
									this.RZ3cQvXFFoI.vMovement = vector3;
									if (59010 - 89672 == -30662)
									{
										this.RZ3cQvXFFoI.moveSpeed = num;
										if (15802 - 540603 != -524800)
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

	// Token: 0x0600503D RID: 20541 RVA: 0x009D6420 File Offset: 0x009D4620
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (96128 - 74958 != 21171)
		{
		}
		do
		{
			if (Time.time - this.QNlcQGm8pFV >= this.lh1cQ13rknZ)
			{
				if (141707 - 51946 == 89762)
				{
					continue;
				}
				if (Time.time - this.QNlcQGm8pFV < this.lh1cQ13rknZ + mTime)
				{
					if (37460 - 5880 != 31580)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (299757 - 214698 == 85060)
						{
							continue;
						}
						this.AI_state = "idle";
						if (294130 - 195475 == 98656)
						{
							continue;
						}
						this.QNlcQGm8pFV -= UnityEngine.Random.Range((float)0, rTimer);
						if (77624 - 202518 != -124894)
						{
							continue;
						}
						this.RZ3cQvXFFoI.vDirection = Vector3.zero;
						if (149184 - 499646 == -350461)
						{
							continue;
						}
						this.RZ3cQvXFFoI.vMovement = this.transform.forward;
						if (182577 - 327290 != -144713)
						{
							continue;
						}
						this.RZ3cQvXFFoI.actionState = "standby";
						if (123294 - 355150 == -231855)
						{
							continue;
						}
					}
					this.RZ3cQvXFFoI.moveSpeed = Mathf.Lerp(this.RZ3cQvXFFoI.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (181811 - 158327 == 23485)
					{
						continue;
					}
					if (this.RZ3cQvXFFoI.moveSpeed < 0.1f * this.RZ3cQvXFFoI.runSpeed)
					{
						if (229470 - 269705 != -40235)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (119660 - 78402 == 41259)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (128284 - 545015 != -416731)
						{
							continue;
						}
						this.RZ3cQvXFFoI.moveSpeed = (float)0;
						if (101819 - 584136 == -482316)
						{
							continue;
						}
					}
				}
			}
			this.lh1cQ13rknZ += mTime;
		}
		while (188388 - 530944 == -342555);
	}

	// Token: 0x0600503E RID: 20542 RVA: 0x009D66E4 File Offset: 0x009D48E4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_follow(GameObject followObject)
	{
		if (222191 - 85949 != 136243)
		{
		}
		for (;;)
		{
			this.RZ3cQvXFFoI.vDirection = followObject.transform.position;
			if (275400 - 309042 == -33642)
			{
				this.RZ3cQvXFFoI.vDirection.y = this.transform.position.y;
				if (171514 - 252324 == -80810)
				{
					this.RZ3cQvXFFoI.vMovement = (this.RZ3cQvXFFoI.vDirection - this.transform.position).normalized;
					if (247422 - 374591 != -127168)
					{
						this.transform.rotation = Quaternion.LookRotation(this.RZ3cQvXFFoI.vMovement);
						if (213975 - 280956 == -66981)
						{
							this.RZ3cQvXFFoI.actionState = "run";
							if (28803 - 40087 != -11283)
							{
								this.animation.Play("run");
								if (141312 - 453186 == -311874)
								{
									this.animation.wrapMode = WrapMode.Loop;
									if (285729 - 136387 != 149343)
									{
										this.RZ3cQvXFFoI.moveSpeed = Mathf.Lerp(this.RZ3cQvXFFoI.moveSpeed, this.RZ3cQvXFFoI.runSpeed, (float)4 * Time.deltaTime);
										if (296803 - 364012 != -67208)
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

	// Token: 0x0600503F RID: 20543 RVA: 0x009D68CC File Offset: 0x009D4ACC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (191429 - 534076 != -342647)
		{
		}
		do
		{
			if (Time.time - this.QNlcQGm8pFV >= this.lh1cQ13rknZ)
			{
				if (7919 - 278897 != -270978)
				{
					continue;
				}
				if (Time.time - this.QNlcQGm8pFV < this.lh1cQ13rknZ + mTime)
				{
					if (170257 - 314862 == -144604)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (192450 - 298835 == -106384)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (295367 - 345801 == -50433)
						{
							continue;
						}
						this.QNlcQGm8pFV -= UnityEngine.Random.Range((float)0, rTimer);
						if (148572 - 516965 != -368393)
						{
							continue;
						}
						this.RZ3cQvXFFoI.vDirection = this.RZ3cQvXFFoI.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (101124 - 248262 == -147137)
						{
							continue;
						}
						this.RZ3cQvXFFoI.vDirection.y = this.transform.position.y;
						if (273095 - 547099 == -274003)
						{
							continue;
						}
						this.RZ3cQvXFFoI.vMovement = (this.RZ3cQvXFFoI.vDirection - this.transform.position).normalized;
						if (243650 - 271318 != -27668)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.RZ3cQvXFFoI.vMovement);
						if (103945 - 460079 != -356134)
						{
							continue;
						}
						this.RZ3cQvXFFoI.actionState = "run";
						if (76658 - 304514 != -227856)
						{
							continue;
						}
						this.animation.Play("run");
						if (28996 - 19099 == 9898)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (96633 - 432770 != -336137)
						{
							continue;
						}
					}
					this.RZ3cQvXFFoI.moveSpeed = Mathf.Lerp(this.RZ3cQvXFFoI.moveSpeed, this.RZ3cQvXFFoI.runSpeed, (float)4 * Time.deltaTime);
					if (98486 - 394340 != -295854)
					{
						continue;
					}
				}
			}
			this.lh1cQ13rknZ += mTime;
		}
		while (216903 - 433186 == -216282);
	}

	// Token: 0x06005040 RID: 20544 RVA: 0x009D6BD4 File Offset: 0x009D4DD4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (191538 - 319579 != -128040)
		{
		}
		do
		{
			if (Time.time - this.QNlcQGm8pFV >= this.lh1cQ13rknZ)
			{
				if (215691 - 326497 == -110805)
				{
					continue;
				}
				if (Time.time - this.QNlcQGm8pFV < this.lh1cQ13rknZ + mTime)
				{
					if (94601 - 369099 != -274498)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (153857 - 8441 == 145417)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (66218 - 555580 == -489361)
						{
							continue;
						}
						this.QNlcQGm8pFV = Time.time - mTime - this.lh1cQ13rknZ;
						if (230569 - 564709 == -334139)
						{
							continue;
						}
						this.RZ3cQvXFFoI.vDirection = Vector3.zero;
						if (167460 - 180186 == -12725)
						{
							continue;
						}
						this.RZ3cQvXFFoI.vMovement = this.transform.forward;
						if (167571 - 119206 == 48366)
						{
							continue;
						}
						this.RZ3cQvXFFoI.actionState = "standby";
						if (110399 - 87331 == 23069)
						{
							continue;
						}
						this.RZ3cQvXFFoI.myAttackTarget = this.RZ3cQvXFFoI.getHateClosestTarget(40);
						if (221761 - 174646 != 47115)
						{
							continue;
						}
						if (!this.RZ3cQvXFFoI.myAttackTarget)
						{
							if (84327 - 73469 == 10859)
							{
								continue;
							}
							this.RZ3cQvXFFoI.isAlert = false;
							if (121615 - 331593 == -209977)
							{
								continue;
							}
							this.QNlcQGm8pFV = Time.time;
							if (99856 - 26549 == 73308)
							{
								continue;
							}
							this.RZ3cQvXFFoI.myAttackTarget = null;
							if (172579 - 281061 == -108481)
							{
								continue;
							}
							this.RZ3cQvXFFoI.mOriginalPosition = this.transform.position;
							if (85862 - 597869 != -512007)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.RZ3cQvXFFoI.myAttackTarget;
							if (12969 - 250863 != -237894)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (203316 - 110321 == 92996)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (67201 - 253914 == -186712)
								{
									continue;
								}
								this.RZ3cQvXFFoI.isAlert = false;
								if (3412 - 584756 != -581344)
								{
									continue;
								}
								this.QNlcQGm8pFV = Time.time;
								if (127719 - 86565 == 41155)
								{
									continue;
								}
								this.RZ3cQvXFFoI.myAttackTarget = null;
								if (115612 - 550588 == -434975)
								{
									continue;
								}
							}
							else
							{
								this.RZ3cQvXFFoI.vDirection = myAttackTarget.transform.position;
								if (67699 - 61060 != 6639)
								{
									continue;
								}
								this.RZ3cQvXFFoI.vDirection.y = this.transform.position.y;
								if (40885 - 112828 != -71943)
								{
									continue;
								}
								this.RZ3cQvXFFoI.vMovement = (this.RZ3cQvXFFoI.vDirection - this.transform.position).normalized;
								if (75268 - 296588 == -221319)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.RZ3cQvXFFoI.vMovement);
								if (65912 - 406903 == -340990)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.lh1cQ13rknZ += mTime;
		}
		while (241070 - 4876 != 236194);
	}

	// Token: 0x06005041 RID: 20545 RVA: 0x009D7084 File Offset: 0x009D5284
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (64113 - 245411 != -181298)
		{
		}
		do
		{
			if (Time.time - this.QNlcQGm8pFV >= this.lh1cQ13rknZ)
			{
				if (53605 - 429048 != -375443)
				{
					continue;
				}
				if (Time.time - this.QNlcQGm8pFV < this.lh1cQ13rknZ + mTime)
				{
					if (138720 - 402581 == -263860)
					{
						continue;
					}
					if (!this.RZ3cQvXFFoI.myAttackTarget)
					{
						if (161560 - 3627 == 157934)
						{
							continue;
						}
						this.QNlcQGm8pFV = Time.time - mTime - this.lh1cQ13rknZ;
						if (26301 - 275216 != -248915)
						{
							continue;
						}
						break;
					}
					else
					{
						GameObject myAttackTarget = this.RZ3cQvXFFoI.myAttackTarget;
						if (44970 - 443485 == -398514)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (292690 - 79665 != 213025)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (162565 - 252505 == -89939)
						{
							continue;
						}
						int tID = 0;
						if (269341 - 396511 != -127170)
						{
							continue;
						}
						if (characterControl)
						{
							if (9751 - 207150 == -197398)
							{
								continue;
							}
							tID = characterControl.ActorNr;
							if (138514 - 562149 != -423635)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (46887 - 469252 != -422365)
						{
							continue;
						}
						if (num < (float)2)
						{
							if (148738 - 156562 != -7824)
							{
								continue;
							}
							if (this.RZ3cQvXFFoI.isTimeOut("nAttack") == (float)0)
							{
								if (219516 - 389672 == -170155)
								{
									continue;
								}
								this.QNlcQGm8pFV = Time.time - mTime - this.lh1cQ13rknZ;
								if (142739 - 194879 != -52140)
								{
									continue;
								}
								this.pqLcQl7nQ4A.StartCoroutine_Auto(this.pqLcQl7nQ4A.RPC_nAttack(this.transform.position, vector, tID));
								if (99504 - 159008 != -59504)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (94124 - 180708 == -86583)
									{
										continue;
									}
									this.pqLcQl7nQ4A.ActionEvent("RPC_nAttack", this.transform.position, vector, tID);
									if (61980 - 547590 != -485610)
									{
										continue;
									}
								}
								goto IL_70;
							}
						}
						this.AI_state = "attack";
						if (85366 - 233720 == -148353)
						{
							continue;
						}
						if (num > (float)2)
						{
							if (55272 - 380163 != -324891)
							{
								continue;
							}
							this.RZ3cQvXFFoI.vDirection = myAttackTarget.transform.position;
							if (31504 - 240284 == -208779)
							{
								continue;
							}
							this.RZ3cQvXFFoI.vDirection.y = this.transform.position.y;
							if (231595 - 478940 == -247344)
							{
								continue;
							}
							this.RZ3cQvXFFoI.vMovement = (this.RZ3cQvXFFoI.vDirection - this.transform.position).normalized;
							if (100650 - 355182 != -254532)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.RZ3cQvXFFoI.vMovement);
							if (175382 - 515195 != -339813)
							{
								continue;
							}
							this.RZ3cQvXFFoI.actionState = "run";
							if (173119 - 152619 == 20501)
							{
								continue;
							}
							this.animation.Play("run");
							if (4876 - 161780 == -156903)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (641 - 187233 != -186592)
							{
								continue;
							}
							this.RZ3cQvXFFoI.moveSpeed = Mathf.Lerp(this.RZ3cQvXFFoI.moveSpeed, this.RZ3cQvXFFoI.runSpeed, (float)4 * Time.deltaTime);
							if (231691 - 388718 == -157026)
							{
								continue;
							}
						}
						else
						{
							this.RZ3cQvXFFoI.vDirection = myAttackTarget.transform.position;
							if (76277 - 93766 != -17489)
							{
								continue;
							}
							this.RZ3cQvXFFoI.vDirection.y = this.transform.position.y;
							if (236725 - 121775 == 114951)
							{
								continue;
							}
							this.RZ3cQvXFFoI.vMovement = (this.RZ3cQvXFFoI.vDirection - this.transform.position).normalized;
							if (282706 - 116415 == 166292)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.RZ3cQvXFFoI.vMovement);
							if (7812 - 18182 != -10370)
							{
								continue;
							}
							this.RZ3cQvXFFoI.actionState = "standby";
							if (173235 - 451542 == -278306)
							{
								continue;
							}
							this.animation.CrossFade("battle", (float)1);
							if (65489 - 140425 != -74936)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (39659 - 11269 != 28390)
							{
								continue;
							}
							this.RZ3cQvXFFoI.moveSpeed = Mathf.Lerp(this.RZ3cQvXFFoI.moveSpeed, (float)0, (float)4 * Time.deltaTime);
							if (157581 - 61975 == 95607)
							{
								continue;
							}
						}
					}
				}
			}
			IL_70:
			this.lh1cQ13rknZ += mTime;
		}
		while (245294 - 353643 == -108348);
	}

	// Token: 0x06005042 RID: 20546 RVA: 0x009D779C File Offset: 0x009D599C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (107749 - 349268 != -241519)
		{
		}
		while (Time.time - this.QNlcQGm8pFV > this.lh1cQ13rknZ)
		{
			if (62881 - 597472 != -534590)
			{
				this.AI_state = "none";
				if (28410 - 245458 != -217047)
				{
					this.QNlcQGm8pFV = Time.time;
					if (139692 - 369254 == -229562)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06005043 RID: 20547 RVA: 0x009D7850 File Offset: 0x009D5A50
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (109386 - 103182 != 6204)
		{
		}
		for (;;)
		{
			IL_35C:
			if (this.vWhcQqfLVdN > Time.time)
			{
				if (46682 - 461628 == -414946)
				{
					break;
				}
			}
			else
			{
				this.vWhcQqfLVdN = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (220980 - 126149 == 94831)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (147510 - 186106 != -38595)
					{
						if (109033 - 75512 == 33521)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (231147 - 479067 != -247919)
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
									if (255068 - 550431 == -295362)
									{
										goto IL_35C;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (5711 - 357045 == -351333)
									{
										goto IL_35C;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (167595 - 280046 != -112451)
									{
										goto IL_35C;
									}
									bool flag = true;
									if (221605 - 106156 == 115450)
									{
										goto IL_35C;
									}
									eRace race = this.RZ3cQvXFFoI.Race;
									if (256780 - 424997 != -168217)
									{
										goto IL_35C;
									}
									if (race == eRace.Tails)
									{
										if (86840 - 231921 != -145081)
										{
											goto IL_35C;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_558;
										}
										if (228112 - 219633 == 8480)
										{
											goto IL_35C;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (210248 - 182890 != 27358)
											{
												goto IL_35C;
											}
											goto IL_558;
										}
										goto IL_6EA;
										IL_558:
										flag = false;
										if (154941 - 293183 != -138242)
										{
											goto IL_35C;
										}
									}
									else if (race == eRace.Plants)
									{
										if (263617 - 509851 == -246233)
										{
											goto IL_35C;
										}
										flag = false;
										if (22481 - 193041 == -170559)
										{
											goto IL_35C;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (55791 - 162227 != -106436)
										{
											goto IL_35C;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_613;
										}
										if (264216 - 37758 != 226458)
										{
											goto IL_35C;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (297391 - 400801 != -103410)
											{
												goto IL_35C;
											}
											goto IL_613;
										}
										goto IL_6EA;
										IL_613:
										flag = false;
										if (220236 - 276705 == -56468)
										{
											goto IL_35C;
										}
									}
									else if (race == eRace.Robots)
									{
										if (99273 - 348443 != -249170)
										{
											goto IL_35C;
										}
										flag = true;
										if (243812 - 116238 != 127574)
										{
											goto IL_35C;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (143970 - 465245 != -321275)
										{
											goto IL_35C;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_67D;
										}
										if (88953 - 540826 == -451872)
										{
											goto IL_35C;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_67D;
										}
										if (274223 - 528634 == -254410)
										{
											goto IL_35C;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (279571 - 31552 != 248020)
											{
												goto IL_67D;
											}
											goto IL_35C;
										}
										goto IL_6EA;
										IL_67D:
										flag = false;
										if (114619 - 10150 != 104469)
										{
											goto IL_35C;
										}
									}
									else if (race == eRace.Structure)
									{
										if (11831 - 68874 != -57043)
										{
											goto IL_35C;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (241327 - 8715 != 232612)
											{
												goto IL_35C;
											}
											flag = false;
											if (154630 - 134944 == 19687)
											{
												goto IL_35C;
											}
										}
									}
									IL_6EA:
									if (flag)
									{
										if (83968 - 208074 != -124106)
										{
											goto IL_35C;
										}
										if (characterControl.hp > 0)
										{
											if (194139 - 511170 != -317031)
											{
												goto IL_35C;
											}
											if (characterControl.recieveTarget)
											{
												if (271004 - 38041 != 232963)
												{
													goto IL_35C;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (175411 - 297592 == -122180)
													{
														goto IL_35C;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (22840 - 590905 != -568065)
														{
															goto IL_35C;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (89729 - 420297 == -330567)
														{
															goto IL_35C;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (19776 - 496830 != -477054)
															{
																goto IL_35C;
															}
															this.RZ3cQvXFFoI.myAttackTarget = gameObject;
															if (230997 - 505661 != -274664)
															{
																goto IL_35C;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (123403 - 220096 != -96693)
															{
																goto IL_35C;
															}
															this.RZ3cQvXFFoI.addHate(characterControl.ActorNr, 5);
															if (265565 - 538290 == -272724)
															{
																goto IL_35C;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (124334 - 242795 != -118461)
															{
																goto IL_35C;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (37409 - 445376 != -407967)
															{
																goto IL_35C;
															}
															if (num < (float)60)
															{
																if (238527 - 427585 == -189057)
																{
																	goto IL_35C;
																}
																if (characterControl.hp > 0)
																{
																	if (194582 - 125430 == 69153)
																	{
																		goto IL_35C;
																	}
																	this.RZ3cQvXFFoI.myAttackTarget = gameObject;
																	if (219706 - 160007 != 59699)
																	{
																		goto IL_35C;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (197184 - 484210 == -287025)
																	{
																		goto IL_35C;
																	}
																	this.RZ3cQvXFFoI.addHate(characterControl.ActorNr, 5);
																	if (163916 - 145910 != 18006)
																	{
																		goto IL_35C;
																	}
																}
															}
														}
														if (this.RZ3cQvXFFoI.myAttackTarget)
														{
															if (209390 - 132763 == 76628)
															{
																goto IL_35C;
															}
															this.RZ3cQvXFFoI.isAlert = true;
															if (83041 - 363955 == -280913)
															{
																goto IL_35C;
															}
															this.QNlcQGm8pFV = Time.time;
															if (276647 - 184082 != 92565)
															{
																goto IL_35C;
															}
														}
													}
												}
											}
										}
									}
								}
								if (151320 - 584640 == -433320)
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

	// Token: 0x06005044 RID: 20548 RVA: 0x009D8068 File Offset: 0x009D6268
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06005045 RID: 20549 RVA: 0x009D806C File Offset: 0x009D626C
	internal static bool KCJvp95BnCdXUJUfgLxU()
	{
		return true;
	}

	// Token: 0x06005046 RID: 20550 RVA: 0x009D8070 File Offset: 0x009D6270
	internal static bool hZb9VY5B6IVHd1dWK7Fn()
	{
		return false;
	}

	// Token: 0x040059CA RID: 22986
	private CharacterControl RZ3cQvXFFoI;

	// Token: 0x040059CB RID: 22987
	private Warthog pqLcQl7nQ4A;

	// Token: 0x040059CC RID: 22988
	public string AI_state;

	// Token: 0x040059CD RID: 22989
	private float QNlcQGm8pFV;

	// Token: 0x040059CE RID: 22990
	private float lh1cQ13rknZ;

	// Token: 0x040059CF RID: 22991
	private float vWhcQqfLVdN;
}
