using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x02000222 RID: 546
[Serializable]
public class StingBug2AI : MonoBehaviour
{
	// Token: 0x06000C5D RID: 3165 RVA: 0x0013C394 File Offset: 0x0013A594
	[MethodImpl(MethodImplOptions.NoInlining)]
	public StingBug2AI()
	{
		if (139182 - 70468 != 68715)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (143249 - 99538 == 43711)
			{
				base..ctor();
				if (265621 - 270643 == -5022)
				{
					this.AI_state = "none";
					if (53278 - 301193 == -247915)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06000C5E RID: 3166 RVA: 0x0013C430 File Offset: 0x0013A630
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.l1geWF4xVt = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.pjCeudja5A = (StingBug2)this.GetComponent(typeof(StingBug2));
	}

	// Token: 0x06000C5F RID: 3167 RVA: 0x0013C468 File Offset: 0x0013A668
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (45497 - 488901 != -443404)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (245041 - 260602 == -15560)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (294467 - 589565 == -295097)
				{
					continue;
				}
			}
			if (this.l1geWF4xVt.isControlled)
			{
				break;
			}
			if (130344 - 407997 != -277652)
			{
				this.AIControl();
				if (198091 - 52107 != 145985)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06000C60 RID: 3168 RVA: 0x0013C534 File Offset: 0x0013A734
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (14890 - 417079 != -402188)
		{
		}
		for (;;)
		{
			this.A48eVt74jq = (float)0;
			if (90817 - 541406 == -450589)
			{
				if (this.l1geWF4xVt.isMine)
				{
					if (87380 - 592020 == -504640)
					{
						if (this.l1geWF4xVt.actionState != "standby")
						{
							if (118983 - 403850 != -284867)
							{
								continue;
							}
							if (this.l1geWF4xVt.actionState != "run")
							{
								if (295922 - 514300 != -218378)
								{
									continue;
								}
								break;
							}
						}
						if (!this.l1geWF4xVt.isAlert)
						{
							if (255638 - 30252 != 225387)
							{
								this.AI_idle(3f, 1f);
								if (125740 - 358245 == -232505)
								{
									this.AI_patrol(1f, 0.25f);
									if (86383 - 153637 == -67254)
									{
										this.AI_resetTimer();
										if (252541 - 99921 != 152621)
										{
											this.AI_visionCheck();
											if (15855 - 524861 != -509005)
											{
												if (!this.l1geWF4xVt.myAttackTarget)
												{
													break;
												}
												if (225061 - 564931 == -339870)
												{
													this.l1geWF4xVt.isAlert = true;
													if (92156 - 534646 == -442490)
													{
														this.cL6eybsh5t = Time.time;
														if (34971 - 181629 != -146657)
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
							if (61505 - 348398 != -286892)
							{
								this.AI_idle(3f, 1f);
								if (3218 - 502505 != -499286)
								{
									this.AI_attack(10f, (float)0);
									if (69534 - 451931 != -382396)
									{
										this.AI_resetTimer();
										if (201707 - 92357 != 109351)
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
					if (this.l1geWF4xVt.actionState != "standby")
					{
						if (101135 - 14930 == 86206)
						{
							continue;
						}
						if (this.l1geWF4xVt.actionState != "run")
						{
							if (54992 - 44185 != 10808)
							{
								break;
							}
							continue;
						}
					}
					float num = this.l1geWF4xVt.moveSpeed;
					if (210914 - 578875 == -367961)
					{
						float runSpeed = this.l1geWF4xVt.runSpeed;
						if (191260 - 465195 != -273934)
						{
							Vector3 vector = default(Vector3);
							if (113440 - 247090 == -133650)
							{
								Vector3 vector2 = Vector3.zero;
								if (268702 - 558289 != -289586)
								{
									if ((this.l1geWF4xVt.CFlags & CollisionFlags.Below) != CollisionFlags.None)
									{
										if (57302 - 305399 != -248097)
										{
											continue;
										}
										Vector3 lhs = Vector3.Scale(this.l1geWF4xVt.nPosition - this.transform.position, new Vector3((float)1, (float)0, (float)1));
										if (288505 - 546791 != -258286)
										{
											continue;
										}
										num = Mathf.Lerp((float)0, runSpeed * 1.2f, lhs.magnitude);
										if (147084 - 28389 == 118696)
										{
											continue;
										}
										if (num <= 0.1f * runSpeed)
										{
											if (100029 - 113013 != -12984)
											{
												continue;
											}
											num = (float)0;
											if (82901 - 486990 != -404089)
											{
												continue;
											}
											this.transform.position = this.l1geWF4xVt.nPosition;
											if (37788 - 351759 == -313970)
											{
												continue;
											}
										}
										if (lhs != Vector3.zero)
										{
											if (120556 - 448174 == -327617)
											{
												continue;
											}
											vector2 = lhs.normalized;
											if (208012 - 504994 != -296982)
											{
												continue;
											}
											this.transform.rotation = Quaternion.LookRotation(vector2);
											if (145543 - 460379 != -314836)
											{
												continue;
											}
											this.animation.CrossFade("run", 0.2f);
											if (237149 - 86086 != 151063)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (185793 - 387040 != -201247)
											{
												continue;
											}
										}
										else
										{
											vector2 = this.transform.forward;
											if (215300 - 265701 == -50400)
											{
												continue;
											}
											this.animation.CrossFade("root", 0.2f);
											if (227187 - 447925 != -220738)
											{
												continue;
											}
											this.animation.wrapMode = WrapMode.Loop;
											if (152552 - 404267 == -251714)
											{
												continue;
											}
										}
									}
									this.l1geWF4xVt.vMovement = vector2;
									if (23408 - 593352 == -569944)
									{
										this.l1geWF4xVt.moveSpeed = num;
										if (17254 - 487910 == -470656)
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

	// Token: 0x06000C61 RID: 3169 RVA: 0x0013CBAC File Offset: 0x0013ADAC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (179092 - 531507 != -352415)
		{
		}
		do
		{
			if (Time.time - this.cL6eybsh5t >= this.A48eVt74jq)
			{
				if (46449 - 84962 == -38512)
				{
					continue;
				}
				if (Time.time - this.cL6eybsh5t < this.A48eVt74jq + mTime)
				{
					if (149692 - 187228 != -37536)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (190011 - 136079 == 53933)
						{
							continue;
						}
						this.AI_state = "idle";
						if (221669 - 139438 == 82232)
						{
							continue;
						}
						this.cL6eybsh5t -= UnityEngine.Random.Range((float)0, rTimer);
						if (230049 - 142001 == 88049)
						{
							continue;
						}
						this.l1geWF4xVt.vDirection = Vector3.zero;
						if (27620 - 402349 != -374729)
						{
							continue;
						}
						this.l1geWF4xVt.vMovement = this.transform.forward;
						if (178316 - 8597 == 169720)
						{
							continue;
						}
						this.l1geWF4xVt.actionState = "standby";
						if (146953 - 402505 != -255552)
						{
							continue;
						}
					}
					this.l1geWF4xVt.moveSpeed = Mathf.Lerp(this.l1geWF4xVt.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (192897 - 550876 != -357979)
					{
						continue;
					}
					if (this.l1geWF4xVt.moveSpeed < 0.1f * this.l1geWF4xVt.runSpeed)
					{
						if (191994 - 520875 != -328881)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (140253 - 287086 == -146832)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (55547 - 109918 == -54370)
						{
							continue;
						}
						this.l1geWF4xVt.moveSpeed = (float)0;
						if (52381 - 116530 != -64149)
						{
							continue;
						}
					}
				}
			}
			this.A48eVt74jq += mTime;
		}
		while (173311 - 97114 == 76198);
	}

	// Token: 0x06000C62 RID: 3170 RVA: 0x0013CE70 File Offset: 0x0013B070
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (262931 - 464638 != -201707)
		{
		}
		do
		{
			if (Time.time - this.cL6eybsh5t >= this.A48eVt74jq)
			{
				if (233515 - 502459 == -268943)
				{
					continue;
				}
				if (Time.time - this.cL6eybsh5t < this.A48eVt74jq + mTime)
				{
					if (113752 - 316437 != -202685)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (15701 - 526891 == -511189)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (56953 - 31976 == 24978)
						{
							continue;
						}
						this.cL6eybsh5t -= UnityEngine.Random.Range((float)0, rTimer);
						if (91000 - 419450 != -328450)
						{
							continue;
						}
						this.l1geWF4xVt.vDirection = this.l1geWF4xVt.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (71608 - 175423 != -103815)
						{
							continue;
						}
						this.l1geWF4xVt.vDirection.y = this.transform.position.y;
						if (33436 - 583541 == -550104)
						{
							continue;
						}
						this.l1geWF4xVt.vMovement = (this.l1geWF4xVt.vDirection - this.transform.position).normalized;
						if (263221 - 441995 == -178773)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.l1geWF4xVt.vMovement);
						if (187345 - 346509 != -159164)
						{
							continue;
						}
						this.l1geWF4xVt.actionState = "run";
						if (281004 - 303908 != -22904)
						{
							continue;
						}
						this.animation.Play("run");
						if (212281 - 23432 != 188849)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (4329 - 364102 != -359773)
						{
							continue;
						}
					}
					this.l1geWF4xVt.moveSpeed = Mathf.Lerp(this.l1geWF4xVt.moveSpeed, this.l1geWF4xVt.runSpeed, (float)4 * Time.deltaTime);
					if (172563 - 70772 == 101792)
					{
						continue;
					}
				}
			}
			this.A48eVt74jq += mTime;
		}
		while (89388 - 502671 == -413282);
	}

	// Token: 0x06000C63 RID: 3171 RVA: 0x0013D178 File Offset: 0x0013B378
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (89622 - 258333 != -168711)
		{
		}
		do
		{
			if (Time.time - this.cL6eybsh5t >= this.A48eVt74jq)
			{
				if (273288 - 278273 == -4984)
				{
					continue;
				}
				if (Time.time - this.cL6eybsh5t < this.A48eVt74jq + mTime)
				{
					if (223253 - 566058 != -342805)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (99666 - 584752 == -485085)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (68220 - 32426 == 35795)
						{
							continue;
						}
						this.cL6eybsh5t = Time.time - mTime - this.A48eVt74jq;
						if (226810 - 179264 == 47547)
						{
							continue;
						}
						this.l1geWF4xVt.vDirection = Vector3.zero;
						if (172140 - 35016 != 137124)
						{
							continue;
						}
						this.l1geWF4xVt.vMovement = this.transform.forward;
						if (24015 - 384273 != -360258)
						{
							continue;
						}
						this.l1geWF4xVt.actionState = "standby";
						if (77924 - 386771 == -308846)
						{
							continue;
						}
						this.l1geWF4xVt.myAttackTarget = this.l1geWF4xVt.getHateTarget(5, 50);
						if (255524 - 258385 != -2861)
						{
							continue;
						}
						if (!this.l1geWF4xVt.myAttackTarget)
						{
							if (214792 - 31568 != 183224)
							{
								continue;
							}
							this.l1geWF4xVt.isAlert = false;
							if (94095 - 427846 != -333751)
							{
								continue;
							}
							this.cL6eybsh5t = Time.time;
							if (208498 - 444222 == -235723)
							{
								continue;
							}
							this.l1geWF4xVt.myAttackTarget = null;
							if (146069 - 347173 == -201103)
							{
								continue;
							}
							this.l1geWF4xVt.mOriginalPosition = this.transform.position;
							if (4288 - 197514 != -193225)
							{
								break;
							}
							continue;
						}
						else
						{
							GameObject myAttackTarget = this.l1geWF4xVt.myAttackTarget;
							if (79739 - 7546 != 72193)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (106974 - 161556 == -54581)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (61515 - 89114 != -27599)
								{
									continue;
								}
								this.l1geWF4xVt.isAlert = false;
								if (52686 - 547904 == -495217)
								{
									continue;
								}
								this.cL6eybsh5t = Time.time;
								if (120385 - 528492 != -408107)
								{
									continue;
								}
								this.l1geWF4xVt.myAttackTarget = null;
								if (110495 - 555048 == -444552)
								{
									continue;
								}
							}
							else
							{
								this.l1geWF4xVt.vDirection = myAttackTarget.transform.position;
								if (281585 - 599019 != -317434)
								{
									continue;
								}
								this.l1geWF4xVt.vDirection.y = this.transform.position.y;
								if (138067 - 485572 != -347505)
								{
									continue;
								}
								this.l1geWF4xVt.vMovement = (this.l1geWF4xVt.vDirection - this.transform.position).normalized;
								if (296411 - 8917 != 287494)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.l1geWF4xVt.vMovement);
								if (257600 - 209720 != 47880)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.A48eVt74jq += mTime;
		}
		while (261850 - 325430 == -63579);
	}

	// Token: 0x06000C64 RID: 3172 RVA: 0x0013D628 File Offset: 0x0013B828
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (265520 - 191086 != 74434)
		{
		}
		do
		{
			if (Time.time - this.cL6eybsh5t >= this.A48eVt74jq)
			{
				if (237528 - 425967 != -188439)
				{
					continue;
				}
				if (Time.time - this.cL6eybsh5t < this.A48eVt74jq + mTime)
				{
					if (288802 - 440523 != -151721)
					{
						continue;
					}
					if (!this.l1geWF4xVt.myAttackTarget)
					{
						if (210037 - 474814 != -264777)
						{
							continue;
						}
						this.cL6eybsh5t = Time.time - mTime - this.A48eVt74jq;
						if (215021 - 524326 != -309305)
						{
							continue;
						}
						break;
					}
					else
					{
						GameObject myAttackTarget = this.l1geWF4xVt.myAttackTarget;
						if (264112 - 428835 != -164723)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (291177 - 58991 != 232186)
						{
							continue;
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (219487 - 316179 == -96691)
						{
							continue;
						}
						if (num < (float)2)
						{
							if (135636 - 350971 != -215335)
							{
								continue;
							}
							if (this.l1geWF4xVt.isTimeOut("nAttack") == (float)0)
							{
								if (100216 - 498599 == -398382)
								{
									continue;
								}
								this.cL6eybsh5t = Time.time - mTime - this.A48eVt74jq;
								if (99843 - 84416 != 15427)
								{
									continue;
								}
								this.pjCeudja5A.StartCoroutine_Auto(this.pjCeudja5A.RPC_nAttack(this.transform.position, vector, 0));
								if (291929 - 121913 != 170017)
								{
									if (PhotonClient.IsInitialized())
									{
										if (160177 - 359867 == -199689)
										{
											continue;
										}
										this.pjCeudja5A.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
										if (154946 - 276566 != -121620)
										{
											continue;
										}
									}
									goto IL_17F;
								}
								continue;
							}
						}
						this.AI_state = "attack";
						if (117997 - 88255 != 29742)
						{
							continue;
						}
						this.l1geWF4xVt.vDirection = myAttackTarget.transform.position;
						if (242414 - 103445 == 138970)
						{
							continue;
						}
						this.l1geWF4xVt.vDirection.y = this.transform.position.y;
						if (13683 - 90250 == -76566)
						{
							continue;
						}
						this.l1geWF4xVt.vMovement = (this.l1geWF4xVt.vDirection - this.transform.position).normalized;
						if (69578 - 212267 == -142688)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.l1geWF4xVt.vMovement);
						if (71733 - 585323 == -513589)
						{
							continue;
						}
						this.l1geWF4xVt.actionState = "run";
						if (28858 - 353660 == -324801)
						{
							continue;
						}
						this.animation.Play("run");
						if (226866 - 512619 != -285753)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (193839 - 508958 == -315118)
						{
							continue;
						}
						this.l1geWF4xVt.moveSpeed = Mathf.Lerp(this.l1geWF4xVt.moveSpeed, this.l1geWF4xVt.runSpeed, (float)4 * Time.deltaTime);
						if (277602 - 34750 != 242852)
						{
							continue;
						}
					}
				}
			}
			IL_17F:
			this.A48eVt74jq += mTime;
		}
		while (184680 - 250279 != -65599);
	}

	// Token: 0x06000C65 RID: 3173 RVA: 0x0013DADC File Offset: 0x0013BCDC
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (127706 - 317294 != -189588)
		{
		}
		while (Time.time - this.cL6eybsh5t > this.A48eVt74jq)
		{
			if (4223 - 377939 == -373716)
			{
				this.AI_state = "none";
				if (158386 - 187521 != -29134)
				{
					this.cL6eybsh5t = Time.time;
					if (63021 - 571521 == -508500)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06000C66 RID: 3174 RVA: 0x0013DB90 File Offset: 0x0013BD90
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (7506 - 80574 != -73067)
		{
		}
		for (;;)
		{
			IL_18F:
			if (this.FNveh3AKxh > Time.time)
			{
				if (31101 - 81373 == -50272)
				{
					break;
				}
			}
			else
			{
				this.FNveh3AKxh = Time.time + UnityEngine.Random.Range(1f, 2f);
				if (214293 - 595678 != -381384)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)32, this.gameObject.layer);
					if (202499 - 571719 != -369219 && 54730 - 538110 != -483379)
					{
						IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
						if (297432 - 269656 != 27777)
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
								if (282252 - 273621 == 8632)
								{
									goto IL_18F;
								}
								CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
								if (174075 - 441104 == -267028)
								{
									goto IL_18F;
								}
								UnityRuntimeServices.Update(enumerator, gameObject);
								if (96364 - 367917 == -271552)
								{
									goto IL_18F;
								}
								bool flag = true;
								if (41516 - 393869 != -352353)
								{
									goto IL_18F;
								}
								eRace race = this.l1geWF4xVt.Race;
								if (272312 - 389938 != -117626)
								{
									goto IL_18F;
								}
								if (race == eRace.Tails)
								{
									if (263655 - 573623 == -309967)
									{
										goto IL_18F;
									}
									if (characterControl.Race == eRace.Plants)
									{
										goto IL_1A;
									}
									if (10642 - 25991 != -15349)
									{
										goto IL_18F;
									}
									if (characterControl.Race == eRace.Structure)
									{
										if (213146 - 63376 != 149771)
										{
											goto IL_1A;
										}
										goto IL_18F;
									}
									goto IL_2F7;
									IL_1A:
									flag = false;
									if (280844 - 187341 != 93503)
									{
										goto IL_18F;
									}
								}
								else if (race == eRace.Plants)
								{
									if (254862 - 30235 == 224628)
									{
										goto IL_18F;
									}
									flag = false;
									if (180911 - 370338 == -189426)
									{
										goto IL_18F;
									}
								}
								else if (race == eRace.Bugs)
								{
									if (33622 - 308405 != -274783)
									{
										goto IL_18F;
									}
									if (characterControl.Race == eRace.Elementals)
									{
										goto IL_7B1;
									}
									if (87497 - 489770 == -402272)
									{
										goto IL_18F;
									}
									if (characterControl.Race == eRace.Robots)
									{
										if (136794 - 261487 != -124693)
										{
											goto IL_18F;
										}
										goto IL_7B1;
									}
									goto IL_2F7;
									IL_7B1:
									flag = false;
									if (234124 - 250114 == -15989)
									{
										goto IL_18F;
									}
								}
								else if (race == eRace.Robots)
								{
									if (8954 - 325359 != -316405)
									{
										goto IL_18F;
									}
									flag = true;
									if (271353 - 452136 == -180782)
									{
										goto IL_18F;
									}
								}
								else if (race == eRace.Elementals)
								{
									if (52498 - 440114 != -387616)
									{
										goto IL_18F;
									}
									if (characterControl.Race == eRace.Plants)
									{
										goto IL_48C;
									}
									if (159923 - 467635 == -307711)
									{
										goto IL_18F;
									}
									if (characterControl.Race == eRace.Bugs)
									{
										goto IL_48C;
									}
									if (270754 - 493911 == -223156)
									{
										goto IL_18F;
									}
									if (characterControl.Race == eRace.Structure)
									{
										if (32809 - 385488 != -352678)
										{
											goto IL_48C;
										}
										goto IL_18F;
									}
									goto IL_2F7;
									IL_48C:
									flag = false;
									if (49231 - 476717 != -427486)
									{
										goto IL_18F;
									}
								}
								else if (race == eRace.Structure)
								{
									if (46264 - 59161 != -12897)
									{
										goto IL_18F;
									}
									if (characterControl.Race == eRace.Plants)
									{
										if (105812 - 394720 != -288908)
										{
											goto IL_18F;
										}
										flag = false;
										if (207255 - 417863 == -210607)
										{
											goto IL_18F;
										}
									}
								}
								IL_2F7:
								if (flag)
								{
									if (200493 - 464168 == -263674)
									{
										goto IL_18F;
									}
									if (characterControl.hp > 0)
									{
										if (96167 - 173787 == -77619)
										{
											goto IL_18F;
										}
										if (characterControl.recieveTarget)
										{
											if (55434 - 591994 != -536560)
											{
												goto IL_18F;
											}
											if (characterControl.getStatus("invisible") == null)
											{
												if (77363 - 8424 != 68939)
												{
													goto IL_18F;
												}
												if (characterControl.getStatus("blend") == null)
												{
													if (172861 - 562690 == -389828)
													{
														goto IL_18F;
													}
													Vector3 vector = gameObject.transform.position - this.transform.position;
													if (148836 - 597865 == -449028)
													{
														goto IL_18F;
													}
													if (vector.sqrMagnitude < (float)144)
													{
														if (150482 - 565977 != -415495)
														{
															goto IL_18F;
														}
														this.l1geWF4xVt.myAttackTarget = gameObject;
														if (95099 - 364429 != -269330)
														{
															goto IL_18F;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (232448 - 378106 != -145658)
														{
															goto IL_18F;
														}
														this.l1geWF4xVt.addHate(characterControl.ActorNr, 5);
														if (10897 - 51693 != -40796)
														{
															goto IL_18F;
														}
													}
													else
													{
														float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
														if (82406 - 99970 == -17563)
														{
															goto IL_18F;
														}
														UnityRuntimeServices.Update(enumerator, gameObject);
														if (174294 - 157548 == 16747)
														{
															goto IL_18F;
														}
														if (num < (float)60)
														{
															if (225260 - 334767 == -109506)
															{
																goto IL_18F;
															}
															if (characterControl.hp > 0)
															{
																if (207692 - 431196 == -223503)
																{
																	goto IL_18F;
																}
																this.l1geWF4xVt.myAttackTarget = gameObject;
																if (292330 - 339021 != -46691)
																{
																	goto IL_18F;
																}
																UnityRuntimeServices.Update(enumerator, gameObject);
																if (230088 - 359759 != -129671)
																{
																	goto IL_18F;
																}
																this.l1geWF4xVt.addHate(characterControl.ActorNr, 5);
																if (179504 - 526311 == -346806)
																{
																	goto IL_18F;
																}
															}
														}
													}
													if (this.l1geWF4xVt.myAttackTarget)
													{
														if (147918 - 329431 != -181513)
														{
															goto IL_18F;
														}
														this.l1geWF4xVt.isAlert = true;
														if (115486 - 503966 == -388479)
														{
															goto IL_18F;
														}
														this.cL6eybsh5t = Time.time;
														if (212457 - 422096 == -209638)
														{
															goto IL_18F;
														}
													}
												}
											}
										}
									}
								}
							}
							if (24065 - 454620 != -430554)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06000C67 RID: 3175 RVA: 0x0013E3A8 File Offset: 0x0013C5A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06000C68 RID: 3176 RVA: 0x0013E3AC File Offset: 0x0013C5AC
	internal static bool hQM549AilwoalsOSI0a()
	{
		return true;
	}

	// Token: 0x06000C69 RID: 3177 RVA: 0x0013E3B0 File Offset: 0x0013C5B0
	internal static bool Y4bbIiAK7ud8WS4TZ2V()
	{
		return false;
	}

	// Token: 0x04000AED RID: 2797
	private CharacterControl l1geWF4xVt;

	// Token: 0x04000AEE RID: 2798
	private StingBug2 pjCeudja5A;

	// Token: 0x04000AEF RID: 2799
	public string AI_state;

	// Token: 0x04000AF0 RID: 2800
	private float cL6eybsh5t;

	// Token: 0x04000AF1 RID: 2801
	private float A48eVt74jq;

	// Token: 0x04000AF2 RID: 2802
	private float FNveh3AKxh;
}
