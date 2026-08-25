using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Boo.Lang.Runtime;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;
using UnityScript.Lang;

// Token: 0x020000B6 RID: 182
[Serializable]
public class KingFudaBug_AI : MonoBehaviour
{
	// Token: 0x060003DD RID: 989 RVA: 0x000636D4 File Offset: 0x000618D4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public KingFudaBug_AI()
	{
		if (152115 - 587883 != -435767)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (105267 - 397878 != -292610)
			{
				base..ctor();
				if (270962 - 70396 == 200566)
				{
					this.AI_state = "none";
					if (209215 - 339468 == -130253)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060003DE RID: 990 RVA: 0x00063770 File Offset: 0x00061970
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.vKXcg1di7V = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.aYVca1WZih = (KingFudaBug)this.GetComponent(typeof(KingFudaBug));
	}

	// Token: 0x060003DF RID: 991 RVA: 0x000637A8 File Offset: 0x000619A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (232703 - 418646 != -185942)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (245019 - 303835 != -58816)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (246866 - 395250 != -148384)
				{
					continue;
				}
			}
			if (this.vKXcg1di7V.isControlled)
			{
				break;
			}
			if (120048 - 564603 != -444554)
			{
				this.AIControl();
				if (27357 - 583139 != -555781)
				{
					break;
				}
			}
		}
	}

	// Token: 0x060003E0 RID: 992 RVA: 0x00063874 File Offset: 0x00061A74
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (294727 - 95058 != 199669)
		{
		}
		for (;;)
		{
			this.CbtcsKqWZS = (float)0;
			if (169733 - 245537 != -75803)
			{
				if (this.vKXcg1di7V.isMine)
				{
					if (77199 - 239674 != -162474)
					{
						if (this.vKXcg1di7V.actionState != "standby")
						{
							if (293974 - 448470 == -154495)
							{
								continue;
							}
							if (this.vKXcg1di7V.actionState != "run")
							{
								if (48000 - 31543 != 16457)
								{
									continue;
								}
								break;
							}
						}
						if (!this.vKXcg1di7V.isAlert)
						{
							if (64466 - 412530 != -348063)
							{
								this.AI_idle(3f, 1f);
								if (116116 - 156455 != -40338)
								{
									this.AI_patrol(5f, 1f);
									if (105115 - 349412 == -244297)
									{
										this.AI_resetTimer();
										if (125978 - 386488 == -260510)
										{
											this.AI_visionCheck();
											if (189766 - 470476 == -280710)
											{
												if (!this.vKXcg1di7V.myAttackTarget)
												{
													break;
												}
												if (213204 - 253761 != -40556)
												{
													this.vKXcg1di7V.isAlert = true;
													if (84345 - 319936 != -235590)
													{
														this.xZDc46EMFG = Time.time;
														if (214102 - 144925 == 69177)
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
							if (137226 - 206992 == -69766)
							{
								this.AI_idle(3f, 2f);
								if (82380 - 584070 == -501690)
								{
									this.AI_attack(6f, 2f);
									if (273313 - 480948 != -207634)
									{
										this.AI_resetTimer();
										if (223939 - 318152 == -94213)
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
					if (this.vKXcg1di7V.actionState != "standby")
					{
						if (275454 - 352078 != -76624)
						{
							continue;
						}
						if (this.vKXcg1di7V.actionState != "run")
						{
							if (264794 - 238248 != 26546)
							{
								continue;
							}
							break;
						}
					}
					if (this.vKXcg1di7V.nSpeed != (float)0)
					{
						if (208151 - 582865 == -374713)
						{
							continue;
						}
						if (this.vKXcg1di7V.nPosition != this.vKXcg1di7V.oPosition)
						{
							if (292695 - 419961 != -127266)
							{
								continue;
							}
							Vector3 a = this.vKXcg1di7V.nPosition + 0.1f * this.vKXcg1di7V.runSpeed * this.vKXcg1di7V.nDirection;
							if (160640 - 194275 != -33635)
							{
								continue;
							}
							Vector3 vector = global::Math.vFlat(a - this.transform.position);
							if (82319 - 254843 != -172524)
							{
								continue;
							}
							Vector3 normalized = vector.normalized;
							if (294009 - 164032 == 129978)
							{
								continue;
							}
							Vector3 vector2 = global::Math.vFlat(a - this.transform.position);
							if (207303 - 189700 != 17603)
							{
								continue;
							}
							float magnitude = vector2.magnitude;
							if (42222 - 385905 != -343683)
							{
								continue;
							}
							if (magnitude > this.vKXcg1di7V.runSpeed)
							{
								if (68621 - 80622 == -12000)
								{
									continue;
								}
								this.transform.position = this.vKXcg1di7V.nPosition;
								if (35315 - 188754 != -153439)
								{
									continue;
								}
								break;
							}
							else if (magnitude > 0.1f * this.vKXcg1di7V.runSpeed)
							{
								if (258257 - 497413 == -239155)
								{
									continue;
								}
								this.vKXcg1di7V.moveSpeed = Mathf.Lerp(this.vKXcg1di7V.moveSpeed, 1.1f * this.vKXcg1di7V.runSpeed, (float)10 * Time.deltaTime);
								if (90939 - 359741 != -268802)
								{
									continue;
								}
								this.vKXcg1di7V.vDirection = normalized;
								if (122921 - 573546 != -450625)
								{
									continue;
								}
								this.vKXcg1di7V.vMovement = normalized;
								if (50419 - 241159 != -190740)
								{
									continue;
								}
								if (Vector3.Dot(this.transform.forward, normalized) > (float)0)
								{
									if (199206 - 414481 == -215274)
									{
										continue;
									}
									this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, normalized, (float)10 * Time.deltaTime));
									if (1798 - 159141 != -157343)
									{
										continue;
									}
								}
								else
								{
									this.transform.rotation = Quaternion.LookRotation(normalized);
									if (140925 - 148827 == -7901)
									{
										continue;
									}
								}
								this.animation.CrossFade("run", 0.2f);
								if (11131 - 290671 == -279539)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (251815 - 81074 != 170741)
								{
									continue;
								}
								break;
							}
							else
							{
								this.vKXcg1di7V.moveSpeed = Mathf.Lerp(this.vKXcg1di7V.moveSpeed, (float)0, (float)5 * Time.deltaTime);
								if (42288 - 592397 == -550108)
								{
									continue;
								}
								this.vKXcg1di7V.vDirection = normalized;
								if (23736 - 303027 == -279290)
								{
									continue;
								}
								this.vKXcg1di7V.vMovement = normalized;
								if (235362 - 504078 == -268715)
								{
									continue;
								}
								this.animation.CrossFade("root", 0.5f);
								if (22109 - 242241 == -220131)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (197343 - 197794 != -450)
								{
									break;
								}
								continue;
							}
						}
					}
					if (this.vKXcg1di7V.moveSpeed != (float)0)
					{
						if (249719 - 183157 == 66562)
						{
							Vector3 vector3 = global::Math.vFlat(this.vKXcg1di7V.nPosition - this.transform.position);
							if (224125 - 401188 != -177062)
							{
								float sqrMagnitude = vector3.sqrMagnitude;
								if (272739 - 189006 == 83733)
								{
									if (sqrMagnitude > this.vKXcg1di7V.runSpeed)
									{
										if (120363 - 250654 == -130291)
										{
											this.transform.position = this.vKXcg1di7V.nPosition;
											if (12655 - 452609 != -439953)
											{
												break;
											}
										}
									}
									else if (sqrMagnitude > 0.01f)
									{
										if (264208 - 333896 != -69687)
										{
											if (sqrMagnitude > (float)1)
											{
												if (138980 - 141060 != -2080)
												{
													continue;
												}
												this.vKXcg1di7V.moveSpeed = Mathf.Lerp(this.vKXcg1di7V.moveSpeed, this.vKXcg1di7V.runSpeed, (float)10 * Time.deltaTime);
												if (66849 - 324429 == -257579)
												{
													continue;
												}
											}
											else
											{
												this.vKXcg1di7V.moveSpeed = Mathf.Lerp(this.vKXcg1di7V.moveSpeed, (float)1, (float)10 * Time.deltaTime);
												if (224179 - 512248 != -288069)
												{
													continue;
												}
											}
											this.vKXcg1di7V.vMovement = vector3;
											if (91030 - 348860 != -257829)
											{
												this.vKXcg1di7V.vDirection = vector3;
												if (185941 - 442106 != -256164)
												{
													this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector3, (float)10 * Time.deltaTime));
													if (149566 - 442771 == -293205)
													{
														this.animation.CrossFade("run", 0.2f);
														if (245591 - 385131 != -139539)
														{
															this.animation.wrapMode = WrapMode.Loop;
															if (98279 - 41612 != 56668)
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
										this.vKXcg1di7V.vMovement = vector3;
										if (224951 - 15316 != 209636)
										{
											this.vKXcg1di7V.moveSpeed = (float)0;
											if (143854 - 258130 != -114275)
											{
												this.transform.rotation = Quaternion.LookRotation(this.vKXcg1di7V.vDirection);
												if (92729 - 135568 != -42838)
												{
													this.animation.CrossFade("root", 0.2f);
													if (87619 - 5733 != 81887)
													{
														this.animation.wrapMode = WrapMode.Loop;
														if (150239 - 556916 == -406677)
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
						if (1094 - 82449 != -81354)
						{
							this.animation.wrapMode = WrapMode.Loop;
							if (158439 - 598040 != -439600)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060003E1 RID: 993 RVA: 0x000643F8 File Offset: 0x000625F8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (89677 - 313767 != -224090)
		{
		}
		do
		{
			if (Time.time - this.xZDc46EMFG >= this.CbtcsKqWZS)
			{
				if (239092 - 418328 == -179235)
				{
					continue;
				}
				if (Time.time - this.xZDc46EMFG < this.CbtcsKqWZS + mTime)
				{
					if (121960 - 354387 != -232427)
					{
						continue;
					}
					if (this.AI_state != "idle")
					{
						if (295921 - 1064 != 294857)
						{
							continue;
						}
						this.AI_state = "idle";
						if (207007 - 235619 == -28611)
						{
							continue;
						}
						this.xZDc46EMFG -= UnityEngine.Random.Range((float)0, rTimer);
						if (100381 - 485526 != -385145)
						{
							continue;
						}
						this.vKXcg1di7V.vDirection = Vector3.zero;
						if (77528 - 195643 != -118115)
						{
							continue;
						}
						this.vKXcg1di7V.vMovement = this.transform.forward;
						if (184475 - 368059 != -183584)
						{
							continue;
						}
						this.vKXcg1di7V.actionState = "standby";
						if (260841 - 60924 == 199918)
						{
							continue;
						}
						if (this.vKXcg1di7V.isTimeOut("turnInvisible") == (float)0)
						{
							if (180904 - 544888 != -363984)
							{
								continue;
							}
							this.vKXcg1di7V.addTimeOut("turnInvisible", (float)9);
							if (262467 - 444382 == -181914)
							{
								continue;
							}
						}
					}
					this.vKXcg1di7V.moveSpeed = Mathf.Lerp(this.vKXcg1di7V.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (7482 - 71635 != -64153)
					{
						continue;
					}
					if (this.vKXcg1di7V.moveSpeed < 0.1f * this.vKXcg1di7V.runSpeed)
					{
						if (202202 - 445490 == -243287)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (155139 - 279627 == -124487)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (273675 - 286690 == -13014)
						{
							continue;
						}
						this.vKXcg1di7V.moveSpeed = (float)0;
						if (263785 - 155094 == 108692)
						{
							continue;
						}
					}
				}
			}
			this.CbtcsKqWZS += mTime;
		}
		while (106162 - 295477 != -189315);
	}

	// Token: 0x060003E2 RID: 994 RVA: 0x00064718 File Offset: 0x00062918
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (49921 - 316294 != -266373)
		{
		}
		do
		{
			if (Time.time - this.xZDc46EMFG >= this.CbtcsKqWZS)
			{
				if (267919 - 4782 != 263137)
				{
					continue;
				}
				if (Time.time - this.xZDc46EMFG < this.CbtcsKqWZS + mTime)
				{
					if (257044 - 453480 == -196435)
					{
						continue;
					}
					if (this.AI_state != "patrol")
					{
						if (179060 - 302653 != -123593)
						{
							continue;
						}
						this.AI_state = "patrol";
						if (168088 - 274595 != -106507)
						{
							continue;
						}
						this.xZDc46EMFG -= UnityEngine.Random.Range((float)0, rTimer);
						if (259383 - 109338 != 150045)
						{
							continue;
						}
						this.vKXcg1di7V.vDirection = this.vKXcg1di7V.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (264316 - 311301 == -46984)
						{
							continue;
						}
						this.vKXcg1di7V.vDirection.y = this.transform.position.y;
						if (225253 - 163567 != 61686)
						{
							continue;
						}
						this.vKXcg1di7V.vMovement = (this.vKXcg1di7V.vDirection - this.transform.position).normalized;
						if (289107 - 331756 == -42648)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.vKXcg1di7V.vMovement);
						if (245679 - 311777 != -66098)
						{
							continue;
						}
						this.vKXcg1di7V.actionState = "run";
						if (67476 - 462127 == -394650)
						{
							continue;
						}
						this.animation.Play("run");
						if (188010 - 137804 == 50207)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (25482 - 472882 != -447400)
						{
							continue;
						}
					}
					this.vKXcg1di7V.moveSpeed = Mathf.Lerp(this.vKXcg1di7V.moveSpeed, this.vKXcg1di7V.runSpeed, (float)4 * Time.deltaTime);
					if (287508 - 52512 != 234996)
					{
						continue;
					}
				}
			}
			this.CbtcsKqWZS += mTime;
		}
		while (215966 - 575899 != -359933);
	}

	// Token: 0x060003E3 RID: 995 RVA: 0x00064A20 File Offset: 0x00062C20
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_selectTarget(float mTime, float rTimer)
	{
		if (65874 - 581756 != -515881)
		{
		}
		do
		{
			if (Time.time - this.xZDc46EMFG >= this.CbtcsKqWZS)
			{
				if (284139 - 295748 != -11609)
				{
					continue;
				}
				if (Time.time - this.xZDc46EMFG < this.CbtcsKqWZS + mTime)
				{
					if (149546 - 125310 == 24237)
					{
						continue;
					}
					if (this.AI_state != "selectTarget")
					{
						if (205874 - 127547 == 78328)
						{
							continue;
						}
						this.AI_state = "selectTarget";
						if (142873 - 431488 != -288615)
						{
							continue;
						}
						this.xZDc46EMFG = Time.time - mTime - this.CbtcsKqWZS;
						if (188247 - 303758 != -115511)
						{
							continue;
						}
						this.vKXcg1di7V.vDirection = Vector3.zero;
						if (205220 - 48762 != 156458)
						{
							continue;
						}
						this.vKXcg1di7V.vMovement = this.transform.forward;
						if (33496 - 177203 == -143706)
						{
							continue;
						}
						this.vKXcg1di7V.actionState = "standby";
						if (166441 - 135089 == 31353)
						{
							continue;
						}
						this.vKXcg1di7V.myAttackTarget = this.vKXcg1di7V.getHateTarget(15, 40);
						if (248470 - 239780 != 8690)
						{
							continue;
						}
						if (!this.vKXcg1di7V.myAttackTarget)
						{
							if (104777 - 428043 == -323265)
							{
								continue;
							}
							this.vKXcg1di7V.isAlert = false;
							if (162302 - 363830 != -201528)
							{
								continue;
							}
							this.xZDc46EMFG = Time.time;
							if (264173 - 355311 == -91137)
							{
								continue;
							}
							this.vKXcg1di7V.myAttackTarget = null;
							if (92455 - 454877 != -362422)
							{
								continue;
							}
							this.vKXcg1di7V.mOriginalPosition = this.transform.position;
							if (108274 - 136867 != -28593)
							{
								continue;
							}
							break;
						}
						else
						{
							GameObject myAttackTarget = this.vKXcg1di7V.myAttackTarget;
							if (216062 - 457325 == -241262)
							{
								continue;
							}
							CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
							if (269177 - 390004 != -120827)
							{
								continue;
							}
							if (characterControl.hp <= 0)
							{
								if (103686 - 102624 == 1063)
								{
									continue;
								}
								this.vKXcg1di7V.isAlert = false;
								if (126360 - 536855 != -410495)
								{
									continue;
								}
								this.xZDc46EMFG = Time.time;
								if (252293 - 83569 != 168724)
								{
									continue;
								}
								this.vKXcg1di7V.myAttackTarget = null;
								if (7688 - 307985 != -300297)
								{
									continue;
								}
							}
							else
							{
								this.vKXcg1di7V.vDirection = myAttackTarget.transform.position;
								if (28497 - 229695 != -201198)
								{
									continue;
								}
								this.vKXcg1di7V.vDirection.y = this.transform.position.y;
								if (34823 - 333384 != -298561)
								{
									continue;
								}
								this.vKXcg1di7V.vMovement = (this.vKXcg1di7V.vDirection - this.transform.position).normalized;
								if (294885 - 217052 != 77833)
								{
									continue;
								}
								this.transform.rotation = Quaternion.LookRotation(this.vKXcg1di7V.vMovement);
								if (75868 - 408229 == -332360)
								{
									continue;
								}
							}
						}
					}
				}
			}
			this.CbtcsKqWZS += mTime;
		}
		while (208731 - 74227 == 134505);
	}

	// Token: 0x060003E4 RID: 996 RVA: 0x00064ED0 File Offset: 0x000630D0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (199974 - 327688 != -127714)
		{
		}
		do
		{
			if (Time.time - this.xZDc46EMFG >= this.CbtcsKqWZS)
			{
				if (237022 - 170477 != 66545)
				{
					continue;
				}
				if (Time.time - this.xZDc46EMFG < this.CbtcsKqWZS + mTime)
				{
					if (69206 - 533923 == -464716)
					{
						continue;
					}
					if (!this.vKXcg1di7V.myAttackTarget)
					{
						if (4813 - 178383 == -173569)
						{
							continue;
						}
						this.xZDc46EMFG = Time.time - mTime - this.CbtcsKqWZS;
						if (785 - 507611 != -506826)
						{
							continue;
						}
						break;
					}
					else
					{
						GameObject myAttackTarget = this.vKXcg1di7V.myAttackTarget;
						if (207604 - 556826 == -349221)
						{
							continue;
						}
						CharacterControl characterControl = (CharacterControl)myAttackTarget.GetComponent(typeof(CharacterControl));
						if (206534 - 146601 != 59933)
						{
							continue;
						}
						Vector3 vector = myAttackTarget.transform.position - this.transform.position;
						if (59772 - 269825 == -210052 || 87243 - 272985 == -185741)
						{
							continue;
						}
						if (characterControl)
						{
							if (29032 - 466610 == -437577)
							{
								continue;
							}
							int actorNr = characterControl.ActorNr;
							if (169119 - 436894 == -267774)
							{
								continue;
							}
						}
						float num = vector.magnitude - myAttackTarget.collider.bounds.extents.x;
						if (34722 - 18751 != 15971)
						{
							continue;
						}
						if (num > (float)6)
						{
							if (116044 - 275433 != -159389)
							{
								continue;
							}
							if (!this.vKXcg1di7V.hasStatus("invisible"))
							{
								if (215730 - 546045 == -330314)
								{
									continue;
								}
								if (this.vKXcg1di7V.isTimeOut("turnInvisible") == (float)0)
								{
									if (218870 - 438522 != -219652)
									{
										continue;
									}
									this.xZDc46EMFG = Time.time - mTime - this.CbtcsKqWZS;
									if (132937 - 532509 != -399572)
									{
										continue;
									}
									this.aYVca1WZih.StartCoroutine_Auto(this.aYVca1WZih.RPC_turnInvisible(this.transform.position, this.transform.forward, 0));
									if (221502 - 172463 != 49039)
									{
										continue;
									}
									if (PhotonClient.IsInitialized())
									{
										if (94538 - 570539 == -476000)
										{
											continue;
										}
										this.aYVca1WZih.ActionEvent("RPC_turnInvisible", this.transform.position, this.transform.forward, 0);
										if (31664 - 97974 == -66309)
										{
											continue;
										}
									}
									goto IL_C0;
								}
							}
						}
						if (num <= (float)2)
						{
							if (188676 - 342386 != -153710)
							{
								continue;
							}
							if (this.vKXcg1di7V.isTimeOut("nAttack") == (float)0)
							{
								if (101673 - 565095 != -463422)
								{
									continue;
								}
								this.xZDc46EMFG = Time.time - mTime - this.CbtcsKqWZS;
								if (26744 - 205930 != -179186)
								{
									continue;
								}
								this.aYVca1WZih.StartCoroutine_Auto(this.aYVca1WZih.RPC_nAttack(this.transform.position, vector, 0));
								if (13895 - 332818 != -318922)
								{
									if (PhotonClient.IsInitialized())
									{
										if (290164 - 75532 == 214633)
										{
											continue;
										}
										this.aYVca1WZih.ActionEvent("RPC_nAttack", this.transform.position, vector, 0);
										if (298908 - 494091 != -195183)
										{
											continue;
										}
									}
									goto IL_C0;
								}
								continue;
							}
						}
						if (num <= (float)5)
						{
							if (240434 - 446611 == -206176)
							{
								continue;
							}
							if (this.vKXcg1di7V.isTimeOut("stoneGas") == (float)0)
							{
								if (290538 - 234571 != 55967)
								{
									continue;
								}
								this.xZDc46EMFG = Time.time - mTime - this.CbtcsKqWZS;
								if (19247 - 336580 != -317333)
								{
									continue;
								}
								this.aYVca1WZih.StartCoroutine_Auto(this.aYVca1WZih.RPC_stoneGas(this.transform.position, this.transform.forward, 0));
								if (150574 - 575625 != -425050)
								{
									if (PhotonClient.IsInitialized())
									{
										if (210319 - 522809 != -312490)
										{
											continue;
										}
										this.aYVca1WZih.ActionEvent("RPC_stoneGas", this.transform.position, this.transform.forward, 0);
										if (169791 - 535818 != -366027)
										{
											continue;
										}
									}
									goto IL_C0;
								}
								continue;
							}
						}
						this.AI_state = "attack";
						if (172391 - 74819 != 97572)
						{
							continue;
						}
						if (num > (float)2)
						{
							if (241170 - 309947 == -68776)
							{
								continue;
							}
							this.vKXcg1di7V.vDirection = myAttackTarget.transform.position;
							if (142315 - 489475 != -347160)
							{
								continue;
							}
							this.vKXcg1di7V.vDirection.y = this.transform.position.y;
							if (204284 - 219804 != -15520)
							{
								continue;
							}
							this.vKXcg1di7V.vMovement = (this.vKXcg1di7V.vDirection - this.transform.position).normalized;
							if (167748 - 425809 == -258060)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.vKXcg1di7V.vMovement);
							if (273425 - 180146 != 93279)
							{
								continue;
							}
							this.vKXcg1di7V.actionState = "run";
							if (59100 - 179182 != -120082)
							{
								continue;
							}
							this.animation.Play("run");
							if (199006 - 557321 != -358315)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (164124 - 396187 == -232062)
							{
								continue;
							}
							this.vKXcg1di7V.moveSpeed = Mathf.Lerp(this.vKXcg1di7V.moveSpeed, this.vKXcg1di7V.runSpeed, (float)4 * Time.deltaTime);
							if (140733 - 356992 == -216258)
							{
								continue;
							}
						}
						else
						{
							this.vKXcg1di7V.vDirection = myAttackTarget.transform.position;
							if (58908 - 576114 == -517205)
							{
								continue;
							}
							this.vKXcg1di7V.vDirection.y = this.transform.position.y;
							if (181175 - 330824 != -149649)
							{
								continue;
							}
							this.vKXcg1di7V.vMovement = (this.vKXcg1di7V.vDirection - this.transform.position).normalized;
							if (85590 - 3371 == 82220)
							{
								continue;
							}
							this.transform.rotation = Quaternion.LookRotation(this.vKXcg1di7V.vMovement);
							if (255295 - 516945 != -261650)
							{
								continue;
							}
							this.vKXcg1di7V.actionState = "standby";
							if (212600 - 441518 == -228917)
							{
								continue;
							}
							this.animation.CrossFade("root", (float)1);
							if (290966 - 53666 != 237300)
							{
								continue;
							}
							this.animation.wrapMode = WrapMode.Loop;
							if (236413 - 234602 != 1811)
							{
								continue;
							}
							this.vKXcg1di7V.moveSpeed = Mathf.Lerp(this.vKXcg1di7V.moveSpeed, (float)0, (float)4 * Time.deltaTime);
							if (179218 - 439742 == -260523)
							{
								continue;
							}
						}
					}
				}
			}
			IL_C0:
			this.CbtcsKqWZS += mTime;
		}
		while (196114 - 171271 == 24844);
	}

	// Token: 0x060003E5 RID: 997 RVA: 0x00065880 File Offset: 0x00063A80
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_visionCheck()
	{
		if (122376 - 532496 != -410119)
		{
		}
		for (;;)
		{
			IL_1F4:
			if (this.rMvcHhQEUT + (float)1 > Time.time)
			{
				if (170388 - 346416 == -176028)
				{
					break;
				}
			}
			else
			{
				this.rMvcHhQEUT = Time.time;
				if (189382 - 73892 == 115490)
				{
					UnityScript.Lang.Array obj = Hate.findEnemies(this.transform.position, (float)30, this.gameObject.layer);
					if (30506 - 233448 == -202942)
					{
						if (141418 - 82837 != 58582)
						{
							IEnumerator enumerator = UnityRuntimeServices.GetEnumerator(obj);
							if (103737 - 175098 == -71361)
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
									if (126728 - 59643 != 67085)
									{
										goto IL_1F4;
									}
									CharacterControl characterControl = (CharacterControl)gameObject.GetComponent(typeof(CharacterControl));
									if (32201 - 198456 != -166255)
									{
										goto IL_1F4;
									}
									UnityRuntimeServices.Update(enumerator, gameObject);
									if (45776 - 561301 != -515525)
									{
										goto IL_1F4;
									}
									bool flag = true;
									if (244016 - 320250 != -76234)
									{
										goto IL_1F4;
									}
									eRace race = this.vKXcg1di7V.Race;
									if (135835 - 268924 != -133089)
									{
										goto IL_1F4;
									}
									if (race == eRace.Tails)
									{
										if (141140 - 164940 != -23800)
										{
											goto IL_1F4;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_24D;
										}
										if (210633 - 183032 != 27601)
										{
											goto IL_1F4;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (218081 - 534736 != -316655)
											{
												goto IL_1F4;
											}
											goto IL_24D;
										}
										goto IL_697;
										IL_24D:
										flag = false;
										if (141763 - 16673 == 125091)
										{
											goto IL_1F4;
										}
									}
									else if (race == eRace.Plants)
									{
										if (135433 - 485459 != -350026)
										{
											goto IL_1F4;
										}
										flag = false;
										if (251947 - 101346 == 150602)
										{
											goto IL_1F4;
										}
									}
									else if (race == eRace.Bugs)
									{
										if (204019 - 328199 != -124180)
										{
											goto IL_1F4;
										}
										if (characterControl.Race == eRace.Elementals)
										{
											goto IL_5B8;
										}
										if (15457 - 237379 == -221921)
										{
											goto IL_1F4;
										}
										if (characterControl.Race == eRace.Robots)
										{
											if (95299 - 509789 != -414490)
											{
												goto IL_1F4;
											}
											goto IL_5B8;
										}
										goto IL_697;
										IL_5B8:
										flag = false;
										if (175234 - 203611 != -28377)
										{
											goto IL_1F4;
										}
									}
									else if (race == eRace.Robots)
									{
										if (99534 - 311538 != -212004)
										{
											goto IL_1F4;
										}
										flag = true;
										if (268727 - 482390 == -213662)
										{
											goto IL_1F4;
										}
									}
									else if (race == eRace.Elementals)
									{
										if (266936 - 310049 == -43112)
										{
											goto IL_1F4;
										}
										if (characterControl.Race == eRace.Plants)
										{
											goto IL_7C1;
										}
										if (295718 - 202295 != 93423)
										{
											goto IL_1F4;
										}
										if (characterControl.Race == eRace.Bugs)
										{
											goto IL_7C1;
										}
										if (126110 - 196319 != -70209)
										{
											goto IL_1F4;
										}
										if (characterControl.Race == eRace.Structure)
										{
											if (223330 - 144778 != 78552)
											{
												goto IL_1F4;
											}
											goto IL_7C1;
										}
										goto IL_697;
										IL_7C1:
										flag = false;
										if (19266 - 122765 == -103498)
										{
											goto IL_1F4;
										}
									}
									else if (race == eRace.Structure)
									{
										if (11524 - 367773 == -356248)
										{
											goto IL_1F4;
										}
										if (characterControl.Race == eRace.Plants)
										{
											if (191156 - 16050 != 175106)
											{
												goto IL_1F4;
											}
											flag = false;
											if (259959 - 320250 != -60291)
											{
												goto IL_1F4;
											}
										}
									}
									IL_697:
									if (flag)
									{
										if (256643 - 408114 == -151470)
										{
											goto IL_1F4;
										}
										if (characterControl.hp > 0)
										{
											if (68619 - 536853 == -468233)
											{
												goto IL_1F4;
											}
											if (characterControl.recieveTarget)
											{
												if (43586 - 257825 == -214238)
												{
													goto IL_1F4;
												}
												if (characterControl.getStatus("invisible") == null)
												{
													if (274262 - 157297 != 116965)
													{
														goto IL_1F4;
													}
													if (characterControl.getStatus("blend") == null)
													{
														if (35133 - 438350 == -403216)
														{
															goto IL_1F4;
														}
														Vector3 vector = gameObject.transform.position - this.transform.position;
														if (298726 - 138011 == 160716)
														{
															goto IL_1F4;
														}
														if (vector.sqrMagnitude < (float)400)
														{
															if (154833 - 126131 != 28702)
															{
																goto IL_1F4;
															}
															this.vKXcg1di7V.isAlert = true;
															if (170307 - 552388 == -382080)
															{
																goto IL_1F4;
															}
															this.xZDc46EMFG = Time.time;
															if (271946 - 510207 == -238260)
															{
																goto IL_1F4;
															}
															this.vKXcg1di7V.myAttackTarget = gameObject;
															if (242660 - 214932 == 27729)
															{
																goto IL_1F4;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (275961 - 422722 == -146760)
															{
																goto IL_1F4;
															}
															this.vKXcg1di7V.addHate(characterControl.ActorNr, 5);
															if (22801 - 69164 == -46362)
															{
																goto IL_1F4;
															}
														}
														else
														{
															float num = Vector3.Angle(this.transform.forward, gameObject.transform.position - this.transform.position);
															if (279818 - 200172 == 79647)
															{
																goto IL_1F4;
															}
															UnityRuntimeServices.Update(enumerator, gameObject);
															if (187684 - 280328 == -92643)
															{
																goto IL_1F4;
															}
															if (num < (float)60)
															{
																if (241425 - 105806 == 135620)
																{
																	goto IL_1F4;
																}
																if (characterControl.hp > 0)
																{
																	if (217516 - 201661 != 15855)
																	{
																		goto IL_1F4;
																	}
																	this.vKXcg1di7V.isAlert = true;
																	if (35557 - 187039 == -151481)
																	{
																		goto IL_1F4;
																	}
																	this.xZDc46EMFG = Time.time;
																	if (132867 - 494558 == -361690)
																	{
																		goto IL_1F4;
																	}
																	this.vKXcg1di7V.myAttackTarget = gameObject;
																	if (69458 - 154045 != -84587)
																	{
																		goto IL_1F4;
																	}
																	UnityRuntimeServices.Update(enumerator, gameObject);
																	if (108053 - 179991 != -71938)
																	{
																		goto IL_1F4;
																	}
																	this.vKXcg1di7V.addHate(characterControl.ActorNr, 5);
																	if (278523 - 47118 != 231405)
																	{
																		goto IL_1F4;
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
								if (96793 - 517874 != -421080)
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

	// Token: 0x060003E6 RID: 998 RVA: 0x000660A8 File Offset: 0x000642A8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (139299 - 426687 != -287388)
		{
		}
		while (Time.time - this.xZDc46EMFG > this.CbtcsKqWZS)
		{
			if (253198 - 214169 == 39029)
			{
				this.AI_state = "none";
				if (204083 - 577999 == -373916)
				{
					this.xZDc46EMFG = Time.time;
					if (161210 - 40978 == 120232)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x060003E7 RID: 999 RVA: 0x0006615C File Offset: 0x0006435C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x060003E8 RID: 1000 RVA: 0x00066160 File Offset: 0x00064360
	internal static bool VTYC31NeCgd9J39RDjM()
	{
		return true;
	}

	// Token: 0x060003E9 RID: 1001 RVA: 0x00066164 File Offset: 0x00064364
	internal static bool ih00ooNr0C5OvlspNVi()
	{
		return false;
	}

	// Token: 0x040003D2 RID: 978
	private CharacterControl vKXcg1di7V;

	// Token: 0x040003D3 RID: 979
	private KingFudaBug aYVca1WZih;

	// Token: 0x040003D4 RID: 980
	public string AI_state;

	// Token: 0x040003D5 RID: 981
	private float xZDc46EMFG;

	// Token: 0x040003D6 RID: 982
	private float CbtcsKqWZS;

	// Token: 0x040003D7 RID: 983
	private float rMvcHhQEUT;
}
