using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Boo.Lang;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020003B5 RID: 949
[Serializable]
public class ShadowSheep_AI : MonoBehaviour
{
	// Token: 0x060015FF RID: 5631 RVA: 0x0023C674 File Offset: 0x0023A874
	[MethodImpl(MethodImplOptions.NoInlining)]
	public ShadowSheep_AI()
	{
		if (231732 - 40168 != 191565)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (10450 - 134894 == -124444)
			{
				base..ctor();
				if (163735 - 499925 != -336189)
				{
					this.AI_state = "none";
					if (243176 - 303381 == -60205)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06001600 RID: 5632 RVA: 0x0023C710 File Offset: 0x0023A910
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.mrBO5AWWPK = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.oSfOc7ACsv = (Sheep)this.GetComponent(typeof(Sheep));
	}

	// Token: 0x06001601 RID: 5633 RVA: 0x0023C748 File Offset: 0x0023A948
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (150851 - 444721 != -293869)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (3460 - 193207 != -189747)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (216593 - 62803 == 153791)
				{
					continue;
				}
			}
			if (this.mrBO5AWWPK.isControlled)
			{
				break;
			}
			if (263179 - 461898 != -198718)
			{
				this.AIControl();
				if (244548 - 343532 == -98984)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06001602 RID: 5634 RVA: 0x0023C814 File Offset: 0x0023AA14
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AddAISummoner(GameObject nSummoner)
	{
		this.yJ7OeoiHTF = nSummoner;
	}

	// Token: 0x06001603 RID: 5635 RVA: 0x0023C820 File Offset: 0x0023AA20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (231044 - 584300 != -353255)
		{
		}
		for (;;)
		{
			this.ARSOQXUkPQ = (float)0;
			if (70715 - 436318 != -365602)
			{
				if (this.mrBO5AWWPK.isMine)
				{
					if (106811 - 509738 != -402926)
					{
						if (this.mrBO5AWWPK.actionState != "standby")
						{
							if (150065 - 565453 == -415387)
							{
								continue;
							}
							if (this.mrBO5AWWPK.actionState != "run")
							{
								if (250808 - 87813 != 162995)
								{
									continue;
								}
								break;
							}
						}
						if (this.yJ7OeoiHTF)
						{
							if (268873 - 8989 == 259884)
							{
								if (!this.mrBO5AWWPK.isAlert)
								{
									if (1314 - 243196 == -241882)
									{
										Vector3 vector = this.yJ7OeoiHTF.transform.position - this.transform.position;
										if (216160 - 152663 == 63497)
										{
											if (vector.sqrMagnitude > (float)36)
											{
												if (153465 - 368784 == -215318)
												{
													continue;
												}
												this.AI_follow(this.yJ7OeoiHTF);
												if (57443 - 61272 != -3829)
												{
													continue;
												}
											}
											else
											{
												this.AI_idle(3f, 1f);
												if (73453 - 100034 == -26580)
												{
													continue;
												}
												this.AI_patrol(1f, 0.25f);
												if (44841 - 245810 == -200968)
												{
													continue;
												}
												this.AI_resetTimer();
												if (298362 - 467226 == -168863)
												{
													continue;
												}
												this.AI_visionCheck();
												if (108787 - 262738 != -153951)
												{
													continue;
												}
											}
											if (!this.mrBO5AWWPK.myAttackTarget)
											{
												break;
											}
											if (211223 - 153608 != 57616)
											{
												this.mrBO5AWWPK.isAlert = true;
												if (273624 - 412374 == -138750)
												{
													this.rnLOnf7kHs = Time.time;
													if (201166 - 417632 == -216466)
													{
														break;
													}
												}
											}
										}
									}
								}
								else
								{
									Vector3 vector2 = this.yJ7OeoiHTF.transform.position - this.transform.position;
									if (256728 - 142423 == 114305)
									{
										if (vector2.sqrMagnitude > (float)900)
										{
											if (233714 - 313053 != -79338)
											{
												this.mrBO5AWWPK.isAlert = false;
												if (151956 - 139544 == 12412)
												{
													this.AI_resetTimer();
													if (166068 - 205438 != -39369)
													{
														break;
													}
												}
											}
										}
										else
										{
											this.AI_selectTarget(1f, (float)0);
											if (109342 - 229515 != -120172)
											{
												this.AI_patrol(3f, 1f);
												if (26878 - 138068 != -111189)
												{
													this.StartCoroutine_Auto(this.AI_attack(10f, (float)0));
													if (226519 - 397839 != -171319)
													{
														this.AI_resetTimer();
														if (269134 - 286856 == -17722)
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
						else if (!this.mrBO5AWWPK.isAlert)
						{
							if (125816 - 460326 != -334509)
							{
								this.AI_idle(3f, 1f);
								if (205984 - 107178 == 98806)
								{
									this.AI_patrol(1f, 0.25f);
									if (92374 - 486786 == -394412)
									{
										this.AI_resetTimer();
										if (148993 - 403466 != -254472)
										{
											this.AI_visionCheck();
											if (60418 - 257163 == -196745)
											{
												if (!this.mrBO5AWWPK.myAttackTarget)
												{
													break;
												}
												if (111165 - 57299 == 53866)
												{
													this.mrBO5AWWPK.isAlert = true;
													if (289502 - 174258 == 115244)
													{
														this.rnLOnf7kHs = Time.time;
														if (212484 - 47335 == 165149)
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
							if (134051 - 205068 == -71017)
							{
								this.AI_patrol(3f, 1f);
								if (281282 - 368348 == -87066)
								{
									this.StartCoroutine_Auto(this.AI_attack(10f, (float)0));
									if (148232 - 434325 != -286092)
									{
										this.AI_resetTimer();
										if (40631 - 419444 != -378812)
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
					if (this.mrBO5AWWPK.actionState != "standby")
					{
						if (74795 - 293971 == -219175)
						{
							continue;
						}
						if (this.mrBO5AWWPK.actionState != "run")
						{
							if (96835 - 574555 != -477719)
							{
								break;
							}
							continue;
						}
					}
					float num = this.mrBO5AWWPK.moveSpeed;
					if (163587 - 472260 == -308673)
					{
						float runSpeed = this.mrBO5AWWPK.runSpeed;
						if (230198 - 334431 != -104232)
						{
							Vector3 vector3 = default(Vector3);
							if (269240 - 217050 == 52190)
							{
								Vector3 vector4 = Vector3.zero;
								if (138837 - 340120 != -201282)
								{
									if ((this.mrBO5AWWPK.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (6106 - 433907 == -427800)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.mrBO5AWWPK.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (125559 - 450721 != -325162)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (4607 - 185758 == -181150)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (59052 - 161539 != -102487)
											{
												continue;
											}
											num = (float)0;
											if (225428 - 490319 == -264890)
											{
												continue;
											}
											this.transform.position = this.mrBO5AWWPK.nPosition;
											if (182514 - 428802 != -246288)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (283522 - 369471 != -85949)
											{
												continue;
											}
											vector4 = lhs.normalized;
											if (217776 - 475460 != -257684)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector4);
											if (100979 - 150732 == -49752)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (233030 - 475378 == -242347)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (264407 - 572218 == -307810)
											{
												continue;
											}
										}
										else
										{
											vector4 = this.transform.forward;
											if (235824 - 106783 != 129041)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (14617 - 79485 != -64868)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (184733 - 206679 == -21945)
											{
												continue;
											}
										}
									}
									this.mrBO5AWWPK.vMovement = vector4;
									if (251974 - 203393 != 48582)
									{
										this.mrBO5AWWPK.moveSpeed = num;
										if (294152 - 21748 != 272405)
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

	// Token: 0x06001604 RID: 5636 RVA: 0x0023D1EC File Offset: 0x0023B3EC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (286741 - 412634 != -125893)
		{
		}
		do
		{
			if (Time.time - this.rnLOnf7kHs >= this.ARSOQXUkPQ)
			{
				if (142400 - 566755 != -424355)
				{
					continue;
				}
				if (Time.time - this.rnLOnf7kHs < this.ARSOQXUkPQ + mTime)
				{
					if (8372 - 226206 == -217833)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (145094 - 198467 == -53372)
						{
							continue;
						}
						this.AI_state = "idle";
						if (248620 - 104572 == 144049)
						{
							continue;
						}
						this.rnLOnf7kHs -= UnityEngine.Random.Range((float)0, rTimer);
						if (49497 - 453302 == -403804)
						{
							continue;
						}
						this.mrBO5AWWPK.vDirection = Vector3.zero;
						if (25419 - 508327 == -482907)
						{
							continue;
						}
						this.mrBO5AWWPK.vMovement = this.transform.forward;
						if (183837 - 36805 == 147033)
						{
							continue;
						}
						this.mrBO5AWWPK.actionState = "standby";
						if (174755 - 577034 != -402279)
						{
							continue;
						}
					}
					this.mrBO5AWWPK.moveSpeed = Mathf.Lerp(this.mrBO5AWWPK.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (89209 - 507610 == -418400)
					{
						continue;
					}
					if (this.mrBO5AWWPK.moveSpeed < 0.1f * this.mrBO5AWWPK.runSpeed)
					{
						if (62909 - 282630 != -219721)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (134386 - 114812 == 19575)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (189242 - 436179 != -246937)
						{
							continue;
						}
						this.mrBO5AWWPK.moveSpeed = (float)0;
						if (10363 - 178749 == -168385)
						{
							continue;
						}
					}
				}
			}
			this.ARSOQXUkPQ += mTime;
		}
		while (160114 - 148876 == 11239);
	}

	// Token: 0x06001605 RID: 5637 RVA: 0x0023D4B0 File Offset: 0x0023B6B0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (193089 - 402841 != -209751)
		{
		}
		do
		{
			if (Time.time - this.rnLOnf7kHs >= this.ARSOQXUkPQ)
			{
				if (192584 - 93990 != 98594)
				{
					continue;
				}
				if (Time.time - this.rnLOnf7kHs < this.ARSOQXUkPQ + mTime)
				{
					if (36356 - 33224 != 3132)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (115981 - 180225 != -64244)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (172422 - 122613 == 49810)
						{
							continue;
						}
						this.rnLOnf7kHs -= UnityEngine.Random.Range((float)0, rTimer);
						if (207408 - 117613 == 89796)
						{
							continue;
						}
						this.mrBO5AWWPK.vDirection = this.mrBO5AWWPK.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (113392 - 132053 != -18661)
						{
							continue;
						}
						this.mrBO5AWWPK.vDirection.y = this.transform.position.y;
						if (211162 - 455699 == -244536)
						{
							continue;
						}
						this.mrBO5AWWPK.vMovement = (this.mrBO5AWWPK.vDirection - this.transform.position).normalized;
						if (51909 - 39628 == 12282)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.mrBO5AWWPK.vMovement);
						if (286896 - 310126 != -23230)
						{
							continue;
						}
						this.mrBO5AWWPK.actionState = "run";
						if (95627 - 112473 != -16846)
						{
							continue;
						}
						this.animation.Play("run");
						if (192426 - 86607 == 105820)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (163079 - 328520 != -165441)
						{
							continue;
						}
					}
					this.mrBO5AWWPK.moveSpeed = Mathf.Lerp(this.mrBO5AWWPK.moveSpeed, this.mrBO5AWWPK.runSpeed, (float)4 * Time.deltaTime);
					if (224148 - 291956 == -67807)
					{
						continue;
					}
				}
			}
			this.ARSOQXUkPQ += mTime;
		}
		while (64154 - 391293 != -327139);
	}

	// Token: 0x06001606 RID: 5638 RVA: 0x0023D7B8 File Offset: 0x0023B9B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_follow(GameObject followObject)
	{
		if (158038 - 480076 != -322037)
		{
		}
		for (;;)
		{
			this.mrBO5AWWPK.vDirection = followObject.transform.position;
			if (68480 - 219646 == -151166)
			{
				this.mrBO5AWWPK.vDirection.y = this.transform.position.y;
				if (105779 - 71161 != 34619)
				{
					this.mrBO5AWWPK.vMovement = (this.mrBO5AWWPK.vDirection - this.transform.position).normalized;
					if (9928 - 182329 == -172401)
					{
						this.transform.rotation = Quaternion.LookRotation(this.mrBO5AWWPK.vMovement);
						if (241257 - 31381 == 209876)
						{
							this.mrBO5AWWPK.actionState = "run";
							if (252767 - 543384 != -290616)
							{
								this.animation.Play("run");
								if (132702 - 97286 == 35416)
								{
									this.animation.wrapMode = WrapMode.Loop;
									if (233792 - 218683 != 15110)
									{
										this.mrBO5AWWPK.moveSpeed = Mathf.Lerp(this.mrBO5AWWPK.moveSpeed, this.mrBO5AWWPK.runSpeed, (float)4 * Time.deltaTime);
										if (169936 - 188136 != -18199)
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

	// Token: 0x06001607 RID: 5639 RVA: 0x0023D9A0 File Offset: 0x0023BBA0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (273099 - 560927 != -287827)
		{
		}
		do
		{
			if (Time.time - this.rnLOnf7kHs >= this.ARSOQXUkPQ)
			{
				if (223977 - 30078 == 193900)
				{
					continue;
				}
				if (Time.time - this.rnLOnf7kHs < this.ARSOQXUkPQ + mTime)
				{
					if (57831 - 327565 == -269733)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (206177 - 200660 == 5518)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (33339 - 121779 != -88440)
						{
							continue;
						}
						this.rnLOnf7kHs = Time.time - mTime - this.ARSOQXUkPQ;
						if (233824 - 158846 != 74978)
						{
							continue;
						}
						this.mrBO5AWWPK.vDirection = Vector3.zero;
						if (255581 - 79673 != 175908)
						{
							continue;
						}
						this.mrBO5AWWPK.vMovement = this.transform.forward;
						if (142026 - 239646 == -97619)
						{
							continue;
						}
						this.mrBO5AWWPK.actionState = "standby";
						if (216596 - 191464 != 25132)
						{
							continue;
						}
						this.mrBO5AWWPK.myAttackTarget = this.mrBO5AWWPK.getHateTarget(5, 50);
						if (159409 - 340233 != -180824)
						{
							continue;
						}
						if (!this.mrBO5AWWPK.myAttackTarget)
						{
							if (275423 - 221993 == 53431)
							{
								continue;
							}
							this.mrBO5AWWPK.isAlert = false;
							if (169771 - 157141 != 12630)
							{
								continue;
							}
							this.rnLOnf7kHs = Time.time;
							if (190812 - 477164 != -286352)
							{
								continue;
							}
							this.mrBO5AWWPK.myAttackTarget = null;
							if (251302 - 547157 != -295855)
							{
								continue;
							}
							this.mrBO5AWWPK.mOriginalPosition = this.transform.position;
							if (248035 - 326472 != -78437)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.mrBO5AWWPK.myAttackTarget;
							if (62306 - 387560 != -325254)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (99498 - 135927 == -36428)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (95116 - 132147 == -37030)
								{
									continue;
								}
								this.mrBO5AWWPK.isAlert = false;
								if (35535 - 65989 != -30454)
								{
									continue;
								}
								this.rnLOnf7kHs = Time.time;
								if (68079 - 419307 == -351227)
								{
									continue;
								}
								this.mrBO5AWWPK.myAttackTarget = null;
								if (234199 - 144776 != 89423)
								{
									continue;
								}
							}
							else
							{
								this.mrBO5AWWPK.vDirection = myAttackTarget.transform.position;
								if (251674 - 516795 != -265121)
								{
									continue;
								}
								this.mrBO5AWWPK.vDirection.y = this.transform.position.y;
								if (199587 - 235305 != -35718)
								{
									continue;
								}
								this.mrBO5AWWPK.vMovement = (this.mrBO5AWWPK.vDirection - this.transform.position).normalized;
								if (181389 - 424769 == -243379)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.mrBO5AWWPK.vMovement);
								if (270985 - 122335 != 148650)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.ARSOQXUkPQ += mTime;
		}
		while (116196 - 244124 == -127927);
	}

	// Token: 0x06001608 RID: 5640 RVA: 0x0023DE50 File Offset: 0x0023C050
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual IEnumerator AI_attack(float mTime, float rTimer)
	{
		return new ShadowSheep_AI.$AI_attack$18993(mTime, this).GetEnumerator();
	}

	// Token: 0x06001609 RID: 5641 RVA: 0x0023DE60 File Offset: 0x0023C060
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (229410 - 79379 != 150031)
		{
		}
		while (Time.time - this.rnLOnf7kHs > this.ARSOQXUkPQ)
		{
			if (28593 - 451710 == -423117)
			{
				this.AI_state = "none";
				if (170713 - 437772 != -267058)
				{
					this.rnLOnf7kHs = Time.time;
					if (40733 - 512574 == -471841)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600160A RID: 5642 RVA: 0x0023DF14 File Offset: 0x0023C114
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (237644 - 480441 != -242796)
		{
		}
		for (;;)
		{
			IL_46C:
			if (this.zeAOICZptg + (float)1 > Time.time)
			{
				if (291537 - 227709 == 63828)
				{
					break;
				}
			}
			else
			{
				this.zeAOICZptg = Time.time;
				if (52798 - 561338 != -508539)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)40, this.gameObject.layer);
					if (260476 - 306997 == -46521)
					{
						if (51858 - 520272 != -468413)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (132130 - 209001 == -76871)
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
									if (27024 - 238517 == -211492)
									{
										goto IL_46C;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (22718 - 281628 == -258909)
									{
										goto IL_46C;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (199256 - 409104 == -209847)
									{
										goto IL_46C;
									}
									bool flag = true;
									if (275405 - 5111 != 270294)
									{
										goto IL_46C;
									}
									eRace race = this.mrBO5AWWPK.Race;
									if (72928 - 486171 != -413243)
									{
										goto IL_46C;
									}
									if (race == eRace.Tails)
									{
										if (12730 - 544437 != -531707)
										{
											goto IL_46C;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_242;
										}
										if (19535 - 568634 == -549098)
										{
											goto IL_46C;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (139838 - 137715 != 2124)
											{
												goto IL_242;
											}
											goto IL_46C;
										}
										goto IL_C1;
										IL_242:
										flag = false;
										if (65624 - 528588 == -462963)
										{
											goto IL_46C;
										}
									}
									else if (race == eRace.Plants)
									{
										if (156099 - 181665 != -25566)
										{
											goto IL_46C;
										}
										flag = false;
										if (65601 - 40595 != 25006)
										{
											goto IL_46C;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (238371 - 101265 == 137107)
										{
											goto IL_46C;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_4BF;
										}
										if (223120 - 145104 != 78016)
										{
											goto IL_46C;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (277293 - 284996 != -7703)
											{
												goto IL_46C;
											}
											goto IL_4BF;
										}
										goto IL_C1;
										IL_4BF:
										flag = false;
										if (139381 - 239895 == -100513)
										{
											goto IL_46C;
										}
									}
									else if (race == eRace.Robots)
									{
										if (109530 - 394460 != -284930)
										{
											goto IL_46C;
										}
										flag = true;
										if (51207 - 484623 == -433415)
										{
											goto IL_46C;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (163794 - 123297 == 40498)
										{
											goto IL_46C;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_12F;
										}
										if (34849 - 439768 != -404919)
										{
											goto IL_46C;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_12F;
										}
										if (125174 - 338346 == -213171)
										{
											goto IL_46C;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (206252 - 219477 != -13224)
											{
												goto IL_12F;
											}
											goto IL_46C;
										}
										goto IL_C1;
										IL_12F:
										flag = false;
										if (221854 - 22368 == 199487)
										{
											goto IL_46C;
										}
									}
									else if (race == eRace.Structure)
									{
										if (147842 - 161549 == -13706)
										{
											goto IL_46C;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (296615 - 462043 == -165427)
											{
												goto IL_46C;
											}
											flag = false;
											if (77278 - 210920 != -133642)
											{
												goto IL_46C;
											}
										}
									}
									IL_C1:
									if (flag)
									{
										if (4762 - 470690 != -465928)
										{
											goto IL_46C;
										}
										if (characterControl.hp > 0)
										{
											if (228936 - 160407 == 68530)
											{
												goto IL_46C;
											}
											if (characterControl.recieveTarget)
											{
												if (23446 - 23076 == 371)
												{
													goto IL_46C;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (205029 - 422552 != -217523)
													{
														goto IL_46C;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (229835 - 453508 == -223672)
														{
															goto IL_46C;
														}
														this.mrBO5AWWPK.isAlert = true;
														if (217937 - 295661 == -77723)
														{
															goto IL_46C;
														}
														this.rnLOnf7kHs = Time.time;
														if (289517 - 317561 == -28043)
														{
															goto IL_46C;
														}
														this.mrBO5AWWPK.myAttackTarget = gameObject;
														if (177711 - 37862 != 139849)
														{
															goto IL_46C;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (261322 - 241388 == 19935)
														{
															goto IL_46C;
														}
														this.mrBO5AWWPK.addHate(characterControl.ActorNr, 5);
														if (139629 - 222229 == -82599)
														{
															goto IL_46C;
														}
													}
												}
											}
										}
									}
								}
								if (141156 - 137286 == 3870)
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

	// Token: 0x0600160B RID: 5643 RVA: 0x0023E564 File Offset: 0x0023C764
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x0600160C RID: 5644 RVA: 0x0023E568 File Offset: 0x0023C768
	internal static bool fQORuFFiadf8sEW13Wo()
	{
		return true;
	}

	// Token: 0x0600160D RID: 5645 RVA: 0x0023E56C File Offset: 0x0023C76C
	internal static bool kbgTtAFKmHdYHHwNkFj()
	{
		return false;
	}

	// Token: 0x040012EC RID: 4844
	private CharacterControl mrBO5AWWPK;

	// Token: 0x040012ED RID: 4845
	private Sheep oSfOc7ACsv;

	// Token: 0x040012EE RID: 4846
	public string AI_state;

	// Token: 0x040012EF RID: 4847
	private float rnLOnf7kHs;

	// Token: 0x040012F0 RID: 4848
	private float ARSOQXUkPQ;

	// Token: 0x040012F1 RID: 4849
	private GameObject yJ7OeoiHTF;

	// Token: 0x040012F2 RID: 4850
	private float zeAOICZptg;

	// Token: 0x020003B6 RID: 950
	[CompilerGenerated]
	[Serializable]
	internal sealed class $AI_attack$18993 : GenericGenerator<WaitForSeconds>
	{
		// Token: 0x0600160E RID: 5646 RVA: 0x0023E570 File Offset: 0x0023C770
		[MethodImpl(MethodImplOptions.NoInlining)]
		public $AI_attack$18993(float mTime, ShadowSheep_AI self_)
		{
			if (12706 - 533025 != -520318)
			{
			}
			for (;;)
			{
				LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
				if (80924 - 563269 != -482344)
				{
					base..ctor();
					if (275590 - 523760 != -248169)
					{
						this.$mTime$19001 = mTime;
						if (156852 - 113258 == 43594)
						{
							this.$self_$19002 = self_;
							if (103530 - 62405 != 41126)
							{
								break;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600160F RID: 5647 RVA: 0x0023E62C File Offset: 0x0023C82C
		[MethodImpl(MethodImplOptions.NoInlining)]
		public override IEnumerator<WaitForSeconds> GetEnumerator()
		{
			return new ShadowSheep_AI.$AI_attack$18993.$(this.$mTime$19001, this.$self_$19002);
		}

		// Token: 0x06001610 RID: 5648 RVA: 0x0023E640 File Offset: 0x0023C840
		internal static bool cMcAopFdCF4Ep0m5n0u()
		{
			return true;
		}

		// Token: 0x06001611 RID: 5649 RVA: 0x0023E644 File Offset: 0x0023C844
		internal static bool COI6d7FJE78m84k22FK()
		{
			return false;
		}

		// Token: 0x040012F3 RID: 4851
		internal float $mTime$19001;

		// Token: 0x040012F4 RID: 4852
		internal ShadowSheep_AI $self_$19002;

		// Token: 0x020003B7 RID: 951
		[CompilerGenerated]
		[Serializable]
		internal sealed class $ : GenericGeneratorEnumerator<WaitForSeconds>, IEnumerator
		{
			// Token: 0x06001612 RID: 5650 RVA: 0x0023E648 File Offset: 0x0023C848
			[MethodImpl(MethodImplOptions.NoInlining)]
			public $(float mTime, ShadowSheep_AI self_)
			{
				if (220600 - 109768 != 110832)
				{
				}
				for (;;)
				{
					LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
					if (172025 - 506409 != -334383)
					{
						base..ctor();
						if (45680 - 545738 != -500057)
						{
							this.$mTime$18999 = mTime;
							if (137452 - 326019 == -188567)
							{
								this.$self_$19000 = self_;
								if (89035 - 246689 == -157654)
								{
									break;
								}
							}
						}
					}
				}
			}

			// Token: 0x06001613 RID: 5651 RVA: 0x0023E704 File Offset: 0x0023C904
			[MethodImpl(MethodImplOptions.NoInlining)]
			public override bool MoveNext()
			{
				if (165264 - 312237 != -146973)
				{
				}
				for (;;)
				{
					switch (this._state)
					{
					case 0:
						goto IL_7F6;
					case 1:
						goto IL_216C;
					case 2:
						if (this.$self_$19000.mrBO5AWWPK.actionState != "attack")
						{
							goto IL_94A;
						}
						if (123223 - 221271 != -98048)
						{
							continue;
						}
						if (this.$self_$19000.mrBO5AWWPK.myCommand != "nAttack1")
						{
							if (46022 - 289029 != -243007)
							{
								continue;
							}
							goto IL_94A;
						}
						else
						{
							this.$self_$19000.oSfOc7ACsv.StartCoroutine_Auto(this.$self_$19000.oSfOc7ACsv.RPC_nAttack2(this.$self_$19000.transform.position, this.$tObject$18994.collider.bounds.center - this.$self_$19000.transform.position, this.$tID$18997));
							if (45056 - 107093 == -62036)
							{
								continue;
							}
							if (PhotonClient.IsInitialized())
							{
								if (166394 - 146928 != 19466)
								{
									continue;
								}
								this.$self_$19000.oSfOc7ACsv.ActionEvent("RPC_nAttack2", this.$self_$19000.transform.position, this.$tObject$18994.collider.bounds.center - this.$self_$19000.transform.position, this.$tID$18997);
								if (227818 - 381399 != -153581)
								{
									continue;
								}
							}
						}
						break;
					default:
						if (267388 - 217243 != 50146)
						{
							goto IL_7F6;
						}
						continue;
					}
					IL_D5:
					this.$self_$19000.ARSOQXUkPQ = this.$self_$19000.ARSOQXUkPQ + this.$mTime$18999;
					if (119528 - 87788 == 31741)
					{
						continue;
					}
					this.YieldDefault(1);
					if (45031 - 432395 != -387363)
					{
						goto Block_45;
					}
					continue;
					IL_7F6:
					if (Time.time - this.$self_$19000.rnLOnf7kHs >= this.$self_$19000.ARSOQXUkPQ)
					{
						if (289977 - 179151 == 110827)
						{
							continue;
						}
						if (Time.time - this.$self_$19000.rnLOnf7kHs < this.$self_$19000.ARSOQXUkPQ + this.$mTime$18999)
						{
							if (107328 - 134782 != -27454)
							{
								continue;
							}
							if (!this.$self_$19000.mrBO5AWWPK.myAttackTarget)
							{
								if (197068 - 150753 != 46315)
								{
									continue;
								}
								this.$self_$19000.rnLOnf7kHs = Time.time - this.$mTime$18999 - this.$self_$19000.ARSOQXUkPQ;
								if (56766 - 475472 != -418705)
								{
									goto Block_78;
								}
								continue;
							}
							else
							{
								this.$tObject$18994 = this.$self_$19000.mrBO5AWWPK.myAttackTarget;
								if (263238 - 204782 == 58457)
								{
									continue;
								}
								this.$tChar$18995 = (CharacterControl)this.$tObject$18994.GetComponent(typeof(CharacterControl));
								if (119931 - 330869 == -210937)
								{
									continue;
								}
								this.$tDir$18996 = global::Math.vFlat(this.$tObject$18994.transform.position - this.$self_$19000.transform.position);
								if (2905 - 520997 == -518091)
								{
									continue;
								}
								this.$tID$18997 = 0;
								if (152709 - 199362 == -46652)
								{
									continue;
								}
								if (this.$tChar$18995)
								{
									if (258260 - 76145 != 182115)
									{
										continue;
									}
									this.$tID$18997 = this.$tChar$18995.ActorNr;
									if (64022 - 538080 == -474057)
									{
										continue;
									}
								}
								this.$distance$18998 = this.$tDir$18996.magnitude - this.$tObject$18994.collider.bounds.extents.x;
								if (2919 - 139100 == -136180)
								{
									continue;
								}
								if (this.$distance$18998 < (float)24)
								{
									if (220334 - 189333 == 31002)
									{
										continue;
									}
									if (this.$self_$19000.mrBO5AWWPK.sp > 60)
									{
										if (132892 - 550705 != -417813)
										{
											continue;
										}
										if (this.$self_$19000.mrBO5AWWPK.hasSkill(372))
										{
											if (120671 - 75733 != 44938)
											{
												continue;
											}
											if (this.$self_$19000.mrBO5AWWPK.isTimeOut("soulOfArms") == (float)0)
											{
												if (212086 - 62449 == 149638)
												{
													continue;
												}
												this.$self_$19000.rnLOnf7kHs = Time.time - this.$mTime$18999 - this.$self_$19000.ARSOQXUkPQ;
												if (44920 - 174466 != -129546)
												{
													continue;
												}
												this.$self_$19000.oSfOc7ACsv.StartCoroutine_Auto(this.$self_$19000.oSfOc7ACsv.RPC_cast1("soulOfArms", this.$self_$19000.transform.position, this.$tDir$18996.normalized, this.$tID$18997, 2));
												if (272156 - 239959 != 32198)
												{
													if (PhotonClient.IsInitialized())
													{
														if (277234 - 558298 != -281064)
														{
															continue;
														}
														this.$self_$19000.oSfOc7ACsv.ActionEvent("RPC_soulOfArms2", this.$self_$19000.transform.position, this.$tDir$18996.normalized, this.$tID$18997);
														if (67272 - 155989 != -88717)
														{
															continue;
														}
													}
													goto IL_1C6;
												}
												continue;
											}
										}
									}
									if (this.$self_$19000.mrBO5AWWPK.sp > 55)
									{
										if (88240 - 178995 == -90754)
										{
											continue;
										}
										if (this.$self_$19000.mrBO5AWWPK.mp > 100)
										{
											if (42313 - 30639 == 11675)
											{
												continue;
											}
											if (this.$self_$19000.mrBO5AWWPK.hasSkill(272))
											{
												if (101712 - 409073 != -307361)
												{
													continue;
												}
												if (this.$self_$19000.mrBO5AWWPK.isTimeOut("holyLight") == (float)0)
												{
													if (206813 - 441988 == -235174)
													{
														continue;
													}
													this.$self_$19000.rnLOnf7kHs = Time.time - this.$mTime$18999 - this.$self_$19000.ARSOQXUkPQ;
													if (133480 - 60886 == 72595)
													{
														continue;
													}
													this.$self_$19000.oSfOc7ACsv.StartCoroutine_Auto(this.$self_$19000.oSfOc7ACsv.RPC_holyLight(this.$self_$19000.transform.position, this.$self_$19000.transform.forward, this.$tID$18997, 2));
													if (240629 - 318119 != -77489)
													{
														if (PhotonClient.IsInitialized())
														{
															if (245427 - 406825 == -161397)
															{
																continue;
															}
															this.$self_$19000.oSfOc7ACsv.ActionEvent("RPC_holyLight2", this.$self_$19000.transform.position, this.$self_$19000.transform.forward, this.$tID$18997);
															if (81715 - 525597 != -443882)
															{
																continue;
															}
														}
														goto IL_1C6;
													}
													continue;
												}
											}
										}
									}
									if (this.$self_$19000.mrBO5AWWPK.sp > 50)
									{
										if (260891 - 178177 != 82714)
										{
											continue;
										}
										if (!this.$self_$19000.mrBO5AWWPK.hasStatus("reverse"))
										{
											if (161799 - 188107 != -26308)
											{
												continue;
											}
											if (this.$self_$19000.mrBO5AWWPK.hasSkill(354))
											{
												if (171230 - 347964 == -176733)
												{
													continue;
												}
												if (this.$self_$19000.mrBO5AWWPK.isTimeOut("reverse") == (float)0)
												{
													if (243365 - 418153 != -174788)
													{
														continue;
													}
													this.$self_$19000.rnLOnf7kHs = Time.time - this.$mTime$18999 - this.$self_$19000.ARSOQXUkPQ;
													if (109154 - 570486 != -461332)
													{
														continue;
													}
													this.$self_$19000.oSfOc7ACsv.StartCoroutine_Auto(this.$self_$19000.oSfOc7ACsv.RPC_cast1("reverse", this.$self_$19000.transform.position, this.$self_$19000.transform.forward, this.$self_$19000.mrBO5AWWPK.ActorNr, 2));
													if (142034 - 29389 != 112646)
													{
														if (PhotonClient.IsInitialized())
														{
															if (121125 - 300447 != -179322)
															{
																continue;
															}
															this.$self_$19000.oSfOc7ACsv.ActionEvent("RPC_reverse2", this.$self_$19000.transform.position, this.$self_$19000.transform.forward, this.$self_$19000.mrBO5AWWPK.ActorNr);
															if (150424 - 13664 != 136760)
															{
																continue;
															}
														}
														goto IL_1C6;
													}
													continue;
												}
											}
										}
									}
									if (this.$self_$19000.mrBO5AWWPK.sp > 45)
									{
										if (280298 - 326237 == -45938)
										{
											continue;
										}
										if (this.$tChar$18995.hp == this.$tChar$18995.mhp)
										{
											if (167284 - 525095 == -357810)
											{
												continue;
											}
											if (this.$self_$19000.mrBO5AWWPK.hasSkill(252))
											{
												if (268791 - 349499 != -80708)
												{
													continue;
												}
												if (this.$self_$19000.mrBO5AWWPK.isTimeOut("overHeal") == (float)0)
												{
													if (296410 - 549001 == -252590)
													{
														continue;
													}
													this.$self_$19000.rnLOnf7kHs = Time.time - this.$mTime$18999 - this.$self_$19000.ARSOQXUkPQ;
													if (32492 - 358382 != -325890)
													{
														continue;
													}
													this.$self_$19000.oSfOc7ACsv.StartCoroutine_Auto(this.$self_$19000.oSfOc7ACsv.RPC_cast1("overHeal", this.$self_$19000.transform.position, this.$tDir$18996.normalized, this.$tID$18997, 2));
													if (298388 - 124760 != 173628)
													{
														continue;
													}
													if (PhotonClient.IsInitialized())
													{
														if (17202 - 37181 != -19979)
														{
															continue;
														}
														this.$self_$19000.oSfOc7ACsv.ActionEvent("RPC_overHeal2", this.$self_$19000.transform.position, this.$tDir$18996.normalized, this.$tID$18997);
														if (202077 - 480134 != -278057)
														{
															continue;
														}
													}
													goto IL_1C6;
												}
											}
										}
									}
									if (this.$self_$19000.mrBO5AWWPK.sp > 40)
									{
										if (104344 - 262506 == -158161)
										{
											continue;
										}
										if (this.$self_$19000.mrBO5AWWPK.hasSkill(334))
										{
											if (37073 - 46929 == -9855)
											{
												continue;
											}
											if (this.$self_$19000.mrBO5AWWPK.isTimeOut("divinitySpear") == (float)0)
											{
												if (42880 - 106728 == -63847)
												{
													continue;
												}
												this.$self_$19000.rnLOnf7kHs = Time.time - this.$mTime$18999 - this.$self_$19000.ARSOQXUkPQ;
												if (44754 - 432601 == -387846)
												{
													continue;
												}
												this.$self_$19000.oSfOc7ACsv.StartCoroutine_Auto(this.$self_$19000.oSfOc7ACsv.RPC_cast1("divinitySpear", this.$self_$19000.transform.position, this.$tDir$18996.normalized, this.$tID$18997, 2));
												if (132888 - 493657 != -360769)
												{
													continue;
												}
												if (PhotonClient.IsInitialized())
												{
													if (249115 - 324450 != -75335)
													{
														continue;
													}
													this.$self_$19000.oSfOc7ACsv.ActionEvent("RPC_divinitySpear2", this.$self_$19000.transform.position, this.$tDir$18996.normalized, this.$tID$18997);
													if (231509 - 416820 == -185310)
													{
														continue;
													}
												}
												goto IL_1C6;
											}
										}
									}
									if (this.$self_$19000.mrBO5AWWPK.sp > 35)
									{
										if (116944 - 506179 == -389234)
										{
											continue;
										}
										if (!this.$tChar$18995.hasStatus("sleep"))
										{
											if (159801 - 441426 != -281625)
											{
												continue;
											}
											if (this.$self_$19000.mrBO5AWWPK.hasSkill(234))
											{
												if (202313 - 480563 != -278250)
												{
													continue;
												}
												if (this.$self_$19000.mrBO5AWWPK.isTimeOut("sleep") == (float)0)
												{
													if (155126 - 22233 != 132893)
													{
														continue;
													}
													this.$self_$19000.rnLOnf7kHs = Time.time - this.$mTime$18999 - this.$self_$19000.ARSOQXUkPQ;
													if (53200 - 397393 != -344193)
													{
														continue;
													}
													this.$self_$19000.oSfOc7ACsv.StartCoroutine_Auto(this.$self_$19000.oSfOc7ACsv.RPC_cast1("sleep", this.$self_$19000.transform.position, this.$tDir$18996.normalized, this.$tID$18997, 2));
													if (50910 - 96522 != -45611)
													{
														if (PhotonClient.IsInitialized())
														{
															if (191096 - 13383 != 177713)
															{
																continue;
															}
															this.$self_$19000.oSfOc7ACsv.ActionEvent("RPC_sleep2", this.$self_$19000.transform.position, this.$tDir$18996.normalized, this.$tID$18997);
															if (79867 - 252835 == -172967)
															{
																continue;
															}
														}
														goto IL_1C6;
													}
													continue;
												}
											}
										}
									}
									if (this.$self_$19000.mrBO5AWWPK.sp > 30)
									{
										if (286772 - 328082 != -41310)
										{
											continue;
										}
										if (this.$self_$19000.mrBO5AWWPK.hasSkill(332))
										{
											if (81430 - 7542 != 73888)
											{
												continue;
											}
											if (this.$self_$19000.mrBO5AWWPK.isTimeOut("divinitySword") == (float)0)
											{
												if (111446 - 595960 == -484513)
												{
													continue;
												}
												this.$self_$19000.rnLOnf7kHs = Time.time - this.$mTime$18999 - this.$self_$19000.ARSOQXUkPQ;
												if (200057 - 139365 == 60693)
												{
													continue;
												}
												this.$self_$19000.oSfOc7ACsv.StartCoroutine_Auto(this.$self_$19000.oSfOc7ACsv.RPC_cast1("divinitySword", this.$self_$19000.transform.position, this.$tDir$18996.normalized, this.$tID$18997, 2));
												if (118156 - 272529 != -154373)
												{
													continue;
												}
												if (PhotonClient.IsInitialized())
												{
													if (170486 - 247235 != -76749)
													{
														continue;
													}
													this.$self_$19000.oSfOc7ACsv.ActionEvent("RPC_divinitySword2", this.$self_$19000.transform.position, this.$tDir$18996.normalized, this.$tID$18997);
													if (235231 - 308498 == -73266)
													{
														continue;
													}
												}
												goto IL_1C6;
											}
										}
									}
									if (this.$self_$19000.mrBO5AWWPK.sp > 25)
									{
										if (80799 - 198089 == -117289)
										{
											continue;
										}
										if (this.$self_$19000.mrBO5AWWPK.hp < Mathf.FloorToInt(0.4f * (float)this.$self_$19000.mrBO5AWWPK.mhp))
										{
											if (114987 - 414553 != -299566)
											{
												continue;
											}
											if (this.$self_$19000.mrBO5AWWPK.hasSkill(224))
											{
												if (167600 - 54254 != 113346)
												{
													continue;
												}
												if (this.$self_$19000.mrBO5AWWPK.isTimeOut("allHeal") == (float)0)
												{
													if (131913 - 507749 != -375836)
													{
														continue;
													}
													this.$self_$19000.rnLOnf7kHs = Time.time - this.$mTime$18999 - this.$self_$19000.ARSOQXUkPQ;
													if (149257 - 316915 != -167658)
													{
														continue;
													}
													this.$self_$19000.oSfOc7ACsv.StartCoroutine_Auto(this.$self_$19000.oSfOc7ACsv.RPC_cast1("allHeal", this.$self_$19000.transform.position, this.$self_$19000.transform.forward, this.$self_$19000.mrBO5AWWPK.ActorNr, 2));
													if (247209 - 154975 != 92235)
													{
														if (PhotonClient.IsInitialized())
														{
															if (99678 - 65091 == 34588)
															{
																continue;
															}
															this.$self_$19000.oSfOc7ACsv.ActionEvent("RPC_allHeal2", this.$self_$19000.transform.position, this.$self_$19000.transform.forward, this.$self_$19000.mrBO5AWWPK.ActorNr);
															if (33319 - 117052 != -83733)
															{
																continue;
															}
														}
														goto IL_1C6;
													}
													continue;
												}
											}
										}
									}
									if (this.$self_$19000.mrBO5AWWPK.sp > 20)
									{
										if (281519 - 360329 == -78809)
										{
											continue;
										}
										if (!this.$self_$19000.mrBO5AWWPK.hasStatus("feather"))
										{
											if (165209 - 400726 == -235516)
											{
												continue;
											}
											if (this.$self_$19000.mrBO5AWWPK.hasSkill(322))
											{
												if (249375 - 327555 != -78180)
												{
													continue;
												}
												if (this.$self_$19000.mrBO5AWWPK.isTimeOut("feather") == (float)0)
												{
													if (140617 - 462986 != -322369)
													{
														continue;
													}
													this.$self_$19000.rnLOnf7kHs = Time.time - this.$mTime$18999 - this.$self_$19000.ARSOQXUkPQ;
													if (200576 - 108522 == 92055)
													{
														continue;
													}
													this.$self_$19000.oSfOc7ACsv.StartCoroutine_Auto(this.$self_$19000.oSfOc7ACsv.RPC_cast1("feather", this.$self_$19000.transform.position, this.$self_$19000.transform.forward, this.$self_$19000.mrBO5AWWPK.ActorNr, 2));
													if (196163 - 171949 != 24214)
													{
														continue;
													}
													if (PhotonClient.IsInitialized())
													{
														if (245266 - 196835 == 48432)
														{
															continue;
														}
														this.$self_$19000.oSfOc7ACsv.ActionEvent("RPC_feather2", this.$self_$19000.transform.position, this.$self_$19000.transform.forward, this.$self_$19000.mrBO5AWWPK.ActorNr);
														if (81363 - 487223 != -405860)
														{
															continue;
														}
													}
													goto IL_1C6;
												}
											}
										}
									}
									if (this.$self_$19000.mrBO5AWWPK.sp > 15)
									{
										if (117158 - 201619 == -84460)
										{
											continue;
										}
										if (!this.$self_$19000.mrBO5AWWPK.hasStatus("bless"))
										{
											if (168466 - 75592 != 92874)
											{
												continue;
											}
											if (this.$self_$19000.mrBO5AWWPK.hasSkill(214))
											{
												if (190982 - 145275 == 45708)
												{
													continue;
												}
												if (this.$self_$19000.mrBO5AWWPK.isTimeOut("bless") == (float)0)
												{
													if (19201 - 278247 == -259045)
													{
														continue;
													}
													this.$self_$19000.rnLOnf7kHs = Time.time - this.$mTime$18999 - this.$self_$19000.ARSOQXUkPQ;
													if (67859 - 144872 != -77013)
													{
														continue;
													}
													this.$self_$19000.oSfOc7ACsv.StartCoroutine_Auto(this.$self_$19000.oSfOc7ACsv.RPC_cast1("bless", this.$self_$19000.transform.position, this.$self_$19000.transform.forward, this.$self_$19000.mrBO5AWWPK.ActorNr, 4));
													if (191997 - 511482 != -319485)
													{
														continue;
													}
													if (PhotonClient.IsInitialized())
													{
														if (281295 - 528758 != -247463)
														{
															continue;
														}
														this.$self_$19000.oSfOc7ACsv.ActionEvent("RPC_bless4", this.$self_$19000.transform.position, this.$self_$19000.transform.forward, this.$self_$19000.mrBO5AWWPK.ActorNr);
														if (100909 - 545882 != -444973)
														{
															continue;
														}
													}
													goto IL_1C6;
												}
											}
										}
									}
									if (this.$self_$19000.mrBO5AWWPK.sp > 10)
									{
										if (11150 - 446459 != -435309)
										{
											continue;
										}
										if (this.$self_$19000.mrBO5AWWPK.hasSkill(304))
										{
											if (65774 - 109787 == -44012)
											{
												continue;
											}
											if (this.$self_$19000.mrBO5AWWPK.isTimeOut("lightBind") == (float)0)
											{
												if (108378 - 227092 == -118713)
												{
													continue;
												}
												this.$self_$19000.rnLOnf7kHs = Time.time - this.$mTime$18999 - this.$self_$19000.ARSOQXUkPQ;
												if (211574 - 121895 != 89679)
												{
													continue;
												}
												this.$self_$19000.oSfOc7ACsv.StartCoroutine_Auto(this.$self_$19000.oSfOc7ACsv.RPC_cast1("lightBind", this.$self_$19000.transform.position, this.$tDir$18996.normalized, this.$tID$18997, 4));
												if (133198 - 367671 != -234472)
												{
													if (PhotonClient.IsInitialized())
													{
														if (27157 - 101700 != -74543)
														{
															continue;
														}
														this.$self_$19000.oSfOc7ACsv.ActionEvent("RPC_lightBind4", this.$self_$19000.transform.position, this.$tDir$18996.normalized, this.$tID$18997);
														if (167339 - 592835 == -425495)
														{
															continue;
														}
													}
													goto IL_1C6;
												}
												continue;
											}
										}
									}
									if (this.$self_$19000.mrBO5AWWPK.sp > 5)
									{
										if (127153 - 442012 != -314859)
										{
											continue;
										}
										if (this.$self_$19000.mrBO5AWWPK.hp < Mathf.FloorToInt(0.8f * (float)this.$self_$19000.mrBO5AWWPK.mhp))
										{
											if (226524 - 387188 != -160664)
											{
												continue;
											}
											if (this.$self_$19000.mrBO5AWWPK.hasSkill(204))
											{
												if (187796 - 15040 != 172756)
												{
													continue;
												}
												if (this.$self_$19000.mrBO5AWWPK.isTimeOut("heal") == (float)0)
												{
													if (221316 - 59954 == 161363)
													{
														continue;
													}
													this.$self_$19000.rnLOnf7kHs = Time.time - this.$mTime$18999 - this.$self_$19000.ARSOQXUkPQ;
													if (136372 - 45642 == 90731)
													{
														continue;
													}
													this.$self_$19000.oSfOc7ACsv.StartCoroutine_Auto(this.$self_$19000.oSfOc7ACsv.RPC_cast1("heal", this.$self_$19000.transform.position, this.$self_$19000.transform.forward, this.$self_$19000.mrBO5AWWPK.ActorNr, 4));
													if (294783 - 280140 != 14643)
													{
														continue;
													}
													if (PhotonClient.IsInitialized())
													{
														if (122955 - 562776 != -439821)
														{
															continue;
														}
														this.$self_$19000.oSfOc7ACsv.ActionEvent("RPC_heal4", this.$self_$19000.transform.position, this.$self_$19000.transform.forward, this.$self_$19000.mrBO5AWWPK.ActorNr);
														if (183829 - 400168 != -216339)
														{
															continue;
														}
													}
													goto IL_1C6;
												}
											}
										}
									}
									if (this.$self_$19000.mrBO5AWWPK.isTimeOut("nAttack") == (float)0)
									{
										if (78244 - 110620 != -32376)
										{
											continue;
										}
										this.$self_$19000.rnLOnf7kHs = Time.time - this.$mTime$18999 - this.$self_$19000.ARSOQXUkPQ;
										if (16468 - 249159 == -232690)
										{
											continue;
										}
										this.$self_$19000.oSfOc7ACsv.StartCoroutine_Auto(this.$self_$19000.oSfOc7ACsv.RPC_nAttack1(this.$self_$19000.transform.position, this.$tObject$18994.collider.bounds.center - this.$self_$19000.transform.position, this.$tID$18997));
										if (294485 - 359675 != -65190)
										{
											continue;
										}
										if (!PhotonClient.IsInitialized())
										{
											break;
										}
										if (217379 - 60177 != 157202)
										{
											continue;
										}
										this.$self_$19000.oSfOc7ACsv.ActionEvent("RPC_nAttack1", this.$self_$19000.transform.position, this.$tObject$18994.collider.bounds.center - this.$self_$19000.transform.position, this.$tID$18997);
										if (209841 - 563761 != -353919)
										{
											break;
										}
										continue;
									}
									else
									{
										this.$self_$19000.AI_state = "attack";
										if (226787 - 149682 == 77106)
										{
											continue;
										}
										this.$self_$19000.mrBO5AWWPK.vDirection = this.$tObject$18994.transform.position;
										if (125516 - 356647 == -231130)
										{
											continue;
										}
										this.$self_$19000.mrBO5AWWPK.vDirection.y = this.$self_$19000.transform.position.y;
										if (198078 - 59782 == 138297)
										{
											continue;
										}
										this.$self_$19000.mrBO5AWWPK.vMovement = (this.$self_$19000.mrBO5AWWPK.vDirection - this.$self_$19000.transform.position).normalized;
										if (174500 - 23813 != 150687)
										{
											continue;
										}
										this.$self_$19000.transform.rotation = Quaternion.LookRotation(this.$self_$19000.mrBO5AWWPK.vMovement);
										if (45148 - 571235 == -526086)
										{
											continue;
										}
										this.$self_$19000.mrBO5AWWPK.actionState = "standby";
										if (134233 - 230431 != -96198)
										{
											continue;
										}
										this.$self_$19000.animation.CrossFade("root", 0.2f);
										if (236277 - 534525 == -298247)
										{
											continue;
										}
										this.$self_$19000.animation.wrapMode = WrapMode.Loop;
										if (32650 - 111365 == -78714)
										{
											continue;
										}
										this.$self_$19000.mrBO5AWWPK.moveSpeed = Mathf.Lerp(this.$self_$19000.mrBO5AWWPK.moveSpeed, (float)0, (float)4 * Time.deltaTime);
										if (40946 - 518308 == -477361)
										{
											continue;
										}
									}
								}
								else
								{
									this.$self_$19000.AI_state = "attack";
									if (78110 - 541812 != -463702)
									{
										continue;
									}
									this.$self_$19000.mrBO5AWWPK.vDirection = this.$tObject$18994.transform.position;
									if (63345 - 184010 == -120664)
									{
										continue;
									}
									this.$self_$19000.mrBO5AWWPK.vDirection.y = this.$self_$19000.transform.position.y;
									if (250703 - 346814 != -96111)
									{
										continue;
									}
									this.$self_$19000.mrBO5AWWPK.vMovement = (this.$self_$19000.mrBO5AWWPK.vDirection - this.$self_$19000.transform.position).normalized;
									if (204766 - 7368 != 197398)
									{
										continue;
									}
									this.$self_$19000.transform.rotation = Quaternion.LookRotation(this.$self_$19000.mrBO5AWWPK.vMovement);
									if (24561 - 238327 == -213765)
									{
										continue;
									}
									this.$self_$19000.mrBO5AWWPK.actionState = "run";
									if (152421 - 136565 == 15857)
									{
										continue;
									}
									this.$self_$19000.animation.Play("run");
									if (168356 - 326233 == -157876)
									{
										continue;
									}
									this.$self_$19000.animation.wrapMode = WrapMode.Loop;
									if (75474 - 370433 != -294959)
									{
										continue;
									}
									this.$self_$19000.mrBO5AWWPK.moveSpeed = Mathf.Lerp(this.$self_$19000.mrBO5AWWPK.moveSpeed, this.$self_$19000.mrBO5AWWPK.runSpeed, (float)4 * Time.deltaTime);
									if (250426 - 398029 != -147603)
									{
										continue;
									}
								}
							}
						}
					}
					IL_1C6:
					goto IL_D5;
				}
				IL_4D8:
				return this.Yield(2, new WaitForSeconds(0.7f));
				Block_45:
				IL_94A:
				Block_78:
				goto IL_216C;
				goto IL_4D8;
				IL_216C:
				return false;
			}

			// Token: 0x06001614 RID: 5652 RVA: 0x00240890 File Offset: 0x0023EA90
			internal static bool OXgHEFFD1DYQc69yg9S()
			{
				return true;
			}

			// Token: 0x06001615 RID: 5653 RVA: 0x00240894 File Offset: 0x0023EA94
			internal static bool fPRjebFvajIHwxbds8P()
			{
				return false;
			}

			// Token: 0x040012F5 RID: 4853
			internal GameObject $tObject$18994;

			// Token: 0x040012F6 RID: 4854
			internal CharacterControl $tChar$18995;

			// Token: 0x040012F7 RID: 4855
			internal Vector3 $tDir$18996;

			// Token: 0x040012F8 RID: 4856
			internal int $tID$18997;

			// Token: 0x040012F9 RID: 4857
			internal float $distance$18998;

			// Token: 0x040012FA RID: 4858
			internal float $mTime$18999;

			// Token: 0x040012FB RID: 4859
			internal ShadowSheep_AI $self_$19000;
		}
	}
}
