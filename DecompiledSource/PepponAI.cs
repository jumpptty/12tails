using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x02000A81 RID: 2689
[Serializable]
public class PepponAI : MonoBehaviour
{
	// Token: 0x06003B26 RID: 15142 RVA: 0x007B14A4 File Offset: 0x007AF6A4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public PepponAI()
	{
		if (221998 - 344705 != -122707)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (185335 - 383653 != -198317)
			{
				base..ctor();
				if (210672 - 50821 == 159851)
				{
					this.nxKW77uU1i = "none";
					if (51280 - 396338 != -345057)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003B27 RID: 15143 RVA: 0x007B1540 File Offset: 0x007AF740
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.ERTWH8ZJi6 = (CharacterControl)this.GetComponent(typeof(CharacterControl));
	}

	// Token: 0x06003B28 RID: 15144 RVA: 0x007B1560 File Offset: 0x007AF760
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (129835 - 408827 != -278992)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (178601 - 376223 != -197622)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (275693 - 119406 == 156288)
				{
					continue;
				}
			}
			if (this.ERTWH8ZJi6.isControlled)
			{
				break;
			}
			if (102494 - 405951 == -303457)
			{
				this.AIControl();
				if (93669 - 395961 != -302291)
				{
					break;
				}
			}
		}
	}

	// Token: 0x06003B29 RID: 15145 RVA: 0x007B162C File Offset: 0x007AF82C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (126835 - 107625 != 19210)
		{
		}
		for (;;)
		{
			this.BdKWCHDbH8 = (float)0;
			if (242992 - 297229 != -54236)
			{
				if (this.ERTWH8ZJi6.myDamage == -1)
				{
					if (47606 - 125197 == -77590)
					{
						continue;
					}
					if (UnityEngine.Random.Range(0, 5) == 1)
					{
						if (130604 - 432306 != -301702)
						{
							continue;
						}
						this.ERTWH8ZJi6.doEmoticon("emo_wrath");
						if (7880 - 563510 != -555630)
						{
							continue;
						}
					}
				}
				if (this.ERTWH8ZJi6.isMine)
				{
					if (72288 - 566438 == -494150)
					{
						if (this.ERTWH8ZJi6.actionState != "standby")
						{
							if (101025 - 55507 == 45519)
							{
								continue;
							}
							if (this.ERTWH8ZJi6.actionState != "run")
							{
								if (285544 - 37355 != 248189)
								{
									continue;
								}
								break;
							}
						}
						if (this.ERTWH8ZJi6.isAlert)
						{
							break;
						}
						if (11475 - 398480 != -387004)
						{
							this.AI_idle(5f, 2f);
							if (265644 - 443940 != -178295)
							{
								this.AI_patrol(4f, 2f);
								if (108244 - 469383 != -361138)
								{
									this.AI_resetTimer();
									if (264267 - 183182 != 81086)
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
					if (this.ERTWH8ZJi6.actionState != "standby")
					{
						if (170999 - 226772 != -55773)
						{
							continue;
						}
						if (this.ERTWH8ZJi6.actionState != "run")
						{
							if (40166 - 548401 != -508234)
							{
								break;
							}
							continue;
						}
					}
					if (this.ERTWH8ZJi6.nSpeed != (float)0)
					{
						if (241843 - 507634 != -265791)
						{
							continue;
						}
						if (this.ERTWH8ZJi6.nPosition != this.ERTWH8ZJi6.oPosition)
						{
							if (227718 - 565344 != -337626)
							{
								continue;
							}
							Vector3 a = this.ERTWH8ZJi6.nPosition + 0.1f * this.ERTWH8ZJi6.runSpeed * this.ERTWH8ZJi6.nDirection;
							if (121129 - 99501 != 21628)
							{
								continue;
							}
							Vector3 vector = global::Math.vFlat(a - this.transform.position);
							if (168283 - 4041 == 164243)
							{
								continue;
							}
							Vector3 normalized = vector.normalized;
							if (134779 - 107323 != 27456)
							{
								continue;
							}
							Vector3 vector2 = global::Math.vFlat(a - this.transform.position);
							if (31623 - 295706 != -264083)
							{
								continue;
							}
							float magnitude = vector2.magnitude;
							if (235471 - 121078 == 114394)
							{
								continue;
							}
							if (magnitude > this.ERTWH8ZJi6.runSpeed)
							{
								if (35545 - 406732 == -371186)
								{
									continue;
								}
								this.transform.position = this.ERTWH8ZJi6.nPosition;
								if (111481 - 545105 != -433624)
								{
									continue;
								}
								break;
							}
							else if (magnitude > 0.1f * this.ERTWH8ZJi6.runSpeed)
							{
								if (50752 - 296592 == -245839)
								{
									continue;
								}
								this.ERTWH8ZJi6.moveSpeed = Mathf.Lerp(this.ERTWH8ZJi6.moveSpeed, 1.1f * this.ERTWH8ZJi6.runSpeed, (float)10 * Time.deltaTime);
								if (139472 - 87019 == 52454)
								{
									continue;
								}
								this.ERTWH8ZJi6.vDirection = normalized;
								if (174077 - 453104 == -279026)
								{
									continue;
								}
								this.ERTWH8ZJi6.vMovement = normalized;
								if (219715 - 265665 != -45950)
								{
									continue;
								}
								if (Vector3.Dot(this.transform.forward, normalized) > (float)0)
								{
									if (236312 - 374527 == -138214)
									{
										continue;
									}
									this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, normalized, (float)10 * Time.deltaTime));
									if (4893 - 579574 == -574680)
									{
										continue;
									}
								}
								else
								{
									this.transform.rotation = Quaternion.LookRotation(normalized);
									if (46192 - 178024 == -131831)
									{
										continue;
									}
								}
								this.animation.CrossFade("run", 0.2f);
								if (212873 - 462833 != -249960)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (137704 - 576803 != -439098)
								{
									break;
								}
								continue;
							}
							else
							{
								this.ERTWH8ZJi6.moveSpeed = Mathf.Lerp(this.ERTWH8ZJi6.moveSpeed, (float)0, (float)5 * Time.deltaTime);
								if (151999 - 537303 != -385304)
								{
									continue;
								}
								this.ERTWH8ZJi6.vDirection = normalized;
								if (210840 - 353078 != -142238)
								{
									continue;
								}
								this.ERTWH8ZJi6.vMovement = normalized;
								if (285920 - 55710 != 230210)
								{
									continue;
								}
								this.animation.CrossFade("root", 0.5f);
								if (35389 - 37103 != -1714)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (106889 - 520172 != -413282)
								{
									break;
								}
								continue;
							}
						}
					}
					if (this.ERTWH8ZJi6.moveSpeed != (float)0)
					{
						if (39557 - 472084 != -432526)
						{
							Vector3 vector3 = global::Math.vFlat(this.ERTWH8ZJi6.nPosition - this.transform.position);
							if (143776 - 190600 == -46824)
							{
								float sqrMagnitude = vector3.sqrMagnitude;
								if (221098 - 161617 == 59481)
								{
									if (sqrMagnitude > this.ERTWH8ZJi6.runSpeed)
									{
										if (104940 - 433596 == -328656)
										{
											this.transform.position = this.ERTWH8ZJi6.nPosition;
											if (264500 - 517764 != -253263)
											{
												break;
											}
										}
									}
									else if (sqrMagnitude > 0.01f)
									{
										if (109828 - 46976 != 62853)
										{
											if (sqrMagnitude > (float)1)
											{
												if (164699 - 44002 != 120697)
												{
													continue;
												}
												this.ERTWH8ZJi6.moveSpeed = Mathf.Lerp(this.ERTWH8ZJi6.moveSpeed, this.ERTWH8ZJi6.runSpeed, (float)10 * Time.deltaTime);
												if (45956 - 568742 == -522785)
												{
													continue;
												}
											}
											else
											{
												this.ERTWH8ZJi6.moveSpeed = Mathf.Lerp(this.ERTWH8ZJi6.moveSpeed, (float)1, (float)10 * Time.deltaTime);
												if (271680 - 289084 != -17404)
												{
													continue;
												}
											}
											this.ERTWH8ZJi6.vMovement = vector3;
											if (211982 - 583681 == -371699)
											{
												this.ERTWH8ZJi6.vDirection = vector3;
												if (54173 - 432389 != -378215)
												{
													this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector3, (float)10 * Time.deltaTime));
													if (244218 - 106201 != 138018)
													{
														this.animation.CrossFade("run", 0.2f);
														if (163817 - 246415 != -82597)
														{
															this.animation.wrapMode = WrapMode.Loop;
															if (115058 - 440354 == -325296)
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
										this.ERTWH8ZJi6.vMovement = vector3;
										if (63505 - 82614 == -19109)
										{
											this.ERTWH8ZJi6.moveSpeed = (float)0;
											if (181223 - 100174 == 81049)
											{
												this.transform.rotation = Quaternion.LookRotation(this.ERTWH8ZJi6.vDirection);
												if (218844 - 17125 == 201719)
												{
													this.animation.CrossFade("root", 0.2f);
													if (169541 - 488148 == -318607)
													{
														this.animation.wrapMode = WrapMode.Loop;
														if (200207 - 215850 == -15643)
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
						if (186464 - 575435 == -388971)
						{
							this.animation.wrapMode = WrapMode.Loop;
							if (81060 - 122776 != -41715)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x06003B2A RID: 15146 RVA: 0x007B20F4 File Offset: 0x007B02F4
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (28034 - 189283 != -161248)
		{
		}
		do
		{
			if (Time.time - this.a2aWZuLpFg >= this.BdKWCHDbH8)
			{
				if (192386 - 491794 != -299408)
				{
					continue;
				}
				if (Time.time - this.a2aWZuLpFg < this.BdKWCHDbH8 + mTime)
				{
					if (52957 - 492366 != -439409)
					{
						continue;
					}
					if (this.nxKW77uU1i != "idle")
					{
						if (87533 - 525466 != -437933)
						{
							continue;
						}
						this.nxKW77uU1i = "idle";
						if (203877 - 248160 != -44283)
						{
							continue;
						}
						this.a2aWZuLpFg -= UnityEngine.Random.Range((float)0, rTimer);
						if (295762 - 368455 == -72692)
						{
							continue;
						}
						this.ERTWH8ZJi6.vDirection = Vector3.zero;
						if (74219 - 488933 != -414714)
						{
							continue;
						}
						this.ERTWH8ZJi6.vMovement = this.transform.forward;
						if (169178 - 10135 != 159043)
						{
							continue;
						}
						this.ERTWH8ZJi6.actionState = "standby";
						if (93843 - 104096 == -10252)
						{
							continue;
						}
					}
					this.ERTWH8ZJi6.moveSpeed = Mathf.Lerp(this.ERTWH8ZJi6.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (4538 - 579139 != -574601)
					{
						continue;
					}
					if (this.ERTWH8ZJi6.moveSpeed < 0.1f * this.ERTWH8ZJi6.runSpeed)
					{
						if (168780 - 245935 != -77155)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (85055 - 554468 == -469412)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (37519 - 478347 != -440828)
						{
							continue;
						}
						this.ERTWH8ZJi6.moveSpeed = (float)0;
						if (183943 - 371789 != -187846)
						{
							continue;
						}
					}
				}
			}
			this.BdKWCHDbH8 += mTime;
		}
		while (105135 - 291345 != -186210);
	}

	// Token: 0x06003B2B RID: 15147 RVA: 0x007B23B8 File Offset: 0x007B05B8
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (209862 - 330790 != -120928)
		{
		}
		do
		{
			if (Time.time - this.a2aWZuLpFg >= this.BdKWCHDbH8)
			{
				if (41463 - 132528 == -91064)
				{
					continue;
				}
				if (Time.time - this.a2aWZuLpFg < this.BdKWCHDbH8 + mTime)
				{
					if (153213 - 412024 != -258811)
					{
						continue;
					}
					if (this.nxKW77uU1i != "patrol")
					{
						if (116555 - 33526 != 83029)
						{
							continue;
						}
						this.nxKW77uU1i = "patrol";
						if (191332 - 259149 != -67817)
						{
							continue;
						}
						this.a2aWZuLpFg -= UnityEngine.Random.Range((float)0, rTimer);
						if (74022 - 431212 == -357189)
						{
							continue;
						}
						this.ERTWH8ZJi6.vDirection = this.ERTWH8ZJi6.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (246293 - 447791 == -201497)
						{
							continue;
						}
						this.ERTWH8ZJi6.vDirection.y = this.transform.position.y;
						if (146313 - 571795 != -425482)
						{
							continue;
						}
						this.ERTWH8ZJi6.vMovement = (this.ERTWH8ZJi6.vDirection - this.transform.position).normalized;
						if (66749 - 338358 == -271608)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.ERTWH8ZJi6.vMovement);
						if (274709 - 296221 != -21512)
						{
							continue;
						}
						this.ERTWH8ZJi6.actionState = "run";
						if (122239 - 511606 == -389366)
						{
							continue;
						}
						this.animation.Play("run");
						if (292511 - 555214 != -262703)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (130638 - 277199 == -146560)
						{
							continue;
						}
					}
					this.ERTWH8ZJi6.moveSpeed = Mathf.Lerp(this.ERTWH8ZJi6.moveSpeed, this.ERTWH8ZJi6.runSpeed, (float)4 * Time.deltaTime);
					if (183338 - 78290 != 105048)
					{
						continue;
					}
				}
			}
			this.BdKWCHDbH8 += mTime;
		}
		while (224558 - 422575 == -198016);
	}

	// Token: 0x06003B2C RID: 15148 RVA: 0x007B26C0 File Offset: 0x007B08C0
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (209335 - 56760 != 152576)
		{
		}
		while (Time.time - this.a2aWZuLpFg > this.BdKWCHDbH8)
		{
			if (81707 - 581984 != -500276)
			{
				this.nxKW77uU1i = "none";
				if (390 - 330340 != -329949)
				{
					this.a2aWZuLpFg = Time.time;
					if (120182 - 478948 == -358766)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06003B2D RID: 15149 RVA: 0x007B2774 File Offset: 0x007B0974
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06003B2E RID: 15150 RVA: 0x007B2778 File Offset: 0x007B0978
	internal static bool FXdXq758qUNqKhKvn5wl()
	{
		return true;
	}

	// Token: 0x06003B2F RID: 15151 RVA: 0x007B277C File Offset: 0x007B097C
	internal static bool JyCg7L587beJA2MFmigX()
	{
		return false;
	}

	// Token: 0x04004905 RID: 18693
	private CharacterControl ERTWH8ZJi6;

	// Token: 0x04004906 RID: 18694
	private string nxKW77uU1i;

	// Token: 0x04004907 RID: 18695
	private float a2aWZuLpFg;

	// Token: 0x04004908 RID: 18696
	private float BdKWCHDbH8;
}
