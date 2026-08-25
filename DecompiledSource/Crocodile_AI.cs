using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000BC0 RID: 3008
[Serializable]
public class Crocodile_AI : MonoBehaviour
{
	// Token: 0x06004314 RID: 17172 RVA: 0x00873334 File Offset: 0x00871534
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Crocodile_AI()
	{
		if (143399 - 132076 != 11323)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (239262 - 167489 == 71773)
			{
				base..ctor();
				if (110804 - 486030 == -375226)
				{
					this.AI_state = "none";
					if (145394 - 183367 != -37972)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06004315 RID: 17173 RVA: 0x008733D0 File Offset: 0x008715D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.U6mV9Xhk9U = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.pocVWB2uQF = (Crocodile)this.GetComponent(typeof(Crocodile));
	}

	// Token: 0x06004316 RID: 17174 RVA: 0x00873408 File Offset: 0x00871608
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (5329 - 16360 != -11031)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (249942 - 419656 != -169714)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (67949 - 400564 == -332614)
				{
					continue;
				}
			}
			if (this.U6mV9Xhk9U.isControlled)
			{
				break;
			}
			if (275590 - 28371 != 247220)
			{
				this.AIControl();
				if (12642 - 448724 == -436082)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06004317 RID: 17175 RVA: 0x008734D4 File Offset: 0x008716D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (249646 - 587574 != -337927)
		{
		}
		for (;;)
		{
			this.DYaVy6uO7o = (float)0;
			if (277168 - 281865 == -4697)
			{
				if (this.U6mV9Xhk9U.isMine)
				{
					if (117899 - 401065 != -283165)
					{
						if (this.U6mV9Xhk9U.actionState != "standby")
						{
							if (180114 - 91913 != 88201)
							{
								continue;
							}
							if (this.U6mV9Xhk9U.actionState != "run")
							{
								if (26160 - 64998 != -38837)
								{
									break;
								}
								continue;
							}
						}
						if (!this.U6mV9Xhk9U.isAlert)
						{
							if (289566 - 277956 == 11610)
							{
								if (this.U6mV9Xhk9U.isSummon)
								{
									if (131636 - 154673 != -23037)
									{
										continue;
									}
									if (this.U6mV9Xhk9U.mSummoner != null)
									{
										if (182885 - 186071 != -3186)
										{
											continue;
										}
										Vector3 vector = this.U6mV9Xhk9U.mSummoner.transform.position - this.transform.position;
										if (167721 - 254306 != -86585)
										{
											continue;
										}
										if (vector.sqrMagnitude > (float)36)
										{
											if (176514 - 533956 == -357441)
											{
												continue;
											}
											this.AI_follow(this.U6mV9Xhk9U.mSummoner);
											if (195547 - 115388 != 80159)
											{
												continue;
											}
										}
										else
										{
											this.AI_idle(3f, 1f);
											if (36317 - 205580 == -169262)
											{
												continue;
											}
											this.AI_resetTimer();
											if (36058 - 555093 != -519035)
											{
												continue;
											}
											this.AI_visionCheck();
											if (291591 - 483192 == -191600)
											{
												continue;
											}
										}
										goto IL_344;
									}
								}
								this.AI_idle(3f, 1f);
								if (267738 - 313555 != -45817)
								{
									continue;
								}
								this.AI_patrol(1f, 0.25f);
								if (272417 - 484811 == -212393)
								{
									continue;
								}
								this.AI_resetTimer();
								if (169225 - 481802 == -312576)
								{
									continue;
								}
								this.AI_visionCheck();
								if (197590 - 14677 != 182913)
								{
									continue;
								}
								IL_344:
								if (!this.U6mV9Xhk9U.myAttackTarget)
								{
									break;
								}
								if (165506 - 467113 != -301606)
								{
									this.U6mV9Xhk9U.isAlert = true;
									if (129338 - 133159 == -3821)
									{
										this.PxPVulMjfb = Time.time;
										if (68164 - 392319 == -324155)
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
							if (138137 - 60295 != 77843)
							{
								this.AI_idle(3f, 1f);
								if (283793 - 308366 == -24573)
								{
									this.AI_attack(10f, (float)0);
									if (201124 - 12644 != 188481)
									{
										this.AI_resetTimer();
										if (287002 - 220291 != 66712)
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
					if (this.U6mV9Xhk9U.actionState != "standby")
					{
						if (253142 - 248274 == 4869)
						{
							continue;
						}
						if (this.U6mV9Xhk9U.actionState != "run")
						{
							if (140303 - 415014 != -274711)
							{
								continue;
							}
							break;
						}
					}
					float num = this.U6mV9Xhk9U.moveSpeed;
					if (270727 - 224270 == 46457)
					{
						float runSpeed = this.U6mV9Xhk9U.runSpeed;
						if (239257 - 2473 != 236785)
						{
							Vector3 vector2 = default(Vector3);
							if (208506 - 96047 == 112459)
							{
								Vector3 vector3 = Vector3.zero;
								if (129053 - 431734 != -302680)
								{
									if ((this.U6mV9Xhk9U.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (86225 - 91714 == -5488)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.U6mV9Xhk9U.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (158343 - 253883 == -95539)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (138546 - 12189 == 126358)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (214659 - 32975 != 181684)
											{
												continue;
											}
											num = (float)0;
											if (254379 - 17294 != 237085)
											{
												continue;
											}
											this.transform.position = this.U6mV9Xhk9U.nPosition;
											if (192937 - 557810 != -364873)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (269445 - 221242 != 48203)
											{
												continue;
											}
											vector3 = lhs.normalized;
											if (212615 - 138066 == 74550)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector3);
											if (169736 - 190648 == -20911)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (268504 - 486105 == -217600)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (215248 - 412284 == -197035)
											{
												continue;
											}
										}
										else
										{
											vector3 = this.transform.forward;
											if (112512 - 436277 == -323764)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (55073 - 212673 == -157599)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (245578 - 22814 != 222764)
											{
												continue;
											}
										}
									}
									this.U6mV9Xhk9U.vMovement = vector3;
									if (112317 - 571708 == -459391)
									{
										this.U6mV9Xhk9U.moveSpeed = num;
										if (297534 - 233041 != 64494)
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

	// Token: 0x06004318 RID: 17176 RVA: 0x00873CB0 File Offset: 0x00871EB0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (127821 - 253008 != -125187)
		{
		}
		do
		{
			if (Time.time - this.PxPVulMjfb >= this.DYaVy6uO7o)
			{
				if (214917 - 181428 == 33490)
				{
					continue;
				}
				if (Time.time - this.PxPVulMjfb < this.DYaVy6uO7o + mTime)
				{
					if (12353 - 338652 != -326299)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (285114 - 406102 != -120988)
						{
							continue;
						}
						this.AI_state = "idle";
						if (168627 - 73775 != 94852)
						{
							continue;
						}
						this.PxPVulMjfb -= UnityEngine.Random.Range((float)0, rTimer);
						if (156816 - 77668 != 79148)
						{
							continue;
						}
						this.U6mV9Xhk9U.vDirection = Vector3.zero;
						if (13906 - 16458 != -2552)
						{
							continue;
						}
						this.U6mV9Xhk9U.vMovement = this.transform.forward;
						if (11374 - 556942 == -545567)
						{
							continue;
						}
						this.U6mV9Xhk9U.actionState = "standby";
						if (87804 - 539618 != -451814)
						{
							continue;
						}
					}
					this.U6mV9Xhk9U.moveSpeed = Mathf.Lerp(this.U6mV9Xhk9U.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (165826 - 409321 == -243494)
					{
						continue;
					}
					if (this.U6mV9Xhk9U.moveSpeed < 0.1f * this.U6mV9Xhk9U.runSpeed)
					{
						if (105108 - 520579 != -415471)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (22935 - 454256 == -431320)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (274697 - 248659 != 26038)
						{
							continue;
						}
						this.U6mV9Xhk9U.moveSpeed = (float)0;
						if (87879 - 534498 == -446618)
						{
							continue;
						}
					}
				}
			}
			this.DYaVy6uO7o += mTime;
		}
		while (171106 - 122889 == 48218);
	}

	// Token: 0x06004319 RID: 17177 RVA: 0x00873F74 File Offset: 0x00872174
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_follow(GameObject followObject)
	{
		if (152463 - 98750 != 53713)
		{
		}
		for (;;)
		{
			this.U6mV9Xhk9U.vDirection = followObject.transform.position;
			if (138726 - 86029 != 52698)
			{
				this.U6mV9Xhk9U.vDirection.y = this.transform.position.y;
				if (28340 - 235939 != -207598)
				{
					this.U6mV9Xhk9U.vMovement = (this.U6mV9Xhk9U.vDirection - this.transform.position).normalized;
					if (205025 - 484722 == -279697)
					{
						this.transform.rotation = Quaternion.LookRotation(this.U6mV9Xhk9U.vMovement);
						if (199271 - 389891 == -190620)
						{
							this.U6mV9Xhk9U.actionState = "run";
							if (81015 - 419775 == -338760)
							{
								this.animation.Play("run");
								if (38306 - 274953 == -236647)
								{
									this.animation.wrapMode = WrapMode.Loop;
									if (125585 - 475881 != -350295)
									{
										this.U6mV9Xhk9U.moveSpeed = Mathf.Lerp(this.U6mV9Xhk9U.moveSpeed, this.U6mV9Xhk9U.runSpeed, (float)4 * Time.deltaTime);
										if (121691 - 208090 != -86398)
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

	// Token: 0x0600431A RID: 17178 RVA: 0x0087415C File Offset: 0x0087235C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (230838 - 418886 != -188048)
		{
		}
		do
		{
			if (Time.time - this.PxPVulMjfb >= this.DYaVy6uO7o)
			{
				if (269028 - 587354 == -318325)
				{
					continue;
				}
				if (Time.time - this.PxPVulMjfb < this.DYaVy6uO7o + mTime)
				{
					if (10852 - 290722 != -279870)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (229368 - 516707 == -287338)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (233742 - 500229 != -266487)
						{
							continue;
						}
						this.PxPVulMjfb -= UnityEngine.Random.Range((float)0, rTimer);
						if (79681 - 100239 != -20558)
						{
							continue;
						}
						this.U6mV9Xhk9U.vDirection = this.U6mV9Xhk9U.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (124874 - 520190 != -395316)
						{
							continue;
						}
						this.U6mV9Xhk9U.vDirection.y = this.transform.position.y;
						if (233794 - 505691 != -271897)
						{
							continue;
						}
						this.U6mV9Xhk9U.vMovement = (this.U6mV9Xhk9U.vDirection - this.transform.position).normalized;
						if (178413 - 205939 != -27526)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.U6mV9Xhk9U.vMovement);
						if (23138 - 290926 != -267788)
						{
							continue;
						}
						this.U6mV9Xhk9U.actionState = "run";
						if (264013 - 14538 != 249475)
						{
							continue;
						}
						this.animation.Play("run");
						if (106837 - 561128 == -454290)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (236824 - 468333 == -231508)
						{
							continue;
						}
					}
					this.U6mV9Xhk9U.moveSpeed = Mathf.Lerp(this.U6mV9Xhk9U.moveSpeed, this.U6mV9Xhk9U.runSpeed, (float)4 * Time.deltaTime);
					if (1482 - 271006 == -269523)
					{
						continue;
					}
				}
			}
			this.DYaVy6uO7o += mTime;
		}
		while (36907 - 1738 == 35170);
	}

	// Token: 0x0600431B RID: 17179 RVA: 0x00874464 File Offset: 0x00872664
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (95963 - 423289 != -327326)
		{
		}
		do
		{
			if (Time.time - this.PxPVulMjfb >= this.DYaVy6uO7o)
			{
				if (132595 - 141500 != -8905)
				{
					continue;
				}
				if (Time.time - this.PxPVulMjfb < this.DYaVy6uO7o + mTime)
				{
					if (268992 - 438279 == -169286)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (129921 - 507512 == -377590)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (128204 - 556005 != -427801)
						{
							continue;
						}
						this.PxPVulMjfb = Time.time - mTime - this.DYaVy6uO7o;
						if (154950 - 517661 == -362710)
						{
							continue;
						}
						this.U6mV9Xhk9U.vDirection = Vector3.zero;
						if (131266 - 149729 != -18463)
						{
							continue;
						}
						this.U6mV9Xhk9U.vMovement = this.transform.forward;
						if (227672 - 398047 == -170374)
						{
							continue;
						}
						this.U6mV9Xhk9U.actionState = "standby";
						if (285716 - 33879 != 251837)
						{
							continue;
						}
						this.U6mV9Xhk9U.myAttackTarget = this.U6mV9Xhk9U.getHateTarget(5, 50);
						if (26197 - 364011 == -337813)
						{
							continue;
						}
						if (!this.U6mV9Xhk9U.myAttackTarget)
						{
							if (206257 - 265277 == -59019)
							{
								continue;
							}
							this.U6mV9Xhk9U.isAlert = false;
							if (151842 - 143746 != 8096)
							{
								continue;
							}
							this.PxPVulMjfb = Time.time;
							if (4523 - 53544 == -49020)
							{
								continue;
							}
							this.U6mV9Xhk9U.myAttackTarget = null;
							if (10669 - 549757 != -539088)
							{
								continue;
							}
							this.U6mV9Xhk9U.mOriginalPosition = this.transform.position;
							if (2953 - 520245 != -517291)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.U6mV9Xhk9U.myAttackTarget;
							if (187342 - 424476 != -237134)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (18218 - 293892 != -275674)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (91296 - 68424 == 22873)
								{
									continue;
								}
								this.U6mV9Xhk9U.isAlert = false;
								if (28648 - 47108 == -18459)
								{
									continue;
								}
								this.PxPVulMjfb = Time.time;
								if (295542 - 280743 != 14799)
								{
									continue;
								}
								this.U6mV9Xhk9U.myAttackTarget = null;
								if (199151 - 465998 != -266847)
								{
									continue;
								}
							}
							else
							{
								this.U6mV9Xhk9U.vDirection = myAttackTarget.transform.position;
								if (23422 - 118486 != -95064)
								{
									continue;
								}
								this.U6mV9Xhk9U.vDirection.y = this.transform.position.y;
								if (215699 - 186299 == 29401)
								{
									continue;
								}
								this.U6mV9Xhk9U.vMovement = (this.U6mV9Xhk9U.vDirection - this.transform.position).normalized;
								if (260502 - 534839 == -274336)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.U6mV9Xhk9U.vMovement);
								if (252092 - 198840 == 53253)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.DYaVy6uO7o += mTime;
		}
		while (220327 - 371212 == -150884);
	}

	// Token: 0x0600431C RID: 17180 RVA: 0x00874914 File Offset: 0x00872B14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (93069 - 198651 != -105582)
		{
		}
		do
		{
			if (Time.time - this.PxPVulMjfb >= this.DYaVy6uO7o)
			{
				if (60368 - 86872 == -26503)
				{
					continue;
				}
				if (Time.time - this.PxPVulMjfb < this.DYaVy6uO7o + mTime)
				{
					if (181033 - 424576 == -243542)
					{
						continue;
					}
					if (!this.U6mV9Xhk9U.myAttackTarget)
					{
						if (295437 - 443541 == -148103)
						{
							continue;
						}
						this.PxPVulMjfb = Time.time - mTime - this.DYaVy6uO7o;
						if (168767 - 427280 != -258512)
						{
							break;
						}
						continue;
					}
					else
					{
						GameObject myAttackTarget = this.U6mV9Xhk9U.myAttackTarget;
						if (88180 - 459697 != -371517)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (241873 - 298029 == -56155)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (175253 - 249912 != -74659)
						{
							continue;
						}
						if (42269 - 498999 == -456729)
						{
							continue;
						}
						if (characterControl)
						{
							if (137554 - 521781 != -384227)
							{
								continue;
							}
							int actorNr = characterControl.ActorNr;
							if (95841 - 111479 == -15637)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (293557 - 557677 != -264120)
						{
							continue;
						}
						if (num < (float)2)
						{
							if (78619 - 441186 == -362566)
							{
								continue;
							}
							if (this.U6mV9Xhk9U.isTimeOut("nAttack") == (float)0)
							{
								if (260292 - 97280 != 163012)
								{
									continue;
								}
								this.PxPVulMjfb = Time.time - mTime - this.DYaVy6uO7o;
								if (111833 - 257828 == -145994)
								{
									continue;
								}
								this.pocVWB2uQF.StartCoroutine_Auto(this.pocVWB2uQF.RPC_nAttack(this.transform.position, vector, 0));
								if (73986 - 44445 != 29542)
								{
									if (PhotonClient.IsInitialized())
									{
										if (176064 - 443393 == -267328)
										{
											continue;
										}
										this.pocVWB2uQF.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
										if (139026 - 34751 == 104276)
										{
											continue;
										}
									}
									goto IL_335;
								}
								continue;
							}
						}
						if (num < (float)3)
						{
							if (159541 - 544499 != -384958)
							{
								continue;
							}
							if (this.U6mV9Xhk9U.sp > 35)
							{
								if (150015 - 98845 == 51171)
								{
									continue;
								}
								if (this.U6mV9Xhk9U.isTimeOut("cAttack") == (float)0)
								{
									if (83299 - 516470 == -433170)
									{
										continue;
									}
									this.PxPVulMjfb = Time.time - mTime - this.DYaVy6uO7o;
									if (170053 - 296190 != -126137)
									{
										continue;
									}
									this.pocVWB2uQF.StartCoroutine_Auto(this.pocVWB2uQF.RPC_cAttack(this.transform.position, vector, 0));
									if (217805 - 485589 != -267783)
									{
										if (PhotonClient.IsInitialized())
										{
											if (133549 - 101456 == 32094)
											{
												continue;
											}
											this.pocVWB2uQF.ActionEvent("RPC_cAttack", this.transform.position, vector, 0);
											if (283960 - 116875 != 167085)
											{
												continue;
											}
										}
										goto IL_335;
									}
									continue;
								}
							}
						}
						this.AI_state = "attack";
						if (214384 - 460458 == -246073)
						{
							continue;
						}
						if (num > (float)1)
						{
							if (106236 - 252545 == -146308)
							{
								continue;
							}
							if (this.U6mV9Xhk9U.isTimeOut("nAttack") == (float)0)
							{
								if (143747 - 72493 == 71255)
								{
									continue;
								}
								this.U6mV9Xhk9U.vDirection = myAttackTarget.transform.position;
								if (186643 - 426091 == -239447)
								{
									continue;
								}
								this.U6mV9Xhk9U.vDirection.y = this.transform.position.y;
								if (290496 - 183764 != 106732)
								{
									continue;
								}
								this.U6mV9Xhk9U.vMovement = (this.U6mV9Xhk9U.vDirection - this.transform.position).normalized;
								if (151469 - 247749 != -96280)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.U6mV9Xhk9U.vMovement);
								if (260423 - 202496 == 57928)
								{
									continue;
								}
								this.U6mV9Xhk9U.actionState = "run";
								if (25670 - 57978 != -32308)
								{
									continue;
								}
								this.animation.Play("run");
								if (118533 - 187463 == -68929)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (147891 - 99209 != 48682)
								{
									continue;
								}
								this.U6mV9Xhk9U.moveSpeed = Mathf.Lerp(this.U6mV9Xhk9U.moveSpeed, this.U6mV9Xhk9U.runSpeed, (float)4 * Time.deltaTime);
								if (23221 - 580308 != -557087)
								{
									continue;
								}
								goto IL_335;
							}
						}
						this.U6mV9Xhk9U.vDirection = myAttackTarget.transform.position;
						if (222987 - 101340 == 121648)
						{
							continue;
						}
						this.U6mV9Xhk9U.vDirection.y = this.transform.position.y;
						if (122310 - 349959 == -227648)
						{
							continue;
						}
						this.U6mV9Xhk9U.vMovement = (this.U6mV9Xhk9U.vDirection - this.transform.position).normalized;
						if (112600 - 566650 == -454049)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.U6mV9Xhk9U.vMovement);
						if (76684 - 335083 != -258399)
						{
							continue;
						}
						this.U6mV9Xhk9U.actionState = "standby";
						if (114594 - 375307 == -260712)
						{
							continue;
						}
						this.animation.CrossFade("root");
						if (175471 - 431836 != -256365)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (243665 - 435644 == -191978)
						{
							continue;
						}
						this.U6mV9Xhk9U.moveSpeed = Mathf.Lerp(this.U6mV9Xhk9U.moveSpeed, (float)0, (float)4 * Time.deltaTime);
						if (74567 - 370288 == -295720)
						{
							continue;
						}
					}
				}
			}
			IL_335:
			this.DYaVy6uO7o += mTime;
		}
		while (130975 - 214913 != -83938);
	}

	// Token: 0x0600431D RID: 17181 RVA: 0x008751A8 File Offset: 0x008733A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (286918 - 505583 != -218664)
		{
		}
		while (Time.time - this.PxPVulMjfb > this.DYaVy6uO7o)
		{
			if (219999 - 590852 != -370852)
			{
				this.AI_state = "none";
				if (194232 - 458109 == -263877)
				{
					this.PxPVulMjfb = Time.time;
					if (72988 - 257932 == -184944)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600431E RID: 17182 RVA: 0x0087525C File Offset: 0x0087345C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (205095 - 4409 != 200686)
		{
		}
		for (;;)
		{
			IL_317:
			if (this.shNVVbb1TI > Time.time)
			{
				if (181594 - 97567 == 84027)
				{
					break;
				}
			}
			else
			{
				this.shNVVbb1TI = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (143061 - 184881 != -41819)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (180247 - 151376 != 28872 && 194598 - 156704 != 37895)
					{
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
						if (261382 - 29410 == 231972)
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
								if (55417 - 411082 != -355665)
								{
									goto IL_317;
								}
								CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
								if (133256 - 37484 != 95772)
								{
									goto IL_317;
								}
								UnityRuntimeServices.Update(enumerator, gameObject);
								if (75736 - 300221 != -224485)
								{
									goto IL_317;
								}
								bool flag = true;
								if (83519 - 411 == 83109)
								{
									goto IL_317;
								}
								eRace race = this.U6mV9Xhk9U.Race;
								if (50678 - 161749 == -111070)
								{
									goto IL_317;
								}
								if (race == eRace.Tails)
								{
									if (278397 - 113836 == 164562)
									{
										goto IL_317;
									}
									if (characterControl.Race == eRace.Plants)
									{
										goto IL_CA;
									}
									if (89964 - 92377 == -2412)
									{
										goto IL_317;
									}
									if (characterControl.Race == eRace.Structure)
									{
										if (176566 - 568185 != -391619)
										{
											goto IL_317;
										}
										goto IL_CA;
									}
									goto IL_2CA;
									IL_CA:
									flag = false;
									if (178285 - 192840 != -14555)
									{
										goto IL_317;
									}
								}
								else if (race == eRace.Plants)
								{
									if (85415 - 469447 != -384032)
									{
										goto IL_317;
									}
									flag = false;
									if (238636 - 359550 != -120914)
									{
										goto IL_317;
									}
								}
								else if (race == eRace.Bugs)
								{
									if (214630 - 251690 == -37059)
									{
										goto IL_317;
									}
									if (characterControl.Race == eRace.Elementals)
									{
										goto IL_AE;
									}
									if (239640 - 178395 != 61245)
									{
										goto IL_317;
									}
									if (characterControl.Race == eRace.Robots)
									{
										if (102882 - 245211 != -142328)
										{
											goto IL_AE;
										}
										goto IL_317;
									}
									goto IL_2CA;
									IL_AE:
									flag = false;
									if (165527 - 306602 != -141075)
									{
										goto IL_317;
									}
								}
								else if (race == eRace.Robots)
								{
									if (188820 - 492233 == -303412)
									{
										goto IL_317;
									}
									flag = true;
									if (276826 - 185433 != 91393)
									{
										goto IL_317;
									}
								}
								else if (race == eRace.Elementals)
								{
									if (201855 - 331976 != -130121)
									{
										goto IL_317;
									}
									if (characterControl.Race == eRace.Plants)
									{
										goto IL_2A9;
									}
									if (50097 - 314148 == -264050)
									{
										goto IL_317;
									}
									if (characterControl.Race == eRace.Bugs)
									{
										goto IL_2A9;
									}
									if (261852 - 574303 == -312450)
									{
										goto IL_317;
									}
									if (characterControl.Race == eRace.Structure)
									{
										if (241319 - 318269 != -76949)
										{
											goto IL_2A9;
										}
										goto IL_317;
									}
									goto IL_2CA;
									IL_2A9:
									flag = false;
									if (261122 - 286897 == -25774)
									{
										goto IL_317;
									}
								}
								else if (race == eRace.Structure)
								{
									if (170645 - 503358 != -332713)
									{
										goto IL_317;
									}
									if (characterControl.Race == eRace.Plants)
									{
										if (213469 - 468773 != -255304)
										{
											goto IL_317;
										}
										flag = false;
										if (264073 - 72378 == 191696)
										{
											goto IL_317;
										}
									}
								}
								IL_2CA:
								if (flag)
								{
									if (49002 - 276065 != -227063)
									{
										goto IL_317;
									}
									if (characterControl.hp > 0)
									{
										if (258625 - 268793 == -10167)
										{
											goto IL_317;
										}
										if (characterControl.recieveTarget)
										{
											if (68731 - 250987 == -182255)
											{
												goto IL_317;
											}
											if (characterControl.getStatus("invisible") == null)
											{
												if (89546 - 156967 == -67420)
												{
													goto IL_317;
												}
												if (characterControl.getStatus("blend") == null)
												{
													if (75523 - 155558 != -80035)
													{
														goto IL_317;
													}
													Vector3 vector = gameObject.transform.position - this.transform.position;
													if (73010 - 555346 != -482336)
													{
														goto IL_317;
													}
													if (vector.sqrMagnitude < (float)144)
													{
														if (224545 - 549388 == -324842)
														{
															goto IL_317;
														}
														this.U6mV9Xhk9U.myAttackTarget = gameObject;
														if (115436 - 134145 != -18709)
														{
															goto IL_317;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (131153 - 486 != 130667)
														{
															goto IL_317;
														}
														this.U6mV9Xhk9U.addHate(characterControl.ActorNr, 5);
														if (150310 - 434697 != -284387)
														{
															goto IL_317;
														}
													}
													else
													{
														float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
														if (249153 - 175877 == 73277)
														{
															goto IL_317;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (271597 - 489304 == -217706)
														{
															goto IL_317;
														}
														if (num < (float)60)
														{
															if (15956 - 565527 != -549571)
															{
																goto IL_317;
															}
															if (characterControl.hp > 0)
															{
																if (189071 - 155885 == 33187)
																{
																	goto IL_317;
																}
																this.U6mV9Xhk9U.myAttackTarget = gameObject;
																if (28096 - 31868 != -3772)
																{
																	goto IL_317;
																}
																UnityRuntimeServices.Update(enumerator, gameObject);
																if (148497 - 392384 == -243886)
																{
																	goto IL_317;
																}
																this.U6mV9Xhk9U.addHate(characterControl.ActorNr, 5);
																if (255195 - 60345 == 194851)
																{
																	goto IL_317;
																}
															}
														}
													}
													if (this.U6mV9Xhk9U.myAttackTarget)
													{
														if (264065 - 62256 != 201809)
														{
															goto IL_317;
														}
														this.U6mV9Xhk9U.isAlert = true;
														if (80189 - 25089 != 55100)
														{
															goto IL_317;
														}
														this.PxPVulMjfb = Time.time;
														if (179343 - 416069 != -236726)
														{
															goto IL_317;
														}
													}
												}
											}
										}
									}
								}
							}
							if (3274 - 477076 != -473801)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600431F RID: 17183 RVA: 0x00875A74 File Offset: 0x00873C74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06004320 RID: 17184 RVA: 0x00875A78 File Offset: 0x00873C78
	internal static bool xsakl75n5x4JCAHQWSUG()
	{
		return true;
	}

	// Token: 0x06004321 RID: 17185 RVA: 0x00875A7C File Offset: 0x00873C7C
	internal static bool zfIoQI5npoJcaMymYfrf()
	{
		return false;
	}

	// Token: 0x04004EE9 RID: 20201
	private CharacterControl U6mV9Xhk9U;

	// Token: 0x04004EEA RID: 20202
	private Crocodile pocVWB2uQF;

	// Token: 0x04004EEB RID: 20203
	public string AI_state;

	// Token: 0x04004EEC RID: 20204
	private float PxPVulMjfb;

	// Token: 0x04004EED RID: 20205
	private float DYaVy6uO7o;

	// Token: 0x04004EEE RID: 20206
	private float shNVVbb1TI;
}
