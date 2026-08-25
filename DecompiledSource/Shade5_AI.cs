using System;
using System.Runtime.CompilerServices;
using cZRJ81ju0AbIsUerIn;
using UnityEngine;

// Token: 0x0200039A RID: 922
[Serializable]
public class Shade5_AI : MonoBehaviour
{
	// Token: 0x06001527 RID: 5415 RVA: 0x00217080 File Offset: 0x00215280
	[MethodImpl(MethodImplOptions.NoInlining)]
	public Shade5_AI()
	{
		if (74262 - 302466 != -228203)
		{
		}
		for (;;)
		{
			LTRpgsKoBpCYTrSOvr.eNjlINQSLXVTn();
			if (56511 - 585825 == -529314)
			{
				base..ctor();
				if (57922 - 471310 != -413387)
				{
					this.zo5Xc8V6h7 = "none";
					if (204134 - 575548 == -371414)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x06001528 RID: 5416 RVA: 0x0021711C File Offset: 0x0021531C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Awake()
	{
		this.IXHtzdUP87 = (CharacterControl)this.GetComponent(typeof(CharacterControl));
		this.BRFX5nRoHL = (Shade5)this.GetComponent(typeof(Shade5));
	}

	// Token: 0x06001529 RID: 5417 RVA: 0x00217154 File Offset: 0x00215354
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Update()
	{
		if (131868 - 324449 != -192581)
		{
		}
		for (;;)
		{
			if (Game.mGameState != eGameState.Normal)
			{
				if (90039 - 11575 == 78465)
				{
					continue;
				}
				if (Game.mGameState != eGameState.Hold)
				{
					break;
				}
				if (236100 - 110500 != 125600)
				{
					continue;
				}
			}
			if (this.IXHtzdUP87.isControlled)
			{
				break;
			}
			if (87008 - 163398 == -76390)
			{
				this.AIControl();
				if (118185 - 499634 != -381448)
				{
					break;
				}
			}
		}
	}

	// Token: 0x0600152A RID: 5418 RVA: 0x00217220 File Offset: 0x00215420
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AIControl()
	{
		if (276564 - 240564 != 36001)
		{
		}
		for (;;)
		{
			this.W7gXQv9mpT = (float)0;
			if (277397 - 10090 == 267307)
			{
				if (this.IXHtzdUP87.isMine)
				{
					if (269309 - 437787 != -168477)
					{
						if (this.IXHtzdUP87.actionState != "standby")
						{
							if (37329 - 300188 != -262859)
							{
								continue;
							}
							if (this.IXHtzdUP87.actionState != "run")
							{
								if (210124 - 285987 != -75862)
								{
									break;
								}
								continue;
							}
						}
						if (this.IXHtzdUP87.isAlert)
						{
							break;
						}
						if (193484 - 237110 != -43625)
						{
							this.AI_patrol(2f, 1f);
							if (5156 - 289005 != -283848)
							{
								this.AI_attack(1f, (float)0);
								if (150752 - 427380 != -276627)
								{
									this.AI_resetTimer();
									if (276065 - 173345 == 102720)
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
					if (this.IXHtzdUP87.actionState != "standby")
					{
						if (231520 - 423088 == -191567)
						{
							continue;
						}
						if (this.IXHtzdUP87.actionState != "run")
						{
							if (63272 - 272395 != -209122)
							{
								break;
							}
							continue;
						}
					}
					if (this.IXHtzdUP87.nSpeed != (float)0)
					{
						if (213614 - 267239 != -53625)
						{
							continue;
						}
						if (this.IXHtzdUP87.nPosition != this.IXHtzdUP87.oPosition)
						{
							if (73761 - 485930 != -412169)
							{
								continue;
							}
							Vector3 a = this.IXHtzdUP87.nPosition + 0.1f * this.IXHtzdUP87.runSpeed * this.IXHtzdUP87.nDirection;
							if (110193 - 553168 != -442975)
							{
								continue;
							}
							Vector3 vector = global::Math.vFlat(a - this.transform.position);
							if (207065 - 408900 != -201835)
							{
								continue;
							}
							Vector3 normalized = vector.normalized;
							if (86801 - 249981 == -163179)
							{
								continue;
							}
							Vector3 vector2 = global::Math.vFlat(a - this.transform.position);
							if (105247 - 306283 == -201035)
							{
								continue;
							}
							float magnitude = vector2.magnitude;
							if (132373 - 200657 != -68284)
							{
								continue;
							}
							if (magnitude > this.IXHtzdUP87.runSpeed)
							{
								if (244694 - 26874 != 217820)
								{
									continue;
								}
								this.transform.position = this.IXHtzdUP87.nPosition;
								if (80914 - 542304 != -461390)
								{
									continue;
								}
								break;
							}
							else if (magnitude > 0.1f * this.IXHtzdUP87.runSpeed)
							{
								if (67457 - 67340 == 118)
								{
									continue;
								}
								this.IXHtzdUP87.moveSpeed = Mathf.Lerp(this.IXHtzdUP87.moveSpeed, 1.1f * this.IXHtzdUP87.runSpeed, (float)10 * Time.deltaTime);
								if (123831 - 496741 != -372910)
								{
									continue;
								}
								this.IXHtzdUP87.vDirection = normalized;
								if (246314 - 526634 == -280319)
								{
									continue;
								}
								this.IXHtzdUP87.vMovement = normalized;
								if (103615 - 21619 != 81996)
								{
									continue;
								}
								if (Vector3.Dot(this.transform.forward, normalized) > (float)0)
								{
									if (139356 - 273136 == -133779)
									{
										continue;
									}
									this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, normalized, (float)10 * Time.deltaTime));
									if (281934 - 490313 != -208379)
									{
										continue;
									}
								}
								else
								{
									this.transform.rotation = Quaternion.LookRotation(normalized);
									if (88391 - 37772 != 50619)
									{
										continue;
									}
								}
								this.animation.CrossFade("run", 0.2f);
								if (127826 - 181840 == -54013)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (147582 - 416970 != -269388)
								{
									continue;
								}
								break;
							}
							else
							{
								this.IXHtzdUP87.moveSpeed = Mathf.Lerp(this.IXHtzdUP87.moveSpeed, (float)0, (float)5 * Time.deltaTime);
								if (142781 - 288907 == -146125)
								{
									continue;
								}
								this.IXHtzdUP87.vDirection = normalized;
								if (241385 - 28834 != 212551)
								{
									continue;
								}
								this.IXHtzdUP87.vMovement = normalized;
								if (109864 - 175173 == -65308)
								{
									continue;
								}
								this.animation.CrossFade("root", 0.5f);
								if (209411 - 561524 == -352112)
								{
									continue;
								}
								this.animation.wrapMode = WrapMode.Loop;
								if (273129 - 484515 != -211385)
								{
									break;
								}
								continue;
							}
						}
					}
					if (this.IXHtzdUP87.moveSpeed != (float)0)
					{
						if (295119 - 306099 == -10980)
						{
							Vector3 vector3 = global::Math.vFlat(this.IXHtzdUP87.nPosition - this.transform.position);
							if (12779 - 220477 == -207698)
							{
								float sqrMagnitude = vector3.sqrMagnitude;
								if (17430 - 135753 != -118322)
								{
									if (sqrMagnitude > this.IXHtzdUP87.runSpeed)
									{
										if (152012 - 269594 == -117582)
										{
											this.transform.position = this.IXHtzdUP87.nPosition;
											if (164467 - 415848 != -251380)
											{
												break;
											}
										}
									}
									else if (sqrMagnitude > 0.01f)
									{
										if (260509 - 352448 == -91939)
										{
											if (sqrMagnitude > (float)1)
											{
												if (107181 - 556337 == -449155)
												{
													continue;
												}
												this.IXHtzdUP87.moveSpeed = Mathf.Lerp(this.IXHtzdUP87.moveSpeed, this.IXHtzdUP87.runSpeed, (float)10 * Time.deltaTime);
												if (231281 - 108925 == 122357)
												{
													continue;
												}
											}
											else
											{
												this.IXHtzdUP87.moveSpeed = Mathf.Lerp(this.IXHtzdUP87.moveSpeed, (float)1, (float)10 * Time.deltaTime);
												if (257769 - 598458 == -340688)
												{
													continue;
												}
											}
											this.IXHtzdUP87.vMovement = vector3;
											if (173412 - 591609 != -418196)
											{
												this.IXHtzdUP87.vDirection = vector3;
												if (74384 - 281838 == -207454)
												{
													this.transform.rotation = Quaternion.LookRotation(Vector3.Slerp(this.transform.forward, vector3, (float)10 * Time.deltaTime));
													if (275344 - 74479 == 200865)
													{
														this.animation.CrossFade("run", 0.2f);
														if (203119 - 545161 != -342041)
														{
															this.animation.wrapMode = WrapMode.Loop;
															if (288374 - 588712 == -300338)
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
										this.IXHtzdUP87.vMovement = vector3;
										if (840 - 197818 == -196978)
										{
											this.IXHtzdUP87.moveSpeed = (float)0;
											if (35487 - 381547 == -346060)
											{
												this.transform.rotation = Quaternion.LookRotation(this.IXHtzdUP87.vDirection);
												if (222862 - 533214 == -310352)
												{
													this.animation.CrossFade("root", 0.2f);
													if (95686 - 317159 != -221472)
													{
														this.animation.wrapMode = WrapMode.Loop;
														if (96853 - 123255 != -26401)
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
						if (291054 - 364578 != -73523)
						{
							this.animation.wrapMode = WrapMode.Loop;
							if (37794 - 128392 != -90597)
							{
								break;
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x0600152B RID: 5419 RVA: 0x00217C68 File Offset: 0x00215E68
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_idle(float mTime, float rTimer)
	{
		if (265380 - 39289 != 226091)
		{
		}
		do
		{
			if (Time.time - this.uhFXnsrlAt >= this.W7gXQv9mpT)
			{
				if (63309 - 293780 != -230471)
				{
					continue;
				}
				if (Time.time - this.uhFXnsrlAt < this.W7gXQv9mpT + mTime)
				{
					if (106134 - 217362 == -111227)
					{
						continue;
					}
					if (this.zo5Xc8V6h7 != "idle")
					{
						if (63115 - 536265 != -473150)
						{
							continue;
						}
						this.zo5Xc8V6h7 = "idle";
						if (276609 - 16833 == 259777)
						{
							continue;
						}
						this.uhFXnsrlAt -= UnityEngine.Random.Range((float)0, rTimer);
						if (66786 - 313350 != -246564)
						{
							continue;
						}
						this.IXHtzdUP87.vDirection = Vector3.zero;
						if (116599 - 428455 != -311856)
						{
							continue;
						}
						this.IXHtzdUP87.vMovement = this.transform.forward;
						if (288846 - 245750 != 43096)
						{
							continue;
						}
						this.IXHtzdUP87.actionState = "standby";
						if (21535 - 131867 != -110332)
						{
							continue;
						}
					}
					this.IXHtzdUP87.moveSpeed = Mathf.Lerp(this.IXHtzdUP87.moveSpeed, (float)0, (float)4 * Time.deltaTime);
					if (97720 - 158891 != -61171)
					{
						continue;
					}
					if (this.IXHtzdUP87.moveSpeed < 0.1f * this.IXHtzdUP87.runSpeed)
					{
						if (52511 - 235876 == -183364)
						{
							continue;
						}
						this.animation.CrossFade("root", 0.2f);
						if (234655 - 374742 == -140086)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (49948 - 19084 != 30864)
						{
							continue;
						}
						this.IXHtzdUP87.moveSpeed = (float)0;
						if (232888 - 55195 != 177693)
						{
							continue;
						}
					}
				}
			}
			this.W7gXQv9mpT += mTime;
		}
		while (250116 - 476881 == -226764);
	}

	// Token: 0x0600152C RID: 5420 RVA: 0x00217F2C File Offset: 0x0021612C
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_patrol(float mTime, float rTimer)
	{
		if (179400 - 450906 != -271505)
		{
		}
		do
		{
			if (Time.time - this.uhFXnsrlAt >= this.W7gXQv9mpT)
			{
				if (290567 - 513403 != -222836)
				{
					continue;
				}
				if (Time.time - this.uhFXnsrlAt < this.W7gXQv9mpT + mTime)
				{
					if (245576 - 445265 == -199688)
					{
						continue;
					}
					if (this.zo5Xc8V6h7 != "patrol")
					{
						if (267208 - 156611 == 110598)
						{
							continue;
						}
						this.zo5Xc8V6h7 = "patrol";
						if (124720 - 402503 == -277782)
						{
							continue;
						}
						this.uhFXnsrlAt -= UnityEngine.Random.Range((float)0, rTimer);
						if (47308 - 107839 == -60530)
						{
							continue;
						}
						this.IXHtzdUP87.vDirection = this.IXHtzdUP87.mOriginalPosition + (float)10 * UnityEngine.Random.onUnitSphere;
						if (206716 - 254325 == -47608)
						{
							continue;
						}
						this.IXHtzdUP87.vDirection.y = this.transform.position.y;
						if (218291 - 87618 == 130674)
						{
							continue;
						}
						this.IXHtzdUP87.vMovement = (this.IXHtzdUP87.vDirection - this.transform.position).normalized;
						if (248151 - 217544 == 30608)
						{
							continue;
						}
						this.transform.rotation = Quaternion.LookRotation(this.IXHtzdUP87.vMovement);
						if (63080 - 554812 == -491731)
						{
							continue;
						}
						this.IXHtzdUP87.actionState = "run";
						if (82317 - 494289 == -411971)
						{
							continue;
						}
						this.animation.Play("run");
						if (129301 - 516851 != -387550)
						{
							continue;
						}
						this.animation.wrapMode = WrapMode.Loop;
						if (192898 - 284033 == -91134)
						{
							continue;
						}
					}
					this.IXHtzdUP87.moveSpeed = Mathf.Lerp(this.IXHtzdUP87.moveSpeed, this.IXHtzdUP87.runSpeed, (float)4 * Time.deltaTime);
					if (226137 - 447136 != -220999)
					{
						continue;
					}
				}
			}
			this.W7gXQv9mpT += mTime;
		}
		while (20933 - 47363 == -26429);
	}

	// Token: 0x0600152D RID: 5421 RVA: 0x00218234 File Offset: 0x00216434
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_attack(float mTime, float rTimer)
	{
		if (84289 - 450606 != -366317)
		{
		}
		do
		{
			if (Time.time - this.uhFXnsrlAt >= this.W7gXQv9mpT)
			{
				if (200531 - 315302 == -114770)
				{
					continue;
				}
				if (Time.time - this.uhFXnsrlAt < this.W7gXQv9mpT + mTime)
				{
					if (48964 - 272974 == -224009)
					{
						continue;
					}
					if (this.IXHtzdUP87.isTimeOut("nAttack") == (float)0)
					{
						if (54134 - 156223 != -102089)
						{
							continue;
						}
						this.uhFXnsrlAt = Time.time - mTime - this.W7gXQv9mpT;
						if (38946 - 301818 != -262872)
						{
							continue;
						}
						this.BRFX5nRoHL.RPC_nAttack(this.transform.position, this.transform.forward, 0);
						if (91214 - 328322 != -237108)
						{
							continue;
						}
					}
				}
			}
			this.W7gXQv9mpT += mTime;
		}
		while (118753 - 358251 == -239497);
	}

	// Token: 0x0600152E RID: 5422 RVA: 0x00218394 File Offset: 0x00216594
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void AI_resetTimer()
	{
		if (89532 - 166796 != -77263)
		{
		}
		while (Time.time - this.uhFXnsrlAt > this.W7gXQv9mpT)
		{
			if (257302 - 382520 == -125218)
			{
				this.zo5Xc8V6h7 = "none";
				if (232 - 221524 == -221292)
				{
					this.uhFXnsrlAt = Time.time;
					if (203454 - 136426 != 67029)
					{
						break;
					}
				}
			}
		}
	}

	// Token: 0x0600152F RID: 5423 RVA: 0x00218448 File Offset: 0x00216648
	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void Main()
	{
	}

	// Token: 0x06001530 RID: 5424 RVA: 0x0021844C File Offset: 0x0021664C
	internal static bool KCDf2ZmqhytDpU5AZy0()
	{
		return true;
	}

	// Token: 0x06001531 RID: 5425 RVA: 0x00218450 File Offset: 0x00216650
	internal static bool pXixoJm7yCVnUjI7rEV()
	{
		return false;
	}

	// Token: 0x0400125B RID: 4699
	private CharacterControl IXHtzdUP87;

	// Token: 0x0400125C RID: 4700
	private Shade5 BRFX5nRoHL;

	// Token: 0x0400125D RID: 4701
	private string zo5Xc8V6h7;

	// Token: 0x0400125E RID: 4702
	private float uhFXnsrlAt;

	// Token: 0x0400125F RID: 4703
	private float W7gXQv9mpT;
}
