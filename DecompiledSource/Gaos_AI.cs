using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020002D8 RID: 728
[Serializable]
public class Gaos_AI : MonoBehaviour
{
	// Token: 0x06001081 RID: 4225 RVA: 0x001A1F8C File Offset: 0x001A018C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Gaos_AI()
	{
		if (37286 - 82090 != -44804)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (11666 - 367546 == -355880)
			{
				base..ctor();
				if (142846 - 501533 == -358687)
				{
					this.AI_state = "none";
					if (128763 - 147544 == -18781)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06001082 RID: 4226 RVA: 0x001A2028 File Offset: 0x001A0228
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.jkl6Jw85IJ = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.Rug66ZfBxo = (Gaos)this.GetComponent(typeof(Gaos));
	}

	// Token: 0x06001083 RID: 4227 RVA: 0x001A2060 File Offset: 0x001A0260
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (162685 - 528385 != -365699)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (191159 - 415070 != -223911)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (88428 - 45712 != 42716)
				{
					continue;
				}
			}
			if (this.jkl6Jw85IJ.isControlled)
			{
				break;
			}
			if (201238 - 179016 != 22223)
			{
				this.AIControl();
				if (254668 - 435583 != -180914)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06001084 RID: 4228 RVA: 0x001A212C File Offset: 0x001A032C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (36565 - 436264 != -399698)
		{
		}
		for (;;)
		{
			this.Lt76XdbGJq = (float)0;
			if (6384 - 312829 == -306445)
			{
				if (this.jkl6Jw85IJ.isMine)
				{
					if (28007 - 315495 != -287487)
					{
						if (this.jkl6Jw85IJ.actionState != "standby")
						{
							if (25201 - 118711 != -93510)
							{
								continue;
							}
							if (this.jkl6Jw85IJ.actionState != "run")
							{
								if (133740 - 257454 != -123713)
								{
									break;
								}
								continue;
							}
						}
						if (this.jkl6Jw85IJ.isSummon)
						{
							if (51433 - 210907 == -159473)
							{
								continue;
							}
							if (this.AI_state == "defense")
							{
								if (163768 - 442553 != -278785)
								{
									continue;
								}
								this.AI_defense();
								if (154741 - 567061 != -412319)
								{
									break;
								}
								continue;
							}
						}
						if (!this.jkl6Jw85IJ.isAlert)
						{
							if (265784 - 137229 == 128555)
							{
								if (!this.jkl6Jw85IJ.isSummon)
								{
									goto IL_23A;
								}
								if (15746 - 312864 == -297117)
								{
									continue;
								}
								if (!(this.jkl6Jw85IJ.mSummoner != null))
								{
									goto IL_23A;
								}
								if (99262 - 93671 != 5591)
								{
									continue;
								}
								Vector3 vector = this.jkl6Jw85IJ.mSummoner.transform.position - this.transform.position;
								if (242490 - 135204 == 107287)
								{
									continue;
								}
								if (vector.sqrMagnitude > (float)81)
								{
									if (54022 - 316151 != -262129)
									{
										continue;
									}
									this.AI_follow(this.jkl6Jw85IJ.mSummoner);
									if (25527 - 566288 != -540761)
									{
										continue;
									}
								}
								else
								{
									this.AI_idle(3f, 1f);
									if (42808 - 272843 == -230034)
									{
										continue;
									}
									this.AI_resetTimer();
									if (139195 - 258285 == -119089)
									{
										continue;
									}
									this.AI_visionCheck();
									if (15389 - 167393 == -152003)
									{
										continue;
									}
								}
								IL_A3:
								if (!this.jkl6Jw85IJ.myAttackTarget)
								{
									break;
								}
								if (276701 - 28388 == 248314)
								{
									continue;
								}
								this.jkl6Jw85IJ.isAlert = true;
								if (159458 - 355330 != -195872)
								{
									continue;
								}
								this.RNn6t1ced7 = Time.time;
								if (74091 - 85532 != -11440)
								{
									break;
								}
								continue;
								IL_23A:
								this.AI_idle(3f, 1f);
								if (254572 - 512541 == -257969)
								{
									this.AI_patrol(1f, 0.25f);
									if (227650 - 590218 == -362568)
									{
										this.AI_resetTimer();
										if (277953 - 128775 != 149179)
										{
											this.AI_visionCheck();
											if (61206 - 393194 != -331987)
											{
												goto IL_A3;
											}
										}
									}
								}
							}
						}
						else
						{
							if (this.jkl6Jw85IJ.isSummon)
							{
								if (90401 - 448035 == -357633)
								{
									continue;
								}
								if (this.jkl6Jw85IJ.mSummoner != null)
								{
									if (254648 - 413497 == -158848)
									{
										continue;
									}
									Vector3 vector2 = this.jkl6Jw85IJ.mSummoner.transform.position - this.transform.position;
									if (296581 - 150189 == 146393)
									{
										continue;
									}
									if (vector2.sqrMagnitude > (float)1225)
									{
										if (271472 - 421808 != -150336)
										{
											continue;
										}
										this.jkl6Jw85IJ.isAlert = false;
										if (252646 - 264125 == -11478)
										{
											continue;
										}
										this.AI_resetTimer();
										if (217660 - 500864 == -283203)
										{
											continue;
										}
									}
								}
							}
							this.AI_selectTarget(1f, (float)0);
							if (6493 - 209710 != -203216)
							{
								this.AI_idle(2f, 1f);
								if (154096 - 492811 != -338714)
								{
									this.AI_attack(10f, (float)0);
									if (65534 - 157848 != -92313)
									{
										this.AI_resetTimer();
										if (296750 - 402194 == -105444)
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
					if (this.jkl6Jw85IJ.actionState != "standby")
					{
						if (272496 - 460933 == -188436)
						{
							continue;
						}
						if (this.jkl6Jw85IJ.actionState != "run")
						{
							if (72155 - 547828 != -475673)
							{
								continue;
							}
							break;
						}
					}
					float num = this.jkl6Jw85IJ.moveSpeed;
					if (232216 - 261955 != -29738)
					{
						float runSpeed = this.jkl6Jw85IJ.runSpeed;
						if (30699 - 370625 != -339925)
						{
							Vector3 vector3 = default(Vector3);
							if (109423 - 501312 == -391889)
							{
								Vector3 vector4 = Vector3.zero;
								if (274666 - 169654 != 105013)
								{
									if ((this.jkl6Jw85IJ.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (270012 - 5142 != 264870)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.jkl6Jw85IJ.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (244456 - 296001 == -51544)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (275239 - 547974 != -272735)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (295864 - 526085 != -230221)
											{
												continue;
											}
											num = (float)0;
											if (86679 - 264583 == -177903)
											{
												continue;
											}
											this.transform.position = this.jkl6Jw85IJ.nPosition;
											if (155111 - 276796 == -121684)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (257517 - 438534 == -181016)
											{
												continue;
											}
											vector4 = lhs.normalized;
											if (147550 - 214308 == -66757)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector4);
											if (298848 - 463291 == -164442)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (47847 - 575463 == -527615)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (277017 - 225848 == 51170)
											{
												continue;
											}
										}
										else
										{
											vector4 = this.transform.forward;
											if (71898 - 473820 != -401922)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (215177 - 222666 == -7488)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (197747 - 559777 != -362030)
											{
												continue;
											}
										}
									}
									this.jkl6Jw85IJ.vMovement = vector4;
									if (231459 - 359375 == -127916)
									{
										this.jkl6Jw85IJ.moveSpeed = num;
										if (206286 - 255899 == -49613)
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

	// Token: 0x06001085 RID: 4229 RVA: 0x001A2A90 File Offset: 0x001A0C90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (190223 - 330293 != -140070)
		{
		}
		do
		{
			if (Time.time - this.RNn6t1ced7 >= this.Lt76XdbGJq)
			{
				if (267806 - 490172 == -222365)
				{
					continue;
				}
				if (Time.time - this.RNn6t1ced7 < this.Lt76XdbGJq + mTime)
				{
					if (13165 - 503481 == -490315)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (90455 - 357282 == -266826)
						{
							continue;
						}
						this.AI_state = "idle";
						if (250128 - 64509 != 185619)
						{
							continue;
						}
						this.RNn6t1ced7 -= UnityEngine.Random.Range((float)0, rTimer);
						if (127280 - 121815 == 5466)
						{
							continue;
						}
						this.jkl6Jw85IJ.vDirection = Vector3.zero;
						if (4094 - 318803 == -314708)
						{
							continue;
						}
						this.jkl6Jw85IJ.vMovement = this.transform.forward;
						if (48517 - 524956 == -476438)
						{
							continue;
						}
						this.jkl6Jw85IJ.actionState = "standby";
						if (184319 - 304866 == -120546)
						{
							continue;
						}
					}
					this.jkl6Jw85IJ.moveSpeed = Mathf.Lerp(this.jkl6Jw85IJ.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (157005 - 191917 != -34912)
					{
						continue;
					}
					if (this.jkl6Jw85IJ.moveSpeed < 0.1f * this.jkl6Jw85IJ.runSpeed)
					{
						if (275057 - 444735 == -169677)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (42148 - 262694 != -220546)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (255878 - 163375 != 92503)
						{
							continue;
						}
						this.jkl6Jw85IJ.moveSpeed = (float)0;
						if (263479 - 578417 != -314938)
						{
							continue;
						}
					}
				}
			}
			this.Lt76XdbGJq += mTime;
		}
		while (6254 - 200757 == -194502);
	}

	// Token: 0x06001086 RID: 4230 RVA: 0x001A2D54 File Offset: 0x001A0F54
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (66840 - 273162 != -206321)
		{
		}
		do
		{
			if (Time.time - this.RNn6t1ced7 >= this.Lt76XdbGJq)
			{
				if (59365 - 166179 == -106813)
				{
					continue;
				}
				if (Time.time - this.RNn6t1ced7 < this.Lt76XdbGJq + mTime)
				{
					if (25398 - 237962 == -212563)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (19098 - 239309 == -220210)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (254747 - 396071 == -141323)
						{
							continue;
						}
						this.RNn6t1ced7 -= UnityEngine.Random.Range((float)0, rTimer);
						if (298561 - 122494 == 176068)
						{
							continue;
						}
						this.jkl6Jw85IJ.vDirection = this.jkl6Jw85IJ.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (19910 - 457124 == -437213)
						{
							continue;
						}
						this.jkl6Jw85IJ.vDirection.y = this.transform.position.y;
						if (125268 - 354332 != -229064)
						{
							continue;
						}
						this.jkl6Jw85IJ.vMovement = (this.jkl6Jw85IJ.vDirection - this.transform.position).normalized;
						if (137577 - 123331 == 14247)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.jkl6Jw85IJ.vMovement);
						if (182920 - 512537 != -329617)
						{
							continue;
						}
						this.jkl6Jw85IJ.actionState = "run";
						if (85155 - 247584 == -162428)
						{
							continue;
						}
						this.animation.Play("run");
						if (235571 - 495984 != -260413)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (20206 - 570659 != -550453)
						{
							continue;
						}
					}
					this.jkl6Jw85IJ.moveSpeed = Mathf.Lerp(this.jkl6Jw85IJ.moveSpeed, this.jkl6Jw85IJ.runSpeed, (float)4 * Time.deltaTime);
					if (199159 - 173748 != 25411)
					{
						continue;
					}
				}
			}
			this.Lt76XdbGJq += mTime;
		}
		while (216075 - 318884 == -102808);
	}

	// Token: 0x06001087 RID: 4231 RVA: 0x001A305C File Offset: 0x001A125C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_follow(GameObject followObject)
	{
		if (82420 - 363371 != -280951)
		{
		}
		for (;;)
		{
			this.jkl6Jw85IJ.vDirection = followObject.transform.position;
			if (267654 - 10972 == 256682)
			{
				this.jkl6Jw85IJ.vDirection.y = this.transform.position.y;
				if (273092 - 141665 == 131427)
				{
					this.jkl6Jw85IJ.vMovement = (this.jkl6Jw85IJ.vDirection - this.transform.position).normalized;
					if (67173 - 373523 != -306349)
					{
						this.transform.rotation = Quaternion.LookRotation(this.jkl6Jw85IJ.vMovement);
						if (274551 - 152395 != 122157)
						{
							this.jkl6Jw85IJ.actionState = "run";
							if (240105 - 233068 != 7038)
							{
								this.animation.Play("run");
								if (87011 - 357178 != -270166)
								{
									this.animation.wrapMode = WrapMode.Loop;
									if (105937 - 558250 != -452312)
									{
										this.jkl6Jw85IJ.moveSpeed = Mathf.Lerp(this.jkl6Jw85IJ.moveSpeed, this.jkl6Jw85IJ.runSpeed, (float)4 * Time.deltaTime);
										if (61000 - 219095 != -158094)
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

	// Token: 0x06001088 RID: 4232 RVA: 0x001A3244 File Offset: 0x001A1444
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (57971 - 529267 != -471296)
		{
		}
		do
		{
			if (Time.time - this.RNn6t1ced7 >= this.Lt76XdbGJq)
			{
				if (297495 - 271389 == 26107)
				{
					continue;
				}
				if (Time.time - this.RNn6t1ced7 < this.Lt76XdbGJq + mTime)
				{
					if (167074 - 350919 == -183844)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (293634 - 534840 != -241206)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (115789 - 48004 != 67785)
						{
							continue;
						}
						this.RNn6t1ced7 = Time.time - mTime - this.Lt76XdbGJq;
						if (84347 - 188419 == -104071)
						{
							continue;
						}
						this.jkl6Jw85IJ.vDirection = Vector3.zero;
						if (114625 - 544455 != -429830)
						{
							continue;
						}
						this.jkl6Jw85IJ.vMovement = this.transform.forward;
						if (272548 - 24251 != 248297)
						{
							continue;
						}
						this.jkl6Jw85IJ.actionState = "standby";
						if (132196 - 4552 != 127644)
						{
							continue;
						}
						this.jkl6Jw85IJ.myAttackTarget = this.jkl6Jw85IJ.getHateTarget(5, 50);
						if (33066 - 62906 != -29840)
						{
							continue;
						}
						if (!this.jkl6Jw85IJ.myAttackTarget)
						{
							if (52026 - 325458 != -273432)
							{
								continue;
							}
							this.jkl6Jw85IJ.isAlert = false;
							if (91364 - 173442 == -82077)
							{
								continue;
							}
							this.RNn6t1ced7 = Time.time;
							if (10888 - 568379 == -557490)
							{
								continue;
							}
							this.jkl6Jw85IJ.myAttackTarget = null;
							if (62605 - 247500 != -184895)
							{
								continue;
							}
							this.jkl6Jw85IJ.mOriginalPosition = this.transform.position;
							if (245633 - 317387 != -71754)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.jkl6Jw85IJ.myAttackTarget;
							if (287807 - 584869 == -297061)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (92224 - 298274 == -206049)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (137284 - 412146 != -274862)
								{
									continue;
								}
								this.jkl6Jw85IJ.isAlert = false;
								if (221128 - 584757 != -363629)
								{
									continue;
								}
								this.RNn6t1ced7 = Time.time;
								if (191640 - 333583 != -141943)
								{
									continue;
								}
								this.jkl6Jw85IJ.myAttackTarget = null;
								if (143390 - 365924 != -222534)
								{
									continue;
								}
							}
							else
							{
								this.jkl6Jw85IJ.vDirection = myAttackTarget.transform.position;
								if (159751 - 42600 != 117151)
								{
									continue;
								}
								this.jkl6Jw85IJ.vDirection.y = this.transform.position.y;
								if (43491 - 145922 != -102431)
								{
									continue;
								}
								this.jkl6Jw85IJ.vMovement = (this.jkl6Jw85IJ.vDirection - this.transform.position).normalized;
								if (38950 - 530377 == -491426)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.jkl6Jw85IJ.vMovement);
								if (141212 - 448630 != -307418)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.Lt76XdbGJq += mTime;
		}
		while (11850 - 264723 == -252872);
	}

	// Token: 0x06001089 RID: 4233 RVA: 0x001A36F4 File Offset: 0x001A18F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (9930 - 217829 != -207898)
		{
		}
		do
		{
			if (Time.time - this.RNn6t1ced7 >= this.Lt76XdbGJq)
			{
				if (69846 - 581275 != -511429)
				{
					continue;
				}
				if (Time.time - this.RNn6t1ced7 < this.Lt76XdbGJq + mTime)
				{
					if (189054 - 177656 == 11399)
					{
						continue;
					}
					if (!this.jkl6Jw85IJ.myAttackTarget)
					{
						if (25284 - 97805 != -72521)
						{
							continue;
						}
						this.RNn6t1ced7 = Time.time - mTime - this.Lt76XdbGJq;
						if (209780 - 143962 != 65819)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.jkl6Jw85IJ.myAttackTarget;
						if (28576 - 412653 != -384077)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (6914 - 19522 != -12608)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (134490 - 160757 == -26266)
						{
							continue;
						}
						int tID = 0;
						if (88038 - 90678 != -2640)
						{
							continue;
						}
						if (characterControl)
						{
							if (138840 - 149906 != -11066)
							{
								continue;
							}
							tID = characterControl.ActorNr;
							if (144304 - 520057 != -375753)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (57410 - 199459 == -142048)
						{
							continue;
						}
						if (num > (float)9)
						{
							if (68231 - 541356 != -473125)
							{
								continue;
							}
							if ((float)this.jkl6Jw85IJ.hp < 0.5f * (float)this.jkl6Jw85IJ.mhp)
							{
								if (283750 - 5991 == 277760)
								{
									continue;
								}
								if (this.jkl6Jw85IJ.isTimeOut("rampage") == (float)0)
								{
									if (123963 - 325109 == -201145)
									{
										continue;
									}
									this.RNn6t1ced7 = Time.time - mTime - this.Lt76XdbGJq;
									if (270530 - 482694 != -212164)
									{
										continue;
									}
									this.Rug66ZfBxo.StartCoroutine_Auto(this.Rug66ZfBxo.RPC_rampage(this.transform.position, vector.normalized, tID));
									if (84344 - 269722 != -185378)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (218103 - 127396 == 90708)
										{
											continue;
										}
										this.Rug66ZfBxo.ActionEvent("RPC_rampage", this.transform.position, vector.normalized, tID);
										if (212092 - 535371 != -323279)
										{
											continue;
										}
									}
									goto IL_BAC;
								}
							}
						}
						if (num > (float)12)
						{
							if (173303 - 461735 == -288431)
							{
								continue;
							}
							if (this.jkl6Jw85IJ.isTimeOut("goasFire") == (float)0)
							{
								if (232951 - 151548 == 81404)
								{
									continue;
								}
								this.RNn6t1ced7 = Time.time - mTime - this.Lt76XdbGJq;
								if (275494 - 235660 != 39834)
								{
									continue;
								}
								this.Rug66ZfBxo.StartCoroutine_Auto(this.Rug66ZfBxo.RPC_gaosFire(this.transform.position, myAttackTarget.collider.bounds.center - this.transform.position, tID));
								if (66299 - 242114 != -175814)
								{
									if (PhotonClient.IsInitialized())
									{
										if (48928 - 327225 == -278296)
										{
											continue;
										}
										this.Rug66ZfBxo.ActionEvent("RPC_gaosFire", this.transform.position, myAttackTarget.collider.bounds.center - this.transform.position, tID);
										if (276337 - 466850 != -190513)
										{
											continue;
										}
									}
									goto IL_BAC;
								}
								continue;
							}
						}
						if (num < (float)6)
						{
							if (284891 - 260756 != 24135)
							{
								continue;
							}
							if (this.jkl6Jw85IJ.isTimeOut("cAttack") == (float)0)
							{
								if (254544 - 564573 == -310028)
								{
									continue;
								}
								this.RNn6t1ced7 = Time.time - mTime - this.Lt76XdbGJq;
								if (3053 - 251340 != -248287)
								{
									continue;
								}
								this.Rug66ZfBxo.StartCoroutine_Auto(this.Rug66ZfBxo.RPC_tailSpin(this.transform.position, vector.normalized, tID));
								if (56359 - 549221 != -492862)
								{
									continue;
								}
								if (PhotonClient.IsInitialized())
								{
									if (24003 - 365583 == -341579)
									{
										continue;
									}
									this.Rug66ZfBxo.ActionEvent("RPC_tailSpin", this.transform.position, vector.normalized, tID);
									if (260378 - 52971 != 207407)
									{
										continue;
									}
								}
								goto IL_BAC;
							}
						}
						if (num < (float)5)
						{
							if (204943 - 576295 == -371351)
							{
								continue;
							}
							if (this.jkl6Jw85IJ.isTimeOut("nAttack") == (float)0)
							{
								if (42827 - 371676 == -328848)
								{
									continue;
								}
								this.RNn6t1ced7 = Time.time - mTime - this.Lt76XdbGJq;
								if (66454 - 157989 != -91534)
								{
									if (UnityEngine.Random.Range(0, 2) == 1)
									{
										if (60388 - 379609 == -319220)
										{
											continue;
										}
										this.Rug66ZfBxo.StartCoroutine_Auto(this.Rug66ZfBxo.RPC_nAttack1(this.transform.position, vector.normalized, tID));
										if (190922 - 490035 != -299113)
										{
											continue;
										}
										if (PhotonClient.IsInitialized())
										{
											if (98294 - 406336 != -308042)
											{
												continue;
											}
											this.Rug66ZfBxo.ActionEvent("RPC_nAttack1", this.transform.position, vector.normalized, tID);
											if (238577 - 369226 != -130649)
											{
												continue;
											}
										}
									}
									else
									{
										this.Rug66ZfBxo.StartCoroutine_Auto(this.Rug66ZfBxo.RPC_nAttack2(this.transform.position, vector.normalized, tID));
										if (264874 - 357410 != -92536)
										{
											continue;
										}
										if (PhotonClient.IsInitialized())
										{
											if (54950 - 585133 == -530182)
											{
												continue;
											}
											this.Rug66ZfBxo.ActionEvent("RPC_nAttack2", this.transform.position, vector.normalized, tID);
											if (48106 - 93380 != -45274)
											{
												continue;
											}
										}
									}
									goto IL_BAC;
								}
								continue;
							}
						}
						this.AI_state = "attack";
						if (82898 - 22241 != 60657)
						{
							continue;
						}
						if (num > (float)3)
						{
							if (226998 - 256845 != -29847)
							{
								continue;
							}
							this.jkl6Jw85IJ.vDirection = myAttackTarget.transform.position;
							if (41158 - 164272 != -123114)
							{
								continue;
							}
							this.jkl6Jw85IJ.vDirection.y = this.transform.position.y;
							if (88006 - 342035 != -254029)
							{
								continue;
							}
							this.jkl6Jw85IJ.vMovement = (this.jkl6Jw85IJ.vDirection - this.transform.position).normalized;
							if (158522 - 14406 == 144117)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.jkl6Jw85IJ.vMovement);
							if (190059 - 20137 != 169922)
							{
								continue;
							}
							this.jkl6Jw85IJ.actionState = "run";
							if (241000 - 52830 == 188171)
							{
								continue;
							}
							this.animation.Play("run");
							if (133532 - 316483 != -182951)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (267964 - 1779 != 266185)
							{
								continue;
							}
							this.jkl6Jw85IJ.moveSpeed = Mathf.Lerp(this.jkl6Jw85IJ.moveSpeed, this.jkl6Jw85IJ.runSpeed, (float)4 * Time.deltaTime);
							if (63108 - 369377 != -306269)
							{
								continue;
							}
						}
						else
						{
							this.jkl6Jw85IJ.vDirection = myAttackTarget.transform.position;
							if (136173 - 343145 != -206972)
							{
								continue;
							}
							this.jkl6Jw85IJ.vDirection.y = this.transform.position.y;
							if (18351 - 540204 != -521853)
							{
								continue;
							}
							this.jkl6Jw85IJ.vMovement = (this.jkl6Jw85IJ.vDirection - this.transform.position).normalized;
							if (282863 - 433357 == -150493)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.jkl6Jw85IJ.vMovement);
							if (111169 - 404896 != -293727)
							{
								continue;
							}
							this.jkl6Jw85IJ.actionState = "standby";
							if (148856 - 478024 == -329167)
							{
								continue;
							}
							this.animation.CrossFade("root", (float)1);
							if (104253 - 52283 == 51971)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (115425 - 336237 == -220811)
							{
								continue;
							}
							this.jkl6Jw85IJ.moveSpeed = Mathf.Lerp(this.jkl6Jw85IJ.moveSpeed, (float)0, (float)4 * Time.deltaTime);
							if (39892 - 429434 != -389542)
							{
								continue;
							}
						}
					}
				}
			}
			IL_BAC:
			this.Lt76XdbGJq += mTime;
		}
		while (172830 - 539109 != -366279);
	}

	// Token: 0x0600108A RID: 4234 RVA: 0x001A42E8 File Offset: 0x001A24E8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_defense()
	{
		if (269775 - 202236 != 67539)
		{
		}
		for (;;)
		{
			if (!this.jkl6Jw85IJ.isSummon)
			{
				if (72593 - 264453 == -191860)
				{
					this.AI_resetTimer();
					if (70421 - 343280 != -272858)
					{
						break;
					}
				}
			}
			else
			{
				if (!(this.jkl6Jw85IJ.mSummoner != null))
				{
					break;
				}
				if (105575 - 507920 != -402344)
				{
					Vector3 vector = this.jkl6Jw85IJ.mSummoner.transform.position - this.transform.position;
					if (31270 - 589924 == -558654)
					{
						if (vector.sqrMagnitude > (float)144)
						{
							if (103530 - 137524 == -33994)
							{
								this.AI_follow(this.jkl6Jw85IJ.mSummoner);
								if (25221 - 322465 != -297243)
								{
									break;
								}
							}
						}
						else
						{
							this.jkl6Jw85IJ.vDirection = Vector3.zero;
							if (30017 - 81428 == -51411)
							{
								this.jkl6Jw85IJ.vMovement = this.transform.forward;
								if (194051 - 191600 != 2452)
								{
									this.jkl6Jw85IJ.actionState = "standby";
									if (42411 - 139937 == -97526)
									{
										this.jkl6Jw85IJ.moveSpeed = Mathf.Lerp(this.jkl6Jw85IJ.moveSpeed, (float)0, (float)4 * Time.deltaTime);
										if (152083 - 83521 == 68562)
										{
											if (this.jkl6Jw85IJ.moveSpeed >= 0.1f * this.jkl6Jw85IJ.runSpeed)
											{
												break;
											}
											if (20300 - 397026 == -376726)
											{
												this.animation.CrossFade("root", 0.2f);
												if (129582 - 546332 == -416750)
												{
													this.animation.wrapMode = WrapMode.Loop;
													if (108074 - 407923 != -299848)
													{
														this.jkl6Jw85IJ.moveSpeed = (float)0;
														if (282697 - 237287 == 45410)
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

	// Token: 0x0600108B RID: 4235 RVA: 0x001A45B8 File Offset: 0x001A27B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_setTimer(float nTime)
	{
		this.AI_state = "none";
		this.RNn6t1ced7 = Time.time - nTime;
	}

	// Token: 0x0600108C RID: 4236 RVA: 0x001A45D4 File Offset: 0x001A27D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (165917 - 580403 != -414486)
		{
		}
		while (Time.time - this.RNn6t1ced7 > this.Lt76XdbGJq)
		{
			if (16148 - 98574 != -82425)
			{
				this.AI_state = "none";
				if (9854 - 135928 == -126074)
				{
					this.RNn6t1ced7 = Time.time;
					if (175993 - 509360 != -333366)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600108D RID: 4237 RVA: 0x001A4688 File Offset: 0x001A2888
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (89675 - 254175 != -164500)
		{
		}
		for (;;)
		{
			IL_5C2:
			if (this.p7W6OX2O9D > Time.time)
			{
				if (19312 - 271638 != -252325)
				{
					break;
				}
			}
			else
			{
				this.p7W6OX2O9D = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (198282 - 260773 == -62491)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (271939 - 517971 != -246031)
					{
						if (10679 - 339399 == -328720)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (203248 - 158066 != 45183)
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
									if (175809 - 431424 != -255615)
									{
										goto IL_5C2;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (63586 - 346866 == -283279)
									{
										goto IL_5C2;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (232524 - 537234 != -304710)
									{
										goto IL_5C2;
									}
									bool flag = true;
									if (244615 - 173837 != 70778)
									{
										goto IL_5C2;
									}
									eRace race = this.jkl6Jw85IJ.Race;
									if (62605 - 30548 == 32058)
									{
										goto IL_5C2;
									}
									if (race == eRace.Tails)
									{
										if (115771 - 126124 == -10352)
										{
											goto IL_5C2;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_77A;
										}
										if (37276 - 98337 == -61060)
										{
											goto IL_5C2;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (265506 - 311740 != -46234)
											{
												goto IL_5C2;
											}
											goto IL_77A;
										}
										goto IL_1A6;
										IL_77A:
										flag = false;
										if (7408 - 227543 == -220134)
										{
											goto IL_5C2;
										}
									}
									else if (race == eRace.Plants)
									{
										if (36832 - 329694 != -292862)
										{
											goto IL_5C2;
										}
										flag = false;
										if (297612 - 345749 == -48136)
										{
											goto IL_5C2;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (4560 - 174275 == -169714)
										{
											goto IL_5C2;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_8C;
										}
										if (299234 - 518539 != -219305)
										{
											goto IL_5C2;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (168360 - 428447 != -260086)
											{
												goto IL_8C;
											}
											goto IL_5C2;
										}
										goto IL_1A6;
										IL_8C:
										flag = false;
										if (235516 - 38112 != 197404)
										{
											goto IL_5C2;
										}
									}
									else if (race == eRace.Robots)
									{
										if (77571 - 153727 != -76156)
										{
											goto IL_5C2;
										}
										flag = true;
										if (268404 - 95294 == 173111)
										{
											goto IL_5C2;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (105029 - 569769 != -464740)
										{
											goto IL_5C2;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_23F;
										}
										if (142237 - 520650 != -378413)
										{
											goto IL_5C2;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_23F;
										}
										if (72748 - 166150 != -93402)
										{
											goto IL_5C2;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (21407 - 332655 != -311248)
											{
												goto IL_5C2;
											}
											goto IL_23F;
										}
										goto IL_1A6;
										IL_23F:
										flag = false;
										if (149741 - 172013 != -22272)
										{
											goto IL_5C2;
										}
									}
									else if (race == eRace.Structure)
									{
										if (203589 - 558324 != -354735)
										{
											goto IL_5C2;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (281583 - 327248 != -45665)
											{
												goto IL_5C2;
											}
											flag = false;
											if (287679 - 156268 != 131411)
											{
												goto IL_5C2;
											}
										}
									}
									IL_1A6:
									if (flag)
									{
										if (283114 - 527269 != -244155)
										{
											goto IL_5C2;
										}
										if (characterControl.hp > 0)
										{
											if (35479 - 198442 != -162963)
											{
												goto IL_5C2;
											}
											if (characterControl.recieveTarget)
											{
												if (997 - 101090 == -100092)
												{
													goto IL_5C2;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (41006 - 556089 == -515082)
													{
														goto IL_5C2;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (162505 - 210200 != -47695)
														{
															goto IL_5C2;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (109326 - 319873 != -210547)
														{
															goto IL_5C2;
														}
														if (vector.sqrMagnitude < (float)144)
														{
															if (22263 - 60546 != -38283)
															{
																goto IL_5C2;
															}
															this.jkl6Jw85IJ.myAttackTarget = gameObject;
															if (193197 - 175414 == 17784)
															{
																goto IL_5C2;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (225429 - 300481 != -75052)
															{
																goto IL_5C2;
															}
															this.jkl6Jw85IJ.addHate(characterControl.ActorNr, 5);
															if (112752 - 186141 == -73388)
															{
																goto IL_5C2;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (254978 - 2762 == 252217)
															{
																goto IL_5C2;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (48561 - 203586 == -155024)
															{
																goto IL_5C2;
															}
															if (num < (float)60)
															{
																if (222243 - 53213 == 169031)
																{
																	goto IL_5C2;
																}
																if (characterControl.hp > 0)
																{
																	if (72900 - 404624 != -331724)
																	{
																		goto IL_5C2;
																	}
																	this.jkl6Jw85IJ.myAttackTarget = gameObject;
																	if (229832 - 191922 == 37911)
																	{
																		goto IL_5C2;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (246494 - 551963 != -305469)
																	{
																		goto IL_5C2;
																	}
																	this.jkl6Jw85IJ.addHate(characterControl.ActorNr, 5);
																	if (193326 - 478888 != -285562)
																	{
																		goto IL_5C2;
																	}
																}
															}
														}
														if (this.jkl6Jw85IJ.myAttackTarget)
														{
															if (267267 - 316323 == -49055)
															{
																goto IL_5C2;
															}
															this.jkl6Jw85IJ.isAlert = true;
															if (41221 - 182398 != -141177)
															{
																goto IL_5C2;
															}
															this.RNn6t1ced7 = Time.time;
															if (240521 - 321360 == -80838)
															{
																goto IL_5C2;
															}
														}
													}
												}
											}
										}
									}
								}
								if (203 - 133969 != -133765)
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

	// Token: 0x0600108E RID: 4238 RVA: 0x001A4EA0 File Offset: 0x001A30A0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600108F RID: 4239 RVA: 0x001A4EA4 File Offset: 0x001A30A4
	internal static bool YnkyRZ2mvxB6VAElqs8()
	{
		return true;
	}

	// Token: 0x06001090 RID: 4240 RVA: 0x001A4EA8 File Offset: 0x001A30A8
	internal static bool hMMlcQ2F4ByghR7vWq1()
	{
		return false;
	}

	// Token: 0x04000E75 RID: 3701
	private CharacterControl jkl6Jw85IJ;

	// Token: 0x04000E76 RID: 3702
	private Gaos Rug66ZfBxo;

	// Token: 0x04000E77 RID: 3703
	public string AI_state;

	// Token: 0x04000E78 RID: 3704
	private float RNn6t1ced7;

	// Token: 0x04000E79 RID: 3705
	private float Lt76XdbGJq;

	// Token: 0x04000E7A RID: 3706
	private float p7W6OX2O9D;
}
