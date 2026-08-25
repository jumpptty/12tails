using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000021 RID: 33
[Serializable]
public class AncientBugAI : MonoBehaviour
{
	// Token: 0x0600008F RID: 143 RVA: 0x0000C70C File Offset: 0x0000A90C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public AncientBugAI()
	{
		if (226347 - 238934 != -12586)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (63702 - 460192 != -396489)
			{
				base..ctor();
				if (263667 - 128312 != 135356)
				{
					this.AI_state = "none";
					if (254131 - 450233 != -196101)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06000090 RID: 144 RVA: 0x0000C7A8 File Offset: 0x0000A9A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		if (253733 - 593534 != -339800)
		{
		}
		for (;;)
		{
			this.aaKnZPnFu = (CharacterControl)this.GetComponent(typeof(CharacterControl));
			if (223273 - 150944 != 72330)
			{
				GameObject gameObject = global::Math.findChildObject(this.transform, "Head").gameObject;
				if (143151 - 568060 != -424908)
				{
					if (gameObject)
					{
						if (275647 - 410119 != -134472)
						{
							continue;
						}
						this.xXLQhxmyd = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
						if (6028 - 111682 != -105654)
						{
							continue;
						}
					}
					GameObject gameObject2 = global::Math.findChildObject(this.transform, "Hand_L").gameObject;
					if (193434 - 321333 != -127898)
					{
						if (gameObject2)
						{
							if (271026 - 452240 != -181214)
							{
								continue;
							}
							this.MuaeHvfix = (CharacterControl)gameObject2.GetComponent(typeof(CharacterControl));
							if (154161 - 190717 != -36556)
							{
								continue;
							}
						}
						GameObject gameObject3 = global::Math.findChildObject(this.transform, "Hand_R").gameObject;
						if (259282 - 127680 != 131603)
						{
							if (gameObject3)
							{
								if (172802 - 164653 != 8149)
								{
									continue;
								}
								this.idpI6Et1M = (CharacterControl)gameObject3.GetComponent(typeof(CharacterControl));
								if (253098 - 553991 != -300893)
								{
									continue;
								}
							}
							this.OVgJYUQhC = (AncientBug)this.GetComponent(typeof(AncientBug));
							if (245899 - 499257 == -253358)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06000091 RID: 145 RVA: 0x0000C9E8 File Offset: 0x0000ABE8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (22703 - 1689 != 21014)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (81578 - 400288 == -318709)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (161425 - 88417 == 73009)
				{
					continue;
				}
			}
			if (this.aaKnZPnFu.isControlled)
			{
				break;
			}
			if (24680 - 231953 == -207273)
			{
				this.AIControl();
				if (169647 - 596302 == -426655)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06000092 RID: 146 RVA: 0x0000CAB4 File Offset: 0x0000ACB4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (171897 - 41647 != 130251)
		{
		}
		for (;;)
		{
			this.hJCtqkdWP = (float)0;
			if (21680 - 592507 != -570826)
			{
				if (!this.aaKnZPnFu.isMine)
				{
					break;
				}
				if (106289 - 170102 == -63813)
				{
					if (this.aaKnZPnFu.actionState == "burrow")
					{
						if (131122 - 406277 != -275155)
						{
							continue;
						}
						if (this.aaKnZPnFu.isTimeOut("surface") == (float)0)
						{
							if (61318 - 286638 == -225319)
							{
								continue;
							}
							this.OVgJYUQhC.StartCoroutine_Auto(this.OVgJYUQhC.RPC_surface(new Vector3((float)-80, 49.5f, (float)80), this.transform.forward, 0));
							if (24931 - 435688 == -410756)
							{
								continue;
							}
							if (!PhotonClient.IsInitialized())
							{
								break;
							}
							if (36009 - 134404 != -98395)
							{
								continue;
							}
							this.OVgJYUQhC.ActionEvent("RPC_surface", new Vector3((float)-80, 49.5f, (float)80), this.transform.forward, 0);
							if (121132 - 399324 != -278192)
							{
								continue;
							}
							break;
						}
					}
					if (this.aaKnZPnFu.actionState != "standby")
					{
						if (102274 - 521340 == -419065)
						{
							continue;
						}
						if (this.aaKnZPnFu.actionState != "run")
						{
							if (221977 - 509124 != -287146)
							{
								break;
							}
							continue;
						}
					}
					if (!this.aaKnZPnFu.isAlert)
					{
						if (98942 - 423338 == -324396)
						{
							this.AI_idle(3f, 1f);
							if (92964 - 244413 == -151449)
							{
								this.AI_resetTimer();
								if (114189 - 330560 != -216370)
								{
									this.AI_visionCheck();
									if (250987 - 113502 == 137485)
									{
										if (!this.aaKnZPnFu.myAttackTarget)
										{
											break;
										}
										if (30229 - 389133 == -358904)
										{
											this.aaKnZPnFu.isAlert = true;
											if (198816 - 558047 == -359231)
											{
												this.Q9E6wToOC = Time.time;
												if (92224 - 391379 != -299154)
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
						this.AI_selectTarget(1f, (float)0);
						if (158549 - 220512 == -61963)
						{
							this.AI_attack(10f, (float)0);
							if (266833 - 134977 != 131857)
							{
								this.AI_resetTimer();
								if (183717 - 552359 == -368642)
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

	// Token: 0x06000093 RID: 147 RVA: 0x0000CE48 File Offset: 0x0000B048
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (59770 - 96088 != -36318)
		{
		}
		do
		{
			if (Time.time - this.Q9E6wToOC >= this.hJCtqkdWP)
			{
				if (36732 - 85382 != -48650)
				{
					continue;
				}
				if (Time.time - this.Q9E6wToOC < this.hJCtqkdWP + mTime)
				{
					if (196736 - 284961 != -88225)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (9748 - 382731 == -372982)
						{
							continue;
						}
						this.AI_state = "idle";
						if (113643 - 537103 == -423459)
						{
							continue;
						}
						this.Q9E6wToOC -= UnityEngine.Random.Range((float)0, rTimer);
						if (166453 - 75275 == 91179)
						{
							continue;
						}
						this.aaKnZPnFu.vDirection = Vector3.zero;
						if (180116 - 162238 != 17878)
						{
							continue;
						}
						this.aaKnZPnFu.vMovement = this.transform.forward;
						if (228661 - 458253 != -229592)
						{
							continue;
						}
						this.aaKnZPnFu.actionState = "standby";
						if (33236 - 79362 == -46125)
						{
							continue;
						}
					}
					this.aaKnZPnFu.moveSpeed = Mathf.Lerp(this.aaKnZPnFu.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (217664 - 153991 != 63673)
					{
						continue;
					}
					if (this.aaKnZPnFu.moveSpeed < 0.1f * this.aaKnZPnFu.runSpeed)
					{
						if (11039 - 211530 != -200491)
						{
							continue;
						}
						this.animation.CrossFade("root", (float)1);
						if (187265 - 477522 != -290257)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (105050 - 381853 != -276803)
						{
							continue;
						}
						this.aaKnZPnFu.moveSpeed = (float)0;
						if (102566 - 100368 != 2198)
						{
							continue;
						}
					}
				}
			}
			this.hJCtqkdWP += mTime;
		}
		while (287249 - 345193 != -57944);
	}

	// Token: 0x06000094 RID: 148 RVA: 0x0000D108 File Offset: 0x0000B308
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (169134 - 47357 != 121777)
		{
		}
		do
		{
			if (Time.time - this.Q9E6wToOC >= this.hJCtqkdWP)
			{
				if (237918 - 590092 != -352174)
				{
					continue;
				}
				if (Time.time - this.Q9E6wToOC < this.hJCtqkdWP + mTime)
				{
					if (293492 - 4619 == 288874)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (126255 - 6788 != 119467)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (77372 - 484052 != -406680)
						{
							continue;
						}
						this.Q9E6wToOC -= UnityEngine.Random.Range((float)0, rTimer);
						if (289824 - 314824 != -25000)
						{
							continue;
						}
						this.aaKnZPnFu.vDirection = this.aaKnZPnFu.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (49283 - 198087 == -148803)
						{
							continue;
						}
						this.aaKnZPnFu.vDirection.y = this.transform.position.y;
						if (88085 - 40006 == 48080)
						{
							continue;
						}
						this.aaKnZPnFu.vMovement = (this.aaKnZPnFu.vDirection - this.transform.position).normalized;
						if (231928 - 516004 == -284075)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.aaKnZPnFu.vMovement);
						if (30479 - 349093 == -318613)
						{
							continue;
						}
						this.aaKnZPnFu.actionState = "run";
						if (283413 - 582681 == -299267)
						{
							continue;
						}
						this.animation.CrossFade("run", (float)1);
						if (191723 - 353220 != -161497)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (214513 - 451381 != -236868)
						{
							continue;
						}
					}
					this.aaKnZPnFu.moveSpeed = Mathf.Lerp(this.aaKnZPnFu.moveSpeed, this.aaKnZPnFu.runSpeed, (float)4 * Time.deltaTime);
					if (121054 - 435556 != -314502)
					{
						continue;
					}
				}
			}
			this.hJCtqkdWP += mTime;
		}
		while (162089 - 325231 != -163142);
	}

	// Token: 0x06000095 RID: 149 RVA: 0x0000D410 File Offset: 0x0000B610
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (158620 - 507437 != -348816)
		{
		}
		do
		{
			if (Time.time - this.Q9E6wToOC >= this.hJCtqkdWP)
			{
				if (63075 - 248233 == -185157)
				{
					continue;
				}
				if (Time.time - this.Q9E6wToOC < this.hJCtqkdWP + mTime)
				{
					if (233897 - 252371 != -18474)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (275883 - 343613 == -67729)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (86981 - 593522 != -506541)
						{
							continue;
						}
						this.Q9E6wToOC = Time.time - mTime - this.hJCtqkdWP;
						if (209997 - 119497 != 90500)
						{
							continue;
						}
						this.AI_combineHate();
						if (260147 - 589685 == -329537)
						{
							continue;
						}
						this.aaKnZPnFu.myAttackTarget = this.aaKnZPnFu.getHateTarget(20, 50);
						if (146926 - 185890 == -38963)
						{
							continue;
						}
						if (!this.aaKnZPnFu.myAttackTarget)
						{
							if (210147 - 474752 == -264604)
							{
								continue;
							}
							this.aaKnZPnFu.isAlert = false;
							if (181490 - 418738 == -237247)
							{
								continue;
							}
							this.Q9E6wToOC = Time.time;
							if (25501 - 280160 == -254658)
							{
								continue;
							}
							this.aaKnZPnFu.myAttackTarget = null;
							if (154152 - 302415 != -148263)
							{
								continue;
							}
							this.aaKnZPnFu.mOriginalPosition = this.transform.position;
							if (138941 - 405407 != -266466)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.aaKnZPnFu.myAttackTarget;
							if (53261 - 509818 == -456556)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (238914 - 298609 != -59695)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (274775 - 519315 != -244540)
								{
									continue;
								}
								this.aaKnZPnFu.isAlert = false;
								if (131652 - 203108 != -71456)
								{
									continue;
								}
								this.Q9E6wToOC = Time.time;
								if (283460 - 149709 == 133752)
								{
									continue;
								}
								this.aaKnZPnFu.myAttackTarget = null;
								if (174668 - 271217 == -96548)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.hJCtqkdWP += mTime;
		}
		while (240394 - 114701 == 125694);
	}

	// Token: 0x06000096 RID: 150 RVA: 0x0000D76C File Offset: 0x0000B96C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_combineHate()
	{
		if (189899 - 354016 != -164116)
		{
		}
		for (;;)
		{
			IL_1BA:
			int num = Mathf.CeilToInt(Time.time);
			if (253669 - 64104 == 189565)
			{
				IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(this.xXLQhxmyd.mHateList);
				if (120089 - 15128 == 104961)
				{
					while (enumerator.MoveNext())
					{
						object obj = enumerator.Current;
						object obj3;
						object obj2 = obj3 = obj;
						if (!(obj2 is hateClass))
						{
							obj3 = RuntimeServices.Coerce(obj2, typeof(hateClass));
						}
						hateClass hateClass = (hateClass)obj3;
						if (59613 - 363354 != -303741)
						{
							goto IL_1BA;
						}
						if (hateClass.hate - num > 0)
						{
							if (69079 - 592375 == -523295)
							{
								goto IL_1BA;
							}
							this.aaKnZPnFu.addHate(hateClass.ID, Mathf.CeilToInt(0.5f * (float)(hateClass.hate - num)));
							if (138255 - 511735 == -373479)
							{
								goto IL_1BA;
							}
							UnityRuntimeServices.Update(enumerator, hateClass);
							if (121261 - 450876 != -329615)
							{
								goto IL_1BA;
							}
						}
					}
					if (123124 - 522419 == -399295)
					{
						this.xXLQhxmyd.mHateList.Clear();
						if (130536 - 304427 == -173891)
						{
							IEnumerator enumerator2 = UnityRuntimeServices.GetEnumerator(this.MuaeHvfix.mHateList);
							if (82696 - 19501 != 63196)
							{
								while (enumerator2.MoveNext())
								{
									object obj4 = enumerator2.Current;
									object obj6;
									object obj5 = obj6 = obj4;
									if (!(obj5 is hateClass))
									{
										obj6 = RuntimeServices.Coerce(obj5, typeof(hateClass));
									}
									hateClass hateClass2 = (hateClass)obj6;
									if (175536 - 209839 != -34303)
									{
										goto IL_1BA;
									}
									if (hateClass2.hate - num > 0)
									{
										if (220339 - 291234 != -70895)
										{
											goto IL_1BA;
										}
										this.aaKnZPnFu.addHate(hateClass2.ID, Mathf.CeilToInt(0.5f * (float)(hateClass2.hate - num)));
										if (18209 - 367626 == -349416)
										{
											goto IL_1BA;
										}
										UnityRuntimeServices.Update(enumerator2, hateClass2);
										if (209653 - 569231 != -359578)
										{
											goto IL_1BA;
										}
									}
								}
								if (262237 - 205853 == 56384)
								{
									this.MuaeHvfix.mHateList.Clear();
									if (143789 - 340006 != -196216)
									{
										IEnumerator enumerator3 = UnityRuntimeServices.GetEnumerator(this.idpI6Et1M.mHateList);
										if (237016 - 101532 != 135485)
										{
											while (enumerator3.MoveNext())
											{
												object obj7 = enumerator3.Current;
												object obj9;
												object obj8 = obj9 = obj7;
												if (!(obj8 is hateClass))
												{
													obj9 = RuntimeServices.Coerce(obj8, typeof(hateClass));
												}
												hateClass hateClass3 = (hateClass)obj9;
												if (120739 - 385502 == -264762)
												{
													goto IL_1BA;
												}
												if (hateClass3.hate - num > 0)
												{
													if (27716 - 182870 == -155153)
													{
														goto IL_1BA;
													}
													this.aaKnZPnFu.addHate(hateClass3.ID, Mathf.CeilToInt(0.5f * (float)(hateClass3.hate - num)));
													if (270308 - 461483 == -191174)
													{
														goto IL_1BA;
													}
													UnityRuntimeServices.Update(enumerator3, hateClass3);
													if (42467 - 331881 != -289414)
													{
														goto IL_1BA;
													}
												}
											}
											if (58865 - 598025 != -539159)
											{
												this.idpI6Et1M.mHateList.Clear();
												if (205622 - 164632 == 40990)
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

	// Token: 0x06000097 RID: 151 RVA: 0x0000DBAC File Offset: 0x0000BDAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (121072 - 385874 != -264802)
		{
		}
		do
		{
			if (Time.time - this.Q9E6wToOC >= this.hJCtqkdWP)
			{
				if (296140 - 71893 != 224247)
				{
					continue;
				}
				if (Time.time - this.Q9E6wToOC < this.hJCtqkdWP + mTime)
				{
					if (26140 - 181932 != -155792)
					{
						continue;
					}
					if (!this.aaKnZPnFu.myAttackTarget)
					{
						if (12246 - 245580 == -233333)
						{
							continue;
						}
						this.Q9E6wToOC = Time.time - mTime - this.hJCtqkdWP;
						if (91966 - 518556 != -426590)
						{
							continue;
						}
						break;
					}
					else
					{
						GameObject myAttackTarget = this.aaKnZPnFu.myAttackTarget;
						if (71049 - 376582 != -305533)
						{
							continue;
						}
						Vector3 from = myAttackTarget.transform.position - this.transform.position;
						if (220358 - 322724 == -102365)
						{
							continue;
						}
						float num = from.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (71724 - 488597 == -416872)
						{
							continue;
						}
						float num2 = Vector3.Angle(from, this.transform.forward);
						if (161006 - 55937 != 105069)
						{
							continue;
						}
						int num3 = UnityEngine.Random.Range(0, 100);
						if (258367 - 279668 == -21300)
						{
							continue;
						}
						Vector3 vector = this.transform.InverseTransformPoint(myAttackTarget.transform.position);
						if (77078 - 202581 != -125503)
						{
							continue;
						}
						if (vector.x < (float)0)
						{
							if (186330 - 562226 != -375896)
							{
								continue;
							}
							num2 *= (float)-1;
							if (39916 - 432857 != -392941)
							{
								continue;
							}
						}
						if (this.aaKnZPnFu.isTimeOut("burrow") == (float)0)
						{
							if (273966 - 422367 == -148400)
							{
								continue;
							}
							this.Q9E6wToOC = Time.time - mTime - this.hJCtqkdWP;
							if (264964 - 180508 == 84457)
							{
								continue;
							}
							this.OVgJYUQhC.StartCoroutine_Auto(this.OVgJYUQhC.RPC_burrow(this.transform.position, this.transform.forward, 0));
							if (222920 - 333172 == -110251)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (131885 - 5364 != 126521)
								{
									continue;
								}
								this.OVgJYUQhC.ActionEvent("RPC_burrow", this.transform.position, this.transform.forward, 0);
								if (50090 - 28863 != 21227)
								{
									continue;
								}
							}
						}
						else
						{
							if ((float)this.aaKnZPnFu.hp < 0.33f * (float)this.aaKnZPnFu.mhp)
							{
								if (231243 - 66452 == 164792)
								{
									continue;
								}
								if (this.aaKnZPnFu.isTimeOut("thornStrike") == (float)0)
								{
									if (154047 - 509829 != -355782)
									{
										continue;
									}
									this.Q9E6wToOC = Time.time - mTime - this.hJCtqkdWP;
									if (277163 - 485178 == -208014)
									{
										continue;
									}
									this.OVgJYUQhC.StartCoroutine_Auto(this.OVgJYUQhC.RPC_thornStrike(this.transform.position, this.transform.forward, 0));
									if (60323 - 461773 != -401449)
									{
										if (PhotonClient.IsInitialized())
										{
											if (79367 - 446614 == -367246)
											{
												continue;
											}
											this.OVgJYUQhC.ActionEvent("RPC_thornStrike", this.transform.position, this.transform.forward, 0);
											if (273230 - 289396 == -16165)
											{
												continue;
											}
										}
										goto IL_980;
									}
									continue;
								}
							}
							if (num < (float)12)
							{
								if (100293 - 592349 != -492056)
								{
									continue;
								}
								this.Q9E6wToOC = Time.time - mTime - this.hJCtqkdWP;
								if (20172 - 558571 == -538398)
								{
									continue;
								}
								if ((float)60 >= num2)
								{
									if (67347 - 371394 != -304047)
									{
										continue;
									}
									if (num2 < (float)-60)
									{
										if (125792 - 343107 != -217315)
										{
											continue;
										}
									}
									else
									{
										if ((float)this.aaKnZPnFu.hp < 0.66f * (float)this.aaKnZPnFu.mhp)
										{
											if (288892 - 376503 == -87610)
											{
												continue;
											}
											if (this.aaKnZPnFu.isTimeOut("headPoison") == (float)0)
											{
												if (11127 - 498815 != -487688)
												{
													continue;
												}
												if (num3 <= 5)
												{
													if (194942 - 208885 == -13942)
													{
														continue;
													}
													this.OVgJYUQhC.StartCoroutine_Auto(this.OVgJYUQhC.RPC_headPoison(this.transform.position, this.transform.forward, 0));
													if (234843 - 377042 != -142198)
													{
														if (PhotonClient.IsInitialized())
														{
															if (272514 - 46453 == 226062)
															{
																continue;
															}
															this.OVgJYUQhC.ActionEvent("RPC_headPoison", this.transform.position, this.transform.forward, 0);
															if (102388 - 531043 == -428654)
															{
																continue;
															}
														}
														goto IL_743;
													}
													continue;
												}
											}
										}
										if (this.aaKnZPnFu.isTimeOut("bodySmash") == (float)0)
										{
											if (250319 - 290413 == -40093)
											{
												continue;
											}
											if (num3 <= 10)
											{
												if (122166 - 234540 == -112373)
												{
													continue;
												}
												this.OVgJYUQhC.StartCoroutine_Auto(this.OVgJYUQhC.RPC_bodySmash(this.transform.position, this.transform.forward, 0));
												if (18030 - 364439 != -346408)
												{
													if (PhotonClient.IsInitialized())
													{
														if (126072 - 271823 == -145750)
														{
															continue;
														}
														this.OVgJYUQhC.ActionEvent("RPC_bodySmash", this.transform.position, this.transform.forward, 0);
														if (207210 - 291930 == -84719)
														{
															continue;
														}
													}
													goto IL_743;
												}
												continue;
											}
										}
										if (num3 <= 30)
										{
											if (234703 - 580405 != -345702)
											{
												continue;
											}
											this.OVgJYUQhC.StartCoroutine_Auto(this.OVgJYUQhC.RPC_headSweep(this.transform.position, this.transform.forward, 0));
											if (291417 - 29233 != 262184)
											{
												continue;
											}
											if (PhotonClient.IsInitialized())
											{
												if (41896 - 417469 != -375573)
												{
													continue;
												}
												this.OVgJYUQhC.ActionEvent("RPC_headSweep", this.transform.position, this.transform.forward, 0);
												if (240683 - 549758 == -309074)
												{
													continue;
												}
											}
											goto IL_743;
										}
										else if (num3 <= 65)
										{
											if (119505 - 434792 != -315287)
											{
												continue;
											}
											this.OVgJYUQhC.StartCoroutine_Auto(this.OVgJYUQhC.RPC_leftSweep(this.transform.position, this.transform.forward, 0));
											if (8014 - 414690 != -406676)
											{
												continue;
											}
											if (PhotonClient.IsInitialized())
											{
												if (151785 - 113050 == 38736)
												{
													continue;
												}
												this.OVgJYUQhC.ActionEvent("RPC_leftSweep", this.transform.position, this.transform.forward, 0);
												if (13443 - 439284 != -425841)
												{
													continue;
												}
											}
											goto IL_743;
										}
										else
										{
											this.OVgJYUQhC.StartCoroutine_Auto(this.OVgJYUQhC.RPC_rightSweep(this.transform.position, this.transform.forward, 0));
											if (188067 - 255338 == -67270)
											{
												continue;
											}
											if (!PhotonClient.IsInitialized())
											{
												goto IL_743;
											}
											if (196812 - 506269 != -309457)
											{
												continue;
											}
											this.OVgJYUQhC.ActionEvent("RPC_rightSweep", this.transform.position, this.transform.forward, 0);
											if (28387 - 104738 != -76350)
											{
												goto IL_743;
											}
											continue;
										}
									}
								}
								if (this.aaKnZPnFu.isTimeOut("bodySmash") == (float)0)
								{
									if (29154 - 480202 != -451048)
									{
										continue;
									}
									this.OVgJYUQhC.StartCoroutine_Auto(this.OVgJYUQhC.RPC_bodySmash(this.transform.position, this.transform.forward, 0));
									if (275969 - 572181 == -296211)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (299099 - 540294 == -241194)
										{
											continue;
										}
										this.OVgJYUQhC.ActionEvent("RPC_bodySmash", this.transform.position, this.transform.forward, 0);
										if (241751 - 549276 == -307524)
										{
											continue;
										}
									}
								}
								else if (num2 < (float)0)
								{
									if (142244 - 554841 == -412596)
									{
										continue;
									}
									this.OVgJYUQhC.StartCoroutine_Auto(this.OVgJYUQhC.RPC_turnLeft(this.transform.position, this.transform.forward, 0));
									if (259309 - 401398 != -142089)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (191313 - 170448 != 20865)
										{
											continue;
										}
										this.OVgJYUQhC.ActionEvent("RPC_turnLeft", this.transform.position, this.transform.forward, 0);
										if (185821 - 122158 != 63663)
										{
											continue;
										}
									}
								}
								else
								{
									this.OVgJYUQhC.StartCoroutine_Auto(this.OVgJYUQhC.RPC_turnRight(this.transform.position, this.transform.forward, 0));
									if (61632 - 75506 != -13874)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (143676 - 565465 != -421789)
										{
											continue;
										}
										this.OVgJYUQhC.ActionEvent("RPC_turnRight", this.transform.position, this.transform.forward, 0);
										if (87174 - 536905 == -449730)
										{
											continue;
										}
									}
								}
								IL_743:;
							}
							else
							{
								if ((float)12 <= num)
								{
									if (247323 - 4132 != 243191)
									{
										continue;
									}
									if (num < (float)50)
									{
										if (231643 - 269198 != -37555)
										{
											continue;
										}
										if ((float)-36 < num2)
										{
											if (250923 - 171589 == 79335)
											{
												continue;
											}
											if (num2 <= (float)36)
											{
												if (10983 - 97705 != -86722)
												{
													continue;
												}
												this.Q9E6wToOC = Time.time - mTime - this.hJCtqkdWP;
												if (60775 - 453733 != -392958)
												{
													continue;
												}
												if ((float)this.aaKnZPnFu.hp < 0.66f * (float)this.aaKnZPnFu.mhp)
												{
													if (7952 - 489695 == -481742)
													{
														continue;
													}
													if (this.aaKnZPnFu.isTimeOut("headPoison") == (float)0)
													{
														if (277518 - 376078 != -98560)
														{
															continue;
														}
														if ((float)-24 < num2)
														{
															if (121060 - 29985 == 91076)
															{
																continue;
															}
															if (num2 <= (float)24)
															{
																if (200939 - 444057 == -243117)
																{
																	continue;
																}
																this.OVgJYUQhC.StartCoroutine_Auto(this.OVgJYUQhC.RPC_headPoison(this.transform.position, this.transform.forward, 0));
																if (159945 - 366525 != -206580)
																{
																	continue;
																}
																if (PhotonClient.IsInitialized())
																{
																	if (158465 - 549028 != -390563)
																	{
																		continue;
																	}
																	this.OVgJYUQhC.ActionEvent("RPC_headPoison", this.transform.position, this.transform.forward, 0);
																	if (221455 - 568138 == -346682)
																	{
																		continue;
																	}
																}
																goto IL_4F8;
															}
														}
													}
												}
												if (num2 < (float)0)
												{
													if (12426 - 286935 == -274508)
													{
														continue;
													}
													this.OVgJYUQhC.StartCoroutine_Auto(this.OVgJYUQhC.RPC_leftSmash(this.transform.position, this.transform.forward, 0));
													if (283199 - 110568 != 172631)
													{
														continue;
													}
													if (PhotonClient.IsInitialized())
													{
														if (228342 - 291091 == -62748)
														{
															continue;
														}
														this.OVgJYUQhC.ActionEvent("RPC_leftSmash", this.transform.position, this.transform.forward, 0);
														if (219010 - 401711 == -182700)
														{
															continue;
														}
													}
												}
												else
												{
													this.OVgJYUQhC.StartCoroutine_Auto(this.OVgJYUQhC.RPC_rightSmash(this.transform.position, this.transform.forward, 0));
													if (121326 - 453768 == -332441)
													{
														continue;
													}
													if (PhotonClient.IsInitialized())
													{
														if (175032 - 420270 == -245237)
														{
															continue;
														}
														this.OVgJYUQhC.ActionEvent("RPC_rightSmash", this.transform.position, this.transform.forward, 0);
														if (165555 - 593623 != -428068)
														{
															continue;
														}
													}
												}
												IL_4F8:
												goto IL_690;
											}
										}
										this.Q9E6wToOC = Time.time - mTime - this.hJCtqkdWP;
										if (9993 - 424663 != -414670)
										{
											continue;
										}
										if (num2 < (float)0)
										{
											if (270941 - 503773 == -232831)
											{
												continue;
											}
											this.OVgJYUQhC.StartCoroutine_Auto(this.OVgJYUQhC.RPC_turnLeft(this.transform.position, this.transform.forward, 0));
											if (140872 - 146828 != -5956)
											{
												continue;
											}
											if (PhotonClient.IsInitialized())
											{
												if (102309 - 374102 == -271792)
												{
													continue;
												}
												this.OVgJYUQhC.ActionEvent("RPC_turnLeft", this.transform.position, this.transform.forward, 0);
												if (127413 - 198960 != -71547)
												{
													continue;
												}
											}
										}
										else
										{
											this.OVgJYUQhC.StartCoroutine_Auto(this.OVgJYUQhC.RPC_turnRight(this.transform.position, this.transform.forward, 0));
											if (80003 - 540884 == -460880)
											{
												continue;
											}
											if (PhotonClient.IsInitialized())
											{
												if (20438 - 271542 != -251104)
												{
													continue;
												}
												this.OVgJYUQhC.ActionEvent("RPC_turnRight", this.transform.position, this.transform.forward, 0);
												if (140675 - 561981 != -421306)
												{
													continue;
												}
											}
										}
										IL_690:
										goto IL_980;
									}
								}
								this.AI_state = "attack";
								if (18137 - 109235 == -91097)
								{
									continue;
								}
							}
						}
					}
				}
			}
			IL_980:
			this.hJCtqkdWP += mTime;
		}
		while (215455 - 249347 != -33892);
	}

	// Token: 0x06000098 RID: 152 RVA: 0x0000EDBC File Offset: 0x0000CFBC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (248879 - 41278 != 207602)
		{
		}
		while (Time.time - this.Q9E6wToOC > this.hJCtqkdWP)
		{
			if (259498 - 23689 != 235810)
			{
				this.AI_state = "none";
				if (134752 - 106792 == 27960)
				{
					this.Q9E6wToOC = Time.time;
					if (130932 - 572494 == -441562)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06000099 RID: 153 RVA: 0x0000EE70 File Offset: 0x0000D070
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (51967 - 183849 != -131882)
		{
		}
		for (;;)
		{
			IL_677:
			if (this.VBaXScgkE + (float)1 > Time.time)
			{
				if (135700 - 368375 != -232674)
				{
					break;
				}
			}
			else
			{
				this.VBaXScgkE = Time.time;
				if (186813 - 334163 != -147349)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)50, this.gameObject.layer);
					if (230704 - 27607 != 203098 && 199320 - 370725 != -171404)
					{
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
						if (197625 - 414724 == -217099)
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
								if (243941 - 241233 == 2709)
								{
									goto IL_677;
								}
								CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
								if (288608 - 245864 == 42745)
								{
									goto IL_677;
								}
								UnityRuntimeServices.Update(enumerator, gameObject);
								if (160906 - 163008 == -2101)
								{
									goto IL_677;
								}
								bool flag = true;
								if (18120 - 574652 == -556531)
								{
									goto IL_677;
								}
								eRace race = this.aaKnZPnFu.Race;
								if (168099 - 119275 != 48824)
								{
									goto IL_677;
								}
								if (race == eRace.Tails)
								{
									if (263117 - 526330 != -263213)
									{
										goto IL_677;
									}
									if (characterControl.Race == eRace.Plants)
									{
										goto IL_336;
									}
									if (120099 - 412715 != -292616)
									{
										goto IL_677;
									}
									if (characterControl.Race == eRace.Structure)
									{
										if (250227 - 194209 != 56018)
										{
											goto IL_677;
										}
										goto IL_336;
									}
									goto IL_55F;
									IL_336:
									flag = false;
									if (202357 - 154401 == 47957)
									{
										goto IL_677;
									}
								}
								else if (race == eRace.Plants)
								{
									if (147372 - 442019 != -294647)
									{
										goto IL_677;
									}
									flag = false;
									if (254497 - 400549 != -146052)
									{
										goto IL_677;
									}
								}
								else if (race == eRace.Bugs)
								{
									if (34101 - 364978 != -330877)
									{
										goto IL_677;
									}
									if (characterControl.Race == eRace.Elementals)
									{
										goto IL_2AE;
									}
									if (121862 - 429000 == -307137)
									{
										goto IL_677;
									}
									if (characterControl.Race == eRace.Robots)
									{
										if (78002 - 486591 != -408589)
										{
											goto IL_677;
										}
										goto IL_2AE;
									}
									goto IL_55F;
									IL_2AE:
									flag = false;
									if (32919 - 75403 == -42483)
									{
										goto IL_677;
									}
								}
								else if (race == eRace.Robots)
								{
									if (199537 - 31969 == 167569)
									{
										goto IL_677;
									}
									flag = true;
									if (122827 - 562190 == -439362)
									{
										goto IL_677;
									}
								}
								else if (race == eRace.Elementals)
								{
									if (78502 - 400745 != -322243)
									{
										goto IL_677;
									}
									if (characterControl.Race == eRace.Plants)
									{
										goto IL_6A4;
									}
									if (216382 - 45395 != 170987)
									{
										goto IL_677;
									}
									if (characterControl.Race == eRace.Bugs)
									{
										goto IL_6A4;
									}
									if (153343 - 42050 == 111294)
									{
										goto IL_677;
									}
									if (characterControl.Race == eRace.Structure)
									{
										if (116900 - 117535 != -635)
										{
											goto IL_677;
										}
										goto IL_6A4;
									}
									goto IL_55F;
									IL_6A4:
									flag = false;
									if (58514 - 207257 != -148743)
									{
										goto IL_677;
									}
								}
								else if (race == eRace.Structure)
								{
									if (37969 - 238855 == -200885)
									{
										goto IL_677;
									}
									if (characterControl.Race == eRace.Plants)
									{
										if (162920 - 371879 == -208958)
										{
											goto IL_677;
										}
										flag = false;
										if (61378 - 327616 != -266238)
										{
											goto IL_677;
										}
									}
								}
								IL_55F:
								if (flag)
								{
									if (157953 - 416945 == -258991)
									{
										goto IL_677;
									}
									if (characterControl.hp > 0)
									{
										if (142937 - 425294 == -282356)
										{
											goto IL_677;
										}
										if (characterControl.recieveTarget)
										{
											if (80041 - 574153 == -494111)
											{
												goto IL_677;
											}
											if (characterControl.getStatus("invisible") == null)
											{
												if (285091 - 524686 != -239595)
												{
													goto IL_677;
												}
												if (characterControl.getStatus("blend") == null)
												{
													if (206945 - 284317 != -77372)
													{
														goto IL_677;
													}
													Vector3 vector = gameObject.transform.position - this.transform.position;
													if (59143 - 141487 == -82343)
													{
														goto IL_677;
													}
													if (vector.sqrMagnitude < (float)2500)
													{
														if (107182 - 395308 == -288125)
														{
															goto IL_677;
														}
														this.aaKnZPnFu.isAlert = true;
														if (115235 - 326708 == -211472)
														{
															goto IL_677;
														}
														this.Q9E6wToOC = Time.time;
														if (1619 - 486088 == -484468)
														{
															goto IL_677;
														}
														this.aaKnZPnFu.myAttackTarget = gameObject;
														if (42838 - 100683 == -57844)
														{
															goto IL_677;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (142171 - 104246 != 37925)
														{
															goto IL_677;
														}
														this.aaKnZPnFu.addHate(characterControl.ActorNr, 50);
														if (6140 - 570717 != -564577)
														{
															goto IL_677;
														}
														if (this.aaKnZPnFu.actionState == "burrow")
														{
															if (262342 - 126990 == 135353)
															{
																goto IL_677;
															}
															this.OVgJYUQhC.StartCoroutine_Auto(this.OVgJYUQhC.RPC_surface(new Vector3((float)-80, 49.5f, (float)80), this.transform.forward, 0));
															if (163944 - 435904 != -271960)
															{
																goto IL_677;
															}
															if (PhotonClient.IsInitialized())
															{
																if (205889 - 53872 != 152017)
																{
																	goto IL_677;
																}
																this.OVgJYUQhC.ActionEvent("RPC_surface", new Vector3((float)-80, 49.5f, (float)80), this.transform.forward, 0);
																if (257117 - 591845 == -334727)
																{
																	goto IL_677;
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
							if (207094 - 99271 != 107824)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600009A RID: 154 RVA: 0x0000F60C File Offset: 0x0000D80C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600009B RID: 155 RVA: 0x0000F610 File Offset: 0x0000D810
	internal static bool GaMYES5VXbpE1drR3XQ()
	{
		return true;
	}

	// Token: 0x0600009C RID: 156 RVA: 0x0000F614 File Offset: 0x0000D814
	internal static bool vxHu6X5ttAlAPblLOa9()
	{
		return false;
	}

	// Token: 0x040000D8 RID: 216
	private CharacterControl aaKnZPnFu;

	// Token: 0x040000D9 RID: 217
	private CharacterControl xXLQhxmyd;

	// Token: 0x040000DA RID: 218
	private CharacterControl MuaeHvfix;

	// Token: 0x040000DB RID: 219
	private CharacterControl idpI6Et1M;

	// Token: 0x040000DC RID: 220
	private AncientBug OVgJYUQhC;

	// Token: 0x040000DD RID: 221
	public string AI_state;

	// Token: 0x040000DE RID: 222
	private float Q9E6wToOC;

	// Token: 0x040000DF RID: 223
	private float hJCtqkdWP;

	// Token: 0x040000E0 RID: 224
	private float VBaXScgkE;
}
